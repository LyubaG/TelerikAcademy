var mongoose = require('mongoose');

var requiredMessage = '{PATH} is required';

module.exports.init = function() {
    var playlistSchema = mongoose.Schema({
        title: { type: String, required: requiredMessage },
        description: { type: String, required: requiredMessage },
        category: { type: String, required: requiredMessage },
	    videos: {
		    type: [String] },
        /*type: {
            initiative: { type: String, required: requiredMessage },
            season: { type: String, required: requiredMessage },
        },*/
        creationDate: { type: Date, required: requiredMessage },
        creator: { type: String, required: requiredMessage },
	    privacy: String,
	    rating: {type: Number, required: requiredMessage},
        comments: [{
            username: String,
            content: String
        }]
    });

    var Playlist = mongoose.model('Playlist', playlistSchema);
};



