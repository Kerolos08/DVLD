using DVLD.People.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.People
{
    public partial class frmFindPerson : Form
    {
        public event Action<int> OnPersonFound;
        public frmFindPerson()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            OnPersonFound?.Invoke(ctrlpersonCardWithFilters1.PersonID);
            this.Close();
        }
    }
}
