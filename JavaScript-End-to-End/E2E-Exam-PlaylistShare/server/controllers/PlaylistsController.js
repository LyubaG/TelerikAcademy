var playlists = require('../data/playlists'),
	constants = require('../common/constants');
var Playlist = require('mongoose').model('Playlist');

var CONTROLLER_NAME = 'playlists';

var topLists = [];

module.exports = {
	getCreate: function (req, res) {
		/*        if (!req.user.phoneNumber) {
		 // req.session.error = 'Sorry...';
		 // res.render(CONTROLLER_NAME + '/users/profile'); // TODO:
		 }*/

		res.render(CONTROLLER_NAME + '/create', {
			categories: constants.categories,
			privacy: constants.privacy
		});
	},
	postCreate: function (req, res) {
		var playlist = req.body;
		var user = req.user;
		playlists.create(
			playlist,
			{
				username: user.username,
				//eNumber: user.phoneNumber
			},
			function (err, playlist) {
				if (err) {
					var data = {
						categories: constants.categories,
						privacy: constants.privacy,
						errorMessage: err
					};
					res.render(CONTROLLER_NAME + '/create', data);
				}
				else {
					res.redirect('/playlists/details/' + playlist._id);
				}
			});
	},
	getActive: function (req, res) {
		var page = req.query.page;
		var pageSize = req.query.pageSize;

		// TODO: get user initatives and season + 'Public' + 'None'

		playlists.active(page, pageSize, ['Public'], function (err, data) {
			res.render(CONTROLLER_NAME + '/active', {
				data: data
			});
		});
	},
	getPopular: function (req, res) {

		playlists.popular('Public', function (err, data) {
			res.render(CONTROLLER_NAME + '/popular', {
				data: data
			});
		});
	},
	getById: function (req, res) {
		var id = req.params._id;

		Playlist.findById(id, function (err, playlist) {
			if (err) {
				throw err;
			}

			if (!playlist) {
				res.redirect('not-found');
				return;
			}

			res.render(CONTROLLER_NAME + '/details/', {
				data: playlist
			});
		});
	}
	,
};