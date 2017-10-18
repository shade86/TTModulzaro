using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTModulzaro
{
    public class ThreatmentViewModel : BaseModel
    {
        public Patient Patient { get; set; }
        public BNO BNO { get; set; }
        public ObservableCollection<BNO> BNOs { get; set; }
        public BNO SelectedBNO { get; set; }
        public ThreatmentViewModel()
        {
            BNOs = new ObservableCollection<BNO>
            {
                new BNO {Name = "E053736 Pajzsmirigy", Jegyzet = "Nagyon komoly pajzsmirigy gyulladás"},
                new BNO {Name = "E034556 Sípcsonttörés", Jegyzet = "Nagyon komoly sípcsonttörés"},
            };
        }
    }

}
