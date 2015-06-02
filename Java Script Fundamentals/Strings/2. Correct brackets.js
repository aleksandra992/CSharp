/**
 Problem 2. Correct brackets

 Write a JavaScript function to check if in a given expression the brackets are put correctly.
 Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b))..
 */

var incorrect=')(a+b))';
var correct='(a+b)+(c+d)';
console.log(bracketCorrect(incorrect));
console.log(bracketCorrect(correct));
function bracketCorrect(expression)
{
    if(numberOfChars(expression,'(')!==numberOfChars(expression,')'))
        {
            return false;
        }
    else
        return true;
}
    function numberOfChars(string,char)
    {
        var index=string.indexOf(char),
            count=0;
        while(index>=0)
        {
            count++;
            index=string.indexOf(char,index+1);

        }
        return count;
    }