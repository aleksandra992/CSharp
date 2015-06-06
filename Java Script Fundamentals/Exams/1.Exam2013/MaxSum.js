/**
 * Created by Aleksandra on 6/4/2015.
 */


function Solve(params) {
    var N = parseInt(params[0]);
    var answer = 0;
    var max=Math.max();
    var sum=0;
    if(params[0]==='1')
    {
        return Number(params[1]);
    }
    for(var i=1;i<=N;i++)
    {

        sum+=Number(params[i]);
        if(sum>max)
        {
            max=sum;
        }
        for(var j=i+1;j<=N;j++)
        {


            sum+=Number(params[j]);
            if(sum>max)
            {
                max=sum;
            }


        }
        sum=0;
    }
    answer=max;
    // Your code here...
    return answer;
}
var args=['2','-9','-8'];
console.log(Solve(args));
