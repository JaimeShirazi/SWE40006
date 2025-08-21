using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;

namespace MS_Store_App
{
    public partial class WindowName : Form
    {
        public WindowName()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectFolder.ShowDialog();
            label1.Text = "Starting zip.";
            try
            {
                TestFastZipCreate(selectFolder.SelectedPath);
            }
            catch
            {
                label1.Text = "Zip failed.";
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e) { }

        #region Zip logic
        //Just going to put the code here because the program is so simple
        private int _uptoFileCount;
        private int _totalFileCount;

        public void TestFastZipCreate(string backupFolderPath)
        {
            _totalFileCount = FolderContentsCount(backupFolderPath);

            FastZipEvents events = new FastZipEvents();
            events.ProcessFile = ProcessFileMethod;
            FastZip fastZip = new FastZip(events);

            fastZip.CreateEmptyDirectories = true;

            DirectoryInfo targetFolderInfo = new DirectoryInfo(backupFolderPath);
            string zipFileName = targetFolderInfo.FullName + ".zip";

            fastZip.CreateZip(zipFileName, backupFolderPath, true, "");

            label1.Text = "Finished zipping!";
        }

        private void ProcessFileMethod(object sender, ScanEventArgs args)
        {
            _uptoFileCount++;
            int percentCompleted = _uptoFileCount * 100 / _totalFileCount;

            //The lines I added - updates the progress bar with the progress of the zip.
            progressBar1.Value = percentCompleted; 
            label1.Text = string.Format("Compressing: {0}/{1} Files", _uptoFileCount, _totalFileCount);

            string fileName = args.Name;
            // To terminate the process, set args.ContinueRunning = false
            if (fileName == "stop on this file")
                args.ContinueRunning = false;
        }

        /// <summary>
        /// Returns the number of files in this and all subdirectories
        /// </summary>
        private int FolderContentsCount(string path)
        {
            int result = Directory.GetFiles(path).Length;
            string[] subFolders = Directory.GetDirectories(path);
            foreach (string subFolder in subFolders)
            {
                result += FolderContentsCount(subFolder);
            }
            return result;
        }
        #endregion
    }
}
