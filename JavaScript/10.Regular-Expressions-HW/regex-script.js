/*
Problem 1. Format with placeholders

    Write a function that formats a string. The function should have placeholders, as shown in the example
        Add the function to the String.prototype
*/

String.prototype.format = function (options) {
	var option,
		regex,
		formatted = this;
	for (option in options) {
		regex = new RegExp('#{' + option + '}', 'g');
		formatted = formatted.replace(regex, options[option]);
	}
	return formatted;
};
console.log('Hello, there! Are you #{name}?'.format({name: 'John'}));  // var options = {name: 'John'};
console.log('My name is #{name} and I am #{age}-years-old'.format({name: 'John', age: 13}));  // var options = {name: 'John', age: 13};

/*
Problem 2. HTML binding

    Write a function that puts the value of an object into the content/attributes of HTML tags.
        Add the function to the String.prototype
*/

String.prototype.bind = function (output, parameters) {
	var regexContent,
		regexHref,
		regexClass,
		prop;
	output = this;
	for (prop in parameters) {
		contentPattern = new RegExp('(<.*?data-bind-content="' + prop + '".*?>)(.*?)(<\\s*/.*?>)', 'g');
		hrefPattern = new RegExp('(<.*?data-bind-href="' + prop + '".*?)>', 'g');
		classPattern = new RegExp('(<.*?data-bind-class="(' + prop + ')".*?)>', 'g');
		output = output.replace(contentPattern, function (element, openingTag, content, closingTag) {
			return openingTag + parameters[prop] + closingTag;
		});
		output = output.replace(hrefPattern, function (tag, contentBeforeClosing) {
			return contentBeforeClosing + ' href="' + parameters[prop] + '">';
		});
		output = output.replace(classPattern, function (tag, contentBeforeClosing) {
			return contentBeforeClosing + ' class="' + parameters[prop] + '">';
		});
	}
	return output;
};
console.log('<div data-bind-content="name"></div>'.bind('', {name: 'Steven'}));
console.log('<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></div>'.bind('', {
	name: 'Elena',
	link: 'http://telerikacademy.com'
}));