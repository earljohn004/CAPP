// Decompiled with JetBrains decompiler
// Type: coinapp.form_use_account
// Assembly: coinapp, Version=1.4.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6DB842CC-5810-43FB-8044-475700CA1E42
// Assembly location: C:\Users\EarlJohn\Desktop\Coinapp\coinapp_1.4.0.0\coinapp.exe

using coinapp.My;
using coinapplib;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace coinapp
{
  [DesignerGenerated]
  public class form_use_account : Form
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private IContainer components;
    [AccessedThroughProperty("btn_enter")]
    private Button _btn_enter;
    [AccessedThroughProperty("txtbx_user")]
    private TextBox _txtbx_user;
    [AccessedThroughProperty("txtbx_pass")]
    private TextBox _txtbx_pass;
    private bool working;
    private bool LOGGED;
    private ArrayList accountTemp;
    [AccessedThroughProperty("worker")]
    private BackgroundWorker _worker;

    [DebuggerNonUserCode]
    static form_use_account()
    {
    }

    public form_use_account()
    {
      this.Load += new EventHandler(this.form_use_account_Load);
      form_use_account.__ENCAddToList((object) this);
      this.LOGGED = false;
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (form_use_account.__ENCList)
      {
        if (form_use_account.__ENCList.Count == form_use_account.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (form_use_account.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (form_use_account.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                form_use_account.__ENCList[index1] = form_use_account.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          form_use_account.__ENCList.RemoveRange(index1, checked (form_use_account.__ENCList.Count - index1));
          form_use_account.__ENCList.Capacity = form_use_account.__ENCList.Count;
        }
        form_use_account.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
      this.btn_enter = new Button();
      this.txtbx_user = new TextBox();
      this.txtbx_pass = new TextBox();
      this.SuspendLayout();
      this.btn_enter.Enabled = false;
      this.btn_enter.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Button btnEnter1 = this.btn_enter;
      Point point1 = new Point(24, 72);
      Point point2 = point1;
      btnEnter1.Location = point2;
      this.btn_enter.Name = "btn_enter";
      Button btnEnter2 = this.btn_enter;
      Size size1 = new Size(165, 28);
      Size size2 = size1;
      btnEnter2.Size = size2;
      this.btn_enter.TabIndex = 2;
      this.btn_enter.TabStop = false;
      this.btn_enter.Text = "Enter";
      this.btn_enter.UseVisualStyleBackColor = true;
      this.txtbx_user.Enabled = false;
      this.txtbx_user.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtbx_user.ForeColor = Color.DimGray;
      TextBox txtbxUser1 = this.txtbx_user;
      point1 = new Point(24, 14);
      Point point3 = point1;
      txtbxUser1.Location = point3;
      this.txtbx_user.Name = "txtbx_user";
      TextBox txtbxUser2 = this.txtbx_user;
      size1 = new Size(165, 22);
      Size size3 = size1;
      txtbxUser2.Size = size3;
      this.txtbx_user.TabIndex = 0;
      this.txtbx_user.Text = "username";
      this.txtbx_user.TextAlign = HorizontalAlignment.Center;
      this.txtbx_pass.Enabled = false;
      this.txtbx_pass.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtbx_pass.ForeColor = Color.DimGray;
      TextBox txtbxPass1 = this.txtbx_pass;
      point1 = new Point(24, 44);
      Point point4 = point1;
      txtbxPass1.Location = point4;
      this.txtbx_pass.Name = "txtbx_pass";
      TextBox txtbxPass2 = this.txtbx_pass;
      size1 = new Size(165, 22);
      Size size4 = size1;
      txtbxPass2.Size = size4;
      this.txtbx_pass.TabIndex = 1;
      this.txtbx_pass.Text = "password";
      this.txtbx_pass.TextAlign = HorizontalAlignment.Center;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(214, 106);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.btn_enter);
      this.Controls.Add((Control) this.txtbx_pass);
      this.Controls.Add((Control) this.txtbx_user);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.MaximizeBox = false;
      size1 = new Size(230, 140);
      this.MaximumSize = size1;
      this.MinimizeBox = false;
      size1 = new Size(230, 140);
      this.MinimumSize = size1;
      this.Name = nameof (form_use_account);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Use account";
      this.TopMost = true;
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual Button btn_enter
    {
      [DebuggerNonUserCode] get
      {
        return this._btn_enter;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btn_enter_Click);
        if (this._btn_enter != null)
          this._btn_enter.Click -= eventHandler;
        this._btn_enter = value;
        if (this._btn_enter == null)
          return;
        this._btn_enter.Click += eventHandler;
      }
    }

    internal virtual TextBox txtbx_user
    {
      [DebuggerNonUserCode] get
      {
        return this._txtbx_user;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtbx_user_pass_GotFocus);
        EventHandler eventHandler2 = new EventHandler(this.txtbx_user_pass_TextChanged);
        EventHandler eventHandler3 = new EventHandler(this.txtbx_user_pass_LostFocus);
        KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtbx_user_pass_KeyDown);
        if (this._txtbx_user != null)
        {
          this._txtbx_user.GotFocus -= eventHandler1;
          this._txtbx_user.TextChanged -= eventHandler2;
          this._txtbx_user.LostFocus -= eventHandler3;
          this._txtbx_user.KeyDown -= keyEventHandler;
        }
        this._txtbx_user = value;
        if (this._txtbx_user == null)
          return;
        this._txtbx_user.GotFocus += eventHandler1;
        this._txtbx_user.TextChanged += eventHandler2;
        this._txtbx_user.LostFocus += eventHandler3;
        this._txtbx_user.KeyDown += keyEventHandler;
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
        EventHandler eventHandler1 = new EventHandler(this.txtbx_user_pass_GotFocus);
        EventHandler eventHandler2 = new EventHandler(this.txtbx_user_pass_TextChanged);
        EventHandler eventHandler3 = new EventHandler(this.txtbx_user_pass_LostFocus);
        KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtbx_user_pass_KeyDown);
        if (this._txtbx_pass != null)
        {
          this._txtbx_pass.GotFocus -= eventHandler1;
          this._txtbx_pass.TextChanged -= eventHandler2;
          this._txtbx_pass.LostFocus -= eventHandler3;
          this._txtbx_pass.KeyDown -= keyEventHandler;
        }
        this._txtbx_pass = value;
        if (this._txtbx_pass == null)
          return;
        this._txtbx_pass.GotFocus += eventHandler1;
        this._txtbx_pass.TextChanged += eventHandler2;
        this._txtbx_pass.LostFocus += eventHandler3;
        this._txtbx_pass.KeyDown += keyEventHandler;
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
        RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.worker_RunWorkerCompleted);
        DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.worker_DoWork);
        if (this._worker != null)
        {
          this._worker.RunWorkerCompleted -= completedEventHandler;
          this._worker.DoWork -= workEventHandler;
        }
        this._worker = value;
        if (this._worker == null)
          return;
        this._worker.RunWorkerCompleted += completedEventHandler;
        this._worker.DoWork += workEventHandler;
      }
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      if (e.CloseReason == CloseReason.UserClosing && this.working)
        e.Cancel = true;
      if (coinappMods.BEGINCHARGE)
        coinappMods.BEGINCHARGE = false;
      base.OnFormClosing(e);
    }

    private void form_use_account_Load(object sender, EventArgs e)
    {
      if (MyProject.Forms.form_dialog.Visible)
      {
        MyProject.Forms.form_dialog.Dispose();
        MyProject.Forms.form_dialog.Close();
      }
      if (MyProject.Forms.form_login.Visible)
        MyProject.Forms.form_login.Close();
      if (MyProject.Forms.form_use_voucher.Visible)
        MyProject.Forms.form_use_voucher.Close();
      if (MyProject.Forms.form_account_create.Visible)
        MyProject.Forms.form_account_create.Close();
      string filePath;
      try
      {
        filePath = coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("data")), "data");
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) "This feature is unavailable. Contact the owner.", MsgBoxStyle.Critical, (object) "Feature not available");
        ProjectData.ClearProjectError();
        return;
      }
      if (coinappMods.conf.account > 0)
      {
        string str1;
        try
        {
          str1 = coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("accountFilename")), "account");
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          str1 = "";
          ProjectData.ClearProjectError();
        }
        string str2;
        try
        {
          str2 = coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("accountPassword")), "account");
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          str2 = "";
          ProjectData.ClearProjectError();
        }
        if (Operators.CompareString(str1, "", false) == 0 || Operators.CompareString(str2, "", false) == 0)
        {
          int num1 = (int) Interaction.MsgBox((object) "You cannot use an account at this time. Contact the owner.", MsgBoxStyle.Critical, (object) "Account not available: data path");
        }
        else if (!File.Exists(filePath + str1 + ".mdb"))
        {
          int num2 = (int) Interaction.MsgBox((object) "You cannot use an account at this time. Contact the owner.", MsgBoxStyle.Critical, (object) "Account not available");
        }
        else
        {
          coinappMods.account = new database(filePath, str1, str2);
          try
          {
            coinappMods.account.open();
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          if (!coinappMods.account.isOpen)
          {
            int num3 = (int) Interaction.MsgBox((object) "You cannot use an account at this time. Contact the owner.", MsgBoxStyle.Critical, (object) "Account not available");
          }
          else
          {
            this.txtbx_user.Enabled = true;
            this.txtbx_pass.Enabled = true;
            coinappMods.account.close();
          }
        }
      }
    }

    private void worker_DoWork(object sender, DoWorkEventArgs e)
    {
      this.working = true;
      try
      {
        coinappMods.account.open();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      if (coinappMods.account != null && coinappMods.account.isOpen)
      {
        coinappMods.aCommand = new OleDbCommand();
        coinappMods.aCommand.Connection = coinappMods.account.conn;
        coinappMods.aCommand.CommandText = "SELECT * FROM users WHERE ( Username = '" + this.txtbx_user.Text + "')";
        try
        {
          coinappMods.aCommand.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Exception exception = ex;
          e.Result = (object) exception.Message;
          ProjectData.ClearProjectError();
          return;
        }
        OleDbDataReader oleDbDataReader = coinappMods.aCommand.ExecuteReader();
        this.accountTemp = new ArrayList();
        while (oleDbDataReader.Read())
        {
          this.accountTemp.Add((object) oleDbDataReader["ID"].ToString());
          this.accountTemp.Add((object) oleDbDataReader["Username"].ToString());
          this.accountTemp.Add((object) oleDbDataReader["Password"].ToString());
          this.accountTemp.Add((object) oleDbDataReader["Credits"].ToString());
          this.accountTemp.Add((object) oleDbDataReader["Created"].ToString());
          this.accountTemp.Add((object) oleDbDataReader["Full Name"].ToString());
          this.accountTemp.Add((object) oleDbDataReader["Email"].ToString());
          this.accountTemp.Add((object) oleDbDataReader["Last Logged"].ToString());
        }
        oleDbDataReader.Close();
        if (this.accountTemp.Count <= 0)
          e.Result = (object) "account:no";
        else if (string.Compare(this.accountTemp[2].ToString(), this.txtbx_pass.Text, false) != 0)
          e.Result = (object) "account:invalid";
        else if (coinappMods.BEGINCHARGE)
        {
          coinappMods.userAccount = this.accountTemp[1].ToString();
          this.LOGGED = true;
          e.Result = (object) "charge";
        }
        else
        {
          int result = 0;
          if (!int.TryParse(this.accountTemp[3].ToString(), out result))
            result = 0;
          if (result <= 0)
          {
            if (coinappMods.desktop.IsLocked)
            {
              e.Result = (object) "account:used";
            }
            else
            {
              form_use_account formUseAccount = this;
              DialogResult dialogResult;
              this.Invoke((Delegate) (() => dialogResult = MessageBox.Show("Save remaining time to user account '" + formUseAccount.accountTemp[1].ToString() + "'. After saving the remaining time it will lock the PC automatically.", "Save credits", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)));
              if (dialogResult == DialogResult.OK)
              {
                coinappMods.aCommand.CommandText = "UPDATE users SET [Credits]='" + Conversions.ToString(checked (result + coinappMods.credits)) + "' WHERE [Username]='" + this.accountTemp[1].ToString() + "'";
                this.LOGGED = true;
                try
                {
                  coinappMods.aCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                  ProjectData.SetProjectError(ex);
                  e.Result = (object) "error:save";
                  ProjectData.ClearProjectError();
                  return;
                }
                e.Result = (object) "save";
              }
            }
          }
          else
          {
            form_use_account formUseAccount = this;
            int num1 = result % 60;
            int num2 = checked ((int) Math.Round(unchecked ((double) checked (result - num1) / 60.0 % 60.0)));
            int num3 = checked ((int) Math.Round(unchecked ((double) checked (result - num1 + num2 * 60) / 3600.0 % 60.0)));
            DialogResult dialogResult;
            if (coinappMods.desktop.IsLocked)
              this.Invoke((Delegate) (() => dialogResult = MessageBox.Show("Account credits: " + (num3 > 0 ? Conversions.ToString(num3) + " " + (num3 == 1 ? "hour " : "hours ") : "") + (num2 > 0 ? Conversions.ToString(num2) + " " + (num2 == 1 ? "minute " : "minutes ") : "") + (num1 > 0 ? Conversions.ToString(num1) + " " + (num1 == 1 ? "second" : "seconds") : "") + "\r\nLogin user account?", "Use account", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)));
            else
              this.Invoke((Delegate) (() => dialogResult = MessageBox.Show("Save remaining time to user account '" + formUseAccount.accountTemp[1].ToString() + "'. After saving the remaining time it will lock the PC automatically.", "Save credits", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)));
            if (dialogResult != DialogResult.OK)
            {
              e.Result = (object) "cancel";
            }
            else
            {
              this.BeginInvoke((Delegate) (() => this.ControlBox = false));
              this.BeginInvoke((Delegate) (() => this.btn_enter.Text = "Please wait..."));
              string str = Strings.Format((object) DateAndTime.Now, "yyyy/MM/dd @ hh:mm:ss tt");
              if (coinappMods.desktop.IsLocked)
              {
                coinappMods.aCommand.CommandText = "UPDATE users SET [Last Logged]='" + str + "' WHERE [Username]='" + this.accountTemp[1].ToString() + "'";
                try
                {
                  coinappMods.aCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                  ProjectData.SetProjectError(ex);
                  Exception exception = ex;
                  e.Result = (object) exception.Message;
                  ProjectData.ClearProjectError();
                  return;
                }
              }
              if (coinappMods.SerialComPort.IsOpen)
              {
                if (coinappMods.desktop.IsLocked)
                {
                  coinappMods.userAccount = this.accountTemp[1].ToString();
                  coinappMods.CREDITSTYPE = 2;
                  coinappMods.SerialComPort.Write("CREDITS=" + Conversions.ToString(result));
                  coinappMods.SerialComPort.Write("COUNT=1");
                  this.LOGGED = true;
                  this.working = false;
                  this.Dispose();
                  this.Close();
                  coinappMods.desktop.lockForm.BeginInvoke((Delegate) (() => coinappMods.desktop.Unlock()));
                }
                else
                {
                  coinappMods.aCommand.CommandText = "UPDATE users SET [Credits]='" + Conversions.ToString(checked (result + coinappMods.credits)) + "' WHERE [Username]='" + this.accountTemp[1].ToString() + "'";
                  this.LOGGED = true;
                  try
                  {
                    coinappMods.aCommand.ExecuteNonQuery();
                  }
                  catch (Exception ex)
                  {
                    ProjectData.SetProjectError(ex);
                    e.Result = (object) "error:save";
                    ProjectData.ClearProjectError();
                    return;
                  }
                  e.Result = (object) "save";
                }
              }
              else
                e.Result = (object) "nodevice";
            }
          }
        }
      }
      else
        e.Result = (object) "account:error";
    }

    private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      if (!this.LOGGED && Operators.CompareString(e.Result.ToString(), "cancel", false) != 0)
      {
        string Left = Conversions.ToString(e.Result);
        if (Operators.CompareString(Left, "account:no", false) == 0)
        {
          int num1 = (int) Interaction.MsgBox((object) "User account not registered.", MsgBoxStyle.Critical, (object) "No user account");
        }
        else if (Operators.CompareString(Left, "account:invalid", false) == 0)
        {
          int num2 = (int) Interaction.MsgBox((object) "Password is incorrect. Please try again.", MsgBoxStyle.Critical, (object) "Password incorrect");
        }
        else if (Operators.CompareString(Left, "account:used", false) == 0)
        {
          int num3 = (int) Interaction.MsgBox((object) "User account credits has been used.", MsgBoxStyle.Critical, (object) "No credits");
        }
        else if (Operators.CompareString(Left, "account:error", false) == 0)
        {
          int num4 = (int) Interaction.MsgBox((object) "You cannot use a user account at this time. Please try again later. Or contact the owner", MsgBoxStyle.Critical, (object) "User account error");
        }
        else if (Operators.CompareString(Left, "nodevice", false) == 0)
        {
          int num5 = (int) Interaction.MsgBox((object) "Device is not connected.", MsgBoxStyle.Critical, (object) "Device error");
        }
        else
        {
          int num6 = (int) Interaction.MsgBox(RuntimeHelpers.GetObjectValue(e.Result), MsgBoxStyle.Critical, (object) null);
        }
        coinappMods.account.close();
        coinappMods.aCommand.Dispose();
        coinappMods.aCommand = (OleDbCommand) null;
      }
      this.working = false;
      string Left1 = e.Result.ToString();
      if (Operators.CompareString(Left1, "cancel", false) == 0)
      {
        coinappMods.account.close();
        coinappMods.aCommand.Dispose();
        coinappMods.aCommand = (OleDbCommand) null;
      }
      else if (Operators.CompareString(Left1, "save", false) == 0)
      {
        coinappMods.account.close();
        coinappMods.aCommand.Dispose();
        coinappMods.aCommand = (OleDbCommand) null;
        if (coinappMods.SerialComPort.IsOpen)
        {
          coinappMods.SerialComPort.Write("COUNT=0");
          coinappMods.SerialComPort.Write("CREDITS=0");
        }
        if (coinappMods.conf.data > 0 && coinappMods.CREDITSTYPE < 2)
          coinappMods.settings.writeCoin(coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("data")), "data"), coinappMods.enc.GetMd5Hash("time" + coinappMods.sID), coinappMods.enc.Encrypt("0", "time"));
        coinappMods.credits = 0;
        coinappMods.LOCKCODE = 6;
        coinappMods.CREDITSTYPE = 0;
        this.Close();
        coinappMods.desktop.mainForm.BeginInvoke((Delegate) (() => coinappMods.desktop.Lock((IWin32Window) MyProject.Forms.form_lock)));
      }
      else if (Operators.CompareString(Left1, "error:save", false) == 0)
      {
        int num7 = (int) Interaction.MsgBox((object) "Credits can't save to account.", MsgBoxStyle.Critical, (object) "Account error");
      }
      else if (Operators.CompareString(Left1, "charge", false) == 0)
      {
        coinappMods.account.close();
        coinappMods.aCommand.Dispose();
        coinappMods.aCommand = (OleDbCommand) null;
        coinappMods.CHARGE = true;
        coinappMods.BEGINCHARGE = false;
        this.Close();
        int num1;
        coinappMods.desktop.lockForm.BeginInvoke((Delegate) (() => num1 = (int) MyProject.Forms.form_dialog.Show("Insert a coin to charge the '" + coinappMods.userAccount + "' user account...\r\n---User account credits: (No time credits)\r\n---Coin inserted: 0\r\n---Time added: (No time added)\r\nClick OK when done.", "Charging  '" + coinappMods.userAccount + "' user account...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)));
        return;
      }
      this.txtbx_user.Enabled = true;
      this.txtbx_pass.Enabled = true;
      this.btn_enter.Text = "Enter";
      if (Operators.CompareString(this.txtbx_user.Text, "", false) != 0 && Operators.CompareString(this.txtbx_user.Text, "username", false) != 0 && this.txtbx_pass.UseSystemPasswordChar)
        this.btn_enter.Enabled = true;
      else
        this.btn_enter.Enabled = false;
      this.accountTemp = (ArrayList) null;
    }

    private void txtbx_user_pass_GotFocus(object sender, EventArgs e)
    {
      if (sender == this.txtbx_user)
      {
        if (Operators.CompareString(this.txtbx_user.Text, "username", false) != 0)
          return;
        this.txtbx_user.Clear();
        this.txtbx_user.ForeColor = Color.Black;
      }
      else
      {
        if (sender != this.txtbx_pass || Operators.CompareString(this.txtbx_pass.Text, "password", false) != 0)
          return;
        this.txtbx_pass.Clear();
        this.txtbx_pass.UseSystemPasswordChar = true;
        this.txtbx_pass.ForeColor = Color.Black;
      }
    }

    private void txtbx_user_pass_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      if (Operators.CompareString(this.txtbx_user.Text, "", false) == 0 || Operators.CompareString(this.txtbx_pass.Text, "", false) == 0)
      {
        int num = (int) Interaction.MsgBox((object) "Input text field", MsgBoxStyle.Critical, (object) null);
      }
      else
      {
        this.txtbx_user.Enabled = false;
        this.txtbx_pass.Enabled = false;
        this.btn_enter.Enabled = false;
        this.btn_enter.Text = "Checking account...";
        this.worker = new BackgroundWorker();
        this.worker.RunWorkerAsync();
      }
    }

    private void txtbx_user_pass_LostFocus(object sender, EventArgs e)
    {
      if (sender == this.txtbx_user)
      {
        if (Operators.CompareString(this.txtbx_user.Text, "", false) != 0)
          return;
        this.txtbx_user.ForeColor = Color.DimGray;
        this.txtbx_user.Text = "username";
      }
      else
      {
        if (sender != this.txtbx_pass || Operators.CompareString(this.txtbx_pass.Text, "", false) != 0)
          return;
        if (this.txtbx_pass.UseSystemPasswordChar)
          this.txtbx_pass.BeginInvoke((Delegate) (() => this.txtbx_pass.UseSystemPasswordChar = false));
        this.txtbx_pass.ForeColor = Color.DimGray;
        this.txtbx_pass.Text = "password";
      }
    }

    private void txtbx_user_pass_TextChanged(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.txtbx_user.Text, "", false) != 0 && Operators.CompareString(this.txtbx_user.Text, "username", false) != 0 && (Operators.CompareString(this.txtbx_pass.Text, "", false) != 0 && Operators.CompareString(this.txtbx_pass.Text, "password", false) != 0))
        this.btn_enter.Enabled = true;
      else
        this.btn_enter.Enabled = false;
    }

    private void btn_enter_Click(object sender, EventArgs e)
    {
      this.ActiveControl = (Control) null;
      if (Operators.CompareString(this.txtbx_user.Text, "", false) == 0 || Operators.CompareString(this.txtbx_pass.Text, "", false) == 0)
      {
        int num = (int) Interaction.MsgBox((object) "Input text field", MsgBoxStyle.Critical, (object) null);
      }
      else
      {
        this.txtbx_user.Enabled = false;
        this.txtbx_pass.Enabled = false;
        this.btn_enter.Enabled = false;
        this.btn_enter.Text = "Checking account...";
        this.worker = new BackgroundWorker();
        this.worker.RunWorkerAsync();
      }
    }

    private delegate void MyDelegate();
  }
}
