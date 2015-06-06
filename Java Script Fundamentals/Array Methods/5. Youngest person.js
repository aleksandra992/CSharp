/**
 * Write a function that finds the youngest male person in a given array of people and prints his full name
 Use only array methods and no regular loops (for, while)
 Use Array#find
 */
var people=[{ firstname: 'Pesho0',
    lastname: 'Peshov0',
    age: 5,
    gender: 'male' },
    { firstname: 'Pesho1',
        lastname: 'Peshov1',
        age: 1,
        gender: 'male' },
    { firstname: 'Pesho2',
        lastname: 'Peshov2',
        age: 2,
        gender: 'female' },
    { firstname: 'Pesho3',
        lastname: 'Peshov3',
        age: 3,
        gender: 'male' },
    { firstname: 'Pesho4',
        lastname: 'Peshov4',
        age: 4,
        gender: 'male' },
    { firstname: 'Pesho5',
        lastname: 'Peshov5',
        age: 5,
        gender: 'female' },
    { firstname: 'Pesho6',
        lastname: 'Peshov6',
        age: 6,
        gender: 'male' },
    { firstname: 'Pesho7',
        lastname: 'Peshov7',
        age: 7,
        gender: 'female' },
    { firstname: 'Pesho8',
        lastname: 'Peshov8',
        age: 8,
        gender: 'male' },
    { firstname: 'Pesho9',
        lastname: 'Peshov9',
        age: 9,
        gender: 'male' }];

if (!Array.prototype.find) {
    Array.prototype.find = function(callback) {
        var i, len = this.length;
        for (i = 0; i < len; i+=1) {
            if (callback(this[i], i, this)) {
                return this[i];
            }
        }
    }
}


var minAge=people.filter(function(person){
    return person.gender==='male';
})
    .reduce(function(min,person){
        return min>person.age?person.age:min;
    },Math.min());

var youngest = people.filter(function(person){
    return person.gender==='male';
}).find(function(person){return person.age === minAge;});

console.log(youngest.firstname + " " + youngest.lastname)
;
