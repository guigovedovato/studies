import airtravel
from boardingpasses import card_printer


f, g = airtravel.make_flights()

print(f.num_available_seats())
print(g.num_available_seats())
