/* globals $ */

/* 

 Create a function that takes an id or DOM element and:


 */

function solve() {
    return function (selector) {


        if (selector === undefined) {
            throw Error();
        }

        if (typeof selector !== 'string') {
            throw Error();
        }

        var elementId = selector;
        var len;
        if (selector instanceof HTMLElement) {
            elementId = selector.id;
        }
        var domElement = document.getElementById(elementId);
        if (domElement === null) {
            throw Error();
        }
        var i = 0;
        var allWithClassButton = domElement.querySelectorAll('.button');
        var allWithClassContent = domElement.querySelectorAll('.content');

        for (var i = 0, len = allWithClassButton.length; i < len; i += 1) {
            var buttonElement = allWithClassButton[i];
            buttonElement.innerHTML = "hide";

            buttonElement.addEventListener('click', function () {
                var contentElement;
                var next = this.nextElementSibling;

                while (next.className !== 'button') {
                    if (next.className === 'content') {
                        break;
                    }
                    next = next.nextElementSibling;

                }
                console.log(next.className);    
                if (next.className === 'content' && next.style.display == '') {
                    // console.log('tukaaaaa');
                    this.innerHTML = 'show';
                    next.style.display = "none";
                }
                else if (next.className === 'content' && next.style.display == 'none') {
                    //  console.log('none');
                    this.innerHTML = "hide";
                    next.style.display = '';
                }

            }, false);


            var allWithClassContent = domElement.querySelectorAll('.content');


        }

    };
}
module.exports = solve;