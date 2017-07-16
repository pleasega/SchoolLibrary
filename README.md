# SchoolLibrary
A basic school library program, includes lending and returning with Access DB.

## Installation
1. Extract the folder from the compressed file to a discrete directory/location and set a shortcut to the desktop.
2. Install required [dependencies](#dependencies).
3. Add library books to the database through Microsoft Access.
4. Encrypt Access DB with a desired password and set the password and path to the database file in the program config file under `accessDBPath` and `passphrase`.

## Dependencies<a name="dependencies"></a>
1. [Microsoft Access Database Engine 2010 Redistributable](https://www.microsoft.com/en-us/download/details.aspx?id=13255) (Only 32-bit version works NOT 64-bit)

## Access Database Query Scripts
* **Show Active Borrows**

Displays all current books being borrowed, which are not yet returned.

* **Show Book Borrow History**

Displays all past and current borrows and borrow information for a particular book.

* **Show Books Information**

Displays all books' information including the quantity and currently borrowed quantity.

* **Show Student Active Borrows**

Displays all current book borrows and borrow information for a particular student.

* **Show Student Borrow History**

Displays all past and current borrows and borrow information for a particular student.

## Todo List
* Fix any reported bugs and implement any enhancement suggestions.
