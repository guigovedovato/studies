from singly_linked_list import Node


class DoublyNode(Node):
    
    def __init__(self,value):
        super().__init__(value)
        self.prev_node = None
    

# Test
a = DoublyNode(1)
b = DoublyNode(2)
c = DoublyNode(3)
print("DoublyNode 'a' value:",a.value)
print("DoublyNode 'b' value:",b.value)
print("DoublyNode 'c' value:",c.value)
print("Linking a<->b<->c")
a.next_node = b
b.prev_node = a
b.next_node = c
c.prev_node = b
c.next_node = a
a.prev_node = c
print("DoublyNode 'a.next_node' value:",a.next_node.value)
print("DoublyNode 'b.next_node' value:",b.next_node.value)
print("DoublyNode 'c.next_node' value:",c.next_node.value)
print("DoublyNode 'a.prev_node' value:",a.prev_node.value)
print("DoublyNode 'b.prev_node' value:",b.prev_node.value)
print("DoublyNode 'c.prev_node' value:",c.prev_node.value)
