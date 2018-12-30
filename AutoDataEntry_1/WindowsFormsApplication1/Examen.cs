using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Examen
    {
        int type_id;
        int annee_scolaire_id;
        int personnel_id;
        int periode_id;
        int UniteMatiere_id;

        public Examen()
        {

        }
        public Examen(int type_id,int annee_scolaire_id,int personnel_id,int periode_id,int UniteMatiere_id)
        {
            this.type_id=type_id;
            this.annee_scolaire_id=annee_scolaire_id;
            this.personnel_id= personnel_id;
            this.periode_id= periode_id;
            this.UniteMatiere_id= UniteMatiere_id;
        }



    }
}
