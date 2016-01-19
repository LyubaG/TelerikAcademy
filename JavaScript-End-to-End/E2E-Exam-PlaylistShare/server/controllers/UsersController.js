var encryption = require('../utilities/encryption');
var users = require('../data/users');
var User = require('mongoose').model('User');

var CONTROLLER_NAME = 'users';

module.exports = {
	getRegister: function (req, res, next) {
		res.render(CONTROLLER_NAME + '/register')
	},
	postRegister: function (req, res, next) {
		var newUserData = req.body;

		if (newUserData.password != newUserData.confirmPassword) {
			req.session.error = 'Passwords do not match!';
			res.redirect('/register');
		}
		else {
			newUserData.salt = encryption.generateSalt();
			newUserData.hashPass = encryption.generateHashedPassword(newUserData.salt, newUserData.password);
			users.create(newUserData, function (err, user) {
				if (err) {
					req.session.error = 'Failed to register user: ' + err;
					console.log('Failed to register user: ' + err);
					res.redirect('/register');
					return;
				}

				req.logIn(user, function (err) {
					if (err) {
						res.status(400);
						return res.send({reason: err.toString()}); // TODO: ?
					}
					else {
						res.redirect('/');
					}
				});
			});
		}
	},
	getLogin: function (req, res, next) {
		res.render(CONTROLLER_NAME + '/login');
	},
	getUpdate: function (req, res, next) {
		res.render(CONTROLLER_NAME + '/profile');
	},
	updateUser: function (req, res, next) {
		var updatedUserData = req.user;
		if (updatedUserData.password) {
			updatedUserData.salt = encryption.generateSalt();
			updatedUserData.hashPass = encryption.generateHashedPassword(updatedUserData.salt, updatedUserData.password);
		}

		User.update({_id: updatedUserData._id}, updatedUserData, function () {
			res.redirect('/');
		});
	}

};