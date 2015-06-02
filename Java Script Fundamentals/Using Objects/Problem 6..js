/**
 Write a function that groups an array of people by age, first or last name.
 The function must return an associative array, with keys - the groups, and values - arrays with people in this groups
 groups={key:0 value:[person1,person2]}
 Use function overloading (i.e. just one function)

 Example:

 var people = {…};
 var groupedByFname = group(people, 'firstname');
 var groupedByAge= group(people, 'age');
 */
var people =[{firstname:'Gosho', lastname:'Petrov',age:25,fullname:function(){return this.firstname+" "+this.lastname}},
 {firstname:'Bay', lastname: 'Ivan', age: 81,fullname:function(){return this.firstname+" "+this.lastname}},
 {firstname:'Ivaylo', lastname: 'Peshov', age: 35,fullname:function(){return this.firstname+" "+this.lastname}},
 {firstname:'Doncho', lastname: 'Minkov', age: 29,fullname:function(){return this.firstname+" "+this.lastname}},
 {firstname:'Doncho1', lastname: 'Minkov1', age: 29,fullname:function(){return this.firstname+" "+this.lastname}},
 {firstname:'Ivaylo', lastname:'Kenov',age:25,fullname:function(){return this.firstname+" "+this.lastname}}
];

function group(people,criteria)
{
var groups={};

for(var ind in people)
{
 if(groups[people[ind][criteria]]===undefined)
 {
  groups[people[ind][criteria]]=[people[ind]];

 }
 else
 {
groups[people[ind][criteria]].push(people[ind]);
 }

}
return groups;
}
console.log("Age groups")
console.log(group(people,'age'));
console.log("Firstname groups");
console.log(group(people,'firstname'));