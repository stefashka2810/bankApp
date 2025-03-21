namespace bankApp;

public interface IObserver
{
    void OnExportStarted();
    void OnExportCompleted();
    void OnExportError(string message);
}