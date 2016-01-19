var User = require('mongoose').model('User');

module.exports = {
    create: function(user, callback) {
        User.create(user, callback);
    },
	update: function (user, callback) {
		User.updateUser(user, callback);
	}
};