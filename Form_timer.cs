// Decompiled with JetBrains decompiler
// Type: Coinapp.Form_timer
// Assembly: Coinapp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: ED4B7D1C-BF2E-4AAF-8FCA-FEC188D22124
// Assembly location: C:\Users\EarlJohn\Desktop\Coinapp\Coinapp.exe

using Coinapp.My;
using Control;
using Device;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using RegistryUtils;
using Settings;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Management;
using System.Media;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace Coinapp
{
  [DesignerGenerated]
  public class Form_timer : Form
  {
    private IContainer components;
    private Form MeForm;

    public Form_timer()
    {
      this.Load += new EventHandler(this.Form_timer_Load);
      this.MouseDown += new MouseEventHandler(this.Me_MouseDown);
      this.MouseDoubleClick += new MouseEventHandler(this.Me_MouseDoubleClick);
      this.MeForm = _Entrypoint.MyMainForm;
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form_timer));
      this.label_countdown = new Label();
      this.picturebox_icon = new PictureBox();
      this.TableLayoutPanel1 = new TableLayoutPanel();
      ((ISupportInitialize) this.picturebox_icon).BeginInit();
      this.TableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      this.label_countdown.AutoSize = true;
      this.label_countdown.BackColor = System.Drawing.Color.Transparent;
      this.label_countdown.Dock = DockStyle.Fill;
      this.label_countdown.Font = new Font("Antonio", 24f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label_countdown.ForeColor = SystemColors.ControlText;
      this.label_countdown.Location = new Point(55, 0);
      this.label_countdown.Margin = new Padding(0);
      this.label_countdown.Name = "label_countdown";
      this.label_countdown.RightToLeft = RightToLeft.No;
      this.label_countdown.Size = new Size(145, 55);
      this.label_countdown.TabIndex = 0;
      this.label_countdown.Text = "00:00:00";
      this.label_countdown.TextAlign = ContentAlignment.MiddleLeft;
      this.picturebox_icon.Dock = DockStyle.Fill;
      this.picturebox_icon.Image = (System.Drawing.Image) componentResourceManager.GetObject("picturebox_icon.Image");
      this.picturebox_icon.Location = new Point(3, 3);
      this.picturebox_icon.Name = "picturebox_icon";
      this.picturebox_icon.Size = new Size(49, 49);
      this.picturebox_icon.SizeMode = PictureBoxSizeMode.Zoom;
      this.picturebox_icon.TabIndex = 4;
      this.picturebox_icon.TabStop = false;
      this.TableLayoutPanel1.ColumnCount = 2;
      this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
      this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 145f));
      this.TableLayoutPanel1.Controls.Add((System.Windows.Forms.Control) this.picturebox_icon, 0, 0);
      this.TableLayoutPanel1.Controls.Add((System.Windows.Forms.Control) this.label_countdown, 1, 0);
      this.TableLayoutPanel1.Dock = DockStyle.Fill;
      this.TableLayoutPanel1.Location = new Point(0, 0);
      this.TableLayoutPanel1.Name = "TableLayoutPanel1";
      this.TableLayoutPanel1.RowCount = 1;
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
      this.TableLayoutPanel1.Size = new Size(200, 55);
      this.TableLayoutPanel1.TabIndex = 5;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new Size(200, 55);
      this.ControlBox = false;
      this.Controls.Add((System.Windows.Forms.Control) this.TableLayoutPanel1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.MaximizeBox = false;
      this.MaximumSize = new Size(200, 55);
      this.MinimizeBox = false;
      this.MinimumSize = new Size(200, 55);
      this.Name = nameof (Form_timer);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.Manual;
      this.Text = "Coinapp";
      this.TopMost = true;
      ((ISupportInitialize) this.picturebox_icon).EndInit();
      this.TableLayoutPanel1.ResumeLayout(false);
      this.TableLayoutPanel1.PerformLayout();
      this.ResumeLayout(false);
    }

    internal virtual Label label_countdown
    {
      get
      {
        return this._label_countdown;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.Me_MouseDown);
        MouseEventHandler mouseEventHandler2 = new MouseEventHandler(this.Me_MouseDoubleClick);
        Label labelCountdown1 = this._label_countdown;
        if (labelCountdown1 != null)
        {
          labelCountdown1.MouseDown -= mouseEventHandler1;
          labelCountdown1.MouseDoubleClick -= mouseEventHandler2;
        }
        this._label_countdown = value;
        Label labelCountdown2 = this._label_countdown;
        if (labelCountdown2 == null)
          return;
        labelCountdown2.MouseDown += mouseEventHandler1;
        labelCountdown2.MouseDoubleClick += mouseEventHandler2;
      }
    }

    internal virtual PictureBox picturebox_icon
    {
      get
      {
        return this._picturebox_icon;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.Me_MouseDown);
        MouseEventHandler mouseEventHandler2 = new MouseEventHandler(this.Me_MouseDoubleClick);
        PictureBox pictureboxIcon1 = this._picturebox_icon;
        if (pictureboxIcon1 != null)
        {
          pictureboxIcon1.MouseDown -= mouseEventHandler1;
          pictureboxIcon1.MouseDoubleClick -= mouseEventHandler2;
        }
        this._picturebox_icon = value;
        PictureBox pictureboxIcon2 = this._picturebox_icon;
        if (pictureboxIcon2 == null)
          return;
        pictureboxIcon2.MouseDown += mouseEventHandler1;
        pictureboxIcon2.MouseDoubleClick += mouseEventHandler2;
      }
    }

    internal virtual TableLayoutPanel TableLayoutPanel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual BackgroundWorker Worker
    {
      get
      {
        return this._Worker;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.Worker_DoWork);
        BackgroundWorker worker1 = this._Worker;
        if (worker1 != null)
          worker1.DoWork -= workEventHandler;
        this._Worker = value;
        BackgroundWorker worker2 = this._Worker;
        if (worker2 == null)
          return;
        worker2.DoWork += workEventHandler;
      }
    }

    private virtual BackgroundWorker LockDelay
    {
      get
      {
        return this._LockDelay;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.LockDelay_DoWork);
        RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.Worker_RunWorkerCompleted);
        BackgroundWorker lockDelay1 = this._LockDelay;
        if (lockDelay1 != null)
        {
          lockDelay1.DoWork -= workEventHandler;
          lockDelay1.RunWorkerCompleted -= completedEventHandler;
        }
        this._LockDelay = value;
        BackgroundWorker lockDelay2 = this._LockDelay;
        if (lockDelay2 == null)
          return;
        lockDelay2.DoWork += workEventHandler;
        lockDelay2.RunWorkerCompleted += completedEventHandler;
      }
    }

    protected override CreateParams CreateParams
    {
      get
      {
        CreateParams createParams = base.CreateParams;
        createParams.ClassStyle |= 512;
        createParams.ExStyle |= 128;
        return createParams;
      }
    }

    protected override void WndProc(ref Message m)
    {
      if (m.Msg == 17)
        base.WndProc(ref new Message() { Msg = 31 });
      else
        base.WndProc(ref m);
    }

    protected override void DefWndProc(ref Message m)
    {
      if (!_Module.Desktop.IsLocked)
      {
        if (_Module.Conf.DisconnectLock)
          _Module.Device.ProcessWinMessageDevice(m.Msg, m.WParam);
        if (!_Module.Desktop.IsAdmin)
          _Module.Hotkey.ProcessWinMessageHotkey(m.Msg, m.WParam);
      }
      base.DefWndProc(ref m);
    }

    protected override void OnGotFocus(EventArgs e)
    {
      if (_Module.Conf.DisconnectLock)
        _Module.Device.UnregisterDeviceNotification(this.Handle);
      base.OnGotFocus(e);
    }

    protected override void OnLostFocus(EventArgs e)
    {
      if (_Module.Conf.DisconnectLock)
        _Module.Device.UnregisterDeviceNotification(this.Handle);
      base.OnLostFocus(e);
    }

    private void Form_timer_Load(object sender, EventArgs e)
    {
      _Module.BringTo.Front(this.Handle);
      Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
      int x = checked (workingArea.Width - this.Width + 20);
      workingArea = Screen.PrimaryScreen.WorkingArea;
      int y = checked (workingArea.Height - this.Height + 15);
      this.Location = new Point(x, y);
      this.label_countdown.Font = _Module._font.get_Antonio(24f, FontStyle.Bold);
      _Module.FormTimerIsHidden = false;
      if (_Module.ExecuteVariables)
        return;
      _Module.PreventShutdown = new Watcher();
      _Module.MyPID = Process.GetCurrentProcess().Id;
      _Module.Desktop.MainHandle = this.Handle;
      _Module.Desktop.MainForm = (Form) this;
      _Module.Desktop.KeyCode = _Module.Config.Keycode();
      int num1 = (int) _Module.PowerManager.PowerSaveOff();
      if (_Module.Conf.SaveData)
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
          if (Operators.CompareString(Left, "", false) == 0)
            _Module.Conf.SaveData = false;
        }
        else
          _Module.Conf.SaveData = false;
      }
      if (_Module.Conf.Protect)
      {
        if (_Module.Conf.AdvanceCustomization && Conversions.ToInteger(_Module.Conf.WaitForProcmon) >= 1000)
          _Module.waitProcmonProcess = Conversions.ToInteger(_Module.Conf.WaitForProcmon);
        if (!File.Exists(_Module.procmon))
        {
          _Module.errorcode = "1";
          _Module.hacked = true;
          _Module.Desktop.Lock((IWin32Window) MyProject.Forms.Form_lock);
        }
        else
        {
          _Module.proc = Process.Start(_Module.procmon);
          _Module.procPID = _Module.proc.Id;
          _Module.proc.EnableRaisingEvents = true;
          _Module.proc.Exited += new EventHandler(_Module.ProcessExited);
          this.Worker = new BackgroundWorker();
          this.Worker.RunWorkerAsync((object) "CheckProcess");
          _Module.processes = Process.GetProcessesByName("procmon");
          if (_Module.processes.Length == 0)
          {
            _Module.errorcode = "3";
            _Module.hacked = true;
            _Module.Desktop.Lock((IWin32Window) MyProject.Forms.Form_lock);
          }
          else if (_Module.processes.Length > 1)
          {
            int num2 = checked (_Module.processes.Length - 1);
            int index = 0;
            bool flag;
            while (index <= num2)
            {
              if (_Module.processes[index].Id == _Module.procPID)
                flag = true;
              checked { ++index; }
            }
            if (!flag)
            {
              _Module.errorcode = "4";
              _Module.hacked = true;
              _Module.Desktop.Lock((IWin32Window) MyProject.Forms.Form_lock);
            }
            else
              this.ExecuteAllVariables();
          }
          else
            this.ExecuteAllVariables();
        }
      }
      else
        this.ExecuteAllVariables();
    }

    public void CoinappNotifyIcon_DoubleClick(object sender, EventArgs e)
    {
      if (!_Module.Initialized || _Module.Desktop.IsAdmin)
        return;
      if (_Module.FormTimerIsHidden)
      {
        this.Show();
        _Module.FormTimerIsHidden = false;
        Rectangle rectangle = Screen.PrimaryScreen.Bounds;
        int x = checked (rectangle.Width - this.Width + 20);
        rectangle = Screen.PrimaryScreen.WorkingArea;
        int y = checked (rectangle.Height - this.Height + 15);
        this.Location = new Point(x, y);
        _Module.CoinappVisibleToolStrip.Text = "Hide";
      }
      else
      {
        _Module.FormTimerIsHidden = true;
        this.label_countdown.Text = "00:00:00";
        this.Hide();
        _Module.CoinappVisibleToolStrip.Text = "Show";
        this.CheckFirstTimeHideToTray();
      }
    }

    private void CheckFirstTimeHideToTray()
    {
      if (!_Module.FirstTimeToHide)
        return;
      _Module.FirstTimeToHide = false;
      _Module.CoinappNotifyIcon.ShowBalloonTip(1, "", "You can show me again here.", ToolTipIcon.Info);
    }

    private void CoinappVisibleToolStrip_Click(object sender, EventArgs e)
    {
      if (Operators.CompareString(_Module.CoinappVisibleToolStrip.Text, "Hide", false) == 0)
      {
        _Module.FormTimerIsHidden = true;
        this.Hide();
        this.label_countdown.Text = "00:00:00";
        _Module.CoinappVisibleToolStrip.Text = "Show";
        this.CheckFirstTimeHideToTray();
      }
      else
      {
        this.Show();
        _Module.FormTimerIsHidden = false;
        Rectangle rectangle = Screen.PrimaryScreen.Bounds;
        int x = checked (rectangle.Width - this.Width + 20);
        rectangle = Screen.PrimaryScreen.WorkingArea;
        int y = checked (rectangle.Height - this.Height + 15);
        this.Location = new Point(x, y);
        _Module.CoinappVisibleToolStrip.Text = "Hide";
      }
    }

    private void Me_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Right)
        return;
      _Module.CoinappContextMenuStrip.Show(System.Windows.Forms.Control.MousePosition);
    }

    private void CoinappSettingsToolStrip_Click(object sender, EventArgs e)
    {
      MyProject.Forms.Form_settings.Show();
    }

    private void CoinappLockToolStrip_Click(object sender, EventArgs e)
    {
      if (_Module.CoinappContextMenuStrip.Items.Contains((ToolStripItem) _Module.CoinappSettingsToolStrip))
        _Module.CoinappContextMenuStrip.Items.Remove((ToolStripItem) _Module.CoinappSettingsToolStrip);
      if (_Module.CoinappContextMenuStrip.Items.Contains((ToolStripItem) _Module.CoinappCounterToolStrip))
        _Module.CoinappContextMenuStrip.Items.Remove((ToolStripItem) _Module.CoinappCounterToolStrip);
      if (_Module.CoinappContextMenuStrip.Items.Contains((ToolStripItem) _Module.CoinappLockToolStrip))
        _Module.CoinappContextMenuStrip.Items.Remove((ToolStripItem) _Module.CoinappLockToolStrip);
      _Module.CoinappNotifyIcon.Icon = _Module.Image.icon();
      _Module.Desktop.IsAdmin = false;
      _Module.ApplicationStarted = true;
      if (_Module.MainSerialPort.IsOpen)
        _Module.MainSerialPort.Write("ADMIN=0");
      _Module.LockWatcher.Start();
      _Module.Desktop.Lock((IWin32Window) MyProject.Forms.Form_lock);
    }

    private void CoinappLogoutToolStrip_Click(object sender, EventArgs e)
    {
      _Module.CoinappLogoutToolStrip.Enabled = false;
      _Module.Dialog = new Form_dialog("LOGOUT SESSION", "WARNING: You will be logout and your time remaining will be cancel and cannot resume. Are you sure?", "LOGOUT", "CANCEL");
      SystemSounds.Exclamation.Play();
      int num = (int) _Module.Dialog.ShowDialog();
      if (_Module.Dialog.Result)
      {
        _Module.MainSerialPort.Write("COUNT=0");
        _Module.CreditsIsCounting = false;
        _Module.MainSerialPort.Write("CREDITS=0");
        _Module.CoinCredits = 0;
        if (_Module.Conf.SaveData)
        {
          _Module.resumeTime = false;
          _Module.Config.WriteCoin(_Module._MD5.Decrypt(_Module.Config.EncryptedReadFile(_Module._MD5.GetMd5Hash("datafolder")), "datafolder"), _Module._MD5.GetMd5Hash("remainingtime" + _Module.MyID), _Module._MD5.Encrypt("0", "remainingtime"));
        }
        _Module.logout = true;
        _Module.resumeTime = false;
        if (_Module.Notify != null && _Module.Notify.Visible)
          _Module.Notify.Close();
        if (this.Visible)
        {
          _Module.FormTimerIsHidden = true;
          this.label_countdown.Text = "00:00:00";
          this.Hide();
        }
        this.LockDelay = new BackgroundWorker();
        this.LockDelay.RunWorkerAsync((object) "logout");
      }
      _Module.Dialog.Dispose();
      _Module.CoinappLogoutToolStrip.Enabled = true;
    }

    private void CoinappCounterToolStrip_Click(object sender, EventArgs e)
    {
      _Module.CoinappCounterToolStrip.Enabled = false;
      _Module.Dialog = new Form_dialog("COIN COUNTER", "Date : " + DateTime.Now.ToString("yyyy-MM-dd") + "\r\nTime : " + DateTime.Now.ToString("hh:mm:ss tt") + "\r\nTotal coins earned : " + Conversions.ToString(_Module.TotalCoinCounter(0)), "CLEAR COINS", "CLOSE");
      if (MyProject.Forms.Form_login.Visible)
        MyProject.Forms.Form_login.Close();
      if (_Module.TotalCoinCounter(0) == 0)
        _Module.Dialog.button_yes.Enabled = false;
      else
        _Module.Dialog.Coins = true;
      int num = (int) _Module.Dialog.ShowDialog();
      _Module.CoinappCounterToolStrip.Enabled = true;
    }

    private void Me_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      if (!_Module.Initialized)
        return;
      _Module.FormTimerIsHidden = true;
      this.Hide();
      _Module.CoinappVisibleToolStrip.Text = "Show";
      this.CheckFirstTimeHideToTray();
    }

    private void NotifyIcon_MouseMove(object sender, MouseEventArgs e)
    {
      if (!_Module.Desktop.IsAdmin && !this.Visible)
      {
        if (!_Module.Initialized)
          _Module.CoinappNotifyIcon.Text = "Initializing...";
        else
          _Module.CoinappNotifyIcon.Text = _Module.GetTime(_Module.CoinCredits);
      }
      else if (_Module.Desktop.IsAdmin)
      {
        if (_Module.MainSerialPort.IsOpen)
          _Module.CoinappNotifyIcon.Text = "Administrator mode\r\n(Connected)";
        else
          _Module.CoinappNotifyIcon.Text = "Administrator mode\r\n(Disconnected)";
      }
      else
        _Module.CoinappNotifyIcon.Text = !_Module.MainSerialPort.IsOpen ? "Coinapp (Disconnected)" : "Coinapp (Connected)";
    }

    public void Logged_Event()
    {
      if (!_Module.FormTimerIsHidden)
      {
        _Module.FormTimerIsHidden = true;
        this.Hide();
      }
      if (_Module.CoinappContextMenuStrip.Items.Contains((ToolStripItem) _Module.CoinappVisibleToolStrip))
        _Module.CoinappContextMenuStrip.Items.Remove((ToolStripItem) _Module.CoinappVisibleToolStrip);
      if (_Module.CoinappContextMenuStrip.Items.Contains((ToolStripItem) _Module.CoinappLogoutToolStrip))
        _Module.CoinappContextMenuStrip.Items.Remove((ToolStripItem) _Module.CoinappLogoutToolStrip);
      if (!_Module.CoinappContextMenuStrip.Items.Contains((ToolStripItem) _Module.CoinappSettingsToolStrip))
        _Module.CoinappContextMenuStrip.Items.Add((ToolStripItem) _Module.CoinappSettingsToolStrip);
      if (_Module.Conf.SaveData && !_Module.CoinappContextMenuStrip.Items.Contains((ToolStripItem) _Module.CoinappCounterToolStrip))
        _Module.CoinappContextMenuStrip.Items.Add((ToolStripItem) _Module.CoinappCounterToolStrip);
      if (!_Module.CoinappContextMenuStrip.Items.Contains((ToolStripItem) _Module.CoinappLockToolStrip))
        _Module.CoinappContextMenuStrip.Items.Add((ToolStripItem) _Module.CoinappLockToolStrip);
      if (_Module.MainSerialPort.IsOpen)
      {
        _Module.MainSerialPort.Write("ADMIN=1");
        _Module.CoinappNotifyIcon.Icon = _Module.Image.admin();
        _Module.CoinappNotifyIcon.BalloonTipText = "Administrator mode (Connected)";
      }
      else
      {
        _Module.CoinappNotifyIcon.Icon = _Module.Image.admin_red();
        _Module.CoinappNotifyIcon.BalloonTipText = "Administrator mode (Disconnected)";
      }
      _Module.CoinappNotifyIcon.ShowBalloonTip(1);
    }

    private void CoinInserted_Event()
    {
      if (_Module.FormTimerIsHidden)
      {
        this.Show();
        _Module.FormTimerIsHidden = false;
        _Module.CoinappVisibleToolStrip.Text = "Hide";
      }
      if (!_Module.CoinappContextMenuStrip.Items.Contains((ToolStripItem) _Module.CoinappVisibleToolStrip))
        _Module.CoinappContextMenuStrip.Items.Add((ToolStripItem) _Module.CoinappVisibleToolStrip);
      if (!_Module.CoinappContextMenuStrip.Items.Contains((ToolStripItem) _Module.CoinappLogoutToolStrip))
        _Module.CoinappContextMenuStrip.Items.Add((ToolStripItem) _Module.CoinappLogoutToolStrip);
      if (_Module.CoinappContextMenuStrip.Items.Contains((ToolStripItem) _Module.CoinappSettingsToolStrip))
        _Module.CoinappContextMenuStrip.Items.Remove((ToolStripItem) _Module.CoinappSettingsToolStrip);
      if (_Module.CoinappContextMenuStrip.Items.Contains((ToolStripItem) _Module.CoinappLockToolStrip))
        _Module.CoinappContextMenuStrip.Items.Remove((ToolStripItem) _Module.CoinappLockToolStrip);
      if (!_Module.CoinappContextMenuStrip.Items.Contains((ToolStripItem) _Module.CoinappCounterToolStrip))
        return;
      _Module.CoinappContextMenuStrip.Items.Remove((ToolStripItem) _Module.CoinappCounterToolStrip);
    }

    private void ExecuteAllVariables()
    {
      _Module.CoinappNotifyIcon = new NotifyIcon();
      _Module.CoinappContextMenuStrip = new ContextMenuStrip();
      _Module.CoinappVisibleToolStrip = new ToolStripMenuItem("Hide");
      _Module.CoinappSettingsToolStrip = new ToolStripMenuItem("Setting...");
      _Module.CoinappLockToolStrip = new ToolStripMenuItem("Lock Desktop");
      _Module.CoinappLogoutToolStrip = new ToolStripMenuItem("Logout...");
      _Module.CoinappCounterToolStrip = new ToolStripMenuItem("Total coins...");
      _Module.CoinappNotifyIcon.Icon = _Module.Image.icon();
      _Module.CoinappNotifyIcon.ContextMenuStrip = _Module.CoinappContextMenuStrip;
      _Module.CoinappNotifyIcon.Visible = true;
      _Module.StartupChecker = new RegistryMonitor(RegistryHive.LocalMachine, _Module.Conf.StartupSubKey);
      _Module.CoinappVisibleToolStrip.Click += new EventHandler(this.CoinappVisibleToolStrip_Click);
      _Module.CoinappSettingsToolStrip.Click += new EventHandler(this.CoinappSettingsToolStrip_Click);
      _Module.CoinappLockToolStrip.Click += new EventHandler(this.CoinappLockToolStrip_Click);
      _Module.CoinappLogoutToolStrip.Click += new EventHandler(this.CoinappLogoutToolStrip_Click);
      _Module.CoinappCounterToolStrip.Click += new EventHandler(this.CoinappCounterToolStrip_Click);
      _Module.CoinappNotifyIcon.DoubleClick += new EventHandler(this.CoinappNotifyIcon_DoubleClick);
      _Module.CoinappNotifyIcon.MouseMove += new MouseEventHandler(this.NotifyIcon_MouseMove);
      _Module.Hotkey.KeyDown += new Hotkeys.KeyDownEventHandler(_Module.Hotkey_Keydown);
      _Module.MainSerialPort.DataReceived += new SerialDataReceivedEventHandler(_Module.MainSerialPort_DataReceived);
      if (_Module.Conf.DisconnectLock)
      {
        _Module.Device.Removed += new Board.RemovedEventHandler(this.DeviceRemoved_Event);
        _Module.DeviceConnectionWatcher.EventArrived += new EventArrivedEventHandler(this.DeviceRemoved_Event);
        _Module.DeviceConnectionWorker.DoWork += new DoWorkEventHandler(this.CheckDeviceConnection_Worker);
        _Module.DeviceConnectionWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.CheckDeviceConnection_Completed);
      }
      _Module.Desktop.Logged += new Desktop.LoggedEventHandler(this.Logged_Event);
      _Module.Desktop.CoinInserted += new Desktop.CoinInsertedEventHandler(this.CoinInserted_Event);
      _Module.SwitchTimerLock.Elapsed += new ElapsedEventHandler(_Module.SwitchTimerLock_Event);
      _Module.LockWatcher.Elapsed += new ElapsedEventHandler(_Module.LockWatcher_Event);
      _Module.StartupChecker.RegChanged += new EventHandler(this.StartupChecker_Event);
      SystemEvents.SessionEnding += new SessionEndingEventHandler(_Module.SessionEnding);
      SystemEvents.SessionSwitch += new SessionSwitchEventHandler(_Module.SessionSwitch);
      if (_Module.ConnectDevice())
      {
        this.LockDelay = new BackgroundWorker();
        this.LockDelay.RunWorkerAsync((object) "startup");
        _Module.StartupChecker.Start();
      }
      _Module.ExecuteVariables = true;
    }

    private void Worker_DoWork(object sender, DoWorkEventArgs e)
    {
      if (Operators.ConditionalCompareObjectEqual(e.Argument, (object) "CheckProcess", false))
      {
        e.Result = (object) _Module.SendMessage();
      }
      else
      {
        if (!Operators.ConditionalCompareObjectEqual(e.Argument, (object) "ConfigureDevice", false))
          return;
        _Module.ConfigureDevice();
      }
    }

    private void LockDelay_DoWork(object sender, DoWorkEventArgs e)
    {
      if (Operators.ConditionalCompareObjectEqual(e.Argument, (object) "startup", false))
      {
        this.Invoke((Delegate) new Form_timer.MyDelegate(((System.Windows.Forms.Control) this).Hide));
        _Module.FormTimerIsHidden = true;
        Thread.Sleep(3000);
        e.Result = (object) "started";
      }
      else
      {
        if (!Operators.ConditionalCompareObjectEqual(e.Argument, (object) "logout", false))
          return;
        Thread.Sleep(1000);
        e.Result = (object) "loggedout";
      }
    }

    private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      if (Operators.ConditionalCompareObjectEqual(e.Result, (object) "started", false))
      {
        this.Worker = new BackgroundWorker();
        this.Worker.RunWorkerAsync((object) "ConfigureDevice");
      }
      else
      {
        if (!Operators.ConditionalCompareObjectEqual(e.Result, (object) "loggedout", false))
          return;
        _Module.LockWatcher.Start();
        _Module.Desktop.Lock((IWin32Window) MyProject.Forms.Form_lock);
      }
    }

    private void StartupChecker_Event(object sender, EventArgs e)
    {
      if (!_Module.Conf.AtStartup)
        return;
      if (!_Module.Config.CheckStartupRegistry())
        _Module.Config.SetStartupRegValue();
      else if (!_Module.Config.CheckStartupValue())
        _Module.Config.SetStartupRegValue();
    }

    private void DeviceRemoved_Event(object sender, EventArgs e)
    {
      if (!_Module.Conf.DisconnectLock || _Module.Desktop.IsLocked || _Module.DeviceConnectionWorker.IsBusy)
        return;
      _Module.DeviceConnectionWorker.RunWorkerAsync((object) "NotLocked");
    }

    private void CheckDeviceConnection_Worker(object sender, DoWorkEventArgs e)
    {
      if (!Operators.ConditionalCompareObjectEqual(e.Argument, (object) "NotLocked", false))
        return;
      int coinCredits = _Module.CoinCredits;
      Thread.Sleep(5000);
      if (coinCredits == _Module.CoinCredits)
        e.Result = (object) "disconnect";
    }

    private void CheckDeviceConnection_Completed(object sender, RunWorkerCompletedEventArgs e)
    {
      if (!Operators.ConditionalCompareObjectEqual(e.Result, (object) "disconnect", false))
        return;
      _Module.DeviceIsError = true;
      _Module.MyID = "";
      _Module.DeviceConnectionWatcher.Stop();
      if (!_Module.LockWatcher.Enabled)
        _Module.LockWatcher.Start();
      if (!_Module.FormTimerIsHidden)
      {
        this.Invoke((Delegate) (() => this.label_countdown.Text = "00:00:00"));
        this.Invoke((Delegate) (() => this.Hide()));
        _Module.FormTimerIsHidden = true;
      }
      Form_timer.MyDelegate myDelegate;
      // ISSUE: reference to a compiler-generated field
      if (Form_timer._Closure\u0024__.\u0024I52\u002D2 != null)
      {
        // ISSUE: reference to a compiler-generated field
        myDelegate = Form_timer._Closure\u0024__.\u0024I52\u002D2;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        Form_timer._Closure\u0024__.\u0024I52\u002D2 = myDelegate = (Form_timer.MyDelegate) (() => _Module.Desktop.Lock((IWin32Window) MyProject.Forms.Form_lock));
      }
      this.Invoke((Delegate) myDelegate);
    }

    private delegate void MyDelegate();
  }
}
