Czech:

    Jedná se o jednoduchou okení aplikaci napsanou v jazyce C# a jazyku XAML (C# + XAML = WPF aplikace).
    Aplikace má dvě okna hlavní a pod okno.
    Hlavní okno:
        Hlavní okno obsahuje po načtení tabulku, kam jsou načtená data z příslušného datového uložistě(SQLite databáze).
        Dale je zde textové pole pro vyhledání uživatele podle jména a příjmení.
        A jako poslední komponenty jsou zde v druhé půlce okna textové bloky a calenář pro editaci informací o pacientoví a dvě tlačítka, kde jedno ukládá změněná data do databáze a druhé tlačítko pouze otevře podokno pro vytvoření nového pacienta.
    Pod okno:
        Okno pro tvorbu nového pacienta obsahuje pouze dva textové bloky pro zadní jmená a příjmení, calendář pro zadání datumu narození a tlačítko pro potvrzení.
        Po zadaní probběhne uložení do databáze a příslušné okno se zavře a tabulka v hlavnim okně s načtenými daty se aktualizuje a zobrazí všechny uživatele i s příslušným nově zadaným.

English:

    It is a simple windows application written in C # and XAML (C # + XAML = WPF applications).
    The application has two main windows and a sub window.
    Main window:
        After loading, the main window contains a table where the data from the relevant data store (SQLite database) is loaded.
        There is also a text box for finding a user by first and last name.
        And as the last components, there are text blocks and a calendar in the second half of the window for editing patient information and two buttons, where one stores the changed data in the database and the other button only opens the pane for creating a new patient.
    Sub window:
        The window for creating a new patient contains only two text blocks for back names and surnames, a calendar for entering the date of birth and a confirmation button.
        Once entered, the database will be saved and the relevant window will close and the table in the main window with the loaded data will be updated and all users will be displayed, including the newly entered one.

@Author Daniel Cífka
@Date 15.6.2022