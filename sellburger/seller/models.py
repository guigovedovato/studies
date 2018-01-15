from django.db import models

# Create your models here.
class Base(models.Model):
    active = models.BooleanField(default=True)
    created = models.DateField()
    updated = models.DateField()

    class Meta:
        abstract = True
        
class Customer(Base):
    name = models.CharField(max_length=100)
    address = models.CharField(max_length=250)
    phone = models.CharField(max_length=9, db_index=True)

class Product(Base):
    name = models.CharField(max_length=50)
    price = models.DecimalField(max_digits=4, decimal_places=2)
    photo = models.FileField(upload_to='products/')

class Order(models.Model):
    customer = models.ForeignKey(Customer, on_delete=models.DO_NOTHING)
    created = models.DateField()
    time = models.IntegerField(default=1)

class OrderDetail(models.Model):
    order = models.ForeignKey(Order, on_delete=models.CASCADE)
    product = models.ForeignKey(Product, on_delete=models.DO_NOTHING)
    quantity = models.IntegerField(default=1)
