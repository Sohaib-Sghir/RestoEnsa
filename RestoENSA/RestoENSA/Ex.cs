using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoENSA
{
    class Ex : Exception 
    {
        public Ex(string message) : base(message)
        {
            MessageBox.Show(message,"Erreur");
        }

        public Ex(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
