import os
from library import Library
from person import Person
from customer import Customer
from student import Student


def final():
    print()
    print("Press Enter to return")
    input()
    
    
def cls():
    os.system('cls')
    
    
def choice(name):
    while True:
        cls()
        print(f"{name} make your choice:", end="\n\n")
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


cls()
print(f"The library purpose is: - {Library.purpose()}")
input()

library = Library([f"Book {b}" for b in range(1, 11)])

cls()
print(f"Is there anyone in library? - {Person.is_in_action()}")
input()

cls()
userName = input("Enter your name: ")
if not userName:
    course = input("Enter your course: ")
    customer = Student("Student", course)
else:
    customer = Customer(userName)

print(customer)
input()

cls()
print(f"Is there anyone in library? - {Person.is_in_action()}")
input()

cls()    
print(f"You can borrow {customer.max_reading_books} books at time")
input()

while True:
    match choice(customer.name):
        case 1:
            cls()
            library.display_available_books()
            final()
        case 2:
            cls()
            if customer.is_reading:
                requestedBook = customer.request_book()
                library.lend_book(requestedBook)
            else:
                print(f"You are reading {customer.reading_books} book(s) at moment")
            final()
        case 3:
            cls()
            if customer.has_borrowed:
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
