namespace Delegati01;
    // definicija delegata, delegat prima dva parametra
    public delegate int operation(int x, int y);

    class Program
    {
        // funkcija koja ce ici u delegat, ima ISTE parametre
        
        static int Addition(int a, int b)
        {
            return a + b;
        }

        static int Multiplication(int a, int b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            // kreiranje tj. instanciranje elegata
            // kao parametar moze ici funkcija koja ima iste paramatre
            operation obj = new operation(Program.Addition);

            // output
            Console.WriteLine("Zbroj  je = {0} necega",obj(4,7));

            obj += Program.Multiplication;
            
            Console.WriteLine("Umnozak  je = {0} necega",obj(4,7));



            Console.ReadLine();
        }
    }

 