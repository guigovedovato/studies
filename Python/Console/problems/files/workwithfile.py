import pickle


students_score = {"Student 1": 89, "Student 2": 78, "Student 3": 93,}

data = open("student_data.dat", "wb")
pickle.dump(students_score, data)
data.close()

data = open("student_data.dat", "rb")
students = pickle.load(data)
data.close()

print(students)
