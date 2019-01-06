// Decompiled with JetBrains decompiler
// Type: coinapp.form_dialog
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
  public class form_dialog : Form
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private IContainer components;
    [AccessedThroughProperty("TableLayoutPanel1")]
    private TableLayoutPanel _TableLayoutPanel1;
    [AccessedThroughProperty("Panel1")]
    private Panel _Panel1;
    [AccessedThroughProperty("btn_1")]
    private Button _btn_1;
    [AccessedThroughProperty("btn_2")]
    private Button _btn_2;
    [AccessedThroughProperty("Panel2")]
    private Panel _Panel2;
    [AccessedThroughProperty("pb_icon")]
    private PictureBox _pb_icon;
    [AccessedThroughProperty("lbl_message")]
    private Label _lbl_message;
    private DialogResult result;

    [DebuggerNonUserCode]
    static form_dialog()
    {
    }

    public form_dialog()
    {
      this.FormClosing += new FormClosingEventHandler(this.form_dialog_FormClosing);
      this.Load += new EventHandler(this.form_dialog_Load);
      form_dialog.__ENCAddToList((object) this);
      this.result = DialogResult.None;
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (form_dialog.__ENCList)
      {
        if (form_dialog.__ENCList.Count == form_dialog.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (form_dialog.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (form_dialog.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                form_dialog.__ENCList[index1] = form_dialog.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          form_dialog.__ENCList.RemoveRange(index1, checked (form_dialog.__ENCList.Count - index1));
          form_dialog.__ENCList.Capacity = form_dialog.__ENCList.Count;
        }
        form_dialog.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
      }
    }

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
      this.TableLayoutPanel1 = new TableLayoutPanel();
      this.Panel1 = new Panel();
      this.btn_2 = new Button();
      this.btn_1 = new Button();
      this.Panel2 = new Panel();
      this.lbl_message = new Label();
      this.pb_icon = new PictureBox();
      this.TableLayoutPanel1.SuspendLayout();
      this.Panel1.SuspendLayout();
      this.Panel2.SuspendLayout();
      ((ISupportInitialize) this.pb_icon).BeginInit();
      this.SuspendLayout();
      this.TableLayoutPanel1.ColumnCount = 1;
      this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
      this.TableLayoutPanel1.Controls.Add((Control) this.Panel1, 0, 1);
      this.TableLayoutPanel1.Controls.Add((Control) this.Panel2, 0, 0);
      this.TableLayoutPanel1.Dock = DockStyle.Fill;
      TableLayoutPanel tableLayoutPanel1_1 = this.TableLayoutPanel1;
      Point point1 = new Point(0, 0);
      Point point2 = point1;
      tableLayoutPanel1_1.Location = point2;
      this.TableLayoutPanel1.Name = "TableLayoutPanel1";
      this.TableLayoutPanel1.RowCount = 2;
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50f));
      TableLayoutPanel tableLayoutPanel1_2 = this.TableLayoutPanel1;
      Size size1 = new Size(434, 162);
      Size size2 = size1;
      tableLayoutPanel1_2.Size = size2;
      this.TableLayoutPanel1.TabIndex = 0;
      this.Panel1.Controls.Add((Control) this.btn_2);
      this.Panel1.Controls.Add((Control) this.btn_1);
      this.Panel1.Dock = DockStyle.Fill;
      Panel panel1_1 = this.Panel1;
      point1 = new Point(3, 115);
      Point point3 = point1;
      panel1_1.Location = point3;
      this.Panel1.Name = "Panel1";
      Panel panel1_2 = this.Panel1;
      size1 = new Size(428, 44);
      Size size3 = size1;
      panel1_2.Size = size3;
      this.Panel1.TabIndex = 0;
      this.btn_2.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Button btn2_1 = this.btn_2;
      point1 = new Point(325, 9);
      Point point4 = point1;
      btn2_1.Location = point4;
      this.btn_2.Name = "btn_2";
      Button btn2_2 = this.btn_2;
      size1 = new Size(90, 25);
      Size size4 = size1;
      btn2_2.Size = size4;
      this.btn_2.TabIndex = 0;
      this.btn_2.TabStop = false;
      this.btn_2.Text = "Button 2";
      this.btn_2.UseVisualStyleBackColor = true;
      this.btn_1.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Button btn1_1 = this.btn_1;
      point1 = new Point(229, 9);
      Point point5 = point1;
      btn1_1.Location = point5;
      this.btn_1.Name = "btn_1";
      Button btn1_2 = this.btn_1;
      size1 = new Size(90, 25);
      Size size5 = size1;
      btn1_2.Size = size5;
      this.btn_1.TabIndex = 0;
      this.btn_1.TabStop = false;
      this.btn_1.Text = "Button 1";
      this.btn_1.UseVisualStyleBackColor = true;
      this.Panel2.BackColor = Color.White;
      this.Panel2.Controls.Add((Control) this.lbl_message);
      this.Panel2.Controls.Add((Control) this.pb_icon);
      this.Panel2.Dock = DockStyle.Fill;
      Panel panel2_1 = this.Panel2;
      point1 = new Point(3, 3);
      Point point6 = point1;
      panel2_1.Location = point6;
      this.Panel2.Name = "Panel2";
      Panel panel2_2 = this.Panel2;
      size1 = new Size(428, 106);
      Size size6 = size1;
      panel2_2.Size = size6;
      this.Panel2.TabIndex = 0;
      this.lbl_message.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label lblMessage1 = this.lbl_message;
      point1 = new Point(69, 6);
      Point point7 = point1;
      lblMessage1.Location = point7;
      this.lbl_message.Name = "lbl_message";
      Label lblMessage2 = this.lbl_message;
      size1 = new Size(350, 93);
      Size size7 = size1;
      lblMessage2.Size = size7;
      this.lbl_message.TabIndex = 0;
      this.lbl_message.Text = "Insert a coin to charge the 'admin' account.\r\n---User account credits: 0 (No time credits)\r\n---Coin inserted: 0\r\n---Time added: 0\r\nClick OK when done.";
      this.lbl_message.TextAlign = ContentAlignment.MiddleLeft;
      this.pb_icon.BackgroundImageLayout = ImageLayout.Zoom;
      PictureBox pbIcon1 = this.pb_icon;
      point1 = new Point(23, 35);
      Point point8 = point1;
      pbIcon1.Location = point8;
      this.pb_icon.Name = "pb_icon";
      PictureBox pbIcon2 = this.pb_icon;
      size1 = new Size(35, 35);
      Size size8 = size1;
      pbIcon2.Size = size8;
      this.pb_icon.TabIndex = 0;
      this.pb_icon.TabStop = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(434, 162);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.TableLayoutPanel1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      size1 = new Size(450, 200);
      this.MaximumSize = size1;
      this.MinimizeBox = false;
      size1 = new Size(450, 200);
      this.MinimumSize = size1;
      this.Name = nameof (form_dialog);
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.TopMost = true;
      this.TableLayoutPanel1.ResumeLayout(false);
      this.Panel1.ResumeLayout(false);
      this.Panel2.ResumeLayout(false);
      ((ISupportInitialize) this.pb_icon).EndInit();
      this.ResumeLayout(false);
    }

    internal virtual TableLayoutPanel TableLayoutPanel1
    {
      [DebuggerNonUserCode] get
      {
        return this._TableLayoutPanel1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TableLayoutPanel1 = value;
      }
    }

    internal virtual Panel Panel1
    {
      [DebuggerNonUserCode] get
      {
        return this._Panel1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Panel1 = value;
      }
    }

    internal virtual Button btn_1
    {
      [DebuggerNonUserCode] get
      {
        return this._btn_1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btn_1_Click);
        if (this._btn_1 != null)
          this._btn_1.Click -= eventHandler;
        this._btn_1 = value;
        if (this._btn_1 == null)
          return;
        this._btn_1.Click += eventHandler;
      }
    }

    internal virtual Button btn_2
    {
      [DebuggerNonUserCode] get
      {
        return this._btn_2;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btn_2_Click);
        if (this._btn_2 != null)
          this._btn_2.Click -= eventHandler;
        this._btn_2 = value;
        if (this._btn_2 == null)
          return;
        this._btn_2.Click += eventHandler;
      }
    }

    internal virtual Panel Panel2
    {
      [DebuggerNonUserCode] get
      {
        return this._Panel2;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Panel2 = value;
      }
    }

    internal virtual PictureBox pb_icon
    {
      [DebuggerNonUserCode] get
      {
        return this._pb_icon;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._pb_icon = value;
      }
    }

    public virtual Label lbl_message
    {
      [DebuggerNonUserCode] get
      {
        return this._lbl_message;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lbl_message = value;
      }
    }

    public DialogResult Show(
      string message,
      string title,
      MessageBoxButtons buttons = MessageBoxButtons.OK,
      MessageBoxIcon icon = MessageBoxIcon.None)
    {
      this.Text = title;
      this.lbl_message.Text = message;
      switch (buttons)
      {
        case MessageBoxButtons.OK:
          this.btn_1.Visible = false;
          this.btn_2.Text = "OK";
          break;
        case MessageBoxButtons.OKCancel:
          this.btn_1.Text = "OK";
          this.btn_2.Text = "Cancel";
          break;
        case MessageBoxButtons.YesNo:
          this.btn_1.Text = "Yes";
          this.btn_2.Text = "No";
          break;
      }
      MessageBoxIcon messageBoxIcon = icon;
      if (messageBoxIcon == MessageBoxIcon.Asterisk)
        this.pb_icon.BackgroundImage = (Image) SystemIcons.Asterisk.ToBitmap();
      else if (messageBoxIcon == MessageBoxIcon.Hand)
        this.pb_icon.BackgroundImage = (Image) SystemIcons.Error.ToBitmap();
      else if (messageBoxIcon == MessageBoxIcon.Exclamation)
        this.pb_icon.BackgroundImage = (Image) SystemIcons.Exclamation.ToBitmap();
      else if (messageBoxIcon == MessageBoxIcon.Hand)
        this.pb_icon.BackgroundImage = (Image) SystemIcons.Hand.ToBitmap();
      else if (messageBoxIcon == MessageBoxIcon.Asterisk)
        this.pb_icon.BackgroundImage = (Image) SystemIcons.Information.ToBitmap();
      else if (messageBoxIcon == MessageBoxIcon.None)
        this.pb_icon.BackgroundImage = (Image) SystemIcons.WinLogo.ToBitmap();
      else if (messageBoxIcon == MessageBoxIcon.Question)
        this.pb_icon.BackgroundImage = (Image) SystemIcons.Question.ToBitmap();
      else if (messageBoxIcon == MessageBoxIcon.Hand)
        this.pb_icon.BackgroundImage = (Image) SystemIcons.Shield.ToBitmap();
      else if (messageBoxIcon == MessageBoxIcon.Exclamation)
        this.pb_icon.BackgroundImage = (Image) SystemIcons.Warning.ToBitmap();
      int num = (int) this.ShowDialog();
      if (coinappMods.CHARGE)
      {
        if (coinappMods.SerialComPort.IsOpen)
          coinappMods.SerialComPort.Write("CREDITS=0");
        coinappMods.credits = 0;
        coinappMods.coinCredits = 0;
        coinappMods.coin = 0;
        coinappMods.userAccount = "";
        coinappMods.account.close();
        coinappMods.aCommand.Dispose();
        coinappMods.aCommand = (OleDbCommand) null;
        coinappMods.CHARGE = false;
      }
      if (this.result == DialogResult.None)
        return DialogResult.Cancel;
      return this.result;
    }

    private void btn_1_Click(object sender, EventArgs e)
    {
      string text = this.btn_1.Text;
      if (Operators.CompareString(text, "OK", false) == 0)
        this.result = DialogResult.OK;
      else if (Operators.CompareString(text, "Yes", false) == 0)
        this.result = DialogResult.Yes;
      this.Close();
    }

    private void btn_2_Click(object sender, EventArgs e)
    {
      string text = this.btn_2.Text;
      if (Operators.CompareString(text, "OK", false) == 0)
        this.result = DialogResult.OK;
      else if (Operators.CompareString(text, "Cancel", false) == 0)
        this.result = DialogResult.Cancel;
      else if (Operators.CompareString(text, "No", false) == 0)
        this.result = DialogResult.No;
      this.Close();
    }

    private void form_dialog_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (this.result == DialogResult.None)
      {
        string text = this.btn_2.Text;
        if (Operators.CompareString(text, "OK", false) == 0)
          this.result = DialogResult.OK;
        else if (Operators.CompareString(text, "Cancel", false) == 0)
          this.result = DialogResult.Cancel;
        else if (Operators.CompareString(text, "No", false) == 0)
          this.result = DialogResult.No;
      }
      this.Dispose();
    }

    private void form_dialog_Load(object sender, EventArgs e)
    {
      this.ActiveControl = (Control) null;
      if (MyProject.Forms.form_login.Visible)
        MyProject.Forms.form_login.Close();
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
      if (!coinappMods.CHARGE)
      {
        if (MyProject.Forms.form_account_create.Visible)
          MyProject.Forms.form_account_create.Close();
      }
      else
      {
        string filePath;
        try
        {
          filePath = coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("data")), "data");
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          int num = (int) Interaction.MsgBox((object) "You cannot charge a user account at this time. Contact the owner.", MsgBoxStyle.Critical, (object) "Save data error");
          ProjectData.ClearProjectError();
          return;
        }
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
          int num1 = (int) Interaction.MsgBox((object) "You cannot charge a user account at this time. Contact the owner.", MsgBoxStyle.Critical, (object) "Save data path error");
        }
        else if (!File.Exists(filePath + str1 + ".mdb"))
        {
          int num2 = (int) Interaction.MsgBox((object) "You cannot charge a user account at this time. Contact the owner.", MsgBoxStyle.Critical, (object) "Database error");
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
            int num3 = (int) Interaction.MsgBox((object) "You cannot charge a user account at this time. Contact the owner.", MsgBoxStyle.Critical, (object) "Database not available");
          }
          else
          {
            coinappMods.credits = 0;
            ArrayList arrayList1 = new ArrayList();
            coinappMods.aCommand = new OleDbCommand();
            coinappMods.aCommand.Connection = coinappMods.account.conn;
            coinappMods.aCommand.CommandText = "SELECT * FROM users WHERE ( Username = '" + coinappMods.userAccount + "')";
            try
            {
              coinappMods.aCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              this.lbl_message.Text = "Charging user account error. Cannot continue";
              ProjectData.ClearProjectError();
              return;
            }
            OleDbDataReader oleDbDataReader = coinappMods.aCommand.ExecuteReader();
            ArrayList arrayList2 = new ArrayList();
            while (oleDbDataReader.Read())
              arrayList2.Add((object) oleDbDataReader["Credits"].ToString());
            oleDbDataReader.Close();
            if (arrayList2.Count <= 0)
            {
              this.lbl_message.Text = "Charging user account error. Cannot continue";
            }
            else
            {
              if (!int.TryParse(arrayList2[0].ToString(), out coinappMods.credits))
                coinappMods.credits = 0;
              int num4 = coinappMods.credits % 60;
              int num5 = checked ((int) Math.Round(unchecked ((double) checked (coinappMods.credits - num4) / 60.0 % 60.0)));
              int num6 = checked ((int) Math.Round(unchecked ((double) checked (coinappMods.credits - num4 + num5 * 60) / 3600.0 % 60.0)));
              this.lbl_message.Text = "Insert a coin to charge the '" + coinappMods.userAccount + "' user account.\r\n---User account credits: " + (coinappMods.credits > 0 ? (num6 > 0 ? Conversions.ToString(num6) + " " + (num6 == 1 ? "hour " : "hours ") : "") + (num5 > 0 ? Conversions.ToString(num5) + " " + (num5 == 1 ? "minute " : "minutes ") : "") + (num4 > 0 ? Conversions.ToString(num4) + " " + (num4 == 1 ? "second" : "seconds") : "") : "(No time credits)") + "\r\n---Coin inserted: 0\r\n---Time added: (No time added)\r\nClick OK when done.";
            }
          }
        }
      }
    }
  }
}
