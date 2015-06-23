/* Task description */
/*
	Write a function that finds all the prime numbers in a range
		1) it should return the prime numbers in an array
		2) it must throw an Error if any on the range params is not convertible to `Number`
		3) it must throw an Error if any of the range params is missing
*/

function findPrimes(begin, end) {
	if(begin===undefined || end===undefined)
	{
		throw Error();
	}
	var primesArray = [];
	primesArray[end+1]=undefined;
    primesArray[0] = true;
	primesArray[1]=true;
	for (var i = 2,len=primesArray.length;i<len; i++)
	{
		for (var j = i; j*i < len; j++)
		{
			primesArray[i*j] = true;
		}
	}

	var result=[];
	for(var i=begin;i<=end;i++)
	{
		if(primesArray[i]!==true)
		{
			result.push(i);
		}
	}
return result;
}

module.exports = findPrimes;
