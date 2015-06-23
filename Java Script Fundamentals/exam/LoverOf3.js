/**
 * Created by Aleksandra on 6/10/2015.
 */

function solve(params)
{
    var result=0;
    var numRows=Number(params[0].split(' ')[0]);
    var numCols=Number(params[0].split(' ')[1]);
    var n=Number(params[1]);
var matrix=[];
    var counterCol=0;
    var counterRow=0;
    var flag=1;
    for(var i=numRows-1;i>=0;i-=1)
    {
        matrix[i]=[];
        flag=1;
        for(var j=0;j<numCols;j+=1)
        {
            matrix[i][j]=counterCol;
            counterCol+=3;
            if(flag===1) {
                counterRow = counterCol;
                flag=0;
            }
        }
        counterCol=counterRow;
    }


var row=numRows-1;
    var col=0;
    var r=matrix[row][col];
    result+=r;
    matrix[row][col]=0;

    for(var i=2;i<2+n;i++)
    {
        var direction=params[i].split(' ')[0];
        var jumps=params[i].split(' ')[1];
    jumps=jumps-1;
        while(jumps!=0) {
            if (direction === 'UR' || direction === 'RU') {
               var tempRow=row;
                var tempCol=col;
                row-=1;
                col+=1;
                if(row<0 || row>numRows-1 || col<0 || col>numCols-1)
                {
                    row=tempRow;
                    col=tempCol;
                    break;
                }
                else
                {
                    var r=matrix[row][col];
                    result+=matrix[row][col];
                    matrix[row][col]=0;
                }
            }
            if(direction==='UL' || direction==='LU')
            {
                var tempRow=row;
                var tempCol=col;
                row-=1;
                col-=1;
                if(row<0 || row>numRows-1 || col<0 || col>numCols-1)
                {
                    row=tempRow;
                    col=tempCol;
                    break;
                }
                else
                {
                    result+=matrix[row][col];
                    matrix[row][col]=0;
                }
            }
            if(direction==='DL' || direction==='LD')
            {
                var tempRow=row;
                var tempCol=col;
                row+=1;
                col-=1;
                if(row<0 || row>numRows-1 || col<0 || col>numCols-1)
                {
                    row=tempRow;
                    col=tempCol;
                    break;
                }
                else
                {
                    result+=matrix[row][col];
                    matrix[row][col]=0;
                }
            }
            if(direction==='DR' || direction==='RD')
            {
                var tempRow=row;
                var tempCol=col;
                row+=1;
                col+=1;
                if(row<0 || row>numRows-1 || col<0 || col>numCols-1)
                {
                    row=tempRow;
                    col=tempCol;
                    break;
                }
                else
                {
                    result+=matrix[row][col];
                    matrix[row][col]=0;
                }
            }
            jumps-=1;
        }

    }



    return result;
}


var test1=['6 7','5','UR 5','RD 2','DL 3','LU 6','DR 5'];
var test2=[
    '2 2',
    '10',
    'UR 2',
    'LD 100',
    'DR 500',
    'UL 500',
    'UL 5',
    'LD 120',
    'RD 123',
    'LU 321',
    'UR 2',
    'LD 100'

];
var test3=[
    '3 3',
    '4',
    'UR 22',
    'DL 2',
    'DR 8',
    'UL 75'

];
console.log(solve(test1)===150);
console.log(solve(test2)===6);
console.log(solve(test3)===30);