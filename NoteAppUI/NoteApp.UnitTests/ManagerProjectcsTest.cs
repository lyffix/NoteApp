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
            //Project TestCopy = ManagerProject.Des();
            Project TestSaveProject = new Project();
            Note NotesL = new Note();
            NotesL.Namenote = "Ksuxa";
            NotesL.CategoryNote = NoteApp.NoteCategory.Home.ToString();
            NotesL.NoteText = "kk";
            NotesL.timeCreated = new DateTime(2018, 12, 15);
            NotesL.ChangeTime = new DateTime(2018, 12, 15);

            TestSaveProject.NotesList.Add(NotesL);
            TestSaveProject.CurrentNote = NotesL;
            ManagerProject.Save(TestSaveProject);

            Project actual = ManagerProject.Des();
            //Project exception = TestSaveProject;
            //ManagerProject.Save(TestCopy);

            bool TestTrue = true;

            if (actual.NotesList[0].Namenote == TestSaveProject.NotesList[0].Namenote)
            {
                TestTrue = true;
            }
            else
            {
                TestTrue = false;
            }
            Assert.IsTrue(TestTrue);

        }


        [Test(Description = "Тест сериализации")]
        public void TestSerialization()
        {
            Project TestCopy = ManagerProject.Des();
            Project TestSaveProject = new Project();
            Note NotesL = new Note();
            NotesL.Namenote = "Katuxa";
            NotesL.CategoryNote = NoteApp.NoteCategory.Work.ToString();
            NotesL.NoteText = "kk";
            NotesL.timeCreated = new DateTime(2018, 12, 15);
            NotesL.ChangeTime = new DateTime(2018, 12, 15);
            TestSaveProject.NotesList.Add(NotesL);
            ManagerProject.Save(TestSaveProject);
          
        }
    }
}
    


