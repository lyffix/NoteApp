using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteApp;
using System.Collections.Concurrent;

namespace NoteApp
{
    /// <summary>
    /// Класс проекта, содержащий список всех заметок
    /// </summary>
    public class Project
    {
        public List<Note> NotesList = new List<Note>();


        /// <summary>
        /// метод, который возвращает список заметок, отсортированный по дате изменения.
        /// </summary> 
        public List<Note> SortingNote()
        {
            var sortedNotesList = NotesList.OrderBy(x => x.ChangeTime);
            return sortedNotesList.ToList();
        }

        //метод для вывода заметок по категориям 
        public List<Note> SortingNote(string Find)
        {
            var sortedNote = NotesList.OrderBy(x => x.ChangeTime);
            var FindsortedNote = sortedNote.ToList().FindAll(x => x.CategoryNote.StartsWith(Find));
            return FindsortedNote;

        }
    }

}
