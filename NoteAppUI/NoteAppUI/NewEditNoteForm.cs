using NoteApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteAppUI
{
    public partial class NewEditNoteForm : Form
    {
        public Note note;



        public Note Note
        {
            get { return note; }
            set
            {
                note = value;
                if (note != null)
                {

                    textBox1.Text = note.Namenote;
                    comboBox1.Text = note.CategoryNote;
                    noteListTextBox.Text = note.NoteText;
                    dateTimePicker1.Value = note.timeCreated;
                    dateTimePicker2.Value = note.ChangeTime;
                }
                else
                {

                    textBox1.Text = "";

                    noteListTextBox.Text = "";
                    dateTimePicker1.Value = DateTime.Today;
                    dateTimePicker2.Value = DateTime.Today;
                }

            }
        }



        //public NoteApp.Note Note;

        public NewEditNoteForm()
        {

            note = new NoteApp.Note();

            InitializeComponent();

            comboBox1.Items.Add(NoteCategory.Work);
            comboBox1.Items.Add(NoteCategory.People);
            comboBox1.Items.Add(NoteCategory.Home);
            comboBox1.Items.Add(NoteCategory.HealtfandSport);
            comboBox1.Items.Add(NoteCategory.Finance);
            comboBox1.Items.Add(NoteCategory.Documents);
            comboBox1.Items.Add(NoteCategory.Other);

            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        //Редактирование заметки 
        public void EditNoteForm(NoteApp.Note notein)
        {
            note = new NoteApp.Note();
            note = notein;
           
            
            try
            {
                textBox1.Text = note.Namenote;
                comboBox1.Text = note.CategoryNote;
                noteListTextBox.Text = note.NoteText;
                dateTimePicker1.Value = note.timeCreated;
                dateTimePicker2.Value = note.ChangeTime;
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message);
                
            }
            

        }


        //Сохранение заметки 
        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {

                note.Namenote = textBox1.Text;
                note.CategoryNote = comboBox1.Text;
                note.NoteText = noteListTextBox.Text;
                note.timeCreated = dateTimePicker1.Value;
                note.ChangeTime = dateTimePicker2.Value;
                DialogResult = DialogResult.OK;
            }

            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message);
                
            }
            
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
    
        
    }

