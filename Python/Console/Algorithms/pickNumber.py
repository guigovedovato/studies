# Create a random range of numbers and pick 1
from random import sample, randrange
import common

def randomValues(number):
    values = sample(range(1, 101), k=randrange(100))

    for v in sorted(values):
        if v == number:
            print(f"{number} is mine as well, we have the same thoughts!!!")
            break
    else:
        print(f"Oh no! I picked {randrange(100)}")

print("Pick a number between 1 and 100")
attempts = 3
choice = common.EnterNumber(attempts)
if choice >= 1 and choice <= 100:
    randomValues(choice)
else:
    print(f"Oh no! Your number {choice} is not between 1 and 100")
