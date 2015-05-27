/**
 Problem 5. Appearance count

 Write a function that counts how many times given number appears in given array.
 Write a test function to check if the function is working correctly.
 */
var array=[1,2,4,6,5,7,4,6,7,8,4];
var number=4;
console.log(countAppearance(number,array));
function countAppearance(number,array)
{
    var count=0;
 for(var i=0;i<array.length;i+=1)
 {
     if(array[i]===number)
     {
         count+=1
     }
 }

  return count;
}