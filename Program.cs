using System;

namespace UnicamFattoriale
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stampo dei messaggi di cortesia per l'utente, così lo guido all'utilizzo del programma
            Console.WriteLine("Questo programma calcola il fattoriale di un numero");
            Console.Write("Digita un numero intero e premi invio: ");

            //Console.ReadLine si mette in attesa che l'utente digiti qualcosa e prema invio.
            //Quando ha premuto invio, il testo che ha digitato lo assegno ad una variabile di tipo string.
            string testoDigitatoDallUtente = Console.ReadLine();

            //Interpreto il testo come un numero intero
            //Attenzione: questa istruzione fallirà se l'utente ha digitato un testo
            //che non è interpretabile come un numero! (Es. ABCD)
            int numero;
            
            if(!Int32.TryParse(testoDigitatoDallUtente, out numero)) {
                Console.WriteLine("Spiacente, non posso calcolare il fattoriale per questo valore");
                Console.ReadKey();
            } else {
                if(numero < Int32.MaxValue) {
                    if(numero == 0) {
                        var numeroPassato = numero;
                        int risultato = 1;
                        Console.WriteLine($"Il fattoriale di {numeroPassato} e' {risultato}");
                        Console.ReadKey();
                    } else {
                        var numeroPassato = numero;
                        //Calcolo il fattoriale: qui ci sono degli errori!
                        int risultato = 1;
                        while (numero > 0) {
                            try {
                                risultato *= numero;
                            } catch(ArgumentOutOfRangeException) {
                                Console.WriteLine("Il numero è troppo grande ");
                                Console.ReadKey();
                            }
                            numero--; 
                        }

                        //Stampo il risultato
                        Console.WriteLine($"Il fattoriale di {numeroPassato} e' {risultato}");
                        //Attendo che l'utente prema un tasto prima di uscire, altrimenti 
                        Console.ReadKey();
                    }       
                } else {
                    Console.WriteLine("Spiacente, non posso calcolare il fattoriale per questo valore");
                    Console.ReadKey();  
                }
            }
            
            
        }
    }
}
