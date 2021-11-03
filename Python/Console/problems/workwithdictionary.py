# Enter the name and score of competitors
# Show scores
# show the max score
competitors = {}

how_many = int(input("Enter the number of competitors: "))

for c in range(how_many):
    name = input(f"Enter the name of competitor {c + 1}: ")
    score = int(input(f"Enter the score of competitor {c + 1}: "))
    competitors[name] = score

print("Competitors:")
for k,v in competitors.items():
    print(f"Name: {k}, Score: {v}")

print(f"The highest score is {max(competitors.values())}")
