from customer import Customer


class Student(Customer):
    
    def __init__(self, name, course):
        super().__init__(name)
        self._course = course
        self._max_reading_books = 5
        
    @property
    def couse(self):
        return self._course
    
    @couse.setter
    def couse(self, value):
        self._course = value
        
    def __str__(self):
        return  f"{super().__str__()}\n{f'My course is {self._course}'}"
