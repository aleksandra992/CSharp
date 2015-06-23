/**
 * Created by Aleksandra on 6/7/2015.
 */
function Solve(commands) {

    var result;
    for(var i=0;i<commands.length;i++)
    {
        var currentRow=commands[i];
        var currentSymbol='';
        var word='';
        var inDef=false;
        var operator='';
        var inParameters=false;
        var functionName='';
        var parameters=[];
        var currentDigit='';
        var variable='';
        var variables=[];
        for(var j=0;j<currentRow.length;j++)
        {
            currentSymbol=currentRow[j];
            if(word==='def')
            {
                inDef=true;
                word='';
                continue;
            }

                if (isNumber(currentSymbol) && word === '') {
                    currentDigit += currentSymbol;
                    continue;
                }

                if (inParameters === true) {
                    if (currentSymbol === ' ' || currentSymbol === ',') {
                        if (currentDigit != '') {
                            parameters.push(Number(currentDigit));
                            currentDigit = '';
                        }


                    }
                }

                if (currentSymbol === '[') {
                    inParameters = true;
                    if (isOperator(word)) {
                        operator = word;

                        word = '';
                    }

                }
                if (currentSymbol !== ' ' && inParameters === false) {
                    word += currentSymbol;
                    continue;
                }

                if (word != '' && inParameters === false) {
                    functionName = word;
                    word = '';
                }






    }

        console.log(operator);
        console.log(parameters);
        console.log(functionName);
        if(functionName===undefined || functionName==='')
        {
            result=calculate(operator,parameters);

        }
        else {
            if (variables[functionName] === undefined) {
                variables[functionName] = calculate(operator, parameters);
            }
            else
                variables[functionName].push(calculate(operator, parameters));

        }


}
    return result;




function isOperator(operator)
{
    if(operator==='sum' || operator==='max' || operator==='min' || operator==='avg')
    {
        return true;
    }
    else return false;
}
function isNumber(number)
{
    if(number===' ')
    {
        return false;
    }
    return number==Number(number);
}
function calculate(operator,parameters)
{ var result;
    switch (operator)
    {

        case 'sum':{
            var sum=0;
            for(var i=0;i<parameters.length;i++)
            {
                sum+=parameters[i];
            }
            result=sum;
        }break;
        case 'max':{
            var max=Math.max();
            for(var i=0;i<parameters.length;i++)
            {
                if(parameters[i]>max)
                {
                    max=parameters[i];
                }
            }
            result=max;

        }break;
        case 'avg':{
            var sum=0;
            for(var i=0;i<parameters.length;i++)
            {
                sum+=parameters[i];
            }
            result=sum/parameters.length;
        }break;
        case 'min':
        {
            var min=Math.min();
            for(var i=0;i<parameters.length;i++)
            {
                if(parameters[i]<min)
                {
                    min=parameters[i];
                }
            }
            result=min;
        }break;
    }
   return result;
}

    // Your code here...
    //return answer;
}

var first=['def func2 sum[5, 30, 255, 6, 3]'];
console.log(Solve(first));
//console.log(Solve(second));