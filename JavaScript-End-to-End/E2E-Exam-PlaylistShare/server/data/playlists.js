var Playlist = require('mongoose').model('Playlist'),
	constants = require('../common/constants');

var cache = {
	expires: undefined,
	data: undefined
};

module.exports = {
	create: function (playlist, user, callback) {
		if (constants.categories.indexOf(playlist.category) < 0
			|| constants.privacy.indexOf(playlist.privacy) < 0) {
			callback('Invalid category or privacy value');
			return;
		}
		else {
			privacy: playlist.privacy;
			category: playlist.category
		}

		playlist.creator = user.username;
		playlist.creationDate = new Date();
		playlist.rating = 0;

		Playlist.create(playlist, callback);
	},
	active: function (page, pageSize, privacy, callback) {
		page = page || 1;
		pageSize = pageSize || 10;

		Playlist
			.find()//TODO specify a bit.....
			.sort({
				creationDate: 'desc'
			})
			.limit(pageSize)
			.skip((page - 1) * pageSize)
			.exec(function (err, foundPlaylists) {
				if (err) {
					callback(err);
					return;
				}

				Playlist.count().exec(function (err, numberOfPlaylists) {
					var data = {
						playlists: foundPlaylists,
						currentPage: page,
						pageSize: pageSize,
						total: numberOfPlaylists
					};

					callback(err, data);
				});
			});
	},
	popular: function (privacy, callback) {

		if (cache.expires && cache.expires < new Date()) {
			callback(null, cache.data);
			return;
		}

		Playlist
			.find({privacy: 'Public'})
			.sort({
				creationDate: 'desc'
			})
			.limit(8)
			.exec(function (err, foundPlaylists) {
				if (err) {
					callback(err);
					return;
				}

				Playlist.count().exec(function (err, numberOfPlaylists) {
					var data = {
						playlists: foundPlaylists,
						total: numberOfPlaylists
					};
					console.log(data);

					callback(err, data);

					cache.data = data;
					cache.expires = new Date() + 10;
				});
			});
	}/*,

	findById: function (id, callback) {
		Playlist
			.find({_id: id})
			.exec(function (err, foundPlaylists) {
				if (err) {
					callback(err);
					return;
				}

				Playlist.count().exec(function (err, numberOfPlaylists) {
					var data = {
						playlists: foundPlaylists,
						total: numberOfPlaylists
					};
					console.log('whoa!' + data);

					callback(err, data);
				});
			});
	}*/
};