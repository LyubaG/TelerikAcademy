//Problem 12. Generate list
//    Write a function that creates a HTML <ul> using a template for every HTML <li>.
//    The source of the list should be an array of elements.
//    Replace all placeholders marked with –{…}– with the value of the corresponding property of the object.

var people = [
		{name: 'Baba Meca', age: 12},
		{name: 'Kuma Lisa', age: 14},
		{name: 'Dodko', age: 45},
		{name: 'Muncho', age: 7},
		{name: 'Telefonka', age: 124}];

var template = document.getElementById('list-item').innerHTML;

function generateList() {
	var ul = document.createElement('ul');
	for (var ind in people) {
		var li = document.createElement('li');
		li.innerHTML = format(template, people[ind]);
		ul.appendChild(li);
	}
	document.body.appendChild(ul);
};

function format(string, person) {
	return string.replace(/\-{(\w+\d*)\}-/g, function (match, prop) {
		return person[prop] || '';
	});
}