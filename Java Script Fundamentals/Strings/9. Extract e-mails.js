/**
 Problem 9. Extract e-mails

 Write a function for extracting all email addresses from given text.
 All sub-strings that match the format @… should be recognized as emails.
 Return the emails as array of strings.
 */
var text=' aaaa aa@yahoo.com aaajajajja pecho@gmail.com';
console.log(extractEmails(text));
function extractEmails(text) {
    var result = [],
        startIndex,
        endIndex,
        ind=-1;
   /*  for(ind=0,len=text.length;ind<len;ind+=1)
    {
    if(text[ind]==='@')
    {
        startIndex=text.lastIndexOf(' ',ind);
        endIndex=text.indexOf(' ',ind);
        result.push(text.substring(startIndex+1,endIndex));
        ind=endIndex+1;
    }
}*/
    while((ind=text.indexOf('@',ind+1))>=0){

        startIndex=text.lastIndexOf(' ',ind);
        if((endIndex=text.indexOf(' ',ind))<0)
        endIndex=text.length;
        result.push(text.substring(startIndex+1,endIndex));


    }
    return result;

}