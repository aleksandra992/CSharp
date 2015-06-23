/**
 * Created by Aleksandra on 6/6/2015.
 */
function solve(input) {
    var finalResult;
    var functions = [];
    for (var i = 0; i < input.length; i += 1) {
        var currentRow = input[i].trim();
        var operator = '';
        var nestedOperator = '';
        var parameters = [];
        var nestedParameters = [];
        var currentDigit = '';
        var currentFunctionName = '';
        var currentNewFunction;

        var nestedResult;
        var inCommand = false;
        var inNestedCommand = false;

        for (var j = 0; j < currentRow.length; j += 1) {
            var currentSymbol = currentRow[j];


            if ((currentSymbol === ' ' || currentSymbol === ')')) {
                if (currentFunctionName !== '') {
                    if (functions[currentFunctionName]!==undefined) {
                        var functionResult = functions[currentFunctionName];
                        if (inNestedCommand === true) {
                            nestedParameters.push(functionResult);

                        }
                        else {
                            parameters.push(functionResult);
                        }
                    }
                    else
                    {
                        currentNewFunction=currentFunctionName;

                    }
                    currentFunctionName = '';
                }
                if (currentDigit !== '') {

                    if (inNestedCommand === true) {
                        nestedParameters.push((parseInt(currentDigit)));

                    }
                    else {
                        parameters.push(parseInt(currentDigit));
                    }
                    currentDigit = '';
                }
                if(currentSymbol===')' && currentNewFunction!='')
                {

                    var result;
                    if(inNestedCommand)
                    {
                        result=calculate(nestedOperator,nestedParameters);

                    }
                    else {
                        result = calculate(operator, parameters);

                    }
                    if (result === 'Error') {
                        return 'Division by zero! At Line:' + (i + 1);
                    }
                    if(currentNewFunction!=='def')
                    {
                        functions[currentNewFunction]=result;
                        currentNewFunction='';

                    }


                }
                if (currentSymbol === ')') {
                    if (inNestedCommand === true) {
                        nestedResult = calculate(nestedOperator, nestedParameters);
                        if (nestedResult === 'Error') {
                            return 'Division by zero! At Line:' + (i + 1);
                        }

                        parameters.push(nestedResult);

                        inNestedCommand = false;
                        nestedParameters = [];
                        nestedOperator = '';


                    }
                    continue;
                }

                continue;
            }
            if (isMathOperator(currentSymbol)) {
                if ((j + 1) < currentRow.length
                    && isNumber(currentRow[j + 1])) {
                    currentDigit += currentSymbol;
                    continue;
                }
                if (inNestedCommand === true) {
                    nestedOperator = currentSymbol;
                }
                else
                    operator = currentSymbol;
                continue;
            }

            if (isNumber(currentSymbol)) {
                if (currentFunctionName != '') {
                    currentFunctionName += currentSymbol;
                }
                else
                    currentDigit += currentSymbol;

                continue;
            }
            if (currentSymbol === '(') {
                if (inCommand === true) {
                    inNestedCommand = true;
                }
                else
                    inCommand = true;
                continue;

            }
            currentFunctionName += currentSymbol;


        }

        finalResult=calculate(operator,parameters);
        if (finalResult === 'Error') {
            return 'Division by zero! At Line:' + (i + 1);
        }

    }
    return finalResult;
    function isMathOperator(symbol) {
        if (symbol === '+' || symbol === '-' || symbol === '*' || symbol === '/') {
            return true;
        }
        return false;
    }

    function isNumber(symbol) {
        if (symbol == ' ') {
            return false;
        }
        return (symbol == Number(symbol));
    }

    function calculate(operator, parameters) {
        if (parameters.length === 1) {
            return parameters[0];
        }
        result = parameters[0];
        for (var i = 1; i < parameters.length; i++) {
            switch (operator) {
                case '+':
                    result += parameters[i];
                    break;
                case '-':
                    result -= parameters[i];
                    break;
                case '*':
                    result *= parameters[i];
                    break;
                case '/':
                    if (parameters[i] === 0)
                        return 'Error';
                    result /= parameters[i];

                    break;
            }
        }
        return parseInt(result);
    }



}



var second=[
        '(def myFunc 5 )',
        '(def myFun (+  myFunc  myFunc 2 ))',
        '(def MyFunc (* 2  myFun))',
        '(/   MyFunc  myFunc)'
],
    third=[
        '(def func 10)',
        '(def newFunc (+  func 2))',
        '(def sumFunc (+ func func newFunc 0 0 0))',
        '(* sumFunc 2)',
],
    fourth=[
    '(def func (+ 5 2))',
    '(def func2 (/  func 5 2 1 0))',
    '(def func3 (/ func 2))',
    '(+ func3 func)'
];
//console.log(solve(first));
console.log(solve(second));
console.log(solve(third));
console.log(solve(fourth));