public interface ISelectable
{
    void OnSelect();
}

public interface IUpdatable
{
    void Refresh();
}

public class Screen : ISelectable, IUpdatable
{
    public void OnSelect()
    {
        Console.WriteLine("Вывод метода OnSelect");
    }

    public void Refresh()
    {
        Console.WriteLine("Вывод метода Refresh");

    }
}
public class Program
{
    public static void Main()
    {
        Screen screen = new Screen();
        screen.OnSelect();
        screen.Refresh();
    }
}