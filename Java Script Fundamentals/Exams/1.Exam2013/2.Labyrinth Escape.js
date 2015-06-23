/**
 * Created by Aleksandra on 6/4/2015.
 */
function solve(params)
{
    var numRows=params[0].split(' ')[0];
    var numCols=params[0].split(' ')[1];
    var directions=[],
        matrix=[],
        row=Number(params[1].split(' ')[0]),
        col=Number(params[1].split(' ')[1]),
        sum= 0,
        numCell=0;


        counter=1
    for(var i=0;i<numRows;i++)
    {
        directions[i]=params[i+2].split('');
    }
    for(var j=0;j<numRows;j++)
    {matrix[j]=[];
        for(var k=0;k<numCols;k++)
        {
            matrix[j][k]=counter;
            counter++;

        }
    }
    while(true)
    {
        counter++;
        sum+=matrix[row][col];
        numCell++;
        matrix[row][col]=0;
        if(directions[row][col]==='l')
        {
            col-=1;
        }
        else
        if(directions[row][col]==='r')
        col+=1;
        else
        if(directions[row][col]==='u')
        {
            row-=1;
        }
        else if(directions[row][col]==='d')
        row+=1;

        if(row>(numRows-1) || row<0 || col>(numCols-1) || col<0)
        {
            return 'out '+sum;
        }
        if(matrix[row][col]===0)
        {
            return "lost "+numCell;
        }


    }

}
args =[
    "5 8",
    "0 0",
    "rrrrrrrd",
    "rludulrd",
    "durlddud",
    "urrrldud",
    "ulllllll"];



console.log(solve(args));