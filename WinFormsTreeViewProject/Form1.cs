namespace WinFormsTreeViewProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            AddDrivers();
        }

        void AddDrivers()
        {
            try
            {
                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    TreeNode nodeDrive = new() { Text = drive.Name };
                    AddDirectories(nodeDrive, drive.Name);
                    trvDrive.Nodes.Add(nodeDrive);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        void AddDirectories(TreeNode nodeParent, string path)
        {
            string[] dirs = Directory.GetDirectories(path);
            foreach (string dir in dirs)
            {
                TreeNode nodeDir = new();
                nodeDir.Text = dir.Remove(0, dir.LastIndexOf(@"\") + 1);
                nodeParent.Nodes.Add(nodeDir);
            }
        }

        private void trvDrive_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            e?.Node?.Nodes.Clear();
            string[] dirs;
            try
            {
                if(Directory.Exists(e?.Node?.FullPath))
                {
                    dirs = Directory.GetDirectories(e.Node.FullPath);
                    foreach(string dir in dirs)
                    {
                        TreeNode nodeDir = new() { Text = new DirectoryInfo(dir).Name };
                        AddDirectories(nodeDir, dir);
                        e.Node.Nodes.Add(nodeDir);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void trvDrive_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e?.Node?.Nodes.Clear();
            string[] dirs;
            try
            {
                if (Directory.Exists(e?.Node?.FullPath))
                {
                    dirs = Directory.GetDirectories(e.Node.FullPath);
                    foreach (string dir in dirs)
                    {
                        TreeNode nodeDir = new() { Text = new DirectoryInfo(dir).Name };
                        AddDirectories(nodeDir, dir);
                        e.Node.Nodes.Add(nodeDir);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}