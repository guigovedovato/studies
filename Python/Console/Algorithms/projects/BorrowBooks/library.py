class Library:  
    
    def __init__(self, listOfBooks):
        self._availableBooks = listOfBooks
    
    def display_available_books(self):
        print("Available Books: ")
        print()
        for book in sorted(self._availableBooks):
            print(book)
    
    def lend_book(self, requestedBook):
        if requestedBook in self._availableBooks:
            print("You have now borrowed the book")
            self._availableBooks.remove(requestedBook)
        else:
            print("Sorry, the book is not available")
    
    def add_book(self, returnedBook):
        self._availableBooks.append(returnedBook)
        print("You have returned the book, thanks")
