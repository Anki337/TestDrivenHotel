# TestDrivenHotel
User-Stories:
1	. As a user, I want to be able to look at a hotel website and book a room that fits my needs. I also want to be able to unbook my room if I change my mind.
Acceptance-Criteria:
1   . User can see a list of available rooms. 
2   . User can see how mmuch each room costs. 
3   . User can see a list of booked rooms, so that they can see which rooms are already booked.
4   . User has the possibility to book a room, so that they can reserve the room for their stay. 




```
Innehåller:

- En lista som skall fungera som en databas som inntehåller alla tillgängliga rum, dessa skall kunna bokas, och tas bort från listan med tillgängliga rum.
- En lista som skall fungera som en databas som innehåller alla gäster
- En Dictionary som skall fungera som en temporär databas som innehåller alla bokade rum tillsammans med Guest Id.

- Vid bokning så tas rummet bort från listan och läggs till i Dictionaryn tillsammas med Guest Id. ({RoomId, GuestId})
- Vid avbokning så tas gästen bort från listan och rummet blir tillgängligt igen.
- 
```
