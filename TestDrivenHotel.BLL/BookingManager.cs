namespace TestDrivenHotel.BLL
{
    public class BookingManager
    {
        //Här sköts allt som har med databasen att göra!
        // Använd EF core för att skapa databasen och kopplingarna till functionerna.
        //En statisk lista som skall fungera som en databas som inntehåller alla tillgängliga rum, Dessa skall kunna bokas och avbokas.
        //En lista som skall fungera som en databas som innehåller alla gäster, fylls på när man bokar ett rum med sitt namn, både gäst och rum läggs till i en dictionary.
        //Dictionary som både gäst namn och rum namn länkas som ett key:value pair så man kan skriva ut listan och se vilka gäster som är bokade i vilka rum
        //Vid avbokning så tas gästen bort från listan och rummet blir tillgängligt igen.

        //Statisk lista för alla tillgängliga rum
        //Statisk lista för alla gäster
        //Statisk dictionary för att länka gäst och rum
    }
}
