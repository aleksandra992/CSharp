/**
 Problem 2. Numbers not divisible

 Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time
 */
var N=100;
notDivisible(N);
function notDivisible(N)
{
    for(var ind=1;ind<=N;ind++)
    {
        if(ind%(3*7))//3 and 7 are co-prime so we can check with 3*7 instead of checking with 3 and with 7
        {
            console.log(ind);
        }
    }
}