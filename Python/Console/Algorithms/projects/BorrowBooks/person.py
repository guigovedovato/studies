from abc import ABCMeta


class Person(metaclass = ABCMeta):
    
    in_action = False
    
    def __init__(self, name):
        self._name = name
        Person.in_action = True
    
    @property     
    def name(self):
        return self._name

    @classmethod
    def is_in_action(cls):
        return cls.in_action
    
    def __str__(self):
        return f"My name is {self._name}"
