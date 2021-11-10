# Fibonacci

## 1. Through Iterations
def fibo_iter(n):
    
    a,b = 0,1
    
    for i in range(n):
        a,b = b,a+b
    
    return a


print("Fibonacci iteratively for 10:")
print(fibo_iter(10))

## 2. Through Recursion
def fib_rec(n):
    
    # Base Case
    if n <= 1:
        return n
    else:
        return fib_rec(n-1) + fib_rec(n-2)


print("Fibonacci recursively for 10:")
print(fib_rec(10))

## 3. Through Dynamically - Memoization
n = 10
cache = [None]*(n+1)

def fib_dyn(n):
    
    # Base Case
    if n <= 1:
        return n
    
    # Check Cache
    if cache[n] != None:
        return cache[n]
    
    # Keep Setting Cache
    cache[n] = fib_rec(n-1) + fib_rec(n-2)
    
    return cache[n]


print("Fibonacci dynamically for 10:")
print(fib_dyn(n))
