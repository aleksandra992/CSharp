/**
 Problem 6. Most frequent number

 Write a script that finds the most frequent number in an array.
 */
var array=[4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3];



console.log(mostFrequent(array)[0]+" ("+mostFrequent(array)[1]+" times)");
function maxElement(array) {
    var max=Math.max();
    for(var ind=0;ind<array.length;ind++)
    {
        if(array[ind]>max)
        {
            max=array[ind];
        }
    }
    return max;
}
function mostFrequent(array)
{
    var finalResult=[];
    var max=maxElement(array);
    var result=new Array(max+1);
     for(var i=0;i<result.length;i++)
        {
        result[i]=0;
        }

    var timesCurrent=1;
    var timesMax=Math.max();
    var elementMax;

    for(var ind=0;ind<array.length;ind++)
    {
        result[array[ind]]++;
    }
    var res=result.indexOf(maxElement(result));
    finalResult.push(res,maxElement(result));
    return finalResult;
}

