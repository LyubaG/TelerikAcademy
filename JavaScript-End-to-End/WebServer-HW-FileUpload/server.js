(function () {
	'use strict';

	var http = require('http'),
		url = require('url'),
		fs = require('fs'),
		formidable = require('formidable'),
		util = require('util'),
		filestore = require('fs-extra'),
		uuid = require('node-uuid'),
		port = 1111,
		uploadDirectory = __dirname + '/FileUploads/';

	http.createServer(function (req, res) {
		var parsedUrl = url.parse(req.url),
			queryData = url.parse(req.url, true).query;

		if (req.method.toLowerCase() === 'get') {
			switch (parsedUrl.path) {
				case '/':
					getPage(res, 'index.html', 'text/html');
					break;
				case '/upload':
					getPage(res, 'upload.html', 'text/html');
					break;
				case '/success':
					getPage(res, 'success.html');
					break;
				default:
					send404Response(res);
					break;
			}
		}

		// file download
		if (queryData.id) {
			var dir = uploadDirectory + queryData.id + '/';

			try {
				if (filestore.statSync(dir)) {
					var files = filestore.readdirSync(dir),
						file;

					for (var i in files) {
						file = files[i];
						break;
					}

					res.writeHead(200, {
						'Content-disposition': 'attachment; filename=' + file,
						'content-type': 'text/html'
					});
					res.write(file, 'binary');
					res.end();
				}
			} catch (e) {
				console.error('No such file exists');
			}
		}

		if (req.method.toLowerCase() === 'post') {
			var form = new formidable.IncomingForm();
			var guid = uuid.v1();

			if (!fs.existsSync(uploadDirectory)) {
				fs.mkdirSync(uploadDirectory);
			}

			// this creates weird temp files!!!
			//form.uploadDir = uploadDirectory;

			form.parse(req, function (err, fields, files) {
				res.writeHead(200, {'content-type': 'text/html'});
				// TODO fs.createReadStream('success.html').pipe(res);
				res.write('<div><h4 style="display: inline; margin-right: 5px">Success! Upload identifier: </h4>' +
					'<h3 style="display: inline">' + guid + '</h3></div>');
				res.end('<a href="/">Go back home</a>');
			});

			form.on('end', function (fields, files) {
				var tempPath = this.openedFiles[0].path;
				var fileName = this.openedFiles[0].name;
				var newPath = uploadDirectory + '/' + guid + '/';

				filestore.copy(tempPath, newPath + fileName, function (err) {
					if (err) {
						console.error(err);
					} else {
						console.log('File Uploaded');
					}
				});
			});

			return;
		}
	}).listen(port);
	console.log('Server running on port ' + port);

	function send404Response(response) {
		response.writeHead(404, {"Content-Type": "text/plain"});
		response.write("Error 404 - The teapot couldn\'t find what you\'re looking for...");
		response.end();
	}


	function getPage(response, filepath, contentType) {
		fs.createReadStream(filepath).pipe(response);
		/*fs.readFile(filepath, function (error, content) {
		 if (content) {
		 response.writeHead(200, {
		 'Content-Type': contentType}),
		 'Server': 'NodeJS at Home';
		 response.end(content);
		 }
		 else {
		 response.writeHead(500, {'Content-Type': contentType});
		 response.write('The server is down for some time. Sorry.');
		 response.end();
		 }
		 });*/
	}
}());