/**
 Problem 11. String format

 Write a function that formats a string using placeholders.
 The function should work with up to 30 placeholders and all types.
 Examples:

 var str = stringFormat('Hello {0}!', 'Peter');
 //str = 'Hello Peter!';

 var frmt = '{0}, {1}, {0} text {2}';
 var str = stringFormat(frmt, 1, 'Pesho', 'Gosho');
 //str = '1, Pesho, 1 text Gosho'
 */
function stringFormat()
{

var string=arguments[0];

 for(var i=1;i<arguments.length;i+=1)
 {
  var pattern='{'+(i-1)+'\\}';
  var regex=new RegExp(pattern,'g');
  string=string.replace(regex,arguments[i]);
 }
 return string;
}
var str = stringFormat('Hello {0}!', 'Peter');
console.log(str);
var frmt = '{0}, {1}, {0} text {2}';
var str1 = stringFormat(frmt, 1, 'Pesho', 'Gosho');
console.log(str1);