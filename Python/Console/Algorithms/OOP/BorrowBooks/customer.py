from person import Person


class Customer(Person):
        
        
    def __init__(self, name):
        super().__init__(name)
        self._maxReadingBooks = 2
        self.__booksReading = 0
    
    
    def request_book(self):
        self.__set_number_of_reading_books()
        print("Enter the book name: ", end = ' ')
        self.book = input()
        return self.book
    
    
    def return_book(self):
        self.__release_number_of_reading_books()
        print("Enter the book name which is returning: ", end = ' ')
        self.book = input()
        return self.book
    
    
    def get_reading_books(self):
        return self.__booksReading
    
    
    def check_reading_books(self):
        return self.__booksReading < self._maxReadingBooks
    
    
    def check_borrowed_books(self):
        return self.__booksReading > 0
    
    
    def __set_number_of_reading_books(self):
        self.__booksReading += 1
        
        
    def __release_number_of_reading_books(self):
        self.__booksReading -= 1
