/**
 Problem 4. Parse tags

 You are given a text. Write a function that changes the text in all regions:

 <upcase>text</upcase> to uppercase.
 <lowcase>text</lowcase> to lowercase
 <mixcase>text</mixcase> to mix casing(random)
 Example: We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.

 The expected result:
 We are LiVinG in a YELLOW SUBMARINE. We dOn'T have anything else.

 Note: Regions can be nested.
 */
var text='Example: We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>.'
    +' We <mixcase>don\'t</mixcase> have <lowcase>anything else.</lowcase><mixcase>We don\'t have anything else.</mixcase> ';


function parseTags(text,myCase) {
    var stringCase = '<' + myCase + '>',
        cloaseStringCase = '</' + myCase + '>',
        indexOfUpcase=-1,
        result = '',
        begin = 0,
        random,
        semiResult;

    while ((indexOfUpcase = text.indexOf(stringCase, indexOfUpcase + 1)) >= 0) {
        result += text.substring(begin, indexOfUpcase);
        if(myCase==='upcase' ) {
            result += text.substring(indexOfUpcase + stringCase.length, text.indexOf(cloaseStringCase, indexOfUpcase)).toUpperCase();
        }
        else if(myCase==="lowcase")
            result += text.substring(indexOfUpcase + stringCase.length, text.indexOf(cloaseStringCase, indexOfUpcase)).toLowerCase();
        else
        {
            semiResult=text.substring(indexOfUpcase + stringCase.length, text.indexOf(cloaseStringCase, indexOfUpcase));
            for(var ind=0;ind<semiResult.length;ind++)
            {
                random=Math.round(Math.random());

                if(random===1)
                result+=semiResult[ind].toUpperCase();
                else
                result+=semiResult[ind].toLowerCase();
            }
        }
        begin = text.indexOf(cloaseStringCase, indexOfUpcase) + cloaseStringCase.length;
        // console.log(text[begin]);
    }
    if (begin < text.length) {
        result += text.substring(begin, text.length);
    }
    return result;

    /*  var regex=new RegExp(/<upcase>(.*)<upcase>/g);
     var parsed,result='';



     while(match=regex.exec(text))
     {

     parsed= text.replace(/<upcase>(.*)<upcase>/,function(){ return match[1].toUpperCase()});
     result+=parsed;

     }
     */


}
var result=parseTags(text,'lowcase');
result=parseTags(result,'mixcase');
result=parseTags(result,'upcase');

console.log(result);
