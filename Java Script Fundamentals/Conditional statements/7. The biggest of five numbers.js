/**
 Problem 7. The biggest of five numbers

 Write a script that finds the greatest of given 5 variables.
 Use nested if statements.
 */
var numbers=[2,12,9,11,10];
console.log(max(numbers));
function max(numbers)
{
var max=Math.max();
  if(numbers[0]>max)
  {
      max=numbers[0];
  }
  if(numbers[1]>max)
  {
      max=numbers[1];
  }
    if(numbers[2]>max)
    {
        max=numbers[2];
    }
    if(numbers[3]>max)
    {
        max=numbers[3];
    }
    if(numbers[4]>max)
    {
        max=numbers[4];
    }

return max;
}