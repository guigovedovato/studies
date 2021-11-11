class BinaryTree(object):
    
    def __init__(self,root):
        self._key = root
        self._left_child = None
        self._right_child = None
    
    def insert_left(self,node):
        if self._left_child == None:
            self._left_child = BinaryTree(node)
        else:
            l = BinaryTree(node)
            l._left_child = self._left_child
            self._eft_child = l
    
    def insert_right(self,node):
        if self._right_child == None:
            self._right_child = BinaryTree(node)
        else:
            r = BinaryTree(node)
            r._right_child = self._right_child
            self._right_child = r
    
    def get_right_child(self):
        return self._right_child
    
    def get_left_child(self):
        return self._left_child
    
    def set_root_val(self,root):
        self._key = root
    
    def get_root_val(self):
        return self._key


t = BinaryTree('a')
print("Val of tree:",t.get_root_val())
print("Val of right:",t.get_right_child())
t.insert_left('b')
print("Val of left:",t.get_left_child().get_root_val())
