using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APQuiz
{
    internal abstract class QuizQuestion
    {
        public string VraagTekst { get; set; }

        public abstract bool ControleerAntwoord(string gebruikerAntwoord);

        public override string ToString()
        {
            return $"Vraag: {VraagTekst}";
        }

    }
}
