/**
 Problem 3. Deep copy

 Write a function that makes a deep copy of an object.
 The function should work for both primitive and reference types.
 */
function deepCopy(obj) {
    if(obj === null || typeof(obj) !== 'object')
        return obj;

    var temp = {};

    for(var key in obj) {
        if(Object.prototype.hasOwnProperty.call(obj, key)) {
            temp[key] = deepCopy(obj[key]);
        }
    }
    return temp;
}

Car.prototype.deepCopy=function() {
    if(this === null || typeof(this) !== 'object')
        return this;

    var temp = new Car();

    for(var key in this) {
        if(Object.prototype.hasOwnProperty.call(this, key)) {
            temp[key] = deepCopy(this[key]);
        }
    }
    return temp;
}
function Car(color,price ) {

    if (!(this instanceof Car)) {
        return new Car(color, price);
    }

    this.color = color;
    this.price = price;
}
Car.prototype.toString=function()
{
    return 'Car{color:' + this.color + ', price' + this.price + '}';
}


console.log(deepCopy("pesho"));
var car=new Car('red','1500$');
var copy=new Car();
copy=car.deepCopy();
console.log(car);
console.log('The original is '+car.toString());
console.log('The deep copy is '+copy.toString());

car.color='blue';
console.log('The original with changed  color toString blue is '+car.toString());
console.log('The deep copy is '+ copy.toString() );
car.color="blue";
