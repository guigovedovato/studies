# Question 1
# You have array of integers, find the first missing positive integer (find the lowest positive integer that does not exist in the array). 
# The array can contain duplicates and negative numbers as well.
# For example, the input [9, 5, -2, 1] should give 2. 
# The input [1, 2, 3] should give 4.
# You can modify the input array in-place.
def first_missing_positive(input):
    input = [x for x in sorted(set(input)) if x >= 0]
    for p in range(1,len(input)):
        output = input[p - 1] + 1
        if output != input[p]:
            return output
    else:
        output += 1
    return output


print("Question 1")
lst = [9, 5, -2, 1]
print(f"For list {lst} the first missing positive integer is:", first_missing_positive(lst))
lst = [1, 2, 3, 3, 2]
print(f"For list {lst} the first missing positive integer is:", first_missing_positive(lst))
lst = [1, 2, 3, 4, 5]
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
    index = len(input)
    for f in range(index):
        for s in range(f + 1, index):
            if input[f] + input[s] == k:
                return f"{input[f]} + {input[s]} is {k}"
    return f"No such two number that their sum equals {k}"


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
print()

# Question 4
# Given an integer array, output all the unique pairs that sum up to a specific value k
# So the imput:
#   pair_sum([1,3,2,2],4)
# would return 2 pairs:
#   (1,3)
#   (2,2)
def pair_sum(arr,k):
    
    if len(arr)<2:
        return
    
    # Sets for tracking
    seen = set()
    output = set()
    
    for num in arr:        
        target = k-num        
        if target not in seen:
            seen.add(num)
        else:
            output.add((min(num,target),max(num,target)))
        
    #return len(output)
    return '\n'.join(map(str,list(output)))


print("Question 4")
lst = [1,3,2,2]
k = 4
print(f"For list {lst} and K {k}:", pair_sum(lst, k), sep='\n')
