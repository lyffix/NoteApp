using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteApp;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using NUnit;
using System.IO;

namespace NoteApp.UnitTests
{

    [TestFixture]
    public class ManagerProjectcsTest
    {


        [Test(Description = "Тест десериализации")]
        public void TestDeserialization()
        {
            Project TestCopy = ManagerProject.Des();
            Project TestSaveProject = new Project();
            Note NotesL = new Note();
            NotesL.Namenote = "Ksuxa";
            NotesL.CategoryNote = NoteCategory.Work;
            NotesL.NoteText = "kk";
            NotesL.timeCreated = new DateTime(2018, 12, 15);
            NotesL.ChangeTime = new DateTime(2018, 12, 15);

            TestSaveProject.NotesList.Add(NotesL);
            ManagerProject.Save(TestSaveProject);
            Project actual = new Project();

            actual = ManagerProject.Des();
            Project exception = TestSaveProject;
            ManagerProject.Save(TestCopy);

            bool TestTrue = true;

            if (actual.NotesList[0] == exception.NotesList[0])
            {
                TestTrue = true;
            }
            else
            {
                TestTrue = false;
            }
            Assert.AreEqual(true, TestTrue, " Десериализация работает некорректно");

        }


        [Test(Description = "Тест сериализации")]
        public void TestSerialization()
        {
            Project TestCopy = ManagerProject.Des();
            Project TestSaveProject = new Project();
            Note NotesL = new Note();
            NotesL.Namenote = "Katuxa";
            NotesL.CategoryNote = NoteCategory.Work;
            NotesL.NoteText = "kk";
            NotesL.timeCreated = new DateTime(2018, 12, 15);
            NotesL.ChangeTime = new DateTime(2018, 12, 15);
            TestSaveProject.NotesList.Add(NotesL);
            ManagerProject.Save(TestSaveProject);
            ManagerProject.Save(TestCopy);
        }
    }
}
    


