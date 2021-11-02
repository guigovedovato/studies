# Enter the number of scores
# Enter each score
# Show scores in rounded number and 2 decimals

number_of_scores = int(input("Enter the number of scores: "))
score_values = []

for score in range(number_of_scores):
    score_values.append(int(input(f"Enter the value of score {score + 1}: ")))
    
average_score = sum(score_values)/number_of_scores

print(f"The average is: {format(average_score,'.2f')}")
print(f"The rounded average is: {sum(score_values)//number_of_scores}")

# Enter the number of approved and disapproved students
# Show the percentage of each

approved = int(input("Enter the number of approved students: "))
disapproved  = int(input("Enter the number of disapproved students: "))
total_students = approved + disapproved

print(f"The percentage of approved students is: {format(approved/total_students, '.0%')}")
print(f"The percentage of disapproved students is: {format(disapproved/total_students, '.2%')}")
