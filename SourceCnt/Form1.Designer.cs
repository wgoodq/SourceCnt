namespace SourceCnt
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SetPath = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.FileType = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CntLine = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FolderPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SetPath
            // 
            this.SetPath.Location = new System.Drawing.Point(12, 12);
            this.SetPath.Name = "SetPath";
            this.SetPath.Size = new System.Drawing.Size(100, 26);
            this.SetPath.TabIndex = 1;
            this.SetPath.Text = "选择目标路径";
            this.SetPath.UseVisualStyleBackColor = true;
            this.SetPath.Click += new System.EventHandler(this.SetPath_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "请选择工程的根目录";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "输入代码格式";
            // 
            // FileType
            // 
            this.FileType.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FileType.Location = new System.Drawing.Point(12, 88);
            this.FileType.Name = "FileType";
            this.FileType.Size = new System.Drawing.Size(242, 22);
            this.FileType.TabIndex = 5;
            this.FileType.Text = "*.java;*.cs;";
            // 
            // Output
            // 
            this.Output.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Output.Location = new System.Drawing.Point(12, 143);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(460, 23);
            this.Output.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "统计结果：";
            // 
            // CntLine
            // 
            this.CntLine.Location = new System.Drawing.Point(200, 200);
            this.CntLine.Name = "CntLine";
            this.CntLine.Size = new System.Drawing.Size(100, 30);
            this.CntLine.TabIndex = 8;
            this.CntLine.Text = "统计";
            this.CntLine.UseVisualStyleBackColor = true;
            this.CntLine.Click += new System.EventHandler(this.CntLine_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(419, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 11);
            this.label1.TabIndex = 9;
            this.label1.Text = "By YX.OK";
            // 
            // FolderPath
            // 
            this.FolderPath.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FolderPath.Location = new System.Drawing.Point(12, 44);
            this.FolderPath.Name = "FolderPath";
            this.FolderPath.Size = new System.Drawing.Size(460, 23);
            this.FolderPath.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 242);
            this.Controls.Add(this.FolderPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CntLine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.FileType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SetPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "代码行数统计工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SetPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FileType;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CntLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FolderPath;

    }
}

