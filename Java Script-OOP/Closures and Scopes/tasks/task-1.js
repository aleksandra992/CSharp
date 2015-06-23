/* Task Description */
/*
 *	Create a module for working with books
 *	The module must provide the following functionalities:
 *	Add a new book to category
 *	Each book has unique title, author and ISBN
 *	It must return the newly created book with assigned ID
 *	If the category is missing, it must be automatically created
 *	List all books
 *	Books are sorted by ID
 *	This can be done by author, by category or all
 *	List all categories
 *	Categories are sorted by ID
 *	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1/
 *	When adding a book/category, the ID is generated automatically/
 *	Add validation everywhere, where possible/
 *	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
 *	Author is any non-empty string/
 *	Unique params are Book title and Book ISBN/
 *	Book ISBN is an unique code that contains either 10 or 13 digits/
 *	If something is not valid - throw Error/
 */
function solve() {
	var library = (function () {
		var books = [];
		var categories = [];
		function Book(book){
			if(typeof book.title!=='string' || book.title.length<2 || book.title.length>100)
			{
				throw'The book title must be between 2 and 100 characters'+book.title.length;
			}
			if(typeof book.author!=='string' || book.author.length===0)
			{
				throw'Author must be non empty string';
			}
			if((book.isbn.length!==13 && book.isbn.length!==10) ||
				!(book.isbn.split('').every(function(digit){
				return digit==Number(digit);
			}))) {
				throw 'ISBN must be a string, containing 10 or 13 digits';
			}
			this.ID=books.length+1;
			this.title=book.title;
			this.author=book.author;
			this.isbn=book.isbn;
			this.category=book.category;

		}
        function Category(name)
        {
        	if (typeof name !== 'string' || name.length < 2 || name.length > 100) {
        		throw 'Category name must be between 2 and 100 characters';
        	}
        	this.name=name;
        	this.ID=categories.length+1;
        	this.books=[];
        }
		function listBooks(properties) {
if(properties===undefined)
{
	return books.sort(function(a,b){
		return a.ID- b.ID;
	});


}
			var copyBooks=books.slice();
			for(var prop in properties){
				copyBooks=copyBooks.filter(function(item){
					return item[prop]===properties[prop];
				});
			}
			return copyBooks.sort(function(a,b){
				return a.ID- b.ID;
			});


		}

		function addBook(book) {
			var newBook,
				newCategory,
				categoryIndex;
			if (books.every(function(item) {
					return (item.title !== book.title &&
					item.isbn !== book.isbn);
				})) {
				newBook = new Book(book);
				books.push(newBook);
			} else {
				throw 'Book titles must be unique';
			}

			if (!categories.some(function(item, index) {
					categoryIndex = index;
					return item.name === book.category;
				})) {
				newCategory = new Category(book.category);
				newCategory.books.push(newBook);
				categories.push(newCategory);
			} else {
				categories[categoryIndex].books.push(newBook);
			}

			return newBook;
		}

		function listCategories() {


			return categories.sort(function(a,b){
				return a.ID- b.ID;
			}).map(function(item){
				return item.name;
			});

		}

		return {
			books: {
				list: listBooks,
				add: addBook
			},
			categories: {
				list: listCategories
			}
		};
	} ());
	return library;
}

module.exports = solve;