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


    return function (element, contents) {
        var id = element;
        var len = contents.length;
        if (element instanceof HTMLElement) {
            id = element.id;
        }
        if (!(typeof(element) === 'string' || (element instanceof HTMLElement))) {
            throw new Error('The first parameter must be string or object');
        }
        var domElement = document.getElementById(id);
        if (domElement === null) {
            throw new Error('Element with that id doesn\'t exist');
        }
        if (element === null || contents === null) {
            throw Error('You must pass two parameters');
        }
        if (!Array.isArray(contents)) {
            throw Error('The contents must be array');
        }
        for (var i = 0; i < contents.length; i += 1) {
            if (!(typeof contents[i] === 'string' || typeof contents[i] === 'number')) {
                throw Error('All the contents must be either number of string');
            }
        }

        var domElement = document.getElementById(id);
        domElement.innerHTML = "";
        var div = document.createElement('div');
        var fragment = document.createDocumentFragment();
        var selectedElement = document.getElementById(id);
        for (var i = 0; i < len; i += 1) {
            var divToAdd = div.cloneNode(true);
            divToAdd.innerHTML = contents[i];
            fragment.appendChild(divToAdd);
        }
        domElement.appendChild(fragment);

    }
}


