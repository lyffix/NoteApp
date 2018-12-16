using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
namespace NoteApp
{
    /// <summary>
    /// Класс менеджер проекта, реализующий метод для сохранения "Проект" в файл и метод загрузки проекта из файла
    /// </summary>
    public class ManagerProject
    {

        public static void Save(Project S)

        {
             string File = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\notes.xml";
            //Создаём экземпляр сериализатора
            JsonSerializer serializer = new JsonSerializer();

            //Открываем поток для записи в файл с указанием пути
            using (StreamWriter sw = new StreamWriter(File))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                //Вызываем сериализацию и передаем объект, который хотим сериализовать
                serializer.Serialize(writer, S);
            }
        }

        public static Project Des()
        {
            string File = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\notes.xml";
            //Создаём переменную, в которую поместим результат десериализации
            Project Des = null;
            //Создаём экземпляр сериализатора
            JsonSerializer serializer = new JsonSerializer();
            try
            {
                //Открываем поток для чтения из файла с указанием пути
                using (StreamReader sr = new StreamReader(File))
                using (JsonReader reader = new JsonTextReader(sr))

                {
                    //Вызываем десериализацию и явно преобразуем результат в целевой тип данных
                    Des = serializer.Deserialize<Project>(reader);
                }
            }
            catch (Exception expected)
            {
                Des = new Project();
            }
            if (Des == null)
                Des = new Project();
            return Des;

        }
    }
}
