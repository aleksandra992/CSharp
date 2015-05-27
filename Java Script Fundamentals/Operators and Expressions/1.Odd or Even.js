//Problem 1. Odd or Even

//Write an expression that checks if given integer is odd or even.

var even= 2;
var odd=3;
console.log(isEven(even));
console.log(isEven(odd));


function isEven(number)
{
    if(Math.abs(number%2===0))
    {
        return true;
    }
    return false;
}

