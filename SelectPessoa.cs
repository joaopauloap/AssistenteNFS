using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssistenteNFS
{
    public partial class SelectPessoa : Form
    {
        public SelectPessoa()
        {
            InitializeComponent();
        }
        public List<string> Items
        {
            set
            {
                listBox1.Items.Clear();
                listBox1.Items.AddRange(value.ToArray());
            }
        }

        public string SelectedItem { get; private set; }

        private void SelectPessoa_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                SelectedItem = listBox1.SelectedItem.ToString();
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
