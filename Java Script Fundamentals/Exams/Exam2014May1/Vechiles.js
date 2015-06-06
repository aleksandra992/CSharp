/**
 * Created by Aleksandra on 6/3/2015.
 */
function solve(params) {
    var s = params[0];

    var count = 0;
    var carWheels= 4,
        truckWheels=10,
        trickWheels= 3,
        cars=Math.floor(s/carWheels),
        trucks=Math.floor(s/truckWheels),
        tricks=Math.floor(s/trickWheels),
        numWheels;

    for(var trick= 0;trick<=tricks;trick++)
    {
        for(var car=0;car<=cars;car++)
        {
            for(var truck=0;truck<=trucks;truck++)
            {
                numWheels=trick*trickWheels+car*carWheels+truck*truckWheels;
                if(numWheels===parseInt(s))
                {
                    count+=1;
                }
            }
        }
    }




    // Your solution here
    console.log(count);
}
var input=['40']
solve(input);/**
 * Created by Aleksandra on 6/6/2015.
 */
