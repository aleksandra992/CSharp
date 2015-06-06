/**
 Problem 4. Average age of females

 Write a function that calculates the average age of all females, extracted from an array of persons
 Use Array#filter
 Use only array methods and no regular loops (for, while)
 */
var people=[{ firstname: 'Pesho0',
    lastname: 'Peshov0',
    age: 0,
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

var femalesAges=people.filter(function(person){
    return person.gender==='female';
})
    .reduce(function(ages,person){
        return ages+(person.age);
    },0);



var females=people.filter(function(person){
    return person['gender']==='female';
}).length;





console.log("The average of the females is "+femalesAges/females);
