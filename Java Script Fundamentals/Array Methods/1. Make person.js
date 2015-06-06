/**
 Problem 1. Make person

 Write a function for creating persons.
 Each person must have firstname, lastname, age and gender (true is female, false is male)
 Generate an array with ten person with different names, ages and genders
 */

if (!Array.prototype.fill) {
    Array.prototype.fill = function(callback) {
        var i, len = this.length;
        for (i = 0;i < len; i+=1) {
            this[i] = arguments[0];
        }
        return this;
    };
}
function createPerson(firstname,lastname,age,gender)
{
    if(gender===true)
    {
     return {firstname:firstname,lastname:lastname,age:age,gender:'female'};

    }
    return {firstname:firstname,lastname:lastname,age:age,gender:'male'};
}
var arr=[];
arr[9]=undefined;
arr=arr.fill(1);
arr.forEach(function(element,index,arr){
console.log(createPerson('Pesho'+index,'Peshov'+index,index,!Math.round(Math.random())));


});