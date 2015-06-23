/**
 * Created by Aleksandra on 6/4/2015.
 */

solve(['110', '19','29','39']);
function solve(params) {
    var s = params[0], c1 = params[1], c2 = params[2], c3 = params[3];
    var answer = 0;
    // Your solution here
    var c1Count=Math.floor(s/c1),
        c2Count=Math.floor(s/c2),
        c3Count=Math.floor(s/c3),
        maxSum=Math.max(),
        sum=0;
for(var i=0;i<=c1Count;i+=1)
{
    for(var j=0;j<=(s-c1*i)/c2;j+=1)
    {
        for(var k=0;k<=(s-c2*j-c1*i)/c3;k++)
        {
            if((i*c1 +j*c2+k*c3)<=s)
            {
                sum=i*c1 +j*c2+k*c3;
            }
            if(sum>maxSum)
            {
                maxSum=sum;
            }
        }
    }
}
    answer=maxSum;
    console.log(answer);
}
