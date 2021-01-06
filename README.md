# movierater
MovieRater

Moje obycie z platformą .NET Core jest dość małe, dlatego nie będę ukrywał, że przy robieniu tego zadania wspomagałem się internetem i innymi przykładami. Nie napisałem testów jednostkowych, ponieważ nie mam doświadczenia w pisaniu testów na platformie .net.

Nie do końca jasno było opisane w treści jak połączyć filmy w API z ocenami lokalnymi, więc uznałem że forma jest dowolna. Dlatego w bazie danych trzymam tylko oceny z identyfikatorami filmów, a same filmy są pobierane jednorazowo z API.

Po uruchomieniu "Update-Database" baza danych powinna się poprawnie zbudować
