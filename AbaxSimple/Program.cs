// See https://aka.ms/new-console-template for more information
//
// Oppgave Abaxrekruttering
// Oppgaven under er laget av Kjetil Lassen i Abax. Han bruker den som "opptaksprøve" når han ansetter nye utviklere, som en test på om
// man har forstått objektorientering.  
//
//     Oppgaven kan forsåvidt løses uten objekter i det hele tatt, men poenget her er å skjønne hvilke klasser man er ute etter og
// modellere dette skikkelig - selv om det blir "å skyte spurv med kanoner" i forhold til det programmet faktisk gjør.
//
// Skriv et konsoll-program i C# som kan:
// Printe informasjon om en en bil 1 med
// reg. nr NF123456,
// 147kw effekt,
// maksfart 200km/t,
// grønn farge av typen lett kjøretøy. 

// Printe informasjon om en annen bil (bil 2) med reg.
// nr NF654321,
// 150kw effekt,
// maksfart 195km/t,
// blå farge og av typen lett kjøretøy 

//Sammenlikne de to bilene over for å sjekke om de er det samme kjøretøyet 

// Printe informasjon om et fly med
// kjennetegn LN1234
// , 1000kw effekt,
// 30m vingespenn,
// 2tonn lasteevne,
// 10 tonn egenvekt I flyklasse jetfly 



// Konsollprogrammet skal be flyet om å fly og printe dette i konsollet. 
// Konsollprogrammet skal be bil 1 om å kjøre og printe dette I konsollet     
// Printe informasjon om en båt med
// kjennetegn ABC123
// , 100kw effekt,
// maksfart på 30knop,
// 500kg bruttotonnasje.

using AbaxSimple;

var car1 = new Car("NF123456", 147, 200, "Green", "Light weight");
var car2 = new Car("NF654321", 150, 195, "Blue", "Light weight");
car1.printInfo();
car2.printInfo();
var boat = new boat("ABC123", 100, 30, 500);
boat.printInfo();
var plane = new Plane("LN1234", 1000, 30, 2, 10, "Jet plane");
plane.printInfo();
car1.Run();
plane.Run();
boat.Run();
