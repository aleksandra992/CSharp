//Problem 2. Divisible by 7 and 5

//Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.
var number1=35, number2=25;
console.log(isDivisible(number1));
console.log(isDivisible(number2));

function isDivisible(number)
{
    if (!number%(7*5))
    {
        return true;
    }
    return false;
}