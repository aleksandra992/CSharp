/**
 * Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
 Use Array#reduce
 Use only array methods and no regular loops (for, while)
 */
var people=[{ firstname: 'Pesho0',
 lastname: 'Peshov0',
 age: 5,
 gender: 'male' },
 { firstname: 'Pesho0',
  lastname: 'Peshov1',
  age: 1,
  gender: 'male' },
 { firstname: 'Pesho2',
  lastname: 'Peshov2',
  age: 2,
  gender: 'female' },
 { firstname: 'Pesho2',
  lastname: 'Peshov3',
  age: 3,
  gender: 'male' },
 { firstname: 'Pesho4',
  lastname: 'Peshov4',
  age: 4,
  gender: 'male' },
 { firstname: 'Pesho4',
  lastname: 'Peshov5',
  age: 5,
  gender: 'female' },
 { firstname: 'Pesho6',
  lastname: 'Peshov6',
  age: 6,
  gender: 'male' },
 { firstname: 'Pesho6',
  lastname: 'Peshov7',
  age: 7,
  gender: 'female' },
 { firstname: 'Pesho8',
  lastname: 'Peshov8',
  age: 8,
  gender: 'male' },
 { firstname: 'Pesho8',
  lastname: 'Peshov9',
  age: 9,
  gender: 'male' }];

function getGroupsByName(people)
{

 var result= people.reduce(function(obj,person,index){
if(obj[person.firstname]===undefined)
{
 obj[person['firstname']]=[person];
}  else
 obj[person['firstname']].push(person);
  return obj;
 },{});
 return result;
}
console.log(getGroupsByName(people));