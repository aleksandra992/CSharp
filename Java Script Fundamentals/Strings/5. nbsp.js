/**
 Problem 5. nbsp

 Write a function that replaces non breaking white-spaces in a text with &nbsp;
 */
var text="aaaaa bb  ccc   ddd  \n   ";
function replaceWhiteSpaces(text)
{
    var regex=new RegExp(' ','g');
    return   text.replace(regex,'&nbsp;');


}
console.log(replaceWhiteSpaces(text));
// Write a function that replaces non breaking whitespaces
// in a text with &nbsp;
