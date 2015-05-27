//open index.html and see the result in the console
console.log('window');
getMin(window);
getMax(window);
console.log('navigator');
getMin(navigator);
getMax(navigator);
console.log('document');
getMin(document);
getMax(document);
function getMin(obj){
    var min;
    var flag=0;

    for(var property in obj){
        if(flag===0)
        {
            min=property;
            flag=1;
        }
        if(property < min){
            min = property;
        }


    }

    console.log('The min is: ' + min);

}
function getMax(obj){
    var max;
    var flag=0;

    for(var property in obj){
        if(flag===0)
        {
            max=property;
            flag=1;
        }
        if(property > max){
            max = property;
        }


    }

    console.log('The max is: ' + max);

}
