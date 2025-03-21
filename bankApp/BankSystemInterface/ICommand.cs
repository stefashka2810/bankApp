namespace bankApp;

public interface ICommand<out T>
{
    T Execute();
}