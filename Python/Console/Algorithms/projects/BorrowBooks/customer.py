from person import Person


class Customer(Person):

    def __init__(self, name):
        super().__init__(name)
        self._booksReading = 0  
        self._maxReadingBooks = 2
    
    def request_book(self):
        self._set_number_of_reading_books()
        self.book = input("Enter the book name: ")
        return self.book  
    
    def return_book(self):
        self._release_number_of_reading_books()
        self.book = input("Enter the book name which is returning: ")
        return self.book  
    
    def get_reading_books(self):
        return self._booksReading   
    
    def check_reading_books(self):
        return self._booksReading < self._maxReadingBooks[0]   
    
    def check_borrowed_books(self):
        return self._booksReading > 0  
    
    def _set_number_of_reading_books(self):
        self._booksReading += 1
              
    def _release_number_of_reading_books(self):
        self._booksReading -= 1
