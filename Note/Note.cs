using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note
{

    public enum NoteCategory
    {
        Work,
        Home,
        HealtfandSport,
        People,
        Doc,
        Finance,
        Other
    }

    public class Note
    {
        private string name;
        private string category;
        private DateTime creationDate;
        private DateTime editDate;
        private string text;
        
    }
}
