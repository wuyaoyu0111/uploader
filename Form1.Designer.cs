namespace ul
{
    partial class 上传工具
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(上传工具));
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("微软雅黑", 15F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button1.Location = new Point(-4, -1);
            button1.Name = "button1";
            button1.Size = new Size(808, 460);
            button1.TabIndex = 0;
            button1.Text = resources.GetString("button1.Text");
            button1.TextAlign = ContentAlignment.TopLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // 上传工具
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Name = "上传工具";
            Text = "上传工具";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
    }
}
