function solve() {
	//'use strict';
	if (!Array.prototype.findIndex) {
		Array.prototype.findIndex = function (predicate) {
			if (this == null) {
				throw new TypeError('Array.prototype.findIndex called on null or undefined');
			}
			if (typeof predicate !== 'function') {
				throw new TypeError('predicate must be a function');
			}
			var list = Object(this);
			var length = list.length >>> 0;
			var thisArg = arguments[1];
			var value;

			for (var i = 0; i < length; i++) {
				value = list[i];
				if (predicate.call(thisArg, value, i, list)) {
					return i;
				}
			}
			return -1;
		};
	}

	tfObjSort = {
		init: function () {
			Array.prototype.objSort = function () {
				tfObjSort.setThings(this);
				var a = arguments;
				var x = tfObjSort;
				x.a = [];
				x.d = [];
				for (var i = 0; i < a.length; i++) {
					if (typeof a[i] == "string") {
						x.a.push(a[i]);
						x.d.push(1)
					}
					;
					if (a[i] === -1) {
						x.d[x.d.length - 1] = -1
					}
				}
				return this.sort(tfObjSort.sorter);
			};
			Array.prototype.strSort = function () {
				tfObjSort.setThings(this);
				return this.sort(tfObjSort.charSorter)
			}
		},
		sorter: function (x, y) {
			var a = tfObjSort.a
			var d = tfObjSort.d
			var r = 0
			for (var i = 0; i < a.length; i++) {
				if (typeof x + typeof y != "objectobject") {
					return typeof x == "object" ? -1 : 1
				}
				;
				var m = x[a[i]];
				var n = y[a[i]];
				var t = typeof m + typeof n;
				if (t == "booleanboolean") {
					m *= -1;
					n *= -1
				}
				else if (t.split("string").join("").split("number").join("") != "") {
					continue
				}
				;
				r = m - n;
				if (isNaN(r)) {
					r = tfObjSort.charSorter(m, n)
				}
				;
				if (r != 0) {
					return r * d[i]
				}
			}
			return r
		},
		charSorter: function (x, y) {
			if (tfObjSort.ignoreCase) {
				x = x.toLowerCase();
				y = y.toLowerCase()
			}
			;
			var s = tfObjSort.chars;
			if (!s) {
				return x > y ? 1 : x < y ? -1 : 0
			}
			;
			x = x.split("");
			y = y.split("");
			l = x.length > y.length ? y.length : x.length;
			var p = 0;
			for (var i = 0; i < l; i++) {
				p = s.indexOf(x[i]) - s.indexOf(y[i]);
				if (p != 0) {
					break
				}
				;
			}
			;
			if (p == 0) {
				p = x.length - y.length
			}
			;
			return p
		},
		setThings: function (x) {
			this.ignoreCase = x.sortIgnoreCase;
			var s = x.sortCharOrder;
			if (!s) {
				this.chars = false;
				return true
			}
			;
			if (!s.sort) {
				s = s.split(",")
			}
			;
			var a = "";
			for (var i = 1; i < 1024; i++) {
				a += String.fromCharCode(i)
			}
			;
			for (var i = 0; i < s.length; i++) {
				z = s[i].split("");
				var m = z[0];
				var n = z[1];
				var o = "";
				if (z[2] == "_") {
					o = n + m
				} else {
					o = m + n
				}
				;
				a = a.split(m).join("").split(n).join(o);
			}
			;
			this.chars = a
		}
	};
	tfObjSort.init();


	// hiden funcs:
	// for name, author, title
	function isValidString(param) {
		if (typeof (param) !== 'string') {
			return false;
		}
		return param.length >= 3 && param.length <= 25;
	};
	// for id? TODO put somewhere
	function isValidId(param) {
		return !isNaN(param) && param > 0;
	};

	// TODO playable interface make more hidden???
	var playable = function(){
		var id = 0;

		//function GenerateId() {
		//	return ++id;
		//}

		var playable = {
			init: function (title, author) {
				this.title = title;
				this.author = author;
				this.id = id +=1;// += has higher priority as operator....
				return this;
			},
// IVO on hiding the ID with defineProperty _id :) --> https://youtu.be/_qDJgAeEkoo?t=765
			//get and set only on newer browsers, defineProperty is better....node.js likes it though
			get title() {
				return this._title;
			},
			set title(val) {
				if (!isValidString(val)) {
					throw new Error('invalid title');
				}
				this._title = val;
			},
			get author() {
				return this._author;
			},
			set author(val) {
				if (!isValidString(val)) {
					throw new Error('invalid author');
				}
				this._author = val;
			},
			play: function() {
				return this.id + '. ' + this.title + ' - ' + this.author;
			}
		};

		return playable;
	}();

	var audio = function (parent) {
		// https://youtu.be/O_M5bsCJjOM?t=3030 TODO without defineProps?
		var audio = Object.create(parent); // makes sure our props go through get and set of parent
		audio.init = function (title, author, length) {
			parent.init.call(this, title, author);
			this.length = length;
			return this;
		};
		// !!! we can't use get and set because to use them, we have to use them with an object initialization;
		// and her we initialize with Object.create, where we can't add any other get and set; the object is
		// already created so we can't validate through get and set anymore
		Object.defineProperty(audio, 'length', {
			get: function(){
				return this._length;
			},
			set: function(val) {
				val = +val; //TODO remember to convert values!
				if (isNaN(val) || val <= 0) {    //TODO careful: null is not NaN....(try with typeof then)
					throw new Error('invalid length');
				} // OR typeof(val) !== 'number'
				this._length = val;
			}
		});

		/*var audio = Object.defineProperties(parent, {
		 init: {
		 value: function (title, author, length) {
		 parent.init.call(this, title, author);
		 this.length = length;
		 return this;
		 }
		 },
		 get length() {
		 return this._length;
		 },
		 set length(val) {
		 if (val <= 0) {
		 throw new Error('invalid length');
		 }
		 this._length = val;
		 }
		 });*/
		audio.play = function () {
			var baseResult = parent.play.call(this);
			return baseResult + ' - ' + this.length;
		}

		return audio;
	}(playable);

	var video = function (parent) {
		var video = Object.create(parent);
		video.init = function (title, author, imdbRating) {
			parent.init.call(this, title, author);
			this.imdbRating = imdbRating;
			return this;
		};
		Object.defineProperty(video, 'imdbRating', {
			get: function () {
				return this._imdbRating;
			},
			set: function (val) {
				if (typeof(val) !== 'number' || val <1 || val > 5) {
					throw new Error('invalid imdbRating');
				} // OR typeof(val) !== 'number'
				this._imdbRating = val;
			}
		});

		video.play = function () {
			var baseResult = parent.play.call(this);
			return baseResult + ' - ' + this.imdbRating;
		}

		return video;
	}(playable);

	var player = function () {
		var id = 0; // WTF tests...not according to task..

		function byNameThenById(pl1, pl2) {
			if (pl1.name === pl2.name) {
				return pl1.id - pl2.id;
			}
			return pl1.name.localeCompare(pl2.name);
		}

		var player = {
			init: function (name) {
				this.name = name;
				this.id = id+=1;
				this.playlists = [];
				return this;
			},
			get name() {
				return this._name;
			},
			set name(val) {
				if (!isValidString(val)) {
					throw new Error('invalid name');
				}
				this._name = val;
			},
			addPlaylist: function (playlistToAdd) {
				if (typeof (playlistToAdd.id) === 'undefined'
				|| !playlistToAdd.name) {        // Wrong way (it's classic inheritance): playlistToAdd instanceof
				// playlist
					throw new Error('not instance of playlist');
				}
				this.playlists.push(playlistToAdd);
				return this;
			},
			getPlaylistById: function (id) {
				var i,
					len = this.playlists.length;
				for (i = 0; i < len; i += 1) {
					if (this.playlists[i].id === id) {
						return this.playlists[i];
					}
				}
				return null;
			},
			removePlaylist: function (idORplaylist) {
				if (typeof (idORplaylist) === 'undefined') {
					throw new Error('invalid idORplaylist')
				};
				if (typeof (idORplaylist) !== 'number') {
					id = idORplaylist.id;
				}
				var index = this.playlists.findIndex(function (playable) {
					return playable.id === idORplaylist;
				});
				if (index < 0) {
					throw new Error('invalid id')
				};
				this.playlists.splice(index, 1);
				return this;
/*				if (idORplaylist instanceof Object) {
					if (this.playlists.indexOf(idORplaylist) < 0) {
						throw new Error('wrong playlist');
					}
					delete this.playlists[this.playlists.indexOf(idORplaylist)];
				}
				else 		// it's the id'
				if (!this.playlists[idORplaylist]) {
					throw new Error('no such id');
				}
				delete this.playlists[idORplaylist];*/
			},
			listPlaylists: function (page, size) {
				//this.playlists = this.playlists.objSort('name', 'id');
				if (typeof(page) === 'undefined'
					|| typeof(size) === 'undefined' ||
					page < 0 || size <= 0 || this.playlists.length < page * size) {
					throw new Error('page*size bigger than playlist count OR ETC');
				}
				this.playlists.sort(byNameThenById);
				if (this.playlists.length < size) {
					return this.playlists;
				} // not needed coz slice would not return empty elements
				else return this.playlists.slice(page * size, (page + 1) * size);
			},
			contains: function (playable, playlist) {
				var list = this.playlists[this.playlists.indexOf(playlist)];
				return list.indexOf(playable) > -1;
			},
			search: function (pattern) {
				pattern = pattern.toLocaleLowerCase();
				return this.playlists.filter(function(playlists){
					return playlist.getAllPlayables()
						.some(function(playable){
							return playable.title.toLocaleLowerCase()
								.indexOf(pattern)>= 0;
						});
				}); // if empty, filter returns an empty array...

/*				var resultArr = [];
				var regex = /pattern/gi;
				for (var list in this.playlists) {
					for (var song in list) {
						if (regex.test(song)) {
							resultArr.push(list.toString()); // TODO return only name and id
						}
					}
				}
				return resultArr;*/
			}
		};

		return player;
	}();

	var playlist = function () {
		var lastId = 0;

		var playlist = {
			init: function (name) {
				this.name = name;
				this.id = lastId += 1;
				this.list = [];
				return this;
			},
			get name() {
				return this._name;
			},
			set name(val) {
				if (!isValidString(val)) {
					throw new Error('invalid name');
				}
				this._name = val;
			},
			addPlayable: function(playable) {
				if(typeof(playable.id) === 'undefined' ){  // WRONG TO ADD: || !playable.title // check
				// typeof 'object'
					throw { name: 'invalid playable', message: 'whaaa'};
				} // not obligatory but checks instanceof in aprototypal inheritance..
				this.list.push(playable);
				return this; // TODO remember to return this to enable chaining
			},
			getPlayableById: function(id) {
				var i,
					len = this.list.length;
				for(i = 0; i < len; i+= 1){
					if (this.list[i] === 'undefined') {
						return null;
					}
					else if (this.list[i].id === id) {
						return this.list[i];
					}
				}
				return null;
				// only this is not enough:  return this.list[id];
			},
			removePlayable: function(idORplayable) {
/*				if(typeof (idORplayable) === 'undefined') {
					throw new Error('invalid idORplayable')
				};
				if(typeof (idORplayable) !== 'number'){
					id = idORplayable.id; //i.e. the id is the id of the playable
				}
				//use MDN polyfill for arra.findIndex to find the element
				var index = this.list.findIndex(function(playable){
					return playable.id === idORplayable;
				});
				if(index < 0) {
					throw new Error('invalid id')
				};
				this.list.splice(index, 1);*/
							//my way - check :)
				if (idORplayable instanceof Object) {
					if (this.list.indexOf(idORplayable) < 0) {
						throw new Error('wrong playable');
					}
					delete this.list[this.list.indexOf(idORplayable)];
				}
				else if (!this.list[idORplayable]) {
					throw new Error('no such playable id');
				}
				delete this.list[idORplayable];
				return this; // chaining....
			},

			listPlayables: function(page, size) {
				this.list.sort(function(pl1, pl2) {
					if(pl1.title === pl2.title) {
						return pl1.id - pl2.id;
					}
					return pl1.title.localeCompare(pl2.title); // lexic. comparison
				});
				//TODO check my way :) :::
				// this.list = this.list.objSort('title', 'id');
				if (typeof(page) === 'undefined'
				|| typeof(size) === 'undefined' ||
					page < 0 || size <= 0 || this.list.length < page * size) {
                throw new Error('page*size bigger than playlist count OR ETC');
				}
				if (this.list.length < size) {
					return this.list;
				} // not needed coz slice would not return empty elements
				else return this.list.slice(page * size, (page + 1) * size); // from index to index
			},
			// for our player search func, to make it public:
			getAllPlayables: function (){
				return this.list.slice();
			},
			toString: function () {
				return '{name: "' + this.name + '", id: ' + this.id + '}'; // TODO fix this damn hack...
			}
		};

		return playlist;
	}();

	var module = {
		getPlayer: function (name) {
			return Object.create(player).init(name);
		},

		getPlaylist: function (name) {
			return Object.create(playlist).init(name);
		},

		getAudio: function (title, author, length) {
			return Object.create(audio).init(title, author, length);
		},

		getVideo: function (title, author, imdbRating) {
			return Object.create(video).init(title, author, imdbRating);
		}
	};

	return module;
}

module.exports = solve;

/*
//TEST:
var module = solve();
console.log(module.getAudio('Bitch', 'Madonna', 4.5).play());
// check errors:
// console.log(module.getAudio('Bitch').play());
// console.log(module.getAudio('Te', 'Madonna', 4.5).play());
// console.log(module.getVideo('Bitch', 'Madonna', 6).play());
var playlist = module.getPlaylist('Hip hop');
playlist.addPlayable(module.getAudio('mamma mia', 'abba', 5.67));
playlist.addPlayable(module.getAudio('mamma mia 12', 'abba', 5.67));
playlist.addPlayable(module.getAudio('mamma mia 7', 'abba', 5.67));
playlist.addPlayable(module.getAudio('mamma mia 8', 'abba', 5.67));
console.log(playlist.listPlayables(0,10));
playlist.removePlayable(4);
console.log(playlist.listPlayables(0, 10));
var playable = playlist.getPlayableById(2);
console.log(playable);*/

//mocha::::::::::::::::::::::::::::;;;
/*
var module = solve();
var name = 'Rock and roll',
	testlist = module.getPlaylist(name),
	testplayable = {id: 1, name: 'Banana Rock', author: 'Wombles'},
	testplayable2 = {id: 2, name: 'Banana Rock2', author: 'Wombles2', length: 67};
testlist.addPlayable(testplayable2);
testlist.addPlayable(testplayable);
console.log(testlist);
testlist.removePlayable(testplayable2);
console.log(testlist);*/
