using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteApp;



namespace NoteApp
{
    
    /// Класс записи 
    public class Note
    {
        /// Название заметки 
        private string NameNote;

        /// Категории заметок 
        private string NoteCategory;

        /// Текст заметки 
        private string TextNote;

        /// Время создания 
        private DateTime CreatedOfTime;

        /// Время последнего изменения 
        private DateTime LastChangeTime;

        /// Заголовок не болжен быть длинее 50 символов 
        public string Namenote
        {
            get
            {
                return NameNote;
            }
            set
            {
                
                NameNote = value;
                LastChangeTime = DateTime.Now;
            }
        }

       
        public string CategoryNote
        {
            get
            {
                return NoteCategory;
            }
            set
            {
                NoteCategory = value;
                
            }
        }

        //
        public string NoteText
        {
            get
            {
                return TextNote;
            }
            set
            {
                TextNote = value;
                LastChangeTime = DateTime.Now;
            }
        }

        //
        public DateTime timeCreated
        {
            get
            {
                return CreatedOfTime;
            }
            set
            {
                CreatedOfTime = value;
            }
        }

        public DateTime ChangeTime
        {
            get
            {
                return LastChangeTime;
            }

            set
            {
                LastChangeTime = value;
            }
        }

        
    }
}

    
