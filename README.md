# stampantePersistente
 ## Descrizione

Questo progetto, basato su WPFStampante, è stato esteso per rendere persistente lo stato del programma anche attraverso le riaperture dell'applicazione. Le modifiche apportate includono:

- **Persistenza dello Stato:**
  - Al riavvio dell'applicazione, le percentuali dei colori (Ciano, Magenta, Giallo, Nero) nella stampante rimangono invariate.
  - Il numero di fogli nel cassetto della stampante rimane costante anche dopo la riapertura dell'applicazione.

### `SalvaStatoSuFile(string filePath)`

Questo metodo consente di salvare lo stato corrente della stampante su un file specificato. Le percentuali di inchiostro per i colori Ciano, Magenta, Giallo e Nero, insieme al numero di fogli nel cassetto, vengono scritte nel file in un formato facilmente leggibile.

### `CaricaStatoDaFile(string filePath)`

Questo metodo permette di caricare uno stato precedentemente salvato dalla stampante da un file. Se il file specificato esiste, le percentuali di inchiostro e il numero di fogli vengono ripristinati sulla stampante, consentendo il recupero dello stato precedente.

Entrambi i metodi contribuiscono a rendere persistente l'esperienza dell'utente, consentendo il salvataggio e il ripristino degli stati della stampante anche tra sessioni diverse dell'applicazione.
