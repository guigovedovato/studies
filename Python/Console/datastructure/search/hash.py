class HashTable(object):
    
    def __init__(self,size):
        self.size = size
        self.slots = [None] * self.size
        self.data = [None] * self.size
    
    def _put(self,key,data):
        hash_value = self._hash_function(key,len(self.slots))
        if self.slots[hash_value] == None:
            self.slots[hash_value] = key
            self.data[hash_value] = data
        else:
            if self.slots[hash_value] == key:
                self.data[hash_value] = data
            else:
                next_slot = self._rehash(hash_value,len(self.slots))
                while self.slots[next_slot] != None and self.slots[next_slot] != key:
                    next_slot = self._rehash(next_slot,len(self.slots))
                if self.slots[next_slot] == None:
                    self.slots[next_slot] = key
                    self.data[next_slot] = data
                else:
                    self.data[next_slot] = data
    
    def _hash_function(self,key,size):
        return key%size

    def _rehash(self,old_hash,size):
        return (old_hash+1)%size
    
    def _get(self,key):
        start_slot = self._hash_function(key,len(self.slots))
        data = None
        stop = False
        found = False
        position = start_slot
        while self.slots[position] != None and not found and not stop:
            if self.slots[position] == key:
                found = True
                data = self.data[position]
            else:
                position = self._rehash(position,len(self.slots))
                if position == start_slot:
                    stop = True
        return data
    
    def __getitem__(self,key):
        return self._get(key)
    
    def __setitem__(self,key,data):
        return self._put(key,data)


hash = HashTable(5)
hash[1] = 'One'
hash[2] = 'Two'
hash[3] = 'Three'
print(hash[1])
print(hash[2])
print(hash[3])
print(hash[4])
