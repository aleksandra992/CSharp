/**
 Problem 4. Number of elements

 Write a function to count the number of div elements on the web page

 Start index.html click the button and see the result in the console
 */




function countElements(type) {

 var count = document.getElementsByTagName(type).length;
 console.log(count);
 return count;

}