/**
 Problem 3. The biggest of Three

 Write a script that finds the biggest of three numbers.
 Use nested if statements.
 */
var numbers=[5,3,8];
var anotherNumners=[9,3,5];
console.log("The biggest number of "+numbers+ " is "+theBiggestOfThree(numbers) );
console.log("The biggest number of "+anotherNumners+ " is "+theBiggestOfThree(anotherNumners) );
function theBiggestOfThree(numbers)
{
    var max;
    if(numbers[0]>numbers[1])
    {
        if(numbers[0]>numbers[2])
        {
            max=numbers[0];
        }
        else
       max=numbers[2];

    }
    else
    {
        if(numbers[1]>numbers[2])
        max=numbers[1];
        else
        max=numbers[2];
    }
    return max;
}