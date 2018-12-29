﻿using System;
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
        public List<NoteApp.Note> NotesList = new List<NoteApp.Note>();

        public NoteApp.Note CurrentNote = new NoteApp.Note();

        public List<NoteApp.Note> SelectedNotes = new List<NoteApp.Note>();

        //метод Текущей заметки сделать через get set

        /// <summary>
        /// метод, который возвращает список заметок, отсортированный по дате изменения.
        /// </summary> 
        public List<NoteApp.Note> SortingNote(List<NoteApp.Note> ListToSort)
        {
            var sortedNotesList = ListToSort.OrderByDescending(x => x.ChangeTime);
            return sortedNotesList.ToList();
        }

        //метод для вывода заметок по категориям 
        public List<NoteApp.Note> SortingNote(string Find)
        {
            var sortedNote = NotesList.OrderByDescending(x => x.ChangeTime);
            var FindsortedNote = sortedNote.ToList().FindAll(x => x.CategoryNote.StartsWith(Find));
            return FindsortedNote;

        }
    }

}
