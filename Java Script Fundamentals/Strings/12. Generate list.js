/**
 * Created by Aleksandra on 6/5/2015.
 */

var people = [{name: 'Peter', age: 14},{name:'Pesho',age:15},{name:'Gosho', age:22}];
var template1='<strong>-{name}-</strong> <span>-{age}-</span>';
var template2='<b>-{name}-</b> <italic>-{age}-</italic>';
function generateList(people,template)
{
var list='';
    list+='<ul>';


    for(var person in people)
    {
        list+='<li>';
        list+=template;
        for(var prop in people[person]) {
            var reg=new RegExp('-{'+prop+'\}-','g');
            list = list.replace(reg, people[person][prop]);

        }
        list+='</li>'
    }
    list+='</ul>';
    return list;

}
console.log('Template 1 '+generateList(people,template1));
console.log('Template 2 '+generateList(people,template2));