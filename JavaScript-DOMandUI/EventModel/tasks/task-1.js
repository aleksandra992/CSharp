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
        }
        var lastButton = allWithClassButton[allWithClassButton.length - 1];
        domElement.addEventListener('click', function (ev) {

            var contentElement;
            var next = ev.target.nextElementSibling;

            while (next) {

                if (next.className === 'content') {
                    break;
                }
                if (next.className === 'button') {
                    break;
                }
                next = next.nextElementSibling;

            }

            if (!Object.is(lastButton, ev.target)) {

                if (next.className === 'content') {
                    if (next.style.display == 'none') {
                        // console.log('tukaaaaa');
                        ev.target.innerHTML = 'hide';
                        next.style.display = '';
                    }
                    else {
                        ev.target.innerHTML = "show";
                        next.style.display = 'none';
                    }
                }
            }

        }, false);

    };
}
module.exports = solve;