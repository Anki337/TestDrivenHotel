# TestDrivenHotel
User-Stories:
1	. As a user, I want to be able to look at a hotel website and book a room that fits my needs. I also want to be able to unbook my room if I change my mind.
Acceptance-Criteria:
1   . User can see a list of available rooms.
2   . User can see how mmuch each room costs.
3   . User can see a list of booked rooms, so that they can see which rooms are already booked.
4   . User has the possibility to book a room, so that they can reserve the room for their stay.
5.  . User can limit their search to a specific date range, so that they can see which rooms are available for their stay.
6.  . User can see the total cost of their stay, so that they can see how much they will be charged.



What the program contains in form of classes and methods in pseudo code:
```
- En lista som skall fungera som en databas som innteh�ller alla tillg�ngliga rum, dessa skall kunna bokas, och tas bort fr�n listan med tillg�ngliga rum och l�ggas till i listan med bokade rum.
- En lista som skall fungera som en databas som inneh�ller alla bokade rum, dessa skall kunna avbokas, och l�ggas tillbaka i listan med tillg�ngliga rum.
 -En lista som skall fungera som en databas som inneh�ller alla g�ster, fylls p� n�r man bokar ett rum med sitt namn, b�de g�st och rum l�ggs till i en dictionary.
- Dictionary som b�de g�st namn och rum namn l�nkas som ett key:value pair s� man kan skriva ut listan och se vilka g�ster som �r bokade i vilka rum
- Vid bokning s� tas rummet bort fr�n listan och l�ggs till i listan med bokade rum.
- Vid avbokning s� tas g�sten bort fr�n listan och rummet blir tillg�ngligt igen.
- 
```
