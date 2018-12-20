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
    //TODO:
    //1. юнит тест для дес-ции и сер-ции 
    //2. доработать сортировку заметок по дате изменения + перегруженный метод (возвращает отсортированный по дате изменения
    //список заметок, принадлежащих только этой категории)
    //3. сделать показ заметок по категориям (При выборе пункта «All» отобразить все заметки)
    //4.в классе Project создать свойство "Текущая заметка, 
    //которое меняется в случае просмотра пользователем какой-либо заметки в программе
    //Значение свойства должно также сохраняться в файл. 
    //При запуске программы значение свойства должно загружаться из файла, 
    //и пользователю в главном окне должна отобразиться последняя просмотренная им заметка.

    public partial class MainForm : Form
    {
        private Project _project = new Project();
                
        List<Note> NotesList = new List<Note>();

        List<Note> SelectedNoteList = new List<Note>();

        
        Note NotesL = new Note();

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadListToScreen()
        {
           for (int i = 0; i < _project.NotesList.Count; i++)
            {
                listBox1.Items.Add(_project.NotesList[i].Namenote);
            }

        }

        public MainForm()
        {
            InitializeComponent();
            _project = ManagerProject.Des();
            //сортировка заметок
            _project.NotesList = _project.SortingNote();

            
            SelectCategoryComboBox1.Items.Add(NoteCategory.Work);
            SelectCategoryComboBox1.Items.Add(NoteCategory.People);
            SelectCategoryComboBox1.Items.Add(NoteCategory.Home);
            SelectCategoryComboBox1.Items.Add(NoteCategory.HealtfandSport);
            SelectCategoryComboBox1.Items.Add(NoteCategory.Finance);
            SelectCategoryComboBox1.Items.Add(NoteCategory.Documents);
            SelectCategoryComboBox1.Items.Add(NoteCategory.Other);

            for (int i = 0; i < _project.NotesList.Count; i++)
            {

                listBox1.Items.Add(_project.NotesList[i].Namenote);
            }

            //удаляем через del
            listBox1.KeyDown += new KeyEventHandler(listBox1_Keys);

            /*foreach (var note in _project.NotesList)
            {
               listBox1.Items.Add(note.Namenote);//отображение всех заметок по дате изменения
            }
            */



        }
               
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        //Выход из программы
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadNotesFromDiskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Создаём экземпляр сериализатора
            JsonSerializer serializer = new JsonSerializer();
            //Открываем поток для чтения из файла с указанием пути

            serializer.DateFormatString = "yyyy'-'MM'-'dd'T'HH':'mm':'ss";

            using (StreamReader sr = new StreamReader(@"c:\json.txt"))
            using (JsonReader reader = new JsonTextReader(sr))

            {
                //Вызываем десериализацию и явно преобразуем результат в целевой тип данных
                NotesList = (List<Note>)serializer.Deserialize(reader);
            }

        }

        private void saveToDiskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Создаём экземпляр сериализатора
            JsonSerializer serializer = new JsonSerializer();
            serializer.DateFormatString = "yyyy'-'MM'-'dd'T'HH':'mm':'ss";
            //Открываем поток для записи в файл с указанием пути
            using (StreamWriter sw = new StreamWriter(@"C:\NoteApp.notes"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                //Вызываем сериализацию и передаем объект, который хотим сериализовать
                serializer.Serialize(writer, NotesL);
            }
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

        //метод добавления новой заметки
        private void AddNote()
        {
            NewEditNoteForm newNoteForm = new NewEditNoteForm();

            if (newNoteForm.ShowDialog() == DialogResult.OK)
            {

                NotesL = newNoteForm.Note;

                _project.NotesList.Add(NotesL);
                listBox1.Items.Add(NotesL.Namenote);

                
                _project.NotesList = _project.SortingNote();

                ManagerProject.Save(_project);

            }
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
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (listBox1.SelectedIndex != -1)
            
            {
                NotesL = _project.NotesList[listBox1.SelectedIndex];

                label1.Text = NotesL.Namenote;
                dateTimePicker1.Value = NotesL.timeCreated;
                modifiactionDateTimePicker.Value = NotesL.ChangeTime;
                noteTextTextBox.Text = NotesL.NoteText;
                SelectCategoryComboBox1.Text = NotesL.CategoryNote;
                label7.Text = NotesL.CategoryNote;
                
            }
           
           
 
        }

        //Показ окна о программе
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine(DateTime.Now);
        }

        private void modifiactionDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine(DateTime.Now);
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
                    _project.NotesList.Remove(NotesL);
                    listBox1.Items.Clear();
                    LoadListToScreen();

                    if (_project.NotesList.Count != 0)
                    {
                        listBox1.SelectedIndex = 0;
                    }

                _project.NotesList = _project.SortingNote();

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
                var selectedNote = _project.NotesList[selectedIndex];
                var inner = new NewEditNoteForm();
                inner.Note = selectedNote; //Создаем форму
                var result = inner.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    //inner.EditNoteForm(selectedNote);
                    //Передаем форме данные
                    var updatenote = inner.Note;

                    listBox1.Items.RemoveAt(selectedIndex);
                    _project.NotesList.RemoveAt(selectedIndex);

                    _project.NotesList.Insert(selectedIndex, updatenote);
                    _project.NotesList = _project.SortingNote();
                    
                    ManagerProject.Save(_project);
                }
               
            }
        }

        private void SelectCategoryComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for(int i = 0; i < _project.NotesList.Count; i++)
            {

                if(_project.NotesList[i].CategoryNote == SelectCategoryComboBox1.Text)
                {
                    listBox1.Items.Add(_project.NotesList[i].Namenote);
                }

            }
        }
    }
    
}








