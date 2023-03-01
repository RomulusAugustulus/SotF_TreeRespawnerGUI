using Newtonsoft.Json;

namespace SotF_TreeRespawnerGUI
{
    public partial class MainDialog : Form
    {
        public MainDialog()
        {
            InitializeComponent();
        }

        private void MainDialog_Load(object sender, EventArgs e)
        {
            L_Result.Text = "";

            LoadSaveGameLocation();

            string localLowPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).Replace("Roaming", "LocalLow");
            FolderDlg.SelectedPath = localLowPath;
        }

        private void LoadSaveGameLocation()
        {
            if(File.Exists("config.txt"))
            {
                string saveGameFolder = File.ReadLines("config.txt").First();

                TB_SaveFolder.Text = saveGameFolder;
            }
        }

        private void B_SaveFolder_Click(object sender, EventArgs e)
        {
            if(FolderDlg.ShowDialog() == DialogResult.OK)
            {
                TB_SaveFolder.Text = FolderDlg.SelectedPath;
            }
        }

        private void B_Respawn_Click(object sender, EventArgs e)
        {
            string path = TB_SaveFolder.Text.Trim();

            if (path.Length > 0)
            {
                path = Path.Combine(path, "WorldObjectLocatorManagerSaveData.json");

                if(File.Exists(path))
                {
                    string worldObjectLocatorManagerJSON = File.ReadAllText(path);

                    WorldObjectLocatorManagerSaveData? worldObjectLocatorManagerSaveData = JsonConvert.DeserializeObject<WorldObjectLocatorManagerSaveData>(worldObjectLocatorManagerJSON);

                    if (worldObjectLocatorManagerSaveData != null)
                    {
                        WorldObjectLocatorManager? worldObjectLocatorManager = JsonConvert.DeserializeObject<WorldObjectLocatorManager>(worldObjectLocatorManagerSaveData.Data.WorldObjectLocatorManager);

                        for (int i = worldObjectLocatorManager.SerializedStates.Count - 1; i > -1; i--)
                        {
                            if (worldObjectLocatorManager.SerializedStates[i].Value == 3)
                            {
                                worldObjectLocatorManager.SerializedStates.RemoveAt(i);
                            }
                        }

                        worldObjectLocatorManagerSaveData.Data.WorldObjectLocatorManager = JsonConvert.SerializeObject(worldObjectLocatorManager);

                        worldObjectLocatorManagerJSON = JsonConvert.SerializeObject(worldObjectLocatorManagerSaveData);

                        File.WriteAllText(path, worldObjectLocatorManagerJSON);

                        L_Result.Text = "Success: Trees respawned!";
                    }
                    else
                    {
                        L_Result.Text = "Error: save game is corrupted or version not supported!";
                    }
                }
                else
                {
                    L_Result.Text = "Error: No save game found!";
                }
            }
            else
            {
                L_Result.Text = "Error: Please enter a valid path!";
            }
        }

        private void B_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(TB_SaveFolder.Text.Trim().Length > 0)
            {
                File.WriteAllText("config.txt", TB_SaveFolder.Text.Trim());
            }
        }
    }
}