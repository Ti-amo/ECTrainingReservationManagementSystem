using System.Windows.Forms;

namespace ReservationManagementSystem
{
    public partial class ManageExamFormTemp : Form
    {
        public ManageExamFormTemp()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEdit_Click(object sender, System.EventArgs e)
        {
            LabelLanguage.Visible = true;
            DropDownListMajorItem_Add.Visible = false;
            TextboxMajorItemName_Eng.Visible = true;
            TextboxMajorItemName_Ja.Visible = true;
        }
    }
}