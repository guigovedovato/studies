from person import Person

class Customer(Person):
        
    def __init__(self, name):
        super().__init__(name)
        self._maxReadingBooks = 2
        self.__booksReading = 0
    
    def requestBook(self):
        self.__setNumberOfReadingBooks()
        print("Enter the book name: ", end = ' ')
        self.book = input()
        return self.book
    
    def returnBook(self):
        self.__releaseNumberOfReadingBooks()
        print("Enter the book name which is returning: ", end = ' ')
        self.book = input()
        return self.book
    
    def getReadingBooks(self):
        return self.__booksReading
    
    def checkReadingBooks(self):
        return self.__booksReading < self._maxReadingBooks
    
    def checkBorrowedBooks(self):
        return self.__booksReading > 0
    
    def __setNumberOfReadingBooks(self):
        self.__booksReading += 1
        
    def __releaseNumberOfReadingBooks(self):
        self.__booksReading -= 1
