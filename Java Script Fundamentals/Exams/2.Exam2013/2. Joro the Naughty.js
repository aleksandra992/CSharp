/**
 * Created by Aleksandra on 6/6/2015.
 */
function solve(params) {
    var numRows = Number(params[0].split(' ')[0]),
        numCols = Number(params[0].split(' ')[1]),
        numJumps =0,
        row = Number(params[1].split(' ')[0]),
        col = Number(params[1].split(' ')[1]),
        directions = params.slice(2),
        sum= 0,
        counter = 1,
        nextRow,
        nextCol,
        len;
    var matrix = [];
    for (var i = 0; i < numRows; i++) {
        matrix[i] = [];
        for (var j = 0; j < numCols; j++) {
            matrix[i][j] = counter;
            counter += 1;
        }
    }
    while(true) {
        for (var i = 0, len = directions.length; i < len; i += 1) {
            sum += matrix[row][col];
            matrix[row][col] = 0;
            nextRow = row + Number(directions[i].split(' ')[0]);
            nextCol = col + Number(directions[i].split(' ')[1]);
            if (nextRow > numRows - 1 || nextRow < 0 || nextCol > numCols - 1 || nextCol < 0) {
                return "escaped " + sum;
            }
            if (matrix[nextRow, nextCol] === 0) {
                return "caught " + i + 1;
            }
            row = nextRow;
            col = nextCol;

        }
    }


}
var args=['6 7 3','0 0','2 2','-2 2','3 -1'];
console.log(solve(args));