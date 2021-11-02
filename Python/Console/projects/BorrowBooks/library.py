class Library:  
    
    def __init__(self, books):
        self._available_books = books
    
    def display_available_books(self):
        print("Available Books: ", end="\n\n")
        print(", ".join(self._available_books))
    
    def lend_book(self, requested_book):
        if requested_book in self._available_books:
            print("You have now borrowed the book")
            self._available_books.remove(requested_book)
        else:
            print("Sorry, the book is not available")
    
    def add_book(self, returned_book):
        self._available_books.append(returned_book)
        print("You have returned the book, thanks")
        
    @staticmethod
    def purpose():
        return "Library purpose is borrow books"
