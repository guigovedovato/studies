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
        self._savingsAccounts = {}
        
    def createAccount(self, name, initialDeposit):
        print()
        self._accountNumber = randint(10000, 99999)
        self._savingsAccounts[self._accountNumber] = [name, initialDeposit]
        print("Account creation has been successful. Your account number is ", self._accountNumber)
        print()

    def authenticate(self, name, accountNumber):
        print()
        if accountNumber in self._savingsAccounts.keys():
            if self._savingsAccounts[accountNumber][0] == name:
                print("Authentication Successful")
                self._accountNumber = accountNumber
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

    def withdraw(self, withdrawalAmount):
        print()
        if withdrawalAmount > self._savingsAccounts[self._accountNumber][1]:
            print("Insufficient balance")
        else:
            self._savingsAccounts[self._accountNumber][1] -= withdrawalAmount
            print("Withdrawal was successful.")
            self.displayBalance()
        print()

    def deposit(self, depositAmount):
        print()
        self._savingsAccounts[self._accountNumber][1] += depositAmount
        print("Deposit was successful.")
        self.displayBalance()
        print()

    def displayBalance(self):
        print("Avaialble balance: ", self._savingsAccounts[self._accountNumber][1])
