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

userName = input("Enter your name:")
if not userName:
    userName = "Camarada"
customer = Customer(userName)

while True:
    match choice(customer.get_name()):
        case 1:
            cls()
            library.display_available_books()
            final()
        case 2:
            cls()
            if customer.check_reading_books():
                requestedBook = customer.request_book()
                library.lend_book(requestedBook)
            else:
                print(f"You are reading {customer.get_reading_books()} book(s) at moment")
            final()
        case 3:
            cls()
            if customer.check_borrowed_books():
                returnedBook = customer.return_book()
                library.add_book(returnedBook)
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
