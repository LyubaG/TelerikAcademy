/*1. Write functions for working with shapes in standard Planar coordinate system
 > Points are represented by coordinates P(X, Y)
 > Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))
 > Calculate the distance between two points
 > Check if three segment lines can form a triangle*/
function isNumber(n) {
	return !isNaN(parseFloat(n)) && isFinite(n);
}
function Point(x, y) {
	if (!isNumber(x) || !isNumber(y)) {
		throw new Error('X and Y should be numbers.');
	}
	if (!(this instanceof Point)) {
		return new Point(x, y);
	}
	this.x = x;
	this.y = y;
}
Point.prototype.toString = function () {
	return 'P(' + this.x + ',' + this.y + ')';
};
function Line(sPoint, ePoint) {
	if (!(sPoint instanceof Point) || !(ePoint instanceof Point)) {
		throw new Error("sPoint and ePoint should be instances of Point");
	}
	if (!(this instanceof Line)) {
		return new Line(sPoint, ePoint);
	}
	this.sPoint = sPoint;
	this.ePoint = ePoint;
}
Line.prototype.getDistance = function () {
	var x = (this.sPoint.x - this.ePoint.x) * (this.sPoint.x - this.ePoint.x);
	var y = (this.sPoint.y - this.ePoint.y) * (this.sPoint.y - this.ePoint.y);
	return Math.sqrt(x + y);
};
Line.prototype.toString = function () {
	return 'L[' + this.sPoint.toString() + ',' + this.ePoint.toString() + ']';
};
function Triangle(a, b, c) {
	if (!(a instanceof Line) || !(b instanceof Line) || !(c instanceof Line)) {
		throw new Error('A, B and C should be instances of Line');
	}
	if (!(this instanceof Triangle)) {
		return new Triangle(a, b, c);
	}
	if (!canFormTriangle(a, b, c)) {
		throw new Error('invalid triangle');
	}
	this.a = a;
	this.b = b;
	this.c = c;
}
function canFormTriangle(a, b, c) {
	return a.getDistance() < b.getDistance() + c.getDistance() &&
		b.getDistance() < c.getDistance() + a.getDistance() &&
		c.getDistance() < a.getDistance() + b.getDistance();
}
var pointA = new Point(2, 3),
	pointB = new Point(5, 6),
	pointC = new Point(3, 8),
	lineA = new Line(pointA, pointB),
	lineB = new Line(pointB, pointC),
	lineC = new Line(pointC, pointA),
	triangle = new Triangle(lineA, lineB, lineC);
console.log('pointA = ' + pointA.toString());
console.log('pointB = ' + pointB.toString());
console.log('pointC = ' + pointC.toString());
console.log('lineA = ' + lineA.toString());
console.log('lineB = ' + lineB.toString());
console.log('lineC = ' + lineC.toString());
console.log('Can it form a triangle from lineA, lineB and lineC? ' + canFormTriangle(lineA, lineB, lineC));
//------------------------------------------------------------------------------------------------
/*2. Write a function that removes all elements with a given value
 > Attach it to the array type.
 > Read about prototype and how to attach methods.*/
var arr = [7,55,64,89,0,7,6,7];
console.log(arr);
Array.prototype.remove = function (value) {
	for (var i in this) {
		if (this[i] === value) {
			this.splice(i, 1);
		}
	}
	return this;
}
console.log(arr.remove(7));
//------------------------------------------------------------------------------------------------
//3. Write a function that makes a deep copy of an object. The function should work for both primitive and reference types.
console.log(deepCopy(12.5));
console.log(deepCopy({name: 'baba meca', weight: 190}));

function deepCopy(obj) {
	var copy = obj instanceof Array ? [] : {};
	if (obj === null || typeof(obj) !== 'object') {
		return obj;
	}
	for (var i in obj) {
		if (typeof(obj[i]) === 'object') {
			copy[i] = deepCopy(obj[i]);
		} else {
			copy[i] = obj[i];
		}
	}
	return copy;
}
//------------------------------------------------------------------------------------------------
//4. Write a function that checks if a given object contains a given property.
var obj = {fname: "baba", lname: "meca", age: 12, weight: 190, occupation: 'ninja'}
console.log(hasProperty(obj, 'occupation'));
console.log(hasProperty(obj, 'address'));

function hasProperty(obj, prop) {
	if (prop in obj) {
		return true;
	}
	return false;
}
//------------------------------------------------------------------------------------------------
//5. Write a function that finds the youngest person in a given array of persons and prints his/hers full name.
//Each person have properties firstname, lastname and age

var people = [
	{firstname: "Baba", lastname: "Meca", age: 17},
	{firstname: "Kuma", lastname: "Lisa", age: 11},
	{firstname: "Kumcho", lastname: "Vylcho", age: 18},
	{firstname: "Mamma", lastname: "Mia", age: 55},
	{firstname: "J", lastname: "O", age: 12}];

console.log(findYoungestPerson(people));

function findYoungestPerson(people) {
	var youngest = {},
		min = 500;
	for (var i = 0; i < people.length; i += 1) {
		if (people[i].age < min) {
			min = people[i].age;
			youngest = people[i];
		}
	}
	return youngest.firstname + " " + youngest.lastname;
}
//------------------------------------------------------------------------------------------------
/*6. Write a function that groups an array of persons by age, first or last name.
 The function must return an associative array, with keys - the groups, and values -
 arrays with persons in this groups.
 Use function overloading (i.e. just one function).*/

var people = [
	{firstname: "Baba", lastname: "Meca", age: 12},
	{firstname: "Kuma", lastname: "Lisa", age: 14},
	{firstname: "Kumcho", lastname: "Vylcho", age: 18},
	{firstname: "Mamma", lastname: "Mia", age: 55},
	{firstname: "Mamma", lastname: "Lisa", age: 12}];


function Person(firstname, lastname, age) {
	if (isNaN(age) || !isFinite(age)) {
		throw new Error('age must be a number');
	}
	if (!(this instanceof Person)) {
		return new Person(firstname, lastname, age);
	}
	this.firstname = firstname;
	this.lastname = lastname;
	this.age = age;
}
Person.prototype.toString = function () {
	return '(' + this.firstname + ' ' + this.lastname + ',' + this.age + ')';
};

function group(arr, prop) {
	var group = [];
	for (var ind in arr) {
		var currProp = arr[ind][prop];
		group[currProp] = group[currProp] || [];
		group[currProp].push(arr[ind]);
	}
	return group;
}
function printGroups(prop, arr) {
	console.log(prop);
	for (var key in arr) {
		console.log(arr[key].join('; '));
	}
	console.log();
}
var props = ['firstname', 'lastname', 'age'];
for (var ind in props) {
	var groups = group(people, props[ind]);
	printGroups(props[ind], groups);
}