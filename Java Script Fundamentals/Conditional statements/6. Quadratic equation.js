/**
 Problem 6. Quadratic equation

 Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
 Calculates and prints its real roots.
 Note: Quadratic equations may have 0, 1 or 2 real roots.
 */
var a=-0.5, b=4, c=-8;
console.log(realRoots(a,b,c));
a=5,b=2,c=8;
console.log(realRoots(a,b,c));
function realRoots(a,b,c)
{
    var x=Math.pow(b,2) - (4 * a * c);
    var result=[];
    if(x<0)
    {
        return "No real roots";

    }
   else {

        result[0]= (b*(-1) + Math.sqrt(x)) / (2 * a);
        result[1] = (b*(-1) - Math.sqrt(x)) / (2 * a);
        if(result[0]==result[1])
        return "x1=x2="+result[0];
        else
       return "x1="+result[0]+"x2="+result[1];
    }
   // return result;

}