class Queue(object):
    
    def __init__(self):
        self.items = []
        
    def is_empty(self):
        return self.items == []
    
    def size(self):
        return len(self.items)
    
    def enqueue(self,item):
        self.items.insert(0,item)
    
    def dequeue(self):
        return self.items.pop()


# Test
q = Queue()
print("Is empty:",q.is_empty())
print("enqueue:", 1)
q.enqueue(1)
print("enqueue:", 2)
q.enqueue(2)
print("enqueue:", 3)
q.enqueue(3)
print("Size:",q.size())
print("Is empty:",q.is_empty())
print("dequeue:",q.dequeue())
print("dequeue:",q.dequeue())
print("dequeue:",q.dequeue())
print("Is empty:",q.is_empty())
