using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteApp;



namespace NoteApp
{
    
    ///Класс записок 
    public class Note
    {
        ///Название заметки 
        private string NameNote;

        ///Категории заметок 
        private string NoteCategory;

        ///Текст заметки 
        private string TextNote;

        ///Время создания 
        private DateTime CreatedOfTime;

        ///Время последнего изменения 
        private DateTime LastChangeTime;

        ///Заголовок заметки
        public string Namenote
        {
            get
            {
                return NameNote;
                
            }
            set
            {
                
                if (value.Length > 50)
                {
                    throw new ArgumentException("Длина заголовка заметки не должна быть более 50 символов" + value.Length);
                }
                else
                {
                    
                    NameNote = value;
                    
                    LastChangeTime = DateTime.Now;
                }
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

    
