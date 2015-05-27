/**
 Problem 8. Trapezoid area

 Write an expression that calculates trapezoid's area by given sides a and b and height h.
 */
var a= 5,b= 6,h=2;
console.log((trapezoidArea(a,b,h)));
function trapezoidArea(a,b,h)
{
    return ((a+b)/2)*h;
}