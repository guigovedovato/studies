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

# Anagram
def anagram(s1,s2):
    
    s1 = s1.replace(' ', '').lower()
    s2 = s2.replace(' ', '').lower()
    
    return sorted(s1) == sorted(s2)


def anagram_preferred(s1,s2):
    
    s1 = s1.replace(' ', '').lower()
    s2 = s2.replace(' ', '').lower()
    
    # Edge Case  Check
    if len(s1) != len(s2):
        return False
    
    count = {}
    
    for letter in s1:
        if letter in count:
            count[letter] += 1
        else:
            count[letter] = 1

    for letter in s2:
        if letter in count:
            count[letter] -= 1
        else:
            count[letter] = 1
    
    for k in count:
        if count[k] != 0:
            return False
        
    return True

print(anagram('dog','God'))
print(anagram_preferred('God','dog'))
print(anagram('dog','good'))
print(anagram_preferred('God','dig'))

# reverse sentence
def rev_word_reversed(s):
    return " ".join(reversed(s.split()))


def rev_word_arr(s):
    return " ".join(s.split()[::-1])


def rev_word_preferred(s):
    
    words = []
    length = len(s)
    spaces = [' ']
    
    i = 0
    
    while i < length:
        if s[i] not in spaces:
            word_start = i            
            while i < length and s[i] not in spaces:
                i += 1          
            words.insert(0,s[word_start:i])
        i += 1
    return " ".join(words)


print(rev_word_preferred("  Hello John   how are you    "))

# String compression
def compress(s):
    
    r = ""
    l = len(s)
    
    if l == 0:
        return r
    
    if l == 1:
        return s+"1"
    
    cnt = 1
    i = 1
    
    while i < l:
        if s[i] == s[i-1]:
            cnt += 1
        else:
            r = r+s[i-1]+str(cnt)
            cnt = 1
        i += 1
    
    r = r+s[i-1]+str(cnt)
    
    return r

print(compress('AAaa'))
print(compress('AAB'))
print(compress('AAABBCCCCC'))

# Unique characters
def uni_char_set(s):
    return len(set(s)) == len(s)


def uni_char(s):
    
    chars = set()
    
    for let in s:
        if let in chars:
            return False
        else:
            chars.add(let)
    
    return True


print("abcde:",uni_char_set('abcde'))
print("abcdce:",uni_char_set('abcdce'))
print("abcde:",uni_char('abcde'))
print("abcdce:",uni_char('abcdce'))
