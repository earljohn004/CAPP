// Decompiled with JetBrains decompiler
// Type: coinapp.form_main
// Assembly: coinapp, Version=1.4.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6DB842CC-5810-43FB-8044-475700CA1E42
// Assembly location: C:\Users\EarlJohn\Desktop\Coinapp\coinapp_1.4.0.0\coinapp.exe

using coinapp.My;
using coinapplib;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.CompilerServices;
using System.ServiceProcess;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace coinapp
{
  [DesignerGenerated]
  public class form_main : Form
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private IContainer components;
    [AccessedThroughProperty("lbl_timer")]
    private Label _lbl_timer;
    [AccessedThroughProperty("worker")]
    private BackgroundWorker _worker;
    private ToolStripMenuItem cSaveToolStrip;
    [AccessedThroughProperty("cVoucherToolStrip")]
    private ToolStripMenuItem _cVoucherToolStrip;
    [AccessedThroughProperty("cLoginToolStrip")]
    private ToolStripMenuItem _cLoginToolStrip;
    [AccessedThroughProperty("cCreateToolStrip")]
    private ToolStripMenuItem _cCreateToolStrip;

    [DebuggerNonUserCode]
    static form_main()
    {
    }

    [DebuggerNonUserCode]
    public form_main()
    {
      this.Load += new EventHandler(this.form_main_Load);
      form_main.__ENCAddToList((object) this);
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (form_main.__ENCList)
      {
        if (form_main.__ENCList.Count == form_main.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (form_main.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (form_main.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                form_main.__ENCList[index1] = form_main.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          form_main.__ENCList.RemoveRange(index1, checked (form_main.__ENCList.Count - index1));
          form_main.__ENCList.Capacity = form_main.__ENCList.Count;
        }
        form_main.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
      this.lbl_timer = new Label();
      this.SuspendLayout();
      this.lbl_timer.BackColor = Color.FromArgb(20, 20, 20);
      this.lbl_timer.BorderStyle = BorderStyle.FixedSingle;
      this.lbl_timer.Dock = DockStyle.Fill;
      this.lbl_timer.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lbl_timer.ForeColor = Color.SpringGreen;
      this.lbl_timer.Location = new Point(0, 0);
      this.lbl_timer.Name = "lbl_timer";
      Label lblTimer = this.lbl_timer;
      Size size1 = new Size(170, 25);
      Size size2 = size1;
      lblTimer.Size = size2;
      this.lbl_timer.TabIndex = 0;
      this.lbl_timer.Text = "0 0  :  0 0  :  0 0";
      this.lbl_timer.TextAlign = ContentAlignment.MiddleCenter;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(170, 25);
      this.ClientSize = size1;
      this.ControlBox = false;
      this.Controls.Add((Control) this.lbl_timer);
      this.FormBorderStyle = FormBorderStyle.None;
      this.MaximizeBox = false;
      size1 = new Size(170, 25);
      this.MaximumSize = size1;
      this.MinimizeBox = false;
      size1 = new Size(170, 25);
      this.MinimumSize = size1;
      this.Name = nameof (form_main);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.Manual;
      this.TopMost = true;
      this.ResumeLayout(false);
    }

    internal virtual Label lbl_timer
    {
      [DebuggerNonUserCode] get
      {
        return this._lbl_timer;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lbl_timer = value;
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

    private virtual ToolStripMenuItem cVoucherToolStrip
    {
      [DebuggerNonUserCode] get
      {
        return this._cVoucherToolStrip;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cVoucherToolStrip_Click);
        if (this._cVoucherToolStrip != null)
          this._cVoucherToolStrip.Click -= eventHandler;
        this._cVoucherToolStrip = value;
        if (this._cVoucherToolStrip == null)
          return;
        this._cVoucherToolStrip.Click += eventHandler;
      }
    }

    private virtual ToolStripMenuItem cLoginToolStrip
    {
      [DebuggerNonUserCode] get
      {
        return this._cLoginToolStrip;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cLoginToolStrip_Click);
        if (this._cLoginToolStrip != null)
          this._cLoginToolStrip.Click -= eventHandler;
        this._cLoginToolStrip = value;
        if (this._cLoginToolStrip == null)
          return;
        this._cLoginToolStrip.Click += eventHandler;
      }
    }

    private virtual ToolStripMenuItem cCreateToolStrip
    {
      [DebuggerNonUserCode] get
      {
        return this._cCreateToolStrip;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cCreateToolStrip_Click);
        if (this._cCreateToolStrip != null)
          this._cCreateToolStrip.Click -= eventHandler;
        this._cCreateToolStrip = value;
        if (this._cCreateToolStrip == null)
          return;
        this._cCreateToolStrip.Click += eventHandler;
      }
    }

    protected override CreateParams CreateParams
    {
      get
      {
        CreateParams createParams = base.CreateParams;
        createParams.ClassStyle |= 512;
        createParams.ExStyle = createParams.ExStyle | 128 | 8;
        return createParams;
      }
    }

    protected override void DefWndProc(ref Message m)
    {
      if (!coinappMods.desktop.IsLocked && !coinappMods.desktop.IsAdmin)
        coinappMods.hotkey.ProcessWinMessageHotkey(m.Msg, m.WParam);
      base.DefWndProc(ref m);
    }

    private void form_main_Load(object sender, EventArgs e)
    {
      this.Opacity = 0.0;
      coinappMods.desktop.mainHandle = this.Handle;
      coinappMods.desktop.mainForm = (Form) this;
      coinappMods.desktop.KeyCode = coinappMods.conf.keycode;
      int num = (int) coinappMods.powerMode.saveOff();
      coinappMods.cNotifyIcon = new NotifyIcon();
      coinappMods.cUserContextMenuStrip = new ContextMenuStrip();
      coinappMods.cAdminContextMenuStrip = new ContextMenuStrip();
      coinappMods.cVisibleToolStrip = new ToolStripMenuItem("Hide");
      coinappMods.cLogoutToolStrip = new ToolStripMenuItem("Logout");
      coinappMods.cPauseToolStrip = new ToolStripMenuItem("Pause time");
      coinappMods.cSettingsToolStrip = new ToolStripMenuItem("Settings");
      coinappMods.cTotalToolStrip = new ToolStripMenuItem("Total coins");
      coinappMods.cLockToolStrip = new ToolStripMenuItem("Lock Desktop");
      this.cSaveToolStrip = new ToolStripMenuItem("Save time");
      this.cLoginToolStrip = new ToolStripMenuItem("User account");
      this.cCreateToolStrip = new ToolStripMenuItem("Create account");
      this.cVoucherToolStrip = new ToolStripMenuItem("Use voucher");
      ToolStripItemCollection items1 = coinappMods.cUserContextMenuStrip.Items;
      items1.Add((ToolStripItem) coinappMods.cVisibleToolStrip);
      items1.Add((ToolStripItem) coinappMods.cLogoutToolStrip);
      if (coinappMods.conf.data > 0 && coinappMods.conf.voucher > 0)
        coinappMods.cUserContextMenuStrip.Items.Add((ToolStripItem) this.cVoucherToolStrip);
      ToolStripItemCollection items2 = coinappMods.cAdminContextMenuStrip.Items;
      items2.Add((ToolStripItem) coinappMods.cSettingsToolStrip);
      if (coinappMods.conf.data > 0)
        items2.Add((ToolStripItem) coinappMods.cTotalToolStrip);
      items2.Add((ToolStripItem) coinappMods.cLockToolStrip);
      coinappMods.cNotifyIcon.Icon = coinappMods.pix.icon();
      coinappMods.cNotifyIcon.Visible = true;
      coinappMods.cNotifyIcon.MouseDoubleClick += new MouseEventHandler(this.cNotifyIcon_DoubleClick);
      coinappMods.cLogoutToolStrip.Click += new EventHandler(this.cLogoutToolStrip_Click);
      coinappMods.cTotalToolStrip.Click += new EventHandler(this.cTotalToolStrip_Click);
      coinappMods.cVisibleToolStrip.Click += new EventHandler(this.cVisibleToolStrip_Click);
      coinappMods.cPauseToolStrip.Click += new EventHandler(this.cPauseToolStrip_Click);
      coinappMods.cSettingsToolStrip.Click += new EventHandler(this.cSettingsToolStrip_Click);
      coinappMods.cLockToolStrip.Click += new EventHandler(this.cLockToolStrip_Click);
      coinappMods.cNotifyIcon.MouseMove += new MouseEventHandler(this.cNotifyIcon_MouseMove);
      coinappMods.hotkey.KeyDown += new hotkey.KeyDownEventHandler(coinappMods.hotkey_Keydown);
      coinappMods.SerialComPort.DataReceived += new SerialDataReceivedEventHandler(this.SerialComPort_DataReceived);
      coinappMods.serviceWatcher.Elapsed += new ElapsedEventHandler(this.serviceWatcher_Event);
      coinappMods.desktop.userInput += new desktop.userInputEventHandler(this.userInput_Event);
      this.worker = new BackgroundWorker();
      this.worker.RunWorkerAsync((object) "start");
    }

    private void userInput_Event(int result)
    {
      if (result == 0)
      {
        coinappMods.cNotifyIcon.Icon = coinappMods.pix.icon();
        if (!coinappMods.timerVisible)
        {
          this.Opacity = 100.0;
          coinappMods.timerVisible = true;
        }
        switch (coinappMods.CREDITSTYPE)
        {
          case 0:
            coinappMods.cNotifyIcon.BalloonTipText = "Welcome Guest";
            break;
          case 1:
            coinappMods.cNotifyIcon.BalloonTipText = "Coupon voucher used";
            break;
          case 2:
            coinappMods.cNotifyIcon.BalloonTipText = "Hello " + coinappMods.userAccount + "!";
            ToolStripItemCollection items = coinappMods.cUserContextMenuStrip.Items;
            if (items.Contains((ToolStripItem) coinappMods.cPauseToolStrip))
              items.Remove((ToolStripItem) coinappMods.cPauseToolStrip);
            if (items.Contains((ToolStripItem) this.cSaveToolStrip))
              items.Remove((ToolStripItem) this.cSaveToolStrip);
            if (coinappMods.conf.voucher > 0 && !items.Contains((ToolStripItem) this.cVoucherToolStrip))
              items.Add((ToolStripItem) this.cVoucherToolStrip);
            goto default;
          default:
label_23:
            coinappMods.cNotifyIcon.ContextMenuStrip = coinappMods.cUserContextMenuStrip;
            coinappMods.cNotifyIcon.ShowBalloonTip(1);
            return;
        }
        if (coinappMods.conf.account > 0 && !coinappMods.cUserContextMenuStrip.Items.Contains((ToolStripItem) this.cSaveToolStrip))
        {
          coinappMods.cUserContextMenuStrip.Items.Add((ToolStripItem) this.cSaveToolStrip);
          ToolStripItemCollection dropDownItems = this.cSaveToolStrip.DropDownItems;
          if (!dropDownItems.Contains((ToolStripItem) this.cLoginToolStrip))
            dropDownItems.Add((ToolStripItem) this.cLoginToolStrip);
          if (!dropDownItems.Contains((ToolStripItem) this.cCreateToolStrip))
            dropDownItems.Add((ToolStripItem) this.cCreateToolStrip);
        }
        if (coinappMods.oPause > 0 && coinappMods.conf.pause > 0)
        {
          coinappMods.cPauseToolStrip.Text = "Pause time (" + Conversions.ToString(coinappMods.oPause) + ")";
          if (!coinappMods.cUserContextMenuStrip.Items.Contains((ToolStripItem) coinappMods.cPauseToolStrip))
            coinappMods.cUserContextMenuStrip.Items.Add((ToolStripItem) coinappMods.cPauseToolStrip);
          goto label_23;
        }
        else
          goto label_23;
      }
      else
      {
        if (coinappMods.timerVisible)
        {
          this.Opacity = 0.0;
          coinappMods.timerVisible = false;
        }
        if (coinappMods.SerialComPort.IsOpen && coinappMods.deviceIsReady)
        {
          coinappMods.SerialComPort.Write("ADMIN=1");
          coinappMods.cNotifyIcon.Icon = coinappMods.pix.admin_red();
          switch (coinappMods.LOCKCODE)
          {
            case 0:
              coinappMods.cNotifyIcon.Icon = coinappMods.pix.admin();
              coinappMods.cNotifyIcon.BalloonTipText = "Admin mode (Connected)";
              break;
            case 1:
              coinappMods.cNotifyIcon.BalloonTipText = "DEVICE ERROR";
              break;
            case 2:
              coinappMods.cNotifyIcon.BalloonTipText = "APPLICATION ERROR";
              break;
            default:
              coinappMods.cNotifyIcon.BalloonTipText = "Device initializing...";
              break;
          }
        }
        else
        {
          coinappMods.cNotifyIcon.Icon = coinappMods.pix.admin_red();
          switch (coinappMods.LOCKCODE)
          {
            case 0:
              coinappMods.LOCKCODE = 1;
              coinappMods.ERR_DEVICE = 2;
              coinappMods.cNotifyIcon.BalloonTipText = "No device connected";
              break;
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
                  coinappMods.cNotifyIcon.BalloonTipText = "No additional startup arguments";
                  break;
                case 5:
                  coinappMods.cNotifyIcon.BalloonTipText = "Invalid startup arguments";
                  break;
                case 6:
                  coinappMods.cNotifyIcon.BalloonTipText = "Invalid process id";
                  break;
                default:
                  coinappMods.cNotifyIcon.BalloonTipText = "APPLICATION ERROR";
                  break;
              }
            default:
              coinappMods.cNotifyIcon.BalloonTipText = "Admin mode (Disconnected)";
              break;
          }
        }
        coinappMods.cNotifyIcon.ContextMenuStrip = coinappMods.cAdminContextMenuStrip;
        coinappMods.cNotifyIcon.ShowBalloonTip(1);
      }
    }

    private void worker_DoWork(object sender, DoWorkEventArgs e)
    {
      string Left = Conversions.ToString(e.Argument);
      if (Operators.CompareString(Left, "lock", false) == 0)
      {
        Thread.Sleep(500);
        this.BeginInvoke((Delegate) (() => coinappMods.desktop.Lock((IWin32Window) MyProject.Forms.form_lock)));
      }
      else
      {
        bool flag;
        if (Operators.CompareString(Left, "start", false) == 0)
        {
          if (coinappMods.LOCKCODE == -1)
          {
            coinappMods.serviceMonitor = new Thread(new ThreadStart(this.MonitorService));
            coinappMods.serviceMonitor.Start();
            Thread.Sleep(3000);
            this.BeginInvoke((Delegate) (() => this.Location = new Point(checked (Screen.PrimaryScreen.WorkingArea.Width - this.Width), checked (Screen.PrimaryScreen.WorkingArea.Height - this.Height))));
            this.BeginInvoke((Delegate) (() => coinappMods.desktop.Lock((IWin32Window) MyProject.Forms.form_lock)));
            flag = this.InitializeDevice();
          }
          else
            this.BeginInvoke((Delegate) (() => coinappMods.desktop.Lock((IWin32Window) MyProject.Forms.form_lock)));
        }
        if (coinappMods.desktop.IsLocked && !flag)
          coinappMods.desktop.lockForm.BeginInvoke((Delegate) (() => ((form_lock) coinappMods.desktop.lockForm).startup(coinappMods.LOCKCODE)));
      }
    }

    private void cNotifyIcon_DoubleClick(object sender, MouseEventArgs e)
    {
      if (!coinappMods.deviceIsReady || coinappMods.desktop.IsAdmin || e.Button != MouseButtons.Left)
        return;
      if (coinappMods.timerVisible)
      {
        this.Opacity = 0.0;
        coinappMods.timerVisible = false;
        coinappMods.cVisibleToolStrip.Text = "Show";
      }
      else
      {
        this.Opacity = 100.0;
        coinappMods.pos.top(this.Handle);
        coinappMods.timerVisible = true;
        coinappMods.cVisibleToolStrip.Text = "Hide";
      }
    }

    private void cVisibleToolStrip_Click(object sender, EventArgs e)
    {
      if (coinappMods.desktop.IsAdmin)
        return;
      if (coinappMods.timerVisible)
      {
        this.Opacity = 0.0;
        coinappMods.timerVisible = false;
        coinappMods.cVisibleToolStrip.Text = "Show";
      }
      else
      {
        this.Opacity = 100.0;
        coinappMods.timerVisible = true;
        coinappMods.cVisibleToolStrip.Text = "Hide";
      }
    }

    private void cSettingsToolStrip_Click(object sender, EventArgs e)
    {
      if (!coinappMods.desktop.IsAdmin)
        return;
      MyProject.Forms.form_config.Show();
    }

    private void cTotalToolStrip_Click(object sender, EventArgs e)
    {
      if (!coinappMods.desktop.IsAdmin)
        return;
      coinappMods.cTotalToolStrip.Enabled = false;
      if (MyProject.Forms.form_dialog.Visible)
        MyProject.Forms.form_dialog.Close();
      int num = (int) MyProject.Forms.form_dialog.Show(this.totalCoins(0) > 0 ? "There are " + Conversions.ToString(this.totalCoins(0)) + " total coin(s) earned.\r\n\r\nTo clear the saved coins, disable the save data on the program settings." : "There are no total coins earned yet or the coins has been cleared/moved/deleted.", "Total coins", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      coinappMods.cTotalToolStrip.Enabled = true;
    }

    private void cLockToolStrip_Click(object sender, EventArgs e)
    {
      if (!coinappMods.desktop.IsAdmin)
        return;
      coinappMods.desktop.IsAdmin = false;
      if (coinappMods.SerialComPort.IsOpen)
        coinappMods.SerialComPort.Write("ADMIN=0");
      this.worker = new BackgroundWorker();
      this.worker.RunWorkerAsync((object) "lock");
    }

    private void cLogoutToolStrip_Click(object sender, EventArgs e)
    {
      if (coinappMods.desktop.IsLocked)
        return;
      coinappMods.cLogoutToolStrip.Enabled = false;
      if (MyProject.Forms.form_dialog.Visible)
        MyProject.Forms.form_dialog.Close();
      int creditstype1 = coinappMods.CREDITSTYPE;
      DialogResult dialogResult;
      if (creditstype1 < 2)
        dialogResult = MyProject.Forms.form_dialog.Show("WARNING: You will be LOGOUT and your remaining time will be cancel and cannot resume. Are you really sure?", "Coinapp logout", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
      else if (creditstype1 == 2)
        dialogResult = MyProject.Forms.form_dialog.Show("Do you want to logout your account and lock the PC? Remaining time will be saved on your account", "Coinapp logout", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
      if (dialogResult == DialogResult.OK)
      {
        coinappMods.credits = 0;
        coinappMods.LOCKCODE = 4;
        coinappMods.CREDITSTYPE = 0;
        this.lbl_timer.Text = "0 0  :  0 0  :  0 0";
        if (coinappMods.timerVisible)
        {
          coinappMods.timerVisible = false;
          this.Opacity = 0.0;
        }
        if (coinappMods.SerialComPort.IsOpen)
        {
          coinappMods.SerialComPort.Write("COUNT=0");
          coinappMods.SerialComPort.Write("CREDITS=0");
        }
        if (coinappMods.conf.data > 0)
        {
          int creditstype2 = coinappMods.CREDITSTYPE;
          if (creditstype2 < 2)
            coinappMods.settings.writeCoin(coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("data")), "data"), coinappMods.enc.GetMd5Hash("time" + coinappMods.sID), coinappMods.enc.Encrypt("0", "time"));
          else if (creditstype2 == 2 && coinappMods.conf.account > 0)
          {
            coinappMods.userAccount = "";
            if (coinappMods.account != null)
              coinappMods.account.close();
          }
        }
        this.worker = new BackgroundWorker();
        this.worker.RunWorkerAsync((object) "lock");
      }
      coinappMods.cLogoutToolStrip.Enabled = true;
    }

    private void cPauseToolStrip_Click(object sender, EventArgs e)
    {
      if (coinappMods.desktop.IsAdmin || coinappMods.CREDITSTYPE >= 2)
        return;
      coinappMods.cPauseToolStrip.Enabled = false;
      if (MyProject.Forms.form_dialog.Visible)
        MyProject.Forms.form_dialog.Close();
      if (MyProject.Forms.form_dialog.Show("Do you want to PAUSE your remaining time and lock the PC?", "Coinapp pause time", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
      {
        if (coinappMods.SerialComPort.IsOpen)
          coinappMods.SerialComPort.Write("COUNT=0");
        coinappMods.LOCKCODE = 5;
        if (coinappMods.conf.pause > 0 && coinappMods.oPause > 0)
        {
          checked { --coinappMods.oPause; }
          if (coinappMods.oPause <= 0)
          {
            if (coinappMods.cUserContextMenuStrip.Items.Contains((ToolStripItem) coinappMods.cPauseToolStrip))
              coinappMods.cUserContextMenuStrip.Items.Remove((ToolStripItem) coinappMods.cPauseToolStrip);
          }
          else
            coinappMods.cPauseToolStrip.Text = "Pause time (" + Conversions.ToString(coinappMods.oPause) + ")";
        }
        this.lbl_timer.Text = "0 0  :  0 0  :  0 0";
        if (coinappMods.timerVisible)
        {
          coinappMods.timerVisible = false;
          this.Opacity = 0.0;
        }
        this.worker = new BackgroundWorker();
        this.worker.RunWorkerAsync((object) "lock");
      }
      coinappMods.cPauseToolStrip.Enabled = true;
    }

    private void cNotifyIcon_MouseMove(object sender, MouseEventArgs e)
    {
      if (coinappMods.desktop.IsAdmin)
      {
        if (coinappMods.SerialComPort.IsOpen)
        {
          coinappMods.cNotifyIcon.Text = "Admin mode (connected)";
        }
        else
        {
          switch (coinappMods.LOCKCODE)
          {
            case 1:
              switch (coinappMods.ERR_DEVICE)
              {
                case 1:
                  coinappMods.cNotifyIcon.Text = "Error retrieving device information";
                  break;
                case 2:
                  coinappMods.cNotifyIcon.Text = "No device connected";
                  break;
                case 3:
                  coinappMods.cNotifyIcon.Text = "Cannot open port/Access denied";
                  break;
                case 4:
                  coinappMods.cNotifyIcon.Text = "The port detected not opened";
                  break;
                case 5:
                  coinappMods.cNotifyIcon.Text = "Device is not compatible";
                  break;
                case 6:
                  coinappMods.cNotifyIcon.Text = "Cannot close the opened port";
                  break;
                default:
                  coinappMods.cNotifyIcon.Text = "DEVICE ERROR";
                  break;
              }
            case 2:
              switch (coinappMods.ERR_APPS)
              {
                case 1:
                  coinappMods.cNotifyIcon.Text = "Coinapp process terminated";
                  break;
                case 2:
                  coinappMods.cNotifyIcon.Text = "Service process terminated";
                  break;
                case 3:
                  coinappMods.cNotifyIcon.Text = "Service process stopped";
                  break;
                case 4:
                  coinappMods.cNotifyIcon.Text = "Service process terminated 3 times";
                  break;
                case 5:
                  coinappMods.cNotifyIcon.Text = "Invalid startup arguments";
                  break;
                case 6:
                  coinappMods.cNotifyIcon.Text = "Invalid process id";
                  break;
                default:
                  coinappMods.cNotifyIcon.Text = "APPLICATION ERROR";
                  break;
              }
            default:
              coinappMods.cNotifyIcon.Text = "Admin mode (disconnected)";
              break;
          }
        }
      }
      else if (coinappMods.SerialComPort.IsOpen)
      {
        switch (coinappMods.CREDITSTYPE)
        {
          case 0:
            coinappMods.cNotifyIcon.Text = "Guest logged";
            break;
          case 1:
            coinappMods.cNotifyIcon.Text = "Coupon voucher used";
            break;
          case 2:
            coinappMods.cNotifyIcon.Text = "Account logged (" + coinappMods.userAccount + ")";
            break;
        }
      }
    }

    private bool InitializeDevice()
    {
      string str;
      bool flag;
      try
      {
        str = coinappMods.device.Port();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        coinappMods.LOCKCODE = 1;
        coinappMods.ERR_DEVICE = 1;
        flag = false;
        ProjectData.ClearProjectError();
        goto label_17;
      }
      if (Operators.CompareString(str, (string) null, false) != 0)
      {
        if (Operators.CompareString(str, coinappMods.conf.port, false) != 0)
          coinappMods.settings.setPort(str);
        try
        {
          coinappMods.SerialComPort.BaudRate = coinappMods.conf.baud;
          coinappMods.SerialComPort.PortName = str;
          coinappMods.SerialComPort.DtrEnable = true;
          coinappMods.SerialComPort.Open();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          coinappMods.LOCKCODE = 1;
          coinappMods.ERR_DEVICE = 3;
          flag = false;
          ProjectData.ClearProjectError();
          goto label_17;
        }
        if (coinappMods.SerialComPort.IsOpen)
        {
          Thread.Sleep(3000);
          coinappMods.SerialComPort.Write("REQDEVID;");
          Thread.Sleep(1000);
          coinappMods.LOCKCODE = 0;
          if (coinappMods.desktop.IsLocked)
            flag = false;
          else if (!coinappMods.deviceIsReady)
          {
            coinappMods.LOCKCODE = 1;
            coinappMods.ERR_DEVICE = 5;
            coinappMods.sID = (string) null;
            this.BeginInvoke((Delegate) (() => coinappMods.cNotifyIcon.Icon = coinappMods.pix.admin_red()));
            this.BeginInvoke((Delegate) (() => coinappMods.cNotifyIcon.BalloonTipText = "Device is not compatible"));
            this.BeginInvoke((Delegate) (() => coinappMods.cNotifyIcon.ShowBalloonTip(1)));
            flag = true;
          }
          else
          {
            coinappMods.SerialComPort.Write("ADMIN=1");
            this.BeginInvoke((Delegate) (() => coinappMods.cNotifyIcon.Icon = coinappMods.pix.admin()));
            this.BeginInvoke((Delegate) (() => coinappMods.cNotifyIcon.BalloonTipText = "Device connected successfully!"));
            this.BeginInvoke((Delegate) (() => coinappMods.cNotifyIcon.ShowBalloonTip(1)));
            flag = true;
          }
        }
        else
        {
          coinappMods.LOCKCODE = 1;
          coinappMods.ERR_DEVICE = 4;
          flag = false;
        }
      }
      else
      {
        coinappMods.LOCKCODE = 1;
        coinappMods.ERR_DEVICE = 2;
        flag = false;
      }
label_17:
      return flag;
    }

    private void SerialComPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
      string str = coinappMods.SerialComPort.ReadTo(",");

	  // DEVICE READY CONDITION
      if (coinappMods.deviceIsReady)
      {
		// First Condition COIN TYPE
        if (Operators.CompareString(str, "COIN1", false) == 0 || Operators.CompareString(str, "COIN2", false) == 0 || Operators.CompareString(str, "COIN3", false) == 0)
        {
          if (!coinappMods.CHARGE)
          {
            this.saveCoins(str);
            coinappMods.SerialComPort.Write("COUNT=1");
            if (!coinappMods.timerVisible)
            {
              coinappMods.desktop.mainForm.BeginInvoke((Delegate) (() => this.Opacity = 100.0));
              coinappMods.timerVisible = true;
            }
            coinappMods.pos.top(this.Handle);
          }
          else
          {
            string Left = str;
            if (Operators.CompareString(Left, "COIN1", false) == 0)
            {
              checked { ++coinappMods.coin; }
              checked { coinappMods.coinCredits += coinappMods.conf.coin1; }
              checked { coinappMods.credits += coinappMods.conf.coin1; }
            }
            else if (Operators.CompareString(Left, "COIN2", false) == 0)
            {
              checked { coinappMods.coin += 5; }
              checked { coinappMods.coinCredits += coinappMods.conf.coin2; }
              checked { coinappMods.credits += coinappMods.conf.coin2; }
            }
            else if (Operators.CompareString(Left, "COIN3", false) == 0)
            {
              checked { coinappMods.coin += 10; }
              checked { coinappMods.coinCredits += coinappMods.conf.coin3; }
              checked { coinappMods.credits += coinappMods.conf.coin3; }
            }
            try
            {
              coinappMods.aCommand.CommandText = "UPDATE users SET [Credits]='" + Conversions.ToString(coinappMods.credits) + "' WHERE [Username]='" + coinappMods.userAccount + "'";
              coinappMods.aCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              coinappMods.desktop.lockForm.BeginInvoke((Delegate) (() => MyProject.Forms.form_dialog.lbl_message.Text = "Something went wrong while charging the account. Cannot continue"));
              ProjectData.ClearProjectError();
            }
            int num1 = coinappMods.credits % 60;
            int num2 = checked ((int) Math.Round(unchecked ((double) checked (coinappMods.credits - num1) / 60.0 % 60.0)));
            int num3 = checked ((int) Math.Round(unchecked ((double) checked (coinappMods.credits - num1 + num2 * 60) / 3600.0 % 60.0)));
            int num4 = coinappMods.coinCredits % 60;
            int num5 = checked ((int) Math.Round(unchecked ((double) checked (coinappMods.coinCredits - num4) / 60.0 % 60.0)));
            int num6 = checked ((int) Math.Round(unchecked ((double) checked (coinappMods.coinCredits - num4 + num5 * 60) / 3600.0 % 60.0)));
            coinappMods.desktop.lockForm.BeginInvoke((Delegate) (() => MyProject.Forms.form_dialog.lbl_message.Text = "Insert a coin to charge the '" + coinappMods.userAccount + "' user account.\r\n---User account credits: " + (coinappMods.credits > 0 ? (num3 > 0 ? Conversions.ToString(num3) + " " + (num3 == 1 ? "hour " : "hours ") : "") + (num2 > 0 ? Conversions.ToString(num2) + " " + (num2 == 1 ? "minute " : "minutes ") : "") + (num1 > 0 ? Conversions.ToString(num1) + " " + (num1 == 1 ? "second" : "seconds") : "") : "(No time credits)") + "\r\n---Coin inserted: " + Conversions.ToString(coinappMods.coin) + "\r\n---Time added: " + (coinappMods.coinCredits > 0 ? (num6 > 0 ? Conversions.ToString(num6) + " " + (num6 == 1 ? "hour " : "hours ") : "") + (num5 > 0 ? Conversions.ToString(num5) + " " + (num5 == 1 ? "minute " : "minutes ") : "") + (num4 > 0 ? Conversions.ToString(num4) + " " + (num4 == 1 ? "second" : "seconds") : "") : "(No time added)") + "\r\nClick OK when done."));
          }
        } //END OF COIN TYPE 


		//SECOND CONDITION ABOUT TIME
        if (Operators.CompareString(str, "TIME", false) == 0)
        {
          coinappMods.credits = 0;
          coinappMods.LOCKCODE = 3;
          coinappMods.CREDITSTYPE = 0;
          this.BeginInvoke((Delegate) (() => MyProject.Forms.form_dialog.Close()));
          coinappMods.cLogoutToolStrip.Enabled = true;
          coinappMods.cPauseToolStrip.Enabled = true;
          coinappMods.desktop.mainForm.BeginInvoke((Delegate) (() => coinappMods.desktop.Lock((IWin32Window) MyProject.Forms.form_lock)));
        } else {

          string s = str;
          int num = 0;
          ref int local = ref num;
          if (int.TryParse(s, out local))
          {
            coinappMods.credits = Conversions.ToInteger(str);
            if (coinappMods.conf.data > 0)
            {
              int creditstype = coinappMods.CREDITSTYPE;
              if (creditstype < 2)
                coinappMods.settings.writeCoin(coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("data")), "data"), coinappMods.enc.GetMd5Hash("time" + coinappMods.sID), coinappMods.enc.Encrypt(Conversions.ToString(coinappMods.credits), "time"));
              else if (creditstype == 2)
              {
                if (coinappMods.conf.account > 0)
                {
                  try
                  {
                    coinappMods.aCommand.CommandText = "UPDATE users SET [Credits]='" + Conversions.ToString(coinappMods.credits) + "' WHERE [Username]='" + coinappMods.userAccount + "'";
                    coinappMods.aCommand.ExecuteNonQuery();
                  }
                  catch (Exception ex)
                  {
                    ProjectData.SetProjectError(ex);
                    ProjectData.ClearProjectError();
                  }
                }
              }
            }
            if (coinappMods.desktop.IsLocked)
              coinappMods.desktop.lockForm.BeginInvoke((Delegate) (() => coinappMods.desktop.Unlock()));
            coinappMods.desktop.mainForm.BeginInvoke((Delegate) (() => this.lbl_timer.Text = coinappMods.getTime(coinappMods.credits)));
          }
        } // END OF SECOND CONDITION about TIME


		// 3RD CONDITION
        if (Operators.CompareString(str, "MULTI", false) == 0)
        {
          coinappMods.SerialComPort.Write("COIN1=" + Conversions.ToString(coinappMods.conf.coin1));
          coinappMods.SerialComPort.Write("COIN2=" + Conversions.ToString(coinappMods.conf.coin2));
          coinappMods.SerialComPort.Write("COIN3=" + Conversions.ToString(coinappMods.conf.coin3));
          coinappMods.SerialComPort.Write("PULSE1=" + Conversions.ToString(coinappMods.conf.pulse1));
          coinappMods.SerialComPort.Write("PULSE2=" + Conversions.ToString(coinappMods.conf.pulse2));
          coinappMods.SerialComPort.Write("PULSE3=" + Conversions.ToString(coinappMods.conf.pulse3));
        }
        else if (Operators.CompareString(str, "DUAL", false) == 0)
        {
          coinappMods.SerialComPort.Write("COIN1=" + Conversions.ToString(coinappMods.conf.coin1));
          coinappMods.SerialComPort.Write("PULSE1=" + Conversions.ToString(coinappMods.conf.pulse1));
          coinappMods.SerialComPort.Write("COIN2=" + Conversions.ToString(coinappMods.conf.coin2));
          coinappMods.SerialComPort.Write("PULSE2=" + Conversions.ToString(coinappMods.conf.pulse2));
        }
        else if (Operators.CompareString(str, "SINGLE", false) == 0)
        {
          coinappMods.SerialComPort.Write("COIN1=" + Conversions.ToString(coinappMods.conf.coin1));
          coinappMods.SerialComPort.Write("PULSE1=" + Conversions.ToString(coinappMods.conf.pulse1));
        }

		// 4TH CONDITION
        if (Operators.CompareString(str, "DEVID", false) == 0)
          coinappMods.deviceid = coinappMods.SerialComPort.ReadTo(",");
        if (Operators.CompareString(str, "FIRMVER", false) == 0)
          coinappMods.devicefw = coinappMods.SerialComPort.ReadTo(",");
        if (Operators.CompareString(str, "FIRMDATE", false) != 0)
          return;
        coinappMods.devicedate = coinappMods.SerialComPort.ReadTo(",");
      } //END OF DEVICE READY CONDITION = TRUE
	  
	  // ELSE CONDITION DEVICE READY CONDITION = FALSE
      else
      {
        if (Operators.CompareString(str, "READY", false) == 0)
        {
          coinappMods.deviceIsReady = true;
          coinappMods.SerialComPort.Write("COINSLOT=" + Conversions.ToString(coinappMods.conf.acceptor));
          this.checkRemainingTime();
        }
        if (Operators.CompareString(str, "REQDEVID", false) == 0)
        {
          coinappMods.sID = coinappMods.SerialComPort.ReadTo(",");
          if (coinappMods.isValidID(coinappMods.sID))
            coinappMods.SerialComPort.Write(coinappMods.sID + ";");
          else
            coinappMods.sID = (string) null;
        }
      }


    }

    private void saveCoins(string insertedCoin)
    {
      if (coinappMods.conf.data <= 0)
        return;
      string Left = insertedCoin;
      if (Operators.CompareString(Left, "COIN1", false) == 0)
        coinappMods.settings.writeCoin(coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("data")), "data"), coinappMods.enc.GetMd5Hash("coin" + coinappMods.sID), coinappMods.enc.Encrypt(Conversions.ToString(this.totalCoins(1)), "coin"));
      else if (Operators.CompareString(Left, "COIN2", false) == 0)
        coinappMods.settings.writeCoin(coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("data")), "data"), coinappMods.enc.GetMd5Hash("coin" + coinappMods.sID), coinappMods.enc.Encrypt(Conversions.ToString(this.totalCoins(5)), "coin"));
      else if (Operators.CompareString(Left, "COIN3", false) == 0)
        coinappMods.settings.writeCoin(coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("data")), "data"), coinappMods.enc.GetMd5Hash("coin" + coinappMods.sID), coinappMods.enc.Encrypt(Conversions.ToString(this.totalCoins(10)), "coin"));
    }

    private int totalCoins(int addCoin = 0)
    {
      int num;
      try
      {
        num = Conversions.ToInteger(coinappMods.enc.Decrypt(coinappMods.settings.readEncCoin(coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("data")), "data"), coinappMods.enc.GetMd5Hash("coin" + coinappMods.sID)), "coin"));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        num = 0;
        ProjectData.ClearProjectError();
      }
      return checked (addCoin + num);
    }

    private void checkRemainingTime()
    {
      if (coinappMods.conf.data <= 0)
        return;
      int num;
      try
      {
        num = Conversions.ToInteger(coinappMods.enc.Decrypt(coinappMods.settings.readEncCoin(coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("data")), "data"), coinappMods.enc.GetMd5Hash("time" + coinappMods.sID)), "time"));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        num = 0;
        ProjectData.ClearProjectError();
      }
      coinappMods.credits = num;
    }

    private void MonitorService()
    {
      coinappMods.serviceWatcher.Start();
      coinappMods.svccaProc.WaitForExit();
      coinappMods.serviceWatcher.Stop();
      coinappMods.deviceIsReady = false;
      coinappMods.credits = 0;
      coinappMods.LOCKCODE = 2;
      coinappMods.ERR_APPS = 2;
      coinappMods.sID = (string) null;
      if (coinappMods.SerialComPort.IsOpen)
      {
        coinappMods.SerialComPort.Write("DISC;");
        coinappMods.SerialComPort.Close();
      }
      this.BeginInvoke((Delegate) (() => this.lbl_timer.Text = "0 0  :  0 0  :  0 0"));
      this.BeginInvoke((Delegate) (() => this.Opacity = 0.0));
      if (coinappMods.desktop.IsLocked)
        return;
      coinappMods.desktop.mainForm.BeginInvoke((Delegate) (() => coinappMods.desktop.Lock((IWin32Window) MyProject.Forms.form_lock)));
    }

    private void serviceWatcher_Event(object sender, ElapsedEventArgs e)
    {
      if (((IEnumerable<ServiceController>) ServiceController.GetServices()).Any<ServiceController>((Func<ServiceController, bool>) (x => Operators.CompareString(x.ServiceName, "svcca", false) == 0)))
      {
        using (ServiceController serviceController = new ServiceController("svcca"))
        {
          if (serviceController.Status != ServiceControllerStatus.Stopped)
            return;
          coinappMods.serviceWatcher.Stop();
          if (coinappMods.serviceMonitor.IsAlive)
            coinappMods.serviceMonitor.Abort();
          coinappMods.deviceIsReady = false;
          coinappMods.credits = 0;
          coinappMods.LOCKCODE = 2;
          coinappMods.ERR_APPS = 3;
          coinappMods.sID = (string) null;
          if (coinappMods.SerialComPort.IsOpen)
          {
            coinappMods.SerialComPort.Write("DISC;");
            coinappMods.SerialComPort.Close();
          }
          this.BeginInvoke((Delegate) (() => this.lbl_timer.Text = "0 0  :  0 0  :  0 0"));
          this.BeginInvoke((Delegate) (() => this.Opacity = 0.0));
          if (!coinappMods.desktop.IsLocked)
            coinappMods.desktop.mainForm.BeginInvoke((Delegate) (() => coinappMods.desktop.Lock((IWin32Window) MyProject.Forms.form_lock)));
        }
      }
      else
      {
        coinappMods.serviceWatcher.Stop();
        if (coinappMods.serviceMonitor.IsAlive)
          coinappMods.serviceMonitor.Abort();
        coinappMods.deviceIsReady = false;
        coinappMods.credits = 0;
        coinappMods.LOCKCODE = 2;
        coinappMods.ERR_APPS = 4;
        coinappMods.sID = (string) null;
        if (coinappMods.SerialComPort.IsOpen)
        {
          coinappMods.SerialComPort.Write("DISC;");
          coinappMods.SerialComPort.Close();
        }
        this.BeginInvoke((Delegate) (() => this.lbl_timer.Text = "0 0  :  0 0  :  0 0"));
        this.BeginInvoke((Delegate) (() => this.Opacity = 0.0));
        if (!coinappMods.desktop.IsLocked)
          coinappMods.desktop.mainForm.BeginInvoke((Delegate) (() => coinappMods.desktop.Lock((IWin32Window) MyProject.Forms.form_lock)));
      }
    }

    private void cLoginToolStrip_Click(object sender, EventArgs e)
    {
      MyProject.Forms.form_use_account.Text = "Save time to user account";
      MyProject.Forms.form_use_account.Show();
    }

    private void cVoucherToolStrip_Click(object sender, EventArgs e)
    {
      MyProject.Forms.form_use_voucher.Text = "Add time from coupon voucher";
      MyProject.Forms.form_use_voucher.Show();
    }

    private void cCreateToolStrip_Click(object sender, EventArgs e)
    {
      MyProject.Forms.form_account_create.Text = "Save time to NEW user account";
      MyProject.Forms.form_account_create.Show();
    }

    private delegate void MyDelegate();
  }
}
