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

        //List
        private void DatabaseListing()
        {
            dgwNotes.DataSource = _noteDal.GetAll();
        }


        //Added
        private void btnAdd_Click(object sender, EventArgs e)
        {

            _noteDal.Add(new Note
            {
                StudentNameSurname = tbxNameAdd.Text,
                Mathematics = Convert.ToInt32(tbxMathAdd.Text),
                Turkish = Convert.ToInt32(tbxTurkAdd.Text),
                PhysicalEducation = Convert.ToInt32(tbxPhysicalAdd.Text),
                Music = Convert.ToInt32(tbxMusicAdd.Text)
            });

            DatabaseListing();
            MessageBox.Show("Added!");

        }


        //Update
        private void dgwNotes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwNotes.CurrentRow.Cells[1].Value.ToString();
            tbxMathUpdate.Text = dgwNotes.CurrentRow.Cells[2].Value.ToString();
            tbxTurkUpdate.Text = dgwNotes.CurrentRow.Cells[3].Value.ToString();
            tbxPhysicalUpdate.Text = dgwNotes.CurrentRow.Cells[4].Value.ToString();
            tbxMusicUpdate.Text = dgwNotes.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Note note = new Note
            {
                StudentID = Convert.ToInt32(dgwNotes.CurrentRow.Cells[0].Value),
                StudentNameSurname = tbxNameUpdate.Text,
                Mathematics = Convert.ToInt32(tbxMathUpdate.Text),
                Turkish = Convert.ToInt32(tbxTurkUpdate.Text),
                PhysicalEducation = Convert.ToInt32(tbxPhysicalUpdate.Text),
                Music = Convert.ToInt32(tbxMusicUpdate.Text)

            };

            _noteDal.Update(note);
            DatabaseListing();
            MessageBox.Show("Update!");
        }


        //Delete
        private void btnRemove_Click(object sender, EventArgs e)
        {
            int studentId = Convert.ToInt32(dgwNotes.CurrentRow.Cells[0].Value);
            _noteDal.Delete(studentId);

            DatabaseListing();
            MessageBox.Show("Deleted!");
        }
    }
}
