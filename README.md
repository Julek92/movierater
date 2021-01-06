# movierater
MovieRater

Moje obycie z platformą .NET Core jest dość małe, dlatego nie będę ukrywał, że przy robieniu tego zadania wspomagałem się internetem i innymi przykładami. Nie napisałem testów jednostkowych, ponieważ nie mam doświadczenia w pisaniu testów na platformie .net (Chociaż projekt dodałem, ale zaniechałem dalszego działania).

Nie do końca jasno było opisane w treści jak filmy mają być wyświetlane, więc uznałem że forma jest dowolna. Dlatego w bazie danych trzymam tylko oceny z identyfikatorami filmów, a same filmy są pobierane jednorazowo przy starcie aplikacji (uznałem, że do naszych celów wystarczy pobrać tą listę jednorazowo)

Po uruchomieniu "Update-Database" baza danych powinna się poprawnie zbudować
