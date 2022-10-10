internal class Program
{
    private static void Main(string[] args)
    {
        String nome = "giacomo";
        String cognome = "corcella";
        int psw = 134567;
        String verifyname = "";
        String verifycognome = "";
        int verifypsw = 0;

        Console.WriteLine("Salve , inserisci i dati per verificare se sono corretti ");

        Console.WriteLine("Inserisci il nome");
        verifyname = Console.ReadLine();
        Console.WriteLine("Inserisci il cognome");
        verifycognome = Console.ReadLine();
        Console.WriteLine("Inserisci la password");
        verifypsw = Convert.ToInt32(Console.ReadLine());
        if (verifyname == nome && verifycognome == cognome && verifypsw == psw)
        {
            Console.WriteLine("Benvenuto " + " " + nome + " " + cognome + " modifica i tuoi dati");

            Console.WriteLine("Inserisci nuovo nome");
            nome = Console.ReadLine();

            while (nome.Length < 3)
            {
                Console.WriteLine("Inserisci un nome più lungo");
                nome = Console.ReadLine();
            }

            Console.WriteLine("Inserisci nuovo cognome");
            cognome = Console.ReadLine();

            while (cognome.Length < 3)
            {
                Console.WriteLine("Inserisci un cognome più lungo");
                cognome = Console.ReadLine();
            }

            Console.WriteLine("Inserisci nuova password");
            psw = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine("Psw poco sicura, utilizza una più lunga");
                psw = Convert.ToInt32(Console.ReadLine());
            } while (psw.ToString().Length < 3);

            Console.WriteLine("I tuoi dati sono stati modificati , ora sono : " + nome + " " + cognome + " " + psw);

        }   //SCRIVE SU FILE
        /*  StreamWriter sw = new StreamWriter("C:\\Users\\giaco\\csharp\\progetto2\\dati.txt");
         sw.WriteLine(nome);
         sw.WriteLine(cognome);
         sw.WriteLine(psw);
         sw.Close();

         StreamReader sr = new StreamReader("C:\\Users\\giaco\\csharp\\progetto2\\dati.txt");
         Console.WriteLine("I dati salvati sono : " + sr.ReadToEnd());
         sr.Close(); */



        else if (verifyname != nome || verifycognome != cognome || verifypsw != psw)
        {
            Console.WriteLine("Hai sbagliato qualche dato , riprova");
        }
        else
        {
            Console.WriteLine("Errore");
        }


    }
}