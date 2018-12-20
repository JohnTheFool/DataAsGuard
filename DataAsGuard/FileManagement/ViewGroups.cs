using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAsGuard.FileManagement
{
    public partial class ViewGroups : Form
    {
        public ViewGroups()
        {
            InitializeComponent();
        }

        private void createGroupButton_Click(object sender, EventArgs e)
        {
            FileManagement.CreateNewGroup createNewGroup = new FileManagement.CreateNewGroup();
            createNewGroup.Show();
            Hide();
        }
    }
}
