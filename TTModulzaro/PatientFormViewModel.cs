using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTModulzaro
{
    public class PatientFormViewModel : BaseModel
    {
        public Patient Patient { get; set; }
        public bool Validate()
        {
            return Patient.Name != null &&
                Patient.Name.Length > 4 &&
                Patient.BornPlace != null &&
                Patient.BornPlace.Length > 1 &&
                //Patient.Born != null &&
                Patient.TAJ != null &&
                Patient.TAJ.Length == 9;
        }
        public bool IsEdit { get; set; }

        public bool OnWindowClosing()
        {
            return
           IsEdit == true
                &&
                Validate() != true;
        }
    }
}


