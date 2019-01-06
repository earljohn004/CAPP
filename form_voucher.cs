// Decompiled with JetBrains decompiler
// Type: coinapp.form_voucher
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
  public class form_voucher : Form
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private IContainer components;
    [AccessedThroughProperty("dgv_voucher")]
    private DataGridView _dgv_voucher;
    [AccessedThroughProperty("btn_create")]
    private Button _btn_create;
    [AccessedThroughProperty("txtbx_search")]
    private TextBox _txtbx_search;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("cb_search")]
    private ComboBox _cb_search;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("btn_search")]
    private Button _btn_search;
    [AccessedThroughProperty("btn_delete")]
    private Button _btn_delete;
    [AccessedThroughProperty("btn_print")]
    private Button _btn_print;
    [AccessedThroughProperty("nud_hour")]
    private NumericUpDown _nud_hour;
    [AccessedThroughProperty("gb_details")]
    private GroupBox _gb_details;
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
    [AccessedThroughProperty("GroupBox2")]
    private GroupBox _GroupBox2;
    [AccessedThroughProperty("StatusStrip1")]
    private StatusStrip _StatusStrip1;
    [AccessedThroughProperty("Label6")]
    private Label _Label6;
    [AccessedThroughProperty("nud_piece")]
    private NumericUpDown _nud_piece;
    [AccessedThroughProperty("dtp_expiration")]
    private DateTimePicker _dtp_expiration;
    [AccessedThroughProperty("chkbx_expiration")]
    private CheckBox _chkbx_expiration;
    [AccessedThroughProperty("btn_quickcreate")]
    private Button _btn_quickcreate;
    [AccessedThroughProperty("btn_clear")]
    private Button _btn_clear;
    [AccessedThroughProperty("btn_quickdel")]
    private Button _btn_quickdel;
    private database v;
    private int voucherDigit;
    private ArrayList voucherTemp;
    private int voucherCreated;
    private DataTable table;
    [AccessedThroughProperty("worker")]
    private BackgroundWorker _worker;
    private ToolStripStatusLabel labelStatus;
    private int selectedIndex;
    private bool quick;
    private bool working;

    [DebuggerNonUserCode]
    static form_voucher()
    {
    }

    public form_voucher()
    {
      this.Load += new EventHandler(this.form_voucher_Load);
      form_voucher.__ENCAddToList((object) this);
      this.voucherDigit = 8;
      this.voucherCreated = 0;
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (form_voucher.__ENCList)
      {
        if (form_voucher.__ENCList.Count == form_voucher.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (form_voucher.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (form_voucher.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                form_voucher.__ENCList[index1] = form_voucher.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          form_voucher.__ENCList.RemoveRange(index1, checked (form_voucher.__ENCList.Count - index1));
          form_voucher.__ENCList.Capacity = form_voucher.__ENCList.Count;
        }
        form_voucher.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (form_voucher));
      this.dgv_voucher = new DataGridView();
      this.btn_create = new Button();
      this.txtbx_search = new TextBox();
      this.Label1 = new Label();
      this.cb_search = new ComboBox();
      this.Label2 = new Label();
      this.btn_search = new Button();
      this.btn_delete = new Button();
      this.btn_print = new Button();
      this.nud_hour = new NumericUpDown();
      this.gb_details = new GroupBox();
      this.chkbx_expiration = new CheckBox();
      this.nud_piece = new NumericUpDown();
      this.dtp_expiration = new DateTimePicker();
      this.Label6 = new Label();
      this.Label5 = new Label();
      this.Label4 = new Label();
      this.nud_second = new NumericUpDown();
      this.Label3 = new Label();
      this.nud_minute = new NumericUpDown();
      this.GroupBox2 = new GroupBox();
      this.btn_quickdel = new Button();
      this.btn_clear = new Button();
      this.StatusStrip1 = new StatusStrip();
      this.btn_quickcreate = new Button();
      ((ISupportInitialize) this.dgv_voucher).BeginInit();
      this.nud_hour.BeginInit();
      this.gb_details.SuspendLayout();
      this.nud_piece.BeginInit();
      this.nud_second.BeginInit();
      this.nud_minute.BeginInit();
      this.GroupBox2.SuspendLayout();
      this.SuspendLayout();
      this.dgv_voucher.AllowUserToAddRows = false;
      this.dgv_voucher.AllowUserToDeleteRows = false;
      this.dgv_voucher.AllowUserToResizeColumns = false;
      this.dgv_voucher.AllowUserToResizeRows = false;
      this.dgv_voucher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
      this.dgv_voucher.BorderStyle = BorderStyle.Fixed3D;
      gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle1.BackColor = Color.DimGray;
      gridViewCellStyle1.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      gridViewCellStyle1.ForeColor = Color.White;
      gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
      this.dgv_voucher.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
      this.dgv_voucher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle2.BackColor = SystemColors.Window;
      gridViewCellStyle2.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      gridViewCellStyle2.ForeColor = SystemColors.ControlText;
      gridViewCellStyle2.SelectionBackColor = SystemColors.HotTrack;
      gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
      this.dgv_voucher.DefaultCellStyle = gridViewCellStyle2;
      this.dgv_voucher.EnableHeadersVisualStyles = false;
      DataGridView dgvVoucher1 = this.dgv_voucher;
      Point point1 = new Point(19, 58);
      Point point2 = point1;
      dgvVoucher1.Location = point2;
      this.dgv_voucher.MultiSelect = false;
      this.dgv_voucher.Name = "dgv_voucher";
      this.dgv_voucher.ReadOnly = true;
      this.dgv_voucher.RowHeadersVisible = false;
      this.dgv_voucher.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      DataGridView dgvVoucher2 = this.dgv_voucher;
      Size size1 = new Size(411, 164);
      Size size2 = size1;
      dgvVoucher2.Size = size2;
      this.dgv_voucher.TabIndex = 20;
      this.dgv_voucher.TabStop = false;
      this.btn_create.Enabled = false;
      Button btnCreate1 = this.btn_create;
      point1 = new Point(315, 17);
      Point point3 = point1;
      btnCreate1.Location = point3;
      this.btn_create.Name = "btn_create";
      Button btnCreate2 = this.btn_create;
      size1 = new Size(153, 82);
      Size size3 = size1;
      btnCreate2.Size = size3;
      this.btn_create.TabIndex = 11;
      this.btn_create.TabStop = false;
      this.btn_create.Text = "Create New Voucher";
      this.btn_create.UseVisualStyleBackColor = true;
      this.txtbx_search.Enabled = false;
      this.txtbx_search.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      TextBox txtbxSearch1 = this.txtbx_search;
      point1 = new Point(19, 30);
      Point point4 = point1;
      txtbxSearch1.Location = point4;
      this.txtbx_search.Name = "txtbx_search";
      TextBox txtbxSearch2 = this.txtbx_search;
      size1 = new Size(170, 22);
      Size size4 = size1;
      txtbxSearch2.Size = size4;
      this.txtbx_search.TabIndex = 15;
      this.Label1.AutoSize = true;
      Label label1_1 = this.Label1;
      point1 = new Point(16, 12);
      Point point5 = point1;
      label1_1.Location = point5;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(86, 13);
      Size size5 = size1;
      label1_2.Size = size5;
      this.Label1.TabIndex = 14;
      this.Label1.Text = "Search voucher:";
      this.cb_search.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cb_search.Enabled = false;
      this.cb_search.FormattingEnabled = true;
      this.cb_search.Items.AddRange(new object[6]
      {
        (object) "#",
        (object) "ID",
        (object) "Status",
        (object) "Expiration",
        (object) "Created",
        (object) "Date Used"
      });
      ComboBox cbSearch1 = this.cb_search;
      point1 = new Point(195, 30);
      Point point6 = point1;
      cbSearch1.Location = point6;
      this.cb_search.Name = "cb_search";
      ComboBox cbSearch2 = this.cb_search;
      size1 = new Size(88, 21);
      Size size6 = size1;
      cbSearch2.Size = size6;
      this.cb_search.TabIndex = 17;
      this.Label2.AutoSize = true;
      Label label2_1 = this.Label2;
      point1 = new Point(192, 12);
      Point point7 = point1;
      label2_1.Location = point7;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(58, 13);
      Size size7 = size1;
      label2_2.Size = size7;
      this.Label2.TabIndex = 16;
      this.Label2.Text = "Search by:";
      this.btn_search.Enabled = false;
      Button btnSearch1 = this.btn_search;
      point1 = new Point(287, 28);
      Point point8 = point1;
      btnSearch1.Location = point8;
      this.btn_search.Name = "btn_search";
      Button btnSearch2 = this.btn_search;
      size1 = new Size(70, 25);
      Size size8 = size1;
      btnSearch2.Size = size8;
      this.btn_search.TabIndex = 18;
      this.btn_search.TabStop = false;
      this.btn_search.Text = "Search";
      this.btn_search.UseVisualStyleBackColor = true;
      this.btn_delete.Enabled = false;
      Button btnDelete1 = this.btn_delete;
      point1 = new Point(340, 228);
      Point point9 = point1;
      btnDelete1.Location = point9;
      this.btn_delete.Name = "btn_delete";
      Button btnDelete2 = this.btn_delete;
      size1 = new Size(90, 25);
      Size size9 = size1;
      btnDelete2.Size = size9;
      this.btn_delete.TabIndex = 23;
      this.btn_delete.TabStop = false;
      this.btn_delete.Text = "Delete";
      this.btn_delete.UseVisualStyleBackColor = true;
      this.btn_print.Enabled = false;
      Button btnPrint1 = this.btn_print;
      point1 = new Point(148, 228);
      Point point10 = point1;
      btnPrint1.Location = point10;
      this.btn_print.Name = "btn_print";
      Button btnPrint2 = this.btn_print;
      size1 = new Size(90, 25);
      Size size10 = size1;
      btnPrint2.Size = size10;
      this.btn_print.TabIndex = 21;
      this.btn_print.TabStop = false;
      this.btn_print.Text = "Print";
      this.btn_print.UseVisualStyleBackColor = true;
      NumericUpDown nudHour1 = this.nud_hour;
      point1 = new Point(80, 26);
      Point point11 = point1;
      nudHour1.Location = point11;
      NumericUpDown nudHour2 = this.nud_hour;
      Decimal num1 = new Decimal(new int[4]
      {
        999,
        0,
        0,
        0
      });
      Decimal num2 = num1;
      nudHour2.Maximum = num2;
      this.nud_hour.Name = "nud_hour";
      NumericUpDown nudHour3 = this.nud_hour;
      size1 = new Size(50, 20);
      Size size11 = size1;
      nudHour3.Size = size11;
      this.nud_hour.TabIndex = 2;
      this.gb_details.Controls.Add((Control) this.chkbx_expiration);
      this.gb_details.Controls.Add((Control) this.nud_piece);
      this.gb_details.Controls.Add((Control) this.dtp_expiration);
      this.gb_details.Controls.Add((Control) this.Label6);
      this.gb_details.Controls.Add((Control) this.Label5);
      this.gb_details.Controls.Add((Control) this.Label4);
      this.gb_details.Controls.Add((Control) this.nud_second);
      this.gb_details.Controls.Add((Control) this.Label3);
      this.gb_details.Controls.Add((Control) this.nud_minute);
      this.gb_details.Controls.Add((Control) this.nud_hour);
      this.gb_details.Enabled = false;
      GroupBox gbDetails1 = this.gb_details;
      point1 = new Point(15, 12);
      Point point12 = point1;
      gbDetails1.Location = point12;
      this.gb_details.Name = "gb_details";
      GroupBox gbDetails2 = this.gb_details;
      size1 = new Size(294, 135);
      Size size12 = size1;
      gbDetails2.Size = size12;
      this.gb_details.TabIndex = 0;
      this.gb_details.TabStop = false;
      this.gb_details.Text = "VOUCHER DETAILS";
      this.chkbx_expiration.AutoSize = true;
      this.chkbx_expiration.Enabled = false;
      CheckBox chkbxExpiration1 = this.chkbx_expiration;
      point1 = new Point(150, 79);
      Point point13 = point1;
      chkbxExpiration1.Location = point13;
      this.chkbx_expiration.Name = "chkbx_expiration";
      CheckBox chkbxExpiration2 = this.chkbx_expiration;
      size1 = new Size(88, 17);
      Size size13 = size1;
      chkbxExpiration2.Size = size13;
      this.chkbx_expiration.TabIndex = 9;
      this.chkbx_expiration.Text = "w/ Expiration";
      this.chkbx_expiration.UseVisualStyleBackColor = true;
      this.nud_piece.Enabled = false;
      NumericUpDown nudPiece1 = this.nud_piece;
      point1 = new Point(150, 42);
      Point point14 = point1;
      nudPiece1.Location = point14;
      NumericUpDown nudPiece2 = this.nud_piece;
      num1 = new Decimal(new int[4]{ 1000, 0, 0, 0 });
      Decimal num3 = num1;
      nudPiece2.Maximum = num3;
      this.nud_piece.Name = "nud_piece";
      NumericUpDown nudPiece3 = this.nud_piece;
      size1 = new Size(107, 20);
      Size size14 = size1;
      nudPiece3.Size = size14;
      this.nud_piece.TabIndex = 8;
      this.dtp_expiration.CustomFormat = "yyyy/MM/dd";
      this.dtp_expiration.Enabled = false;
      this.dtp_expiration.Format = DateTimePickerFormat.Custom;
      this.dtp_expiration.ImeMode = ImeMode.NoControl;
      DateTimePicker dtpExpiration1 = this.dtp_expiration;
      point1 = new Point(150, 100);
      Point point15 = point1;
      dtpExpiration1.Location = point15;
      DateTimePicker dtpExpiration2 = this.dtp_expiration;
      DateTime dateTime1 = new DateTime(2018, 12, 12, 0, 0, 0, 0);
      DateTime dateTime2 = dateTime1;
      dtpExpiration2.MinDate = dateTime2;
      this.dtp_expiration.Name = "dtp_expiration";
      DateTimePicker dtpExpiration3 = this.dtp_expiration;
      size1 = new Size(107, 20);
      Size size15 = size1;
      dtpExpiration3.Size = size15;
      this.dtp_expiration.TabIndex = 10;
      DateTimePicker dtpExpiration4 = this.dtp_expiration;
      dateTime1 = new DateTime(2018, 12, 12, 0, 0, 0, 0);
      DateTime dateTime3 = dateTime1;
      dtpExpiration4.Value = dateTime3;
      this.Label6.AutoSize = true;
      Label label6_1 = this.Label6;
      point1 = new Point(147, 26);
      Point point16 = point1;
      label6_1.Location = point16;
      this.Label6.Name = "Label6";
      Label label6_2 = this.Label6;
      size1 = new Size(110, 13);
      Size size16 = size1;
      label6_2.Size = size16;
      this.Label6.TabIndex = 7;
      this.Label6.Text = "How many vouchers?";
      this.Label5.AutoSize = true;
      Label label5_1 = this.Label5;
      point1 = new Point(19, 100);
      Point point17 = point1;
      label5_1.Location = point17;
      this.Label5.Name = "Label5";
      Label label5_2 = this.Label5;
      size1 = new Size(55, 13);
      Size size17 = size1;
      label5_2.Size = size17;
      this.Label5.TabIndex = 5;
      this.Label5.Text = "Second(s)";
      this.Label4.AutoSize = true;
      Label label4_1 = this.Label4;
      point1 = new Point(19, 62);
      Point point18 = point1;
      label4_1.Location = point18;
      this.Label4.Name = "Label4";
      Label label4_2 = this.Label4;
      size1 = new Size(50, 13);
      Size size18 = size1;
      label4_2.Size = size18;
      this.Label4.TabIndex = 3;
      this.Label4.Text = "Minute(s)";
      NumericUpDown nudSecond1 = this.nud_second;
      point1 = new Point(80, 98);
      Point point19 = point1;
      nudSecond1.Location = point19;
      NumericUpDown nudSecond2 = this.nud_second;
      num1 = new Decimal(new int[4]{ 59, 0, 0, 0 });
      Decimal num4 = num1;
      nudSecond2.Maximum = num4;
      this.nud_second.Name = "nud_second";
      NumericUpDown nudSecond3 = this.nud_second;
      size1 = new Size(50, 20);
      Size size19 = size1;
      nudSecond3.Size = size19;
      this.nud_second.TabIndex = 6;
      this.Label3.AutoSize = true;
      Label label3_1 = this.Label3;
      point1 = new Point(19, 28);
      Point point20 = point1;
      label3_1.Location = point20;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(41, 13);
      Size size20 = size1;
      label3_2.Size = size20;
      this.Label3.TabIndex = 1;
      this.Label3.Text = "Hour(s)";
      NumericUpDown nudMinute1 = this.nud_minute;
      point1 = new Point(80, 60);
      Point point21 = point1;
      nudMinute1.Location = point21;
      NumericUpDown nudMinute2 = this.nud_minute;
      num1 = new Decimal(new int[4]{ 59, 0, 0, 0 });
      Decimal num5 = num1;
      nudMinute2.Maximum = num5;
      this.nud_minute.Name = "nud_minute";
      NumericUpDown nudMinute3 = this.nud_minute;
      size1 = new Size(50, 20);
      Size size21 = size1;
      nudMinute3.Size = size21;
      this.nud_minute.TabIndex = 4;
      this.GroupBox2.Controls.Add((Control) this.txtbx_search);
      this.GroupBox2.Controls.Add((Control) this.Label1);
      this.GroupBox2.Controls.Add((Control) this.btn_print);
      this.GroupBox2.Controls.Add((Control) this.btn_quickdel);
      this.GroupBox2.Controls.Add((Control) this.btn_delete);
      this.GroupBox2.Controls.Add((Control) this.Label2);
      this.GroupBox2.Controls.Add((Control) this.cb_search);
      this.GroupBox2.Controls.Add((Control) this.btn_clear);
      this.GroupBox2.Controls.Add((Control) this.btn_search);
      this.GroupBox2.Controls.Add((Control) this.dgv_voucher);
      GroupBox groupBox2_1 = this.GroupBox2;
      point1 = new Point(15, 153);
      Point point22 = point1;
      groupBox2_1.Location = point22;
      this.GroupBox2.Name = "GroupBox2";
      GroupBox groupBox2_2 = this.GroupBox2;
      size1 = new Size(453, 263);
      Size size22 = size1;
      groupBox2_2.Size = size22;
      this.GroupBox2.TabIndex = 13;
      this.GroupBox2.TabStop = false;
      this.btn_quickdel.Enabled = false;
      Button btnQuickdel1 = this.btn_quickdel;
      point1 = new Point(244, 228);
      Point point23 = point1;
      btnQuickdel1.Location = point23;
      this.btn_quickdel.Name = "btn_quickdel";
      Button btnQuickdel2 = this.btn_quickdel;
      size1 = new Size(90, 25);
      Size size23 = size1;
      btnQuickdel2.Size = size23;
      this.btn_quickdel.TabIndex = 22;
      this.btn_quickdel.TabStop = false;
      this.btn_quickdel.Text = "Quick Delete";
      this.btn_quickdel.UseVisualStyleBackColor = true;
      this.btn_clear.Enabled = false;
      Button btnClear1 = this.btn_clear;
      point1 = new Point(360, 28);
      Point point24 = point1;
      btnClear1.Location = point24;
      this.btn_clear.Name = "btn_clear";
      Button btnClear2 = this.btn_clear;
      size1 = new Size(70, 25);
      Size size24 = size1;
      btnClear2.Size = size24;
      this.btn_clear.TabIndex = 19;
      this.btn_clear.TabStop = false;
      this.btn_clear.Text = "Clear";
      this.btn_clear.UseVisualStyleBackColor = true;
      StatusStrip statusStrip1_1 = this.StatusStrip1;
      point1 = new Point(0, 436);
      Point point25 = point1;
      statusStrip1_1.Location = point25;
      this.StatusStrip1.Name = "StatusStrip1";
      StatusStrip statusStrip1_2 = this.StatusStrip1;
      size1 = new Size(480, 22);
      Size size25 = size1;
      statusStrip1_2.Size = size25;
      this.StatusStrip1.TabIndex = 24;
      this.StatusStrip1.Text = "StatusStrip1";
      this.btn_quickcreate.Enabled = false;
      Button btnQuickcreate1 = this.btn_quickcreate;
      point1 = new Point(315, 105);
      Point point26 = point1;
      btnQuickcreate1.Location = point26;
      this.btn_quickcreate.Name = "btn_quickcreate";
      Button btnQuickcreate2 = this.btn_quickcreate;
      size1 = new Size(153, 42);
      Size size26 = size1;
      btnQuickcreate2.Size = size26;
      this.btn_quickcreate.TabIndex = 12;
      this.btn_quickcreate.TabStop = false;
      this.btn_quickcreate.Text = "Quick create";
      this.btn_quickcreate.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(480, 458);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.StatusStrip1);
      this.Controls.Add((Control) this.GroupBox2);
      this.Controls.Add((Control) this.btn_quickcreate);
      this.Controls.Add((Control) this.btn_create);
      this.Controls.Add((Control) this.gb_details);
      this.FormBorderStyle = FormBorderStyle.Fixed3D;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      size1 = new Size(500, 500);
      this.MaximumSize = size1;
      size1 = new Size(500, 500);
      this.MinimumSize = size1;
      this.Name = nameof (form_voucher);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Voucher Manager";
      ((ISupportInitialize) this.dgv_voucher).EndInit();
      this.nud_hour.EndInit();
      this.gb_details.ResumeLayout(false);
      this.gb_details.PerformLayout();
      this.nud_piece.EndInit();
      this.nud_second.EndInit();
      this.nud_minute.EndInit();
      this.GroupBox2.ResumeLayout(false);
      this.GroupBox2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual DataGridView dgv_voucher
    {
      [DebuggerNonUserCode] get
      {
        return this._dgv_voucher;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.dgv_voucher_CellClick);
        if (this._dgv_voucher != null)
          this._dgv_voucher.CellClick -= cellEventHandler;
        this._dgv_voucher = value;
        if (this._dgv_voucher == null)
          return;
        this._dgv_voucher.CellClick += cellEventHandler;
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

    internal virtual Label Label1
    {
      [DebuggerNonUserCode] get
      {
        return this._Label1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label1 = value;
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

    internal virtual Button btn_print
    {
      [DebuggerNonUserCode] get
      {
        return this._btn_print;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btn_print_Click);
        if (this._btn_print != null)
          this._btn_print.Click -= eventHandler;
        this._btn_print = value;
        if (this._btn_print == null)
          return;
        this._btn_print.Click += eventHandler;
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
        EventHandler eventHandler = new EventHandler(this.nud_TextChanged);
        if (this._nud_hour != null)
          this._nud_hour.TextChanged -= eventHandler;
        this._nud_hour = value;
        if (this._nud_hour == null)
          return;
        this._nud_hour.TextChanged += eventHandler;
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
        EventHandler eventHandler = new EventHandler(this.nud_TextChanged);
        if (this._nud_second != null)
          this._nud_second.TextChanged -= eventHandler;
        this._nud_second = value;
        if (this._nud_second == null)
          return;
        this._nud_second.TextChanged += eventHandler;
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
        EventHandler eventHandler = new EventHandler(this.nud_TextChanged);
        if (this._nud_minute != null)
          this._nud_minute.TextChanged -= eventHandler;
        this._nud_minute = value;
        if (this._nud_minute == null)
          return;
        this._nud_minute.TextChanged += eventHandler;
      }
    }

    internal virtual GroupBox GroupBox2
    {
      [DebuggerNonUserCode] get
      {
        return this._GroupBox2;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._GroupBox2 = value;
      }
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

    internal virtual NumericUpDown nud_piece
    {
      [DebuggerNonUserCode] get
      {
        return this._nud_piece;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._nud_piece = value;
      }
    }

    internal virtual DateTimePicker dtp_expiration
    {
      [DebuggerNonUserCode] get
      {
        return this._dtp_expiration;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._dtp_expiration = value;
      }
    }

    internal virtual CheckBox chkbx_expiration
    {
      [DebuggerNonUserCode] get
      {
        return this._chkbx_expiration;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkbx_expiration_CheckedChanged);
        if (this._chkbx_expiration != null)
          this._chkbx_expiration.CheckedChanged -= eventHandler;
        this._chkbx_expiration = value;
        if (this._chkbx_expiration == null)
          return;
        this._chkbx_expiration.CheckedChanged += eventHandler;
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
        EventHandler eventHandler = new EventHandler(this.btn_quick_Click);
        if (this._btn_quickcreate != null)
          this._btn_quickcreate.Click -= eventHandler;
        this._btn_quickcreate = value;
        if (this._btn_quickcreate == null)
          return;
        this._btn_quickcreate.Click += eventHandler;
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
        ProgressChangedEventHandler changedEventHandler = new ProgressChangedEventHandler(this.worker_ProgressChanged);
        if (this._worker != null)
        {
          this._worker.RunWorkerCompleted -= completedEventHandler;
          this._worker.DoWork -= workEventHandler;
          this._worker.ProgressChanged -= changedEventHandler;
        }
        this._worker = value;
        if (this._worker == null)
          return;
        this._worker.RunWorkerCompleted += completedEventHandler;
        this._worker.DoWork += workEventHandler;
        this._worker.ProgressChanged += changedEventHandler;
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
        else if (this.v != null)
          this.v.close();
      }
      else if (this.v != null)
        this.v.close();
      base.OnFormClosing(e);
    }

    private void form_voucher_Load(object sender, EventArgs e)
    {
      this.labelStatus = new ToolStripStatusLabel();
      this.StatusStrip1.Items.Add((ToolStripItem) this.labelStatus);
      string filePath = coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("data")), "data");
      string databaseFileName = coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("voucherFilename")), "voucher");
      string databasePassword = coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("voucherPassword")), "voucher");
      if (!File.Exists(filePath + databaseFileName + ".mdb"))
      {
        int num1 = (int) Interaction.MsgBox((object) (databaseFileName + ".mdb database voucher is missing in data folder location."), MsgBoxStyle.Critical, (object) "Database voucher not found!");
      }
      else
      {
        this.v = new database(filePath, databaseFileName, databasePassword);
        try
        {
          this.v.open();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          int num2 = (int) Interaction.MsgBox((object) ex.Message, MsgBoxStyle.Critical, (object) "Error opening database voucher");
          ProjectData.ClearProjectError();
          return;
        }
        if (this.v.isOpen)
        {
          if (this.v.conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[4]
          {
            (object) null,
            (object) null,
            (object) "coupons",
            (object) "TABLE"
          }).Rows.Count > 0 || MessageBox.Show("This will create a 'coupons' table in the database voucher ''" + databaseFileName + ".mdb'", "Create table", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) != DialogResult.OK)
            goto label_10;
label_7:
          OleDbCommand oleDbCommand1 = new OleDbCommand("CREATE TABLE [coupons] ([#] TEXT(5), [ID] TEXT(8), [Credits] TEXT(50), [Status] TEXT(50), [Expiration] TEXT(50), [Created] TEXT(50), [Date Used] TEXT(50))", this.v.conn);
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
          DataColumnCollection columns = this.v.dataTable("coupons").Columns;
          if (columns.Count != 7)
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
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnName, "#", false) == 0)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataColumn.DataType.ToString(), "System.String", false) != 0)
                    flag = true;
                }
                else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnName, "ID", false) == 0)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataColumn.DataType.ToString(), "System.String", false) != 0)
                    flag = true;
                }
                else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnName, "Credits", false) == 0)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataColumn.DataType.ToString(), "System.String", false) != 0)
                    flag = true;
                }
                else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnName, "Status", false) == 0)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataColumn.DataType.ToString(), "System.String", false) != 0)
                    flag = true;
                }
                else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnName, "Expiration", false) == 0)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataColumn.DataType.ToString(), "System.String", false) != 0)
                    flag = true;
                }
                else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnName, "Created", false) == 0)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataColumn.DataType.ToString(), "System.String", false) != 0)
                    flag = true;
                }
                else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnName, "Date Used", false) == 0)
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
          if (flag && MessageBox.Show("The column field DataTypes in table 'coupons' is invalid. Do you want to delete the table 'coupons' and create for a new one to correct the format?\r\nWARNING: all the data on the table 'coupons' will be deleted. Continue?", "Create new table", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
          {
            OleDbCommand oleDbCommand2 = new OleDbCommand("DROP TABLE coupons", this.v.conn);
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
            this.dgv_voucher.DataSource = (object) this.v.dataTable("coupons");
            this.dgv_voucher.ClearSelection();
            this.v.close();
          }
        }
        if (this.dgv_voucher.Rows.Count >= 1)
        {
          this.dgv_voucher.Sort(this.dgv_voucher.Columns[5], ListSortDirection.Ascending);
          this.txtbx_search.Enabled = true;
        }
        this.labelStatus.Text = this.dgv_voucher.Rows.Count == 0 ? " There are no voucher record." : (this.dgv_voucher.Rows.Count == 1 ? "There are " + Conversions.ToString(this.dgv_voucher.Rows.Count) + " voucher only." : "There are " + Conversions.ToString(this.dgv_voucher.Rows.Count) + " total vouchers.");
        this.gb_details.Enabled = true;
      }
    }

    private void nud_TextChanged(object sender, EventArgs e)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(sender, (System.Type) null, "Text", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "0", false) && Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(sender, (System.Type) null, "Text", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "", false))
      {
        this.btn_create.Enabled = true;
        this.btn_quickcreate.Enabled = true;
        this.nud_piece.Enabled = true;
        this.nud_piece.Value = Decimal.One;
        this.nud_piece.Minimum = Decimal.One;
        this.chkbx_expiration.Enabled = true;
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.nud_hour.Text, "0", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.nud_hour.Text, "", false) != 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.nud_minute.Text, "0", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.nud_minute.Text, "", false) != 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.nud_second.Text, "0", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.nud_second.Text, "", false) != 0)
      {
        this.btn_create.Enabled = true;
        this.nud_piece.Enabled = true;
        this.btn_quickcreate.Enabled = true;
        this.nud_piece.Value = Decimal.One;
        this.nud_piece.Minimum = Decimal.One;
        this.chkbx_expiration.Enabled = true;
      }
      else
      {
        this.btn_create.Enabled = false;
        this.btn_quickcreate.Enabled = false;
        this.nud_piece.Enabled = false;
        this.nud_piece.Minimum = Decimal.Zero;
        this.nud_piece.Value = Decimal.Zero;
        this.chkbx_expiration.Checked = false;
        this.chkbx_expiration.Enabled = false;
        this.dtp_expiration.Enabled = false;
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

    private void btn_create_Click(object sender, EventArgs e)
    {
      this.ActiveControl = (Control) null;
      if (MessageBox.Show("Create " + Conversions.ToString(this.nud_piece.Value) + (Decimal.Compare(this.nud_piece.Value, Decimal.One) == 0 ? " voucher?" : " vouchers?") + "\r\n\r\nIf you create more vouchers it will consume a CPU usage and it will take a time. Continue?", "Create voucher", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) != DialogResult.OK)
        return;
      this.btn_create.Text = "Creating...";
      this.btn_create.Enabled = false;
      this.btn_quickcreate.Enabled = false;
      this.gb_details.Enabled = false;
      this.worker = new BackgroundWorker();
      this.worker.WorkerSupportsCancellation = true;
      this.worker.WorkerReportsProgress = true;
      this.worker.RunWorkerAsync();
    }

    private void btn_search_Click(object sender, EventArgs e)
    {
      this.ActiveControl = (Control) null;
      if (this.working)
      {
        int num1 = (int) Interaction.MsgBox((object) "Wait for the background operation to complete.", MsgBoxStyle.Critical, (object) null);
      }
      else if (!this.v.open())
      {
        int num2 = (int) Interaction.MsgBox((object) "There is a problem connecting to the database.", MsgBoxStyle.Critical, (object) "Failed to search");
      }
      else
      {
        OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter();
        DataTable dataTable = new DataTable();
        string str = (string) null;
        switch (this.cb_search.SelectedIndex)
        {
          case 0:
            str = "#";
            break;
          case 1:
            str = "ID";
            break;
          case 2:
            str = "Status";
            break;
          case 3:
            str = "Expiration";
            break;
          case 4:
            str = "Created";
            break;
          case 5:
            str = "Date Used";
            break;
        }
        OleDbCommand oleDbCommand = new OleDbCommand("SELECT * FROM coupons WHERE ([" + str + "] LIKE '%" + this.txtbx_search.Text + "%')", this.v.conn);
        try
        {
          oleDbCommand.ExecuteNonQuery();
          oleDbDataAdapter.SelectCommand = oleDbCommand;
          oleDbDataAdapter.Fill(dataTable);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          int num3 = (int) Interaction.MsgBox((object) ex.Message, MsgBoxStyle.Critical, (object) "Search");
          ProjectData.ClearProjectError();
        }
        this.dgv_voucher.DataSource = (object) dataTable;
        this.dgv_voucher.ClearSelection();
        this.btn_clear.Enabled = true;
        this.btn_print.Enabled = false;
        this.btn_delete.Enabled = false;
        this.btn_quickdel.Enabled = false;
        this.labelStatus.Text = this.dgv_voucher.RowCount < 1 ? "No record found!" : (this.dgv_voucher.RowCount == 1 ? Conversions.ToString(this.dgv_voucher.RowCount) + " record found" : Conversions.ToString(this.dgv_voucher.RowCount) + " records found");
        this.v.close();
      }
    }

    private void btn_delete_Click(object sender, EventArgs e)
    {
      this.ActiveControl = (Control) null;
      if (this.working)
      {
        int num1 = (int) Interaction.MsgBox((object) "Wait for the background operation to complete.", MsgBoxStyle.Critical, (object) null);
      }
      else if (this.voucherTemp != null)
      {
        int integer = Conversions.ToInteger(this.voucherTemp[2]);
        int num2 = integer % 60;
        int num3 = checked ((int) Math.Round(unchecked ((double) checked (integer - num2) / 60.0 % 60.0)));
        int num4 = checked ((int) Math.Round(unchecked ((double) checked (integer - num2 + num3 * 60) / 3600.0 % 60.0)));
        if (MessageBox.Show("Delete this voucher?\r\n\r\nVoucher #: " + this.voucherTemp[0].ToString() + "\r\nVoucher ID: " + this.voucherTemp[1].ToString() + "\r\nCredits: " + (num4 > 0 ? Conversions.ToString(num4) + " " + (num4 == 1 ? "hour " : "hours ") : "") + (num3 > 0 ? Conversions.ToString(num3) + " " + (num3 == 1 ? "minute " : "minutes ") : "") + (num2 > 0 ? Conversions.ToString(num2) + " " + (num2 == 1 ? "second" : "seconds") : "") + "\r\nStatus: " + this.voucherTemp[3].ToString() + "\r\nExpiration: " + this.voucherTemp[4].ToString() + "\r\nCreated: " + this.voucherTemp[5].ToString() + "\r\nDate Used: " + (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.voucherTemp[6].ToString(), "", false) == 0 ? "(Never used)" : this.voucherTemp[6].ToString()), "Delete voucher", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
        {
          OleDbCommand oleDbCommand = new OleDbCommand();
          string str = "DELETE * FROM coupons WHERE ([ID] = '" + this.voucherTemp[1].ToString() + "')";
          try
          {
            this.v.open();
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            int num5 = (int) Interaction.MsgBox((object) ex.Message, MsgBoxStyle.Critical, (object) "Deleting voucher failed");
            ProjectData.ClearProjectError();
            return;
          }
          if (this.v.isOpen)
          {
            try
            {
              oleDbCommand.Connection = this.v.conn;
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
            this.v.close();
          }
          this.voucherTemp = (ArrayList) null;
          this.dgv_voucher.DataSource = (object) this.v.dataTable("coupons");
          this.dgv_voucher.Sort(this.dgv_voucher.Columns[5], ListSortDirection.Ascending);
          if (this.dgv_voucher.Rows.Count > 0)
          {
            if (this.selectedIndex != checked (this.dgv_voucher.Rows.Count - 1) && this.selectedIndex != 0)
              checked { --this.selectedIndex; }
            this.dgv_voucher.CurrentCell = this.dgv_voucher[0, this.selectedIndex];
            this.voucherTemp = new ArrayList();
            int num5 = checked (this.dgv_voucher.Columns.Count - 1);
            int index = 0;
            while (index <= num5)
            {
              this.voucherTemp.Add(RuntimeHelpers.GetObjectValue(this.dgv_voucher[index, this.selectedIndex].Value));
              checked { ++index; }
            }
          }
          else
          {
            this.selectedIndex = 0;
            this.btn_print.Enabled = false;
            this.btn_delete.Enabled = false;
            this.btn_quickdel.Enabled = false;
            this.txtbx_search.Enabled = false;
            this.txtbx_search.Clear();
            this.cb_search.SelectedIndex = -1;
            this.cb_search.Enabled = false;
            this.btn_search.Enabled = false;
          }
          this.labelStatus.Text = "1 voucher deleted";
          int num6 = (int) Interaction.MsgBox((object) "Deleted voucher", MsgBoxStyle.Information, (object) null);
        }
      }
    }

    private void btn_print_Click(object sender, EventArgs e)
    {
      this.ActiveControl = (Control) null;
      if (this.working)
      {
        int num1 = (int) Interaction.MsgBox((object) "Wait for the background operation to complete.", MsgBoxStyle.Critical, (object) null);
      }
      else
      {
        int num2 = (int) Interaction.MsgBox((object) "Function not available", MsgBoxStyle.Critical, (object) null);
      }
    }

    private void chkbx_expiration_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chkbx_expiration.Checked)
        this.dtp_expiration.Enabled = true;
      else
        this.dtp_expiration.Enabled = false;
    }

    private void worker_DoWork(object sender, DoWorkEventArgs e)
    {
      this.working = true;
      OleDbCommand oleDbCommand = new OleDbCommand();
      try
      {
        this.v.open();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        e.Result = (object) exception.Message;
        ProjectData.ClearProjectError();
        return;
      }
      if (this.v.isOpen)
      {
        oleDbCommand.Connection = this.v.conn;
        int int32_1 = Convert.ToInt32(this.nud_piece.Value);
        int num = 1;
label_17:
        if (num <= int32_1)
        {
          while (!this.worker.CancellationPending)
          {
            string id = this.v.generateId(this.voucherDigit);
            string number = this.v.generateNumber(5);
            this.voucherTemp = new ArrayList();
            oleDbCommand.CommandText = "SELECT * FROM coupons WHERE ([#] = '" + number + "' or [ID] = '" + id + "')";
            try
            {
              oleDbCommand.ExecuteNonQuery();
              OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
              while (oleDbDataReader.Read())
              {
                this.voucherTemp.Add((object) oleDbDataReader["#"].ToString());
                this.voucherTemp.Add((object) oleDbDataReader["ID"].ToString());
              }
              oleDbDataReader.Close();
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              Exception exception = ex;
              e.Result = (object) exception.Message;
              ProjectData.ClearProjectError();
              return;
            }
            if (this.voucherTemp.Count == 0)
            {
              this.voucherTemp = (ArrayList) null;
              string str1 = Strings.Format((object) DateAndTime.Now, "yyyy/MM/dd @ hh:mm:ss tt");
              int int32_2 = Convert.ToInt32(Decimal.Add(Decimal.Add(this.nud_second.Value, Decimal.Multiply(this.nud_minute.Value, new Decimal(60L))), Decimal.Multiply(new Decimal(60L), Decimal.Multiply(this.nud_hour.Value, new Decimal(60L)))));
              string str2 = this.chkbx_expiration.Checked ? Strings.Format((object) this.dtp_expiration.Value, "yyyy/MM/dd") : "No expiration";
              oleDbCommand.CommandText = "INSERT INTO coupons ([#], [ID], [Credits], [Status], [Expiration], [Created]) VALUES ('" + number + "', '" + id + "', '" + Conversions.ToString(int32_2) + "','Unused', '" + str2 + "', ' " + str1 + "')";
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
              checked { ++this.voucherCreated; }
              this.worker.ReportProgress(checked ((int) Math.Round(unchecked ((double) num / (double) Convert.ToInt32(this.nud_piece.Value) * 100.0))));
              checked { ++num; }
              goto label_17;
            }
          }
        }
        e.Result = (object) "success";
      }
      else
        e.Result = (object) "closed";
    }

    private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      this.labelStatus.Text = "Creating vouchers please wait... " + Conversions.ToString(e.ProgressPercentage) + "%     ( Click 'X' button to stop operation )";
    }

    private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.nud_hour.Value = Decimal.Zero;
      this.nud_minute.Value = Decimal.Zero;
      this.nud_second.Value = Decimal.Zero;
      this.nud_piece.Value = Decimal.Zero;
      this.nud_piece.Minimum = Decimal.Zero;
      this.nud_piece.Enabled = false;
      this.chkbx_expiration.Checked = false;
      this.dtp_expiration.Enabled = false;
      this.gb_details.Enabled = true;
      this.btn_print.Enabled = false;
      this.btn_delete.Enabled = false;
      this.btn_quickdel.Enabled = false;
      this.dgv_voucher.DataSource = (object) this.v.dataTable("coupons");
      if (this.dgv_voucher.Rows.Count >= 1)
      {
        this.txtbx_search.Enabled = true;
        this.dgv_voucher.CurrentCell = this.dgv_voucher[0, checked (this.dgv_voucher.Rows.Count - 1)];
        this.dgv_voucher.Sort(this.dgv_voucher.Columns[5], ListSortDirection.Ascending);
        this.dgv_voucher.ClearSelection();
      }
      if (!this.quick)
      {
        this.btn_create.Text = "Create New Voucher";
        this.labelStatus.Text = "Vouchers creation done!";
        string Left = Conversions.ToString(e.Result);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "closed", false) == 0)
        {
          int num;
          this.Invoke((Delegate) (() => num = (int) Interaction.MsgBox((object) "Creating voucher failed.", MsgBoxStyle.Critical, (object) null)));
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "success", false) == 0)
        {
          int num;
          this.Invoke((Delegate) (() => num = (int) Interaction.MsgBox((object) (Conversions.ToString(this.voucherCreated) + " voucher(s) created successfully."), MsgBoxStyle.Information, (object) null)));
        }
        else
        {
          int num;
          this.Invoke((Delegate) (() => num = (int) Interaction.MsgBox(RuntimeHelpers.GetObjectValue(e.Result), MsgBoxStyle.Critical, (object) null)));
        }
      }
      else
      {
        this.btn_quickcreate.Text = "Quick create";
        this.quick = false;
      }
      this.labelStatus.Text = this.voucherCreated == 0 ? "No voucher has been created." : Conversions.ToString(this.voucherCreated) + (this.voucherCreated == 1 ? " voucher created." : " vouchers created.");
      this.voucherCreated = 0;
      this.worker.Dispose();
      this.worker = (BackgroundWorker) null;
      this.v.close();
      this.working = false;
    }

    private void dgv_voucher_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.working || e.RowIndex == -1)
        return;
      this.voucherTemp = new ArrayList();
      this.selectedIndex = e.RowIndex;
      int num1 = checked (this.dgv_voucher.Columns.Count - 1);
      int index = 0;
      while (index <= num1)
      {
        this.voucherTemp.Add(RuntimeHelpers.GetObjectValue(this.dgv_voucher[index, this.dgv_voucher.CurrentRow.Index].Value));
        checked { ++index; }
      }
      if (this.voucherTemp.Count != 0)
      {
        this.btn_print.Enabled = true;
        this.btn_delete.Enabled = true;
        this.btn_quickdel.Enabled = true;
        int integer = Conversions.ToInteger(this.voucherTemp[2]);
        int num2 = integer % 60;
        int num3 = checked ((int) Math.Round(unchecked ((double) checked (integer - num2) / 60.0 % 60.0)));
        int num4 = checked ((int) Math.Round(unchecked ((double) checked (integer - num2 + num3 * 60) / 3600.0 % 60.0)));
        this.labelStatus.Text = "#: " + this.voucherTemp[0].ToString() + "   |   ID: " + this.voucherTemp[1].ToString() + "   |   Credits: " + (num4 > 0 ? Conversions.ToString(num4) + " " + (num4 == 1 ? "hour " : "hours ") : "") + (num3 > 0 ? Conversions.ToString(num3) + " " + (num3 == 1 ? "minute " : "minutes ") : "") + (num2 > 0 ? Conversions.ToString(num2) + " " + (num2 == 1 ? "second" : "seconds") : "");
      }
      else
      {
        this.btn_print.Enabled = false;
        this.btn_delete.Enabled = false;
        this.btn_quickdel.Enabled = false;
        this.labelStatus.Text = "No records of voucher";
      }
    }

    private void btn_quick_Click(object sender, EventArgs e)
    {
      this.ActiveControl = (Control) null;
      this.btn_quickcreate.Text = "Creating...";
      this.btn_quickcreate.Enabled = false;
      this.btn_create.Enabled = false;
      this.gb_details.Enabled = false;
      this.quick = true;
      this.worker = new BackgroundWorker();
      this.worker.WorkerSupportsCancellation = true;
      this.worker.WorkerReportsProgress = true;
      this.worker.RunWorkerAsync();
    }

    private void btn_clear_Click(object sender, EventArgs e)
    {
      this.ActiveControl = (Control) null;
      this.dgv_voucher.DataSource = (object) this.v.dataTable("coupons");
      if (this.dgv_voucher.Rows.Count >= 1)
      {
        this.dgv_voucher.Sort(this.dgv_voucher.Columns[5], ListSortDirection.Ascending);
        this.txtbx_search.Clear();
        this.labelStatus.Text = "There are " + Conversions.ToString(this.dgv_voucher.Rows.Count) + " total vouchers";
      }
      this.btn_print.Enabled = false;
      this.btn_delete.Enabled = false;
      this.btn_quickdel.Enabled = false;
      this.btn_clear.Enabled = false;
    }

    private void btn_quickdel_Click(object sender, EventArgs e)
    {
      this.ActiveControl = (Control) null;
      if (this.working)
      {
        int num1 = (int) Interaction.MsgBox((object) "Wait for the background operation to complete.", MsgBoxStyle.Critical, (object) null);
      }
      else if (this.voucherTemp != null)
      {
        OleDbCommand oleDbCommand = new OleDbCommand();
        string str = "DELETE * FROM coupons WHERE ([ID] = '" + this.voucherTemp[1].ToString() + "')";
        try
        {
          this.v.open();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          int num2 = (int) Interaction.MsgBox((object) ex.Message, MsgBoxStyle.Critical, (object) "Delete voucher failed!");
          ProjectData.ClearProjectError();
          return;
        }
        if (this.v.isOpen)
        {
          try
          {
            oleDbCommand.Connection = this.v.conn;
            oleDbCommand.CommandText = str;
            oleDbCommand.ExecuteNonQuery();
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            this.labelStatus.Text = "deleting voucher failed!";
            ProjectData.ClearProjectError();
            return;
          }
          this.v.close();
        }
        this.voucherTemp = (ArrayList) null;
        this.dgv_voucher.DataSource = (object) this.v.dataTable("coupons");
        this.dgv_voucher.Sort(this.dgv_voucher.Columns[5], ListSortDirection.Ascending);
        if (this.dgv_voucher.Rows.Count > 0)
        {
          if (this.selectedIndex != checked (this.dgv_voucher.Rows.Count - 1) && this.selectedIndex != 0)
            checked { --this.selectedIndex; }
          this.dgv_voucher.CurrentCell = this.dgv_voucher[0, this.selectedIndex];
          this.voucherTemp = new ArrayList();
          int num2 = checked (this.dgv_voucher.Columns.Count - 1);
          int index = 0;
          while (index <= num2)
          {
            this.voucherTemp.Add(RuntimeHelpers.GetObjectValue(this.dgv_voucher[index, this.selectedIndex].Value));
            checked { ++index; }
          }
        }
        else
        {
          this.selectedIndex = 0;
          this.btn_print.Enabled = false;
          this.btn_delete.Enabled = false;
          this.btn_quickdel.Enabled = false;
          this.txtbx_search.Enabled = false;
          this.txtbx_search.Clear();
          this.cb_search.SelectedIndex = -1;
          this.cb_search.Enabled = false;
          this.btn_search.Enabled = false;
        }
        this.labelStatus.Text = "1 voucher deleted";
      }
    }

    private delegate void MyDelegate();
  }
}
