/* Task Description */
/*
 * Create an object domElement, that has the following properties and methods:
 * use prototypal inheritance, without function constructors
 * method init() that gets the domElement type
 * i.e. `Object.create(domElement).init('div')`
 * property type that is the type of the domElement
 * a valid type is any non-empty string that contains only Latin letters and digits
 * property innerHTML of type string
 * gets the domElement, parsed as valid HTML
 * <type attr1="value1" attr2="value2" ...> .. content / children's.innerHTML .. </type>
 * property content of type string
 * sets the content of the element
 * works only if there are no children
 * property attributes
 * each attribute has name and value
 * a valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes (-)
 * property children
 * each child is a domElement or a string
 * property parent
 * parent is a domElement
 * method appendChild(domElement / string)
 * appends to the end of children list
 * method addAttribute(name, value)
 * throw Error if type is not valid
 * // method removeAttribute(attribute)
 */

/* Example

 var meta = Object.create(domElement)
 .init('meta')
 .addAttribute('charset', 'utf-8');

 var head = Object.create(domElement)
 .init('head')
 .appendChild(meta)

 var div = Object.create(domElement)
 .init('div')
 .addAttribute('style', 'font-size: 42px');

 div.content = 'Hello, world!';

 var body = Object.create(domElement)
 .init('body')
 .appendChild(div)
 .addAttribute('id', 'cuki')
 .addAttribute('bgcolor', '#012345');

 var root = Object.create(domElement)
 .init('html')
 .appendChild(head)
 .appendChild(body);

 console.log(root.innerHTML);
 Outputs:
 <html><head><meta charset="utf-8"></meta></head><body bgcolor="#012345" id="cuki"><div style="font-size: 42px">Hello, world!</div></body></html>
 */


function solve() {
    var domElement = (function () {

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
                return (isNumberOrLetter(char) || char === '-');
            });

        }

        var domElement = {
            init: function (type) {
                this.type = type;
                this.content = '';
                this.attributes = [];
                this.children = [];
                this.parent = null;
                return this;

            },
            appendChild: function (child) {
                if (typeof child !== 'string') {
                    child.parent = this;
                }
                this.children.push(child);
                return this;
            },
            addAttribute: function (name, value) {
                if (name === '' || !isNumberLetterOrDash(name)) {
                    throw Error('The type of the element must be non emtpy string with digits, letters and dashes');
                }

                var attribute = {
                    name: name,
                    value: value
                };
                var indexAttr;
                var attributeExist = this.attributes.some(function (item,index) {
                    indexAttr=index;
                    return item.name === name;
                });
                if (attributeExist) {
                    this.attributes[indexAttr]=attribute;
                }
                else
                {
                    this.attributes.push(attribute);
                }
                return this;
            },
            removeAttribute: function (attribute) {
                var flag = true;
                for (var i = 0; i < this.attributes.length; i++) {
                    if (attribute === this.attributes[i].name) {
                        this.attributes.splice(i, 1);
                        flag = false;
                    }
                }
                if (flag === true) {
                    flag = false;
                    throw Error('The attribute doesn\'t exist');
                }
                return this;
            },
            get innerHTML() {
                var sorted = this.attributes.sort(function (a, b) {
                    if (a.name < b.name) {
                        return -1;
                    }
                    else
                        return 1;
                });
                var innerHtml = '<' + this.type;
                for (var i = 0; i < sorted.length; i++) {
                    var attribute = sorted[i];
                    innerHtml += ' ' + attribute.name + '="' + attribute.value + '"';
                }
                innerHtml += '>';

                for (var i = 0; i < this.children.length; i++) {
                    var child = this.children[i];
                    if (typeof child === 'string') {
                        innerHtml += child
                    }
                    else {
                        innerHtml += child.innerHTML;
                    }
                }
                innerHtml += this.content;
                innerHtml += '</' + this.type + '>';
                return innerHtml;
            }


        };
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
        Object.defineProperty(domElement, 'content', {
            set: function (value) {
          if(!this.children||this.children.length===0)
                this._content = value;
            },
            get: function () {
                return this._content;

            }

        });
        return domElement;
    }());
    return domElement;
}
module.exports = solve;
var domElement = solve();

var meta = Object.create(domElement)
    .init('meta')
    .addAttribute('charset', 'utf-8');

var head = Object.create(domElement)
    .init('head')
    .appendChild(meta)

var div = Object.create(domElement)
    .init('div')
    .addAttribute('style', 'font-size: 42px');

div.content = 'Hello, world!';

var text = 'Some text here, doesn\'t really matter that much what it is.',
    root = Object.create(domElement).init('p');
root.content = text;
console.log(root.innerHTML);
//expect(root.innerHTML).to.eql('<p>' + text + '</p>');


