function solve(){
  return function(selector){

	  var $selectedList = $(selector)
		  .hide();  // style="display: none;
	  var options = $selectedList.find('option');

	  var $divContainer = $('<div>')
		  .addClass('dropdown-list')
		  .append($selectedList);

	  var $currentSelection = $('<div>')
		  .addClass('current')
		  .attr('data-value', '')
		  .text('Select value');

	  var $optionsContainer = $('<div>')
		  .addClass('options-container')
		  .css({
			  'position': 'absolute',
			  'display': 'none'
		  });

	  $currentSelection.on('click', function () {
		  var $optionsList = $('.options-container');
		  $optionsList.css('display', 'inline-block'); //show() ????
	  });

	  for (var i = 0, len = options.length; i < len; i += 1) {
		  var dropOption = $('<div>')
			  .addClass('dropdown-item')
			  .attr('data-value', $(options[i]).val())
			  .attr('data-index', i)
			  .text($(options[i]).text());
		  dropOption.appendTo($optionsContainer);
	  }

	  $optionsContainer.on('click', '.dropdown-item', function (ev) {
		  $optionsContainer.hide();
		  var $clickedItem = $(ev.target);
		  $(selector).val($(this).attr('data-value')); // $selectedList.val($clicked.attr('data-value'));  //  WHYYYY??????
		  $('.current').text($clickedItem.text());

		  //$(this).css('display', 'none');
	  });

	  $divContainer.append($currentSelection).append($optionsContainer);
	  $divContainer.appendTo('body');
  };
}

module.exports = solve;