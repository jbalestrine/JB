using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;
using TeamDigitalJB.Properties;

namespace TeamDigitalJB
{
	public class FormTeamDigitalJB : Form
	{

		private const string dragDropFormat = "FileDrop";

		private IContainer components = null;

		private SplitContainer splitContainer1;

		private GroupBox groupBox1;

		private TextBox textBoxScript;

		private Panel panel1;

		private Button buttonRunScript;

		private GroupBox groupBox2;

		private TextBox textBoxOutput;

		private Button bBrowse;

		private Button button1;

		private Button button2;

		private Button button3;

		private MenuStrip menuStrip1;

		private ToolStripMenuItem scriptsToolStripMenuItem;

		private ToolStripMenuItem checkUptimeToolStripMenuItem;

		private ToolStripMenuItem checkLastUpdateToolStripMenuItem;

		private ToolStripMenuItem checkRebootRequiredToolStripMenuItem;

		private ToolStripMenuItem openWebConfigToolStripMenuItem;

		private ToolStripMenuItem restartAppPoolToolStripMenuItem;

		private ToolStripMenuItem azureServicesToolStripMenuItem;

		private ToolStripMenuItem reDeployServerToolStripMenuItem;

		private ToolStripMenuItem nSGsToolStripMenuItem;

		private ToolStripMenuItem createVMToolStripMenuItem;

		private ToolStripMenuItem resetPasswordMasterAdminToolStripMenuItem;

		private ToolStripMenuItem dashBoardsToolStripMenuItem;

		private ToolStripMenuItem rDPToolStripMenuItem;

		private ToolStripMenuItem downloadsToolStripMenuItem;

		private ToolStripMenuItem aboutToolStripMenuItem;

		private ToolStripMenuItem aUTH01ToolStripMenuItem;

		private ToolStripMenuItem oPENINNOTEPADToolStripMenuItem;

		private ToolStripMenuItem oPENINOUTPUTToolStripMenuItem;

		private ToolStripMenuItem aUTH02ToolStripMenuItem;

		private ToolStripMenuItem dATA01ToolStripMenuItem;

		private ToolStripMenuItem dATA02ToolStripMenuItem;

		private ToolStripMenuItem oPENINNOTEPADToolStripMenuItem1;

		private ToolStripMenuItem aZSCTDWEBD01ToolStripMenuItem;

		private ToolStripMenuItem aboutJoeBalestrineToolStripMenuItem;

		private ToolStripMenuItem downloadPRISMCLIENTToolStripMenuItem;

		private ToolStripMenuItem certificatesToolStripMenuItem;

		private ToolStripMenuItem createCAsToolStripMenuItem;

		private ToolStripMenuItem createUserLicenseToolStripMenuItem;

		private ToolStripMenuItem createToolStripMenuItem;

		private ToolStripMenuItem lOGSToolStripMenuItem;

		private ToolStripMenuItem aZSCTDWEBD01ToolStripMenuItem1;

		private ToolStripMenuItem applicationLogsToolStripMenuItem;

		private ToolStripMenuItem systemLogsToolStripMenuItem;

		private ToolStripMenuItem errorLogsToolStripMenuItem;

		private ToolStripMenuItem warningLogsToolStripMenuItem;

		private ToolStripMenuItem aZSCTDWEBD02ToolStripMenuItem;

		private ToolStripMenuItem aZSCTDSQLD01ToolStripMenuItem;

		private ToolStripMenuItem aZSCTDSQLD02ToolStripMenuItem;

		private ToolStripMenuItem aZSCTDWEBD041ToolStripMenuItem;

		private ToolStripMenuItem aZSCTDWEBD042ToolStripMenuItem;

		private ToolStripMenuItem aZSCTDADD01ToolStripMenuItem;

		private ToolStripMenuItem sECURITYPATCHINGToolStripMenuItem;

		private ToolStripMenuItem wSUSToolStripMenuItem;

		private ToolStripMenuItem deployModulesToolStripMenuItem;

		private ToolStripMenuItem getWUHistoryToolStripMenuItem;

		private ToolStripMenuItem exportcsvseeOutputForPathToolStripMenuItem;

		private ToolStripMenuItem checkWebServiceToolStripMenuItem;

		private ToolStripMenuItem authServiceToolStripMenuItem;

		private ToolStripMenuItem dataServiceToolStripMenuItem;

		private ToolStripMenuItem subscriptionServiceToolStripMenuItem;

		private ToolStripMenuItem relayServiceToolStripMenuItem;

		private ToolStripMenuItem last10ToolStripMenuItem;

		private ToolStripMenuItem last10ToolStripMenuItem1;

		private ToolStripMenuItem restartIISToolStripMenuItem;

		private ToolStripMenuItem aPPPOOLToolStripMenuItem;

		private ToolStripMenuItem iISSERVICEToolStripMenuItem;

		private ToolStripMenuItem restartServicesToolStripMenuItem;

		private ToolStripMenuItem restoreDataBaseToolStripMenuItem;

		private ToolStripMenuItem pRODFeaturesToolStripMenuItem;

		private ToolStripMenuItem prodToolStripMenuItem;

		private ToolStripMenuItem prodToolStripMenuItem1;

		private ToolStripMenuItem dBRestoreBackupToolStripMenuItem;

		private ToolStripMenuItem restoreDBToolStripMenuItem;

		private ToolStripMenuItem backupDBToolStripMenuItem;

		private ToolStripMenuItem prodAuthToolStripMenuItem;

		private ToolStripMenuItem appdataToolStripMenuItem;

		private ToolStripMenuItem openAppDataToolStripMenuItem;

		private ToolStripMenuItem licenseUserToolStripMenuItem;

		private ToolStripMenuItem licenseUserToolStripMenuItem1;

		private ToolStripMenuItem licenseAppToolStripMenuItem1;

		private ToolStripMenuItem teamDigitalDeploymentAppToolStripMenuItem;

		private ToolStripMenuItem verifyServicesRunningToolStripMenuItem;

		private ToolStripMenuItem loadCustomScriptToolStripMenuItem;

		private ToolStripMenuItem loadScriptToolStripMenuItem;

		private RadioButton radioButton1;

		private RadioButton radioButton3;

		private RadioButton radioButton2;

		private PictureBox pictureBox1;

		private ToolStripMenuItem aZSCTDWEBD02ToolStripMenuItem1;

		private ToolStripMenuItem aZSCTDWEBD03ToolStripMenuItem;

		private ToolStripMenuItem aZSCTDSQLD01ToolStripMenuItem1;

		private ToolStripMenuItem aZSCTDSQLD02ToolStripMenuItem1;

		private ToolStripMenuItem aZSCTDADD01ToolStripMenuItem1;

		private ToolStripMenuItem aZSCTDWEBD041ToolStripMenuItem1;

		private ToolStripMenuItem aZSCTDWEBD042ToolStripMenuItem1;

		private LinkLabel linkLabel1;

		private PictureBox pictureBox4;

		private LinkLabel linkLabel4;

		private PictureBox pictureBox3;

		private LinkLabel linkLabel3;

		private PictureBox pictureBox2;

		private LinkLabel linkLabel2;

		private PictureBox pictureBox6;

		private PictureBox pictureBox5;

		private LinkLabel linkLabel6;

		private LinkLabel linkLabel5;

		private ToolStripMenuItem getSQLUsersToolStripMenuItem;

		private ToolStripMenuItem sQLLOGINSToolStripMenuItem;

		private ToolStripMenuItem cPUUtilizationReportsToolStripMenuItem;

		private ToolStripMenuItem ramUtilizationReportsToolStripMenuItem;

		private ToolStripMenuItem allResourceUtilizationReportsToolStripMenuItem;

		private ToolStripMenuItem downtimeToolStripMenuItem;

		private ToolStripMenuItem outagesToolStripMenuItem;

		private ToolStripMenuItem teamDigitalToolStripMenuItem;

		private ToolStripMenuItem teamMembersToolStripMenuItem;

		private ToolStripMenuItem servicesToolStripMenuItem;

		private TabControl ServerUp;

		private TabPage tabPage1;

		private TabPage tabPage2;

		private PictureBox pictureBox7;

		private PictureBox pictureBox8;

		private Label label2;

		private Label label1;

		private Timer ServerCheck1;

		private Timer azsctdwebd01TIMER;

		private Timer tdwebd02TIMER;

		private Timer tdwebd041TIMER;

		private Timer d042TIMER;
        private ToolStripMenuItem sMOKETESTINGDEPLOYMENTSToolStripMenuItem;
        private ToolStripMenuItem cHECKSERVICES7010AUTHToolStripMenuItem;
        private ToolStripMenuItem cHECKSERVICES7011DATAToolStripMenuItem;
        private ToolStripMenuItem cHECKSQLLOGINToolStripMenuItem;
        private ToolStripMenuItem cHECKSQLSTATEMENTToolStripMenuItem;
        private ToolStripMenuItem cHECKSQLQUERYToolStripMenuItem;
        private ToolStripMenuItem cHECKBACKUPDATEToolStripMenuItem;
        private ToolStripMenuItem verifySQLRestoreDateToolStripMenuItem;
        private ToolStripMenuItem runALLVerificationChecksToolStripMenuItem;
        private ToolStripMenuItem oUTPUTTOCOMMANDSHELLToolStripMenuItem;
        private ToolStripMenuItem oUTPUTTOFILEToolStripMenuItem;
        private ToolStripMenuItem cSVToolStripMenuItem;
        private ToolStripMenuItem tXTToolStripMenuItem;
        private ToolStripMenuItem smokeTestingMigrationsToolStripMenuItem;
        private ToolStripMenuItem runAllVerificationChecksToolStripMenuItem1;
        private ToolStripMenuItem outputToCommandShellToolStripMenuItem1;
        private ToolStripMenuItem outputToFileToolStripMenuItem1;
        private ToolStripMenuItem convertToCSVToolStripMenuItem;
        private ToolStripMenuItem convertToTXTToolStripMenuItem;
        private ToolStripMenuItem checkFileSizeToolStripMenuItem;
        private ToolStripMenuItem checkFolderReadWritePermissionsToolStripMenuItem;
        private ToolStripMenuItem checkDBBackupSuccessfullToolStripMenuItem;
        private ToolStripMenuItem checkServerUptimeToolStripMenuItem;
        private ToolStripMenuItem verifyIfRebootIsRequiredToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem verifyServiceOnlineToolStripMenuItem;
        private ToolStripMenuItem verifyBinaryVersionToolStripMenuItem;
        private ToolStripMenuItem verifyFileDateToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem dATAToolStripMenuItem;
        private ToolStripMenuItem aUTHToolStripMenuItem;
        private ToolStripMenuItem rELAYToolStripMenuItem;
        private ToolStripMenuItem healthCheckToolStripMenuItem;
        private ToolStripMenuItem runFullHealthCheckToolStripMenuItem;
        private ToolStripMenuItem runSoundGeneratorToolStripMenuItem;
        private ToolStripMenuItem gen1ToolStripMenuItem;
        private Timer tdsqld01TIMER;

		public FormTeamDigitalJB()
		{
			this.InitializeComponent();
		}

		private void buttonRunScript_Click(object sender, EventArgs e)
		{
			try
			{
				this.textBoxOutput.Clear();
				this.textBoxOutput.Text = this.RunScript(this.textBoxScript.Text);
			}
			catch (Exception ex)
			{
				TextBox expr_36 = this.textBoxOutput;
				expr_36.Text += string.Format("\r\nError in script : {0}\r\n", ex.Message);
			}
		}

		private string RunScript(string scriptText)
		{
			Runspace runspace = RunspaceFactory.CreateRunspace();
			runspace.Open();
			Pipeline pipeline = runspace.CreatePipeline();
			pipeline.Commands.AddScript(scriptText);
			pipeline.Commands.Add("Out-String");
			Collection<PSObject> collection = pipeline.Invoke();
			runspace.Close();
			StringBuilder stringBuilder = new StringBuilder();
			foreach (PSObject current in collection)
			{
				stringBuilder.AppendLine(current.ToString());
			}
			return stringBuilder.ToString();
		}

		private void FormPowerShellSample_DragDrop(object sender, DragEventArgs e)
		{
			bool dataPresent = e.Data.GetDataPresent("FileDrop");
			if (dataPresent)
			{
				string[] array = (string[])e.Data.GetData("FileDrop");
				bool flag = array.Length != 0;
				if (flag)
				{
					using (StreamReader streamReader = new StreamReader(array[0]))
					{
						this.textBoxScript.Text = streamReader.ReadToEnd();
					}
				}
			}
		}

		private void FormPowerShellSample_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = (e.Data.GetDataPresent("FileDrop") ? DragDropEffects.Link : DragDropEffects.None);
		}

		private void textBoxScript_TextChanged(object sender, EventArgs e)
		{
		}

		private void bBrowse_Click(object sender, EventArgs e)
		{
			string path = "C:\\AZPILOT\\Serverslist.txt";
			using (StreamReader streamReader = new StreamReader(path))
			{
				string text = streamReader.ReadToEnd();
				this.textBoxScript.Text = text;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string path = "\\\\myCL1SOFS\\UpdStorage\\scripts\\Deployauth.txt";
			using (StreamReader streamReader = new StreamReader(path))
			{
				string text = streamReader.ReadToEnd();
				this.textBoxScript.Text = text;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string path = "\\\\myCL1SOFS\\UpdStorage\\scripts\\Deploydata.txt";
			using (StreamReader streamReader = new StreamReader(path))
			{
				string text = streamReader.ReadToEnd();
				this.textBoxScript.Text = text;
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			string path = "\\\\myCL1SOFS\\UpdStorage\\scripts\\Deploy.txt";
			using (StreamReader streamReader = new StreamReader(path))
			{
				string text = streamReader.ReadToEnd();
				this.textBoxScript.Text = text;
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			string path = "\\\\myCL1SOFS\\UpdStorage\\scripts\\copy.txt";
			using (StreamReader streamReader = new StreamReader(path))
			{
				string text = streamReader.ReadToEnd();
				this.textBoxScript.Text = text;
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			string path = "\\\\myCL1SOFS\\UpdStorage\\scripts\\getdir.txt";
			using (StreamReader streamReader = new StreamReader(path))
			{
				string text = streamReader.ReadToEnd();
				this.textBoxScript.Text = text;
			}
		}

		private void FormPowerShellSample_Load(object sender, EventArgs e)
		{
		}

		private void scriptsToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void checkUptimeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string path = "\\\\myCL1SOFS\\UpdStorage\\scripts\\get-uptime.ps1";
			using (StreamReader streamReader = new StreamReader(path))
			{
				string text = streamReader.ReadToEnd();
				this.textBoxScript.Text = text;
			}
		}

		private void checkRebootRequiredToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string path = "\\\\myCL1SOFS\\UpdStorage\\scripts\\get-reboot.ps1";
			using (StreamReader streamReader = new StreamReader(path))
			{
				string text = streamReader.ReadToEnd();
				this.textBoxScript.Text = text;
			}
		}

		private void aUTH01ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string path = "\\\\myCL1SOFS\\UpdStorage\\scripts\\get-webconfig.ps1";
			using (StreamReader streamReader = new StreamReader(path))
			{
				string text = streamReader.ReadToEnd();
				this.textBoxScript.Text = text;
			}
		}

		private void oPENINNOTEPADToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string path = "\\\\myCL1SOFS\\UpdStorage\\scripts\\notepad.ps1";
			using (StreamReader streamReader = new StreamReader(path))
			{
				string text = streamReader.ReadToEnd();
				this.textBoxScript.Text = text;
			}
		}

		private void oPENINOUTPUTToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string path = "\\\\myCL1SOFS\\UpdStorage\\scripts\\get-webconfig.ps1";
			using (StreamReader streamReader = new StreamReader(path))
			{
				string text = streamReader.ReadToEnd();
				this.textBoxScript.Text = text;
			}
		}

		private void aUTH02ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string path = "\\\\myCL1SOFS\\UpdStorage\\scripts\\get-webconfigd02.ps1";
			using (StreamReader streamReader = new StreamReader(path))
			{
				string text = streamReader.ReadToEnd();
				this.textBoxScript.Text = text;
			}
		}

		private void oPENINNOTEPADToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			string path = "\\\\myCL1SOFS\\UpdStorage\\scripts\\get-notepadd02.ps1";
			using (StreamReader streamReader = new StreamReader(path))
			{
				string text = streamReader.ReadToEnd();
				this.textBoxScript.Text = text;
			}
		}

		private void aZSCTDWEBD01ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string path = "\\\\myCL1SOFS\\UpdStorage\\scripts\\mstscd01.ps1";
			using (StreamReader streamReader = new StreamReader(path))
			{
				string text = streamReader.ReadToEnd();
				this.textBoxScript.Text = text;
			}
		}

		private void aboutJoeBalestrineToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AboutBox1 aboutBox = new AboutBox1();
			aboutBox.ShowDialog();
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void downloadPRISMCLIENTToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string path = "\\\\myCL1SOFS\\UpdStorage\\scripts\\prism.ps1";
			using (StreamReader streamReader = new StreamReader(path))
			{
				string text = streamReader.ReadToEnd();
				this.textBoxScript.Text = text;
			}
		}

		private void createCAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string path = "\\\\myCL1SOFS\\UpdStorage\\scripts\\ca.ps1";
			using (StreamReader streamReader = new StreamReader(path))
			{
				string text = streamReader.ReadToEnd();
				this.textBoxScript.Text = text;
			}
		}

		private void deployModulesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string path = "\\\\myCL1SOFS\\UpdStorage\\scripts\\extractwsus.ps1";
			using (StreamReader streamReader = new StreamReader(path))
			{
				string text = streamReader.ReadToEnd();
				this.textBoxScript.Text = text;
			}
		}

		private void sECURITYPATCHINGToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void getWUHistoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string path = "\\\\myCL1SOFS\\UpdStorage\\scripts\\extractwsus\\Get-WUHistory.ps1";
			using (StreamReader streamReader = new StreamReader(path))
			{
				string text = streamReader.ReadToEnd();
				this.textBoxScript.Text = text;
			}
		}

		private void exportcsvseeOutputForPathToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string path = "\\\\myCL1SOFS\\UpdStorage\\scripts\\extractwsus\\Get-WUHistoryexport.ps1";
			using (StreamReader streamReader = new StreamReader(path))
			{
				string text = streamReader.ReadToEnd();
				this.textBoxScript.Text = text;
			}
		}

		private void authServiceToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string path = "\\\\myCL1SOFS\\UpdStorage\\scripts\\authservicecheck.ps1";
			using (StreamReader streamReader = new StreamReader(path))
			{
				string text = streamReader.ReadToEnd();
				this.textBoxScript.Text = text;
			}
		}

		private void systemLogsToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void last10ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string path = "\\\\myCL1SOFS\\UpdStorage\\scripts\\get-eventlogs-system.ps1";
			using (StreamReader streamReader = new StreamReader(path))
			{
				string text = streamReader.ReadToEnd();
				this.textBoxScript.Text = text;
			}
		}

		private void applicationLogsToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void last10ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			string path = "\\\\myCL1SOFS\\UpdStorage\\scripts\\get-eventlogs-application.ps1";
			using (StreamReader streamReader = new StreamReader(path))
			{
				string text = streamReader.ReadToEnd();
				this.textBoxScript.Text = text;
			}
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void button4_Click_1(object sender, EventArgs e)
		{
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
		}

		private void Messenger_Click(object sender, EventArgs e)
		{
		}

		private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
		}

		private void pRODFeaturesToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void restoreDBToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void backupDBToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string path = "\\\\myCL1SOFS\\UpdStorage\\scripts\\SQLBACKUP.ps1";
			using (StreamReader streamReader = new StreamReader(path))
			{
				string text = streamReader.ReadToEnd();
				this.textBoxScript.Text = text;
			}
		}

		private void prodAuthToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string path = "\\\\myCL1SOFS\\UpdStorage\\scripts\\restoredbprodauth.ps1";
			using (StreamReader streamReader = new StreamReader(path))
			{
				string text = streamReader.ReadToEnd();
				this.textBoxScript.Text = text;
			}
		}

		private void appdataToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string path = "\\\\myCL1SOFS\\UpdStorage\\scripts\\appdata.ps1";
			using (StreamReader streamReader = new StreamReader(path))
			{
				string text = streamReader.ReadToEnd();
				this.textBoxScript.Text = text;
			}
		}

		private void openAppDataToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			string path = Path.Combine(folderPath, "TEAMDIGITALJB");
			bool flag = !Directory.Exists(path);
			if (flag)
			{
				Directory.CreateDirectory(path);
			}
		}

		private void certificatesToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void licenseUserToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string path = "\\\\myCL1SOFS\\UpdStorage\\scripts\\openfoundry.ps1";
			using (StreamReader streamReader = new StreamReader(path))
			{
				string text = streamReader.ReadToEnd();
				this.textBoxScript.Text = text;
			}
		}

		private void licenseUserToolStripMenuItem1_Click(object sender, EventArgs e)
		{
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{
		}

		private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
		}

		

		private void loadScriptToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = "c:\\";
			openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
			openFileDialog.FilterIndex = 2;
			openFileDialog.RestoreDirectory = true;
			bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				try
				{
					Stream stream;
					bool flag2 = (stream = openFileDialog.OpenFile()) != null;
					if (flag2)
					{
						using (stream)
						{
							this.textBoxScript.Text = File.ReadAllText(openFileDialog.FileName);
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
				}
			}
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.radioButton1.Checked;
			if (@checked)
			{
				this.BackColor = Color.Red;
			}
			else
			{
				bool checked2 = this.radioButton2.Checked;
				if (checked2)
				{
					this.BackColor = Color.Blue;
				}
				else
				{
					bool checked3 = this.radioButton3.Checked;
					if (checked3)
					{
						this.BackColor = Color.Green;
					}
				}
			}
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.radioButton2.Checked;
			if (@checked)
			{
				this.BackColor = Color.Blue;
			}
			else
			{
				bool checked2 = this.radioButton2.Checked;
				if (checked2)
				{
					this.BackColor = Color.Blue;
				}
				else
				{
					bool checked3 = this.radioButton3.Checked;
					if (checked3)
					{
						this.BackColor = Color.Green;
					}
				}
			}
		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.radioButton3.Checked;
			if (@checked)
			{
				this.BackColor = Color.Green;
			}
			else
			{
				bool checked2 = this.radioButton2.Checked;
				if (checked2)
				{
					this.BackColor = Color.Blue;
				}
				else
				{
					bool checked3 = this.radioButton3.Checked;
					if (checked3)
					{
						this.BackColor = Color.Green;
					}
				}
			}
		}

		private void radioButton4_CheckedChanged(object sender, EventArgs e)
		{
			Ping ping = new Ping();
			PingReply pingReply = ping.Send("localhost");
			bool flag = pingReply.Status == IPStatus.Success;
			if (flag)
			{
			}
		}

		private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
		{
			Ping ping = new Ping();
			PingReply pingReply = ping.Send("azsc-tdweb-d01.teamdigital.dev");
			bool flag = pingReply.Status == IPStatus.Success;
			if (flag)
			{
				this.textBoxOutput.Text = "ONLINE";
				this.pictureBox1.Image = Image.FromFile("\\\\myCL1SOFS\\UpdStorage\\images\\online.png");
			}
			else
			{
				this.textBoxOutput.Text = "Offline";
				this.pictureBox1.Image = Image.FromFile("\\\\myCL1SOFS\\UpdStorage\\images\\offline.png");
			}
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Ping ping = new Ping();
			PingReply pingReply = ping.Send("azsc-tdweb-d01.teamdigital.dev");
			bool flag = pingReply.Status == IPStatus.Success;
			if (flag)
			{
				this.textBoxOutput.Text = "ONLINE";
				this.pictureBox1.Image = Image.FromFile("\\\\myCL1SOFS\\UpdStorage\\images\\online.png");
			}
			else
			{
				this.textBoxOutput.Text = "Offline";
				this.pictureBox1.Image = Image.FromFile("\\\\myCL1SOFS\\UpdStorage\\images\\offline.png");
			}
		}

		private void aZSCTDWEBD02ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			string path = "\\\\myCL1SOFS\\UpdStorage\\scripts\\mstscd02.ps1";
			using (StreamReader streamReader = new StreamReader(path))
			{
				string text = streamReader.ReadToEnd();
				this.textBoxScript.Text = text;
			}
		}

		private void aZSCTDWEBD03ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string path = "\\\\myCL1SOFS\\UpdStorage\\scripts\\mstscd03.ps1";
			using (StreamReader streamReader = new StreamReader(path))
			{
				string text = streamReader.ReadToEnd();
				this.textBoxScript.Text = text;
			}
		}

		private void aZSCTDSQLD01ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			string path = "\\\\myCL1SOFS\\UpdStorage\\scripts\\mstscsqld01.ps1";
			using (StreamReader streamReader = new StreamReader(path))
			{
				string text = streamReader.ReadToEnd();
				this.textBoxScript.Text = text;
			}
		}

		private void aZSCTDSQLD02ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			string path = "\\\\myCL1SOFS\\UpdStorage\\scripts\\mstscsqld02.ps1";
			using (StreamReader streamReader = new StreamReader(path))
			{
				string text = streamReader.ReadToEnd();
				this.textBoxScript.Text = text;
			}
		}

		private void aZSCTDADD01ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			string path = "\\\\myCL1SOFS\\UpdStorage\\scripts\\mstscadd01.ps1";
			using (StreamReader streamReader = new StreamReader(path))
			{
				string text = streamReader.ReadToEnd();
				this.textBoxScript.Text = text;
			}
		}

		private void aZSCTDWEBD041ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			string path = "\\\\myCL1SOFS\\UpdStorage\\scripts\\mstsctdwebd041.ps1";
			using (StreamReader streamReader = new StreamReader(path))
			{
				string text = streamReader.ReadToEnd();
				this.textBoxScript.Text = text;
			}
		}

		private void aZSCTDWEBD042ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			string path = "\\\\myCL1SOFS\\UpdStorage\\scripts\\mstsctdwebd042.ps1";
			using (StreamReader streamReader = new StreamReader(path))
			{
				string text = streamReader.ReadToEnd();
				this.textBoxScript.Text = text;
			}
		}

		private void sQLLOGINSToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string path = "\\\\myCL1SOFS\\UpdStorage\\scripts\\SQLLOGINS.ps1";
			using (StreamReader streamReader = new StreamReader(path))
			{
				string text = streamReader.ReadToEnd();
				this.textBoxScript.Text = text;
			}
		}

		private void ServerCheck1_Tick(object sender, EventArgs e)
		{
			Ping ping = new Ping();
			PingReply pingReply = ping.Send("localhost");
			bool flag = pingReply.Status == IPStatus.Success;
			if (flag)
			{
				this.pictureBox6.Image = Resources.serverup;
			}
			else
			{
				this.pictureBox6.Image = Resources.offline;
			}
		}

		private void azsctdwebd01TIMER_Tick(object sender, EventArgs e)
		{
			Ping ping = new Ping();
			PingReply pingReply = ping.Send("localhost");
			bool flag = pingReply.Status == IPStatus.Success;
			if (flag)
			{
				this.pictureBox1.Image = Resources.serverup;
			}
			else
			{
				this.pictureBox1.Image = Resources.offline;
			}
		}

		private void tdwebd02TIMER_Tick(object sender, EventArgs e)
		{
			Ping ping = new Ping();
			PingReply pingReply = ping.Send("localhost");
			bool flag = pingReply.Status == IPStatus.Success;
			if (flag)
			{
				this.pictureBox2.Image = Resources.serverup;
			}
			else
			{
				this.pictureBox2.Image = Resources.offline;
			}
		}

		private void tdwebd041TIMER_Tick(object sender, EventArgs e)
		{
			Ping ping = new Ping();
			PingReply pingReply = ping.Send("localhost");
			bool flag = pingReply.Status == IPStatus.Success;
			if (flag)
			{
				this.pictureBox3.Image = Resources.serverup;
			}
			else
			{
				this.pictureBox3.Image = Resources.offline;
			}
		}

		private void d042TIMER_Tick(object sender, EventArgs e)
		{
			Ping ping = new Ping();
			PingReply pingReply = ping.Send("localhost");
			bool flag = pingReply.Status == IPStatus.Success;
			if (flag)
			{
				this.pictureBox4.Image = Resources.serverup;
			}
			else
			{
				this.pictureBox4.Image = Resources.offline;
			}
		}

		private void tdsqld01TIMER_Tick(object sender, EventArgs e)
		{
			Ping ping = new Ping();
			PingReply pingReply = ping.Send("localhost");
			bool flag = pingReply.Status == IPStatus.Success;
			if (flag)
			{
				this.pictureBox5.Image = Resources.serverup;
			}
			else
			{
				this.pictureBox5.Image = Resources.offline;
			}
		}

		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTeamDigitalJB));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ServerUp = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxScript = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bBrowse = new System.Windows.Forms.Button();
            this.buttonRunScript = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.scriptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadCustomScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkUptimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkLastUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkRebootRequiredToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWebConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aUTH01ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPENINNOTEPADToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPENINOUTPUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aUTH02ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPENINNOTEPADToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dATA01ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dATA02ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartAppPoolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkWebServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subscriptionServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relayServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartIISToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aPPPOOLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iISSERVICEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verifyServicesRunningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sMOKETESTINGDEPLOYMENTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runALLVerificationChecksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oUTPUTTOCOMMANDSHELLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oUTPUTTOFILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cHECKSERVICES7010AUTHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cHECKSERVICES7011DATAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cHECKSQLLOGINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cHECKSQLSTATEMENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cHECKSQLQUERYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cHECKBACKUPDATEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verifySQLRestoreDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smokeTestingMigrationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runAllVerificationChecksToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.outputToCommandShellToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.outputToFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToTXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkFileSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkFolderReadWritePermissionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkDBBackupSuccessfullToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkServerUptimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verifyIfRebootIsRequiredToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verifyServiceOnlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.verifyBinaryVersionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dATAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aUTHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rELAYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verifyFileDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.healthCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runFullHealthCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.azureServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reDeployServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nSGsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetPasswordMasterAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createVMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashBoardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cPUUtilizationReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ramUtilizationReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allResourceUtilizationReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downtimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rDPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aZSCTDWEBD01ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aZSCTDWEBD02ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aZSCTDWEBD03ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aZSCTDSQLD01ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aZSCTDSQLD02ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aZSCTDADD01ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aZSCTDWEBD041ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aZSCTDWEBD042ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadPRISMCLIENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.certificatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createCAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createUserLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenseUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenseUserToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.licenseAppToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aZSCTDWEBD01ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.last10ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.systemLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.last10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warningLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appdataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAppDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aZSCTDWEBD02ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aZSCTDSQLD01ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aZSCTDSQLD02ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aZSCTDWEBD041ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aZSCTDWEBD042ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aZSCTDADD01ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sECURITYPATCHINGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wSUSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deployModulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getWUHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportcsvseeOutputForPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dBRestoreBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prodAuthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getSQLUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLLOGINSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutJoeBalestrineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamDigitalDeploymentAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreDataBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamDigitalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.pRODFeaturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prodToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ServerCheck1 = new System.Windows.Forms.Timer(this.components);
            this.azsctdwebd01TIMER = new System.Windows.Forms.Timer(this.components);
            this.tdwebd02TIMER = new System.Windows.Forms.Timer(this.components);
            this.tdwebd041TIMER = new System.Windows.Forms.Timer(this.components);
            this.d042TIMER = new System.Windows.Forms.Timer(this.components);
            this.tdsqld01TIMER = new System.Windows.Forms.Timer(this.components);
            this.runSoundGeneratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gen1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ServerUp.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1770, 1203);
            this.splitContainer1.SplitterDistance = 406;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.ServerUp);
            this.groupBox1.Controls.Add(this.textBoxScript);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(12, 12, 12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.groupBox1.Size = new System.Drawing.Size(1770, 406);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu Scripts, System Administrator, Reports,  and Diagnostics";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ServerUp
            // 
            this.ServerUp.Controls.Add(this.tabPage1);
            this.ServerUp.Controls.Add(this.tabPage2);
            this.ServerUp.Location = new System.Drawing.Point(1143, 83);
            this.ServerUp.Name = "ServerUp";
            this.ServerUp.SelectedIndex = 0;
            this.ServerUp.Size = new System.Drawing.Size(612, 309);
            this.ServerUp.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pictureBox8);
            this.tabPage1.Controls.Add(this.pictureBox7);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.pictureBox6);
            this.tabPage1.Controls.Add(this.linkLabel1);
            this.tabPage1.Controls.Add(this.pictureBox5);
            this.tabPage1.Controls.Add(this.linkLabel2);
            this.tabPage1.Controls.Add(this.linkLabel6);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.linkLabel5);
            this.tabPage1.Controls.Add(this.linkLabel3);
            this.tabPage1.Controls.Add(this.pictureBox4);
            this.tabPage1.Controls.Add(this.pictureBox3);
            this.tabPage1.Controls.Add(this.linkLabel4);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(604, 276);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Server Status";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Offline";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Online";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::TeamDigitalJB.Properties.Resources.offline;
            this.pictureBox8.Location = new System.Drawing.Point(352, 46);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(24, 22);
            this.pictureBox8.TabIndex = 21;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::TeamDigitalJB.Properties.Resources.serverup;
            this.pictureBox7.Location = new System.Drawing.Point(352, 3);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(24, 31);
            this.pictureBox7.TabIndex = 20;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(150, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 32);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::TeamDigitalJB.Properties.Resources.hover;
            this.pictureBox6.Location = new System.Drawing.Point(150, 205);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(39, 31);
            this.pictureBox6.TabIndex = 19;
            this.pictureBox6.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 8);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(122, 20);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "azsc-tdweb-d01";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::TeamDigitalJB.Properties.Resources.hover;
            this.pictureBox5.Location = new System.Drawing.Point(150, 169);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(39, 32);
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(12, 37);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(122, 20);
            this.linkLabel2.TabIndex = 10;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "azsc-tdweb-d02";
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Location = new System.Drawing.Point(20, 212);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(113, 20);
            this.linkLabel6.TabIndex = 17;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "azsc-tdsql-d02";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(150, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 31);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Location = new System.Drawing.Point(20, 182);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(113, 20);
            this.linkLabel5.TabIndex = 16;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "azsc-tdsql-d01";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(14, 89);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(131, 20);
            this.linkLabel3.TabIndex = 12;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "azsc-tdweb-d041";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(150, 103);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(39, 38);
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(150, 75);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 35);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(14, 122);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(131, 20);
            this.linkLabel4.TabIndex = 14;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "azsc-tdweb-d042";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(604, 276);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxScript
            // 
            this.textBoxScript.AcceptsTab = true;
            this.textBoxScript.AllowDrop = true;
            this.textBoxScript.BackColor = System.Drawing.SystemColors.ControlText;
            this.textBoxScript.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxScript.Location = new System.Drawing.Point(12, 83);
            this.textBoxScript.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxScript.MaxLength = 0;
            this.textBoxScript.Multiline = true;
            this.textBoxScript.Name = "textBoxScript";
            this.textBoxScript.Size = new System.Drawing.Size(883, 215);
            this.textBoxScript.TabIndex = 0;
            this.textBoxScript.Text = "Choose Script to Initalize and then Click \'Run Script\' Button";
            this.textBoxScript.WordWrap = false;
            this.textBoxScript.TextChanged += new System.EventHandler(this.textBoxScript_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.bBrowse);
            this.panel1.Controls.Add(this.buttonRunScript);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(12, 351);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1746, 43);
            this.panel1.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(435, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(192, 35);
            this.button3.TabIndex = 5;
            this.button3.Text = "Deploy Subscription";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(294, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "Deploy Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Deploy Auth";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bBrowse
            // 
            this.bBrowse.Location = new System.Drawing.Point(9, 3);
            this.bBrowse.Name = "bBrowse";
            this.bBrowse.Size = new System.Drawing.Size(146, 35);
            this.bBrowse.TabIndex = 2;
            this.bBrowse.Text = "Load Server List";
            this.bBrowse.UseVisualStyleBackColor = true;
            this.bBrowse.Click += new System.EventHandler(this.bBrowse_Click);
            // 
            // buttonRunScript
            // 
            this.buttonRunScript.Location = new System.Drawing.Point(710, 3);
            this.buttonRunScript.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRunScript.Name = "buttonRunScript";
            this.buttonRunScript.Size = new System.Drawing.Size(120, 35);
            this.buttonRunScript.TabIndex = 1;
            this.buttonRunScript.Text = "&Run Script";
            this.buttonRunScript.UseVisualStyleBackColor = true;
            this.buttonRunScript.Click += new System.EventHandler(this.buttonRunScript_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scriptsToolStripMenuItem,
            this.azureServicesToolStripMenuItem,
            this.dashBoardsToolStripMenuItem,
            this.rDPToolStripMenuItem,
            this.downloadsToolStripMenuItem,
            this.certificatesToolStripMenuItem,
            this.lOGSToolStripMenuItem,
            this.sECURITYPATCHINGToolStripMenuItem,
            this.dBRestoreBackupToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.restoreDataBaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(12, 31);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1746, 39);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // scriptsToolStripMenuItem
            // 
            this.scriptsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadCustomScriptToolStripMenuItem,
            this.checkUptimeToolStripMenuItem,
            this.checkLastUpdateToolStripMenuItem,
            this.checkRebootRequiredToolStripMenuItem,
            this.openWebConfigToolStripMenuItem,
            this.restartAppPoolToolStripMenuItem,
            this.checkWebServiceToolStripMenuItem,
            this.restartIISToolStripMenuItem,
            this.restartServicesToolStripMenuItem,
            this.verifyServicesRunningToolStripMenuItem,
            this.sMOKETESTINGDEPLOYMENTSToolStripMenuItem,
            this.smokeTestingMigrationsToolStripMenuItem,
            this.healthCheckToolStripMenuItem,
            this.runSoundGeneratorToolStripMenuItem});
            this.scriptsToolStripMenuItem.Image = global::TeamDigitalJB.Properties.Resources.script;
            this.scriptsToolStripMenuItem.Name = "scriptsToolStripMenuItem";
            this.scriptsToolStripMenuItem.Size = new System.Drawing.Size(101, 33);
            this.scriptsToolStripMenuItem.Text = "Scripts";
            this.scriptsToolStripMenuItem.Click += new System.EventHandler(this.scriptsToolStripMenuItem_Click);
            // 
            // loadCustomScriptToolStripMenuItem
            // 
            this.loadCustomScriptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadScriptToolStripMenuItem});
            this.loadCustomScriptToolStripMenuItem.Image = global::TeamDigitalJB.Properties.Resources.script;
            this.loadCustomScriptToolStripMenuItem.Name = "loadCustomScriptToolStripMenuItem";
            this.loadCustomScriptToolStripMenuItem.Size = new System.Drawing.Size(340, 34);
            this.loadCustomScriptToolStripMenuItem.Text = "Load Custom Script";
            // 
            // loadScriptToolStripMenuItem
            // 
            this.loadScriptToolStripMenuItem.Name = "loadScriptToolStripMenuItem";
            this.loadScriptToolStripMenuItem.Size = new System.Drawing.Size(203, 34);
            this.loadScriptToolStripMenuItem.Text = "Load Script";
            this.loadScriptToolStripMenuItem.Click += new System.EventHandler(this.loadScriptToolStripMenuItem_Click);
            // 
            // checkUptimeToolStripMenuItem
            // 
            this.checkUptimeToolStripMenuItem.Name = "checkUptimeToolStripMenuItem";
            this.checkUptimeToolStripMenuItem.Size = new System.Drawing.Size(340, 34);
            this.checkUptimeToolStripMenuItem.Text = "Check Uptime";
            this.checkUptimeToolStripMenuItem.Click += new System.EventHandler(this.checkUptimeToolStripMenuItem_Click);
            // 
            // checkLastUpdateToolStripMenuItem
            // 
            this.checkLastUpdateToolStripMenuItem.Name = "checkLastUpdateToolStripMenuItem";
            this.checkLastUpdateToolStripMenuItem.Size = new System.Drawing.Size(340, 34);
            this.checkLastUpdateToolStripMenuItem.Text = "Check Last Update";
            // 
            // checkRebootRequiredToolStripMenuItem
            // 
            this.checkRebootRequiredToolStripMenuItem.Name = "checkRebootRequiredToolStripMenuItem";
            this.checkRebootRequiredToolStripMenuItem.Size = new System.Drawing.Size(340, 34);
            this.checkRebootRequiredToolStripMenuItem.Text = "Check Reboot Required";
            this.checkRebootRequiredToolStripMenuItem.Click += new System.EventHandler(this.checkRebootRequiredToolStripMenuItem_Click);
            // 
            // openWebConfigToolStripMenuItem
            // 
            this.openWebConfigToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aUTH01ToolStripMenuItem,
            this.aUTH02ToolStripMenuItem,
            this.dATA01ToolStripMenuItem,
            this.dATA02ToolStripMenuItem});
            this.openWebConfigToolStripMenuItem.Name = "openWebConfigToolStripMenuItem";
            this.openWebConfigToolStripMenuItem.Size = new System.Drawing.Size(340, 34);
            this.openWebConfigToolStripMenuItem.Text = "Open Web.Config";
            // 
            // aUTH01ToolStripMenuItem
            // 
            this.aUTH01ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oPENINNOTEPADToolStripMenuItem,
            this.oPENINOUTPUTToolStripMenuItem});
            this.aUTH01ToolStripMenuItem.Name = "aUTH01ToolStripMenuItem";
            this.aUTH01ToolStripMenuItem.Size = new System.Drawing.Size(180, 34);
            this.aUTH01ToolStripMenuItem.Text = "AUTH01";
            this.aUTH01ToolStripMenuItem.Click += new System.EventHandler(this.aUTH01ToolStripMenuItem_Click);
            // 
            // oPENINNOTEPADToolStripMenuItem
            // 
            this.oPENINNOTEPADToolStripMenuItem.Name = "oPENINNOTEPADToolStripMenuItem";
            this.oPENINNOTEPADToolStripMenuItem.Size = new System.Drawing.Size(266, 34);
            this.oPENINNOTEPADToolStripMenuItem.Text = "OPEN IN NOTEPAD";
            this.oPENINNOTEPADToolStripMenuItem.Click += new System.EventHandler(this.oPENINNOTEPADToolStripMenuItem_Click);
            // 
            // oPENINOUTPUTToolStripMenuItem
            // 
            this.oPENINOUTPUTToolStripMenuItem.Name = "oPENINOUTPUTToolStripMenuItem";
            this.oPENINOUTPUTToolStripMenuItem.Size = new System.Drawing.Size(266, 34);
            this.oPENINOUTPUTToolStripMenuItem.Text = "OPEN IN OUTPUT";
            this.oPENINOUTPUTToolStripMenuItem.Click += new System.EventHandler(this.oPENINOUTPUTToolStripMenuItem_Click);
            // 
            // aUTH02ToolStripMenuItem
            // 
            this.aUTH02ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oPENINNOTEPADToolStripMenuItem1});
            this.aUTH02ToolStripMenuItem.Name = "aUTH02ToolStripMenuItem";
            this.aUTH02ToolStripMenuItem.Size = new System.Drawing.Size(180, 34);
            this.aUTH02ToolStripMenuItem.Text = "AUTH02";
            this.aUTH02ToolStripMenuItem.Click += new System.EventHandler(this.aUTH02ToolStripMenuItem_Click);
            // 
            // oPENINNOTEPADToolStripMenuItem1
            // 
            this.oPENINNOTEPADToolStripMenuItem1.Name = "oPENINNOTEPADToolStripMenuItem1";
            this.oPENINNOTEPADToolStripMenuItem1.Size = new System.Drawing.Size(266, 34);
            this.oPENINNOTEPADToolStripMenuItem1.Text = "OPEN IN NOTEPAD";
            this.oPENINNOTEPADToolStripMenuItem1.Click += new System.EventHandler(this.oPENINNOTEPADToolStripMenuItem1_Click);
            // 
            // dATA01ToolStripMenuItem
            // 
            this.dATA01ToolStripMenuItem.Name = "dATA01ToolStripMenuItem";
            this.dATA01ToolStripMenuItem.Size = new System.Drawing.Size(180, 34);
            this.dATA01ToolStripMenuItem.Text = "DATA01";
            // 
            // dATA02ToolStripMenuItem
            // 
            this.dATA02ToolStripMenuItem.Name = "dATA02ToolStripMenuItem";
            this.dATA02ToolStripMenuItem.Size = new System.Drawing.Size(180, 34);
            this.dATA02ToolStripMenuItem.Text = "DATA02";
            // 
            // restartAppPoolToolStripMenuItem
            // 
            this.restartAppPoolToolStripMenuItem.Name = "restartAppPoolToolStripMenuItem";
            this.restartAppPoolToolStripMenuItem.Size = new System.Drawing.Size(340, 34);
            this.restartAppPoolToolStripMenuItem.Text = "Restart App Pool";
            // 
            // checkWebServiceToolStripMenuItem
            // 
            this.checkWebServiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authServiceToolStripMenuItem,
            this.dataServiceToolStripMenuItem,
            this.subscriptionServiceToolStripMenuItem,
            this.relayServiceToolStripMenuItem});
            this.checkWebServiceToolStripMenuItem.Name = "checkWebServiceToolStripMenuItem";
            this.checkWebServiceToolStripMenuItem.Size = new System.Drawing.Size(340, 34);
            this.checkWebServiceToolStripMenuItem.Text = "Check WebService";
            // 
            // authServiceToolStripMenuItem
            // 
            this.authServiceToolStripMenuItem.Name = "authServiceToolStripMenuItem";
            this.authServiceToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.authServiceToolStripMenuItem.Text = "Auth Service";
            this.authServiceToolStripMenuItem.Click += new System.EventHandler(this.authServiceToolStripMenuItem_Click);
            // 
            // dataServiceToolStripMenuItem
            // 
            this.dataServiceToolStripMenuItem.Name = "dataServiceToolStripMenuItem";
            this.dataServiceToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.dataServiceToolStripMenuItem.Text = "Data Service";
            // 
            // subscriptionServiceToolStripMenuItem
            // 
            this.subscriptionServiceToolStripMenuItem.Name = "subscriptionServiceToolStripMenuItem";
            this.subscriptionServiceToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.subscriptionServiceToolStripMenuItem.Text = "Subscription Service";
            // 
            // relayServiceToolStripMenuItem
            // 
            this.relayServiceToolStripMenuItem.Name = "relayServiceToolStripMenuItem";
            this.relayServiceToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.relayServiceToolStripMenuItem.Text = "Relay Service";
            // 
            // restartIISToolStripMenuItem
            // 
            this.restartIISToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aPPPOOLToolStripMenuItem,
            this.iISSERVICEToolStripMenuItem});
            this.restartIISToolStripMenuItem.Name = "restartIISToolStripMenuItem";
            this.restartIISToolStripMenuItem.Size = new System.Drawing.Size(340, 34);
            this.restartIISToolStripMenuItem.Text = "Restart IIS";
            // 
            // aPPPOOLToolStripMenuItem
            // 
            this.aPPPOOLToolStripMenuItem.Name = "aPPPOOLToolStripMenuItem";
            this.aPPPOOLToolStripMenuItem.Size = new System.Drawing.Size(197, 34);
            this.aPPPOOLToolStripMenuItem.Text = "APP POOL";
            // 
            // iISSERVICEToolStripMenuItem
            // 
            this.iISSERVICEToolStripMenuItem.Name = "iISSERVICEToolStripMenuItem";
            this.iISSERVICEToolStripMenuItem.Size = new System.Drawing.Size(197, 34);
            this.iISSERVICEToolStripMenuItem.Text = "IIS";
            // 
            // restartServicesToolStripMenuItem
            // 
            this.restartServicesToolStripMenuItem.Image = global::TeamDigitalJB.Properties.Resources.service;
            this.restartServicesToolStripMenuItem.Name = "restartServicesToolStripMenuItem";
            this.restartServicesToolStripMenuItem.Size = new System.Drawing.Size(340, 34);
            this.restartServicesToolStripMenuItem.Text = "Restart Services";
            // 
            // verifyServicesRunningToolStripMenuItem
            // 
            this.verifyServicesRunningToolStripMenuItem.Name = "verifyServicesRunningToolStripMenuItem";
            this.verifyServicesRunningToolStripMenuItem.Size = new System.Drawing.Size(340, 34);
            // 
            // sMOKETESTINGDEPLOYMENTSToolStripMenuItem
            // 
            this.sMOKETESTINGDEPLOYMENTSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runALLVerificationChecksToolStripMenuItem,
            this.cHECKSERVICES7010AUTHToolStripMenuItem,
            this.cHECKSERVICES7011DATAToolStripMenuItem,
            this.cHECKSQLLOGINToolStripMenuItem,
            this.cHECKSQLSTATEMENTToolStripMenuItem,
            this.cHECKSQLQUERYToolStripMenuItem,
            this.cHECKBACKUPDATEToolStripMenuItem,
            this.verifySQLRestoreDateToolStripMenuItem});
            this.sMOKETESTINGDEPLOYMENTSToolStripMenuItem.Name = "sMOKETESTINGDEPLOYMENTSToolStripMenuItem";
            this.sMOKETESTINGDEPLOYMENTSToolStripMenuItem.Size = new System.Drawing.Size(340, 34);
            this.sMOKETESTINGDEPLOYMENTSToolStripMenuItem.Text = "Smoke Testing Deployments";
            // 
            // runALLVerificationChecksToolStripMenuItem
            // 
            this.runALLVerificationChecksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oUTPUTTOCOMMANDSHELLToolStripMenuItem,
            this.oUTPUTTOFILEToolStripMenuItem});
            this.runALLVerificationChecksToolStripMenuItem.Name = "runALLVerificationChecksToolStripMenuItem";
            this.runALLVerificationChecksToolStripMenuItem.Size = new System.Drawing.Size(335, 34);
            this.runALLVerificationChecksToolStripMenuItem.Text = "Run ALL Verification Checks";
            // 
            // oUTPUTTOCOMMANDSHELLToolStripMenuItem
            // 
            this.oUTPUTTOCOMMANDSHELLToolStripMenuItem.Name = "oUTPUTTOCOMMANDSHELLToolStripMenuItem";
            this.oUTPUTTOCOMMANDSHELLToolStripMenuItem.Size = new System.Drawing.Size(360, 34);
            this.oUTPUTTOCOMMANDSHELLToolStripMenuItem.Text = "OUTPUT TO COMMAND SHELL";
            // 
            // oUTPUTTOFILEToolStripMenuItem
            // 
            this.oUTPUTTOFILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cSVToolStripMenuItem,
            this.tXTToolStripMenuItem});
            this.oUTPUTTOFILEToolStripMenuItem.Name = "oUTPUTTOFILEToolStripMenuItem";
            this.oUTPUTTOFILEToolStripMenuItem.Size = new System.Drawing.Size(360, 34);
            this.oUTPUTTOFILEToolStripMenuItem.Text = "OUTPUT TO FILE";
            // 
            // cSVToolStripMenuItem
            // 
            this.cSVToolStripMenuItem.Name = "cSVToolStripMenuItem";
            this.cSVToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.cSVToolStripMenuItem.Text = "CSV";
            // 
            // tXTToolStripMenuItem
            // 
            this.tXTToolStripMenuItem.Name = "tXTToolStripMenuItem";
            this.tXTToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.tXTToolStripMenuItem.Text = "TXT";
            // 
            // cHECKSERVICES7010AUTHToolStripMenuItem
            // 
            this.cHECKSERVICES7010AUTHToolStripMenuItem.Name = "cHECKSERVICES7010AUTHToolStripMenuItem";
            this.cHECKSERVICES7010AUTHToolStripMenuItem.Size = new System.Drawing.Size(335, 34);
            this.cHECKSERVICES7010AUTHToolStripMenuItem.Text = "Verify SERVICES 7010 AUTH";
            // 
            // cHECKSERVICES7011DATAToolStripMenuItem
            // 
            this.cHECKSERVICES7011DATAToolStripMenuItem.Name = "cHECKSERVICES7011DATAToolStripMenuItem";
            this.cHECKSERVICES7011DATAToolStripMenuItem.Size = new System.Drawing.Size(335, 34);
            this.cHECKSERVICES7011DATAToolStripMenuItem.Text = "Verify SERVICES 7011 DATA";
            // 
            // cHECKSQLLOGINToolStripMenuItem
            // 
            this.cHECKSQLLOGINToolStripMenuItem.Name = "cHECKSQLLOGINToolStripMenuItem";
            this.cHECKSQLLOGINToolStripMenuItem.Size = new System.Drawing.Size(335, 34);
            this.cHECKSQLLOGINToolStripMenuItem.Text = "Verify SQL LOGIN";
            // 
            // cHECKSQLSTATEMENTToolStripMenuItem
            // 
            this.cHECKSQLSTATEMENTToolStripMenuItem.Name = "cHECKSQLSTATEMENTToolStripMenuItem";
            this.cHECKSQLSTATEMENTToolStripMenuItem.Size = new System.Drawing.Size(335, 34);
            this.cHECKSQLSTATEMENTToolStripMenuItem.Text = "Verify SQL STATEMENT";
            this.cHECKSQLSTATEMENTToolStripMenuItem.Click += new System.EventHandler(this.cHECKSQLSTATEMENTToolStripMenuItem_Click);
            // 
            // cHECKSQLQUERYToolStripMenuItem
            // 
            this.cHECKSQLQUERYToolStripMenuItem.Name = "cHECKSQLQUERYToolStripMenuItem";
            this.cHECKSQLQUERYToolStripMenuItem.Size = new System.Drawing.Size(335, 34);
            this.cHECKSQLQUERYToolStripMenuItem.Text = "Verify SQL QUERY";
            // 
            // cHECKBACKUPDATEToolStripMenuItem
            // 
            this.cHECKBACKUPDATEToolStripMenuItem.Name = "cHECKBACKUPDATEToolStripMenuItem";
            this.cHECKBACKUPDATEToolStripMenuItem.Size = new System.Drawing.Size(335, 34);
            this.cHECKBACKUPDATEToolStripMenuItem.Text = "Verify SQL BACKUP DATE";
            // 
            // verifySQLRestoreDateToolStripMenuItem
            // 
            this.verifySQLRestoreDateToolStripMenuItem.Name = "verifySQLRestoreDateToolStripMenuItem";
            this.verifySQLRestoreDateToolStripMenuItem.Size = new System.Drawing.Size(335, 34);
            this.verifySQLRestoreDateToolStripMenuItem.Text = "Verify SQL Restore Date";
            // 
            // smokeTestingMigrationsToolStripMenuItem
            // 
            this.smokeTestingMigrationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runAllVerificationChecksToolStripMenuItem1,
            this.checkFileSizeToolStripMenuItem,
            this.checkFolderReadWritePermissionsToolStripMenuItem,
            this.checkDBBackupSuccessfullToolStripMenuItem,
            this.checkServerUptimeToolStripMenuItem,
            this.verifyIfRebootIsRequiredToolStripMenuItem,
            this.toolStripMenuItem1,
            this.verifyServiceOnlineToolStripMenuItem,
            this.toolStripMenuItem2,
            this.verifyBinaryVersionToolStripMenuItem,
            this.verifyFileDateToolStripMenuItem});
            this.smokeTestingMigrationsToolStripMenuItem.Name = "smokeTestingMigrationsToolStripMenuItem";
            this.smokeTestingMigrationsToolStripMenuItem.Size = new System.Drawing.Size(340, 34);
            this.smokeTestingMigrationsToolStripMenuItem.Text = "Smoke Testing Migrations";
            // 
            // runAllVerificationChecksToolStripMenuItem1
            // 
            this.runAllVerificationChecksToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outputToCommandShellToolStripMenuItem1,
            this.outputToFileToolStripMenuItem1});
            this.runAllVerificationChecksToolStripMenuItem1.Name = "runAllVerificationChecksToolStripMenuItem1";
            this.runAllVerificationChecksToolStripMenuItem1.Size = new System.Drawing.Size(436, 34);
            this.runAllVerificationChecksToolStripMenuItem1.Text = "Run All Verification Checks";
            // 
            // outputToCommandShellToolStripMenuItem1
            // 
            this.outputToCommandShellToolStripMenuItem1.Name = "outputToCommandShellToolStripMenuItem1";
            this.outputToCommandShellToolStripMenuItem1.Size = new System.Drawing.Size(324, 34);
            this.outputToCommandShellToolStripMenuItem1.Text = "Output to Command Shell";
            // 
            // outputToFileToolStripMenuItem1
            // 
            this.outputToFileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertToCSVToolStripMenuItem,
            this.convertToTXTToolStripMenuItem});
            this.outputToFileToolStripMenuItem1.Name = "outputToFileToolStripMenuItem1";
            this.outputToFileToolStripMenuItem1.Size = new System.Drawing.Size(324, 34);
            this.outputToFileToolStripMenuItem1.Text = "Output to File";
            // 
            // convertToCSVToolStripMenuItem
            // 
            this.convertToCSVToolStripMenuItem.Name = "convertToCSVToolStripMenuItem";
            this.convertToCSVToolStripMenuItem.Size = new System.Drawing.Size(235, 34);
            this.convertToCSVToolStripMenuItem.Text = "Convert to CSV";
            // 
            // convertToTXTToolStripMenuItem
            // 
            this.convertToTXTToolStripMenuItem.Name = "convertToTXTToolStripMenuItem";
            this.convertToTXTToolStripMenuItem.Size = new System.Drawing.Size(235, 34);
            this.convertToTXTToolStripMenuItem.Text = "Convert to TXT";
            // 
            // checkFileSizeToolStripMenuItem
            // 
            this.checkFileSizeToolStripMenuItem.Name = "checkFileSizeToolStripMenuItem";
            this.checkFileSizeToolStripMenuItem.Size = new System.Drawing.Size(436, 34);
            this.checkFileSizeToolStripMenuItem.Text = "1. Check File Size";
            // 
            // checkFolderReadWritePermissionsToolStripMenuItem
            // 
            this.checkFolderReadWritePermissionsToolStripMenuItem.Name = "checkFolderReadWritePermissionsToolStripMenuItem";
            this.checkFolderReadWritePermissionsToolStripMenuItem.Size = new System.Drawing.Size(436, 34);
            this.checkFolderReadWritePermissionsToolStripMenuItem.Text = "2. Check Folder Read / Write Permissions";
            // 
            // checkDBBackupSuccessfullToolStripMenuItem
            // 
            this.checkDBBackupSuccessfullToolStripMenuItem.Name = "checkDBBackupSuccessfullToolStripMenuItem";
            this.checkDBBackupSuccessfullToolStripMenuItem.Size = new System.Drawing.Size(436, 34);
            this.checkDBBackupSuccessfullToolStripMenuItem.Text = "3. Check DB Backup Successful";
            // 
            // checkServerUptimeToolStripMenuItem
            // 
            this.checkServerUptimeToolStripMenuItem.Name = "checkServerUptimeToolStripMenuItem";
            this.checkServerUptimeToolStripMenuItem.Size = new System.Drawing.Size(436, 34);
            this.checkServerUptimeToolStripMenuItem.Text = "4. Check Server Uptime";
            // 
            // verifyIfRebootIsRequiredToolStripMenuItem
            // 
            this.verifyIfRebootIsRequiredToolStripMenuItem.Name = "verifyIfRebootIsRequiredToolStripMenuItem";
            this.verifyIfRebootIsRequiredToolStripMenuItem.Size = new System.Drawing.Size(436, 34);
            this.verifyIfRebootIsRequiredToolStripMenuItem.Text = "5. Verify If Reboot is Required";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(436, 34);
            this.toolStripMenuItem1.Text = "5A. Verify Data Service Online: 7011";
            // 
            // verifyServiceOnlineToolStripMenuItem
            // 
            this.verifyServiceOnlineToolStripMenuItem.Name = "verifyServiceOnlineToolStripMenuItem";
            this.verifyServiceOnlineToolStripMenuItem.Size = new System.Drawing.Size(436, 34);
            this.verifyServiceOnlineToolStripMenuItem.Text = "5B. Verify Auth Service Online 7010";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(436, 34);
            this.toolStripMenuItem2.Text = "6. Verify Read / Write Access to DB";
            // 
            // verifyBinaryVersionToolStripMenuItem
            // 
            this.verifyBinaryVersionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dATAToolStripMenuItem,
            this.aUTHToolStripMenuItem,
            this.rELAYToolStripMenuItem});
            this.verifyBinaryVersionToolStripMenuItem.Name = "verifyBinaryVersionToolStripMenuItem";
            this.verifyBinaryVersionToolStripMenuItem.Size = new System.Drawing.Size(436, 34);
            this.verifyBinaryVersionToolStripMenuItem.Text = "7. Verify Binary Version ";
            // 
            // dATAToolStripMenuItem
            // 
            this.dATAToolStripMenuItem.Name = "dATAToolStripMenuItem";
            this.dATAToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.dATAToolStripMenuItem.Text = "DATA";
            // 
            // aUTHToolStripMenuItem
            // 
            this.aUTHToolStripMenuItem.Name = "aUTHToolStripMenuItem";
            this.aUTHToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.aUTHToolStripMenuItem.Text = "AUTH";
            // 
            // rELAYToolStripMenuItem
            // 
            this.rELAYToolStripMenuItem.Name = "rELAYToolStripMenuItem";
            this.rELAYToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.rELAYToolStripMenuItem.Text = "RELAY";
            // 
            // verifyFileDateToolStripMenuItem
            // 
            this.verifyFileDateToolStripMenuItem.Name = "verifyFileDateToolStripMenuItem";
            this.verifyFileDateToolStripMenuItem.Size = new System.Drawing.Size(436, 34);
            this.verifyFileDateToolStripMenuItem.Text = "8. Verify File Date";
            // 
            // healthCheckToolStripMenuItem
            // 
            this.healthCheckToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runFullHealthCheckToolStripMenuItem});
            this.healthCheckToolStripMenuItem.Name = "healthCheckToolStripMenuItem";
            this.healthCheckToolStripMenuItem.Size = new System.Drawing.Size(340, 34);
            this.healthCheckToolStripMenuItem.Text = "Health Check";
            // 
            // runFullHealthCheckToolStripMenuItem
            // 
            this.runFullHealthCheckToolStripMenuItem.Name = "runFullHealthCheckToolStripMenuItem";
            this.runFullHealthCheckToolStripMenuItem.Size = new System.Drawing.Size(285, 34);
            this.runFullHealthCheckToolStripMenuItem.Text = "Run Full Health Check";
            this.runFullHealthCheckToolStripMenuItem.Click += new System.EventHandler(this.runFullHealthCheckToolStripMenuItem_Click);
            // 
            // azureServicesToolStripMenuItem
            // 
            this.azureServicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reDeployServerToolStripMenuItem,
            this.nSGsToolStripMenuItem,
            this.resetPasswordMasterAdminToolStripMenuItem,
            this.createVMToolStripMenuItem});
            this.azureServicesToolStripMenuItem.Image = global::TeamDigitalJB.Properties.Resources.azure;
            this.azureServicesToolStripMenuItem.Name = "azureServicesToolStripMenuItem";
            this.azureServicesToolStripMenuItem.Size = new System.Drawing.Size(161, 33);
            this.azureServicesToolStripMenuItem.Text = "Azure Services";
            // 
            // reDeployServerToolStripMenuItem
            // 
            this.reDeployServerToolStripMenuItem.Name = "reDeployServerToolStripMenuItem";
            this.reDeployServerToolStripMenuItem.Size = new System.Drawing.Size(353, 34);
            this.reDeployServerToolStripMenuItem.Text = "Re-Deploy Server";
            // 
            // nSGsToolStripMenuItem
            // 
            this.nSGsToolStripMenuItem.Image = global::TeamDigitalJB.Properties.Resources.nsg;
            this.nSGsToolStripMenuItem.Name = "nSGsToolStripMenuItem";
            this.nSGsToolStripMenuItem.Size = new System.Drawing.Size(353, 34);
            this.nSGsToolStripMenuItem.Text = "NSGs";
            // 
            // resetPasswordMasterAdminToolStripMenuItem
            // 
            this.resetPasswordMasterAdminToolStripMenuItem.Name = "resetPasswordMasterAdminToolStripMenuItem";
            this.resetPasswordMasterAdminToolStripMenuItem.Size = new System.Drawing.Size(353, 34);
            this.resetPasswordMasterAdminToolStripMenuItem.Text = "Reset Password master Admin";
            // 
            // createVMToolStripMenuItem
            // 
            this.createVMToolStripMenuItem.Name = "createVMToolStripMenuItem";
            this.createVMToolStripMenuItem.Size = new System.Drawing.Size(353, 34);
            this.createVMToolStripMenuItem.Text = "Create VM";
            // 
            // dashBoardsToolStripMenuItem
            // 
            this.dashBoardsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cPUUtilizationReportsToolStripMenuItem,
            this.ramUtilizationReportsToolStripMenuItem,
            this.allResourceUtilizationReportsToolStripMenuItem,
            this.downtimeToolStripMenuItem,
            this.outagesToolStripMenuItem});
            this.dashBoardsToolStripMenuItem.Image = global::TeamDigitalJB.Properties.Resources.dashboards;
            this.dashBoardsToolStripMenuItem.Name = "dashBoardsToolStripMenuItem";
            this.dashBoardsToolStripMenuItem.Size = new System.Drawing.Size(148, 33);
            this.dashBoardsToolStripMenuItem.Text = "Dash Boards";
            // 
            // cPUUtilizationReportsToolStripMenuItem
            // 
            this.cPUUtilizationReportsToolStripMenuItem.Name = "cPUUtilizationReportsToolStripMenuItem";
            this.cPUUtilizationReportsToolStripMenuItem.Size = new System.Drawing.Size(359, 34);
            this.cPUUtilizationReportsToolStripMenuItem.Text = "CPU Utilization Reports";
            // 
            // ramUtilizationReportsToolStripMenuItem
            // 
            this.ramUtilizationReportsToolStripMenuItem.Name = "ramUtilizationReportsToolStripMenuItem";
            this.ramUtilizationReportsToolStripMenuItem.Size = new System.Drawing.Size(359, 34);
            this.ramUtilizationReportsToolStripMenuItem.Text = "Ram Utilization Reports";
            // 
            // allResourceUtilizationReportsToolStripMenuItem
            // 
            this.allResourceUtilizationReportsToolStripMenuItem.Name = "allResourceUtilizationReportsToolStripMenuItem";
            this.allResourceUtilizationReportsToolStripMenuItem.Size = new System.Drawing.Size(359, 34);
            this.allResourceUtilizationReportsToolStripMenuItem.Text = "All Resource Utilization Reports";
            // 
            // downtimeToolStripMenuItem
            // 
            this.downtimeToolStripMenuItem.Name = "downtimeToolStripMenuItem";
            this.downtimeToolStripMenuItem.Size = new System.Drawing.Size(359, 34);
            this.downtimeToolStripMenuItem.Text = "Downtime";
            // 
            // outagesToolStripMenuItem
            // 
            this.outagesToolStripMenuItem.Name = "outagesToolStripMenuItem";
            this.outagesToolStripMenuItem.Size = new System.Drawing.Size(359, 34);
            this.outagesToolStripMenuItem.Text = "Outages";
            // 
            // rDPToolStripMenuItem
            // 
            this.rDPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aZSCTDWEBD01ToolStripMenuItem,
            this.aZSCTDWEBD02ToolStripMenuItem1,
            this.aZSCTDWEBD03ToolStripMenuItem,
            this.aZSCTDSQLD01ToolStripMenuItem1,
            this.aZSCTDSQLD02ToolStripMenuItem1,
            this.aZSCTDADD01ToolStripMenuItem1,
            this.aZSCTDWEBD041ToolStripMenuItem1,
            this.aZSCTDWEBD042ToolStripMenuItem1});
            this.rDPToolStripMenuItem.Image = global::TeamDigitalJB.Properties.Resources.rdp;
            this.rDPToolStripMenuItem.Name = "rDPToolStripMenuItem";
            this.rDPToolStripMenuItem.Size = new System.Drawing.Size(82, 33);
            this.rDPToolStripMenuItem.Text = "RDP";
            // 
            // aZSCTDWEBD01ToolStripMenuItem
            // 
            this.aZSCTDWEBD01ToolStripMenuItem.Image = global::TeamDigitalJB.Properties.Resources.rdp;
            this.aZSCTDWEBD01ToolStripMenuItem.Name = "aZSCTDWEBD01ToolStripMenuItem";
            this.aZSCTDWEBD01ToolStripMenuItem.Size = new System.Drawing.Size(376, 34);
            this.aZSCTDWEBD01ToolStripMenuItem.Text = "AZSC-TDWEB-D01 - AUTH01";
            this.aZSCTDWEBD01ToolStripMenuItem.Click += new System.EventHandler(this.aZSCTDWEBD01ToolStripMenuItem_Click);
            // 
            // aZSCTDWEBD02ToolStripMenuItem1
            // 
            this.aZSCTDWEBD02ToolStripMenuItem1.Image = global::TeamDigitalJB.Properties.Resources.rdp;
            this.aZSCTDWEBD02ToolStripMenuItem1.Name = "aZSCTDWEBD02ToolStripMenuItem1";
            this.aZSCTDWEBD02ToolStripMenuItem1.Size = new System.Drawing.Size(376, 34);
            this.aZSCTDWEBD02ToolStripMenuItem1.Text = "AZSC-TDWEB-D02 - AUTH02";
            this.aZSCTDWEBD02ToolStripMenuItem1.Click += new System.EventHandler(this.aZSCTDWEBD02ToolStripMenuItem1_Click);
            // 
            // aZSCTDWEBD03ToolStripMenuItem
            // 
            this.aZSCTDWEBD03ToolStripMenuItem.Image = global::TeamDigitalJB.Properties.Resources.rdp;
            this.aZSCTDWEBD03ToolStripMenuItem.Name = "aZSCTDWEBD03ToolStripMenuItem";
            this.aZSCTDWEBD03ToolStripMenuItem.Size = new System.Drawing.Size(376, 34);
            this.aZSCTDWEBD03ToolStripMenuItem.Text = "AZSC-TDWEB-D03 - TABLEAU 03";
            this.aZSCTDWEBD03ToolStripMenuItem.Click += new System.EventHandler(this.aZSCTDWEBD03ToolStripMenuItem_Click);
            // 
            // aZSCTDSQLD01ToolStripMenuItem1
            // 
            this.aZSCTDSQLD01ToolStripMenuItem1.Image = global::TeamDigitalJB.Properties.Resources.rdp;
            this.aZSCTDSQLD01ToolStripMenuItem1.Name = "aZSCTDSQLD01ToolStripMenuItem1";
            this.aZSCTDSQLD01ToolStripMenuItem1.Size = new System.Drawing.Size(376, 34);
            this.aZSCTDSQLD01ToolStripMenuItem1.Text = "AZSC-TDSQL-D01";
            this.aZSCTDSQLD01ToolStripMenuItem1.Click += new System.EventHandler(this.aZSCTDSQLD01ToolStripMenuItem1_Click);
            // 
            // aZSCTDSQLD02ToolStripMenuItem1
            // 
            this.aZSCTDSQLD02ToolStripMenuItem1.Image = global::TeamDigitalJB.Properties.Resources.rdp;
            this.aZSCTDSQLD02ToolStripMenuItem1.Name = "aZSCTDSQLD02ToolStripMenuItem1";
            this.aZSCTDSQLD02ToolStripMenuItem1.Size = new System.Drawing.Size(376, 34);
            this.aZSCTDSQLD02ToolStripMenuItem1.Text = "AZSC-TDSQL-D02";
            this.aZSCTDSQLD02ToolStripMenuItem1.Click += new System.EventHandler(this.aZSCTDSQLD02ToolStripMenuItem1_Click);
            // 
            // aZSCTDADD01ToolStripMenuItem1
            // 
            this.aZSCTDADD01ToolStripMenuItem1.Image = global::TeamDigitalJB.Properties.Resources.rdp;
            this.aZSCTDADD01ToolStripMenuItem1.Name = "aZSCTDADD01ToolStripMenuItem1";
            this.aZSCTDADD01ToolStripMenuItem1.Size = new System.Drawing.Size(376, 34);
            this.aZSCTDADD01ToolStripMenuItem1.Text = "AZSC-TDAD-D01";
            this.aZSCTDADD01ToolStripMenuItem1.Click += new System.EventHandler(this.aZSCTDADD01ToolStripMenuItem1_Click);
            // 
            // aZSCTDWEBD041ToolStripMenuItem1
            // 
            this.aZSCTDWEBD041ToolStripMenuItem1.Image = global::TeamDigitalJB.Properties.Resources.rdp;
            this.aZSCTDWEBD041ToolStripMenuItem1.Name = "aZSCTDWEBD041ToolStripMenuItem1";
            this.aZSCTDWEBD041ToolStripMenuItem1.Size = new System.Drawing.Size(376, 34);
            this.aZSCTDWEBD041ToolStripMenuItem1.Text = "AZSC-TDWEB-D041 - DATA01";
            this.aZSCTDWEBD041ToolStripMenuItem1.Click += new System.EventHandler(this.aZSCTDWEBD041ToolStripMenuItem1_Click);
            // 
            // aZSCTDWEBD042ToolStripMenuItem1
            // 
            this.aZSCTDWEBD042ToolStripMenuItem1.Image = global::TeamDigitalJB.Properties.Resources.rdp;
            this.aZSCTDWEBD042ToolStripMenuItem1.Name = "aZSCTDWEBD042ToolStripMenuItem1";
            this.aZSCTDWEBD042ToolStripMenuItem1.Size = new System.Drawing.Size(376, 34);
            this.aZSCTDWEBD042ToolStripMenuItem1.Text = "AZSC-TDWEB-D042 -DATA02";
            this.aZSCTDWEBD042ToolStripMenuItem1.Click += new System.EventHandler(this.aZSCTDWEBD042ToolStripMenuItem1_Click);
            // 
            // downloadsToolStripMenuItem
            // 
            this.downloadsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadPRISMCLIENTToolStripMenuItem});
            this.downloadsToolStripMenuItem.Image = global::TeamDigitalJB.Properties.Resources.downloads;
            this.downloadsToolStripMenuItem.Name = "downloadsToolStripMenuItem";
            this.downloadsToolStripMenuItem.Size = new System.Drawing.Size(138, 33);
            this.downloadsToolStripMenuItem.Text = "Downloads";
            // 
            // downloadPRISMCLIENTToolStripMenuItem
            // 
            this.downloadPRISMCLIENTToolStripMenuItem.Image = global::TeamDigitalJB.Properties.Resources.downloads;
            this.downloadPRISMCLIENTToolStripMenuItem.Name = "downloadPRISMCLIENTToolStripMenuItem";
            this.downloadPRISMCLIENTToolStripMenuItem.Size = new System.Drawing.Size(313, 34);
            this.downloadPRISMCLIENTToolStripMenuItem.Text = "Download PRISM CLIENT";
            this.downloadPRISMCLIENTToolStripMenuItem.Click += new System.EventHandler(this.downloadPRISMCLIENTToolStripMenuItem_Click);
            // 
            // certificatesToolStripMenuItem
            // 
            this.certificatesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createCAsToolStripMenuItem,
            this.createUserLicenseToolStripMenuItem,
            this.createToolStripMenuItem,
            this.licenseUserToolStripMenuItem});
            this.certificatesToolStripMenuItem.Image = global::TeamDigitalJB.Properties.Resources.cert2;
            this.certificatesToolStripMenuItem.Name = "certificatesToolStripMenuItem";
            this.certificatesToolStripMenuItem.Size = new System.Drawing.Size(153, 33);
            this.certificatesToolStripMenuItem.Text = "Cert / License";
            this.certificatesToolStripMenuItem.Click += new System.EventHandler(this.certificatesToolStripMenuItem_Click);
            // 
            // createCAsToolStripMenuItem
            // 
            this.createCAsToolStripMenuItem.Image = global::TeamDigitalJB.Properties.Resources.cert;
            this.createCAsToolStripMenuItem.Name = "createCAsToolStripMenuItem";
            this.createCAsToolStripMenuItem.Size = new System.Drawing.Size(265, 34);
            this.createCAsToolStripMenuItem.Text = "Create CAs";
            this.createCAsToolStripMenuItem.Click += new System.EventHandler(this.createCAsToolStripMenuItem_Click);
            // 
            // createUserLicenseToolStripMenuItem
            // 
            this.createUserLicenseToolStripMenuItem.Name = "createUserLicenseToolStripMenuItem";
            this.createUserLicenseToolStripMenuItem.Size = new System.Drawing.Size(265, 34);
            this.createUserLicenseToolStripMenuItem.Text = "Create User License";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(265, 34);
            this.createToolStripMenuItem.Text = "Relicense Software";
            // 
            // licenseUserToolStripMenuItem
            // 
            this.licenseUserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.licenseUserToolStripMenuItem1,
            this.licenseAppToolStripMenuItem1});
            this.licenseUserToolStripMenuItem.Name = "licenseUserToolStripMenuItem";
            this.licenseUserToolStripMenuItem.Size = new System.Drawing.Size(265, 34);
            this.licenseUserToolStripMenuItem.Text = "FOUNDRY";
            this.licenseUserToolStripMenuItem.Click += new System.EventHandler(this.licenseUserToolStripMenuItem_Click);
            // 
            // licenseUserToolStripMenuItem1
            // 
            this.licenseUserToolStripMenuItem1.Name = "licenseUserToolStripMenuItem1";
            this.licenseUserToolStripMenuItem1.Size = new System.Drawing.Size(210, 34);
            this.licenseUserToolStripMenuItem1.Text = "License User";
            this.licenseUserToolStripMenuItem1.Click += new System.EventHandler(this.licenseUserToolStripMenuItem1_Click);
            // 
            // licenseAppToolStripMenuItem1
            // 
            this.licenseAppToolStripMenuItem1.Name = "licenseAppToolStripMenuItem1";
            this.licenseAppToolStripMenuItem1.Size = new System.Drawing.Size(210, 34);
            this.licenseAppToolStripMenuItem1.Text = "License App";
            // 
            // lOGSToolStripMenuItem
            // 
            this.lOGSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aZSCTDWEBD01ToolStripMenuItem1,
            this.aZSCTDWEBD02ToolStripMenuItem,
            this.aZSCTDSQLD01ToolStripMenuItem,
            this.aZSCTDSQLD02ToolStripMenuItem,
            this.aZSCTDWEBD041ToolStripMenuItem,
            this.aZSCTDWEBD042ToolStripMenuItem,
            this.aZSCTDADD01ToolStripMenuItem});
            this.lOGSToolStripMenuItem.Image = global::TeamDigitalJB.Properties.Resources.log;
            this.lOGSToolStripMenuItem.Name = "lOGSToolStripMenuItem";
            this.lOGSToolStripMenuItem.Size = new System.Drawing.Size(91, 33);
            this.lOGSToolStripMenuItem.Text = "LOGS";
            // 
            // aZSCTDWEBD01ToolStripMenuItem1
            // 
            this.aZSCTDWEBD01ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationLogsToolStripMenuItem,
            this.systemLogsToolStripMenuItem,
            this.errorLogsToolStripMenuItem,
            this.warningLogsToolStripMenuItem,
            this.appdataToolStripMenuItem});
            this.aZSCTDWEBD01ToolStripMenuItem1.Name = "aZSCTDWEBD01ToolStripMenuItem1";
            this.aZSCTDWEBD01ToolStripMenuItem1.Size = new System.Drawing.Size(273, 34);
            this.aZSCTDWEBD01ToolStripMenuItem1.Text = "AZSC-TDWEB-D01";
            // 
            // applicationLogsToolStripMenuItem
            // 
            this.applicationLogsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.last10ToolStripMenuItem1});
            this.applicationLogsToolStripMenuItem.Name = "applicationLogsToolStripMenuItem";
            this.applicationLogsToolStripMenuItem.Size = new System.Drawing.Size(247, 34);
            this.applicationLogsToolStripMenuItem.Text = "Application Logs";
            this.applicationLogsToolStripMenuItem.Click += new System.EventHandler(this.applicationLogsToolStripMenuItem_Click);
            // 
            // last10ToolStripMenuItem1
            // 
            this.last10ToolStripMenuItem1.Name = "last10ToolStripMenuItem1";
            this.last10ToolStripMenuItem1.Size = new System.Drawing.Size(170, 34);
            this.last10ToolStripMenuItem1.Text = "Last 10";
            this.last10ToolStripMenuItem1.Click += new System.EventHandler(this.last10ToolStripMenuItem1_Click);
            // 
            // systemLogsToolStripMenuItem
            // 
            this.systemLogsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.last10ToolStripMenuItem});
            this.systemLogsToolStripMenuItem.Name = "systemLogsToolStripMenuItem";
            this.systemLogsToolStripMenuItem.Size = new System.Drawing.Size(247, 34);
            this.systemLogsToolStripMenuItem.Text = "System Logs";
            this.systemLogsToolStripMenuItem.Click += new System.EventHandler(this.systemLogsToolStripMenuItem_Click);
            // 
            // last10ToolStripMenuItem
            // 
            this.last10ToolStripMenuItem.Name = "last10ToolStripMenuItem";
            this.last10ToolStripMenuItem.Size = new System.Drawing.Size(170, 34);
            this.last10ToolStripMenuItem.Text = "Last 10";
            this.last10ToolStripMenuItem.Click += new System.EventHandler(this.last10ToolStripMenuItem_Click);
            // 
            // errorLogsToolStripMenuItem
            // 
            this.errorLogsToolStripMenuItem.Name = "errorLogsToolStripMenuItem";
            this.errorLogsToolStripMenuItem.Size = new System.Drawing.Size(247, 34);
            this.errorLogsToolStripMenuItem.Text = "Error Logs";
            // 
            // warningLogsToolStripMenuItem
            // 
            this.warningLogsToolStripMenuItem.Name = "warningLogsToolStripMenuItem";
            this.warningLogsToolStripMenuItem.Size = new System.Drawing.Size(247, 34);
            this.warningLogsToolStripMenuItem.Text = "Warning Logs";
            // 
            // appdataToolStripMenuItem
            // 
            this.appdataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openAppDataToolStripMenuItem});
            this.appdataToolStripMenuItem.Name = "appdataToolStripMenuItem";
            this.appdataToolStripMenuItem.Size = new System.Drawing.Size(247, 34);
            this.appdataToolStripMenuItem.Text = "%appdata%";
            this.appdataToolStripMenuItem.Click += new System.EventHandler(this.appdataToolStripMenuItem_Click);
            // 
            // openAppDataToolStripMenuItem
            // 
            this.openAppDataToolStripMenuItem.Name = "openAppDataToolStripMenuItem";
            this.openAppDataToolStripMenuItem.Size = new System.Drawing.Size(231, 34);
            this.openAppDataToolStripMenuItem.Text = "open AppData";
            this.openAppDataToolStripMenuItem.Click += new System.EventHandler(this.openAppDataToolStripMenuItem_Click);
            // 
            // aZSCTDWEBD02ToolStripMenuItem
            // 
            this.aZSCTDWEBD02ToolStripMenuItem.Name = "aZSCTDWEBD02ToolStripMenuItem";
            this.aZSCTDWEBD02ToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.aZSCTDWEBD02ToolStripMenuItem.Text = "AZSC-TDWEB-D02";
            // 
            // aZSCTDSQLD01ToolStripMenuItem
            // 
            this.aZSCTDSQLD01ToolStripMenuItem.Name = "aZSCTDSQLD01ToolStripMenuItem";
            this.aZSCTDSQLD01ToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.aZSCTDSQLD01ToolStripMenuItem.Text = "AZSC-TDSQL-D01";
            // 
            // aZSCTDSQLD02ToolStripMenuItem
            // 
            this.aZSCTDSQLD02ToolStripMenuItem.Name = "aZSCTDSQLD02ToolStripMenuItem";
            this.aZSCTDSQLD02ToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.aZSCTDSQLD02ToolStripMenuItem.Text = "AZSC-TDSQL-D02";
            // 
            // aZSCTDWEBD041ToolStripMenuItem
            // 
            this.aZSCTDWEBD041ToolStripMenuItem.Name = "aZSCTDWEBD041ToolStripMenuItem";
            this.aZSCTDWEBD041ToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.aZSCTDWEBD041ToolStripMenuItem.Text = "AZSC-TDWEB-D041";
            // 
            // aZSCTDWEBD042ToolStripMenuItem
            // 
            this.aZSCTDWEBD042ToolStripMenuItem.Name = "aZSCTDWEBD042ToolStripMenuItem";
            this.aZSCTDWEBD042ToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.aZSCTDWEBD042ToolStripMenuItem.Text = "AZSC-TDWEB-D042";
            // 
            // aZSCTDADD01ToolStripMenuItem
            // 
            this.aZSCTDADD01ToolStripMenuItem.Name = "aZSCTDADD01ToolStripMenuItem";
            this.aZSCTDADD01ToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.aZSCTDADD01ToolStripMenuItem.Text = "AZSC-TDAD-D01";
            // 
            // sECURITYPATCHINGToolStripMenuItem
            // 
            this.sECURITYPATCHINGToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wSUSToolStripMenuItem});
            this.sECURITYPATCHINGToolStripMenuItem.Image = global::TeamDigitalJB.Properties.Resources.security;
            this.sECURITYPATCHINGToolStripMenuItem.Name = "sECURITYPATCHINGToolStripMenuItem";
            this.sECURITYPATCHINGToolStripMenuItem.Size = new System.Drawing.Size(217, 33);
            this.sECURITYPATCHINGToolStripMenuItem.Text = "SECURITY PATCHING ";
            this.sECURITYPATCHINGToolStripMenuItem.Click += new System.EventHandler(this.sECURITYPATCHINGToolStripMenuItem_Click);
            // 
            // wSUSToolStripMenuItem
            // 
            this.wSUSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deployModulesToolStripMenuItem,
            this.getWUHistoryToolStripMenuItem});
            this.wSUSToolStripMenuItem.Image = global::TeamDigitalJB.Properties.Resources.security;
            this.wSUSToolStripMenuItem.Name = "wSUSToolStripMenuItem";
            this.wSUSToolStripMenuItem.Size = new System.Drawing.Size(163, 34);
            this.wSUSToolStripMenuItem.Text = "WSUS";
            // 
            // deployModulesToolStripMenuItem
            // 
            this.deployModulesToolStripMenuItem.Name = "deployModulesToolStripMenuItem";
            this.deployModulesToolStripMenuItem.Size = new System.Drawing.Size(245, 34);
            this.deployModulesToolStripMenuItem.Text = "Deploy Modules";
            this.deployModulesToolStripMenuItem.Click += new System.EventHandler(this.deployModulesToolStripMenuItem_Click);
            // 
            // getWUHistoryToolStripMenuItem
            // 
            this.getWUHistoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportcsvseeOutputForPathToolStripMenuItem});
            this.getWUHistoryToolStripMenuItem.Name = "getWUHistoryToolStripMenuItem";
            this.getWUHistoryToolStripMenuItem.Size = new System.Drawing.Size(245, 34);
            this.getWUHistoryToolStripMenuItem.Text = "Get WU History";
            this.getWUHistoryToolStripMenuItem.Click += new System.EventHandler(this.getWUHistoryToolStripMenuItem_Click);
            // 
            // exportcsvseeOutputForPathToolStripMenuItem
            // 
            this.exportcsvseeOutputForPathToolStripMenuItem.Name = "exportcsvseeOutputForPathToolStripMenuItem";
            this.exportcsvseeOutputForPathToolStripMenuItem.Size = new System.Drawing.Size(402, 34);
            this.exportcsvseeOutputForPathToolStripMenuItem.Text = "AZSC-TDWEB-D01 -output to HTML";
            this.exportcsvseeOutputForPathToolStripMenuItem.Click += new System.EventHandler(this.exportcsvseeOutputForPathToolStripMenuItem_Click);
            // 
            // dBRestoreBackupToolStripMenuItem
            // 
            this.dBRestoreBackupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restoreDBToolStripMenuItem,
            this.backupDBToolStripMenuItem,
            this.getSQLUsersToolStripMenuItem});
            this.dBRestoreBackupToolStripMenuItem.Image = global::TeamDigitalJB.Properties.Resources.sql;
            this.dBRestoreBackupToolStripMenuItem.Name = "dBRestoreBackupToolStripMenuItem";
            this.dBRestoreBackupToolStripMenuItem.Size = new System.Drawing.Size(209, 33);
            this.dBRestoreBackupToolStripMenuItem.Text = "DB Restore / Backup";
            // 
            // restoreDBToolStripMenuItem
            // 
            this.restoreDBToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prodAuthToolStripMenuItem});
            this.restoreDBToolStripMenuItem.Image = global::TeamDigitalJB.Properties.Resources.sql;
            this.restoreDBToolStripMenuItem.Name = "restoreDBToolStripMenuItem";
            this.restoreDBToolStripMenuItem.Size = new System.Drawing.Size(226, 34);
            this.restoreDBToolStripMenuItem.Text = "Restore DB";
            this.restoreDBToolStripMenuItem.Click += new System.EventHandler(this.restoreDBToolStripMenuItem_Click);
            // 
            // prodAuthToolStripMenuItem
            // 
            this.prodAuthToolStripMenuItem.Name = "prodAuthToolStripMenuItem";
            this.prodAuthToolStripMenuItem.Size = new System.Drawing.Size(195, 34);
            this.prodAuthToolStripMenuItem.Text = "Prod Auth";
            this.prodAuthToolStripMenuItem.Click += new System.EventHandler(this.prodAuthToolStripMenuItem_Click);
            // 
            // backupDBToolStripMenuItem
            // 
            this.backupDBToolStripMenuItem.Image = global::TeamDigitalJB.Properties.Resources.sql;
            this.backupDBToolStripMenuItem.Name = "backupDBToolStripMenuItem";
            this.backupDBToolStripMenuItem.Size = new System.Drawing.Size(226, 34);
            this.backupDBToolStripMenuItem.Text = "Backup DB";
            this.backupDBToolStripMenuItem.Click += new System.EventHandler(this.backupDBToolStripMenuItem_Click);
            // 
            // getSQLUsersToolStripMenuItem
            // 
            this.getSQLUsersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sQLLOGINSToolStripMenuItem});
            this.getSQLUsersToolStripMenuItem.Image = global::TeamDigitalJB.Properties.Resources.sql;
            this.getSQLUsersToolStripMenuItem.Name = "getSQLUsersToolStripMenuItem";
            this.getSQLUsersToolStripMenuItem.Size = new System.Drawing.Size(226, 34);
            this.getSQLUsersToolStripMenuItem.Text = "Get SQL Users";
            // 
            // sQLLOGINSToolStripMenuItem
            // 
            this.sQLLOGINSToolStripMenuItem.Name = "sQLLOGINSToolStripMenuItem";
            this.sQLLOGINSToolStripMenuItem.Size = new System.Drawing.Size(212, 34);
            this.sQLLOGINSToolStripMenuItem.Text = "SQL LOGINS";
            this.sQLLOGINSToolStripMenuItem.Click += new System.EventHandler(this.sQLLOGINSToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutJoeBalestrineToolStripMenuItem,
            this.teamDigitalDeploymentAppToolStripMenuItem});
            this.aboutToolStripMenuItem.Image = global::TeamDigitalJB.Properties.Resources.about;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(98, 33);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // aboutJoeBalestrineToolStripMenuItem
            // 
            this.aboutJoeBalestrineToolStripMenuItem.Name = "aboutJoeBalestrineToolStripMenuItem";
            this.aboutJoeBalestrineToolStripMenuItem.Size = new System.Drawing.Size(353, 34);
            this.aboutJoeBalestrineToolStripMenuItem.Text = "About Joe Balestrine";
            this.aboutJoeBalestrineToolStripMenuItem.Click += new System.EventHandler(this.aboutJoeBalestrineToolStripMenuItem_Click);
            // 
            // teamDigitalDeploymentAppToolStripMenuItem
            // 
            this.teamDigitalDeploymentAppToolStripMenuItem.Name = "teamDigitalDeploymentAppToolStripMenuItem";
            this.teamDigitalDeploymentAppToolStripMenuItem.Size = new System.Drawing.Size(353, 34);
            this.teamDigitalDeploymentAppToolStripMenuItem.Text = "Team Digital Deployment App";
            // 
            // restoreDataBaseToolStripMenuItem
            // 
            this.restoreDataBaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teamDigitalToolStripMenuItem});
            this.restoreDataBaseToolStripMenuItem.Image = global::TeamDigitalJB.Properties.Resources.team;
            this.restoreDataBaseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.restoreDataBaseToolStripMenuItem.Name = "restoreDataBaseToolStripMenuItem";
            this.restoreDataBaseToolStripMenuItem.Size = new System.Drawing.Size(112, 33);
            // 
            // teamDigitalToolStripMenuItem
            // 
            this.teamDigitalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teamMembersToolStripMenuItem,
            this.servicesToolStripMenuItem});
            this.teamDigitalToolStripMenuItem.Name = "teamDigitalToolStripMenuItem";
            this.teamDigitalToolStripMenuItem.Size = new System.Drawing.Size(211, 34);
            this.teamDigitalToolStripMenuItem.Text = "Team Digital";
            // 
            // teamMembersToolStripMenuItem
            // 
            this.teamMembersToolStripMenuItem.Name = "teamMembersToolStripMenuItem";
            this.teamMembersToolStripMenuItem.Size = new System.Drawing.Size(235, 34);
            this.teamMembersToolStripMenuItem.Text = "Team Members";
            // 
            // servicesToolStripMenuItem
            // 
            this.servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            this.servicesToolStripMenuItem.Size = new System.Drawing.Size(235, 34);
            this.servicesToolStripMenuItem.Text = "Services";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxOutput);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.groupBox2.Size = new System.Drawing.Size(1770, 791);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutput.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOutput.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxOutput.Location = new System.Drawing.Point(12, 31);
            this.textBoxOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxOutput.MaxLength = 0;
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxOutput.Size = new System.Drawing.Size(1746, 748);
            this.textBoxOutput.TabIndex = 0;
            this.textBoxOutput.WordWrap = false;
            this.textBoxOutput.TextChanged += new System.EventHandler(this.textBoxOutput_TextChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(1184, 0);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 24);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Red";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(1252, 0);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(64, 24);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "blue";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(1322, 0);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(75, 24);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "green";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // pRODFeaturesToolStripMenuItem
            // 
            this.pRODFeaturesToolStripMenuItem.Name = "pRODFeaturesToolStripMenuItem";
            this.pRODFeaturesToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.pRODFeaturesToolStripMenuItem.Text = "PROD_Features";
            this.pRODFeaturesToolStripMenuItem.Click += new System.EventHandler(this.pRODFeaturesToolStripMenuItem_Click);
            // 
            // prodToolStripMenuItem
            // 
            this.prodToolStripMenuItem.Name = "prodToolStripMenuItem";
            this.prodToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.prodToolStripMenuItem.Text = "Prod...";
            // 
            // prodToolStripMenuItem1
            // 
            this.prodToolStripMenuItem1.Name = "prodToolStripMenuItem1";
            this.prodToolStripMenuItem1.Size = new System.Drawing.Size(184, 26);
            this.prodToolStripMenuItem1.Text = "Prod_";
            // 
            // ServerCheck1
            // 
            this.ServerCheck1.Enabled = true;
            this.ServerCheck1.Interval = 500;
            this.ServerCheck1.Tick += new System.EventHandler(this.ServerCheck1_Tick);
            // 
            // azsctdwebd01TIMER
            // 
            this.azsctdwebd01TIMER.Enabled = true;
            this.azsctdwebd01TIMER.Interval = 500;
            this.azsctdwebd01TIMER.Tick += new System.EventHandler(this.azsctdwebd01TIMER_Tick);
            // 
            // tdwebd02TIMER
            // 
            this.tdwebd02TIMER.Enabled = true;
            this.tdwebd02TIMER.Interval = 500;
            this.tdwebd02TIMER.Tick += new System.EventHandler(this.tdwebd02TIMER_Tick);
            // 
            // tdwebd041TIMER
            // 
            this.tdwebd041TIMER.Enabled = true;
            this.tdwebd041TIMER.Interval = 500;
            this.tdwebd041TIMER.Tick += new System.EventHandler(this.tdwebd041TIMER_Tick);
            // 
            // d042TIMER
            // 
            this.d042TIMER.Enabled = true;
            this.d042TIMER.Interval = 500;
            this.d042TIMER.Tick += new System.EventHandler(this.d042TIMER_Tick);
            // 
            // tdsqld01TIMER
            // 
            this.tdsqld01TIMER.Enabled = true;
            this.tdsqld01TIMER.Interval = 500;
            this.tdsqld01TIMER.Tick += new System.EventHandler(this.tdsqld01TIMER_Tick);
            // 
            // runSoundGeneratorToolStripMenuItem
            // 
            this.runSoundGeneratorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gen1ToolStripMenuItem});
            this.runSoundGeneratorToolStripMenuItem.Name = "runSoundGeneratorToolStripMenuItem";
            this.runSoundGeneratorToolStripMenuItem.Size = new System.Drawing.Size(340, 34);
            this.runSoundGeneratorToolStripMenuItem.Text = "Sound Generator";
            this.runSoundGeneratorToolStripMenuItem.Click += new System.EventHandler(this.runSoundGeneratorToolStripMenuItem_Click);
            // 
            // gen1ToolStripMenuItem
            // 
            this.gen1ToolStripMenuItem.Name = "gen1ToolStripMenuItem";
            this.gen1ToolStripMenuItem.Size = new System.Drawing.Size(1295, 34);
            this.gen1ToolStripMenuItem.Text = "Play song by saying it - Say \"Sting\" or other title to load music current songs a" +
    "vailable: STING, WHAT IS LOVE, SLIPKNOT, STILLBORN, DOMINATION. .";
            this.gen1ToolStripMenuItem.Click += new System.EventHandler(this.gen1ToolStripMenuItem_Click);
            // 
            // FormTeamDigitalJB
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1770, 1203);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormTeamDigitalJB";
            this.Text = "Team Digital - TDWEB - DEPLOYMENT - Joseph Balestrine";
            this.Load += new System.EventHandler(this.FormPowerShellSample_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormPowerShellSample_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormPowerShellSample_DragEnter);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ServerUp.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

		}

        private void cHECKSQLSTATEMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBoxOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void runFullHealthCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("powershell", "\\\\myCL1SOFS\\UpdStorage\\scripts\\TDHealthcheck.ps1");            


            }
        public static int RunBat(string currentFile, bool waitexit)
        {
            try
            {
                string path = AppDomain.CurrentDomain.BaseDirectory;
                Process process = new Process();
                process.StartInfo.FileName = path + currentFile;
                process.Start();
                if (waitexit == true)
                {
                    process.WaitForExit();
                }
                return 0;

            }
            catch
            {
                return 1;
            }
        } 
        private void gen1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            RunBat("playsong.py", true);
        }

        private static string PatchParameter(string parameter, int serviceid)
        {
            var engine = Python.CreateEngine(); // Extract Python language engine from their grasp
            var scope = engine.CreateScope(); // Introduce Python namespace (scope)
            var d = new Dictionary<string, object>
            {
                { "serviceid", serviceid},
                { "parameter", parameter}
            }; // Add some sample parameters. Notice that there is no need in specifically setting the object type, interpreter will do that part for us in the script properly with high probability

            scope.SetVariable("params", d); // This will be the name of the dictionary in python script, initialized with previously created .NET Dictionary
            ScriptSource source = engine.CreateScriptSourceFromFile("playsong.py"); // Load the script
            object result = source.Execute(scope);
            parameter = scope.GetVariable<string>("parameter"); // To get the finally set variable 'parameter' from the python script
            return parameter;
        }

        private void runSoundGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
    }
