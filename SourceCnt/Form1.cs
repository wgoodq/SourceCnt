using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SourceCnt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void SetPath_Click(object sender, EventArgs e)
        {
            DialogResult dr = folderBrowserDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                FolderPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void CntLine_Click(object sender, EventArgs e)
        {
            try
            {
                string strFolderPath = FolderPath.Text;
                string strFileType = FileType.Text;

                if (strFolderPath.Equals(""))
                {
                    MessageBox.Show("请设置路径！");
                    return;
                }

                if (strFileType.Equals(""))
                {
                    MessageBox.Show("请指定文件类型！");
                    return;
                }

                RootFolder rootFolder = new RootFolder(strFolderPath, strFileType);
                string strRtn = rootFolder.Init();
                if (strRtn.Equals(""))
                {
                    // 没有消息就是好消息。
                    Output.Text = rootFolder.GetOutPutFilePath();
                }
                else
                {
                    MessageBox.Show(strRtn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
