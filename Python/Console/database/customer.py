import datetime
import mongoengine


class Customer(mongoengine.Document):
    
    registered_date = mongoengine.DateTimeField(default=datetime.datetime.now)
    name = mongoengine.StringField(required=True)
    is_active = mongoengine.BooleanField(default=True)
    age = mongoengine.IntField(required=True, min_value=18)
    
    meta = {
        'db_alias': 'core',
        'collection': 'customer'
    }
