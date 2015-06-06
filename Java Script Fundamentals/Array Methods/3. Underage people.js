/**
 Problem 3. Underage people

 Write a function that prints all underaged persons of an array of person
 Use Array#filter and Array#forEach
 Use only array methods and no regular loops (for, while)
 */
var people=[{name:'Doncho',age:27},{name:'Pesho',age:18},{name:'Niki',age:25}];
people.filter(function(person){
    return person.age<20;

}).forEach(function(person)
{
    console.log(person);
});