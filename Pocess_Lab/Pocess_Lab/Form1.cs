using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Pocess_Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RefreshProcessList();
        }

        private void RefreshProcessList()
        {
            processListView.Items.Clear();

            Process[] processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                ListViewItem item = new ListViewItem(process.Id.ToString());
                item.SubItems.Add(process.ProcessName);
                item.SubItems.Add(process.MainWindowTitle);
                item.Tag = process;
                processListView.Items.Add(item);
            }
        }

        private void showProcessInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (processListView.SelectedItems.Count > 0)
            {
                Process selectedProcess = (Process)processListView.SelectedItems[0].Tag;
                MessageBox.Show($"Process ID: {selectedProcess.Id}\n" +
                    $"Name: {selectedProcess.ProcessName}\n" +
                    $"Title: {selectedProcess.MainWindowTitle}");
            }
        }

        private void terminateProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (processListView.SelectedItems.Count > 0)
            {
                Process selectedProcess = (Process)processListView.SelectedItems[0].Tag;
                selectedProcess.Kill();
                RefreshProcessList();
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshProcessList();
        }

        private void exportToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
            saveFileDialog.FileName = "process_list.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (ListViewItem item in processListView.Items)
                    {
                        writer.WriteLine($"Process ID: {item.SubItems[0].Text}\t" +
                            $"Name: {item.SubItems[1].Text}\t" +
                            $"Title: {item.SubItems[2].Text}");
                    }
                }
            }
        }

        private void showProcessThreadsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (processListView.SelectedItems.Count > 0)
            {
                Process selectedProcess = (Process)processListView.SelectedItems[0].Tag;
                List<string> threadInfo = new List<string>();

                foreach (ProcessThread thread in selectedProcess.Threads)
                {
                    threadInfo.Add($"Thread ID: {thread.Id}\t" +
                        $"State: {thread.ThreadState}\t" +
                        $"Priority: {thread.PriorityLevel}");
                }

                MessageBox.Show(string.Join("\n", threadInfo));
            }
        }

        private void showProcessModulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (processListView.SelectedItems.Count > 0)
            {
                Process selectedProcess = (Process)processListView.SelectedItems[0].Tag;
                List<string> moduleInfo = new List<string>();

                foreach (ProcessModule module in selectedProcess.Modules)
                {
                    moduleInfo.Add($"Name: {module.ModuleName}\t" +
                        $"Path: {module.FileName}");
                }

                MessageBox.Show(string.Join("\n", moduleInfo));
            }
        }
    }
}
