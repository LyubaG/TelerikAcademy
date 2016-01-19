function solve() {
	return function (selector, isCaseSensitive) {
		isCaseSensitive = isCaseSensitive || false;
		var root = document.querySelector(selector), // TODO check for selector validity
			newDivAdd = document.createElement('div'),
			newDivSearch = document.createElement('div'),
			newAddBtn = document.createElement('button'),
			result = document.createElement('div'),
			itemsList = document.createElement('div'),
			btnName = document.createTextNode("Add"),
			searchField = document.createElement('input');

		newDivAdd.className = 'add-controls';

		newDivSearch.className = 'search-controls';

		newAddBtn.className = 'button';
		result.className = 'result-controls';
		itemsList.className = 'items-list';

		newAddBtn.appendChild(btnName);
		newDivAdd.label = 'Enter text'; // or just =
		var addField = searchField.cloneNode(true);
		addField.label = 'Enter text';
		newDivAdd.appendChild(addField);
		addField.id = 'ADD';
		newDivAdd.appendChild(newAddBtn);
// TODO button etc styles !!!!!!!!! (or remove them?)


		newDivSearch.label = 'Search';
		newDivSearch.appendChild(searchField);

		newAddBtn.addEventListener("click", function () {
			var newItem = document.createElement('div');
			newItem.className += 'list-item',
				addName = document.getElementById("ADD").value;
			//parent = this.parentNode.firstChild.nodeValue;
			var newItemTxt = document.createTextNode(addName);  // post-exam: or... .innerHTML =
			// inputField.value;
			newItem.appendChild(newItemTxt);
			var newItemBtn = document.createElement('button');
			var newBtnName = document.createTextNode("X");
			newItemBtn.appendChild(newBtnName);
			newItem.appendChild(newItemBtn);

			newItemBtn.addEventListener('click', function () {
				this.parentNode.style.display = 'none';    // post-exam: remove it, don't hide it!
			}, false);
			result.appendChild(newItem);
			itemsList.appendChild(newItem);
		}, false);

		result.appendChild(itemsList);

		searchField.addEventListener('change', function () {
			var searchTerm = this.value || '';

			for (var i = 0, len = itemsList.childNodes.length; i < len; i++) {
				var value;

				if(isCaseSensitive) {
					value = itemsList.childNodes[i].innerHTML;
				} else value = itemsList.childNodes[i].innerHTML.toLowerCase();

				if (!(value.contains(searchTerm))) {
					itemsList.childNodes[i].style.display = 'none'; //post-exam: else display block?
				}
				}
		}, false);


		if (!String.prototype.contains) {
			String.prototype.contains = function (searchPattern) {
				var patternLen = searchPattern.length;
				for (var i = 0, length = this.length - patternLen; i < length; i++) {
					var isMatch = true;
					for (var j = 0; j < patternLen; j++) {
						if (searchPattern[j] !== this[i + j]) {
							isMatch = false;
							break;
						}
					}
					if (isMatch) {
						return true;
					}
				}
				return isMatch;
			}
		}
		//!

		var docFragment = document.createDocumentFragment();
		docFragment.appendChild(newDivAdd);
		docFragment.appendChild(newDivSearch);
		docFragment.appendChild(result);
		root.appendChild(docFragment);
	};
}

module.exports = solve;