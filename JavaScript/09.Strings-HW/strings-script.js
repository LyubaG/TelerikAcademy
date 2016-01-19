//Problem 1. Reverse string
//    Write a JavaScript function that reverses a string and returns it.

console.log(reverse('sample'));
console.log(reverse('reverse'));
function reverse(string) {
	var reversed = [];
	for (var ind = string.length - 1; ind >= 0; ind--) {
		reversed.push(string[ind]);
	}
	return reversed.join('');
}

//Problem 2. Correct brackets
//    Write a JavaScript function to check if in a given expression the brackets are put correctly.
// Example of correct expression: ((a+b)/5-d).
// Example of incorrect expression: )(a+b)).

console.log('((a+b)/5-d) - ' + isCorrectExpression('((a+b)/5-d)'));
console.log(')(a+b)) - ' + isCorrectExpression(')(a+b))'));
function isCorrectExpression(expr) {
	var check = 0;
	for (var ind = 0; ind < expr.length; ind++) {
		if (expr[ind] === '(') {
			check++;
		} else if (expr[ind] === ')') {
			check--;
		}
		if (check < 0) {
			return 'incorrect';
		}
	}
	return check ? 'incorrect' : 'correct';
}


//Problem 3. Sub-string in text
//    Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).

var text = 'We are living in an yellow submarine. We don\'t have anything else. ' +
	'Inside the submarine is very tight. So we are drinking all the day. ' +
	'We will move out of it in 5 days.';
console.log(getOccurrenceCount(text, 'in'));
function getOccurrenceCount(text, word) {
	var regex = new RegExp(word, 'gi'); //case-insensitive with the addition of 'i'
	return (text.match(regex)).length;
}


//Problem 4. Parse tags
//    You are given a text. Write a function that changes the text in all regions:
//    <upcase>text</upcase> to uppercase.
//    <lowcase>text</lowcase> to lowercase
//    <mixcase>text</mixcase> to mix casing(random)

var text = 'We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. ' +
	'We <mixcase>don\'t</mixcase> have <lowcase>anYTHing</lowcase> else.';
console.log(text);
text = replaceTags(text);
text = parseTags(text);
console.log(text);
function replaceTags(text) {
	text = text.replace(/<\s*upcase\s*>/gi, '<U>');
	text = text.replace(/<\s*\/upcase\s*>/gi, '</U>');
	text = text.replace(/<\s*lowcase\s*>/gi, '<L>');
	text = text.replace(/<\s*\/lowcase\s*>/gi, '</L>');
	text = text.replace(/<\s*mixcase\s*>/gi, '<M>');
	text = text.replace(/<\s*\/mixcase\s*>/gi, '</M>');
	return text;
}
function parseTags(text) {
	var result = [],
		inputArr = text.split(''),
		tags = [],
		inTag = false,
		inClosingTag = false;
	for (var ind = 0; ind < inputArr.length; ind++) {
		if (inputArr[ind] === '<') {
			inTag = true;
			continue;
		}
		if (inputArr[ind] === '/' && inTag) {
			inClosingTag = true;
			continue;
		}
		if (inTag && !inClosingTag && inputArr[ind].match(/[a-z]/i)) {
			tags.push(inputArr[ind]);
			continue;
		}
		if (inputArr[ind] === '>') {
			if (inClosingTag) {
				tags.pop();
				inClosingTag = false;
			}
			inTag = false;
			continue;
		}
		if (!inTag) {
			if (!tags.length) {
				result.push(inputArr[ind]);
			}
			else {
				switch (tags[0]) {
					case 'L':
						result.push(inputArr[ind].toLowerCase());
						break;
					case 'U':
						result.push(inputArr[ind].toUpperCase());
						break;
					case 'M':
						if (!Math.round(Math.random())) {
							result.push(inputArr[ind].toLowerCase());
						} else {
							result.push(inputArr[ind].toUpperCase());
						}
						break;
				}
			}
		}
	}
	return result.join('');
}


//Problem 5. nbsp
//    Write a function that replaces non breaking white-spaces in a text with &nbsp;

var text = 'We are living in a yellow submarine. We don\'t have anything else.';
text = replaceAll(text, ' ', '&nbsp;');
console.log(text);
function replaceAll(text, toReplace, replacement) {
	var regex = new RegExp(toReplace, 'gi');
	return text.replace(regex, replacement);
}

//Problem 6. Extract text from HTML
//    Write a function that extracts the content of a html page given as text.
//    The function should return anything that is in a tag, without the tags.

var html = '<html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body</body></html>';
var text = getText(html);
console.log(text);
function getText(html) {
	return html.replace(/<[^>]*>/g, '');
}

//Problem 7. Parse URL
//    Write a script that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
//    Return the elements in a JSON object.

function parseUri(str) {
	var o = parseUri.options,
		m = o.parser[o.strictMode ? "strict" : "loose"].exec(str),
		uri = {},
		i = 14;
	while (i--) uri[o.key[i]] = m[i] || "";
	uri[o.q.name] = {};
	uri[o.key[12]].replace(o.q.parser, function ($0, $1, $2) {
		if ($1) uri[o.q.name][$1] = $2;
	});
	return uri;
};
parseUri.options = {
	strictMode: false,
	key: ["source", "protocol", "authority", "userInfo", "user", "password", "host", "port", "relative", "path", "directory", "file", "query", "anchor"],
	q: {
		name: "queryKey",
		parser: /(?:^|&)([^&=]*)=?([^&]*)/g
	},
	parser: {
		strict: /^(?:([^:\/?#]+):)?(?:\/\/((?:(([^:@]*)(?::([^:@]*))?)?@)?([^:\/?#]*)(?::(\d*))?))?((((?:[^?#\/]*\/)*)([^?#]*))(?:\?([^#]*))?(?:#(.*))?)/,
		loose: /^(?:(?![^:@]+:[^:@\/]*@)([^:\/?#.]+):)?(?:\/\/)?((?:(([^:@]*)(?::([^:@]*))?)?@)?([^:\/?#]*)(?::(\d*))?)(((\/(?:[^?#](?![^?#\/]*\.[^?#\/.]+(?:[?#]|$)))*\/?)?([^?#\/]*))(?:\?([^#]*))?(?:#(.*))?)/
	}
};
var uri = parseUri('http://telerikacademy.com/Courses/Courses/Details/239');
var parsed = {
	protocol: uri.protocol,
	server: uri.host,
	resource: uri.path
};
console.log(parsed);

//Problem 8. Replace tags
//    Write a JavaScript function that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].

var paragraph = '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. ' +
	'Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';
paragraph = replaceLinkTags(paragraph);
console.log(paragraph);
function replaceLinkTags(text) {
	var regex = /<\s*a\s+href\s*=\s*"(.*?)"\s*>(.*?)<\s*\/a\s*>/gi;
	return text.replace(regex, function (tag, url, content) {
		return '[URL=' + url + ']' + content + '[\/URL]';
	});
}

//Problem 9. Extract e-mails
//    Write a function for extracting all email addresses from given text.
//    All sub-strings that match the format @… should be recognized as emails.
//    Return the emails as array of strings.

var text = 'sdabhikagathara@rediffmail.com, "assdsdf" <dsfassdfhsdfarkal@gmail.com>, "rodnsdfald ferdfnson" <rfernsdfson@gmal.com>, ' +
	'"Affdmdol Gondfgale" <gyfanamosl@gmail.com>, "truform techno" <pidfpinfg@truformdftechnoproducts.com>, "NiTsdfeSh ThIdfsKaRe" ' +
	'<nthfsskare@ysahoo.in>, "akasdfsh kasdfstla" <akashkatsdfsa@yahsdfsfoo.in>, "Bisdsdfamal Prakaasdsh" <bimsdaalprakash@live.com>,; ' +
	'"milisdfsfnd ansdfasdfnsftwar" <dfdmilifsd.ensfdfcogndfdfatia@gmail.com>';
console.log(getEmails(text).join('\n\r'));
function getEmails(text) {
	return text.match(/([a-zA-Z0-9._-]+@[a-zA-Z0-9._-]+\.[a-zA-Z0-9._-]+)/gi);
}

//Problem 10. Find palindromes
//    Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

var text = '"ABBA", "lamal", "exe", "sos", "not", "palindrome", "test"';
console.log(extractPalindromes(text).join('; '));
function extractPalindromes(text) {
	var palindromes = [];
	var words = text.match(/\b\w+\b/g);
	for (var ind in words) {
		if (isPlaindrome(words[ind])) {
			palindromes.push(words[ind]);
		}
	}
	return palindromes;
}
function isPlaindrome(word) {
	for (var ind = 0; ind < word.length / 2; ind++) {
		if (word[ind] !== word[word.length - ind - 1]) {
			return false;
		}
	}
	return true;
}

//Problem 11. String format
//    Write a function that formats a string using placeholders.
//    The function should work with up to 30 placeholders and all types.

console.log(format('{0}, {1}, {0} text {2}', 1, 'Pesho', 'Gosho'));
function format() {
	var args = arguments,
		string = args[0],
		placeholder;
	for (var ind = 1; ind < args.length; ind++) {
		placeholder = '{' + (ind - 1) + '}';
		while (string.indexOf(placeholder) > -1) {
			string = string.replace(placeholder, args[ind]);
		}
	}
	return string;
}




