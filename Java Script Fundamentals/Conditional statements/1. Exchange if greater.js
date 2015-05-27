/**
 Problem 1. Exchange if greater

 Write an if statement that takes two double variables a and b and exchanges their values if the first one is greater than the second.
 As a result print the values a and b, separated by a space.
 */
var greater=10, lower=5;
console.log(greaterThan(greater,lower)[0],greaterThan(greater,lower)[1]);
console.log(greaterThan(lower,greater)[0],greaterThan(lower,greater)[1]);
function greaterThan(a,b)
{
    if(a>b)
    {
        var tmp=a;
        a=b;
        b=tmp;
    }
    return[a,b];
}
