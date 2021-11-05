from customer import Customer
import mongo_setup


def init():
    mongo_setup.global_init()
    

def create_customer() -> Customer:
    name = input("What is your name? ")
    age = int(input("What is yout age? "))
    
    customer = Customer()
    customer.name = name.strip()
    customer.age = age
    customer.save()
    
    return customer


def print_customer(name: str):
    c = Customer.objects(name=name).only("name", "age", "is_active").first()
    if not c:
        print("This name is not inserted")
    if not c.is_active:
        print("This name is not active")
    print("Your name is:", c.name)
    print("Your age is:", c.age)


init()
customer = create_customer()
print_customer(customer.name)
