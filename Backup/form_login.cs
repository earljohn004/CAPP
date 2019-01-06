// Decompiled with JetBrains decompiler
// Type: coinapp.form_login
// Assembly: coinapp, Version=1.4.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6DB842CC-5810-43FB-8044-475700CA1E42
// Assembly location: C:\Users\EarlJohn\Desktop\Coinapp\coinapp_1.4.0.0\coinapp.exe

using coinapp.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Media;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace coinapp
{
  [DesignerGenerated]
  public class form_login : Form
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private IContainer components;
    [AccessedThroughProperty("txtbx_login")]
    private TextBox _txtbx_login;
    [AccessedThroughProperty("btn_login")]
    private Button _btn_login;
    [AccessedThroughProperty("lbl_login")]
    private Label _lbl_login;
    [AccessedThroughProperty("btn_toggle")]
    private Button _btn_toggle;
    private bool passExists;
    private bool emailExists;
    private bool working;
    [AccessedThroughProperty("worker")]
    private BackgroundWorker _worker;

    [DebuggerNonUserCode]
    static form_login()
    {
    }

    public form_login()
    {
      this.Load += new EventHandler(this.form_login_Load);
      form_login.__ENCAddToList((object) this);
      this.passExists = coinappMods.settings.XconfigExist(coinappMods.enc.GetMd5Hash("password"));
      this.emailExists = coinappMods.settings.XconfigExist(coinappMods.enc.GetMd5Hash("email"));
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (form_login.__ENCList)
      {
        if (form_login.__ENCList.Count == form_login.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (form_login.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (form_login.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                form_login.__ENCList[index1] = form_login.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          form_login.__ENCList.RemoveRange(index1, checked (form_login.__ENCList.Count - index1));
          form_login.__ENCList.Capacity = form_login.__ENCList.Count;
        }
        form_login.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
      this.txtbx_login = new TextBox();
      this.btn_login = new Button();
      this.lbl_login = new Label();
      this.btn_toggle = new Button();
      this.SuspendLayout();
      TextBox txtbxLogin1 = this.txtbx_login;
      Point point1 = new Point(13, 9);
      Point point2 = point1;
      txtbxLogin1.Location = point2;
      this.txtbx_login.Name = "txtbx_login";
      TextBox txtbxLogin2 = this.txtbx_login;
      Size size1 = new Size(210, 20);
      Size size2 = size1;
      txtbxLogin2.Size = size2;
      this.txtbx_login.TabIndex = 0;
      this.txtbx_login.UseSystemPasswordChar = true;
      this.btn_login.Enabled = false;
      Button btnLogin1 = this.btn_login;
      point1 = new Point(13, 35);
      Point point3 = point1;
      btnLogin1.Location = point3;
      this.btn_login.Name = "btn_login";
      Button btnLogin2 = this.btn_login;
      size1 = new Size(189, 32);
      Size size3 = size1;
      btnLogin2.Size = size3;
      this.btn_login.TabIndex = 1;
      this.btn_login.Text = "Login";
      this.btn_login.UseVisualStyleBackColor = true;
      this.lbl_login.ForeColor = Color.Red;
      Label lblLogin1 = this.lbl_login;
      point1 = new Point(12, 74);
      Point point4 = point1;
      lblLogin1.Location = point4;
      this.lbl_login.Name = "lbl_login";
      Label lblLogin2 = this.lbl_login;
      size1 = new Size(210, 36);
      Size size4 = size1;
      lblLogin2.Size = size4;
      this.lbl_login.TabIndex = 2;
      this.lbl_login.TextAlign = ContentAlignment.MiddleCenter;
      Button btnToggle1 = this.btn_toggle;
      point1 = new Point(203, 35);
      Point point5 = point1;
      btnToggle1.Location = point5;
      this.btn_toggle.Name = "btn_toggle";
      Button btnToggle2 = this.btn_toggle;
      size1 = new Size(20, 32);
      Size size5 = size1;
      btnToggle2.Size = size5;
      this.btn_toggle.TabIndex = 1;
      this.btn_toggle.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(234, 76);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.lbl_login);
      this.Controls.Add((Control) this.btn_toggle);
      this.Controls.Add((Control) this.btn_login);
      this.Controls.Add((Control) this.txtbx_login);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.MaximizeBox = false;
      size1 = new Size(250, 150);
      this.MaximumSize = size1;
      this.MinimizeBox = false;
      size1 = new Size(250, 110);
      this.MinimumSize = size1;
      this.Name = nameof (form_login);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Login";
      this.TopMost = true;
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual TextBox txtbx_login
    {
      [DebuggerNonUserCode] get
      {
        return this._txtbx_login;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtbx_login_KeyDown);
        EventHandler eventHandler = new EventHandler(this.txtbx_login_TextChanged);
        if (this._txtbx_login != null)
        {
          this._txtbx_login.KeyDown -= keyEventHandler;
          this._txtbx_login.TextChanged -= eventHandler;
        }
        this._txtbx_login = value;
        if (this._txtbx_login == null)
          return;
        this._txtbx_login.KeyDown += keyEventHandler;
        this._txtbx_login.TextChanged += eventHandler;
      }
    }

    internal virtual Button btn_login
    {
      [DebuggerNonUserCode] get
      {
        return this._btn_login;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btn_login_Click);
        if (this._btn_login != null)
          this._btn_login.Click -= eventHandler;
        this._btn_login = value;
        if (this._btn_login == null)
          return;
        this._btn_login.Click += eventHandler;
      }
    }

    internal virtual Label lbl_login
    {
      [DebuggerNonUserCode] get
      {
        return this._lbl_login;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lbl_login = value;
      }
    }

    internal virtual Button btn_toggle
    {
      [DebuggerNonUserCode] get
      {
        return this._btn_toggle;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btn_toggle_Click);
        if (this._btn_toggle != null)
          this._btn_toggle.Click -= eventHandler;
        this._btn_toggle = value;
        if (this._btn_toggle == null)
          return;
        this._btn_toggle.Click += eventHandler;
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
        RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.Worker_RunWorkerCompleted);
        if (this._worker != null)
        {
          this._worker.DoWork -= workEventHandler;
          this._worker.RunWorkerCompleted -= completedEventHandler;
        }
        this._worker = value;
        if (this._worker == null)
          return;
        this._worker.DoWork += workEventHandler;
        this._worker.RunWorkerCompleted += completedEventHandler;
      }
    }

    protected override CreateParams CreateParams
    {
      get
      {
        CreateParams createParams = base.CreateParams;
        createParams.ExStyle |= 8;
        return createParams;
      }
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      if (e.CloseReason == CloseReason.UserClosing && this.working)
        e.Cancel = true;
      this.Dispose();
      base.OnFormClosing(e);
    }

    private void btn_login_Click(object sender, EventArgs e)
    {
      if (!this.passExists || !this.emailExists)
      {
        int num = (int) Interaction.MsgBox((object) "Coinapp not configured properly.", MsgBoxStyle.Critical, (object) null);
        this.noSystemFile();
      }
      else
        this.login();
      this.ActiveControl = (Control) null;
    }

    private void btn_toggle_Click(object sender, EventArgs e)
    {
      this.btn_login.Enabled = false;
      if (Operators.CompareString(this.btn_login.Text, "Login", false) == 0 || Operators.CompareString(this.btn_login.Text, "Unlock", false) == 0)
      {
        this.btn_login.Text = "Recover";
        this.txtbx_login.UseSystemPasswordChar = false;
        this.txtbx_login.PasswordChar = char.MinValue;
        this.Text = "Recovery";
      }
      else if (Operators.CompareString(this.btn_login.Text, "Recover", false) == 0)
      {
        this.txtbx_login.UseSystemPasswordChar = true;
        this.Text = "Login";
        if (coinappMods.desktop.IsLocked)
          this.btn_login.Text = "Unlock";
        else
          this.btn_login.Text = "Login";
      }
      this.txtbx_login.Text = "";
      this.lbl_login.Text = "";
      this.Height = 110;
      this.ActiveControl = (Control) null;
    }

    private void txtbx_login_TextChanged(object sender, EventArgs e)
    {
      this.Height = 110;
      if (Operators.CompareString(this.btn_login.Text, "Login", false) == 0 || Operators.CompareString(this.btn_login.Text, "Unlock", false) == 0)
      {
        if (Operators.CompareString(this.txtbx_login.Text, "", false) != 0)
          this.btn_login.Enabled = true;
        else
          this.btn_login.Enabled = false;
      }
      else
      {
        if (Operators.CompareString(this.btn_login.Text, "Recover", false) != 0)
          return;
        if (coinappMods.isValidEmail(this.txtbx_login.Text))
          this.btn_login.Enabled = true;
        else
          this.btn_login.Enabled = false;
      }
    }

    private void txtbx_login_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Return)
      {
        if (!this.passExists || !this.passExists)
        {
          int num = (int) Interaction.MsgBox((object) "Coinapp not configured properly.", MsgBoxStyle.Critical, (object) null);
          this.noSystemFile();
        }
        else
          this.login();
      }
      else
        this.lbl_login.Text = (string) null;
    }

    private void login()
    {
      if (Operators.CompareString(this.txtbx_login.Text, "", false) == 0)
      {
        if (Operators.CompareString(this.btn_login.Text, "Recover", false) == 0)
        {
          this.lbl_login.Text = "Type a email and try again.";
          SystemSounds.Beep.Play();
        }
        else
        {
          this.lbl_login.Text = "Type a password and try again.";
          SystemSounds.Beep.Play();
        }
        this.Height = 150;
      }
      else if (Operators.CompareString(this.btn_login.Text, "Recover", false) == 0)
      {
        string str;
        try
        {
          str = coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("email")), "email");
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          str = "";
          ProjectData.ClearProjectError();
        }
        if (Operators.CompareString(str, "", false) == 0)
        {
          int num = (int) Interaction.MsgBox((object) "Coinapp not configured properly.", MsgBoxStyle.Critical, (object) null);
          this.noSystemFile();
        }
        else if (Operators.CompareString(this.txtbx_login.Text, str, false) == 0)
        {
          this.Height = 150;
          this.lbl_login.Text = "Sending password. Please wait...";
          coinappMods.loginAttempt = 0;
          this.txtbx_login.Enabled = false;
          this.btn_login.Enabled = false;
          this.btn_toggle.Enabled = false;
          this.worker = new BackgroundWorker();
          this.worker.RunWorkerAsync();
        }
        else
        {
          this.txtbx_login.Text = "";
          checked { ++coinappMods.loginAttempt; }
          this.Height = 150;
          this.lbl_login.Text = "Incorrect email (" + Conversions.ToString(coinappMods.loginAttempt) + " out of " + Conversions.ToString(coinappMods.conf.retryLog) + " attempt)";
          SystemSounds.Hand.Play();
          if (coinappMods.loginAttempt >= coinappMods.conf.retryLog)
          {
            this.lbl_login.Text = "Shutting down...";
            this.txtbx_login.Enabled = false;
            this.btn_login.Enabled = false;
            this.btn_toggle.Enabled = false;
            coinappMods.shutdown.Force();
          }
        }
      }
      else
      {
        string str;
        try
        {
          str = coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("password")), "password");
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          str = "";
          ProjectData.ClearProjectError();
        }
        if (Operators.CompareString(str, "", false) == 0)
        {
          int num = (int) Interaction.MsgBox((object) "Coinapp not configured properly.", MsgBoxStyle.Critical, (object) null);
          this.noSystemFile();
        }
        else if (Operators.CompareString(this.txtbx_login.Text, str, false) == 0)
        {
          this.Height = 150;
          this.lbl_login.Text = "Logging in. Please wait...";
          this.txtbx_login.Enabled = false;
          this.btn_login.Enabled = false;
          this.btn_toggle.Enabled = false;
          coinappMods.loginAttempt = 0;
          this.worker = new BackgroundWorker();
          this.worker.RunWorkerAsync();
        }
        else
        {
          this.txtbx_login.Text = "";
          checked { ++coinappMods.loginAttempt; }
          this.Height = 150;
          this.lbl_login.Text = "Incorrect password (" + Conversions.ToString(coinappMods.loginAttempt) + " out of " + Conversions.ToString(coinappMods.conf.retryLog) + " attempt)";
          SystemSounds.Hand.Play();
          if (coinappMods.loginAttempt >= coinappMods.conf.retryLog)
          {
            this.lbl_login.Text = "Shutting down...";
            this.txtbx_login.Enabled = false;
            this.btn_login.Enabled = false;
            this.btn_toggle.Enabled = false;
            coinappMods.shutdown.Force();
          }
        }
      }
    }

    private void noSystemFile()
    {
      if (Operators.CompareString(this.txtbx_login.Text, "visionstudio", false) == 0)
      {
        this.txtbx_login.Enabled = false;
        this.btn_login.Enabled = false;
        this.btn_toggle.Enabled = false;
        coinappMods.loginAttempt = 0;
        this.worker = new BackgroundWorker();
        this.worker.RunWorkerAsync();
      }
      else
      {
        this.txtbx_login.Text = "";
        checked { ++coinappMods.loginAttempt; }
        this.Height = 150;
        this.lbl_login.Text = "Password is incorrect (" + Conversions.ToString(coinappMods.loginAttempt) + " out of " + Conversions.ToString(coinappMods.conf.retryLog) + " attempt)";
        SystemSounds.Hand.Play();
        if (coinappMods.loginAttempt >= coinappMods.conf.retryLog)
        {
          this.lbl_login.Text = "Shutting down...";
          this.txtbx_login.Enabled = false;
          this.btn_login.Enabled = false;
          this.btn_toggle.Enabled = false;
          coinappMods.shutdown.Force();
        }
      }
    }

    private string RecoverPassword(string email, string recover)
    {
      MailMessage message = new MailMessage();
      SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
      smtpClient.EnableSsl = true;
      smtpClient.Timeout = 20000;
      smtpClient.Credentials = (ICredentialsByHost) new NetworkCredential("coinapptechnology@gmail.com", "coinapp2018");
      message.Subject = "Coinapp Password Recovery";
      message.Body = "Your forgotten password is: " + recover + "\r\nDo not share your password to anyone.\r\n\r\nCoinapp Software & Device\r\nCoinappTechnology\r\nEmail: coinapptechnology@gmail.com\r\nWebsite: http://coinapp.site\r\nFacebook: https://www.facebook.com/CoinappTechnology";
      message.From = new MailAddress("coinapptechnology@gmail.com");
      message.To.Add(email);
      string str;
      try
      {
        smtpClient.Send(message);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        str = ex.Message;
        ProjectData.ClearProjectError();
        goto label_4;
      }
      str = "Password sent successfully";
label_4:
      return str;
    }

    private void worker_DoWork(object sender, DoWorkEventArgs e)
    {
      this.working = true;
      if (Operators.CompareString(this.btn_login.Text, "Recover", false) == 0)
        e.Result = (object) this.RecoverPassword(this.txtbx_login.Text, coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("password")), "password"));
      else if (Operators.CompareString(this.btn_login.Text, "Unlock", false) == 0)
      {
        coinappMods.desktop.IsAdmin = true;
        coinappMods.desktop.lockForm.BeginInvoke((Delegate) (() => coinappMods.desktop.Unlock()));
        this.BeginInvoke((Delegate) (() => this.Close()));
      }
      else
      {
        this.BeginInvoke((Delegate) (() => MyProject.Forms.form_config.Show((IWin32Window) MyProject.Forms.form_main)));
        this.BeginInvoke((Delegate) (() => this.Close()));
      }
      this.working = false;
    }

    private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      form_login formLogin = this;
      if (Operators.CompareString(this.btn_login.Text, "Recover", false) != 0)
        return;
      this.BeginInvoke((Delegate) (() => this.txtbx_login.Text = ""));
      this.BeginInvoke((Delegate) (() => this.Height = 150));
      this.BeginInvoke((Delegate) (() => formLogin.lbl_login.Text = Conversions.ToString(e.Result)));
      this.BeginInvoke((Delegate) (() => this.txtbx_login.Enabled = true));
      this.BeginInvoke((Delegate) (() => this.btn_toggle.Enabled = true));
    }

    private void form_login_Load(object sender, EventArgs e)
    {
      coinappMods.pos.top(this.Handle);
      this.Focus();
      this.ActiveControl = (Control) this.txtbx_login;
      if (MyProject.Forms.form_dialog.Visible)
      {
        MyProject.Forms.form_dialog.Dispose();
        MyProject.Forms.form_dialog.Close();
      }
      if (MyProject.Forms.form_use_account.Visible)
      {
        MyProject.Forms.form_use_account.Dispose();
        MyProject.Forms.form_use_account.Close();
      }
      if (MyProject.Forms.form_use_voucher.Visible)
      {
        MyProject.Forms.form_use_voucher.Dispose();
        MyProject.Forms.form_use_voucher.Close();
      }
      if (!MyProject.Forms.form_account_create.Visible)
        return;
      MyProject.Forms.form_account_create.Close();
    }

    private delegate void MyDelegate();
  }
}
