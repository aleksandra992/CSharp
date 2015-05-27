/**
 Problem 2. Lexicographically comparison

 Write a script that compares two char arrays lexicographically (letter by letter).
 */
var first = ['a', 'b', 'c'];
var second = ['a', 'b', 'd'];
switch (compareLexi(first,second))
{
    case 1:
        console.log(first+" is bigger than "+second);
        break;
    case 2:
        console.log(second+" is bigger than "+first);
        break;
    default:
        console.log("They are equal");
}
function compareLexi(first,second)
{
if(first.length<second.length)
{
    return 2;
}
else
if(first.length>second.length)
{
    return 1;
}
    else
{
    for(var ind=0;ind<first.length;ind++)
    {
        if(first[ind]>second[ind])
        {
            return 1;
        }
        else if(first[ind]<second[ind])
        {
            return 2;
        }


    }
    return 0;
}
}


