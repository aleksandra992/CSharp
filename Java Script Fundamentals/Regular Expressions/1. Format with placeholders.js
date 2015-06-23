/**
 Problem 1. Format with placeholders

 Write a function that formats a string. The function should have placeholders, as shown in the example
 Add the function to the String.prototype
 */
String.prototype.format=function(options) {

    var string = this;
    for (var i in options) {


        var pattern = '#{' + (i) + '\\}';
        var regex = new RegExp(pattern, 'g');
        string = string.replace(regex, options[i]);
    }
    return string;
}


var options = {name: 'John'};
console.log('Hello, there! Are you #{name}?'.format(options));

var options = {name: 'John', age: 13};
console.log('My name is #{name} and I am #{age}-years-old'.format(options));