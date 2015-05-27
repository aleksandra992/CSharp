/**
 Problem 2. Reverse number

 Write a function that reverses the digits of given decimal numbe
 */
var number=1234.54;
    console.log(reverse(number));
var num=1234556;
console.log(reverse(num));
function reverse(number)
{
    var result='';
   var strNumber=number.toString();
    for(var i=strNumber.length-1;i>=0;i-=1)
    {
        result+=strNumber[i];
    }
    return result;
}