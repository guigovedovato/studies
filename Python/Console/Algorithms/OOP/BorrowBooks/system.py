import os

from library import Library
from customer import Customer

def final():
    print()
    print("Press Enter to return")
    input()
    
def cls():
    os.system('cls')
    
def choice(name):
    while True:
        cls()
        print(f"{name} make your choice:")
        print()
        print("Enter 1 to display available books")
        print("Enter 2 to request for a book")
        print("Enter 3 to return a book")
        print("Enter 4 to exit")
        try:
            userChoice = int(input())
            break
        except ValueError:
            cls()
            print("You must enter a number")
            final()
    return userChoice

library = Library(["Book 1", "Book 2", "Book 3",])

cls()

print("Enter your name:", end = ' ')
userName = input()
if not userName:
    userName = "Camarada"
customer = Customer(userName)

while True:
    match choice(customer.getName()):
        case 1:
            cls()
            library.displayAvailableBooks()
            final()
        case 2:
            cls()
            if customer.checkReadingBooks():
                requestedBook = customer.requestBook()
                library.lendBook(requestedBook)
            else:
                print(f"You are reading {customer.getReadingBooks()} book(s) at moment")
            final()
        case 3:
            cls()
            if customer.checkBorrowedBooks():
                returnedBook = customer.returnBook()
                library.addBook(returnedBook)
            else:
                print("You have no book to return")
            final()
        case 4:
            cls()
            quit()
        case _:
            cls()
            print("This option is invalid!!!")
            final()
