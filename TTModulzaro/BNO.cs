using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTModulzaro
{ 
    public class BNO : BaseModel
{
    string _name;
    string _jegyzet;


    public string Name { get { return _name; } set { _name = value; OnPropertyChange(); } }
    public string Jegyzet { get { return _jegyzet; } set { _jegyzet = value; OnPropertyChange(); } }
}
}
