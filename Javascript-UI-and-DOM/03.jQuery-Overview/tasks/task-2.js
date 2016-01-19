/* globals $ */

/*
 Create a function that takes a selector and:
 * Finds all elements with class `button` or `content` within the provided element
 * Change the content of all `.button` elements with "hide"
 * When a `.button` is clicked:
 * Find the topmost `.content` element, that is before another `.button` and:
 * If the `.content` is visible:
 * Hide the `.content`
 * Change the content of the `.button` to "show"       
 * If the `.content` is hidden:
 * Show the `.content`
 * Change the content of the `.button` to "hide"
 * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
 * Throws if:
 * The provided ID is not a **jQuery object** or a `string` 

 */
function solve() {
	var onClickEvent = function () {
	};

	return function (selector) {
		if (typeof(selector) !== 'string' || $(selector).size() === 0) {
			throw 'invalid jQuery object';
		}
		var $buttons = $('.button'),
			i, len = $buttons.length;

		for (i = 0; i < len; i += 1) {
			$($buttons[i]).text('hide');

			//$("ul").on("click", "li", onListItemClick);

			$($buttons[i]).on('click',function () {
				var clickedButton = $(this),
					nextElement = clickedButton.next(),
					firstContent,
					validFirstContent = false;

				while (nextElement) {
					if (nextElement.hasClass('content')) {
						firstContent = nextElement;
						nextElement = nextElement.next();
						while (nextElement) {
							if (nextElement.hasClass('button')) {
								validFirstContent = true;
								break;
							}
							nextElement = nextElement.next();
						}
						break;
					} else {
						nextElement = nextElement.next();
					}
				}

				if (validFirstContent) {
					if (firstContent.css('display') === 'none') {
						clickedButton.text('hide');
						firstContent.css('display', '');
					} else {
						clickedButton.text('show');
						firstContent.hide();
					}
				}
			});

		}
	};
}

module.exports = solve;