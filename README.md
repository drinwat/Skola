#Skola

sākums...
Kam, kāpēc projekts nepieciešams, kādu problēmu projekts risina:

Matemātikas olimpiādei ir vajadzīgi uzdevumi, kurus pasniegt 2. Klases skolēniem. Viena no olimpiādes tēmām ir reizreiķins un dalīšana. Matemātikas olimpiādes organizētāji tikai pēdējā brīdī atjēdzās, ka nav sagatavojuši uzdevumus un steigā, pēdējā vakarā izveidoja vienkāršu veidu kā ātri pārbaudīt olimpiādes dalībnieku zināšanas. 

Projekta prasības: 

1. Olimpiādes uzdevumiem jābūt izpildāmiem kā konsoles vai darbvirsmas programmatūrai. 
2. Olimpiādes uzdevumi atbilst 2. klases līmenim, bet ir āķīgi. 
3. Programmatūras vizuālais izskats ir vienkārš:
bez bildēm, bez pārlieku daudz krāsainiem elementiem, bez izskaistināšanas, ir viegli pārskatāms un bez uzmanību novērsošiem elementiem. 
4. Kopā ir 10 Olimpiādes uzdevumi par matemātiku.


Programmas funkciju uzskaitījums: 

1. Pēc programmas iedarbināšanas ekrānā redzama - Matemātikas Olimpiādes tēma "Reizināšana un Dalīšana" un poga olimpiādes uzsākšanai. 
2. Pēc olimpiādes uzsākšanas vienlaicīgi ekrānā redzams pirmais matemātikas jautājums, no 10 jautājumiem, un trīs tā atbilžu varianti. Viens no atbilžu variantiem vienmēr ir pareizs un divi nepareizi. 
3. Ekrāna kreisajā augšējā stūrī redzams jautājumu skaitītājs (1 no 10).
4. Ekrāna labajā augšējā stūrī redzams olimpiādes rezultāts - iekrātie punkti (vesels skaitlis).
5. Pēc atbildes izvēles:
	ja atbilde ir pareiza, punktu skaits tiek palielināts par +1.
	ja atbilde ir nepareiza, punktu skaits tiek samazināts par -1, bet punktu skaits nevar būt mazāks par 0.
6. Neatkarīgi no atbildes pareizības, tiek parādīts nākošais jautājums no atlikušajiem jautājumiem un tā atbilžu varianti.
7. Olimpiāde turpinās tik ilgi, līdz skolēns sniedzis atbildes uz 10 jautājumiem.
8. Olimpiādes beigās tiek saskaitīts iegūtais punktu skaits un parādīts.

Wireframe diagramma:
https://lucid.app/lucidchart/045d8d10-5d0b-4ade-ad5c-fee0ae8fd148/edit?viewport_loc=-4541%2C-1262%2C7663%2C3800%2C0_0&invitationId=inv_9676b89c-5d70-4759-9ca8-de457d4b9807

Jautājumi, varianti un atbildes:

"CIK IR 2 + 2 = ?", 0 ; 2 ; 4, Atbilde: 4

"CIK IR 2 * 2 = ?", 2 ; 4 ; 22, Atbilde: 4

"CIK IR 2 + 2 * 2 = ?", 8 ; 4 ; 6, Atbilde: 6 

"CIK IR 2 * (2 + 2) = ?", 6 ; 100 ; 8, Atbilde: 8 

"CIK IR 10 / 2 = ?", 5 ; 300 ; 500, Atbilde: 5

"CIK IR 10000 / 2 = ?", 5000 ; 20 ; 400, Atbilde: 5000

"CIK IR 10 / 0.2 = ?", 5 ; 45 ; 50, Atbilde: 50

"CIK IR 1000 / 0.02 = ?", 2000 ; 21 ; 50000, Atbilde: 50000

"CIK IR 1001 / 2 = ?", 1000.5 ; 109 ; 500.5, Atbilde: 500.5

"CIK IR 2002 / (2 * 2) = ?", 200 ; 1000 ; 500.5, Atbilde: 500.5

Lietotāja rokasgrāmata:

1. Atrodi vietu, kur saglabāji "Matemātikas Olimpiāde Reizreiķins un Dalīšana" failu un atver to. 
2. Spied "Sākt".
3. Pildi dotos uzdevumus un centies atbildēt pareizi, lai dabūtu maksimālo punktu skaitu.
4. Kad atbildējis visus 10 jautājumus, apskati savu rezultātu un programmu var aizvērt. 
5. Pildīšanas laikā ir opcija programmu minimizēt, maksimizēt un no tās arī iziet.
6. Gala rezultāti nekur netiek saglabāti tāpēc veic screenshot, ja vēlies saglabāt savu rezultātu.
7. Programma neatcerās iepriekšējās lietošanas reizes un tiek katru reizi svaigi palaista. 
8. Programma izseko tikai pareizās atbildes un to kopējo vērtību parāda beigās. 


 
