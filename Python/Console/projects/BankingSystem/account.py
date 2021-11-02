from abc import ABCMeta, abstractmethod
from random import randint


class Account(metaclass = ABCMeta):
    
    @abstractmethod
    def createAccount():
        return 0
    
    @abstractmethod
    def authenticate():
        return 0
    
    @abstractmethod
    def withdraw():
        return 0
    
    @abstractmethod
    def deposit():
        return 0
    
    @abstractmethod
    def displayBalance():
        return 0


class SavingsAccount(Account):
    
    def __init__(self):
        self._savings_accounts = {}
        
    def create_account(self, name, initial_deposit):
        print()
        self._account_number = randint(10000, 99999)
        self._savings_accounts[self._account_number] = [name, initial_deposit]
        print("Account creation has been successful. Your account number is ", self._account_number)
        print()

    def authenticate(self, name, account_number):
        print()
        if account_number in self._savings_accounts.keys():
            if self._savings_accounts[account_number][0] == name:
                print("Authentication Successful")
                self._account_number = account_number
                print()
                return True
            else:
                print("Authentication Failed")
                print()
                return False
        else:
            print("Authentication Failed")
            print()
            return False

    def withdraw(self, withdrawal_amount):
        print()
        if withdrawal_amount > self._savings_accounts[self._account_number][1]:
            print("Insufficient balance")
        else:
            self._savings_accounts[self._account_number][1] -= withdrawal_amount
            print("Withdrawal was successful.")
            self.display_balance()
        print()

    def deposit(self, deposit_amount):
        print()
        self._savings_accounts[self._account_number][1] += deposit_amount
        print("Deposit was successful.")
        self.display_balance()
        print()

    def display_balance(self):
        print("Avaialble balance: ", self._savings_accounts[self._account_number][1])
