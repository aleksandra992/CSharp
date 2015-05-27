/**
 Problem 3. Occurrences of word

 Write a function that finds all the occurrences of word in a text.
 The search can be case sensitive or case insensitive.
 Use function overloading.
 */
var text="telerik Erik erika erik ";
var word="erik";
var IsSensitive=true;
console.log(occurrencesOfWord(text,word,IsSensitive));
console.log(occurrencesOfWord(text,word,!IsSensitive));
function occurrencesOfWord(text,word,isSensitive)
{
    var modifier="ig";
if(isSensitive===true)
{
    modifier="g";
}

    var regexString = '\\b' + word + '\\b';
var regex=new RegExp(regexString,modifier);
    var result=text.match(regex).length;
    return result;
}