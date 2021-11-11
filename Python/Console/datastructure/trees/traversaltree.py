from binarytree import BinaryTree


def preorder(tree):
    if tree:
        print(tree.get_root_val())
        preorder(tree.get_left_child())
        preorder(tree.get_right_child())


def postorder(tree):
    if tree != None:
        postorder(tree.get_left_child())
        postorder(tree.get_right_child())
        print(tree.get_root_val())


def inorder(tree):
    if tree != None:
        inorder(tree.get_left_child())
        print(tree.get_root_val())
        inorder(tree.get_right_child())
        

t = BinaryTree('a')
t.insert_left('b')
t.insert_right('C')
t.get_left_child().insert_right('d')
t.get_left_child().insert_left('e')
t.get_right_child().insert_right('f')

print("Preorder")
preorder(t)
print("Postorder")
postorder(t)
print("Inorder")
inorder(t)
