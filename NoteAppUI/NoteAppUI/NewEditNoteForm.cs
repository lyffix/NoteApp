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
        public NoteApp.Note note;

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
        public NewEditNoteForm(NoteApp.Note notein)
        {
            note = new NoteApp.Note();
            note = notein;

            InitializeComponent();

            textBox1.Text = note.Namenote;
            comboBox1.Text = note.CategoryNote;
            noteListTextBox.Text = note.NoteText;
            dateTimePicker1.Value = note.timeCreated;
            dateTimePicker2.Value = note.ChangeTime;

        }
        
        
        //Сохранение файла или его редактирование
        private void button1_Click(object sender, EventArgs e)
        {
            note.Namenote = textBox1.Text;
            note.CategoryNote = comboBox1.Text;
            note.NoteText = noteListTextBox.Text;
            note.timeCreated = dateTimePicker1.Value;
            note.ChangeTime = dateTimePicker2.Value;
            //Сохранение файла
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                // получаем выбранный файл
                string filename = saveFileDialog1.FileName;
                // сохраняем текст в файл
                System.IO.File.WriteAllText(filename, textBox1.Text);
                MessageBox.Show("Файл сохранен");
            }

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }
    }
}
