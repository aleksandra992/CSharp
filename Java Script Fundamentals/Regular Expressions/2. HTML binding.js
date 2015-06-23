/**
 Problem 2. HTML binding

 Write a function that puts the value of an object into the content/attributes of HTML tags.
 Add the function to the String.prototype
 */
String.prototype.bind=function(bindingString,string)
{
    var str=bindingString,
        patternClass,
        regexClass,
        regexLink,
        patternLink,
        result='',
        ind;

    for(var i in string) {
        patternClass = 'data-bind-class="' + i + '"';
        regexClass = new RegExp(patternClass, 'g');
        str = str.replace(regexClass, 'class="' + string[i] + '"');
        patternLink = 'data-bind-href="' + i + '"';
        regexLink = new RegExp(patternLink, 'g');

        str = str.replace(regexLink, 'href="' + string[i] + '"');

        if (str.indexOf('data-bind-content="' + i + '"') > 0) {
            ind=str.indexOf(">");
            str=str.substring(0,ind+1)+string[i]+str.substring(ind+1,str.length);
        }
    }
    return str;

}
var str = '<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></a>'
console.log(str.bind(str, {name: 'Elena', link: 'http://telerikacademy.com'}));

var str1 = '<div data-bind-content="name"></div>';
console.log(str1.bind(str1, {name: 'Steven'}));