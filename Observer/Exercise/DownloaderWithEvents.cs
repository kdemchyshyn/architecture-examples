namespace Observer.Exercise;

public class DownloaderWithEvents
{
    public Action<int> OnUpdateProgress;
    public Action OnFinished;
    
    private int progress = 0;
    public void UpdateProgress(int percentage)
    {
        if (percentage <= progress)
        {
            return;
        }
        
        progress = percentage;
        OnUpdateProgress?.Invoke(progress);

        if (progress == 100)
        {
            OnFinished?.Invoke();
        }
    }
}

public class UserWithEvents
{
    public bool IsInterestedInProgress { get; set; } = false;
    public bool IsInterestedInFinish { get; set; } = false;
    
    private DownloaderWithEvents downloader;

    public void ListenTo(DownloaderWithEvents downloader)
    {
        this.downloader = downloader;
        downloader.OnUpdateProgress += OnUpdateProgress;
        downloader.OnFinished += OnFinished;
    }

    public void UnlistenTo(DownloaderWithEvents downloader)
    {
        downloader.OnUpdateProgress -= OnUpdateProgress;
        downloader.OnFinished -= OnFinished;
    }
    
    private void OnUpdateProgress(int progress)
    {
        if (IsInterestedInProgress)
        {
            Console.WriteLine($"Current progress: {progress}%");
        }
    }

    private void OnFinished()
    {
        if (IsInterestedInFinish)
        {
            Console.WriteLine($"Download finished!");
        }
    }
}