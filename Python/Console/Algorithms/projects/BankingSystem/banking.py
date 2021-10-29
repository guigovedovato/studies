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
            name = input("Enter your name: ")
            deposit = int(input("Enter the initial deposit: "))
            savingsAccount.createAccount(name, deposit)
            print()
        case 2:
            print()
            name = input("Enter your name: ")
            accountNumber = int(input("Enter your account number: "))
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
                            withdrawalAmount = int(input("Enter a withdrawal amount"))
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
