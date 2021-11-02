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
print(set(color1) & set(color2))

# Find uncommon items from two lists
color1 = "Red", "Green", "Orange", "White"
color2 = "Black", "Green", "White", "Pink"
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

# Create a list of sales based in user entrance
# Add values to the list
num_days = int(input("How many days you had sales? "))
sales_list = [0]*num_days

for v in range(num_days):
    sales_list[v] = int(input(f"Enter the sales for day {v + 1}: "))

print(sales_list)
