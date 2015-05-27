//Problem 6. Point in Circle

//Write an expression that checks if given point P(x, y) is within a circle K(O, 5).

var inside=[2,3],outside=[5,6];
console.log(isInside(inside));
console.log(isInside(outside));
function isInside(point)
{
if(point[0]*point[0]+point[1]*point[1]<5*5)
{
    return true;
}
    return false;
}