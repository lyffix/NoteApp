using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NoteApp;
using NUnit.Framework.Constraints;
using NUnit;


namespace NoteApp.UnitTests
{
    [TestFixture]
    public class NoteTest
    {
        private Note note;

        [SetUp]
        public void UnitNote()
        {
            note = new Note();
        }

        [Test(Description = "Позитивный тест геттера Namenote")]
        public void TestNamenoteGet_CorrectValue()
        {
            var expected = "Название";

            var note = new Note();
            note.Namenote = expected;
            var actual = note.Namenote;
            Assert.AreEqual(expected, actual, "Геттер Namenote возвращает неправильный заголовок");
        }

        [Test(Description = "Негативный тест сеттера Namenote")]
        public void TestNamenoteSet_Longer50Symbols()
        {
            var wrongNamenote = "Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов";
            var note = new Note();
            Assert.Throws<ArgumentException>(
            () => { note.Namenote = wrongNamenote; },
            "Должно возникать исключение, если заголовок длиннее 50 символов");
        }

        [Test(Description = "Позитивный тест геттера CategoryNote")]
        public void TestCategoryNoteGet_CorrectValue()
        {
            var expected = "Ошибка в задании категории";

            var note = new Note();
            note.CategoryNote = expected;
            var actual = note.CategoryNote;
            Assert.AreEqual(expected, actual, "Геттер CategoryNote возвращает неправильную информацию");
        }

        [Test(Description = "Позитивный тест геттера NoteText")]
        public void TestNoteTextGet_CorrectValue()
        {
            var expected = "Ошибка в создании текста заметки";

            var note = new Note();
            note.NoteText = expected;
            var actual = note.NoteText;
            Assert.AreEqual(expected, actual, "Геттер NoteText возвращает неправильную информацию");
        }

        [Test(Description = "Позитивный тест геттера timeCreated")]
        public void TesttimeCreatedGet_CorrectValue()
        {
            var expected = new DateTime(2018, 12, 15);

            var note = new Note();
            note.timeCreated = expected;
            var actual = note.timeCreated;
            Assert.AreEqual(expected, actual, "Геттер timeCreated возвращает неправильную дату");
        }

       

        [Test(Description = "Позитивный тест геттера ChangeTime")]
        public void TestChangeTimeGet_CorrectValue()
        {
            var expected = new DateTime(2018, 12, 15);

            var note = new Note();
            note.timeCreated = expected;
            var actual = note.timeCreated;
            Assert.AreEqual(expected, actual, "Геттер ChangeTime возвращает неправильную дату");
        }

        
    }

}
