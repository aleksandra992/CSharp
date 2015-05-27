/**
 Problem 9. Point in Circle and outside Rectangle

 Write an expression that checks for given point P(x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).
 */
var pointTrue=[3,3];
var pointFalse=[1,1];

console.log(isInsideCircle(pointTrue[0],pointTrue[1],0,0,5) && isOutsideRectangle(pointTrue[0],pointTrue[1],2,-2,-2,2));
console.log(isInsideCircle(pointFalse[0],pointFalse[1],0,0,5) && isOutsideRectangle(pointFalse[0],pointFalse[1],2,-2,-2,2));
function isInsideCircle(x,y,cx,cy,r)
{
    return (x - cx) * (x - cx) + (y - cy) * (y - cy) < r * r;
}
function isOutsideRectangle(x,y,top,bottom,left,right)
{
    if(x>=left && x<=right && y<=top && y>=bottom)
    {
return false;
    }
    return true;
}