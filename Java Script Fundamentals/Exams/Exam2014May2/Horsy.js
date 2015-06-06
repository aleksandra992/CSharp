/**
 * Created by Aleksandra on 6/4/2015.
 */
args = [
    '3 5',
    '54361',
    '43326',
    '52188',
];


console.log(solve(args));
function solve(params)
{
    var numRows=params[0].split(' ')[0];
    var numCols=params[0].split(' ')[1];
    var a=['1','1','3'];
    var b= a.map(Number);

    var directions=[];
    var counter,
        count= 0,
        row,
        col,
        jumps=0;
    for(var i=0;i<numRows;i++)
    {
       var numbers=params[i+1].split('').map(Number);
       directions[i]=numbers;
    }
    var matrix=[];
    for(var i=0;i<numRows;i++)
    {
        matrix[i]=[];
        counter=Math.pow(2,i);

        for(var j=0;j<numCols;j++)
        {
            matrix[i][j]=counter;
            counter-=1;

        }
    }
    row=numRows-1;
    col=numCols-1;
    while(true)
    {
        count+=matrix[row][col];
       matrix[row][col]=false;
        switch(directions[row][col])
        {
            case 1: row-=2; col+=1;break;
            case 2:col+=2; row-=1; break;
            case 3: col+=2; row+=1;break;
            case 4: row+=2; col+=1;break;
            case 5: row+=2; col-=1;break;
            case 6:col-=2; row+=1; break;
            case 7:col-=2;row-=1; break;
            case 8: row-=2; col-=1; break;



        }
        if(row<0 || row>(numRows-1) || col<0 || col>(numCols-1))
        {
            return 'Go go Horsy! Collected '+ count +' weeds';
        }
        if(matrix[row][col]===false)
        {
            return 'Sadly the horse is doomed in '+(jumps+1)+' jumps';
        }

        jumps+=1;
    }
}