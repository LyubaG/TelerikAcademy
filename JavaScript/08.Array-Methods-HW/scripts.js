// TO CHECK: just execute in any console

/*Problem 1. Make person
Write a function for creating persons.
Each person must have firstname, lastname, age and gender (true is female, false is male)
Generate an array with ten person with different names, ages and genders*/

function createPerson(firstname,lastname, age, gender){
	return {
		firstname: firstname,
		lastname: lastname,
		age: age,
		gender: gender
	};
}

var people = [1,1,1,1,1,1,1,1,1,1].map(function(_,i){
	return createPerson('Name #' + (i+1),'Last name #' + (i + 1), 5*i, i%2 ? false : true );
});
// '_' means we don't need the actual element, just the index i

console.log(people);
console.log('----------------');
//Problem 2. People of age
//Write a function that checks if an array of person contains only people of age (with age 18 or greater)
//Use only array methods and no regular loops (for, while)

var areAllAdults = people.every(function(element){
	return element.age >=18;
});

console.log(areAllAdults);
console.log('----------------');
//Problem 3. Underage people
//Write a function that prints all underaged persons of an array of person
//Use Array#filter and Array#forEach
//Use only array methods and no regular loops (for, while)

console.log('The underaged:');

(people.filter(function(obj){
	return obj.age < 18;
})).forEach(function(obj){
		console.log(obj.firstname + ': aged ' + obj.age)
	});
console.log('----------------');
//Problem 4. Average age of females
//Write a function that calculates the average age of all females, extracted from an array of persons
//Use Array#filter
//Use only array methods and no regular loops (for, while)

var ladyArr = people.filter(function (obj) {
	return !!(obj.gender);
});
var ladyAge = ladyArr.reduce(function (s, obj) {
	return s + obj.age;
}, 0);
var avrg = ladyAge / ladyArr.length;
console.log('The ladies have the average age of: ' + avrg);
console.log('----------------');
//Problem 5. Youngest person
//Write a function that finds the youngest male person in a given array of people and prints his full name
//Use only array methods and no regular loops (for, while)
//Use Array#find

// Array#find polyfill:
if (!Array.prototype.find) {
	Array.prototype.find = function (predicate) {
		if (this == null) {
			throw new TypeError('Array.prototype.find called on null or undefined');
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
				return value;
			}
		}
		return undefined;
	};
}

console.log('The youngest male: ');

function getYoungestGuy(people) {
	var youngGuy = people.sort(function (a, b) {
		return a.age - b.age;
	}) // to get the first found object with the respective property
		.find(function (person) {
			return !person.gender;
		});
	return youngGuy.firstname + ', age ' + youngGuy.age;
}

console.log(getYoungestGuy(people));
console.log('----------------');
//Problem 6. Group people
//Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
//Use Array#reduce
//Use only array methods and no regular loops (for, while)

console.log('Groups by first letter of name: ');
// Let's first change up the names in my amazing people array:
people[4].firstname = people[9].firstname = 'Proletka';
people[3].firstname = people[7].firstname = 'Ginka';
var groupedObj = people.reduce(function (group, person) {
	var letter = person.firstname[0];
	if (group[letter]) {
		group[letter].push(person);
	} else {
		group[letter] = [person];
	}
	return group;
}, {});
console.log(groupedObj);