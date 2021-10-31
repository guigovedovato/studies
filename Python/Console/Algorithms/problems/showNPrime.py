from math import sqrt
import common


def is_prime(x):
    if x < 2:
        return False
    for i in range(2, int(sqrt(x)) + 1):
        if x % i == 0:
            return False
    return True


print("Enter a number to show the prime numbers in the range")

attempts = 3

try:
    number = common.enter_number(attempts)
except ValueError as e:
    print(e)
    quit()

#Comprehensions
print([x for x in range(number) if is_prime(x)])
