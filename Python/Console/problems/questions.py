# Question 1
# You have array of integers, find the first missing positive integer (find the lowest positive integer that does not exist in the array). 
# The array can contain duplicates and negative numbers as well.
# For example, the input [9, 5, -2, 1] should give 2. 
# The input [1, 2, 3] should give 4.
# You can modify the input array in-place.
def first_missing_positive(input):
    positives = [x for x in sorted(set(input)) if x >= 0]
    for p in range(len(positives)):
        try:
            output = positives[p] + 1
            if output != positives[p + 1]:
                break
        except IndexError:
            break
    return output


print("Question 1")
lst = [9, 5, -2, 1]
print(f"For list {lst} the first missing positive integer is:", first_missing_positive(lst))
lst = [1, 2, 3, 3, 2]
print(f"For list {lst} the first missing positive integer is:", first_missing_positive(lst))
lst = [-1, -25, 37, 99, 115]
print(f"For list {lst} the first missing positive integer is:", first_missing_positive(lst))
print()

# Question 2
# You Given a list of numbers, you also given another number named (K).
# Create a function which returns true wehenever any two numbers from the list add up to k.
# For example, if you given [10, 9,8 , 7] and k of 16, return true since 9 + 7 is 16. 
# [1,4,6] and k = 18, return False, because no such two number that their sum equals 18
def add_up_to_k(input, k):
    ordered = sorted(input)
    index = len(ordered)
    response = f"No such two number that their sum equals {k}"
    for f in range(index):
        for s in range(f + 1, index):
            if ordered[f] + ordered[s] == k:
                response = f"{ordered[f]} + {ordered[s]} is {k}"
                break
    return response


print("Question 2")
lst = [10, 9, 8, 7]
k = 16
print(f"For list {lst} and K {k}:", add_up_to_k(lst, k))
lst = [1,4,6]
k = 18
print(f"For list {lst} and K {k}:", add_up_to_k(lst, k))
lst = [25, -4, -6, 7, 12]
k = -10
print(f"For list {lst} and K {k}:", add_up_to_k(lst, k))
print()


# Question 3
# Given a list of integers, return a new list such that each element in the new list is the product of all the numbers in the original list 
# except the element that in the same position of the new list element
# For example, if our input was [1, 2, 3, 4, 5], the expected output would be [120, 60, 40, 30, 24]. 
# If our input was [3, 2, 1], the expected output would be [2, 3, 6].
def new_product_list(input):
    index = len(input)
    for i in range(index):
        a = 1
        for j in range(index):
            if i == j:
                continue
            a *= input[j]
        yield a


print("Question 3")
lst = [1, 2, 3, 4, 5]
print(f"The product list of {lst} is:", list(new_product_list(lst)))
lst = [3, 2, 1]
print(f"The product list of {lst} is:", list(new_product_list(lst)))
lst = [33, 126, 221]
print(f"The product list of {lst} is:", list(new_product_list(lst)))
