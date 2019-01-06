// Decompiled with JetBrains decompiler
// Type: Coinapp.Form_notify
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
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Coinapp
{
  [DesignerGenerated]
  public class Form_notify : Form
  {
    private IContainer components;
    private double fade;
    private int timetoshow;
    private int myX;
    private int myY;

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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form_notify));
      this.label_messages = new Label();
      this.picturebox_icon = new PictureBox();
      this.ShowTimer = new Timer(this.components);
      this.WaitToClose = new Timer(this.components);
      this.FadeToClose = new Timer(this.components);
      this.TableLayoutPanel1 = new TableLayoutPanel();
      ((ISupportInitialize) this.picturebox_icon).BeginInit();
      this.TableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      this.label_messages.BackColor = Color.Transparent;
      this.label_messages.Dock = DockStyle.Fill;
      this.label_messages.Font = new Font("Century Gothic", 8.25f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.label_messages.ForeColor = SystemColors.ControlText;
      this.label_messages.Location = new Point(53, 0);
      this.label_messages.Margin = new Padding(0);
      this.label_messages.Name = "label_messages";
      this.label_messages.RightToLeft = RightToLeft.No;
      this.label_messages.Size = new Size(147, 55);
      this.label_messages.TabIndex = 0;
      this.label_messages.Text = "1 Peso coin inserted.\r\n4 minutes time added";
      this.label_messages.TextAlign = ContentAlignment.MiddleLeft;
      this.picturebox_icon.BackColor = Color.Transparent;
      this.picturebox_icon.BackgroundImageLayout = ImageLayout.Zoom;
      this.picturebox_icon.Dock = DockStyle.Fill;
      this.picturebox_icon.Image = (Image) componentResourceManager.GetObject("picturebox_icon.Image");
      this.picturebox_icon.Location = new Point(3, 3);
      this.picturebox_icon.Name = "picturebox_icon";
      this.picturebox_icon.Size = new Size(47, 49);
      this.picturebox_icon.SizeMode = PictureBoxSizeMode.Zoom;
      this.picturebox_icon.TabIndex = 4;
      this.picturebox_icon.TabStop = false;
      this.ShowTimer.Interval = 10;
      this.WaitToClose.Interval = 1000;
      this.FadeToClose.Interval = 10;
      this.TableLayoutPanel1.ColumnCount = 2;
      this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 53f));
      this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
      this.TableLayoutPanel1.Controls.Add((Control) this.picturebox_icon, 0, 0);
      this.TableLayoutPanel1.Controls.Add((Control) this.label_messages, 1, 0);
      this.TableLayoutPanel1.Dock = DockStyle.Fill;
      this.TableLayoutPanel1.Location = new Point(0, 0);
      this.TableLayoutPanel1.Name = "TableLayoutPanel1";
      this.TableLayoutPanel1.RowCount = 1;
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
      this.TableLayoutPanel1.Size = new Size(200, 55);
      this.TableLayoutPanel1.TabIndex = 5;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(200, 55);
      this.ControlBox = false;
      this.Controls.Add((Control) this.TableLayoutPanel1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.MaximizeBox = false;
      this.MaximumSize = new Size(200, 55);
      this.MinimizeBox = false;
      this.MinimumSize = new Size(200, 55);
      this.Name = nameof (Form_notify);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.Manual;
      this.Text = nameof (Form_notify);
      this.TopMost = true;
      ((ISupportInitialize) this.picturebox_icon).EndInit();
      this.TableLayoutPanel1.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    internal virtual Label label_messages
    {
      get
      {
        return this._label_messages;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.Me_MouseClick);
        Label labelMessages1 = this._label_messages;
        if (labelMessages1 != null)
          labelMessages1.MouseClick -= mouseEventHandler;
        this._label_messages = value;
        Label labelMessages2 = this._label_messages;
        if (labelMessages2 == null)
          return;
        labelMessages2.MouseClick += mouseEventHandler;
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
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.Me_MouseClick);
        PictureBox pictureboxIcon1 = this._picturebox_icon;
        if (pictureboxIcon1 != null)
          pictureboxIcon1.MouseClick -= mouseEventHandler;
        this._picturebox_icon = value;
        PictureBox pictureboxIcon2 = this._picturebox_icon;
        if (pictureboxIcon2 == null)
          return;
        pictureboxIcon2.MouseClick += mouseEventHandler;
      }
    }

    internal virtual Timer ShowTimer
    {
      get
      {
        return this._ShowTimer;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ShowTimer_Tick);
        Timer showTimer1 = this._ShowTimer;
        if (showTimer1 != null)
          showTimer1.Tick -= eventHandler;
        this._ShowTimer = value;
        Timer showTimer2 = this._ShowTimer;
        if (showTimer2 == null)
          return;
        showTimer2.Tick += eventHandler;
      }
    }

    internal virtual Timer WaitToClose
    {
      get
      {
        return this._WaitToClose;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.WaitToClose_Tick);
        Timer waitToClose1 = this._WaitToClose;
        if (waitToClose1 != null)
          waitToClose1.Tick -= eventHandler;
        this._WaitToClose = value;
        Timer waitToClose2 = this._WaitToClose;
        if (waitToClose2 == null)
          return;
        waitToClose2.Tick += eventHandler;
      }
    }

    internal virtual Timer FadeToClose
    {
      get
      {
        return this._FadeToClose;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.FadeToCLose_Tick);
        Timer fadeToClose1 = this._FadeToClose;
        if (fadeToClose1 != null)
          fadeToClose1.Tick -= eventHandler;
        this._FadeToClose = value;
        Timer fadeToClose2 = this._FadeToClose;
        if (fadeToClose2 == null)
          return;
        fadeToClose2.Tick += eventHandler;
      }
    }

    internal virtual TableLayoutPanel TableLayoutPanel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    public Form_notify(string message, Bitmap icon, int time)
    {
      this.Move += new EventHandler(this.FormPreventToMoveWithKeyboard);
      this.Load += new EventHandler(this.Form_notify_Load);
      this.MouseClick += new MouseEventHandler(this.Me_MouseClick);
      this.Closing += new CancelEventHandler(this.Form_notify_Closing);
      this.fade = 1.0;
      this.timetoshow = 0;
      this.myX = 0;
      this.myY = 0;
      this.InitializeComponent();
      this.label_messages.Text = message;
      this.picturebox_icon.Image = (Image) icon;
      this.timetoshow = time;
    }

    private void FormPreventToMoveWithKeyboard(object sender, EventArgs e)
    {
      if (this.WindowState != FormWindowState.Maximized && this.WindowState != FormWindowState.Minimized)
        return;
      this.WindowState = FormWindowState.Normal;
    }

    private void Form_notify_Load(object sender, EventArgs e)
    {
      _Module.BringTo.Front(this.Handle);
      if (_Module.Conf.PlaySound)
      {
        if (_Module.CoinNotify)
        {
          _Module.CoinNotify = false;
          if (_Module.Conf.CoinSound != -1)
          {
            switch (_Module.Conf.CoinSound)
            {
              case 0:
                try
                {
                  MyProject.Computer.Audio.Play(_Module.Config.CoinSoundFile, AudioPlayMode.Background);
                  break;
                }
                catch (Exception ex)
                {
                  ProjectData.SetProjectError(ex);
                  int num = (int) Interaction.MsgBox((object) ex.Message, MsgBoxStyle.Critical, (object) null);
                  ProjectData.ClearProjectError();
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
          }
        }
        else if (_Module.TimeNotify)
        {
          _Module.TimeNotify = false;
          if (_Module.Conf.TimeSound != -1)
          {
            switch (_Module.Conf.TimeSound)
            {
              case 0:
                try
                {
                  MyProject.Computer.Audio.Play(_Module.Config.TimeSoundFile, AudioPlayMode.Background);
                  break;
                }
                catch (Exception ex)
                {
                  ProjectData.SetProjectError(ex);
                  int num = (int) Interaction.MsgBox((object) ex.Message, MsgBoxStyle.Critical, (object) null);
                  ProjectData.ClearProjectError();
                  break;
                }
              case 1:
                MyProject.Computer.Audio.Play((Stream) _Module.Config.siren(), AudioPlayMode.Background);
                break;
            }
          }
        }
      }
      Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
      this.myX = workingArea.Width;
      workingArea = Screen.PrimaryScreen.WorkingArea;
      this.myY = workingArea.Height;
      this.label_messages.Font = _Module._font.get_CenturyGothicItalic(8f, FontStyle.Italic);
      if (!_Module.FormTimerIsHidden)
      {
        // ISSUE: variable of a reference type
        int& local;
        // ISSUE: explicit reference operation
        int num = checked (^(local = ref this.myY) - this.Height + 80);
        local = num;
      }
      else
      {
        // ISSUE: variable of a reference type
        int& local;
        // ISSUE: explicit reference operation
        int num = checked (^(local = ref this.myY) - this.Height + 15);
        local = num;
      }
      this.Location = new Point(this.myX, this.myY);
      this.ShowTimer.Start();
    }

    private void WaitToClose_Tick(object sender, EventArgs e)
    {
      if (this.timetoshow <= 0)
      {
        this.WaitToClose.Stop();
        this.FadeToClose.Start();
      }
      // ISSUE: variable of a reference type
      int& local;
      // ISSUE: explicit reference operation
      int num = checked (^(local = ref this.timetoshow) - 1);
      local = num;
    }

    private void FadeToCLose_Tick(object sender, EventArgs e)
    {
      // ISSUE: variable of a reference type
      double& local;
      // ISSUE: explicit reference operation
      double num = ^(local = ref this.fade) - 0.03;
      local = num;
      this.Opacity = this.fade;
      if (this.Opacity > 0.0)
        return;
      if (_Module.FormTimerIsHidden && !MyProject.Forms.Form_settings.Visible)
      {
        Form_timer mainForm = (Form_timer) _Entrypoint.MyMainForm;
        Form_notify.MyDelegate myDelegate;
        // ISSUE: reference to a compiler-generated field
        if (Form_notify._Closure\u0024__.\u0024I36\u002D0 != null)
        {
          // ISSUE: reference to a compiler-generated field
          myDelegate = Form_notify._Closure\u0024__.\u0024I36\u002D0;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          Form_notify._Closure\u0024__.\u0024I36\u002D0 = myDelegate = (Form_notify.MyDelegate) (() => _Entrypoint.MyMainForm.Show());
        }
        mainForm.BeginInvoke((Delegate) myDelegate);
        _Module.FormTimerIsHidden = false;
        _Module.CoinappVisibleToolStrip.Text = "Hide";
        _Module.BringTo.Front(_Module.Desktop.MainHandle);
      }
      _Entrypoint.MyMainForm.BeginInvoke((Delegate) (() => this.Close()));
    }

    private void Me_MouseClick(object sender, MouseEventArgs e)
    {
      this.WaitToClose.Stop();
      this.FadeToClose.Stop();
      if (_Module.FormTimerIsHidden && !MyProject.Forms.Form_settings.Visible)
      {
        _Entrypoint.MyMainForm.BeginInvoke((Delegate) new Form_notify.MyDelegate(((Control) _Entrypoint.MyMainForm).Show));
        _Module.FormTimerIsHidden = false;
        _Module.CoinappVisibleToolStrip.Text = "Hide";
        _Module.BringTo.Front(_Module.Desktop.MainHandle);
      }
      _Entrypoint.MyMainForm.BeginInvoke((Delegate) (() => this.Close()));
    }

    private void ShowTimer_Tick(object sender, EventArgs e)
    {
      // ISSUE: variable of a reference type
      int& local;
      // ISSUE: explicit reference operation
      int num = checked (^(local = ref this.myX) - 15);
      local = num;
      if (this.myX <= checked (Screen.PrimaryScreen.WorkingArea.Width - this.Width + 20))
      {
        this.ShowTimer.Stop();
        this.myX = checked (Screen.PrimaryScreen.WorkingArea.Width - this.Width + 20);
        this.WaitToClose.Start();
      }
      this.Location = new Point(this.myX, this.myY);
    }

    private void Form_notify_Closing(object sender, CancelEventArgs e)
    {
      this.Dispose();
    }

    private delegate void MyDelegate();
  }
}
