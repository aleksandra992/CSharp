/**
 Problem 6. Larger than neighbours

 Write a function that checks if the element at given position in given array of integers is bigger than its two neighbours (when such exist).
 */
var array=[1,2,3,5,4,5,6,7,3,8];
var position=3;
console.log(largerThanNeightbours(array,position));
function largerThanNeightbours(array,position)
{
    if(position<=0 || position>=array.length-1)
    return false;
    else
    {
        if(array[position]>array[position+1] && array[position]>array[position-1])
        {
            return true;

        }
    }
    return false;
}