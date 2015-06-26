
var domElement = (function () {

    var domElement = {};
    Object.defineProperty(domElement, 'init', {
        value: function (type) {
            this.type = type;
            this.content = '';
            this.attributes = [];
            this.children = [];
            return this;

        }
    });

    function isNumberOrLetter(number) {
        if (number === ' ') {
            return false;
        }
        return number.split('').every(function (char) {
            var isLetter = ('A' <= char.toUpperCase() && char.toUpperCase() <= 'Z');
            return (char == Number(char) || isLetter);
        });

    }

    function isNumberLetterOrDash(number) {
        if (number === ' ') {
            return false;
        }
        return number.split('').every(function (char) {
            var isLetter = ('A' <= char.toUpperCase() && char.toUpperCase() <= 'Z');
            return (char == Number(char) || isLetter || char === '-');
        });

    }

    Object.defineProperty(domElement, 'type', {
        get: function () {
            return this._type;
        },
        set: function (value) {
            if (value === '' || !isNumberOrLetter(value)) {
                throw Error('The type of the element must be non emtpy string with digits or letters');
            }

            this._type = value;

        }

    });
    Object.defineProperty(domElement, 'innerHTML', {
        get: function () {
            var sorted = this.attributes.sort(function (a, b) {
                return a.name = b.name;
            });
            var result = '<' + this.type + ' ';
            for (var i = 0; i < this.attributes.length; i++) {
                result += this.attributes[i].name + '=' + this.attributes[i].value + ' ';
            }
            resul += '>';
            result += this.content;

        }

    });
    Object.defineProperty(domElement, 'content', {
        //check if there are no child
        set: function (value) {
            this._content = value;
        }

    });


    Object.defineProperty(domElement, 'appendChild', {
        value: function (child) {
            this._children.push(child);

        }
    });
    Object.defineProperty(domElement, 'addAtribute', {
        value: function (name, value) {
            if (name === '' || !isNumberLetterOrDash(name)) {
                throw Error('The type of the element must be non emtpy string with digits, letters and dashes');
            }
            var attribute = {
                name: name,
                value: value
            };
            this.attributes.push(attribute);

        }
    });
    Object.defineProperty(domElement, 'removeAttribute', {
        value: function (attribute) {
            for (var i = 0; i < this.attributes.length; i++) {
                if (attribute.name === this.attributes[i].name && attribute.value === this.attributes[i].value) {
                    this.attributes.splice(i, 1);
                }
            }
        }
    });


}());
var children = (function () {
    var childre = {};

}());/**
 * Created by Aleksandra on 6/26/2015.
 */
