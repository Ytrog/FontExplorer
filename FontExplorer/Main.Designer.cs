namespace FontExplorer
{
    partial class Main
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            toolStripContainer1 = new ToolStripContainer();
            fontContainer = new FlowLayoutPanel();
            toolStrip1 = new ToolStrip();
            tbText = new ToolStripTextBox();
            btnShow = new ToolStripButton();
            toolTip1 = new ToolTip(components);
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(fontContainer);
            toolStripContainer1.ContentPanel.Size = new Size(800, 425);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(800, 450);
            toolStripContainer1.TabIndex = 0;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(toolStrip1);
            // 
            // fontContainer
            // 
            fontContainer.AutoScroll = true;
            fontContainer.Dock = DockStyle.Fill;
            fontContainer.Location = new Point(0, 0);
            fontContainer.Name = "fontContainer";
            fontContainer.Size = new Size(800, 425);
            fontContainer.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.Items.AddRange(new ToolStripItem[] { tbText, btnShow });
            toolStrip1.Location = new Point(3, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(154, 25);
            toolStrip1.TabIndex = 0;
            // 
            // tbText
            // 
            tbText.MaxLength = 15;
            tbText.Name = "tbText";
            tbText.Size = new Size(100, 25);
            // 
            // btnShow
            // 
            btnShow.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnShow.Image = (Image)resources.GetObject("btnShow.Image");
            btnShow.ImageTransparentColor = Color.Magenta;
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(40, 22);
            btnShow.Text = "Show";
            btnShow.ToolTipText = "Show the text in different fonts";
            btnShow.Click += btnShow_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStripContainer1);
            Name = "Main";
            Text = "Font Explorer";
            WindowState = FormWindowState.Maximized;
            Shown += Main_Shown;
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStripContainer toolStripContainer1;
        private ToolStrip toolStrip1;
        private ToolStripTextBox tbText;
        private ToolStripButton btnShow;
        private FlowLayoutPanel fontContainer;
        private ToolTip toolTip1;
    }
}
