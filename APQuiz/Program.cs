namespace APQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<QuizQuestion> vragenLijst = new List<QuizQuestion>();

            vragenLijst.Add(new NumericQuestion());
            vragenLijst.Add(new SingleWordQuestion("Welke laptop heeft mr Dams","Dell"));
            vragenLijst.Add(new SingleWordQuestion("Wie gaat haar naam veranderen volgend jaar?", "Els"));
            vragenLijst.Add(new NumericQuestion("Hoeveel volk zat er in de les vandaag?", 20));

            int score = 0;
            foreach (var vraag in vragenLijst)
            {
                Console.WriteLine("De vraag volgt nu....");
                Console.WriteLine(vraag);
                Console.WriteLine("Wat is het antwoord? ");
                string antwoord = Console.ReadLine();
                if (vraag.ControleerAntwoord(antwoord))
                {
                    Console.WriteLine("HOERA. Puntje bij");
                    score++;
                }
                else
                    Console.WriteLine("WRONG");
            }
            Console.WriteLine($"Je behaalde {100* score/vragenLijst.Count}%");
        }
    }
}
