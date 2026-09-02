/*

        ██╗░░░░░██╗░░░██╗░█████╗░██╗░░██╗██╗░░░██╗██████╗░██╗░░░░░░█████╗░██╗░░██╗
        ██║░░░░░██║░░░██║██╔══██╗██║░██╔╝╚██╗░██╔╝██╔══██╗██║░░░░░██╔══██╗╚██╗██╔╝
        ██║░░░░░██║░░░██║██║░░╚═╝█████═╝░░╚████╔╝░██████╦╝██║░░░░░██║░░██║░╚███╔╝░
        ██║░░░░░██║░░░██║██║░░██╗██╔═██╗░░░╚██╔╝░░██╔══██╗██║░░░░░██║░░██║░██╔██╗░
        ███████╗╚██████╔╝╚█████╔╝██║░╚██╗░░░██║░░░██████╦╝███████╗╚█████╔╝██╔╝╚██╗
        ╚══════╝░╚═════╝░░╚════╝░╚═╝░░╚═╝░░░╚═╝░░░╚═════╝░╚══════╝░╚════╝░╚═╝░░╚═╝

██╗░░░░░░█████╗░██╗░░░██╗███╗░░██╗░█████╗░██╗░░██╗███████╗██████╗░  ░██████╗██████╗░░█████╗░
██║░░░░░██╔══██╗██║░░░██║████╗░██║██╔══██╗██║░░██║██╔════╝██╔══██╗  ██╔════╝██╔══██╗██╔══██╗
██║░░░░░███████║██║░░░██║██╔██╗██║██║░░╚═╝███████║█████╗░░██████╔╝  ╚█████╗░██████╔╝██║░░╚═╝
██║░░░░░██╔══██║██║░░░██║██║╚████║██║░░██╗██╔══██║██╔══╝░░██╔══██╗  ░╚═══██╗██╔══██╗██║░░██╗
███████╗██║░░██║╚██████╔╝██║░╚███║╚█████╔╝██║░░██║███████╗██║░░██║  ██████╔╝██║░░██║╚█████╔╝
╚══════╝╚═╝░░╚═╝░╚═════╝░╚═╝░░╚══╝░╚════╝░╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝  ╚═════╝░╚═╝░░╚═╝░╚════╝░
     ------------------          Release 0.7 from 11.08.2026          ------------------

                                 THIS NOW OPEN SOURCED! WOW!
                                      Made by atpied

I know the code is currently bad written. Soon I’ll fix it properly so that it’s fully stable.
                Based on the source code of FilteringDisabled (by beepboopbap)

                                          Enjoy!

*/

using GameServer;
using GameServer.Rcc;
using GameServer.Rcc.Classes;
using soapframework;
using SoapUI.Rcc.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Media;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _2017Launcher;

public class Form1 : Form
{
	private string http = "http";

	private int num;

	private string assetsaving = "true";

	private string headcolor = "Pastel brown";

	private string torsocolor = "Pastel brown";

	private string leftlegcolor = "Pastel brown";

	private string rightlegcolor = "Pastel brown";

	private string leftarmcolor = "Pastel brown";

	private string rightarmcolor = "Pastel brown";

	private string chartype = "R6";

	private bool started2017 = true;

	private bool started2008 = true;

	private Point startPoint = new Point(0, 0);

	private System.Windows.Forms.Timer timer1;

	private string selectedbodypart = "Head";

	private string currentclient = "2018M";

	private static readonly Regex sWhitespace = new Regex("\\s+");

	private bool _dragging;

	private Point _start_point = new Point(0, 0);

	private IContainer components;

	private Button button1;

	private Label label2;

	private TextBox textBox2;

	private Label label3;

	private TextBox textBox3;

	private Label label1;

	private TextBox textBox1;

	private Button button3;

	private ListBox listBox1;

	private TextBox textBox4;

	private Label label4;

	private TabControl tabControl1;

	private TabPage tabPage1;

	private TabPage tabPage2;

	private TabPage tabPage4;

	private ColorDialog colorDialog1;

	private Button button4;

	private Button button5;

	private TabPage tabPage5;

	private Button button6;

	private TabPage tabPage6;

	private TextBox textBox5;

	private Button button7;

	private Label label11;

	private Panel scriptArgumentPanel;

	private Button saveArgsToFileBtn;

	private Button openArgsFromFileBtn;

	private Button addArgumentButton;

	private Panel argumentTemplate;

	private Button removeArgument;

	private TextBox argumentValue;

	private ComboBox argumentType;

	private Button button8;

	private ListBox listBox2;

	private Label label13;

	private Label label5;

	private Label label10;

	private Button button9;

	private Button ExitButton;

	private Button button2;
    private Button button11;
    private TabPage tabPage3;
    private TabControl tabControl2;
    private TabPage tabPage7;
    private TabPage tabPage8;
    private Label label12;
    private ListBox listBox3;
    private Label label14;
    private TextBox textBox10;
    private Label label9;
    private TextBox textBox9;
    private Label label8;
    private TextBox textBox8;
    private Label label7;
    private TextBox textBox7;
    private Label label6;
    private TextBox textBox6;
    private Button button12;
    private Label label15;
    private TextBox textBox11;
    private PictureBox pictureBox1;
    private PictureBox pictureBox5;
    private PictureBox pictureBox4;
    private PictureBox pictureBox3;
    private PictureBox pictureBox2;
    private Label label16;
    private Panel panel1;
    private PictureBox pictureBox7;
    private Button button13;
    private ListBox listBox4;
    private Label label17;
    private Button button14;
    private TabPage tabPage9;
    private RichTextBox richTextBox1;
    private Label label19;
    private Label label18;
    private Button button15;
    private PictureBox pictureBox8;
    private Label label20;
    private Label label21;
    private Label label23;
    private Label label22;
    private ListBox listBox5;
    private Button button16;
    private Label label25;
    private Button button17;
    private Label label24;
    private Label label26;
    private Button button18;
    private Button button19;
    private Label label28;
    private Label label27;
    private ListBox listBox6;
    private Button button20;
    private Label label30;
    private Label label29;
    private Button button21;
    private Label label31;
    private Label label32;
    private ListBox listBox7;
    private Label label34;
    private Label label33;
    private Label label35;
    private Button button10;

    public Form1()
    {
        Application.ThreadException += (sender, args) =>
        {
            if (args.Exception is NullReferenceException)
            {
                return;
            }
        };
        InitializeComponent();
        InitializeDiscordRpc();
        listBox5.SelectedItem = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "Settings\\AdonisEnabled.txt");
        listBox7.SelectedItem = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "Settings\\membership.txt");
    }

    private DiscordRPC.DiscordRpcClient client;
    private System.Windows.Forms.Timer rpcTimer;
    bool IsSnapshot = false;
    private void InitializeDiscordRpc()
    {
        string settingsPath = AppDomain.CurrentDomain.BaseDirectory + "Settings\\DiscordRPC.txt";

        if (!File.Exists(settingsPath))
        {
            Directory.CreateDirectory(Path.GetDirectoryName(settingsPath));
            File.WriteAllText(settingsPath, "Fully Enabled");
        }

        client = new DiscordRPC.DiscordRpcClient("1517510862665945139");
        client.Initialize();

        rpcTimer = new System.Windows.Forms.Timer();
        rpcTimer.Interval = 5000;

        rpcTimer.Tick += (s, args) =>
        {
            if (client == null || client.IsDisposed) return;

            string rpcStatus = File.ReadAllText(settingsPath).Trim();

            if (rpcStatus == "Disabled")
            {
                if (client.CurrentPresence != null)
                {
                    client.ClearPresence();
                }
                return;
            }

            var presence = new DiscordRPC.RichPresence()
            {
                Assets = new DiscordRPC.Assets()
                {
                    LargeImageKey = "LuckyBlox Launcher",
                    LargeImageText = "LuckyBlox Launcher 0.7"
                }
            };

            if (rpcStatus == "Fully Enabled")
            {
                presence.Details = "In the launcher (0.7)";
                presence.State = "Info: " + currentclient + " ; " + textBox3.Text + " ; " + textBox2.Text;
            }
            else if (rpcStatus == "Show in-launcher only")
            {
                presence.Details = "In the launcher (0.7)";
                presence.State = "Info hidden";
            }

            client.SetPresence(presence);
            client.Invoke();
        };

        rpcTimer.Start();
    }

    protected override void OnFormClosed(FormClosedEventArgs e)
    {
        rpcTimer?.Stop();
        rpcTimer?.Dispose();
        client?.Dispose();
        base.OnFormClosed(e);
    }



    public string Get_Form1Text()
	{
		return textBox2.Text;
	}

	public void InitTimer()
	{
		timer1 = new System.Windows.Forms.Timer();
		timer1.Tick += timer1_Tick;
		timer1.Interval = 3500;
		timer1.Start();
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		if (label5.Text != "Clothing")
		{
			label5.Text = "Clothing";
		}
		if (!started2017)
		{
			string hostscr = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/shared/2017host.txt");
			hostscr = hostscr.Replace("%bodytype%", chartype);
			hostscr = hostscr.Replace("%port%", textBox4.Text);
			string port = "64989";
			string ip = "localhost";
			string baseurl = "roblox.com";
			string http = this.http;
			started2017 = true;
			Thread thread = new Thread((ThreadStart)delegate
			{
				jmmwantsitstable(ip, port, baseurl, http, hostscr);
			});
			thread.IsBackground = true;
			thread.Start();
		}
		if (!started2008)
		{
			string script = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/shared/2008host.txt");
			string ip2 = "localhost";
			string url = "localhost/";
			_ = this.http;
			started2008 = true;
			ParseXML(SOAP2.OpenJob(int.Parse("64989"), new Job("Test", double.Parse("600000"), 0, double.Parse("0")), new Script("GameServer", script, GetLuaValues()), url, ip2), "OpenJob");
		}
		List<LuaValueNew> GetLuaValues()
		{
			List<LuaValueNew> list = new List<LuaValueNew>();
			foreach (Control control in scriptArgumentPanel.Controls)
			{
				if (control.Name == "argumentTemplate" && control.Visible)
				{
					list.Add(new LuaValueNew(control.Controls["argumentType"].Text, control.Controls["argumentValue"].Text));
				}
			}
			return list;
		}
		static void ParseXML(string xml, string soapAction)
		{
			try
			{
				XDocument xDocument = XDocument.Parse(xml);
				dynamic val = null;
				switch (soapAction)
				{
				case "HelloWorld":
					val = (from x in xDocument.Descendants()
						where x.Name.LocalName == "HelloWorldResult"
						select x).FirstOrDefault();
					MessageBox.Show(val.FirstNode.ToString(), "HelloWorld Response", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					break;
				case "GetVersion":
					val = (from x in xDocument.Descendants()
						where x.Name.LocalName == "GetVersionResult"
						select x).FirstOrDefault();
					MessageBox.Show(val.FirstNode.ToString(), "GetVersion Response", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					break;
				case "OpenJobEx":
					MessageBox.Show("Success!", "OpenJobEx Response", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					break;
				case "RenewLease":
					val = (from x in xDocument.Descendants()
						where x.Name.LocalName == "RenewLeaseResult"
						select x).FirstOrDefault();
					MessageBox.Show(val.FirstNode.ToString(), "RenewLease Response", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					break;
				case "ExecuteEx":
					MessageBox.Show("Success!", "ExecuteEx Response", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					break;
				case "Execute":
					MessageBox.Show("Success!", "Execute Response", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					break;
				case "CloseJob":
					MessageBox.Show("Success!", "CloseJob Response", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					break;
				case "DiagEx":
					val = (from x in xDocument.Descendants()
						where x.Name.LocalName == "DiagExResult"
						select x).FirstOrDefault();
					MessageBox.Show(val.ToString(), "DiagEx Response", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					break;
				case "Diag":
					val = (from x in xDocument.Descendants()
						where x.Name.LocalName == "DiagResult"
						select x).FirstOrDefault();
					MessageBox.Show(val.ToString(), "Diag Response", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					break;
				case "GetAllJobsEx":
					val = (from x in xDocument.Descendants()
						where x.Name.LocalName == "GetAllJobsExResult"
						select x).FirstOrDefault();
					MessageBox.Show(val.ToString(), "GetAllJobsEx Response", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					break;
				case "GetAllJobs":
					val = (from x in xDocument.Descendants()
						where x.Name.LocalName == "GetAllJobsResult"
						select x).FirstOrDefault();
					MessageBox.Show(val.ToString(), "GetAllJobs Response", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					break;
				case "CloseExpiredJobs":
					val = (from x in xDocument.Descendants()
						where x.Name.LocalName == "CloseExpiredJobsResult"
						select x).FirstOrDefault();
					MessageBox.Show("Jobs closed: " + val.FirstNode.ToString(), "CloseExpiredJobs Response", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					break;
				case "CloseAllJobs":
					val = (from x in xDocument.Descendants()
						where x.Name.LocalName == "CloseAllJobsResult"
						select x).FirstOrDefault();
					MessageBox.Show("Jobs closed: " + val.FirstNode.ToString(), "CloseAllJobs Response", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					break;
				default:
					MessageBox.Show("Attempt to call ParseXML(string xml, string soapAction) with invalid arguments", "ParseXML(string xml, string soapAction) error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					break;
				case "OpenJob":
					break;
				}
			}
			catch
			{
			}
		}
	}

	public static void CopyFilesRecursively(DirectoryInfo source, DirectoryInfo target)
	{
		DirectoryInfo[] directories = source.GetDirectories();
		foreach (DirectoryInfo directoryInfo in directories)
		{
			try
			{
				CopyFilesRecursively(directoryInfo, target.CreateSubdirectory(directoryInfo.Name));
			}
			catch (Exception)
			{
			}
		}
		FileInfo[] files = source.GetFiles();
		foreach (FileInfo fileInfo in files)
		{
			if (File.Exists(target.FullName + "\\" + fileInfo.Name))
			{
				File.Delete(target.FullName + "\\" + fileInfo.Name);
			}
			fileInfo.CopyTo(Path.Combine(target.FullName, fileInfo.Name));
		}
	}

	private static void ExecuteCommand(string command)
	{
		Process.Start(new ProcessStartInfo("cmd.exe", "/c " + command)
		{
			CreateNoWindow = true,
			UseShellExecute = false,
			RedirectStandardError = true,
			RedirectStandardOutput = true
		}).Close();
	}

    private void playaudio() // normal click sound
    {
		SoundPlayer audio = new SoundPlayer(_2017Launcher.Properties.Resource1._switch); ; // click sound, feel free to disable.
        audio.Play();
    }

    private void playaudio1() // clear appearence sound
    {
        SoundPlayer audio = new SoundPlayer(_2017Launcher.Properties.Resource1.ClearAppear); ; // click sound, feel free to disable.
        audio.Play();
    }

    private void playaudio2() // clear appearence sound
    {
        SoundPlayer audio = new SoundPlayer(_2017Launcher.Properties.Resource1.Switch2); ; // click sound, feel free to disable.
        audio.Play();
    }

    private void playaudio3() // clear appearence sound
    {
        SoundPlayer audio = new SoundPlayer(_2017Launcher.Properties.Resource1.tabsound); ; // click sound, feel free to disable.
        audio.Play();
    }

    private void Form1_Load(object sender, EventArgs e)
	{
		if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\Clients"))
		{
			Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\Clients");
		}
		if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\Settings"))
		{
			Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\Settings");
		}
		if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\Settings\\assetsaving"))
		{
			Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\Settings\\assetsaving");
		}
		if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\Settings\\BodyColors"))
		{
			Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\Settings\\BodyColors");
		}
        try
        {
            listBox1.Items.Clear();
            string[] directories = Directory.GetDirectories(AppDomain.CurrentDomain.BaseDirectory + "\\Clients");
            for (int i = 0; i < directories.Length; i++)
            {
                listBox1.Items.Add(Path.GetFileName(directories[i]));
            }
        }
        catch
        {
            if (MessageBox.Show("Clients folder not found. LuckyBlox Launcher is need to quit. We re sorry!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop) == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.Close();
            }
        }
        try
        {
            listBox4.Items.Clear();
            string[] directories4 = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + "\\Maps");
            for (int i = 0; i < directories4.Length; i++)
            {
                listBox4.Items.Add(Path.GetFileName(directories4[i]));
            }
        }
        catch
        {
            if (MessageBox.Show("Maps folder not found. LuckyBlox Launcher is need to quit. We re sorry!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop) == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.Close();
            }
        }
        InitTimer();
        if (IsSnapshot == true)
        {
            label16.Text = "LuckyBlox Launcher Snapshot 0.7_1";
            label16.BackColor = Color.FromArgb(128, 64, 64);
        }
        else
        {
            Random rndtext = new Random();
            string[] phrases = { "looking some guy want to patch new client?", "confuse publickey and privatekey", "whata ama patchez", "thats my house, builderman", "letz play crossroads", "'hey atpiedd where tha 2015M client :(((('", "tired of patching? download luckyblox launcher!", "if you playing obby, and SPACE not work, try W", "what are you think about this launcher?", "this is my pizzeria, Dued1 muahahahaha!", "incredible client", "u saying 'retrostud better', i am say 'only 3Gb~ on disk'", "Also try Novetus!", "Also try another revivals, if this tired of", "also try to play with RTX210 (Not GT210)", "We trying to settle this situations about 'my revival better'", "The LuckyBlox Launcher Creator is 13 years old, are u know?", "Welcome to HeavenBlox!", "Rocket launcher says: 'KABOOMM!!!'", "Today is day of day from day", "steal lil brother nintendo switch to be cool in school", "one pizza and a one patched client please", "Boo", "why are you use filtering and how", "good times", "please don't play without computer", "what happened if you delete Shaders in Roblox folder?", "Your favorite dream women OR play old roblox again?", "To be continued", "bleh!", "hey Bitl, can we made a collab?", "Powering imagination", "Wait for LuckyBlox 2!"};
            int index = rndtext.Next(phrases.Length);
            label16.Text = phrases[index];
        }
        label17.Text = "Current map patch:\r\n" + File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "Settings/MapPath.txt");
        string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Settings", "BodyColors");

        listBox6.SelectedItem = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "Settings\\DiscordRPC.txt");

        if (Directory.Exists(folderPath))
        {
            if (File.Exists(Path.Combine(folderPath, "HeadColor.txt")))
                textBox6.Text = File.ReadAllText(Path.Combine(folderPath, "HeadColor.txt"));

            if (File.Exists(Path.Combine(folderPath, "TorsoColor.txt")))
                textBox7.Text = File.ReadAllText(Path.Combine(folderPath, "TorsoColor.txt"));

            if (File.Exists(Path.Combine(folderPath, "RightArmColor.txt")))
                textBox8.Text = File.ReadAllText(Path.Combine(folderPath, "RightArmColor.txt"));

            if (File.Exists(Path.Combine(folderPath, "LeftArmColor.txt")))
                textBox9.Text = File.ReadAllText(Path.Combine(folderPath, "LeftArmColor.txt"));

            if (File.Exists(Path.Combine(folderPath, "RightLegColor.txt")))
                textBox10.Text = File.ReadAllText(Path.Combine(folderPath, "RightLegColor.txt"));

            if (File.Exists(Path.Combine(folderPath, "LeftLegColor.txt")))
                textBox11.Text = File.ReadAllText(Path.Combine(folderPath, "LeftLegColor.txt"));
        }
    }

	private void textBox2_TextChanged(object sender, EventArgs e)
	{
	}

	private void jmmwantsitstablebutjson(string ip, string port, string baseurl, string text, string req)
	{
		try
		{
			SOAP.jsonExecute(baseurl, ip + ":" + port, text, req);
		}
		catch
		{
		}
	}

	private void jmmwantsitstable(string ip, string port, string baseurl, string req, string scr)
	{
		try
		{
			SOAP.ExecuteScript(ip + ":" + port, "RanScript", scr, "Test", "", baseurl, req);
		}
		catch
		{
		}
	}

	public static void OpenClient(string rbxexe, string args, string mapname, bool customization = false)
	{
		Process process = new Process();
		process.StartInfo.FileName = rbxexe;
		process.StartInfo.WorkingDirectory = Path.GetDirectoryName(rbxexe);
		process.StartInfo.Arguments = args;
		process.Start();
	}

	private void button1_Click(object sender, EventArgs e)
	{
        playaudio();
        string text = listBox1.SelectedItem.ToString();
		if (text == "Empty")
		{
			return;
		}
		string text2 = "password=" + num;
		string text3 = "_G.AdminPasswordPublic = '" + text2 + "'\r\n\r\n";
		try
		{
			string text4 = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "Settings\\ServerScript.txt");
			string path = AppDomain.CurrentDomain.BaseDirectory.ToString() + "Clients\\" + text + "\\Player\\content\\scripts\\CoreScripts\\ServerStarterScript.lua";
			text4 = text4.Replace("%bodytype%", chartype);
			File.WriteAllText(path, text3 + text4);
		}
		catch
		{
			string text5 = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "Settings\\ServerScript.txt");
			string path2 = AppDomain.CurrentDomain.BaseDirectory.ToString() + "shared\\content\\scripts\\CoreScripts\\ServerStarterScript.lua";
			text5 = text5.Replace("%bodytype%", chartype);
			File.WriteAllText(path2, text3 + text5);
		}
		try
		{
			string text6 = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "Settings\\2021Server.lua");
			string path3 = AppDomain.CurrentDomain.BaseDirectory.ToString() + "shared\\ExtraContent\\scripts\\CoreScripts\\ServerStarterScript.lua";
			text6 = text6.Replace("%bodytype%", chartype);
			File.WriteAllText(path3, text3 + text6);
		}
		catch
		{
		}
		string text7 = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/Settings/MapPath.txt");
		if (File.Exists(text7))
		{
			string path4 = AppDomain.CurrentDomain.BaseDirectory + "Webserver/www/.127.0.0.1/asset/1818";
			if (File.Exists(path4))
			{
				File.Delete(path4);
			}
			string destFileName = AppDomain.CurrentDomain.BaseDirectory + "Webserver/www/.127.0.0.1/asset/1818";
			try
			{
				File.Copy(text7, destFileName, overwrite: true);
			}
			catch (IOException ex)
			{
				Console.WriteLine(ex.Message);
			}
			string path5 = AppDomain.CurrentDomain.BaseDirectory + "Webserver/www/.localhost/asset/1818";
			if (File.Exists(path5))
			{
				File.Delete(path5);
			}
			string destFileName2 = AppDomain.CurrentDomain.BaseDirectory + "Webserver/www/.localhost/asset/1818";
			try
			{
				File.Copy(text7, destFileName2, overwrite: true);
			}
			catch (IOException ex2)
			{
				Console.WriteLine(ex2.Message);
			}
			string path6 = AppDomain.CurrentDomain.BaseDirectory + "shared/content/place.rbxl";
			if (File.Exists(path6))
			{
				File.Delete(path6);
			}
			string destFileName3 = AppDomain.CurrentDomain.BaseDirectory + "shared/content/place.rbxl";
			try
			{
				File.Copy(text7, destFileName3, overwrite: true);
			}
			catch (IOException ex3)
			{
				Console.WriteLine(ex3.Message);
			}
			string path7 = AppDomain.CurrentDomain.BaseDirectory + "shared/content/1818";
			if (File.Exists(path7))
			{
				File.Delete(path7);
			}
			string destFileName4 = AppDomain.CurrentDomain.BaseDirectory + "shared/content/1818";
			try
			{
				File.Copy(text7, destFileName4, overwrite: true);
			}
			catch (IOException ex4)
			{
				Console.WriteLine(ex4.Message);
			}
			string path8 = AppDomain.CurrentDomain.BaseDirectory + "Clients\\2014M\\content\\temp.rbxl";
			if (File.Exists(path8))
			{
				File.Delete(path8);
			}
			string destFileName5 = AppDomain.CurrentDomain.BaseDirectory + "Clients\\2014M\\content\\temp.rbxl";
			try
			{
				File.Copy(text7, destFileName5, overwrite: true);
			}
			catch (IOException ex5)
			{
				Console.WriteLine(ex5.Message);
			}
            string path9 = AppDomain.CurrentDomain.BaseDirectory + "Clients\\" + currentclient + "\\content\\temp.rbxl";
            if (File.Exists(path9))
            {
                File.Delete(path9);
            }
            string destFileName6 = AppDomain.CurrentDomain.BaseDirectory + "Clients\\" + currentclient + "\\content\\temp.rbxl";
            try
            {
                File.Copy(text7, destFileName6, overwrite: true);
            }
            catch (IOException ex6)
            {
                Console.WriteLine(ex6.Message);
            }
        }
		using (StreamWriter streamWriter = new StreamWriter(new SaveFileDialog
		{
			FileName = AppDomain.CurrentDomain.BaseDirectory + "Settings/HostPort.txt"
		}.FileName))
		{
			streamWriter.WriteLine(textBox4.Text);
		}
		string text8 = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/Settings/Fix.ini");
		if (currentclient == "2022M")
		{
			string text9 = "";
			switch (MessageBox.Show("Would you like to host without filtering? (Clicking no is insecure!)", "LuckyBlox Launcher", MessageBoxButtons.YesNo))
			{
			case DialogResult.Yes:
				text9 = "_G.FilteringEnabled=true";
				break;
			case DialogResult.No:
				text9 = "_G.FilteringEnabled=false";
				break;
			}
			string value = "<roblox xmlns:xmime=" + text8 + "http://www.w3.org/2005/05/xmlmime" + text8 + " xmlns:xsi=" + text8 + "http://www.w3.org/2001/XMLSchema-instance" + text8 + " xsi:noNamespaceSchemaLocation=" + text8 + "http://www.localhost//roblox.xsd" + text8 + " version=" + text8 + "4" + text8 + ">\r\n    <External>null</External>\r\n    <External>nil</External>\r\n    <Item class=" + text8 + "Script" + text8 + " referent=" + text8 + "RBXA9BF459DE88842189FF810D1F9615061" + text8 + ">\r\n\t\t<Properties>\r\n\t\t\t<bool name =" + text8 + "Disabled" + text8 + ">false</bool>\r\n            <Content name=" + text8 + "LinkedSource" + text8 + "><null></null></Content>\r\n\t\t\t<string name =" + text8 + "Name" + text8 + ">Script</string>\r\n            <string name=" + text8 + "ScriptGuid" + text8 + ">{1166F3A8-F70B-4DAF-B7C6-3C89D8BBC049}</string>\r\n\t\t\t<ProtectedString name=" + text8 + "Source" + text8 + "><![CDATA[" + text9 + "]]></ProtectedString>\r\n            <BinaryString name=" + text8 + "Tags" + text8 + "></BinaryString>\r\n\t\t</Properties>\r\n\t</Item>\r\n</roblox>";
			using (StreamWriter streamWriter2 = new StreamWriter(new SaveFileDialog
			{
				FileName = AppDomain.CurrentDomain.BaseDirectory + "shared/content/server.rbxmx"
			}.FileName))
			{
				streamWriter2.WriteLine(value);
			}
			string text10 = "\"";
			string rbxexe = AppDomain.CurrentDomain.BaseDirectory + "Clients/" + currentclient + "/RobloxStudioBeta.exe";
			string text11 = AppDomain.CurrentDomain.BaseDirectory + "shared/content/place.rbxl";
			string mapname = "place.rbxl";
			string args = text10 + "\" -localPlaceFile " + text8 + text11 + text8 + " -task StartServer -port " + textBox4.Text + text10;
			OpenClient(rbxexe, args, mapname);
			return;
		}
		if (currentclient == "2016L" || currentclient == "2015L")
		{
			string text12 = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/shared/test.txt");
			text12 = text12.Replace("%bodytype%", chartype);
			text12 = text12.Replace("%port%", textBox4.Text);
			using (StreamWriter streamWriter3 = new StreamWriter(new SaveFileDialog
			{
				FileName = AppDomain.CurrentDomain.BaseDirectory + "/shared/gameserver.txt"
			}.FileName))
			{
				streamWriter3.WriteLine(text12);
			}
			Process.Start(new ProcessStartInfo(AppDomain.CurrentDomain.BaseDirectory + "shared\\" + currentclient + ".bat")
			{
				UseShellExecute = true
			});
			return;
		}
		if (currentclient == "2017M")
		{
			ExecuteCommand("start shared\\" + currentclient + ".bat -Console -verbose -placeid:1818 -port 64989");
			started2017 = false;
			return;
		}
        if (currentclient == "2021M")
        {
            string text13 = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/Settings/gameserverraw.json");
            text13 = text13.Replace("%port%", textBox4.Text);
            using (StreamWriter streamWriter4 = new StreamWriter(new SaveFileDialog
            {
                FileName = AppDomain.CurrentDomain.BaseDirectory + "shared\\gameserver.json"
            }.FileName))
            {
                streamWriter4.WriteLine(text13);
            }
            ExecuteCommand("start shared\\2021M.bat");
            return;
        }
        if (currentclient == "2021E")
		{
			string text13 = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/Settings/gameserverraw.json");
			text13 = text13.Replace("%port%", textBox4.Text);
			using (StreamWriter streamWriter4 = new StreamWriter(new SaveFileDialog
			{
				FileName = AppDomain.CurrentDomain.BaseDirectory + "shared\\gameserver.json"
			}.FileName))
			{
				streamWriter4.WriteLine(text13);
			}
			ExecuteCommand("start shared\\" + currentclient + ".bat");
			return;
		}
		if (currentclient == "2020L")
		{
			string text14 = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/Settings/gameserverraw.json");
			text14 = text14.Replace("%port%", textBox4.Text);
			using (StreamWriter streamWriter5 = new StreamWriter(new SaveFileDialog
			{
				FileName = AppDomain.CurrentDomain.BaseDirectory + "shared\\gameserver.json"
			}.FileName))
			{
				streamWriter5.WriteLine(text14);
			}
			ExecuteCommand("start shared\\" + currentclient + ".bat");
			return;
		}
		if (currentclient == "2014M")
		{
			ExecuteCommand("start Clients\\2014M\\RCCService.exe -a " + text8 + "http://localhost/www.civdefn.tk/" + text8 + " -j " + text8 + "http://localhost/www.civdefn.tk/game/host.php?port=" + textBox4.Text + text8 + " -t " + text8 + "1" + text8);
			return;
		}
        if (currentclient == "2014L")
        {
            ExecuteCommand("start Clients\\2014L\\RobloxPlayerBeta.exe -a " + text8 + "http://localhost/www.civdefn.tk/" + text8 + " -j " + text8 + "http://localhost/www.civdefn.tk/game/host.php?port=" + textBox4.Text + text8 + " -t " + text8 + "1" + text8);
            return;
        }
        if (currentclient == "2013L")
		{
			ExecuteCommand("start Clients\\2013L\\RCCService.exe -a " + text8 + "http://localhost/www.civdefn.tk/" + text8 + " -j " + text8 + "http://localhost/www.civdefn.tk/game/host.php?port=" + textBox4.Text + text8 + " -t " + text8 + "1" + text8);
			return;
		}
        if (currentclient == "2008M")
        {
            System.Windows.Forms.Timer backgroundTimer = null;
            if (this.components != null)
            {
                foreach (var item in this.components.Components)
                {
                    if (item is System.Windows.Forms.Timer)
                    {
                        backgroundTimer = (System.Windows.Forms.Timer)item;
                        backgroundTimer.Stop();
                    }
                }
            }

            string Basedir = AppDomain.CurrentDomain.BaseDirectory;
            string sourceFile = Path.Combine(Basedir, "shared", "content", "temp.rbxl");
            string destFile = Path.Combine(Basedir, "Clients", currentclient, "Player", "content", "temp.rbxl");

            File.Copy(sourceFile, destFile, true);

            string selectedPort = "53640";
            if (textBox4 != null && !string.IsNullOrEmpty(textBox4.Text))
            {
                selectedPort = textBox4.Text;
            }

            string hostFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Clients", "2008M", "Player", "content", "host.txt");

            if (File.Exists(hostFilePath))
            {
                string fileContent = File.ReadAllText(hostFilePath);
                if (fileContent.Contains("%port%"))
                {
                    fileContent = fileContent.Replace("%port%", selectedPort);
                    File.WriteAllText(hostFilePath, fileContent);
                }
            }

            string exePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Clients", currentclient, "Player", "Roblox.exe");
            string arguments = "-script \"dofile('rbxasset://host.txt')\"";

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = exePath,
                Arguments = arguments,
                WorkingDirectory = Path.GetDirectoryName(exePath)
            });

            started2008 = false;
            return;
        }

        if (currentclient == "2007E")
        {
            string text15 = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/shared/2008hostoriginal.txt");
            text15 = text15.Replace("%port%", textBox4.Text);
            using (StreamWriter streamWriter6 = new StreamWriter(new SaveFileDialog
            {
                FileName = AppDomain.CurrentDomain.BaseDirectory + "/shared/2008host.txt"
            }.FileName))
            {
                streamWriter6.WriteLine(text15);
            }
            ExecuteCommand("start Clients\\" + currentclient + "\\RCCService\\RCCService.bat");
            started2008 = false;
            return;
        }
        if (currentclient == "2013")
		{
			string text16 = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/shared/2008hostoriginal.txt");
			text16 = text16.Replace("%port%", textBox4.Text);
			using (StreamWriter streamWriter7 = new StreamWriter(new SaveFileDialog
			{
				FileName = AppDomain.CurrentDomain.BaseDirectory + "/Clients/2013/Player/content/2014host.txt"
			}.FileName))
			{
				streamWriter7.WriteLine(text16);
			}
			ExecuteCommand("start Clients\\" + currentclient + "\\Player\\RCCService.bat");
			return;
		}
		try
		{
			string text17 = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/Settings/gameserverraw.json");
			text17 = text17.Replace("%port%", textBox4.Text);
			using (StreamWriter streamWriter8 = new StreamWriter(new SaveFileDialog
			{
				FileName = AppDomain.CurrentDomain.BaseDirectory + "shared/gameserver.json"
			}.FileName))
			{
				streamWriter8.WriteLine(text17);
			}
			ExecuteCommand("start shared\\" + currentclient + ".bat");
		}
		catch
		{
			string text18 = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/Settings/gameserverraw.json");
			text18 = text18.Replace("%port%", textBox4.Text);
			using (StreamWriter streamWriter9 = new StreamWriter(new SaveFileDialog
			{
				FileName = AppDomain.CurrentDomain.BaseDirectory + "shared/gameserver.json"
			}.FileName))
			{
				streamWriter9.WriteLine(text18);
			}
			ExecuteCommand("start shared/" + currentclient + ".exe -Console -verbose -placeid:1818 -localtest " + text8 + "gameserver.json" + text8 + "  -port 64989");
		}
	}

	private static string RemoveWhitespace(string input)
	{
		return new string((from c in input.ToCharArray()
			where !char.IsWhiteSpace(c)
			select c).ToArray());
	}

	private void button2_Click(object sender, EventArgs e)
	{
        playaudio();
        using (StreamWriter streamWriter = new StreamWriter(new SaveFileDialog
		{
			FileName = AppDomain.CurrentDomain.BaseDirectory + "Settings/username.txt"
		}.FileName))
		{
			streamWriter.WriteLine(textBox1.Text);
		}
		using (StreamWriter streamWriter2 = new StreamWriter(new SaveFileDialog
		{
			FileName = AppDomain.CurrentDomain.BaseDirectory + "Settings/ip.txt"
		}.FileName))
		{
			streamWriter2.WriteLine(textBox3.Text);
		}
		using (StreamWriter streamWriter3 = new StreamWriter(new SaveFileDialog
		{
			FileName = AppDomain.CurrentDomain.BaseDirectory + "Settings/clientport.txt"
		}.FileName))
		{
			streamWriter3.WriteLine(textBox2.Text);
		}
		string text = "_G.ShowNames=true";
		string text2 = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/Settings/Fix.ini");
		string text3 = RemoveWhitespace(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/Settings/Appearence.ini")) + ";password=" + num + "|" + headcolor + ";" + torsocolor + ";" + leftarmcolor + ";" + rightarmcolor + ";" + leftlegcolor + ";" + rightlegcolor;
		string mapname = "1818";
		string rbxexe = AppDomain.CurrentDomain.BaseDirectory + "Clients/" + currentclient + "/RobloxStudioBeta.exe";
		string text4 = "\"";
		if (currentclient == "2022M")
		{
			text3 = RemoveWhitespace(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/Settings/Appearence.ini"));
			string text5 = text + " _G.app='" + text3 + "' print(_G.app)\r\norigstring =_G.app\r\nlocal foundchar=false\r\nlocal username1 = '" + textBox1.Text.Replace("\n", "").Replace("\r", "") + "'  \r\nlocal username = '" + textBox1.Text.Replace("\n", "").Replace("\r", "") + "' \r\nlocal a=Instance.new('StringValue') a.Parent=game:GetService('ReplicatedStorage') a.Name=game:GetService('Players').LocalPlayer.Name a.Value=username\r\nlocal number= nil\r\n local words = {}\r\nfor w in (origstring .. ';'):gmatch('([^;]*);') do \r\n    table.insert(words, w) \r\nend\r\nlocal num1=words[1]\r\nfunction loadchar()\r\nwait(1)\r\nlocal char = game:GetService('Players').LocalPlayer.Character\r\nfor i,v in pairs(words) do\r\n    pcall(function()\r\n\tlocal a=game:GetService('ReplicatedStorage'):FindFirstChild('charapp')\r\n     a:FireServer(v)\r\n\t end)\r\n\tend\r\ngame:GetService('ReplicatedStorage').BodyColorsRemote:FireServer('" + headcolor + ";" + torsocolor + ";" + leftarmcolor + ";" + rightarmcolor + ";" + leftlegcolor + ";" + rightlegcolor + "')\r\nlocal a={}\r\ngame:GetService('ReplicatedStorage').Nametag:FireServer(username)\r\nend\r\ngame:GetService('Players').PlayerAdded:connect(function(plr)\r\nif plr == game:GetService('Players').LocalPlayer then\r\nfoundchar=true\r\nif workspace:FindFirstChild(plr.Name) then\r\nif plr.Character~=nil then\r\nloadchar()\r\nend\r\nend\r\ngame:GetService('Players').LocalPlayer.CharacterAdded:connect(function()\r\npcall(function()\r\nloadchar()\r\nend)\r\nend)\r\nend\r\nend)\r\nrepeat wait() until game:GetService('Players').LocalPlayer.Character~=nil\r\nlocal char=game:GetService('Players').LocalPlayer.Character\r\n\r\nwait(0.1)\r\nif foundchar==false and game:GetService('Players').LocalPlayer~=nil then\r\nloadchar()\r\ngame:GetService('Players').LocalPlayer.CharacterAdded:connect(function()\r\npcall(function()\r\nloadchar()\r\nend)\r\nend)\r\nelse\r\nrepeat wait() until game:GetService('Players').LocalPlayer~=nil\r\nloadchar()\r\ngame:GetService('Players').LocalPlayer.CharacterAdded:connect(function()\r\npcall(function()\r\nloadchar()\r\nend)\r\nend)\r\nend\r\nlocal shortcut=Instance.new('BoolValue',game:GetService('Players').LocalPlayer) shortcut.Name='ShowNames' shortcut.Value=_G.ShowNames";
			string value = "<roblox xmlns:xmime=" + text2 + "http://www.w3.org/2005/05/xmlmime" + text2 + " xmlns:xsi=" + text2 + "http://www.w3.org/2001/XMLSchema-instance" + text2 + " xsi:noNamespaceSchemaLocation=" + text2 + "http://www.localhost//roblox.xsd" + text2 + " version=" + text2 + "4" + text2 + ">\r\n    <External>null</External>\r\n    <External>nil</External>\r\n    <Item class=" + text2 + "LocalScript" + text2 + " referent=" + text2 + "RBXA9BF459DE88842189FF810D1F9615061" + text2 + ">\r\n\t\t<Properties>\r\n\t\t\t<bool name =" + text2 + "Disabled" + text2 + ">false</bool>\r\n            <Content name=" + text2 + "LinkedSource" + text2 + "><null></null></Content>\r\n\t\t\t<string name =" + text2 + "Name" + text2 + ">LocalScript</string>\r\n            <string name=" + text2 + "ScriptGuid" + text2 + ">{1166F3A8-F70B-4DAF-B7C6-3C89D8BBC049}</string>\r\n\t\t\t<ProtectedString name=" + text2 + "Source" + text2 + "><![CDATA[" + text5 + "]]></ProtectedString>\r\n            <BinaryString name=" + text2 + "Tags" + text2 + "></BinaryString>\r\n\t\t</Properties>\r\n\t</Item>\r\n</roblox>";
			using (StreamWriter streamWriter4 = new StreamWriter(new SaveFileDialog
			{
				FileName = AppDomain.CurrentDomain.BaseDirectory + "shared/ExtraContent/test.rbxmx"
			}.FileName))
			{
				streamWriter4.WriteLine(value);
			}
			string args = text4 + "\" -task StartClient -server " + text2 + textBox3.Text.Replace("\n", "").Replace("\r", "") + text2 + " -port " + textBox2.Text + text4;
			OpenClient(rbxexe, args, mapname);
		}
        else if (currentclient == "2015L")
        {
            ExecuteCommand("start shared/2015LPlayer.exe -a " + text2 + "http://localhost/login/negotiate.ashx" + text2 + " -j " + text2 + "http://localhost/game/placelaunchrrr.php/?placeid=1818&ip=" + textBox3.Text + "&port=" + textBox2.Text + "&id=" + num + "&app=" + text3 + "&user=" + textBox1.Text + text2 + " -t " + text2 + "1" + text2);
        }
        else if (currentclient == "2015M")
        {
            ExecuteCommand("start shared/2015MPlayer.exe -a " + text2 + "http://localhost/login/negotiate.ashx" + text2 + " -j " + text2 + "http://localhost/game/placelaunchrrr.php/?placeid=1818&ip=" + textBox3.Text + "&port=" + textBox2.Text + "&id=" + num + "&app=" + text3 + "&user=" + textBox1.Text + text2 + " -t " + text2 + "1" + text2);
        }
        else if (currentclient == "2016L")
        {
            ExecuteCommand("start shared/2016Player.exe -a " + text2 + "http://localhost/login/negotiate.ashx" + text2 + " -j " + text2 + "http://localhost/game/placelaunchrrr.php/?placeid=1818&ip=" + textBox3.Text + "&port=" + textBox2.Text + "&id=" + num + "&app=" + text3 + "&user=" + textBox1.Text + text2 + " -t " + text2 + "1" + text2);
        }
        else if (currentclient == "2017M")
        {
            ExecuteCommand("start shared/2017Player.exe -a " + text2 + "http://localhost/login/negotiate.ashx" + text2 + " -j " + text2 + "http://localhost/game/join.php/?placeid=1818&ip=" + textBox3.Text + "&port=" + textBox2.Text + "&id=" + num + "&app=" + text3 + "&user=" + textBox1.Text + text2 + " -t " + text2 + "1" + text2);
        }
        else if (currentclient == "2014M")
        {
            text3 = text3.Replace("localhost", "localhost/www.civdefn.tk/");
            ExecuteCommand("start Clients\\2014M\\RobloxPlayerBeta.exe -a " + text2 + "http://localhost/www.civdefn.tk/" + text2 + " -j " + text2 + "http://localhost/www.civdefn.tk/game/join.php?port=" + textBox4.Text + "&app=" + text3 + "&ip=" + textBox3.Text + "&username=" + textBox1.Text + "&id=" + num + "&mode=1" + text2 + " -t " + text2 + "1" + text2);
        }
        else if (currentclient == "2014L")
        {
            text3 = text3.Replace("localhost", "localhost/www.civdefn.tk/");
            ExecuteCommand("start Clients\\2014L\\RobloxPlayerBeta.exe -a " + text2 + "http://localhost/www.civdefn.tk/" + text2 + " -j " + text2 + "http://localhost/www.civdefn.tk/game/join.php?port=" + textBox4.Text + "&app=" + text3 + "&ip=" + textBox3.Text + "&username=" + textBox1.Text + "&id=" + num + "&mode=1" + text2 + " -t " + text2 + "1" + text2);
        }
        else if (currentclient == "2013L")
        {
            text3 = text3.Replace("localhost", "localhost/www.civdefn.tk/");
            ExecuteCommand("start Clients\\2013L\\RobloxPlayerBeta.exe -a " + text2 + "http://localhost/www.civdefn.tk/" + text2 + " -j " + text2 + "http://localhost/www.civdefn.tk/game/join.php?port=" + textBox4.Text + "&app=" + text3 + "&ip=" + textBox3.Text + "&username=" + textBox1.Text + "&id=" + num + "&mode=1" + text2 + " -t " + text2 + "1" + text2);
        }
        else if (currentclient == "2021M")
        {
            text3 = text3.Replace("1111111", "");
            ExecuteCommand("start Clients\\2021M\\RobloxPlayerBeta.exe -a " + text2 + "http://localhost/2021/login/negotiate.ashx" + text2 + " -j " + text2 + "http://localhost/2021/game/placelauncher.ashx?placeid=1818&ip=" + textBox3.Text + "&user=" + textBox1.Text + "&membership=" + listBox7.SelectedItem + "&port=" + textBox2.Text + "&id=" + num + "&app=" + text3 + text2 + " -t " + text2 + "1" + text2);
        }
        else if (currentclient == "2021E")
        {
            text3 = text3.Replace("1111111", "");
            ExecuteCommand("start Clients\\2021E\\RCCService\\RobloxPlayerBeta.exe -a " + text2 + "http://localhost/2021/login/negotiate.ashx" + text2 + " -j " + text2 + "http://localhost/2021/game/placelauncher.ashx?placeid=1818&ip=" + textBox3.Text + "&user=" + textBox1.Text + "&membership=" + listBox7.SelectedItem + "&port=" + textBox2.Text + "&id=" + num + "&app=" + text3 + text2 + " -t " + text2 + "1" + text2);
        }
        else if (currentclient == "2020E")
        {
            text3 = text3.Replace("1111111", "");
            ExecuteCommand("start Clients\\2020E\\RobloxPlayerBeta.exe -a " + text2 + "http://localhost/2021/login/negotiate.ashx" + text2 + " -j " + text2 + "http://localhost/2021/game/placelauncher.ashx?placeid=1818&ip=" + textBox3.Text + "&user=" + textBox1.Text + "&membership=" + listBox7.SelectedItem + "&port=" + textBox2.Text + "&id=" + num + "&app=" + text3 + text2 + " -t " + text2 + "1" + text2);
        }
        else if (currentclient == "2020L")
        {
            MessageBox.Show("The selected client does not have RobloxPlayer, but you can still connect to the server using 2021E or 2021M due to backward compatibility.", "Connecting from 2020L", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        else if (currentclient == "2020M")
        {
            text3 = text3.Replace("1111111", "");
            ExecuteCommand("start Clients\\2020M\\RobloxPlayerBeta.exe -a " + text2 + "http://localhost/2021/login/negotiate.ashx" + text2 + " -j " + text2 + "http://localhost/2021/game/placelauncher.ashx?placeid=1818&ip=" + textBox3.Text + "&user=" + textBox1.Text + "&membership=" + listBox7.SelectedItem + "&port=" + textBox2.Text + "&id=" + num + "&app=" + text3 + text2 + " -t " + text2 + "1" + text2);
        }
        else if (currentclient == "2008M")
        {
            string text6 = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "Clients/2008M/join.txt");
            text6 = text6.Replace("%port%", textBox4.Text);
            text6 = text6.Replace("%ip%", text2 + textBox3.Text + text2);
            text6 = text6.Replace("%name%", text2 + textBox1.Text + text2);
            text6 = text6.Replace("%id%", num.ToString());
            text3 = RemoveWhitespace(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/Settings/Appearence.ini")) + "|" + headcolor + ";" + torsocolor + ";" + leftarmcolor + ";" + rightarmcolor + ";" + leftlegcolor + ";" + rightlegcolor;
            text6 = "charapp = [[" + text3 + "]]  \n" + text6;
            using (StreamWriter streamWriter5 = new StreamWriter(new SaveFileDialog
            {
                FileName = AppDomain.CurrentDomain.BaseDirectory + "Clients/2008M/Player/content/join.txt"
            }.FileName))
            {
                streamWriter5.WriteLine(text6);
            }
            ExecuteCommand("start Clients/2008M/Player/Roblox.exe -script " + text2 + "dofile('rbxasset://join.txt')" + text2);
        }
        else if (currentclient == "2013")
        {
            string text7 = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "Clients/2013/join.txt");
            text7 = text7.Replace("%port%", textBox4.Text);
            text7 = text7.Replace("%ip%", text2 + textBox3.Text + text2);
            text7 = text7.Replace("%name%", text2 + textBox1.Text + text2);
            text7 = text7.Replace("%id%", num.ToString());
            text3 = RemoveWhitespace(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/Settings/Appearence.ini")) + "|" + headcolor + ";" + torsocolor + ";" + leftarmcolor + ";" + rightarmcolor + ";" + leftlegcolor + ";" + rightlegcolor;
            text7 = "charapp = [[" + text3 + "]]  \n" + text7;
            using (StreamWriter streamWriter6 = new StreamWriter(new SaveFileDialog
            {
                FileName = AppDomain.CurrentDomain.BaseDirectory + "Clients/2013/Player/content/join.txt"
            }.FileName))
            {
                streamWriter6.WriteLine(text7);
            }
            ExecuteCommand("start Clients/2013/Player/Roblox.exe -script " + text2 + "dofile('rbxasset://join.txt')" + text2);
        }
        else
        {
            text3 = text3.Replace("1111111", "");
            ExecuteCommand("start Clients/" + currentclient + "/Player/RobloxPlayerBeta.exe -a " + text2 + "http://localhost/login/negotiate.ashx" + text2 + " -j " + text2 + "http://localhost/game/placelauncher.ashx?&year=2018&placeid=1818&ip=" + textBox3.Text + "&port=" + textBox2.Text + "&id=" + num + "&app=" + text3 + "&user=" + textBox1.Text + "&membership=" + listBox7.SelectedItem + text2 + " -t " + text2 + "1" + text2);
        }
	}

	private void Form1_Shown(object sender, EventArgs e)
	{
        if (Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\WebServer") && File.Exists(AppDomain.CurrentDomain.BaseDirectory + "WebServer/Start.bat"))
        {
            Process.Start(new ProcessStartInfo(AppDomain.CurrentDomain.BaseDirectory + "WebServer/Start.bat")
            {
                UseShellExecute = true,
                WindowStyle = ProcessWindowStyle.Minimized
            });
            string text = RemoveWhitespace(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "Settings/username.txt"));
            string s = text.GetHashCode().ToString().Remove(0, 1);
            num = int.Parse(s);
            textBox1.Text = text;
            text = RemoveWhitespace(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "Settings/ip.txt"));
            textBox3.Text = text;
            text = RemoveWhitespace(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "Settings/clientport.txt"));
            textBox2.Text = text;
            text = RemoveWhitespace(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "Settings/HostPort.txt"));
            textBox4.Text = text;
            text = RemoveWhitespace(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "Settings/SelectedClient.txt"));
            listBox1.SetSelected(listBox1.FindString(text), value: true);
            text = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "Settings/BodyColors/HeadColor.txt");
            headcolor = text;
            text = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "Settings/BodyColors/TorsoColor.txt");
            torsocolor = text;
            text = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "Settings/BodyColors/LeftArmColor.txt");
            leftarmcolor = text;
            text = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "Settings/BodyColors/RightArmColor.txt");
            rightarmcolor = text;
            text = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "Settings/BodyColors/LeftLegColor.txt");
            leftlegcolor = text;
            text = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "Settings/BodyColors/RightLegColor.txt");
            rightlegcolor = text;
            text = RemoveWhitespace(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "Settings/BodyType.txt"));
            listBox2.SetSelected(listBox2.FindString(text), value: true);
            text = RemoveWhitespace(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "Settings/assetsaving/Enabled.txt"));
            listBox3.SetSelected(listBox3.FindString(text), value: true);
        }
    }

	private void button3_Click(object sender, EventArgs e)
	{
        playaudio();

        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.InitialDirectory = "c:\\";
        openFileDialog.Filter = "Roblox places (*.rbxl)|*.rbxl|Roblox XML places (*.rbxlx)|*.rbxlx";
        openFileDialog.FilterIndex = 0;
        openFileDialog.RestoreDirectory = true;

        if (openFileDialog.ShowDialog() != DialogResult.OK)
        {
            return;
        }

        string fileName = openFileDialog.FileName;

        string settingsDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Settings");
        if (!Directory.Exists(settingsDir)) Directory.CreateDirectory(settingsDir);

        string mapPathTxt = Path.Combine(settingsDir, "MapPath.txt");
        File.WriteAllText(mapPathTxt, fileName);

        if (File.Exists(fileName))
        {
            try
            {
                string mapsDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Maps");
                if (!Directory.Exists(mapsDirectory))
                {
                    Directory.CreateDirectory(mapsDirectory);
                }
                string mapName = Path.GetFileName(fileName);
                string mapsDestPath = Path.Combine(mapsDirectory, mapName);

                File.Copy(fileName, mapsDestPath, overwrite: true);

                if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\Maps"))
                {
                    Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\Maps");
                }
                listBox4.Items.Clear();
                string[] directories = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + "\\Maps");
                for (int i = 0; i < directories.Length; i++)
                {
                    listBox4.Items.Add(Path.GetFileName(directories[i]));
                }
                MessageBox.Show("Custom Map Added Successfully!", "LuckyBlox Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		using (StreamWriter streamWriter = new StreamWriter(new SaveFileDialog
		{
			FileName = AppDomain.CurrentDomain.BaseDirectory + "Settings/SelectedClient.txt"
		}.FileName))
		{
			streamWriter.Write(currentclient);
		}
		using (StreamWriter streamWriter2 = new StreamWriter(new SaveFileDialog
		{
			FileName = AppDomain.CurrentDomain.BaseDirectory + "Settings/BodyColors/HeadColor.txt"
		}.FileName))
		{
			streamWriter2.Write(headcolor);
		}
		using (StreamWriter streamWriter3 = new StreamWriter(new SaveFileDialog
		{
			FileName = AppDomain.CurrentDomain.BaseDirectory + "Settings/BodyColors/TorsoColor.txt"
		}.FileName))
		{
			streamWriter3.Write(torsocolor);
		}
		using (StreamWriter streamWriter4 = new StreamWriter(new SaveFileDialog
		{
			FileName = AppDomain.CurrentDomain.BaseDirectory + "Settings/BodyColors/LeftArmColor.txt"
		}.FileName))
		{
			streamWriter4.Write(leftarmcolor);
		}
		using (StreamWriter streamWriter5 = new StreamWriter(new SaveFileDialog
		{
			FileName = AppDomain.CurrentDomain.BaseDirectory + "Settings/BodyColors/RightArmColor.txt"
		}.FileName))
		{
			streamWriter5.Write(rightarmcolor);
		}
		using (StreamWriter streamWriter6 = new StreamWriter(new SaveFileDialog
		{
			FileName = AppDomain.CurrentDomain.BaseDirectory + "Settings/BodyColors/LeftLegColor.txt"
		}.FileName))
		{
			streamWriter6.Write(leftlegcolor);
		}
		using (StreamWriter streamWriter7 = new StreamWriter(new SaveFileDialog
		{
			FileName = AppDomain.CurrentDomain.BaseDirectory + "Settings/BodyColors/RightLegColor.txt"
		}.FileName))
		{
			streamWriter7.Write(rightlegcolor);
		}
		using (StreamWriter streamWriter8 = new StreamWriter(new SaveFileDialog
		{
			FileName = AppDomain.CurrentDomain.BaseDirectory + "Settings/BodyType.txt"
		}.FileName))
		{
			streamWriter8.Write(chartype);
		}
		using (StreamWriter streamWriter9 = new StreamWriter(new SaveFileDialog
		{
			FileName = AppDomain.CurrentDomain.BaseDirectory + "Settings/assetsaving/Enabled.txt"
		}.FileName))
		{
			streamWriter9.Write(assetsaving);
		}
		try
		{
			Process.Start(new ProcessStartInfo(AppDomain.CurrentDomain.BaseDirectory + "WebServer/kill.bat")
			{
				UseShellExecute = true,
				WindowStyle = ProcessWindowStyle.Minimized
			});
		}
		catch
		{
		}
	}

	private void textBox1_TextChanged(object sender, EventArgs e)
	{
		try
		{
			string s = textBox1.Text.GetHashCode().ToString().Remove(0, 1);
			num = int.Parse(s);
		}
		catch (Exception)
		{
		}
	}

	private void textBox4_TextChanged(object sender, EventArgs e)
	{
	}

	private void Form1_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		playaudio();
		string text = listBox1.SelectedItem.ToString();
		currentclient = text;
		if (listBox1.SelectedItem.ToString() == "2022M")
		{
			label18.Text = "Client Version: 0.547.0.5470549 (64bit)";
            label19.Text = "Client Description:\r\nNo RCC, No RobloxPlayer. Only RobloxStudio for\r\nplay and host. Runs only on 64 Bit Operating\r\nsystems.\r\n\r\nAre you got nostalgia from the old Roblox Studio\r\ninterface?\r\n";
        }
        else if (listBox1.SelectedItem.ToString() == "2021M")
        {
            label18.Text = "Client Version: 0.482.0.31052";
            label19.Text = "Client Description:\r\nLast version of Roblox that can join to RCC server\r\nthat hosted on v463 version.\r\nDO NOT USE FOR ONLINE! THIS CLIENT IS NOT\r\nPROTECTED!\r\nPatched by atpied";
        }
        else if (listBox1.SelectedItem.ToString() == "2021E")
        {
            label18.Text = "Client Version: 0.463.0.23788";
            label19.Text = "Client Description:\r\nLast version of Roblox that includes RCC for  \r\nwindows.\r\n\r\n\r\nThe first influx of the ODers!";
        }
        else if (listBox1.SelectedItem.ToString() == "2020L")
        {
            label18.Text = "Client Version: 0.457.0.414557";
            label19.Text = "Client Description:\r\nNo client, only RCC\r\nBut it is backward compatible with 2021E and 2021M\r\nDO NOT USE FOR ONLINE! THIS CLIENT IS NOT\r\nPROTECTED!\r\nPatched by atpied\r\n\r\n\r\n";
        }
        else if (listBox1.SelectedItem.ToString() == "2020M")
        {
            label18.Text = "Client Version: 0.447.1.411042";
            label19.Text = "Client Description:\r\nNew CoreGui and physics\r\n\r\n\r\n";
        }
        else if (listBox1.SelectedItem.ToString() == "2019M")
        {
            label18.Text = "Client Version: 0.392.0.316754";
            label19.Text = "Client Description:\r\nNow Roblox icon is a Gray, better camera (and more).\r\nGood times to.\r\n\r\n";
        }
        else if (listBox1.SelectedItem.ToString() == "2018L")
        {
            label18.Text = "Client Version: 0.360.0.521000";
            label19.Text = "Client Description:\r\nDon't have global updates,\r\nBut this client is most stabillity of all 2018 clients";
        }
        else if (listBox1.SelectedItem.ToString() == "2018M")
        {
            label18.Text = "Client Version: 0.348.0.224077";
            label19.Text = "Client Description:\r\nUpdated Developer Console and shiftlock switch\r\nbutton on pc now not showing in left down.";
        }
        else if (listBox1.SelectedItem.ToString() == "2018E")
        {
            label18.Text = "Client Version: 0.325.0.179359";
            label19.Text = "Client Description:\r\nUpdated font's (chat fonts too), and new error style\r\n(like a today in modern roblox).";
        }
        else if (listBox1.SelectedItem.ToString() == "2017M")
        {
            label18.Text = "Client Version: 0.300.0.7899";
            label19.Text = "Client Description:\r\nCyrillic alphabet is now supported in the chat and\r\nin another game elements (like a UI). New Roblox icon\r\nand a new place loading screen.\r\nAnd updated materials textures!";
        }
        else if (listBox1.SelectedItem.ToString() == "2016L")
        {
            label18.Text = "Client Version: 0.271.1.32426";
            label19.Text = "Client Description:\r\nMost stable than 2015L :)";
        }
        else if (listBox1.SelectedItem.ToString() == "2015L")
        {
            label18.Text = "Client Version: 0.206.X.XXXXX";
            label19.Text = "Client Description:\r\nNew loading screen, new roblox interface and more!";
        }
        else if (listBox1.SelectedItem.ToString() == "2014M")
        {
            label18.Text = "Client Version: 0.158.0.48436";
            label19.Text = "Client Description:\r\nDeveloper console added, and a new textures.";
        }
        else if (listBox1.SelectedItem.ToString() == "2013L")
        {
            label18.Text = "Client Version: 0.132.0.41338";
            label19.Text = "Client Description:\r\nNew interface and textures with graphics\r\nand more!..";
        }
        else if (listBox1.SelectedItem.ToString() == "2008M")
        {
            label18.Text = "Client Version: 0.3.783.0";
            label19.Text = "Client Description:\r\nGood times, no GUI, low client size and nostalgia.";
        }
        else if (listBox1.SelectedItem.ToString() == "2007E")
        {
            label18.Text = "Client Version: 0.3.368.0";
            label19.Text = "Client Description:\r\nEarliest client that founded by community.\r\nA Roblox 2007 March client (Modified)\r\n\r\nCredits to: MaximumADHD\r\n(GitHub:\r\ngithub.com/MaximumADHD/Roblox_0.3.368.0)\r\n\r\nIt is not recommended to use this client for\r\nMultiplayer game (very unsecure). If you decide\r\nto play online with friends, do not connect to\r\nunknown servers and play only on a private network.\r\n";
        }
        else
        {
            label18.Text = "Client Version: The selected client may be\r\ncustom or have been added by someone else";
            label19.Text = "";
        }

    }

    private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void button4_Click(object sender, EventArgs e)
	{
		playaudio();
		Process.Start(new ProcessStartInfo(AppDomain.CurrentDomain.BaseDirectory + "WebServer/Start.bat")
		{
			UseShellExecute = true,
			WindowStyle = ProcessWindowStyle.Minimized
		});
	}

	private void button5_Click(object sender, EventArgs e)
	{
		playaudio();
		Process.Start(new ProcessStartInfo(AppDomain.CurrentDomain.BaseDirectory + "WebServer/kill.bat")
		{
			UseShellExecute = true,
			WindowStyle = ProcessWindowStyle.Minimized
		});
	}

	public static string ReplaceWhitespace(string input, string replacement)
	{
		return sWhitespace.Replace(input, replacement);
	}

	private void pictureBox11_Click(object sender, EventArgs e)
	{
		string value = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/Settings/Appearence.ini") + ";http://localhost/asset/?id=607785314";
		label5.Text = "Equipped!";
		using StreamWriter streamWriter = new StreamWriter(new SaveFileDialog
		{
			FileName = AppDomain.CurrentDomain.BaseDirectory + "Settings/Appearence.ini"
		}.FileName);
		streamWriter.WriteLine(value);
	}

	private void button6_Click(object sender, EventArgs e)
	{
		playaudio1();
		label5.Text = "Cleared!";
		using StreamWriter streamWriter = new StreamWriter(new SaveFileDialog
		{
			FileName = AppDomain.CurrentDomain.BaseDirectory + "Settings/Appearence.ini"
		}.FileName);
		streamWriter.WriteLine("http://localhost/charscript/Custom.php?hat=0");
	}

	private void pictureBox12_Click(object sender, EventArgs e)
	{
		string value = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/Settings/Appearence.ini") + ";http://localhost/asset/?id=398633584";
		label5.Text = "Equipped!";
		using StreamWriter streamWriter = new StreamWriter(new SaveFileDialog
		{
			FileName = AppDomain.CurrentDomain.BaseDirectory + "Settings/Appearence.ini"
		}.FileName);
		streamWriter.WriteLine(value);
	}

	private void pictureBox13_Click(object sender, EventArgs e)
	{
		string value = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/Settings/Appearence.ini") + ";http://localhost/asset/?id=398634487";
		label5.Text = "Equipped!";
		using StreamWriter streamWriter = new StreamWriter(new SaveFileDialog
		{
			FileName = AppDomain.CurrentDomain.BaseDirectory + "Settings/Appearence.ini"
		}.FileName);
		streamWriter.WriteLine(value);
	}

	private void pictureBox14_Click(object sender, EventArgs e)
	{
		string value = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/Settings/Appearence.ini") + ";http://localhost/asset/?id=398635338";
		label5.Text = "Equipped!";
		using StreamWriter streamWriter = new StreamWriter(new SaveFileDialog
		{
			FileName = AppDomain.CurrentDomain.BaseDirectory + "Settings/Appearence.ini"
		}.FileName);
		streamWriter.WriteLine(value);
	}

	private void pictureBox15_Click(object sender, EventArgs e)
	{
		string value = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/Settings/Appearence.ini") + ";http://localhost/asset/?id=3670737444";
		label5.Text = "Equipped!";
		using StreamWriter streamWriter = new StreamWriter(new SaveFileDialog
		{
			FileName = AppDomain.CurrentDomain.BaseDirectory + "Settings/Appearence.ini"
		}.FileName);
		streamWriter.WriteLine(value);
	}

	private void pictureBox17_Click(object sender, EventArgs e)
	{
		string value = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/Settings/Appearence.ini") + ";http://localhost/asset/?id=6111376717";
		label5.Text = "Equipped!";
		using StreamWriter streamWriter = new StreamWriter(new SaveFileDialog
		{
			FileName = AppDomain.CurrentDomain.BaseDirectory + "Settings/Appearence.ini"
		}.FileName);
		streamWriter.WriteLine(value);
	}

	private void pictureBox18_Click(object sender, EventArgs e)
	{
		string value = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/Settings/Appearence.ini") + ";http://localhost/asset/?id=6087965870";
		label5.Text = "Equipped!";
		using StreamWriter streamWriter = new StreamWriter(new SaveFileDialog
		{
			FileName = AppDomain.CurrentDomain.BaseDirectory + "Settings/Appearence.ini"
		}.FileName);
		streamWriter.WriteLine(value);
	}

	private void pictureBox19_Click(object sender, EventArgs e)
	{
		string value = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/Settings/Appearence.ini") + ";http://localhost/asset/?id=451221329";
		label5.Text = "Equipped!";
		using StreamWriter streamWriter = new StreamWriter(new SaveFileDialog
		{
			FileName = AppDomain.CurrentDomain.BaseDirectory + "Settings/Appearence.ini"
		}.FileName);
		streamWriter.WriteLine(value);
	}

	private void pictureBox20_Click(object sender, EventArgs e)
	{
		string value = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/Settings/Appearence.ini") + ";http://localhost/asset/?id=2956239660";
		label5.Text = "Equipped!";
		using StreamWriter streamWriter = new StreamWriter(new SaveFileDialog
		{
			FileName = AppDomain.CurrentDomain.BaseDirectory + "Settings/Appearence.ini"
		}.FileName);
		streamWriter.WriteLine(value);
	}

	private void pictureBox21_Click(object sender, EventArgs e)
	{
		string value = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/Settings/Appearence.ini") + ";http://localhost/asset/?id=212967757";
		label5.Text = "Equipped!";
		using StreamWriter streamWriter = new StreamWriter(new SaveFileDialog
		{
			FileName = AppDomain.CurrentDomain.BaseDirectory + "Settings/Appearence.ini"
		}.FileName);
		streamWriter.WriteLine(value);
	}

	private void pictureBox22_Click(object sender, EventArgs e)
	{
		string value = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/Settings/Appearence.ini") + ";http://localhost/asset/?id=63690008";
		label5.Text = "Equipped!";
		using StreamWriter streamWriter = new StreamWriter(new SaveFileDialog
		{
			FileName = AppDomain.CurrentDomain.BaseDirectory + "Settings/Appearence.ini"
		}.FileName);
		streamWriter.WriteLine(value);
	}

	private void pictureBox23_Click(object sender, EventArgs e)
	{
		string value = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/Settings/Appearence.ini") + ";http://localhost/asset/?id=1103003368";
		label5.Text = "Equipped!";
		using StreamWriter streamWriter = new StreamWriter(new SaveFileDialog
		{
			FileName = AppDomain.CurrentDomain.BaseDirectory + "Settings/Appearence.ini"
		}.FileName);
		streamWriter.WriteLine(value);
	}

	private void button7_Click(object sender, EventArgs e)
	{
        playaudio();
        string value = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/Settings/Appearence.ini") + ";http://localhost/asset/?id=1111111" + textBox5.Text;
		label5.Text = "Equipped!";
		using StreamWriter streamWriter = new StreamWriter(new SaveFileDialog
		{
			FileName = AppDomain.CurrentDomain.BaseDirectory + "Settings/Appearence.ini"
		}.FileName);
		streamWriter.WriteLine(value);
	}

	private void pictureBox16_Click(object sender, EventArgs e)
	{
		try
		{
			if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "/Settings/Appearence.ini"))
			{
				File.Create(AppDomain.CurrentDomain.BaseDirectory + "/Settings/Appearence.ini");
			}
		}
		catch
		{
		}
		string value = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/Settings/Appearence.ini") + ";http://localhost/asset/?id=398635081";
		label5.Text = "Equipped!";
		using StreamWriter streamWriter = new StreamWriter(new SaveFileDialog
		{
			FileName = AppDomain.CurrentDomain.BaseDirectory + "Settings/Appearence.ini"
		}.FileName);
		streamWriter.WriteLine(value);
	}

	private void button8_Click(object sender, EventArgs e)
	{
        playaudio();
        try
		{
			string text = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/Settings/MapPath.txt");
			if (File.Exists(text))
			{
				string path = AppDomain.CurrentDomain.BaseDirectory + "/Webserver/www/.127.0.0.1/asset/1818";
				if (File.Exists(path))
				{
					File.Delete(path);
				}
				string destFileName = AppDomain.CurrentDomain.BaseDirectory + "/Webserver/www/.127.0.0.1/asset/1818";
				try
				{
					File.Copy(text, destFileName, overwrite: true);
				}
				catch (IOException ex)
				{
					Console.WriteLine(ex.Message);
				}
				string path2 = AppDomain.CurrentDomain.BaseDirectory + "/Webserver/www/.localhost/asset/1818";
				if (File.Exists(path2))
				{
					File.Delete(path2);
				}
				string destFileName2 = AppDomain.CurrentDomain.BaseDirectory + "/Webserver/www/.localhost/asset/1818";
				try
				{
					File.Copy(text, destFileName2, overwrite: true);
				}
				catch (IOException ex2)
				{
					Console.WriteLine(ex2.Message);
				}
				string path3 = AppDomain.CurrentDomain.BaseDirectory + "/shared/content/place.rbxl";
				if (File.Exists(path3))
				{
					File.Delete(path3);
				}
				string destFileName3 = AppDomain.CurrentDomain.BaseDirectory + "/shared/content/place.rbxl";
				try
				{
					File.Copy(text, destFileName3, overwrite: true);
				}
				catch (IOException ex3)
				{
					Console.WriteLine(ex3.Message);
				}
				string path4 = AppDomain.CurrentDomain.BaseDirectory + "/shared/content/1818";
				if (File.Exists(path4))
				{
					File.Delete(path4);
				}
				string destFileName4 = AppDomain.CurrentDomain.BaseDirectory + "/shared/content/1818";
				try
				{
					File.Copy(text, destFileName4, overwrite: true);
				}
				catch (IOException ex4)
				{
					Console.WriteLine(ex4.Message);
				}
				string path5 = AppDomain.CurrentDomain.BaseDirectory + "\\Clients\\2014M\\content\\temp.rbxl";
				if (File.Exists(path5))
				{
					File.Delete(path5);
				}
				string destFileName5 = AppDomain.CurrentDomain.BaseDirectory + "\\Clients\\2014M\\content\\temp.rbxl";
				try
				{
					File.Copy(text, destFileName5, overwrite: true);
				}
				catch (IOException ex5)
				{
					Console.WriteLine(ex5.Message);
				}
				string text2 = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/Settings/Fix.ini");
				string text3 = "";
				string text4 = "";
				text4 = "_G.FilteringEnabled=true";
				string value = "<roblox xmlns:xmime=" + text2 + "http://www.w3.org/2005/05/xmlmime" + text2 + " xmlns:xsi=" + text2 + "http://www.w3.org/2001/XMLSchema-instance" + text2 + " xsi:noNamespaceSchemaLocation=" + text2 + "http://www.localhost//roblox.xsd" + text2 + " version=" + text2 + "4" + text2 + ">\r\n    <External>null</External>\r\n    <External>nil</External>\r\n    <Item class=" + text2 + "Script" + text2 + " referent=" + text2 + "RBXA9BF459DE88842189FF810D1F9615061" + text2 + ">\r\n\t\t<Properties>\r\n\t\t\t<bool name =" + text2 + "Disabled" + text2 + ">false</bool>\r\n            <Content name=" + text2 + "LinkedSource" + text2 + "><null></null></Content>\r\n\t\t\t<string name =" + text2 + "Name" + text2 + ">Script</string>\r\n            <string name=" + text2 + "ScriptGuid" + text2 + ">{1166F3A8-F70B-4DAF-B7C6-3C89D8BBC049}</string>\r\n\t\t\t<ProtectedString name=" + text2 + "Source" + text2 + "><![CDATA[" + text4 + "]]></ProtectedString>\r\n            <BinaryString name=" + text2 + "Tags" + text2 + "></BinaryString>\r\n\t\t</Properties>\r\n\t</Item>\r\n</roblox>";
				using (StreamWriter streamWriter = new StreamWriter(new SaveFileDialog
				{
					FileName = AppDomain.CurrentDomain.BaseDirectory + "//shared/content/server.rbxmx"
				}.FileName))
				{
					streamWriter.WriteLine(value);
				}
				string text5 = "\"";
				string text6 = AppDomain.CurrentDomain.BaseDirectory + "\\Clients\\2022M\\RobloxStudioBeta.exe";
				_ = AppDomain.CurrentDomain.BaseDirectory + "\\shared\\content\\place.rbxl";
				string text7 = " -localPlaceFile " + text5 + text + text5;
				text3 = text5 + text6 + text5 + text7;
				using (StreamWriter streamWriter2 = new StreamWriter(new SaveFileDialog
				{
					FileName = AppDomain.CurrentDomain.BaseDirectory + "Settings/EditMap.bat"
				}.FileName))
				{
					streamWriter2.WriteLine(text3 + "\n exit");
				}
				ExecuteCommand("start Settings\\EditMap.bat");
			}
		}
		catch
		{
		}
	}

	private void tabPage2_Click(object sender, EventArgs e)
	{
	}

	private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Settings/BodyType.txt"))
		{
			File.Create(AppDomain.CurrentDomain.BaseDirectory + "Settings/BodyType.txt");
		}
		chartype = listBox2.SelectedItem.ToString();
	}

	private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
	{
        playaudio();
        string text = listBox1.SelectedItem.ToString();
        assetsaving = text;
		if (assetsaving == "true")
		{
			string fullPath = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + "\\Webserver\\www");
			DirectoryInfo target = new DirectoryInfo(Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + "\\Webserver\\www"));
			DirectoryInfo source = new DirectoryInfo(Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + "\\Settings\\assetsaving\\SaveAssets"));
			if (Directory.Exists(fullPath))
			{
				CopyFilesRecursively(source, target);
			}
		}
		if (assetsaving == "false")
		{
			string fullPath2 = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + "\\Webserver\\www");
			DirectoryInfo target2 = new DirectoryInfo(Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + "\\Webserver\\www"));
			DirectoryInfo source2 = new DirectoryInfo(Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + "\\Settings\\assetsaving\\DontSave"));
			if (Directory.Exists(fullPath2))
			{
				CopyFilesRecursively(source2, target2);
			}
		}
	}

	private void tabPage1_Click(object sender, EventArgs e)
	{
	}

	private void textBox3_TextChanged(object sender, EventArgs e)
	{
	}

	private void label1_Click(object sender, EventArgs e)
	{
	}

	private void label2_Click(object sender, EventArgs e)
	{
	}

	private void label3_Click(object sender, EventArgs e)
	{
	}

	private void ExploitName_Click(object sender, EventArgs e)
	{
	}

	private void ExitButton_Click(object sender, EventArgs e)
	{
	}

	private void button10_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void button11_Click(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void panel1_MouseDown(object sender, MouseEventArgs e)
	{
		_dragging = true;
		_start_point = new Point(e.X, e.Y);
	}

	private void panel1_MouseUp(object sender, MouseEventArgs e)
	{
		_dragging = false;
	}

	private void panel1_MouseMove(object sender, MouseEventArgs e)
	{
		if (_dragging)
		{
			Point point = PointToScreen(e.Location);
			base.Location = new Point(point.X - _start_point.X, point.Y - _start_point.Y);
		}
	}

	private void button14_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void button13_Click(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
	{
		Rectangle clientRectangle = tabControl1.ClientRectangle;
		StringFormat stringFormat = new StringFormat();
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Alignment = StringAlignment.Center;
		SolidBrush brush = new SolidBrush(Color.FromArgb(40, 40, 40));
		SolidBrush brush2 = new SolidBrush(Color.White);
		e.Graphics.FillRectangle(brush, clientRectangle);
		Font font = new Font(new FontFamily("Segoe UI"), 12f, FontStyle.Regular, GraphicsUnit.Point);
		Brush brush3 = new SolidBrush(Color.FromArgb(30, 30, 30));
		for (int i = 0; i < tabControl1.TabPages.Count; i++)
		{
			bool num = tabControl1.SelectedIndex == i;
			Rectangle tabRect = tabControl1.GetTabRect(i);
			RectangleF layoutRectangle = tabControl1.GetTabRect(i);
			if (num)
			{
				tabRect.Inflate(2, 5);
				e.Graphics.FillRectangle(brush3, tabRect);
				e.Graphics.DrawString(tabControl1.TabPages[i].Text, font, brush2, layoutRectangle, stringFormat);
			}
			else
			{
				e.Graphics.DrawString(tabControl1.TabPages[i].Text, font, brush2, layoutRectangle, stringFormat);
			}
		}
	}

	private void button10_Click_1(object sender, EventArgs e)
	{
        playaudio();
        if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\Clients"))
		{
			Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\Clients");
		}
		listBox1.Items.Clear();
		string[] directories = Directory.GetDirectories(AppDomain.CurrentDomain.BaseDirectory + "\\Clients");
		for (int i = 0; i < directories.Length; i++)
		{
			listBox1.Items.Add(Path.GetFileName(directories[i]));
		}
	}

	private void label6_Click(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.listBox7 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label25 = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.label17 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button8 = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button12 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.button21 = new System.Windows.Forms.Button();
            this.label31 = new System.Windows.Forms.Label();
            this.button20 = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.button18 = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.button14 = new System.Windows.Forms.Button();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.label24 = new System.Windows.Forms.Label();
            this.button17 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.scriptArgumentPanel = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.saveArgsToFileBtn = new System.Windows.Forms.Button();
            this.openArgsFromFileBtn = new System.Windows.Forms.Button();
            this.addArgumentButton = new System.Windows.Forms.Button();
            this.argumentTemplate = new System.Windows.Forms.Panel();
            this.removeArgument = new System.Windows.Forms.Button();
            this.argumentValue = new System.Windows.Forms.TextBox();
            this.argumentType = new System.Windows.Forms.ComboBox();
            this.button11 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.button15 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.scriptArgumentPanel.SuspendLayout();
            this.argumentTemplate.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(763, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Host";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(245, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(352, 161);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(142, 29);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(245, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "IP:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox3.Location = new System.Drawing.Point(352, 126);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(142, 29);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(245, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(352, 196);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 29);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(341, 302);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 31);
            this.button3.TabIndex = 10;
            this.button3.Text = "Add Custom Map";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Items.AddRange(new object[] {
            "Empty"});
            this.listBox1.Location = new System.Drawing.Point(0, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(643, 400);
            this.listBox1.TabIndex = 24;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(612, 287);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(145, 29);
            this.textBox4.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(539, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 21);
            this.label4.TabIndex = 26;
            this.label4.Text = "Port:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.Location = new System.Drawing.Point(324, 144);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(992, 446);
            this.tabControl1.TabIndex = 30;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabPage1.Controls.Add(this.label35);
            this.tabPage1.Controls.Add(this.label34);
            this.tabPage1.Controls.Add(this.label33);
            this.tabPage1.Controls.Add(this.label32);
            this.tabPage1.Controls.Add(this.listBox7);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(984, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Connect";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label35.ForeColor = System.Drawing.Color.White;
            this.label35.Location = new System.Drawing.Point(581, 219);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(340, 15);
            this.label35.TabIndex = 48;
            this.label35.Text = "*This is an experimental feature. It only works on 2020M-2021M";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label34.ForeColor = System.Drawing.Color.White;
            this.label34.Location = new System.Drawing.Point(579, 63);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(234, 28);
            this.label34.TabIndex = 36;
            this.label34.Text = "Advanched User Settings:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label33.ForeColor = System.Drawing.Color.White;
            this.label33.Location = new System.Drawing.Point(240, 63);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(164, 28);
            this.label33.TabIndex = 35;
            this.label33.Text = "Connect Settings:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label32.ForeColor = System.Drawing.Color.White;
            this.label32.Location = new System.Drawing.Point(580, 134);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(103, 21);
            this.label32.TabIndex = 34;
            this.label32.Text = "MemberShip:";
            // 
            // listBox7
            // 
            this.listBox7.BackColor = System.Drawing.Color.DimGray;
            this.listBox7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox7.ForeColor = System.Drawing.SystemColors.Info;
            this.listBox7.FormattingEnabled = true;
            this.listBox7.ItemHeight = 21;
            this.listBox7.Items.AddRange(new object[] {
            "None",
            "BuildersClub",
            "TurboBuildersClub",
            "OutrageousBuildersClub",
            "Premium"});
            this.listBox7.Location = new System.Drawing.Point(703, 106);
            this.listBox7.Name = "listBox7";
            this.listBox7.Size = new System.Drawing.Size(207, 109);
            this.listBox7.TabIndex = 33;
            this.listBox7.SelectedIndexChanged += new System.EventHandler(this.listBox7_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(417, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(245, 64);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabPage2.Controls.Add(this.label25);
            this.tabPage2.Controls.Add(this.button16);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.listBox5);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.button13);
            this.tabPage2.Controls.Add(this.listBox4);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.listBox2);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(984, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Host";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(512, 343);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(58, 15);
            this.label25.TabIndex = 47;
            this.label25.Text = "(2017M+)";
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button16.ForeColor = System.Drawing.Color.White;
            this.button16.Location = new System.Drawing.Point(763, 334);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(208, 34);
            this.button16.TabIndex = 46;
            this.button16.Text = "Launch 2022M Studio without map";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(17, 334);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(181, 30);
            this.label23.TabIndex = 45;
            this.label23.Text = "A Basic Admin Panel\r\n(Working only on 2017M-2019M)";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(17, 313);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(159, 21);
            this.label22.TabIndex = 44;
            this.label22.Text = "Enable Adonis admin:";
            // 
            // listBox5
            // 
            this.listBox5.BackColor = System.Drawing.Color.DimGray;
            this.listBox5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox5.ForeColor = System.Drawing.SystemColors.Info;
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 21;
            this.listBox5.Items.AddRange(new object[] {
            "true",
            "false"});
            this.listBox5.Location = new System.Drawing.Point(199, 315);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(125, 46);
            this.listBox5.TabIndex = 43;
            this.listBox5.SelectedIndexChanged += new System.EventHandler(this.listBox5_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(6, 371);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(128, 38);
            this.label17.TabIndex = 42;
            this.label17.Text = "Current map patch:\r\nC:\\";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Location = new System.Drawing.Point(771, 238);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(160, 37);
            this.button13.TabIndex = 39;
            this.button13.Text = "Refresh";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click_1);
            // 
            // listBox4
            // 
            this.listBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.listBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listBox4.ForeColor = System.Drawing.SystemColors.Info;
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 21;
            this.listBox4.Items.AddRange(new object[] {
            "Empty"});
            this.listBox4.Location = new System.Drawing.Point(10, 8);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(958, 273);
            this.listBox4.TabIndex = 38;
            this.listBox4.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(512, 322);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 21);
            this.label13.TabIndex = 29;
            this.label13.Text = "Avatar Type:";
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.DimGray;
            this.listBox2.ForeColor = System.Drawing.SystemColors.Info;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 21;
            this.listBox2.Items.AddRange(new object[] {
            "R6",
            "R15",
            "Custom"});
            this.listBox2.Location = new System.Drawing.Point(612, 322);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(145, 46);
            this.listBox2.TabIndex = 28;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(341, 339);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(165, 31);
            this.button8.TabIndex = 27;
            this.button8.Text = "Edit Map with 2022M Studio";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabPage5.Controls.Add(this.label19);
            this.tabPage5.Controls.Add(this.label18);
            this.tabPage5.Controls.Add(this.button10);
            this.tabPage5.Controls.Add(this.listBox1);
            this.tabPage5.Location = new System.Drawing.Point(4, 30);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(984, 412);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Clients";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(649, 33);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(130, 19);
            this.label19.TabIndex = 39;
            this.label19.Text = "Client Description: -";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(649, 3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(106, 19);
            this.label18.TabIndex = 38;
            this.label18.Text = "Client Version: -";
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(717, 337);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(144, 28);
            this.button10.TabIndex = 37;
            this.button10.Text = "Refresh";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click_1);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabPage4.Controls.Add(this.label21);
            this.tabPage4.Controls.Add(this.label20);
            this.tabPage4.Controls.Add(this.pictureBox8);
            this.tabPage4.Controls.Add(this.pictureBox5);
            this.tabPage4.Controls.Add(this.pictureBox4);
            this.tabPage4.Controls.Add(this.pictureBox3);
            this.tabPage4.Controls.Add(this.pictureBox2);
            this.tabPage4.Controls.Add(this.pictureBox1);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.textBox11);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.textBox10);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.textBox9);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.textBox8);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.textBox7);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.textBox6);
            this.tabPage4.Controls.Add(this.button12);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Location = new System.Drawing.Point(4, 30);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(984, 412);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Body Colors";
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(57, 331);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(509, 63);
            this.label21.TabIndex = 58;
            this.label21.Text = "Do not write (for example) \"Bright Blue\". Write only \"Bright blue\"\r\n(or else if y" +
    "ou using another BrickColor), otherwise your skin will\r\nbe completely gray witho" +
    "ut an asset ID";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(376, 295);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(554, 21);
            this.label20.TabIndex = 57;
            this.label20.Text = "If in-game applied colors not work, try close and launch launcher again";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.BackgroundImage")));
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox8.Location = new System.Drawing.Point(320, 278);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(29, 29);
            this.pictureBox8.TabIndex = 56;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Location = new System.Drawing.Point(320, 247);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(29, 29);
            this.pictureBox5.TabIndex = 55;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(320, 216);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(29, 29);
            this.pictureBox4.TabIndex = 54;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(320, 184);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 29);
            this.pictureBox3.TabIndex = 53;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(320, 152);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 29);
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(320, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 29);
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(38, 281);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 21);
            this.label15.TabIndex = 50;
            this.label15.Text = "Left Leg Color:";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(169, 278);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(145, 29);
            this.textBox11.TabIndex = 49;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(38, 250);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 21);
            this.label14.TabIndex = 48;
            this.label14.Text = "Right Leg Color:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(169, 247);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(145, 29);
            this.textBox10.TabIndex = 47;
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(38, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 21);
            this.label9.TabIndex = 46;
            this.label9.Text = "Left Arm Color:";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(169, 216);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(145, 29);
            this.textBox9.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(38, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 21);
            this.label8.TabIndex = 44;
            this.label8.Text = "Right Arm Color:";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(169, 184);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(145, 29);
            this.textBox8.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(72, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 21);
            this.label7.TabIndex = 42;
            this.label7.Text = "Torso Color:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(169, 152);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(145, 29);
            this.textBox7.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(72, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 21);
            this.label6.TabIndex = 40;
            this.label6.Text = "Head Color:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(169, 120);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(145, 29);
            this.textBox6.TabIndex = 39;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(811, 364);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(144, 28);
            this.button12.TabIndex = 38;
            this.button12.Text = "Save and Apply";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(861, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 21);
            this.label10.TabIndex = 32;
            this.label10.Text = "Body Colors";
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabPage6.Controls.Add(this.button21);
            this.tabPage6.Controls.Add(this.label31);
            this.tabPage6.Controls.Add(this.button20);
            this.tabPage6.Controls.Add(this.label30);
            this.tabPage6.Controls.Add(this.label29);
            this.tabPage6.Controls.Add(this.button18);
            this.tabPage6.Controls.Add(this.label26);
            this.tabPage6.Controls.Add(this.label5);
            this.tabPage6.Controls.Add(this.textBox5);
            this.tabPage6.Controls.Add(this.button7);
            this.tabPage6.Controls.Add(this.label11);
            this.tabPage6.Controls.Add(this.button6);
            this.tabPage6.Location = new System.Drawing.Point(4, 30);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(984, 412);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Clothing & Assets";
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button21.FlatAppearance.BorderSize = 0;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.ForeColor = System.Drawing.Color.White;
            this.button21.Location = new System.Drawing.Point(246, 312);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(202, 52);
            this.button21.TabIndex = 65;
            this.button21.Text = "Export .LAP Asset Pack";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label31.ForeColor = System.Drawing.Color.White;
            this.label31.Location = new System.Drawing.Point(19, 376);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(469, 15);
            this.label31.TabIndex = 64;
            this.label31.Text = ".LAP - LuckyBlox Asset Pack Format Can be inserted multiple assets (.rbxm, .rbxmx" +
    " only)";
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button20.FlatAppearance.BorderSize = 0;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.ForeColor = System.Drawing.Color.White;
            this.button20.Location = new System.Drawing.Point(22, 312);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(202, 52);
            this.button20.TabIndex = 63;
            this.button20.Text = "Import .LAP Asset Pack";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.ForeColor = System.Drawing.Color.White;
            this.label30.Location = new System.Drawing.Point(394, 59);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(54, 21);
            this.label30.TabIndex = 62;
            this.label30.Text = "Assets";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.ForeColor = System.Drawing.Color.White;
            this.label29.Location = new System.Drawing.Point(18, 288);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(89, 21);
            this.label29.TabIndex = 61;
            this.label29.Text = "Asset Packs";
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.ForeColor = System.Drawing.Color.White;
            this.button18.Location = new System.Drawing.Point(420, 94);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(202, 52);
            this.button18.TabIndex = 60;
            this.button18.Text = "Import Custom Asset";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(29, 195);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(844, 60);
            this.label26.TabIndex = 59;
            this.label26.Text = resources.GetString("label26.Text");
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 21);
            this.label5.TabIndex = 31;
            this.label5.Text = "Clothing";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(22, 107);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(149, 29);
            this.textBox5.TabIndex = 30;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(22, 142);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(149, 29);
            this.button7.TabIndex = 29;
            this.button7.Text = "Insert";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(18, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 21);
            this.label11.TabIndex = 28;
            this.label11.Text = "ID:";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(22, 51);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(149, 29);
            this.button6.TabIndex = 15;
            this.button6.Text = "Clear Appearance";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabPage3.Controls.Add(this.tabControl2);
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(984, 412);
            this.tabPage3.TabIndex = 6;
            this.tabPage3.Text = "Settings";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.Location = new System.Drawing.Point(6, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(972, 400);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabPage7.Controls.Add(this.label28);
            this.tabPage7.Controls.Add(this.label27);
            this.tabPage7.Controls.Add(this.listBox6);
            this.tabPage7.Controls.Add(this.button14);
            this.tabPage7.Location = new System.Drawing.Point(4, 30);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(964, 366);
            this.tabPage7.TabIndex = 0;
            this.tabPage7.Text = "Launcher";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(345, 101);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(435, 45);
            this.label28.TabIndex = 46;
            this.label28.Text = resources.GetString("label28.Text");
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(344, 57);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(99, 21);
            this.label27.TabIndex = 32;
            this.label27.Text = "Discord RPC:";
            // 
            // listBox6
            // 
            this.listBox6.BackColor = System.Drawing.Color.DimGray;
            this.listBox6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox6.ForeColor = System.Drawing.SystemColors.Info;
            this.listBox6.FormattingEnabled = true;
            this.listBox6.ItemHeight = 21;
            this.listBox6.Items.AddRange(new object[] {
            "Fully Enabled",
            "Show in-launcher only",
            "Disabled"});
            this.listBox6.Location = new System.Drawing.Point(491, 29);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(169, 67);
            this.listBox6.TabIndex = 31;
            this.listBox6.SelectedIndexChanged += new System.EventHandler(this.listBox6_SelectedIndexChanged);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button14.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.ForeColor = System.Drawing.Color.IndianRed;
            this.button14.Location = new System.Drawing.Point(447, 308);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(165, 31);
            this.button14.TabIndex = 1;
            this.button14.Text = "Uninstall Launcher";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click_1);
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabPage8.Controls.Add(this.label24);
            this.tabPage8.Controls.Add(this.button17);
            this.tabPage8.Controls.Add(this.label12);
            this.tabPage8.Controls.Add(this.listBox3);
            this.tabPage8.Location = new System.Drawing.Point(4, 30);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(964, 366);
            this.tabPage8.TabIndex = 1;
            this.tabPage8.Text = "Game";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(386, 207);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(281, 15);
            this.label24.TabIndex = 46;
            this.label24.Text = "Backup your DataStore server that hosted on this PC";
            this.label24.Click += new System.EventHandler(this.label24_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button17.ForeColor = System.Drawing.Color.White;
            this.button17.Location = new System.Drawing.Point(406, 162);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(245, 42);
            this.button17.TabIndex = 33;
            this.button17.Text = "Open DataStore Webserver folder";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(402, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 21);
            this.label12.TabIndex = 30;
            this.label12.Text = "Asset Saving:";
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.Color.DimGray;
            this.listBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox3.ForeColor = System.Drawing.SystemColors.Info;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 21;
            this.listBox3.Items.AddRange(new object[] {
            "true",
            "false"});
            this.listBox3.Location = new System.Drawing.Point(509, 74);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(142, 46);
            this.listBox3.TabIndex = 29;
            // 
            // tabPage9
            // 
            this.tabPage9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabPage9.Controls.Add(this.richTextBox1);
            this.tabPage9.Location = new System.Drawing.Point(4, 30);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(984, 412);
            this.tabPage9.TabIndex = 7;
            this.tabPage9.Text = "Changelog";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(6, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(972, 403);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(898, 622);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 50);
            this.button4.TabIndex = 31;
            this.button4.Text = "Start PHP Server";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(738, 622);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(143, 50);
            this.button5.TabIndex = 32;
            this.button5.Text = "Kill PHP Server";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // scriptArgumentPanel
            // 
            this.scriptArgumentPanel.AutoScroll = true;
            this.scriptArgumentPanel.BackColor = System.Drawing.Color.Transparent;
            this.scriptArgumentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scriptArgumentPanel.Controls.Add(this.button9);
            this.scriptArgumentPanel.Controls.Add(this.ExitButton);
            this.scriptArgumentPanel.Controls.Add(this.saveArgsToFileBtn);
            this.scriptArgumentPanel.Controls.Add(this.openArgsFromFileBtn);
            this.scriptArgumentPanel.Controls.Add(this.addArgumentButton);
            this.scriptArgumentPanel.Controls.Add(this.argumentTemplate);
            this.scriptArgumentPanel.Location = new System.Drawing.Point(1091, 254);
            this.scriptArgumentPanel.Name = "scriptArgumentPanel";
            this.scriptArgumentPanel.Size = new System.Drawing.Size(0, 0);
            this.scriptArgumentPanel.TabIndex = 33;
            this.scriptArgumentPanel.Visible = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(-37, -182);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(194, 204);
            this.button9.TabIndex = 5;
            this.button9.Text = "_";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(-3, -185);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(194, 204);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            // 
            // saveArgsToFileBtn
            // 
            this.saveArgsToFileBtn.Location = new System.Drawing.Point(449, 53);
            this.saveArgsToFileBtn.Name = "saveArgsToFileBtn";
            this.saveArgsToFileBtn.Size = new System.Drawing.Size(18, 21);
            this.saveArgsToFileBtn.TabIndex = 3;
            this.saveArgsToFileBtn.Text = "S";
            this.saveArgsToFileBtn.UseVisualStyleBackColor = true;
            // 
            // openArgsFromFileBtn
            // 
            this.openArgsFromFileBtn.Location = new System.Drawing.Point(449, 30);
            this.openArgsFromFileBtn.Name = "openArgsFromFileBtn";
            this.openArgsFromFileBtn.Size = new System.Drawing.Size(18, 21);
            this.openArgsFromFileBtn.TabIndex = 2;
            this.openArgsFromFileBtn.Text = "F";
            this.openArgsFromFileBtn.UseVisualStyleBackColor = true;
            // 
            // addArgumentButton
            // 
            this.addArgumentButton.Location = new System.Drawing.Point(449, 7);
            this.addArgumentButton.Name = "addArgumentButton";
            this.addArgumentButton.Size = new System.Drawing.Size(18, 21);
            this.addArgumentButton.TabIndex = 1;
            this.addArgumentButton.Text = "+";
            this.addArgumentButton.UseVisualStyleBackColor = true;
            // 
            // argumentTemplate
            // 
            this.argumentTemplate.Controls.Add(this.removeArgument);
            this.argumentTemplate.Controls.Add(this.argumentValue);
            this.argumentTemplate.Controls.Add(this.argumentType);
            this.argumentTemplate.Location = new System.Drawing.Point(4, 4);
            this.argumentTemplate.Name = "argumentTemplate";
            this.argumentTemplate.Size = new System.Drawing.Size(444, 29);
            this.argumentTemplate.TabIndex = 0;
            this.argumentTemplate.Visible = false;
            // 
            // removeArgument
            // 
            this.removeArgument.Location = new System.Drawing.Point(365, 3);
            this.removeArgument.Name = "removeArgument";
            this.removeArgument.Size = new System.Drawing.Size(74, 20);
            this.removeArgument.TabIndex = 2;
            this.removeArgument.Text = "Remove";
            this.removeArgument.UseVisualStyleBackColor = true;
            // 
            // argumentValue
            // 
            this.argumentValue.Location = new System.Drawing.Point(130, 3);
            this.argumentValue.Name = "argumentValue";
            this.argumentValue.Size = new System.Drawing.Size(229, 22);
            this.argumentValue.TabIndex = 1;
            // 
            // argumentType
            // 
            this.argumentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.argumentType.FormattingEnabled = true;
            this.argumentType.Items.AddRange(new object[] {
            "LUA_TNIL",
            "LUA_TBOOLEAN",
            "LUA_TNUMBER",
            "LUA_TSTRING",
            "LUA_TTABLE"});
            this.argumentType.Location = new System.Drawing.Point(3, 3);
            this.argumentType.Name = "argumentType";
            this.argumentType.Size = new System.Drawing.Size(121, 21);
            this.argumentType.TabIndex = 0;
            // 
            // button11
            // 
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(1186, 622);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(143, 50);
            this.button11.TabIndex = 34;
            this.button11.Text = "About";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click_1);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label16.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(0, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(550, 25);
            this.label16.TabIndex = 10;
            this.label16.Text = "Text";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label16);
            this.panel1.Location = new System.Drawing.Point(400, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 25);
            this.panel1.TabIndex = 35;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.Location = new System.Drawing.Point(389, 12);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(552, 61);
            this.pictureBox7.TabIndex = 36;
            this.pictureBox7.TabStop = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Transparent;
            this.button15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button15.BackgroundImage")));
            this.button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button15.ForeColor = System.Drawing.Color.White;
            this.button15.Location = new System.Drawing.Point(12, 624);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(71, 60);
            this.button15.TabIndex = 37;
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button19.ForeColor = System.Drawing.Color.White;
            this.button19.Location = new System.Drawing.Point(556, 622);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(166, 50);
            this.button19.TabIndex = 38;
            this.button19.Text = "Check PHP Server status";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.scriptArgumentPanel);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.MinimumSize = new System.Drawing.Size(1364, 718);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LuckyBlox Launcher 0.7";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.scriptArgumentPanel.ResumeLayout(false);
            this.argumentTemplate.ResumeLayout(false);
            this.argumentTemplate.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

	}

    private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {
		playaudio3();
    }

    private void button11_Click_1(object sender, EventArgs e)
    {
		playaudio();
        Form2 frm = new Form2();
        frm.Show();
    }

    private void listBox3_SelectedIndexChanged_1(object sender, EventArgs e)
    {

    }

    private void button12_Click(object sender, EventArgs e)
    {

    }

    private void tabPage4_Click(object sender, EventArgs e)
    {

    }

    private void label14_Click(object sender, EventArgs e)
    {

    }

    private void textBox10_TextChanged(object sender, EventArgs e)
    {

    }

    private void button13_Click_1(object sender, EventArgs e)
    {
        playaudio();
        if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\Maps"))
        {
            Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\Maps");
        }
        listBox4.Items.Clear();
        string[] directories = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + "\\Maps");
        for (int i = 0; i < directories.Length; i++)
        {
            listBox4.Items.Add(Path.GetFileName(directories[i]));
        }
    }
    private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
    {
		File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "Settings\\MapPath.txt", AppDomain.CurrentDomain.BaseDirectory + "Maps\\" + listBox4.SelectedItem.ToString());
        label17.Text = "Current map patch:\r\n" + File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "Settings/MapPath.txt");
        try
        {
            string filePathMapInfo = AppDomain.CurrentDomain.BaseDirectory + "/Webserver/www/marketplace/productinfo/index.php";
            if (listBox4.SelectedItem == null)
            {
                return;
            }
            string newValue = listBox4.SelectedItem.ToString();
            string fileContentMapInfo = File.ReadAllText(filePathMapInfo);
            string pattern = @"""Name"":""[^""]*"",""Description""";
            string replacement = $"\"Name\":\"{newValue}\",\"Description\"";
            string updatedContent = Regex.Replace(fileContentMapInfo, pattern, replacement);
            File.WriteAllText(filePathMapInfo, updatedContent);
        }
        catch
        {
        }

    }

    private async void button12_Click_1(object sender, EventArgs e)
    {
        headcolor = textBox6.Text;
        torsocolor = textBox7.Text;
        rightarmcolor = textBox8.Text;
        leftarmcolor = textBox9.Text;
        rightlegcolor = textBox10.Text;
        leftlegcolor = textBox11.Text;

		label10.Text = "Saved!";
        await Task.Delay(1000);
        label10.Text = "Body Colors";
    }

    private void label17_Click(object sender, EventArgs e)
    {

    }

    private void button14_Click_1(object sender, EventArgs e)
    {
		try
		{
			Process.Start(AppDomain.CurrentDomain.BaseDirectory + "unins000.exe");
			Environment.Exit(0);
		}
		catch
		{
			MessageBox.Show("unins000.exe not found in " + AppDomain.CurrentDomain.BaseDirectory + ". Are you just unpacked the launcher from zip without uninstall app?\r\n\r\nLooking, you are download the launcher without unoficcial installer. Just ignore it and close.", "Launcher");
		}
    }

    private void label16_Click(object sender, EventArgs e)
    {

    }

    private void button15_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (listBox5.SelectedItem != null && listBox5.SelectedItem.ToString() == "true")
        {
            File.Copy(AppDomain.CurrentDomain.BaseDirectory + "Settings\\EnabledAdonis\\admin.rbxm", AppDomain.CurrentDomain.BaseDirectory + "shared\\content\\admin.rbxm", true);
            File.Copy(AppDomain.CurrentDomain.BaseDirectory + "Settings\\EnabledAdonis\\admin.rbxm", AppDomain.CurrentDomain.BaseDirectory + "Clients\\2019M\\Player\\content\\admin.rbxm", true);

            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "Settings\\AdonisEnabled.txt", "true");
        }
        else if (listBox5.SelectedItem != null && listBox5.SelectedItem.ToString() == "false")
        {
            File.Copy(AppDomain.CurrentDomain.BaseDirectory + "Settings\\DisabledAdonis\\admin.rbxm", AppDomain.CurrentDomain.BaseDirectory + "shared\\content\\admin.rbxm", true);
            File.Copy(AppDomain.CurrentDomain.BaseDirectory + "Settings\\DisabledAdonis\\admin.rbxm", AppDomain.CurrentDomain.BaseDirectory + "Clients\\2019M\\Player\\content\\admin.rbxm", true);

            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "Settings\\AdonisEnabled.txt", "false");
        }
    }

    private void button16_Click(object sender, EventArgs e)
    {
        Process.Start(AppDomain.CurrentDomain.BaseDirectory + "Clients\\2022M\\RobloxStudioBeta.exe");
    }

    private void button17_Click(object sender, EventArgs e)
    {
        try
        {
            string targetPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Webserver", "www", "datastore", "items");

            if (!Directory.Exists(targetPath))
            {
                Directory.CreateDirectory(targetPath);
            }

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "explorer.exe",
                Arguments = $"\"{targetPath}\"",
                WindowStyle = ProcessWindowStyle.Maximized
            };

            Process.Start(psi);
        }
        catch (Exception ex)
        {
            Form errorForm = new Form
            {
                Text = "Information",
                Width = 430,
                Height = 160,
                StartPosition = FormStartPosition.CenterScreen,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };

            PictureBox picIcon = new PictureBox
            {
                Image = SystemIcons.Information.ToBitmap(),
                Location = new Point(20, 20),
                Size = new Size(32, 32),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            Label lblMessage = new Label
            {
                Text = "Something went wrong. Please try again later.",
                Location = new Point(65, 27),
                Size = new Size(335, 30),
                Font = new Font("Segoe UI", 10F, FontStyle.Regular)
            };

            Label lblInstructions = new Label
            {
                Text = "Copy this text and report it in our forum:",
                Location = new Point(20, 115),
                Size = new Size(375, 20),
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Visible = false
            };

            RichTextBox rtbDetails = new RichTextBox
            {
                Text = ex.ToString(),
                Location = new Point(20, 140),
                Size = new Size(375, 130),
                ReadOnly = true,
                Visible = false
            };

            Button btnOk = new Button
            {
                Text = "OK",
                Location = new Point(315, 70),
                Size = new Size(80, 28),
                DialogResult = DialogResult.OK
            };
            errorForm.AcceptButton = btnOk;

            Button btnDetails = new Button
            {
                Text = "Show details",
                Location = new Point(20, 70),
                Size = new Size(100, 28)
            };

            btnDetails.Click += (s, ea) =>
            {
                if (!rtbDetails.Visible)
                {
                    lblInstructions.Visible = true;
                    rtbDetails.Visible = true;
                    btnDetails.Text = "Hide details";
                    errorForm.Height = 330;
                }
                else
                {
                    lblInstructions.Visible = false;
                    rtbDetails.Visible = false;
                    btnDetails.Text = "Show details";
                    errorForm.Height = 160;
                }
            };

            errorForm.Controls.Add(picIcon);
            errorForm.Controls.Add(lblMessage);
            errorForm.Controls.Add(btnDetails);
            errorForm.Controls.Add(btnOk);
            errorForm.Controls.Add(lblInstructions);
            errorForm.Controls.Add(rtbDetails);

            errorForm.ShowDialog();
        }
    }

    private void label24_Click(object sender, EventArgs e)
    {

    }

    private void button18_Click(object sender, EventArgs e)
    {
        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            openFileDialog.Filter = "Roblox Assets (*.rbxm; *.rbxmx)|*.rbxm;*.rbxmx|All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Title = "Select Asset File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string sourceFile = openFileDialog.FileName;
                    string fileName = Path.GetFileName(sourceFile);
                    string baseDir = AppDomain.CurrentDomain.BaseDirectory;

                    string[] targetDirectories = new string[]
                    {
                            Path.Combine(baseDir, "Webserver", "www", "asset"),
                            Path.Combine(baseDir, "Webserver", "www", ".127.0.0.1", "asset"),
                            Path.Combine(baseDir, "Webserver", "www", "www.civdefn.tk", "asset"),
                            Path.Combine(baseDir, "Webserver", "www", ".localhost", "asset"),
                            Path.Combine(baseDir, "Webserver", "www", ".localhost", "aset", "asset")
                    };

                    foreach (string dir in targetDirectories)
                    {
                        if (!Directory.Exists(dir))
                        {
                            Directory.CreateDirectory(dir);
                        }

                        string destFile = Path.Combine(dir, fileName);
                        File.Copy(sourceFile, destFile, true);
                    }

                    MessageBox.Show("Success", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Form errorForm = new Form
                    {
                        Text = "Information",
                        Width = 430,
                        Height = 160,
                        StartPosition = FormStartPosition.CenterScreen,
                        FormBorderStyle = FormBorderStyle.FixedDialog,
                        MaximizeBox = false,
                        MinimizeBox = false
                    };

                    PictureBox picIcon = new PictureBox
                    {
                        Image = SystemIcons.Information.ToBitmap(),
                        Location = new Point(20, 20),
                        Size = new Size(32, 32),
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };

                    Label lblMessage = new Label
                    {
                        Text = "Something went wrong. Please try again later.",
                        Location = new Point(65, 27),
                        Size = new Size(335, 30),
                        Font = new Font("Segoe UI", 10F, FontStyle.Regular)
                    };

                    Label lblInstructions = new Label
                    {
                        Text = "Copy this text and report it in our forum:",
                        Location = new Point(20, 115),
                        Size = new Size(375, 20),
                        Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                        Visible = false
                    };

                    RichTextBox rtbDetails = new RichTextBox
                    {
                        Text = ex.ToString(),
                        Location = new Point(20, 140),
                        Size = new Size(375, 130),
                        ReadOnly = true,
                        Visible = false
                    };

                    Button btnOk = new Button
                    {
                        Text = "OK",
                        Location = new Point(315, 70),
                        Size = new Size(80, 28),
                        DialogResult = DialogResult.OK
                    };
                    errorForm.AcceptButton = btnOk;

                    Button btnDetails = new Button
                    {
                        Text = "Show details",
                        Location = new Point(20, 70),
                        Size = new Size(100, 28)
                    };

                    btnDetails.Click += (s, ea) =>
                    {
                        if (!rtbDetails.Visible)
                        {
                            lblInstructions.Visible = true;
                            rtbDetails.Visible = true;
                            btnDetails.Text = "Hide details";
                            errorForm.Height = 330;
                        }
                        else
                        {
                            lblInstructions.Visible = false;
                            rtbDetails.Visible = false;
                            btnDetails.Text = "Show details";
                            errorForm.Height = 160;
                        }
                    };

                    errorForm.Controls.Add(picIcon);
                    errorForm.Controls.Add(lblMessage);
                    errorForm.Controls.Add(btnDetails);
                    errorForm.Controls.Add(btnOk);
                    errorForm.Controls.Add(lblInstructions);
                    errorForm.Controls.Add(rtbDetails);

                    errorForm.ShowDialog();
                }
            }
        }
    }

    private void button19_Click_1(object sender, EventArgs e)
    {
        try
        {
            string url = "http://localhost/";

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };

            Process.Start(psi);
        }
        catch (Exception ex)
        {
            Form errorForm = new Form
            {
                Text = "Information",
                Width = 430,
                Height = 160,
                StartPosition = FormStartPosition.CenterScreen,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };

            PictureBox picIcon = new PictureBox
            {
                Image = SystemIcons.Information.ToBitmap(),
                Location = new Point(20, 20),
                Size = new Size(32, 32),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            Label lblMessage = new Label
            {
                Text = "Something went wrong. Please try again later.",
                Location = new Point(65, 27),
                Size = new Size(335, 30),
                Font = new Font("Segoe UI", 10F, FontStyle.Regular)
            };

            Label lblInstructions = new Label
            {
                Text = "Copy this text and report it in our forum:",
                Location = new Point(20, 115),
                Size = new Size(375, 20),
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Visible = false
            };

            RichTextBox rtbDetails = new RichTextBox
            {
                Text = ex.ToString(),
                Location = new Point(20, 140),
                Size = new Size(375, 130),
                ReadOnly = true,
                Visible = false
            };

            Button btnOk = new Button
            {
                Text = "OK",
                Location = new Point(315, 70),
                Size = new Size(80, 28),
                DialogResult = DialogResult.OK
            };
            errorForm.AcceptButton = btnOk;

            Button btnDetails = new Button
            {
                Text = "Show details",
                Location = new Point(20, 70),
                Size = new Size(100, 28)
            };

            btnDetails.Click += (s, ea) =>
            {
                if (!rtbDetails.Visible)
                {
                    lblInstructions.Visible = true;
                    rtbDetails.Visible = true;
                    btnDetails.Text = "Hide details";
                    errorForm.Height = 330;
                }
                else
                {
                    lblInstructions.Visible = false;
                    rtbDetails.Visible = false;
                    btnDetails.Text = "Show details";
                    errorForm.Height = 160;
                }
            };

            errorForm.Controls.Add(picIcon);
            errorForm.Controls.Add(lblMessage);
            errorForm.Controls.Add(btnDetails);
            errorForm.Controls.Add(btnOk);
            errorForm.Controls.Add(lblInstructions);
            errorForm.Controls.Add(rtbDetails);

            errorForm.ShowDialog();
        }
    }

    private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
    {
        File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "Settings\\DiscordRPC.txt", listBox6.SelectedItem.ToString());
    }

    private void button21_Click(object sender, EventArgs e)
    {
        OpenFileDialog openDialog = new OpenFileDialog();
        openDialog.Filter = "Roblox Assets (*.rbxm;*.rbxmx)|*.rbxm;*.rbxmx";
        openDialog.Multiselect = true;
        openDialog.Title = "Select assets to pack into LAP";

        if (openDialog.ShowDialog() != DialogResult.OK) return;

        SaveFileDialog saveDialog = new SaveFileDialog();
        saveDialog.Filter = "LuckyBlox Asset Pack (*.lap)|*.lap";
        saveDialog.Title = "Save LAP file";

        if (saveDialog.ShowDialog() != DialogResult.OK) return;

        string[] selectedFiles = openDialog.FileNames;
        string targetLapFile = saveDialog.FileName;

        Form progressForm = new Form();
        progressForm.Text = "LuckyBlox Launcher LAP Packer";
        progressForm.Size = new Size(400, 150);
        progressForm.FormBorderStyle = FormBorderStyle.FixedDialog;
        progressForm.StartPosition = FormStartPosition.CenterParent;
        progressForm.MaximizeBox = false;
        progressForm.MinimizeBox = false;

        Label lblStatus = new Label();
        lblStatus.Text = "Preparing...";
        lblStatus.Location = new Point(20, 20);
        lblStatus.Size = new Size(340, 25);

        ProgressBar progressBar1 = new ProgressBar();
        progressBar1.Location = new Point(20, 50);
        progressBar1.Size = new Size(340, 30);
        progressBar1.Minimum = 0;
        progressBar1.Maximum = 100;

        progressForm.Controls.Add(lblStatus);
        progressForm.Controls.Add(progressBar1);

        progressForm.Show(this);
        progressForm.Refresh();

        Action<int, string> updateProgress = (val, text) => {
            if (progressForm.InvokeRequired)
            {
                progressForm.Invoke(new Action(() => {
                    progressBar1.Value = val;
                    lblStatus.Text = text;
                }));
            }
            else
            {
                progressBar1.Value = val;
                lblStatus.Text = text;
            }
        };

        Thread backgroundThread = new Thread(() =>
        {
            try
            {
                string tempZipPath = Path.GetTempFileName();

                if (File.Exists(tempZipPath)) File.Delete(tempZipPath);

                using (ZipArchive archive = ZipFile.Open(tempZipPath, ZipArchiveMode.Create))
                {
                    for (int i = 0; i < selectedFiles.Length; i++)
                    {
                        string filePath = selectedFiles[i];
                        string fileName = Path.GetFileName(filePath);

                        int percent = (int)(((double)i / selectedFiles.Length) * 50);
                        updateProgress(percent, $"Packing: {fileName}...");

                        archive.CreateEntryFromFile(filePath, fileName);
                    }
                }

                updateProgress(50, "Encrypting asset pack...");

                byte[] key = Encoding.UTF8.GetBytes("LuckyBloxSecretKey123");

                using (FileStream fsIn = new FileStream(tempZipPath, FileMode.Open, FileAccess.Read))
                using (FileStream fsOut = new FileStream(targetLapFile, FileMode.Create, FileAccess.Write))
                {
                    byte[] buffer = new byte[4096];
                    long totalBytes = fsIn.Length;
                    long readBytes = 0;
                    int bytesRead;

                    while ((bytesRead = fsIn.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        for (int i = 0; i < bytesRead; i++)
                        {
                            buffer[i] = (byte)(buffer[i] ^ key[i % key.Length]);
                        }

                        fsOut.Write(buffer, 0, bytesRead);
                        readBytes += bytesRead;

                        int encryptPercent = 50 + (int)(((double)readBytes / totalBytes) * 50);
                        updateProgress(encryptPercent, $"Writing LAP file... {encryptPercent}%");
                    }
                }

                if (File.Exists(tempZipPath)) File.Delete(tempZipPath);

                updateProgress(100, "Done!");

                this.Invoke(new Action(() => {
                    progressForm.Close();
                    progressForm.Dispose();
                    MessageBox.Show(".LAP asset pack built successfully!", "LuckyBlox Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }));
            }
            catch (Exception ex)
            {
                this.Invoke(new Action(() => {
                    progressForm.Close();
                    progressForm.Dispose();
                    MessageBox.Show($"Error creating LAP: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }));
            }
        });

        backgroundThread.Start();
    }

    private void button20_Click(object sender, EventArgs e)
    {
        OpenFileDialog openDialog = new OpenFileDialog();
        openDialog.Filter = "LuckyBlox Asset Pack (*.lap)|*.lap";
        openDialog.Title = "Select LAP file to unpack";

        if (openDialog.ShowDialog() != DialogResult.OK) return;

        string sourceLapFile = openDialog.FileName;
        string baseDir = AppDomain.CurrentDomain.BaseDirectory;

        string[] targetDirectories = new string[]
        {
        Path.Combine(baseDir, "Webserver", "www", "asset"),
        Path.Combine(baseDir, "Webserver", "www", ".127.0.0.1", "asset"),
        Path.Combine(baseDir, "Webserver", "www", "www.civdefn.tk", "asset"),
        Path.Combine(baseDir, "Webserver", "www", ".localhost", "asset"),
        Path.Combine(baseDir, "Webserver", "www", ".localhost", "aset", "asset")
        };

        Form progressForm = new Form();
        progressForm.Text = "LuckyBlox Launcher";
        progressForm.Size = new Size(400, 150);
        progressForm.FormBorderStyle = FormBorderStyle.FixedDialog;
        progressForm.StartPosition = FormStartPosition.CenterParent;
        progressForm.MaximizeBox = false;
        progressForm.MinimizeBox = false;

        Label lblStatus = new Label();
        lblStatus.Text = "Preparing...";
        lblStatus.Location = new Point(20, 20);
        lblStatus.Size = new Size(340, 25);

        ProgressBar progressBar1 = new ProgressBar();
        progressBar1.Location = new Point(20, 50);
        progressBar1.Size = new Size(340, 30);
        progressBar1.Minimum = 0;
        progressBar1.Maximum = 100;

        progressForm.Controls.Add(lblStatus);
        progressForm.Controls.Add(progressBar1);

        progressForm.Show(this);
        progressForm.Refresh();

        Action<int, string> updateProgress = (val, text) => {
            if (progressForm.InvokeRequired)
            {
                progressForm.Invoke(new Action(() => {
                    progressBar1.Value = val;
                    lblStatus.Text = text;
                }));
            }
            else
            {
                progressBar1.Value = val;
                lblStatus.Text = text;
            }
        };

        Thread backgroundThread = new Thread(() =>
        {
            try
            {
                updateProgress(10, "Decrypting asset pack...");

                string tempZipPath = Path.GetTempFileName();
                if (File.Exists(tempZipPath)) File.Delete(tempZipPath);

                byte[] key = Encoding.UTF8.GetBytes("LuckyBloxSecretKey123");

                using (FileStream fsIn = new FileStream(sourceLapFile, FileMode.Open, FileAccess.Read))
                using (FileStream fsOut = new FileStream(tempZipPath, FileMode.Create, FileAccess.Write))
                {
                    byte[] buffer = new byte[4096];
                    long totalBytes = fsIn.Length;
                    long readBytes = 0;
                    int bytesRead;

                    while ((bytesRead = fsIn.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        for (int i = 0; i < bytesRead; i++)
                        {
                            buffer[i] = (byte)(buffer[i] ^ key[i % key.Length]);
                        }

                        fsOut.Write(buffer, 0, bytesRead);
                        readBytes += bytesRead;

                        int decryptPercent = 10 + (int)(((double)readBytes / totalBytes) * 40);
                        updateProgress(decryptPercent, $"Decrypting... {decryptPercent}%");
                    }
                }

                updateProgress(50, "Unpacking assets...");

                using (ZipArchive archive = ZipFile.OpenRead(tempZipPath))
                {
                    int totalEntries = archive.Entries.Count;
                    for (int i = 0; i < totalEntries; i++)
                    {
                        ZipArchiveEntry entry = archive.Entries[i];

                        int unpackPercent = 50 + (int)(((double)i / totalEntries) * 50);
                        updateProgress(unpackPercent, $"Extracting: {entry.Name}...");

                        foreach (string dir in targetDirectories)
                        {
                            if (!Directory.Exists(dir))
                            {
                                Directory.CreateDirectory(dir);
                            }

                            string fullPath = Path.Combine(dir, entry.FullName);
                            entry.ExtractToFile(fullPath, true);
                        }
                    }
                }

                if (File.Exists(tempZipPath)) File.Delete(tempZipPath);

                updateProgress(100, "Done!");

                this.Invoke(new Action(() => {
                    progressForm.Close();
                    progressForm.Dispose();
                    MessageBox.Show(".LAP asset pack imported!", "LuckyBlox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }));
            }
            catch (Exception ex)
            {
                this.Invoke(new Action(() => {
                    progressForm.Close();
                    progressForm.Dispose();
                    MessageBox.Show($"Error unpacking LAP: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }));
            }
        });

        backgroundThread.Start();
    }

    private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "Settings\\membership.txt", listBox7.SelectedItem.ToString());
        }
        catch { }
    }
}
