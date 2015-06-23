/**
 * Created by Aleksandra on 6/6/2015.
 */
function Solve(params) {
    var N = parseInt(params[0]);
    var answer = 0;
    var numbers=params.map(Number);
    for(var i=1;i<N;i+=1)
    {
        if(numbers[i]>numbers[i+1])
        {
            answer+=1;
        }
    }
    answer+=1;

    // Your code here...
    return answer;
}
var args=['7','1','2','-3','4', '4','0','1'];
console.log(Solve(args));
var args1=['9','1','8', '8','7','6','5','7','7','6'];
console.log(Solve(args1));