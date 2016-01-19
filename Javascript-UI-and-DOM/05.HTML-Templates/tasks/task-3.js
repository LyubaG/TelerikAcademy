function solve(){
  return function(){
    $.fn.listview = function(data){
	    var $this = $(this),
		    templateId = $this.attr('data-template'),
		    template = $('#' + templateId).html(),
		    processedHtml = handlebars.compile(template),//Handlebars is not defined error, use lowercase here
		    i, len = data.length;

	    for (i = 0; i < len; i += 1) {
		    // append each li to the ul ($this); apply each data element to the handlebared html
		    $this.append(processedHtml(data[i]));
	    }

	    return this;
    };
  };
}

module.exports = solve;