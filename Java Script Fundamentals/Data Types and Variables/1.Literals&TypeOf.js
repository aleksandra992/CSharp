//Problem 1.Assign all the possible JavaScript literals to different variables.
//Problem 3.Try typeof on all variables you created.
//Problem 4. Typeof null
//Create null, undefined variables and try typeof on them.

var number = 5;
var floatNumber = 5.5;
var str = 'Neshto';
var array = [1, 1, 1];
var nullVariable = null;
var undefinedVariable;
var object = {firstName: "Pesho", lastName: "Peshov" };
var func = function () {
    return 0;
};
var all = [number, floatNumber, str, array, nullVariable, undefinedVariable, object, func];

for(var variable in all)
{
    console.log(all[variable]);
}
for(var variable in all)
{
    console.log(typeof(all[variable]));
}
console.log()


