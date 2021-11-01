# Fibonacci

## 1. Through Generators
def fibo(num):
    a,b = 0, 1
    for i in range(0, num):
        yield a
        a, b = b, a + b
    

print(list(fibo(10)))

## 2. Through Recursion
def fibonacci_ser(n):
    if(n <= 1):
        return n
    else:
        return(fibonacci_ser(n-1) + fibonacci_ser(n-2))
    
    
n = int(input("Enter number of terms: "))
print("Fibonacci sequence:")
fib = []
for i in range(n):
    fib.append(fibonacci_ser(i))
print(fib)
