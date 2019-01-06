// Decompiled with JetBrains decompiler
// Type: coinapp.form_lock
// Assembly: coinapp, Version=1.4.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6DB842CC-5810-43FB-8044-475700CA1E42
// Assembly location: C:\Users\EarlJohn\Desktop\Coinapp\coinapp_1.4.0.0\coinapp.exe

using coinapp.My;
using coinapplib;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Timers;
using System.Windows.Forms;

namespace coinapp
{
  [DesignerGenerated]
  public class form_lock : Form
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private IContainer components;
    [AccessedThroughProperty("TableLayoutPanel1")]
    private TableLayoutPanel _TableLayoutPanel1;
    [AccessedThroughProperty("pb_coin3")]
    private PictureBox _pb_coin3;
    [AccessedThroughProperty("pb_coin2")]
    private PictureBox _pb_coin2;
    [AccessedThroughProperty("pb_coin1")]
    private PictureBox _pb_coin1;
    [AccessedThroughProperty("lbl_shutdown")]
    private Label _lbl_shutdown;
    [AccessedThroughProperty("lbl_status")]
    private Label _lbl_status;
    [AccessedThroughProperty("TableLayoutPanel2")]
    private TableLayoutPanel _TableLayoutPanel2;
    [AccessedThroughProperty("pb_shutdown")]
    private PictureBox _pb_shutdown;
    [AccessedThroughProperty("pb_plugin")]
    private PictureBox _pb_plugin;
    [AccessedThroughProperty("TableLayoutPanel3")]
    private TableLayoutPanel _TableLayoutPanel3;
    [AccessedThroughProperty("TableLayoutPanel4")]
    private TableLayoutPanel _TableLayoutPanel4;
    private Point p;
    private int sTime;
    [AccessedThroughProperty("sTimer")]
    private System.Timers.Timer _sTimer;
    [AccessedThroughProperty("worker")]
    private BackgroundWorker _worker;
    [AccessedThroughProperty("cLockContextMenuStrip")]
    private ContextMenuStrip _cLockContextMenuStrip;
    [AccessedThroughProperty("cResumeToolStrip")]
    private ToolStripMenuItem _cResumeToolStrip;
    [AccessedThroughProperty("cVoucherToolStrip")]
    private ToolStripMenuItem _cVoucherToolStrip;
    [AccessedThroughProperty("cLoginToolStrip")]
    private ToolStripMenuItem _cLoginToolStrip;
    [AccessedThroughProperty("cChargeToolStrip")]
    private ToolStripMenuItem _cChargeToolStrip;
    [AccessedThroughProperty("cCreateToolStrip")]
    private ToolStripMenuItem _cCreateToolStrip;
    private ToolStripMenuItem cAccountToolStrip;
    private Bitmap bgImageReady;
    private Bitmap bgImageError;
    private bool passExists;
    private bool emailExists;

    [DebuggerNonUserCode]
    static form_lock()
    {
    }

    public form_lock()
    {
      this.FormClosing += new FormClosingEventHandler(this.form_lock_FormClosing);
      this.Load += new EventHandler(this.form_lock_Load);
      form_lock.__ENCAddToList((object) this);
      this.sTime = 0;
      this.sTimer = new System.Timers.Timer(1000.0);
      this.passExists = coinappMods.settings.XconfigExist(coinappMods.enc.GetMd5Hash("password"));
      this.emailExists = coinappMods.settings.XconfigExist(coinappMods.enc.GetMd5Hash("email"));
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (form_lock.__ENCList)
      {
        if (form_lock.__ENCList.Count == form_lock.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (form_lock.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (form_lock.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                form_lock.__ENCList[index1] = form_lock.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          form_lock.__ENCList.RemoveRange(index1, checked (form_lock.__ENCList.Count - index1));
          form_lock.__ENCList.Capacity = form_lock.__ENCList.Count;
        }
        form_lock.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (form_lock));
      this.TableLayoutPanel1 = new TableLayoutPanel();
      this.pb_coin3 = new PictureBox();
      this.pb_coin2 = new PictureBox();
      this.pb_coin1 = new PictureBox();
      this.TableLayoutPanel2 = new TableLayoutPanel();
      this.lbl_status = new Label();
      this.pb_shutdown = new PictureBox();
      this.pb_plugin = new PictureBox();
      this.lbl_shutdown = new Label();
      this.TableLayoutPanel3 = new TableLayoutPanel();
      this.TableLayoutPanel4 = new TableLayoutPanel();
      this.TableLayoutPanel1.SuspendLayout();
      ((ISupportInitialize) this.pb_coin3).BeginInit();
      ((ISupportInitialize) this.pb_coin2).BeginInit();
      ((ISupportInitialize) this.pb_coin1).BeginInit();
      this.TableLayoutPanel2.SuspendLayout();
      ((ISupportInitialize) this.pb_shutdown).BeginInit();
      ((ISupportInitialize) this.pb_plugin).BeginInit();
      this.TableLayoutPanel3.SuspendLayout();
      this.TableLayoutPanel4.SuspendLayout();
      this.SuspendLayout();
      this.TableLayoutPanel1.BackColor = Color.Transparent;
      this.TableLayoutPanel1.ColumnCount = 1;
      this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
      this.TableLayoutPanel1.Controls.Add((Control) this.TableLayoutPanel3, 0, 1);
      this.TableLayoutPanel1.Controls.Add((Control) this.TableLayoutPanel2, 0, 3);
      this.TableLayoutPanel1.Controls.Add((Control) this.TableLayoutPanel4, 0, 2);
      this.TableLayoutPanel1.Dock = DockStyle.Fill;
      TableLayoutPanel tableLayoutPanel1_1 = this.TableLayoutPanel1;
      Point point1 = new Point(0, 0);
      Point point2 = point1;
      tableLayoutPanel1_1.Location = point2;
      this.TableLayoutPanel1.Name = "TableLayoutPanel1";
      this.TableLayoutPanel1.RowCount = 4;
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 91f));
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 89f));
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50f));
      TableLayoutPanel tableLayoutPanel1_2 = this.TableLayoutPanel1;
      Size size1 = new Size(662, 375);
      Size size2 = size1;
      tableLayoutPanel1_2.Size = size2;
      this.TableLayoutPanel1.TabIndex = 0;
      this.pb_coin3.Dock = DockStyle.Fill;
      this.pb_coin3.Image = (Image) componentResourceManager.GetObject("pb_coin3.Image");
      PictureBox pbCoin3_1 = this.pb_coin3;
      point1 = new Point(419, 4);
      Point point3 = point1;
      pbCoin3_1.Location = point3;
      this.pb_coin3.Name = "pb_coin3";
      PictureBox pbCoin3_2 = this.pb_coin3;
      size1 = new Size(75, 75);
      Size size3 = size1;
      pbCoin3_2.Size = size3;
      this.pb_coin3.SizeMode = PictureBoxSizeMode.Zoom;
      this.pb_coin3.TabIndex = 0;
      this.pb_coin3.TabStop = false;
      this.pb_coin2.Dock = DockStyle.Fill;
      this.pb_coin2.Image = (Image) componentResourceManager.GetObject("pb_coin2.Image");
      PictureBox pbCoin2_1 = this.pb_coin2;
      point1 = new Point(284, 5);
      Point point4 = point1;
      pbCoin2_1.Location = point4;
      this.pb_coin2.Name = "pb_coin2";
      PictureBox pbCoin2_2 = this.pb_coin2;
      size1 = new Size(75, 75);
      Size size4 = size1;
      pbCoin2_2.Size = size4;
      this.pb_coin2.SizeMode = PictureBoxSizeMode.Zoom;
      this.pb_coin2.TabIndex = 0;
      this.pb_coin2.TabStop = false;
      this.pb_coin1.Dock = DockStyle.Fill;
      this.pb_coin1.Image = (Image) componentResourceManager.GetObject("pb_coin1.Image");
      PictureBox pbCoin1_1 = this.pb_coin1;
      point1 = new Point(157, 5);
      Point point5 = point1;
      pbCoin1_1.Location = point5;
      this.pb_coin1.Name = "pb_coin1";
      PictureBox pbCoin1_2 = this.pb_coin1;
      size1 = new Size(75, 75);
      Size size5 = size1;
      pbCoin1_2.Size = size5;
      this.pb_coin1.SizeMode = PictureBoxSizeMode.Zoom;
      this.pb_coin1.TabIndex = 0;
      this.pb_coin1.TabStop = false;
      this.TableLayoutPanel2.ColumnCount = 6;
      this.TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 108f));
      this.TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
      this.TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 44f));
      this.TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10f));
      this.TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 44f));
      this.TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10f));
      this.TableLayoutPanel2.Controls.Add((Control) this.lbl_status, 1, 0);
      this.TableLayoutPanel2.Controls.Add((Control) this.pb_shutdown, 4, 0);
      this.TableLayoutPanel2.Controls.Add((Control) this.pb_plugin, 2, 0);
      this.TableLayoutPanel2.Dock = DockStyle.Fill;
      TableLayoutPanel tableLayoutPanel2_1 = this.TableLayoutPanel2;
      point1 = new Point(3, 328);
      Point point6 = point1;
      tableLayoutPanel2_1.Location = point6;
      this.TableLayoutPanel2.Name = "TableLayoutPanel2";
      this.TableLayoutPanel2.RowCount = 1;
      this.TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
      TableLayoutPanel tableLayoutPanel2_2 = this.TableLayoutPanel2;
      size1 = new Size(656, 44);
      Size size6 = size1;
      tableLayoutPanel2_2.Size = size6;
      this.TableLayoutPanel2.TabIndex = 0;
      this.lbl_status.Dock = DockStyle.Fill;
      this.lbl_status.Font = new Font("Microsoft Sans Serif", 26.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lbl_status.ForeColor = Color.White;
      Label lblStatus1 = this.lbl_status;
      point1 = new Point(111, 0);
      Point point7 = point1;
      lblStatus1.Location = point7;
      this.lbl_status.Name = "lbl_status";
      Label lblStatus2 = this.lbl_status;
      size1 = new Size(434, 44);
      Size size7 = size1;
      lblStatus2.Size = size7;
      this.lbl_status.TabIndex = 0;
      this.lbl_status.Text = "INTIZIALIZING...";
      this.lbl_status.TextAlign = ContentAlignment.MiddleCenter;
      this.lbl_status.UseCompatibleTextRendering = true;
      this.pb_shutdown.BackgroundImage = (Image) componentResourceManager.GetObject("pb_shutdown.BackgroundImage");
      this.pb_shutdown.BackgroundImageLayout = ImageLayout.Zoom;
      this.pb_shutdown.Cursor = Cursors.Hand;
      this.pb_shutdown.Dock = DockStyle.Fill;
      PictureBox pbShutdown1 = this.pb_shutdown;
      point1 = new Point(605, 3);
      Point point8 = point1;
      pbShutdown1.Location = point8;
      this.pb_shutdown.Name = "pb_shutdown";
      PictureBox pbShutdown2 = this.pb_shutdown;
      size1 = new Size(38, 38);
      Size size8 = size1;
      pbShutdown2.Size = size8;
      this.pb_shutdown.TabIndex = 0;
      this.pb_shutdown.TabStop = false;
      this.pb_plugin.BackgroundImage = (Image) componentResourceManager.GetObject("pb_plugin.BackgroundImage");
      this.pb_plugin.BackgroundImageLayout = ImageLayout.Zoom;
      this.pb_plugin.Cursor = Cursors.Hand;
      this.pb_plugin.Dock = DockStyle.Fill;
      PictureBox pbPlugin1 = this.pb_plugin;
      point1 = new Point(551, 3);
      Point point9 = point1;
      pbPlugin1.Location = point9;
      this.pb_plugin.Name = "pb_plugin";
      PictureBox pbPlugin2 = this.pb_plugin;
      size1 = new Size(38, 38);
      Size size9 = size1;
      pbPlugin2.Size = size9;
      this.pb_plugin.TabIndex = 1;
      this.pb_plugin.TabStop = false;
      this.pb_plugin.Visible = false;
      this.lbl_shutdown.AutoSize = true;
      this.lbl_shutdown.BackColor = Color.Transparent;
      this.lbl_shutdown.Cursor = Cursors.Default;
      this.lbl_shutdown.Dock = DockStyle.Fill;
      this.lbl_shutdown.Font = new Font("Century Gothic", 50.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lbl_shutdown.ForeColor = Color.White;
      Label lblShutdown1 = this.lbl_shutdown;
      point1 = new Point(0, 0);
      Point point10 = point1;
      lblShutdown1.Location = point10;
      this.lbl_shutdown.Margin = new Padding(0);
      this.lbl_shutdown.Name = "lbl_shutdown";
      Label lblShutdown2 = this.lbl_shutdown;
      size1 = new Size(656, 85);
      Size size10 = size1;
      lblShutdown2.Size = size10;
      this.lbl_shutdown.TabIndex = 1;
      this.lbl_shutdown.Text = "00:00";
      this.lbl_shutdown.TextAlign = ContentAlignment.MiddleCenter;
      this.lbl_shutdown.UseCompatibleTextRendering = true;
      this.TableLayoutPanel3.ColumnCount = 1;
      this.TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
      this.TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20f));
      this.TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20f));
      this.TableLayoutPanel3.Controls.Add((Control) this.lbl_shutdown, 0, 0);
      this.TableLayoutPanel3.Dock = DockStyle.Fill;
      TableLayoutPanel tableLayoutPanel3_1 = this.TableLayoutPanel3;
      point1 = new Point(3, 148);
      Point point11 = point1;
      tableLayoutPanel3_1.Location = point11;
      this.TableLayoutPanel3.Name = "TableLayoutPanel3";
      this.TableLayoutPanel3.RowCount = 1;
      this.TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
      TableLayoutPanel tableLayoutPanel3_2 = this.TableLayoutPanel3;
      size1 = new Size(656, 85);
      Size size11 = size1;
      tableLayoutPanel3_2.Size = size11;
      this.TableLayoutPanel3.TabIndex = 2;
      this.TableLayoutPanel4.ColumnCount = 7;
      this.TableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
      this.TableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75f));
      this.TableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20f));
      this.TableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75f));
      this.TableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20f));
      this.TableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75f));
      this.TableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
      this.TableLayoutPanel4.Controls.Add((Control) this.pb_coin1, 1, 0);
      this.TableLayoutPanel4.Controls.Add((Control) this.pb_coin2, 3, 0);
      this.TableLayoutPanel4.Controls.Add((Control) this.pb_coin3, 5, 0);
      this.TableLayoutPanel4.Dock = DockStyle.Fill;
      TableLayoutPanel tableLayoutPanel4_1 = this.TableLayoutPanel4;
      point1 = new Point(3, 239);
      Point point12 = point1;
      tableLayoutPanel4_1.Location = point12;
      this.TableLayoutPanel4.Name = "TableLayoutPanel4";
      this.TableLayoutPanel4.RowCount = 1;
      this.TableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
      TableLayoutPanel tableLayoutPanel4_2 = this.TableLayoutPanel4;
      size1 = new Size(656, 83);
      Size size12 = size1;
      tableLayoutPanel4_2.Size = size12;
      this.TableLayoutPanel4.TabIndex = 3;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.Black;
      this.BackgroundImageLayout = ImageLayout.Stretch;
      size1 = new Size(662, 375);
      this.ClientSize = size1;
      this.ControlBox = false;
      this.Controls.Add((Control) this.TableLayoutPanel1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (form_lock);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = nameof (form_lock);
      this.WindowState = FormWindowState.Maximized;
      this.TableLayoutPanel1.ResumeLayout(false);
      ((ISupportInitialize) this.pb_coin3).EndInit();
      ((ISupportInitialize) this.pb_coin2).EndInit();
      ((ISupportInitialize) this.pb_coin1).EndInit();
      this.TableLayoutPanel2.ResumeLayout(false);
      ((ISupportInitialize) this.pb_shutdown).EndInit();
      ((ISupportInitialize) this.pb_plugin).EndInit();
      this.TableLayoutPanel3.ResumeLayout(false);
      this.TableLayoutPanel3.PerformLayout();
      this.TableLayoutPanel4.ResumeLayout(false);
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

    internal virtual PictureBox pb_coin3
    {
      [DebuggerNonUserCode] get
      {
        return this._pb_coin3;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._pb_coin3 = value;
      }
    }

    internal virtual PictureBox pb_coin2
    {
      [DebuggerNonUserCode] get
      {
        return this._pb_coin2;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._pb_coin2 = value;
      }
    }

    internal virtual PictureBox pb_coin1
    {
      [DebuggerNonUserCode] get
      {
        return this._pb_coin1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._pb_coin1 = value;
      }
    }

    internal virtual Label lbl_shutdown
    {
      [DebuggerNonUserCode] get
      {
        return this._lbl_shutdown;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lbl_shutdown = value;
      }
    }

    internal virtual Label lbl_status
    {
      [DebuggerNonUserCode] get
      {
        return this._lbl_status;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lbl_status = value;
      }
    }

    internal virtual TableLayoutPanel TableLayoutPanel2
    {
      [DebuggerNonUserCode] get
      {
        return this._TableLayoutPanel2;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TableLayoutPanel2 = value;
      }
    }

    internal virtual PictureBox pb_shutdown
    {
      [DebuggerNonUserCode] get
      {
        return this._pb_shutdown;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = (EventHandler) ((a0, a1) => this.pb_shutdown_Click(RuntimeHelpers.GetObjectValue(a0), (MouseEventArgs) a1));
        if (this._pb_shutdown != null)
          this._pb_shutdown.Click -= eventHandler;
        this._pb_shutdown = value;
        if (this._pb_shutdown == null)
          return;
        this._pb_shutdown.Click += eventHandler;
      }
    }

    internal virtual PictureBox pb_plugin
    {
      [DebuggerNonUserCode] get
      {
        return this._pb_plugin;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = (EventHandler) ((a0, a1) => this.pb_plugin_MouseDown(RuntimeHelpers.GetObjectValue(a0), (MouseEventArgs) a1));
        if (this._pb_plugin != null)
          this._pb_plugin.Click -= eventHandler;
        this._pb_plugin = value;
        if (this._pb_plugin == null)
          return;
        this._pb_plugin.Click += eventHandler;
      }
    }

    internal virtual TableLayoutPanel TableLayoutPanel3
    {
      [DebuggerNonUserCode] get
      {
        return this._TableLayoutPanel3;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TableLayoutPanel3 = value;
      }
    }

    internal virtual TableLayoutPanel TableLayoutPanel4
    {
      [DebuggerNonUserCode] get
      {
        return this._TableLayoutPanel4;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TableLayoutPanel4 = value;
      }
    }

    private virtual System.Timers.Timer sTimer
    {
      [DebuggerNonUserCode] get
      {
        return this._sTimer;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ElapsedEventHandler elapsedEventHandler = new ElapsedEventHandler(this.sTimer_Tick);
        if (this._sTimer != null)
          this._sTimer.Elapsed -= elapsedEventHandler;
        this._sTimer = value;
        if (this._sTimer == null)
          return;
        this._sTimer.Elapsed += elapsedEventHandler;
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

    private virtual ContextMenuStrip cLockContextMenuStrip
    {
      [DebuggerNonUserCode] get
      {
        return this._cLockContextMenuStrip;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._cLockContextMenuStrip = value;
      }
    }

    private virtual ToolStripMenuItem cResumeToolStrip
    {
      [DebuggerNonUserCode] get
      {
        return this._cResumeToolStrip;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cResumeToolStrip_Click);
        if (this._cResumeToolStrip != null)
          this._cResumeToolStrip.Click -= eventHandler;
        this._cResumeToolStrip = value;
        if (this._cResumeToolStrip == null)
          return;
        this._cResumeToolStrip.Click += eventHandler;
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

    private virtual ToolStripMenuItem cChargeToolStrip
    {
      [DebuggerNonUserCode] get
      {
        return this._cChargeToolStrip;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cChargeToolStrip_Click);
        if (this._cChargeToolStrip != null)
          this._cChargeToolStrip.Click -= eventHandler;
        this._cChargeToolStrip = value;
        if (this._cChargeToolStrip == null)
          return;
        this._cChargeToolStrip.Click += eventHandler;
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
        createParams.ExStyle |= 128;
        return createParams;
      }
    }

    protected override void DefWndProc(ref Message m)
    {
      coinappMods.hotkey.ProcessWinMessageHotkey(m.Msg, m.WParam);
      base.DefWndProc(ref m);
    }

    private void form_lock_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (this.bgImageReady != null)
        this.bgImageReady.Dispose();
      if (this.bgImageError != null)
        this.bgImageError.Dispose();
      if (this.sTimer != null)
        this.sTimer.Dispose();
      if (this.worker != null)
        this.worker.Dispose();
      if (this.cLockContextMenuStrip != null)
        this.cLockContextMenuStrip.Dispose();
      if (this.cResumeToolStrip != null)
        this.cResumeToolStrip.Dispose();
      if (this.cAccountToolStrip != null)
        this.cAccountToolStrip.Dispose();
      this.Dispose();
    }

    private void form_lock_Load(object sender, EventArgs e)
    {
      coinappMods.desktop.lockHandle = this.Handle;
      coinappMods.desktop.lockForm = (Form) this;
      this.Width = Screen.PrimaryScreen.Bounds.Width;
      this.Height = Screen.PrimaryScreen.Bounds.Height;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.WindowState = FormWindowState.Maximized;
      this.cLockContextMenuStrip = new ContextMenuStrip();
      this.cResumeToolStrip = new ToolStripMenuItem("Resume time");
      this.cAccountToolStrip = new ToolStripMenuItem("Use account");
      this.cVoucherToolStrip = new ToolStripMenuItem("Use voucher");
      this.cLoginToolStrip = new ToolStripMenuItem("User login");
      this.cChargeToolStrip = new ToolStripMenuItem("Charge account");
      this.cCreateToolStrip = new ToolStripMenuItem("Create account");
      this.p = new Point(checked (Screen.PrimaryScreen.Bounds.Width - this.cLockContextMenuStrip.Size.Width + 98), checked (Screen.PrimaryScreen.Bounds.Height - 30));
      coinappMods.hotkey.KeyDown += new hotkey.KeyDownEventHandler(coinappMods.hotkey_Keydown);
      this.cLockContextMenuStrip.Closed += new ToolStripDropDownClosedEventHandler(this.cPluginContextMenuStrip_Closed);
      coinappMods.hotkey.Register(this.Handle, coinappMods.conf.keycode);
      if (Operators.CompareString(coinappMods.settings.bgReady(), "", false) != 0)
      {
        if (File.Exists(coinappMods.settings.bgReady()))
        {
          bool flag;
          try
          {
            this.bgImageReady = new Bitmap(coinappMods.settings.bgReady());
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            flag = true;
            ProjectData.ClearProjectError();
          }
          if (!flag)
            this.BackgroundImage = (Image) this.bgImageReady;
        }
      }
      if (Operators.CompareString(coinappMods.settings.bgError(), "", false) != 0)
      {
        if (File.Exists(coinappMods.settings.bgError()))
        {
          try
          {
            this.bgImageError = new Bitmap(coinappMods.settings.bgError());
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
      }
      this.sTime = coinappMods.conf.shutdown;
      this.lbl_shutdown.Text = Strings.Format((object) checked ((int) Math.Round(unchecked ((double) checked (this.sTime - unchecked (this.sTime % 60)) / 60.0 % 60.0))), "00") + ":" + Strings.Format((object) (this.sTime % 60), "00");
      this.sTimer.Start();
      if (!this.passExists && !this.emailExists)
      {
        this.coinSlot(0);
        this.lbl_status.Text = "Coinapp not configured properly";
      }
      else
      {
        switch (coinappMods.LOCKCODE)
        {
          case -1:
            this.lbl_status.Text = "INITIALIZING...";
            this.coinSlot(0);
            break;
          case 0:
            this.lbl_status.Text = "WELCOME USER!";
            this.coinSlot(coinappMods.conf.acceptor);
            this.initializeToolStripMenuItems(true, true);
            break;
          case 1:
            this.coinSlot(0);
            if (this.bgImageError != null)
              this.BackgroundImage = (Image) this.bgImageError;
            switch (coinappMods.ERR_DEVICE)
            {
              case 1:
                this.lbl_status.Text = "Error retrieving device information";
                break;
              case 2:
                this.lbl_status.Text = "No device connected";
                break;
              case 3:
                this.lbl_status.Text = "Cannot open port/Access denied";
                break;
              case 4:
                this.lbl_status.Text = "The port detected not opened";
                break;
              case 5:
                this.lbl_status.Text = "Device is not compatible";
                break;
              case 6:
                this.lbl_status.Text = "Cannot close the opened port";
                break;
              default:
                this.lbl_status.Text = "DEVICE ERROR";
                break;
            }
          case 2:
            this.coinSlot(0);
            if (this.bgImageError != null)
              this.BackgroundImage = (Image) this.bgImageError;
            switch (coinappMods.ERR_APPS)
            {
              case 1:
                this.lbl_status.Text = "Coinapp process terminated";
                break;
              case 2:
                this.lbl_status.Text = "Service process terminated";
                break;
              case 3:
                this.lbl_status.Text = "Service process stopped";
                break;
              case 4:
                this.lbl_status.Text = "Service uninstalled";
                break;
              case 5:
                this.lbl_status.Text = "No additional startup arguments";
                break;
              case 6:
                this.lbl_status.Text = "Invalid startup arguments";
                break;
              case 7:
                this.lbl_status.Text = "Invalid process id";
                break;
              default:
                this.lbl_status.Text = "APPLICATION ERROR";
                break;
            }
          case 3:
            this.lbl_status.Text = "TIME'S UP";
            this.coinSlot(coinappMods.conf.acceptor);
            coinappMods.LOCKCODE = 0;
            this.initializeToolStripMenuItems(false, true);
            break;
          case 4:
            this.lbl_status.Text = "USER LOGGED OUT";
            this.coinSlot(coinappMods.conf.acceptor);
            coinappMods.LOCKCODE = 0;
            this.initializeToolStripMenuItems(false, true);
            break;
          case 5:
            this.lbl_status.Text = "USER TIME PAUSED";
            this.coinSlot(coinappMods.conf.acceptor);
            coinappMods.LOCKCODE = 0;
            this.initializeToolStripMenuItems(false, false);
            break;
          case 6:
            this.lbl_status.Text = "USE TIME SAVED";
            this.coinSlot(coinappMods.conf.acceptor);
            coinappMods.LOCKCODE = 0;
            this.initializeToolStripMenuItems(false, true);
            break;
          default:
            this.lbl_status.Text = "SOMETING WENT WRONG";
            this.coinSlot(0);
            break;
        }
      }
    }

    private void sTimer_Tick(object sender, ElapsedEventArgs e)
    {
      if (!this.IsHandleCreated)
        return;
      form_lock formLock = this;
      int num1 = this.sTime % 60;
      int num2 = checked ((int) Math.Round(unchecked ((double) checked (this.sTime - num1) / 60.0 % 60.0)));
      this.BeginInvoke((Delegate) (() => formLock.lbl_shutdown.Text = Strings.Format((object) num2, "00") + ":" + Strings.Format((object) num1, "00")));
      if (this.sTime <= 0)
      {
        this.sTimer.Stop();
        coinappMods.shutdown.Force();
      }
      checked { --this.sTime; }
    }

    private void coinSlot(int type)
    {
      switch (type)
      {
        case 0:
          this.pb_coin1.Image = (Image) coinappMods.pix.xCoin1();
          this.pb_coin2.Image = (Image) coinappMods.pix.xCoin2();
          this.pb_coin3.Image = (Image) coinappMods.pix.xCoin3();
          break;
        case 1:
          this.pb_coin1.Image = (Image) coinappMods.pix.coin1();
          this.pb_coin2.Image = (Image) coinappMods.pix.xCoin2();
          this.pb_coin3.Image = (Image) coinappMods.pix.xCoin3();
          break;
        case 2:
          this.pb_coin1.Image = (Image) coinappMods.pix.coin1();
          this.pb_coin2.Image = (Image) coinappMods.pix.coin2();
          this.pb_coin3.Image = (Image) coinappMods.pix.xCoin3();
          break;
        case 3:
          this.pb_coin1.Image = (Image) coinappMods.pix.coin1();
          this.pb_coin2.Image = (Image) coinappMods.pix.coin2();
          this.pb_coin3.Image = (Image) coinappMods.pix.coin3();
          break;
      }
    }

    private void worker_DoWork(object sender, DoWorkEventArgs e)
    {
      if (Operators.ConditionalCompareObjectEqual(e.Argument, (object) 1, false))
      {
        this.BeginInvoke((Delegate) (() => this.coinSlot(0)));
        if (this.bgImageError != null)
          this.BeginInvoke((Delegate) (() => this.BackgroundImage = (Image) this.bgImageError));
        switch (coinappMods.ERR_DEVICE - 1)
        {
          case 0:
            this.BeginInvoke((Delegate) (() => this.lbl_status.Text = "Error retrieving device information"));
            break;
          case 1:
            this.BeginInvoke((Delegate) (() => this.lbl_status.Text = "No device connected"));
            break;
          case 2:
            this.BeginInvoke((Delegate) (() => this.lbl_status.Text = "Cannot open port/Access denied"));
            break;
          case 3:
            this.BeginInvoke((Delegate) (() => this.lbl_status.Text = "The port detected not opened"));
            break;
          case 4:
            this.BeginInvoke((Delegate) (() => this.lbl_status.Text = "Device is not compatible"));
            break;
        }
      }
      else if (Operators.ConditionalCompareObjectEqual(e.Argument, (object) 2, false))
      {
        this.BeginInvoke((Delegate) (() => this.coinSlot(0)));
        if (this.bgImageError != null)
          this.BeginInvoke((Delegate) (() => this.BackgroundImage = (Image) this.bgImageError));
        switch (coinappMods.ERR_APPS)
        {
          case 1:
            this.BeginInvoke((Delegate) (() => this.lbl_status.Text = "Coinapp process terminated"));
            break;
          case 2:
            this.BeginInvoke((Delegate) (() => this.lbl_status.Text = "Service process terminated"));
            break;
          case 3:
            this.BeginInvoke((Delegate) (() => this.lbl_status.Text = "Service process stopped"));
            break;
          case 4:
            this.BeginInvoke((Delegate) (() => this.lbl_status.Text = "Service uninstalled"));
            break;
          case 5:
            this.BeginInvoke((Delegate) (() => this.lbl_status.Text = "No additional startup arguments"));
            break;
          case 6:
            this.BeginInvoke((Delegate) (() => this.lbl_status.Text = "Invalid process id"));
            break;
          case 7:
            this.BeginInvoke((Delegate) (() => this.lbl_status.Text = "Invalid process id"));
            break;
        }
      }
      else if (!coinappMods.deviceIsReady)
      {
        coinappMods.LOCKCODE = 1;
        coinappMods.ERR_DEVICE = 5;
        if (this.bgImageError != null)
          this.BeginInvoke((Delegate) (() => this.BackgroundImage = (Image) this.bgImageError));
        this.BeginInvoke((Delegate) (() => this.coinSlot(0)));
        this.BeginInvoke((Delegate) (() => this.lbl_status.Text = "Device is not compatible"));
      }
	  //TODO: this is where the action begins
      else
      {
        coinappMods.LOCKCODE = 0;
        coinappMods.ERR_DEVICE = 0;
        this.BeginInvoke((Delegate) (() => this.coinSlot(coinappMods.conf.acceptor)));
        this.BeginInvoke((Delegate) (() => this.lbl_status.Text = "Welcome user!"));
        this.BeginInvoke((Delegate) (() => this.initializeToolStripMenuItems(true, true)));
      }
      if (coinappMods.ERR_DEVICE != 5)
        return;
      coinappMods.sID = (string) null;
      if (coinappMods.SerialComPort.IsOpen)
      {
        try
        {
          coinappMods.SerialComPort.Close();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Exception exception1 = ex;
          form_lock formLock = this;
          Exception exception = exception1;
          coinappMods.ERR_DEVICE = 6;
          this.BeginInvoke((Delegate) (() => formLock.lbl_status.Text = exception.Message));
          ProjectData.ClearProjectError();
        }
      }
    }

    public void startup(int lcode = -1)
    {
      this.worker = new BackgroundWorker();
      this.worker.RunWorkerAsync((object) lcode);
    }

    private void pb_shutdown_Click(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.pb_shutdown.BackgroundImage = (Image) coinappMods.pix.xShutdown();
      this.pb_shutdown.Cursor = Cursors.Default;
      if (MyProject.Forms.form_dialog.Show("Shutdown the Machine?\r\n\r\nCAUTION: All open applications will not be save. Are you sure?", "Shutdown", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
      {
        this.sTimer.Stop();
        this.lbl_status.Text = "Shutting down please wait...";
        coinappMods.shutdown.Force();
      }
      this.pb_shutdown.BackgroundImage = (Image) coinappMods.pix.shutdown();
      this.pb_shutdown.Cursor = Cursors.Hand;
    }

    private void pb_plugin_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.pb_plugin.BackgroundImage = (Image) coinappMods.pix.xPlugin();
      this.pb_plugin.Cursor = Cursors.Default;
      this.cLockContextMenuStrip.DropShadowEnabled = true;
      this.cLockContextMenuStrip.Show(this.p);
    }

    private void cPluginContextMenuStrip_Closed(object sender, ToolStripDropDownClosedEventArgs e)
    {
      this.pb_plugin.BackgroundImage = (Image) coinappMods.pix.plugin();
      this.pb_plugin.Cursor = Cursors.Hand;
    }

    private void initializeToolStripMenuItems(bool showRemainingTime = false, bool resetPauseToolStrip = false)
    {
      if (resetPauseToolStrip && coinappMods.conf.pause > 0)
        coinappMods.oPause = coinappMods.conf.pause;
      ToolStripItemCollection items = this.cLockContextMenuStrip.Items;
      if (coinappMods.credits > 0 && coinappMods.CREDITSTYPE < 2 && !items.Contains((ToolStripItem) this.cResumeToolStrip))
        items.Add((ToolStripItem) this.cResumeToolStrip);
      if (coinappMods.conf.data > 0)
      {
        if (coinappMods.conf.voucher > 0)
          items.Add((ToolStripItem) this.cVoucherToolStrip);
        if (coinappMods.conf.account > 0)
        {
          if (coinappMods.conf.voucher < 1 && this.cLockContextMenuStrip.Items.Count <= 0)
          {
            items.Add((ToolStripItem) this.cLoginToolStrip);
            items.Add((ToolStripItem) this.cChargeToolStrip);
            items.Add((ToolStripItem) this.cCreateToolStrip);
          }
          else
          {
            items.Add((ToolStripItem) this.cAccountToolStrip);
            ToolStripItemCollection dropDownItems = this.cAccountToolStrip.DropDownItems;
            dropDownItems.Add((ToolStripItem) this.cLoginToolStrip);
            dropDownItems.Add((ToolStripItem) this.cChargeToolStrip);
            dropDownItems.Add((ToolStripItem) this.cCreateToolStrip);
          }
        }
      }
      if (this.cLockContextMenuStrip.Items.Count > 0)
        this.pb_plugin.Visible = true;
      if (!showRemainingTime || coinappMods.credits <= 0)
        return;
      if (MyProject.Forms.form_dialog.Visible)
        MyProject.Forms.form_dialog.Close();
      int num1 = coinappMods.credits % 60;
      int num2 = checked ((int) Math.Round(unchecked ((double) checked (coinappMods.credits - num1) / 60.0 % 60.0)));
      int num3 = checked ((int) Math.Round(unchecked ((double) checked (coinappMods.credits - num1 + num2 * 60) / 3600.0 % 60.0)));
      if (MyProject.Forms.form_dialog.Show("You have " + (num3 > 0 ? Conversions.ToString(num3) + " " + (num3 == 1 ? "hour " : "hours ") : "") + (num2 > 0 ? Conversions.ToString(num2) + " " + (num2 == 1 ? "minute " : "minutes ") : "") + (num1 > 0 ? Conversions.ToString(num1) + " " + (num1 == 1 ? "second " : "seconds ") : "") + "time to be resume. Do you want to use it?", "Time resume", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
      {
        coinappMods.desktop.lockForm.BeginInvoke((Delegate) (() => coinappMods.desktop.Unlock()));
        if (coinappMods.SerialComPort.IsOpen)
        {
          coinappMods.SerialComPort.Write("CREDITS=" + Conversions.ToString(coinappMods.credits));
          coinappMods.SerialComPort.Write("COUNT=1");
        }
      }
    }

    private void cResumeToolStrip_Click(object sender, EventArgs e)
    {
      if (coinappMods.credits <= 0 || coinappMods.CREDITSTYPE >= 2)
        return;
      int num1 = coinappMods.credits % 60;
      int num2 = checked ((int) Math.Round(unchecked ((double) checked (coinappMods.credits - num1) / 60.0 % 60.0)));
      int num3 = checked ((int) Math.Round(unchecked ((double) checked (coinappMods.credits - num1 + num2 * 60) / 3600.0 % 60.0)));
      if (MyProject.Forms.form_dialog.Show("You have " + (num3 > 0 ? Conversions.ToString(num3) + " " + (num3 == 1 ? "hour " : "hours ") : "") + (num2 > 0 ? Conversions.ToString(num2) + " " + (num2 == 1 ? "minute " : "minutes ") : "") + (num1 > 0 ? Conversions.ToString(num1) + " " + (num1 == 1 ? "second" : "seconds") : "") + "time to be resume. Do you want to use it?", "Resume time", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
      {
        coinappMods.desktop.lockForm.BeginInvoke((Delegate) (() => coinappMods.desktop.Unlock()));
        if (coinappMods.SerialComPort.IsOpen)
        {
          coinappMods.SerialComPort.Write("CREDITS=" + Conversions.ToString(coinappMods.credits));
          coinappMods.SerialComPort.Write("COUNT=1");
        }
      }
    }

    private void cLoginToolStrip_Click(object sender, EventArgs e)
    {
      if (coinappMods.credits > 0)
      {
        if (MyProject.Forms.form_dialog.Show("There is a REMAINING TIME that can be resume.\r\nIf you use an account, the REMAINING TIME will be CANCEL. Do you want to continue and CANCEL the REMAINING TIME?", "Cancel remaining time", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) != DialogResult.OK)
          return;
        MyProject.Forms.form_use_account.Show();
      }
      else
        MyProject.Forms.form_use_account.Show();
    }

    private void cVoucherToolStrip_Click(object sender, EventArgs e)
    {
      if (coinappMods.credits > 0)
      {
        if (MyProject.Forms.form_dialog.Show("There is a REMAINING TIME that can be resume.\r\nIf you use a coupon voucher the REMAINING TIME will be CANCEL. Do you want to continue and CANCEL the REMAINING TIME?", "Cancel remaining time", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) != DialogResult.OK)
          return;
        MyProject.Forms.form_use_voucher.Show();
      }
      else
        MyProject.Forms.form_use_voucher.Show();
    }

    private void cCreateToolStrip_Click(object sender, EventArgs e)
    {
      MyProject.Forms.form_account_create.Show();
    }

    private void cChargeToolStrip_Click(object sender, EventArgs e)
    {
      coinappMods.BEGINCHARGE = true;
      MyProject.Forms.form_use_account.Text = "Charge account";
      MyProject.Forms.form_use_account.Show();
    }

    private delegate void MyDelegate();
  }
}
