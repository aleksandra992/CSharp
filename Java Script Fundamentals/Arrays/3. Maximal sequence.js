/**
 Problem 3. Maximal sequence

 Write a script that finds the maximal sequence of equal elements in an array.
 */
var arr=[2,1,1,1, 1, 1, 2, 3, 3,3, 2, 2, 2,2, 1];
var semiResult=maxSequence(arr);
var result=[];
    for(var i=0;i<semiResult[1];i++)
    {
        result.push(semiResult[0]);
    }
console.log(result);
//return array with two element in which
// the first is the number that has the longest sequence and the second is the size of the longest sequence
function maxSequence(arr)
{
    var maxCount=0;
    var bestElement=0;
    var currentCount=1;
   var result=[];
    for(var ind=0;ind<arr.length-1;ind++)
    {
        if(arr[ind]===arr[ind+1]) {
            currentCount++;
        }
        else
        {
            currentCount=1;
        }
        if (currentCount > maxCount) {
            maxCount = currentCount;
            bestElement = arr[ind];
        }

    }
    result.push(bestElement,maxCount);
    return result;

}