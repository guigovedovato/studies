class Library:
    
    def __init__(self, listOfBooks):
        self.availableBooks = listOfBooks
    
    def displayAvailableBooks(self):
        print("Available Books: ")
        print()
        for book in self.availableBooks:
            print(book)
    
    def lendBook(self, requestedBook):
        if requestedBook in self.availableBooks:
            print("You have now borrowed the book")
            self.availableBooks.remove(requestedBook)
        else:
            print("Sorry, the book is not available")
    
    def addBook(self, returnedBook):
        self.availableBooks.append(returnedBook)
        print("You have returned the book, thanks")
