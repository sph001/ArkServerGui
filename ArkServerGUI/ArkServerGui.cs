using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArkServerCore;

namespace ArkServerGUI
{
    public partial class ArkServerGUI : Form
    {
        readonly Server _arkServer = new Server();

        int ServerButtonClickCount = 0;
        public ArkServerGUI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ProcessSettings();
        }

        private void ProcessSettings()
        {
            if (this._arkServer.Settings.SessionName != null)
            { this.SessionNameTextBox.Text = this._arkServer.Settings.SessionName; }
            else { this.SessionNameTextBox.BackColor = Color.Red; }
            if (this._arkServer.Settings.QueryPort != 0)
            { this.PortTextBox.Text = this._arkServer.Settings.QueryPort.ToString(); }
            else { this.PortTextBox.BackColor = Color.Red; }
            if (this._arkServer.Settings.ServerAdminPassword != null)
            { this.AdminPasswordTextBox.Text = this._arkServer.Settings.ServerAdminPassword; }
            else { this.AdminPasswordTextBox.BackColor = Color.Red; }

            this.PveServerCheckBox.Checked = this._arkServer.Settings.ServerPVE;
            this.HardcoreCheckBox.Checked = this._arkServer.Settings.ServerHardcore;
            this.CrosshairsCheckBox.Checked = this._arkServer.Settings.ServerCrosshair;
            this.ForceNoHudCheckBox.Checked = this._arkServer.Settings.ServerForceNoHud;
            this.GlobalVoiceChatCheckBox.Checked = this._arkServer.Settings.GlobalVoiceChat;
            this.NoTributeDownloadsCheckBox.Checked = this._arkServer.Settings.NoTributeDownloads;
            this.AllowThirdPersonCheckBox.Checked = this._arkServer.Settings.AllowThirdPersonPlayer;
            this.NotifyPlayerLeftCheckBox.Checked = this._arkServer.Settings.AllowsNotifyPlayerLeft;
            this.DontAlwaysNotifyPlayerJoinedCheckBox.Checked = this._arkServer.Settings.DontAlwaysNotifyPlayerJoined;
            this.MapPlayerLocationCheckBox.Checked = this._arkServer.Settings.MapPlayerLocation;
            this.DifficultyTextBox.Text = this._arkServer.Settings.Difficulty.ToString();
            this.MaxPlayersTextBox.Text = this._arkServer.Settings.MaxPlayers.ToString();
            this.PasswordTextBox.Text = this._arkServer.Settings.ServerPassword;
            this.MessageOfTheDayRichTextBox.Text = this._arkServer.Settings.MessageOfTheDay;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this._arkServer.SaveSettings();
        }

        private async void UpdateServerBtn_Click(object sender, EventArgs e)
        {
            this.UpdateServerBtn.Enabled = false;
            this._arkServer.SteamCmd.StartUpdate();
            while (!this._arkServer.SteamCmd.SteamProcess.HasExited)
            {

                await Task.Run(() => Thread.Sleep(100));
            }
            this.UpdateServerBtn.Enabled = true;
        }

        private async void StartServerButton_Click(object sender, EventArgs e)
        {
            if (this.ServerButtonClickCount % 2 == 0)
            {
                this.StartServerButton.Text = "Stop Server";
                await Task.Run(() => this._arkServer.StartServer());
            }
            else
            {
                this.StartServerButton.Text = "Start Server";
                await Task.Run(() => this._arkServer.CloseSever());
            }
            this.ServerButtonClickCount = this.ServerButtonClickCount + 1;
        }

        private void PveServerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this._arkServer.Settings.ServerPVE = this.PveServerCheckBox.Checked;
        }

        private void HardcoreCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this._arkServer.Settings.ServerHardcore = this.HardcoreCheckBox.Checked;
        }

        private void CrosshairsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this._arkServer.Settings.ServerCrosshair = this.CrosshairsCheckBox.Checked;
        }

        private void ForceNoHudCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this._arkServer.Settings.ServerForceNoHud = this.ForceNoHudCheckBox.Checked;
        }

        private void GlobalVoiceChatCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this._arkServer.Settings.GlobalVoiceChat = this.GlobalVoiceChatCheckBox.Checked;
        }

        private void NoTributeDownloadsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this._arkServer.Settings.NoTributeDownloads = this.NoTributeDownloadsCheckBox.Checked;
        }

        private void AllowThirdPersonCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this._arkServer.Settings.AllowThirdPersonPlayer = this.AllowThirdPersonCheckBox.Checked;
        }

        private void NotifyPlayerLeftCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this._arkServer.Settings.AllowsNotifyPlayerLeft = this.NotifyPlayerLeftCheckBox.Checked;
        }

        private void DontAlwaysNotifyPlayerJoinedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this._arkServer.Settings.DontAlwaysNotifyPlayerJoined = this.DontAlwaysNotifyPlayerJoinedCheckBox.Checked;
        }

        private void MapPlayerLocationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this._arkServer.Settings.MapPlayerLocation = this.MapPlayerLocationCheckBox.Checked;
        }

        private void SessionNameTextBox_TextChanged(object sender, EventArgs e)
        {
            this._arkServer.Settings.SessionName = this.SessionNameTextBox.Text;
            if (this.SessionNameTextBox.Text != string.Empty)
            {
                this.SessionNameTextBox.BackColor = Color.Empty;
            }
            else this.SessionNameTextBox.BackColor = Color.Red;
        }

        private void PortTextBox_TextChanged(object sender, EventArgs e)
        {
            this._arkServer.Settings.QueryPort = Convert.ToInt32(this.PortTextBox.Text);
            if (this.PortTextBox.Text != string.Empty)
            {
                this.PortTextBox.BackColor = Color.Empty;
            }
            else this.PortTextBox.BackColor = Color.Red;
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            this._arkServer.Settings.ServerPassword = this.PasswordTextBox.Text;
        }

        private void AdminPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            this._arkServer.Settings.ServerAdminPassword = this.AdminPasswordTextBox.Text;
            if (this.AdminPasswordTextBox.Text != String.Empty)
            {
                this.AdminPasswordTextBox.BackColor = Color.Empty;
            }
            else this.AdminPasswordTextBox.BackColor = Color.Red;
        }

        private void DifficultyTextBox_TextChanged(object sender, EventArgs e)
        {
            this._arkServer.Settings.Difficulty = decimal.Parse(this.DifficultyTextBox.Text);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

            this._arkServer.Settings.MessageOfTheDay = this.MessageOfTheDayRichTextBox.Text.Replace("\n", "\\n");
        }

        private void MaxPlayersTextBox_TextChanged(object sender, EventArgs e)
        {
            this._arkServer.Settings.MaxPlayers = Convert.ToInt32(this.MaxPlayersTextBox.Text);
        }

        private void MaxPlayersTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void DifficultyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (e.KeyChar != '.')
                {
                    e.Handled = true;
                }
            }
        }

        private void PortTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void DisableStructureDecayPveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this._arkServer.Settings.bDisableStructureDecayPve = this.DisableStructureDecayPveCheckBox.Checked;
        }

        private void AllowFlyerCarryPveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this._arkServer.Settings.bAllowFlyerCarryPve = this.AllowFlyerCarryPveCheckBox.Checked;
        }

        private void EnablePvPGamaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this._arkServer.Settings.EnablePvpGama = this.EnablePvPGamaCheckBox.Checked;
        }

        private void MaxStructuresInRangeTextBox_TextChanged(object sender, EventArgs e)
        {
            this._arkServer.Settings.MaxStructuresInRange = Convert.ToInt32(this.MaxStructuresInRangeTextBox.Text);
        }

        private void MaxStructuresInRangeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
