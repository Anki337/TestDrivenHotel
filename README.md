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
- En lista som skall fungera som en databas som inntehåller alla tillgängliga rum, dessa skall kunna bokas, och tas bort från listan med tillgängliga rum och läggas till i listan med bokade rum.
- En lista som skall fungera som en databas som innehåller alla bokade rum, dessa skall kunna avbokas, och läggas tillbaka i listan med tillgängliga rum.
 -En lista som skall fungera som en databas som innehåller alla gäster, fylls på när man bokar ett rum med sitt namn, både gäst och rum läggs till i en dictionary.
- Dictionary som både gäst namn och rum namn länkas som ett key:value pair så man kan skriva ut listan och se vilka gäster som är bokade i vilka rum
- Vid bokning så tas rummet bort från listan och läggs till i listan med bokade rum.
- Vid avbokning så tas gästen bort från listan och rummet blir tillgängligt igen.
- 
```
