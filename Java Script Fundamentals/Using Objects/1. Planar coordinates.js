/**
 Problem 1. Planar coordinates

 Write functions for working with shapes in standard Planar coordinate system.
 Points are represented by coordinates P(X, Y)
 Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))
 Calculate the distance between two points.
 Check if three segment lines can form a triangle.
 */
function point(xx,yy)
{
    var point= {
        x: xx,
        y: yy
    }
    return point;
}
function line(bPoint,ePoint)
{
    var line={
        beginPoint:bPoint,
    endPoint:ePoint
    }
return line;
}
function distanceBetweenTwoPoints(first,second)
{
    return Math.sqrt(Math.pow(first.x-second.x,2)+Math.pow(first.y-second.y,2));
}

var f=point(3,4);
var s=point(4,5);
console.log("The distance between f and s is "+distanceBetweenTwoPoints(f,s));

function canFormTriangle(firstLine,secondLine,thirdLine)
{
    var a=distanceBetweenTwoPoints(firstLine.beginPoint,firstLine.endPoint);
    var b=distanceBetweenTwoPoints(secondLine.beginPoint,secondLine.endPoint);
    var c=distanceBetweenTwoPoints(thirdLine.beginPoint,thirdLine.endPoint);
    if(((a+b)>c) && ((b+c)>a) && ((a+c)>b))
    {
        return true;
    }
    return false;
}
var a=line(f,s);
var b=line(f,s);
var c=line(f,s);
b1=line(0,0);
console.log(canFormTriangle(a,b,c)==true?"You can form a triangle with a, b and c":"You cannot form a triangle with a,b and c");
console.log(canFormTriangle(a,b1,c)==true?"You can form a triangle with a, b1 and c":"You cannot form a triangle with a,b1 and c");