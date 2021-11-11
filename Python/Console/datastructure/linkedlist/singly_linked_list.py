# Singly Linked List
class Node(object):
    
    def __init__(self,value):
        self.value = value
        self.next_node = None


# Test
from nose.tools import assert_equal


class TestSinglyLinkedList(object):
    
    # Assert
    def test_cycle_check(self,func):
        assert_equal(func(a),False)
        assert_equal(func(x),True)
        
        print("     All Test Cases Passed")
        
    def test_reversal_check(self,func):
        func(a)
        assert_equal(c.next_node.value,2)
        assert_equal(b.next_node.value,1)
        
        print("     All Test Cases Passed")
        
    def test_nth_to_last_node_check(self,func):
        assert_equal(func(2,c),b)
        
        print("     All Test Cases Passed")


t = TestSinglyLinkedList()

# Arrange
print("Create no cycle list")
a = Node(1)
b = Node(2)
c = Node(3)
a.next_node = b
b.next_node = c
print("Create cycle list")
x = Node(1)
y = Node(2)
z = Node(3)
x.next_node = y
y.next_node = z
z.next_node = x

# Questions

# 1. Given a singly linked list, write a function which takes in the first node in a singly linked list and returns
# a boolean indicating if the linked list contains a "cycle".
def cycle_check(node):
    
    marker1 = node
    marker2 = node
    
    while marker2 != None and marker2.next_node != None:
        
        marker1 = marker1.next_node
        marker2 = marker2.next_node.next_node
        
        if marker2 == marker1:
            return True
    
    return False


# Test - Check Singly Linked List Cycle
print("Check Singly Linked List Cycle")
# Act
t.test_cycle_check(cycle_check)

# 2. Write a function to reverse a Linked List in place. The function will take in the head of the list as
# input an return the new head of the list
def reverse(head):
    
    current = head
    prev = None
    next = None
    
    while current:
        
        next = current.next_node
        current.next_node = prev
        prev = current
        current = next
        
    return prev


# Test - Check Singly Linked List Reversal
print("Check Singly Linked List Reversal")
# Act
t.test_reversal_check(reverse)

# 3. Write a function that takes a head node and an integer value n and then returns the nth to last
# node in the linked list
def nth_to_last_node(n,head):
    
    left_pointer = head
    right_pointer = head
    
    for i in range(n-1):
        
        if not right_pointer.next_node:
            raise LookupError("Error: n is larger than the linked list")
        
        right_pointer = right_pointer.next_node
        
    while right_pointer.next_node:
        
        left_pointer = left_pointer.next_node
        right_pointer = right_pointer.next_node
    
    return left_pointer


# Test - Check Singly Linked List Nth to Last Node
print("Check Singly Linked List Nth to Last Node")
# Act
t.test_nth_to_last_node_check(nth_to_last_node)
