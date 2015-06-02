/**
 Problem 5. Youngest person

 Write a function that finds the youngest person in a given array of people and prints his/hers full name
 Each person has properties firstname, lastname and age.

 Example:

 var people = [
 { firstname : 'Gosho', lastname: 'Petrov', age: 32 },
 { firstname : 'Bay', lastname: 'Ivan', age: 81},… ];
 */
var people =[{firstname:'Gosho', lastname:'Petrov',age:32,fullname:function(){return this.firstname+" "+this.lastname}},
            {firstname:'Bay', lastname: 'Ivan', age: 81,fullname:function(){return this.firstname+" "+this.lastname}},
            {firstname:'Pesho', lastname: 'Peshov', age: 35,fullname:function(){return this.firstname+" "+this.lastname}},
             {firstname:'Doncho', lastname: 'Minkov', age: 29,fullname:function(){return this.firstname+" "+this.lastname}},
];
console.log(people[0]);
function youngest(people)
{
for(var key in people) {
    var min = Math.min();
    var youngest;
    if (people[key].age < min) {
        youngest = people[key];
    }


}
    return youngest;
}

console.log("The youngest is: "+youngest(people));
console.log("The youngest is:"+youngest(people).fullname());