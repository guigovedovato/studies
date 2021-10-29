# FizzBuzz challenge
def fizz_buzz(number):
    mod_3 = number % 3
    mod_5 = number % 5

    match (mod_3, mod_5):
        case (0, 0):
            return "fizzbuzz"
        case (0, _):
            return "fizz"
        case (_, 0):
            return "buzz"
        case _:
            return number


print("FizzBuzz between numbers")

attempts = 3

print(f"You have {attempts} attempts")

while True:
    try:
        first = int(input("Enter the first number:"))
    except ValueError:
            print("You have not entered a number!!!")
            attempts -= 1
            print(f"You have {attempts} attempts")
            continue
    finally:
        if attempts == 0:
            print("Bye!!!")
            quit()
    try:
        last = int(input("Enter the last number:"))
        if last < first:
            print("The last number must be greater than the first")
            attempts -= 1
            print(f"You have {attempts} attempts")
            continue
        break
    except ValueError:
            print("You have not entered a number!!!")
            attempts -= 1
            print(f"You have {attempts} attempts")
    finally:
        if attempts == 0:
            print("Bye!!!")
            quit()
    
print(f"FizzBuzz for numbers from {first} to {last}")

for n in range(first,last+1):
    number = fizz_buzz(n)
    if type(number) is int:
        continue
    print(f"Number {n} = {number}")
