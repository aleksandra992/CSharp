/**
 Problem 2. People of age

 Write a function that checks if an array of person contains only people of age (with age 18 or greater)
 Use only array methods and no regular loops (for, while)
 */
var people=[{name:'Doncho',age:27},{name:'Pesho',age:18},{name:'Niki',age:25}];


function isOlderThan18(person,index)
{
        return  person.age>=18;
}
function everobodyOlderThan18(people)
{

return people.every(isOlderThan18);

}
console.log(everobodyOlderThan18(people));
