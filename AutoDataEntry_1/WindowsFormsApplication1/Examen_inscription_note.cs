using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Examen_inscription_note
    {
        public int inscription_id;
        public int examen_id;
        public Double moyenne;
        public String remarque;

        public Examen_inscription_note()
        {

        }
        public Examen_inscription_note(int inscription_id,int examen_id, Double moyenne )
        {
            this.inscription_id = inscription_id;
            this.examen_id = examen_id;
            this.moyenne = moyenne;
            

        }
        public Examen_inscription_note(int inscription_id, int examen_id, Double moyenne, String remarque)
        {
            this.inscription_id = inscription_id;
            this.examen_id = examen_id;
            this.moyenne = moyenne;
            this.remarque = remarque;

        }





    }
}
