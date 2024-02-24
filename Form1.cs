namespace ul
{
    public partial class 上传工具 : Form
    {
        public 上传工具()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "表格文件 (*.xls)|*.xls";
                openFileDialog.Title = "请选择你根据示例修改过后的表格文件";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string sourcePath = openFileDialog.FileName;
                    string primaryDestPath = @"\\10.1.2.3\root\mindplus\cache\1" + Path.GetFileName(sourcePath);
                    string secondaryDestPath = @"\\192.168.123.1\root\mindplus\cache\1" + Path.GetFileName(sourcePath);

                    // 尝试复制到主路径
                    if (TryCopyFile(sourcePath, primaryDestPath))
                    {
                        MessageBox.Show("文件已经成功上传，重启终端以应用更改.", "现已可以断开与终端的连接", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (TryCopyFile(sourcePath, secondaryDestPath)) // 如果主路径失败，尝试备用路径
                    {
                        MessageBox.Show("文件已经成功上传，重启终端以应用更改.", "现已可以断开与终端的连接", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("上传失败", "请检查与终端的连接", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // 用户没有选择文件或关闭了对话框
                    Application.Exit(); // 如果没有选择文件则关闭应用程序
                }
            }
        }

        private bool TryCopyFile(string sourcePath, string destPath)
        {
            try
            {
                File.Copy(sourcePath, destPath, overwrite: true);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
    
