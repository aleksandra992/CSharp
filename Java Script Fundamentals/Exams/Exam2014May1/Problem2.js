/**
 * Created by Aleksandra on 6/3/2015.
 */
args = [
    '3 5',
    'dr dl dl ur ul',
    'dr dr ul ul ur',
    'dl dr ur dl ur'
];

console.log(solve(args));

function solve(params)
{
    var numRows=params[0].split(' ')[0];
    var numCols=params[0].split(' ')[1];
    var directions=[];
    var matrix=[];
    var counter,
        row= 0,
        col= 0,
        previousRow,
        previousCol,
        count=0;

    for(var i=0;i<numRows;i+=1)
    {
        directions[i]=params[i+1].split(' ');


    }
    for(var j=0;j<numRows;j++)
    {
        matrix[j]=[];
        counter=Math.pow(2,j);
        for(var k=0;k<numCols;k+=1)
        {

            matrix[j][k]=counter;
            counter++;

        }

    }

 while(true)
 {

     count+=matrix[row][col];
     matrix[row][col]=0;
     if(directions[row][col]==='dr')
     {
         row+=1;
         col+=1;
     }
     else
     if(directions[row][col]==='ur')
     {
         row-=1;
         col+=1;
     }
     else
     if(directions[row][col]==='dl')
     {
         row+=1;
         col-=1;
     }
     else
     if(directions[row][col]==='ul')
     {
         row-=1;
         col-=1;
     }

     if(row>=numRows || row<0 || col>=numCols|| col<0)
     {

         return 'successed with '+count;
     }
     if(matrix[row][col]===0)
     {
         return 'failed at ('+row+', '+col+')';
     }

 }


}