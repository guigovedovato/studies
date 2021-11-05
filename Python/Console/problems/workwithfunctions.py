# Function of function
def contruct(a, b):
    def pair(x):
        return x(a,b)
    return pair

def first(pair):
    def x(a,b):
        return a
    return pair(x)

def last(pair):
    def x(a,b):
        return b
    return pair(x)

a = 9
b = 6

print("First:",first(contruct(a,b)))
print("Last:",last(contruct(a,b)))
