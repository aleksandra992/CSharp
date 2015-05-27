/**
 Problem 8. Number as words

 Write a script that converts a number in the range [0…999] to words, corresponding to its English pronunciation.
 */
var a=22;
console.log(numberAsWord(a));
    function numberAsWord(number) {
        var result=[];
        var proba="";
    var hundredsArr = ["One hundred", "Two hundred", "Three hundred", "Four hundred", "Five hundred", "Six hundred", "Seven hundred", "Eight hundred", "Nine hundred"];
    var tensArr = ["twenty", "thirthy", "fourthy", "fifthy", "sixty", "seventy", "eighty", "ninety"];
    var onesArr = ["zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"];
    var and = "and";
    if(number<20)
    {
        return onesArr[number];
    }
    if(number>=20 && number<100)
    {
        var indTens=Math.floor(number/10)-2;

        result.push(tensArr[indTens],(number%10==0)?"":onesArr[number%10]);

    }
    if(number>=100 && number<1000)
    {
        var hundreds=Math.floor(number/100);
        var tens=Math.floor((number%100)/10);
        var ones=Math.floor((number % 100)%10);
        if(tens==1)
        {
            result.push( hundredsArr[number/10 - 1], and , onesArr[number%100]);
        }
        else
        {
            result.push(hundredsArr[hundreds - 1], and, ((tens) == 0 ? "" : tensArr[tens - 2])  , ((ones == 0) ? "" : onesArr[ones]));
        }
    }
        return proba;
}