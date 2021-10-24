# FizzBuzz challenge
def fizzbuzz(number):
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

print("FizzBuzz for numbers:")

attempts = 3
print(f"You have {attempts} attempts")
while True:
    print("Enter the first number:")
    try:
        first = int(input())
    except ValueError:
            print("You have not entered a number!!!")
            attempts -= 1
            print(f"You have {attempts} attempts")
            continue
    print("Enter the last number:")
    try:
        last = int(input())
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

if attempts == 0:
    print("Bye!!!")
    quit()
    
print(f"FizzBuzz for numbers from {first} to {last}")

for n in range(first,last+1):
    number = fizzbuzz(n)
    if type(number) is int:
        continue
    print(f"Number {n} = {number}")
