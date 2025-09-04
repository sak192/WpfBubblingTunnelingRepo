using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace WpfApp_BubblingAndTunnelingEvents.ViewModel
{
    public class ModelViewMV
    {
        public string result { get; set; }

        public String Result
        {
            get { return result; }
            set { result = value; }
        }

        public ModelViewMV()
        {
            Result = "abc";
        }

    }
}
