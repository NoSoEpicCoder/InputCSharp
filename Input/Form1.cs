using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Input {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void BtnAnswer_Click(object sender, EventArgs e) {
            int firstTextBoxNumber = int.Parse(btFirstNumber.Text);
            int secondTextBoxNumber = int.Parse(tbSecondNumber.Text);
            int answer = firstTextBoxNumber / secondTextBoxNumber;

            MessageBox.Show(answer.ToString());
        }
    }
}
