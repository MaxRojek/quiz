using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    class Presenter
    {
        IView view;
        Model model;
        public Presenter(IView view, Model model)
        {
            this.view = view;
            this.model = model;
            this.view.Addq += View_Addq;
            this.view.Edit += View_Edit;
            this.view.LoadQuiz += View_Load;
            this.view.CreateFile += View_CreateFile;
            this.view.ChoseFile += View_ChoseFile;

        }

        private void View_Addq()
        {

             model.Object(view.Id, view.Pytanie,view.Odp1,view.Odp2,view.Odp3,view.Odp4, view.Correct);
        }
        private void View_Edit()
        {        
             view.Id = model.GetId(view.Editque);
            view.Pytanie = model.GetPytanie(view.Editque);
            view.Odp1 = model.GetOdp1(view.Editque);
            view.Odp2 = model.GetOdp2(view.Editque);
            view.Odp3 = model.GetOdp3(view.Editque);
            view.Odp4 = model.GetOdp4(view.Editque);
            view.Correct = model.GetCorrect(view.Editque);
            model.Edit(view.Editque);
        }
        private void View_Load()
        {
            model.Load();
        }
        private void View_CreateFile()
        {
            model.CreateFile(view.QuizName);
        }
       private void View_ChoseFile()
        {
            model.ChoseFile();
        }
    }
}
