﻿using System;

namespace Hangman
{
    class WordProvider
    {
        private static string[] _words = new[]
        {
            "Aerger", "aerztin", "Abend", "Abfahrt", "Abflug", "Absender", "Adresse", "Alkohol", "Alter", "Ampel",
            "Anfang", "Angebot", "Angestellte", "Angst", "Ankunft", "Anmeldung", "Anrede", "Anruf", "Anrufbeantworter",
            "Ansage", "Anschluss", "Antwort", "Anzeige", "Anzug", "Apfel", "Apotheke", "Appartement", "Appetit",
            "April", "Arbeit", "Arbeitsplatz", "Arm", "Arzt", "Aufenthalt", "Aufgabe", "Aufzug", "Auge", "August",
            "Ausbildung", "Ausflug", "Ausgang", "Auskunft", "Auslaender", "Auslaenderin", "Ausland", "Aussage",
            "Ausstellung", "Ausweis", "Auto", "Autobahn", "Automat", "Baeckerei", "Buero", "Baby", "Bad", "Bahn",
            "Bahnhof", "Bahnsteig", "Balkon", "Banane", "Bank", "Batterie", "Baum", "Beamte", "Beamtin", "Bein",
            "Beispiel", "Bekannte", "Benzin", "Beratung", "Berg", "Beruf", "Berufsschule", "Besuch", "Betrag", "Bett",
            "Bewerbung", "Bier", "Bild", "Bildschirm", "Birne", "Bitte", "Blatt", "Bleistift", "Blick", "Blume",
            "Bluse", "Blut", "Bogen", "Bohne", "Broetchen", "Bruecke", "Brief", "Briefkasten", "Briefmarke",
            "Brieftasche", "Briefumschlag", "Brille", "Brot", "Bruder", "Buch", "Buchstabe", "Bus", "Butter", "Cafe",
            "CD", "Chef", "Computer", "Creme", "Dach", "Dame", "Dank", "Datum", "Dauer", "Deutsche", "Dezember",
            "Dienstag", "Ding", "Disco", "Doktor", "Dom", "Donnerstag", "Doppelzimmer", "Dorf", "Drucker", "Durchsage",
            "Durst", "Dusche", "Ecke", "Ehefrau", "Ehemann", "Ei", "Einfuehrung", "Eingang", "Einladung", "Eintritt",
            "Einwohner", "Einzelzimmer", "Eis", "Eltern", "Empfaenger", "Empfang", "Ende", "Enkel", "Entschuldigung",
            "Erdgeschoss", "Erfahrung", "Ergebnis", "Erlaubnis", "Ermaessigung", "Erwachsene", "Essen", "Export",
            "Faehre", "Fuehrerschein", "Fuehrung", "Fabrik", "Fahrer", "Fahrkarte", "Fahrplan", "Fahrrad", "Familie",
            "Familienname", "Familienstand", "Farbe", "Fax", "Februar", "Fehler", "Fenster", "Ferien", "Fernsehgeraet",
            "Fest", "Feuer", "Feuerwehr", "Feuerzeug", "Fieber", "Film", "Firma", "Fisch", "Flasche", "Fleisch",
            "Flughafen", "Flugzeug", "Flur", "Fluss", "Formular", "Foto", "Fotoapparat", "Fruehjahr", "Fruehling",
            "Fruehstueck", "Frage", "Frau", "Freitag", "Freizeit", "Freund", "Freundin", "Friseur", "Frist", "Fuss",
            "Fussball", "Fundbuero", "Gabel", "Garage", "Garten", "Gas", "Gast", "Gebuehr", "Geburtsjahr", "Geburtsort",
            "Geburtstag", "Gegenteil", "Geld", "Geldboerse", "Gemuese", "Gepaeck", "Gericht", "Gesamtschule",
            "Geschaeft", "Geschenk", "Geschirr", "Geschwister", "Gesicht", "Gespraech", "Gesundheit", "Getraenk",
            "Gewicht", "Gewitter", "Glueck", "Glueckwunsch", "Glas", "Gleis", "Groesse", "Grenze", "Grippe",
            "Grosseltern", "Grossmutter", "Grossvater", "Gruss", "Grundschule", "Gruppe", "Guthaben", "Gymnasium",
            "Haehnchen", "Haar", "Halbpension", "Halle", "Hals", "Haltestelle", "Hand", "Handtuch", "Handy", "Haus",
            "Hausaufgabe", "Hausfrau", "Haushalt", "Hausmann", "Heimat", "Heizung", "Hemd", "Herbst", "Herd", "Herr",
            "Herz", "Hilfe", "Hobby", "Holz", "Hose", "Hund", "Hunger", "Idee", "Import", "Industrie", "Information",
            "Inhalt", "Internet", "Jacke", "Jahr", "Januar", "Job", "Jugendherberge", "Jugendliche", "Juli", "Junge",
            "Juni", "Kaese", "Koerper", "Kueche", "Kuehlschrank", "Kuendigung", "Kaffee", "Kalender", "Kamera", "Kanne",
            "Karte", "Kartoffel", "Kasse", "Kassette", "Kassettenrecorder", "Katze", "Keller", "Kellner", "Kenntnisse",
            "Kennzeichen", "Kette", "Kfz", "Kind", "Kindergarten", "Kinderwagen", "Kino", "Kiosk", "Kirche", "Klasse",
            "Kleid", "Kleidung", "Kneipe", "Koffer", "Kollege", "Kollegin", "Konsulat", "Kontakt", "Konto", "Kontrolle",
            "Konzert", "Kopf", "Kosmetik", "Krankenkasse", "Krankheit", "Kredit", "Kreditkarte", "Kreis", "Kreuzung",
            "Kuchen", "Kugelschreiber", "Kunde", "Kundin", "Kurs", "Loeffel", "Loesung", "Laden", "Lager", "Lampe",
            "Land", "Landschaft", "Leben", "Lebensmittel", "Leid", "Lehre", "Lehrer", "Lehrerin", "Leute", "Licht",
            "Lied", "Lkw", "Loch", "Lohn", "Lokal", "Luft", "Lust", "Maedchen", "Maerz", "Moebel", "Muell",
            "Muelltonne", "Magen", "Mai", "Mal", "Mann", "Mantel", "Markt", "Maschine", "Material", "Mechaniker",
            "Medikament", "Meer", "Mehrwertsteuer", "Meinung", "Menge", "Mensch", "Messer", "Metall", "Miete", "Milch",
            "Minute", "Mittag", "Mitte", "Mitteilung", "Mittel", "Mittelschule", "Mittwoch", "Mode", "Moment", "Monat",
            "Montag", "Morgen", "Motor", "Mund", "Museum", "Musik", "Mutter", "Naehe", "Nachbar", "Nachbarin",
            "Nachmittag", "Nachrichten", "Nacht", "Name", "Natur", "Nebel", "Norden", "Notarzt", "Note", "Notfall",
            "Notiz", "November", "Nudel", "Nummer", "Ober", "Obst", "Oktober", "Oma", "Opa", "Operation", "Orange",
            "Ordnung", "Ort", "Osten", "oel", "Paeckchen", "Paket", "Panne", "Papier", "Papiere", "Parfuem", "Park",
            "Partei", "Partner", "Partnerin", "Party", "Pass", "Pause", "Pension", "Pkw", "Plan", "Plastik", "Platz",
            "Polizei", "Portion", "Post", "Postleitzahl", "Pruefung", "Praktikum", "Praxis", "Preis", "Problem",
            "Produkt", "Programm", "Prospekt", "Pullover", "Qualitaet", "Quittung", "Ruecken", "Rabatt", "Radio",
            "Rathaus", "Raucher", "Raucherin", "Raum", "Realschule", "Rechnung", "Regen", "Reifen", "Reinigung", "Reis",
            "Reise", "Reisebuero", "Reisefuehrer", "Reparatur", "Restaurant", "Rezept", "Rezeption", "Rind", "Rock",
            "Rose", "Rundgang", "Sueden", "Sache", "Saft", "Salat", "Salz", "Samstag/Sonnabend", "Satz", "Schueler",
            "Schuelerin", "Schalter", "Scheckkarte", "Schiff", "Schild", "Schinken", "Schirm", "Schluessel", "Schloss",
            "Schluss", "Schmerzen", "Schnee", "Schnupfen", "Schokolade", "Schrank", "Schuh", "Schule", "Schwein",
            "Schwester", "Schwimmbad", "See", "Sehenswuerdigkeit", "Seife", "Sekretaerin", "Sekunde", "Sendung",
            "Senioren", "September", "Service", "Sessel", "Sofa", "Sohn", "Sommer", "Sonderangebot", "Sonne", "Sonntag",
            "Sorge", "Spuelmaschine", "Spass", "Spaziergang", "Speisekarte", "Spielplatz", "Sprache", "Sprachschule",
            "Sprechstunde", "Stueck", "Stadt", "Standesamt", "Stempel", "Steuer", "Stock", "Stoff", "Strasse",
            "Strassenbahn", "Strand", "Streichholz", "Strom", "Student", "Studentin", "Studium", "Stuhl", "Stunde",
            "Supermarkt", "Suppe", "Tuer", "Tuete", "Tag", "Tankstelle", "Tasche", "Tasse", "Taxi", "Tee", "Teil",
            "Telefon", "Telefonbuch", "Teller", "Teppich", "Termin", "Test", "Text", "Theater", "Thema", "Ticket",
            "Tier", "Tipp", "Tisch", "Tochter", "Toilette", "Tomate", "Topf", "Tourist", "Treppe", "Trinkgeld", "Turm",
            "Uhr", "Unfall", "Universitaet", "Unterhaltung", "Unterkunft", "Unterricht", "Unterschied", "Unterschrift",
            "Untersuchung", "Urlaub", "uebernachtung", "Vater", "Verbindung", "Verein", "Verkaeufer", "Verkaeuferin",
            "Verkehr", "Vermieter", "Versicherung", "Verspaetung", "Vertrag", "Video", "Vogel", "Volksschule",
            "Vormittag", "Vorname", "Vorsicht", "Vorwahl", "Waesche", "Wagen", "Wald", "Wasser", "Weg", "Wein", "Welt",
            "Werkstatt", "Werkzeug", "Westen", "Wetter", "Wiederhoeren", "Wiedersehen", "Wind", "Winter", "Wirtschaft",
            "Woche", "Wochenende", "Wochentag", "Wohnung", "Wolke", "Wort", "Wunsch", "Wurst", "Zahl", "Zahn", "Zeit",
            "Zeitschrift", "Zeitung", "Zentrum", "Zettel", "Zeugnis", "Zigarette", "Zimmer", "Zitrone", "Zoll",
            "Zucker", "Zug"
        };

        public static string GetWord()
        {
            Random randomNumberProvider = new Random();
            return _words[randomNumberProvider.Next(0, _words.Length)].ToUpper();
        }
    }
}