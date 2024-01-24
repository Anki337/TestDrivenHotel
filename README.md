# TestDrivenHotel
User-Stories:
1	. As a user, I want to be able to look at a hotel website and book a room that fits my needs. I also want to be able to unbook my room if I change my mind.
Acceptance-Criteria:
1   . User can see a list of available rooms. 
2   . User can see how mmuch each room costs. 
3   . User can see a list of booked rooms, so that they can see which rooms are already booked.
4   . User has the possibility to book a room, so that they can reserve the room for their stay. 




```
Inneh�ller:

- En lista som skall fungera som en databas som innteh�ller alla tillg�ngliga rum, dessa skall kunna bokas, och tas bort fr�n listan med tillg�ngliga rum.
- En lista som skall fungera som en databas som inneh�ller alla g�ster
- En Dictionary som skall fungera som en tempor�r databas som inneh�ller alla bokade rum tillsammans med Guest Id.

- Vid bokning s� tas rummet bort fr�n listan och l�ggs till i Dictionaryn tillsammas med Guest Id. ({RoomId, GuestId})
- Vid avbokning s� tas g�sten bort fr�n listan och rummet blir tillg�ngligt igen.
- 
```
