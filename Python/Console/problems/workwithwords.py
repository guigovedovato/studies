import re


word = "hello world"

# Print in reverse way
print(word[::-1])

# Print first of each word capitalized
print(word.title())

# Print if word is polindrome
def polindrome(str):
    return str == str[::-1]


print(polindrome("racecar"))
print(polindrome(word))

# Validate password
# Validation :
#   At least 1 letter between [a-z] and 1 letter between [A-Z].
#   At least 1 number between [0-9].
#   At least 1 character from [$#@].
#   Minimum length 6 characters.
#   Maximum length 16 characters.
def pass_check(str):
    x = True
    charRe = re.compile(r'[^a-zA-Z0-9.]')
    while x:
        if (len(str) < 6 or len(str) > 12):
            break
        elif not charRe.search(str):
            break
        elif not re.search("[$#@]", str):
            break
        elif re.search("\s", str):
            break
        else:
            print("Valid Password")
            x = False
            break
    if x:
        print("Not a Valid Password")
    
    
pass_check(input("Password: "))

# Find all five characters long word in a string
text = 'The quick brown fox jumps over the lazy dog.'
print(re.findall(r"\b\w{5}\b", text))

# Remove everything except alphanumeric characters from a string
text = '**//Python Exercises// - 12. '
pattern = re.compile('[\W_]+')
print(pattern.sub('', text))

# Remove the parenthesis area in a string
items = ["example (.com)", "w3resource", "github (.com)", "stackoverflow (.com)"]
for item in items:
    print(re.sub(r" ?\([^)]+\)", "", item))

# Remove \n
text = "Hello\n"
print(text)
print("World")
print(text.rstrip('\n'))
print("World")
