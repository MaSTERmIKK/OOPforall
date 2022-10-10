internal class Program
{
    private static void Main(string[] args)
    {
        string newnome = "";
        int newpsw = 0;
        int newid = 0;
        string uscita = "esci";
        int valore = 0;
        string condizioneuscita = "";
        string nomecontrollo = "";
        int pswcontrollo = 0;
        int idcontrollo = 0;


        Persona p = new Persona(newnome, newpsw, newid);
        Console.WriteLine("Inserisci il tuo nome");
        newnome = Console.ReadLine();
        p.setNome(newnome);
        Console.WriteLine("Inserisci la tua password");
        newpsw = Convert.ToInt32(Console.ReadLine());
        p.setPsw(newpsw);
        Console.WriteLine("Inserisci il tuo ID");
        newid = Convert.ToInt32(Console.ReadLine());
        p.setId(newid);
        Console.WriteLine("opzioni menù:");
        Console.WriteLine("1) Visualizza dati");
        Console.WriteLine("2) Modifica dati");
        Console.WriteLine("3) Esci");
        Console.WriteLine("Inserisci il numero dell'opzione che vuoi eseguire");
        valore = Convert.ToInt32(Console.ReadLine());
        switch (valore)
        {
            case 1:
                Console.WriteLine(p.stampa());
                break;
            case 2:
                do
                {
                    Console.WriteLine("***CONTROLLO DATI***");
                    Console.WriteLine("Inserisci il tuo nome");
                    nomecontrollo = Console.ReadLine();
                    Console.WriteLine("Inserisci la tua password");
                    pswcontrollo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Inserisci il tuo ID");
                    idcontrollo = Convert.ToInt32(Console.ReadLine());
                    if (nomecontrollo != newnome || pswcontrollo != newpsw || idcontrollo != newid)
                    {
                        Console.WriteLine("Dati errati riprova");
                    }
                    else
                    {
                        Console.WriteLine("Inserisci il nuovo nome");
                        newnome = Console.ReadLine();
                        p.setNome(newnome);
                        Console.WriteLine("Inserisci la nuova password");
                        newpsw = Convert.ToInt32(Console.ReadLine());
                        p.setPsw(newpsw);
                        Console.WriteLine("Inserisci il nuovo ID");
                        newid = Convert.ToInt32(Console.ReadLine());
                        p.setId(newid);
                        StreamWriter sw = File.AppendText("storicodati.txt");
                        sw.WriteLine(p.stampa());
                        sw.Close();
                        Console.WriteLine("Vuoi modificarlo ancora?");
                        Console.WriteLine("Inserisci 'esci' per uscire");
                        condizioneuscita = Console.ReadLine();
                    }
                } while (condizioneuscita != uscita);
                Console.WriteLine("Dati modificati" + p.stampa());
                break;
            case 3:
                Console.WriteLine("Grazie per aver usato il programma");

                break;
            default:
                Console.WriteLine("Errore Generico");
                break;
        }




    }
}