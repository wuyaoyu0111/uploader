namespace ul
{
    public partial class �ϴ����� : Form
    {
        public �ϴ�����()
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
                openFileDialog.Filter = "����ļ� (*.xls)|*.xls";
                openFileDialog.Title = "��ѡ�������ʾ���޸Ĺ���ı���ļ�";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string sourcePath = openFileDialog.FileName;
                    string primaryDestPath = @"\\10.1.2.3\root\mindplus\cache\1" + Path.GetFileName(sourcePath);
                    string secondaryDestPath = @"\\192.168.123.1\root\mindplus\cache\1" + Path.GetFileName(sourcePath);

                    // ���Ը��Ƶ���·��
                    if (TryCopyFile(sourcePath, primaryDestPath))
                    {
                        MessageBox.Show("�ļ��Ѿ��ɹ��ϴ��������ն���Ӧ�ø���.", "���ѿ��ԶϿ����ն˵�����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (TryCopyFile(sourcePath, secondaryDestPath)) // �����·��ʧ�ܣ����Ա���·��
                    {
                        MessageBox.Show("�ļ��Ѿ��ɹ��ϴ��������ն���Ӧ�ø���.", "���ѿ��ԶϿ����ն˵�����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("�ϴ�ʧ��", "�������ն˵�����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // �û�û��ѡ���ļ���ر��˶Ի���
                    Application.Exit(); // ���û��ѡ���ļ���ر�Ӧ�ó���
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
    
