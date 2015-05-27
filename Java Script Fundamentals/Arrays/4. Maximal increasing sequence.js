/**
 Problem 4. Maximal increasing sequence

 Write a script that finds the maximal increasing sequence in an array
 */
var array = [3, 2, 3, 4, 2, 2, 4];
console.log(maxIncreasingSeq(array));
function maxIncreasingSeq(array) {
    'use strict';
    var tempArr = [], result = [array[0]];


 for (var ind=0;ind<array.length-1;ind++)
 {

 if(array[ind]<array[ind+1])
 {
  tempArr.push(array[ind+1]);
 }
  else
 {
  tempArr=[array[ind+1]];
 }
  if(tempArr.length>result.length)
  {
   result=tempArr.slice();
  }
 }
 return result;
}