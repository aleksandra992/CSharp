/**
 Problem 3. Sub-string in text

 Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).
 Example:

 The target sub-string is in

 The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

 The result is: 9
 */
var text="The text is as follows: We are living in an yellow submarine. " +
    "We don't have anything else. inside the submarine is very tight. " +
    "So we are drinking all the day. We will move out of it in 5 days.";
console.log(numberOfSubStrings(text,'in'));

function numberOfSubStrings(string,subString)
{
    var lowerString=string.toLowerCase();
    var lowerSubString=subString.toLowerCase();
    var index=lowerString.indexOf(lowerSubString);
        count=0;
    while(index>=0)
    {
        count++;
        index=lowerString.indexOf(lowerSubString,index+1);

    }
    return count;
}
