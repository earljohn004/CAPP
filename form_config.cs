// Decompiled with JetBrains decompiler
// Type: coinapp.form_config
// Assembly: coinapp, Version=1.4.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6DB842CC-5810-43FB-8044-475700CA1E42
// Assembly location: C:\Users\EarlJohn\Desktop\Coinapp\coinapp_1.4.0.0\coinapp.exe

using ADOX;
using coinapp.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.ServiceProcess;
using System.Threading;
using System.Windows.Forms;

namespace coinapp
{
  [DesignerGenerated]
  public class form_config : Form
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private IContainer components;
    [AccessedThroughProperty("cb_device")]
    private ComboBox _cb_device;
    [AccessedThroughProperty("btn_device")]
    private Button _btn_device;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("TabControl1")]
    private TabControl _TabControl1;
    [AccessedThroughProperty("TabPage1")]
    private TabPage _TabPage1;
    [AccessedThroughProperty("TabPage2")]
    private TabPage _TabPage2;
    [AccessedThroughProperty("btn_save")]
    private Button _btn_save;
    [AccessedThroughProperty("cb_cointype")]
    private ComboBox _cb_cointype;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("StatusStrip1")]
    private StatusStrip _StatusStrip1;
    [AccessedThroughProperty("nud_second1")]
    private NumericUpDown _nud_second1;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("nud_pulse1")]
    private NumericUpDown _nud_pulse1;
    [AccessedThroughProperty("Label4")]
    private Label _Label4;
    [AccessedThroughProperty("gb_coin1")]
    private GroupBox _gb_coin1;
    [AccessedThroughProperty("gb_windows")]
    private GroupBox _gb_windows;
    [AccessedThroughProperty("nud_shutdowntime")]
    private NumericUpDown _nud_shutdowntime;
    [AccessedThroughProperty("Label12")]
    private Label _Label12;
    [AccessedThroughProperty("nud_logretry")]
    private NumericUpDown _nud_logretry;
    [AccessedThroughProperty("Label13")]
    private Label _Label13;
    [AccessedThroughProperty("Label14")]
    private Label _Label14;
    [AccessedThroughProperty("txtbx_hotkey")]
    private TextBox _txtbx_hotkey;
    [AccessedThroughProperty("chkbx_taskmgr")]
    private CheckBox _chkbx_taskmgr;
    [AccessedThroughProperty("gb_pass")]
    private GroupBox _gb_pass;
    [AccessedThroughProperty("txtbx_retype")]
    private TextBox _txtbx_retype;
    [AccessedThroughProperty("txtbx_new")]
    private TextBox _txtbx_new;
    [AccessedThroughProperty("txtbx_old")]
    private TextBox _txtbx_old;
    [AccessedThroughProperty("Label17")]
    private Label _Label17;
    [AccessedThroughProperty("Label16")]
    private Label _Label16;
    [AccessedThroughProperty("Label15")]
    private Label _Label15;
    [AccessedThroughProperty("btn_pass")]
    private Button _btn_pass;
    [AccessedThroughProperty("gb_email")]
    private GroupBox _gb_email;
    [AccessedThroughProperty("btn_email")]
    private Button _btn_email;
    [AccessedThroughProperty("txtbx_email")]
    private TextBox _txtbx_email;
    [AccessedThroughProperty("lbl_email")]
    private Label _lbl_email;
    [AccessedThroughProperty("btn_close")]
    private Button _btn_close;
    [AccessedThroughProperty("gb_coin5")]
    private GroupBox _gb_coin5;
    [AccessedThroughProperty("nud_second5")]
    private NumericUpDown _nud_second5;
    [AccessedThroughProperty("nud_pulse5")]
    private NumericUpDown _nud_pulse5;
    [AccessedThroughProperty("Label11")]
    private Label _Label11;
    [AccessedThroughProperty("Label19")]
    private Label _Label19;
    [AccessedThroughProperty("gb_coin4")]
    private GroupBox _gb_coin4;
    [AccessedThroughProperty("nud_second4")]
    private NumericUpDown _nud_second4;
    [AccessedThroughProperty("nud_pulse4")]
    private NumericUpDown _nud_pulse4;
    [AccessedThroughProperty("Label9")]
    private Label _Label9;
    [AccessedThroughProperty("Label10")]
    private Label _Label10;
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
    [AccessedThroughProperty("gb_coin6")]
    private GroupBox _gb_coin6;
    [AccessedThroughProperty("nud_second6")]
    private NumericUpDown _nud_second6;
    [AccessedThroughProperty("nud_pulse6")]
    private NumericUpDown _nud_pulse6;
    [AccessedThroughProperty("Label20")]
    private Label _Label20;
    [AccessedThroughProperty("Label21")]
    private Label _Label21;
    [AccessedThroughProperty("gb_bg")]
    private GroupBox _gb_bg;
    [AccessedThroughProperty("btn_restart")]
    private Button _btn_restart;
    [AccessedThroughProperty("txtbx_bgready")]
    private TextBox _txtbx_bgready;
    [AccessedThroughProperty("btn_bgready")]
    private Button _btn_bgready;
    [AccessedThroughProperty("label_bg")]
    private Label _label_bg;
    [AccessedThroughProperty("Label18")]
    private Label _Label18;
    [AccessedThroughProperty("txtbx_bgerror")]
    private TextBox _txtbx_bgerror;
    [AccessedThroughProperty("btn_bgerror")]
    private Button _btn_bgerror;
    [AccessedThroughProperty("TabPage3")]
    private TabPage _TabPage3;
    [AccessedThroughProperty("nud_pause")]
    private NumericUpDown _nud_pause;
    [AccessedThroughProperty("GroupBox1")]
    private GroupBox _GroupBox1;
    [AccessedThroughProperty("lbl_pause")]
    private Label _lbl_pause;
    [AccessedThroughProperty("chkbx_savedata")]
    private CheckBox _chkbx_savedata;
    [AccessedThroughProperty("gb_accounts")]
    private GroupBox _gb_accounts;
    [AccessedThroughProperty("txtbx_savedata")]
    private TextBox _txtbx_savedata;
    [AccessedThroughProperty("btn_savedata")]
    private Button _btn_savedata;
    [AccessedThroughProperty("gb_vouchers")]
    private GroupBox _gb_vouchers;
    [AccessedThroughProperty("chkbx_voucher")]
    private CheckBox _chkbx_voucher;
    [AccessedThroughProperty("chkbx_account")]
    private CheckBox _chkbx_account;
    [AccessedThroughProperty("gb_dbVoucher")]
    private GroupBox _gb_dbVoucher;
    [AccessedThroughProperty("Label23")]
    private Label _Label23;
    [AccessedThroughProperty("Label22")]
    private Label _Label22;
    [AccessedThroughProperty("txtbx_dbVoucherPass")]
    private TextBox _txtbx_dbVoucherPass;
    [AccessedThroughProperty("txtbx_dbVoucherName")]
    private TextBox _txtbx_dbVoucherName;
    [AccessedThroughProperty("btn_vouchers")]
    private Button _btn_vouchers;
    [AccessedThroughProperty("gb_dbAccount")]
    private GroupBox _gb_dbAccount;
    [AccessedThroughProperty("btn_accounts")]
    private Button _btn_accounts;
    [AccessedThroughProperty("txtbx_dbAccountPass")]
    private TextBox _txtbx_dbAccountPass;
    [AccessedThroughProperty("txtbx_dbAccountName")]
    private TextBox _txtbx_dbAccountName;
    [AccessedThroughProperty("Label24")]
    private Label _Label24;
    [AccessedThroughProperty("Label25")]
    private Label _Label25;
    private bool passExists;
    private bool emailExists;
    private string pass;
    private string email;
    private string keycodeString;
    private int keycode;
    private int previousKeycode;
    private string xport;
    private string xname;
    private Bitmap bgImageReady;
    private Bitmap bgImageError;
    private bool exitapp;
    private bool working;
    private ToolStripStatusLabel labelStatus;
    [AccessedThroughProperty("worker")]
    private BackgroundWorker _worker;

    [DebuggerNonUserCode]
    static form_config()
    {
    }

    public form_config()
    {
      this.Load += new EventHandler(this.form_config_Load);
      form_config.__ENCAddToList((object) this);
      this.passExists = coinappMods.settings.XconfigExist(coinappMods.enc.GetMd5Hash("password"));
      this.emailExists = coinappMods.settings.XconfigExist(coinappMods.enc.GetMd5Hash(nameof (email)));
      this.bgImageReady = (Bitmap) null;
      this.bgImageError = (Bitmap) null;
      this.labelStatus = (ToolStripStatusLabel) null;
      this.worker = (BackgroundWorker) null;
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (form_config.__ENCList)
      {
        if (form_config.__ENCList.Count == form_config.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (form_config.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (form_config.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                form_config.__ENCList[index1] = form_config.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          form_config.__ENCList.RemoveRange(index1, checked (form_config.__ENCList.Count - index1));
          form_config.__ENCList.Capacity = form_config.__ENCList.Count;
        }
        form_config.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (form_config));
      this.cb_device = new ComboBox();
      this.btn_device = new Button();
      this.Label1 = new Label();
      this.TabControl1 = new TabControl();
      this.TabPage1 = new TabPage();
      this.gb_coin6 = new GroupBox();
      this.nud_second6 = new NumericUpDown();
      this.nud_pulse6 = new NumericUpDown();
      this.Label20 = new Label();
      this.Label21 = new Label();
      this.gb_coin5 = new GroupBox();
      this.nud_second5 = new NumericUpDown();
      this.nud_pulse5 = new NumericUpDown();
      this.Label11 = new Label();
      this.Label19 = new Label();
      this.gb_coin4 = new GroupBox();
      this.nud_second4 = new NumericUpDown();
      this.nud_pulse4 = new NumericUpDown();
      this.Label9 = new Label();
      this.Label10 = new Label();
      this.gb_coin3 = new GroupBox();
      this.nud_second3 = new NumericUpDown();
      this.nud_pulse3 = new NumericUpDown();
      this.Label7 = new Label();
      this.Label8 = new Label();
      this.gb_coin2 = new GroupBox();
      this.nud_second2 = new NumericUpDown();
      this.nud_pulse2 = new NumericUpDown();
      this.Label5 = new Label();
      this.Label6 = new Label();
      this.gb_coin1 = new GroupBox();
      this.nud_second1 = new NumericUpDown();
      this.nud_pulse1 = new NumericUpDown();
      this.Label3 = new Label();
      this.Label4 = new Label();
      this.cb_cointype = new ComboBox();
      this.Label2 = new Label();
      this.TabPage2 = new TabPage();
      this.gb_bg = new GroupBox();
      this.Label18 = new Label();
      this.label_bg = new Label();
      this.txtbx_bgerror = new TextBox();
      this.btn_bgerror = new Button();
      this.txtbx_bgready = new TextBox();
      this.btn_bgready = new Button();
      this.gb_email = new GroupBox();
      this.lbl_email = new Label();
      this.btn_email = new Button();
      this.txtbx_email = new TextBox();
      this.gb_pass = new GroupBox();
      this.txtbx_retype = new TextBox();
      this.txtbx_new = new TextBox();
      this.txtbx_old = new TextBox();
      this.Label17 = new Label();
      this.Label16 = new Label();
      this.btn_pass = new Button();
      this.Label15 = new Label();
      this.gb_windows = new GroupBox();
      this.lbl_pause = new Label();
      this.txtbx_hotkey = new TextBox();
      this.nud_logretry = new NumericUpDown();
      this.nud_pause = new NumericUpDown();
      this.nud_shutdowntime = new NumericUpDown();
      this.Label14 = new Label();
      this.Label13 = new Label();
      this.Label12 = new Label();
      this.chkbx_taskmgr = new CheckBox();
      this.TabPage3 = new TabPage();
      this.GroupBox1 = new GroupBox();
      this.btn_savedata = new Button();
      this.txtbx_savedata = new TextBox();
      this.gb_vouchers = new GroupBox();
      this.gb_dbVoucher = new GroupBox();
      this.btn_vouchers = new Button();
      this.txtbx_dbVoucherPass = new TextBox();
      this.txtbx_dbVoucherName = new TextBox();
      this.Label23 = new Label();
      this.Label22 = new Label();
      this.chkbx_voucher = new CheckBox();
      this.gb_accounts = new GroupBox();
      this.gb_dbAccount = new GroupBox();
      this.btn_accounts = new Button();
      this.txtbx_dbAccountPass = new TextBox();
      this.txtbx_dbAccountName = new TextBox();
      this.Label24 = new Label();
      this.Label25 = new Label();
      this.chkbx_account = new CheckBox();
      this.chkbx_savedata = new CheckBox();
      this.btn_close = new Button();
      this.btn_save = new Button();
      this.StatusStrip1 = new StatusStrip();
      this.btn_restart = new Button();
      this.TabControl1.SuspendLayout();
      this.TabPage1.SuspendLayout();
      this.gb_coin6.SuspendLayout();
      this.nud_second6.BeginInit();
      this.nud_pulse6.BeginInit();
      this.gb_coin5.SuspendLayout();
      this.nud_second5.BeginInit();
      this.nud_pulse5.BeginInit();
      this.gb_coin4.SuspendLayout();
      this.nud_second4.BeginInit();
      this.nud_pulse4.BeginInit();
      this.gb_coin3.SuspendLayout();
      this.nud_second3.BeginInit();
      this.nud_pulse3.BeginInit();
      this.gb_coin2.SuspendLayout();
      this.nud_second2.BeginInit();
      this.nud_pulse2.BeginInit();
      this.gb_coin1.SuspendLayout();
      this.nud_second1.BeginInit();
      this.nud_pulse1.BeginInit();
      this.TabPage2.SuspendLayout();
      this.gb_bg.SuspendLayout();
      this.gb_email.SuspendLayout();
      this.gb_pass.SuspendLayout();
      this.gb_windows.SuspendLayout();
      this.nud_logretry.BeginInit();
      this.nud_pause.BeginInit();
      this.nud_shutdowntime.BeginInit();
      this.TabPage3.SuspendLayout();
      this.GroupBox1.SuspendLayout();
      this.gb_vouchers.SuspendLayout();
      this.gb_dbVoucher.SuspendLayout();
      this.gb_accounts.SuspendLayout();
      this.gb_dbAccount.SuspendLayout();
      this.SuspendLayout();
      this.cb_device.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cb_device.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cb_device.FormattingEnabled = true;
      ComboBox cbDevice1 = this.cb_device;
      Point point1 = new Point(15, 26);
      Point point2 = point1;
      cbDevice1.Location = point2;
      this.cb_device.Name = "cb_device";
      ComboBox cbDevice2 = this.cb_device;
      Size size1 = new Size(226, 23);
      Size size2 = size1;
      cbDevice2.Size = size2;
      this.cb_device.TabIndex = 0;
      this.cb_device.TabStop = false;
      this.btn_device.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Button btnDevice1 = this.btn_device;
      point1 = new Point(247, 25);
      Point point3 = point1;
      btnDevice1.Location = point3;
      this.btn_device.Name = "btn_device";
      Button btnDevice2 = this.btn_device;
      size1 = new Size(93, 25);
      Size size3 = size1;
      btnDevice2.Size = size3;
      this.btn_device.TabIndex = 1;
      this.btn_device.TabStop = false;
      this.btn_device.Text = "Disconnected";
      this.btn_device.UseVisualStyleBackColor = true;
      this.Label1.AutoSize = true;
      Label label1_1 = this.Label1;
      point1 = new Point(13, 7);
      Point point4 = point1;
      label1_1.Location = point4;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(41, 13);
      Size size4 = size1;
      label1_2.Size = size4;
      this.Label1.TabIndex = 2;
      this.Label1.Text = "Device";
      this.TabControl1.Controls.Add((Control) this.TabPage1);
      this.TabControl1.Controls.Add((Control) this.TabPage2);
      this.TabControl1.Controls.Add((Control) this.TabPage3);
      TabControl tabControl1_1 = this.TabControl1;
      point1 = new Point(12, 56);
      Point point5 = point1;
      tabControl1_1.Location = point5;
      this.TabControl1.Name = "TabControl1";
      this.TabControl1.SelectedIndex = 0;
      TabControl tabControl1_2 = this.TabControl1;
      size1 = new Size(453, 331);
      Size size5 = size1;
      tabControl1_2.Size = size5;
      this.TabControl1.TabIndex = 2;
      this.TabControl1.TabStop = false;
      this.TabPage1.Controls.Add((Control) this.gb_coin6);
      this.TabPage1.Controls.Add((Control) this.gb_coin5);
      this.TabPage1.Controls.Add((Control) this.gb_coin4);
      this.TabPage1.Controls.Add((Control) this.gb_coin3);
      this.TabPage1.Controls.Add((Control) this.gb_coin2);
      this.TabPage1.Controls.Add((Control) this.gb_coin1);
      this.TabPage1.Controls.Add((Control) this.cb_cointype);
      this.TabPage1.Controls.Add((Control) this.Label2);
      TabPage tabPage1_1 = this.TabPage1;
      point1 = new Point(4, 22);
      Point point6 = point1;
      tabPage1_1.Location = point6;
      this.TabPage1.Name = "TabPage1";
      TabPage tabPage1_2 = this.TabPage1;
      Padding padding1 = new Padding(3);
      Padding padding2 = padding1;
      tabPage1_2.Padding = padding2;
      TabPage tabPage1_3 = this.TabPage1;
      size1 = new Size(445, 305);
      Size size6 = size1;
      tabPage1_3.Size = size6;
      this.TabPage1.TabIndex = 0;
      this.TabPage1.Text = "Device";
      this.TabPage1.UseVisualStyleBackColor = true;
      this.gb_coin6.Controls.Add((Control) this.nud_second6);
      this.gb_coin6.Controls.Add((Control) this.nud_pulse6);
      this.gb_coin6.Controls.Add((Control) this.Label20);
      this.gb_coin6.Controls.Add((Control) this.Label21);
      this.gb_coin6.Enabled = false;
      GroupBox gbCoin6_1 = this.gb_coin6;
      point1 = new Point(17, 253);
      Point point7 = point1;
      gbCoin6_1.Location = point7;
      this.gb_coin6.Name = "gb_coin6";
      GroupBox gbCoin6_2 = this.gb_coin6;
      size1 = new Size(261, 40);
      Size size7 = size1;
      gbCoin6_2.Size = size7;
      this.gb_coin6.TabIndex = 30;
      this.gb_coin6.TabStop = false;
      this.gb_coin6.Text = "Coin 6";
      NumericUpDown nudSecond6_1 = this.nud_second6;
      point1 = new Point(62, 13);
      Point point8 = point1;
      nudSecond6_1.Location = point8;
      NumericUpDown nudSecond6_2 = this.nud_second6;
      Decimal num1 = new Decimal(new int[4]
      {
        9999,
        0,
        0,
        0
      });
      Decimal num2 = num1;
      nudSecond6_2.Maximum = num2;
      this.nud_second6.Name = "nud_second6";
      NumericUpDown nudSecond6_3 = this.nud_second6;
      size1 = new Size(79, 20);
      Size size8 = size1;
      nudSecond6_3.Size = size8;
      this.nud_second6.TabIndex = 32;
      NumericUpDown nudPulse6_1 = this.nud_pulse6;
      point1 = new Point(189, 13);
      Point point9 = point1;
      nudPulse6_1.Location = point9;
      NumericUpDown nudPulse6_2 = this.nud_pulse6;
      num1 = new Decimal(new int[4]{ 99, 0, 0, 0 });
      Decimal num3 = num1;
      nudPulse6_2.Maximum = num3;
      this.nud_pulse6.Name = "nud_pulse6";
      NumericUpDown nudPulse6_3 = this.nud_pulse6;
      size1 = new Size(53, 20);
      Size size9 = size1;
      nudPulse6_3.Size = size9;
      this.nud_pulse6.TabIndex = 34;
      this.Label20.AutoSize = true;
      Label label20_1 = this.Label20;
      point1 = new Point(10, 15);
      Point point10 = point1;
      label20_1.Location = point10;
      this.Label20.Name = "Label20";
      Label label20_2 = this.Label20;
      size1 = new Size(49, 13);
      Size size10 = size1;
      label20_2.Size = size10;
      this.Label20.TabIndex = 31;
      this.Label20.Text = "Seconds";
      this.Label21.AutoSize = true;
      Label label21_1 = this.Label21;
      point1 = new Point(155, 15);
      Point point11 = point1;
      label21_1.Location = point11;
      this.Label21.Name = "Label21";
      Label label21_2 = this.Label21;
      size1 = new Size(33, 13);
      Size size11 = size1;
      label21_2.Size = size11;
      this.Label21.TabIndex = 33;
      this.Label21.Text = "Pulse";
      this.gb_coin5.Controls.Add((Control) this.nud_second5);
      this.gb_coin5.Controls.Add((Control) this.nud_pulse5);
      this.gb_coin5.Controls.Add((Control) this.Label11);
      this.gb_coin5.Controls.Add((Control) this.Label19);
      this.gb_coin5.Enabled = false;
      GroupBox gbCoin5_1 = this.gb_coin5;
      point1 = new Point(17, 211);
      Point point12 = point1;
      gbCoin5_1.Location = point12;
      this.gb_coin5.Name = "gb_coin5";
      GroupBox gbCoin5_2 = this.gb_coin5;
      size1 = new Size(261, 40);
      Size size12 = size1;
      gbCoin5_2.Size = size12;
      this.gb_coin5.TabIndex = 25;
      this.gb_coin5.TabStop = false;
      this.gb_coin5.Text = "Coin 5";
      NumericUpDown nudSecond5_1 = this.nud_second5;
      point1 = new Point(62, 13);
      Point point13 = point1;
      nudSecond5_1.Location = point13;
      NumericUpDown nudSecond5_2 = this.nud_second5;
      num1 = new Decimal(new int[4]{ 9999, 0, 0, 0 });
      Decimal num4 = num1;
      nudSecond5_2.Maximum = num4;
      this.nud_second5.Name = "nud_second5";
      NumericUpDown nudSecond5_3 = this.nud_second5;
      size1 = new Size(79, 20);
      Size size13 = size1;
      nudSecond5_3.Size = size13;
      this.nud_second5.TabIndex = 27;
      NumericUpDown nudPulse5_1 = this.nud_pulse5;
      point1 = new Point(189, 13);
      Point point14 = point1;
      nudPulse5_1.Location = point14;
      NumericUpDown nudPulse5_2 = this.nud_pulse5;
      num1 = new Decimal(new int[4]{ 99, 0, 0, 0 });
      Decimal num5 = num1;
      nudPulse5_2.Maximum = num5;
      this.nud_pulse5.Name = "nud_pulse5";
      NumericUpDown nudPulse5_3 = this.nud_pulse5;
      size1 = new Size(53, 20);
      Size size14 = size1;
      nudPulse5_3.Size = size14;
      this.nud_pulse5.TabIndex = 29;
      this.Label11.AutoSize = true;
      Label label11_1 = this.Label11;
      point1 = new Point(10, 15);
      Point point15 = point1;
      label11_1.Location = point15;
      this.Label11.Name = "Label11";
      Label label11_2 = this.Label11;
      size1 = new Size(49, 13);
      Size size15 = size1;
      label11_2.Size = size15;
      this.Label11.TabIndex = 26;
      this.Label11.Text = "Seconds";
      this.Label19.AutoSize = true;
      Label label19_1 = this.Label19;
      point1 = new Point(155, 15);
      Point point16 = point1;
      label19_1.Location = point16;
      this.Label19.Name = "Label19";
      Label label19_2 = this.Label19;
      size1 = new Size(33, 13);
      Size size16 = size1;
      label19_2.Size = size16;
      this.Label19.TabIndex = 28;
      this.Label19.Text = "Pulse";
      this.gb_coin4.Controls.Add((Control) this.nud_second4);
      this.gb_coin4.Controls.Add((Control) this.nud_pulse4);
      this.gb_coin4.Controls.Add((Control) this.Label9);
      this.gb_coin4.Controls.Add((Control) this.Label10);
      this.gb_coin4.Enabled = false;
      GroupBox gbCoin4_1 = this.gb_coin4;
      point1 = new Point(17, 169);
      Point point17 = point1;
      gbCoin4_1.Location = point17;
      this.gb_coin4.Name = "gb_coin4";
      GroupBox gbCoin4_2 = this.gb_coin4;
      size1 = new Size(261, 40);
      Size size17 = size1;
      gbCoin4_2.Size = size17;
      this.gb_coin4.TabIndex = 20;
      this.gb_coin4.TabStop = false;
      this.gb_coin4.Text = "Coin 4";
      NumericUpDown nudSecond4_1 = this.nud_second4;
      point1 = new Point(62, 13);
      Point point18 = point1;
      nudSecond4_1.Location = point18;
      NumericUpDown nudSecond4_2 = this.nud_second4;
      num1 = new Decimal(new int[4]{ 9999, 0, 0, 0 });
      Decimal num6 = num1;
      nudSecond4_2.Maximum = num6;
      this.nud_second4.Name = "nud_second4";
      NumericUpDown nudSecond4_3 = this.nud_second4;
      size1 = new Size(79, 20);
      Size size18 = size1;
      nudSecond4_3.Size = size18;
      this.nud_second4.TabIndex = 22;
      NumericUpDown nudPulse4_1 = this.nud_pulse4;
      point1 = new Point(189, 13);
      Point point19 = point1;
      nudPulse4_1.Location = point19;
      NumericUpDown nudPulse4_2 = this.nud_pulse4;
      num1 = new Decimal(new int[4]{ 99, 0, 0, 0 });
      Decimal num7 = num1;
      nudPulse4_2.Maximum = num7;
      this.nud_pulse4.Name = "nud_pulse4";
      NumericUpDown nudPulse4_3 = this.nud_pulse4;
      size1 = new Size(53, 20);
      Size size19 = size1;
      nudPulse4_3.Size = size19;
      this.nud_pulse4.TabIndex = 24;
      this.Label9.AutoSize = true;
      Label label9_1 = this.Label9;
      point1 = new Point(10, 15);
      Point point20 = point1;
      label9_1.Location = point20;
      this.Label9.Name = "Label9";
      Label label9_2 = this.Label9;
      size1 = new Size(49, 13);
      Size size20 = size1;
      label9_2.Size = size20;
      this.Label9.TabIndex = 21;
      this.Label9.Text = "Seconds";
      this.Label10.AutoSize = true;
      Label label10_1 = this.Label10;
      point1 = new Point(155, 15);
      Point point21 = point1;
      label10_1.Location = point21;
      this.Label10.Name = "Label10";
      Label label10_2 = this.Label10;
      size1 = new Size(33, 13);
      Size size21 = size1;
      label10_2.Size = size21;
      this.Label10.TabIndex = 23;
      this.Label10.Text = "Pulse";
      this.gb_coin3.Controls.Add((Control) this.nud_second3);
      this.gb_coin3.Controls.Add((Control) this.nud_pulse3);
      this.gb_coin3.Controls.Add((Control) this.Label7);
      this.gb_coin3.Controls.Add((Control) this.Label8);
      this.gb_coin3.Enabled = false;
      GroupBox gbCoin3_1 = this.gb_coin3;
      point1 = new Point(17, (int) sbyte.MaxValue);
      Point point22 = point1;
      gbCoin3_1.Location = point22;
      this.gb_coin3.Name = "gb_coin3";
      GroupBox gbCoin3_2 = this.gb_coin3;
      size1 = new Size(261, 40);
      Size size22 = size1;
      gbCoin3_2.Size = size22;
      this.gb_coin3.TabIndex = 15;
      this.gb_coin3.TabStop = false;
      this.gb_coin3.Text = "Coin 3";
      NumericUpDown nudSecond3_1 = this.nud_second3;
      point1 = new Point(62, 13);
      Point point23 = point1;
      nudSecond3_1.Location = point23;
      NumericUpDown nudSecond3_2 = this.nud_second3;
      num1 = new Decimal(new int[4]{ 9999, 0, 0, 0 });
      Decimal num8 = num1;
      nudSecond3_2.Maximum = num8;
      this.nud_second3.Name = "nud_second3";
      NumericUpDown nudSecond3_3 = this.nud_second3;
      size1 = new Size(79, 20);
      Size size23 = size1;
      nudSecond3_3.Size = size23;
      this.nud_second3.TabIndex = 17;
      NumericUpDown nudPulse3_1 = this.nud_pulse3;
      point1 = new Point(189, 13);
      Point point24 = point1;
      nudPulse3_1.Location = point24;
      NumericUpDown nudPulse3_2 = this.nud_pulse3;
      num1 = new Decimal(new int[4]{ 99, 0, 0, 0 });
      Decimal num9 = num1;
      nudPulse3_2.Maximum = num9;
      this.nud_pulse3.Name = "nud_pulse3";
      NumericUpDown nudPulse3_3 = this.nud_pulse3;
      size1 = new Size(53, 20);
      Size size24 = size1;
      nudPulse3_3.Size = size24;
      this.nud_pulse3.TabIndex = 19;
      this.Label7.AutoSize = true;
      Label label7_1 = this.Label7;
      point1 = new Point(10, 15);
      Point point25 = point1;
      label7_1.Location = point25;
      this.Label7.Name = "Label7";
      Label label7_2 = this.Label7;
      size1 = new Size(49, 13);
      Size size25 = size1;
      label7_2.Size = size25;
      this.Label7.TabIndex = 16;
      this.Label7.Text = "Seconds";
      this.Label8.AutoSize = true;
      Label label8_1 = this.Label8;
      point1 = new Point(155, 15);
      Point point26 = point1;
      label8_1.Location = point26;
      this.Label8.Name = "Label8";
      Label label8_2 = this.Label8;
      size1 = new Size(33, 13);
      Size size26 = size1;
      label8_2.Size = size26;
      this.Label8.TabIndex = 18;
      this.Label8.Text = "Pulse";
      this.gb_coin2.Controls.Add((Control) this.nud_second2);
      this.gb_coin2.Controls.Add((Control) this.nud_pulse2);
      this.gb_coin2.Controls.Add((Control) this.Label5);
      this.gb_coin2.Controls.Add((Control) this.Label6);
      this.gb_coin2.Enabled = false;
      GroupBox gbCoin2_1 = this.gb_coin2;
      point1 = new Point(17, 85);
      Point point27 = point1;
      gbCoin2_1.Location = point27;
      this.gb_coin2.Name = "gb_coin2";
      GroupBox gbCoin2_2 = this.gb_coin2;
      size1 = new Size(261, 40);
      Size size27 = size1;
      gbCoin2_2.Size = size27;
      this.gb_coin2.TabIndex = 10;
      this.gb_coin2.TabStop = false;
      this.gb_coin2.Text = "Coin 2";
      NumericUpDown nudSecond2_1 = this.nud_second2;
      point1 = new Point(62, 13);
      Point point28 = point1;
      nudSecond2_1.Location = point28;
      NumericUpDown nudSecond2_2 = this.nud_second2;
      num1 = new Decimal(new int[4]{ 9999, 0, 0, 0 });
      Decimal num10 = num1;
      nudSecond2_2.Maximum = num10;
      this.nud_second2.Name = "nud_second2";
      NumericUpDown nudSecond2_3 = this.nud_second2;
      size1 = new Size(79, 20);
      Size size28 = size1;
      nudSecond2_3.Size = size28;
      this.nud_second2.TabIndex = 12;
      NumericUpDown nudPulse2_1 = this.nud_pulse2;
      point1 = new Point(189, 13);
      Point point29 = point1;
      nudPulse2_1.Location = point29;
      NumericUpDown nudPulse2_2 = this.nud_pulse2;
      num1 = new Decimal(new int[4]{ 99, 0, 0, 0 });
      Decimal num11 = num1;
      nudPulse2_2.Maximum = num11;
      this.nud_pulse2.Name = "nud_pulse2";
      NumericUpDown nudPulse2_3 = this.nud_pulse2;
      size1 = new Size(53, 20);
      Size size29 = size1;
      nudPulse2_3.Size = size29;
      this.nud_pulse2.TabIndex = 14;
      this.Label5.AutoSize = true;
      Label label5_1 = this.Label5;
      point1 = new Point(10, 15);
      Point point30 = point1;
      label5_1.Location = point30;
      this.Label5.Name = "Label5";
      Label label5_2 = this.Label5;
      size1 = new Size(49, 13);
      Size size30 = size1;
      label5_2.Size = size30;
      this.Label5.TabIndex = 11;
      this.Label5.Text = "Seconds";
      this.Label6.AutoSize = true;
      Label label6_1 = this.Label6;
      point1 = new Point(155, 15);
      Point point31 = point1;
      label6_1.Location = point31;
      this.Label6.Name = "Label6";
      Label label6_2 = this.Label6;
      size1 = new Size(33, 13);
      Size size31 = size1;
      label6_2.Size = size31;
      this.Label6.TabIndex = 13;
      this.Label6.Text = "Pulse";
      this.gb_coin1.Controls.Add((Control) this.nud_second1);
      this.gb_coin1.Controls.Add((Control) this.nud_pulse1);
      this.gb_coin1.Controls.Add((Control) this.Label3);
      this.gb_coin1.Controls.Add((Control) this.Label4);
      this.gb_coin1.Enabled = false;
      GroupBox gbCoin1_1 = this.gb_coin1;
      point1 = new Point(17, 43);
      Point point32 = point1;
      gbCoin1_1.Location = point32;
      this.gb_coin1.Name = "gb_coin1";
      GroupBox gbCoin1_2 = this.gb_coin1;
      size1 = new Size(261, 40);
      Size size32 = size1;
      gbCoin1_2.Size = size32;
      this.gb_coin1.TabIndex = 5;
      this.gb_coin1.TabStop = false;
      this.gb_coin1.Text = "Coin 1";
      NumericUpDown nudSecond1_1 = this.nud_second1;
      point1 = new Point(62, 13);
      Point point33 = point1;
      nudSecond1_1.Location = point33;
      NumericUpDown nudSecond1_2 = this.nud_second1;
      num1 = new Decimal(new int[4]{ 9999, 0, 0, 0 });
      Decimal num12 = num1;
      nudSecond1_2.Maximum = num12;
      this.nud_second1.Name = "nud_second1";
      NumericUpDown nudSecond1_3 = this.nud_second1;
      size1 = new Size(79, 20);
      Size size33 = size1;
      nudSecond1_3.Size = size33;
      this.nud_second1.TabIndex = 7;
      NumericUpDown nudPulse1_1 = this.nud_pulse1;
      point1 = new Point(189, 13);
      Point point34 = point1;
      nudPulse1_1.Location = point34;
      NumericUpDown nudPulse1_2 = this.nud_pulse1;
      num1 = new Decimal(new int[4]{ 99, 0, 0, 0 });
      Decimal num13 = num1;
      nudPulse1_2.Maximum = num13;
      this.nud_pulse1.Name = "nud_pulse1";
      NumericUpDown nudPulse1_3 = this.nud_pulse1;
      size1 = new Size(53, 20);
      Size size34 = size1;
      nudPulse1_3.Size = size34;
      this.nud_pulse1.TabIndex = 9;
      this.Label3.AutoSize = true;
      Label label3_1 = this.Label3;
      point1 = new Point(10, 15);
      Point point35 = point1;
      label3_1.Location = point35;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(49, 13);
      Size size35 = size1;
      label3_2.Size = size35;
      this.Label3.TabIndex = 6;
      this.Label3.Text = "Seconds";
      this.Label4.AutoSize = true;
      Label label4_1 = this.Label4;
      point1 = new Point(155, 15);
      Point point36 = point1;
      label4_1.Location = point36;
      this.Label4.Name = "Label4";
      Label label4_2 = this.Label4;
      size1 = new Size(33, 13);
      Size size36 = size1;
      label4_2.Size = size36;
      this.Label4.TabIndex = 8;
      this.Label4.Text = "Pulse";
      this.cb_cointype.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cb_cointype.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cb_cointype.FormattingEnabled = true;
      this.cb_cointype.Items.AddRange(new object[4]
      {
        (object) "Single coin acceptor",
        (object) "Dual coin acceptor",
        (object) "Multi coin acceptor",
        (object) "Super multi-coin acceptor"
      });
      ComboBox cbCointype1 = this.cb_cointype;
      point1 = new Point(123, 14);
      Point point37 = point1;
      cbCointype1.Location = point37;
      this.cb_cointype.Name = "cb_cointype";
      ComboBox cbCointype2 = this.cb_cointype;
      size1 = new Size(179, 21);
      Size size37 = size1;
      cbCointype2.Size = size37;
      this.cb_cointype.TabIndex = 4;
      this.cb_cointype.TabStop = false;
      this.Label2.AutoSize = true;
      Label label2_1 = this.Label2;
      point1 = new Point(17, 17);
      Point point38 = point1;
      label2_1.Location = point38;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(96, 13);
      Size size38 = size1;
      label2_2.Size = size38;
      this.Label2.TabIndex = 3;
      this.Label2.Text = "Coin acceptor type";
      this.TabPage2.Controls.Add((Control) this.gb_bg);
      this.TabPage2.Controls.Add((Control) this.gb_email);
      this.TabPage2.Controls.Add((Control) this.gb_pass);
      this.TabPage2.Controls.Add((Control) this.gb_windows);
      TabPage tabPage2_1 = this.TabPage2;
      point1 = new Point(4, 22);
      Point point39 = point1;
      tabPage2_1.Location = point39;
      this.TabPage2.Name = "TabPage2";
      TabPage tabPage2_2 = this.TabPage2;
      padding1 = new Padding(3);
      Padding padding3 = padding1;
      tabPage2_2.Padding = padding3;
      TabPage tabPage2_3 = this.TabPage2;
      size1 = new Size(445, 305);
      Size size39 = size1;
      tabPage2_3.Size = size39;
      this.TabPage2.TabIndex = 1;
      this.TabPage2.Text = "Apps";
      this.TabPage2.UseVisualStyleBackColor = true;
      this.gb_bg.Controls.Add((Control) this.Label18);
      this.gb_bg.Controls.Add((Control) this.label_bg);
      this.gb_bg.Controls.Add((Control) this.txtbx_bgerror);
      this.gb_bg.Controls.Add((Control) this.btn_bgerror);
      this.gb_bg.Controls.Add((Control) this.txtbx_bgready);
      this.gb_bg.Controls.Add((Control) this.btn_bgready);
      GroupBox gbBg1 = this.gb_bg;
      point1 = new Point(13, 176);
      Point point40 = point1;
      gbBg1.Location = point40;
      this.gb_bg.Name = "gb_bg";
      GroupBox gbBg2 = this.gb_bg;
      size1 = new Size(228, 121);
      Size size40 = size1;
      gbBg2.Size = size40;
      this.gb_bg.TabIndex = 45;
      this.gb_bg.TabStop = false;
      this.gb_bg.Text = "BACKGROUND IMAGE";
      this.Label18.AutoSize = true;
      Label label18_1 = this.Label18;
      point1 = new Point(13, 71);
      Point point41 = point1;
      label18_1.Location = point41;
      this.Label18.Name = "Label18";
      Label label18_2 = this.Label18;
      size1 = new Size(121, 13);
      Size size41 = size1;
      label18_2.Size = size41;
      this.Label18.TabIndex = 49;
      this.Label18.Text = "Error Background image";
      this.label_bg.AutoSize = true;
      Label labelBg1 = this.label_bg;
      point1 = new Point(14, 23);
      Point point42 = point1;
      labelBg1.Location = point42;
      this.label_bg.Name = "label_bg";
      Label labelBg2 = this.label_bg;
      size1 = new Size(130, 13);
      Size size42 = size1;
      labelBg2.Size = size42;
      this.label_bg.TabIndex = 46;
      this.label_bg.Text = "Ready Background image";
      this.txtbx_bgerror.ForeColor = Color.Red;
      TextBox txtbxBgerror1 = this.txtbx_bgerror;
      point1 = new Point(16, 90);
      Point point43 = point1;
      txtbxBgerror1.Location = point43;
      this.txtbx_bgerror.Name = "txtbx_bgerror";
      TextBox txtbxBgerror2 = this.txtbx_bgerror;
      size1 = new Size(173, 20);
      Size size43 = size1;
      txtbxBgerror2.Size = size43;
      this.txtbx_bgerror.TabIndex = 50;
      Button btnBgerror1 = this.btn_bgerror;
      point1 = new Point(193, 88);
      Point point44 = point1;
      btnBgerror1.Location = point44;
      this.btn_bgerror.Name = "btn_bgerror";
      Button btnBgerror2 = this.btn_bgerror;
      size1 = new Size(19, 23);
      Size size44 = size1;
      btnBgerror2.Size = size44;
      this.btn_bgerror.TabIndex = 51;
      this.btn_bgerror.TabStop = false;
      this.btn_bgerror.UseVisualStyleBackColor = true;
      this.txtbx_bgready.ForeColor = Color.SeaGreen;
      TextBox txtbxBgready1 = this.txtbx_bgready;
      point1 = new Point(17, 42);
      Point point45 = point1;
      txtbxBgready1.Location = point45;
      this.txtbx_bgready.Name = "txtbx_bgready";
      TextBox txtbxBgready2 = this.txtbx_bgready;
      size1 = new Size(173, 20);
      Size size45 = size1;
      txtbxBgready2.Size = size45;
      this.txtbx_bgready.TabIndex = 47;
      Button btnBgready1 = this.btn_bgready;
      point1 = new Point(194, 40);
      Point point46 = point1;
      btnBgready1.Location = point46;
      this.btn_bgready.Name = "btn_bgready";
      Button btnBgready2 = this.btn_bgready;
      size1 = new Size(19, 23);
      Size size46 = size1;
      btnBgready2.Size = size46;
      this.btn_bgready.TabIndex = 48;
      this.btn_bgready.TabStop = false;
      this.btn_bgready.UseVisualStyleBackColor = true;
      this.gb_email.Controls.Add((Control) this.lbl_email);
      this.gb_email.Controls.Add((Control) this.btn_email);
      this.gb_email.Controls.Add((Control) this.txtbx_email);
      GroupBox gbEmail1 = this.gb_email;
      point1 = new Point(247, 193);
      Point point47 = point1;
      gbEmail1.Location = point47;
      this.gb_email.Name = "gb_email";
      GroupBox gbEmail2 = this.gb_email;
      size1 = new Size(185, 104);
      Size size47 = size1;
      gbEmail2.Size = size47;
      this.gb_email.TabIndex = 60;
      this.gb_email.TabStop = false;
      this.gb_email.Text = "EMAIL ADDRESS";
      this.lbl_email.Anchor = AnchorStyles.Right;
      this.lbl_email.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lbl_email.ForeColor = Color.Blue;
      Label lblEmail1 = this.lbl_email;
      point1 = new Point(11, 17);
      Point point48 = point1;
      lblEmail1.Location = point48;
      this.lbl_email.Name = "lbl_email";
      this.lbl_email.RightToLeft = RightToLeft.No;
      Label lblEmail2 = this.lbl_email;
      size1 = new Size(168, 20);
      Size size48 = size1;
      lblEmail2.Size = size48;
      this.lbl_email.TabIndex = 61;
      this.lbl_email.Text = "address@domain.com";
      this.lbl_email.TextAlign = ContentAlignment.MiddleRight;
      this.btn_email.Enabled = false;
      this.btn_email.Font = new Font("Microsoft Sans Serif", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Button btnEmail1 = this.btn_email;
      point1 = new Point(11, 71);
      Point point49 = point1;
      btnEmail1.Location = point49;
      this.btn_email.Name = "btn_email";
      Button btnEmail2 = this.btn_email;
      size1 = new Size(168, 22);
      Size size49 = size1;
      btnEmail2.Size = size49;
      this.btn_email.TabIndex = 63;
      this.btn_email.TabStop = false;
      this.btn_email.Text = "CHANGE EMAIL";
      this.btn_email.UseVisualStyleBackColor = true;
      TextBox txtbxEmail1 = this.txtbx_email;
      point1 = new Point(11, 43);
      Point point50 = point1;
      txtbxEmail1.Location = point50;
      this.txtbx_email.Name = "txtbx_email";
      TextBox txtbxEmail2 = this.txtbx_email;
      size1 = new Size(168, 20);
      Size size50 = size1;
      txtbxEmail2.Size = size50;
      this.txtbx_email.TabIndex = 62;
      this.gb_pass.Controls.Add((Control) this.txtbx_retype);
      this.gb_pass.Controls.Add((Control) this.txtbx_new);
      this.gb_pass.Controls.Add((Control) this.txtbx_old);
      this.gb_pass.Controls.Add((Control) this.Label17);
      this.gb_pass.Controls.Add((Control) this.Label16);
      this.gb_pass.Controls.Add((Control) this.btn_pass);
      this.gb_pass.Controls.Add((Control) this.Label15);
      GroupBox gbPass1 = this.gb_pass;
      point1 = new Point(247, 12);
      Point point51 = point1;
      gbPass1.Location = point51;
      this.gb_pass.Name = "gb_pass";
      GroupBox gbPass2 = this.gb_pass;
      size1 = new Size(185, 175);
      Size size51 = size1;
      gbPass2.Size = size51;
      this.gb_pass.TabIndex = 52;
      this.gb_pass.TabStop = false;
      this.gb_pass.Text = "PASSWORD";
      TextBox txtbxRetype1 = this.txtbx_retype;
      point1 = new Point(11, 119);
      Point point52 = point1;
      txtbxRetype1.Location = point52;
      this.txtbx_retype.Name = "txtbx_retype";
      TextBox txtbxRetype2 = this.txtbx_retype;
      size1 = new Size(168, 20);
      Size size52 = size1;
      txtbxRetype2.Size = size52;
      this.txtbx_retype.TabIndex = 58;
      this.txtbx_retype.UseSystemPasswordChar = true;
      TextBox txtbxNew1 = this.txtbx_new;
      point1 = new Point(11, 80);
      Point point53 = point1;
      txtbxNew1.Location = point53;
      this.txtbx_new.Name = "txtbx_new";
      TextBox txtbxNew2 = this.txtbx_new;
      size1 = new Size(168, 20);
      Size size53 = size1;
      txtbxNew2.Size = size53;
      this.txtbx_new.TabIndex = 56;
      this.txtbx_new.UseSystemPasswordChar = true;
      TextBox txtbxOld1 = this.txtbx_old;
      point1 = new Point(11, 37);
      Point point54 = point1;
      txtbxOld1.Location = point54;
      this.txtbx_old.Name = "txtbx_old";
      TextBox txtbxOld2 = this.txtbx_old;
      size1 = new Size(168, 20);
      Size size54 = size1;
      txtbxOld2.Size = size54;
      this.txtbx_old.TabIndex = 54;
      this.txtbx_old.UseSystemPasswordChar = true;
      this.Label17.AutoSize = true;
      Label label17_1 = this.Label17;
      point1 = new Point(8, 104);
      Point point55 = point1;
      label17_1.Location = point55;
      this.Label17.Name = "Label17";
      Label label17_2 = this.Label17;
      size1 = new Size(64, 13);
      Size size55 = size1;
      label17_2.Size = size55;
      this.Label17.TabIndex = 57;
      this.Label17.Text = "Retype new";
      this.Label16.AutoSize = true;
      Label label16_1 = this.Label16;
      point1 = new Point(8, 64);
      Point point56 = point1;
      label16_1.Location = point56;
      this.Label16.Name = "Label16";
      Label label16_2 = this.Label16;
      size1 = new Size(29, 13);
      Size size56 = size1;
      label16_2.Size = size56;
      this.Label16.TabIndex = 55;
      this.Label16.Text = "New";
      this.btn_pass.Enabled = false;
      this.btn_pass.Font = new Font("Microsoft Sans Serif", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Button btnPass1 = this.btn_pass;
      point1 = new Point(11, 145);
      Point point57 = point1;
      btnPass1.Location = point57;
      this.btn_pass.Name = "btn_pass";
      Button btnPass2 = this.btn_pass;
      size1 = new Size(168, 22);
      Size size57 = size1;
      btnPass2.Size = size57;
      this.btn_pass.TabIndex = 59;
      this.btn_pass.TabStop = false;
      this.btn_pass.Text = "CHANGE PASSWORD";
      this.btn_pass.UseVisualStyleBackColor = true;
      this.Label15.AutoSize = true;
      Label label15_1 = this.Label15;
      point1 = new Point(8, 21);
      Point point58 = point1;
      label15_1.Location = point58;
      this.Label15.Name = "Label15";
      Label label15_2 = this.Label15;
      size1 = new Size(23, 13);
      Size size58 = size1;
      label15_2.Size = size58;
      this.Label15.TabIndex = 53;
      this.Label15.Text = "Old";
      this.gb_windows.Controls.Add((Control) this.lbl_pause);
      this.gb_windows.Controls.Add((Control) this.txtbx_hotkey);
      this.gb_windows.Controls.Add((Control) this.nud_logretry);
      this.gb_windows.Controls.Add((Control) this.nud_pause);
      this.gb_windows.Controls.Add((Control) this.nud_shutdowntime);
      this.gb_windows.Controls.Add((Control) this.Label14);
      this.gb_windows.Controls.Add((Control) this.Label13);
      this.gb_windows.Controls.Add((Control) this.Label12);
      this.gb_windows.Controls.Add((Control) this.chkbx_taskmgr);
      GroupBox gbWindows1 = this.gb_windows;
      point1 = new Point(13, 11);
      Point point59 = point1;
      gbWindows1.Location = point59;
      this.gb_windows.Name = "gb_windows";
      GroupBox gbWindows2 = this.gb_windows;
      size1 = new Size(228, 159);
      Size size59 = size1;
      gbWindows2.Size = size59;
      this.gb_windows.TabIndex = 35;
      this.gb_windows.TabStop = false;
      this.gb_windows.Text = "WINDOWS";
      this.lbl_pause.AutoSize = true;
      Label lblPause1 = this.lbl_pause;
      point1 = new Point(13, 102);
      Point point60 = point1;
      lblPause1.Location = point60;
      this.lbl_pause.Name = "lbl_pause";
      Label lblPause2 = this.lbl_pause;
      size1 = new Size(59, 13);
      Size size60 = size1;
      lblPause2.Size = size60;
      this.lbl_pause.TabIndex = 41;
      this.lbl_pause.Text = "Pause time";
      TextBox txtbxHotkey1 = this.txtbx_hotkey;
      point1 = new Point(142, 126);
      Point point61 = point1;
      txtbxHotkey1.Location = point61;
      this.txtbx_hotkey.MaxLength = 1;
      this.txtbx_hotkey.Name = "txtbx_hotkey";
      this.txtbx_hotkey.ReadOnly = true;
      TextBox txtbxHotkey2 = this.txtbx_hotkey;
      size1 = new Size(72, 20);
      Size size61 = size1;
      txtbxHotkey2.Size = size61;
      this.txtbx_hotkey.TabIndex = 44;
      NumericUpDown nudLogretry1 = this.nud_logretry;
      point1 = new Point(142, 74);
      Point point62 = point1;
      nudLogretry1.Location = point62;
      NumericUpDown nudLogretry2 = this.nud_logretry;
      num1 = new Decimal(new int[4]{ 999, 0, 0, 0 });
      Decimal num14 = num1;
      nudLogretry2.Maximum = num14;
      this.nud_logretry.Name = "nud_logretry";
      NumericUpDown nudLogretry3 = this.nud_logretry;
      size1 = new Size(72, 20);
      Size size62 = size1;
      nudLogretry3.Size = size62;
      this.nud_logretry.TabIndex = 40;
      NumericUpDown nudPause1 = this.nud_pause;
      point1 = new Point(142, 100);
      Point point63 = point1;
      nudPause1.Location = point63;
      NumericUpDown nudPause2 = this.nud_pause;
      num1 = new Decimal(new int[4]{ 999, 0, 0, 0 });
      Decimal num15 = num1;
      nudPause2.Maximum = num15;
      this.nud_pause.Name = "nud_pause";
      NumericUpDown nudPause3 = this.nud_pause;
      size1 = new Size(72, 20);
      Size size63 = size1;
      nudPause3.Size = size63;
      this.nud_pause.TabIndex = 42;
      NumericUpDown nudShutdowntime1 = this.nud_shutdowntime;
      point1 = new Point(142, 48);
      Point point64 = point1;
      nudShutdowntime1.Location = point64;
      NumericUpDown nudShutdowntime2 = this.nud_shutdowntime;
      num1 = new Decimal(new int[4]{ 999, 0, 0, 0 });
      Decimal num16 = num1;
      nudShutdowntime2.Maximum = num16;
      this.nud_shutdowntime.Name = "nud_shutdowntime";
      NumericUpDown nudShutdowntime3 = this.nud_shutdowntime;
      size1 = new Size(72, 20);
      Size size64 = size1;
      nudShutdowntime3.Size = size64;
      this.nud_shutdowntime.TabIndex = 38;
      this.Label14.AutoSize = true;
      Label label14_1 = this.Label14;
      point1 = new Point(13, 129);
      Point point65 = point1;
      label14_1.Location = point65;
      this.Label14.Name = "Label14";
      Label label14_2 = this.Label14;
      size1 = new Size(112, 13);
      Size size65 = size1;
      label14_2.Size = size65;
      this.Label14.TabIndex = 43;
      this.Label14.Text = "Hotkey (ctrl+alt+shift+)";
      this.Label13.AutoSize = true;
      Label label13_1 = this.Label13;
      point1 = new Point(13, 77);
      Point point66 = point1;
      label13_1.Location = point66;
      this.Label13.Name = "Label13";
      Label label13_2 = this.Label13;
      size1 = new Size(56, 13);
      Size size66 = size1;
      label13_2.Size = size66;
      this.Label13.TabIndex = 39;
      this.Label13.Text = "Login retry";
      this.Label12.AutoSize = true;
      Label label12_1 = this.Label12;
      point1 = new Point(13, 52);
      Point point67 = point1;
      label12_1.Location = point67;
      this.Label12.Name = "Label12";
      Label label12_2 = this.Label12;
      size1 = new Size(77, 13);
      Size size67 = size1;
      label12_2.Size = size67;
      this.Label12.TabIndex = 37;
      this.Label12.Text = "Shutdown time";
      this.chkbx_taskmgr.AutoSize = true;
      CheckBox chkbxTaskmgr1 = this.chkbx_taskmgr;
      point1 = new Point(16, 21);
      Point point68 = point1;
      chkbxTaskmgr1.Location = point68;
      this.chkbx_taskmgr.Name = "chkbx_taskmgr";
      CheckBox chkbxTaskmgr2 = this.chkbx_taskmgr;
      size1 = new Size(167, 17);
      Size size68 = size1;
      chkbxTaskmgr2.Size = size68;
      this.chkbx_taskmgr.TabIndex = 36;
      this.chkbx_taskmgr.TabStop = false;
      this.chkbx_taskmgr.Text = "Disable the TASK MANAGER";
      this.chkbx_taskmgr.UseVisualStyleBackColor = true;
      this.TabPage3.Controls.Add((Control) this.GroupBox1);
      TabPage tabPage3_1 = this.TabPage3;
      point1 = new Point(4, 22);
      Point point69 = point1;
      tabPage3_1.Location = point69;
      this.TabPage3.Name = "TabPage3";
      TabPage tabPage3_2 = this.TabPage3;
      size1 = new Size(445, 305);
      Size size69 = size1;
      tabPage3_2.Size = size69;
      this.TabPage3.TabIndex = 2;
      this.TabPage3.Text = "Data";
      this.TabPage3.UseVisualStyleBackColor = true;
      this.GroupBox1.Controls.Add((Control) this.btn_savedata);
      this.GroupBox1.Controls.Add((Control) this.txtbx_savedata);
      this.GroupBox1.Controls.Add((Control) this.gb_vouchers);
      this.GroupBox1.Controls.Add((Control) this.gb_accounts);
      this.GroupBox1.Controls.Add((Control) this.chkbx_savedata);
      GroupBox groupBox1_1 = this.GroupBox1;
      point1 = new Point(12, 10);
      Point point70 = point1;
      groupBox1_1.Location = point70;
      this.GroupBox1.Name = "GroupBox1";
      GroupBox groupBox1_2 = this.GroupBox1;
      size1 = new Size(420, 285);
      Size size70 = size1;
      groupBox1_2.Size = size70;
      this.GroupBox1.TabIndex = 64;
      this.GroupBox1.TabStop = false;
      this.GroupBox1.Text = "SAVE DATA";
      Button btnSavedata1 = this.btn_savedata;
      point1 = new Point(393, 41);
      Point point71 = point1;
      btnSavedata1.Location = point71;
      this.btn_savedata.Name = "btn_savedata";
      Button btnSavedata2 = this.btn_savedata;
      size1 = new Size(17, 23);
      Size size71 = size1;
      btnSavedata2.Size = size71;
      this.btn_savedata.TabIndex = 67;
      this.btn_savedata.TabStop = false;
      this.btn_savedata.UseVisualStyleBackColor = true;
      this.txtbx_savedata.ForeColor = Color.Blue;
      TextBox txtbxSavedata1 = this.txtbx_savedata;
      point1 = new Point(13, 44);
      Point point72 = point1;
      txtbxSavedata1.Location = point72;
      this.txtbx_savedata.Name = "txtbx_savedata";
      TextBox txtbxSavedata2 = this.txtbx_savedata;
      size1 = new Size(374, 20);
      Size size72 = size1;
      txtbxSavedata2.Size = size72;
      this.txtbx_savedata.TabIndex = 66;
      this.txtbx_savedata.Text = "f:\\_WORKING FILES\\Coinapp Service\\Coinapp 2.0\\bin\\";
      this.gb_vouchers.Controls.Add((Control) this.gb_dbVoucher);
      this.gb_vouchers.Controls.Add((Control) this.chkbx_voucher);
      GroupBox gbVouchers1 = this.gb_vouchers;
      point1 = new Point(9, 79);
      Point point73 = point1;
      gbVouchers1.Location = point73;
      this.gb_vouchers.Name = "gb_vouchers";
      GroupBox gbVouchers2 = this.gb_vouchers;
      size1 = new Size(197, 195);
      Size size73 = size1;
      gbVouchers2.Size = size73;
      this.gb_vouchers.TabIndex = 68;
      this.gb_vouchers.TabStop = false;
      this.gb_vouchers.Text = "VOUCHERS";
      this.gb_dbVoucher.Controls.Add((Control) this.btn_vouchers);
      this.gb_dbVoucher.Controls.Add((Control) this.txtbx_dbVoucherPass);
      this.gb_dbVoucher.Controls.Add((Control) this.txtbx_dbVoucherName);
      this.gb_dbVoucher.Controls.Add((Control) this.Label23);
      this.gb_dbVoucher.Controls.Add((Control) this.Label22);
      this.gb_dbVoucher.Enabled = false;
      GroupBox gbDbVoucher1 = this.gb_dbVoucher;
      point1 = new Point(12, 54);
      Point point74 = point1;
      gbDbVoucher1.Location = point74;
      this.gb_dbVoucher.Name = "gb_dbVoucher";
      GroupBox gbDbVoucher2 = this.gb_dbVoucher;
      size1 = new Size(175, (int) sbyte.MaxValue);
      Size size74 = size1;
      gbDbVoucher2.Size = size74;
      this.gb_dbVoucher.TabIndex = 70;
      this.gb_dbVoucher.TabStop = false;
      this.gb_dbVoucher.Text = "Database";
      this.btn_vouchers.Enabled = false;
      Button btnVouchers1 = this.btn_vouchers;
      point1 = new Point(18, 85);
      Point point75 = point1;
      btnVouchers1.Location = point75;
      this.btn_vouchers.Name = "btn_vouchers";
      Button btnVouchers2 = this.btn_vouchers;
      size1 = new Size(142, 30);
      Size size75 = size1;
      btnVouchers2.Size = size75;
      this.btn_vouchers.TabIndex = 75;
      this.btn_vouchers.TabStop = false;
      this.btn_vouchers.Text = "Vouchers Manager";
      this.btn_vouchers.UseVisualStyleBackColor = true;
      TextBox txtbxDbVoucherPass1 = this.txtbx_dbVoucherPass;
      point1 = new Point(65, 55);
      Point point76 = point1;
      txtbxDbVoucherPass1.Location = point76;
      this.txtbx_dbVoucherPass.Name = "txtbx_dbVoucherPass";
      TextBox txtbxDbVoucherPass2 = this.txtbx_dbVoucherPass;
      size1 = new Size(100, 20);
      Size size76 = size1;
      txtbxDbVoucherPass2.Size = size76;
      this.txtbx_dbVoucherPass.TabIndex = 74;
      TextBox txtbxDbVoucherName1 = this.txtbx_dbVoucherName;
      point1 = new Point(65, 27);
      Point point77 = point1;
      txtbxDbVoucherName1.Location = point77;
      this.txtbx_dbVoucherName.Name = "txtbx_dbVoucherName";
      TextBox txtbxDbVoucherName2 = this.txtbx_dbVoucherName;
      size1 = new Size(100, 20);
      Size size77 = size1;
      txtbxDbVoucherName2.Size = size77;
      this.txtbx_dbVoucherName.TabIndex = 72;
      this.Label23.AutoSize = true;
      Label label23_1 = this.Label23;
      point1 = new Point(10, 58);
      Point point78 = point1;
      label23_1.Location = point78;
      this.Label23.Name = "Label23";
      Label label23_2 = this.Label23;
      size1 = new Size(53, 13);
      Size size78 = size1;
      label23_2.Size = size78;
      this.Label23.TabIndex = 73;
      this.Label23.Text = "Password";
      this.Label22.AutoSize = true;
      Label label22_1 = this.Label22;
      point1 = new Point(10, 30);
      Point point79 = point1;
      label22_1.Location = point79;
      this.Label22.Name = "Label22";
      Label label22_2 = this.Label22;
      size1 = new Size(49, 13);
      Size size79 = size1;
      label22_2.Size = size79;
      this.Label22.TabIndex = 71;
      this.Label22.Text = "Filename";
      this.chkbx_voucher.AutoSize = true;
      CheckBox chkbxVoucher1 = this.chkbx_voucher;
      point1 = new Point(19, 25);
      Point point80 = point1;
      chkbxVoucher1.Location = point80;
      this.chkbx_voucher.Name = "chkbx_voucher";
      CheckBox chkbxVoucher2 = this.chkbx_voucher;
      size1 = new Size(140, 17);
      Size size80 = size1;
      chkbxVoucher2.Size = size80;
      this.chkbx_voucher.TabIndex = 69;
      this.chkbx_voucher.Text = "Enable voucher coupon";
      this.chkbx_voucher.UseVisualStyleBackColor = true;
      this.gb_accounts.Controls.Add((Control) this.gb_dbAccount);
      this.gb_accounts.Controls.Add((Control) this.chkbx_account);
      GroupBox gbAccounts1 = this.gb_accounts;
      point1 = new Point(213, 79);
      Point point81 = point1;
      gbAccounts1.Location = point81;
      this.gb_accounts.Name = "gb_accounts";
      GroupBox gbAccounts2 = this.gb_accounts;
      size1 = new Size(197, 195);
      Size size81 = size1;
      gbAccounts2.Size = size81;
      this.gb_accounts.TabIndex = 76;
      this.gb_accounts.TabStop = false;
      this.gb_accounts.Text = "ACCOUNTS";
      this.gb_dbAccount.Controls.Add((Control) this.btn_accounts);
      this.gb_dbAccount.Controls.Add((Control) this.txtbx_dbAccountPass);
      this.gb_dbAccount.Controls.Add((Control) this.txtbx_dbAccountName);
      this.gb_dbAccount.Controls.Add((Control) this.Label24);
      this.gb_dbAccount.Controls.Add((Control) this.Label25);
      this.gb_dbAccount.Enabled = false;
      GroupBox gbDbAccount1 = this.gb_dbAccount;
      point1 = new Point(11, 55);
      Point point82 = point1;
      gbDbAccount1.Location = point82;
      this.gb_dbAccount.Name = "gb_dbAccount";
      GroupBox gbDbAccount2 = this.gb_dbAccount;
      size1 = new Size(175, (int) sbyte.MaxValue);
      Size size82 = size1;
      gbDbAccount2.Size = size82;
      this.gb_dbAccount.TabIndex = 78;
      this.gb_dbAccount.TabStop = false;
      this.gb_dbAccount.Text = "Database";
      this.btn_accounts.Enabled = false;
      Button btnAccounts1 = this.btn_accounts;
      point1 = new Point(18, 85);
      Point point83 = point1;
      btnAccounts1.Location = point83;
      this.btn_accounts.Name = "btn_accounts";
      Button btnAccounts2 = this.btn_accounts;
      size1 = new Size(142, 30);
      Size size83 = size1;
      btnAccounts2.Size = size83;
      this.btn_accounts.TabIndex = 83;
      this.btn_accounts.TabStop = false;
      this.btn_accounts.Text = "Accounts Manager";
      this.btn_accounts.UseVisualStyleBackColor = true;
      TextBox txtbxDbAccountPass1 = this.txtbx_dbAccountPass;
      point1 = new Point(65, 55);
      Point point84 = point1;
      txtbxDbAccountPass1.Location = point84;
      this.txtbx_dbAccountPass.Name = "txtbx_dbAccountPass";
      TextBox txtbxDbAccountPass2 = this.txtbx_dbAccountPass;
      size1 = new Size(100, 20);
      Size size84 = size1;
      txtbxDbAccountPass2.Size = size84;
      this.txtbx_dbAccountPass.TabIndex = 82;
      TextBox txtbxDbAccountName1 = this.txtbx_dbAccountName;
      point1 = new Point(65, 27);
      Point point85 = point1;
      txtbxDbAccountName1.Location = point85;
      this.txtbx_dbAccountName.Name = "txtbx_dbAccountName";
      TextBox txtbxDbAccountName2 = this.txtbx_dbAccountName;
      size1 = new Size(100, 20);
      Size size85 = size1;
      txtbxDbAccountName2.Size = size85;
      this.txtbx_dbAccountName.TabIndex = 80;
      this.Label24.AutoSize = true;
      Label label24_1 = this.Label24;
      point1 = new Point(10, 58);
      Point point86 = point1;
      label24_1.Location = point86;
      this.Label24.Name = "Label24";
      Label label24_2 = this.Label24;
      size1 = new Size(53, 13);
      Size size86 = size1;
      label24_2.Size = size86;
      this.Label24.TabIndex = 81;
      this.Label24.Text = "Password";
      this.Label25.AutoSize = true;
      Label label25_1 = this.Label25;
      point1 = new Point(10, 30);
      Point point87 = point1;
      label25_1.Location = point87;
      this.Label25.Name = "Label25";
      Label label25_2 = this.Label25;
      size1 = new Size(49, 13);
      Size size87 = size1;
      label25_2.Size = size87;
      this.Label25.TabIndex = 79;
      this.Label25.Text = "Filename";
      this.chkbx_account.AutoSize = true;
      CheckBox chkbxAccount1 = this.chkbx_account;
      point1 = new Point(20, 25);
      Point point88 = point1;
      chkbxAccount1.Location = point88;
      this.chkbx_account.Name = "chkbx_account";
      CheckBox chkbxAccount2 = this.chkbx_account;
      size1 = new Size(124, 17);
      Size size88 = size1;
      chkbxAccount2.Size = size88;
      this.chkbx_account.TabIndex = 77;
      this.chkbx_account.Text = "Enable user account";
      this.chkbx_account.UseVisualStyleBackColor = true;
      this.chkbx_savedata.AutoSize = true;
      CheckBox chkbxSavedata1 = this.chkbx_savedata;
      point1 = new Point(14, 21);
      Point point89 = point1;
      chkbxSavedata1.Location = point89;
      this.chkbx_savedata.Name = "chkbx_savedata";
      CheckBox chkbxSavedata2 = this.chkbx_savedata;
      size1 = new Size(109, 17);
      Size size89 = size1;
      chkbxSavedata2.Size = size89;
      this.chkbx_savedata.TabIndex = 65;
      this.chkbx_savedata.Text = "Enable save data";
      this.chkbx_savedata.UseVisualStyleBackColor = true;
      this.btn_close.Enabled = false;
      this.btn_close.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Button btnClose1 = this.btn_close;
      point1 = new Point(207, 397);
      Point point90 = point1;
      btnClose1.Location = point90;
      this.btn_close.Name = "btn_close";
      Button btnClose2 = this.btn_close;
      size1 = new Size(107, 24);
      Size size90 = size1;
      btnClose2.Size = size90;
      this.btn_close.TabIndex = 85;
      this.btn_close.TabStop = false;
      this.btn_close.Text = "EXIT APP";
      this.btn_close.UseVisualStyleBackColor = true;
      this.btn_save.Enabled = false;
      this.btn_save.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Button btnSave1 = this.btn_save;
      point1 = new Point(320, 397);
      Point point91 = point1;
      btnSave1.Location = point91;
      this.btn_save.Name = "btn_save";
      Button btnSave2 = this.btn_save;
      size1 = new Size(144, 24);
      Size size91 = size1;
      btnSave2.Size = size91;
      this.btn_save.TabIndex = 86;
      this.btn_save.TabStop = false;
      this.btn_save.Text = "SAVE";
      this.btn_save.UseVisualStyleBackColor = true;
      StatusStrip statusStrip1_1 = this.StatusStrip1;
      point1 = new Point(0, 431);
      Point point92 = point1;
      statusStrip1_1.Location = point92;
      this.StatusStrip1.Name = "StatusStrip1";
      StatusStrip statusStrip1_2 = this.StatusStrip1;
      size1 = new Size(478, 22);
      Size size92 = size1;
      statusStrip1_2.Size = size92;
      this.StatusStrip1.TabIndex = 87;
      this.StatusStrip1.Text = "StatusStrip1";
      this.btn_restart.Enabled = false;
      this.btn_restart.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Button btnRestart1 = this.btn_restart;
      point1 = new Point(94, 397);
      Point point93 = point1;
      btnRestart1.Location = point93;
      this.btn_restart.Name = "btn_restart";
      Button btnRestart2 = this.btn_restart;
      size1 = new Size(107, 24);
      Size size93 = size1;
      btnRestart2.Size = size93;
      this.btn_restart.TabIndex = 84;
      this.btn_restart.TabStop = false;
      this.btn_restart.Text = "RESTART APP";
      this.btn_restart.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(478, 453);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.StatusStrip1);
      this.Controls.Add((Control) this.TabControl1);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.btn_restart);
      this.Controls.Add((Control) this.btn_close);
      this.Controls.Add((Control) this.btn_save);
      this.Controls.Add((Control) this.btn_device);
      this.Controls.Add((Control) this.cb_device);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.Name = nameof (form_config);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "COINAPP SETTINGS";
      this.TabControl1.ResumeLayout(false);
      this.TabPage1.ResumeLayout(false);
      this.TabPage1.PerformLayout();
      this.gb_coin6.ResumeLayout(false);
      this.gb_coin6.PerformLayout();
      this.nud_second6.EndInit();
      this.nud_pulse6.EndInit();
      this.gb_coin5.ResumeLayout(false);
      this.gb_coin5.PerformLayout();
      this.nud_second5.EndInit();
      this.nud_pulse5.EndInit();
      this.gb_coin4.ResumeLayout(false);
      this.gb_coin4.PerformLayout();
      this.nud_second4.EndInit();
      this.nud_pulse4.EndInit();
      this.gb_coin3.ResumeLayout(false);
      this.gb_coin3.PerformLayout();
      this.nud_second3.EndInit();
      this.nud_pulse3.EndInit();
      this.gb_coin2.ResumeLayout(false);
      this.gb_coin2.PerformLayout();
      this.nud_second2.EndInit();
      this.nud_pulse2.EndInit();
      this.gb_coin1.ResumeLayout(false);
      this.gb_coin1.PerformLayout();
      this.nud_second1.EndInit();
      this.nud_pulse1.EndInit();
      this.TabPage2.ResumeLayout(false);
      this.gb_bg.ResumeLayout(false);
      this.gb_bg.PerformLayout();
      this.gb_email.ResumeLayout(false);
      this.gb_email.PerformLayout();
      this.gb_pass.ResumeLayout(false);
      this.gb_pass.PerformLayout();
      this.gb_windows.ResumeLayout(false);
      this.gb_windows.PerformLayout();
      this.nud_logretry.EndInit();
      this.nud_pause.EndInit();
      this.nud_shutdowntime.EndInit();
      this.TabPage3.ResumeLayout(false);
      this.GroupBox1.ResumeLayout(false);
      this.GroupBox1.PerformLayout();
      this.gb_vouchers.ResumeLayout(false);
      this.gb_vouchers.PerformLayout();
      this.gb_dbVoucher.ResumeLayout(false);
      this.gb_dbVoucher.PerformLayout();
      this.gb_accounts.ResumeLayout(false);
      this.gb_accounts.PerformLayout();
      this.gb_dbAccount.ResumeLayout(false);
      this.gb_dbAccount.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
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

    internal virtual Button btn_device
    {
      [DebuggerNonUserCode] get
      {
        return this._btn_device;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.btn_device_MouseLeave);
        EventHandler eventHandler2 = new EventHandler(this.btn_device_MouseHover);
        EventHandler eventHandler3 = new EventHandler(this.btn_device_Click);
        if (this._btn_device != null)
        {
          this._btn_device.MouseLeave -= eventHandler1;
          this._btn_device.MouseHover -= eventHandler2;
          this._btn_device.Click -= eventHandler3;
        }
        this._btn_device = value;
        if (this._btn_device == null)
          return;
        this._btn_device.MouseLeave += eventHandler1;
        this._btn_device.MouseHover += eventHandler2;
        this._btn_device.Click += eventHandler3;
      }
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

    internal virtual TabControl TabControl1
    {
      [DebuggerNonUserCode] get
      {
        return this._TabControl1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TabControl1 = value;
      }
    }

    internal virtual TabPage TabPage1
    {
      [DebuggerNonUserCode] get
      {
        return this._TabPage1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TabPage1 = value;
      }
    }

    internal virtual TabPage TabPage2
    {
      [DebuggerNonUserCode] get
      {
        return this._TabPage2;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TabPage2 = value;
      }
    }

    internal virtual Button btn_save
    {
      [DebuggerNonUserCode] get
      {
        return this._btn_save;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btn_save_Click);
        if (this._btn_save != null)
          this._btn_save.Click -= eventHandler;
        this._btn_save = value;
        if (this._btn_save == null)
          return;
        this._btn_save.Click += eventHandler;
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
        EventHandler eventHandler = new EventHandler(this.cb_coinslot_SelectedIndexChanged);
        if (this._cb_cointype != null)
          this._cb_cointype.SelectedIndexChanged -= eventHandler;
        this._cb_cointype = value;
        if (this._cb_cointype == null)
          return;
        this._cb_cointype.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual Label Label2
    {
      [DebuggerNonUserCode] get
      {
        return this._Label2;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label2 = value;
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

    internal virtual GroupBox gb_windows
    {
      [DebuggerNonUserCode] get
      {
        return this._gb_windows;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._gb_windows = value;
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

    internal virtual Label Label12
    {
      [DebuggerNonUserCode] get
      {
        return this._Label12;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label12 = value;
      }
    }

    internal virtual NumericUpDown nud_logretry
    {
      [DebuggerNonUserCode] get
      {
        return this._nud_logretry;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.inputTextbox_TextChanged);
        if (this._nud_logretry != null)
          this._nud_logretry.TextChanged -= eventHandler;
        this._nud_logretry = value;
        if (this._nud_logretry == null)
          return;
        this._nud_logretry.TextChanged += eventHandler;
      }
    }

    internal virtual Label Label13
    {
      [DebuggerNonUserCode] get
      {
        return this._Label13;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label13 = value;
      }
    }

    internal virtual Label Label14
    {
      [DebuggerNonUserCode] get
      {
        return this._Label14;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label14 = value;
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

    internal virtual CheckBox chkbx_taskmgr
    {
      [DebuggerNonUserCode] get
      {
        return this._chkbx_taskmgr;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._chkbx_taskmgr = value;
      }
    }

    internal virtual GroupBox gb_pass
    {
      [DebuggerNonUserCode] get
      {
        return this._gb_pass;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._gb_pass = value;
      }
    }

    internal virtual TextBox txtbx_retype
    {
      [DebuggerNonUserCode] get
      {
        return this._txtbx_retype;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtbox_passwordChanged);
        if (this._txtbx_retype != null)
          this._txtbx_retype.TextChanged -= eventHandler;
        this._txtbx_retype = value;
        if (this._txtbx_retype == null)
          return;
        this._txtbx_retype.TextChanged += eventHandler;
      }
    }

    internal virtual TextBox txtbx_new
    {
      [DebuggerNonUserCode] get
      {
        return this._txtbx_new;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtbox_passwordChanged);
        if (this._txtbx_new != null)
          this._txtbx_new.TextChanged -= eventHandler;
        this._txtbx_new = value;
        if (this._txtbx_new == null)
          return;
        this._txtbx_new.TextChanged += eventHandler;
      }
    }

    internal virtual TextBox txtbx_old
    {
      [DebuggerNonUserCode] get
      {
        return this._txtbx_old;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtbox_passwordChanged);
        if (this._txtbx_old != null)
          this._txtbx_old.TextChanged -= eventHandler;
        this._txtbx_old = value;
        if (this._txtbx_old == null)
          return;
        this._txtbx_old.TextChanged += eventHandler;
      }
    }

    internal virtual Label Label17
    {
      [DebuggerNonUserCode] get
      {
        return this._Label17;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label17 = value;
      }
    }

    internal virtual Label Label16
    {
      [DebuggerNonUserCode] get
      {
        return this._Label16;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label16 = value;
      }
    }

    internal virtual Label Label15
    {
      [DebuggerNonUserCode] get
      {
        return this._Label15;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label15 = value;
      }
    }

    internal virtual Button btn_pass
    {
      [DebuggerNonUserCode] get
      {
        return this._btn_pass;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btn_pass_Click);
        if (this._btn_pass != null)
          this._btn_pass.Click -= eventHandler;
        this._btn_pass = value;
        if (this._btn_pass == null)
          return;
        this._btn_pass.Click += eventHandler;
      }
    }

    internal virtual GroupBox gb_email
    {
      [DebuggerNonUserCode] get
      {
        return this._gb_email;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._gb_email = value;
      }
    }

    internal virtual Button btn_email
    {
      [DebuggerNonUserCode] get
      {
        return this._btn_email;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btn_email_Click);
        if (this._btn_email != null)
          this._btn_email.Click -= eventHandler;
        this._btn_email = value;
        if (this._btn_email == null)
          return;
        this._btn_email.Click += eventHandler;
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
        EventHandler eventHandler = new EventHandler(this.txtbx_email_TextChanged);
        if (this._txtbx_email != null)
          this._txtbx_email.TextChanged -= eventHandler;
        this._txtbx_email = value;
        if (this._txtbx_email == null)
          return;
        this._txtbx_email.TextChanged += eventHandler;
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

    internal virtual Button btn_close
    {
      [DebuggerNonUserCode] get
      {
        return this._btn_close;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btn_close_Click);
        if (this._btn_close != null)
          this._btn_close.Click -= eventHandler;
        this._btn_close = value;
        if (this._btn_close == null)
          return;
        this._btn_close.Click += eventHandler;
      }
    }

    internal virtual GroupBox gb_coin5
    {
      [DebuggerNonUserCode] get
      {
        return this._gb_coin5;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._gb_coin5 = value;
      }
    }

    internal virtual NumericUpDown nud_second5
    {
      [DebuggerNonUserCode] get
      {
        return this._nud_second5;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.inputTextbox_TextChanged);
        if (this._nud_second5 != null)
          this._nud_second5.TextChanged -= eventHandler;
        this._nud_second5 = value;
        if (this._nud_second5 == null)
          return;
        this._nud_second5.TextChanged += eventHandler;
      }
    }

    internal virtual NumericUpDown nud_pulse5
    {
      [DebuggerNonUserCode] get
      {
        return this._nud_pulse5;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.inputTextbox_TextChanged);
        if (this._nud_pulse5 != null)
          this._nud_pulse5.TextChanged -= eventHandler;
        this._nud_pulse5 = value;
        if (this._nud_pulse5 == null)
          return;
        this._nud_pulse5.TextChanged += eventHandler;
      }
    }

    internal virtual Label Label11
    {
      [DebuggerNonUserCode] get
      {
        return this._Label11;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label11 = value;
      }
    }

    internal virtual Label Label19
    {
      [DebuggerNonUserCode] get
      {
        return this._Label19;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label19 = value;
      }
    }

    internal virtual GroupBox gb_coin4
    {
      [DebuggerNonUserCode] get
      {
        return this._gb_coin4;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._gb_coin4 = value;
      }
    }

    internal virtual NumericUpDown nud_second4
    {
      [DebuggerNonUserCode] get
      {
        return this._nud_second4;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.inputTextbox_TextChanged);
        if (this._nud_second4 != null)
          this._nud_second4.TextChanged -= eventHandler;
        this._nud_second4 = value;
        if (this._nud_second4 == null)
          return;
        this._nud_second4.TextChanged += eventHandler;
      }
    }

    internal virtual NumericUpDown nud_pulse4
    {
      [DebuggerNonUserCode] get
      {
        return this._nud_pulse4;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.inputTextbox_TextChanged);
        if (this._nud_pulse4 != null)
          this._nud_pulse4.TextChanged -= eventHandler;
        this._nud_pulse4 = value;
        if (this._nud_pulse4 == null)
          return;
        this._nud_pulse4.TextChanged += eventHandler;
      }
    }

    internal virtual Label Label9
    {
      [DebuggerNonUserCode] get
      {
        return this._Label9;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label9 = value;
      }
    }

    internal virtual Label Label10
    {
      [DebuggerNonUserCode] get
      {
        return this._Label10;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label10 = value;
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

    internal virtual GroupBox gb_coin6
    {
      [DebuggerNonUserCode] get
      {
        return this._gb_coin6;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._gb_coin6 = value;
      }
    }

    internal virtual NumericUpDown nud_second6
    {
      [DebuggerNonUserCode] get
      {
        return this._nud_second6;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.inputTextbox_TextChanged);
        if (this._nud_second6 != null)
          this._nud_second6.TextChanged -= eventHandler;
        this._nud_second6 = value;
        if (this._nud_second6 == null)
          return;
        this._nud_second6.TextChanged += eventHandler;
      }
    }

    internal virtual NumericUpDown nud_pulse6
    {
      [DebuggerNonUserCode] get
      {
        return this._nud_pulse6;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.inputTextbox_TextChanged);
        if (this._nud_pulse6 != null)
          this._nud_pulse6.TextChanged -= eventHandler;
        this._nud_pulse6 = value;
        if (this._nud_pulse6 == null)
          return;
        this._nud_pulse6.TextChanged += eventHandler;
      }
    }

    internal virtual Label Label20
    {
      [DebuggerNonUserCode] get
      {
        return this._Label20;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label20 = value;
      }
    }

    internal virtual Label Label21
    {
      [DebuggerNonUserCode] get
      {
        return this._Label21;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label21 = value;
      }
    }

    internal virtual GroupBox gb_bg
    {
      [DebuggerNonUserCode] get
      {
        return this._gb_bg;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._gb_bg = value;
      }
    }

    internal virtual Button btn_restart
    {
      [DebuggerNonUserCode] get
      {
        return this._btn_restart;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btn_restart_Click);
        if (this._btn_restart != null)
          this._btn_restart.Click -= eventHandler;
        this._btn_restart = value;
        if (this._btn_restart == null)
          return;
        this._btn_restart.Click += eventHandler;
      }
    }

    internal virtual TextBox txtbx_bgready
    {
      [DebuggerNonUserCode] get
      {
        return this._txtbx_bgready;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._txtbx_bgready = value;
      }
    }

    internal virtual Button btn_bgready
    {
      [DebuggerNonUserCode] get
      {
        return this._btn_bgready;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btn_bgready_Click);
        if (this._btn_bgready != null)
          this._btn_bgready.Click -= eventHandler;
        this._btn_bgready = value;
        if (this._btn_bgready == null)
          return;
        this._btn_bgready.Click += eventHandler;
      }
    }

    internal virtual Label label_bg
    {
      [DebuggerNonUserCode] get
      {
        return this._label_bg;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._label_bg = value;
      }
    }

    internal virtual Label Label18
    {
      [DebuggerNonUserCode] get
      {
        return this._Label18;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label18 = value;
      }
    }

    internal virtual TextBox txtbx_bgerror
    {
      [DebuggerNonUserCode] get
      {
        return this._txtbx_bgerror;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._txtbx_bgerror = value;
      }
    }

    internal virtual Button btn_bgerror
    {
      [DebuggerNonUserCode] get
      {
        return this._btn_bgerror;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btn_bgerror_Click);
        if (this._btn_bgerror != null)
          this._btn_bgerror.Click -= eventHandler;
        this._btn_bgerror = value;
        if (this._btn_bgerror == null)
          return;
        this._btn_bgerror.Click += eventHandler;
      }
    }

    internal virtual TabPage TabPage3
    {
      [DebuggerNonUserCode] get
      {
        return this._TabPage3;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TabPage3 = value;
      }
    }

    internal virtual NumericUpDown nud_pause
    {
      [DebuggerNonUserCode] get
      {
        return this._nud_pause;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._nud_pause = value;
      }
    }

    internal virtual GroupBox GroupBox1
    {
      [DebuggerNonUserCode] get
      {
        return this._GroupBox1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._GroupBox1 = value;
      }
    }

    internal virtual Label lbl_pause
    {
      [DebuggerNonUserCode] get
      {
        return this._lbl_pause;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lbl_pause = value;
      }
    }

    internal virtual CheckBox chkbx_savedata
    {
      [DebuggerNonUserCode] get
      {
        return this._chkbx_savedata;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkbx_savedata_CheckedChanged);
        if (this._chkbx_savedata != null)
          this._chkbx_savedata.CheckedChanged -= eventHandler;
        this._chkbx_savedata = value;
        if (this._chkbx_savedata == null)
          return;
        this._chkbx_savedata.CheckedChanged += eventHandler;
      }
    }

    internal virtual GroupBox gb_accounts
    {
      [DebuggerNonUserCode] get
      {
        return this._gb_accounts;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._gb_accounts = value;
      }
    }

    internal virtual TextBox txtbx_savedata
    {
      [DebuggerNonUserCode] get
      {
        return this._txtbx_savedata;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._txtbx_savedata = value;
      }
    }

    internal virtual Button btn_savedata
    {
      [DebuggerNonUserCode] get
      {
        return this._btn_savedata;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btn_savedata_Click);
        if (this._btn_savedata != null)
          this._btn_savedata.Click -= eventHandler;
        this._btn_savedata = value;
        if (this._btn_savedata == null)
          return;
        this._btn_savedata.Click += eventHandler;
      }
    }

    internal virtual GroupBox gb_vouchers
    {
      [DebuggerNonUserCode] get
      {
        return this._gb_vouchers;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._gb_vouchers = value;
      }
    }

    internal virtual CheckBox chkbx_voucher
    {
      [DebuggerNonUserCode] get
      {
        return this._chkbx_voucher;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkbx_CheckedChanged);
        if (this._chkbx_voucher != null)
          this._chkbx_voucher.CheckedChanged -= eventHandler;
        this._chkbx_voucher = value;
        if (this._chkbx_voucher == null)
          return;
        this._chkbx_voucher.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chkbx_account
    {
      [DebuggerNonUserCode] get
      {
        return this._chkbx_account;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkbx_CheckedChanged);
        if (this._chkbx_account != null)
          this._chkbx_account.CheckedChanged -= eventHandler;
        this._chkbx_account = value;
        if (this._chkbx_account == null)
          return;
        this._chkbx_account.CheckedChanged += eventHandler;
      }
    }

    internal virtual GroupBox gb_dbVoucher
    {
      [DebuggerNonUserCode] get
      {
        return this._gb_dbVoucher;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._gb_dbVoucher = value;
      }
    }

    internal virtual Label Label23
    {
      [DebuggerNonUserCode] get
      {
        return this._Label23;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label23 = value;
      }
    }

    internal virtual Label Label22
    {
      [DebuggerNonUserCode] get
      {
        return this._Label22;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label22 = value;
      }
    }

    internal virtual TextBox txtbx_dbVoucherPass
    {
      [DebuggerNonUserCode] get
      {
        return this._txtbx_dbVoucherPass;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtbx_dbVouchers_TextChanged);
        if (this._txtbx_dbVoucherPass != null)
          this._txtbx_dbVoucherPass.TextChanged -= eventHandler;
        this._txtbx_dbVoucherPass = value;
        if (this._txtbx_dbVoucherPass == null)
          return;
        this._txtbx_dbVoucherPass.TextChanged += eventHandler;
      }
    }

    internal virtual TextBox txtbx_dbVoucherName
    {
      [DebuggerNonUserCode] get
      {
        return this._txtbx_dbVoucherName;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtbx_dbVouchers_TextChanged);
        if (this._txtbx_dbVoucherName != null)
          this._txtbx_dbVoucherName.TextChanged -= eventHandler;
        this._txtbx_dbVoucherName = value;
        if (this._txtbx_dbVoucherName == null)
          return;
        this._txtbx_dbVoucherName.TextChanged += eventHandler;
      }
    }

    internal virtual Button btn_vouchers
    {
      [DebuggerNonUserCode] get
      {
        return this._btn_vouchers;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btn_vouchers_Click);
        if (this._btn_vouchers != null)
          this._btn_vouchers.Click -= eventHandler;
        this._btn_vouchers = value;
        if (this._btn_vouchers == null)
          return;
        this._btn_vouchers.Click += eventHandler;
      }
    }

    internal virtual GroupBox gb_dbAccount
    {
      [DebuggerNonUserCode] get
      {
        return this._gb_dbAccount;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._gb_dbAccount = value;
      }
    }

    internal virtual Button btn_accounts
    {
      [DebuggerNonUserCode] get
      {
        return this._btn_accounts;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btn_accounts_Click);
        if (this._btn_accounts != null)
          this._btn_accounts.Click -= eventHandler;
        this._btn_accounts = value;
        if (this._btn_accounts == null)
          return;
        this._btn_accounts.Click += eventHandler;
      }
    }

    internal virtual TextBox txtbx_dbAccountPass
    {
      [DebuggerNonUserCode] get
      {
        return this._txtbx_dbAccountPass;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtbx_dbAccountss_TextChanged);
        if (this._txtbx_dbAccountPass != null)
          this._txtbx_dbAccountPass.TextChanged -= eventHandler;
        this._txtbx_dbAccountPass = value;
        if (this._txtbx_dbAccountPass == null)
          return;
        this._txtbx_dbAccountPass.TextChanged += eventHandler;
      }
    }

    internal virtual TextBox txtbx_dbAccountName
    {
      [DebuggerNonUserCode] get
      {
        return this._txtbx_dbAccountName;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtbx_dbAccountss_TextChanged);
        if (this._txtbx_dbAccountName != null)
          this._txtbx_dbAccountName.TextChanged -= eventHandler;
        this._txtbx_dbAccountName = value;
        if (this._txtbx_dbAccountName == null)
          return;
        this._txtbx_dbAccountName.TextChanged += eventHandler;
      }
    }

    internal virtual Label Label24
    {
      [DebuggerNonUserCode] get
      {
        return this._Label24;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label24 = value;
      }
    }

    internal virtual Label Label25
    {
      [DebuggerNonUserCode] get
      {
        return this._Label25;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label25 = value;
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
      if (e.CloseReason == CloseReason.UserClosing)
      {
        if (this.working)
        {
          e.Cancel = true;
          this.labelStatus.Text = "Permorming a background operation...";
        }
        else
          this.closeConfig();
      }
      else
        this.closeConfig();
      base.OnFormClosing(e);
    }

    private void closeConfig()
    {
      if (this.exitapp)
        return;
      coinappMods.cNotifyIcon.Visible = true;
      if (!coinappMods.SerialComPort.IsOpen)
      {
        coinappMods.cNotifyIcon.Icon = coinappMods.desktop.IsAdmin ? coinappMods.pix.admin_red() : coinappMods.pix.icon_red();
        switch (coinappMods.LOCKCODE)
        {
          case 1:
            switch (coinappMods.ERR_DEVICE)
            {
              case 1:
                coinappMods.cNotifyIcon.BalloonTipText = "Error retrieving device information";
                break;
              case 2:
                coinappMods.cNotifyIcon.BalloonTipText = "No device connected";
                break;
              case 3:
                coinappMods.cNotifyIcon.BalloonTipText = "Cannot open port/Access denied";
                break;
              case 4:
                coinappMods.cNotifyIcon.BalloonTipText = "The port detected not opened";
                break;
              case 5:
                coinappMods.cNotifyIcon.BalloonTipText = "Device is not compatible";
                break;
              case 6:
                coinappMods.cNotifyIcon.BalloonTipText = "Cannot close the opened port";
                break;
              default:
                coinappMods.cNotifyIcon.BalloonTipText = "DEVICE ERROR";
                break;
            }
          case 2:
            switch (coinappMods.ERR_APPS)
            {
              case 1:
                coinappMods.cNotifyIcon.BalloonTipText = "Coinapp process terminated";
                break;
              case 2:
                coinappMods.cNotifyIcon.BalloonTipText = "Service process terminated";
                break;
              case 3:
                coinappMods.cNotifyIcon.BalloonTipText = "Service process stopped";
                break;
              case 4:
                coinappMods.cNotifyIcon.BalloonTipText = "Service uninstalled";
                break;
              case 5:
                coinappMods.cNotifyIcon.BalloonTipText = "No additional startup arguments";
                break;
              case 6:
                coinappMods.cNotifyIcon.BalloonTipText = "Invalid startup arguments";
                break;
              case 7:
                coinappMods.cNotifyIcon.BalloonTipText = "Invalid process id";
                break;
              default:
                coinappMods.cNotifyIcon.BalloonTipText = "APPLICATION ERROR";
                break;
            }
          default:
            coinappMods.cNotifyIcon.BalloonTipText = coinappMods.desktop.IsAdmin ? "Admin mode (disconnected)" : "Disconnected";
            break;
        }
        coinappMods.cNotifyIcon.ShowBalloonTip(1);
      }
      else if (!coinappMods.desktop.IsAdmin)
      {
        coinappMods.SerialComPort.Write("ADMIN=0");
        coinappMods.timerVisible = true;
        MyProject.Forms.form_main.Opacity = 100.0;
        coinappMods.pos.top(MyProject.Forms.form_main.Handle);
      }
      if (this.bgImageReady != null)
        this.bgImageReady.Dispose();
      if (this.bgImageError != null)
        this.bgImageError.Dispose();
      if (this.worker != null)
        this.worker.Dispose();
      if (this.labelStatus != null)
        this.labelStatus.Dispose();
      this.Dispose();
    }

    private void form_config_Load(object sender, EventArgs e)
    {
      this.labelStatus = new ToolStripStatusLabel();
      this.StatusStrip1.Items.Add((ToolStripItem) this.labelStatus);
      this.labelStatus.Text = "Loading configuration files....";
      if (!coinappMods.settings.configExist())
      {
        coinappMods.settings.createConfigFile();
        coinappMods.conf = new config();
        int num = (int) MessageBox.Show("Configuration file is missing.\r\nCoinapp created a new one with the default setting", "Coinapp", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      if (!coinappMods.desktop.IsAdmin && coinappMods.timerVisible)
      {
        MyProject.Forms.form_main.Opacity = 0.0;
        coinappMods.timerVisible = false;
      }
      coinappMods.cNotifyIcon.Visible = false;
      this.cb_cointype.SelectedIndex = checked (coinappMods.conf.acceptor - 1);
      this.nud_second1.Value = new Decimal(coinappMods.conf.coin1);
      this.nud_pulse1.Value = new Decimal(coinappMods.conf.pulse1);
      switch (coinappMods.conf.acceptor)
      {
        case 1:
          this.gb_coin1.Enabled = true;
          break;
        case 2:
          this.gb_coin1.Enabled = true;
          this.gb_coin2.Enabled = true;
          this.nud_second2.Value = new Decimal(coinappMods.conf.coin2);
          this.nud_pulse2.Value = new Decimal(coinappMods.conf.pulse2);
          break;
        case 3:
          this.gb_coin1.Enabled = true;
          this.gb_coin2.Enabled = true;
          this.gb_coin3.Enabled = true;
          this.nud_second2.Value = new Decimal(coinappMods.conf.coin2);
          this.nud_pulse2.Value = new Decimal(coinappMods.conf.pulse2);
          this.nud_second3.Value = new Decimal(coinappMods.conf.coin3);
          this.nud_pulse3.Value = new Decimal(coinappMods.conf.pulse3);
          break;
        case 4:
          this.gb_coin1.Enabled = true;
          this.gb_coin2.Enabled = true;
          this.gb_coin3.Enabled = true;
          this.gb_coin4.Enabled = true;
          this.gb_coin5.Enabled = true;
          this.gb_coin6.Enabled = true;
          break;
        default:
          this.cb_cointype.SelectedIndex = -1;
          this.cb_cointype.Enabled = false;
          break;
      }
      this.nud_shutdowntime.Value = new Decimal(coinappMods.conf.shutdown);
      this.nud_logretry.Value = new Decimal(coinappMods.conf.retryLog);
      this.nud_pause.Value = new Decimal(coinappMods.conf.pause);
      this.previousKeycode = coinappMods.conf.keycode;
      this.keycodeString = coinappMods.hotkey.GetKeypressed(this.previousKeycode);
      this.txtbx_hotkey.Text = this.keycodeString;
      if (coinappMods.conf.data > 0)
      {
        if (coinappMods.settings.XconfigExist(coinappMods.enc.GetMd5Hash("data")))
        {
          string Left1;
          try
          {
            Left1 = coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("data")), "data");
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            Left1 = "";
            ProjectData.ClearProjectError();
          }
          if (Operators.CompareString(Left1, "", false) != 0)
          {
            this.chkbx_savedata.Checked = true;
            this.txtbx_savedata.Text = Left1;
          }
          else
          {
            int num = (int) Interaction.MsgBox((object) "Data folder exists but no saved folder location.", MsgBoxStyle.Critical, (object) "No saved folder");
          }
          if (coinappMods.conf.voucher > 0)
          {
            string Left2;
            try
            {
              Left2 = coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("voucherFilename")), "voucher");
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              Left2 = "";
              ProjectData.ClearProjectError();
            }
            string Left3;
            try
            {
              Left3 = coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("voucherPassword")), "voucher");
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              Left3 = "";
              ProjectData.ClearProjectError();
            }
            if (Operators.CompareString(Left2, "", false) != 0 || Operators.CompareString(Left3, "", false) != 0)
            {
              this.chkbx_voucher.Checked = true;
              this.txtbx_dbVoucherName.Text = Left2;
              this.txtbx_dbVoucherPass.Text = Left3;
            }
          }
          if (coinappMods.conf.account > 0)
          {
            string Left2;
            try
            {
              Left2 = coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("accountFilename")), "account");
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              Left2 = "";
              ProjectData.ClearProjectError();
            }
            string Left3;
            try
            {
              Left3 = coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("accountPassword")), "account");
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              Left3 = "";
              ProjectData.ClearProjectError();
            }
            if (Operators.CompareString(Left2, "", false) != 0 || Operators.CompareString(Left3, "", false) != 0)
            {
              this.chkbx_account.Checked = true;
              this.txtbx_dbAccountName.Text = Left2;
              this.txtbx_dbAccountPass.Text = Left3;
            }
          }
        }
        else
        {
          int num1 = (int) Interaction.MsgBox((object) "Data folder location not exists. Select a data folder and save it again.", MsgBoxStyle.Critical, (object) null);
        }
      }
      else
      {
        this.chkbx_savedata.Checked = false;
        this.txtbx_savedata.Clear();
        this.txtbx_savedata.Enabled = false;
        this.btn_savedata.Enabled = false;
        this.chkbx_voucher.Checked = false;
        this.chkbx_account.Checked = false;
        this.gb_vouchers.Enabled = false;
        this.gb_accounts.Enabled = false;
      }
      if (coinappMods.conf.taskmgr > 0)
        this.chkbx_taskmgr.Checked = true;
      if (Operators.CompareString(coinappMods.settings.bgReady(), "", false) != 0)
      {
        if (File.Exists(coinappMods.settings.bgReady()))
        {
          bool flag;
          try
          {
            this.bgImageReady = new Bitmap(coinappMods.settings.bgReady());
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            flag = true;
            ProjectData.ClearProjectError();
          }
          if (!flag)
            this.txtbx_bgready.Text = coinappMods.settings.bgReady();
        }
      }
      if (Operators.CompareString(coinappMods.settings.bgError(), "", false) != 0)
      {
        if (File.Exists(coinappMods.settings.bgError()))
        {
          bool flag;
          try
          {
            this.bgImageError = new Bitmap(coinappMods.settings.bgError());
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            flag = true;
            ProjectData.ClearProjectError();
          }
          if (!flag)
            this.txtbx_bgerror.Text = coinappMods.settings.bgError();
        }
      }
      this.worker = new BackgroundWorker();
      this.worker.RunWorkerAsync((object) "onLoad");
    }

    private void worker_DoWork(object sender, DoWorkEventArgs e)
    {
      this.working = true;
      string Left = Conversions.ToString(e.Argument);


	  //TODO: first condition
      if (Operators.CompareString(Left, "onLoad", false) == 0)
      {
        if (this.emailExists)
        {
          try
          {
            this.email = coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("email")), "email");
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            this.email = "";
            ProjectData.ClearProjectError();
          }
          if (Operators.CompareString(this.email, "", false) == 0)
            this.Invoke((Delegate) (() => this.lbl_email.Text = "Invalid Coinapp system file."));
          else
            this.Invoke((Delegate) (() => this.lbl_email.Text = this.email));
        }
        else
          this.Invoke((Delegate) (() => this.lbl_email.Text = "Coinapp system file missing."));
        if (!this.passExists)
        {
          int num;
          this.Invoke((Delegate) (() => num = (int) MessageBox.Show("Coinapp system file is missing. \r\nRe-install the Coinapp", "Coinapp error", MessageBoxButtons.OK, MessageBoxIcon.Hand)));
        }
        try
        {
          this.xname = coinappMods.device.Name();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Exception exception = ex;
          // ISSUE: variable of a compiler-generated type
          form_config._Closure\u0024__4 other;
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          form_config._Closure\u0024__4 closure4 = new form_config._Closure\u0024__4(other);
          // ISSUE: reference to a compiler-generated field
          closure4.\u0024VB\u0024Local_ex = exception;
          coinappMods.LOCKCODE = 1;
          coinappMods.ERR_DEVICE = 1;
          this.labelStatus.Text = "Error: retrieving device information";
          this.working = false;
          // ISSUE: reference to a compiler-generated method
          this.Invoke((Delegate) new form_config.MyDelegate(closure4._Lambda\u0024__43));
          ProjectData.ClearProjectError();
          return;
        }
        if (Operators.CompareString(this.xname, "", false) != 0)
        {
          this.BeginInvoke((Delegate) (() => this.cb_device.Items.Add((object) this.xname)));
          this.BeginInvoke((Delegate) (() => this.cb_device.SelectedIndex = 0));
          if (coinappMods.SerialComPort.IsOpen)
          {
            this.BeginInvoke((Delegate) (() => this.cb_device.Enabled = false));
            this.BeginInvoke((Delegate) (() => this.btn_close.Enabled = false));
            this.BeginInvoke((Delegate) (() => this.btn_restart.Enabled = false));
            this.BeginInvoke((Delegate) (() => this.btn_device.Text = "Connected"));
            coinappMods.SerialComPort.Write("ADMIN=1");
          }
          else
          {
            this.BeginInvoke((Delegate) (() => this.btn_close.Enabled = true));
            this.BeginInvoke((Delegate) (() => this.btn_restart.Enabled = true));
            if (coinappMods.LOCKCODE == 2)
              this.BeginInvoke((Delegate) (() => this.btn_device.Enabled = false));
          }
          switch (coinappMods.LOCKCODE)
          {
            case 1:
              switch (coinappMods.ERR_DEVICE)
              {
                case 1:
                  this.labelStatus.Text = "Error retrieving device information";
                  break;
                case 2:
                  this.labelStatus.Text = "No device connected";
                  break;
                case 3:
                  this.labelStatus.Text = "Cannot open port/Access denied";
                  break;
                case 4:
                  this.labelStatus.Text = "The port detected not opened";
                  break;
                case 5:
                  this.labelStatus.Text = "Device is not compatible";
                  break;
                case 6:
                  this.labelStatus.Text = "Cannot close the opened port";
                  break;
                default:
                  this.labelStatus.Text = "DEVICE ERROR";
                  break;
              }
            case 2:
              switch (coinappMods.ERR_APPS)
              {
                case 1:
                  this.labelStatus.Text = "Coinapp process terminated";
                  break;
                case 2:
                  this.labelStatus.Text = "Service process terminated";
                  break;
                case 3:
                  this.labelStatus.Text = "Service stopped";
                  break;
                case 4:
                  this.labelStatus.Text = "Service uninstalled";
                  break;
                case 5:
                  this.labelStatus.Text = "No additional startup arguments";
                  break;
                case 6:
                  this.labelStatus.Text = "Invalid startup arguments";
                  break;
                case 7:
                  this.labelStatus.Text = "Invalid process id";
                  break;
                default:
                  this.labelStatus.Text = "APPLICATION ERROR";
                  break;
              }
            default:
              this.labelStatus.Text = "";
              break;
          }
        }
        else
        {
          coinappMods.sID = (string) null;
          coinappMods.LOCKCODE = 1;
          coinappMods.ERR_DEVICE = 2;
          this.labelStatus.Text = "Error: no device connected.";
          this.BeginInvoke((Delegate) (() => this.btn_device.Enabled = false));
          this.BeginInvoke((Delegate) (() => this.btn_restart.Enabled = true));
          this.BeginInvoke((Delegate) (() => this.btn_close.Enabled = true));
          this.working = false;
          return;
        }
      }


	  //TODO: second condition
      else if (Operators.CompareString(Left, "connect", false) == 0)
      {
        try
        {
          this.xport = coinappMods.device.Port();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Exception exception = ex;
          // ISSUE: variable of a compiler-generated type
          form_config._Closure\u0024__5 other;
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          form_config._Closure\u0024__5 closure5 = new form_config._Closure\u0024__5(other);
          // ISSUE: reference to a compiler-generated field
          closure5.\u0024VB\u0024Local_ex = exception;
          coinappMods.LOCKCODE = 1;
          coinappMods.ERR_DEVICE = 1;
          this.labelStatus.Text = "Error: retrieving device information";
          this.working = false;
          // ISSUE: reference to a compiler-generated method
          this.Invoke((Delegate) new form_config.MyDelegate(closure5._Lambda\u0024__56));
          ProjectData.ClearProjectError();
          goto label_106;
        }
        if (Operators.CompareString(this.xport, "", false) != 0)
        {
          try
          {
            coinappMods.SerialComPort.BaudRate = coinappMods.conf.baud;
            coinappMods.SerialComPort.PortName = this.xport;
            coinappMods.SerialComPort.DtrEnable = true;
            coinappMods.SerialComPort.Open();
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            Exception exception = ex;
            // ISSUE: variable of a compiler-generated type
            form_config._Closure\u0024__6 other;
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            form_config._Closure\u0024__6 closure6 = new form_config._Closure\u0024__6(other);
            // ISSUE: reference to a compiler-generated field
            closure6.\u0024VB\u0024Local_ex = exception;
            coinappMods.LOCKCODE = 1;
            coinappMods.ERR_DEVICE = 3;
            // ISSUE: reference to a compiler-generated field
            this.labelStatus.Text = closure6.\u0024VB\u0024Local_ex.Message;
            this.working = false;
            // ISSUE: reference to a compiler-generated method
            this.Invoke((Delegate) new form_config.MyDelegate(closure6._Lambda\u0024__57));
            ProjectData.ClearProjectError();
            goto label_106;
          }


		//TODO: investigate here
          if (coinappMods.SerialComPort.IsOpen)
          {
            Thread.Sleep(3000);
            coinappMods.SerialComPort.Write("REQDEVID;");
            Thread.Sleep(1000);
            if (coinappMods.deviceIsReady)
            {
              coinappMods.desktop.IsAdmin = true;
              coinappMods.SerialComPort.Write("ADMIN=1");
              coinappMods.settings.setPort(this.xport);
              coinappMods.ERR_DEVICE = 0;
              coinappMods.LOCKCODE = 0;
              this.BeginInvoke((Delegate) (() => this.cb_device.Enabled = false));
              this.BeginInvoke((Delegate) (() => this.btn_device.Text = "Connected"));
              this.BeginInvoke((Delegate) (() => this.btn_device.Enabled = true));
              this.BeginInvoke((Delegate) (() => this.btn_restart.Enabled = false));
              this.BeginInvoke((Delegate) (() => this.btn_close.Enabled = false));
              this.BeginInvoke((Delegate) (() => coinappMods.cNotifyIcon.Icon = coinappMods.pix.admin()));
              this.labelStatus.Text = "Connected to " + this.xname + " successfully.";
              int num;
              this.Invoke((Delegate) (() => num = (int) MessageBox.Show("Connected to the device successfully", "Coinapp connect", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)));
            }
            else
            {
              coinappMods.LOCKCODE = 1;
              coinappMods.ERR_DEVICE = 5;
              this.labelStatus.Text = "Device not compatible. " + this.xname + " is not a Coinapp device.";
              this.BeginInvoke((Delegate) (() => coinappMods.cNotifyIcon.Icon = coinappMods.pix.admin_red()));
              this.working = false;
              int num;
              this.Invoke((Delegate) (() => num = (int) Interaction.MsgBox((object) ("Device not compatible. " + this.xname + " is not a Coinapp device."), MsgBoxStyle.Critical, (object) null)));
              try
              {
                coinappMods.SerialComPort.Close();
                goto label_106;
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                Exception exception = ex;
                // ISSUE: variable of a compiler-generated type
                form_config._Closure\u0024__7 other;
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                form_config._Closure\u0024__7 closure7 = new form_config._Closure\u0024__7(other);
                // ISSUE: reference to a compiler-generated field
                closure7.\u0024VB\u0024Local_ex = exception;
                coinappMods.ERR_DEVICE = 6;
                // ISSUE: reference to a compiler-generated field
                this.labelStatus.Text = closure7.\u0024VB\u0024Local_ex.Message;
                this.working = false;
                // ISSUE: reference to a compiler-generated method
                this.Invoke((Delegate) new form_config.MyDelegate(closure7._Lambda\u0024__67));
                ProjectData.ClearProjectError();
                goto label_106;
              }
            }
          }
          else
          {
            coinappMods.LOCKCODE = 1;
            coinappMods.ERR_DEVICE = 4;
            this.labelStatus.Text = "Connecting to the device failed.";
            this.BeginInvoke((Delegate) (() => coinappMods.cNotifyIcon.Icon = coinappMods.pix.admin_red()));
            this.working = false;
            int num;
            this.Invoke((Delegate) (() => num = (int) Interaction.MsgBox((object) "Connecting to the device failed.", MsgBoxStyle.Critical, (object) null)));
            goto label_106;
          }
        }
        else
        {
          coinappMods.LOCKCODE = 1;
          coinappMods.ERR_DEVICE = 2;
          this.labelStatus.Text = "Error: no device connected.";
          this.working = false;
          int num;
          this.Invoke((Delegate) (() => num = (int) Interaction.MsgBox((object) "Error: no device connected.", MsgBoxStyle.Critical, (object) null)));
        }
      }


	  // TODO: 3rd condition
      else if (Operators.CompareString(Left, "save", false) == 0)
      {
        if (coinappMods.SerialComPort.IsOpen)
        {
          this.labelStatus.Text = "Disconnecting first the device";
          try
          {
            coinappMods.SerialComPort.Write("DISC;");
            coinappMods.SerialComPort.Close();
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            Exception exception = ex;
            this.labelStatus.Text = "An error occured while saving. Cannot continue";
            this.BeginInvoke((Delegate) (() => this.cb_device.Enabled = true));
            this.BeginInvoke((Delegate) (() => this.btn_restart.Enabled = true));
            this.BeginInvoke((Delegate) (() => this.btn_close.Enabled = true));
            this.working = false;
            int num = (int) Interaction.MsgBox((object) exception.Message, MsgBoxStyle.Critical, (object) null);
            ProjectData.ClearProjectError();
            return;
          }
          if (!coinappMods.SerialComPort.IsOpen)
          {
            this.BeginInvoke((Delegate) (() => this.btn_device.Text = "Disconnected"));
          }
          else
          {
            this.working = false;
            this.BeginInvoke((Delegate) (() => this.cb_device.Enabled = true));
            this.BeginInvoke((Delegate) (() => this.btn_restart.Enabled = true));
            this.BeginInvoke((Delegate) (() => this.btn_close.Enabled = true));
            int num = (int) Interaction.MsgBox((object) "An error occured while saving. Cannot continue", MsgBoxStyle.Critical, (object) null);
            return;
          }
        }
        if (!coinappMods.settings.configExist())
        {
          try
          {
            coinappMods.settings.createConfigFile();
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            Exception exception = ex;
            // ISSUE: variable of a compiler-generated type
            form_config._Closure\u0024__8 other;
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            form_config._Closure\u0024__8 closure8 = new form_config._Closure\u0024__8(other);
            // ISSUE: reference to a compiler-generated field
            closure8.\u0024VB\u0024Local_ex = exception;
            this.labelStatus.Text = "Error: cannot create configuration file.";
            this.working = false;
            // ISSUE: reference to a compiler-generated method
            this.Invoke((Delegate) new form_config.MyDelegate(closure8._Lambda\u0024__78));
            ProjectData.ClearProjectError();
            return;
          }
        }
        try
        {
          coinappMods.settings.setCoin1(this.nud_second1.Text, this.nud_pulse1.Text);
          coinappMods.settings.setShutdown(this.nud_shutdowntime.Text);
          coinappMods.settings.setRetryLog(this.nud_logretry.Text);
          coinappMods.settings.setPause(this.nud_pause.Text);
          if (this.keycode != 0)
            coinappMods.settings.setKeycode(this.keycode);
          this.BeginInvoke((Delegate) (() => this.configureCointype()));
          if (Operators.CompareString(this.txtbx_bgready.Text, "", false) != 0 && File.Exists(this.txtbx_bgready.Text))
            coinappMods.settings.setBgReady(this.txtbx_bgready.Text);
          else
            coinappMods.settings.setBgReady("");
          if (Operators.CompareString(this.txtbx_bgerror.Text, "", false) != 0 && File.Exists(this.txtbx_bgerror.Text))
            coinappMods.settings.setBgError(this.txtbx_bgerror.Text);
          else
            coinappMods.settings.setBgError("");
          if (!this.chkbx_savedata.Checked)
          {
            coinappMods.settings.setData(0);
            coinappMods.settings.writeSystemFile(coinappMods.enc.GetMd5Hash("data"), coinappMods.enc.Encrypt("", "data"));
          }
          else if (Operators.CompareString(this.txtbx_savedata.Text, "", false) == 0)
          {
            coinappMods.settings.setData(0);
            coinappMods.settings.writeSystemFile(coinappMods.enc.GetMd5Hash("data"), coinappMods.enc.Encrypt("", "data"));
          }
          else
          {
            bool flag = true;
            if (!Directory.Exists(this.txtbx_savedata.Text))
            {
              try
              {
                Directory.CreateDirectory(this.txtbx_savedata.Text);
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                flag = false;
                ProjectData.ClearProjectError();
              }
            }
            if (flag)
            {
              coinappMods.settings.setData(1);
              coinappMods.settings.writeSystemFile(coinappMods.enc.GetMd5Hash("data"), coinappMods.enc.Encrypt(this.txtbx_savedata.Text, "data"));
            }
            else
            {
              coinappMods.settings.setData(0);
              coinappMods.settings.writeSystemFile(coinappMods.enc.GetMd5Hash("data"), coinappMods.enc.Encrypt("", "data"));
            }
            if (this.chkbx_voucher.Checked)
            {
              coinappMods.settings.setVoucher(1);
              coinappMods.settings.writeSystemFile(coinappMods.enc.GetMd5Hash("voucherFilename"), coinappMods.enc.Encrypt(this.txtbx_dbVoucherName.Text, "voucher"));
              coinappMods.settings.writeSystemFile(coinappMods.enc.GetMd5Hash("voucherPassword"), coinappMods.enc.Encrypt(this.txtbx_dbVoucherPass.Text, "voucher"));
            }
            else
            {
              coinappMods.settings.setVoucher(0);
              coinappMods.settings.writeSystemFile(coinappMods.enc.GetMd5Hash("voucherFilename"), coinappMods.enc.Encrypt("", "voucher"));
              coinappMods.settings.writeSystemFile(coinappMods.enc.GetMd5Hash("voucherPassword"), coinappMods.enc.Encrypt("", "voucher"));
            }
            if (this.chkbx_account.Checked)
            {
              coinappMods.settings.setAccount(1);
              coinappMods.settings.writeSystemFile(coinappMods.enc.GetMd5Hash("accountFilename"), coinappMods.enc.Encrypt(this.txtbx_dbAccountName.Text, "account"));
              coinappMods.settings.writeSystemFile(coinappMods.enc.GetMd5Hash("accountPassword"), coinappMods.enc.Encrypt(this.txtbx_dbAccountPass.Text, "account"));
            }
            else
            {
              coinappMods.settings.setAccount(0);
              coinappMods.settings.writeSystemFile(coinappMods.enc.GetMd5Hash("accountFilename"), coinappMods.enc.Encrypt("", "account"));
              coinappMods.settings.writeSystemFile(coinappMods.enc.GetMd5Hash("accountPassword"), coinappMods.enc.Encrypt("", "account"));
            }
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Exception exception = ex;
          // ISSUE: variable of a compiler-generated type
          form_config._Closure\u0024__9 other;
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          form_config._Closure\u0024__9 closure9 = new form_config._Closure\u0024__9(other);
          // ISSUE: reference to a compiler-generated field
          closure9.\u0024VB\u0024Local_ex = exception;
          this.labelStatus.Text = "Error occured while saving.";
          this.working = false;
          // ISSUE: reference to a compiler-generated method
          this.Invoke((Delegate) new form_config.MyDelegate(closure9._Lambda\u0024__80));
          ProjectData.ClearProjectError();
          return;
        }
        this.labelStatus.Text = "Save settings successfully. Restarting COINAPP...";
        if (coinappMods.serviceMonitor.IsAlive)
          coinappMods.serviceMonitor.Abort();
        coinappMods.serviceWatcher.Stop();
        coinappMods.serviceControllers = ServiceController.GetServices();
        coinappMods.serviceExist = ((IEnumerable<ServiceController>) coinappMods.serviceControllers).Any<ServiceController>((Func<ServiceController, bool>) (x => Operators.CompareString(x.ServiceName, coinappMods.serviceName, false) == 0));
        if (!coinappMods.serviceExist)
        {
          this.labelStatus.Text = "Error while restarting coinapp";
          int num = (int) MessageBox.Show("Error while restarting coinapp.", "Coinapp restart", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        else
        {
          this.working = false;
          this.exitapp = true;
          using (ServiceController serviceController = new ServiceController(coinappMods.serviceName))
          {
            if (serviceController.Status == ServiceControllerStatus.Running)
            {
              serviceController.Stop();
              serviceController.WaitForStatus(ServiceControllerStatus.Stopped);
            }
            serviceController.Start();
            serviceController.WaitForStatus(ServiceControllerStatus.Running);
          }
        }
      }



	  //TODO: 4th condition
      else
      {
        this.labelStatus.Text = "Invalid arguments.";
        SystemSounds.Hand.Play();
        this.working = false;
      }
      if (coinappMods.LOCKCODE != 1)
        goto label_107;
label_106:
      this.BeginInvoke((Delegate) (() => this.cb_device.Enabled = true));
      this.BeginInvoke((Delegate) (() => this.btn_device.Enabled = true));
      this.BeginInvoke((Delegate) (() => this.btn_device.Text = "Disconnected"));
      this.BeginInvoke((Delegate) (() => this.btn_close.Enabled = true));
      this.BeginInvoke((Delegate) (() => this.btn_restart.Enabled = true));
label_107:
      this.working = false;
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
          this.labelStatus.Text = "Super multi-coin feature is not available.";
          break;
      }
    }

    private void txtbx_email_TextChanged(object sender, EventArgs e)
    {
      if (coinappMods.isValidEmail(Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "Text", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))) && Operators.CompareString(Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "Text", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), "", false) != 0)
        this.btn_email.Enabled = true;
      else
        this.btn_email.Enabled = false;
    }

    private void btn_device_MouseHover(object sender, EventArgs e)
    {
      if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (System.Type) null, "Text", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Connected", false) && coinappMods.LOCKCODE != 1)
      {
        NewLateBinding.LateSet(sender, (System.Type) null, "Text", new object[1]
        {
          (object) "Disconnect"
        }, (string[]) null, (System.Type[]) null);
      }
      else
      {
        if (!Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (System.Type) null, "Text", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Disconnected", false) || Operators.CompareString(this.xname, "", false) == 0)
          return;
        NewLateBinding.LateSet(sender, (System.Type) null, "Text", new object[1]
        {
          (object) "Connect"
        }, (string[]) null, (System.Type[]) null);
      }
    }

    private void btn_device_MouseLeave(object sender, EventArgs e)
    {
      if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (System.Type) null, "Text", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Disconnect", false) && coinappMods.LOCKCODE != 1)
      {
        NewLateBinding.LateSet(sender, (System.Type) null, "Text", new object[1]
        {
          (object) "Connected"
        }, (string[]) null, (System.Type[]) null);
      }
      else
      {
        if (!Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (System.Type) null, "Text", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Connect", false) || Operators.CompareString(this.xname, "", false) == 0)
          return;
        NewLateBinding.LateSet(sender, (System.Type) null, "Text", new object[1]
        {
          (object) "Disconnected"
        }, (string[]) null, (System.Type[]) null);
      }
    }

    private void btn_email_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Do you really want to change your recovery email?", "Coinapp change email", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
      {
        coinappMods.settings.writeSystemFile(coinappMods.enc.GetMd5Hash("email"), coinappMods.enc.Encrypt(this.txtbx_email.Text, "email"));
        this.lbl_email.Text = this.txtbx_email.Text;
        this.txtbx_email.Text = (string) null;
        int num = (int) MessageBox.Show("Recovery email changed successfully. Do not forget your new Email.", "Coinapp change email", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      this.ActiveControl = (Control) null;
    }

    private void btn_pass_Click(object sender, EventArgs e)
    {
      try
      {
        this.pass = coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("password")), "password");
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.pass = "";
        ProjectData.ClearProjectError();
      }
      if (Operators.CompareString(this.pass, "", false) == 0)
      {
        int num1 = (int) MessageBox.Show("Coinapp system file is missing. \r\nRe-install the Coinapp", "Coinapp error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else if (Operators.CompareString(this.txtbx_old.Text, this.pass, false) != 0)
      {
        int num2 = (int) MessageBox.Show("Incorrect current password.", "Coinapp change password", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else if (Operators.CompareString(this.txtbx_new.Text, this.txtbx_retype.Text, false) != 0)
      {
        int num3 = (int) MessageBox.Show("New password and retype password not match.", "Coinapp change password", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else
      {
        if (MessageBox.Show("Do you really want to change your password?", "Coinapp change password", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
        {
          coinappMods.settings.writeSystemFile(coinappMods.enc.GetMd5Hash("password"), coinappMods.enc.Encrypt(this.txtbx_new.Text, "password"));
          this.txtbx_old.Text = (string) null;
          this.txtbx_new.Text = (string) null;
          this.txtbx_retype.Text = (string) null;
          int num4 = (int) MessageBox.Show("Changed password successfully. Do not forget your new password.", "Coinapp change password", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        this.ActiveControl = (Control) null;
      }
    }

    private void txtbox_passwordChanged(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.txtbx_old.Text, "", false) != 0 && Operators.CompareString(this.txtbx_new.Text, "", false) != 0 && Operators.CompareString(this.txtbx_retype.Text, "", false) != 0)
        this.btn_pass.Enabled = true;
      else
        this.btn_pass.Enabled = false;
    }

    private void cb_coinslot_SelectedIndexChanged(object sender, EventArgs e)
    {
      switch (Conversions.ToInteger(NewLateBinding.LateGet(sender, (System.Type) null, "SelectedIndex", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)))
      {
        case 0:
          this.gb_coin1.Enabled = true;
          this.gb_coin2.Enabled = false;
          this.gb_coin3.Enabled = false;
          this.gb_coin4.Enabled = false;
          this.gb_coin5.Enabled = false;
          this.gb_coin6.Enabled = false;
          this.nud_second2.Value = Decimal.Zero;
          this.nud_second3.Value = Decimal.Zero;
          this.nud_second4.Value = Decimal.Zero;
          this.nud_second5.Value = Decimal.Zero;
          this.nud_second6.Value = Decimal.Zero;
          this.nud_pulse2.Value = Decimal.Zero;
          this.nud_pulse3.Value = Decimal.Zero;
          this.nud_pulse4.Value = Decimal.Zero;
          this.nud_pulse5.Value = Decimal.Zero;
          this.nud_pulse6.Value = Decimal.Zero;
          break;
        case 1:
          this.gb_coin1.Enabled = true;
          this.gb_coin2.Enabled = true;
          this.gb_coin3.Enabled = false;
          this.gb_coin4.Enabled = false;
          this.gb_coin5.Enabled = false;
          this.gb_coin6.Enabled = false;
          this.nud_second3.Value = Decimal.Zero;
          this.nud_second4.Value = Decimal.Zero;
          this.nud_second5.Value = Decimal.Zero;
          this.nud_second6.Value = Decimal.Zero;
          this.nud_pulse3.Value = Decimal.Zero;
          this.nud_pulse4.Value = Decimal.Zero;
          this.nud_pulse5.Value = Decimal.Zero;
          this.nud_pulse6.Value = Decimal.Zero;
          break;
        case 2:
          this.gb_coin1.Enabled = true;
          this.gb_coin2.Enabled = true;
          this.gb_coin3.Enabled = true;
          this.gb_coin4.Enabled = false;
          this.gb_coin5.Enabled = false;
          this.gb_coin6.Enabled = false;
          this.nud_second4.Value = Decimal.Zero;
          this.nud_second5.Value = Decimal.Zero;
          this.nud_second6.Value = Decimal.Zero;
          this.nud_pulse4.Value = Decimal.Zero;
          this.nud_pulse5.Value = Decimal.Zero;
          this.nud_pulse6.Value = Decimal.Zero;
          break;
        case 3:
          this.gb_coin1.Enabled = true;
          this.gb_coin2.Enabled = true;
          this.gb_coin3.Enabled = true;
          this.gb_coin4.Enabled = true;
          this.gb_coin5.Enabled = true;
          this.gb_coin6.Enabled = true;
          break;
        default:
          this.gb_coin1.Enabled = false;
          this.gb_coin2.Enabled = false;
          this.gb_coin3.Enabled = false;
          this.gb_coin4.Enabled = false;
          this.gb_coin5.Enabled = false;
          this.gb_coin6.Enabled = false;
          this.nud_second1.Value = Decimal.Zero;
          this.nud_second2.Value = Decimal.Zero;
          this.nud_second3.Value = Decimal.Zero;
          this.nud_second4.Value = Decimal.Zero;
          this.nud_second5.Value = Decimal.Zero;
          this.nud_second6.Value = Decimal.Zero;
          this.nud_pulse1.Value = Decimal.Zero;
          this.nud_pulse2.Value = Decimal.Zero;
          this.nud_pulse3.Value = Decimal.Zero;
          this.nud_pulse4.Value = Decimal.Zero;
          this.nud_pulse5.Value = Decimal.Zero;
          this.nud_pulse6.Value = Decimal.Zero;
          break;
      }
      this.ValidInputBox();
    }

    private void txtbx_hotkey_KeyDown(object sender, KeyEventArgs e)
    {
      if ((e.KeyCode < System.Windows.Forms.Keys.NumPad0 || e.KeyCode > System.Windows.Forms.Keys.NumPad9) && (e.KeyCode != System.Windows.Forms.Keys.Decimal && e.KeyCode != System.Windows.Forms.Keys.Pause) && (e.KeyCode != System.Windows.Forms.Keys.Tab && e.KeyCode != System.Windows.Forms.Keys.LWin && e.KeyCode != System.Windows.Forms.Keys.RWin) && (e.KeyCode < System.Windows.Forms.Keys.ShiftKey || e.KeyCode > System.Windows.Forms.Keys.Menu))
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

    private void btn_device_Click(object sender, EventArgs e)
    {
      this.ActiveControl = (Control) null;
      if (this.working)
      {
        int num1 = (int) Interaction.MsgBox((object) "Performing background operation. Please wait a moment.", MsgBoxStyle.Critical, (object) null);
      }
      else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (System.Type) null, "Text", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Connect", false) && !coinappMods.SerialComPort.IsOpen)
      {
        this.labelStatus.Text = "Connecting to " + this.xname + " device...";
        this.btn_device.Enabled = false;
        this.cb_device.Enabled = false;
        this.btn_close.Enabled = false;
        this.btn_restart.Enabled = false;
        coinappMods.cNotifyIcon.Icon = coinappMods.pix.admin();
        coinappMods.cNotifyIcon.ContextMenuStrip = coinappMods.cAdminContextMenuStrip;
        this.worker = new BackgroundWorker();
        this.worker.RunWorkerAsync((object) "connect");
      }
      else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (System.Type) null, "Text", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Disconnect", false) && coinappMods.SerialComPort.IsOpen && MessageBox.Show("Disconnect to device. Continue?", "Coinapp disconnect", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
      {
        this.labelStatus.Text = "Disconnecting...";
        try
        {
          coinappMods.SerialComPort.Write("DISC;");
          coinappMods.SerialComPort.Close();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          coinappMods.ERR_DEVICE = 6;
          this.labelStatus.Text = "Error disconnecting to the device.";
          SystemSounds.Hand.Play();
          ProjectData.ClearProjectError();
          return;
        }
        if (!coinappMods.SerialComPort.IsOpen)
        {
          coinappMods.sID = (string) null;
          coinappMods.credits = 0;
          coinappMods.deviceIsReady = false;
          coinappMods.desktop.IsAdmin = true;
          coinappMods.LOCKCODE = 1;
          coinappMods.ERR_DEVICE = 2;
          this.cb_device.Enabled = true;
          this.btn_close.Enabled = true;
          this.btn_restart.Enabled = true;
          this.btn_device.Text = "Disconnected";
          coinappMods.cNotifyIcon.Icon = coinappMods.pix.admin_red();
          coinappMods.cNotifyIcon.ContextMenuStrip = coinappMods.cAdminContextMenuStrip;
          this.labelStatus.Text = "Disconnected.";
          this.working = false;
          int num2;
          this.Invoke((Delegate) (() => num2 = (int) MessageBox.Show("Disconnected to the device.", "Coinapp disconnect", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)));
        }
        else
        {
          coinappMods.ERR_DEVICE = 6;
          this.labelStatus.Text = "Error disconnecting device.";
          this.working = false;
          int num2;
          this.Invoke((Delegate) (() => num2 = (int) MessageBox.Show("Error disconnecting device", "Coinapp disconnect", MessageBoxButtons.OK, MessageBoxIcon.Hand)));
        }
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
        this.labelStatus.Text = "Input a valid data to enable the SAVE button.";
        this.btn_save.Enabled = false;
      }
    }

    private void ValidInputBox()
    {
      if (Operators.CompareString(this.nud_shutdowntime.Text, "0", false) != 0 && Operators.CompareString(this.nud_shutdowntime.Text, "", false) != 0 && (Operators.CompareString(Conversions.ToString(this.nud_shutdowntime.Text.First<char>()), "0", false) != 0 && this.nud_shutdowntime.Text.Count<char>() != 1) && (Operators.CompareString(this.nud_logretry.Text, "0", false) != 0 && Operators.CompareString(this.nud_logretry.Text, "", false) != 0 && (Operators.CompareString(this.txtbx_hotkey.Text, "", false) != 0 && Operators.CompareString(this.txtbx_hotkey.Text, "click to set", false) != 0)) && Operators.CompareString(this.txtbx_hotkey.Text, "press a key", false) != 0)
      {
        if (this.cb_cointype.SelectedIndex == 0)
        {
          if (Operators.CompareString(this.nud_second1.Text, "0", false) != 0 && Operators.CompareString(this.nud_second1.Text, "", false) != 0 && (Operators.CompareString(this.nud_pulse1.Text, "0", false) != 0 && Operators.CompareString(this.nud_pulse1.Text, "", false) != 0))
          {
            this.labelStatus.Text = "";
            this.btn_save.Enabled = true;
          }
          else
          {
            this.labelStatus.Text = "Input a valid data to enable the SAVE button.";
            this.btn_save.Enabled = false;
          }
        }
        else if (this.cb_cointype.SelectedIndex == 1)
        {
          if (Operators.CompareString(this.nud_second1.Text, "0", false) != 0 && Operators.CompareString(this.nud_second1.Text, "", false) != 0 && (Operators.CompareString(this.nud_pulse1.Text, "0", false) != 0 && Operators.CompareString(this.nud_pulse1.Text, "", false) != 0) && (Operators.CompareString(this.nud_second2.Text, "0", false) != 0 && Operators.CompareString(this.nud_second2.Text, "", false) != 0 && (Operators.CompareString(this.nud_pulse2.Text, "0", false) != 0 && Operators.CompareString(this.nud_pulse2.Text, "", false) != 0)))
          {
            this.labelStatus.Text = "";
            this.btn_save.Enabled = true;
          }
          else
          {
            this.labelStatus.Text = "Input a valid data to enable the SAVE button.";
            this.btn_save.Enabled = false;
          }
        }
        else if (this.cb_cointype.SelectedIndex == 2)
        {
          if (Operators.CompareString(this.nud_second1.Text, "0", false) != 0 && Operators.CompareString(this.nud_second1.Text, "", false) != 0 && (Operators.CompareString(this.nud_pulse1.Text, "0", false) != 0 && Operators.CompareString(this.nud_pulse1.Text, "", false) != 0) && (Operators.CompareString(this.nud_second2.Text, "0", false) != 0 && Operators.CompareString(this.nud_second2.Text, "", false) != 0 && (Operators.CompareString(this.nud_pulse2.Text, "0", false) != 0 && Operators.CompareString(this.nud_pulse2.Text, "", false) != 0)) && (Operators.CompareString(this.nud_second3.Text, "0", false) != 0 && Operators.CompareString(this.nud_second3.Text, "", false) != 0 && (Operators.CompareString(this.nud_pulse3.Text, "0", false) != 0 && Operators.CompareString(this.nud_pulse3.Text, "", false) != 0)))
          {
            this.labelStatus.Text = "";
            this.btn_save.Enabled = true;
          }
          else
          {
            this.labelStatus.Text = "Input a valid data to enable the SAVE button.";
            this.btn_save.Enabled = false;
          }
        }
        else if (this.cb_cointype.SelectedIndex == 3)
        {
          if (Operators.CompareString(this.nud_second1.Text, "0", false) != 0 && Operators.CompareString(this.nud_second1.Text, "", false) != 0 && (Operators.CompareString(this.nud_pulse1.Text, "0", false) != 0 && Operators.CompareString(this.nud_pulse1.Text, "", false) != 0) && (Operators.CompareString(this.nud_second2.Text, "0", false) != 0 && Operators.CompareString(this.nud_second2.Text, "", false) != 0 && (Operators.CompareString(this.nud_pulse2.Text, "0", false) != 0 && Operators.CompareString(this.nud_pulse2.Text, "", false) != 0)) && (Operators.CompareString(this.nud_second3.Text, "0", false) != 0 && Operators.CompareString(this.nud_second3.Text, "", false) != 0 && (Operators.CompareString(this.nud_pulse3.Text, "0", false) != 0 && Operators.CompareString(this.nud_pulse3.Text, "", false) != 0) && (Operators.CompareString(this.nud_second4.Text, "0", false) != 0 && Operators.CompareString(this.nud_second4.Text, "", false) != 0 && (Operators.CompareString(this.nud_pulse4.Text, "0", false) != 0 && Operators.CompareString(this.nud_pulse4.Text, "", false) != 0))) && (Operators.CompareString(this.nud_second5.Text, "0", false) != 0 && Operators.CompareString(this.nud_second5.Text, "", false) != 0 && (Operators.CompareString(this.nud_pulse5.Text, "0", false) != 0 && Operators.CompareString(this.nud_pulse5.Text, "", false) != 0) && (Operators.CompareString(this.nud_second6.Text, "0", false) != 0 && Operators.CompareString(this.nud_second6.Text, "", false) != 0 && (Operators.CompareString(this.nud_pulse6.Text, "0", false) != 0 && Operators.CompareString(this.nud_pulse6.Text, "", false) != 0))))
          {
            this.labelStatus.Text = "";
            this.btn_save.Enabled = true;
          }
          else
          {
            this.labelStatus.Text = "Input a valid data to enable the SAVE button.";
            this.btn_save.Enabled = false;
          }
        }
        else
        {
          this.labelStatus.Text = "Input a valid data to enable the SAVE button.";
          this.btn_save.Enabled = false;
        }
      }
      else
      {
        this.labelStatus.Text = "Input a valid data to enable the SAVE button.";
        this.btn_save.Enabled = false;
      }
    }

    private void btn_save_Click(object sender, EventArgs e)
    {
      this.ActiveControl = (Control) null;
      if (this.working)
      {
        int num = (int) Interaction.MsgBox((object) "Performing background operation. Please wait a moment.", MsgBoxStyle.Critical, (object) null);
      }
      else if (MessageBox.Show("Saving settings require RESTART COINAPP .\r\n\r\nCOINAPP will restart automatically when successfully save.\r\nDo you want to continue?", "Saving settings", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
      {
        this.labelStatus.Text = "Saving settings please wait...";
        this.cb_device.Enabled = false;
        this.btn_save.Enabled = false;
        this.btn_restart.Enabled = false;
        this.btn_close.Enabled = false;
        this.worker = new BackgroundWorker();
        this.worker.RunWorkerAsync((object) "save");
      }
    }

    private void btn_close_Click(object sender, EventArgs e)
    {
      this.ActiveControl = (Control) null;
      if (this.working)
      {
        int num1 = (int) Interaction.MsgBox((object) "Performing background operation. Please wait a moment.", MsgBoxStyle.Critical, (object) null);
      }
      else if (MessageBox.Show("If you close the application, you will need to restart the PC to open the Coinapp again. Continue?", "Coinapp close", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
      {
        this.labelStatus.Text = "Closing coinapp please wait...";
        coinappMods.serviceControllers = ServiceController.GetServices();
        coinappMods.serviceExist = ((IEnumerable<ServiceController>) coinappMods.serviceControllers).Any<ServiceController>((Func<ServiceController, bool>) (x => Operators.CompareString(x.ServiceName, coinappMods.serviceName, false) == 0));
        if (!coinappMods.serviceExist)
        {
          this.exitapp = true;
          this.labelStatus.Text = "No coinapp service installed. Re-install application";
          int num2 = (int) MessageBox.Show("Error while closing coinapp.\r\nNo coinapp service installed.", "Coinapp close", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          if (MessageBox.Show("Close now?", "Coinapp close", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
          {
            int num3 = (int) coinappMods.powerMode.saveOn();
            try
            {
              Environment.Exit(0);
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              int num4 = (int) Interaction.MsgBox((object) ex.Message, MsgBoxStyle.Critical, (object) null);
              ProjectData.ClearProjectError();
            }
          }
        }
        else
        {
          this.exitapp = true;
          this.btn_restart.Enabled = false;
          this.btn_close.Enabled = false;
          this.btn_save.Enabled = false;
          if (coinappMods.serviceMonitor.IsAlive)
            coinappMods.serviceMonitor.Abort();
          coinappMods.serviceWatcher.Stop();
          using (ServiceController serviceController = new ServiceController(coinappMods.serviceName))
          {
            if (serviceController.Status == ServiceControllerStatus.Running)
            {
              serviceController.Stop();
              serviceController.WaitForStatus(ServiceControllerStatus.Stopped);
            }
          }
          int num2 = (int) coinappMods.powerMode.saveOn();
          try
          {
            Environment.Exit(0);
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            int num3 = (int) Interaction.MsgBox((object) ex.Message, MsgBoxStyle.Critical, (object) null);
            ProjectData.ClearProjectError();
          }
        }
      }
    }

    private void btn_restart_Click(object sender, EventArgs e)
    {
      this.ActiveControl = (Control) null;
      if (this.working)
      {
        int num1 = (int) Interaction.MsgBox((object) "Performing background operation. Please wait a moment.", MsgBoxStyle.Critical, (object) null);
      }
      else if (MessageBox.Show("You wish to restart the Coinapp, Continue?", "Coinapp restart", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
      {
        this.labelStatus.Text = "Restarting, please wait...";
        coinappMods.serviceControllers = ServiceController.GetServices();
        coinappMods.serviceExist = ((IEnumerable<ServiceController>) coinappMods.serviceControllers).Any<ServiceController>((Func<ServiceController, bool>) (x => Operators.CompareString(x.ServiceName, coinappMods.serviceName, false) == 0));
        if (!coinappMods.serviceExist)
        {
          this.exitapp = true;
          this.labelStatus.Text = "No coinapp service installed. Re-install application";
          int num2 = (int) MessageBox.Show("Error while restarting coinapp.\r\nNo coinapp service installed.", "Coinapp restart", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          if (MessageBox.Show("Close now?", "Coinapp restart", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
          {
            try
            {
              Environment.Exit(0);
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              int num3 = (int) Interaction.MsgBox((object) ex.Message, MsgBoxStyle.Critical, (object) null);
              ProjectData.ClearProjectError();
            }
          }
        }
        else
        {
          this.exitapp = true;
          this.btn_restart.Enabled = false;
          this.btn_close.Enabled = false;
          this.btn_save.Enabled = false;
          if (coinappMods.serviceMonitor.IsAlive)
            coinappMods.serviceMonitor.Abort();
          coinappMods.serviceWatcher.Stop();
          using (ServiceController serviceController = new ServiceController(coinappMods.serviceName))
          {
            if (serviceController.Status == ServiceControllerStatus.Running)
            {
              serviceController.Stop();
              serviceController.WaitForStatus(ServiceControllerStatus.Stopped);
            }
            serviceController.Start();
            serviceController.WaitForStatus(ServiceControllerStatus.Running);
          }
        }
      }
    }

    private void btn_bgready_Click(object sender, EventArgs e)
    {
      this.ActiveControl = (Control) null;
      if (this.working)
      {
        int num1 = (int) MessageBox.Show("Performing background operation. Please wait a moment.", "Background image", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else
      {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.InitialDirectory = Application.StartupPath;
        openFileDialog.Title = "Background image READY for Coinapp";
        openFileDialog.Filter = "JPEG|*.jpg";
        if (openFileDialog.ShowDialog() == DialogResult.Cancel)
          return;
        try
        {
          this.bgImageReady = new Bitmap(openFileDialog.FileName);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          int num2 = (int) Interaction.MsgBox((object) "Selected file is not a valid JPG file.", MsgBoxStyle.Critical, (object) null);
          ProjectData.ClearProjectError();
          return;
        }
        this.txtbx_bgready.Text = Path.GetFullPath(openFileDialog.FileName);
        openFileDialog.Dispose();
        this.bgImageReady.Dispose();
      }
    }

    private void btn_bgerror_Click(object sender, EventArgs e)
    {
      this.ActiveControl = (Control) null;
      if (this.working)
      {
        int num1 = (int) MessageBox.Show("Performing background operation. Please wait a moment.", "Background image", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else
      {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.InitialDirectory = Application.StartupPath;
        openFileDialog.Title = "Background image ERROR for Coinapp";
        openFileDialog.Filter = "JPEG|*.jpg";
        if (openFileDialog.ShowDialog() == DialogResult.Cancel)
          return;
        try
        {
          this.bgImageError = new Bitmap(openFileDialog.FileName);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          int num2 = (int) Interaction.MsgBox((object) "Selected file is not a valid JPG file.", MsgBoxStyle.Critical, (object) null);
          ProjectData.ClearProjectError();
          return;
        }
        this.txtbx_bgerror.Text = Path.GetFullPath(openFileDialog.FileName);
        openFileDialog.Dispose();
        this.bgImageError.Dispose();
      }
    }

    private void btn_savedata_Click(object sender, EventArgs e)
    {
      this.ActiveControl = (Control) null;
      if (this.working)
      {
        int num1 = (int) Interaction.MsgBox((object) "Performing background operation. Please wait a moment.", MsgBoxStyle.Critical, (object) null);
      }
      else
      {
        FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
        folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
        folderBrowserDialog.SelectedPath = "C:\\";
        folderBrowserDialog.Description = "Browse folder data for Coinapp";
        string Left;
        try
        {
          Left = coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("data")), "data");
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Left = "";
          ProjectData.ClearProjectError();
        }
        if (Operators.CompareString(Left, "", false) != 0)
        {
          int num2;
          try
          {
            num2 = Conversions.ToInteger(coinappMods.enc.Decrypt(coinappMods.settings.readEncCoin(coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("data")), "data"), coinappMods.enc.GetMd5Hash("time" + coinappMods.sID)), "time"));
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            num2 = 0;
            ProjectData.ClearProjectError();
          }
          int num3;
          try
          {
            num3 = Conversions.ToInteger(coinappMods.enc.Decrypt(coinappMods.settings.readEncCoin(coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("data")), "data"), coinappMods.enc.GetMd5Hash("coin" + coinappMods.sID)), "coin"));
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            num3 = 0;
            ProjectData.ClearProjectError();
          }
          if (num2 > 0 || num3 > 0)
          {
            if (MyProject.Forms.form_dialog.Show("There is a previous data in a folder containing the remaining time and total coins earned. Do you want to remove the data and turn off the data folder?", "Remove data", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand) == DialogResult.OK && folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
              coinappMods.settings.writeCoin(coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("data")), "data"), coinappMods.enc.GetMd5Hash("time" + coinappMods.sID), coinappMods.enc.Encrypt("0", "time"));
              coinappMods.settings.writeCoin(coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("data")), "data"), coinappMods.enc.GetMd5Hash("coin" + coinappMods.sID), coinappMods.enc.Encrypt("0", "coin"));
              this.txtbx_savedata.Text = Operators.CompareString(Conversions.ToString(folderBrowserDialog.SelectedPath[checked (folderBrowserDialog.SelectedPath.Length - 1)]), "\\", false) != 0 ? folderBrowserDialog.SelectedPath + "\\" : folderBrowserDialog.SelectedPath;
              int num4 = (int) Interaction.MsgBox((object) "Data in a folder deleted.", MsgBoxStyle.Information, (object) null);
            }
          }
          else if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            this.txtbx_savedata.Text = Operators.CompareString(Conversions.ToString(folderBrowserDialog.SelectedPath[checked (folderBrowserDialog.SelectedPath.Length - 1)]), "\\", false) != 0 ? folderBrowserDialog.SelectedPath + "\\" : folderBrowserDialog.SelectedPath;
        }
        else if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
          this.txtbx_savedata.Text = Operators.CompareString(Conversions.ToString(folderBrowserDialog.SelectedPath[checked (folderBrowserDialog.SelectedPath.Length - 1)]), "\\", false) != 0 ? folderBrowserDialog.SelectedPath + "\\" : folderBrowserDialog.SelectedPath;
        folderBrowserDialog.Dispose();
      }
    }

    private void chkbx_savedata_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chkbx_savedata.Checked)
      {
        if (coinappMods.settings.XconfigExist(coinappMods.enc.GetMd5Hash("data")))
        {
          string Left;
          try
          {
            Left = coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("data")), "data");
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            Left = "";
            ProjectData.ClearProjectError();
          }
          this.txtbx_savedata.Text = Operators.CompareString(Left, "", false) == 0 ? Application.StartupPath + "\\data\\" : coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("data")), "data");
        }
        else
          this.txtbx_savedata.Text = Application.StartupPath + "\\data\\";
        this.txtbx_savedata.Enabled = true;
        this.btn_savedata.Enabled = true;
        this.chkbx_voucher.Checked = false;
        this.chkbx_account.Checked = false;
        this.gb_vouchers.Enabled = true;
        this.gb_accounts.Enabled = true;
      }
      else
      {
        int num1;
        try
        {
          num1 = Conversions.ToInteger(coinappMods.enc.Decrypt(coinappMods.settings.readEncCoin(coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("data")), "data"), coinappMods.enc.GetMd5Hash("time" + coinappMods.sID)), "time"));
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          num1 = 0;
          ProjectData.ClearProjectError();
        }
        int num2;
        try
        {
          num2 = Conversions.ToInteger(coinappMods.enc.Decrypt(coinappMods.settings.readEncCoin(coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("data")), "data"), coinappMods.enc.GetMd5Hash("coin" + coinappMods.sID)), "coin"));
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          num2 = 0;
          ProjectData.ClearProjectError();
        }
        if (num1 > 0 || num2 > 0)
        {
          if (MyProject.Forms.form_dialog.Show("There is a previous data in a folder containing the remaining time and total coins earned. Do you want to remove the data and turn off the data folder?", "Turn off data", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand) == DialogResult.OK)
          {
            coinappMods.settings.writeCoin(coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("data")), "data"), coinappMods.enc.GetMd5Hash("time" + coinappMods.sID), coinappMods.enc.Encrypt("0", "time"));
            coinappMods.settings.writeCoin(coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("data")), "data"), coinappMods.enc.GetMd5Hash("coin" + coinappMods.sID), coinappMods.enc.Encrypt("0", "coin"));
            int num3 = (int) MessageBox.Show("Remaining time canceled.", "Time canceled", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.txtbx_savedata.Clear();
            this.txtbx_savedata.Enabled = false;
            this.btn_savedata.Enabled = false;
            this.chkbx_voucher.Checked = false;
            this.chkbx_account.Checked = false;
            this.gb_vouchers.Enabled = false;
            this.gb_accounts.Enabled = false;
          }
          else
            this.chkbx_savedata.Checked = true;
        }
        else
        {
          this.txtbx_savedata.Clear();
          this.txtbx_savedata.Enabled = false;
          this.btn_savedata.Enabled = false;
          this.chkbx_voucher.Checked = false;
          this.chkbx_account.Checked = false;
          this.gb_vouchers.Enabled = false;
          this.gb_accounts.Enabled = false;
        }
      }
    }

    private void chkbx_CheckedChanged(object sender, EventArgs e)
    {
      if (sender == this.chkbx_voucher)
      {
        if (this.chkbx_voucher.Checked)
        {
          this.gb_dbVoucher.Enabled = true;
          string Left1;
          try
          {
            Left1 = coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("voucherFilename")), "voucher");
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            Left1 = "";
            ProjectData.ClearProjectError();
          }
          string Left2;
          try
          {
            Left2 = coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("voucherPassword")), "voucher");
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            Left2 = "";
            ProjectData.ClearProjectError();
          }
          if (Operators.CompareString(Left1, "", false) == 0 && Operators.CompareString(Left2, "", false) == 0)
            return;
          this.txtbx_dbVoucherName.Text = Left1;
          this.txtbx_dbVoucherPass.Text = Left2;
        }
        else
        {
          this.gb_dbVoucher.Enabled = false;
          this.txtbx_dbVoucherName.Clear();
          this.txtbx_dbVoucherPass.Clear();
        }
      }
      else
      {
        if (sender != this.chkbx_account)
          return;
        if (this.chkbx_account.Checked)
        {
          this.gb_dbAccount.Enabled = true;
          string Left1;
          try
          {
            Left1 = coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("accountFilename")), "account");
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            Left1 = "";
            ProjectData.ClearProjectError();
          }
          string Left2;
          try
          {
            Left2 = coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("accountPassword")), "account");
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            Left2 = "";
            ProjectData.ClearProjectError();
          }
          if (Operators.CompareString(Left1, "", false) != 0 || Operators.CompareString(Left2, "", false) != 0)
          {
            this.txtbx_dbAccountName.Text = Left1;
            this.txtbx_dbAccountPass.Text = Left2;
          }
        }
        else
        {
          this.gb_dbAccount.Enabled = false;
          this.txtbx_dbAccountName.Clear();
          this.txtbx_dbAccountPass.Clear();
        }
      }
    }

    private void txtbx_dbVouchers_TextChanged(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.txtbx_dbVoucherName.Text, "", false) != 0 && Operators.CompareString(this.txtbx_dbVoucherPass.Text, "", false) != 0)
        this.btn_vouchers.Enabled = true;
      else
        this.btn_vouchers.Enabled = false;
    }

    private void txtbx_dbAccountss_TextChanged(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.txtbx_dbAccountName.Text, "", false) != 0 && Operators.CompareString(this.txtbx_dbAccountPass.Text, "", false) != 0)
        this.btn_accounts.Enabled = true;
      else
        this.btn_accounts.Enabled = false;
    }

    private void btn_vouchers_Click(object sender, EventArgs e)
    {
      this.ActiveControl = (Control) null;
      if (this.working)
      {
        int num1 = (int) Interaction.MsgBox((object) "Performing background operation. Please wait a moment.", MsgBoxStyle.Critical, (object) null);
      }
      else if (coinappMods.conf.voucher < 1)
      {
        int num2 = (int) Interaction.MsgBox((object) "Check the Enable voucher then saved the settings and try again.", MsgBoxStyle.Critical, (object) null);
      }
      else
      {
        bool flag = false;
        string Left1;
        try
        {
          Left1 = coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("data")), "data");
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Left1 = "";
          ProjectData.ClearProjectError();
        }
        if (Operators.CompareString(Left1, "", false) == 0)
        {
          int num3 = (int) Interaction.MsgBox((object) "Select a folder on save data location then save the settings and try again.", MsgBoxStyle.Critical, (object) "No save data folder location stored");
        }
        else
        {
          string Left2;
          try
          {
            Left2 = coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("voucherFilename")), "voucher");
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            Left2 = "";
            ProjectData.ClearProjectError();
          }
          string Left3;
          try
          {
            Left3 = coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("voucherPassword")), "voucher");
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            Left3 = "";
            ProjectData.ClearProjectError();
          }
          if (Operators.CompareString(Left2, "", false) == 0)
          {
            if (MessageBox.Show("Create new database voucher?", "Create database voucher", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) != DialogResult.OK)
              goto label_41;
          }
          else if (Operators.CompareString(Left2, this.txtbx_dbVoucherName.Text, false) != 0)
          {
            if (!File.Exists(Left1 + Left2 + ".mdb"))
            {
              if (MessageBox.Show("Previous " + Left2 + ".mdb database voucher in the data folder is missing. Do you want to create a new database voucher?", "Create new database voucher", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) != DialogResult.OK)
                goto label_40;
            }
            else if (MessageBox.Show("There is a previous database voucher in the data folder named " + Left2 + ".mdb. Do you want to change the database voucher?", "Change database voucher", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) != DialogResult.OK)
              goto label_34;
          }
          else
          {
            if (!File.Exists(Left1 + Left2 + ".mdb"))
            {
              if (MessageBox.Show(Left2 + ".mdb database voucher file is missing on the data folder location. Do you want to create a new database voucher?", "Create database voucher", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand) == DialogResult.OK)
                goto label_21;
            }
            else if (Operators.CompareString(Left3, this.txtbx_dbVoucherPass.Text, false) != 0)
            {
              int num4 = (int) Interaction.MsgBox((object) "Password is incorrect.", MsgBoxStyle.Critical, (object) null);
            }
            else
              goto label_42;
            goto label_40;
          }
label_21:
          if (Operators.CompareString(this.txtbx_dbVoucherPass.Text, "", false) == 0)
          {
            int num5 = (int) Interaction.MsgBox((object) "You need to input a password for database voucher", MsgBoxStyle.Critical, (object) "No database voucher password");
          }
          else if (File.Exists(Left1 + this.txtbx_dbVoucherName.Text + ".mdb"))
          {
            if (MessageBox.Show("There is already " + this.txtbx_dbVoucherName.Text + ".mdb database in the data folder location. Do you want to save the filename and the password as your database voucher and open the database?", "Database already exists", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand) == DialogResult.OK)
            {
              coinappMods.settings.writeSystemFile(coinappMods.enc.GetMd5Hash("voucherFilename"), coinappMods.enc.Encrypt(this.txtbx_dbVoucherName.Text, "voucher"));
              coinappMods.settings.writeSystemFile(coinappMods.enc.GetMd5Hash("voucherPassword"), coinappMods.enc.Encrypt(this.txtbx_dbVoucherPass.Text, "voucher"));
              goto label_42;
            }
            else
            {
              int num6 = (int) Interaction.MsgBox((object) ("Cannot use " + this.txtbx_dbVoucherName.Text + " database name because it's already exists in the data folder location."), MsgBoxStyle.Critical, (object) "");
            }
          }
          else
          {
            try
            {
              ((_Catalog) new CatalogClass()).Create("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Left1 + this.txtbx_dbVoucherName.Text + ".mdb; Jet OLEDB:Engine Type=5; Jet OLEDB:Database Password=" + this.txtbx_dbVoucherPass.Text + ";");
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              int num4 = (int) Interaction.MsgBox((object) ex.Message, MsgBoxStyle.Critical, (object) "Create database voucher");
              ProjectData.ClearProjectError();
              return;
            }
            if (!File.Exists(Left1 + this.txtbx_dbVoucherName.Text + ".mdb"))
            {
              int num7 = (int) Interaction.MsgBox((object) "Database voucher creation failed", MsgBoxStyle.Critical, (object) null);
            }
            else
            {
              coinappMods.settings.writeSystemFile(coinappMods.enc.GetMd5Hash("voucherFilename"), coinappMods.enc.Encrypt(this.txtbx_dbVoucherName.Text, "voucher"));
              coinappMods.settings.writeSystemFile(coinappMods.enc.GetMd5Hash("voucherPassword"), coinappMods.enc.Encrypt(this.txtbx_dbVoucherPass.Text, "voucher"));
              int num4 = (int) Interaction.MsgBox((object) ("Database voucher " + this.txtbx_dbVoucherName.Text + ".mdb created successfull."), MsgBoxStyle.Information, (object) null);
              goto label_42;
            }
          }
label_34:
label_40:
label_41:
          if (!flag)
            goto label_43;
label_42:
          NewLateBinding.LateSet(sender, (System.Type) null, "Enabled", new object[1]
          {
            (object) false
          }, (string[]) null, (System.Type[]) null);
          this.Hide();
          int num8 = (int) MyProject.Forms.form_voucher.ShowDialog();
          MyProject.Forms.form_voucher.Dispose();
          MyProject.Forms.form_voucher.Close();
          this.Show();
          NewLateBinding.LateSet(sender, (System.Type) null, "Enabled", new object[1]
          {
            (object) true
          }, (string[]) null, (System.Type[]) null);
label_43:;
        }
      }
    }

    private void btn_accounts_Click(object sender, EventArgs e)
    {
      this.ActiveControl = (Control) null;
      if (this.working)
      {
        int num1 = (int) Interaction.MsgBox((object) "Performing background operation. Please wait a moment.", MsgBoxStyle.Critical, (object) null);
      }
      else if (coinappMods.conf.account < 1)
      {
        int num2 = (int) Interaction.MsgBox((object) "Check the Enable account then saved the settings and try again.", MsgBoxStyle.Critical, (object) null);
      }
      else
      {
        bool flag = false;
        string Left1;
        try
        {
          Left1 = coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("data")), "data");
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Left1 = "";
          ProjectData.ClearProjectError();
        }
        if (Operators.CompareString(Left1, "", false) == 0)
        {
          int num3 = (int) Interaction.MsgBox((object) "Select a folder on save data location then save the settings and try again.", MsgBoxStyle.Critical, (object) "No save data folder location stored");
        }
        else
        {
          string Left2;
          try
          {
            Left2 = coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("accountFilename")), "account");
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            Left2 = "";
            ProjectData.ClearProjectError();
          }
          string Left3;
          try
          {
            Left3 = coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("accountPassword")), "account");
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            Left3 = "";
            ProjectData.ClearProjectError();
          }
          if (Operators.CompareString(Left2, "", false) == 0)
          {
            if (MessageBox.Show("Create new database account?", "Create database account", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) != DialogResult.OK)
              goto label_41;
          }
          else if (Operators.CompareString(Left2, this.txtbx_dbAccountName.Text, false) != 0)
          {
            if (!File.Exists(Left1 + Left2 + ".mdb"))
            {
              if (MessageBox.Show("Previous " + Left2 + ".mdb database account in the data folder is missing. Do you want to create a new database account?", "Create new database account", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) != DialogResult.OK)
                goto label_40;
            }
            else if (MessageBox.Show("There is a previous database account in the data folder named " + Left2 + ".mdb. Do you want to change the database account?", "Change database account", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) != DialogResult.OK)
              goto label_34;
          }
          else
          {
            if (!File.Exists(Left1 + Left2 + ".mdb"))
            {
              if (MessageBox.Show(Left2 + ".mdb database account file is missing on the data folder location. Do you want to create a new database account?", "Create database account", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand) == DialogResult.OK)
                goto label_21;
            }
            else if (Operators.CompareString(Left3, this.txtbx_dbAccountPass.Text, false) != 0)
            {
              int num4 = (int) Interaction.MsgBox((object) "Password is incorrect.", MsgBoxStyle.Critical, (object) null);
            }
            else
              goto label_42;
            goto label_40;
          }
label_21:
          if (Operators.CompareString(this.txtbx_dbAccountPass.Text, "", false) == 0)
          {
            int num5 = (int) Interaction.MsgBox((object) "You need to input a password for database account", MsgBoxStyle.Critical, (object) "No database account password");
          }
          else if (File.Exists(Left1 + this.txtbx_dbAccountName.Text + ".mdb"))
          {
            if (MessageBox.Show("There is already " + this.txtbx_dbAccountName.Text + ".mdb database in the data folder location. Do you want to save the filename and the password as your database account and open the database?", "Database already exists", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand) == DialogResult.OK)
            {
              coinappMods.settings.writeSystemFile(coinappMods.enc.GetMd5Hash("accountFilename"), coinappMods.enc.Encrypt(this.txtbx_dbAccountName.Text, "account"));
              coinappMods.settings.writeSystemFile(coinappMods.enc.GetMd5Hash("accountPassword"), coinappMods.enc.Encrypt(this.txtbx_dbAccountPass.Text, "account"));
              goto label_42;
            }
            else
            {
              int num6 = (int) Interaction.MsgBox((object) ("Cannot use " + this.txtbx_dbAccountName.Text + " database name because it's already exists in the data folder location."), MsgBoxStyle.Critical, (object) "");
            }
          }
          else
          {
            try
            {
              ((_Catalog) new CatalogClass()).Create("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Left1 + this.txtbx_dbAccountName.Text + ".mdb; Jet OLEDB:Engine Type=5; Jet OLEDB:Database Password=" + this.txtbx_dbAccountPass.Text + ";");
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              int num4 = (int) Interaction.MsgBox((object) ex.Message, MsgBoxStyle.Critical, (object) "Create database account");
              ProjectData.ClearProjectError();
              return;
            }
            if (!File.Exists(Left1 + this.txtbx_dbAccountName.Text + ".mdb"))
            {
              int num7 = (int) Interaction.MsgBox((object) "Database account creation failed", MsgBoxStyle.Critical, (object) null);
            }
            else
            {
              coinappMods.settings.writeSystemFile(coinappMods.enc.GetMd5Hash("accountFilename"), coinappMods.enc.Encrypt(this.txtbx_dbAccountName.Text, "account"));
              coinappMods.settings.writeSystemFile(coinappMods.enc.GetMd5Hash("accountPassword"), coinappMods.enc.Encrypt(this.txtbx_dbAccountPass.Text, "account"));
              int num4 = (int) Interaction.MsgBox((object) ("Database account " + this.txtbx_dbAccountName.Text + ".mdb created successfull."), MsgBoxStyle.Information, (object) null);
              goto label_42;
            }
          }
label_34:
label_40:
label_41:
          if (!flag)
            goto label_43;
label_42:
          NewLateBinding.LateSet(sender, (System.Type) null, "Enabled", new object[1]
          {
            (object) false
          }, (string[]) null, (System.Type[]) null);
          this.Hide();
          int num8 = (int) MyProject.Forms.form_account.ShowDialog();
          MyProject.Forms.form_account.Dispose();
          MyProject.Forms.form_account.Close();
          this.Show();
          NewLateBinding.LateSet(sender, (System.Type) null, "Enabled", new object[1]
          {
            (object) true
          }, (string[]) null, (System.Type[]) null);
label_43:;
        }
      }
    }

    private delegate void MyDelegate();
  }
}
