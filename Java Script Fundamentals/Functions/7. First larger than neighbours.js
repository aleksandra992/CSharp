/**
 Problem 7. First larger than neighbours

 Write a function that returns the index of the first element in array that is larger than its neighbours or -1, if there’s no such element.
 Use the function from the previous exercise.
 */
 var arr=[1,2,3,4,5,3,6,3,7,3];
 console.log("The index of the first element larger than the neightbours is "+firstLarger(arr));
function firstLarger(array)
{
    for(var ind=0;ind<array.length;ind++)
    {
        if(largerThanNeightbours(array,ind))
        {
            return ind;
        }

    }
    return -1;
}
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