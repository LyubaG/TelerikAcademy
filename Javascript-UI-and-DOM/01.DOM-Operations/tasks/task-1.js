/* globals $ */

/*
 Create a function that takes an id or DOM element and an array of contents
 * if an id is provided, select the element
 * Add divs to the element
 * Each div's content must be one of the items from the contents array
 * The function must remove all previous content from the DOM element provided
 * Throws if:
 * The provided first parameter is neither string or existing DOM element
 * The provided id does not select anything (there is no element that has such an id)
 * Any of the function params is missing
 * Any of the function params is not as described
 * Any of the contents is neight `string` or `number`
 * In that case, the content of the element **must not be** changed
 */

module.exports = function () {

	return function (element, contentsArr) {
		var selectedEl,
			i,
			len,
			docFragment,
			newDiv;

		if (!element || !contentsArr) {
			throw new Error('Missing function param(s)');
		}
		if (typeof(element) !== 'string' && !(element instanceof HTMLElement)) {
			throw new Error('Element name must be a string or valid DOM element');
		}
		if (!(contentsArr instanceof Array)) {
			throw new Error('Contents must be an array');
		}
		if (document.getElementById(element)) {
			selectedEl = document.getElementById(element);
		}
		else if(element instanceof HTMLElement) {
			selectedEl = element;
		}
		else throw new Error('No such element exists');  // can be optimised!

		for (i = 0, len = contentsArr.length; i < len; i += 1) {
			if (typeof(contentsArr[i]) !== 'string' && typeof(contentsArr[i]) !== 'number') {
				throw new Error('Contents element is not a string or number');
			}
		}
		selectedEl.innerHTML = '';
		docFragment = document.createDocumentFragment();

		for (i = 0; i < len; i += 1) {
			newDiv = document.createElement('div');
			newDiv.innerHTML = contentsArr[i];
			//selectedEl.innerHTML += '<div>' + contentsArr[i] + '</div>'; //slooow
			docFragment.appendChild(newDiv);
		}
		selectedEl.appendChild(docFragment);
	};
};


