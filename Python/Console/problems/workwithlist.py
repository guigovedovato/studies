"""
    list  = [,]      - mutable sequences of homogeneous items
    dict  = {"":"",} - mapping object maps hashable values to arbitrary objects
    tuple = (,)      - immutable sequences of heterogeneous data
    set   = {,}      - unordered collection of distinct hashable objects
"""

import collections
import itertools


# Find common items from two lists
color1 = "Red", "Green", "Orange", "White"
color2 = "Black", "Green", "White", "Pink"
# & means INTERSECTION
print(set(color1) & set(color2))

# Find uncommon items from two lists
color1 = "Red", "Green", "Orange", "White"
color2 = "Black", "Green", "White", "Pink"
# - means DIFERENCE
# | means UNION
print(set(color1) - set(color2) | set(color2) - set(color1))

# Get the frequency of the elements in a list
my_list = [10,10,10,10,20,20,20,20,40,40,50,50,30]
print("Original List : ", my_list)
ctr = collections.Counter(my_list)
print("Frequency of the elements in the List: ", ctr)

# Generate all permutations of a list
print(list(itertools.permutations([1,2,3])))

# Show list without duplicates
a = [10,20,30,20,10,50,60,40,80,50,40]
b = set(a)
print(b)

# Second smallest number in a list
a = [1, 2, -8, -2, 0]
print(sorted(a)[1])
a.sort()
print(a[1])

# Create a list of sales based in user entrance
# Add values to the list
num_days = int(input("How many days you had sales? "))
sales_list = [0]*num_days

for v in range(num_days):
    sales_list[v] = int(input(f"Enter the sales for day {v + 1}: "))

print(sales_list)

# Queue Stack Deques
queue = [] # FIFO - First in first out
stack = [] # FILO - First in last out

print("Adding 10 elements:")
for i in range(10):
    print(f"Adding {i} in the queue")
    queue.insert(0, i)
    print(f"Adding {i} in the stack")
    stack.append(i)
    
print("Queue", queue)
print("Stack", stack)

print("Removing elements:")
for i in range(10):
    print(f"Round {i}")
    q = queue.pop()
    print(f"Removed {q} of the queue")
    s = stack.pop()
    print(f"Removed {s} of the stack")

# Missing elements
def finder(arr1,arr2):
    
    # Sort the arays
    arr1.sort()
    arr2.sort()
    
    # zip([1,2,3],[4,5,6])
    # [(1,4),(2,5),(3,6)]
    for num1, num2 in zip(arr1,arr2):
        if num1 != num2:
            return num1
    
    return arr1[-1]


def preferred_finder(arr1,arr2):
    
    d = collections.defaultdict(int)
    
    for num in arr2:
        d[num] += 1
    
    for num in arr1:
        if d[num] == 0:
            return num
        else:
            d[num] -= 1


def xor_finder(arr1,arr2):
    
    result = 0
    
    for num in arr1+arr2:
        result ^= num
    
    return result

arr1 = [1,2,3,4,5,6,7]
arr2 = [3,7,2,1,4,6]
print(finder(arr1,arr2))
print(preferred_finder(arr1,arr2))
print(xor_finder(arr1,arr2))

# largest continuous sum
def largest_cont_sum(arr):
    
    if len(arr) == 0:
        return 0
    
    max_sun = current_sum = arr[0]
    
    for num in arr[1:]:
        current_sum = max(current_sum+num,num)
        max_sun = max(current_sum,max_sun)
    
    return max_sun


arr = [1,2,-1,3,4,10,10,-10,-1]
print(largest_cont_sum(arr))
