/**
 Problem 8. Replace tags

 Write a JavaScript function that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
 */
var text='<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';
console.log(replaceTags(text));
function replaceTags(text)
{
    var index= 0,
        result='',
        isA=0;
  for(var ind=0,len=text.length;ind<len;ind+=1)
  {
      if(text[ind]==='<' && text[ind+1]==='a')
      {
          result+='[URL';
          ind+=7;
          isA=1;
      }
      if(isA===1 && text[ind]==='>')
      {
          result+=']';
          ind+=1;
          isA=0;
      }
      if(text[ind]==='<' && text[ind+1]==='/' && text[ind+2]==='a')
      {
          result+='[/URL]';
          ind+=4;
      }
      result+=text[ind];
  }
    return result;

}