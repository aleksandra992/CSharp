/**
 Problem 2. Multiplication Sign

 Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
 Use a sequence of if operators.
 */
var positive=5, negative=-5;
console.log(sign(negative,positive,positive));
console.log(sign(positive,negative,negative));
console.log(sign(positive,positive,positive));
console.log(sign(negative,negative,negative));
function sign(a,b,c)
{
    var result="";
    if(a<0) {
        if (b < 0) {
            if (c < 0) {
                result = "-";

            }
            else
                result = "+";

    }
        else
        {
            if(c<0)
            {
                result="+";
            }
            else
            result="-";
        }

    }
    else
    {
        if (b < 0) {
            if (c < 0) {
                result = "+";

            }
            else
                result = "-";

        }
        else
        {
            if(c<0)
            {
                result="-";
            }
            else
                result="+";
        }
    }
    return result;
}