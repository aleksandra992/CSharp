/**
 * Created by Aleksandra on 6/11/2015.
 */
function product(x,a,y,b)
{
    if(a===1 && b===1)
    {
        return x*y;
    }
    else
    {
        var pom=(x*y)*(x*y);
        var result=1;
        while(a>1 && b>1)
        {
            result*=pom;
            a-=2;
            b-=2;

        }
        if(a>=1)
        {
            result*=x;
        }
        if(b==1)
        {
            result*=y;
        }


    }
    return result;
}
console.log(product(2,2,3,5));