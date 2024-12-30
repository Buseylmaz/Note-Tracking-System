using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTrackingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NoteDal _noteDal = new NoteDal();

        private void Form1_Load(object sender, EventArgs e)
        {
            DatabaseListing();      
        }

        private void DatabaseListing()
        {
            dgwNotes.DataSource = _noteDal.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            _noteDal.Add(new Note
            {
                StudentNameSurname = tbxName1.Text,
                Mathematics = Convert.ToInt32(tbxMath1.Text),
                Turkish = Convert.ToInt32(tbxTurk1.Text),
                PhysicalEducation = Convert.ToInt32(tbxPhysical1.Text),
                Music = Convert.ToInt32(tbxMusic1.Text)
            });

            DatabaseListing();
            MessageBox.Show("Notes added!");





        }
    }
}
