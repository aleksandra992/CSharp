/**
 Problem 1. English digit

 Write a function that returns the last digit of given integer as an English word.
 */
var number=1234;
var string="Aleks";
var result=lastDigitAsWord(number);
if( result===null)
{
    console.log("The input must be number");
}
else
console.log("The last digit of "+number+" is "+result);
function lastDigitAsWord(number)
{
    var lastDigit;
    var result;
    if(typeof(number)==="number"){
        lastDigit=number%10;
        switch (lastDigit)
        {
            case 0: result="zero";
                break;
            case 1: result="one";
                break;
            case 2: result="two";
                break;
            case 3: result="three";
                break;
            case 4: result="four";
                break;
            case 5: result="five";
                break;
            case 6: result="six";
                break;
            case 7: result="seven";
                break;
            case 8: result="eight";
                break;
            case 9: result="nine";
                break;
            default: break;


        }

    }
    else
    result=null;

    return result;

}