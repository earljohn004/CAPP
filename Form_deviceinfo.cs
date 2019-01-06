// Decompiled with JetBrains decompiler
// Type: Coinapp.Form_deviceinfo
// Assembly: Coinapp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: ED4B7D1C-BF2E-4AAF-8FCA-FEC188D22124
// Assembly location: C:\Users\EarlJohn\Desktop\Coinapp\Coinapp.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Coinapp
{
  [DesignerGenerated]
  public class Form_deviceinfo : Form
  {
    private IContainer components;
    private string devname;
    private string devport;

    public Form_deviceinfo()
    {
      this.Load += new EventHandler(this.Form_deviceinfo_Load);
      this.Closing += new CancelEventHandler(this.Form_deviceinfo_Closing);
      this.InitializeComponent();
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
      this.Label1 = new Label();
      this.Label2 = new Label();
      this.Label3 = new Label();
      this.Label5 = new Label();
      this.label_name = new Label();
      this.label_port = new Label();
      this.label_version = new Label();
      this.label_id = new Label();
      this.Label4 = new Label();
      this.label_date = new Label();
      this.tablelayoutpanel_main = new TableLayoutPanel();
      this.tablelayoutpanel_main.SuspendLayout();
      this.SuspendLayout();
      this.Label1.AutoSize = true;
      this.Label1.Dock = DockStyle.Fill;
      this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label1.Location = new Point(3, 0);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(82, 25);
      this.Label1.TabIndex = 0;
      this.Label1.Text = "Name:";
      this.Label2.AutoSize = true;
      this.Label2.Dock = DockStyle.Fill;
      this.Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label2.Location = new Point(3, 25);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(82, 25);
      this.Label2.TabIndex = 0;
      this.Label2.Text = "Port:";
      this.Label3.AutoSize = true;
      this.Label3.Dock = DockStyle.Fill;
      this.Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label3.Location = new Point(3, 50);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(82, 28);
      this.Label3.TabIndex = 0;
      this.Label3.Text = "Firmware:";
      this.Label5.AutoSize = true;
      this.Label5.Dock = DockStyle.Fill;
      this.Label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label5.Location = new Point(3, 100);
      this.Label5.Name = "Label5";
      this.Label5.Size = new Size(82, 21);
      this.Label5.TabIndex = 0;
      this.Label5.Text = "Device ID:";
      this.label_name.AutoSize = true;
      this.label_name.Dock = DockStyle.Fill;
      this.label_name.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label_name.Location = new Point(91, 0);
      this.label_name.Name = "label_name";
      this.label_name.Size = new Size(310, 25);
      this.label_name.TabIndex = 41;
      this.label_port.AutoSize = true;
      this.label_port.Dock = DockStyle.Fill;
      this.label_port.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label_port.Location = new Point(91, 25);
      this.label_port.Name = "label_port";
      this.label_port.Size = new Size(310, 25);
      this.label_port.TabIndex = 41;
      this.label_version.AutoSize = true;
      this.label_version.Dock = DockStyle.Fill;
      this.label_version.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label_version.Location = new Point(91, 50);
      this.label_version.Name = "label_version";
      this.label_version.Size = new Size(310, 28);
      this.label_version.TabIndex = 41;
      this.label_id.AutoSize = true;
      this.label_id.Dock = DockStyle.Fill;
      this.label_id.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label_id.Location = new Point(91, 100);
      this.label_id.Name = "label_id";
      this.label_id.Size = new Size(310, 21);
      this.label_id.TabIndex = 41;
      this.Label4.AutoSize = true;
      this.Label4.Dock = DockStyle.Fill;
      this.Label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label4.Location = new Point(3, 78);
      this.Label4.Name = "Label4";
      this.Label4.Size = new Size(82, 22);
      this.Label4.TabIndex = 0;
      this.Label4.Text = "Date:";
      this.label_date.AutoSize = true;
      this.label_date.Dock = DockStyle.Fill;
      this.label_date.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label_date.Location = new Point(91, 78);
      this.label_date.Name = "label_date";
      this.label_date.Size = new Size(310, 22);
      this.label_date.TabIndex = 41;
      this.tablelayoutpanel_main.ColumnCount = 2;
      this.tablelayoutpanel_main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.82741f));
      this.tablelayoutpanel_main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.17259f));
      this.tablelayoutpanel_main.Controls.Add((Control) this.Label1, 0, 0);
      this.tablelayoutpanel_main.Controls.Add((Control) this.label_id, 1, 4);
      this.tablelayoutpanel_main.Controls.Add((Control) this.Label5, 0, 4);
      this.tablelayoutpanel_main.Controls.Add((Control) this.label_date, 1, 3);
      this.tablelayoutpanel_main.Controls.Add((Control) this.Label2, 0, 1);
      this.tablelayoutpanel_main.Controls.Add((Control) this.label_version, 1, 2);
      this.tablelayoutpanel_main.Controls.Add((Control) this.Label4, 0, 3);
      this.tablelayoutpanel_main.Controls.Add((Control) this.label_port, 1, 1);
      this.tablelayoutpanel_main.Controls.Add((Control) this.Label3, 0, 2);
      this.tablelayoutpanel_main.Controls.Add((Control) this.label_name, 1, 0);
      this.tablelayoutpanel_main.Dock = DockStyle.Fill;
      this.tablelayoutpanel_main.Location = new Point(10, 10);
      this.tablelayoutpanel_main.Name = "tablelayoutpanel_main";
      this.tablelayoutpanel_main.RowCount = 5;
      this.tablelayoutpanel_main.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
      this.tablelayoutpanel_main.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
      this.tablelayoutpanel_main.RowStyles.Add(new RowStyle(SizeType.Absolute, 28f));
      this.tablelayoutpanel_main.RowStyles.Add(new RowStyle(SizeType.Absolute, 22f));
      this.tablelayoutpanel_main.RowStyles.Add(new RowStyle(SizeType.Absolute, 21f));
      this.tablelayoutpanel_main.Size = new Size(404, 121);
      this.tablelayoutpanel_main.TabIndex = 42;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(424, 141);
      this.Controls.Add((Control) this.tablelayoutpanel_main);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MaximumSize = new Size(440, 180);
      this.MinimizeBox = false;
      this.MinimumSize = new Size(440, 180);
      this.Name = nameof (Form_deviceinfo);
      this.Padding = new Padding(10);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Device Information";
      this.TopMost = true;
      this.tablelayoutpanel_main.ResumeLayout(false);
      this.tablelayoutpanel_main.PerformLayout();
      this.ResumeLayout(false);
    }

    private virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual Label label_name { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual Label label_port { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual Label label_version { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual Label label_id { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual Label label_date { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TableLayoutPanel tablelayoutpanel_main { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual BackgroundWorker Worker
    {
      get
      {
        return this._Worker;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.Worker_DoWork);
        RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.Worker_RunWorkerCompleted);
        BackgroundWorker worker1 = this._Worker;
        if (worker1 != null)
        {
          worker1.DoWork -= workEventHandler;
          worker1.RunWorkerCompleted -= completedEventHandler;
        }
        this._Worker = value;
        BackgroundWorker worker2 = this._Worker;
        if (worker2 == null)
          return;
        worker2.DoWork += workEventHandler;
        worker2.RunWorkerCompleted += completedEventHandler;
      }
    }

    private void Form_deviceinfo_Load(object sender, EventArgs e)
    {
      _Module.devicefirmware = "";
      _Module.devicefirmwaredate = "";
      _Module.deviceid = "";
      this.Worker = new BackgroundWorker();
      this.Worker.RunWorkerAsync();
    }

    private void Worker_DoWork(object sender, DoWorkEventArgs e)
    {
      if (_Module.MainSerialPort.IsOpen)
      {
        _Module.MainSerialPort.Write("DEVID?");
        _Module.MainSerialPort.Write("FIRMVER?");
        _Module.MainSerialPort.Write("FIRMDATE?");
        try
        {
          this.devname = _Module.Device.Description();
          this.devport = _Module.Device.Port();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          int num = (int) Interaction.MsgBox((object) ex.Message, MsgBoxStyle.Critical, (object) null);
          ProjectData.ClearProjectError();
          return;
        }
        e.Result = (object) "complete";
      }
    }

    private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      if (this.InvokeRequired)
        this.Invoke((Delegate) new Form_deviceinfo.WorkerDelegate(this.Worker_RunWorkerCompleted), sender, (object) e);
      else if (Operators.ConditionalCompareObjectEqual(e.Result, (object) "complete", false))
      {
        this.label_name.Text = this.devname;
        this.label_port.Text = this.devport;
        if (Operators.CompareString(_Module.devicefirmware, "", false) == 0 || Operators.CompareString(_Module.devicefirmware, (string) null, false) == 0)
        {
          this.label_version.Text = "Retrieved error. Please try again";
          this.label_version.ForeColor = Color.Red;
        }
        else
          this.label_version.Text = _Module.devicefirmware;
        if (Operators.CompareString(_Module.deviceid, "", false) == 0 || Operators.CompareString(_Module.deviceid, (string) null, false) == 0)
        {
          this.label_id.Text = "Retrieved error. Please try again";
          this.label_id.ForeColor = Color.Red;
        }
        else
          this.label_id.Text = _Module.deviceid;
        if (Operators.CompareString(_Module.devicefirmwaredate, "", false) == 0 || Operators.CompareString(_Module.devicefirmwaredate, (string) null, false) == 0)
        {
          this.label_date.Text = "Retrieved error. Please try again";
          this.label_date.ForeColor = Color.Red;
        }
        else
          this.label_date.Text = _Module.devicefirmwaredate;
      }
    }

    private void Form_deviceinfo_Closing(object sender, CancelEventArgs e)
    {
      _Module.devicefirmware = "";
      _Module.devicefirmwaredate = "";
      _Module.deviceid = "";
      this.Dispose();
    }

    private void picturebox_close_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private delegate void WorkerDelegate(object sender, RunWorkerCompletedEventArgs e);
  }
}
