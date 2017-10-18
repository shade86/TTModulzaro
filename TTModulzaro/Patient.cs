using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTModulzaro
{
    public class Patient : BaseModel
    {
        string _name;
        string _bornplace;
        string _born;
        string _taj;

        public string Name { get { return _name; } set { _name = value; OnPropertyChange(); } }
        public string BornPlace { get { return _bornplace; } set { _bornplace = value; OnPropertyChange(); } }
        public string Born { get { return _born; } set { _born = value; OnPropertyChange(); } }
        public string TAJ { get { return _taj; } set { _taj = value; OnPropertyChange(); } }
    }
}
