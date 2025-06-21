namespace Model;

public class TaskModel
{
    public required string Name { get; set; }
    public bool IsComplete {  get; set; }

    public override string ToString()
    {
        return $"Название: {Name} Статус: {GetStatus(IsComplete)}";
    }

    public string GetStatus(bool isComplete)
    {
        if (isComplete)
        {
            return "Выполено";
        }

        return "Не выполнено";
    }
}
