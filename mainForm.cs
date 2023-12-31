﻿using Microsoft.WindowsAPICodePack.Dialogs;
using Microsoft.WindowsAPICodePack.Taskbar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace SPTLauncher_ConfigEditor
{
    public partial class mainForm : Form
    {
        public Color listBackcolor = Color.FromArgb(255, 35, 35, 35);
        public Color listSelectedcolor = Color.FromArgb(255, 50, 50, 50);
        public Color listHovercolor = Color.FromArgb(255, 45, 45, 45);
        public string currentDir = Environment.CurrentDirectory;
        string SPTMini;

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            string sptLauncher = $"SPT Launcher";
            if (IsProcessRunning(sptLauncher))
            {
                btnBrowse.Enabled = false;
                bApplyNewFiles.Enabled = false;
                bCloseLauncher.Enabled = true;
                bCloseLauncher.Visible = true;
            }
            else
            {
                btnBrowse.Enabled = true;
                bApplyNewFiles.Enabled = true;
                bCloseLauncher.Enabled = false;
                bCloseLauncher.Visible = false;
            }

            SPTMini = Path.Combine(currentDir, "SPT Mini.json");
            bool SPTMiniExists = File.Exists(SPTMini);
            if (SPTMiniExists)
            {
                object DevStatus = fetchStatus();
                bool simplemode = (bool)DevStatus;
                boolDeveloperMode.Enabled = true;
                boolDeveloperMode.Text = simplemode ? "ON" : "OFF";
            }
            else
            {
                boolDeveloperMode.Enabled = false;
                boolDeveloperMode.Text = "N/A";
            }

            itemDetector.Start();
            placeholder.Select();
        }

        private void addCustomHandlers(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                control.MouseDown += selectHandler;
                control.Click += selectHandler;

                if (control.HasChildren)
                {
                    addCustomHandlers(control.Controls);
                }
            }
        }

        private void selectHandler(object sender, EventArgs e)
        {
            placeholder.Select();
        }

        private void selectMouseHandler(object sender, MouseEventArgs e)
        {
            placeholder.Select();
        }

        private object fetchStatus()
        {
            try
            {
                string sptContent = File.ReadAllText(SPTMini);
                var serializer = new JavaScriptSerializer();
                var sptObject = serializer.Deserialize<Dictionary<string, object>>(sptContent);

                if (sptObject.ContainsKey("Developer_Options") && sptObject["Developer_Options"] is Dictionary<string, object> devOptions)
                {
                    if (devOptions.TryGetValue("Simple_Mode", out var simpleMode))
                    {
                        return simpleMode;
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching Simple_Mode: {ex.Message}");
                return null;
            }
        }

        private void removeListItem()
        {
            if (configItems.Items.Count > -1 && configItems.SelectedIndex > -1)
            {
                configItems.Items.Remove(configItems.SelectedItem);
            }

            placeholder.Select();
        }

        private void ToggleSimpleMode()
        {
            try
            {
                string sptContent = File.ReadAllText(SPTMini);
                var serializer = new JavaScriptSerializer();
                var sptObject = serializer.Deserialize<Dictionary<string, object>>(sptContent);

                if (!sptObject.ContainsKey("Developer_Options"))
                {
                    sptObject["Developer_Options"] = new Dictionary<string, object>();
                }

                var developerOptions = (Dictionary<string, object>)sptObject["Developer_Options"];

                if (!developerOptions.ContainsKey("Simple_Mode"))
                {
                    developerOptions["Simple_Mode"] = false;
                }

                if (boolDeveloperMode.Text.ToLower() == "on")
                {
                    boolDeveloperMode.Text = "OFF";
                    boolDeveloperMode.ForeColor = Color.IndianRed;
                    developerOptions["Simple_Mode"] = false;
                }
                else
                {
                    boolDeveloperMode.Text = "ON";
                    boolDeveloperMode.ForeColor = Color.DodgerBlue;
                    developerOptions["Simple_Mode"] = true;
                }

                string updatedSptContent = serializer.Serialize(sptObject);
                File.WriteAllText(SPTMini, updatedSptContent);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error toggling Simple_Mode: {ex.Message}");
            }
        }

        static bool IsProcessRunning(string processName)
        {
            Process[] processes = Process.GetProcessesByName(processName);
            return processes.Length > 0;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
        }

        private void btnBrowse_MouseDown(object sender, MouseEventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            dialog.IsFolderPicker = true;
            
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                string fullPath = Path.GetFullPath(dialog.FileName);
                configItems.Tag = fullPath;

                string[] configFiles = Directory.GetFiles(fullPath, "*.json");
                foreach (string file in configFiles)
                {
                    string fileName = Path.GetFileName(file);
                    configItems.Items.Add(fileName);
                }
            }
        }

        private void bApplyNewFiles_Click(object sender, EventArgs e)
        {

        }

        private void bApplyNewFiles_MouseDown(object sender, MouseEventArgs e)
        {
            string fullPath = configItems.Tag.ToString();

            try
            {
                foreach (string item in configItems.Items)
                {
                    string fullPathItem = Path.Combine(fullPath, item);
                    string originalPathItem = Path.Combine(currentDir, item);
                    File.Copy(fullPathItem, originalPathItem, true);
                }

                configItems.Tag = null;
                configItems.Items.Clear();

                if (MessageBox.Show($"Config files successfully copied.{Environment.NewLine}{Environment.NewLine}" +
                                    $"Would you like to exit now?", this.Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error transferring files: {ex.Message}", this.Text, MessageBoxButtons.OK);
                configItems.Items.Clear();
                configItems.Tag = null;
            }
        }

        private void configItems_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void configItems_DragDrop(object sender, DragEventArgs e)
        {
            string[] configFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            string parentPath = Path.GetFullPath(System.IO.Directory.GetParent(configFiles[0]).FullName);
            configItems.Tag = parentPath;

            foreach (string file in configFiles)
            {
                string fileName = Path.GetFileName(file);
                configItems.Items.Add(fileName);
            }
        }

        private void btnBrowse_MouseEnter(object sender, EventArgs e)
        {
            btnBrowse.BackColor = listSelectedcolor;
        }

        private void btnBrowse_MouseLeave(object sender, EventArgs e)
        {
            btnBrowse.BackColor = listBackcolor;
        }

        private void bApplyNewFiles_MouseEnter(object sender, EventArgs e)
        {
            bApplyNewFiles.BackColor = listSelectedcolor;
        }

        private void bApplyNewFiles_MouseLeave(object sender, EventArgs e)
        {
            bApplyNewFiles.BackColor = listBackcolor;
        }

        private void bExit_MouseEnter(object sender, EventArgs e)
        {
            bExit.BackColor = listSelectedcolor;
        }

        private void bExit_MouseLeave(object sender, EventArgs e)
        {
            bExit.BackColor = listBackcolor;
        }

        private void bExit_MouseDown(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void bCloseLauncher_MouseEnter(object sender, EventArgs e)
        {
            bCloseLauncher.BackColor = listSelectedcolor;
        }

        private void bCloseLauncher_MouseLeave(object sender, EventArgs e)
        {
            bCloseLauncher.BackColor = listBackcolor;
        }

        private void bCloseLauncher_MouseDown(object sender, MouseEventArgs e)
        {
            string appName = "SPT Launcher";
            Process[] processes = Process.GetProcessesByName(appName);

            if (processes.Length > 0)
            {
                foreach (Process process in processes)
                {
                    try
                    {
                        process.CloseMainWindow();
                        if (!process.WaitForExit(5000))
                        {
                            process.Kill();
                        }

                        btnBrowse.Enabled = true;
                        bApplyNewFiles.Enabled = true;
                        bCloseLauncher.Enabled = false;
                        bCloseLauncher.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error closing process: {ex.Message}");
                    }
                }
            }
        }

        private void boolDeveloperMode_MouseEnter(object sender, EventArgs e)
        {
            boolDeveloperMode.BackColor = listSelectedcolor;
        }

        private void boolDeveloperMode_MouseLeave(object sender, EventArgs e)
        {
            boolDeveloperMode.BackColor = listBackcolor;
        }

        private void boolDeveloperMode_MouseDown(object sender, MouseEventArgs e)
        {
            ToggleSimpleMode();
        }

        private void itemDetector_Tick(object sender, EventArgs e)
        {
            if (configItems.SelectedIndex > -1)
                bRemoveSelected.Enabled = true;
            else
                bRemoveSelected.Enabled = false;

            if (configItems.Items.Count == 0)
            {
                bApplyNewFiles.Enabled = false;
                bClearAll.Enabled = false;
            }
            else
            {
                bClearAll.Enabled = true;
            }
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (itemDetector != null)
            {
                itemDetector.Stop();
                itemDetector.Dispose();
            }
        }

        private void bRemoveSelected_Click(object sender, EventArgs e)
        {
        }

        private void bRemoveSelected_MouseDown(object sender, MouseEventArgs e)
        {
            removeListItem();   
        }

        private void bRemoveSelected_MouseEnter(object sender, EventArgs e)
        {
            bRemoveSelected.BackColor = listSelectedcolor;
        }

        private void bRemoveSelected_MouseLeave(object sender, EventArgs e)
        {
            bRemoveSelected.BackColor = listBackcolor;
        }

        private void bClearAll_Click(object sender, EventArgs e)
        {
        }

        private void bClearAll_MouseDown(object sender, MouseEventArgs e)
        {
            if (configItems.Items.Count > -1)
                configItems.Items.Clear();
        }

        private void bClearAll_MouseEnter(object sender, EventArgs e)
        {
            bClearAll.BackColor = listSelectedcolor;
        }

        private void bClearAll_MouseLeave(object sender, EventArgs e)
        {
            bClearAll.BackColor = listBackcolor;
        }

        private void configItems_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                removeListItem();
            }
        }
    }
}
