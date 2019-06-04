using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    class Pytania
    {
        // aby był łatwiejszy zapis do jsona trzeba dobrze przmyśleć klase 

        public string id { get; set; }
        public string pytanie {get;set;}
        public string odp1 { get; set; }
        public string odp2 { get; set; }
        public string odp3 { get; set; }
        public string odp4 { get; set; }
        public string poprawna { get; set; }
    }
}
