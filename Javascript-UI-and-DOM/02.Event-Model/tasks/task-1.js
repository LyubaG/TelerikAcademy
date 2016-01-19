/* globals $ */

/* 

Create a function that takes an id or DOM element and:


*/

function solve(){
  return function (element) {
    var selectedEl,
        buttonList,
        contentList,
        el,
        i,
        len;

    if (typeof(element) !== 'string' && !(element instanceof HTMLElement)) {
      throw ''; // throw new Error('Missing element');
    }
    if (document.getElementById(element) === null) {
      throw 'no such element';
    }
    if (typeof(element) === 'string') {
      selectedEl = document.getElementById(element);
    } else {
      selectedEl = element;
    }

  buttonList = selectedEl.querySelectorAll('.button');
  // contentList = selectedEl.querySelectorAll('.content');

    for (i = 0, len = buttonList.length; i < len; i += 1) {
      buttonList[i].innerHTML = 'hide';
      buttonList[i].addEventListener('click', onBtnClick, false);


function onBtnClick(ev) {
  var clickedBtn = ev.target,
      nextElement = clickedBtn.nextElementSibling,
      nextElSibling,
      firstContent,
      validContentEl = false;

  while(nextElement) {
    if(nextElement.className === 'content') {
        firstContent = nextElement;
        nextElement = nextElement.nextElementSibling;
      while(nextElement) {
        if(nextElement.className === 'button') {
          validContentEl = true;
          break;
        }
          nextElement = nextElement.nextElementSibling;
      }
      break; //!!!!!
    }
    else {
        nextElement = nextElement.nextElementSibling;
    }
  }

    if(validContentEl) {
        if(firstContent.style.display === '') {
            firstContent.style.display = 'none'; // tests don't test for visible...and '' is visible...oh well
            clickedBtn.innerHTML = 'show';
        }
        else {
            firstContent.style.display = '';
            clickedBtn.innerHTML = 'hide';
        }

    }

};


    }

  };





}

module.exports = solve;