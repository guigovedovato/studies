# Create a random range of numbers and pick 1
from random import sample, randrange

def randomValues(number):
    values = sample(range(1, 101), k=randrange(100))

    for v in sorted(values):
        if v == number:
            print(f"{number} is mine as well, we have the same thoughts!!!")
            break
    else:
        print(f"Oh no! I picked {randrange(100)}")

attempts = 3
print(f"You have {attempts} attempts")
while attempts > 0:
    try:
        print("Pick a number between 1 and 100:")
        choice = int(input())
        break
    except ValueError:
            print("You have not picked a number!!!")
            attempts -= 1
            print(f"You have {attempts} attempts")

if attempts == 0:
    print("Bye!!!")
    quit()

if choice >= 1 and choice <= 100:
    randomValues(choice)
else:
    print(f"Oh no! Your number {choice} is not between 1 and 100")
