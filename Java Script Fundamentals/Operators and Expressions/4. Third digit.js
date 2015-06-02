//Problem 4. Third digit

//Write an expression that checks for given integer if its third digit (right-to-left) is 7.

var number1=324243242,number2 = 34343434797;
console.log(thirdDigit(number1));
console.log(thirdDigit(number2));
function thirdDigit(number)
{
    if(~~(number/100)===0)
    {
        return "The number should be with 3 digits";
    }
    else
    {
        var digit=(~~(number/100))%10;
        if(digit==7 || digit==-7)//for negative numbers
        return true;
        return false;
    }

}