// Decompiled with JetBrains decompiler
// Type: Coinapp.Form_settings
// Assembly: Coinapp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: ED4B7D1C-BF2E-4AAF-8FCA-FEC188D22124
// Assembly location: C:\Users\EarlJohn\Desktop\Coinapp\Coinapp.exe

using Coinapp.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace Coinapp
{
  [DesignerGenerated]
  public class Form_settings : Form
  {
    private IContainer components;
    private string keycodeString;
    private int keycode;
    private int previousKeycode;
    private string result;
    private string port;
    private bool checkConnection;
    private bool working;
    private Bitmap bgImageTemp;

    public Form_settings()
    {
      this.Move += new EventHandler(this.FormPreventToMoveWithKeyboard);
      this.Load += new EventHandler(this.Form_settings_Load);
      this.InitializeComponent();
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
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form_settings));
      this.button_deviceinfo = new Button();
      this.combobox_device = new ComboBox();
      this.combobox_cointype = new ComboBox();
      this.textbox_notification1_messages = new TextBox();
      this.textbox_notification2_seconds = new TextBox();
      this.textbox_notification1_seconds = new TextBox();
      this.textbox_coin3 = new TextBox();
      this.textbox_coin2 = new TextBox();
      this.textbox_notification2_messages = new TextBox();
      this.button_device = new Button();
      this.label_coin3 = new Label();
      this.textbox_coin1_pulse = new TextBox();
      this.label_coin2 = new Label();
      this.textbox_turnoff = new TextBox();
      this.label_coin1 = new Label();
      this.label_notify2 = new Label();
      this.groupbox_coins = new GroupBox();
      this.textbox_coin3_pulse = new TextBox();
      this.textbox_coin2_pulse = new TextBox();
      this.textbox_notify_coin3 = new TextBox();
      this.textbox_coin1 = new TextBox();
      this.textbox_notify_coin2 = new TextBox();
      this.textbox_notify_coin1 = new TextBox();
      this.Label4 = new Label();
      this.Label3 = new Label();
      this.Label2 = new Label();
      this.label_turnoff = new Label();
      this.label_notify1 = new Label();
      this.label_cointype = new Label();
      this.groupbox_notify = new GroupBox();
      this.combobox_coloruserlogout = new ComboBox();
      this.combobox_colortimesup = new ComboBox();
      this.combobox_colorstartup = new ComboBox();
      this.textbox_userlogoutmsg = new TextBox();
      this.textbox_userlogouttitle = new TextBox();
      this.textbox_timesuplock_message = new TextBox();
      this.textbox_timesuplock_title = new TextBox();
      this.Label1 = new Label();
      this.label_timesuplock = new Label();
      this.textbox_startuplock_message = new TextBox();
      this.textbox_notification1_length = new TextBox();
      this.textbox_startuplock_title = new TextBox();
      this.label_startuplock = new Label();
      this.textbox_notification2_length = new TextBox();
      this.button_playbeepshut = new Button();
      this.button_playbeeplock = new Button();
      this.button_playbeeptime = new Button();
      this.button_playbeepcoin = new Button();
      this.textbox_beepshutdur = new TextBox();
      this.textbox_beepcoindur = new TextBox();
      this.textbox_beeplockdur = new TextBox();
      this.textbox_beeptimedur = new TextBox();
      this.textbox_beeplockrep = new TextBox();
      this.textbox_beeptimerep = new TextBox();
      this.textbox_beeplockfreq = new TextBox();
      this.textbox_beeptimefreq = new TextBox();
      this.textbox_beeptime = new TextBox();
      this.textbox_beepshutfreq = new TextBox();
      this.textbox_beepcoinfreq = new TextBox();
      this.label_beeplock = new Label();
      this.label_beeptime = new Label();
      this.label_beepshut = new Label();
      this.label_beepcoindrop = new Label();
      this.toggle_beepshutdown = new CheckBox();
      this.toggle_beephardware = new CheckBox();
      this.groupbox_admin = new GroupBox();
      this.Label8 = new Label();
      this.Label7 = new Label();
      this.Label6 = new Label();
      this.Label5 = new Label();
      this.textbox_newemail = new TextBox();
      this.button_changeemail = new Button();
      this.textbox_currentemail = new TextBox();
      this.button_changepass = new Button();
      this.textbox_retypepass = new TextBox();
      this.textbox_newpass = new TextBox();
      this.textbox_currentpass = new TextBox();
      this.button_savesettings = new Button();
      this.groupbox_apps = new GroupBox();
      this.textbox_datafolder = new TextBox();
      this.textbox_loginretry = new TextBox();
      this.textbox_letterkey = new TextBox();
      this.label_key = new Label();
      this.combobox_timesound = new ComboBox();
      this.combobox_coinsound = new ComboBox();
      this.label_letterkey = new Label();
      this.button_browse = new Button();
      this.button_timeplay = new Button();
      this.button_coinplay = new Button();
      this.toggle_devicedisconnect = new CheckBox();
      this.toggle_protect = new CheckBox();
      this.toggle_savedata = new CheckBox();
      this.toggle_sound = new CheckBox();
      this.toggle_taskmanager = new CheckBox();
      this.label_timesound = new Label();
      this.label_coinsound = new Label();
      this.label_loginretry = new Label();
      this.toggle_startup = new CheckBox();
      this.button_restart = new Button();
      this.button_close = new Button();
      this.tabcontrol_settings = new TabControl();
      this.tabpage_coins = new TabPage();
      this.tabpage_apps = new TabPage();
      this.tabpage_notify = new TabPage();
      this.tabpage_device = new TabPage();
      this.groupbox_device = new GroupBox();
      this.tabpage_passemail = new TabPage();
      this.tabpage_advance = new TabPage();
      this.GroupBox1 = new GroupBox();
      this.textbox_waitforprocmon = new TextBox();
      this.label_waitforprocmon = new Label();
      this.combobox_shutdowntime = new ComboBox();
      this.combobox_deviceproblemcolor = new ComboBox();
      this.combobox_lockwindowbgcolor = new ComboBox();
      this.combobox_startupinitializecolor = new ComboBox();
      this.combobox_lockwindowtrans = new ComboBox();
      this.combobox_lockwindowpos = new ComboBox();
      this.combobox_bgimagelayout = new ComboBox();
      this.checkbox_advance = new CheckBox();
      this.checkbox_customizelock = new CheckBox();
      this.button_browsebgimage = new Button();
      this.label_shutdowntime = new Label();
      this.label_deviceproblemcolor = new Label();
      this.label_startupinitializecolor = new Label();
      this.label_lockwindowbgcolor = new Label();
      this.label_lockwindowtrans = new Label();
      this.label_lockwindowpos = new Label();
      this.label_bgimagelayout = new Label();
      this.label_bg = new Label();
      this.textbox_bgimagelocation = new TextBox();
      this.tooltip_settings = new ToolTip(this.components);
      this.toggle_5secvoice = new CheckBox();
      this.groupbox_coins.SuspendLayout();
      this.groupbox_notify.SuspendLayout();
      this.groupbox_admin.SuspendLayout();
      this.groupbox_apps.SuspendLayout();
      this.tabcontrol_settings.SuspendLayout();
      this.tabpage_coins.SuspendLayout();
      this.tabpage_apps.SuspendLayout();
      this.tabpage_notify.SuspendLayout();
      this.tabpage_device.SuspendLayout();
      this.groupbox_device.SuspendLayout();
      this.tabpage_passemail.SuspendLayout();
      this.tabpage_advance.SuspendLayout();
      this.GroupBox1.SuspendLayout();
      this.SuspendLayout();
      this.button_deviceinfo.Enabled = false;
      this.button_deviceinfo.FlatStyle = FlatStyle.Popup;
      this.button_deviceinfo.ForeColor = SystemColors.Control;
      this.button_deviceinfo.Location = new Point(322, 14);
      this.button_deviceinfo.Name = "button_deviceinfo";
      this.button_deviceinfo.Size = new Size(14, 25);
      this.button_deviceinfo.TabIndex = 0;
      this.button_deviceinfo.TabStop = false;
      this.button_deviceinfo.UseVisualStyleBackColor = false;
      this.combobox_device.DropDownStyle = ComboBoxStyle.DropDownList;
      this.combobox_device.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.combobox_device.FormattingEnabled = true;
      this.combobox_device.ItemHeight = 16;
      this.combobox_device.Location = new Point(18, 15);
      this.combobox_device.Name = "combobox_device";
      this.combobox_device.Size = new Size(214, 24);
      this.combobox_device.TabIndex = 0;
      this.combobox_device.TabStop = false;
      this.combobox_cointype.DropDownStyle = ComboBoxStyle.DropDownList;
      this.combobox_cointype.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.combobox_cointype.FormattingEnabled = true;
      this.combobox_cointype.IntegralHeight = false;
      this.combobox_cointype.ItemHeight = 13;
      this.combobox_cointype.Items.AddRange(new object[3]
      {
        (object) "Single coin acceptor",
        (object) "Multi coin acceptor",
        (object) "Dual coin acceptor"
      });
      this.combobox_cointype.Location = new Point(114, 14);
      this.combobox_cointype.Name = "combobox_cointype";
      this.combobox_cointype.Size = new Size(194, 21);
      this.combobox_cointype.TabIndex = 0;
      this.combobox_cointype.TabStop = false;
      this.textbox_notification1_messages.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_notification1_messages.Location = new Point(13, 38);
      this.textbox_notification1_messages.MaxLength = 40;
      this.textbox_notification1_messages.Name = "textbox_notification1_messages";
      this.textbox_notification1_messages.Size = new Size(274, 20);
      this.textbox_notification1_messages.TabIndex = 24;
      this.textbox_notification2_seconds.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_notification2_seconds.Location = new Point(161, 65);
      this.textbox_notification2_seconds.MaxLength = 4;
      this.textbox_notification2_seconds.Name = "textbox_notification2_seconds";
      this.textbox_notification2_seconds.ShortcutsEnabled = false;
      this.textbox_notification2_seconds.Size = new Size(62, 20);
      this.textbox_notification2_seconds.TabIndex = 25;
      this.textbox_notification2_seconds.TextAlign = HorizontalAlignment.Right;
      this.textbox_notification1_seconds.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_notification1_seconds.Location = new Point(161, 14);
      this.textbox_notification1_seconds.MaxLength = 4;
      this.textbox_notification1_seconds.Name = "textbox_notification1_seconds";
      this.textbox_notification1_seconds.ShortcutsEnabled = false;
      this.textbox_notification1_seconds.Size = new Size(62, 20);
      this.textbox_notification1_seconds.TabIndex = 22;
      this.textbox_notification1_seconds.TextAlign = HorizontalAlignment.Right;
      this.textbox_coin3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_coin3.Location = new Point(93, 122);
      this.textbox_coin3.MaxLength = 4;
      this.textbox_coin3.Name = "textbox_coin3";
      this.textbox_coin3.ShortcutsEnabled = false;
      this.textbox_coin3.Size = new Size(69, 20);
      this.textbox_coin3.TabIndex = 7;
      this.textbox_coin3.TextAlign = HorizontalAlignment.Right;
      this.textbox_coin2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_coin2.Location = new Point(93, 70);
      this.textbox_coin2.MaxLength = 4;
      this.textbox_coin2.Name = "textbox_coin2";
      this.textbox_coin2.ShortcutsEnabled = false;
      this.textbox_coin2.Size = new Size(69, 20);
      this.textbox_coin2.TabIndex = 4;
      this.textbox_coin2.TextAlign = HorizontalAlignment.Right;
      this.textbox_notification2_messages.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_notification2_messages.Location = new Point(12, 88);
      this.textbox_notification2_messages.MaxLength = 40;
      this.textbox_notification2_messages.Name = "textbox_notification2_messages";
      this.textbox_notification2_messages.Size = new Size(275, 20);
      this.textbox_notification2_messages.TabIndex = 27;
      this.button_device.BackColor = Color.DarkGray;
      this.button_device.Cursor = Cursors.Hand;
      this.button_device.FlatAppearance.BorderSize = 0;
      this.button_device.FlatAppearance.MouseOverBackColor = Color.Firebrick;
      this.button_device.FlatStyle = FlatStyle.Popup;
      this.button_device.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button_device.ForeColor = Color.White;
      this.button_device.Location = new Point(234, 15);
      this.button_device.Name = "button_device";
      this.button_device.Size = new Size(86, 24);
      this.button_device.TabIndex = 0;
      this.button_device.TabStop = false;
      this.button_device.UseVisualStyleBackColor = false;
      this.label_coin3.AutoSize = true;
      this.label_coin3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label_coin3.ForeColor = SystemColors.ControlText;
      this.label_coin3.Location = new Point(13, 125);
      this.label_coin3.Name = "label_coin3";
      this.label_coin3.Size = new Size(71, 13);
      this.label_coin3.TabIndex = 0;
      this.label_coin3.Text = "10-peso coin:";
      this.textbox_coin1_pulse.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_coin1_pulse.Location = new Point(226, 18);
      this.textbox_coin1_pulse.MaxLength = 2;
      this.textbox_coin1_pulse.Name = "textbox_coin1_pulse";
      this.textbox_coin1_pulse.ShortcutsEnabled = false;
      this.textbox_coin1_pulse.Size = new Size(60, 20);
      this.textbox_coin1_pulse.TabIndex = 2;
      this.textbox_coin1_pulse.TextAlign = HorizontalAlignment.Right;
      this.label_coin2.AutoSize = true;
      this.label_coin2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label_coin2.ForeColor = SystemColors.ControlText;
      this.label_coin2.Location = new Point(12, 73);
      this.label_coin2.Name = "label_coin2";
      this.label_coin2.Size = new Size(65, 13);
      this.label_coin2.TabIndex = 0;
      this.label_coin2.Text = "5-peso coin:";
      this.textbox_turnoff.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_turnoff.Location = new Point(203, 141);
      this.textbox_turnoff.MaxLength = 4;
      this.textbox_turnoff.Name = "textbox_turnoff";
      this.textbox_turnoff.ShortcutsEnabled = false;
      this.textbox_turnoff.Size = new Size(91, 20);
      this.textbox_turnoff.TabIndex = 17;
      this.textbox_turnoff.TextAlign = HorizontalAlignment.Right;
      this.label_coin1.AutoSize = true;
      this.label_coin1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label_coin1.Location = new Point(11, 21);
      this.label_coin1.Name = "label_coin1";
      this.label_coin1.Size = new Size(65, 13);
      this.label_coin1.TabIndex = 0;
      this.label_coin1.Text = "1-peso coin:";
      this.label_notify2.AutoSize = true;
      this.label_notify2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label_notify2.Location = new Point(16, 68);
      this.label_notify2.Name = "label_notify2";
      this.label_notify2.Size = new Size(123, 13);
      this.label_notify2.TabIndex = 0;
      this.label_notify2.Text = "Final warning notification";
      this.groupbox_coins.Controls.Add((Control) this.textbox_coin3);
      this.groupbox_coins.Controls.Add((Control) this.textbox_coin2);
      this.groupbox_coins.Controls.Add((Control) this.textbox_coin3_pulse);
      this.groupbox_coins.Controls.Add((Control) this.textbox_coin2_pulse);
      this.groupbox_coins.Controls.Add((Control) this.textbox_coin1_pulse);
      this.groupbox_coins.Controls.Add((Control) this.textbox_notify_coin3);
      this.groupbox_coins.Controls.Add((Control) this.textbox_coin1);
      this.groupbox_coins.Controls.Add((Control) this.textbox_notify_coin2);
      this.groupbox_coins.Controls.Add((Control) this.label_coin2);
      this.groupbox_coins.Controls.Add((Control) this.textbox_notify_coin1);
      this.groupbox_coins.Controls.Add((Control) this.label_coin3);
      this.groupbox_coins.Controls.Add((Control) this.Label4);
      this.groupbox_coins.Controls.Add((Control) this.Label3);
      this.groupbox_coins.Controls.Add((Control) this.Label2);
      this.groupbox_coins.Controls.Add((Control) this.label_coin1);
      this.groupbox_coins.Font = new Font("Century Gothic", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.groupbox_coins.Location = new Point(14, 39);
      this.groupbox_coins.Name = "groupbox_coins";
      this.groupbox_coins.Size = new Size(294, 303);
      this.groupbox_coins.TabIndex = 0;
      this.groupbox_coins.TabStop = false;
      this.textbox_coin3_pulse.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_coin3_pulse.Location = new Point(226, 121);
      this.textbox_coin3_pulse.MaxLength = 2;
      this.textbox_coin3_pulse.Name = "textbox_coin3_pulse";
      this.textbox_coin3_pulse.ShortcutsEnabled = false;
      this.textbox_coin3_pulse.Size = new Size(58, 20);
      this.textbox_coin3_pulse.TabIndex = 8;
      this.textbox_coin3_pulse.TextAlign = HorizontalAlignment.Right;
      this.textbox_coin2_pulse.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_coin2_pulse.Location = new Point(225, 69);
      this.textbox_coin2_pulse.MaxLength = 2;
      this.textbox_coin2_pulse.Name = "textbox_coin2_pulse";
      this.textbox_coin2_pulse.ShortcutsEnabled = false;
      this.textbox_coin2_pulse.Size = new Size(59, 20);
      this.textbox_coin2_pulse.TabIndex = 5;
      this.textbox_coin2_pulse.TextAlign = HorizontalAlignment.Right;
      this.textbox_notify_coin3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_notify_coin3.Location = new Point(12, 146);
      this.textbox_notify_coin3.MaxLength = 100;
      this.textbox_notify_coin3.Name = "textbox_notify_coin3";
      this.textbox_notify_coin3.Size = new Size(273, 20);
      this.textbox_notify_coin3.TabIndex = 9;
      this.textbox_coin1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_coin1.Location = new Point(93, 18);
      this.textbox_coin1.MaxLength = 4;
      this.textbox_coin1.Name = "textbox_coin1";
      this.textbox_coin1.ShortcutsEnabled = false;
      this.textbox_coin1.Size = new Size(69, 20);
      this.textbox_coin1.TabIndex = 1;
      this.textbox_coin1.TextAlign = HorizontalAlignment.Right;
      this.textbox_notify_coin2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_notify_coin2.Location = new Point(11, 93);
      this.textbox_notify_coin2.MaxLength = 100;
      this.textbox_notify_coin2.Name = "textbox_notify_coin2";
      this.textbox_notify_coin2.Size = new Size(274, 20);
      this.textbox_notify_coin2.TabIndex = 6;
      this.textbox_notify_coin1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_notify_coin1.Location = new Point(11, 41);
      this.textbox_notify_coin1.MaxLength = 100;
      this.textbox_notify_coin1.Name = "textbox_notify_coin1";
      this.textbox_notify_coin1.Size = new Size(276, 20);
      this.textbox_notify_coin1.TabIndex = 3;
      this.Label4.AutoSize = true;
      this.Label4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label4.Location = new Point(177, 125);
      this.Label4.Name = "Label4";
      this.Label4.Size = new Size(45, 13);
      this.Label4.TabIndex = 0;
      this.Label4.Text = "Pulse 3:";
      this.Label3.AutoSize = true;
      this.Label3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label3.Location = new Point(177, 73);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(45, 13);
      this.Label3.TabIndex = 0;
      this.Label3.Text = "Pulse 2:";
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label2.Location = new Point(178, 21);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(45, 13);
      this.Label2.TabIndex = 0;
      this.Label2.Text = "Pulse 1:";
      this.label_turnoff.AutoSize = true;
      this.label_turnoff.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label_turnoff.Location = new Point(17, 146);
      this.label_turnoff.Name = "label_turnoff";
      this.label_turnoff.Size = new Size(84, 13);
      this.label_turnoff.TabIndex = 0;
      this.label_turnoff.Text = "Shutdown when";
      this.label_notify1.AutoSize = true;
      this.label_notify1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label_notify1.Location = new Point(16, 17);
      this.label_notify1.Name = "label_notify1";
      this.label_notify1.Size = new Size(120, 13);
      this.label_notify1.TabIndex = 0;
      this.label_notify1.Text = "First warning notification";
      this.label_cointype.AutoSize = true;
      this.label_cointype.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label_cointype.Location = new Point(12, 18);
      this.label_cointype.Name = "label_cointype";
      this.label_cointype.Size = new Size(96, 13);
      this.label_cointype.TabIndex = 0;
      this.label_cointype.Text = "Coin acceptor type";
      this.groupbox_notify.BackColor = Color.White;
      this.groupbox_notify.Controls.Add((Control) this.combobox_coloruserlogout);
      this.groupbox_notify.Controls.Add((Control) this.combobox_colortimesup);
      this.groupbox_notify.Controls.Add((Control) this.combobox_colorstartup);
      this.groupbox_notify.Controls.Add((Control) this.textbox_notification1_messages);
      this.groupbox_notify.Controls.Add((Control) this.label_notify1);
      this.groupbox_notify.Controls.Add((Control) this.textbox_userlogoutmsg);
      this.groupbox_notify.Controls.Add((Control) this.textbox_userlogouttitle);
      this.groupbox_notify.Controls.Add((Control) this.textbox_timesuplock_message);
      this.groupbox_notify.Controls.Add((Control) this.textbox_timesuplock_title);
      this.groupbox_notify.Controls.Add((Control) this.Label1);
      this.groupbox_notify.Controls.Add((Control) this.textbox_notification1_seconds);
      this.groupbox_notify.Controls.Add((Control) this.label_timesuplock);
      this.groupbox_notify.Controls.Add((Control) this.textbox_startuplock_message);
      this.groupbox_notify.Controls.Add((Control) this.textbox_notification1_length);
      this.groupbox_notify.Controls.Add((Control) this.textbox_startuplock_title);
      this.groupbox_notify.Controls.Add((Control) this.textbox_notification2_messages);
      this.groupbox_notify.Controls.Add((Control) this.textbox_notification2_seconds);
      this.groupbox_notify.Controls.Add((Control) this.label_startuplock);
      this.groupbox_notify.Controls.Add((Control) this.textbox_notification2_length);
      this.groupbox_notify.Controls.Add((Control) this.label_notify2);
      this.groupbox_notify.Location = new Point(10, 7);
      this.groupbox_notify.Name = "groupbox_notify";
      this.groupbox_notify.Size = new Size(300, 335);
      this.groupbox_notify.TabIndex = 0;
      this.groupbox_notify.TabStop = false;
      this.combobox_coloruserlogout.DropDownStyle = ComboBoxStyle.DropDownList;
      this.combobox_coloruserlogout.FormattingEnabled = true;
      this.combobox_coloruserlogout.Items.AddRange(new object[8]
      {
        (object) "White",
        (object) "Black",
        (object) "Red",
        (object) "Blue",
        (object) "Green",
        (object) "Yellow",
        (object) "Orange",
        (object) "Violet"
      });
      this.combobox_coloruserlogout.Location = new Point(219, 262);
      this.combobox_coloruserlogout.Name = "combobox_coloruserlogout";
      this.combobox_coloruserlogout.Size = new Size(67, 21);
      this.combobox_coloruserlogout.TabIndex = 32;
      this.combobox_colortimesup.DropDownStyle = ComboBoxStyle.DropDownList;
      this.combobox_colortimesup.FormattingEnabled = true;
      this.combobox_colortimesup.Items.AddRange(new object[8]
      {
        (object) "White",
        (object) "Black",
        (object) "Red",
        (object) "Blue",
        (object) "Green",
        (object) "Yellow",
        (object) "Orange",
        (object) "Violet"
      });
      this.combobox_colortimesup.Location = new Point(219, 190);
      this.combobox_colortimesup.Name = "combobox_colortimesup";
      this.combobox_colortimesup.Size = new Size(68, 21);
      this.combobox_colortimesup.TabIndex = 32;
      this.combobox_colorstartup.DropDownStyle = ComboBoxStyle.DropDownList;
      this.combobox_colorstartup.FormattingEnabled = true;
      this.combobox_colorstartup.Items.AddRange(new object[8]
      {
        (object) "White",
        (object) "Black",
        (object) "Red",
        (object) "Blue",
        (object) "Green",
        (object) "Yellow",
        (object) "Orange",
        (object) "Violet"
      });
      this.combobox_colorstartup.Location = new Point(219, 114);
      this.combobox_colorstartup.Name = "combobox_colorstartup";
      this.combobox_colorstartup.Size = new Size(67, 21);
      this.combobox_colorstartup.TabIndex = 32;
      this.textbox_userlogoutmsg.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_userlogoutmsg.Location = new Point(12, 287);
      this.textbox_userlogoutmsg.MaxLength = 150;
      this.textbox_userlogoutmsg.Multiline = true;
      this.textbox_userlogoutmsg.Name = "textbox_userlogoutmsg";
      this.textbox_userlogoutmsg.Size = new Size(275, 40);
      this.textbox_userlogoutmsg.TabIndex = 31;
      this.textbox_userlogouttitle.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_userlogouttitle.Location = new Point(82, 262);
      this.textbox_userlogouttitle.MaxLength = 40;
      this.textbox_userlogouttitle.Name = "textbox_userlogouttitle";
      this.textbox_userlogouttitle.Size = new Size(134, 20);
      this.textbox_userlogouttitle.TabIndex = 30;
      this.textbox_timesuplock_message.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_timesuplock_message.Location = new Point(11, 214);
      this.textbox_timesuplock_message.MaxLength = 150;
      this.textbox_timesuplock_message.Multiline = true;
      this.textbox_timesuplock_message.Name = "textbox_timesuplock_message";
      this.textbox_timesuplock_message.Size = new Size(275, 40);
      this.textbox_timesuplock_message.TabIndex = 31;
      this.textbox_timesuplock_title.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_timesuplock_title.Location = new Point(82, 191);
      this.textbox_timesuplock_title.MaxLength = 40;
      this.textbox_timesuplock_title.Name = "textbox_timesuplock_title";
      this.textbox_timesuplock_title.Size = new Size(134, 20);
      this.textbox_timesuplock_title.TabIndex = 30;
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label1.Location = new Point(5, 266);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(61, 13);
      this.Label1.TabIndex = 0;
      this.Label1.Text = "User logout";
      this.label_timesuplock.AutoSize = true;
      this.label_timesuplock.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label_timesuplock.Location = new Point(7, 194);
      this.label_timesuplock.Name = "label_timesuplock";
      this.label_timesuplock.Size = new Size(75, 13);
      this.label_timesuplock.TabIndex = 0;
      this.label_timesuplock.Text = "Time's up lock";
      this.textbox_startuplock_message.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_startuplock_message.Location = new Point(11, 139);
      this.textbox_startuplock_message.MaxLength = 150;
      this.textbox_startuplock_message.Multiline = true;
      this.textbox_startuplock_message.Name = "textbox_startuplock_message";
      this.textbox_startuplock_message.Size = new Size(275, 40);
      this.textbox_startuplock_message.TabIndex = 29;
      this.textbox_notification1_length.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_notification1_length.Location = new Point(229, 14);
      this.textbox_notification1_length.MaxLength = 2;
      this.textbox_notification1_length.Name = "textbox_notification1_length";
      this.textbox_notification1_length.ShortcutsEnabled = false;
      this.textbox_notification1_length.Size = new Size(58, 20);
      this.textbox_notification1_length.TabIndex = 23;
      this.textbox_notification1_length.TextAlign = HorizontalAlignment.Right;
      this.textbox_startuplock_title.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_startuplock_title.Location = new Point(82, 115);
      this.textbox_startuplock_title.MaxLength = 40;
      this.textbox_startuplock_title.Name = "textbox_startuplock_title";
      this.textbox_startuplock_title.Size = new Size(134, 20);
      this.textbox_startuplock_title.TabIndex = 28;
      this.label_startuplock.AutoSize = true;
      this.label_startuplock.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label_startuplock.Location = new Point(8, 119);
      this.label_startuplock.Name = "label_startuplock";
      this.label_startuplock.Size = new Size(64, 13);
      this.label_startuplock.TabIndex = 0;
      this.label_startuplock.Text = "Startup lock";
      this.textbox_notification2_length.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_notification2_length.Location = new Point(229, 65);
      this.textbox_notification2_length.MaxLength = 2;
      this.textbox_notification2_length.Name = "textbox_notification2_length";
      this.textbox_notification2_length.ShortcutsEnabled = false;
      this.textbox_notification2_length.Size = new Size(58, 20);
      this.textbox_notification2_length.TabIndex = 26;
      this.textbox_notification2_length.TextAlign = HorizontalAlignment.Right;
      this.button_playbeepshut.BackgroundImageLayout = ImageLayout.Center;
      this.button_playbeepshut.FlatStyle = FlatStyle.Popup;
      this.button_playbeepshut.Font = new Font("Microsoft Sans Serif", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button_playbeepshut.Location = new Point(234, 154);
      this.button_playbeepshut.Name = "button_playbeepshut";
      this.button_playbeepshut.Size = new Size(44, 20);
      this.button_playbeepshut.TabIndex = 0;
      this.button_playbeepshut.TabStop = false;
      this.button_playbeepshut.Text = "PLAY";
      this.button_playbeeplock.BackgroundImageLayout = ImageLayout.Center;
      this.button_playbeeplock.FlatStyle = FlatStyle.Popup;
      this.button_playbeeplock.Font = new Font("Microsoft Sans Serif", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button_playbeeplock.Location = new Point(233, 92);
      this.button_playbeeplock.Name = "button_playbeeplock";
      this.button_playbeeplock.Size = new Size(44, 20);
      this.button_playbeeplock.TabIndex = 0;
      this.button_playbeeplock.TabStop = false;
      this.button_playbeeplock.Text = "PLAY";
      this.button_playbeeptime.BackgroundImageLayout = ImageLayout.Center;
      this.button_playbeeptime.FlatStyle = FlatStyle.Popup;
      this.button_playbeeptime.Font = new Font("Microsoft Sans Serif", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button_playbeeptime.Location = new Point(234, 66);
      this.button_playbeeptime.Name = "button_playbeeptime";
      this.button_playbeeptime.Size = new Size(44, 20);
      this.button_playbeeptime.TabIndex = 0;
      this.button_playbeeptime.TabStop = false;
      this.button_playbeeptime.Text = "PLAY";
      this.button_playbeepcoin.BackgroundImageLayout = ImageLayout.Center;
      this.button_playbeepcoin.FlatStyle = FlatStyle.Popup;
      this.button_playbeepcoin.Font = new Font("Microsoft Sans Serif", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button_playbeepcoin.Location = new Point(234, 40);
      this.button_playbeepcoin.Name = "button_playbeepcoin";
      this.button_playbeepcoin.Size = new Size(44, 20);
      this.button_playbeepcoin.TabIndex = 0;
      this.button_playbeepcoin.TabStop = false;
      this.button_playbeepcoin.Text = "PLAY";
      this.textbox_beepshutdur.Enabled = false;
      this.textbox_beepshutdur.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_beepshutdur.Location = new Point(188, 154);
      this.textbox_beepshutdur.MaxLength = 5;
      this.textbox_beepshutdur.Name = "textbox_beepshutdur";
      this.textbox_beepshutdur.RightToLeft = RightToLeft.Yes;
      this.textbox_beepshutdur.ShortcutsEnabled = false;
      this.textbox_beepshutdur.Size = new Size(40, 20);
      this.textbox_beepshutdur.TabIndex = 46;
      this.textbox_beepcoindur.Enabled = false;
      this.textbox_beepcoindur.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_beepcoindur.Location = new Point(188, 40);
      this.textbox_beepcoindur.MaxLength = 5;
      this.textbox_beepcoindur.Name = "textbox_beepcoindur";
      this.textbox_beepcoindur.RightToLeft = RightToLeft.Yes;
      this.textbox_beepcoindur.ShortcutsEnabled = false;
      this.textbox_beepcoindur.Size = new Size(40, 20);
      this.textbox_beepcoindur.TabIndex = 37;
      this.textbox_beeplockdur.Enabled = false;
      this.textbox_beeplockdur.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_beeplockdur.Location = new Point(188, 92);
      this.textbox_beeplockdur.MaxLength = 5;
      this.textbox_beeplockdur.Name = "textbox_beeplockdur";
      this.textbox_beeplockdur.RightToLeft = RightToLeft.Yes;
      this.textbox_beeplockdur.ShortcutsEnabled = false;
      this.textbox_beeplockdur.Size = new Size(40, 20);
      this.textbox_beeplockdur.TabIndex = 44;
      this.textbox_beeptimedur.Enabled = false;
      this.textbox_beeptimedur.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_beeptimedur.Location = new Point(188, 66);
      this.textbox_beeptimedur.MaxLength = 5;
      this.textbox_beeptimedur.Name = "textbox_beeptimedur";
      this.textbox_beeptimedur.RightToLeft = RightToLeft.Yes;
      this.textbox_beeptimedur.ShortcutsEnabled = false;
      this.textbox_beeptimedur.Size = new Size(40, 20);
      this.textbox_beeptimedur.TabIndex = 41;
      this.textbox_beeplockrep.Enabled = false;
      this.textbox_beeplockrep.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_beeplockrep.Location = new Point(100, 92);
      this.textbox_beeplockrep.MaxLength = 2;
      this.textbox_beeplockrep.Name = "textbox_beeplockrep";
      this.textbox_beeplockrep.RightToLeft = RightToLeft.Yes;
      this.textbox_beeplockrep.ShortcutsEnabled = false;
      this.textbox_beeplockrep.Size = new Size(40, 20);
      this.textbox_beeplockrep.TabIndex = 42;
      this.textbox_beeptimerep.Enabled = false;
      this.textbox_beeptimerep.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_beeptimerep.Location = new Point(100, 66);
      this.textbox_beeptimerep.MaxLength = 2;
      this.textbox_beeptimerep.Name = "textbox_beeptimerep";
      this.textbox_beeptimerep.RightToLeft = RightToLeft.Yes;
      this.textbox_beeptimerep.ShortcutsEnabled = false;
      this.textbox_beeptimerep.Size = new Size(40, 20);
      this.textbox_beeptimerep.TabIndex = 39;
      this.textbox_beeplockfreq.Enabled = false;
      this.textbox_beeplockfreq.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_beeplockfreq.Location = new Point(144, 92);
      this.textbox_beeplockfreq.MaxLength = 4;
      this.textbox_beeplockfreq.Name = "textbox_beeplockfreq";
      this.textbox_beeplockfreq.RightToLeft = RightToLeft.Yes;
      this.textbox_beeplockfreq.ShortcutsEnabled = false;
      this.textbox_beeplockfreq.Size = new Size(40, 20);
      this.textbox_beeplockfreq.TabIndex = 43;
      this.textbox_beeptimefreq.Enabled = false;
      this.textbox_beeptimefreq.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_beeptimefreq.Location = new Point(144, 66);
      this.textbox_beeptimefreq.MaxLength = 4;
      this.textbox_beeptimefreq.Name = "textbox_beeptimefreq";
      this.textbox_beeptimefreq.RightToLeft = RightToLeft.Yes;
      this.textbox_beeptimefreq.ShortcutsEnabled = false;
      this.textbox_beeptimefreq.Size = new Size(40, 20);
      this.textbox_beeptimefreq.TabIndex = 40;
      this.textbox_beeptime.Enabled = false;
      this.textbox_beeptime.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_beeptime.Location = new Point(56, 66);
      this.textbox_beeptime.MaxLength = 4;
      this.textbox_beeptime.Name = "textbox_beeptime";
      this.textbox_beeptime.RightToLeft = RightToLeft.Yes;
      this.textbox_beeptime.ShortcutsEnabled = false;
      this.textbox_beeptime.Size = new Size(40, 20);
      this.textbox_beeptime.TabIndex = 38;
      this.textbox_beepshutfreq.Enabled = false;
      this.textbox_beepshutfreq.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_beepshutfreq.Location = new Point(144, 154);
      this.textbox_beepshutfreq.MaxLength = 4;
      this.textbox_beepshutfreq.Name = "textbox_beepshutfreq";
      this.textbox_beepshutfreq.RightToLeft = RightToLeft.Yes;
      this.textbox_beepshutfreq.ShortcutsEnabled = false;
      this.textbox_beepshutfreq.Size = new Size(40, 20);
      this.textbox_beepshutfreq.TabIndex = 45;
      this.textbox_beepcoinfreq.Enabled = false;
      this.textbox_beepcoinfreq.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_beepcoinfreq.Location = new Point(144, 40);
      this.textbox_beepcoinfreq.MaxLength = 4;
      this.textbox_beepcoinfreq.Name = "textbox_beepcoinfreq";
      this.textbox_beepcoinfreq.RightToLeft = RightToLeft.Yes;
      this.textbox_beepcoinfreq.ShortcutsEnabled = false;
      this.textbox_beepcoinfreq.Size = new Size(40, 20);
      this.textbox_beepcoinfreq.TabIndex = 36;
      this.label_beeplock.AutoSize = true;
      this.label_beeplock.Enabled = false;
      this.label_beeplock.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label_beeplock.Location = new Point(16, 96);
      this.label_beeplock.Name = "label_beeplock";
      this.label_beeplock.Size = new Size(34, 13);
      this.label_beeplock.TabIndex = 0;
      this.label_beeplock.Text = "Lock:";
      this.label_beeptime.AutoSize = true;
      this.label_beeptime.Enabled = false;
      this.label_beeptime.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label_beeptime.Location = new Point(16, 69);
      this.label_beeptime.Name = "label_beeptime";
      this.label_beeptime.Size = new Size(33, 13);
      this.label_beeptime.TabIndex = 0;
      this.label_beeptime.Text = "Time:";
      this.label_beepshut.AutoSize = true;
      this.label_beepshut.Enabled = false;
      this.label_beepshut.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label_beepshut.Location = new Point(16, 157);
      this.label_beepshut.Name = "label_beepshut";
      this.label_beepshut.Size = new Size(58, 13);
      this.label_beepshut.TabIndex = 0;
      this.label_beepshut.Text = "Shutdown:";
      this.label_beepcoindrop.AutoSize = true;
      this.label_beepcoindrop.Enabled = false;
      this.label_beepcoindrop.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label_beepcoindrop.Location = new Point(16, 43);
      this.label_beepcoindrop.Name = "label_beepcoindrop";
      this.label_beepcoindrop.Size = new Size(55, 13);
      this.label_beepcoindrop.TabIndex = 0;
      this.label_beepcoindrop.Text = "Coin drop:";
      this.toggle_beepshutdown.AutoSize = true;
      this.toggle_beepshutdown.Enabled = false;
      this.toggle_beepshutdown.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.toggle_beepshutdown.Location = new Point(18, 128);
      this.toggle_beepshutdown.Name = "toggle_beepshutdown";
      this.toggle_beepshutdown.Size = new Size(182, 19);
      this.toggle_beepshutdown.TabIndex = 10;
      this.toggle_beepshutdown.Text = "Beep lock shutting down";
      this.toggle_beephardware.AutoSize = true;
      this.toggle_beephardware.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.toggle_beephardware.Location = new Point(18, 19);
      this.toggle_beephardware.Name = "toggle_beephardware";
      this.toggle_beephardware.Size = new Size(214, 19);
      this.toggle_beephardware.TabIndex = 10;
      this.toggle_beephardware.Text = "Enable beep sound hardware";
      this.groupbox_admin.BackColor = Color.White;
      this.groupbox_admin.Controls.Add((Control) this.Label8);
      this.groupbox_admin.Controls.Add((Control) this.Label7);
      this.groupbox_admin.Controls.Add((Control) this.Label6);
      this.groupbox_admin.Controls.Add((Control) this.Label5);
      this.groupbox_admin.Controls.Add((Control) this.textbox_newemail);
      this.groupbox_admin.Controls.Add((Control) this.button_changeemail);
      this.groupbox_admin.Controls.Add((Control) this.textbox_currentemail);
      this.groupbox_admin.Controls.Add((Control) this.button_changepass);
      this.groupbox_admin.Controls.Add((Control) this.textbox_retypepass);
      this.groupbox_admin.Controls.Add((Control) this.textbox_newpass);
      this.groupbox_admin.Controls.Add((Control) this.textbox_currentpass);
      this.groupbox_admin.Location = new Point(10, 3);
      this.groupbox_admin.Name = "groupbox_admin";
      this.groupbox_admin.Size = new Size(300, 339);
      this.groupbox_admin.TabIndex = 0;
      this.groupbox_admin.TabStop = false;
      this.Label8.AutoSize = true;
      this.Label8.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label8.Location = new Point(9, 137);
      this.Label8.Name = "Label8";
      this.Label8.Size = new Size(56, 13);
      this.Label8.TabIndex = 0;
      this.Label8.Text = "Recovery:";
      this.Label7.AutoSize = true;
      this.Label7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label7.Location = new Point(9, 70);
      this.Label7.Name = "Label7";
      this.Label7.Size = new Size(70, 13);
      this.Label7.TabIndex = 0;
      this.Label7.Text = "Re-type new:";
      this.Label6.AutoSize = true;
      this.Label6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label6.Location = new Point(9, 47);
      this.Label6.Name = "Label6";
      this.Label6.Size = new Size(57, 13);
      this.Label6.TabIndex = 0;
      this.Label6.Text = "New pass:";
      this.Label5.AutoSize = true;
      this.Label5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label5.Location = new Point(9, 21);
      this.Label5.Name = "Label5";
      this.Label5.Size = new Size(69, 13);
      this.Label5.TabIndex = 0;
      this.Label5.Text = "Current pass:";
      this.textbox_newemail.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_newemail.Location = new Point(12, 165);
      this.textbox_newemail.MaxLength = 50;
      this.textbox_newemail.Name = "textbox_newemail";
      this.textbox_newemail.ShortcutsEnabled = false;
      this.textbox_newemail.Size = new Size(220, 20);
      this.textbox_newemail.TabIndex = 35;
      this.textbox_newemail.TextAlign = HorizontalAlignment.Right;
      this.button_changeemail.BackColor = Color.White;
      this.button_changeemail.Enabled = false;
      this.button_changeemail.FlatStyle = FlatStyle.Popup;
      this.button_changeemail.Font = new Font("Microsoft Sans Serif", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button_changeemail.Location = new Point(238, 164);
      this.button_changeemail.Name = "button_changeemail";
      this.button_changeemail.Size = new Size(53, 20);
      this.button_changeemail.TabIndex = 0;
      this.button_changeemail.TabStop = false;
      this.button_changeemail.Text = "Change";
      this.button_changeemail.UseVisualStyleBackColor = false;
      this.textbox_currentemail.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_currentemail.Location = new Point(66, 133);
      this.textbox_currentemail.MaxLength = 50;
      this.textbox_currentemail.Name = "textbox_currentemail";
      this.textbox_currentemail.ReadOnly = true;
      this.textbox_currentemail.ShortcutsEnabled = false;
      this.textbox_currentemail.Size = new Size(224, 20);
      this.textbox_currentemail.TabIndex = 0;
      this.textbox_currentemail.TabStop = false;
      this.textbox_currentemail.TextAlign = HorizontalAlignment.Right;
      this.button_changepass.BackColor = Color.White;
      this.button_changepass.Enabled = false;
      this.button_changepass.FlatStyle = FlatStyle.Popup;
      this.button_changepass.Location = new Point(12, 96);
      this.button_changepass.Name = "button_changepass";
      this.button_changepass.Size = new Size(278, 25);
      this.button_changepass.TabIndex = 0;
      this.button_changepass.TabStop = false;
      this.button_changepass.Text = "Change password now";
      this.button_changepass.UseVisualStyleBackColor = false;
      this.textbox_retypepass.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_retypepass.Location = new Point(100, 67);
      this.textbox_retypepass.MaxLength = 50;
      this.textbox_retypepass.Name = "textbox_retypepass";
      this.textbox_retypepass.PasswordChar = '●';
      this.textbox_retypepass.ShortcutsEnabled = false;
      this.textbox_retypepass.Size = new Size(190, 20);
      this.textbox_retypepass.TabIndex = 34;
      this.textbox_retypepass.TextAlign = HorizontalAlignment.Right;
      this.textbox_retypepass.UseSystemPasswordChar = true;
      this.textbox_newpass.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_newpass.Location = new Point(100, 42);
      this.textbox_newpass.MaxLength = 50;
      this.textbox_newpass.Name = "textbox_newpass";
      this.textbox_newpass.PasswordChar = '●';
      this.textbox_newpass.ShortcutsEnabled = false;
      this.textbox_newpass.Size = new Size(190, 20);
      this.textbox_newpass.TabIndex = 33;
      this.textbox_newpass.TextAlign = HorizontalAlignment.Right;
      this.textbox_newpass.UseSystemPasswordChar = true;
      this.textbox_currentpass.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_currentpass.Location = new Point(100, 17);
      this.textbox_currentpass.MaxLength = 50;
      this.textbox_currentpass.Name = "textbox_currentpass";
      this.textbox_currentpass.PasswordChar = '●';
      this.textbox_currentpass.ShortcutsEnabled = false;
      this.textbox_currentpass.Size = new Size(190, 20);
      this.textbox_currentpass.TabIndex = 32;
      this.textbox_currentpass.TextAlign = HorizontalAlignment.Right;
      this.textbox_currentpass.UseSystemPasswordChar = true;
      this.button_savesettings.Enabled = false;
      this.button_savesettings.FlatStyle = FlatStyle.Flat;
      this.button_savesettings.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button_savesettings.Location = new Point(14, 474);
      this.button_savesettings.Name = "button_savesettings";
      this.button_savesettings.Size = new Size(327, 34);
      this.button_savesettings.TabIndex = 0;
      this.button_savesettings.TabStop = false;
      this.button_savesettings.Text = "Save settings";
      this.button_savesettings.UseVisualStyleBackColor = false;
      this.groupbox_apps.Controls.Add((Control) this.textbox_datafolder);
      this.groupbox_apps.Controls.Add((Control) this.textbox_loginretry);
      this.groupbox_apps.Controls.Add((Control) this.textbox_letterkey);
      this.groupbox_apps.Controls.Add((Control) this.label_key);
      this.groupbox_apps.Controls.Add((Control) this.combobox_timesound);
      this.groupbox_apps.Controls.Add((Control) this.combobox_coinsound);
      this.groupbox_apps.Controls.Add((Control) this.label_letterkey);
      this.groupbox_apps.Controls.Add((Control) this.button_browse);
      this.groupbox_apps.Controls.Add((Control) this.button_timeplay);
      this.groupbox_apps.Controls.Add((Control) this.button_coinplay);
      this.groupbox_apps.Controls.Add((Control) this.toggle_5secvoice);
      this.groupbox_apps.Controls.Add((Control) this.toggle_devicedisconnect);
      this.groupbox_apps.Controls.Add((Control) this.toggle_protect);
      this.groupbox_apps.Controls.Add((Control) this.toggle_savedata);
      this.groupbox_apps.Controls.Add((Control) this.toggle_sound);
      this.groupbox_apps.Controls.Add((Control) this.toggle_taskmanager);
      this.groupbox_apps.Controls.Add((Control) this.label_timesound);
      this.groupbox_apps.Controls.Add((Control) this.label_coinsound);
      this.groupbox_apps.Controls.Add((Control) this.label_loginretry);
      this.groupbox_apps.Controls.Add((Control) this.toggle_startup);
      this.groupbox_apps.Controls.Add((Control) this.textbox_turnoff);
      this.groupbox_apps.Controls.Add((Control) this.label_turnoff);
      this.groupbox_apps.Location = new Point(6, 6);
      this.groupbox_apps.Name = "groupbox_apps";
      this.groupbox_apps.Size = new Size(310, 343);
      this.groupbox_apps.TabIndex = 0;
      this.groupbox_apps.TabStop = false;
      this.textbox_datafolder.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_datafolder.Location = new Point(18, 245);
      this.textbox_datafolder.MaxLength = 9999;
      this.textbox_datafolder.Name = "textbox_datafolder";
      this.textbox_datafolder.ReadOnly = true;
      this.textbox_datafolder.ShortcutsEnabled = false;
      this.textbox_datafolder.Size = new Size(216, 20);
      this.textbox_datafolder.TabIndex = 21;
      this.textbox_datafolder.TabStop = false;
      this.textbox_loginretry.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_loginretry.Location = new Point(203, 165);
      this.textbox_loginretry.MaxLength = 2;
      this.textbox_loginretry.Name = "textbox_loginretry";
      this.textbox_loginretry.RightToLeft = RightToLeft.Yes;
      this.textbox_loginretry.ShortcutsEnabled = false;
      this.textbox_loginretry.Size = new Size(91, 20);
      this.textbox_loginretry.TabIndex = 18;
      this.textbox_letterkey.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_letterkey.Location = new Point(203, 190);
      this.textbox_letterkey.MaxLength = 1;
      this.textbox_letterkey.Name = "textbox_letterkey";
      this.textbox_letterkey.ReadOnly = true;
      this.textbox_letterkey.RightToLeft = RightToLeft.Yes;
      this.textbox_letterkey.ShortcutsEnabled = false;
      this.textbox_letterkey.Size = new Size(91, 20);
      this.textbox_letterkey.TabIndex = 19;
      this.label_key.AutoSize = true;
      this.label_key.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.label_key.Location = new Point(122, 194);
      this.label_key.Name = "label_key";
      this.label_key.Size = new Size(73, 13);
      this.label_key.TabIndex = 0;
      this.label_key.Text = "Ctrl+Alt+Shift+";
      this.combobox_timesound.DropDownStyle = ComboBoxStyle.DropDownList;
      this.combobox_timesound.FormattingEnabled = true;
      this.combobox_timesound.ItemHeight = 13;
      this.combobox_timesound.Items.AddRange(new object[2]
      {
        (object) "Custom sound (Time.wav)",
        (object) "siren"
      });
      this.combobox_timesound.Location = new Point(101, 110);
      this.combobox_timesound.MaxDropDownItems = 7;
      this.combobox_timesound.Name = "combobox_timesound";
      this.combobox_timesound.Size = new Size(145, 21);
      this.combobox_timesound.TabIndex = 16;
      this.combobox_coinsound.DropDownStyle = ComboBoxStyle.DropDownList;
      this.combobox_coinsound.DropDownWidth = 150;
      this.combobox_coinsound.FormattingEnabled = true;
      this.combobox_coinsound.ItemHeight = 13;
      this.combobox_coinsound.Items.AddRange(new object[8]
      {
        (object) "Custom sound (Coin.wav)",
        (object) "all eyes on me",
        (object) "appointed",
        (object) "drop in",
        (object) "exquisite",
        (object) "intuition",
        (object) "open ended",
        (object) "pull out"
      });
      this.combobox_coinsound.Location = new Point(101, 85);
      this.combobox_coinsound.MaxDropDownItems = 7;
      this.combobox_coinsound.Name = "combobox_coinsound";
      this.combobox_coinsound.Size = new Size(145, 21);
      this.combobox_coinsound.TabIndex = 15;
      this.label_letterkey.AutoSize = true;
      this.label_letterkey.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label_letterkey.Location = new Point(17, 194);
      this.label_letterkey.Name = "label_letterkey";
      this.label_letterkey.Size = new Size(44, 13);
      this.label_letterkey.TabIndex = 0;
      this.label_letterkey.Text = "Hotkey:";
      this.button_browse.BackgroundImageLayout = ImageLayout.Center;
      this.button_browse.FlatStyle = FlatStyle.Popup;
      this.button_browse.Font = new Font("Microsoft Sans Serif", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button_browse.Location = new Point(237, 245);
      this.button_browse.Name = "button_browse";
      this.button_browse.Size = new Size(57, 20);
      this.button_browse.TabIndex = 0;
      this.button_browse.TabStop = false;
      this.button_browse.Text = "Browse";
      this.button_timeplay.BackgroundImageLayout = ImageLayout.Center;
      this.button_timeplay.FlatStyle = FlatStyle.Popup;
      this.button_timeplay.Font = new Font("Microsoft Sans Serif", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button_timeplay.Location = new Point(252, 109);
      this.button_timeplay.Name = "button_timeplay";
      this.button_timeplay.Size = new Size(42, 21);
      this.button_timeplay.TabIndex = 0;
      this.button_timeplay.TabStop = false;
      this.button_timeplay.Text = "PLAY";
      this.button_coinplay.BackgroundImageLayout = ImageLayout.Center;
      this.button_coinplay.FlatStyle = FlatStyle.Popup;
      this.button_coinplay.Font = new Font("Microsoft Sans Serif", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button_coinplay.Location = new Point(252, 85);
      this.button_coinplay.Name = "button_coinplay";
      this.button_coinplay.Size = new Size(42, 21);
      this.button_coinplay.TabIndex = 0;
      this.button_coinplay.TabStop = false;
      this.button_coinplay.Text = "PLAY";
      this.toggle_devicedisconnect.AutoSize = true;
      this.toggle_devicedisconnect.BackColor = Color.Transparent;
      this.toggle_devicedisconnect.Location = new Point(156, 41);
      this.toggle_devicedisconnect.Name = "toggle_devicedisconnect";
      this.toggle_devicedisconnect.Size = new Size(140, 17);
      this.toggle_devicedisconnect.TabIndex = 13;
      this.toggle_devicedisconnect.Text = "Lock device disconnect";
      this.toggle_devicedisconnect.UseVisualStyleBackColor = false;
      this.toggle_protect.AutoSize = true;
      this.toggle_protect.BackColor = Color.Transparent;
      this.toggle_protect.Location = new Point(17, 41);
      this.toggle_protect.Name = "toggle_protect";
      this.toggle_protect.Size = new Size(122, 17);
      this.toggle_protect.TabIndex = 12;
      this.toggle_protect.Text = "Protect with process";
      this.toggle_protect.UseVisualStyleBackColor = false;
      this.toggle_savedata.AutoSize = true;
      this.toggle_savedata.Location = new Point(21, 222);
      this.toggle_savedata.Name = "toggle_savedata";
      this.toggle_savedata.Size = new Size(178, 17);
      this.toggle_savedata.TabIndex = 20;
      this.toggle_savedata.Text = "Enable data save folder location";
      this.toggle_sound.AutoSize = true;
      this.toggle_sound.Location = new Point(17, 64);
      this.toggle_sound.Name = "toggle_sound";
      this.toggle_sound.Size = new Size(132, 17);
      this.toggle_sound.TabIndex = 14;
      this.toggle_sound.Text = "Play sound notification";
      this.toggle_taskmanager.AutoSize = true;
      this.toggle_taskmanager.Location = new Point(156, 18);
      this.toggle_taskmanager.Name = "toggle_taskmanager";
      this.toggle_taskmanager.Size = new Size(125, 17);
      this.toggle_taskmanager.TabIndex = 11;
      this.toggle_taskmanager.Text = "Disable taskmanager";
      this.label_timesound.AutoSize = true;
      this.label_timesound.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label_timesound.Location = new Point(32, 114);
      this.label_timesound.Name = "label_timesound";
      this.label_timesound.Size = new Size(62, 13);
      this.label_timesound.TabIndex = 0;
      this.label_timesound.Text = "Time sound";
      this.label_coinsound.AutoSize = true;
      this.label_coinsound.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label_coinsound.Location = new Point(34, 89);
      this.label_coinsound.Name = "label_coinsound";
      this.label_coinsound.Size = new Size(60, 13);
      this.label_coinsound.TabIndex = 0;
      this.label_coinsound.Text = "Coin sound";
      this.label_loginretry.AutoSize = true;
      this.label_loginretry.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label_loginretry.Location = new Point(17, 170);
      this.label_loginretry.Name = "label_loginretry";
      this.label_loginretry.Size = new Size(101, 13);
      this.label_loginretry.TabIndex = 0;
      this.label_loginretry.Text = "Password login retry";
      this.toggle_startup.AutoSize = true;
      this.toggle_startup.Location = new Point(17, 18);
      this.toggle_startup.Name = "toggle_startup";
      this.toggle_startup.Size = new Size(93, 17);
      this.toggle_startup.TabIndex = 10;
      this.toggle_startup.Text = "Run at startup";
      this.button_restart.Enabled = false;
      this.button_restart.FlatStyle = FlatStyle.Popup;
      this.button_restart.Font = new Font("Microsoft Sans Serif", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button_restart.Location = new Point(14, 442);
      this.button_restart.Name = "button_restart";
      this.button_restart.Size = new Size(157, 24);
      this.button_restart.TabIndex = 0;
      this.button_restart.TabStop = false;
      this.button_restart.Text = "RESTART COINAPP";
      this.button_restart.UseVisualStyleBackColor = false;
      this.button_close.Enabled = false;
      this.button_close.FlatStyle = FlatStyle.Popup;
      this.button_close.Font = new Font("Microsoft Sans Serif", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button_close.Location = new Point(183, 442);
      this.button_close.Name = "button_close";
      this.button_close.Size = new Size(157, 24);
      this.button_close.TabIndex = 0;
      this.button_close.TabStop = false;
      this.button_close.Text = "CLOSE COINAPP";
      this.button_close.UseVisualStyleBackColor = false;
      this.tabcontrol_settings.Controls.Add((Control) this.tabpage_coins);
      this.tabcontrol_settings.Controls.Add((Control) this.tabpage_apps);
      this.tabcontrol_settings.Controls.Add((Control) this.tabpage_notify);
      this.tabcontrol_settings.Controls.Add((Control) this.tabpage_device);
      this.tabcontrol_settings.Controls.Add((Control) this.tabpage_passemail);
      this.tabcontrol_settings.Controls.Add((Control) this.tabpage_advance);
      this.tabcontrol_settings.ItemSize = new Size(42, 18);
      this.tabcontrol_settings.Location = new Point(14, 55);
      this.tabcontrol_settings.Name = "tabcontrol_settings";
      this.tabcontrol_settings.SelectedIndex = 0;
      this.tabcontrol_settings.Size = new Size(330, 381);
      this.tabcontrol_settings.TabIndex = 1;
      this.tabpage_coins.Controls.Add((Control) this.label_cointype);
      this.tabpage_coins.Controls.Add((Control) this.combobox_cointype);
      this.tabpage_coins.Controls.Add((Control) this.groupbox_coins);
      this.tabpage_coins.Location = new Point(4, 22);
      this.tabpage_coins.Name = "tabpage_coins";
      this.tabpage_coins.Padding = new Padding(3);
      this.tabpage_coins.Size = new Size(322, 355);
      this.tabpage_coins.TabIndex = 0;
      this.tabpage_coins.Text = "Coins";
      this.tabpage_coins.UseVisualStyleBackColor = true;
      this.tabpage_apps.Controls.Add((Control) this.groupbox_apps);
      this.tabpage_apps.Location = new Point(4, 22);
      this.tabpage_apps.Name = "tabpage_apps";
      this.tabpage_apps.Padding = new Padding(3);
      this.tabpage_apps.Size = new Size(322, 355);
      this.tabpage_apps.TabIndex = 1;
      this.tabpage_apps.Text = "Apps";
      this.tabpage_apps.UseVisualStyleBackColor = true;
      this.tabpage_notify.Controls.Add((Control) this.groupbox_notify);
      this.tabpage_notify.Location = new Point(4, 22);
      this.tabpage_notify.Name = "tabpage_notify";
      this.tabpage_notify.Size = new Size(322, 355);
      this.tabpage_notify.TabIndex = 2;
      this.tabpage_notify.Text = "Notify";
      this.tabpage_notify.UseVisualStyleBackColor = true;
      this.tabpage_device.Controls.Add((Control) this.groupbox_device);
      this.tabpage_device.Location = new Point(4, 22);
      this.tabpage_device.Name = "tabpage_device";
      this.tabpage_device.Size = new Size(322, 355);
      this.tabpage_device.TabIndex = 3;
      this.tabpage_device.Text = "Device";
      this.tabpage_device.UseVisualStyleBackColor = true;
      this.groupbox_device.Controls.Add((Control) this.button_playbeepshut);
      this.groupbox_device.Controls.Add((Control) this.textbox_beeptimefreq);
      this.groupbox_device.Controls.Add((Control) this.button_playbeeplock);
      this.groupbox_device.Controls.Add((Control) this.textbox_beeptime);
      this.groupbox_device.Controls.Add((Control) this.toggle_beephardware);
      this.groupbox_device.Controls.Add((Control) this.textbox_beeplockfreq);
      this.groupbox_device.Controls.Add((Control) this.button_playbeeptime);
      this.groupbox_device.Controls.Add((Control) this.textbox_beepshutfreq);
      this.groupbox_device.Controls.Add((Control) this.textbox_beeptimerep);
      this.groupbox_device.Controls.Add((Control) this.button_playbeepcoin);
      this.groupbox_device.Controls.Add((Control) this.textbox_beepcoinfreq);
      this.groupbox_device.Controls.Add((Control) this.toggle_beepshutdown);
      this.groupbox_device.Controls.Add((Control) this.textbox_beeplockrep);
      this.groupbox_device.Controls.Add((Control) this.textbox_beepshutdur);
      this.groupbox_device.Controls.Add((Control) this.label_beeplock);
      this.groupbox_device.Controls.Add((Control) this.label_beepcoindrop);
      this.groupbox_device.Controls.Add((Control) this.textbox_beeptimedur);
      this.groupbox_device.Controls.Add((Control) this.textbox_beepcoindur);
      this.groupbox_device.Controls.Add((Control) this.label_beeptime);
      this.groupbox_device.Controls.Add((Control) this.label_beepshut);
      this.groupbox_device.Controls.Add((Control) this.textbox_beeplockdur);
      this.groupbox_device.Location = new Point(11, 11);
      this.groupbox_device.Name = "groupbox_device";
      this.groupbox_device.Size = new Size(298, 332);
      this.groupbox_device.TabIndex = 2;
      this.groupbox_device.TabStop = false;
      this.tabpage_passemail.Controls.Add((Control) this.groupbox_admin);
      this.tabpage_passemail.Location = new Point(4, 22);
      this.tabpage_passemail.Name = "tabpage_passemail";
      this.tabpage_passemail.Size = new Size(322, 355);
      this.tabpage_passemail.TabIndex = 4;
      this.tabpage_passemail.Text = "Pass/email";
      this.tabpage_passemail.UseVisualStyleBackColor = true;
      this.tabpage_advance.Controls.Add((Control) this.GroupBox1);
      this.tabpage_advance.Location = new Point(4, 22);
      this.tabpage_advance.Name = "tabpage_advance";
      this.tabpage_advance.Size = new Size(322, 355);
      this.tabpage_advance.TabIndex = 5;
      this.tabpage_advance.Text = "Advance";
      this.tabpage_advance.UseVisualStyleBackColor = true;
      this.GroupBox1.Controls.Add((Control) this.textbox_waitforprocmon);
      this.GroupBox1.Controls.Add((Control) this.label_waitforprocmon);
      this.GroupBox1.Controls.Add((Control) this.combobox_shutdowntime);
      this.GroupBox1.Controls.Add((Control) this.combobox_deviceproblemcolor);
      this.GroupBox1.Controls.Add((Control) this.combobox_lockwindowbgcolor);
      this.GroupBox1.Controls.Add((Control) this.combobox_startupinitializecolor);
      this.GroupBox1.Controls.Add((Control) this.combobox_lockwindowtrans);
      this.GroupBox1.Controls.Add((Control) this.combobox_lockwindowpos);
      this.GroupBox1.Controls.Add((Control) this.combobox_bgimagelayout);
      this.GroupBox1.Controls.Add((Control) this.checkbox_advance);
      this.GroupBox1.Controls.Add((Control) this.checkbox_customizelock);
      this.GroupBox1.Controls.Add((Control) this.button_browsebgimage);
      this.GroupBox1.Controls.Add((Control) this.label_shutdowntime);
      this.GroupBox1.Controls.Add((Control) this.label_deviceproblemcolor);
      this.GroupBox1.Controls.Add((Control) this.label_startupinitializecolor);
      this.GroupBox1.Controls.Add((Control) this.label_lockwindowbgcolor);
      this.GroupBox1.Controls.Add((Control) this.label_lockwindowtrans);
      this.GroupBox1.Controls.Add((Control) this.label_lockwindowpos);
      this.GroupBox1.Controls.Add((Control) this.label_bgimagelayout);
      this.GroupBox1.Controls.Add((Control) this.label_bg);
      this.GroupBox1.Controls.Add((Control) this.textbox_bgimagelocation);
      this.GroupBox1.Location = new Point(10, 5);
      this.GroupBox1.Name = "GroupBox1";
      this.GroupBox1.Size = new Size(299, 337);
      this.GroupBox1.TabIndex = 0;
      this.GroupBox1.TabStop = false;
      this.textbox_waitforprocmon.Location = new Point(220, 282);
      this.textbox_waitforprocmon.MaxLength = 4;
      this.textbox_waitforprocmon.Name = "textbox_waitforprocmon";
      this.textbox_waitforprocmon.Size = new Size(60, 20);
      this.textbox_waitforprocmon.TabIndex = 34;
      this.label_waitforprocmon.AutoSize = true;
      this.label_waitforprocmon.Location = new Point(29, 285);
      this.label_waitforprocmon.Name = "label_waitforprocmon";
      this.label_waitforprocmon.Size = new Size(143, 13);
      this.label_waitforprocmon.TabIndex = 33;
      this.label_waitforprocmon.Text = "Wait for procmon.exe to load";
      this.combobox_shutdowntime.DropDownStyle = ComboBoxStyle.DropDownList;
      this.combobox_shutdowntime.Enabled = false;
      this.combobox_shutdowntime.FormattingEnabled = true;
      this.combobox_shutdowntime.Items.AddRange(new object[8]
      {
        (object) "White",
        (object) "Black",
        (object) "Red",
        (object) "Blue",
        (object) "Green",
        (object) "Yellow",
        (object) "Orange",
        (object) "Violet"
      });
      this.combobox_shutdowntime.Location = new Point(220, 233);
      this.combobox_shutdowntime.Name = "combobox_shutdowntime";
      this.combobox_shutdowntime.Size = new Size(60, 21);
      this.combobox_shutdowntime.TabIndex = 32;
      this.combobox_deviceproblemcolor.DropDownStyle = ComboBoxStyle.DropDownList;
      this.combobox_deviceproblemcolor.Enabled = false;
      this.combobox_deviceproblemcolor.FormattingEnabled = true;
      this.combobox_deviceproblemcolor.Items.AddRange(new object[8]
      {
        (object) "White",
        (object) "Black",
        (object) "Red",
        (object) "Blue",
        (object) "Green",
        (object) "Yellow",
        (object) "Orange",
        (object) "Violet"
      });
      this.combobox_deviceproblemcolor.Location = new Point(220, 207);
      this.combobox_deviceproblemcolor.Name = "combobox_deviceproblemcolor";
      this.combobox_deviceproblemcolor.Size = new Size(60, 21);
      this.combobox_deviceproblemcolor.TabIndex = 32;
      this.combobox_lockwindowbgcolor.DropDownStyle = ComboBoxStyle.DropDownList;
      this.combobox_lockwindowbgcolor.Enabled = false;
      this.combobox_lockwindowbgcolor.FormattingEnabled = true;
      this.combobox_lockwindowbgcolor.Items.AddRange(new object[8]
      {
        (object) "White",
        (object) "Black",
        (object) "Red",
        (object) "Blue",
        (object) "Green",
        (object) "Yellow",
        (object) "Orange",
        (object) "Violet"
      });
      this.combobox_lockwindowbgcolor.Location = new Point(220, 157);
      this.combobox_lockwindowbgcolor.Name = "combobox_lockwindowbgcolor";
      this.combobox_lockwindowbgcolor.Size = new Size(60, 21);
      this.combobox_lockwindowbgcolor.TabIndex = 32;
      this.combobox_startupinitializecolor.DropDownStyle = ComboBoxStyle.DropDownList;
      this.combobox_startupinitializecolor.Enabled = false;
      this.combobox_startupinitializecolor.FormattingEnabled = true;
      this.combobox_startupinitializecolor.Items.AddRange(new object[8]
      {
        (object) "White",
        (object) "Black",
        (object) "Red",
        (object) "Blue",
        (object) "Green",
        (object) "Yellow",
        (object) "Orange",
        (object) "Violet"
      });
      this.combobox_startupinitializecolor.Location = new Point(220, 182);
      this.combobox_startupinitializecolor.Name = "combobox_startupinitializecolor";
      this.combobox_startupinitializecolor.Size = new Size(60, 21);
      this.combobox_startupinitializecolor.TabIndex = 32;
      this.combobox_lockwindowtrans.DropDownStyle = ComboBoxStyle.DropDownList;
      this.combobox_lockwindowtrans.Enabled = false;
      this.combobox_lockwindowtrans.FormattingEnabled = true;
      this.combobox_lockwindowtrans.Items.AddRange(new object[2]
      {
        (object) "Yes",
        (object) "No"
      });
      this.combobox_lockwindowtrans.Location = new Point(220, 133);
      this.combobox_lockwindowtrans.Name = "combobox_lockwindowtrans";
      this.combobox_lockwindowtrans.Size = new Size(60, 21);
      this.combobox_lockwindowtrans.TabIndex = 4;
      this.combobox_lockwindowpos.DropDownStyle = ComboBoxStyle.DropDownList;
      this.combobox_lockwindowpos.Enabled = false;
      this.combobox_lockwindowpos.FormattingEnabled = true;
      this.combobox_lockwindowpos.Items.AddRange(new object[2]
      {
        (object) "Bottom",
        (object) "Top"
      });
      this.combobox_lockwindowpos.Location = new Point(220, 109);
      this.combobox_lockwindowpos.Name = "combobox_lockwindowpos";
      this.combobox_lockwindowpos.Size = new Size(60, 21);
      this.combobox_lockwindowpos.TabIndex = 4;
      this.combobox_bgimagelayout.DropDownStyle = ComboBoxStyle.DropDownList;
      this.combobox_bgimagelayout.Enabled = false;
      this.combobox_bgimagelayout.FormattingEnabled = true;
      this.combobox_bgimagelayout.Items.AddRange(new object[5]
      {
        (object) "None",
        (object) "Tile",
        (object) "Center",
        (object) "Stretch",
        (object) "Zoom"
      });
      this.combobox_bgimagelayout.Location = new Point(220, 85);
      this.combobox_bgimagelayout.Name = "combobox_bgimagelayout";
      this.combobox_bgimagelayout.Size = new Size(60, 21);
      this.combobox_bgimagelayout.TabIndex = 4;
      this.checkbox_advance.AutoSize = true;
      this.checkbox_advance.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.checkbox_advance.Location = new Point(9, 260);
      this.checkbox_advance.Name = "checkbox_advance";
      this.checkbox_advance.Size = new Size(172, 19);
      this.checkbox_advance.TabIndex = 3;
      this.checkbox_advance.Text = "Advance customization";
      this.checkbox_advance.UseVisualStyleBackColor = true;
      this.checkbox_customizelock.AutoSize = true;
      this.checkbox_customizelock.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.checkbox_customizelock.Location = new Point(9, 15);
      this.checkbox_customizelock.Name = "checkbox_customizelock";
      this.checkbox_customizelock.Size = new Size(226, 19);
      this.checkbox_customizelock.TabIndex = 3;
      this.checkbox_customizelock.Text = "Enable GUI Lock customization";
      this.checkbox_customizelock.UseVisualStyleBackColor = true;
      this.button_browsebgimage.Enabled = false;
      this.button_browsebgimage.FlatStyle = FlatStyle.Popup;
      this.button_browsebgimage.Font = new Font("Microsoft Sans Serif", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button_browsebgimage.Location = new Point(220, 57);
      this.button_browsebgimage.Name = "button_browsebgimage";
      this.button_browsebgimage.Size = new Size(60, 20);
      this.button_browsebgimage.TabIndex = 2;
      this.button_browsebgimage.Text = "BROWSE";
      this.button_browsebgimage.UseVisualStyleBackColor = true;
      this.label_shutdowntime.AutoSize = true;
      this.label_shutdowntime.Enabled = false;
      this.label_shutdowntime.Location = new Point(28, 237);
      this.label_shutdowntime.Name = "label_shutdowntime";
      this.label_shutdowntime.Size = new Size(168, 13);
      this.label_shutdowntime.TabIndex = 0;
      this.label_shutdowntime.Text = "Shutdown time counting font color";
      this.label_deviceproblemcolor.AutoSize = true;
      this.label_deviceproblemcolor.Enabled = false;
      this.label_deviceproblemcolor.Location = new Point(28, 211);
      this.label_deviceproblemcolor.Name = "label_deviceproblemcolor";
      this.label_deviceproblemcolor.Size = new Size(170, 13);
      this.label_deviceproblemcolor.TabIndex = 0;
      this.label_deviceproblemcolor.Text = "Device problem occured font color";
      this.label_startupinitializecolor.AutoSize = true;
      this.label_startupinitializecolor.Enabled = false;
      this.label_startupinitializecolor.Location = new Point(28, 187);
      this.label_startupinitializecolor.Name = "label_startupinitializecolor";
      this.label_startupinitializecolor.Size = new Size((int) sbyte.MaxValue, 13);
      this.label_startupinitializecolor.TabIndex = 0;
      this.label_startupinitializecolor.Text = "Startup initialize font color";
      this.label_lockwindowbgcolor.AutoSize = true;
      this.label_lockwindowbgcolor.Enabled = false;
      this.label_lockwindowbgcolor.Location = new Point(28, 161);
      this.label_lockwindowbgcolor.Name = "label_lockwindowbgcolor";
      this.label_lockwindowbgcolor.Size = new Size(149, 13);
      this.label_lockwindowbgcolor.TabIndex = 0;
      this.label_lockwindowbgcolor.Text = "Lock window control BG color";
      this.label_lockwindowtrans.AutoSize = true;
      this.label_lockwindowtrans.Enabled = false;
      this.label_lockwindowtrans.Location = new Point(28, 137);
      this.label_lockwindowtrans.Name = "label_lockwindowtrans";
      this.label_lockwindowtrans.Size = new Size(161, 13);
      this.label_lockwindowtrans.TabIndex = 0;
      this.label_lockwindowtrans.Text = "Lock window control transparent";
      this.label_lockwindowpos.AutoSize = true;
      this.label_lockwindowpos.Enabled = false;
      this.label_lockwindowpos.Location = new Point(28, 113);
      this.label_lockwindowpos.Name = "label_lockwindowpos";
      this.label_lockwindowpos.Size = new Size(144, 13);
      this.label_lockwindowpos.TabIndex = 0;
      this.label_lockwindowpos.Text = "Lock window control position";
      this.label_bgimagelayout.AutoSize = true;
      this.label_bgimagelayout.Enabled = false;
      this.label_bgimagelayout.Location = new Point(28, 89);
      this.label_bgimagelayout.Name = "label_bgimagelayout";
      this.label_bgimagelayout.Size = new Size(128, 13);
      this.label_bgimagelayout.TabIndex = 0;
      this.label_bgimagelayout.Text = "Background Image layout";
      this.label_bg.AutoSize = true;
      this.label_bg.Enabled = false;
      this.label_bg.Location = new Point(28, 39);
      this.label_bg.Name = "label_bg";
      this.label_bg.Size = new Size(136, 13);
      this.label_bg.TabIndex = 0;
      this.label_bg.Text = "Background image location";
      this.textbox_bgimagelocation.Enabled = false;
      this.textbox_bgimagelocation.Location = new Point(31, 58);
      this.textbox_bgimagelocation.Name = "textbox_bgimagelocation";
      this.textbox_bgimagelocation.ReadOnly = true;
      this.textbox_bgimagelocation.Size = new Size(179, 20);
      this.textbox_bgimagelocation.TabIndex = 0;
      this.toggle_5secvoice.AutoSize = true;
      this.toggle_5secvoice.BackColor = Color.Transparent;
      this.toggle_5secvoice.Location = new Point(156, 62);
      this.toggle_5secvoice.Name = "toggle_5secvoice";
      this.toggle_5secvoice.Size = new Size((int) sbyte.MaxValue, 17);
      this.toggle_5secvoice.TabIndex = 13;
      this.toggle_5secvoice.Text = "Play 5 seconds voice";
      this.toggle_5secvoice.UseVisualStyleBackColor = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(354, 521);
      this.Controls.Add((Control) this.tabcontrol_settings);
      this.Controls.Add((Control) this.button_deviceinfo);
      this.Controls.Add((Control) this.button_savesettings);
      this.Controls.Add((Control) this.combobox_device);
      this.Controls.Add((Control) this.button_device);
      this.Controls.Add((Control) this.button_restart);
      this.Controls.Add((Control) this.button_close);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MaximumSize = new Size(370, 560);
      this.MinimizeBox = false;
      this.MinimumSize = new Size(370, 560);
      this.Name = nameof (Form_settings);
      this.Padding = new Padding(20, 30, 20, 20);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = " Settings";
      this.groupbox_coins.ResumeLayout(false);
      this.groupbox_coins.PerformLayout();
      this.groupbox_notify.ResumeLayout(false);
      this.groupbox_notify.PerformLayout();
      this.groupbox_admin.ResumeLayout(false);
      this.groupbox_admin.PerformLayout();
      this.groupbox_apps.ResumeLayout(false);
      this.groupbox_apps.PerformLayout();
      this.tabcontrol_settings.ResumeLayout(false);
      this.tabpage_coins.ResumeLayout(false);
      this.tabpage_coins.PerformLayout();
      this.tabpage_apps.ResumeLayout(false);
      this.tabpage_notify.ResumeLayout(false);
      this.tabpage_device.ResumeLayout(false);
      this.groupbox_device.ResumeLayout(false);
      this.groupbox_device.PerformLayout();
      this.tabpage_passemail.ResumeLayout(false);
      this.tabpage_advance.ResumeLayout(false);
      this.GroupBox1.ResumeLayout(false);
      this.GroupBox1.PerformLayout();
      this.ResumeLayout(false);
    }

    private virtual ComboBox combobox_device { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual Button button_device
    {
      get
      {
        return this._button_device;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.button_device_Click);
        EventHandler eventHandler2 = new EventHandler(this.button_device_MouseHover);
        EventHandler eventHandler3 = new EventHandler(this.button_device_MouseLeave);
        Button buttonDevice1 = this._button_device;
        if (buttonDevice1 != null)
        {
          buttonDevice1.Click -= eventHandler1;
          buttonDevice1.MouseHover -= eventHandler2;
          buttonDevice1.MouseLeave -= eventHandler3;
        }
        this._button_device = value;
        Button buttonDevice2 = this._button_device;
        if (buttonDevice2 == null)
          return;
        buttonDevice2.Click += eventHandler1;
        buttonDevice2.MouseHover += eventHandler2;
        buttonDevice2.MouseLeave += eventHandler3;
      }
    }

    private virtual Button button_deviceinfo
    {
      get
      {
        return this._button_deviceinfo;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.button_deviceinfo_Click);
        Button buttonDeviceinfo1 = this._button_deviceinfo;
        if (buttonDeviceinfo1 != null)
          buttonDeviceinfo1.Click -= eventHandler;
        this._button_deviceinfo = value;
        Button buttonDeviceinfo2 = this._button_deviceinfo;
        if (buttonDeviceinfo2 == null)
          return;
        buttonDeviceinfo2.Click += eventHandler;
      }
    }

    private virtual ComboBox combobox_cointype
    {
      get
      {
        return this._combobox_cointype;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.combobox_cointype_SelectedIndexChanged);
        ComboBox comboboxCointype1 = this._combobox_cointype;
        if (comboboxCointype1 != null)
          comboboxCointype1.SelectedIndexChanged -= eventHandler;
        this._combobox_cointype = value;
        ComboBox comboboxCointype2 = this._combobox_cointype;
        if (comboboxCointype2 == null)
          return;
        comboboxCointype2.SelectedIndexChanged += eventHandler;
      }
    }

    private virtual TextBox textbox_notification1_messages
    {
      get
      {
        return this._textbox_notification1_messages;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.textbox_notifications_MouseHover);
        TextBox notification1Messages1 = this._textbox_notification1_messages;
        if (notification1Messages1 != null)
          notification1Messages1.MouseHover -= eventHandler;
        this._textbox_notification1_messages = value;
        TextBox notification1Messages2 = this._textbox_notification1_messages;
        if (notification1Messages2 == null)
          return;
        notification1Messages2.MouseHover += eventHandler;
      }
    }

    private virtual TextBox textbox_notification2_seconds
    {
      get
      {
        return this._textbox_notification2_seconds;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.textBox_KeyPress);
        EventHandler eventHandler = new EventHandler(this.textbox_notifications_MouseHover);
        TextBox notification2Seconds1 = this._textbox_notification2_seconds;
        if (notification2Seconds1 != null)
        {
          notification2Seconds1.KeyPress -= pressEventHandler;
          notification2Seconds1.MouseHover -= eventHandler;
        }
        this._textbox_notification2_seconds = value;
        TextBox notification2Seconds2 = this._textbox_notification2_seconds;
        if (notification2Seconds2 == null)
          return;
        notification2Seconds2.KeyPress += pressEventHandler;
        notification2Seconds2.MouseHover += eventHandler;
      }
    }

    private virtual TextBox textbox_notification1_seconds
    {
      get
      {
        return this._textbox_notification1_seconds;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.textBox_KeyPress);
        EventHandler eventHandler = new EventHandler(this.textbox_notifications_MouseHover);
        TextBox notification1Seconds1 = this._textbox_notification1_seconds;
        if (notification1Seconds1 != null)
        {
          notification1Seconds1.KeyPress -= pressEventHandler;
          notification1Seconds1.MouseHover -= eventHandler;
        }
        this._textbox_notification1_seconds = value;
        TextBox notification1Seconds2 = this._textbox_notification1_seconds;
        if (notification1Seconds2 == null)
          return;
        notification1Seconds2.KeyPress += pressEventHandler;
        notification1Seconds2.MouseHover += eventHandler;
      }
    }

    private virtual TextBox textbox_coin3
    {
      get
      {
        return this._textbox_coin3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.textBox_KeyPress);
        EventHandler eventHandler1 = new EventHandler(this.textbox_TextChanged);
        EventHandler eventHandler2 = new EventHandler(this.textbox_coins_Click);
        TextBox textboxCoin3_1 = this._textbox_coin3;
        if (textboxCoin3_1 != null)
        {
          textboxCoin3_1.KeyPress -= pressEventHandler;
          textboxCoin3_1.TextChanged -= eventHandler1;
          textboxCoin3_1.MouseHover -= eventHandler2;
        }
        this._textbox_coin3 = value;
        TextBox textboxCoin3_2 = this._textbox_coin3;
        if (textboxCoin3_2 == null)
          return;
        textboxCoin3_2.KeyPress += pressEventHandler;
        textboxCoin3_2.TextChanged += eventHandler1;
        textboxCoin3_2.MouseHover += eventHandler2;
      }
    }

    private virtual TextBox textbox_coin2
    {
      get
      {
        return this._textbox_coin2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.textBox_KeyPress);
        EventHandler eventHandler1 = new EventHandler(this.textbox_TextChanged);
        EventHandler eventHandler2 = new EventHandler(this.textbox_coins_Click);
        TextBox textboxCoin2_1 = this._textbox_coin2;
        if (textboxCoin2_1 != null)
        {
          textboxCoin2_1.KeyPress -= pressEventHandler;
          textboxCoin2_1.TextChanged -= eventHandler1;
          textboxCoin2_1.MouseHover -= eventHandler2;
        }
        this._textbox_coin2 = value;
        TextBox textboxCoin2_2 = this._textbox_coin2;
        if (textboxCoin2_2 == null)
          return;
        textboxCoin2_2.KeyPress += pressEventHandler;
        textboxCoin2_2.TextChanged += eventHandler1;
        textboxCoin2_2.MouseHover += eventHandler2;
      }
    }

    private virtual TextBox textbox_notification2_messages
    {
      get
      {
        return this._textbox_notification2_messages;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.textbox_notifications_MouseHover);
        TextBox notification2Messages1 = this._textbox_notification2_messages;
        if (notification2Messages1 != null)
          notification2Messages1.MouseHover -= eventHandler;
        this._textbox_notification2_messages = value;
        TextBox notification2Messages2 = this._textbox_notification2_messages;
        if (notification2Messages2 == null)
          return;
        notification2Messages2.MouseHover += eventHandler;
      }
    }

    private virtual Label label_coin3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual TextBox textbox_coin1_pulse
    {
      get
      {
        return this._textbox_coin1_pulse;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.textBox_KeyPress);
        EventHandler eventHandler1 = new EventHandler(this.textbox_TextChanged);
        EventHandler eventHandler2 = new EventHandler(this.textbox_coins_Click);
        TextBox textboxCoin1Pulse1 = this._textbox_coin1_pulse;
        if (textboxCoin1Pulse1 != null)
        {
          textboxCoin1Pulse1.KeyPress -= pressEventHandler;
          textboxCoin1Pulse1.TextChanged -= eventHandler1;
          textboxCoin1Pulse1.MouseHover -= eventHandler2;
        }
        this._textbox_coin1_pulse = value;
        TextBox textboxCoin1Pulse2 = this._textbox_coin1_pulse;
        if (textboxCoin1Pulse2 == null)
          return;
        textboxCoin1Pulse2.KeyPress += pressEventHandler;
        textboxCoin1Pulse2.TextChanged += eventHandler1;
        textboxCoin1Pulse2.MouseHover += eventHandler2;
      }
    }

    private virtual Label label_coin2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual TextBox textbox_turnoff
    {
      get
      {
        return this._textbox_turnoff;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.textBox_KeyPress);
        EventHandler eventHandler = new EventHandler(this.textbox_TextChanged);
        TextBox textboxTurnoff1 = this._textbox_turnoff;
        if (textboxTurnoff1 != null)
        {
          textboxTurnoff1.KeyPress -= pressEventHandler;
          textboxTurnoff1.TextChanged -= eventHandler;
        }
        this._textbox_turnoff = value;
        TextBox textboxTurnoff2 = this._textbox_turnoff;
        if (textboxTurnoff2 == null)
          return;
        textboxTurnoff2.KeyPress += pressEventHandler;
        textboxTurnoff2.TextChanged += eventHandler;
      }
    }

    private virtual Label label_coin1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual Label label_notify2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual GroupBox groupbox_coins { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual TextBox textbox_coin3_pulse
    {
      get
      {
        return this._textbox_coin3_pulse;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.textBox_KeyPress);
        EventHandler eventHandler1 = new EventHandler(this.textbox_TextChanged);
        EventHandler eventHandler2 = new EventHandler(this.textbox_coins_Click);
        TextBox textboxCoin3Pulse1 = this._textbox_coin3_pulse;
        if (textboxCoin3Pulse1 != null)
        {
          textboxCoin3Pulse1.KeyPress -= pressEventHandler;
          textboxCoin3Pulse1.TextChanged -= eventHandler1;
          textboxCoin3Pulse1.MouseHover -= eventHandler2;
        }
        this._textbox_coin3_pulse = value;
        TextBox textboxCoin3Pulse2 = this._textbox_coin3_pulse;
        if (textboxCoin3Pulse2 == null)
          return;
        textboxCoin3Pulse2.KeyPress += pressEventHandler;
        textboxCoin3Pulse2.TextChanged += eventHandler1;
        textboxCoin3Pulse2.MouseHover += eventHandler2;
      }
    }

    private virtual TextBox textbox_coin2_pulse
    {
      get
      {
        return this._textbox_coin2_pulse;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.textBox_KeyPress);
        EventHandler eventHandler1 = new EventHandler(this.textbox_TextChanged);
        EventHandler eventHandler2 = new EventHandler(this.textbox_coins_Click);
        TextBox textboxCoin2Pulse1 = this._textbox_coin2_pulse;
        if (textboxCoin2Pulse1 != null)
        {
          textboxCoin2Pulse1.KeyPress -= pressEventHandler;
          textboxCoin2Pulse1.TextChanged -= eventHandler1;
          textboxCoin2Pulse1.MouseHover -= eventHandler2;
        }
        this._textbox_coin2_pulse = value;
        TextBox textboxCoin2Pulse2 = this._textbox_coin2_pulse;
        if (textboxCoin2Pulse2 == null)
          return;
        textboxCoin2Pulse2.KeyPress += pressEventHandler;
        textboxCoin2Pulse2.TextChanged += eventHandler1;
        textboxCoin2Pulse2.MouseHover += eventHandler2;
      }
    }

    private virtual TextBox textbox_coin1
    {
      get
      {
        return this._textbox_coin1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.textBox_KeyPress);
        EventHandler eventHandler1 = new EventHandler(this.textbox_TextChanged);
        EventHandler eventHandler2 = new EventHandler(this.textbox_coins_Click);
        TextBox textboxCoin1_1 = this._textbox_coin1;
        if (textboxCoin1_1 != null)
        {
          textboxCoin1_1.KeyPress -= pressEventHandler;
          textboxCoin1_1.TextChanged -= eventHandler1;
          textboxCoin1_1.MouseHover -= eventHandler2;
        }
        this._textbox_coin1 = value;
        TextBox textboxCoin1_2 = this._textbox_coin1;
        if (textboxCoin1_2 == null)
          return;
        textboxCoin1_2.KeyPress += pressEventHandler;
        textboxCoin1_2.TextChanged += eventHandler1;
        textboxCoin1_2.MouseHover += eventHandler2;
      }
    }

    private virtual Label label_turnoff { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual Label label_notify1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual Label label_cointype { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual GroupBox groupbox_apps { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual CheckBox toggle_startup { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual Button button_savesettings
    {
      get
      {
        return this._button_savesettings;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.button_savesetting_Click);
        Button buttonSavesettings1 = this._button_savesettings;
        if (buttonSavesettings1 != null)
          buttonSavesettings1.Click -= eventHandler;
        this._button_savesettings = value;
        Button buttonSavesettings2 = this._button_savesettings;
        if (buttonSavesettings2 == null)
          return;
        buttonSavesettings2.Click += eventHandler;
      }
    }

    private virtual GroupBox groupbox_admin { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual TextBox textbox_currentpass
    {
      get
      {
        return this._textbox_currentpass;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.textbox_passwordChange);
        TextBox textboxCurrentpass1 = this._textbox_currentpass;
        if (textboxCurrentpass1 != null)
          textboxCurrentpass1.TextChanged -= eventHandler;
        this._textbox_currentpass = value;
        TextBox textboxCurrentpass2 = this._textbox_currentpass;
        if (textboxCurrentpass2 == null)
          return;
        textboxCurrentpass2.TextChanged += eventHandler;
      }
    }

    private virtual TextBox textbox_newpass
    {
      get
      {
        return this._textbox_newpass;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.textbox_passwordChange);
        TextBox textboxNewpass1 = this._textbox_newpass;
        if (textboxNewpass1 != null)
          textboxNewpass1.TextChanged -= eventHandler;
        this._textbox_newpass = value;
        TextBox textboxNewpass2 = this._textbox_newpass;
        if (textboxNewpass2 == null)
          return;
        textboxNewpass2.TextChanged += eventHandler;
      }
    }

    private virtual TextBox textbox_retypepass
    {
      get
      {
        return this._textbox_retypepass;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.textbox_passwordChange);
        TextBox textboxRetypepass1 = this._textbox_retypepass;
        if (textboxRetypepass1 != null)
          textboxRetypepass1.TextChanged -= eventHandler;
        this._textbox_retypepass = value;
        TextBox textboxRetypepass2 = this._textbox_retypepass;
        if (textboxRetypepass2 == null)
          return;
        textboxRetypepass2.TextChanged += eventHandler;
      }
    }

    private virtual Button button_close
    {
      get
      {
        return this._button_close;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.button_close_Click);
        Button buttonClose1 = this._button_close;
        if (buttonClose1 != null)
          buttonClose1.Click -= eventHandler;
        this._button_close = value;
        Button buttonClose2 = this._button_close;
        if (buttonClose2 == null)
          return;
        buttonClose2.Click += eventHandler;
      }
    }

    private virtual Button button_changepass
    {
      get
      {
        return this._button_changepass;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.button_changepass_Click);
        Button buttonChangepass1 = this._button_changepass;
        if (buttonChangepass1 != null)
          buttonChangepass1.Click -= eventHandler;
        this._button_changepass = value;
        Button buttonChangepass2 = this._button_changepass;
        if (buttonChangepass2 == null)
          return;
        buttonChangepass2.Click += eventHandler;
      }
    }

    private virtual TextBox textbox_letterkey
    {
      get
      {
        return this._textbox_letterkey;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyEventHandler keyEventHandler = new KeyEventHandler(this.textbox_letterkey_KeyDown);
        EventHandler eventHandler1 = new EventHandler(this.textbox_letterkey_Click);
        EventHandler eventHandler2 = new EventHandler(this.textbox_letterkey_Click);
        EventHandler eventHandler3 = new EventHandler(this.textbox_letterkey_Leave);
        EventHandler eventHandler4 = new EventHandler(this.textbox_TextChanged);
        TextBox textboxLetterkey1 = this._textbox_letterkey;
        if (textboxLetterkey1 != null)
        {
          textboxLetterkey1.KeyDown -= keyEventHandler;
          textboxLetterkey1.Click -= eventHandler1;
          textboxLetterkey1.GotFocus -= eventHandler2;
          textboxLetterkey1.Leave -= eventHandler3;
          textboxLetterkey1.TextChanged -= eventHandler4;
        }
        this._textbox_letterkey = value;
        TextBox textboxLetterkey2 = this._textbox_letterkey;
        if (textboxLetterkey2 == null)
          return;
        textboxLetterkey2.KeyDown += keyEventHandler;
        textboxLetterkey2.Click += eventHandler1;
        textboxLetterkey2.GotFocus += eventHandler2;
        textboxLetterkey2.Leave += eventHandler3;
        textboxLetterkey2.TextChanged += eventHandler4;
      }
    }

    private virtual Label label_key { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual Label label_letterkey { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual TextBox textbox_notify_coin1
    {
      get
      {
        return this._textbox_notify_coin1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.textbox_coins_Click);
        TextBox textboxNotifyCoin1_1 = this._textbox_notify_coin1;
        if (textboxNotifyCoin1_1 != null)
          textboxNotifyCoin1_1.MouseHover -= eventHandler;
        this._textbox_notify_coin1 = value;
        TextBox textboxNotifyCoin1_2 = this._textbox_notify_coin1;
        if (textboxNotifyCoin1_2 == null)
          return;
        textboxNotifyCoin1_2.MouseHover += eventHandler;
      }
    }

    private virtual TextBox textbox_notify_coin2
    {
      get
      {
        return this._textbox_notify_coin2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.textbox_coins_Click);
        TextBox textboxNotifyCoin2_1 = this._textbox_notify_coin2;
        if (textboxNotifyCoin2_1 != null)
          textboxNotifyCoin2_1.MouseHover -= eventHandler;
        this._textbox_notify_coin2 = value;
        TextBox textboxNotifyCoin2_2 = this._textbox_notify_coin2;
        if (textboxNotifyCoin2_2 == null)
          return;
        textboxNotifyCoin2_2.MouseHover += eventHandler;
      }
    }

    private virtual TextBox textbox_notify_coin3
    {
      get
      {
        return this._textbox_notify_coin3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.textbox_coins_Click);
        TextBox textboxNotifyCoin3_1 = this._textbox_notify_coin3;
        if (textboxNotifyCoin3_1 != null)
          textboxNotifyCoin3_1.MouseHover -= eventHandler;
        this._textbox_notify_coin3 = value;
        TextBox textboxNotifyCoin3_2 = this._textbox_notify_coin3;
        if (textboxNotifyCoin3_2 == null)
          return;
        textboxNotifyCoin3_2.MouseHover += eventHandler;
      }
    }

    private virtual CheckBox toggle_taskmanager { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual Button button_restart
    {
      get
      {
        return this._button_restart;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.button_restart_Click);
        Button buttonRestart1 = this._button_restart;
        if (buttonRestart1 != null)
          buttonRestart1.Click -= eventHandler;
        this._button_restart = value;
        Button buttonRestart2 = this._button_restart;
        if (buttonRestart2 == null)
          return;
        buttonRestart2.Click += eventHandler;
      }
    }

    private virtual CheckBox toggle_sound
    {
      get
      {
        return this._toggle_sound;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.toggle_sound_CheckedChanged);
        CheckBox toggleSound1 = this._toggle_sound;
        if (toggleSound1 != null)
          toggleSound1.CheckedChanged -= eventHandler;
        this._toggle_sound = value;
        CheckBox toggleSound2 = this._toggle_sound;
        if (toggleSound2 == null)
          return;
        toggleSound2.CheckedChanged += eventHandler;
      }
    }

    private virtual CheckBox toggle_protect { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual Label label_loginretry { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual TextBox textbox_loginretry
    {
      get
      {
        return this._textbox_loginretry;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.textBox_KeyPress);
        EventHandler eventHandler = new EventHandler(this.textbox_TextChanged);
        TextBox textboxLoginretry1 = this._textbox_loginretry;
        if (textboxLoginretry1 != null)
        {
          textboxLoginretry1.KeyPress -= pressEventHandler;
          textboxLoginretry1.TextChanged -= eventHandler;
        }
        this._textbox_loginretry = value;
        TextBox textboxLoginretry2 = this._textbox_loginretry;
        if (textboxLoginretry2 == null)
          return;
        textboxLoginretry2.KeyPress += pressEventHandler;
        textboxLoginretry2.TextChanged += eventHandler;
      }
    }

    private virtual TextBox textbox_startuplock_title { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual Label label_startuplock { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual TextBox textbox_notification1_length
    {
      get
      {
        return this._textbox_notification1_length;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.textBox_KeyPress);
        EventHandler eventHandler = new EventHandler(this.textbox_notifications_MouseHover);
        TextBox notification1Length1 = this._textbox_notification1_length;
        if (notification1Length1 != null)
        {
          notification1Length1.KeyPress -= pressEventHandler;
          notification1Length1.MouseHover -= eventHandler;
        }
        this._textbox_notification1_length = value;
        TextBox notification1Length2 = this._textbox_notification1_length;
        if (notification1Length2 == null)
          return;
        notification1Length2.KeyPress += pressEventHandler;
        notification1Length2.MouseHover += eventHandler;
      }
    }

    private virtual TextBox textbox_notification2_length
    {
      get
      {
        return this._textbox_notification2_length;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.textBox_KeyPress);
        EventHandler eventHandler = new EventHandler(this.textbox_notifications_MouseHover);
        TextBox notification2Length1 = this._textbox_notification2_length;
        if (notification2Length1 != null)
        {
          notification2Length1.KeyPress -= pressEventHandler;
          notification2Length1.MouseHover -= eventHandler;
        }
        this._textbox_notification2_length = value;
        TextBox notification2Length2 = this._textbox_notification2_length;
        if (notification2Length2 == null)
          return;
        notification2Length2.KeyPress += pressEventHandler;
        notification2Length2.MouseHover += eventHandler;
      }
    }

    private virtual TextBox textbox_startuplock_message { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual TextBox textbox_timesuplock_message { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual TextBox textbox_timesuplock_title { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual Label label_timesuplock { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual ComboBox combobox_coinsound { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual Button button_coinplay
    {
      get
      {
        return this._button_coinplay;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.button_coinplay_Click);
        Button buttonCoinplay1 = this._button_coinplay;
        if (buttonCoinplay1 != null)
          buttonCoinplay1.Click -= eventHandler;
        this._button_coinplay = value;
        Button buttonCoinplay2 = this._button_coinplay;
        if (buttonCoinplay2 == null)
          return;
        buttonCoinplay2.Click += eventHandler;
      }
    }

    private virtual TextBox textbox_newemail
    {
      get
      {
        return this._textbox_newemail;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.textbox_emailChange);
        TextBox textboxNewemail1 = this._textbox_newemail;
        if (textboxNewemail1 != null)
          textboxNewemail1.TextChanged -= eventHandler;
        this._textbox_newemail = value;
        TextBox textboxNewemail2 = this._textbox_newemail;
        if (textboxNewemail2 == null)
          return;
        textboxNewemail2.TextChanged += eventHandler;
      }
    }

    private virtual TextBox textbox_currentemail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual Button button_changeemail
    {
      get
      {
        return this._button_changeemail;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.button_changeemail_Click);
        Button buttonChangeemail1 = this._button_changeemail;
        if (buttonChangeemail1 != null)
          buttonChangeemail1.Click -= eventHandler;
        this._button_changeemail = value;
        Button buttonChangeemail2 = this._button_changeemail;
        if (buttonChangeemail2 == null)
          return;
        buttonChangeemail2.Click += eventHandler;
      }
    }

    private virtual ComboBox combobox_timesound { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual Button button_timeplay
    {
      get
      {
        return this._button_timeplay;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.button_timeplay_Click);
        Button buttonTimeplay1 = this._button_timeplay;
        if (buttonTimeplay1 != null)
          buttonTimeplay1.Click -= eventHandler;
        this._button_timeplay = value;
        Button buttonTimeplay2 = this._button_timeplay;
        if (buttonTimeplay2 == null)
          return;
        buttonTimeplay2.Click += eventHandler;
      }
    }

    private virtual Label label_timesound { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual Label label_coinsound { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual CheckBox toggle_devicedisconnect { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual GroupBox groupbox_notify { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual CheckBox toggle_savedata
    {
      get
      {
        return this._toggle_savedata;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.toggle_savedata_CheckedChanged);
        CheckBox toggleSavedata1 = this._toggle_savedata;
        if (toggleSavedata1 != null)
          toggleSavedata1.CheckedChanged -= eventHandler;
        this._toggle_savedata = value;
        CheckBox toggleSavedata2 = this._toggle_savedata;
        if (toggleSavedata2 == null)
          return;
        toggleSavedata2.CheckedChanged += eventHandler;
      }
    }

    private virtual Button button_browse
    {
      get
      {
        return this._button_browse;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.button_browse_Click);
        Button buttonBrowse1 = this._button_browse;
        if (buttonBrowse1 != null)
          buttonBrowse1.Click -= eventHandler;
        this._button_browse = value;
        Button buttonBrowse2 = this._button_browse;
        if (buttonBrowse2 == null)
          return;
        buttonBrowse2.Click += eventHandler;
      }
    }

    private virtual TextBox textbox_datafolder { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual Label label_beepcoindrop { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual CheckBox toggle_beephardware
    {
      get
      {
        return this._toggle_beephardware;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.toggle_beephardware_CheckedChanged);
        CheckBox toggleBeephardware1 = this._toggle_beephardware;
        if (toggleBeephardware1 != null)
          toggleBeephardware1.CheckedChanged -= eventHandler;
        this._toggle_beephardware = value;
        CheckBox toggleBeephardware2 = this._toggle_beephardware;
        if (toggleBeephardware2 == null)
          return;
        toggleBeephardware2.CheckedChanged += eventHandler;
      }
    }

    private virtual TextBox textbox_beepcoinfreq
    {
      get
      {
        return this._textbox_beepcoinfreq;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.textBox_KeyPress);
        EventHandler eventHandler = new EventHandler(this.textbox_beep_MouseHover);
        TextBox textboxBeepcoinfreq1 = this._textbox_beepcoinfreq;
        if (textboxBeepcoinfreq1 != null)
        {
          textboxBeepcoinfreq1.KeyPress -= pressEventHandler;
          textboxBeepcoinfreq1.MouseHover -= eventHandler;
        }
        this._textbox_beepcoinfreq = value;
        TextBox textboxBeepcoinfreq2 = this._textbox_beepcoinfreq;
        if (textboxBeepcoinfreq2 == null)
          return;
        textboxBeepcoinfreq2.KeyPress += pressEventHandler;
        textboxBeepcoinfreq2.MouseHover += eventHandler;
      }
    }

    private virtual TextBox textbox_beepcoindur
    {
      get
      {
        return this._textbox_beepcoindur;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.textBox_KeyPress);
        EventHandler eventHandler = new EventHandler(this.textbox_beep_MouseHover);
        TextBox textboxBeepcoindur1 = this._textbox_beepcoindur;
        if (textboxBeepcoindur1 != null)
        {
          textboxBeepcoindur1.KeyPress -= pressEventHandler;
          textboxBeepcoindur1.MouseHover -= eventHandler;
        }
        this._textbox_beepcoindur = value;
        TextBox textboxBeepcoindur2 = this._textbox_beepcoindur;
        if (textboxBeepcoindur2 == null)
          return;
        textboxBeepcoindur2.KeyPress += pressEventHandler;
        textboxBeepcoindur2.MouseHover += eventHandler;
      }
    }

    private virtual TextBox textbox_beeptime
    {
      get
      {
        return this._textbox_beeptime;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.textBox_KeyPress);
        EventHandler eventHandler = new EventHandler(this.textbox_beep_MouseHover);
        TextBox textboxBeeptime1 = this._textbox_beeptime;
        if (textboxBeeptime1 != null)
        {
          textboxBeeptime1.KeyPress -= pressEventHandler;
          textboxBeeptime1.MouseHover -= eventHandler;
        }
        this._textbox_beeptime = value;
        TextBox textboxBeeptime2 = this._textbox_beeptime;
        if (textboxBeeptime2 == null)
          return;
        textboxBeeptime2.KeyPress += pressEventHandler;
        textboxBeeptime2.MouseHover += eventHandler;
      }
    }

    private virtual Label label_beeptime { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual TextBox textbox_beeptimedur
    {
      get
      {
        return this._textbox_beeptimedur;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.textBox_KeyPress);
        EventHandler eventHandler = new EventHandler(this.textbox_beep_MouseHover);
        TextBox textboxBeeptimedur1 = this._textbox_beeptimedur;
        if (textboxBeeptimedur1 != null)
        {
          textboxBeeptimedur1.KeyPress -= pressEventHandler;
          textboxBeeptimedur1.MouseHover -= eventHandler;
        }
        this._textbox_beeptimedur = value;
        TextBox textboxBeeptimedur2 = this._textbox_beeptimedur;
        if (textboxBeeptimedur2 == null)
          return;
        textboxBeeptimedur2.KeyPress += pressEventHandler;
        textboxBeeptimedur2.MouseHover += eventHandler;
      }
    }

    private virtual TextBox textbox_beeptimerep
    {
      get
      {
        return this._textbox_beeptimerep;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.textBox_KeyPress);
        EventHandler eventHandler = new EventHandler(this.textbox_beep_MouseHover);
        TextBox textboxBeeptimerep1 = this._textbox_beeptimerep;
        if (textboxBeeptimerep1 != null)
        {
          textboxBeeptimerep1.KeyPress -= pressEventHandler;
          textboxBeeptimerep1.MouseHover -= eventHandler;
        }
        this._textbox_beeptimerep = value;
        TextBox textboxBeeptimerep2 = this._textbox_beeptimerep;
        if (textboxBeeptimerep2 == null)
          return;
        textboxBeeptimerep2.KeyPress += pressEventHandler;
        textboxBeeptimerep2.MouseHover += eventHandler;
      }
    }

    private virtual TextBox textbox_beeptimefreq
    {
      get
      {
        return this._textbox_beeptimefreq;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.textBox_KeyPress);
        EventHandler eventHandler = new EventHandler(this.textbox_beep_MouseHover);
        TextBox textboxBeeptimefreq1 = this._textbox_beeptimefreq;
        if (textboxBeeptimefreq1 != null)
        {
          textboxBeeptimefreq1.KeyPress -= pressEventHandler;
          textboxBeeptimefreq1.MouseHover -= eventHandler;
        }
        this._textbox_beeptimefreq = value;
        TextBox textboxBeeptimefreq2 = this._textbox_beeptimefreq;
        if (textboxBeeptimefreq2 == null)
          return;
        textboxBeeptimefreq2.KeyPress += pressEventHandler;
        textboxBeeptimefreq2.MouseHover += eventHandler;
      }
    }

    private virtual TextBox textbox_beeplockdur
    {
      get
      {
        return this._textbox_beeplockdur;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.textBox_KeyPress);
        EventHandler eventHandler = new EventHandler(this.textbox_beep_MouseHover);
        TextBox textboxBeeplockdur1 = this._textbox_beeplockdur;
        if (textboxBeeplockdur1 != null)
        {
          textboxBeeplockdur1.KeyPress -= pressEventHandler;
          textboxBeeplockdur1.MouseHover -= eventHandler;
        }
        this._textbox_beeplockdur = value;
        TextBox textboxBeeplockdur2 = this._textbox_beeplockdur;
        if (textboxBeeplockdur2 == null)
          return;
        textboxBeeplockdur2.KeyPress += pressEventHandler;
        textboxBeeplockdur2.MouseHover += eventHandler;
      }
    }

    private virtual TextBox textbox_beeplockrep
    {
      get
      {
        return this._textbox_beeplockrep;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.textBox_KeyPress);
        EventHandler eventHandler = new EventHandler(this.textbox_beep_MouseHover);
        TextBox textboxBeeplockrep1 = this._textbox_beeplockrep;
        if (textboxBeeplockrep1 != null)
        {
          textboxBeeplockrep1.KeyPress -= pressEventHandler;
          textboxBeeplockrep1.MouseHover -= eventHandler;
        }
        this._textbox_beeplockrep = value;
        TextBox textboxBeeplockrep2 = this._textbox_beeplockrep;
        if (textboxBeeplockrep2 == null)
          return;
        textboxBeeplockrep2.KeyPress += pressEventHandler;
        textboxBeeplockrep2.MouseHover += eventHandler;
      }
    }

    private virtual TextBox textbox_beeplockfreq
    {
      get
      {
        return this._textbox_beeplockfreq;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.textBox_KeyPress);
        EventHandler eventHandler = new EventHandler(this.textbox_beep_MouseHover);
        TextBox textboxBeeplockfreq1 = this._textbox_beeplockfreq;
        if (textboxBeeplockfreq1 != null)
        {
          textboxBeeplockfreq1.KeyPress -= pressEventHandler;
          textboxBeeplockfreq1.MouseHover -= eventHandler;
        }
        this._textbox_beeplockfreq = value;
        TextBox textboxBeeplockfreq2 = this._textbox_beeplockfreq;
        if (textboxBeeplockfreq2 == null)
          return;
        textboxBeeplockfreq2.KeyPress += pressEventHandler;
        textboxBeeplockfreq2.MouseHover += eventHandler;
      }
    }

    private virtual Label label_beeplock { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual TextBox textbox_beepshutdur
    {
      get
      {
        return this._textbox_beepshutdur;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.textBox_KeyPress);
        EventHandler eventHandler = new EventHandler(this.textbox_beep_MouseHover);
        TextBox textboxBeepshutdur1 = this._textbox_beepshutdur;
        if (textboxBeepshutdur1 != null)
        {
          textboxBeepshutdur1.KeyPress -= pressEventHandler;
          textboxBeepshutdur1.MouseHover -= eventHandler;
        }
        this._textbox_beepshutdur = value;
        TextBox textboxBeepshutdur2 = this._textbox_beepshutdur;
        if (textboxBeepshutdur2 == null)
          return;
        textboxBeepshutdur2.KeyPress += pressEventHandler;
        textboxBeepshutdur2.MouseHover += eventHandler;
      }
    }

    private virtual TextBox textbox_beepshutfreq
    {
      get
      {
        return this._textbox_beepshutfreq;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.textBox_KeyPress);
        EventHandler eventHandler = new EventHandler(this.textbox_beep_MouseHover);
        TextBox textboxBeepshutfreq1 = this._textbox_beepshutfreq;
        if (textboxBeepshutfreq1 != null)
        {
          textboxBeepshutfreq1.KeyPress -= pressEventHandler;
          textboxBeepshutfreq1.MouseHover -= eventHandler;
        }
        this._textbox_beepshutfreq = value;
        TextBox textboxBeepshutfreq2 = this._textbox_beepshutfreq;
        if (textboxBeepshutfreq2 == null)
          return;
        textboxBeepshutfreq2.KeyPress += pressEventHandler;
        textboxBeepshutfreq2.MouseHover += eventHandler;
      }
    }

    private virtual Label label_beepshut { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual CheckBox toggle_beepshutdown
    {
      get
      {
        return this._toggle_beepshutdown;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.toggle_beepshutdown_CheckedChanged);
        CheckBox toggleBeepshutdown1 = this._toggle_beepshutdown;
        if (toggleBeepshutdown1 != null)
          toggleBeepshutdown1.CheckedChanged -= eventHandler;
        this._toggle_beepshutdown = value;
        CheckBox toggleBeepshutdown2 = this._toggle_beepshutdown;
        if (toggleBeepshutdown2 == null)
          return;
        toggleBeepshutdown2.CheckedChanged += eventHandler;
      }
    }

    private virtual Button button_playbeepshut
    {
      get
      {
        return this._button_playbeepshut;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.button_playbeepshut_Click);
        Button buttonPlaybeepshut1 = this._button_playbeepshut;
        if (buttonPlaybeepshut1 != null)
          buttonPlaybeepshut1.Click -= eventHandler;
        this._button_playbeepshut = value;
        Button buttonPlaybeepshut2 = this._button_playbeepshut;
        if (buttonPlaybeepshut2 == null)
          return;
        buttonPlaybeepshut2.Click += eventHandler;
      }
    }

    private virtual Button button_playbeeplock
    {
      get
      {
        return this._button_playbeeplock;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.button_playbeeplock_Click);
        Button buttonPlaybeeplock1 = this._button_playbeeplock;
        if (buttonPlaybeeplock1 != null)
          buttonPlaybeeplock1.Click -= eventHandler;
        this._button_playbeeplock = value;
        Button buttonPlaybeeplock2 = this._button_playbeeplock;
        if (buttonPlaybeeplock2 == null)
          return;
        buttonPlaybeeplock2.Click += eventHandler;
      }
    }

    private virtual Button button_playbeeptime
    {
      get
      {
        return this._button_playbeeptime;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.button_playbeeptime_Click);
        Button buttonPlaybeeptime1 = this._button_playbeeptime;
        if (buttonPlaybeeptime1 != null)
          buttonPlaybeeptime1.Click -= eventHandler;
        this._button_playbeeptime = value;
        Button buttonPlaybeeptime2 = this._button_playbeeptime;
        if (buttonPlaybeeptime2 == null)
          return;
        buttonPlaybeeptime2.Click += eventHandler;
      }
    }

    private virtual Button button_playbeepcoin
    {
      get
      {
        return this._button_playbeepcoin;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.button_playbeepcoin_Click);
        Button buttonPlaybeepcoin1 = this._button_playbeepcoin;
        if (buttonPlaybeepcoin1 != null)
          buttonPlaybeepcoin1.Click -= eventHandler;
        this._button_playbeepcoin = value;
        Button buttonPlaybeepcoin2 = this._button_playbeepcoin;
        if (buttonPlaybeepcoin2 == null)
          return;
        buttonPlaybeepcoin2.Click += eventHandler;
      }
    }

    internal virtual TabControl tabcontrol_settings { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TabPage tabpage_coins { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TabPage tabpage_apps { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TabPage tabpage_notify { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TabPage tabpage_device { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TabPage tabpage_passemail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual GroupBox groupbox_device { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TabPage tabpage_advance { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button button_browsebgimage
    {
      get
      {
        return this._button_browsebgimage;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.button_browsebgimage_Click);
        Button buttonBrowsebgimage1 = this._button_browsebgimage;
        if (buttonBrowsebgimage1 != null)
          buttonBrowsebgimage1.Click -= eventHandler;
        this._button_browsebgimage = value;
        Button buttonBrowsebgimage2 = this._button_browsebgimage;
        if (buttonBrowsebgimage2 == null)
          return;
        buttonBrowsebgimage2.Click += eventHandler;
      }
    }

    internal virtual Label label_bg { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox textbox_bgimagelocation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox checkbox_customizelock
    {
      get
      {
        return this._checkbox_customizelock;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.checkbox_customizelock_CheckedChanged);
        CheckBox checkboxCustomizelock1 = this._checkbox_customizelock;
        if (checkboxCustomizelock1 != null)
          checkboxCustomizelock1.CheckedChanged -= eventHandler;
        this._checkbox_customizelock = value;
        CheckBox checkboxCustomizelock2 = this._checkbox_customizelock;
        if (checkboxCustomizelock2 == null)
          return;
        checkboxCustomizelock2.CheckedChanged += eventHandler;
      }
    }

    internal virtual ComboBox combobox_bgimagelayout { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label label_bgimagelayout { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label label_lockwindowpos { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox combobox_lockwindowpos { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolTip tooltip_settings { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label label_lockwindowtrans { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox combobox_lockwindowtrans
    {
      get
      {
        return this._combobox_lockwindowtrans;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.combobox_lockwindowtrans_SelectedIndexChanged);
        ComboBox comboboxLockwindowtrans1 = this._combobox_lockwindowtrans;
        if (comboboxLockwindowtrans1 != null)
          comboboxLockwindowtrans1.SelectedIndexChanged -= eventHandler;
        this._combobox_lockwindowtrans = value;
        ComboBox comboboxLockwindowtrans2 = this._combobox_lockwindowtrans;
        if (comboboxLockwindowtrans2 == null)
          return;
        comboboxLockwindowtrans2.SelectedIndexChanged += eventHandler;
      }
    }

    private virtual TextBox textbox_userlogoutmsg { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual TextBox textbox_userlogouttitle { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox combobox_colorstartup { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox combobox_colortimesup { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox combobox_coloruserlogout { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label label_startupinitializecolor { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox combobox_startupinitializecolor { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox combobox_deviceproblemcolor { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label label_deviceproblemcolor { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox combobox_lockwindowbgcolor { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label label_lockwindowbgcolor { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox combobox_shutdowntime { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label label_shutdowntime { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox checkbox_advance
    {
      get
      {
        return this._checkbox_advance;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.checkbox_advance_CheckedChanged);
        CheckBox checkboxAdvance1 = this._checkbox_advance;
        if (checkboxAdvance1 != null)
          checkboxAdvance1.CheckedChanged -= eventHandler;
        this._checkbox_advance = value;
        CheckBox checkboxAdvance2 = this._checkbox_advance;
        if (checkboxAdvance2 == null)
          return;
        checkboxAdvance2.CheckedChanged += eventHandler;
      }
    }

    internal virtual TextBox textbox_waitforprocmon
    {
      get
      {
        return this._textbox_waitforprocmon;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.textBox_KeyPress);
        TextBox textboxWaitforprocmon1 = this._textbox_waitforprocmon;
        if (textboxWaitforprocmon1 != null)
          textboxWaitforprocmon1.KeyPress -= pressEventHandler;
        this._textbox_waitforprocmon = value;
        TextBox textboxWaitforprocmon2 = this._textbox_waitforprocmon;
        if (textboxWaitforprocmon2 == null)
          return;
        textboxWaitforprocmon2.KeyPress += pressEventHandler;
      }
    }

    internal virtual Label label_waitforprocmon { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual CheckBox toggle_5secvoice { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual BackgroundWorker Worker
    {
      get
      {
        return this._Worker;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.Worker_DoWork);
        RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.Worker_RunWorkerCompleted);
        BackgroundWorker worker1 = this._Worker;
        if (worker1 != null)
        {
          worker1.DoWork -= workEventHandler;
          worker1.RunWorkerCompleted -= completedEventHandler;
        }
        this._Worker = value;
        BackgroundWorker worker2 = this._Worker;
        if (worker2 == null)
          return;
        worker2.DoWork += workEventHandler;
        worker2.RunWorkerCompleted += completedEventHandler;
      }
    }

    private void FormPreventToMoveWithKeyboard(object sender, EventArgs e)
    {
      if (this.WindowState != FormWindowState.Maximized)
        return;
      this.WindowState = FormWindowState.Normal;
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      if (e.CloseReason == CloseReason.UserClosing)
      {
        if (this.working)
          e.Cancel = true;
        else
          this.ExitSettings();
      }
      else
        this.ExitSettings();
      base.OnFormClosing(e);
    }

    private void ExitSettings()
    {
      if (_Module.exitapp)
        return;
      _Module.CoinappNotifyIcon.Visible = true;
      if (!_Module.Desktop.IsAdmin)
      {
        if (_Module.DeviceIsError || !_Module.MainSerialPort.IsOpen)
        {
          _Module.MyID = "";
          _Module.LockWatcher.Start();
          _Module.Desktop.Lock((IWin32Window) MyProject.Forms.Form_lock);
        }
        else
        {
          MyProject.Forms.Form_timer.Show();
          _Module.FormTimerIsHidden = false;
          _Module.CoinappVisibleToolStrip.Text = "Hide";
          if (_Module.MainSerialPort.IsOpen)
            _Module.MainSerialPort.Write("ADMIN=0");
        }
      }
      else if (!_Module.MainSerialPort.IsOpen)
      {
        _Module.MyID = "";
        _Module.CoinappNotifyIcon.Icon = _Module.Image.admin_red();
        _Module.CoinappNotifyIcon.BalloonTipText = "Disconnected";
        _Module.CoinappNotifyIcon.ShowBalloonTip(1);
      }
    }

    private void Worker_DoWork(object sender, DoWorkEventArgs e)
    {
      if (Operators.ConditionalCompareObjectEqual(e.Argument, (object) "load", false))
      {
        try
        {
          this.result = _Module.Device.Name();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Exception exception = ex;
          int num;
          this.Invoke((Delegate) (() => num = (int) Interaction.MsgBox((object) exception.Message, MsgBoxStyle.Critical, (object) null)));
          ProjectData.ClearProjectError();
        }
        e.Result = (object) "loaded";
      }
      else if (Operators.ConditionalCompareObjectEqual(e.Argument, (object) "connect", false))
      {
        this.working = true;
        try
        {
          this.port = _Module.Device.Port();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Exception exception = ex;
          int num;
          this.Invoke((Delegate) (() => num = (int) Interaction.MsgBox((object) exception.Message, MsgBoxStyle.Critical, (object) null)));
          ProjectData.ClearProjectError();
        }
        try
        {
          _Module.MainSerialPort.BaudRate = _Module.Config.BaudRate();
          _Module.MainSerialPort.PortName = this.port;
          _Module.MainSerialPort.DtrEnable = true;
          _Module.MainSerialPort.Open();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Exception exception = ex;
          _Module.DeviceIsError = true;
          int num;
          this.Invoke((Delegate) (() => num = (int) MessageBox.Show(exception.Message, "Can't connect", MessageBoxButtons.OK, MessageBoxIcon.Hand)));
          ProjectData.ClearProjectError();
        }
        if (_Module.MainSerialPort.IsOpen)
        {
          Thread.Sleep(3000);
          _Module.MainSerialPort.Write("REQDEVID;");
          Thread.Sleep(_Module.senderIDInterval);
          _Module.Initialized = true;
        }
        e.Result = (object) "connected";
      }
      else
      {
        if (!Operators.ConditionalCompareObjectEqual(e.Argument, (object) "savesettings", false))
          return;
        if (_Module.MainSerialPort.IsOpen)
        {
          try
          {
            _Module.MainSerialPort.Write("DISC;");
            _Module.MainSerialPort.Close();
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            int num = (int) MessageBox.Show("Can't disconect to device. Please try again", "Saving settings error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            this.button_savesettings.Text = "Save settings";
            this.button_savesettings.Enabled = true;
            this.working = false;
            ProjectData.ClearProjectError();
            return;
          }
        }
        try
        {
          _Module.Config.SetCoin1(this.textbox_coin1.Text, this.textbox_coin1_pulse.Text);
          _Module.Config.SetNotifyCoin1(this.textbox_notify_coin1.Text);
          if (this.combobox_cointype.SelectedIndex == 1)
          {
            _Module.Config.SetCoinAcceptor("MULTI");
            _Module.Config.SetCoin2(this.textbox_coin2.Text, this.textbox_coin2_pulse.Text);
            _Module.Config.SetNotifyCoin2(this.textbox_notify_coin2.Text);
            _Module.Config.SetCoin3(this.textbox_coin3.Text, this.textbox_coin3_pulse.Text);
            _Module.Config.SetNotifyCoin3(this.textbox_notify_coin3.Text);
          }
          else if (this.combobox_cointype.SelectedIndex == 2)
          {
            _Module.Config.SetCoinAcceptor("DUAL");
            _Module.Config.SetCoin2(this.textbox_coin2.Text, this.textbox_coin2_pulse.Text);
            _Module.Config.SetNotifyCoin2(this.textbox_notify_coin2.Text);
            _Module.Config.SetCoin3("0", "0");
            _Module.Config.SetNotifyCoin3("");
          }
          else
          {
            _Module.Config.SetCoinAcceptor("SINGLE");
            _Module.Config.SetCoin2("0", "0");
            _Module.Config.SetNotifyCoin2("");
            _Module.Config.SetCoin3("0", "0");
            _Module.Config.SetNotifyCoin3("");
          }
          _Module.Config.SetTimeToShut(this.textbox_turnoff.Text);
          _Module.Config.SetLoginRetry(this.textbox_loginretry.Text);
          if (this.keycode == 0)
            this.keycode = this.previousKeycode;
          _Module.Config.SetKeycode(this.keycode);
          if (this.toggle_startup.Checked)
          {
            if (!_Module.Config.CheckStartupRegistry())
              _Module.Config.SetStartupRegValue();
            else if (!_Module.Config.CheckStartupValue())
              _Module.Config.SetStartupRegValue();
            _Module.Config.SetAtStartup(true);
          }
          else
          {
            if (_Module.Config.CheckStartupRegistry())
              _Module.Config.DelStartupRegValue();
            _Module.Config.SetAtStartup(false);
          }
          if (this.toggle_taskmanager.Checked)
          {
            if (!_Module.Config.CheckTaskmgrRegValue())
              _Module.Config.SetTaskmgrRegValue();
            _Module.Config.SetTaskmgr(true);
          }
          else
          {
            if (_Module.Config.CheckTaskmgrRegValue())
              _Module.Config.DelTaskmgrRegValue();
            _Module.Config.SetTaskmgr(false);
          }
          if (this.toggle_sound.Checked)
          {
            _Module.Config.SetPlaySound(true);
            if (this.toggle_5secvoice.Checked)
              _Module.Config.SetPlay5SecVoice(true);
            else
              _Module.Config.SetPlay5SecVoice(false);
            _Module.Config.SetCoinSound(this.combobox_coinsound.SelectedIndex);
            _Module.Config.SetTimeSound(this.combobox_timesound.SelectedIndex);
          }
          else
          {
            _Module.Config.SetPlaySound(false);
            _Module.Config.SetPlay5SecVoice(false);
            _Module.Config.SetCoinSound(-1);
            _Module.Config.SetTimeSound(-1);
          }
          if (this.toggle_protect.Checked)
            _Module.Config.SetProtect(true);
          else
            _Module.Config.SetProtect(false);
          if (this.toggle_devicedisconnect.Checked)
            _Module.Config.SetDisconnectLock(true);
          else
            _Module.Config.SetDisconnectLock(false);
          if (this.toggle_savedata.Checked)
          {
            if (Operators.CompareString(this.textbox_datafolder.Text, "", false) == 0)
            {
              _Module.Config.SetSaveData(false);
              _Module.Config.WriteFile(_Module._MD5.GetMd5Hash("datafolder"), _Module._MD5.Encrypt("", "datafolder"));
            }
            else
            {
              _Module.Config.SetSaveData(true);
              _Module.Config.WriteFile(_Module._MD5.GetMd5Hash("datafolder"), _Module._MD5.Encrypt(this.textbox_datafolder.Text, "datafolder"));
            }
          }
          else
          {
            _Module.Config.SetSaveData(false);
            _Module.Config.WriteFile(_Module._MD5.GetMd5Hash("datafolder"), _Module._MD5.Encrypt("", "datafolder"));
          }
          if (this.toggle_beephardware.Checked)
          {
            _Module.Config.SetBeep(true);
            _Module.Config.SetBeepCoin(this.textbox_beepcoinfreq.Text, this.textbox_beepcoindur.Text);
            _Module.Config.SetBeepTime(this.textbox_beeptime.Text, this.textbox_beeptimerep.Text, this.textbox_beeptimefreq.Text, this.textbox_beeptimedur.Text);
            _Module.Config.SetBeepLock(this.textbox_beeplockrep.Text, this.textbox_beeplockfreq.Text, this.textbox_beeplockdur.Text);
            if (this.toggle_beepshutdown.Checked)
              _Module.Config.SetBeepShut(true, this.textbox_beepshutfreq.Text, this.textbox_beepshutdur.Text);
            else
              _Module.Config.SetBeepShut(false, "2150", "300");
          }
          else
          {
            _Module.Config.SetBeep(false);
            _Module.Config.SetBeepShut(false, "2150", "300");
          }
          if (this.checkbox_customizelock.Checked)
          {
            _Module.Config.SetCustomizeLock(true);
            _Module.Config.SetBGImage(this.textbox_bgimagelocation.Text, Conversions.ToString(this.combobox_bgimagelayout.SelectedIndex));
            _Module.Config.SetBGImage(this.textbox_bgimagelocation.Text, Conversions.ToString(this.combobox_bgimagelayout.SelectedIndex));
            if (this.combobox_lockwindowtrans.SelectedIndex == 0)
              _Module.Config.SetWindowControl(Conversions.ToString(this.combobox_lockwindowpos.SelectedIndex), true, "-1");
            else
              _Module.Config.SetWindowControl(Conversions.ToString(this.combobox_lockwindowpos.SelectedIndex), false, Conversions.ToString(this.combobox_lockwindowbgcolor.SelectedIndex));
            _Module.Config.SetInitializeColor(Conversions.ToString(this.combobox_startupinitializecolor.SelectedIndex));
            _Module.Config.SetDeviceProblemColor(Conversions.ToString(this.combobox_deviceproblemcolor.SelectedIndex));
            _Module.Config.SetShutdownTimeColor(Conversions.ToString(this.combobox_shutdowntime.SelectedIndex));
          }
          else
            _Module.Config.SetCustomizeLock(false);
          if (this.checkbox_advance.Checked)
          {
            _Module.Config.SetAdvanceCustomization(true);
            if (Conversions.ToInteger(this.textbox_waitforprocmon.Text) < 1000)
              _Module.Config.SetWaitForProcmon("1000");
            else
              _Module.Config.SetWaitForProcmon(this.textbox_waitforprocmon.Text);
          }
          else
            _Module.Config.SetAdvanceCustomization(false);
          _Module.Config.SetNotification1(this.textbox_notification1_seconds.Text, this.textbox_notification1_length.Text, this.textbox_notification1_messages.Text);
          _Module.Config.SetNotification2(this.textbox_notification2_seconds.Text, this.textbox_notification2_length.Text, this.textbox_notification2_messages.Text);
          _Module.Config.SetStartupLock(this.textbox_startuplock_title.Text, this.textbox_startuplock_message.Text, Conversions.ToString(this.combobox_colorstartup.SelectedIndex));
          _Module.Config.SetTimesupLock(this.textbox_timesuplock_title.Text, this.textbox_timesuplock_message.Text, Conversions.ToString(this.combobox_colortimesup.SelectedIndex));
          _Module.Config.SetUserLogout(this.textbox_userlogouttitle.Text, this.textbox_userlogoutmsg.Text, Conversions.ToString(this.combobox_coloruserlogout.SelectedIndex));
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Exception exception = ex;
          int num;
          this.Invoke((Delegate) (() => num = (int) MessageBox.Show(exception.Message, "Saving settings error", MessageBoxButtons.OK, MessageBoxIcon.Hand)));
          this.button_savesettings.Text = "Save settings";
          this.button_savesettings.Enabled = true;
          this.working = false;
          ProjectData.ClearProjectError();
          return;
        }
        e.Result = (object) "settingssaved";
      }
    }

    private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      if (this.InvokeRequired)
      {
        this.Invoke((Delegate) new Form_settings.Worker_RunWorkerCompleted_Delegate(this.Worker_RunWorkerCompleted), sender, (object) e);
      }
      else
      {
        if (Operators.ConditionalCompareObjectEqual(e.Result, (object) "loaded", false))
        {
          if ((uint) Operators.CompareString(this.result, "", false) > 0U)
          {
            this.combobox_device.Items.Add((object) this.result);
            this.combobox_device.SelectedIndex = 0;
            if (_Module.MainSerialPort.IsOpen && !_Module.DeviceIsError)
            {
              this.button_device.Text = "Connected";
              this.button_device.BackColor = Color.MediumSeaGreen;
              this.combobox_device.Enabled = false;
              this.button_close.Enabled = false;
              this.button_restart.Enabled = false;
              this.button_deviceinfo.Enabled = true;
              _Module.MainSerialPort.Write("ADMIN=1");
              if (_Module.Conf.Beep)
              {
                this.toggle_beephardware.Checked = true;
                this.ToggleBeepHardware(true);
                if (_Module.Conf.BeepShut)
                {
                  this.toggle_beepshutdown.Checked = true;
                  this.ToggleBeepShutdown(true);
                }
              }
              else
              {
                this.toggle_beephardware.Checked = false;
                this.toggle_beepshutdown.Checked = false;
                this.ToggleBeepHardware(false);
                this.ToggleBeepShutdown(false);
              }
            }
            else
            {
              _Module.MyID = "";
              this.button_device.Text = "Disconnected";
              this.button_device.BackColor = Color.Brown;
              this.button_device.FlatAppearance.MouseOverBackColor = Color.Maroon;
              this.button_restart.Enabled = true;
              this.button_close.Enabled = true;
              this.toggle_beephardware.Enabled = false;
              this.toggle_beephardware.Checked = false;
              this.toggle_beepshutdown.Checked = false;
              this.ToggleBeepHardware(false);
              this.toggle_beepshutdown.Checked = false;
              this.ToggleBeepShutdown(false);
            }
          }
          else
          {
            _Module.MyID = "";
            this.combobox_device.Items.Add((object) "--No device connected--");
            this.combobox_device.SelectedIndex = 0;
            this.combobox_device.Enabled = false;
            this.button_device.Text = "E r r o r";
            this.button_device.Enabled = false;
            this.button_device.BackColor = Color.Gray;
            this.button_device.ForeColor = Color.White;
            this.button_restart.Enabled = true;
            this.button_close.Enabled = true;
            this.button_savesettings.Enabled = true;
            this.toggle_beephardware.Enabled = false;
            this.toggle_beephardware.Checked = false;
            this.toggle_beepshutdown.Checked = false;
            this.ToggleBeepHardware(false);
            this.toggle_beepshutdown.Checked = false;
            this.ToggleBeepShutdown(false);
            this.working = false;
            return;
          }
        }
        else if (Operators.ConditionalCompareObjectEqual(e.Result, (object) "connected", false))
        {
          if (_Module.MainSerialPort.IsOpen)
          {
            if (_Module.DeviceIsReady)
            {
              _Module.MainSerialPort.Write("ADMIN=1");
              _Module.Config.SetPortName(this.port);
              _Module.DeviceIsError = false;
              _Module.DeviceConnectionWatcher.Start();
              this.combobox_device.Enabled = false;
              this.button_close.Enabled = false;
              this.button_restart.Enabled = false;
              this.button_device.Text = "Connected";
              this.button_deviceinfo.Enabled = true;
              this.button_device.BackColor = Color.MediumSeaGreen;
              this.button_device.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
              _Module.Desktop.IsAdmin = true;
              _Module.CoinappNotifyIcon.Icon = _Module.Image.admin();
              this.toggle_beephardware.Enabled = true;
              if (_Module.Conf.Beep)
              {
                this.toggle_beephardware.Checked = true;
                this.ToggleBeepHardware(true);
                if (_Module.Conf.BeepShut)
                {
                  this.toggle_beepshutdown.Checked = true;
                  this.ToggleBeepShutdown(true);
                }
              }
              else
              {
                this.toggle_beephardware.Checked = false;
                this.toggle_beepshutdown.Checked = false;
                this.ToggleBeepHardware(false);
                this.ToggleBeepShutdown(false);
              }
              int num = (int) MessageBox.Show("Connected to the device successfuly!", "Connected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
              try
              {
                _Module.MainSerialPort.Close();
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                int num = (int) MessageBox.Show(ex.Message, "Can't close connection", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ProjectData.ClearProjectError();
              }
              this.button_restart.Enabled = true;
              this.button_close.Enabled = true;
              this.button_device.Text = "Disconnected";
              this.combobox_device.Enabled = true;
              this.toggle_beephardware.Enabled = false;
              this.toggle_beepshutdown.Enabled = false;
              this.toggle_beephardware.Checked = false;
              this.toggle_beepshutdown.Checked = false;
              this.ToggleBeepHardware(false);
              this.ToggleBeepShutdown(false);
              int num1 = (int) MessageBox.Show("Cannot continue. Device is not compatible with this application.", "Device not compatible", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
          }
          else
          {
            this.combobox_device.Enabled = true;
            this.button_device.Text = "Disconnected";
            this.button_restart.Enabled = true;
            this.button_close.Enabled = true;
            this.toggle_beephardware.Enabled = false;
            this.toggle_beepshutdown.Enabled = false;
            this.toggle_beephardware.Checked = false;
            this.toggle_beepshutdown.Checked = false;
            this.ToggleBeepHardware(false);
            this.ToggleBeepShutdown(false);
          }
          this.button_device.Enabled = true;
        }
        else if (Operators.ConditionalCompareObjectEqual(e.Result, (object) "settingssaved", false))
        {
          Form_settings.MyDelegate myDelegate;
          // ISSUE: reference to a compiler-generated field
          if (Form_settings._Closure\u0024__.\u0024I550\u002D0 != null)
          {
            // ISSUE: reference to a compiler-generated field
            myDelegate = Form_settings._Closure\u0024__.\u0024I550\u002D0;
          }
          else
          {
            int num;
            // ISSUE: reference to a compiler-generated field
            Form_settings._Closure\u0024__.\u0024I550\u002D0 = myDelegate = (Form_settings.MyDelegate) (() => num = (int) MessageBox.Show("Saved settings successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Asterisk));
          }
          this.Invoke((Delegate) myDelegate);
          this.working = false;
          this.CloseApp(true);
          return;
        }
        this.Focus();
        this.button_savesettings.Enabled = true;
        this.working = false;
      }
    }

    private void button_savesetting_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Application restart is required to save the settings. Do you want to save the settings and restart the application?", "Saving settings", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
      {
        if (this.combobox_coinsound.SelectedIndex == 0 || this.combobox_timesound.SelectedIndex == 0)
        {
          if (_Module.Config.CoinSoundExists() || _Module.Config.TimeSoundExists())
          {
            if (!this.toggle_protect.Checked)
            {
              if (MessageBox.Show("WARNING! Protect with process is off. Continue saving without protecting the process?", "No Protection", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
              {
                this.working = true;
                this.button_savesettings.Text = "Saving settings...";
                this.button_savesettings.Enabled = false;
                this.Worker = new BackgroundWorker();
                this.Worker.RunWorkerAsync((object) "savesettings");
              }
            }
            else
            {
              this.working = true;
              this.button_savesettings.Text = "Saving settings...";
              this.button_savesettings.Enabled = false;
              this.Worker = new BackgroundWorker();
              this.Worker.RunWorkerAsync((object) "savesettings");
            }
          }
          else
          {
            int num = (int) MessageBox.Show("Sounds file is missing. Cannot save the setting.", "Saving settings error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          }
        }
        else if (!this.toggle_protect.Checked)
        {
          if (MessageBox.Show("WARNING! Protect with process is off. Continue saving without protecting the process?", "No Protection", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
          {
            this.working = true;
            this.button_savesettings.Text = "Saving settings...";
            this.button_savesettings.Enabled = false;
            this.Worker = new BackgroundWorker();
            this.Worker.RunWorkerAsync((object) "savesettings");
          }
        }
        else
        {
          this.working = true;
          this.button_savesettings.Text = "Saving settings...";
          this.button_savesettings.Enabled = false;
          this.Worker = new BackgroundWorker();
          this.Worker.RunWorkerAsync((object) "savesettings");
        }
      }
      this.ActiveControl = (Control) null;
    }

    private void Form_settings_Load(object sender, EventArgs e)
    {
      this.working = true;
      if (_Module.Dialog != null && _Module.Dialog.Visible)
      {
        _Module.Dialog.Dispose();
        _Module.Dialog.Close();
      }
      if (_Module.Notify != null && _Module.Notify.Visible)
        _Module.Notify.Close();
      if (!_Module.Config.Exists())
      {
        _Module.Config.CreateConfigFile();
        int num = (int) Interaction.MsgBox((object) "The configuration file is missing.", MsgBoxStyle.Critical, (object) null);
      }
      if (MyProject.Forms.Form_timer.Visible)
      {
        MyProject.Forms.Form_timer.Hide();
        _Module.FormTimerIsHidden = true;
      }
      _Module.CoinappNotifyIcon.Visible = false;
      this.button_savesettings.Enabled = false;
      this.textbox_coin1.Text = Conversions.ToString(_Module.Conf.Coin1);
      this.textbox_coin1_pulse.Text = Conversions.ToString(_Module.Conf.Pulse1);
      this.textbox_notify_coin1.Text = _Module.Conf.NotifyCoin1;
      if (Operators.CompareString(_Module.Conf.CoinAcceptor, "DUAL", false) == 0)
      {
        this.combobox_cointype.SelectedIndex = 2;
        this.DualCoinAcceptor();
      }
      else if (Operators.CompareString(_Module.Conf.CoinAcceptor, "MULTI", false) == 0)
      {
        this.combobox_cointype.SelectedIndex = 1;
        this.ToggleMulticoin(true);
      }
      else
      {
        this.combobox_cointype.SelectedIndex = 0;
        this.ToggleMulticoin(false);
      }
      this.textbox_turnoff.Text = Conversions.ToString(_Module.Conf.TimeToShut);
      this.previousKeycode = _Module.Conf.MainKeycode;
      this.keycodeString = _Module.Hotkey.GetKeypressed(_Module.Conf.MainKeycode);
      this.textbox_letterkey.Text = this.keycodeString;
      this.textbox_loginretry.Text = Conversions.ToString(_Module.Conf.LoginRetry);
      this.toggle_startup.Checked = _Module.Config.AtStartUp();
      this.toggle_taskmanager.Checked = _Module.Config.Taskmgr();
      if (_Module.Conf.PlaySound)
      {
        this.toggle_sound.Checked = true;
        this.combobox_coinsound.Enabled = true;
        this.combobox_coinsound.SelectedIndex = _Module.Conf.CoinSound;
        this.combobox_timesound.Enabled = true;
        this.combobox_timesound.SelectedIndex = _Module.Conf.TimeSound;
        this.button_coinplay.Enabled = true;
        this.button_timeplay.Enabled = true;
        this.label_coinsound.Enabled = true;
        this.label_timesound.Enabled = true;
        this.toggle_5secvoice.Enabled = true;
        this.toggle_5secvoice.Checked = _Module.Conf.Play5SecVoice;
      }
      else
      {
        this.toggle_sound.Checked = false;
        this.toggle_5secvoice.Enabled = false;
        this.toggle_5secvoice.Checked = false;
        this.combobox_coinsound.Enabled = false;
        this.combobox_timesound.Enabled = false;
        this.button_coinplay.Enabled = false;
        this.button_timeplay.Enabled = false;
        this.label_coinsound.Enabled = false;
        this.label_timesound.Enabled = false;
        this.combobox_coinsound.SelectedIndex = -1;
        this.combobox_timesound.SelectedIndex = -1;
      }
      this.toggle_protect.Checked = _Module.Conf.Protect;
      this.toggle_devicedisconnect.Checked = _Module.Conf.DisconnectLock;
      if (_Module.Conf.SaveData)
      {
        if (_Module.Config.FileExists(_Module._MD5.GetMd5Hash("datafolder")))
        {
          this.toggle_savedata.Checked = true;
          string Left;
          try
          {
            Left = _Module._MD5.Decrypt(_Module.Config.EncryptedReadFile(_Module._MD5.GetMd5Hash("datafolder")), "datafolder");
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            Left = "";
            ProjectData.ClearProjectError();
          }
          if ((uint) Operators.CompareString(Left, "", false) > 0U)
          {
            this.textbox_datafolder.Text = _Module._MD5.Decrypt(_Module.Config.EncryptedReadFile(_Module._MD5.GetMd5Hash("datafolder")), "datafolder");
          }
          else
          {
            this.textbox_datafolder.Text = _Module.Config.defaultDataFolder;
            int num = (int) Interaction.MsgBox((object) "Data folder exists but no saved folder location. Default folder will use. Be sure to save the settings before exit.", MsgBoxStyle.Critical, (object) null);
          }
        }
        else
        {
          this.toggle_savedata.Checked = false;
          this.textbox_datafolder.Text = _Module.Config.defaultDataFolder;
          int num = (int) Interaction.MsgBox((object) "Data folder location not exists. Default folder will use. Be sure to save the settings before exit.", MsgBoxStyle.Critical, (object) null);
        }
      }
      else
      {
        this.toggle_savedata.Checked = false;
        this.textbox_datafolder.Clear();
        this.textbox_datafolder.Enabled = false;
        this.button_browse.Enabled = false;
      }
      this.textbox_notification1_seconds.Text = Conversions.ToString(_Module.Conf.Notify1);
      this.textbox_notification2_seconds.Text = Conversions.ToString(_Module.Conf.Notify2);
      this.textbox_notification1_messages.Text = _Module.Conf.NotifyMessage1;
      this.textbox_notification2_messages.Text = _Module.Conf.NotifyMessage2;
      this.textbox_notification1_length.Text = Conversions.ToString(_Module.Conf.Notify1sec);
      this.textbox_notification2_length.Text = Conversions.ToString(_Module.Conf.Notify2sec);
      this.textbox_startuplock_title.Text = _Module.Conf.StartupTitle;
      this.textbox_startuplock_message.Text = _Module.Conf.StartupMsg;
      this.textbox_timesuplock_title.Text = _Module.Conf.TimesupTitle;
      this.textbox_timesuplock_message.Text = _Module.Conf.TimesupMsg;
      this.textbox_userlogouttitle.Text = _Module.Conf.UserLogoutTitle;
      this.textbox_userlogoutmsg.Text = _Module.Conf.UserLogoutMsg;
      try
      {
        this.combobox_colorstartup.SelectedIndex = Conversions.ToInteger(_Module.Conf.StartupColor);
        this.combobox_colortimesup.SelectedIndex = Conversions.ToInteger(_Module.Conf.TimesupColor);
        this.combobox_coloruserlogout.SelectedIndex = Conversions.ToInteger(_Module.Conf.UserLogoutColor);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) ex.Message, MsgBoxStyle.Critical, (object) null);
        ProjectData.ClearProjectError();
      }
      this.textbox_currentemail.Text = !_Module.Config.FileExists(_Module._MD5.GetMd5Hash("email")) ? "" : _Module._MD5.Decrypt(_Module.Config.EncryptedReadFile(_Module._MD5.GetMd5Hash("email")), "email");
      if (_Module.Conf.CustomizeLock)
      {
        this.checkbox_customizelock.Checked = true;
        this.ToggleGUILock(true);
      }
      else
      {
        this.checkbox_customizelock.Checked = false;
        this.ToggleGUILock(false);
      }
      if (_Module.Conf.AdvanceCustomization)
      {
        this.checkbox_advance.Checked = true;
        this.ToggleAdvanceCustomization(true);
      }
      else
      {
        this.checkbox_advance.Checked = false;
        this.ToggleAdvanceCustomization(false);
      }
      this.Worker = new BackgroundWorker();
      this.Worker.RunWorkerAsync((object) "load");
    }

    private void button_device_Click(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.button_device.Text, "Connect", false) == 0)
      {
        this.button_device.Text = "Connecting...";
        this.button_device.Enabled = false;
        this.combobox_device.Enabled = false;
        this.button_savesettings.Enabled = false;
        this.button_restart.Enabled = false;
        this.button_close.Enabled = false;
        _Module.Desktop.IsAdmin = true;
        this.MakeAdmin();
        this.Worker = new BackgroundWorker();
        this.Worker.RunWorkerAsync((object) "connect");
      }
      else if (Operators.CompareString(this.button_device.Text, "Disconnect", false) == 0)
      {
        if (MessageBox.Show("Disconnect to device. Continue?", "Disconnect", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
        {
          try
          {
            _Module.MainSerialPort.Write("DISC;");
            _Module.MainSerialPort.Close();
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            Exception exception = ex;
            _Module.DeviceIsError = true;
            int num = (int) MessageBox.Show(exception.Message, "Disconnect error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            ProjectData.ClearProjectError();
          }
          if (!_Module.MainSerialPort.IsOpen)
          {
            _Module.MyID = "";
            _Module.DeviceIsReady = false;
            _Module.DeviceIsError = true;
            _Module.DeviceConnectionWatcher.Stop();
            _Module.CoinCredits = 0;
            _Module.CreditsIsCounting = false;
            this.combobox_device.Enabled = true;
            this.button_close.Enabled = true;
            this.button_restart.Enabled = true;
            this.button_device.Text = "Disconnected";
            this.button_deviceinfo.Enabled = false;
            this.button_device.BackColor = Color.Brown;
            this.button_device.FlatAppearance.MouseOverBackColor = Color.Maroon;
            if (_Module.CoinappContextMenuStrip.Items.Contains((ToolStripItem) _Module.CoinappLogoutToolStrip))
              _Module.CoinappContextMenuStrip.Items.Remove((ToolStripItem) _Module.CoinappLogoutToolStrip);
            _Module.Desktop.IsAdmin = true;
            this.MakeAdmin();
            this.toggle_beephardware.Enabled = false;
            this.toggle_beepshutdown.Enabled = false;
            this.toggle_beephardware.Checked = false;
            this.toggle_beepshutdown.Checked = false;
            this.ToggleBeepHardware(false);
            this.ToggleBeepShutdown(false);
            int num = (int) MessageBox.Show("Disconnected to the device successfully!", "Disconnected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          }
        }
      }
      this.ActiveControl = (Control) null;
    }

    private void ToggleMulticoin(bool @bool)
    {
      if (@bool)
      {
        this.label_coin2.Enabled = true;
        this.textbox_coin2.Enabled = true;
        this.textbox_coin2_pulse.Enabled = true;
        this.textbox_coin2.Text = Conversions.ToString(_Module.Conf.Coin2);
        this.textbox_coin2_pulse.Text = Conversions.ToString(_Module.Conf.Pulse2);
        this.textbox_notify_coin2.Text = _Module.Conf.NotifyCoin2;
        this.textbox_notify_coin2.Enabled = true;
        this.label_coin3.Enabled = true;
        this.textbox_coin3.Enabled = true;
        this.textbox_coin3_pulse.Enabled = true;
        this.textbox_coin3.Text = Conversions.ToString(_Module.Conf.Coin3);
        this.textbox_coin3_pulse.Text = Conversions.ToString(_Module.Conf.Pulse3);
        this.textbox_notify_coin3.Text = _Module.Conf.NotifyCoin3;
        this.textbox_notify_coin3.Enabled = true;
      }
      else
      {
        this.label_coin2.Enabled = false;
        this.textbox_coin2.Enabled = false;
        this.textbox_coin2_pulse.Enabled = false;
        this.textbox_coin2.Text = (string) null;
        this.textbox_coin2_pulse.Text = (string) null;
        this.textbox_notify_coin2.Text = (string) null;
        this.textbox_notify_coin2.Enabled = false;
        this.label_coin3.Enabled = false;
        this.textbox_coin3.Enabled = false;
        this.textbox_coin3_pulse.Enabled = false;
        this.textbox_coin3.Text = (string) null;
        this.textbox_coin3_pulse.Text = (string) null;
        this.textbox_notify_coin3.Text = (string) null;
        this.textbox_notify_coin3.Enabled = false;
      }
    }

    private void DualCoinAcceptor()
    {
      this.label_coin2.Enabled = true;
      this.textbox_coin2.Enabled = true;
      this.textbox_coin2_pulse.Enabled = true;
      this.textbox_coin2.Text = Conversions.ToString(_Module.Conf.Coin2);
      this.textbox_coin2_pulse.Text = Conversions.ToString(_Module.Conf.Pulse2);
      this.textbox_notify_coin2.Text = _Module.Conf.NotifyCoin2;
      this.textbox_notify_coin2.Enabled = true;
      this.label_coin3.Enabled = false;
      this.textbox_coin3.Enabled = false;
      this.textbox_coin3_pulse.Enabled = false;
      this.textbox_coin3.Text = (string) null;
      this.textbox_coin3_pulse.Text = (string) null;
      this.textbox_notify_coin3.Text = (string) null;
      this.textbox_notify_coin3.Enabled = false;
    }

    private void textBox_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (Microsoft.VisualBasic.Strings.Asc(e.KeyChar) == 8 || !(Microsoft.VisualBasic.Strings.Asc(e.KeyChar) < 48 | Microsoft.VisualBasic.Strings.Asc(e.KeyChar) > 57))
        return;
      e.Handled = true;
      SystemSounds.Beep.Play();
    }

    private void combobox_cointype_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.combobox_cointype.SelectedIndex == 0)
      {
        this.ToggleMulticoin(false);
        this.CheckSingleCoin();
      }
      else if (this.combobox_cointype.SelectedIndex == 1)
      {
        this.ToggleMulticoin(true);
      }
      else
      {
        if (this.combobox_cointype.SelectedIndex != 2)
          return;
        this.DualCoinAcceptor();
        this.CheckDualCoin();
      }
    }

    private void button_device_MouseHover(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.button_device.Text, "Connected", false) == 0)
      {
        this.button_device.Text = "Disconnect";
      }
      else
      {
        if (Operators.CompareString(this.button_device.Text, "Disconnected", false) != 0)
          return;
        this.button_device.Text = "Connect";
      }
    }

    private void button_device_MouseLeave(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.button_device.Text, "Disconnect", false) == 0)
      {
        this.button_device.Text = "Connected";
      }
      else
      {
        if (Operators.CompareString(this.button_device.Text, "Connect", false) != 0)
          return;
        this.button_device.Text = "Disconnected";
      }
    }

    private void button_changepass_Click(object sender, EventArgs e)
    {
      if ((uint) Operators.CompareString(this.textbox_currentpass.Text, _Module._MD5.Decrypt(_Module.Config.EncryptedReadFile(_Module._MD5.GetMd5Hash("password")), "password"), false) > 0U)
      {
        int num1 = (int) MessageBox.Show("Incorrect current password.", "Change pass error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else if ((uint) Operators.CompareString(this.textbox_newpass.Text, this.textbox_retypepass.Text, false) > 0U)
      {
        int num2 = (int) MessageBox.Show("New password and retype password not match. Try again", "Change pass error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else if (MessageBox.Show("Do you really want to change your password. This cannot be undone. Continue?", "Change password", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
      {
        _Module.Config.WriteFile(_Module._MD5.GetMd5Hash("password"), _Module._MD5.Encrypt(this.textbox_newpass.Text, "password"));
        this.textbox_currentpass.Text = (string) null;
        this.textbox_newpass.Text = (string) null;
        this.textbox_retypepass.Text = (string) null;
        int num3 = (int) MessageBox.Show("Changed password successfully. Do not forget your new password.", "Changed password", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      this.ActiveControl = (Control) null;
    }

    private void textbox_passwordChange(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.textbox_currentpass.Text, "", false) != 0 && Operators.CompareString(this.textbox_newpass.Text, "", false) != 0 && (uint) Operators.CompareString(this.textbox_retypepass.Text, "", false) > 0U)
        this.button_changepass.Enabled = true;
      else
        this.button_changepass.Enabled = false;
    }

    private void textbox_emailChange(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.textbox_newemail.Text, "", false) != 0 && _Module.IsValidEmailFormat(this.textbox_newemail.Text))
        this.button_changeemail.Enabled = true;
      else
        this.button_changeemail.Enabled = false;
    }

    private void textbox_letterkey_KeyDown(object sender, KeyEventArgs e)
    {
      if ((e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9) && (e.KeyCode != Keys.Decimal && e.KeyCode != Keys.Pause) && (e.KeyCode != Keys.Tab && e.KeyCode != Keys.LWin && e.KeyCode != Keys.RWin) && (e.KeyCode < Keys.ShiftKey || e.KeyCode > Keys.Menu))
      {
        this.keycode = (int) e.KeyCode;
        this.keycodeString = _Module.Hotkey.GetKeypressed((int) e.KeyCode);
        this.textbox_letterkey.Text = this.keycodeString;
      }
      else
      {
        e.Handled = true;
        SystemSounds.Beep.Play();
      }
    }

    private void textbox_letterkey_Click(object sender, EventArgs e)
    {
      this.textbox_letterkey.Text = "Press a key";
    }

    private void textbox_letterkey_Leave(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.keycodeString, "", false) == 0)
        this.textbox_letterkey.Text = "Click to set";
      else
        this.textbox_letterkey.Text = this.keycodeString;
    }

    private void textbox_TextChanged(object sender, EventArgs e)
    {
      if (NewLateBinding.LateGet(sender, (System.Type) null, "Text", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null) != (object) "0" && NewLateBinding.LateGet(sender, (System.Type) null, "Text", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null) != (object) "")
      {
        if (Operators.CompareString(this.textbox_turnoff.Text, "0", false) != 0 && Operators.CompareString(this.textbox_turnoff.Text, "", false) != 0 && (Operators.CompareString(Conversions.ToString(this.textbox_turnoff.Text.First<char>()), "0", false) != 0 && this.textbox_turnoff.Text.Count<char>() != 1) && (Operators.CompareString(this.textbox_loginretry.Text, "0", false) != 0 && Operators.CompareString(this.textbox_loginretry.Text, "", false) != 0 && Operators.CompareString(this.textbox_letterkey.Text, "", false) != 0) && (uint) Operators.CompareString(this.textbox_letterkey.Text, "Click to set", false) > 0U)
        {
          if (this.combobox_cointype.SelectedIndex == 0)
            this.CheckSingleCoin();
          else if (this.combobox_cointype.SelectedIndex == 1)
          {
            if (Operators.CompareString(this.textbox_coin1.Text, "0", false) != 0 && Operators.CompareString(this.textbox_coin1.Text, "", false) != 0 && (Operators.CompareString(Conversions.ToString(this.textbox_coin1.Text.First<char>()), "0", false) != 0 && Operators.CompareString(this.textbox_coin1_pulse.Text, "0", false) != 0) && (Operators.CompareString(this.textbox_coin1_pulse.Text, "", false) != 0 && Operators.CompareString(Conversions.ToString(this.textbox_coin1_pulse.Text.First<char>()), "0", false) != 0 && (Operators.CompareString(this.textbox_coin2.Text, "0", false) != 0 && Operators.CompareString(this.textbox_coin2.Text, "", false) != 0)) && (Operators.CompareString(Conversions.ToString(this.textbox_coin2.Text.First<char>()), "0", false) != 0 && Operators.CompareString(this.textbox_coin2_pulse.Text, "0", false) != 0 && (Operators.CompareString(this.textbox_coin2_pulse.Text, "", false) != 0 && Operators.CompareString(Conversions.ToString(this.textbox_coin2_pulse.Text.First<char>()), "0", false) != 0) && (Operators.CompareString(this.textbox_coin3.Text, "0", false) != 0 && Operators.CompareString(this.textbox_coin3.Text, "", false) != 0 && (Operators.CompareString(Conversions.ToString(this.textbox_coin3.Text.First<char>()), "0", false) != 0 && Operators.CompareString(this.textbox_coin3_pulse.Text, "0", false) != 0))) && Operators.CompareString(this.textbox_coin3_pulse.Text, "", false) != 0 && (uint) Operators.CompareString(Conversions.ToString(this.textbox_coin3_pulse.Text.First<char>()), "0", false) > 0U)
            {
              this.button_savesettings.Enabled = true;
              this.button_savesettings.Cursor = Cursors.Hand;
            }
            else
            {
              this.button_savesettings.Enabled = false;
              this.button_savesettings.Cursor = Cursors.Default;
            }
          }
          else
          {
            if (this.combobox_cointype.SelectedIndex != 2)
              return;
            this.CheckDualCoin();
          }
        }
        else
        {
          this.button_savesettings.Enabled = false;
          this.button_savesettings.Cursor = Cursors.Default;
        }
      }
      else
      {
        this.button_savesettings.Enabled = false;
        this.button_savesettings.Cursor = Cursors.Default;
      }
    }

    private void button_close_Click(object sender, EventArgs e)
    {
      this.ActiveControl = (Control) null;
      if (MessageBox.Show("Coinapp application is about to close. Continue?", "Coinapp closing...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
        return;
      if (_Module.Config.CheckTaskmgrRegValue())
        _Module.Config.DelTaskmgrRegValue();
      int num1 = (int) _Module.PowerManager.PowerSaveOn();
      if (_Module.Conf.SaveData)
      {
        int num2;
        try
        {
          num2 = Conversions.ToInteger(_Module._MD5.Decrypt(_Module.Config.EncryptedReadCoin(_Module._MD5.Decrypt(_Module.Config.EncryptedReadFile(_Module._MD5.GetMd5Hash("datafolder")), "datafolder"), _Module._MD5.GetMd5Hash("remainingtime" + _Module.MyID)), "remainingtime"));
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          num2 = 0;
          ProjectData.ClearProjectError();
        }
        if ((uint) num2 > 0U)
        {
          if (MessageBox.Show("There is a time to be resume later. What will you do?\r\nYES to cancel the time resume; or\r\nNO to resume the time later.", "Cancel time resume?", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
          {
            _Module.Config.WriteCoin(_Module._MD5.Decrypt(_Module.Config.EncryptedReadFile(_Module._MD5.GetMd5Hash("datafolder")), "datafolder"), _Module._MD5.GetMd5Hash("remainingtime" + _Module.MyID), _Module._MD5.Encrypt("0", "remainingtime"));
            this.CloseApp(false);
          }
          else
            this.CloseApp(false);
        }
        this.CloseApp(false);
      }
      else
        this.CloseApp(false);
    }

    private void button_restart_Click(object sender, EventArgs e)
    {
      this.ActiveControl = (Control) null;
      if (MessageBox.Show("Coinapp application is about to restart. Continue?", "Coinapp restarting...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
        return;
      if (_Module.Conf.SaveData)
      {
        int num;
        try
        {
          num = Conversions.ToInteger(_Module._MD5.Decrypt(_Module.Config.EncryptedReadCoin(_Module._MD5.Decrypt(_Module.Config.EncryptedReadFile(_Module._MD5.GetMd5Hash("datafolder")), "datafolder"), _Module._MD5.GetMd5Hash("remainingtime" + _Module.MyID)), "remainingtime"));
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          num = 0;
          ProjectData.ClearProjectError();
        }
        if ((uint) num > 0U)
        {
          if (MessageBox.Show("There is a time to be resume later. What will you do?\r\nYES to cancel the time resume; or\r\nNO to resume the time later.", "Cancel time resume?", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
          {
            _Module.Config.WriteCoin(_Module._MD5.Decrypt(_Module.Config.EncryptedReadFile(_Module._MD5.GetMd5Hash("datafolder")), "datafolder"), _Module._MD5.GetMd5Hash("remainingtime" + _Module.MyID), _Module._MD5.Encrypt("0", "remainingtime"));
            this.CloseApp(true);
          }
          else
            this.CloseApp(true);
        }
        else
          this.CloseApp(true);
      }
      else
        this.CloseApp(true);
    }

    private void CloseApp(bool restart = false)
    {
      _Module.exitapp = true;
      if (_Module.Conf.Protect)
        _Module.proc.Kill();
      if (restart)
      {
        try
        {
          Application.Restart();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          int num = (int) Interaction.MsgBox((object) ex.Message, MsgBoxStyle.Critical, (object) null);
          ProjectData.ClearProjectError();
        }
      }
      else
      {
        try
        {
          Environment.Exit(0);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          int num = (int) Interaction.MsgBox((object) ex.Message, MsgBoxStyle.Critical, (object) null);
          ProjectData.ClearProjectError();
        }
      }
    }

    private void toggle_sound_CheckedChanged(object sender, EventArgs e)
    {
      if (this.toggle_sound.Checked)
      {
        this.combobox_coinsound.SelectedIndex = _Module.Conf.CoinSound == -1 ? 0 : _Module.Conf.CoinSound;
        this.combobox_timesound.SelectedIndex = _Module.Conf.TimeSound == -1 ? 0 : _Module.Conf.TimeSound;
        this.toggle_5secvoice.Enabled = true;
        this.combobox_coinsound.Enabled = true;
        this.combobox_timesound.Enabled = true;
        this.button_coinplay.Enabled = true;
        this.button_timeplay.Enabled = true;
        this.label_coinsound.Enabled = true;
        this.label_timesound.Enabled = true;
      }
      else
      {
        this.toggle_5secvoice.Enabled = false;
        this.toggle_5secvoice.Checked = false;
        this.combobox_coinsound.Enabled = false;
        this.combobox_timesound.Enabled = false;
        this.button_coinplay.Enabled = false;
        this.button_timeplay.Enabled = false;
        this.label_coinsound.Enabled = false;
        this.label_timesound.Enabled = false;
        this.combobox_coinsound.SelectedIndex = -1;
        this.combobox_timesound.SelectedIndex = -1;
      }
    }

    private void button_coinplay_Click(object sender, EventArgs e)
    {
      switch (this.combobox_coinsound.SelectedIndex)
      {
        case 0:
          if (_Module.Config.CoinSoundExists())
          {
            try
            {
              MyProject.Computer.Audio.Play(_Module.Config.CoinSoundFile, AudioPlayMode.Background);
              break;
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              int num = (int) MessageBox.Show(ex.Message, "Error playing", MessageBoxButtons.OK, MessageBoxIcon.Hand);
              ProjectData.ClearProjectError();
              break;
            }
          }
          else
          {
            int num = (int) MessageBox.Show("Coin.wav not found", "Error playing", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            break;
          }
        case 1:
          MyProject.Computer.Audio.Play((Stream) _Module.Config.all_eyes_on_me(), AudioPlayMode.Background);
          break;
        case 2:
          MyProject.Computer.Audio.Play((Stream) _Module.Config.appointed(), AudioPlayMode.Background);
          break;
        case 3:
          MyProject.Computer.Audio.Play((Stream) _Module.Config.drop_in(), AudioPlayMode.Background);
          break;
        case 4:
          MyProject.Computer.Audio.Play((Stream) _Module.Config.exquisite(), AudioPlayMode.Background);
          break;
        case 5:
          MyProject.Computer.Audio.Play((Stream) _Module.Config.intuition(), AudioPlayMode.Background);
          break;
        case 6:
          MyProject.Computer.Audio.Play((Stream) _Module.Config.open_ended(), AudioPlayMode.Background);
          break;
        case 7:
          MyProject.Computer.Audio.Play((Stream) _Module.Config.pull_out(), AudioPlayMode.Background);
          break;
      }
      this.ActiveControl = (Control) null;
    }

    private void button_timeplay_Click(object sender, EventArgs e)
    {
      switch (this.combobox_timesound.SelectedIndex)
      {
        case 0:
          if (_Module.Config.TimeSoundExists())
          {
            try
            {
              MyProject.Computer.Audio.Play(_Module.Config.TimeSoundFile, AudioPlayMode.Background);
              break;
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              int num = (int) MessageBox.Show(ex.Message, "Error playing", MessageBoxButtons.OK, MessageBoxIcon.Hand);
              ProjectData.ClearProjectError();
              break;
            }
          }
          else
          {
            int num = (int) MessageBox.Show("Time.wav not found", "Error playing", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            break;
          }
        case 1:
          MyProject.Computer.Audio.Play((Stream) _Module.Config.siren(), AudioPlayMode.Background);
          break;
      }
      this.ActiveControl = (Control) null;
    }

    private void button_changeemail_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Do you really want to change your recovery email?", "Change email", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
      {
        _Module.Config.WriteFile(_Module._MD5.GetMd5Hash("email"), _Module._MD5.Encrypt(this.textbox_newemail.Text, "email"));
        this.textbox_currentemail.Text = this.textbox_newemail.Text;
        this.textbox_newemail.Text = (string) null;
        int num = (int) MessageBox.Show("Recovery email changed successfully. Do not forget your new Email.", "Changed email", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      this.ActiveControl = (Control) null;
    }

    private void MakeAdmin()
    {
      _Module.CoinappNotifyIcon.Icon = _Module.Image.admin();
      if (_Module.CoinappContextMenuStrip.Items.Contains((ToolStripItem) _Module.CoinappVisibleToolStrip))
        _Module.CoinappContextMenuStrip.Items.Remove((ToolStripItem) _Module.CoinappVisibleToolStrip);
      if (_Module.CoinappContextMenuStrip.Items.Contains((ToolStripItem) _Module.CoinappLogoutToolStrip))
        _Module.CoinappContextMenuStrip.Items.Remove((ToolStripItem) _Module.CoinappLogoutToolStrip);
      if (!_Module.CoinappContextMenuStrip.Items.Contains((ToolStripItem) _Module.CoinappSettingsToolStrip))
        _Module.CoinappContextMenuStrip.Items.Add((ToolStripItem) _Module.CoinappSettingsToolStrip);
      if (_Module.Conf.SaveData && !_Module.CoinappContextMenuStrip.Items.Contains((ToolStripItem) _Module.CoinappCounterToolStrip))
        _Module.CoinappContextMenuStrip.Items.Add((ToolStripItem) _Module.CoinappCounterToolStrip);
      if (_Module.CoinappContextMenuStrip.Items.Contains((ToolStripItem) _Module.CoinappLockToolStrip))
        return;
      _Module.CoinappContextMenuStrip.Items.Add((ToolStripItem) _Module.CoinappLockToolStrip);
    }

    private void CheckSingleCoin()
    {
      if (Operators.CompareString(this.textbox_coin1.Text, "0", false) != 0 && Operators.CompareString(this.textbox_coin1.Text, "", false) != 0 && (Operators.CompareString(Conversions.ToString(this.textbox_coin1.Text.First<char>()), "0", false) != 0 && Operators.CompareString(this.textbox_coin1_pulse.Text, "0", false) != 0) && Operators.CompareString(this.textbox_coin1_pulse.Text, "", false) != 0 && (uint) Operators.CompareString(Conversions.ToString(this.textbox_coin1_pulse.Text.First<char>()), "0", false) > 0U)
      {
        this.button_savesettings.Enabled = true;
        this.button_savesettings.Cursor = Cursors.Hand;
      }
      else
      {
        this.button_savesettings.Enabled = false;
        this.button_savesettings.Cursor = Cursors.Default;
      }
    }

    private void CheckDualCoin()
    {
      if (Operators.CompareString(this.textbox_coin1.Text, "0", false) != 0 && Operators.CompareString(this.textbox_coin1.Text, "", false) != 0 && (Operators.CompareString(Conversions.ToString(this.textbox_coin1.Text.First<char>()), "0", false) != 0 && Operators.CompareString(this.textbox_coin1_pulse.Text, "0", false) != 0) && (Operators.CompareString(this.textbox_coin1_pulse.Text, "", false) != 0 && Operators.CompareString(Conversions.ToString(this.textbox_coin1_pulse.Text.First<char>()), "0", false) != 0 && (Operators.CompareString(this.textbox_coin2.Text, "0", false) != 0 && Operators.CompareString(this.textbox_coin2.Text, "", false) != 0)) && (Operators.CompareString(Conversions.ToString(this.textbox_coin2.Text.First<char>()), "0", false) != 0 && Operators.CompareString(this.textbox_coin2_pulse.Text, "0", false) != 0 && Operators.CompareString(this.textbox_coin2_pulse.Text, "", false) != 0) && (uint) Operators.CompareString(Conversions.ToString(this.textbox_coin2_pulse.Text.First<char>()), "0", false) > 0U)
      {
        this.button_savesettings.Enabled = true;
        this.button_savesettings.Cursor = Cursors.Hand;
      }
      else
      {
        this.button_savesettings.Enabled = false;
        this.button_savesettings.Cursor = Cursors.Default;
      }
    }

    private void button_deviceinfo_Click(object sender, EventArgs e)
    {
      int num = (int) MyProject.Forms.Form_deviceinfo.ShowDialog();
      this.ActiveControl = (Control) null;
    }

    private void toggle_savedata_CheckedChanged(object sender, EventArgs e)
    {
      if (this.toggle_savedata.Checked)
      {
        if (_Module.Config.FileExists(_Module._MD5.GetMd5Hash("datafolder")))
        {
          string Left;
          try
          {
            Left = _Module._MD5.Decrypt(_Module.Config.EncryptedReadFile(_Module._MD5.GetMd5Hash("datafolder")), "datafolder");
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            Left = "";
            ProjectData.ClearProjectError();
          }
          this.textbox_datafolder.Text = (uint) Operators.CompareString(Left, "", false) <= 0U ? _Module.Config.defaultDataFolder : _Module._MD5.Decrypt(_Module.Config.EncryptedReadFile(_Module._MD5.GetMd5Hash("datafolder")), "datafolder");
        }
        else
          this.textbox_datafolder.Text = _Module.Config.defaultDataFolder;
        this.textbox_datafolder.Enabled = true;
        this.button_browse.Enabled = true;
      }
      else
      {
        int num1;
        try
        {
          num1 = Conversions.ToInteger(_Module._MD5.Decrypt(_Module.Config.EncryptedReadCoin(_Module._MD5.Decrypt(_Module.Config.EncryptedReadFile(_Module._MD5.GetMd5Hash("datafolder")), "datafolder"), _Module._MD5.GetMd5Hash("remainingtime" + _Module.MyID)), "remainingtime"));
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
          num2 = Conversions.ToInteger(_Module._MD5.Decrypt(_Module.Config.EncryptedReadCoin(_Module._MD5.Decrypt(_Module.Config.EncryptedReadFile(_Module._MD5.GetMd5Hash("datafolder")), "datafolder"), _Module._MD5.GetMd5Hash("coincounter" + _Module.MyID)), "coincounter"));
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          num2 = 0;
          ProjectData.ClearProjectError();
        }
        if (num1 != 0 || (uint) num2 > 0U)
        {
          if (MessageBox.Show("There is a previous Data in data folder containing the remaining time and total coins earned. Do you want to remove the data and turn off the data folder?", "Turn off data folder", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
          {
            _Module.Config.WriteCoin(_Module._MD5.Decrypt(_Module.Config.EncryptedReadFile(_Module._MD5.GetMd5Hash("datafolder")), "datafolder"), _Module._MD5.GetMd5Hash("remainingtime" + _Module.MyID), _Module._MD5.Encrypt("0", "remainingtime"));
            _Module.Config.WriteCoin(_Module._MD5.Decrypt(_Module.Config.EncryptedReadFile(_Module._MD5.GetMd5Hash("datafolder")), "datafolder"), _Module._MD5.GetMd5Hash("coincounter" + _Module.MyID), _Module._MD5.Encrypt("0", "coincounter"));
            int num3 = (int) MessageBox.Show("Remaining time canceled.", "Time canceled", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.textbox_datafolder.Clear();
            this.textbox_datafolder.Enabled = false;
            this.button_browse.Enabled = false;
          }
          else
            this.toggle_savedata.Checked = true;
        }
        else
        {
          this.textbox_datafolder.Clear();
          this.textbox_datafolder.Enabled = false;
          this.button_browse.Enabled = false;
        }
      }
    }

    private void button_browse_Click(object sender, EventArgs e)
    {
      string Left;
      try
      {
        Left = _Module._MD5.Decrypt(_Module.Config.EncryptedReadFile(_Module._MD5.GetMd5Hash("datafolder")), "datafolder");
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Left = "";
        ProjectData.ClearProjectError();
      }
      if ((uint) Operators.CompareString(Left, "", false) > 0U)
      {
        int num1;
        try
        {
          num1 = Conversions.ToInteger(_Module._MD5.Decrypt(_Module.Config.EncryptedReadCoin(_Module._MD5.Decrypt(_Module.Config.EncryptedReadFile(_Module._MD5.GetMd5Hash("datafolder")), "datafolder"), _Module._MD5.GetMd5Hash("remainingtime" + _Module.MyID)), "remainingtime"));
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
          num2 = Conversions.ToInteger(_Module._MD5.Decrypt(_Module.Config.EncryptedReadCoin(_Module._MD5.Decrypt(_Module.Config.EncryptedReadFile(_Module._MD5.GetMd5Hash("datafolder")), "datafolder"), _Module._MD5.GetMd5Hash("coincounter" + _Module.MyID)), "coincounter"));
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          num2 = 0;
          ProjectData.ClearProjectError();
        }
        if (num1 != 0 || (uint) num2 > 0U)
        {
          if (MessageBox.Show("There is a previous Data in data folder containing the remaining time and total coins earned. Do you want to remove the data and turn off the data folder?", "Remove data", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes && this.BrowseLocation())
          {
            _Module.Config.WriteCoin(_Module._MD5.Decrypt(_Module.Config.EncryptedReadFile(_Module._MD5.GetMd5Hash("datafolder")), "datafolder"), _Module._MD5.GetMd5Hash("remainingtime" + _Module.MyID), _Module._MD5.Encrypt("0", "remainingtime"));
            _Module.Config.WriteCoin(_Module._MD5.Decrypt(_Module.Config.EncryptedReadFile(_Module._MD5.GetMd5Hash("datafolder")), "datafolder"), _Module._MD5.GetMd5Hash("coincounter" + _Module.MyID), _Module._MD5.Encrypt("0", "coincounter"));
            int num3 = (int) Interaction.MsgBox((object) "Data in data folder deleted.", MsgBoxStyle.Information, (object) null);
          }
        }
        else
          this.BrowseLocation();
      }
      else
        this.BrowseLocation();
      this.ActiveControl = (Control) null;
    }

    private bool BrowseLocation()
    {
      FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
      folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;
      folderBrowserDialog.SelectedPath = "C:\\";
      folderBrowserDialog.Description = "Coinapp Save Data";
      if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
        return false;
      this.textbox_datafolder.Text = folderBrowserDialog.SelectedPath + "\\";
      return true;
    }

    private void toggle_beephardware_CheckedChanged(object sender, EventArgs e)
    {
      if (this.toggle_beephardware.Checked)
        this.ToggleBeepHardware(true);
      else
        this.ToggleBeepHardware(false);
    }

    private void ToggleBeepHardware(bool @bool)
    {
      this.label_beepcoindrop.Enabled = @bool;
      this.textbox_beepcoinfreq.Enabled = @bool;
      this.textbox_beepcoindur.Enabled = @bool;
      this.button_playbeepcoin.Enabled = @bool;
      this.label_beeptime.Enabled = @bool;
      this.textbox_beeptime.Enabled = @bool;
      this.textbox_beeptimerep.Enabled = @bool;
      this.textbox_beeptimefreq.Enabled = @bool;
      this.textbox_beeptimedur.Enabled = @bool;
      this.button_playbeeptime.Enabled = @bool;
      this.label_beeplock.Enabled = @bool;
      this.textbox_beeplockrep.Enabled = @bool;
      this.textbox_beeplockfreq.Enabled = @bool;
      this.textbox_beeplockdur.Enabled = @bool;
      this.button_playbeeplock.Enabled = @bool;
      this.toggle_beepshutdown.Enabled = @bool;
      if (@bool)
      {
        this.textbox_beepcoinfreq.Text = Conversions.ToString(_Module.Conf.BeepCoinFreq);
        this.textbox_beepcoindur.Text = Conversions.ToString(_Module.Conf.BeepCoinDur);
        this.textbox_beeptime.Text = Conversions.ToString(_Module.Conf.BeepTime);
        this.textbox_beeptimerep.Text = Conversions.ToString(_Module.Conf.BeepTimeRep);
        this.textbox_beeptimefreq.Text = Conversions.ToString(_Module.Conf.BeepTimeFreq);
        this.textbox_beeptimedur.Text = Conversions.ToString(_Module.Conf.BeepTimeDur);
        this.textbox_beeplockrep.Text = Conversions.ToString(_Module.Conf.BeepLockRep);
        this.textbox_beeplockfreq.Text = Conversions.ToString(_Module.Conf.BeepLockFreq);
        this.textbox_beeplockdur.Text = Conversions.ToString(_Module.Conf.BeepLockDur);
        if (_Module.Conf.BeepShut)
          this.toggle_beepshutdown.Checked = true;
        else
          this.toggle_beepshutdown.Checked = false;
      }
      else
      {
        this.textbox_beepcoinfreq.Text = "";
        this.textbox_beepcoindur.Text = "";
        this.textbox_beeptime.Text = "";
        this.textbox_beeptimerep.Text = "";
        this.textbox_beeptimefreq.Text = "";
        this.textbox_beeptimedur.Text = "";
        this.textbox_beeplockrep.Text = "";
        this.textbox_beeplockfreq.Text = "";
        this.textbox_beeplockdur.Text = "";
        this.toggle_beepshutdown.Checked = false;
        this.ToggleBeepShutdown(false);
      }
    }

    private void toggle_beepshutdown_CheckedChanged(object sender, EventArgs e)
    {
      if (this.toggle_beepshutdown.Checked)
        this.ToggleBeepShutdown(true);
      else
        this.ToggleBeepShutdown(false);
    }

    private void ToggleBeepShutdown(bool @bool)
    {
      this.label_beepshut.Enabled = @bool;
      this.textbox_beepshutfreq.Enabled = @bool;
      this.textbox_beepshutdur.Enabled = @bool;
      this.button_playbeepshut.Enabled = @bool;
      if (@bool)
      {
        this.textbox_beepshutfreq.Text = Conversions.ToString(_Module.Conf.BeepShutFreq);
        this.textbox_beepshutdur.Text = Conversions.ToString(_Module.Conf.BeepShutDur);
      }
      else
      {
        this.textbox_beepshutfreq.Text = "";
        this.textbox_beepshutdur.Text = "";
      }
    }

    private void button_playbeepcoin_Click(object sender, EventArgs e)
    {
      if (_Module.MainSerialPort.IsOpen && !_Module.DeviceIsError)
      {
        _Module.MainSerialPort.Write("FREQ=" + this.textbox_beepcoinfreq.Text);
        _Module.MainSerialPort.Write("DUR=" + this.textbox_beepcoindur.Text);
        _Module.MainSerialPort.Write("PLAYB;");
      }
      _Module.MainSerialPort.Write("FREQ=" + this.textbox_beepcoinfreq.Text);
      _Module.MainSerialPort.Write("DUR=" + this.textbox_beepcoindur.Text);
      _Module.MainSerialPort.Write("PLAYB;");
      this.ActiveControl = (Control) null;
    }

    private void button_playbeeptime_Click(object sender, EventArgs e)
    {
      if (_Module.MainSerialPort.IsOpen && !_Module.DeviceIsError)
      {
        _Module.MainSerialPort.Write("FREQ=" + this.textbox_beeptimefreq.Text);
        _Module.MainSerialPort.Write("DUR=" + this.textbox_beeptimedur.Text);
        _Module.MainSerialPort.Write("PLAYB;");
      }
      this.ActiveControl = (Control) null;
    }

    private void button_playbeeplock_Click(object sender, EventArgs e)
    {
      if (_Module.MainSerialPort.IsOpen && !_Module.DeviceIsError)
      {
        _Module.MainSerialPort.Write("FREQ=" + this.textbox_beeplockfreq.Text);
        _Module.MainSerialPort.Write("DUR=" + this.textbox_beeplockdur.Text);
        _Module.MainSerialPort.Write("PLAYB;");
      }
      this.ActiveControl = (Control) null;
    }

    private void button_playbeepshut_Click(object sender, EventArgs e)
    {
      if (_Module.MainSerialPort.IsOpen && !_Module.DeviceIsError)
      {
        _Module.MainSerialPort.Write("FREQ=" + this.textbox_beepshutfreq.Text);
        _Module.MainSerialPort.Write("DUR=" + this.textbox_beepshutdur.Text);
        _Module.MainSerialPort.Write("PLAYB;");
      }
      this.ActiveControl = (Control) null;
    }

    private void ToggleGUILock(bool @bool)
    {
      this.label_bg.Enabled = @bool;
      this.textbox_bgimagelocation.Enabled = @bool;
      this.button_browsebgimage.Enabled = @bool;
      this.label_bgimagelayout.Enabled = @bool;
      this.label_lockwindowpos.Enabled = @bool;
      this.label_lockwindowtrans.Enabled = @bool;
      this.label_lockwindowbgcolor.Enabled = @bool;
      this.label_startupinitializecolor.Enabled = @bool;
      this.label_deviceproblemcolor.Enabled = @bool;
      this.label_shutdowntime.Enabled = @bool;
      this.combobox_bgimagelayout.Enabled = @bool;
      this.combobox_lockwindowpos.Enabled = @bool;
      this.combobox_lockwindowtrans.Enabled = @bool;
      this.combobox_lockwindowbgcolor.Enabled = @bool;
      this.combobox_startupinitializecolor.Enabled = @bool;
      this.combobox_deviceproblemcolor.Enabled = @bool;
      this.combobox_shutdowntime.Enabled = @bool;
      if (@bool)
      {
        this.textbox_bgimagelocation.Text = _Module.Conf.BackgroundImage;
        try
        {
          this.combobox_bgimagelayout.SelectedIndex = Conversions.ToInteger(_Module.Conf.BackgroundImageLayout);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          int num = (int) Interaction.MsgBox((object) ex.Message, MsgBoxStyle.Critical, (object) null);
          ProjectData.ClearProjectError();
        }
        this.combobox_lockwindowpos.SelectedIndex = Operators.CompareString(_Module.Conf.ControlPosition, "0", false) != 0 ? 1 : 0;
        if (_Module.Conf.ControlTransparent)
        {
          this.combobox_lockwindowtrans.SelectedIndex = 0;
          this.combobox_lockwindowbgcolor.SelectedIndex = -1;
          this.combobox_lockwindowbgcolor.Enabled = false;
          this.label_lockwindowbgcolor.Enabled = false;
        }
        else
        {
          this.combobox_lockwindowtrans.SelectedIndex = 1;
          this.combobox_lockwindowbgcolor.Enabled = true;
          this.label_lockwindowbgcolor.Enabled = true;
          try
          {
            this.combobox_lockwindowbgcolor.SelectedIndex = Conversions.ToInteger(_Module.Conf.ControlBGColor);
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            int num = (int) Interaction.MsgBox((object) ex.Message, MsgBoxStyle.Critical, (object) null);
            ProjectData.ClearProjectError();
          }
        }
        try
        {
          this.combobox_startupinitializecolor.SelectedIndex = Conversions.ToInteger(_Module.Conf.InitializeColor);
          this.combobox_deviceproblemcolor.SelectedIndex = Conversions.ToInteger(_Module.Conf.DeviceProblemColor);
          this.combobox_shutdowntime.SelectedIndex = Conversions.ToInteger(_Module.Conf.ShutdownTimeColor);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          int num = (int) Interaction.MsgBox((object) ex.Message, MsgBoxStyle.Critical, (object) null);
          ProjectData.ClearProjectError();
        }
      }
      else
      {
        this.textbox_bgimagelocation.Text = "";
        this.combobox_bgimagelayout.SelectedIndex = -1;
        this.combobox_lockwindowpos.SelectedIndex = -1;
        this.combobox_lockwindowtrans.SelectedIndex = -1;
        this.combobox_lockwindowbgcolor.SelectedIndex = -1;
        this.combobox_startupinitializecolor.SelectedIndex = -1;
        this.combobox_deviceproblemcolor.SelectedIndex = -1;
        this.combobox_shutdowntime.SelectedIndex = -1;
      }
    }

    private void checkbox_customizelock_CheckedChanged(object sender, EventArgs e)
    {
      if (this.checkbox_customizelock.Checked)
        this.ToggleGUILock(true);
      else
        this.ToggleGUILock(false);
    }

    private void combobox_lockwindowtrans_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.combobox_lockwindowtrans.SelectedIndex == 0)
      {
        this.combobox_lockwindowbgcolor.Enabled = false;
        this.label_lockwindowbgcolor.Enabled = false;
        this.combobox_lockwindowbgcolor.SelectedIndex = -1;
      }
      else if (this.checkbox_customizelock.Checked)
      {
        this.combobox_lockwindowbgcolor.Enabled = true;
        this.label_lockwindowbgcolor.Enabled = true;
        this.combobox_lockwindowbgcolor.SelectedIndex = 0;
      }
      else
      {
        this.combobox_lockwindowbgcolor.Enabled = false;
        this.label_lockwindowbgcolor.Enabled = false;
        this.combobox_lockwindowbgcolor.SelectedIndex = -1;
      }
    }

    private bool BrowseBGImage()
    {
      FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
      folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;
      folderBrowserDialog.SelectedPath = "C:\\";
      folderBrowserDialog.Description = "Coinapp Save Data";
      if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
        return false;
      this.textbox_datafolder.Text = folderBrowserDialog.SelectedPath + "\\";
      return true;
    }

    private void button_browsebgimage_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.InitialDirectory = "C:\\";
      openFileDialog.Title = "Background image for Coinapp";
      openFileDialog.Filter = "JPEG|*.jpg";
      if (openFileDialog.ShowDialog() == DialogResult.Cancel)
        return;
      try
      {
        this.bgImageTemp = new Bitmap(openFileDialog.FileName);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) ex.Message, MsgBoxStyle.Critical, (object) null);
        ProjectData.ClearProjectError();
        return;
      }
      this.textbox_bgimagelocation.Text = Path.GetFullPath(openFileDialog.FileName);
    }

    private void checkbox_advance_CheckedChanged(object sender, EventArgs e)
    {
      if (this.checkbox_advance.Checked)
        this.ToggleAdvanceCustomization(true);
      else
        this.ToggleAdvanceCustomization(false);
    }

    private void ToggleAdvanceCustomization(bool @bool)
    {
      this.label_waitforprocmon.Enabled = @bool;
      this.textbox_waitforprocmon.Enabled = @bool;
      if (@bool)
      {
        if (Conversions.ToInteger(_Module.Conf.WaitForProcmon) < 1000)
          this.textbox_waitforprocmon.Text = "1000";
        else
          this.textbox_waitforprocmon.Text = _Module.Conf.WaitForProcmon;
      }
      else
        this.textbox_waitforprocmon.Text = "";
    }

    private void textbox_coins_Click(object sender, EventArgs e)
    {
      if ((TextBox) sender == this.textbox_coin1)
        this.tooltip_settings.Show("Time in seconds format (ex. 4 minutes x 60 seconds = 240 seconds)", (IWin32Window) this.textbox_coin1, 10000);
      else if ((TextBox) sender == this.textbox_coin2)
        this.tooltip_settings.Show("Time in seconds format (ex. 20 minutes x 60 seconds = 1200 seconds)", (IWin32Window) this.textbox_coin2, 10000);
      else if ((TextBox) sender == this.textbox_coin3)
        this.tooltip_settings.Show("Time in seconds format (ex. 40 minutes x 60 seconds = 2400 seconds)", (IWin32Window) this.textbox_coin3, 10000);
      else if ((TextBox) sender == this.textbox_coin1_pulse)
        this.tooltip_settings.Show("Pulse setting of your coin slot. Usually for 1 peso = 1 pulse.", (IWin32Window) this.textbox_coin1_pulse, 10000);
      else if ((TextBox) sender == this.textbox_coin2_pulse)
        this.tooltip_settings.Show("Pulse setting of your coin slot. Usually for universal coin slot for 5 peso = 5 pulse. If for 5-peso coin slot = 1 pulse also.", (IWin32Window) this.textbox_coin2_pulse, 10000);
      else if ((TextBox) sender == this.textbox_coin3_pulse)
        this.tooltip_settings.Show("Pulse setting of your universal coin slot. Usually for 10 peso = 10 pulse.", (IWin32Window) this.textbox_coin3_pulse, 10000);
      else if ((TextBox) sender == this.textbox_notify_coin1)
        this.tooltip_settings.Show("Notification message if 1-peso coin inserted", (IWin32Window) this.textbox_notify_coin1, 10000);
      else if ((TextBox) sender == this.textbox_notify_coin2)
      {
        this.tooltip_settings.Show("Notification message if 5-peso coin inserted", (IWin32Window) this.textbox_notify_coin2, 10000);
      }
      else
      {
        if ((TextBox) sender != this.textbox_notify_coin3)
          return;
        this.tooltip_settings.Show("Notification message if 10-peso coin inserted", (IWin32Window) this.textbox_notify_coin3, 10000);
      }
    }

    private void textbox_notifications_MouseHover(object sender, EventArgs e)
    {
      if ((TextBox) sender == this.textbox_notification1_seconds)
        this.tooltip_settings.Show("The time in seconds format to show up the 1st warning notification. Type 0 to disable", (IWin32Window) this.textbox_notification1_seconds, 10000);
      else if ((TextBox) sender == this.textbox_notification2_seconds)
        this.tooltip_settings.Show("The time in seconds format to show up the final warning notification. Type 0 to disable", (IWin32Window) this.textbox_notification2_seconds, 10000);
      else if ((TextBox) sender == this.textbox_notification1_length)
        this.tooltip_settings.Show("The duration in seconds format on how long the notification shows", (IWin32Window) this.textbox_notification1_length, 10000);
      else if ((TextBox) sender == this.textbox_notification2_length)
        this.tooltip_settings.Show("The duration in seconds format on how long the notification shows", (IWin32Window) this.textbox_notification2_length, 10000);
      else if ((TextBox) sender == this.textbox_notification1_messages)
      {
        this.tooltip_settings.Show("The message to show for the 1st warning notification", (IWin32Window) this.textbox_notification1_messages, 10000);
      }
      else
      {
        if ((TextBox) sender != this.textbox_notification2_messages)
          return;
        this.tooltip_settings.Show("The message to show for the inal warning notification", (IWin32Window) this.textbox_notification2_messages, 10000);
      }
    }

    private void textbox_beep_MouseHover(object sender, EventArgs e)
    {
      if ((TextBox) sender == this.textbox_beepcoinfreq)
        this.tooltip_settings.Show("The beep sound frequency (ex. 2000)", (IWin32Window) this.textbox_beepcoinfreq, 10000);
      else if ((TextBox) sender == this.textbox_beepcoindur)
        this.tooltip_settings.Show("Time duration of the beep sound in milliseconds format (ex. 1000 = 1 second)", (IWin32Window) this.textbox_beepcoindur, 10000);
      else if ((TextBox) sender == this.textbox_beeptime)
        this.tooltip_settings.Show("The time when will beep the sound in seconds format (ex. 2 minutes = 120 seconds)", (IWin32Window) this.textbox_beeptime, 10000);
      else if ((TextBox) sender == this.textbox_beeptimerep)
        this.tooltip_settings.Show("The beep sound repeat (ex. 5 = repeat the beep in 5 times)", (IWin32Window) this.textbox_beeptimerep, 10000);
      else if ((TextBox) sender == this.textbox_beeptimefreq)
        this.tooltip_settings.Show("The beep sound frequency (ex. 2000)", (IWin32Window) this.textbox_beeptimefreq, 10000);
      else if ((TextBox) sender == this.textbox_beeptimedur)
        this.tooltip_settings.Show("Time duration of the beep sound in milliseconds format (ex. 500 = 0.5 second)", (IWin32Window) this.textbox_beeptimedur, 10000);
      else if ((TextBox) sender == this.textbox_beeplockrep)
        this.tooltip_settings.Show("The beep sound repeat (ex. 5 = repeat the beep in 5 times)", (IWin32Window) this.textbox_beeplockrep, 10000);
      else if ((TextBox) sender == this.textbox_beeplockfreq)
        this.tooltip_settings.Show("The beep sound frequency (ex. 2000)", (IWin32Window) this.textbox_beeplockfreq, 10000);
      else if ((TextBox) sender == this.textbox_beeplockdur)
        this.tooltip_settings.Show("Time duration of the beep sound in milliseconds format (ex. 500 = 0.5 second)", (IWin32Window) this.textbox_beeplockdur, 10000);
      else if ((TextBox) sender == this.textbox_beepshutfreq)
      {
        this.tooltip_settings.Show("The beep sound frequency (ex. 3000)", (IWin32Window) this.textbox_beepshutfreq, 10000);
      }
      else
      {
        if ((TextBox) sender != this.textbox_beepshutdur)
          return;
        this.tooltip_settings.Show("Time duration of the beep sound in milliseconds format (ex. 500 = 0.5 second)", (IWin32Window) this.textbox_beepshutdur, 10000);
      }
    }

    private delegate void MyDelegate();

    private delegate void Worker_RunWorkerCompleted_Delegate(
      object sender,
      RunWorkerCompletedEventArgs e);
  }
}
