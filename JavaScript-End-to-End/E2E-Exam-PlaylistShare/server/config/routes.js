var auth = require('./auth'),
    controllers = require('../controllers');

module.exports = function(app) {
    app.get('/register', controllers.users.getRegister);
    app.post('/register', controllers.users.postRegister);

    app.get('/login', controllers.users.getLogin);
    app.post('/login', auth.login);
    app.get('/logout', auth.logout);

	app.post('/profile', auth.isAuthenticated, controllers.users.updateUser);
	app.get('/profile', auth.isAuthenticated, controllers.users.getUpdate);

    app.get('/playlists/create', auth.isAuthenticated, controllers.playlists.getCreate);
    app.post('/playlists/create', auth.isAuthenticated, controllers.playlists.postCreate);

	app.get('/playlists/popular', controllers.playlists.getPopular);
    app.get('/playlists/active', auth.isAuthenticated, controllers.playlists.getActive);

	//app.get('/playlists/details', controllers.playlists.getById);
	app.get('/playlists/details', function (req, res) {
		res.render('playlists/details');
	});


    app.get('/', function(req, res) {
        res.render('index');
    });

    app.get('*', function(req, res) {
        res.render('index');
    });
};