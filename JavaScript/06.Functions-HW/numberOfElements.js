// Problem 4. Number of elements
// Write a function to count the number of div elements on the web page

console.log(countTags('div'));
function countTags(tagToFind) {
	return document.getElementsByTagName(tagToFind).length;
}

