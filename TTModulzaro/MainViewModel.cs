using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTModulzaro
{
    public class MainViewModel: BaseModel
    {
        public ObservableCollection<Patient> Patients { get; set; }

        public Patient SelectedPatient { get; set; }

        public MainViewModel()
        {
            Patients = new ObservableCollection<Patient>
            {
                new Patient {Name = "Kovács Géza", Born = "XXX", BornPlace = "Budapest", TAJ = "022345733"},
                new Patient {Name = "Tari Edit", Born = "XXX", BornPlace = "Székesfehérvár", TAJ = "543666876"},
                new Patient {Name = "Lángosi Elemér", Born = "XXX", BornPlace = "Gödöllő", TAJ = "051233478"}
            };
        }
    }
}
