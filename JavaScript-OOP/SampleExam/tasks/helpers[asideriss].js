//prototype inheritance

var Animal = (function () {

	var Animal = {
		init: function (name, age) {
			this.name = name;
			this.age = age;
			return this;   //important
		},
		get name() {
			return this._name;
		},
		set name(value) {
			if (true) {
				this._name = value;
			}
			else if (false) {
				throw new Error('someError');
			}
		},
		get age() {
			return this._age;
		},
		set age(value) {
			this._age = value;
		},
		//overriding parent method
		toString: function () {
			return 'overrided toString : name--> ' + this.name + '| age --> ' + this.age;
		}

	};
	return Animal;   //important
}());

var cat = (function (parent) {
	var cat = Object.create(parent);

	Object.defineProperty(this, 'init', {
		value: function (name, age) { // tuk moje da podadem i drugi property ta
			parent.init.call(this, name, age);
		}
	});
	return cat;
}(Animal));

var kitten = (function (parent) {
	var kitten = Object.create(parent);


	kitten.toString = function () {
		return parent.toString.call(this) + ' overrided';
	};
	return kitten;
}(cat));


var testAnimal = Object.create(Animal).init('jirafcho', 3);
var testKitten = Object.create(kitten).init('goshka', 1);
var testCat = Object.create(cat).init('penka', 12);

//ducktyping -> tova se interesuva da ima name i age samo za da moje da si svurshi rabotata
//console.log(testCat.toString.call({name: 'duck', age: 12}));

console.log(testKitten);

//************************************************************************************************


//module pattern -> napravi mi eedno IIFE , koeto ima nqkakvi hidden neshta i nakraq vrushta samo edin obekt
// koito expose-va public methods

var db = (function () {
	var objects = [],
		ID = 0;

	function getNextID() {
		return ++ID;
	}

	return {
		add: function (obj) {
			obj.id = getNextID();
			objects.push(obj);
		},
		list: function () {
			// return objects.slice(); //vinagi vrushtame referenciq za da ne ni smeni nqkoi private obekta
			return objects.map(function (obj) {
				return {
					name: obj.name,
					id: obj.id
				}
			}).slice();
		}
	};
}());

db.add({name: 'John'});

console.log(db.list());

//************************************************************************************************


//revealing module pattern sushtata kato module pattern , samo che razlikata e vmesto da slagame funkciite v return
//obekta vsichki funkcii si gi slagame nai otgore i v return obekta mu podavame referenciq kum funkciite:

var db = (function () {
	var objects = [],
		ID = 0;

	function getNextID() {
		return ++ID; // closure kum ID
	}

	function addObject(obj) {
		obj.ID = getNextID(); // closure kum getNextID
		objects.push(obj);
	}

	function listObjects() {
		// return objects.slice(); //vinagi vrushtame referenciq za da ne ni smeni nqkoi private obekta
		return objects.map(function (obj) {
			return {
				name: obj.name,
				id: obj.ID
			}
		}).slice();
	}

	return {
		add: addObject,  // tuk mu podavame referencii kum funkciite..
		list: listObjects
	};
}());

db.add({name: 'Pesho'});
db.add({name: 'asd'});
db.add({name: 'ttt'});
db.add({name: '222'});

console.log(db.list());


//************************************************************************************************


//singleton pattern -> znachi che kolkoto puti da pravim edin obekt, toi shte ima edna i sushta instanciq
// kato -> saita na akademiqta e edin a ne za vsichki razlichen

// kaji rechi vsqko IIFE implementira SINGLETON pattern tui kato se suzdava samo vednuj

var databases = (function () { // kato ni dava IIFE nqma smisul da pishem slojni neshta

	var items = [];

	var db = {
		add: function (item) {
			items.push(item);
			return this;//po sigurno e da vurnem db   // za da si napravim chaining
		},
		list: function () {
			return items.slice();
		}
	};

	return {
		get: function () {
			return db;
		}
	}
}());

console.log(databases.get()
	.add('John')
	.add('Hohn')
	.list());


//************************************************************************************************


//ArgumentingModules - Extending Existing MODULE -> Na praktika ni kazva:
//ideqta e ako imam modul 500 reda kod da moga da go razpredelq v 2 faila za da mi e po podredeno i qko


// file-1.js   abe tuka imam file 1.js
var mod = (function () {
	return {
		x: 'file-1'
	};
}());

// file-2.js abe tuka imam file 2.js

var mod = (function () {
	return {
		y: 'file-2'
	}
}());

//console.log(mod.x);  tova e undefined zashtoto ednoto override va drugoto i imame samo property [y];
//pravi se taka :
var module = module || {};   //moje da go slojim taka i v dvata faila vmesto da go deklarirame v
// ediniq fail i da mu kazvame ako e undefined to e falsy like da suzdava nov obekt, a ako
// go ima suzdaden kato obekt da si polzva nego :)

(function (scope) {

	scope.x = 'file-1';

}(module));

// file-2.js abe tuka imam file 2.js
var module = module || {};

(function (scope) {

	scope.y = 'file-2';

}(module));

console.log(module.x);
console.log(module.y);


//************************************************************************************************

//************************************************************************************************