/**
 Problem 4. Has property

 Write a function that checks if a given object contains a given property.

 var obj  = …;
 var hasProp = hasProperty(obj, 'length');
 */
function hasProperty(obj,property)
{
    for(var key in obj)
    {
     if(key===property)
     {
         return true;
     }

    }
    return false;
}
var objTrue={count:3, length:50};
var length="length";
console.log("The objTrue has lenght-->"+hasProperty(objTrue,length));
var objFalse={count:2, len:3};
console.log("The objFalse has lenght-->"+hasProperty(objFalse,length));