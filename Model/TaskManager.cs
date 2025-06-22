using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace Model;

public class TaskManager
{
    public void Write(List<TaskModel> tasks, string filePath)
    {
        var jsonSerializerOptions = new JsonSerializerOptions()
        {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
            WriteIndented = true
        };
        var jsonTasks = JsonSerializer.Serialize(tasks, jsonSerializerOptions);

        File.WriteAllText(filePath, jsonTasks);
    }

    public List<TaskModel> Read(string filePath)
    {
        var jsonFromFile = File.ReadAllText(filePath);
        var tasksFromFile = JsonSerializer.Deserialize<List<TaskModel>>(jsonFromFile);

        return tasksFromFile;
    }
}
