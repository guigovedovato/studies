# Factorial
def fact(n):
    
    # Base Case
    if n == 0:
        return 1
    
    else:
        return n * fact(n-1)


print("The Factorial of '5' is:",fact(5))

# Write a recursive function which takes an integer and computes the cumulative sum of 0 to that integer.add()
def rec_sum(n):
    
    # Base Case
    if n == 0:
        return n
    
    else:
        return n + rec_sum(n-1)


print("The sum of '4' is:",rec_sum(4))

# Given an integer, create a function which returns the sum of all the individual digits in that integer.
# For example: if n = 4321, return 4+3+2+1
def sum_func(n):
    
    # Base Case
    if len(str(n)) == 1:
        return n
    
    else:
        return n%10 + sum_func(n//10)


print("The sum of all the individual digits for '4321' is:",sum_func(4321))

# word split
def word_split(phrase,list_of_words,output=None):
    
    if output == None:
        output = []
    
    for word in list_of_words:
        if phrase.startswith(word):
            output.append(word)
            return word_split(phrase[len(word):],list_of_words,output)
    
    return output

p = "themanran"
l = ["clown","ran","man"]
print(f"For phrase {p} and list {l}:",word_split(p,l))
p = "ilovedogsJohn"
l = ["i","am","a","dogs","lover","love","John"]
print(f"For phrase {p} and list {l}:",word_split(p,l))

# factorial Memoization
## dictionaire
factorial_memo = {}

def factorial(k):
    
    if k < 2:
        return 1
    
    if not k in factorial_memo:
        factorial_memo[k] = k * factorial(k-1)
    
    return factorial_memo[k]


print("The Factorial of '4' is:",factorial(4))

## Memoize class
class Memoize:
    def __init__(self,f):
        self.f = f
        self.memo = {}
    def __call__(self,*args):
        if not args in self.memo:
            self.memo[args] = self.f(*args)
        return self.memo[args]


def fact_memo(k):
    
    if k < 2:
        return 1
    
    return k * factorial(k-1)


factorial_object = Memoize(fact_memo)
print("The Factorial of '4' is:",factorial_object(4))

# Reverse string using recursion
def reverse(s):
    
    # Base Case
    if len(s) <= 1:
        return s
    
    # Recursion
    return reverse(s[1:]) + s[0]


w = "Hello World"
print(f"Reverse of '{w}' is:", reverse(w))

# String Permutation
def permute(s):
    
    out = []
    
    # Base Case
    if len(s) == 1:
        out = [s]
    else:
        for i,let in enumerate(s):
            for perm in permute(s[:i]+s[i+1:]):
                out += [let+perm]
                
    return out


w = "abc"
print(f"Permutation of '{w}' is:", permute(w))
w = "abcD"
print(f"Permutation of '{w}' is:", permute(w))

# Coin Change
def rec_coin(target,coins,known_results):
    
    min_coins = target
    
    if target in coins:
        known_results[target] = 1
        return 1
    elif known_results[target] > 0:
        return known_results[target]
    else:
        for i in [c for c in coins if c<=target]:
            num_coins = 1 + rec_coin(target-i,coins,known_results)
            if num_coins < min_coins:
                min_coins = num_coins
                known_results[target] = min_coins
    
    return min_coins


target = 74
coins = [1,5,10,25]
known_results = [0]*(target+1)
print(f"Minimum amount for {target} with {coins} coins is:",rec_coin(target,coins,known_results))
