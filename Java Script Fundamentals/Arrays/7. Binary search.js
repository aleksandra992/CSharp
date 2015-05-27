/**
 Problem 7. Binary search

 Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm.
 */
var arr=[1,3,6,7,8,12,15,18,20];
console.log(binarySearch(arr,3,0,arr.length-1));
console.log(binarySearch(arr,1,0,arr.length-1));
console.log(binarySearch(arr,8,0,arr.length-1));
console.log(binarySearch(arr,20,0,arr.length-1));
console.log(binarySearch(arr,15,0,arr.length-1));
function binarySearch(array,element,min,max)
{
 if(max<min)
 {
  return -1;
 }
 var result;
 if(element===array[min+Math.floor((max-min)/2)])
 {

  return min+Math.floor((max-min)/2);

 }
 else
 if(element<array[min+Math.floor((max-min)/2)])
 {
  return binarySearch(array,element,min,(Math.floor(max/2)));
 }
 else
 {
  return binarySearch(array,element,min+Math.floor((max-min)/2)+1,max);
 }

}