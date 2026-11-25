using Observer.Exercise;

var downloader = new DownloaderWithEvents();

var l1 = new UserWithEvents();
var l2 = new UserWithEvents();
l1.ListenTo(downloader);
l1.IsInterestedInProgress = true;

l2.ListenTo(downloader);
l2.IsInterestedInFinish = true;

downloader.UpdateProgress(10);
l1.IsInterestedInProgress = false;

downloader.UpdateProgress(20);
l1.IsInterestedInProgress = true;

downloader.UpdateProgress(50);
l1.UnlistenTo(downloader);

downloader.UpdateProgress(100);

