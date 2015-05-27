/**
 Problem 5. Selection sort

 Sorting an array means to arrange its elements in increasing order.
 Write a script to sort an array.
 Use the selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
 Hint: Use a second arra
 */
var arr=[3,6,2,7,4,9,4,1,7];
console.log(selectionSort(arr));
function selectionSort(array){

    var min;
    for(var i=0;i<array.length;i++)
    {
        min=array[i];
        var ind;
       var tmp;
        for(var j=i;j<array.length;j++)
        {
           if(array[j]<min)
           {
               min=array[j];
               ind=j;

           }
        }
        tmp=array[i];
        array[i]=min;
        array[ind]=tmp;
    }
    return array;
}