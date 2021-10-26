# Check if a number is a multiple of 3 and/or 7
import common


print("Enter a number and check out if it is mutiple of 3 and/or 7")

attempts = 3

try:
    number = common.enter_number(attempts)
except ValueError as e:
    print(e)
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
