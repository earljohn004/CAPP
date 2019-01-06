// Decompiled with JetBrains decompiler
// Type: coinapp.form_use_voucher
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
  public class form_use_voucher : Form
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private IContainer components;
    [AccessedThroughProperty("txtbx_voucher")]
    private TextBox _txtbx_voucher;
    [AccessedThroughProperty("btn_use")]
    private Button _btn_use;
    private bool working;
    private bool LOGGED;
    private ArrayList voucherTemp;
    private OleDbCommand vCommand;
    private DateTime vDate;
    [AccessedThroughProperty("worker")]
    private BackgroundWorker _worker;

    [DebuggerNonUserCode]
    static form_use_voucher()
    {
    }

    public form_use_voucher()
    {
      this.Load += new EventHandler(this.form_user_Load);
      form_use_voucher.__ENCAddToList((object) this);
      this.LOGGED = false;
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (form_use_voucher.__ENCList)
      {
        if (form_use_voucher.__ENCList.Count == form_use_voucher.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (form_use_voucher.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (form_use_voucher.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                form_use_voucher.__ENCList[index1] = form_use_voucher.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          form_use_voucher.__ENCList.RemoveRange(index1, checked (form_use_voucher.__ENCList.Count - index1));
          form_use_voucher.__ENCList.Capacity = form_use_voucher.__ENCList.Count;
        }
        form_use_voucher.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
      this.txtbx_voucher = new TextBox();
      this.btn_use = new Button();
      this.SuspendLayout();
      this.txtbx_voucher.Enabled = false;
      this.txtbx_voucher.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtbx_voucher.ForeColor = Color.DimGray;
      TextBox txtbxVoucher1 = this.txtbx_voucher;
      Point point1 = new Point(24, 15);
      Point point2 = point1;
      txtbxVoucher1.Location = point2;
      this.txtbx_voucher.Name = "txtbx_voucher";
      TextBox txtbxVoucher2 = this.txtbx_voucher;
      Size size1 = new Size(165, 22);
      Size size2 = size1;
      txtbxVoucher2.Size = size2;
      this.txtbx_voucher.TabIndex = 6;
      this.txtbx_voucher.TabStop = false;
      this.txtbx_voucher.Text = "voucher id";
      this.txtbx_voucher.TextAlign = HorizontalAlignment.Center;
      this.btn_use.Enabled = false;
      this.btn_use.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Button btnUse1 = this.btn_use;
      point1 = new Point(24, 47);
      Point point3 = point1;
      btnUse1.Location = point3;
      this.btn_use.Name = "btn_use";
      Button btnUse2 = this.btn_use;
      size1 = new Size(165, 28);
      Size size3 = size1;
      btnUse2.Size = size3;
      this.btn_use.TabIndex = 7;
      this.btn_use.TabStop = false;
      this.btn_use.Text = "Use voucher";
      this.btn_use.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(214, 86);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.btn_use);
      this.Controls.Add((Control) this.txtbx_voucher);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.MaximizeBox = false;
      size1 = new Size(230, 120);
      this.MaximumSize = size1;
      this.MinimizeBox = false;
      size1 = new Size(230, 120);
      this.MinimumSize = size1;
      this.Name = nameof (form_use_voucher);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Use voucher";
      this.TopMost = true;
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual TextBox txtbx_voucher
    {
      [DebuggerNonUserCode] get
      {
        return this._txtbx_voucher;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtbx_voucher_KeyDown);
        EventHandler eventHandler1 = new EventHandler(this.txtbx_voucher_TextChanged);
        EventHandler eventHandler2 = new EventHandler(this.txtbx_voucher_GotFocus);
        EventHandler eventHandler3 = new EventHandler(this.txtbx_voucher_LostFocus);
        if (this._txtbx_voucher != null)
        {
          this._txtbx_voucher.KeyDown -= keyEventHandler;
          this._txtbx_voucher.TextChanged -= eventHandler1;
          this._txtbx_voucher.GotFocus -= eventHandler2;
          this._txtbx_voucher.LostFocus -= eventHandler3;
        }
        this._txtbx_voucher = value;
        if (this._txtbx_voucher == null)
          return;
        this._txtbx_voucher.KeyDown += keyEventHandler;
        this._txtbx_voucher.TextChanged += eventHandler1;
        this._txtbx_voucher.GotFocus += eventHandler2;
        this._txtbx_voucher.LostFocus += eventHandler3;
      }
    }

    internal virtual Button btn_use
    {
      [DebuggerNonUserCode] get
      {
        return this._btn_use;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btn_use_Click);
        if (this._btn_use != null)
          this._btn_use.Click -= eventHandler;
        this._btn_use = value;
        if (this._btn_use == null)
          return;
        this._btn_use.Click += eventHandler;
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
        RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.worker_RunWorkerCompleted);
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

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      if (e.CloseReason == CloseReason.UserClosing && this.working)
        e.Cancel = true;
      base.OnFormClosing(e);
    }

    private void form_user_Load(object sender, EventArgs e)
    {
      this.ActiveControl = (Control) null;
      if (MyProject.Forms.form_dialog.Visible)
      {
        MyProject.Forms.form_dialog.Dispose();
        MyProject.Forms.form_dialog.Close();
      }
      if (MyProject.Forms.form_login.Visible)
        MyProject.Forms.form_login.Close();
      if (MyProject.Forms.form_use_account.Visible)
        MyProject.Forms.form_use_account.Close();
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
      string str1;
      try
      {
        str1 = coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("voucherFilename")), "voucher");
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
        str2 = coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("voucherPassword")), "voucher");
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        str2 = "";
        ProjectData.ClearProjectError();
      }
      if (Operators.CompareString(str1, "", false) == 0 || Operators.CompareString(str2, "", false) == 0)
      {
        int num1 = (int) Interaction.MsgBox((object) "You cannot use a voucher at this time. Contact the owner.", MsgBoxStyle.Critical, (object) "Voucher not available");
      }
      else if (!File.Exists(filePath + str1 + ".mdb"))
      {
        int num2 = (int) Interaction.MsgBox((object) "You cannot use a voucher at this time. Contact the owner.", MsgBoxStyle.Critical, (object) "Voucher not available");
      }
      else
      {
        coinappMods.voucher = new database(filePath, str1, str2);
        try
        {
          coinappMods.voucher.open();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        if (!coinappMods.voucher.isOpen)
        {
          int num3 = (int) Interaction.MsgBox((object) "You cannot use a voucher at this time. Contact the owner.", MsgBoxStyle.Critical, (object) "Voucher not available");
        }
        else
        {
          this.txtbx_voucher.Enabled = true;
          coinappMods.voucher.close();
        }
      }
    }

    private void btn_use_Click(object sender, EventArgs e)
    {
      this.ActiveControl = (Control) null;
      if (Operators.CompareString(this.txtbx_voucher.Text, "", false) == 0)
      {
        int num1 = (int) Interaction.MsgBox((object) "Input a voucher", MsgBoxStyle.Critical, (object) null);
      }
      else if (this.txtbx_voucher.Text.Length < 8)
      {
        int num2 = (int) Interaction.MsgBox((object) "Input a valid voucher", MsgBoxStyle.Critical, (object) null);
      }
      else
      {
        this.txtbx_voucher.Enabled = false;
        this.btn_use.Enabled = false;
        this.btn_use.Text = "Checking voucher...";
        this.worker = new BackgroundWorker();
        if (coinappMods.desktop.IsLocked)
          this.worker.RunWorkerAsync((object) "login");
        else
          this.worker.RunWorkerAsync((object) "save");
      }
    }

    private void worker_DoWork(object sender, DoWorkEventArgs e)
    {
      this.working = true;
      try
      {
        coinappMods.voucher.open();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        e.Result = (object) exception.Message;
        ProjectData.ClearProjectError();
        return;
      }
      if (coinappMods.voucher != null && coinappMods.voucher.isOpen)
      {
        this.vCommand = new OleDbCommand();
        this.vCommand.Connection = coinappMods.voucher.conn;
        this.vCommand.CommandText = "SELECT * FROM coupons WHERE ( ID = '" + this.txtbx_voucher.Text + "')";
        try
        {
          this.vCommand.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Exception exception = ex;
          e.Result = (object) exception.Message;
          ProjectData.ClearProjectError();
          return;
        }
        OleDbDataReader oleDbDataReader = this.vCommand.ExecuteReader();
        this.voucherTemp = new ArrayList();
        while (oleDbDataReader.Read())
        {
          this.voucherTemp.Add((object) oleDbDataReader["#"].ToString());
          this.voucherTemp.Add((object) oleDbDataReader["ID"].ToString());
          this.voucherTemp.Add((object) oleDbDataReader["Credits"].ToString());
          this.voucherTemp.Add((object) oleDbDataReader["Status"].ToString());
          this.voucherTemp.Add((object) oleDbDataReader["Expiration"].ToString());
          this.voucherTemp.Add((object) oleDbDataReader["Created"].ToString());
          this.voucherTemp.Add((object) oleDbDataReader["Date Used"].ToString());
        }
        oleDbDataReader.Close();
        if (this.voucherTemp.Count <= 0)
          e.Result = (object) "voucher:invalid";
        else if (string.Compare(this.voucherTemp[1].ToString(), this.txtbx_voucher.Text, false) != 0)
          e.Result = (object) "voucher:check";
        else if (Operators.CompareString(this.voucherTemp[3].ToString(), "Unused", false) != 0)
        {
          e.Result = (object) "voucher:used";
        }
        else
        {
          DateTime now = DateAndTime.Now;
          if (DateTime.TryParse(this.voucherTemp[4].ToString(), out this.vDate))
          {
            if (DateTime.Compare(this.vDate, now) < 1)
            {
              e.Result = (object) "voucher:expired";
            }
            else
            {
              int result = 0;
              if (!int.TryParse(this.voucherTemp[2].ToString(), out result))
                result = 0;
              int num1 = result % 60;
              int num2 = checked ((int) Math.Round(unchecked ((double) checked (result - num1) / 60.0 % 60.0)));
              int num3 = checked ((int) Math.Round(unchecked ((double) checked (result - num1 + num2 * 60) / 3600.0 % 60.0)));
              if (result <= 0)
              {
                e.Result = (object) "voucher:used";
              }
              else
              {
                DialogResult dialogResult;
                if (coinappMods.desktop.IsLocked)
                  this.Invoke((Delegate) (() => dialogResult = MessageBox.Show("Do you want to use this COUPON VOUCHER? \r\nTime credits: " + (closure_0 > 0 ? Conversions.ToString(closure_0) + " " + (closure_0 == 1 ? "hour " : "hours ") : "") + (closure_1 > 0 ? Conversions.ToString(closure_1) + " " + (closure_1 == 1 ? "minute " : "minutes ") : "") + (closure_2 > 0 ? Conversions.ToString(closure_2) + " " + (closure_2 == 1 ? "second" : "seconds") : "") + "\r\n\r\nWARNING: Coupon voucher is one time use only. Once you click OK and the time credits will count, this voucher is cannot use anymore. Are you sure?", "Use voucher to login", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)));
                else
                  this.Invoke((Delegate) (() => dialogResult = MessageBox.Show("Do you want to add time credits from this COUPON VOUCHER?\r\nTime credits: " + (closure_0 > 0 ? Conversions.ToString(closure_0) + " " + (closure_0 == 1 ? "hour " : "hours ") : "") + (closure_1 > 0 ? Conversions.ToString(closure_1) + " " + (closure_1 == 1 ? "minute " : "minutes ") : "") + (closure_2 > 0 ? Conversions.ToString(closure_2) + " " + (closure_2 == 1 ? "second" : "seconds") : "") + "\r\n\r\nWARNING: Coupon voucher is one time use only. Once you click OK and time credits will add, this voucher is cannot use anymore. Are you sure?", "Add time credits from voucher", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)));
                if (dialogResult != DialogResult.OK)
                {
                  e.Result = (object) "cancel";
                }
                else
                {
                  this.BeginInvoke((Delegate) (() => this.ControlBox = false));
                  this.BeginInvoke((Delegate) (() => this.btn_use.Text = "Please wait..."));
                  this.vCommand.CommandText = "UPDATE coupons SET [Status]='Used', [Date Used]='" + Strings.Format((object) now, "yyyy/MM/dd @ hh:mm:ss tt") + "' WHERE [ID]='" + this.voucherTemp[1].ToString() + "'";
                  try
                  {
                    this.vCommand.ExecuteNonQuery();
                  }
                  catch (Exception ex)
                  {
                    ProjectData.SetProjectError(ex);
                    Exception exception = ex;
                    e.Result = (object) exception.Message;
                    ProjectData.ClearProjectError();
                    return;
                  }
                  if (coinappMods.SerialComPort.IsOpen)
                  {
                    if (coinappMods.desktop.IsLocked)
                    {
                      coinappMods.CREDITSTYPE = 1;
                      this.LOGGED = true;
                      coinappMods.SerialComPort.Write("CREDITS=" + Conversions.ToString(result));
                      coinappMods.SerialComPort.Write("COUNT=1");
                      this.working = false;
                      coinappMods.desktop.lockForm.BeginInvoke((Delegate) (() => coinappMods.desktop.Unlock()));
                      this.Dispose();
                      this.Close();
                    }
                    else
                    {
                      coinappMods.SerialComPort.Write("CREDITS=" + Conversions.ToString(checked (result + coinappMods.credits)));
                      this.LOGGED = true;
                      e.Result = (object) "save";
                    }
                  }
                  else
                    e.Result = (object) "voucher:disc";
                }
              }
            }
          }
          else
          {
            int result = 0;
            if (!int.TryParse(this.voucherTemp[2].ToString(), out result))
              result = 0;
            int num1 = result % 60;
            int num2 = checked ((int) Math.Round(unchecked ((double) checked (result - num1) / 60.0 % 60.0)));
            int num3 = checked ((int) Math.Round(unchecked ((double) checked (result - num1 + num2 * 60) / 3600.0 % 60.0)));
            if (result <= 0)
            {
              e.Result = (object) "voucher:used";
            }
            else
            {
              DialogResult dialogResult;
              if (coinappMods.desktop.IsLocked)
                this.Invoke((Delegate) (() => dialogResult = MessageBox.Show("Do you want to use this COUPON VOUCHER? \r\nTime credits: " + (closure_4 > 0 ? Conversions.ToString(closure_4) + " " + (closure_4 == 1 ? "hour " : "hours ") : "") + (closure_5 > 0 ? Conversions.ToString(closure_5) + " " + (closure_5 == 1 ? "minute " : "minutes ") : "") + (closure_6 > 0 ? Conversions.ToString(closure_6) + " " + (closure_6 == 1 ? "second" : "seconds") : "") + "\r\n\r\nWARNING: Coupon voucher is one time use only. Once you click OK and the time credits will count, this voucher is cannot use anymore. Are you sure?", "Use voucher to login", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)));
              else
                this.Invoke((Delegate) (() => dialogResult = MessageBox.Show("Do you want to add time credits from this COUPON VOUCHER?\r\nTime credits: " + (closure_4 > 0 ? Conversions.ToString(closure_4) + " " + (closure_4 == 1 ? "hour " : "hours ") : "") + (closure_5 > 0 ? Conversions.ToString(closure_5) + " " + (closure_5 == 1 ? "minute " : "minutes ") : "") + (closure_6 > 0 ? Conversions.ToString(closure_6) + " " + (closure_6 == 1 ? "second" : "seconds") : "") + "\r\n\r\nWARNING: Coupon voucher is one time use only. Once you click OK and time credits will add, this voucher is cannot use anymore. Are you sure?", "Add time credits from voucher", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)));
              if (dialogResult != DialogResult.OK)
              {
                e.Result = (object) "cancel";
              }
              else
              {
                this.BeginInvoke((Delegate) (() => this.ControlBox = false));
                this.BeginInvoke((Delegate) (() => this.btn_use.Text = "Please wait..."));
                this.vCommand.CommandText = "UPDATE coupons SET [Status]='Used', [Date Used]='" + Strings.Format((object) now, "yyyy/MM/dd @ hh:mm:ss tt") + "' WHERE [ID]='" + this.voucherTemp[1].ToString() + "'";
                try
                {
                  this.vCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                  ProjectData.SetProjectError(ex);
                  Exception exception = ex;
                  e.Result = (object) exception.Message;
                  ProjectData.ClearProjectError();
                  return;
                }
                if (coinappMods.SerialComPort.IsOpen)
                {
                  if (coinappMods.desktop.IsLocked)
                  {
                    coinappMods.CREDITSTYPE = 1;
                    this.LOGGED = true;
                    coinappMods.SerialComPort.Write("CREDITS=" + Conversions.ToString(result));
                    coinappMods.SerialComPort.Write("COUNT=1");
                    this.working = false;
                    coinappMods.desktop.lockForm.BeginInvoke((Delegate) (() => coinappMods.desktop.Unlock()));
                    this.Dispose();
                    this.Close();
                  }
                  else
                  {
                    coinappMods.SerialComPort.Write("CREDITS=" + Conversions.ToString(checked (result + coinappMods.credits)));
                    this.LOGGED = true;
                    e.Result = (object) "save";
                  }
                }
                else
                  e.Result = (object) "voucher:disc";
              }
            }
          }
        }
      }
      else
        e.Result = (object) "voucher:error";
    }

    private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      if (!this.LOGGED && Operators.CompareString(e.Result.ToString(), "cancel", false) != 0)
      {
        string Left = Conversions.ToString(e.Result);
        if (Operators.CompareString(Left, "voucher:error", false) == 0)
        {
          int num1 = (int) Interaction.MsgBox((object) "You cannot use a voucher at this time. Please try again later. Or contact the owner", MsgBoxStyle.Critical, (object) "Voucher error");
        }
        else if (Operators.CompareString(Left, "voucher:invalid", false) == 0)
        {
          int num2 = (int) Interaction.MsgBox((object) "Your voucher is invalid voucher", MsgBoxStyle.Critical, (object) "Invalid voucher");
        }
        else if (Operators.CompareString(Left, "voucher:check", false) == 0)
        {
          int num3 = (int) Interaction.MsgBox((object) "Please check your voucher and try again.", MsgBoxStyle.Critical, (object) null);
        }
        else if (Operators.CompareString(Left, "voucher:used", false) == 0)
        {
          int num4 = (int) Interaction.MsgBox((object) "Your voucher has been used. Buy a new voucher.", MsgBoxStyle.Critical, (object) "Voucher used");
        }
        else if (Operators.CompareString(Left, "voucher:expired", false) == 0)
        {
          int num5 = (int) Interaction.MsgBox((object) ("Sorry, your voucher is expired. Buy a new voucher\r\nExpiration date: " + Conversions.ToString(this.vDate)), MsgBoxStyle.Critical, (object) "Voucher expired");
        }
        else if (Operators.CompareString(Left, "nodevice", false) == 0)
        {
          int num6 = (int) Interaction.MsgBox((object) "Device is not connected.", MsgBoxStyle.Critical, (object) "Device error");
        }
        else
        {
          int num7 = (int) Interaction.MsgBox(RuntimeHelpers.GetObjectValue(e.Result), MsgBoxStyle.Critical, (object) null);
        }
        coinappMods.voucher.close();
        this.vCommand.Dispose();
        this.vCommand = (OleDbCommand) null;
      }
      if (Operators.ConditionalCompareObjectEqual(e.Result, (object) "cancel", false))
      {
        coinappMods.voucher.close();
        this.vCommand.Dispose();
        this.vCommand = (OleDbCommand) null;
      }
      this.txtbx_voucher.Enabled = true;
      this.btn_use.Text = "Use voucher";
      if (Operators.CompareString(this.txtbx_voucher.Text, "", false) != 0 && Operators.CompareString(this.txtbx_voucher.Text, "voucher id", false) != 0)
        this.btn_use.Enabled = true;
      else
        this.btn_use.Enabled = false;
      this.voucherTemp = (ArrayList) null;
      this.vDate = new DateTime();
      this.working = false;
      if (!Operators.ConditionalCompareObjectEqual(e.Result, (object) "save", false))
        return;
      coinappMods.voucher.close();
      this.vCommand.Dispose();
      this.vCommand = (OleDbCommand) null;
      int num = (int) Interaction.MsgBox((object) "Voucher credits added to your time successfully..", MsgBoxStyle.Information, (object) "Voucher coupon added");
      this.Close();
    }

    private void txtbx_voucher_GotFocus(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.txtbx_voucher.Text, "voucher id", false) != 0)
        return;
      this.txtbx_voucher.Clear();
      this.txtbx_voucher.ForeColor = Color.Black;
    }

    private void txtbx_voucher_TextChanged(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.txtbx_voucher.Text, "", false) != 0)
      {
        if (Operators.CompareString(this.txtbx_voucher.Text, "voucher id", false) != 0)
          this.btn_use.Enabled = true;
        else
          this.btn_use.Enabled = false;
      }
      else
        this.btn_use.Enabled = false;
    }

    private void txtbx_voucher_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      if (Operators.CompareString(this.txtbx_voucher.Text, "", false) == 0)
      {
        int num1 = (int) Interaction.MsgBox((object) "Input a voucher", MsgBoxStyle.Critical, (object) null);
      }
      else if (this.txtbx_voucher.Text.Length < 8)
      {
        int num2 = (int) Interaction.MsgBox((object) "Input a valid voucher", MsgBoxStyle.Critical, (object) null);
      }
      else
      {
        this.txtbx_voucher.Enabled = false;
        this.btn_use.Enabled = false;
        this.btn_use.Text = "Checking voucher...";
        this.worker = new BackgroundWorker();
        if (coinappMods.desktop.IsLocked)
          this.worker.RunWorkerAsync((object) "login");
        else
          this.worker.RunWorkerAsync((object) "save");
      }
    }

    private void txtbx_voucher_LostFocus(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.txtbx_voucher.Text, "", false) != 0)
        return;
      this.txtbx_voucher.ForeColor = Color.DimGray;
      this.txtbx_voucher.Text = "voucher id";
      this.btn_use.Enabled = false;
    }

    private delegate void MyDelegate();
  }
}
