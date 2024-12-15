# System sprzedaży biletów lotniczych

## Wymagania
Proszę zaimplementować system sprzedaży biletów lotniczych scharakteryzowany
poniżej. Rozwiązanie musi być zgodne z zasadami SOLID.


## Struktura


![struktura](https://github.com/user-attachments/assets/dbf70e65-5b5a-47a0-8cfa-2937bc072a32)

Projekt podzielony jest na dwie części:
 a) Biblioteka
 b) Testy

Biblioteka zawiera następujące klasy
<table>
   <tbody>
      <tr>
         <th>Klassa</th>
         <th>opis</th>
         <th>dodatkowe</th>
      </tr>
      <tr>
         <td>Flight.cs</td>
         <td>Poszczególny lot, między innymi minimalna wartość ceny (poniżej zniżki już nie działają)</td>
      </tr>
      <tr>
         <td>FlightPrice.cs</td>
         <td>Lista cen</td>
      </tr>
      <tr>
         <td>Gender.cs</td>
         <td>Płeć klienta</td>
      </tr>
      <tr>
         <td>Lot.cs</td>
         <td>W pliku zawierają klasy do zniżek na podstawie interfejsu IDiscountCriterion</td>
      </tr>
      <tr>
         <td>Person.cs</td>
         <td>Osoba która ma imie, płeć, datę urodzin</td>
      </tr>
      <tr>
         <td>PurchaseService.cs</td>
         <td>Klasa która ma listę zniżek oraz wartość zniżki</td>
      </tr>
      <tr>
         <td>Tenant.cs</td>
         <td>Abstrakcyjna klasa(typ kienta)</td>
      </tr>
      <tr>
         <td>TenantA.cs</td>
         <td>Dla takiego typu klienta zniżki zapisujemy</td>
         <td>dla takiego klienta w klasie PurchaseService zrwacamy nazwy zniżek </td>
      </tr>
      <tr>
         <td>TenantB.cs</td>
         <td>Dla takiego typu klienta zniżki <b>nie</b> zapisujemy</td>
      </tr>
      <tr>
         <td>TenantGroup.cs</td>
         <td>Enum-->grupa klientów</td>
      </tr>
   </tbody>
</table>


## Testowanie

Testy typu MSTest testujemy następujące przypadki

<table>
        <tr>
         <th>Nazwa metody</th>
         <th>Opia</th>
      </tr>
      <tr>
         <td>Kupno_biletu_grupa_a</td>
         <td>Bilet dla grupy A, gdzie w metodzie PurchaseFlight zwracamy nazwę zniżek</td>
      </tr>
     

</table>


