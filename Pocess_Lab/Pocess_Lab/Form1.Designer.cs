namespace Pocess_Lab
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showProcessInfoToolStripMenuItem = new System.Windows.Forms.Button();
            this.terminateProcessToolStripMenuItem = new System.Windows.Forms.Button();
            this.refreshToolStripMenuItem = new System.Windows.Forms.Button();
            this.exportToFileToolStripMenuItem = new System.Windows.Forms.Button();
            this.showProcessThreadsToolStripMenuItem = new System.Windows.Forms.Button();
            this.showProcessModulesToolStripMenuItem = new System.Windows.Forms.Button();
            this.processListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(433, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Процеси";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // showProcessInfoToolStripMenuItem
            // 
            this.showProcessInfoToolStripMenuItem.Location = new System.Drawing.Point(71, 64);
            this.showProcessInfoToolStripMenuItem.Name = "showProcessInfoToolStripMenuItem";
            this.showProcessInfoToolStripMenuItem.Size = new System.Drawing.Size(175, 23);
            this.showProcessInfoToolStripMenuItem.TabIndex = 1;
            this.showProcessInfoToolStripMenuItem.Text = "Show Process Info";
            this.showProcessInfoToolStripMenuItem.UseVisualStyleBackColor = true;
            this.showProcessInfoToolStripMenuItem.Click += new System.EventHandler(this.showProcessInfoToolStripMenuItem_Click);
            // 
            // terminateProcessToolStripMenuItem
            // 
            this.terminateProcessToolStripMenuItem.Location = new System.Drawing.Point(71, 94);
            this.terminateProcessToolStripMenuItem.Name = "terminateProcessToolStripMenuItem";
            this.terminateProcessToolStripMenuItem.Size = new System.Drawing.Size(175, 23);
            this.terminateProcessToolStripMenuItem.TabIndex = 2;
            this.terminateProcessToolStripMenuItem.Text = "Terminate Process";
            this.terminateProcessToolStripMenuItem.UseVisualStyleBackColor = true;
            this.terminateProcessToolStripMenuItem.Click += new System.EventHandler(this.terminateProcessToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Location = new System.Drawing.Point(71, 124);
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(175, 23);
            this.refreshToolStripMenuItem.TabIndex = 3;
            this.refreshToolStripMenuItem.Text = "Refresh ";
            this.refreshToolStripMenuItem.UseVisualStyleBackColor = true;
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // exportToFileToolStripMenuItem
            // 
            this.exportToFileToolStripMenuItem.Location = new System.Drawing.Point(71, 154);
            this.exportToFileToolStripMenuItem.Name = "exportToFileToolStripMenuItem";
            this.exportToFileToolStripMenuItem.Size = new System.Drawing.Size(175, 23);
            this.exportToFileToolStripMenuItem.TabIndex = 4;
            this.exportToFileToolStripMenuItem.Text = "Export To File";
            this.exportToFileToolStripMenuItem.UseVisualStyleBackColor = true;
            this.exportToFileToolStripMenuItem.Click += new System.EventHandler(this.exportToFileToolStripMenuItem_Click);
            // 
            // showProcessThreadsToolStripMenuItem
            // 
            this.showProcessThreadsToolStripMenuItem.Location = new System.Drawing.Point(71, 184);
            this.showProcessThreadsToolStripMenuItem.Name = "showProcessThreadsToolStripMenuItem";
            this.showProcessThreadsToolStripMenuItem.Size = new System.Drawing.Size(175, 23);
            this.showProcessThreadsToolStripMenuItem.TabIndex = 5;
            this.showProcessThreadsToolStripMenuItem.Text = "Show Process Threads";
            this.showProcessThreadsToolStripMenuItem.UseVisualStyleBackColor = true;
            this.showProcessThreadsToolStripMenuItem.Click += new System.EventHandler(this.showProcessThreadsToolStripMenuItem_Click);
            // 
            // showProcessModulesToolStripMenuItem
            // 
            this.showProcessModulesToolStripMenuItem.Location = new System.Drawing.Point(71, 214);
            this.showProcessModulesToolStripMenuItem.Name = "showProcessModulesToolStripMenuItem";
            this.showProcessModulesToolStripMenuItem.Size = new System.Drawing.Size(175, 23);
            this.showProcessModulesToolStripMenuItem.TabIndex = 6;
            this.showProcessModulesToolStripMenuItem.Text = "Show Process Modules";
            this.showProcessModulesToolStripMenuItem.UseVisualStyleBackColor = true;
            this.showProcessModulesToolStripMenuItem.Click += new System.EventHandler(this.showProcessModulesToolStripMenuItem_Click);
            // 
            // processListView
            // 
            this.processListView.HideSelection = false;
            this.processListView.Location = new System.Drawing.Point(301, 64);
            this.processListView.Name = "processListView";
            this.processListView.Size = new System.Drawing.Size(492, 209);
            this.processListView.TabIndex = 7;
            this.processListView.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 450);
            this.Controls.Add(this.processListView);
            this.Controls.Add(this.showProcessModulesToolStripMenuItem);
            this.Controls.Add(this.showProcessThreadsToolStripMenuItem);
            this.Controls.Add(this.exportToFileToolStripMenuItem);
            this.Controls.Add(this.refreshToolStripMenuItem);
            this.Controls.Add(this.terminateProcessToolStripMenuItem);
            this.Controls.Add(this.showProcessInfoToolStripMenuItem);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.Button showProcessInfoToolStripMenuItem;
        private System.Windows.Forms.Button terminateProcessToolStripMenuItem;
        private System.Windows.Forms.Button refreshToolStripMenuItem;
        private System.Windows.Forms.Button exportToFileToolStripMenuItem;
        private System.Windows.Forms.Button showProcessThreadsToolStripMenuItem;
        private System.Windows.Forms.Button showProcessModulesToolStripMenuItem;
        private System.Windows.Forms.ListView processListView;
    }
}

