using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaConceitoIveco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Inicio i = new Inicio();
            i.CT001();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("excel.exe", "C:\\Users\\Auditeste0367\\Desktop\\IVECO\\ProvaConceitoIveco\\Planilhas\\Massa.xlsx");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "C:\\Users\\Auditeste0367\\Desktop\\IVECO\\ProvaConceitoIveco\\Evidencias");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "C:\\Users\\Auditeste0367\\Desktop\\IVECO\\ProvaConceitoIveco\\Log");

        }
    }
}
