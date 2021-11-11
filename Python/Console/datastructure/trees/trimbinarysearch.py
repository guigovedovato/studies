from node import Node
import treelevelorder


# Given the root of a binary search tree and 2 numbers min and max, trim the tree such that all the numbers in the new tree are between min and max (inclusive). 
# The resulting tree should still be a valid binary search tree.
def trimBST(tree, minVal, maxVal): 
    
    if not tree: 
        return 
    
    tree.left=trimBST(tree.left, minVal, maxVal) 
    tree.right=trimBST(tree.right, minVal, maxVal) 
    
    if minVal<=tree.val<=maxVal: 
        return tree 
    
    if tree.val<minVal: 
        return tree.right 
    
    if tree.val>maxVal: 
        return tree.left


tree = Node(1)
tree.left = Node(2)
tree.right = Node(3)
tree.left.left = Node(4)
tree.left.right = Node(5)
tree.right.left = Node(6)
tree.right.right = Node(7)

print("Tree")
treelevelorder.level_order_print(tree)
print("Tree Trim")
treelevelorder.level_order_print(trimBST(tree,1,5))
