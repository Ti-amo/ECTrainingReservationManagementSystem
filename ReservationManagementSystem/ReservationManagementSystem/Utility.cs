using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationManagementSystem {
    public class Utility {
        public bool CheckFormIsOpen(string formName) {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms) {
                if (f.Name == formName) {
                    IsOpen = true;
                    f.BringToFront();
                    break;
                }
            }
            return IsOpen;
        }
    }
}
