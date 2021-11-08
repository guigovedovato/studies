class Stack(object):
    
    def __init__(self):
        self.items = []
        
    def is_empty(self):
        return self.items == []
    
    def size(self):
        return len(self.items)
    
    def push(self,item):
        self.items.append(item)
        
    def pop(self):
        return self.items.pop()
    
    def pick(self):
        return self.items[-1]


# Test
s = Stack()
print("Is empty:",s.is_empty())
print("Push:", 1)
s.push(1)
print("Push:", 2)
s.push(2)
print("Pick:",s.pick())
print("Push:", 3)
s.push(3)
print("Size:",s.size())
print("Is empty:",s.is_empty())
print("Pop:",s.pop())
print("Pop:",s.pop())
print("Pop:",s.pop())
print("Is empty:",s.is_empty())
