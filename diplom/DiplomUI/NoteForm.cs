using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using diplom.Models;

namespace diplom
{
    public partial class NoteForm : Form
    {
        List<NoteModel> notes = new List<NoteModel>();
        public NoteForm()
        {
            InitializeComponent();
            notes = DataManager.LoadNotes();
            dataGridView1.DataSource = notes;
        }
    }
}
