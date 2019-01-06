// Decompiled with JetBrains decompiler
// Type: coinapp.form_account_create
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
  public class form_account_create : Form
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private IContainer components;
    [AccessedThroughProperty("txtbx_email")]
    private TextBox _txtbx_email;
    [AccessedThroughProperty("txtbx_fullname")]
    private TextBox _txtbx_fullname;
    [AccessedThroughProperty("txtbx_password")]
    private TextBox _txtbx_password;
    [AccessedThroughProperty("txtbx_username")]
    private TextBox _txtbx_username;
    [AccessedThroughProperty("txtbx_repeat")]
    private TextBox _txtbx_repeat;
    [AccessedThroughProperty("btn_create")]
    private Button _btn_create;
    private database a;
    private ArrayList userTemp;
    private bool success;
    private bool working;
    [AccessedThroughProperty("worker")]
    private BackgroundWorker _worker;

    [DebuggerNonUserCode]
    static form_account_create()
    {
    }

    [DebuggerNonUserCode]
    public form_account_create()
    {
      this.Load += new EventHandler(this.form_account_create_Load);
      form_account_create.__ENCAddToList((object) this);
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (form_account_create.__ENCList)
      {
        if (form_account_create.__ENCList.Count == form_account_create.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (form_account_create.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (form_account_create.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                form_account_create.__ENCList[index1] = form_account_create.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          form_account_create.__ENCList.RemoveRange(index1, checked (form_account_create.__ENCList.Count - index1));
          form_account_create.__ENCList.Capacity = form_account_create.__ENCList.Count;
        }
        form_account_create.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
      this.txtbx_email = new TextBox();
      this.txtbx_fullname = new TextBox();
      this.txtbx_password = new TextBox();
      this.txtbx_username = new TextBox();
      this.txtbx_repeat = new TextBox();
      this.btn_create = new Button();
      this.SuspendLayout();
      this.txtbx_email.Enabled = false;
      this.txtbx_email.ForeColor = Color.DimGray;
      TextBox txtbxEmail1 = this.txtbx_email;
      Point point1 = new Point(29, 114);
      Point point2 = point1;
      txtbxEmail1.Location = point2;
      this.txtbx_email.Name = "txtbx_email";
      TextBox txtbxEmail2 = this.txtbx_email;
      Size size1 = new Size(190, 20);
      Size size2 = size1;
      txtbxEmail2.Size = size2;
      this.txtbx_email.TabIndex = 4;
      this.txtbx_email.Text = "Email";
      this.txtbx_fullname.Enabled = false;
      this.txtbx_fullname.ForeColor = Color.DimGray;
      TextBox txtbxFullname1 = this.txtbx_fullname;
      point1 = new Point(29, 88);
      Point point3 = point1;
      txtbxFullname1.Location = point3;
      this.txtbx_fullname.Name = "txtbx_fullname";
      TextBox txtbxFullname2 = this.txtbx_fullname;
      size1 = new Size(190, 20);
      Size size3 = size1;
      txtbxFullname2.Size = size3;
      this.txtbx_fullname.TabIndex = 3;
      this.txtbx_fullname.Text = "Full Name";
      this.txtbx_password.Enabled = false;
      this.txtbx_password.ForeColor = Color.DimGray;
      TextBox txtbxPassword1 = this.txtbx_password;
      point1 = new Point(29, 36);
      Point point4 = point1;
      txtbxPassword1.Location = point4;
      this.txtbx_password.Name = "txtbx_password";
      TextBox txtbxPassword2 = this.txtbx_password;
      size1 = new Size(190, 20);
      Size size4 = size1;
      txtbxPassword2.Size = size4;
      this.txtbx_password.TabIndex = 1;
      this.txtbx_password.Text = "Password";
      this.txtbx_username.Enabled = false;
      this.txtbx_username.ForeColor = Color.DimGray;
      TextBox txtbxUsername1 = this.txtbx_username;
      point1 = new Point(29, 12);
      Point point5 = point1;
      txtbxUsername1.Location = point5;
      this.txtbx_username.Name = "txtbx_username";
      TextBox txtbxUsername2 = this.txtbx_username;
      size1 = new Size(190, 20);
      Size size5 = size1;
      txtbxUsername2.Size = size5;
      this.txtbx_username.TabIndex = 0;
      this.txtbx_username.Text = "Username";
      this.txtbx_repeat.Enabled = false;
      this.txtbx_repeat.ForeColor = Color.DimGray;
      TextBox txtbxRepeat1 = this.txtbx_repeat;
      point1 = new Point(29, 62);
      Point point6 = point1;
      txtbxRepeat1.Location = point6;
      this.txtbx_repeat.Name = "txtbx_repeat";
      TextBox txtbxRepeat2 = this.txtbx_repeat;
      size1 = new Size(190, 20);
      Size size6 = size1;
      txtbxRepeat2.Size = size6;
      this.txtbx_repeat.TabIndex = 2;
      this.txtbx_repeat.Text = "Repeat password";
      this.btn_create.Enabled = false;
      Button btnCreate1 = this.btn_create;
      point1 = new Point(29, 150);
      Point point7 = point1;
      btnCreate1.Location = point7;
      this.btn_create.Name = "btn_create";
      Button btnCreate2 = this.btn_create;
      size1 = new Size(190, 45);
      Size size7 = size1;
      btnCreate2.Size = size7;
      this.btn_create.TabIndex = 5;
      this.btn_create.TabStop = false;
      this.btn_create.Text = "Create account";
      this.btn_create.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(244, 216);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.btn_create);
      this.Controls.Add((Control) this.txtbx_email);
      this.Controls.Add((Control) this.txtbx_fullname);
      this.Controls.Add((Control) this.txtbx_repeat);
      this.Controls.Add((Control) this.txtbx_password);
      this.Controls.Add((Control) this.txtbx_username);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.MaximizeBox = false;
      size1 = new Size(260, 250);
      this.MaximumSize = size1;
      this.MinimizeBox = false;
      size1 = new Size(260, 250);
      this.MinimumSize = size1;
      this.Name = nameof (form_account_create);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Create user account";
      this.TopMost = true;
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual TextBox txtbx_email
    {
      [DebuggerNonUserCode] get
      {
        return this._txtbx_email;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtbx_account_LostFocus);
        EventHandler eventHandler2 = new EventHandler(this.txtbx_account_GotFocus);
        if (this._txtbx_email != null)
        {
          this._txtbx_email.LostFocus -= eventHandler1;
          this._txtbx_email.GotFocus -= eventHandler2;
        }
        this._txtbx_email = value;
        if (this._txtbx_email == null)
          return;
        this._txtbx_email.LostFocus += eventHandler1;
        this._txtbx_email.GotFocus += eventHandler2;
      }
    }

    internal virtual TextBox txtbx_fullname
    {
      [DebuggerNonUserCode] get
      {
        return this._txtbx_fullname;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtbx_account_LostFocus);
        EventHandler eventHandler2 = new EventHandler(this.txtbx_account_GotFocus);
        if (this._txtbx_fullname != null)
        {
          this._txtbx_fullname.LostFocus -= eventHandler1;
          this._txtbx_fullname.GotFocus -= eventHandler2;
        }
        this._txtbx_fullname = value;
        if (this._txtbx_fullname == null)
          return;
        this._txtbx_fullname.LostFocus += eventHandler1;
        this._txtbx_fullname.GotFocus += eventHandler2;
      }
    }

    internal virtual TextBox txtbx_password
    {
      [DebuggerNonUserCode] get
      {
        return this._txtbx_password;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtbx_TextChanged);
        EventHandler eventHandler2 = new EventHandler(this.txtbx_account_LostFocus);
        EventHandler eventHandler3 = new EventHandler(this.txtbx_account_GotFocus);
        if (this._txtbx_password != null)
        {
          this._txtbx_password.TextChanged -= eventHandler1;
          this._txtbx_password.LostFocus -= eventHandler2;
          this._txtbx_password.GotFocus -= eventHandler3;
        }
        this._txtbx_password = value;
        if (this._txtbx_password == null)
          return;
        this._txtbx_password.TextChanged += eventHandler1;
        this._txtbx_password.LostFocus += eventHandler2;
        this._txtbx_password.GotFocus += eventHandler3;
      }
    }

    internal virtual TextBox txtbx_username
    {
      [DebuggerNonUserCode] get
      {
        return this._txtbx_username;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtbx_TextChanged);
        EventHandler eventHandler2 = new EventHandler(this.txtbx_account_LostFocus);
        EventHandler eventHandler3 = new EventHandler(this.txtbx_account_GotFocus);
        if (this._txtbx_username != null)
        {
          this._txtbx_username.TextChanged -= eventHandler1;
          this._txtbx_username.LostFocus -= eventHandler2;
          this._txtbx_username.GotFocus -= eventHandler3;
        }
        this._txtbx_username = value;
        if (this._txtbx_username == null)
          return;
        this._txtbx_username.TextChanged += eventHandler1;
        this._txtbx_username.LostFocus += eventHandler2;
        this._txtbx_username.GotFocus += eventHandler3;
      }
    }

    internal virtual TextBox txtbx_repeat
    {
      [DebuggerNonUserCode] get
      {
        return this._txtbx_repeat;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtbx_TextChanged);
        EventHandler eventHandler2 = new EventHandler(this.txtbx_account_LostFocus);
        EventHandler eventHandler3 = new EventHandler(this.txtbx_account_GotFocus);
        if (this._txtbx_repeat != null)
        {
          this._txtbx_repeat.TextChanged -= eventHandler1;
          this._txtbx_repeat.LostFocus -= eventHandler2;
          this._txtbx_repeat.GotFocus -= eventHandler3;
        }
        this._txtbx_repeat = value;
        if (this._txtbx_repeat == null)
          return;
        this._txtbx_repeat.TextChanged += eventHandler1;
        this._txtbx_repeat.LostFocus += eventHandler2;
        this._txtbx_repeat.GotFocus += eventHandler3;
      }
    }

    internal virtual Button btn_create
    {
      [DebuggerNonUserCode] get
      {
        return this._btn_create;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btn_create_Click);
        if (this._btn_create != null)
          this._btn_create.Click -= eventHandler;
        this._btn_create = value;
        if (this._btn_create == null)
          return;
        this._btn_create.Click += eventHandler;
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
      base.OnFormClosing(e);
    }

    private void txtbx_account_GotFocus(object sender, EventArgs e)
    {
      bool flag = true;
      if (flag == (sender == this.txtbx_username))
      {
        if (!Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (System.Type) null, "Text", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Username", false))
          return;
        NewLateBinding.LateCall(sender, (System.Type) null, "Clear", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null, true);
        NewLateBinding.LateSet(sender, (System.Type) null, "ForeColor", new object[1]
        {
          (object) Color.Black
        }, (string[]) null, (System.Type[]) null);
      }
      else if (flag == (sender == this.txtbx_password))
      {
        if (!Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (System.Type) null, "Text", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Password", false))
          return;
        NewLateBinding.LateCall(sender, (System.Type) null, "Clear", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null, true);
        this.txtbx_password.UseSystemPasswordChar = true;
        NewLateBinding.LateSet(sender, (System.Type) null, "ForeColor", new object[1]
        {
          (object) Color.Black
        }, (string[]) null, (System.Type[]) null);
      }
      else if (flag == (sender == this.txtbx_repeat))
      {
        if (!Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (System.Type) null, "Text", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Repeat password", false))
          return;
        NewLateBinding.LateCall(sender, (System.Type) null, "Clear", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null, true);
        this.txtbx_repeat.UseSystemPasswordChar = true;
        NewLateBinding.LateSet(sender, (System.Type) null, "ForeColor", new object[1]
        {
          (object) Color.Black
        }, (string[]) null, (System.Type[]) null);
      }
      else if (flag == (sender == this.txtbx_fullname))
      {
        if (!Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (System.Type) null, "Text", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Full Name", false))
          return;
        NewLateBinding.LateCall(sender, (System.Type) null, "Clear", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null, true);
        NewLateBinding.LateSet(sender, (System.Type) null, "ForeColor", new object[1]
        {
          (object) Color.Black
        }, (string[]) null, (System.Type[]) null);
      }
      else
      {
        if (flag != (sender == this.txtbx_email) || !Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (System.Type) null, "Text", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Email", false))
          return;
        NewLateBinding.LateCall(sender, (System.Type) null, "Clear", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null, true);
        NewLateBinding.LateSet(sender, (System.Type) null, "ForeColor", new object[1]
        {
          (object) Color.Black
        }, (string[]) null, (System.Type[]) null);
      }
    }

    private void txtbx_account_LostFocus(object sender, EventArgs e)
    {
      bool flag = true;
      if (flag == (sender == this.txtbx_username))
      {
        if (!Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (System.Type) null, "Text", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "", false))
          return;
        NewLateBinding.LateSet(sender, (System.Type) null, "ForeColor", new object[1]
        {
          (object) Color.DimGray
        }, (string[]) null, (System.Type[]) null);
        NewLateBinding.LateSet(sender, (System.Type) null, "Text", new object[1]
        {
          (object) "Username"
        }, (string[]) null, (System.Type[]) null);
      }
      else if (flag == (sender == this.txtbx_password))
      {
        if (!Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (System.Type) null, "Text", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "", false))
          return;
        if (this.txtbx_password.UseSystemPasswordChar)
          this.txtbx_password.BeginInvoke((Delegate) (() => this.txtbx_password.UseSystemPasswordChar = false));
        NewLateBinding.LateSet(sender, (System.Type) null, "ForeColor", new object[1]
        {
          (object) Color.DimGray
        }, (string[]) null, (System.Type[]) null);
        NewLateBinding.LateSet(sender, (System.Type) null, "Text", new object[1]
        {
          (object) "Password"
        }, (string[]) null, (System.Type[]) null);
      }
      else if (flag == (sender == this.txtbx_repeat))
      {
        if (!Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (System.Type) null, "Text", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "", false))
          return;
        if (this.txtbx_repeat.UseSystemPasswordChar)
          this.txtbx_repeat.BeginInvoke((Delegate) (() => this.txtbx_repeat.UseSystemPasswordChar = false));
        NewLateBinding.LateSet(sender, (System.Type) null, "ForeColor", new object[1]
        {
          (object) Color.DimGray
        }, (string[]) null, (System.Type[]) null);
        NewLateBinding.LateSet(sender, (System.Type) null, "Text", new object[1]
        {
          (object) "Repeat password"
        }, (string[]) null, (System.Type[]) null);
      }
      else if (flag == (sender == this.txtbx_fullname))
      {
        if (!Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (System.Type) null, "Text", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "", false))
          return;
        NewLateBinding.LateSet(sender, (System.Type) null, "ForeColor", new object[1]
        {
          (object) Color.DimGray
        }, (string[]) null, (System.Type[]) null);
        NewLateBinding.LateSet(sender, (System.Type) null, "Text", new object[1]
        {
          (object) "Full Name"
        }, (string[]) null, (System.Type[]) null);
      }
      else
      {
        if (flag != (sender == this.txtbx_email) || !Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (System.Type) null, "Text", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "", false))
          return;
        NewLateBinding.LateSet(sender, (System.Type) null, "ForeColor", new object[1]
        {
          (object) Color.DimGray
        }, (string[]) null, (System.Type[]) null);
        NewLateBinding.LateSet(sender, (System.Type) null, "Text", new object[1]
        {
          (object) "Email"
        }, (string[]) null, (System.Type[]) null);
      }
    }

    private void txtbx_TextChanged(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.txtbx_username.Text, "", false) != 0 && Operators.CompareString(this.txtbx_username.Text, "Username", false) != 0 && (Operators.CompareString(this.txtbx_password.Text, "", false) != 0 && Operators.CompareString(this.txtbx_password.Text, "Password", false) != 0) && (Operators.CompareString(this.txtbx_repeat.Text, "", false) != 0 && Operators.CompareString(this.txtbx_repeat.Text, "Repeat password", false) != 0))
        this.btn_create.Enabled = true;
      else
        this.btn_create.Enabled = false;
    }

    private void btn_create_Click(object sender, EventArgs e)
    {
      this.ActiveControl = (Control) null;
      if (Operators.CompareString(this.txtbx_username.Text, "", false) == 0 || Operators.CompareString(this.txtbx_username.Text, "Username", false) == 0 && Operators.CompareString(this.txtbx_password.Text, "", false) == 0 || (Operators.CompareString(this.txtbx_password.Text, "Password", false) == 0 && Operators.CompareString(this.txtbx_repeat.Text, "", false) == 0 || Operators.CompareString(this.txtbx_repeat.Text, "Repeat password", false) == 0))
      {
        int num1 = (int) Interaction.MsgBox((object) "Input text field", MsgBoxStyle.Critical, (object) null);
      }
      else if (Operators.CompareString(this.txtbx_password.Text, this.txtbx_repeat.Text, false) != 0)
      {
        int num2 = (int) Interaction.MsgBox((object) "Password and repeat password not match!", MsgBoxStyle.Critical, (object) null);
      }
      else
      {
        this.txtbx_username.Enabled = false;
        this.txtbx_password.Enabled = false;
        this.txtbx_repeat.Enabled = false;
        this.txtbx_fullname.Enabled = false;
        this.txtbx_email.Enabled = false;
        this.btn_create.Enabled = false;
        this.btn_create.Text = "Creating account...";
        this.worker = new BackgroundWorker();
        this.worker.RunWorkerAsync();
      }
    }

    private void form_account_create_Load(object sender, EventArgs e)
    {
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
      if (MyProject.Forms.form_dialog.Visible)
        MyProject.Forms.form_dialog.Close();
      string filePath;
      try
      {
        filePath = coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("data")), "data");
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) "You cannot register at this time. Contact the owner.", MsgBoxStyle.Critical, (object) "Feature not available");
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
        int num1 = (int) Interaction.MsgBox((object) "You cannot register at this time. Contact the owner.", MsgBoxStyle.Critical, (object) "Account not available: data path");
      }
      else if (!File.Exists(filePath + str1 + ".mdb"))
      {
        int num2 = (int) Interaction.MsgBox((object) "You cannot register at this time. Contact the owner.", MsgBoxStyle.Critical, (object) "Account not available");
      }
      else
      {
        this.a = new database(filePath, str1, str2);
        try
        {
          this.a.open();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        if (!this.a.isOpen)
        {
          int num3 = (int) Interaction.MsgBox((object) "You cannot register at this time. Contact the owner.", MsgBoxStyle.Critical, (object) "Account not available");
        }
        else
        {
          this.a.close();
          this.txtbx_username.Enabled = true;
          this.txtbx_password.Enabled = true;
          this.txtbx_repeat.Enabled = true;
          this.txtbx_fullname.Enabled = true;
          this.txtbx_email.Enabled = true;
        }
      }
    }

    private void worker_DoWork(object sender, DoWorkEventArgs e)
    {
      this.working = true;
      OleDbCommand oleDbCommand = new OleDbCommand();
      try
      {
        this.a.open();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        e.Result = (object) exception.Message;
        ProjectData.ClearProjectError();
        return;
      }
      if (!this.a.isOpen)
      {
        e.Result = (object) "closed";
      }
      else
      {
        string number;
        OleDbDataReader oleDbDataReader1;
        while (true)
        {
          number = this.a.generateNumber(5);
          this.userTemp = new ArrayList();
          oleDbCommand.CommandText = "SELECT * FROM users WHERE ([ID] = '" + number + "')";
          oleDbCommand.Connection = this.a.conn;
          try
          {
            oleDbCommand.ExecuteNonQuery();
            OleDbDataReader oleDbDataReader2 = oleDbCommand.ExecuteReader();
            while (oleDbDataReader2.Read())
            {
              this.userTemp.Add((object) oleDbDataReader2["ID"].ToString());
              this.userTemp.Add((object) oleDbDataReader2["Username"].ToString());
            }
            oleDbDataReader2.Close();
            oleDbDataReader1 = (OleDbDataReader) null;
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            Exception exception = ex;
            e.Result = (object) exception.Message;
            ProjectData.ClearProjectError();
            return;
          }
          if (this.userTemp.Count != 0)
            this.userTemp = (ArrayList) null;
          else
            break;
        }
        oleDbCommand.CommandText = "SELECT * FROM users WHERE ([Username] = '" + this.txtbx_username.Text + "')";
        try
        {
          oleDbCommand.ExecuteNonQuery();
          OleDbDataReader oleDbDataReader2 = oleDbCommand.ExecuteReader();
          while (oleDbDataReader2.Read())
            this.userTemp.Add((object) oleDbDataReader2["Username"].ToString());
          oleDbDataReader2.Close();
          oleDbDataReader1 = (OleDbDataReader) null;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Exception exception = ex;
          e.Result = (object) exception.Message;
          ProjectData.ClearProjectError();
          return;
        }
        if (this.userTemp.Count != 0)
        {
          this.userTemp = (ArrayList) null;
          e.Result = (object) "exists";
        }
        else
        {
          this.userTemp = (ArrayList) null;
          if (coinappMods.desktop.IsLocked)
          {
            string str = Strings.Format((object) DateAndTime.Now, "yyyy/MM/dd @ hh:mm:ss tt");
            oleDbCommand.CommandText = "INSERT INTO users ([ID], [Username], [Password], [Credits], [Created], [Full Name], [Email],  [Last Logged]) VALUES ('" + number + "', '" + this.txtbx_username.Text + "', '" + this.txtbx_password.Text + "','0', '" + str + "', '" + (Operators.CompareString(this.txtbx_fullname.Text, "", false) == 0 || Operators.CompareString(this.txtbx_fullname.Text, "Full Name", false) == 0 ? string.Empty : this.txtbx_fullname.Text) + "', '" + (Operators.CompareString(this.txtbx_email.Text, "", false) == 0 || Operators.CompareString(this.txtbx_email.Text, "Email", false) == 0 ? string.Empty : this.txtbx_email.Text) + "', '" + string.Empty + "')";
            try
            {
              oleDbCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              Exception exception = ex;
              e.Result = (object) exception.Message;
              ProjectData.ClearProjectError();
              return;
            }
            coinappMods.userAccount = this.txtbx_username.Text;
            oleDbCommand.Dispose();
            this.success = true;
          }
          else
          {
            // ISSUE: variable of a compiler-generated type
            form_account_create._Closure\u0024__3 other;
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            form_account_create._Closure\u0024__3 closure3 = new form_account_create._Closure\u0024__3(other);
            // ISSUE: reference to a compiler-generated method
            this.Invoke((Delegate) new form_account_create.MyDelegate(closure3._Lambda\u0024__36));
            // ISSUE: reference to a compiler-generated field
            if (closure3.\u0024VB\u0024Local_dlgr != DialogResult.OK)
            {
              e.Result = (object) "cancel";
            }
            else
            {
              string str = Strings.Format((object) DateAndTime.Now, "yyyy/MM/dd @ hh:mm:ss tt");
              oleDbCommand.CommandText = "INSERT INTO users ([ID], [Username], [Password], [Credits], [Created], [Full Name], [Email],  [Last Logged]) VALUES ('" + number + "', '" + this.txtbx_username.Text + "', '" + this.txtbx_password.Text + "','" + Conversions.ToString(coinappMods.credits) + "', '" + str + "', '" + (Operators.CompareString(this.txtbx_fullname.Text, "", false) == 0 || Operators.CompareString(this.txtbx_fullname.Text, "Full Name", false) == 0 ? string.Empty : this.txtbx_fullname.Text) + "', '" + (Operators.CompareString(this.txtbx_email.Text, "", false) == 0 || Operators.CompareString(this.txtbx_email.Text, "email", false) == 0 ? string.Empty : this.txtbx_email.Text) + "', '" + string.Empty + "')";
              try
              {
                oleDbCommand.ExecuteNonQuery();
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                Exception exception = ex;
                e.Result = (object) exception.Message;
                ProjectData.ClearProjectError();
                return;
              }
              coinappMods.userAccount = this.txtbx_username.Text;
              oleDbCommand.Dispose();
              this.success = true;
            }
          }
        }
      }
    }

    private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.a.close();
      this.working = false;
      if (!this.success)
      {
        string Left = e.Result.ToString();
        if (Operators.CompareString(Left, "closed", false) == 0)
        {
          int num1 = (int) Interaction.MsgBox((object) "Creating account failed. Contact the owner", MsgBoxStyle.Critical, (object) null);
        }
        else if (Operators.CompareString(Left, "exists", false) == 0)
        {
          int num2 = (int) Interaction.MsgBox((object) (this.txtbx_username.Text + " username already used. Try different username and try again."), MsgBoxStyle.Critical, (object) null);
        }
        else if (Operators.CompareString(Left, "cancel", false) == 0)
        {
          int num3 = (int) Interaction.MsgBox((object) "Creation of the user account canceled", MsgBoxStyle.Information, (object) null);
        }
        else
        {
          int num4 = (int) Interaction.MsgBox(RuntimeHelpers.GetObjectValue(e.Result), MsgBoxStyle.Critical, (object) null);
        }
      }
      else
      {
        this.success = false;
        this.txtbx_username.Text = "Username";
        this.txtbx_username.ForeColor = Color.DimGray;
        this.txtbx_password.UseSystemPasswordChar = false;
        this.txtbx_password.Text = "Password";
        this.txtbx_password.ForeColor = Color.DimGray;
        this.txtbx_repeat.Text = "Repeat password";
        this.txtbx_repeat.UseSystemPasswordChar = false;
        this.txtbx_repeat.ForeColor = Color.DimGray;
        this.txtbx_fullname.Text = "Full Name";
        this.txtbx_fullname.ForeColor = Color.DimGray;
        this.txtbx_email.Text = "Email";
        this.txtbx_email.ForeColor = Color.DimGray;
        if (coinappMods.desktop.IsLocked)
        {
          int num1 = (int) Interaction.MsgBox((object) (this.txtbx_username.Text + " user account created successfully."), MsgBoxStyle.Information, (object) null);
          if (MessageBox.Show("Do you want to add a time credits on this account?", "Add time", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
          {
            this.Close();
            coinappMods.CHARGE = true;
            int num2;
            coinappMods.desktop.lockForm.BeginInvoke((Delegate) (() => num2 = (int) MyProject.Forms.form_dialog.Show("Insert a coin to charge the '" + coinappMods.userAccount + "' user account...\r\n---User account credits: (No time credits)\r\n---Coin inserted: 0\r\n---Time added: (No time added)\r\nClick OK when done.", "Charging  '" + coinappMods.userAccount + "' user account...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)));
          }
        }
        else
        {
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
      }
      this.txtbx_username.Enabled = true;
      this.txtbx_password.Enabled = true;
      this.txtbx_repeat.Enabled = true;
      this.txtbx_fullname.Enabled = true;
      this.txtbx_email.Enabled = true;
      this.btn_create.Text = "Create account";
      this.btn_create.Enabled = true;
    }

    private delegate void MyDelegate();
  }
}
