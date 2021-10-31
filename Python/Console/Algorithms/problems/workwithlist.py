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
print("Frequency of the elements in the List : ", ctr)

# Generate all permutations of a list
print(list(itertools.permutations([1,2,3])))

# Remove duplicates from a list
a = [10,20,30,20,10,50,60,40,80,50,40]
print(set(a))

# Second smallest number in a list
a = [1, 2, -8, -2, 0]
print(sorted(a)[1])
