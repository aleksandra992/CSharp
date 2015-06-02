/**
 Problem 1. Reverse string

 Write a JavaScript function that reverses a string and returns it.
 */
var string="Pesho Peshov";
console.log(reverseString(string));
function reverseString(string)
{
    var i,result='';
    for(i=string.length-1;i>=0;i-=1){
        result+=string[i];
    }
    return result;
}