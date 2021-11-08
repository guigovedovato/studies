class Node(object):
    
    def __init__(self,value):
        self.value = value
        self.next_node = None
    

# Test
a = Node(1)
b = Node(2)
c = Node(3)
print("Node 'a' value:",a.value)
print("Node 'b' value:",b.value)
print("Node 'c' value:",c.value)
print("Linking a->b->c")
a.next_node = b
b.next_node = c
print("Node 'a.next_node' value:",a.next_node.value)
print("Node 'b.next_node' value:",b.next_node.value)
