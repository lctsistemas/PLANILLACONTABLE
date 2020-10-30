using Negocio.Models;
using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Subsidios : Form
    {
        private int childFormNumber = 0;
        private NSubsidios ns = new NSubsidios();
        public Subsidios()
        {
            InitializeComponent();
        }

        private void ShowSubsidio()
        {
            using (ns)
            {
                dgvsubsidio.DataSource = ns.Getall();
            }
        }

        private void Tabla()
        {
            dgvsubsidio.Columns[0].HeaderText = "id_subsidios";
            dgvsubsidio.Columns[0].Width = 100;
            dgvsubsidio.Columns[0].Visible = false;

            dgvsubsidio.Columns[1].HeaderText = "Cod_subsidio";
            dgvsubsidio.Columns[1].Width = 100;

            dgvsubsidio.Columns[2].HeaderText = "Tipo de suspension";
            dgvsubsidio.Columns[2].Width = 120;

            dgvsubsidio.Columns[3].HeaderText = "Descripcion corta";
            dgvsubsidio.Columns[3].Width = 150;

            dgvsubsidio.Columns[4].HeaderText = "Descripcion subsidio";
            dgvsubsidio.Columns[4].Width = 250;

            dgvsubsidio.Columns[5].HeaderText = "Tipo Subsidio";
            dgvsubsidio.Columns[5].Width = 100;

            dgvsubsidio.Columns[6].HeaderText = "descuento";
            dgvsubsidio.Columns[6].Width = 100;

            dgvsubsidio.Columns[7].HeaderText = "state";
            dgvsubsidio.Columns[7].Width = 100;
            dgvsubsidio.Columns[7].Visible = false;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void Subsidios_Load(object sender, EventArgs e)
        {
            ShowSubsidio();
            Tabla();
        }
    }
}
