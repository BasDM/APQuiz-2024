using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APQuiz
{
    internal class NumericQuestion : QuizQuestion
    {
        private int antwoord;
        public NumericQuestion(string vraag, int antwoordIn)
        {
            VraagTekst = vraag;
            antwoord = antwoordIn;
        }
        public NumericQuestion()
        {
            Random rng = new Random();
            int g1 = rng.Next(1, 10);
            int g2 = rng.Next(1, 10);
            VraagTekst = $"Hoeveel is {g1}*{g2}";
            antwoord = g1 * g2;
        }
        public override bool ControleerAntwoord(string gebruikerAntwoord)
        {
            return antwoord == int.Parse(gebruikerAntwoord);
        }
    }
}
