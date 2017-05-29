using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CoordinateCalculation;



namespace Forms
{
    public partial class MainForm : Form
    {
        public List<IMotion> Motions;
        public MainForm()
        {
            InitializeComponent();
            Motions = new List<IMotion>();
           iMotionBindingSource.DataSource = Motions;
        }

        private void MainForms_Load(object sender, EventArgs e)
        {
          
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var forms=new AddForm();
            if (forms.ShowDialog() == DialogResult.OK) 
            {
                iMotionBindingSource.Add(forms.CoordinateCalculation);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            iMotionBindingSource.RemoveCurrent();
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.SelectedCells[0].RowIndex;
            var form = new AddForm
            {
                CoordinateCalculation = Motions[index]
            };
            if (form.ShowDialog() == DialogResult.OK)
            {
                iMotionBindingSource.RemoveAt(index);
                iMotionBindingSource.Insert(index, form.CoordinateCalculation);
            }
        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            iMotionBindingSource.Add(new Accelerated(rnd.Next(1, 30),rnd.Next(1,30),rnd.Next(1,30),rnd.Next(1,30)));
            iMotionBindingSource.Add(new Vibrating(rnd.Next(1, 30), rnd.Next(1, 30), rnd.Next(1, 30), rnd.Next(1, 30), rnd.Next(1, 30)));
            iMotionBindingSource.Add(new Uniform(rnd.Next(1, 30), rnd.Next(1, 30), rnd.Next(1, 30)));
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Motions.Count != 0)
            {
                var ofd = new SaveFileDialog
                {
                    Filter = @"dat files (*.dat)|*.dat",
                    RestoreDirectory = true
                };
                if (!(ofd.FileName == null || ofd.ShowDialog() == DialogResult.Cancel))
                {
                    Serialization.Serialize(ofd.FileName, Motions);
                }
            }
            else
            {
                MessageBox.Show(@"Ошибка. Файл не може быть пустым");
            }
        }

       

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (!(ofd.FileName == null || ofd.ShowDialog() == DialogResult.Cancel))
            {
                Motions = Serialization.Deserialize(ofd.FileName);
                iMotionBindingSource.DataSource = Motions;
            }
        }

        private void iMotionBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (iMotionBindingSource.Count != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Сохранить данные?","", MessageBoxButtons.YesNoCancel);
                if (dialogResult == DialogResult.Yes)
                {
                    var ofd = new SaveFileDialog
                    {
                        Filter = @"dat files (*.dat)|*.dat",
                        RestoreDirectory = true
                    };
                    if (!(ofd.FileName == null || ofd.ShowDialog() == DialogResult.Cancel))
                    {
                        Serialization.Serialize(ofd.FileName, Motions);
                    }

                    if (dialogResult == DialogResult.No)
                    {

                    }
                    if (dialogResult == DialogResult.Cancel)
                    {

                    }

                }
            }
        }
    }
}
