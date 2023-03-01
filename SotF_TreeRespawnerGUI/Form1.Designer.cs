namespace SotF_TreeRespawnerGUI
{
    partial class MainDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDialog));
            this.L_SaveFolder = new System.Windows.Forms.Label();
            this.TB_SaveFolder = new System.Windows.Forms.TextBox();
            this.B_SaveFolder = new System.Windows.Forms.Button();
            this.B_Respawn = new System.Windows.Forms.Button();
            this.L_FolderHint = new System.Windows.Forms.Label();
            this.L_Disclaimer = new System.Windows.Forms.Label();
            this.L_Result = new System.Windows.Forms.Label();
            this.B_Close = new System.Windows.Forms.Button();
            this.FolderDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // L_SaveFolder
            // 
            this.L_SaveFolder.AutoSize = true;
            this.L_SaveFolder.Location = new System.Drawing.Point(12, 25);
            this.L_SaveFolder.Name = "L_SaveFolder";
            this.L_SaveFolder.Size = new System.Drawing.Size(43, 15);
            this.L_SaveFolder.TabIndex = 0;
            this.L_SaveFolder.Text = "Folder:";
            // 
            // TB_SaveFolder
            // 
            this.TB_SaveFolder.Location = new System.Drawing.Point(61, 22);
            this.TB_SaveFolder.Name = "TB_SaveFolder";
            this.TB_SaveFolder.Size = new System.Drawing.Size(628, 23);
            this.TB_SaveFolder.TabIndex = 1;
            // 
            // B_SaveFolder
            // 
            this.B_SaveFolder.Location = new System.Drawing.Point(695, 21);
            this.B_SaveFolder.Name = "B_SaveFolder";
            this.B_SaveFolder.Size = new System.Drawing.Size(75, 23);
            this.B_SaveFolder.TabIndex = 2;
            this.B_SaveFolder.Text = "Select...";
            this.B_SaveFolder.UseVisualStyleBackColor = true;
            this.B_SaveFolder.Click += new System.EventHandler(this.B_SaveFolder_Click);
            // 
            // B_Respawn
            // 
            this.B_Respawn.Location = new System.Drawing.Point(356, 157);
            this.B_Respawn.Name = "B_Respawn";
            this.B_Respawn.Size = new System.Drawing.Size(75, 23);
            this.B_Respawn.TabIndex = 3;
            this.B_Respawn.Text = "Respawn";
            this.B_Respawn.UseVisualStyleBackColor = true;
            this.B_Respawn.Click += new System.EventHandler(this.B_Respawn_Click);
            // 
            // L_FolderHint
            // 
            this.L_FolderHint.Location = new System.Drawing.Point(61, 48);
            this.L_FolderHint.Name = "L_FolderHint";
            this.L_FolderHint.Size = new System.Drawing.Size(519, 31);
            this.L_FolderHint.TabIndex = 4;
            this.L_FolderHint.Text = "Hint: The save game folder is located under %APPDATA%..\\LocalLow\\Endnight\\SonsOfT" +
    "heForest\\Saves\\<SteamUserID>\\SinglePlayer\\ .";
            // 
            // L_Disclaimer
            // 
            this.L_Disclaimer.Location = new System.Drawing.Point(61, 90);
            this.L_Disclaimer.Name = "L_Disclaimer";
            this.L_Disclaimer.Size = new System.Drawing.Size(658, 52);
            this.L_Disclaimer.TabIndex = 5;
            this.L_Disclaimer.Text = resources.GetString("L_Disclaimer.Text");
            // 
            // L_Result
            // 
            this.L_Result.Location = new System.Drawing.Point(12, 188);
            this.L_Result.Name = "L_Result";
            this.L_Result.Size = new System.Drawing.Size(758, 18);
            this.L_Result.TabIndex = 6;
            this.L_Result.Text = "label1";
            this.L_Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // B_Close
            // 
            this.B_Close.Location = new System.Drawing.Point(356, 210);
            this.B_Close.Name = "B_Close";
            this.B_Close.Size = new System.Drawing.Size(75, 23);
            this.B_Close.TabIndex = 7;
            this.B_Close.Text = "Close";
            this.B_Close.UseVisualStyleBackColor = true;
            this.B_Close.Click += new System.EventHandler(this.B_Close_Click);
            // 
            // FolderDlg
            // 
            this.FolderDlg.AddToRecent = false;
            this.FolderDlg.AutoUpgradeEnabled = false;
            this.FolderDlg.RootFolder = System.Environment.SpecialFolder.UserProfile;
            this.FolderDlg.ShowNewFolderButton = false;
            // 
            // MainDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 245);
            this.Controls.Add(this.B_Close);
            this.Controls.Add(this.L_Result);
            this.Controls.Add(this.L_Disclaimer);
            this.Controls.Add(this.L_FolderHint);
            this.Controls.Add(this.B_Respawn);
            this.Controls.Add(this.B_SaveFolder);
            this.Controls.Add(this.TB_SaveFolder);
            this.Controls.Add(this.L_SaveFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sons of the Forest - Tree Respawner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainDialog_FormClosing);
            this.Load += new System.EventHandler(this.MainDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label L_SaveFolder;
        private TextBox TB_SaveFolder;
        private Button B_SaveFolder;
        private Button B_Respawn;
        private Label L_FolderHint;
        private Label L_Disclaimer;
        private Label L_Result;
        private Button B_Close;
        private FolderBrowserDialog FolderDlg;
    }
}