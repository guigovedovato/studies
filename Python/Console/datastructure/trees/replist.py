def binary_tree(r):
    return [r,[],[]]

def insert_left(root,elem):
    t = root.pop(1)
    if len(t) > 1:
        root.insert(1,[elem,t,[]])
    else:
        root.insert(1,[elem,[],[]])
    return root

def insert_right(root,elem):
    t = root.pop(2)
    if len(t) > 1:
        root.insert(2,[elem,[],t])
    else:
        root.insert(2,[elem,[],[]])
    return root

def get_root_val(root):
    return root[0]

def set_root_val(root, val):
    root[0] = val

def get_left_child(root):
    return root[1]

def get_right_child(root):
    return root[2]

r = binary_tree(3)
insert_left(r,4)
insert_left(r,5)
insert_right(r,6)
insert_right(r,7)
l = get_left_child(r)
print(l)
set_root_val(l,9)
print(r)
