/**
 * Created by Aleksandra on 6/9/2015.
 */



function solve(params) {

    if (!String.prototype.contains) {
        String.prototype.contains = function (searchPattern) {
            var patternLen = searchPattern.length;
            for (var i = 0, length = this.length - patternLen; i < length; i++) {
                var isMatch = true;
                for (var j = 0; j < patternLen; j+=1) {
                    if (searchPattern[j] !== this[i + j]) {
                        isMatch = false;
                        break;
                    }
                }
                if (isMatch) {
                    return true;
                }
            }
        }
    }
    var s =  Number(params[0]);
    var result = '';
    // Your solution here

    var model = {};
    var templates={};
    for (var i = 0; i < s; i+=1) {
        var propName = '';
        var prop = '';
        propName = params[i + 1].split('-')[0];
        var rightSide = params[i + 1].split('-')[1];
        if (rightSide.indexOf(';') > 0) {
            prop = rightSide.split(';');
        }
        else {
            prop = rightSide;
        }
        model[propName] = prop;
    }
   // console.log(model);
    var numLines=Number(params[s+1]);
   // console.log(numLines);
    var endTemplates=0;
    for(var h=params.length-1;h>=0;h-=1)
    {
        if(params[h].indexOf('</nk-template>')>=0)
        {
            endTemplates=h;
            break;
        }
    }
    //console.log(endTemplates);
for(var j=s+2;j<endTemplates;j++) {
    var currentLine = params[j];
    var index=currentLine.indexOf('<nk-template');

if(index>=0)
{
    var templateName=currentLine.split('"')[1];
    currentLine=params[j+1];
    templates[templateName]=[];
 while(currentLine.indexOf('</nk-template>')<0)
 {

     templates[templateName].push(currentLine);
     j++;
     currentLine=params[j+1];
 }
    j--;
}




}
    //console.log(templates);
    var len=params.length;
    var start;
    if(endTemplates===0)
    {
        start=s+2;
    }
    else
    start=endTemplates+1;
    for(var row=start;row<len;row+=1)
    {
        var current=params[row];
        if(current.indexOf('{{')>=0)
        {
            var indexOFBrackets=current.indexOf("{{");
            var indexOfCloseBrackets=current.indexOf("}}",indexOFBrackets);
            result+=current.substring(0,indexOFBrackets);
            result+=current.substring(indexOFBrackets+2,indexOfCloseBrackets);
            result+=current.substring(indexOfCloseBrackets+2);

            result+='\n';
            continue;
        }
        //'<nk-if condition="showSubtitle">',
        //'<h2><nk-model>subTitle</nk-model></h2>',
        ////    '<div>{{<nk-model>subTitle</nk-model>}} ;)</div>',
          //  '</nk-if>',
        if(current.indexOf('<nk-if')>=0) {
            var indexConditionEnd = current.indexOf('condition="') + 'condition="'.length;
            var condition = current.substring(indexConditionEnd, current.indexOf('"', indexConditionEnd));
            row += 1;
            current = params[row];
            if (model[condition] === 'true') {

                while (current.indexOf('</nk-if>') < 0) {

                    if (current.indexOf('{{') >= 0) {
                        var indexOFBrackets = current.indexOf("{{");
                        var indexOfCloseBrackets = current.indexOf("}}", indexOFBrackets);
                        result += current.substring(0, indexOFBrackets);
                        result += current.substring(indexOFBrackets + 2, indexOfCloseBrackets);
                        result += current.substring(indexOfCloseBrackets + 2);

                        result += '\n';
                        row += 1;
                        current = params[row];
                        continue;
                    }
                    if (current.indexOf('<nk-template') >= 0) {
                        var indexOfTemplate = current.indexOf('render="') + 'render="'.length;
                        var templateName = current.substring(indexOfTemplate, current.indexOf('"', indexOfTemplate));
                        result += templates[templateName].join('\n') + '\n';
                        row += 1;
                        current = params[row];
                        continue;

                    }
                    if (current === '' || current === '\n' || current === ' ') {
                        result += '\n';
                        row += 1;
                        current = params[row];
                        continue;
                    }

                    if (current.indexOf('<nk-model') >= 0) {
                        var indexOfModel = current.indexOf('<nk-model>');
                        var indexOfModelName = current.indexOf('<nk-model>') + '<nk-model>'.length;
                        var modelName = current.substring(indexOfModelName, current.indexOf('<', indexOfModelName));
                        result += current.substring(0, indexOfModel);
                        var n = current.substr(current.indexOf('</nk-model>') + '</nk-model>'.length);

                        result += model[modelName];
                        result += n;
                        result += '\n';
                        row += 1;
                        current = params[row];
                        continue;
                    }

                    row += 1;
                    current = params[row];
                    result += current + '\n';


                }
            }
            else
            {
                while(current.indexOf('</nk-if>') < 0)
                {
                    row += 1;
                    current = params[row];

                }
            }
            continue;
        }

        if(current.indexOf('<nk-repeat')>=0)
        {
            var itemsName=current.split('"')[1].split(' ')[2];
            var itemName=current.split('"')[1].split(' ')[0];
            row += 1;
            current = params[row];
            var pomRow=row;

            for (var st = 0; st < model[itemsName].length; st+=1) {
                row=pomRow;
                current=params[row];
                while (current.indexOf('</nk-repeat>') < 0) {

                    if (current.indexOf('{{') >= 0) {
                        var indexOFBrackets = current.indexOf("{{");
                        var indexOfCloseBrackets = current.indexOf("}}", indexOFBrackets);
                        result += current.substring(0, indexOFBrackets);
                        result += current.substring(indexOFBrackets + 2, indexOfCloseBrackets);
                        result += current.substring(indexOfCloseBrackets + 2);

                        result += '\n';
                        row += 1;
                        current = params[row];
                        continue;
                    }
                    if (current.indexOf('<nk-template') >= 0) {
                        var indexOfTemplate = current.indexOf('render="') + 'render="'.length;
                        var templateName = current.substring(indexOfTemplate, current.indexOf('"', indexOfTemplate));
                        result += templates[templateName].join('\n') + '\n';
                        row += 1;
                        current = params[row];
                        continue;

                    }
                    if (current === '' || current === '\n' || current === ' ') {
                        result += '\n';
                        row += 1;
                        current = params[row];
                        continue;
                    }

                    if (current.indexOf('<nk-model') >= 0) {
                        var indexOfModel = current.indexOf('<nk-model>');
                        var indexOfModelName = current.indexOf('<nk-model>') + '<nk-model>'.length;
                        var modelName = current.substring(indexOfModelName, current.indexOf('<', indexOfModelName));
                        result += current.substring(0, indexOfModel);
                        var n = current.substr(current.indexOf('</nk-model>') + '</nk-model>'.length);
                        if(modelName===itemName)
                        {

                               var name= model[itemsName][st];
                            result+=name;

                        }
                        else
                        result += model[modelName];
                        result += n;
                        result += '\n';
                        row += 1;
                        current = params[row];
                        continue;
                    }

                    result += current + '\n';
                    row += 1;
                    current = params[row];



                }


                    current = params[row];

                }

            continue;
            }


        if(current.indexOf('<nk-template')>=0)
        {
            var indexOfTemplate=current.indexOf('render="')+'render="'.length;
            var templateName=current.substring(indexOfTemplate,current.indexOf('"',indexOfTemplate));
            result+=templates[templateName].join('\n')+'\n';
            continue;

        }
        if(current==='' || current==='\n' || current===' ')
        {
            result+='\n';
            continue;
        }

       if(current.indexOf('<nk-model')>=0)
        {
            var indexOfModel=current.indexOf('<nk-model>');
            var indexOfModelName=current.indexOf('<nk-model>')+'<nk-model>'.length;
            var modelName=current.substring(indexOfModelName,current.indexOf('<',indexOfModelName));
            result+=current.substring(0,indexOfModel);
            var n=current.substr(current.indexOf('</nk-model>')+'</nk-model>'.length);

            result+=model[modelName];
            result+=n;
            result+='\n';

            continue;
        }
        

        result+=current+'\n';



    }

return result;

}




var test=[
    '0',
    '15',
    '<div>',
    '<p>',
    '{{<nk-if condition="pesho">}}',
'{{escaped}} dude',
'</p>',
'<p>',
'{{<nk-template render="pesho">}}',
'</p>',
'<p>',
'{{<nk-repeat for="pesho in peshos">}}',
'{{escaped}} in comment',
'</p>',
'</div>'
]

var test1=[
   '6',
   'title-Telerik Academy',
   'showSubtitle-true',
   'subTitle-Free training',
   'showMarks-false',
   'marks-3;4;5;6',
'students-Ivan;Gosho;Pesho',
'42',
'<nk-template name="menu">',
    '<ul id="menu">',
    '<li>Home</li>',
    '<li>About us</li>',
'</ul>',
'</nk-template>',
'<nk-template name="footer">',
    '<footer>',
    'Copyright Telerik Academy 2014',
'</footer>',
'</nk-template>',
'<!DOCTYPE html>',
'<html>',
'<head>',
'<title>Telerik Academy</title>',
'</head>',
'<body>',
'<nk-template render="menu" />',
'',
    '<h1><nk-model>title</nk-model></h1>',
'<nk-if condition="showSubtitle">',
    '<h2><nk-model>subTitle</nk-model></h2>',
'<div>{{<nk-model>subTitle</nk-model>}} ;)</div>',
'</nk-if>',
'',
'<ul>',
    '<nk-repeat for="student in students">',
        '<li>',
        '<nk-model>student</nk-model>',
        '</li>',
        '<li>Multiline <nk-model>title</nk-model></li>',
    '</nk-repeat>',
    '</ul>',
    '<nk-if condition="showMarks">',
       '<div>',
       '<nk-model>marks</nk-model>',
       '</div>',
       '</nk-if>',
'',
'<nk-template render="footer" />',
        '</body>',
        '</html>',
'',
];
console.log(solve(test));