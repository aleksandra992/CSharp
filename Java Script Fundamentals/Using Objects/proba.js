/**
 * Created by Aleksandra on 5/28/2015.
 */
function user(name1,age1)
{
    var user={name:name1,age:age1};
    return user;
}
var u=user("alek",23);
console.log(u);

function User(name,age)
{
    this.name=name;
    this.age=age;
}
var u=new User("alek",23);
console.log(u);

var us={age:5, name:"alek"};
console.log(us);