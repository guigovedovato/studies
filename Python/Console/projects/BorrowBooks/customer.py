from person import Person


class Customer(Person):

    def __init__(self, name):
        super().__init__(name)
        self._books_reading = 0
        self._max_reading_books = 2
    
    def request_book(self):
        self._set_number_of_reading_books()
        self.book = input("Enter the book name: ")
        return self.book  
    
    def return_book(self):
        self._release_number_of_reading_books()
        self.book = input("Enter the book name which is returning: ")
        return self.book  
    
    @property
    def reading_books(self):
        return self._books_reading   
    
    @property
    def is_reading(self):
        return self._books_reading < self._max_reading_books
    
    @property
    def has_borrowed(self):
        return self._books_reading > 0  
    
    @property
    def max_reading_books(self):
        return self._max_reading_books  
    
    def _set_number_of_reading_books(self):
        self._books_reading += 1
              
    def _release_number_of_reading_books(self):
        self._books_reading -= 1