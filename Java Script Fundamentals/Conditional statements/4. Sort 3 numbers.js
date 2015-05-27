/**
 * Problem 4. Sort 3 numbers
 Sort 3 real values in descending order.
 Use nested if statements.
 */
var numbers=[5,2,10];
console.log(mySort(numbers));
console.log(mySort(numbers));

function mySort(numbers)
{
    var first=numbers[0],second=numbers[1],third=numbers[2];
    var result=[];

    if(first>second)
    {
        if(second>third)
        {
            result.push(first,second,third);
        }
        else
        if(first>third)
        {
            result.push(first,third,second);
        }
        else
        result.push(third,first,second);

    }
    else
    {
        if(first>third)
        {
            result.push(second,first,third);
        }
        else
        if(second>third)
        result.push(second,third,first);
        else
        result.push((third,second,first));
    }
    return result;
}