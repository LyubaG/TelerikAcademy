function solve() {

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


// TODO validation for ID is number
	function isNonEmptyString(param) {
		if (typeof (param) !== 'string') {
			return false;
		}
		return param.length >= 1;
	}
	function isValidString(param) {
		if (typeof (param) !== 'string') {
			return false;
		}
		return param.length >= 2 && param.length <= 40;
	}

	function validateNumber(param) {
		param = +param;
		if (typeof param !== 'number') {
			throw new Error('that is not a number');
		}
	}

	var item = function () {
		var id = 0;

		var item = {
			init: function (description, name) {
				this.description = description;
				this.name = name;
				this.id = id += 1;
				return this;
			},
// IVO on hiding the ID with defineProperty _id :) --> https://youtu.be/_qDJgAeEkoo?t=765
			get description() {
				return this._description;
			},
			set description(val) {
				if (!isNonEmptyString(val)) {
					throw new Error('invalid descritpion');
				}
				this._description = val;
			},
			get name() {
				return this._name;
			},
			set name(val) {
				if (!isValidString(val)) {
					throw new Error('invalid item name');
				}
				this._name = val;
			},
			//play: function () {
			//	return this.id + '. ' + this.title + ' - ' + this.author;
			//}
		};

		return item;
	}();

	var book = function (parent) {
		// https://youtu.be/O_M5bsCJjOM?t=3030 TODO without defineProps?
		var book = Object.create(parent);
		book.init = function (name, isbn, genre, description) {
			parent.init.call(this, name, description); //TODO wtf check whaaa
			this.isbn = isbn;
			this.genre = genre;
			return this;
		};
		Object.defineProperty(book, 'isbn', {
			get: function () {
				return this._isbn;
			},
			set: function (val) {
				if (typeof (val) !== 'string' || (val.length !== 10 && val.length !== 13)) {
					throw new Error('invalid isbn');
				}
				val = +val; //remember to convert values!
				if (typeof(val) !== 'number' || val <= 0) {
					throw new Error('invalid isbn');
				}
				this._isbn = val;
			}
		});
		Object.defineProperty(book, 'genre', {
			get: function () {
				return this._genre;
			},
			set: function (val) {
				if (typeof (val) !== 'string' || val.length < 2 && val.length > 20) {
					throw new Error('invalid genre');
				}
				this._genre = val;
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
		//audio.play = function () {
		//	var baseResult = parent.play.call(this);
		//	return baseResult + ' - ' + this.length;
		//}
		return book;
	}(item);

	var media = function (parent) {
		var media = Object.create(parent);
		media.init = function (name, rating, duration, description) {
			parent.init.call(this, name, description); //TODO wtf check whaaa
			this.rating = rating;
			this.duration = duration;
			return this;
		};
		Object.defineProperty(media, 'rating', {
			get: function () {
				return this._rating;
			},
			set: function (val) {
				val = +val;
				if (typeof(val) !== 'number' || val < 1 || val > 5) {
					throw new Error('invalid rating');
				}
				this._rating = val;
			}
		});
		Object.defineProperty(media, 'duration', {
			get: function () {
				return this._duration;
			},
			set: function (val) {
				val = +val;
				if (typeof (val) !== 'number' || val.length <= 0) {
					throw new Error('invalid duration');
				}
				this._duration = val;
			}
		});

		return media;
	}(item);


	var catalog = function () {
		var lastId = 0;

		var catalog = {
			init: function (name) {
				this.name = name;
				this.id = lastId += 1;
				this.items = []; // TODO don't use slice!!!! (for testing reasons???)
				return this;
			},
			get name() {
				return this._name;
			},
			set name(val) {
				if (!isValidString(val)) {
					throw new Error('invalid catalog name');
				}
				this._name = val;
			},
			// ************ METHODS ******************************
			add: function (args) { // TODO many args or an array
				if(!args || args === undefined) {
					throw new Error('no arguments passed')
				}
				else if (Array.isArray(args)) {
					if (args.length < 1) {
						throw new Error('add items array error');
					}
					for (var item in args) {
						if (typeof (item.id) === 'undefined'
							|| typeof (item.name) === 'undefined' || typeof (item.description) === 'undefined') {  // TODO tricky stuff
							throw new Error('not instance of item');
						}
					}
					for (var item in args) {
						this.items.push(item);
					}
				}
				else if (args.length < 1) {
					throw new Error('no arguments');
				}
				else { //args.length >=1
					var i,
						len = args.length;
					for (i = 0; i < len; i+=1) {
						if (typeof (args[i].id) === 'undefined'
							|| !args[i].name || !args[i].description) {  // TODO tricky stuff
							throw new Error('not instance of item');
						}
					}
					for (i = 0; i < len; i += 1) {
						this.items.push(args[i]);
					}
				}
				//	else throw new Error ('stuff to add does not exist...maybe?'); // TODO keep?
				return this; // TODO remember to return this to enable chaining
			},

			find: function (id) {
				if (id === undefined) {
					throw new Error('no arguments passed');
				}
				if (typeof id === 'object') { // TODO try with typeof object
					var obj = id,
						resultArr =[],
						len = this.items.length;
					for (var option in obj){ //TODO fix mishmash
						if (option === 'name') {

							for (i = 0; i < len; i += 1) {
								if (this.items[i].name.toLowerCase() === obj.name.toLowerCase()) {
									resultArr.push(this.items[i]);
								}
							}
						}
						if (option === 'id') {
							for (i = 0; i < len; i += 1) {
								if (this.items[i].id === obj.id) {
									resultArr.push(this.items[i]);
								}
							}
						}
					}

					return resultArr;
				}
				else validateNumber(id);
				var i,
					len = this.items.length;

				for (i = 0; i < len; i += 1) {
					if (this.items[i] === 'undefined') {
						return null;
					}
					else if (this.items[i].id === id) {
						return this.items[i];
					}
				}
				return this;
			},
			search: function (pattern) {
				if (!(pattern instanceof String) || pattern.length < 1) {
					throw new Error('invalid pattern');
				}

				pattern = pattern.toLowerCase();
				/*				return this.items.filter(function (items) {
				 return item.getAllItems()
				 .some(function (item) {
				 return item.name.toLocaleLowerCase()
				 .indexOf(pattern) >= 0
				 || item.description.toLocaleLowerCase()
				 .indexOf(pattern) >= 0;
				 });
				 }); // if empty, filter returns an empty array...*/
				var resultArr2 = [];
				var regex = new RegExp(pattern);
				for (var item in this.items) {
					if (regex.test(item.name) || regex.test(item.description)) {
							resultArr2.push(item);
						}
				}
				return resultArr2;
			},
			getAllItems: function () {
				return this.items; // TODO don't use slice??? ever???
			}
		};

		return catalog;
	}();

	var bookCatalog = function (parent) {
		var bookCatalog = Object.create(parent);
		/*		bookCatalog.init = function (name) {
		 parent.init.call(name);
		 return this;
		 };*/
		bookCatalog.getGenres = function () {
			//TODO return array of lowercase strings, all unique genres
			var resultArr = [],
				len = this.items.length,
				i;
			resultArr.push(this.items[0].genre.toLowerCase());
			for (i = 1; i < len; i+=1) {
				if (this.items[i].genre.toLowerCase() !== this.items[i-1].genre.toLowerCase()){
					resultArr.push(this.items[i].genre.toLowerCase());
				}
			}
			return resultArr;
		}; // WTF no test????????
		bookCatalog.search = function () {
		return parent.search.call(this);
		};
		bookCatalog.add = function (args) {
			//TODO extend twice

			if (!args || args === undefined) {
				throw new Error('no arguments passed')
			}
			else if (Array.isArray(args)) {
				if (args.length < 1) {
					throw new Error('add items array error');
				}
				for (var item in args) {
					if (typeof (item.id) === 'undefined'
						|| typeof (item.name) === 'undefined'
						|| typeof (item.description) === 'undefined'
						|| typeof (item.isbn) === 'undefined'
						|| typeof (item.genre) === 'undefined') {  // TODO tricky stuff for book now
						throw new Error('not instance of book');
					}
				}
				for (var item in args) {
					this.items.push(item);
				}
			}
			else if (args.length < 1) {
				throw new Error('no arguments');
			}
			else { //args.length >=1
				var i,
					len = args.length;
				for (i = 0; i < len; i += 1) {
					if (typeof (args[i].id) === 'undefined'
						|| typeof (args[i].name) === 'undefined' || typeof (args[i].description) === 'undefined'
						|| typeof (args[i].isbn) === 'undefined'
						|| !args[i].genre) {  // TODO tricky stuff for book now
						throw new Error('not instance of book');
					}
				}
				for (i = 0; i < len; i += 1) {
					this.items.push(args[i]);
				}
			}
			return this;
		};
		bookCatalog.find = function (id) {
			//TODO extend, no copy-paste...
			if (id === undefined) {
				throw new Error('no arguments passed');
			}
			if (typeof id === 'object') { // TODO try with typeof object
				var i,
					obj = id,
					resultArr = [],
					len = this.items.length;
				for (var option in obj) { //TODO fix mishmash
					if (option === 'name') {

						for (i = 0; i < len; i += 1) {
							if (this.items[i].name.toLowerCase() === obj.name.toLowerCase()) {
								resultArr.push(this.items[i]);
							}
						}
					}
					if (option === 'id') {
						for (i = 0; i < len; i += 1) {
							if (this.items[i].id === obj.id) {
								resultArr.push(this.items[i]);
							}
						}
					}
					if (option === 'genre') {
						for (i = 0; i < len; i += 1) {
							if (this.items[i].genre.toLowerCase() === obj.genre.toLowerCase()) {
								resultArr.push(this.items[i]);
							}
						}
					}
				}
				return resultArr;
			}

			else validateNumber(id);
			var i,
				len = this.items.length;

			for (i = 0; i < len; i += 1) {
				if (this.items[i] === 'undefined') {
					return null;
				}
				else if (this.items[i].id === id) {
					return this.items[i];
				}
			}

			return this;

		};

		return bookCatalog;
	}(catalog);


	//TODO lots of work on media catalog::::::::::::::::::::::::::::::::::::;;
	var mediaCatalog = function (parent) {
		var mediaCatalog = Object.create(parent);
		var i, obj = {}, resultArr = [];

		mediaCatalog.getTop = function (count) {
			if (typeof count !== 'number' || +count < 1) {
				throw new Error('count is invalid');
			};
			/*
			 this.items.sort(function (pl2, pl1) {
			 if (pl1.rating === pl2.rating) {
			 return pl1.id - pl2.id;
			 }
			 return pl1.rating.localeCompare(pl2.rating); // lexic. comparison
			 });*/ //TODO check if it works! or use additional func...
			this.items = this.items.objSort('rating', -1, 'name');
			for (i = 0; i < count; i+=1) {
				obj.name = this.items[i].name;
				obj.id = this.items[i].id;
				resultArr.push(obj); // TODO push string?
			}
			return resultArr;
		};

		mediaCatalog.search = function (pattern) {
			return parent.search.call();
		};
		mediaCatalog.getSortedByDuration = function () {
			this.items = this.items.objSort('duration', -1, 'id');
			//TODO
		};

		mediaCatalog.add = function () {
			//TODO extend twice
			if (!args || args === undefined) {
				throw new Error('no arguments passed')
			}
			else if (Array.isArray(args)) {
				if (args.length < 1) {
					throw new Error('add items array error');
				}
				for (var item in args) {
					if (typeof (item.id) === 'undefined'
						|| typeof (item.name) === 'undefined'
						|| typeof (item.description) === 'undefined'
						|| typeof (item.duration) === 'undefined'
						|| typeof (item.rating) === 'undefined') {  // TODO tricky stuff for book now
						throw new Error('not instance of book');
					}
				}
				for (var item in args) {
					this.items.push(item);
				}
			}
			else if (args.length < 1) {
				throw new Error('no arguments');
			}
			else { //args.length >=1
				var i,
					len = args.length;
				for (i = 0; i < len; i += 1) {
					if (typeof (args[i].id) === 'undefined'
						|| typeof (args[i].name) === 'undefined' || typeof (args[i].description) === 'undefined'
						|| typeof (args[i].duration) === 'undefined'
						|| !args[i].rating) {  // TODO tricky stuff for book now
						throw new Error('not instance of book');
					}
				}
				for (i = 0; i < len; i += 1) {
					this.items.push(args[i]);
				}
			}
			return this;


		};

		return mediaCatalog;
	}(catalog);


	return {
		getBook: function (name, isbn, genre, description) {
			return Object.create(book).init(name, isbn, genre, description);
		},
		getMedia: function (name, rating, duration, description) {
			return Object.create(media).init(name, rating, duration, description);
		},
		getBookCatalog: function (name) {
			return Object.create(bookCatalog).init(name);
		},
		getMediaCatalog: function (name) {
			return Object.create(mediaCatalog).init(name);
		}
	};
}

// test
var module = solve();
var catalog = module.getBookCatalog('John\'s catalog');

var book1 = module.getBook('The secrets of the JavaScript Ninja', '1234567890', 'IT', 'A book about JavaScript');
var book2 = module.getBook('JavaScript: The Good Parts', '0123456789', 'IT', 'A good book about JS');
catalog.add(book1);
catalog.add(book2);


console.log(catalog.find(book1.genre));
//returns book1
var hmobj = {id: book2.id, genre: 'IT'};

console.log(catalog.search('js'));
// returns book2

console.log(catalog.search('javascript'));
//returns book1 and book2

console.log(catalog.search('Te sa zeleni'))
//returns []
















