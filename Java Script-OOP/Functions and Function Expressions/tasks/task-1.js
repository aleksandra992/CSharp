/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	

*/

function sum(array) {
	if(array===undefined)
	{
		throw Error();
	}
	if(array.length===0)
	{
		return null;
	}
	array=array.map(Number);
	var resultSum=array.reduce(function(sum,s)
	{
		s=Number(s);
		if(isNaN(s))
		{
			throw Error();
		}
		sum+=s;
		return sum;
	});
return resultSum;
	
}
console.log(sum(['1','2',3]));
module.exports = sum;