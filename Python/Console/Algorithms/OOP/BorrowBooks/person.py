from abc import ABCMeta


class Person(metaclass = ABCMeta):
        
    def __init__(self, name):
        self._name = name
         
    def get_name(self):
        return self._name
