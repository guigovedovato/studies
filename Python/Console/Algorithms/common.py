# This method perform to get value of a number and return its
def enterNumber(attempts):
    
    print(f"You have {attempts} attempts")
    
    while attempts > 0:
        try:
            print("Enter a number:")
            number = int(input())
            break
        except ValueError:
                print("You have not entered a number!!!")
                attempts -= 1
                print(f"You have {attempts} attempts")

    if attempts == 0:
        print("Bye!!!")
        quit()

    return number
