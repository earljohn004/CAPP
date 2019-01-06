// Decompiled with JetBrains decompiler
// Type: coinapp.form_account
// Assembly: coinapp, Version=1.4.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6DB842CC-5810-43FB-8044-475700CA1E42
// Assembly location: C:\Users\EarlJohn\Desktop\Coinapp\coinapp_1.4.0.0\coinapp.exe

using coinapplib;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace coinapp
{
  [DesignerGenerated]
  public class form_account : Form
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private IContainer components;
    [AccessedThroughProperty("StatusStrip1")]
    private StatusStrip _StatusStrip1;
    [AccessedThroughProperty("GroupBox1")]
    private GroupBox _GroupBox1;
    [AccessedThroughProperty("gb_details")]
    private GroupBox _gb_details;
    [AccessedThroughProperty("txtbx_password")]
    private TextBox _txtbx_password;
    [AccessedThroughProperty("txtbx_username")]
    private TextBox _txtbx_username;
    [AccessedThroughProperty("GroupBox3")]
    private GroupBox _GroupBox3;
    [AccessedThroughProperty("Label5")]
    private Label _Label5;
    [AccessedThroughProperty("Label4")]
    private Label _Label4;
    [AccessedThroughProperty("nud_second")]
    private NumericUpDown _nud_second;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("nud_minute")]
    private NumericUpDown _nud_minute;
    [AccessedThroughProperty("nud_hour")]
    private NumericUpDown _nud_hour;
    [AccessedThroughProperty("btn_quickcreate")]
    private Button _btn_quickcreate;
    [AccessedThroughProperty("btn_create")]
    private Button _btn_create;
    [AccessedThroughProperty("txtbx_search")]
    private TextBox _txtbx_search;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("Label6")]
    private Label _Label6;
    [AccessedThroughProperty("cb_search")]
    private ComboBox _cb_search;
    [AccessedThroughProperty("btn_clear")]
    private Button _btn_clear;
    [AccessedThroughProperty("btn_search")]
    private Button _btn_search;
    [AccessedThroughProperty("btn_quickdel")]
    private Button _btn_quickdel;
    [AccessedThroughProperty("btn_delete")]
    private Button _btn_delete;
    [AccessedThroughProperty("dgv_account")]
    private DataGridView _dgv_account;
    [AccessedThroughProperty("btn_edit")]
    private Button _btn_edit;
    [AccessedThroughProperty("txtbx_email")]
    private TextBox _txtbx_email;
    [AccessedThroughProperty("txtbx_fullname")]
    private TextBox _txtbx_fullname;
    private database a;
    private ToolStripStatusLabel labelStatus;
    private bool working;
    private bool quick;
    private int selectedIndex;
    private ArrayList accountTemp;
    private bool edit;
    [AccessedThroughProperty("worker")]
    private BackgroundWorker _worker;

    [DebuggerNonUserCode]
    static form_account()
    {
    }

    [DebuggerNonUserCode]
    public form_account()
    {
      this.Load += new EventHandler(this.form_account_Load);
      form_account.__ENCAddToList((object) this);
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (form_account.__ENCList)
      {
        if (form_account.__ENCList.Count == form_account.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (form_account.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (form_account.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                form_account.__ENCList[index1] = form_account.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          form_account.__ENCList.RemoveRange(index1, checked (form_account.__ENCList.Count - index1));
          form_account.__ENCList.Capacity = form_account.__ENCList.Count;
        }
        form_account.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (form_account));
      this.StatusStrip1 = new StatusStrip();
      this.GroupBox1 = new GroupBox();
      this.dgv_account = new DataGridView();
      this.btn_edit = new Button();
      this.btn_quickdel = new Button();
      this.btn_delete = new Button();
      this.txtbx_search = new TextBox();
      this.Label2 = new Label();
      this.Label6 = new Label();
      this.cb_search = new ComboBox();
      this.btn_clear = new Button();
      this.btn_search = new Button();
      this.gb_details = new GroupBox();
      this.GroupBox3 = new GroupBox();
      this.Label5 = new Label();
      this.Label4 = new Label();
      this.nud_second = new NumericUpDown();
      this.Label3 = new Label();
      this.nud_minute = new NumericUpDown();
      this.nud_hour = new NumericUpDown();
      this.txtbx_email = new TextBox();
      this.txtbx_fullname = new TextBox();
      this.txtbx_password = new TextBox();
      this.txtbx_username = new TextBox();
      this.btn_quickcreate = new Button();
      this.btn_create = new Button();
      this.GroupBox1.SuspendLayout();
      ((ISupportInitialize) this.dgv_account).BeginInit();
      this.gb_details.SuspendLayout();
      this.GroupBox3.SuspendLayout();
      this.nud_second.BeginInit();
      this.nud_minute.BeginInit();
      this.nud_hour.BeginInit();
      this.SuspendLayout();
      StatusStrip statusStrip1_1 = this.StatusStrip1;
      Point point1 = new Point(0, 436);
      Point point2 = point1;
      statusStrip1_1.Location = point2;
      this.StatusStrip1.Name = "StatusStrip1";
      StatusStrip statusStrip1_2 = this.StatusStrip1;
      Size size1 = new Size(540, 22);
      Size size2 = size1;
      statusStrip1_2.Size = size2;
      this.StatusStrip1.TabIndex = 25;
      this.StatusStrip1.Text = "StatusStrip1";
      this.GroupBox1.Controls.Add((Control) this.dgv_account);
      this.GroupBox1.Controls.Add((Control) this.btn_edit);
      this.GroupBox1.Controls.Add((Control) this.btn_quickdel);
      this.GroupBox1.Controls.Add((Control) this.btn_delete);
      this.GroupBox1.Controls.Add((Control) this.txtbx_search);
      this.GroupBox1.Controls.Add((Control) this.Label2);
      this.GroupBox1.Controls.Add((Control) this.Label6);
      this.GroupBox1.Controls.Add((Control) this.cb_search);
      this.GroupBox1.Controls.Add((Control) this.btn_clear);
      this.GroupBox1.Controls.Add((Control) this.btn_search);
      GroupBox groupBox1_1 = this.GroupBox1;
      point1 = new Point(12, 157);
      Point point3 = point1;
      groupBox1_1.Location = point3;
      this.GroupBox1.Name = "GroupBox1";
      GroupBox groupBox1_2 = this.GroupBox1;
      size1 = new Size(519, 268);
      Size size3 = size1;
      groupBox1_2.Size = size3;
      this.GroupBox1.TabIndex = 14;
      this.GroupBox1.TabStop = false;
      this.dgv_account.AllowUserToAddRows = false;
      this.dgv_account.AllowUserToDeleteRows = false;
      this.dgv_account.AllowUserToResizeColumns = false;
      this.dgv_account.AllowUserToResizeRows = false;
      this.dgv_account.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
      this.dgv_account.BorderStyle = BorderStyle.Fixed3D;
      gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle1.BackColor = Color.DimGray;
      gridViewCellStyle1.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      gridViewCellStyle1.ForeColor = Color.White;
      gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
      this.dgv_account.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
      this.dgv_account.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle2.BackColor = SystemColors.Window;
      gridViewCellStyle2.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      gridViewCellStyle2.ForeColor = SystemColors.ControlText;
      gridViewCellStyle2.SelectionBackColor = SystemColors.HotTrack;
      gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
      this.dgv_account.DefaultCellStyle = gridViewCellStyle2;
      this.dgv_account.EditMode = DataGridViewEditMode.EditOnEnter;
      this.dgv_account.EnableHeadersVisualStyles = false;
      DataGridView dgvAccount1 = this.dgv_account;
      point1 = new Point(17, 59);
      Point point4 = point1;
      dgvAccount1.Location = point4;
      this.dgv_account.MultiSelect = false;
      this.dgv_account.Name = "dgv_account";
      this.dgv_account.RowHeadersVisible = false;
      this.dgv_account.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.dgv_account.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      DataGridView dgvAccount2 = this.dgv_account;
      size1 = new Size(486, 167);
      Size size4 = size1;
      dgvAccount2.Size = size4;
      this.dgv_account.TabIndex = 21;
      this.dgv_account.TabStop = false;
      this.btn_edit.Enabled = false;
      Button btnEdit1 = this.btn_edit;
      point1 = new Point(221, 232);
      Point point5 = point1;
      btnEdit1.Location = point5;
      this.btn_edit.Name = "btn_edit";
      Button btnEdit2 = this.btn_edit;
      size1 = new Size(90, 25);
      Size size5 = size1;
      btnEdit2.Size = size5;
      this.btn_edit.TabIndex = 22;
      this.btn_edit.TabStop = false;
      this.btn_edit.Text = "Edit";
      this.btn_edit.UseVisualStyleBackColor = true;
      this.btn_quickdel.Enabled = false;
      Button btnQuickdel1 = this.btn_quickdel;
      point1 = new Point(317, 232);
      Point point6 = point1;
      btnQuickdel1.Location = point6;
      this.btn_quickdel.Name = "btn_quickdel";
      Button btnQuickdel2 = this.btn_quickdel;
      size1 = new Size(90, 25);
      Size size6 = size1;
      btnQuickdel2.Size = size6;
      this.btn_quickdel.TabIndex = 23;
      this.btn_quickdel.TabStop = false;
      this.btn_quickdel.Text = "Quick Delete";
      this.btn_quickdel.UseVisualStyleBackColor = true;
      this.btn_delete.Enabled = false;
      Button btnDelete1 = this.btn_delete;
      point1 = new Point(413, 232);
      Point point7 = point1;
      btnDelete1.Location = point7;
      this.btn_delete.Name = "btn_delete";
      Button btnDelete2 = this.btn_delete;
      size1 = new Size(90, 25);
      Size size7 = size1;
      btnDelete2.Size = size7;
      this.btn_delete.TabIndex = 24;
      this.btn_delete.TabStop = false;
      this.btn_delete.Text = "Delete";
      this.btn_delete.UseVisualStyleBackColor = true;
      this.txtbx_search.Enabled = false;
      this.txtbx_search.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      TextBox txtbxSearch1 = this.txtbx_search;
      point1 = new Point(17, 31);
      Point point8 = point1;
      txtbxSearch1.Location = point8;
      this.txtbx_search.Name = "txtbx_search";
      TextBox txtbxSearch2 = this.txtbx_search;
      size1 = new Size(214, 22);
      Size size8 = size1;
      txtbxSearch2.Size = size8;
      this.txtbx_search.TabIndex = 16;
      this.Label2.AutoSize = true;
      Label label2_1 = this.Label2;
      point1 = new Point(14, 13);
      Point point9 = point1;
      label2_1.Location = point9;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(86, 13);
      Size size9 = size1;
      label2_2.Size = size9;
      this.Label2.TabIndex = 15;
      this.Label2.Text = "Search voucher:";
      this.Label6.AutoSize = true;
      Label label6_1 = this.Label6;
      point1 = new Point(234, 13);
      Point point10 = point1;
      label6_1.Location = point10;
      this.Label6.Name = "Label6";
      Label label6_2 = this.Label6;
      size1 = new Size(58, 13);
      Size size10 = size1;
      label6_2.Size = size10;
      this.Label6.TabIndex = 17;
      this.Label6.Text = "Search by:";
      this.cb_search.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cb_search.Enabled = false;
      this.cb_search.FormattingEnabled = true;
      this.cb_search.Items.AddRange(new object[5]
      {
        (object) "ID",
        (object) "Username",
        (object) "Full name",
        (object) "Email",
        (object) "Last Logged"
      });
      ComboBox cbSearch1 = this.cb_search;
      point1 = new Point(237, 31);
      Point point11 = point1;
      cbSearch1.Location = point11;
      this.cb_search.Name = "cb_search";
      ComboBox cbSearch2 = this.cb_search;
      size1 = new Size(100, 21);
      Size size11 = size1;
      cbSearch2.Size = size11;
      this.cb_search.TabIndex = 18;
      this.btn_clear.Enabled = false;
      Button btnClear1 = this.btn_clear;
      point1 = new Point(435, 28);
      Point point12 = point1;
      btnClear1.Location = point12;
      this.btn_clear.Name = "btn_clear";
      Button btnClear2 = this.btn_clear;
      size1 = new Size(68, 25);
      Size size12 = size1;
      btnClear2.Size = size12;
      this.btn_clear.TabIndex = 20;
      this.btn_clear.TabStop = false;
      this.btn_clear.Text = "Clear";
      this.btn_clear.UseVisualStyleBackColor = true;
      this.btn_search.Enabled = false;
      Button btnSearch1 = this.btn_search;
      point1 = new Point(342, 28);
      Point point13 = point1;
      btnSearch1.Location = point13;
      this.btn_search.Name = "btn_search";
      Button btnSearch2 = this.btn_search;
      size1 = new Size(90, 25);
      Size size13 = size1;
      btnSearch2.Size = size13;
      this.btn_search.TabIndex = 19;
      this.btn_search.TabStop = false;
      this.btn_search.Text = "Search";
      this.btn_search.UseVisualStyleBackColor = true;
      this.gb_details.Controls.Add((Control) this.GroupBox3);
      this.gb_details.Controls.Add((Control) this.txtbx_email);
      this.gb_details.Controls.Add((Control) this.txtbx_fullname);
      this.gb_details.Controls.Add((Control) this.txtbx_password);
      this.gb_details.Controls.Add((Control) this.txtbx_username);
      this.gb_details.Enabled = false;
      GroupBox gbDetails1 = this.gb_details;
      point1 = new Point(12, 12);
      Point point14 = point1;
      gbDetails1.Location = point14;
      this.gb_details.Name = "gb_details";
      GroupBox gbDetails2 = this.gb_details;
      size1 = new Size(369, 139);
      Size size14 = size1;
      gbDetails2.Size = size14;
      this.gb_details.TabIndex = 0;
      this.gb_details.TabStop = false;
      this.gb_details.Text = "ACCOUNT DETAILS";
      this.GroupBox3.Controls.Add((Control) this.Label5);
      this.GroupBox3.Controls.Add((Control) this.Label4);
      this.GroupBox3.Controls.Add((Control) this.nud_second);
      this.GroupBox3.Controls.Add((Control) this.Label3);
      this.GroupBox3.Controls.Add((Control) this.nud_minute);
      this.GroupBox3.Controls.Add((Control) this.nud_hour);
      GroupBox groupBox3_1 = this.GroupBox3;
      point1 = new Point(198, 19);
      Point point15 = point1;
      groupBox3_1.Location = point15;
      this.GroupBox3.Name = "GroupBox3";
      GroupBox groupBox3_2 = this.GroupBox3;
      size1 = new Size(150, 103);
      Size size15 = size1;
      groupBox3_2.Size = size15;
      this.GroupBox3.TabIndex = 5;
      this.GroupBox3.TabStop = false;
      this.GroupBox3.Text = "Credits";
      this.Label5.AutoSize = true;
      Label label5_1 = this.Label5;
      point1 = new Point(17, 73);
      Point point16 = point1;
      label5_1.Location = point16;
      this.Label5.Name = "Label5";
      Label label5_2 = this.Label5;
      size1 = new Size(55, 13);
      Size size16 = size1;
      label5_2.Size = size16;
      this.Label5.TabIndex = 10;
      this.Label5.Text = "Second(s)";
      this.Label4.AutoSize = true;
      Label label4_1 = this.Label4;
      point1 = new Point(17, 46);
      Point point17 = point1;
      label4_1.Location = point17;
      this.Label4.Name = "Label4";
      Label label4_2 = this.Label4;
      size1 = new Size(50, 13);
      Size size17 = size1;
      label4_2.Size = size17;
      this.Label4.TabIndex = 8;
      this.Label4.Text = "Minute(s)";
      NumericUpDown nudSecond1 = this.nud_second;
      point1 = new Point(78, 71);
      Point point18 = point1;
      nudSecond1.Location = point18;
      NumericUpDown nudSecond2 = this.nud_second;
      Decimal num1 = new Decimal(new int[4]
      {
        59,
        0,
        0,
        0
      });
      Decimal num2 = num1;
      nudSecond2.Maximum = num2;
      this.nud_second.Name = "nud_second";
      NumericUpDown nudSecond3 = this.nud_second;
      size1 = new Size(50, 20);
      Size size18 = size1;
      nudSecond3.Size = size18;
      this.nud_second.TabIndex = 11;
      this.Label3.AutoSize = true;
      Label label3_1 = this.Label3;
      point1 = new Point(17, 20);
      Point point19 = point1;
      label3_1.Location = point19;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(41, 13);
      Size size19 = size1;
      label3_2.Size = size19;
      this.Label3.TabIndex = 6;
      this.Label3.Text = "Hour(s)";
      NumericUpDown nudMinute1 = this.nud_minute;
      point1 = new Point(78, 44);
      Point point20 = point1;
      nudMinute1.Location = point20;
      NumericUpDown nudMinute2 = this.nud_minute;
      num1 = new Decimal(new int[4]{ 59, 0, 0, 0 });
      Decimal num3 = num1;
      nudMinute2.Maximum = num3;
      this.nud_minute.Name = "nud_minute";
      NumericUpDown nudMinute3 = this.nud_minute;
      size1 = new Size(50, 20);
      Size size20 = size1;
      nudMinute3.Size = size20;
      this.nud_minute.TabIndex = 9;
      NumericUpDown nudHour1 = this.nud_hour;
      point1 = new Point(78, 18);
      Point point21 = point1;
      nudHour1.Location = point21;
      NumericUpDown nudHour2 = this.nud_hour;
      num1 = new Decimal(new int[4]{ 999, 0, 0, 0 });
      Decimal num4 = num1;
      nudHour2.Maximum = num4;
      this.nud_hour.Name = "nud_hour";
      NumericUpDown nudHour3 = this.nud_hour;
      size1 = new Size(50, 20);
      Size size21 = size1;
      nudHour3.Size = size21;
      this.nud_hour.TabIndex = 7;
      this.txtbx_email.ForeColor = Color.DimGray;
      TextBox txtbxEmail1 = this.txtbx_email;
      point1 = new Point(20, 102);
      Point point22 = point1;
      txtbxEmail1.Location = point22;
      this.txtbx_email.Name = "txtbx_email";
      TextBox txtbxEmail2 = this.txtbx_email;
      size1 = new Size(161, 20);
      Size size22 = size1;
      txtbxEmail2.Size = size22;
      this.txtbx_email.TabIndex = 4;
      this.txtbx_email.Text = "email";
      this.txtbx_fullname.ForeColor = Color.DimGray;
      TextBox txtbxFullname1 = this.txtbx_fullname;
      point1 = new Point(20, 76);
      Point point23 = point1;
      txtbxFullname1.Location = point23;
      this.txtbx_fullname.Name = "txtbx_fullname";
      TextBox txtbxFullname2 = this.txtbx_fullname;
      size1 = new Size(161, 20);
      Size size23 = size1;
      txtbxFullname2.Size = size23;
      this.txtbx_fullname.TabIndex = 3;
      this.txtbx_fullname.Text = "full name";
      this.txtbx_password.ForeColor = Color.DimGray;
      TextBox txtbxPassword1 = this.txtbx_password;
      point1 = new Point(20, 50);
      Point point24 = point1;
      txtbxPassword1.Location = point24;
      this.txtbx_password.Name = "txtbx_password";
      TextBox txtbxPassword2 = this.txtbx_password;
      size1 = new Size(161, 20);
      Size size24 = size1;
      txtbxPassword2.Size = size24;
      this.txtbx_password.TabIndex = 2;
      this.txtbx_password.Text = "password";
      this.txtbx_username.ForeColor = Color.DimGray;
      TextBox txtbxUsername1 = this.txtbx_username;
      point1 = new Point(20, 26);
      Point point25 = point1;
      txtbxUsername1.Location = point25;
      this.txtbx_username.Name = "txtbx_username";
      TextBox txtbxUsername2 = this.txtbx_username;
      size1 = new Size(161, 20);
      Size size25 = size1;
      txtbxUsername2.Size = size25;
      this.txtbx_username.TabIndex = 1;
      this.txtbx_username.Text = "username";
      this.btn_quickcreate.Enabled = false;
      Button btnQuickcreate1 = this.btn_quickcreate;
      point1 = new Point(387, 104);
      Point point26 = point1;
      btnQuickcreate1.Location = point26;
      this.btn_quickcreate.Name = "btn_quickcreate";
      Button btnQuickcreate2 = this.btn_quickcreate;
      size1 = new Size(144, 45);
      Size size26 = size1;
      btnQuickcreate2.Size = size26;
      this.btn_quickcreate.TabIndex = 13;
      this.btn_quickcreate.TabStop = false;
      this.btn_quickcreate.Text = "Quick create";
      this.btn_quickcreate.UseVisualStyleBackColor = true;
      this.btn_create.Enabled = false;
      Button btnCreate1 = this.btn_create;
      point1 = new Point(387, 20);
      Point point27 = point1;
      btnCreate1.Location = point27;
      this.btn_create.Name = "btn_create";
      Button btnCreate2 = this.btn_create;
      size1 = new Size(144, 78);
      Size size27 = size1;
      btnCreate2.Size = size27;
      this.btn_create.TabIndex = 12;
      this.btn_create.TabStop = false;
      this.btn_create.Text = "Create New Account";
      this.btn_create.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(540, 458);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.btn_quickcreate);
      this.Controls.Add((Control) this.btn_create);
      this.Controls.Add((Control) this.gb_details);
      this.Controls.Add((Control) this.GroupBox1);
      this.Controls.Add((Control) this.StatusStrip1);
      this.FormBorderStyle = FormBorderStyle.Fixed3D;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.Name = nameof (form_account);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Account Manager";
      this.GroupBox1.ResumeLayout(false);
      this.GroupBox1.PerformLayout();
      ((ISupportInitialize) this.dgv_account).EndInit();
      this.gb_details.ResumeLayout(false);
      this.gb_details.PerformLayout();
      this.GroupBox3.ResumeLayout(false);
      this.GroupBox3.PerformLayout();
      this.nud_second.EndInit();
      this.nud_minute.EndInit();
      this.nud_hour.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
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

    internal virtual GroupBox gb_details
    {
      [DebuggerNonUserCode] get
      {
        return this._gb_details;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._gb_details = value;
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

    internal virtual GroupBox GroupBox3
    {
      [DebuggerNonUserCode] get
      {
        return this._GroupBox3;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._GroupBox3 = value;
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

    internal virtual NumericUpDown nud_second
    {
      [DebuggerNonUserCode] get
      {
        return this._nud_second;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._nud_second = value;
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

    internal virtual NumericUpDown nud_minute
    {
      [DebuggerNonUserCode] get
      {
        return this._nud_minute;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._nud_minute = value;
      }
    }

    internal virtual NumericUpDown nud_hour
    {
      [DebuggerNonUserCode] get
      {
        return this._nud_hour;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._nud_hour = value;
      }
    }

    internal virtual Button btn_quickcreate
    {
      [DebuggerNonUserCode] get
      {
        return this._btn_quickcreate;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btn_quickcreate_Click);
        if (this._btn_quickcreate != null)
          this._btn_quickcreate.Click -= eventHandler;
        this._btn_quickcreate = value;
        if (this._btn_quickcreate == null)
          return;
        this._btn_quickcreate.Click += eventHandler;
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

    internal virtual TextBox txtbx_search
    {
      [DebuggerNonUserCode] get
      {
        return this._txtbx_search;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtbx_search_TextChanged);
        if (this._txtbx_search != null)
          this._txtbx_search.TextChanged -= eventHandler;
        this._txtbx_search = value;
        if (this._txtbx_search == null)
          return;
        this._txtbx_search.TextChanged += eventHandler;
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

    internal virtual ComboBox cb_search
    {
      [DebuggerNonUserCode] get
      {
        return this._cb_search;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._cb_search = value;
      }
    }

    internal virtual Button btn_clear
    {
      [DebuggerNonUserCode] get
      {
        return this._btn_clear;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btn_clear_Click);
        if (this._btn_clear != null)
          this._btn_clear.Click -= eventHandler;
        this._btn_clear = value;
        if (this._btn_clear == null)
          return;
        this._btn_clear.Click += eventHandler;
      }
    }

    internal virtual Button btn_search
    {
      [DebuggerNonUserCode] get
      {
        return this._btn_search;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btn_search_Click);
        if (this._btn_search != null)
          this._btn_search.Click -= eventHandler;
        this._btn_search = value;
        if (this._btn_search == null)
          return;
        this._btn_search.Click += eventHandler;
      }
    }

    internal virtual Button btn_quickdel
    {
      [DebuggerNonUserCode] get
      {
        return this._btn_quickdel;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btn_quickdel_Click);
        if (this._btn_quickdel != null)
          this._btn_quickdel.Click -= eventHandler;
        this._btn_quickdel = value;
        if (this._btn_quickdel == null)
          return;
        this._btn_quickdel.Click += eventHandler;
      }
    }

    internal virtual Button btn_delete
    {
      [DebuggerNonUserCode] get
      {
        return this._btn_delete;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btn_delete_Click);
        if (this._btn_delete != null)
          this._btn_delete.Click -= eventHandler;
        this._btn_delete = value;
        if (this._btn_delete == null)
          return;
        this._btn_delete.Click += eventHandler;
      }
    }

    internal virtual DataGridView dgv_account
    {
      [DebuggerNonUserCode] get
      {
        return this._dgv_account;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler1 = new DataGridViewCellEventHandler(this.dgv_account_RowLeave);
        DataGridViewCellEventHandler cellEventHandler2 = new DataGridViewCellEventHandler(this.dgv_account_CellClick);
        if (this._dgv_account != null)
        {
          this._dgv_account.RowLeave -= cellEventHandler1;
          this._dgv_account.CellClick -= cellEventHandler2;
        }
        this._dgv_account = value;
        if (this._dgv_account == null)
          return;
        this._dgv_account.RowLeave += cellEventHandler1;
        this._dgv_account.CellClick += cellEventHandler2;
      }
    }

    internal virtual Button btn_edit
    {
      [DebuggerNonUserCode] get
      {
        return this._btn_edit;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btn_edit_Click);
        if (this._btn_edit != null)
          this._btn_edit.Click -= eventHandler;
        this._btn_edit = value;
        if (this._btn_edit == null)
          return;
        this._btn_edit.Click += eventHandler;
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
      if (e.CloseReason == CloseReason.UserClosing)
      {
        if (this.worker != null && this.worker.IsBusy)
        {
          e.Cancel = true;
          this.worker.CancelAsync();
        }
        else if (this.a != null)
          this.a.close();
      }
      else if (this.a != null)
        this.a.close();
      base.OnFormClosing(e);
    }

    private void form_account_Load(object sender, EventArgs e)
    {
      this.labelStatus = new ToolStripStatusLabel();
      this.StatusStrip1.Items.Add((ToolStripItem) this.labelStatus);
      string filePath = coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("data")), "data");
      string databaseFileName = coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("accountFilename")), "account");
      string databasePassword = coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("accountPassword")), "account");
      if (!File.Exists(filePath + databaseFileName + ".mdb"))
      {
        int num1 = (int) Interaction.MsgBox((object) (databaseFileName + ".mdb database account is missing in data folder location."), MsgBoxStyle.Critical, (object) "Database account not found!");
      }
      else
      {
        this.a = new database(filePath, databaseFileName, databasePassword);
        try
        {
          this.a.open();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          int num2 = (int) Interaction.MsgBox((object) ex.Message, MsgBoxStyle.Critical, (object) "Error opening database account");
          ProjectData.ClearProjectError();
          return;
        }
        if (this.a.isOpen)
        {
          if (this.a.conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[4]
          {
            (object) null,
            (object) null,
            (object) "users",
            (object) "TABLE"
          }).Rows.Count > 0 || MessageBox.Show("This will create a 'users' table in the database account ''" + databaseFileName + ".mdb'", "Create table", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) != DialogResult.OK)
            goto label_10;
label_7:
          OleDbCommand oleDbCommand1 = new OleDbCommand("CREATE TABLE [users] ([ID] TEXT(5), [Username] TEXT(50), [Password] TEXT(50), [Credits] TExT(10), [Created] Text(50), [Full Name] TEXT(50), [Email] TEXT(50), [Last Logged] Text(50))", this.a.conn);
          try
          {
            oleDbCommand1.ExecuteNonQuery();
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            int num2 = (int) Interaction.MsgBox((object) ex.Message, MsgBoxStyle.Critical, (object) "Database table creation failed!");
            ProjectData.ClearProjectError();
            return;
          }
label_10:
          bool flag = false;
          DataColumnCollection columns = this.a.dataTable("users").Columns;
          if (columns.Count != 8)
          {
            flag = true;
          }
          else
          {
            try
            {
              foreach (DataColumn dataColumn in (InternalDataCollectionBase) columns)
              {
                string columnName = dataColumn.ColumnName;
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnName, "ID", false) == 0)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataColumn.DataType.ToString(), "System.String", false) != 0)
                    flag = true;
                }
                else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnName, "Username", false) == 0)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataColumn.DataType.ToString(), "System.String", false) != 0)
                    flag = true;
                }
                else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnName, "Password", false) == 0)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataColumn.DataType.ToString(), "System.String", false) != 0)
                    flag = true;
                }
                else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnName, "Credits", false) == 0)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataColumn.DataType.ToString(), "System.String", false) != 0)
                    flag = true;
                }
                else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnName, "Created", false) == 0)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataColumn.DataType.ToString(), "System.String", false) != 0)
                    flag = true;
                }
                else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnName, "Full Name", false) == 0)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataColumn.DataType.ToString(), "System.String", false) != 0)
                    flag = true;
                }
                else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnName, "Email", false) == 0)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataColumn.DataType.ToString(), "System.String", false) != 0)
                    flag = true;
                }
                else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnName, "Last Logged", false) == 0)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataColumn.DataType.ToString(), "System.String", false) != 0)
                    flag = true;
                }
                else
                  flag = true;
              }
            }
            finally
            {
              IEnumerator enumerator;
              if (enumerator is IDisposable)
                (enumerator as IDisposable).Dispose();
            }
          }
          if (flag && MessageBox.Show("The column field DataTypes in table 'users' is invalid. Do you want to delete the table 'users' and create for a new one to correct the format?\r\nWARNING: all the data on the table 'users' will be deleted. Continue?", "Create new table", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
          {
            OleDbCommand oleDbCommand2 = new OleDbCommand("DROP TABLE users", this.a.conn);
            try
            {
              oleDbCommand2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              int num2 = (int) Interaction.MsgBox((object) ex.Message, MsgBoxStyle.Critical, (object) "Deleting table failed!");
              ProjectData.ClearProjectError();
              return;
            }
            goto label_7;
          }
          else
          {
            this.dgv_account.DataSource = (object) this.a.dataTable("users");
            this.a.close();
          }
        }
        if (this.dgv_account.Rows.Count >= 1)
        {
          this.dgv_account.Sort(this.dgv_account.Columns[4], ListSortDirection.Ascending);
          try
          {
            this.dgv_account.Columns["ID"].ReadOnly = true;
            this.dgv_account.Columns["Username"].ReadOnly = true;
            this.dgv_account.Columns["Created"].ReadOnly = true;
            this.dgv_account.Columns["Last Logged"].ReadOnly = true;
            int num2 = checked (this.dgv_account.RowCount - 1);
            int index = 0;
            while (index <= num2)
            {
              this.dgv_account.Rows[index].ReadOnly = true;
              checked { ++index; }
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            int num2 = (int) Interaction.MsgBox((object) ex.Message, MsgBoxStyle.Critical, (object) "Error set read only");
            ProjectData.ClearProjectError();
            return;
          }
          this.txtbx_search.Enabled = true;
          this.dgv_account.ClearSelection();
        }
        this.labelStatus.Text = this.dgv_account.Rows.Count == 0 ? "There are no user account recorded." : (this.dgv_account.Rows.Count == 1 ? "There are " + Conversions.ToString(this.dgv_account.Rows.Count) + " user account only." : "There are " + Conversions.ToString(this.dgv_account.Rows.Count) + " total user accounts.");
        int num3 = checked (this.dgv_account.ColumnCount - 1);
        int index1 = 0;
        while (index1 <= num3)
        {
          this.dgv_account.Columns[index1].SortMode = DataGridViewColumnSortMode.NotSortable;
          checked { ++index1; }
        }
        this.gb_details.Enabled = true;
      }
    }

    private void txtbx_account_GotFocus(object sender, EventArgs e)
    {
      bool flag = true;
      if (flag == (sender == this.txtbx_username))
      {
        if (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (System.Type) null, "Text", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "username", false))
          return;
        NewLateBinding.LateCall(sender, (System.Type) null, "Clear", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null, true);
        NewLateBinding.LateSet(sender, (System.Type) null, "ForeColor", new object[1]
        {
          (object) Color.Black
        }, (string[]) null, (System.Type[]) null);
      }
      else if (flag == (sender == this.txtbx_password))
      {
        if (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (System.Type) null, "Text", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "password", false))
          return;
        NewLateBinding.LateCall(sender, (System.Type) null, "Clear", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null, true);
        NewLateBinding.LateSet(sender, (System.Type) null, "ForeColor", new object[1]
        {
          (object) Color.Black
        }, (string[]) null, (System.Type[]) null);
      }
      else if (flag == (sender == this.txtbx_fullname))
      {
        if (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (System.Type) null, "Text", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "full name", false))
          return;
        NewLateBinding.LateCall(sender, (System.Type) null, "Clear", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null, true);
        NewLateBinding.LateSet(sender, (System.Type) null, "ForeColor", new object[1]
        {
          (object) Color.Black
        }, (string[]) null, (System.Type[]) null);
      }
      else
      {
        if (flag != (sender == this.txtbx_email) || !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (System.Type) null, "Text", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "email", false))
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
        if (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (System.Type) null, "Text", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "", false))
          return;
        NewLateBinding.LateSet(sender, (System.Type) null, "ForeColor", new object[1]
        {
          (object) Color.DimGray
        }, (string[]) null, (System.Type[]) null);
        NewLateBinding.LateSet(sender, (System.Type) null, "Text", new object[1]
        {
          (object) "username"
        }, (string[]) null, (System.Type[]) null);
      }
      else if (flag == (sender == this.txtbx_password))
      {
        if (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (System.Type) null, "Text", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "", false))
          return;
        NewLateBinding.LateSet(sender, (System.Type) null, "ForeColor", new object[1]
        {
          (object) Color.DimGray
        }, (string[]) null, (System.Type[]) null);
        NewLateBinding.LateSet(sender, (System.Type) null, "Text", new object[1]
        {
          (object) "password"
        }, (string[]) null, (System.Type[]) null);
      }
      else if (flag == (sender == this.txtbx_fullname))
      {
        if (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (System.Type) null, "Text", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "", false))
          return;
        NewLateBinding.LateSet(sender, (System.Type) null, "ForeColor", new object[1]
        {
          (object) Color.DimGray
        }, (string[]) null, (System.Type[]) null);
        NewLateBinding.LateSet(sender, (System.Type) null, "Text", new object[1]
        {
          (object) "full name"
        }, (string[]) null, (System.Type[]) null);
      }
      else
      {
        if (flag != (sender == this.txtbx_email) || !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (System.Type) null, "Text", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "", false))
          return;
        NewLateBinding.LateSet(sender, (System.Type) null, "ForeColor", new object[1]
        {
          (object) Color.DimGray
        }, (string[]) null, (System.Type[]) null);
        NewLateBinding.LateSet(sender, (System.Type) null, "Text", new object[1]
        {
          (object) "email"
        }, (string[]) null, (System.Type[]) null);
      }
    }

    private void txtbx_TextChanged(object sender, EventArgs e)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtbx_username.Text, "", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtbx_username.Text, "username", false) != 0 && (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtbx_password.Text, "", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtbx_password.Text, "password", false) != 0))
      {
        this.btn_create.Enabled = true;
        this.btn_quickcreate.Enabled = true;
      }
      else
      {
        this.btn_create.Enabled = false;
        this.btn_quickcreate.Enabled = false;
      }
    }

    private void btn_create_Click(object sender, EventArgs e)
    {
      this.ActiveControl = (Control) null;
      if (this.working)
      {
        int num1 = (int) Interaction.MsgBox((object) "Wait for the background operation to complete.", MsgBoxStyle.Critical, (object) null);
      }
      else
      {
        int int32 = Convert.ToInt32(Decimal.Add(Decimal.Add(this.nud_second.Value, Decimal.Multiply(this.nud_minute.Value, new Decimal(60L))), Decimal.Multiply(Decimal.Multiply(this.nud_hour.Value, new Decimal(60L)), new Decimal(60L))));
        int num2 = int32 % 60;
        int num3 = checked ((int) Math.Round(unchecked ((double) checked (int32 - num2) / 60.0 % 60.0)));
        int num4 = checked ((int) Math.Round(unchecked ((double) checked (int32 - num2 + num3 * 60) / 3600.0 % 60.0)));
        string[] strArray1 = new string[6]
        {
          "Create '",
          this.txtbx_username.Text,
          "' user account with '",
          this.txtbx_password.Text,
          "' password ",
          null
        };
        string[] strArray2 = strArray1;
        string str;
        if (int32 >= 1)
          str = "with " + (num4 > 0 ? Conversions.ToString(num4) + " " + (num4 == 1 ? "hour " : "hours ") : "") + (num3 > 0 ? Conversions.ToString(num3) + " " + (num3 == 1 ? "minute " : "minutes ") : "") + (num2 > 0 ? Conversions.ToString(num2) + " " + (num2 == 1 ? "second" : "seconds") : "") + " time credit";
        else
          str = "without time credit?";
        strArray2[5] = str;
        if (MessageBox.Show(string.Concat(strArray1), "Create user account", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
        {
          this.btn_create.Text = "Creating...";
          this.btn_create.Enabled = false;
          this.btn_quickcreate.Enabled = false;
          this.gb_details.Enabled = false;
          this.worker = new BackgroundWorker();
          this.worker.WorkerSupportsCancellation = true;
          this.worker.WorkerReportsProgress = true;
          this.worker.RunWorkerAsync((object) "create");
        }
      }
    }

    private void btn_quickcreate_Click(object sender, EventArgs e)
    {
      if (this.working)
      {
        int num = (int) Interaction.MsgBox((object) "Wait for the background operation to complete.", MsgBoxStyle.Critical, (object) null);
      }
      else
      {
        this.ActiveControl = (Control) null;
        this.gb_details.Enabled = false;
        this.quick = true;
        this.worker = new BackgroundWorker();
        this.worker.WorkerSupportsCancellation = true;
        this.worker.WorkerReportsProgress = true;
        this.worker.RunWorkerAsync();
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
      if (this.a.isOpen)
      {
        oleDbCommand.Connection = this.a.conn;
        while (!this.worker.CancellationPending)
        {
          string number = this.a.generateNumber(5);
          this.accountTemp = new ArrayList();
          oleDbCommand.CommandText = "SELECT * FROM users WHERE ([ID] = '" + number + "')";
          OleDbDataReader oleDbDataReader1;
          try
          {
            oleDbCommand.ExecuteNonQuery();
            OleDbDataReader oleDbDataReader2 = oleDbCommand.ExecuteReader();
            while (oleDbDataReader2.Read())
            {
              this.accountTemp.Add((object) oleDbDataReader2["ID"].ToString());
              this.accountTemp.Add((object) oleDbDataReader2["Username"].ToString());
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
            break;
          }
          if (this.accountTemp.Count != 0)
          {
            this.accountTemp = (ArrayList) null;
          }
          else
          {
            oleDbCommand.CommandText = "SELECT * FROM users WHERE ([Username] = '" + this.txtbx_username.Text + "')";
            try
            {
              oleDbCommand.ExecuteNonQuery();
              OleDbDataReader oleDbDataReader2 = oleDbCommand.ExecuteReader();
              while (oleDbDataReader2.Read())
                this.accountTemp.Add((object) oleDbDataReader2["Username"].ToString());
              oleDbDataReader2.Close();
              oleDbDataReader1 = (OleDbDataReader) null;
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              Exception exception = ex;
              e.Result = (object) exception.Message;
              ProjectData.ClearProjectError();
              break;
            }
            if (this.accountTemp.Count != 0)
            {
              this.accountTemp = (ArrayList) null;
              e.Result = (object) "exists";
              break;
            }
            string str = Strings.Format((object) DateAndTime.Now, "yyyy/MM/dd @ hh:mm:ss tt");
            int int32 = Convert.ToInt32(Decimal.Add(Decimal.Add(this.nud_second.Value, Decimal.Multiply(this.nud_minute.Value, new Decimal(60L))), Decimal.Multiply(new Decimal(60L), Decimal.Multiply(this.nud_hour.Value, new Decimal(60L)))));
            oleDbCommand.CommandText = "INSERT INTO users ([ID], [Username], [Password], [Credits], [Created], [Full Name], [Email],  [Last Logged]) VALUES ('" + number + "', '" + this.txtbx_username.Text + "', '" + this.txtbx_password.Text + "','" + Conversions.ToString(int32) + "', '" + str + "', '" + (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtbx_fullname.Text, "", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtbx_fullname.Text, "full name", false) == 0 ? string.Empty : this.txtbx_fullname.Text) + "', '" + (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtbx_email.Text, "", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtbx_email.Text, "email", false) == 0 ? string.Empty : this.txtbx_email.Text) + "', '" + string.Empty + "')";
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
              break;
            }
            e.Result = (object) "success";
            break;
          }
        }
      }
      else
        e.Result = (object) "closed";
    }

    private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.btn_delete.Enabled = false;
      this.btn_quickdel.Enabled = false;
      this.btn_edit.Enabled = false;
      this.gb_details.Enabled = true;
      bool flag = false;
      string Left = Conversions.ToString(e.Result);
      string str;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "closed", false) == 0)
      {
        if (!this.quick)
        {
          int num;
          this.Invoke((Delegate) (() => num = (int) Interaction.MsgBox((object) "Creating user account failed.", MsgBoxStyle.Critical, (object) null)));
        }
        str = "Error: while opening the account database";
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "exists", false) == 0)
      {
        if (!this.quick)
        {
          int num;
          this.Invoke((Delegate) (() => num = (int) Interaction.MsgBox((object) (this.txtbx_username.Text + " username already used. Try different username and try again."), MsgBoxStyle.Critical, (object) null)));
        }
        str = this.txtbx_username.Text + " username already used. User account has not created";
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "success", false) == 0)
      {
        flag = true;
        if (!this.quick)
        {
          int num;
          this.Invoke((Delegate) (() => num = (int) Interaction.MsgBox((object) (this.txtbx_username.Text + " user account created successfully."), MsgBoxStyle.Information, (object) null)));
        }
        str = this.txtbx_username.Text + " user account created successfully.";
      }
      else
      {
        if (!this.quick)
        {
          int num;
          this.Invoke((Delegate) (() => num = (int) Interaction.MsgBox(RuntimeHelpers.GetObjectValue(e.Result), MsgBoxStyle.Critical, (object) null)));
        }
        str = e.Result.ToString();
      }
      this.btn_create.Text = "Create New Account";
      this.btn_quickcreate.Text = "Quick create";
      if (!flag)
      {
        this.btn_create.Enabled = true;
        this.btn_quickcreate.Enabled = true;
      }
      else
      {
        if (!this.quick)
        {
          this.btn_create.Enabled = false;
          this.btn_quickcreate.Enabled = false;
          this.nud_hour.Value = Decimal.Zero;
          this.nud_minute.Value = Decimal.Zero;
          this.nud_second.Value = Decimal.Zero;
          this.txtbx_username.Text = "username";
          this.txtbx_username.ForeColor = Color.DimGray;
          this.txtbx_password.Text = "password";
          this.txtbx_password.ForeColor = Color.DimGray;
          this.txtbx_fullname.Text = "full name";
          this.txtbx_fullname.ForeColor = Color.DimGray;
          this.txtbx_email.Text = "email";
          this.txtbx_email.ForeColor = Color.DimGray;
        }
        this.dgv_account.DataSource = (object) this.a.dataTable("users");
        if (this.dgv_account.Rows.Count >= 1)
        {
          this.txtbx_search.Enabled = true;
          this.dgv_account.CurrentCell = this.dgv_account[0, checked (this.dgv_account.Rows.Count - 1)];
          this.dgv_account.Sort(this.dgv_account.Columns[4], ListSortDirection.Ascending);
          int num = checked (this.dgv_account.RowCount - 1);
          int index = 0;
          while (index <= num)
          {
            this.dgv_account.Rows[index].ReadOnly = true;
            checked { ++index; }
          }
          this.dgv_account.ClearSelection();
        }
      }
      this.labelStatus.Text = str;
      this.quick = false;
      this.worker.Dispose();
      this.worker = (BackgroundWorker) null;
      this.a.close();
      this.working = false;
    }

    private void btn_delete_Click(object sender, EventArgs e)
    {
      this.ActiveControl = (Control) null;
      if (this.working)
      {
        int num1 = (int) Interaction.MsgBox((object) "Wait for the background operation to complete.", MsgBoxStyle.Critical, (object) null);
      }
      else if (this.accountTemp != null)
      {
        int result = 0;
        if (!int.TryParse(this.accountTemp[3].ToString(), out result))
          result = 0;
        int num2 = result % 60;
        int num3 = checked ((int) Math.Round(unchecked ((double) checked (result - num2) / 60.0 % 60.0)));
        int num4 = checked ((int) Math.Round(unchecked ((double) checked (result - num2 + num3 * 60) / 3600.0 % 60.0)));
        if (MessageBox.Show("Delete this user account?\r\n\r\nUser ID: " + this.accountTemp[0].ToString() + "\r\nUsername: " + this.accountTemp[1].ToString() + "\r\nPassword: " + this.accountTemp[2].ToString() + "\r\nCredits: " + (result < 1 ? "(No time credit)" : (num4 > 0 ? Conversions.ToString(num4) + " " + (num4 == 1 ? "hour " : "hours ") : "") + (num3 > 0 ? Conversions.ToString(num3) + " " + (num3 == 1 ? "minute " : "minutes ") : "") + (num2 > 0 ? Conversions.ToString(num2) + " " + (num2 == 1 ? "second" : "seconds") : "")) + "\r\nCreated: " + this.accountTemp[4].ToString() + "\r\nFull Name: " + (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.accountTemp[5].ToString(), "", false) == 0 ? "(No full name)" : this.accountTemp[5].ToString()) + "\r\nEmail: " + (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.accountTemp[6].ToString(), "", false) == 0 ? "(No email)" : this.accountTemp[6].ToString()) + "\r\nLast Logged: " + (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.accountTemp[7].ToString(), "", false) == 0 ? "(Never logged)" : this.accountTemp[7].ToString()), "Delete user account", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
        {
          OleDbCommand oleDbCommand = new OleDbCommand();
          string str = "DELETE * FROM users WHERE ([Username] = '" + this.accountTemp[1].ToString() + "')";
          try
          {
            this.a.open();
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            int num5 = (int) Interaction.MsgBox((object) ex.Message, MsgBoxStyle.Critical, (object) "Delete error");
            ProjectData.ClearProjectError();
            return;
          }
          if (this.a.open())
          {
            try
            {
              oleDbCommand.Connection = this.a.conn;
              oleDbCommand.CommandText = str;
              oleDbCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              int num5 = (int) Interaction.MsgBox((object) ex.Message, MsgBoxStyle.Critical, (object) null);
              ProjectData.ClearProjectError();
              return;
            }
          }
          this.a.close();
          this.accountTemp = (ArrayList) null;
          this.dgv_account.DataSource = (object) this.a.dataTable("users");
          this.dgv_account.Sort(this.dgv_account.Columns[4], ListSortDirection.Ascending);
          if (this.dgv_account.Rows.Count > 0)
          {
            int num5 = checked (this.dgv_account.RowCount - 1);
            int index1 = 0;
            while (index1 <= num5)
            {
              this.dgv_account.Rows[index1].ReadOnly = true;
              checked { ++index1; }
            }
            if (this.selectedIndex != checked (this.dgv_account.Rows.Count - 1) && this.selectedIndex != 0)
              checked { --this.selectedIndex; }
            this.dgv_account.CurrentCell = this.dgv_account[0, this.selectedIndex];
            this.accountTemp = new ArrayList();
            int num6 = checked (this.dgv_account.Columns.Count - 1);
            int index2 = 0;
            while (index2 <= num6)
            {
              this.accountTemp.Add(RuntimeHelpers.GetObjectValue(this.dgv_account[index2, this.selectedIndex].Value));
              checked { ++index2; }
            }
            int num7 = checked (this.dgv_account.RowCount - 1);
            int index3 = 0;
            while (index3 <= num7)
            {
              this.dgv_account.Rows[index3].ReadOnly = true;
              checked { ++index3; }
            }
          }
          else
          {
            this.selectedIndex = 0;
            this.btn_delete.Enabled = false;
            this.btn_quickdel.Enabled = false;
            this.btn_edit.Enabled = false;
            this.txtbx_search.Enabled = false;
            this.txtbx_search.Clear();
            this.cb_search.SelectedIndex = -1;
            this.cb_search.Enabled = false;
            this.btn_search.Enabled = false;
          }
          this.labelStatus.Text = "1  user account deleted";
          int num8 = (int) Interaction.MsgBox((object) "Deleted account", MsgBoxStyle.Information, (object) null);
        }
      }
    }

    private void dgv_account_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.working || this.edit || e.RowIndex == -1)
        return;
      this.accountTemp = new ArrayList();
      this.selectedIndex = e.RowIndex;
      int num1 = checked (this.dgv_account.Columns.Count - 1);
      int index = 0;
      while (index <= num1)
      {
        this.accountTemp.Add(RuntimeHelpers.GetObjectValue(this.dgv_account[index, this.dgv_account.CurrentRow.Index].Value));
        checked { ++index; }
      }
      if (this.accountTemp.Count != 0)
      {
        this.btn_delete.Enabled = true;
        this.btn_quickdel.Enabled = true;
        this.btn_edit.Enabled = true;
        int result = 0;
        if (!int.TryParse(this.accountTemp[3].ToString(), out result))
          result = 0;
        int num2 = result % 60;
        int num3 = checked ((int) Math.Round(unchecked ((double) checked (result - num2) / 60.0 % 60.0)));
        int num4 = checked ((int) Math.Round(unchecked ((double) checked (result - num2 + num3 * 60) / 3600.0 % 60.0)));
        this.labelStatus.Text = "ID: " + this.accountTemp[0].ToString() + "   |   Username: " + this.accountTemp[1].ToString() + "   |   " + (result < 1 ? "No time credit" : "Credits: " + (num4 > 0 ? Conversions.ToString(num4) + " " + (num4 == 1 ? "hour " : "hours ") : "") + (num3 > 0 ? Conversions.ToString(num3) + " " + (num3 == 1 ? "minute " : "minutes ") : "") + (num2 > 0 ? Conversions.ToString(num2) + " " + (num2 == 1 ? "second" : "seconds") : ""));
      }
      else
      {
        this.btn_delete.Enabled = false;
        this.btn_quickdel.Enabled = false;
        this.btn_edit.Enabled = false;
        this.labelStatus.Text = "No records of user account";
      }
    }

    private void btn_quickdel_Click(object sender, EventArgs e)
    {
      this.ActiveControl = (Control) null;
      if (this.working)
      {
        int num1 = (int) Interaction.MsgBox((object) "Wait for the background operation to complete.", MsgBoxStyle.Critical, (object) null);
      }
      else if (this.accountTemp != null)
      {
        OleDbCommand oleDbCommand = new OleDbCommand();
        string str = "DELETE * FROM users WHERE ([Username] = '" + this.accountTemp[1].ToString() + "')";
        try
        {
          this.a.open();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          int num2 = (int) Interaction.MsgBox((object) ex.Message, MsgBoxStyle.Critical, (object) "Delete error");
          ProjectData.ClearProjectError();
          return;
        }
        if (this.a.open())
        {
          try
          {
            oleDbCommand.Connection = this.a.conn;
            oleDbCommand.CommandText = str;
            oleDbCommand.ExecuteNonQuery();
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            int num2 = (int) Interaction.MsgBox((object) ex.Message, MsgBoxStyle.Critical, (object) null);
            ProjectData.ClearProjectError();
            return;
          }
        }
        this.a.close();
        this.accountTemp = (ArrayList) null;
        this.dgv_account.DataSource = (object) this.a.dataTable("users");
        this.dgv_account.Sort(this.dgv_account.Columns[4], ListSortDirection.Ascending);
        if (this.dgv_account.Rows.Count > 0)
        {
          int num2 = checked (this.dgv_account.RowCount - 1);
          int index1 = 0;
          while (index1 <= num2)
          {
            this.dgv_account.Rows[index1].ReadOnly = true;
            checked { ++index1; }
          }
          if (this.selectedIndex != checked (this.dgv_account.Rows.Count - 1) && this.selectedIndex != 0)
            checked { --this.selectedIndex; }
          this.dgv_account.CurrentCell = this.dgv_account[0, this.selectedIndex];
          this.accountTemp = new ArrayList();
          int num3 = checked (this.dgv_account.Columns.Count - 1);
          int index2 = 0;
          while (index2 <= num3)
          {
            this.accountTemp.Add(RuntimeHelpers.GetObjectValue(this.dgv_account[index2, this.selectedIndex].Value));
            checked { ++index2; }
          }
        }
        else
        {
          this.selectedIndex = 0;
          this.btn_delete.Enabled = false;
          this.btn_quickdel.Enabled = false;
          this.btn_edit.Enabled = false;
          this.txtbx_search.Enabled = false;
          this.txtbx_search.Clear();
          this.cb_search.SelectedIndex = -1;
          this.cb_search.Enabled = false;
          this.btn_search.Enabled = false;
        }
        this.labelStatus.Text = "1  user account deleted";
      }
    }

    private void txtbx_search_TextChanged(object sender, EventArgs e)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(sender, (System.Type) null, "Text", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "", false))
      {
        this.cb_search.Enabled = true;
        this.btn_search.Enabled = true;
        if (this.cb_search.SelectedIndex != -1)
          return;
        this.cb_search.SelectedIndex = 1;
      }
      else
      {
        this.cb_search.Enabled = false;
        this.btn_search.Enabled = false;
        this.cb_search.SelectedIndex = -1;
      }
    }

    private void btn_search_Click(object sender, EventArgs e)
    {
      this.ActiveControl = (Control) null;
      if (this.working)
      {
        int num1 = (int) Interaction.MsgBox((object) "Wait for the background operation to complete.", MsgBoxStyle.Critical, (object) null);
      }
      else
      {
        try
        {
          this.a.open();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          int num2 = (int) Interaction.MsgBox((object) ex.Message, MsgBoxStyle.Critical, (object) "Opening database account failed");
          ProjectData.ClearProjectError();
          return;
        }
        if (!this.a.isOpen)
        {
          int num3 = (int) Interaction.MsgBox((object) "There is a problem connecting to the database.", MsgBoxStyle.Critical, (object) "Failed to search");
        }
        else
        {
          OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter();
          DataTable dataTable = new DataTable();
          string str = (string) null;
          switch (this.cb_search.SelectedIndex)
          {
            case 0:
              str = "ID";
              break;
            case 1:
              str = "Username";
              break;
            case 2:
              str = "Full Name";
              break;
            case 3:
              str = "Email";
              break;
            case 4:
              str = "Last Logged";
              break;
          }
          OleDbCommand oleDbCommand = new OleDbCommand("SELECT * FROM users WHERE ([" + str + "] LIKE '%" + this.txtbx_search.Text + "%')", this.a.conn);
          try
          {
            oleDbCommand.ExecuteNonQuery();
            oleDbDataAdapter.SelectCommand = oleDbCommand;
            oleDbDataAdapter.Fill(dataTable);
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            int num2 = (int) Interaction.MsgBox((object) ex.Message, MsgBoxStyle.Critical, (object) "Search");
            ProjectData.ClearProjectError();
          }
          this.dgv_account.DataSource = (object) dataTable;
          if (this.dgv_account.Rows.Count >= 1)
          {
            this.dgv_account.Sort(this.dgv_account.Columns[4], ListSortDirection.Ascending);
            int num2 = checked (this.dgv_account.RowCount - 1);
            int index = 0;
            while (index <= num2)
            {
              this.dgv_account.Rows[index].ReadOnly = true;
              checked { ++index; }
            }
          }
          this.dgv_account.ClearSelection();
          this.btn_clear.Enabled = true;
          this.btn_delete.Enabled = false;
          this.btn_quickdel.Enabled = false;
          this.btn_edit.Enabled = false;
          this.labelStatus.Text = this.dgv_account.RowCount < 1 ? "No record found!" : (this.dgv_account.RowCount == 1 ? Conversions.ToString(this.dgv_account.RowCount) + " record found" : Conversions.ToString(this.dgv_account.RowCount) + " records found");
          this.a.close();
        }
      }
    }

    private void btn_clear_Click(object sender, EventArgs e)
    {
      this.ActiveControl = (Control) null;
      this.dgv_account.DataSource = (object) this.a.dataTable("users");
      if (this.dgv_account.Rows.Count >= 1)
      {
        this.dgv_account.Sort(this.dgv_account.Columns[4], ListSortDirection.Ascending);
        int num = checked (this.dgv_account.RowCount - 1);
        int index = 0;
        while (index <= num)
        {
          this.dgv_account.Rows[index].ReadOnly = true;
          checked { ++index; }
        }
        this.txtbx_search.Clear();
        this.labelStatus.Text = "There are " + Conversions.ToString(this.dgv_account.Rows.Count) + " total users";
      }
      this.btn_delete.Enabled = false;
      this.btn_quickdel.Enabled = false;
      this.btn_edit.Enabled = false;
      this.btn_clear.Enabled = false;
    }

    private void btn_edit_Click(object sender, EventArgs e)
    {
      this.ActiveControl = (Control) null;
      if (this.working)
      {
        int num = (int) Interaction.MsgBox((object) "Wait for the background operation to complete.", MsgBoxStyle.Critical, (object) null);
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btn_edit.Text, "Edit", false) == 0)
      {
        if (this.selectedIndex >= 0)
        {
          this.edit = true;
          this.btn_delete.Enabled = false;
          this.btn_quickdel.Enabled = false;
          this.dgv_account.CurrentCell = this.dgv_account[2, this.selectedIndex];
          this.dgv_account.Rows[this.selectedIndex].ReadOnly = false;
          this.dgv_account.BeginEdit(true);
          this.btn_edit.Text = "Save";
        }
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btn_edit.Text, "Save", false) == 0)
      {
        this.edit = false;
        this.editSub();
        this.btn_edit.Text = "Edit";
      }
    }

    private void dgv_account_RowLeave(object sender, EventArgs e)
    {
      if (!this.edit || this.ActiveControl == this.btn_edit)
        return;
      this.edit = false;
      this.editSub();
      this.btn_edit.Text = "Edit";
    }

    private void editSub()
    {
      bool flag = false;
      int num1 = checked (this.dgv_account.Columns.Count - 1);
      int index1 = 0;
      while (index1 <= num1)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dgv_account[index1, this.selectedIndex].Value.ToString(), this.accountTemp[index1].ToString(), false) != 0)
          flag = true;
        checked { ++index1; }
      }
      if (!flag)
        this.dgv_account.Rows[this.selectedIndex].ReadOnly = true;
      else if (MessageBox.Show("Do you want to save your changes on edit?", "Edit user account", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) != DialogResult.OK)
      {
        int num2 = checked (this.dgv_account.Columns.Count - 1);
        int index2 = 0;
        while (index2 <= num2)
        {
          this.dgv_account[index2, this.selectedIndex].Value = RuntimeHelpers.GetObjectValue(this.accountTemp[index2]);
          checked { ++index2; }
        }
        this.dgv_account.Rows[this.selectedIndex].ReadOnly = true;
      }
      else
      {
        int result = 0;
        if (!int.TryParse(this.dgv_account[3, this.selectedIndex].Value.ToString(), out result))
          result = 0;
        try
        {
          this.a.open();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          int num2 = (int) Interaction.MsgBox((object) ex.Message, MsgBoxStyle.Critical, (object) "Editing: Can't open database");
          ProjectData.ClearProjectError();
          return;
        }
        if (this.a.isOpen)
        {
          OleDbCommand oleDbCommand = new OleDbCommand("UPDATE users SET [Password]='" + this.dgv_account[2, this.selectedIndex].Value.ToString() + "', [Credits]='" + Conversions.ToString(result) + "', [Full Name]='" + this.dgv_account[5, this.selectedIndex].Value.ToString() + "', [Email]='" + this.dgv_account[6, this.selectedIndex].Value.ToString() + "' WHERE [Username]='" + this.dgv_account[1, this.selectedIndex].Value.ToString() + "'", this.a.conn);
          try
          {
            oleDbCommand.ExecuteNonQuery();
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            int num2 = (int) Interaction.MsgBox((object) ex.Message, MsgBoxStyle.Critical, (object) "Editing: Can't save");
            ProjectData.ClearProjectError();
            return;
          }
          this.dgv_account[3, this.selectedIndex].Value = (object) result;
          this.dgv_account.Rows[this.selectedIndex].ReadOnly = true;
          this.accountTemp = (ArrayList) null;
          this.accountTemp = new ArrayList();
          int num3 = checked (this.dgv_account.Columns.Count - 1);
          int index2 = 0;
          while (index2 <= num3)
          {
            this.accountTemp.Add(RuntimeHelpers.GetObjectValue(this.dgv_account[index2, this.dgv_account.CurrentRow.Index].Value));
            checked { ++index2; }
          }
          this.a.close();
          this.labelStatus.Text = "Changed saved to the user account " + this.accountTemp[1].ToString();
          int num4 = (int) Interaction.MsgBox((object) "Saved complete!", MsgBoxStyle.Information, (object) "Changed saved");
        }
      }
      this.btn_delete.Enabled = true;
      this.btn_quickdel.Enabled = true;
    }

    private delegate void MyDelegate();
  }
}
