from account import SavingsAccount


savingsAccount = SavingsAccount()

while True:
    print()
    print("Enter 1 to create a new account")
    print("Enter 2 to access an existing account")
    print("Enter 3 to exit")
    userChoice = int(input())
    print()
    match userChoice:
        case 1:
            print()
            print("Enter your name: ")
            name = input()
            print("Enter the initial deposit: ")
            deposit = int(input())
            savingsAccount.createAccount(name, deposit)
            print()
        case 2:
            print()
            print("Enter your name: ")
            name = input()
            print("Enter your account number: ")
            accountNumber = int(input())
            authenticationStatus = savingsAccount.authenticate(name, accountNumber)
            print()
            if authenticationStatus is True:
                while True:
                    print()
                    print("Enter 1 to withdraw")
                    print("Enter 2 to deposit")
                    print("Enter 3 to display avialable balance")
                    print("Enter 4 to go back to the previous menu")
                    userChoice = int(input())
                    print()
                    match userChoice:
                        case 1:
                            print()
                            print("Enter a withdrawal amount")
                            withdrawalAmount = int(input())
                            savingsAccount.withdraw(withdrawalAmount)
                            print()
                        case 2:
                            print()
                            print("Enter an amount to be deposited")
                            depositAmount = int(input())
                            savingsAccount.deposit(depositAmount)
                            print()
                        case 3:
                            print()
                            savingsAccount.displayBalance()
                            print()
                        case 4:
                            break
        case 3:
            quit()
        case _:
            print("This option is invalid!!!")
