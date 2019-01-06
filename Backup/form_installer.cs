// Decompiled with JetBrains decompiler
// Type: coinapp.form_installer
// Assembly: coinapp, Version=1.4.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6DB842CC-5810-43FB-8044-475700CA1E42
// Assembly location: C:\Users\EarlJohn\Desktop\Coinapp\coinapp_1.4.0.0\coinapp.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.ServiceProcess;
using System.Threading;
using System.Windows.Forms;

namespace coinapp
{
  [DesignerGenerated]
  public class form_installer : Form
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private IContainer components;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("cb_device")]
    private ComboBox _cb_device;
    [AccessedThroughProperty("lbl_cointype")]
    private Label _lbl_cointype;
    [AccessedThroughProperty("cb_cointype")]
    private ComboBox _cb_cointype;
    [AccessedThroughProperty("gb_coin1")]
    private GroupBox _gb_coin1;
    [AccessedThroughProperty("nud_second1")]
    private NumericUpDown _nud_second1;
    [AccessedThroughProperty("nud_pulse1")]
    private NumericUpDown _nud_pulse1;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("Label4")]
    private Label _Label4;
    [AccessedThroughProperty("gb_coin2")]
    private GroupBox _gb_coin2;
    [AccessedThroughProperty("nud_second2")]
    private NumericUpDown _nud_second2;
    [AccessedThroughProperty("nud_pulse2")]
    private NumericUpDown _nud_pulse2;
    [AccessedThroughProperty("Label5")]
    private Label _Label5;
    [AccessedThroughProperty("Label6")]
    private Label _Label6;
    [AccessedThroughProperty("gb_coin3")]
    private GroupBox _gb_coin3;
    [AccessedThroughProperty("nud_second3")]
    private NumericUpDown _nud_second3;
    [AccessedThroughProperty("nud_pulse3")]
    private NumericUpDown _nud_pulse3;
    [AccessedThroughProperty("Label7")]
    private Label _Label7;
    [AccessedThroughProperty("Label8")]
    private Label _Label8;
    [AccessedThroughProperty("lbl_shutdwntime")]
    private Label _lbl_shutdwntime;
    [AccessedThroughProperty("nud_shutdowntime")]
    private NumericUpDown _nud_shutdowntime;
    [AccessedThroughProperty("lbl_hotkey")]
    private Label _lbl_hotkey;
    [AccessedThroughProperty("txtbx_hotkey")]
    private TextBox _txtbx_hotkey;
    [AccessedThroughProperty("lbl_pass")]
    private Label _lbl_pass;
    [AccessedThroughProperty("txtbx_pass")]
    private TextBox _txtbx_pass;
    [AccessedThroughProperty("lbl_email")]
    private Label _lbl_email;
    [AccessedThroughProperty("txtbx_email")]
    private TextBox _txtbx_email;
    [AccessedThroughProperty("btn_install")]
    private Button _btn_install;
    [AccessedThroughProperty("StatusStrip1")]
    private StatusStrip _StatusStrip1;
    [AccessedThroughProperty("sComPort")]
    private SerialPort _sComPort;
    private bool WORKING;
    private int keycode;
    private string keycodeString;
    private string xport;
    private string xname;
    [AccessedThroughProperty("worker")]
    private BackgroundWorker _worker;
    private ToolStripStatusLabel labelStatus;

    [DebuggerNonUserCode]
    static form_installer()
    {
    }

    [DebuggerNonUserCode]
    public form_installer()
    {
      this.Load += new EventHandler(this.form_installer_Load);
      form_installer.__ENCAddToList((object) this);
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (form_installer.__ENCList)
      {
        if (form_installer.__ENCList.Count == form_installer.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (form_installer.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (form_installer.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                form_installer.__ENCList[index1] = form_installer.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          form_installer.__ENCList.RemoveRange(index1, checked (form_installer.__ENCList.Count - index1));
          form_installer.__ENCList.Capacity = form_installer.__ENCList.Count;
        }
        form_installer.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
      }
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing || this.components == null)
          return;
        this.components.Dispose();
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (form_installer));
      this.Label1 = new Label();
      this.cb_device = new ComboBox();
      this.lbl_cointype = new Label();
      this.cb_cointype = new ComboBox();
      this.gb_coin1 = new GroupBox();
      this.nud_second1 = new NumericUpDown();
      this.nud_pulse1 = new NumericUpDown();
      this.Label3 = new Label();
      this.Label4 = new Label();
      this.gb_coin2 = new GroupBox();
      this.nud_second2 = new NumericUpDown();
      this.nud_pulse2 = new NumericUpDown();
      this.Label5 = new Label();
      this.Label6 = new Label();
      this.gb_coin3 = new GroupBox();
      this.nud_second3 = new NumericUpDown();
      this.nud_pulse3 = new NumericUpDown();
      this.Label7 = new Label();
      this.Label8 = new Label();
      this.lbl_shutdwntime = new Label();
      this.nud_shutdowntime = new NumericUpDown();
      this.lbl_hotkey = new Label();
      this.txtbx_hotkey = new TextBox();
      this.lbl_pass = new Label();
      this.txtbx_pass = new TextBox();
      this.lbl_email = new Label();
      this.txtbx_email = new TextBox();
      this.btn_install = new Button();
      this.StatusStrip1 = new StatusStrip();
      this.gb_coin1.SuspendLayout();
      this.nud_second1.BeginInit();
      this.nud_pulse1.BeginInit();
      this.gb_coin2.SuspendLayout();
      this.nud_second2.BeginInit();
      this.nud_pulse2.BeginInit();
      this.gb_coin3.SuspendLayout();
      this.nud_second3.BeginInit();
      this.nud_pulse3.BeginInit();
      this.nud_shutdowntime.BeginInit();
      this.SuspendLayout();
      this.Label1.AutoSize = true;
      Label label1_1 = this.Label1;
      Point point1 = new Point(28, 21);
      Point point2 = point1;
      label1_1.Location = point2;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      Size size1 = new Size(126, 13);
      Size size2 = size1;
      label1_2.Size = size2;
      this.Label1.TabIndex = 0;
      this.Label1.Text = "Select compatible device";
      this.cb_device.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cb_device.Enabled = false;
      this.cb_device.FormattingEnabled = true;
      ComboBox cbDevice1 = this.cb_device;
      point1 = new Point(22, 37);
      Point point3 = point1;
      cbDevice1.Location = point3;
      this.cb_device.Name = "cb_device";
      ComboBox cbDevice2 = this.cb_device;
      size1 = new Size(268, 21);
      Size size3 = size1;
      cbDevice2.Size = size3;
      this.cb_device.TabIndex = 1;
      this.lbl_cointype.AutoSize = true;
      Label lblCointype1 = this.lbl_cointype;
      point1 = new Point(28, 74);
      Point point4 = point1;
      lblCointype1.Location = point4;
      this.lbl_cointype.Name = "lbl_cointype";
      Label lblCointype2 = this.lbl_cointype;
      size1 = new Size(151, 13);
      Size size4 = size1;
      lblCointype2.Size = size4;
      this.lbl_cointype.TabIndex = 2;
      this.lbl_cointype.Text = "Select your coin acceptor type";
      this.cb_cointype.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cb_cointype.Enabled = false;
      this.cb_cointype.FormattingEnabled = true;
      this.cb_cointype.Items.AddRange(new object[3]
      {
        (object) "Single-coin slot (1-peso or 5-peso only)",
        (object) "Dual-coin slot (1-peso and 5-peso together)",
        (object) "Multi-coin slot (Universal-coin slot)"
      });
      ComboBox cbCointype1 = this.cb_cointype;
      point1 = new Point(22, 90);
      Point point5 = point1;
      cbCointype1.Location = point5;
      this.cb_cointype.Name = "cb_cointype";
      ComboBox cbCointype2 = this.cb_cointype;
      size1 = new Size(268, 21);
      Size size5 = size1;
      cbCointype2.Size = size5;
      this.cb_cointype.TabIndex = 3;
      this.gb_coin1.Controls.Add((Control) this.nud_second1);
      this.gb_coin1.Controls.Add((Control) this.nud_pulse1);
      this.gb_coin1.Controls.Add((Control) this.Label3);
      this.gb_coin1.Controls.Add((Control) this.Label4);
      this.gb_coin1.Enabled = false;
      GroupBox gbCoin1_1 = this.gb_coin1;
      point1 = new Point(22, 117);
      Point point6 = point1;
      gbCoin1_1.Location = point6;
      this.gb_coin1.Name = "gb_coin1";
      GroupBox gbCoin1_2 = this.gb_coin1;
      size1 = new Size(268, 40);
      Size size6 = size1;
      gbCoin1_2.Size = size6;
      this.gb_coin1.TabIndex = 4;
      this.gb_coin1.TabStop = false;
      this.gb_coin1.Text = "Coin 1";
      NumericUpDown nudSecond1_1 = this.nud_second1;
      point1 = new Point(70, 13);
      Point point7 = point1;
      nudSecond1_1.Location = point7;
      NumericUpDown nudSecond1_2 = this.nud_second1;
      Decimal num1 = new Decimal(new int[4]
      {
        9999,
        0,
        0,
        0
      });
      Decimal num2 = num1;
      nudSecond1_2.Maximum = num2;
      this.nud_second1.Name = "nud_second1";
      NumericUpDown nudSecond1_3 = this.nud_second1;
      size1 = new Size(79, 20);
      Size size7 = size1;
      nudSecond1_3.Size = size7;
      this.nud_second1.TabIndex = 6;
      NumericUpDown nudPulse1_1 = this.nud_pulse1;
      point1 = new Point(200, 13);
      Point point8 = point1;
      nudPulse1_1.Location = point8;
      NumericUpDown nudPulse1_2 = this.nud_pulse1;
      num1 = new Decimal(new int[4]{ 99, 0, 0, 0 });
      Decimal num3 = num1;
      nudPulse1_2.Maximum = num3;
      this.nud_pulse1.Name = "nud_pulse1";
      NumericUpDown nudPulse1_3 = this.nud_pulse1;
      size1 = new Size(53, 20);
      Size size8 = size1;
      nudPulse1_3.Size = size8;
      this.nud_pulse1.TabIndex = 8;
      this.Label3.AutoSize = true;
      Label label3_1 = this.Label3;
      point1 = new Point(18, 16);
      Point point9 = point1;
      label3_1.Location = point9;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(49, 13);
      Size size9 = size1;
      label3_2.Size = size9;
      this.Label3.TabIndex = 5;
      this.Label3.Text = "Seconds";
      this.Label4.AutoSize = true;
      Label label4_1 = this.Label4;
      point1 = new Point(164, 16);
      Point point10 = point1;
      label4_1.Location = point10;
      this.Label4.Name = "Label4";
      Label label4_2 = this.Label4;
      size1 = new Size(33, 13);
      Size size10 = size1;
      label4_2.Size = size10;
      this.Label4.TabIndex = 7;
      this.Label4.Text = "Pulse";
      this.gb_coin2.Controls.Add((Control) this.nud_second2);
      this.gb_coin2.Controls.Add((Control) this.nud_pulse2);
      this.gb_coin2.Controls.Add((Control) this.Label5);
      this.gb_coin2.Controls.Add((Control) this.Label6);
      this.gb_coin2.Enabled = false;
      GroupBox gbCoin2_1 = this.gb_coin2;
      point1 = new Point(22, 163);
      Point point11 = point1;
      gbCoin2_1.Location = point11;
      this.gb_coin2.Name = "gb_coin2";
      GroupBox gbCoin2_2 = this.gb_coin2;
      size1 = new Size(268, 40);
      Size size11 = size1;
      gbCoin2_2.Size = size11;
      this.gb_coin2.TabIndex = 9;
      this.gb_coin2.TabStop = false;
      this.gb_coin2.Text = "Coin 2";
      NumericUpDown nudSecond2_1 = this.nud_second2;
      point1 = new Point(70, 13);
      Point point12 = point1;
      nudSecond2_1.Location = point12;
      NumericUpDown nudSecond2_2 = this.nud_second2;
      num1 = new Decimal(new int[4]{ 9999, 0, 0, 0 });
      Decimal num4 = num1;
      nudSecond2_2.Maximum = num4;
      this.nud_second2.Name = "nud_second2";
      NumericUpDown nudSecond2_3 = this.nud_second2;
      size1 = new Size(79, 20);
      Size size12 = size1;
      nudSecond2_3.Size = size12;
      this.nud_second2.TabIndex = 11;
      NumericUpDown nudPulse2_1 = this.nud_pulse2;
      point1 = new Point(200, 13);
      Point point13 = point1;
      nudPulse2_1.Location = point13;
      NumericUpDown nudPulse2_2 = this.nud_pulse2;
      num1 = new Decimal(new int[4]{ 99, 0, 0, 0 });
      Decimal num5 = num1;
      nudPulse2_2.Maximum = num5;
      this.nud_pulse2.Name = "nud_pulse2";
      NumericUpDown nudPulse2_3 = this.nud_pulse2;
      size1 = new Size(53, 20);
      Size size13 = size1;
      nudPulse2_3.Size = size13;
      this.nud_pulse2.TabIndex = 13;
      this.Label5.AutoSize = true;
      Label label5_1 = this.Label5;
      point1 = new Point(18, 16);
      Point point14 = point1;
      label5_1.Location = point14;
      this.Label5.Name = "Label5";
      Label label5_2 = this.Label5;
      size1 = new Size(49, 13);
      Size size14 = size1;
      label5_2.Size = size14;
      this.Label5.TabIndex = 10;
      this.Label5.Text = "Seconds";
      this.Label6.AutoSize = true;
      Label label6_1 = this.Label6;
      point1 = new Point(164, 16);
      Point point15 = point1;
      label6_1.Location = point15;
      this.Label6.Name = "Label6";
      Label label6_2 = this.Label6;
      size1 = new Size(33, 13);
      Size size15 = size1;
      label6_2.Size = size15;
      this.Label6.TabIndex = 12;
      this.Label6.Text = "Pulse";
      this.gb_coin3.Controls.Add((Control) this.nud_second3);
      this.gb_coin3.Controls.Add((Control) this.nud_pulse3);
      this.gb_coin3.Controls.Add((Control) this.Label7);
      this.gb_coin3.Controls.Add((Control) this.Label8);
      this.gb_coin3.Enabled = false;
      GroupBox gbCoin3_1 = this.gb_coin3;
      point1 = new Point(22, 209);
      Point point16 = point1;
      gbCoin3_1.Location = point16;
      this.gb_coin3.Name = "gb_coin3";
      GroupBox gbCoin3_2 = this.gb_coin3;
      size1 = new Size(268, 40);
      Size size16 = size1;
      gbCoin3_2.Size = size16;
      this.gb_coin3.TabIndex = 14;
      this.gb_coin3.TabStop = false;
      this.gb_coin3.Text = "Coin 3";
      NumericUpDown nudSecond3_1 = this.nud_second3;
      point1 = new Point(70, 13);
      Point point17 = point1;
      nudSecond3_1.Location = point17;
      NumericUpDown nudSecond3_2 = this.nud_second3;
      num1 = new Decimal(new int[4]{ 9999, 0, 0, 0 });
      Decimal num6 = num1;
      nudSecond3_2.Maximum = num6;
      this.nud_second3.Name = "nud_second3";
      NumericUpDown nudSecond3_3 = this.nud_second3;
      size1 = new Size(79, 20);
      Size size17 = size1;
      nudSecond3_3.Size = size17;
      this.nud_second3.TabIndex = 16;
      NumericUpDown nudPulse3_1 = this.nud_pulse3;
      point1 = new Point(200, 13);
      Point point18 = point1;
      nudPulse3_1.Location = point18;
      NumericUpDown nudPulse3_2 = this.nud_pulse3;
      num1 = new Decimal(new int[4]{ 99, 0, 0, 0 });
      Decimal num7 = num1;
      nudPulse3_2.Maximum = num7;
      this.nud_pulse3.Name = "nud_pulse3";
      NumericUpDown nudPulse3_3 = this.nud_pulse3;
      size1 = new Size(53, 20);
      Size size18 = size1;
      nudPulse3_3.Size = size18;
      this.nud_pulse3.TabIndex = 18;
      this.Label7.AutoSize = true;
      Label label7_1 = this.Label7;
      point1 = new Point(18, 16);
      Point point19 = point1;
      label7_1.Location = point19;
      this.Label7.Name = "Label7";
      Label label7_2 = this.Label7;
      size1 = new Size(49, 13);
      Size size19 = size1;
      label7_2.Size = size19;
      this.Label7.TabIndex = 15;
      this.Label7.Text = "Seconds";
      this.Label8.AutoSize = true;
      Label label8_1 = this.Label8;
      point1 = new Point(164, 16);
      Point point20 = point1;
      label8_1.Location = point20;
      this.Label8.Name = "Label8";
      Label label8_2 = this.Label8;
      size1 = new Size(33, 13);
      Size size20 = size1;
      label8_2.Size = size20;
      this.Label8.TabIndex = 17;
      this.Label8.Text = "Pulse";
      this.lbl_shutdwntime.AutoSize = true;
      Label lblShutdwntime1 = this.lbl_shutdwntime;
      point1 = new Point(21, 267);
      Point point21 = point1;
      lblShutdwntime1.Location = point21;
      this.lbl_shutdwntime.Name = "lbl_shutdwntime";
      Label lblShutdwntime2 = this.lbl_shutdwntime;
      size1 = new Size(115, 13);
      Size size21 = size1;
      lblShutdwntime2.Size = size21;
      this.lbl_shutdwntime.TabIndex = 19;
      this.lbl_shutdwntime.Text = "Shutdown time on lock";
      this.nud_shutdowntime.Enabled = false;
      NumericUpDown nudShutdowntime1 = this.nud_shutdowntime;
      point1 = new Point(211, 265);
      Point point22 = point1;
      nudShutdowntime1.Location = point22;
      NumericUpDown nudShutdowntime2 = this.nud_shutdowntime;
      num1 = new Decimal(new int[4]{ 9999, 0, 0, 0 });
      Decimal num8 = num1;
      nudShutdowntime2.Maximum = num8;
      this.nud_shutdowntime.Name = "nud_shutdowntime";
      NumericUpDown nudShutdowntime3 = this.nud_shutdowntime;
      size1 = new Size(79, 20);
      Size size22 = size1;
      nudShutdowntime3.Size = size22;
      this.nud_shutdowntime.TabIndex = 20;
      this.lbl_hotkey.AutoSize = true;
      Label lblHotkey1 = this.lbl_hotkey;
      point1 = new Point(21, 298);
      Point point23 = point1;
      lblHotkey1.Location = point23;
      this.lbl_hotkey.Name = "lbl_hotkey";
      Label lblHotkey2 = this.lbl_hotkey;
      size1 = new Size(159, 13);
      Size size23 = size1;
      lblHotkey2.Size = size23;
      this.lbl_hotkey.TabIndex = 21;
      this.lbl_hotkey.Text = "Hotkey (CTR + ALT + SHIFT + )";
      this.txtbx_hotkey.Enabled = false;
      TextBox txtbxHotkey1 = this.txtbx_hotkey;
      point1 = new Point(211, 295);
      Point point24 = point1;
      txtbxHotkey1.Location = point24;
      this.txtbx_hotkey.MaxLength = 1;
      this.txtbx_hotkey.Name = "txtbx_hotkey";
      this.txtbx_hotkey.ReadOnly = true;
      TextBox txtbxHotkey2 = this.txtbx_hotkey;
      size1 = new Size(79, 20);
      Size size24 = size1;
      txtbxHotkey2.Size = size24;
      this.txtbx_hotkey.TabIndex = 22;
      this.lbl_pass.AutoSize = true;
      Label lblPass1 = this.lbl_pass;
      point1 = new Point(21, 328);
      Point point25 = point1;
      lblPass1.Location = point25;
      this.lbl_pass.Name = "lbl_pass";
      Label lblPass2 = this.lbl_pass;
      size1 = new Size(53, 13);
      Size size25 = size1;
      lblPass2.Size = size25;
      this.lbl_pass.TabIndex = 23;
      this.lbl_pass.Text = "Password";
      this.txtbx_pass.Enabled = false;
      TextBox txtbxPass1 = this.txtbx_pass;
      point1 = new Point(114, 325);
      Point point26 = point1;
      txtbxPass1.Location = point26;
      this.txtbx_pass.Name = "txtbx_pass";
      TextBox txtbxPass2 = this.txtbx_pass;
      size1 = new Size(176, 20);
      Size size26 = size1;
      txtbxPass2.Size = size26;
      this.txtbx_pass.TabIndex = 24;
      this.lbl_email.AutoSize = true;
      Label lblEmail1 = this.lbl_email;
      point1 = new Point(21, 354);
      Point point27 = point1;
      lblEmail1.Location = point27;
      this.lbl_email.Name = "lbl_email";
      Label lblEmail2 = this.lbl_email;
      size1 = new Size(80, 13);
      Size size27 = size1;
      lblEmail2.Size = size27;
      this.lbl_email.TabIndex = 25;
      this.lbl_email.Text = "Recovery email";
      this.txtbx_email.Enabled = false;
      TextBox txtbxEmail1 = this.txtbx_email;
      point1 = new Point(114, 351);
      Point point28 = point1;
      txtbxEmail1.Location = point28;
      this.txtbx_email.Name = "txtbx_email";
      TextBox txtbxEmail2 = this.txtbx_email;
      size1 = new Size(176, 20);
      Size size28 = size1;
      txtbxEmail2.Size = size28;
      this.txtbx_email.TabIndex = 26;
      this.btn_install.Enabled = false;
      Button btnInstall1 = this.btn_install;
      point1 = new Point(22, 391);
      Point point29 = point1;
      btnInstall1.Location = point29;
      this.btn_install.Name = "btn_install";
      Button btnInstall2 = this.btn_install;
      size1 = new Size(268, 31);
      Size size29 = size1;
      btnInstall2.Size = size29;
      this.btn_install.TabIndex = 27;
      this.btn_install.TabStop = false;
      this.btn_install.Text = "I N S T A L L";
      this.btn_install.UseVisualStyleBackColor = true;
      StatusStrip statusStrip1_1 = this.StatusStrip1;
      point1 = new Point(0, 436);
      Point point30 = point1;
      statusStrip1_1.Location = point30;
      this.StatusStrip1.Name = "StatusStrip1";
      StatusStrip statusStrip1_2 = this.StatusStrip1;
      size1 = new Size(310, 22);
      Size size30 = size1;
      statusStrip1_2.Size = size30;
      this.StatusStrip1.TabIndex = 28;
      this.StatusStrip1.Text = "StatusStrip1";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(310, 458);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.StatusStrip1);
      this.Controls.Add((Control) this.btn_install);
      this.Controls.Add((Control) this.txtbx_email);
      this.Controls.Add((Control) this.txtbx_pass);
      this.Controls.Add((Control) this.txtbx_hotkey);
      this.Controls.Add((Control) this.nud_shutdowntime);
      this.Controls.Add((Control) this.gb_coin3);
      this.Controls.Add((Control) this.gb_coin2);
      this.Controls.Add((Control) this.gb_coin1);
      this.Controls.Add((Control) this.cb_cointype);
      this.Controls.Add((Control) this.cb_device);
      this.Controls.Add((Control) this.lbl_email);
      this.Controls.Add((Control) this.lbl_hotkey);
      this.Controls.Add((Control) this.lbl_pass);
      this.Controls.Add((Control) this.lbl_shutdwntime);
      this.Controls.Add((Control) this.lbl_cointype);
      this.Controls.Add((Control) this.Label1);
      this.FormBorderStyle = FormBorderStyle.Fixed3D;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      size1 = new Size(330, 500);
      this.MaximumSize = size1;
      size1 = new Size(330, 500);
      this.MinimumSize = size1;
      this.Name = nameof (form_installer);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "COINAPP INSTALLER";
      this.gb_coin1.ResumeLayout(false);
      this.gb_coin1.PerformLayout();
      this.nud_second1.EndInit();
      this.nud_pulse1.EndInit();
      this.gb_coin2.ResumeLayout(false);
      this.gb_coin2.PerformLayout();
      this.nud_second2.EndInit();
      this.nud_pulse2.EndInit();
      this.gb_coin3.ResumeLayout(false);
      this.gb_coin3.PerformLayout();
      this.nud_second3.EndInit();
      this.nud_pulse3.EndInit();
      this.nud_shutdowntime.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual Label Label1
    {
      [DebuggerNonUserCode] get
      {
        return this._Label1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label1 = value;
      }
    }

    internal virtual ComboBox cb_device
    {
      [DebuggerNonUserCode] get
      {
        return this._cb_device;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._cb_device = value;
      }
    }

    internal virtual Label lbl_cointype
    {
      [DebuggerNonUserCode] get
      {
        return this._lbl_cointype;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lbl_cointype = value;
      }
    }

    internal virtual ComboBox cb_cointype
    {
      [DebuggerNonUserCode] get
      {
        return this._cb_cointype;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.cb_cointype_SelectedIndexChanged);
        EventHandler eventHandler2 = new EventHandler(this.inputTextbox_TextChanged);
        if (this._cb_cointype != null)
        {
          this._cb_cointype.SelectedIndexChanged -= eventHandler1;
          this._cb_cointype.SelectedValueChanged -= eventHandler2;
        }
        this._cb_cointype = value;
        if (this._cb_cointype == null)
          return;
        this._cb_cointype.SelectedIndexChanged += eventHandler1;
        this._cb_cointype.SelectedValueChanged += eventHandler2;
      }
    }

    internal virtual GroupBox gb_coin1
    {
      [DebuggerNonUserCode] get
      {
        return this._gb_coin1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._gb_coin1 = value;
      }
    }

    internal virtual NumericUpDown nud_second1
    {
      [DebuggerNonUserCode] get
      {
        return this._nud_second1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.inputTextbox_TextChanged);
        if (this._nud_second1 != null)
          this._nud_second1.TextChanged -= eventHandler;
        this._nud_second1 = value;
        if (this._nud_second1 == null)
          return;
        this._nud_second1.TextChanged += eventHandler;
      }
    }

    internal virtual NumericUpDown nud_pulse1
    {
      [DebuggerNonUserCode] get
      {
        return this._nud_pulse1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.inputTextbox_TextChanged);
        if (this._nud_pulse1 != null)
          this._nud_pulse1.TextChanged -= eventHandler;
        this._nud_pulse1 = value;
        if (this._nud_pulse1 == null)
          return;
        this._nud_pulse1.TextChanged += eventHandler;
      }
    }

    internal virtual Label Label3
    {
      [DebuggerNonUserCode] get
      {
        return this._Label3;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label3 = value;
      }
    }

    internal virtual Label Label4
    {
      [DebuggerNonUserCode] get
      {
        return this._Label4;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label4 = value;
      }
    }

    internal virtual GroupBox gb_coin2
    {
      [DebuggerNonUserCode] get
      {
        return this._gb_coin2;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._gb_coin2 = value;
      }
    }

    internal virtual NumericUpDown nud_second2
    {
      [DebuggerNonUserCode] get
      {
        return this._nud_second2;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.inputTextbox_TextChanged);
        if (this._nud_second2 != null)
          this._nud_second2.TextChanged -= eventHandler;
        this._nud_second2 = value;
        if (this._nud_second2 == null)
          return;
        this._nud_second2.TextChanged += eventHandler;
      }
    }

    internal virtual NumericUpDown nud_pulse2
    {
      [DebuggerNonUserCode] get
      {
        return this._nud_pulse2;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.inputTextbox_TextChanged);
        if (this._nud_pulse2 != null)
          this._nud_pulse2.TextChanged -= eventHandler;
        this._nud_pulse2 = value;
        if (this._nud_pulse2 == null)
          return;
        this._nud_pulse2.TextChanged += eventHandler;
      }
    }

    internal virtual Label Label5
    {
      [DebuggerNonUserCode] get
      {
        return this._Label5;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label5 = value;
      }
    }

    internal virtual Label Label6
    {
      [DebuggerNonUserCode] get
      {
        return this._Label6;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label6 = value;
      }
    }

    internal virtual GroupBox gb_coin3
    {
      [DebuggerNonUserCode] get
      {
        return this._gb_coin3;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._gb_coin3 = value;
      }
    }

    internal virtual NumericUpDown nud_second3
    {
      [DebuggerNonUserCode] get
      {
        return this._nud_second3;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.inputTextbox_TextChanged);
        if (this._nud_second3 != null)
          this._nud_second3.TextChanged -= eventHandler;
        this._nud_second3 = value;
        if (this._nud_second3 == null)
          return;
        this._nud_second3.TextChanged += eventHandler;
      }
    }

    internal virtual NumericUpDown nud_pulse3
    {
      [DebuggerNonUserCode] get
      {
        return this._nud_pulse3;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.inputTextbox_TextChanged);
        if (this._nud_pulse3 != null)
          this._nud_pulse3.TextChanged -= eventHandler;
        this._nud_pulse3 = value;
        if (this._nud_pulse3 == null)
          return;
        this._nud_pulse3.TextChanged += eventHandler;
      }
    }

    internal virtual Label Label7
    {
      [DebuggerNonUserCode] get
      {
        return this._Label7;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label7 = value;
      }
    }

    internal virtual Label Label8
    {
      [DebuggerNonUserCode] get
      {
        return this._Label8;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label8 = value;
      }
    }

    internal virtual Label lbl_shutdwntime
    {
      [DebuggerNonUserCode] get
      {
        return this._lbl_shutdwntime;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lbl_shutdwntime = value;
      }
    }

    internal virtual NumericUpDown nud_shutdowntime
    {
      [DebuggerNonUserCode] get
      {
        return this._nud_shutdowntime;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.inputTextbox_TextChanged);
        if (this._nud_shutdowntime != null)
          this._nud_shutdowntime.TextChanged -= eventHandler;
        this._nud_shutdowntime = value;
        if (this._nud_shutdowntime == null)
          return;
        this._nud_shutdowntime.TextChanged += eventHandler;
      }
    }

    internal virtual Label lbl_hotkey
    {
      [DebuggerNonUserCode] get
      {
        return this._lbl_hotkey;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lbl_hotkey = value;
      }
    }

    internal virtual TextBox txtbx_hotkey
    {
      [DebuggerNonUserCode] get
      {
        return this._txtbx_hotkey;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.inputTextbox_TextChanged);
        EventHandler eventHandler2 = new EventHandler(this.txtbx_hotkey_Leave);
        EventHandler eventHandler3 = new EventHandler(this.txtbx_hotkey_Click);
        EventHandler eventHandler4 = new EventHandler(this.txtbx_hotkey_Click);
        KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtbx_hotkey_KeyDown);
        if (this._txtbx_hotkey != null)
        {
          this._txtbx_hotkey.TextChanged -= eventHandler1;
          this._txtbx_hotkey.Leave -= eventHandler2;
          this._txtbx_hotkey.GotFocus -= eventHandler3;
          this._txtbx_hotkey.Click -= eventHandler4;
          this._txtbx_hotkey.KeyDown -= keyEventHandler;
        }
        this._txtbx_hotkey = value;
        if (this._txtbx_hotkey == null)
          return;
        this._txtbx_hotkey.TextChanged += eventHandler1;
        this._txtbx_hotkey.Leave += eventHandler2;
        this._txtbx_hotkey.GotFocus += eventHandler3;
        this._txtbx_hotkey.Click += eventHandler4;
        this._txtbx_hotkey.KeyDown += keyEventHandler;
      }
    }

    internal virtual Label lbl_pass
    {
      [DebuggerNonUserCode] get
      {
        return this._lbl_pass;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lbl_pass = value;
      }
    }

    internal virtual TextBox txtbx_pass
    {
      [DebuggerNonUserCode] get
      {
        return this._txtbx_pass;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.inputTextbox_TextChanged);
        if (this._txtbx_pass != null)
          this._txtbx_pass.TextChanged -= eventHandler;
        this._txtbx_pass = value;
        if (this._txtbx_pass == null)
          return;
        this._txtbx_pass.TextChanged += eventHandler;
      }
    }

    internal virtual Label lbl_email
    {
      [DebuggerNonUserCode] get
      {
        return this._lbl_email;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lbl_email = value;
      }
    }

    internal virtual TextBox txtbx_email
    {
      [DebuggerNonUserCode] get
      {
        return this._txtbx_email;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.inputTextbox_TextChanged);
        if (this._txtbx_email != null)
          this._txtbx_email.TextChanged -= eventHandler;
        this._txtbx_email = value;
        if (this._txtbx_email == null)
          return;
        this._txtbx_email.TextChanged += eventHandler;
      }
    }

    internal virtual Button btn_install
    {
      [DebuggerNonUserCode] get
      {
        return this._btn_install;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btn_install_Click);
        if (this._btn_install != null)
          this._btn_install.Click -= eventHandler;
        this._btn_install = value;
        if (this._btn_install == null)
          return;
        this._btn_install.Click += eventHandler;
      }
    }

    internal virtual StatusStrip StatusStrip1
    {
      [DebuggerNonUserCode] get
      {
        return this._StatusStrip1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._StatusStrip1 = value;
      }
    }

    private virtual SerialPort sComPort
    {
      [DebuggerNonUserCode] get
      {
        return this._sComPort;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        SerialDataReceivedEventHandler receivedEventHandler = new SerialDataReceivedEventHandler(this.sComPort_DataReceived);
        if (this._sComPort != null)
          this._sComPort.DataReceived -= receivedEventHandler;
        this._sComPort = value;
        if (this._sComPort == null)
          return;
        this._sComPort.DataReceived += receivedEventHandler;
      }
    }

    private virtual BackgroundWorker worker
    {
      [DebuggerNonUserCode] get
      {
        return this._worker;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.worker_DoWork);
        if (this._worker != null)
          this._worker.DoWork -= workEventHandler;
        this._worker = value;
        if (this._worker == null)
          return;
        this._worker.DoWork += workEventHandler;
      }
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      if (e.CloseReason == CloseReason.UserClosing && this.WORKING)
      {
        e.Cancel = true;
        this.labelStatus.Text = "Permorming a background operation...";
      }
      base.OnFormClosing(e);
    }

    private void form_installer_Load(object sender, EventArgs e)
    {
      this.sComPort = new SerialPort();
      coinappMods.serviceControllers = ServiceController.GetServices();
      this.labelStatus = new ToolStripStatusLabel();
      this.StatusStrip1.Items.Add((ToolStripItem) this.labelStatus);
      this.worker = new BackgroundWorker();
      this.worker.RunWorkerAsync((object) "onLoad");
    }

    private void worker_DoWork(object sender, DoWorkEventArgs e)
    {
      this.WORKING = true;
      string Left = Conversions.ToString(e.Argument);

	  //TODO: first condition 
      if (Operators.CompareString(Left, "onLoad", false) == 0)
      {
        try
        {
          this.xport = coinappMods.device.Port();
          this.xname = coinappMods.device.Name();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Exception exception = ex;
          this.labelStatus.Text = "Error: retrieving device information";
          this.WORKING = false;
          int num;
          this.Invoke((Delegate) (() => num = (int) Interaction.MsgBox((object) exception.Message, MsgBoxStyle.Critical, (object) null)));
          ProjectData.ClearProjectError();
          return;
        }
        if (Operators.CompareString(this.xport, "", false) != 0)
        {
          this.labelStatus.Text = "Testing " + this.xname + " ...";
          try
          {
            this.sComPort.BaudRate = 9600;
            this.sComPort.PortName = this.xport;
            this.sComPort.DtrEnable = true;
            this.sComPort.Open();
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            Exception exception = ex;
            this.labelStatus.Text = "Error: cannot open the device port.";
            this.WORKING = false;
            int num;
            this.Invoke((Delegate) (() => num = (int) Interaction.MsgBox((object) exception.Message, MsgBoxStyle.Critical, (object) null)));
            ProjectData.ClearProjectError();
            return;
          }
          if (this.sComPort.IsOpen)
          {
            Thread.Sleep(3000);
            this.sComPort.Write("REQDEVID;");
            Thread.Sleep(1000);
            if (coinappMods.deviceIsReady)
            {
              this.labelStatus.Text = "Device tested successfully.";
              this.Invoke((Delegate) (() => this.cb_device.Items.Add((object) this.xname)));
              this.Invoke((Delegate) (() => this.cb_device.SelectedIndex = 0));
              this.Invoke((Delegate) (() => this.ComponentsEnabled(true)));
              SystemSounds.Asterisk.Play();
              this.WORKING = false;
              Thread.Sleep(7000);
              this.labelStatus.Text = "Input a valid data to enable the INSTALL button.";
            }
            else
            {
              this.labelStatus.Text = "Error: device is not compatible.";
              this.WORKING = false;
              int num1;
              this.Invoke((Delegate) (() => num1 = (int) Interaction.MsgBox((object) "Error: device is not compatible.", MsgBoxStyle.Critical, (object) null)));
              try
              {
                this.sComPort.Close();
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                Exception exception = ex;
                this.labelStatus.Text = "Error: cannot close the device port.";
                int num2;
                this.Invoke((Delegate) (() => num2 = (int) Interaction.MsgBox((object) exception.Message, MsgBoxStyle.Critical, (object) null)));
                ProjectData.ClearProjectError();
              }
            }
          }
          else
          {
            this.labelStatus.Text = "Error: cannot open the device port.";
            this.WORKING = false;
            int num;
            this.Invoke((Delegate) (() => num = (int) Interaction.MsgBox((object) "Error: cannot open the device port.", MsgBoxStyle.Critical, (object) null)));
          }
        }
        else
        {
          this.labelStatus.Text = "Error: no device detected. Setup cannot continue";
          this.WORKING = false;
          int num;
          this.Invoke((Delegate) (() => num = (int) Interaction.MsgBox((object) "Error: no device detected. Setup cannot continue", MsgBoxStyle.Critical, (object) null)));
        }
      }

	  // TODO: Second condition
      else if (Operators.CompareString(Left, "install", false) == 0)
      {
        this.labelStatus.Text = "Installing the Coinapp service. Please wait...";
        this.Invoke((Delegate) (() => this.InstallService()));
        this.labelStatus.Text = "Installing Coinapp...";
        if (coinappMods.settings.configExist())
        {
          try
          {
            File.Delete(coinappMods.settings.configFile);
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            Exception exception = ex;
            this.labelStatus.Text = "Error: cannot delete configuration file.";
            this.WORKING = false;
            int num;
            this.Invoke((Delegate) (() => num = (int) Interaction.MsgBox((object) exception.Message, MsgBoxStyle.Critical, (object) null)));
            ProjectData.ClearProjectError();
            return;
          }
          try
          {
            coinappMods.settings.createConfigFile();
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            Exception exception = ex;
            this.labelStatus.Text = "Error: cannot create configuration file.";
            this.WORKING = false;
            int num;
            this.Invoke((Delegate) (() => num = (int) Interaction.MsgBox((object) exception.Message, MsgBoxStyle.Critical, (object) null)));
            ProjectData.ClearProjectError();
            return;
          }
        }
        try
        {
          coinappMods.settings.setPort(this.xport);
          coinappMods.settings.setBaud(9600);
          coinappMods.settings.setCoin1(this.nud_second1.Text, this.nud_pulse1.Text);
          coinappMods.settings.setShutdown(this.nud_shutdowntime.Text);
          coinappMods.settings.setKeycode(this.keycode);
          this.Invoke((Delegate) (() => this.configureCointype()));
          coinappMods.settings.writeSystemFile(coinappMods.enc.GetMd5Hash("password"), coinappMods.enc.Encrypt(this.txtbx_pass.Text, "password"));
          coinappMods.settings.writeSystemFile(coinappMods.enc.GetMd5Hash("email"), coinappMods.enc.Encrypt(this.txtbx_email.Text, "email"));
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Exception exception = ex;
          this.labelStatus.Text = "Error creating system configuration file.";
          this.WORKING = false;
          int num;
          this.Invoke((Delegate) (() => num = (int) Interaction.MsgBox((object) exception.Message, MsgBoxStyle.Critical, (object) null)));
          ProjectData.ClearProjectError();
          return;
        }
        this.labelStatus.Text = "Successfully installed.";
        this.WORKING = false;
        int num1;
        this.Invoke((Delegate) (() => num1 = (int) MessageBox.Show("Coinapp successfully installed. Please restart the PC.", "Coinapp Installer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)));
        DialogResult dialogResult;
        this.Invoke((Delegate) (() => dialogResult = MessageBox.Show("Do you want to restart the PC NOW?\r\nCAUTION: Save your work first before clicking yes.", "Coinapp Installer", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)));
        if (dialogResult == DialogResult.OK)
        {
          this.labelStatus.Text = "Restarting PC please wait...";
          this.btn_install.Enabled = false;
          this.WORKING = false;
          coinappMods.shutdown.Restart();
        }
        else
        {
          int num2;
          this.Invoke((Delegate) (() => num2 = (int) MessageBox.Show("You need to restart the PC.", "Coinapp Installer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)));
          Environment.Exit(0);
        }
      }


	  // TODO: 3rd condition
      else if (Operators.CompareString(Left, "uninstall", false) == 0)
      {
        this.labelStatus.Text = "Uninstalling coinapp service...";
        this.Invoke((Delegate) (() => this.UninstallService()));
        this.worker = new BackgroundWorker();
        this.worker.RunWorkerAsync((object) "install");
      }
      else
        this.WORKING = false;
      this.WORKING = false;
    }

    private void configureCointype()
    {
      switch (this.cb_cointype.SelectedIndex)
      {
        case 0:
          coinappMods.settings.setAcceptor(checked (this.cb_cointype.SelectedIndex + 1));
          coinappMods.settings.setCoin2("0", "0");
          coinappMods.settings.setCoin3("0", "0");
          break;
        case 1:
          coinappMods.settings.setAcceptor(checked (this.cb_cointype.SelectedIndex + 1));
          coinappMods.settings.setCoin2(this.nud_second2.Text, this.nud_pulse2.Text);
          coinappMods.settings.setCoin3("0", "0");
          break;
        case 2:
          coinappMods.settings.setAcceptor(checked (this.cb_cointype.SelectedIndex + 1));
          coinappMods.settings.setCoin2(this.nud_second2.Text, this.nud_pulse2.Text);
          coinappMods.settings.setCoin3(this.nud_second3.Text, this.nud_pulse3.Text);
          break;
        default:
          this.labelStatus.Text = "Error occured while saving.";
          break;
      }
    }

    private void ComponentsEnabled(bool @bool)
    {
      this.cb_device.Enabled = @bool;
      this.cb_cointype.Enabled = @bool;
      this.nud_shutdowntime.Enabled = @bool;
      this.txtbx_hotkey.Enabled = @bool;
      this.txtbx_pass.Enabled = @bool;
      this.txtbx_email.Enabled = @bool;
    }

    private void cb_cointype_SelectedIndexChanged(object sender, EventArgs e)
    {
      switch (this.cb_cointype.SelectedIndex)
      {
        case 0:
          this.gb_coin1.Enabled = true;
          this.gb_coin2.Enabled = false;
          this.gb_coin3.Enabled = false;
          break;
        case 1:
          this.gb_coin1.Enabled = true;
          this.gb_coin2.Enabled = true;
          this.gb_coin3.Enabled = false;
          break;
        case 2:
          this.gb_coin1.Enabled = true;
          this.gb_coin2.Enabled = true;
          this.gb_coin3.Enabled = true;
          break;
        default:
          this.gb_coin1.Enabled = false;
          this.gb_coin2.Enabled = false;
          this.gb_coin3.Enabled = false;
          break;
      }
    }

    private void inputTextbox_TextChanged(object sender, EventArgs e)
    {
      if (Operators.CompareString(Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "Text", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), "0", false) != 0 && Operators.CompareString(Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "Text", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), "", false) != 0)
        this.ValidInputBox();
      else if (sender == this.txtbx_hotkey)
      {
        this.ValidInputBox();
      }
      else
      {
        this.labelStatus.Text = "Input a valid data to enable the INSTALL button.";
        this.btn_install.Enabled = false;
      }
    }

    private void ValidInputBox()
    {
      if (Operators.CompareString(this.nud_shutdowntime.Text, "0", false) != 0 && Operators.CompareString(this.nud_shutdowntime.Text, "", false) != 0 && (Operators.CompareString(Conversions.ToString(this.nud_shutdowntime.Text.First<char>()), "0", false) != 0 && this.nud_shutdowntime.Text.Count<char>() != 1) && (Operators.CompareString(this.txtbx_pass.Text, "", false) != 0 && Operators.CompareString(this.txtbx_email.Text, "", false) != 0 && (Operators.CompareString(this.txtbx_hotkey.Text, "", false) != 0 && Operators.CompareString(this.txtbx_hotkey.Text, "click to set", false) != 0)) && (Operators.CompareString(this.txtbx_hotkey.Text, "press a key", false) != 0 && coinappMods.isValidEmail(this.txtbx_email.Text)))
      {
        if (this.cb_cointype.SelectedIndex == 0)
        {
          if (Operators.CompareString(this.nud_second1.Text, "0", false) != 0 && Operators.CompareString(this.nud_second1.Text, "", false) != 0 && (Operators.CompareString(this.nud_pulse1.Text, "0", false) != 0 && Operators.CompareString(this.nud_pulse1.Text, "", false) != 0))
          {
            this.labelStatus.Text = "Ready to install";
            this.btn_install.Enabled = true;
          }
          else
          {
            this.labelStatus.Text = "Input a valid data to enable the INSTALL button.";
            this.btn_install.Enabled = false;
          }
        }
        else if (this.cb_cointype.SelectedIndex == 1)
        {
          if (Operators.CompareString(this.nud_second1.Text, "0", false) != 0 && Operators.CompareString(this.nud_second1.Text, "", false) != 0 && (Operators.CompareString(this.nud_pulse1.Text, "0", false) != 0 && Operators.CompareString(this.nud_pulse1.Text, "", false) != 0) && (Operators.CompareString(this.nud_second2.Text, "0", false) != 0 && Operators.CompareString(this.nud_second2.Text, "", false) != 0 && (Operators.CompareString(this.nud_pulse2.Text, "0", false) != 0 && Operators.CompareString(this.nud_pulse2.Text, "", false) != 0)))
          {
            this.labelStatus.Text = "Ready to install";
            this.btn_install.Enabled = true;
          }
          else
          {
            this.labelStatus.Text = "Input a valid data to enable the INSTALL button.";
            this.btn_install.Enabled = false;
          }
        }
        else if (this.cb_cointype.SelectedIndex == 2)
        {
          if (Operators.CompareString(this.nud_second1.Text, "0", false) != 0 && Operators.CompareString(this.nud_second1.Text, "", false) != 0 && (Operators.CompareString(this.nud_pulse1.Text, "0", false) != 0 && Operators.CompareString(this.nud_pulse1.Text, "", false) != 0) && (Operators.CompareString(this.nud_second2.Text, "0", false) != 0 && Operators.CompareString(this.nud_second2.Text, "", false) != 0 && (Operators.CompareString(this.nud_pulse2.Text, "0", false) != 0 && Operators.CompareString(this.nud_pulse2.Text, "", false) != 0)) && (Operators.CompareString(this.nud_second3.Text, "0", false) != 0 && Operators.CompareString(this.nud_second3.Text, "", false) != 0 && (Operators.CompareString(this.nud_pulse3.Text, "0", false) != 0 && Operators.CompareString(this.nud_pulse3.Text, "", false) != 0)))
          {
            this.labelStatus.Text = "Ready to install";
            this.btn_install.Enabled = true;
          }
          else
          {
            this.labelStatus.Text = "Input a valid data to enable the INSTALL button.";
            this.btn_install.Enabled = false;
          }
        }
        else
        {
          this.labelStatus.Text = "Input a valid data to enable the INSTALL button.";
          this.btn_install.Enabled = false;
        }
      }
      else
      {
        this.labelStatus.Text = "Input a valid data to enable the INSTALL button.";
        this.btn_install.Enabled = false;
      }
    }

    private void txtbx_hotkey_KeyDown(object sender, KeyEventArgs e)
    {
      if ((e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9) && (e.KeyCode != Keys.Decimal && e.KeyCode != Keys.Pause) && (e.KeyCode != Keys.Tab && e.KeyCode != Keys.LWin && e.KeyCode != Keys.RWin) && (e.KeyCode < Keys.ShiftKey || e.KeyCode > Keys.Menu))
      {
        this.keycode = (int) e.KeyCode;
        this.keycodeString = coinappMods.hotkey.GetKeypressed((int) e.KeyCode);
        this.txtbx_hotkey.Text = this.keycodeString;
      }
      else
      {
        e.Handled = true;
        SystemSounds.Beep.Play();
      }
    }

    private void txtbx_hotkey_Click(object sender, EventArgs e)
    {
      this.txtbx_hotkey.Text = "press a key";
    }

    private void txtbx_hotkey_Leave(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.keycodeString, "", false) == 0)
        this.txtbx_hotkey.Text = "click to set";
      else
        this.txtbx_hotkey.Text = this.keycodeString;
    }

    private void btn_install_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Install COINAPP with this configuration?\r\nCAUTION: Don't forget your password.", "Coinapp Installer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
        return;
      this.ComponentsEnabled(false);
      this.gb_coin1.Enabled = false;
      this.gb_coin2.Enabled = false;
      this.gb_coin3.Enabled = false;
      this.btn_install.Enabled = false;
      coinappMods.serviceExist = ((IEnumerable<ServiceController>) coinappMods.serviceControllers).Any<ServiceController>((Func<ServiceController, bool>) (x => Operators.CompareString(x.ServiceName, coinappMods.serviceName, false) == 0));
      if (!coinappMods.serviceExist)
      {
        if (File.Exists(Application.StartupPath + "\\svcca.exe"))
        {
          this.worker = new BackgroundWorker();
          this.worker.RunWorkerAsync((object) "install");
        }
        else
          this.labelStatus.Text = "Error: file missing on Coinapp files.";
      }
      else
      {
        this.worker = new BackgroundWorker();
        this.worker.RunWorkerAsync((object) "uninstall");
      }
    }

    private void InstallService()
    {
      Process.Start(new ProcessStartInfo()
      {
        FileName = "svcca.exe",
        Arguments = "-install /silent",
        UseShellExecute = false,
        WindowStyle = ProcessWindowStyle.Normal
      }).WaitForExit();
    }

    public void UninstallService()
    {
      Process.Start(new ProcessStartInfo()
      {
        FileName = "svcca.exe",
        Arguments = "-uninstall /silent",
        UseShellExecute = false,
        WindowStyle = ProcessWindowStyle.Normal
      }).WaitForExit();
    }

    private void sComPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
      string Left = this.sComPort.ReadTo(",");
      if (Operators.CompareString(Left, "READY", false) == 0)
        coinappMods.deviceIsReady = true;
      if (Operators.CompareString(Left, "REQDEVID", false) != 0)
        return;
      coinappMods.sID = this.sComPort.ReadTo(",");
      if (coinappMods.isValidID(coinappMods.sID))
        this.sComPort.Write(coinappMods.sID + ";");
      else
        coinappMods.sID = (string) null;
    }

    private delegate void MyDelegate();
  }
}
