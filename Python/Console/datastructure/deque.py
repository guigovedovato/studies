class Deque(object):
    
    def __init__(self):
        self.items = []
        
    def is_empty(self):
        return self.items == []
    
    def size(self):
        return len(self.items)
    
    def add_front(self,item):
        self.items.append(item)
    
    def add_rear(self,item):
        self.items.insert(0,item)
        
    def remove_front(self):
        return self.items.pop()
        
    def remove_rear(self):
        return self.items.pop(0)


# Test
d = Deque()
print("Is empty:",d.is_empty())
print("Adding in front: 'Hello'")
d.add_front("Hello")
print("Adding in rear: 'World'")
d.add_rear("World")
print("Size:",d.size())
print("Removing front first and folloed by rear")
print(d.remove_front(),d.remove_rear())
print("Size:",d.size())
print("Is empty:",d.is_empty())
