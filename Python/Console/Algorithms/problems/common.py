# This method perform to get value of a number and return its
def enter_number(attempts):
    
    print(f"You have {attempts} attempts")
    
    while attempts > 0:
        try:
            number = int(input("Enter a number:"))
            break
        except ValueError:
                print("You have not entered a number!!!")
                attempts -= 1
                print(f"You have {attempts} attempts")
        finally:
            if attempts == 0:
                print("Bye!!!")
                raise ValueError("You have not entered a number!!!")

    return number
