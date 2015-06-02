/**
 Problem 10. Find palindromes

 Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".
 */
function reverseString(string)
{
    var i,result='';
    for(i=string.length-1;i>=0;i-=1){
        result+=string[i];
    }
    return result;
}
var text='ABBA,ahahahhaha lamal, exe.Exeeeeeee';
function getAllPalindromes(text)
{
    var regex=/[.' ',]/,
        words=text.split(regex),
        ind,
        count,
        result=[];
    for(ind=0,count=words.length;ind<count;ind+=1)
    {
        if(words[ind]===reverseString(words[ind]) && words[ind]!=='')
        {
result.push(words[ind]);
        }
    }
    return result;

}
console.log(getAllPalindromes(text));