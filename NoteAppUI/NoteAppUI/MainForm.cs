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

        

        List<Note> NotesList = new List<Note>();

        Note NotesL = new Note();

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

            for (int i = 0; i < _project.NotesList.Count; i++)
            {

                listBox1.Items.Add(_project.NotesList[i].Namenote);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

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
        //Удаление текущей заметки (+ прописать сообщение "Вы действительно хотите удалить файл?")
        private void removeNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _project.NotesList.Remove(NotesL);
            LoadListToScreen();
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

                NotesL = newNoteForm.note;

                _project.NotesList.Add(NotesL);
                listBox1.Items.Add(NotesL.Namenote);

            }
        }

        //Редактирование текущей заметки
        private void button2_Click(object sender, EventArgs e)
        {
            EditNote();

        }

        //Удаление текущей заметки (+ прописать сообщение "Вы действительно хотите удалить файл?")
        private void button3_Click(object sender, EventArgs e)
        {
            _project.NotesList.Remove(NotesL);
            LoadListToScreen();
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
                SelectCategoryComboBox1.Text = NotesL.Namenote;
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



        //метод редактирования заметки
        //1.при редактировании не видит данные, после нажатия Cancel заменяет
        //название заметки в листбоксе на текст заметки
        //2.при нажатии кнопки edit ошибка
        private void EditNote()
        {
           
            NewEditNoteForm newNoteForm = new NewEditNoteForm();

            var selectedIndex = listBox1.SelectedIndex;
            var selectedNote = _project.NotesList[selectedIndex];
            if (listBox1.SelectedIndex != -1)

            {
                var inner = new NewEditNoteForm(); //Создаем форму
                inner.EditNoteForm(selectedNote);
                inner.note = selectedNote; //Передаем форме данные
                inner.ShowDialog(); //Отображаем форму для редактирования

                var updatednote = inner.note;

                listBox1.Items.RemoveAt(selectedIndex);
                _project.NotesList.RemoveAt(selectedIndex);

                _project.NotesList.Insert(selectedIndex, updatednote);
                var text = updatednote.NoteText;
                listBox1.Items.Insert(selectedIndex, " " + text);
            } 
       }
    }
}




