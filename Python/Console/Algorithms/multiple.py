# Check if a number is a multiple of 3 and/or 7
attempts = 3
print(f"You have {attempts} attempts")
while attempts > 0:
    try:
        print("Enter a number:")
        number = int(input())
        break
    except ValueError:
            print("You have not entered a number!!!")
            attempts -= 1
            print(f"You have {attempts} attempts")
            
if attempts == 0:
    print("Bye!!!")
    quit()

match (number % 3, number % 7):
    case (0, 0):
        print(f"Number: {number} is multiple of 3 and 7")
    case (0, _):
        print(f"Number: {number} is multiple of 3")
    case (_, 0):
        print(f"Number: {number} is multiple of 7")
    case _:
        print(f"Number: {number} is neither multiple of 3 or 7")
