using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteAppUI;
using Newtonsoft.Json;
using System.IO;

namespace NoteApp
{
   

    public partial class MainForm : Form
    {
        private Project _project = new Project();
                
      
        private void MainForm_Load(object sender, EventArgs e)
        {
            SelectCategoryComboBox1.Text = NoteCategory.All.ToString();
            LoadListToScreen();
        }

        private void LoadListToScreen()
        {
            _project.SelectedNotes = _project.SortingNote(_project.SelectedNotes);

            listBox1.Items.Clear();

            for (int i = 0; i < _project.SelectedNotes.Count; i++)
            {
                listBox1.Items.Add(_project.SelectedNotes[i].Namenote);
            }

            if(listBox1.Items.Count != 0)
            {

                listBox1.SelectedIndex = 0;
            }

        }

        public MainForm()
        {
            InitializeComponent();
            _project = ManagerProject.Des();
           

            SelectCategoryComboBox1.Items.Add(NoteCategory.All);
            SelectCategoryComboBox1.Items.Add(NoteCategory.Work);
            SelectCategoryComboBox1.Items.Add(NoteCategory.People);
            SelectCategoryComboBox1.Items.Add(NoteCategory.Home);
            SelectCategoryComboBox1.Items.Add(NoteCategory.HealtfandSport);
            SelectCategoryComboBox1.Items.Add(NoteCategory.Finance);
            SelectCategoryComboBox1.Items.Add(NoteCategory.Documents);
            SelectCategoryComboBox1.Items.Add(NoteCategory.Other);

            //SelectCategoryComboBox1.SelectedItem = 0;
            //LoadListToScreen();
           
            
            //удаляем через del
            listBox1.KeyDown += new KeyEventHandler(listBox1_Keys);
            
        }
               
       
        //Выход из программы
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        //Добавление новой заметки
        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        //Редактирование текущей заметки
        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        //Удаление текущей заметки
        private void removeNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteNote();
        }

        //Добавление новой заметки
        private void button1_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        //Редактирование текущей заметки
        private void button2_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        //Удаление текущей заметки 
        private void button3_Click(object sender, EventArgs e)
        {
            DeleteNote();
        }

        //метод добавления новой заметки
        private void AddNote()
        {
            NewEditNoteForm newNoteForm = new NewEditNoteForm();

            if (newNoteForm.ShowDialog() == DialogResult.OK)
            {

                _project.CurrentNote = newNoteForm.Note;
                //NotesL = newNoteForm.Note;

                _project.NotesList.Add(_project.CurrentNote);//NotesL);
                listBox1.Items.Add(_project.CurrentNote);
                SelectNotesByCategory();

                LoadListToScreen();

                
               // _project.SelectedNotes = _project.SortingNote(_project.NotesList);

                ManagerProject.Save(_project);

            }
        }

       
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (listBox1.SelectedIndex != -1)
            
            {
                _project.CurrentNote  = _project.SelectedNotes[listBox1.SelectedIndex];

                label1.Text = _project.CurrentNote.Namenote;
                dateTimePicker1.Value = _project.CurrentNote.timeCreated;
                modifiactionDateTimePicker.Value = _project.CurrentNote.ChangeTime;
                noteTextTextBox.Text = _project.CurrentNote.NoteText;
                //SelectCategoryComboBox1.Text = _project.CurrentNote.CategoryNote;
                label7.Text = _project.CurrentNote.CategoryNote;
                
            }
           
           
        }

        //Показ окна о программе
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.ShowDialog();
        }
        
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ManagerProject.Save(_project);
        }

        //метод для удаления заметки
        private void DeleteNote()
        {
            
                if (MessageBox.Show("Do you really want to remove this note? ", "NoteApp",
                  MessageBoxButtons.OKCancel,
                  MessageBoxIcon.Question) == DialogResult.OK)

                {
                _project.NotesList.Remove(_project.CurrentNote);//  NotesL);

                SelectNotesByCategory();

                LoadListToScreen();

                ManagerProject.Save(_project);

            }
            
        }

        /// <summary>
        /// Метод удаления через кнопку DELETE
        /// </summary>
        private void listBox1_Keys(object sender, KeyEventArgs e)
        {
           
                if (e.KeyCode == Keys.Delete)
                {
                    DeleteNote();
                    e.Handled = true;
                }
            
        }

        ///метод редактирования заметки
        private void EditNote()
        {
           
            NewEditNoteForm newNoteForm = new NewEditNoteForm();

            var selectedIndex = listBox1.SelectedIndex;
            if (listBox1.SelectedIndex != -1)
            {
                var selectedNote = _project.SelectedNotes[selectedIndex];
                var inner = new NewEditNoteForm();
                inner.Note = selectedNote; //Создаем форму
                var result = inner.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    //inner.EditNoteForm(selectedNote);
                    //Передаем форме данные
                    var updatenote = inner.Note;
                    _project.NotesList.Remove(selectedNote);
                    _project.NotesList.Add(updatenote);
                    
                    SelectNotesByCategory();
                    LoadListToScreen();

                    ManagerProject.Save(_project);
                }
               
            }
        }


        private void SelectNotesByCategory()
        {
            _project.SelectedNotes.Clear();

            for (int i = 0; i < _project.NotesList.Count; i++)
            {
                if (SelectCategoryComboBox1.Text == "All")
                {

                    _project.SelectedNotes.Add(_project.NotesList[i]);

                }
                else
                {
                    if (_project.NotesList[i].CategoryNote == SelectCategoryComboBox1.Text)
                    {
                        _project.SelectedNotes.Add(_project.NotesList[i]);
                    }

                }

            }

        }


        private void SelectCategoryComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            SelectNotesByCategory();          

            LoadListToScreen();

        }
    }
    
}








