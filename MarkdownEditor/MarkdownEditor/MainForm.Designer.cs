namespace MarkdownEditor
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtMarkdown = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.brsMarkdownPreview = new System.Windows.Forms.WebBrowser();
            this.timMarkdownPreview = new System.Windows.Forms.Timer(this.components);
            this.mnuMarkdown = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMarkdown.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMarkdown
            // 
            this.txtMarkdown.Location = new System.Drawing.Point(30, 87);
            this.txtMarkdown.Multiline = true;
            this.txtMarkdown.Name = "txtMarkdown";
            this.txtMarkdown.Size = new System.Drawing.Size(599, 590);
            this.txtMarkdown.TabIndex = 1;
            this.txtMarkdown.Text = "# Title\r\n- a\r\n- b\r\n- c\r\n\r\n1. x\r\n1. y\r\n1. z";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Markdown";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(656, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "HTML";
            // 
            // brsMarkdownPreview
            // 
            this.brsMarkdownPreview.Location = new System.Drawing.Point(660, 87);
            this.brsMarkdownPreview.MinimumSize = new System.Drawing.Size(20, 20);
            this.brsMarkdownPreview.Name = "brsMarkdownPreview";
            this.brsMarkdownPreview.Size = new System.Drawing.Size(622, 590);
            this.brsMarkdownPreview.TabIndex = 5;
            // 
            // timMarkdownPreview
            // 
            this.timMarkdownPreview.Enabled = true;
            this.timMarkdownPreview.Interval = 1000;
            this.timMarkdownPreview.Tick += new System.EventHandler(this.timMarkdownPreview_Tick);
            // 
            // mnuMarkdown
            // 
            this.mnuMarkdown.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnuMarkdown.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mnuMarkdown.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem});
            this.mnuMarkdown.Location = new System.Drawing.Point(0, 0);
            this.mnuMarkdown.Name = "mnuMarkdown";
            this.mnuMarkdown.Size = new System.Drawing.Size(1321, 48);
            this.mnuMarkdown.TabIndex = 6;
            this.mnuMarkdown.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(129, 38);
            this.FileToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.SaveToolStripMenuItem.Text = "名前を付けて保存(&S)";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 689);
            this.Controls.Add(this.brsMarkdownPreview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMarkdown);
            this.Controls.Add(this.mnuMarkdown);
            this.MainMenuStrip = this.mnuMarkdown;
            this.Name = "MainForm";
            this.Text = "MarkdownEditor";
            this.mnuMarkdown.ResumeLayout(false);
            this.mnuMarkdown.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMarkdown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.WebBrowser brsMarkdownPreview;
        private System.Windows.Forms.Timer timMarkdownPreview;
        private System.Windows.Forms.MenuStrip mnuMarkdown;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
    }
}

