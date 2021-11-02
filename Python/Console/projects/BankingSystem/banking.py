from account import SavingsAccount


savings_account = SavingsAccount()

while True:
    print()
    print("Enter 1 to create a new account")
    print("Enter 2 to access an existing account")
    print("Enter 3 to exit")
    user_choice = int(input())
    print()
    match user_choice:
        case 1:
            print()
            name = input("Enter your name: ")
            deposit = int(input("Enter the initial deposit: "))
            savings_account.create_account(name, deposit)
            print()
        case 2:
            print()
            name = input("Enter your name: ")
            account_number = int(input("Enter your account number: "))
            authentication_status = savings_account.authenticate(name, account_number)
            print()
            if authentication_status is True:
                while True:
                    print()
                    print("Enter 1 to withdraw")
                    print("Enter 2 to deposit")
                    print("Enter 3 to display avialable balance")
                    print("Enter 4 to go back to the previous menu")
                    user_choice = int(input())
                    print()
                    match user_choice:
                        case 1:
                            print()
                            withdrawal_amount = int(input("Enter a withdrawal amount"))
                            savings_account.withdraw(withdrawal_amount)
                            print()
                        case 2:
                            print()
                            print("Enter an amount to be deposited")
                            deposit_amount = int(input())
                            savings_account.deposit(deposit_amount)
                            print()
                        case 3:
                            print()
                            savings_account.display_balance()
                            print()
                        case 4:
                            break
        case 3:
            quit()
        case _:
            print("This option is invalid!!!")
