using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    interface IView
    {
        event Action ChoseFile;
        event Action CreateFile;
        event Action LoadQuiz;
        event Action  Edit;
        int Editque { get; }
        string QuizName { get; set; }
        
        event Action Addq;
        string Id { get; set; }
         string Pytanie { get; set; }
         string Odp1 { get; set; }
         string Odp2 { get; set; }
         string Odp3 { get; set; }
         string Odp4 { get; set; }
        string Correct { get; set; }
    }
}
