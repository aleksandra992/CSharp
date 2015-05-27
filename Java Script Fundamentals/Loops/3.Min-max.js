/**
 Problem 3. Min/Max of sequence

 Write a script that finds the max and min number from a sequence of numbers.
 */
var seq=[8,5,7,4,5,9,2,7,4,10,55,44,33,76,45];

console.log("The max of "+seq+" is "+max(seq));
console.log("The min of "+seq+" is "+min(seq));
function max(seq)
{
    var max=Math.max();
    for(var ind=0;ind<seq.length;ind++)
    {
        if(seq[ind]>max)
        {
            max=seq[ind];
        }
    }
    return max;
}
function min(seq)
{
    var min=Math.min();
    for(var ind=0;ind<seq.length;ind++)
    {
        if(seq[ind]<min)
        {
            min=seq[ind];
        }
    }
    return min;
}