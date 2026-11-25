using Observer.Exercise;

var downloader = new Downloader();

var l1 = new User();
var l2 = new User();

downloader.AddProgressObserver(l1);
downloader.AddFinishObserver(l2);

downloader.UpdateProgress(10);
downloader.UpdateProgress(50);
downloader.RemoveProgressObserver(l1);
downloader.UpdateProgress(100);

