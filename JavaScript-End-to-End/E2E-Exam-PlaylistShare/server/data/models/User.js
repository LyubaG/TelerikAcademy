var mongoose = require('mongoose'),
    encryption = require('../../utilities/encryption');

var requiredMessage = '{PATH} is required';
var defaultAvatar = '../../../public/img/avatar-def.png'; // TODO display properly

module.exports.init = function() {
    var userSchema = mongoose.Schema({
        username: { type: String,
	                validate: {
						validator: function (val) {
							return val.match(/^[a-z0-9_.]{6,20}$/);
						},
		                message: 'Username must be between 6 and 20 characters long and only contain latin' +
		                ' letters, digits, underscore or dot characters.'
	                },
	                required: requiredMessage,
	                unique: true },
        salt: String,
        hashPass: String,
        firstName: { type: String, required: requiredMessage},
        lastName: { type: String, required: requiredMessage},
        email: { type: String,
		        validate: {
			        validator: function (val) {
				        return val.match(/^[a-z0-9._%+-]+@(?:[a-z0-9-]+\.)+[a-z]{2,}$/);
			        },
			        message: 'What you entered is not a valid e-mail address...'
		        },
	            required: requiredMessage},
	    rating: {type: Number}, // TODO rating iaw playlists & , required: requiredMessage
        image: { type: String, default: defaultAvatar }, // TODO maybe image upload....,
	    facebook: String,
	    youtube: String
    });

    userSchema.method({
        authenticate: function(password) {
            if (encryption.generateHashedPassword(this.salt, password) === this.hashPass) {
                return true;
            }
            else {
                return false;
            }
        }
    });

    var User = mongoose.model('User', userSchema);

	var seedInitialUsers = function () {
		User.find({}).exec(function (err, collection) {
			if (err) {
				console.log('Cannot find users: ' + err);
				return;
			}

			if (collection.length === 0) {
				var salt;
				var hashedPwd;

				salt = encryption.generateSalt();
				hashedPwd = encryption.generateHashedPassword(salt, 'Ivaylo');
				User.create({
					username: 'baba-meca',
					firstName: 'Baba',
					lastName: 'Meca',
					salt: salt,
					hashPass: hashedPwd,
					email: 'meca@baba.com',
				});
				salt = encryption.generateSalt();
				hashedPwd = encryption.generateHashedPassword(salt, 'Nikolay');
				User.create({
					username: 'kuma-lisa',
					firstName: 'kuma',
					lastName: 'lisa',
					salt: salt,
					hashPass: hashedPwd,
					email: 'kuma@lisa.com',
				});
				salt = encryption.generateSalt();
				hashedPwd = encryption.generateHashedPassword(salt, 'Doncho');
				User.create({
					username: 'kumchovulcho',
					firstName: 'kum',
					lastName: 'chovulcho',
					salt: salt,
					hashPass: hashedPwd,
					email: 'kumcho@baba.com',
				});
				console.log('Initial users added to database...');
			}
		});
	};
	seedInitialUsers();
};


