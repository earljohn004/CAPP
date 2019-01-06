// Decompiled with JetBrains decompiler
// Type: Coinapp.Form_startup
// Assembly: Coinapp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: ED4B7D1C-BF2E-4AAF-8FCA-FEC188D22124
// Assembly location: C:\Users\EarlJohn\Desktop\Coinapp\Coinapp.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace Coinapp
{
  [DesignerGenerated]
  public class Form_startup : Form
  {
    private IContainer components;
    private int keycode;
    private string keycodeString;
    private string devport;
    private string devname;
    private bool working;
    private bool cannotConnect;

    public Form_startup()
    {
      this.Load += new EventHandler(this.Form_startup_Load);
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
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form_startup));
      this.combobox_cointype = new ComboBox();
      this.combobox_device = new ComboBox();
      this.label_cointype = new Label();
      this.Label1 = new Label();
      this.groupbox_coins = new GroupBox();
      this.textbox_coin3 = new TextBox();
      this.textbox_coin2 = new TextBox();
      this.textbox_pulse3 = new TextBox();
      this.textbox_pulse2 = new TextBox();
      this.textbox_pulse1 = new TextBox();
      this.textbox_coin1 = new TextBox();
      this.label_coin2 = new Label();
      this.label_coin3 = new Label();
      this.Label4 = new Label();
      this.Label3 = new Label();
      this.Label2 = new Label();
      this.label_coin1 = new Label();
      this.textbox_turnoff = new TextBox();
      this.textbox_password = new TextBox();
      this.label_turnoff = new Label();
      this.toggle_startup = new CheckBox();
      this.button_save = new Button();
      this.textbox_letterkey = new TextBox();
      this.label_key = new Label();
      this.label_letterkey = new Label();
      this.toggle_taskmanager = new CheckBox();
      this.textbox_email = new TextBox();
      this.Label5 = new Label();
      this.Label6 = new Label();
      this.tooltip_startup = new ToolTip(this.components);
      this.groupbox_coins.SuspendLayout();
      this.SuspendLayout();
      this.combobox_cointype.DropDownStyle = ComboBoxStyle.DropDownList;
      this.combobox_cointype.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.combobox_cointype.FormattingEnabled = true;
      this.combobox_cointype.IntegralHeight = false;
      this.combobox_cointype.ItemHeight = 16;
      this.combobox_cointype.Items.AddRange(new object[3]
      {
        (object) "Single coin acceptor",
        (object) "Multi coin acceptor",
        (object) "Dual coin acceptor"
      });
      this.combobox_cointype.Location = new Point(27, 99);
      this.combobox_cointype.Name = "combobox_cointype";
      this.combobox_cointype.Size = new Size(278, 24);
      this.combobox_cointype.TabIndex = 0;
      this.combobox_cointype.TabStop = false;
      this.combobox_device.DropDownStyle = ComboBoxStyle.DropDownList;
      this.combobox_device.DropDownWidth = 253;
      this.combobox_device.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.combobox_device.FormattingEnabled = true;
      this.combobox_device.IntegralHeight = false;
      this.combobox_device.ItemHeight = 16;
      this.combobox_device.Location = new Point(27, 37);
      this.combobox_device.Name = "combobox_device";
      this.combobox_device.Size = new Size(278, 24);
      this.combobox_device.TabIndex = 0;
      this.combobox_device.TabStop = false;
      this.label_cointype.AutoSize = true;
      this.label_cointype.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label_cointype.Location = new Point(24, 80);
      this.label_cointype.Name = "label_cointype";
      this.label_cointype.Size = new Size(159, 16);
      this.label_cointype.TabIndex = 0;
      this.label_cointype.Text = "Select coin acceptor type";
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label1.Location = new Point(24, 17);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(160, 16);
      this.Label1.TabIndex = 0;
      this.Label1.Text = "Select compatible device";
      this.groupbox_coins.Controls.Add((Control) this.textbox_coin3);
      this.groupbox_coins.Controls.Add((Control) this.textbox_coin2);
      this.groupbox_coins.Controls.Add((Control) this.textbox_pulse3);
      this.groupbox_coins.Controls.Add((Control) this.textbox_pulse2);
      this.groupbox_coins.Controls.Add((Control) this.textbox_pulse1);
      this.groupbox_coins.Controls.Add((Control) this.textbox_coin1);
      this.groupbox_coins.Controls.Add((Control) this.label_coin2);
      this.groupbox_coins.Controls.Add((Control) this.label_coin3);
      this.groupbox_coins.Controls.Add((Control) this.Label4);
      this.groupbox_coins.Controls.Add((Control) this.Label3);
      this.groupbox_coins.Controls.Add((Control) this.Label2);
      this.groupbox_coins.Controls.Add((Control) this.label_coin1);
      this.groupbox_coins.Enabled = false;
      this.groupbox_coins.Font = new Font("Century Gothic", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.groupbox_coins.Location = new Point(15, 129);
      this.groupbox_coins.Name = "groupbox_coins";
      this.groupbox_coins.Size = new Size(303, 116);
      this.groupbox_coins.TabIndex = 0;
      this.groupbox_coins.TabStop = false;
      this.textbox_coin3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_coin3.Location = new Point(58, 78);
      this.textbox_coin3.MaxLength = 4;
      this.textbox_coin3.Name = "textbox_coin3";
      this.textbox_coin3.ShortcutsEnabled = false;
      this.textbox_coin3.Size = new Size(108, 22);
      this.textbox_coin3.TabIndex = 4;
      this.textbox_coin3.TextAlign = HorizontalAlignment.Right;
      this.textbox_coin2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_coin2.Location = new Point(58, 47);
      this.textbox_coin2.MaxLength = 4;
      this.textbox_coin2.Name = "textbox_coin2";
      this.textbox_coin2.ShortcutsEnabled = false;
      this.textbox_coin2.Size = new Size(108, 22);
      this.textbox_coin2.TabIndex = 2;
      this.textbox_coin2.TextAlign = HorizontalAlignment.Right;
      this.textbox_pulse3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_pulse3.Location = new Point(221, 78);
      this.textbox_pulse3.MaxLength = 2;
      this.textbox_pulse3.Name = "textbox_pulse3";
      this.textbox_pulse3.ShortcutsEnabled = false;
      this.textbox_pulse3.Size = new Size(69, 22);
      this.textbox_pulse3.TabIndex = 5;
      this.textbox_pulse3.TextAlign = HorizontalAlignment.Right;
      this.textbox_pulse2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_pulse2.Location = new Point(221, 47);
      this.textbox_pulse2.MaxLength = 2;
      this.textbox_pulse2.Name = "textbox_pulse2";
      this.textbox_pulse2.ShortcutsEnabled = false;
      this.textbox_pulse2.Size = new Size(69, 22);
      this.textbox_pulse2.TabIndex = 3;
      this.textbox_pulse2.TextAlign = HorizontalAlignment.Right;
      this.textbox_pulse1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_pulse1.Location = new Point(221, 16);
      this.textbox_pulse1.MaxLength = 2;
      this.textbox_pulse1.Name = "textbox_pulse1";
      this.textbox_pulse1.ShortcutsEnabled = false;
      this.textbox_pulse1.Size = new Size(69, 22);
      this.textbox_pulse1.TabIndex = 1;
      this.textbox_pulse1.TextAlign = HorizontalAlignment.Right;
      this.textbox_coin1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_coin1.Location = new Point(58, 16);
      this.textbox_coin1.MaxLength = 4;
      this.textbox_coin1.Name = "textbox_coin1";
      this.textbox_coin1.ShortcutsEnabled = false;
      this.textbox_coin1.Size = new Size(108, 22);
      this.textbox_coin1.TabIndex = 0;
      this.textbox_coin1.TextAlign = HorizontalAlignment.Right;
      this.label_coin2.AutoSize = true;
      this.label_coin2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label_coin2.ForeColor = SystemColors.ControlText;
      this.label_coin2.Location = new Point(10, 49);
      this.label_coin2.Name = "label_coin2";
      this.label_coin2.Size = new Size(51, 16);
      this.label_coin2.TabIndex = 0;
      this.label_coin2.Text = "Coin 2 :";
      this.label_coin3.AutoSize = true;
      this.label_coin3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label_coin3.ForeColor = SystemColors.ControlText;
      this.label_coin3.Location = new Point(10, 81);
      this.label_coin3.Name = "label_coin3";
      this.label_coin3.Size = new Size(51, 16);
      this.label_coin3.TabIndex = 0;
      this.label_coin3.Text = "Coin 3 :";
      this.Label4.AutoSize = true;
      this.Label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label4.Location = new Point(170, 81);
      this.Label4.Name = "Label4";
      this.Label4.Size = new Size(52, 16);
      this.Label4.TabIndex = 0;
      this.Label4.Text = "Pulse3:";
      this.Label3.AutoSize = true;
      this.Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label3.Location = new Point(170, 49);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(52, 16);
      this.Label3.TabIndex = 0;
      this.Label3.Text = "Pulse2:";
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label2.Location = new Point(170, 18);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(52, 16);
      this.Label2.TabIndex = 0;
      this.Label2.Text = "Pulse1:";
      this.label_coin1.AutoSize = true;
      this.label_coin1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label_coin1.Location = new Point(10, 18);
      this.label_coin1.Name = "label_coin1";
      this.label_coin1.Size = new Size(51, 16);
      this.label_coin1.TabIndex = 0;
      this.label_coin1.Text = "Coin 1 :";
      this.textbox_turnoff.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_turnoff.Location = new Point(202, 302);
      this.textbox_turnoff.MaxLength = 4;
      this.textbox_turnoff.Name = "textbox_turnoff";
      this.textbox_turnoff.ShortcutsEnabled = false;
      this.textbox_turnoff.Size = new Size(88, 22);
      this.textbox_turnoff.TabIndex = 8;
      this.textbox_turnoff.TextAlign = HorizontalAlignment.Right;
      this.textbox_password.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_password.Location = new Point(123, 363);
      this.textbox_password.MaxLength = 50;
      this.textbox_password.Name = "textbox_password";
      this.textbox_password.ShortcutsEnabled = false;
      this.textbox_password.Size = new Size(167, 22);
      this.textbox_password.TabIndex = 10;
      this.textbox_password.TextAlign = HorizontalAlignment.Right;
      this.label_turnoff.AutoSize = true;
      this.label_turnoff.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label_turnoff.Location = new Point(26, 307);
      this.label_turnoff.Name = "label_turnoff";
      this.label_turnoff.Size = new Size(103, 16);
      this.label_turnoff.TabIndex = 0;
      this.label_turnoff.Text = "Shutdown Time:";
      this.toggle_startup.AutoSize = true;
      this.toggle_startup.Location = new Point(28, (int) byte.MaxValue);
      this.toggle_startup.Name = "toggle_startup";
      this.toggle_startup.Size = new Size(140, 17);
      this.toggle_startup.TabIndex = 6;
      this.toggle_startup.Text = "Run on windows startup";
      this.button_save.Cursor = Cursors.Default;
      this.button_save.Enabled = false;
      this.button_save.FlatStyle = FlatStyle.System;
      this.button_save.Location = new Point(21, 427);
      this.button_save.Name = "button_save";
      this.button_save.Size = new Size(284, 42);
      this.button_save.TabIndex = 0;
      this.button_save.TabStop = false;
      this.button_save.Text = "Save and start Coinapp";
      this.button_save.UseVisualStyleBackColor = false;
      this.textbox_letterkey.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_letterkey.Location = new Point(202, 333);
      this.textbox_letterkey.MaxLength = 1;
      this.textbox_letterkey.Name = "textbox_letterkey";
      this.textbox_letterkey.ReadOnly = true;
      this.textbox_letterkey.ShortcutsEnabled = false;
      this.textbox_letterkey.Size = new Size(88, 22);
      this.textbox_letterkey.TabIndex = 9;
      this.label_key.AutoSize = true;
      this.label_key.Font = new Font("Century Gothic", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label_key.Location = new Point(96, 334);
      this.label_key.Name = "label_key";
      this.label_key.Size = new Size(100, 16);
      this.label_key.TabIndex = 0;
      this.label_key.Text = "Ctrl+Alt+Shift+";
      this.label_letterkey.AutoSize = true;
      this.label_letterkey.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label_letterkey.Location = new Point(26, 333);
      this.label_letterkey.Name = "label_letterkey";
      this.label_letterkey.Size = new Size(54, 16);
      this.label_letterkey.TabIndex = 0;
      this.label_letterkey.Text = "Hotkey:";
      this.toggle_taskmanager.AutoSize = true;
      this.toggle_taskmanager.Location = new Point(29, 280);
      this.toggle_taskmanager.Name = "toggle_taskmanager";
      this.toggle_taskmanager.Size = new Size(125, 17);
      this.toggle_taskmanager.TabIndex = 7;
      this.toggle_taskmanager.Text = "Disable taskmanager";
      this.textbox_email.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textbox_email.Location = new Point(123, 392);
      this.textbox_email.MaxLength = 50;
      this.textbox_email.Name = "textbox_email";
      this.textbox_email.ShortcutsEnabled = false;
      this.textbox_email.Size = new Size(167, 22);
      this.textbox_email.TabIndex = 11;
      this.textbox_email.TextAlign = HorizontalAlignment.Right;
      this.Label5.AutoSize = true;
      this.Label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label5.Location = new Point(25, 364);
      this.Label5.Name = "Label5";
      this.Label5.Size = new Size(68, 16);
      this.Label5.TabIndex = 0;
      this.Label5.Text = "Password";
      this.Label6.AutoSize = true;
      this.Label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label6.Location = new Point(25, 393);
      this.Label6.Name = "Label6";
      this.Label6.Size = new Size(42, 16);
      this.Label6.TabIndex = 0;
      this.Label6.Text = "Email";
      this.tooltip_startup.AutoPopDelay = 10000;
      this.tooltip_startup.InitialDelay = 500;
      this.tooltip_startup.ReshowDelay = 100;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(333, 481);
      this.Controls.Add((Control) this.textbox_letterkey);
      this.Controls.Add((Control) this.label_key);
      this.Controls.Add((Control) this.Label6);
      this.Controls.Add((Control) this.Label5);
      this.Controls.Add((Control) this.label_letterkey);
      this.Controls.Add((Control) this.button_save);
      this.Controls.Add((Control) this.toggle_taskmanager);
      this.Controls.Add((Control) this.toggle_startup);
      this.Controls.Add((Control) this.textbox_email);
      this.Controls.Add((Control) this.textbox_password);
      this.Controls.Add((Control) this.textbox_turnoff);
      this.Controls.Add((Control) this.groupbox_coins);
      this.Controls.Add((Control) this.combobox_cointype);
      this.Controls.Add((Control) this.combobox_device);
      this.Controls.Add((Control) this.label_turnoff);
      this.Controls.Add((Control) this.label_cointype);
      this.Controls.Add((Control) this.Label1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.Name = nameof (Form_startup);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "First time use";
      this.groupbox_coins.ResumeLayout(false);
      this.groupbox_coins.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual ComboBox combobox_cointype
    {
      get
      {
        return this._combobox_cointype;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.combobox_cointype_SelectedIndexChanged);
        ComboBox comboboxCointype1 = this._combobox_cointype;
        if (comboboxCointype1 != null)
          comboboxCointype1.SelectedIndexChanged -= eventHandler;
        this._combobox_cointype = value;
        ComboBox comboboxCointype2 = this._combobox_cointype;
        if (comboboxCointype2 == null)
          return;
        comboboxCointype2.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual ComboBox combobox_device { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label label_cointype { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual GroupBox groupbox_coins { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual TextBox textbox_coin3
    {
      get
      {
        return this._textbox_coin3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.textBox_KeyPress);
        EventHandler eventHandler = new EventHandler(this.textbox_TextChanged);
        TextBox textboxCoin3_1 = this._textbox_coin3;
        if (textboxCoin3_1 != null)
        {
          textboxCoin3_1.KeyPress -= pressEventHandler;
          textboxCoin3_1.TextChanged -= eventHandler;
        }
        this._textbox_coin3 = value;
        TextBox textboxCoin3_2 = this._textbox_coin3;
        if (textboxCoin3_2 == null)
          return;
        textboxCoin3_2.KeyPress += pressEventHandler;
        textboxCoin3_2.TextChanged += eventHandler;
      }
    }

    private virtual TextBox textbox_coin2
    {
      get
      {
        return this._textbox_coin2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.textBox_KeyPress);
        EventHandler eventHandler = new EventHandler(this.textbox_TextChanged);
        TextBox textboxCoin2_1 = this._textbox_coin2;
        if (textboxCoin2_1 != null)
        {
          textboxCoin2_1.KeyPress -= pressEventHandler;
          textboxCoin2_1.TextChanged -= eventHandler;
        }
        this._textbox_coin2 = value;
        TextBox textboxCoin2_2 = this._textbox_coin2;
        if (textboxCoin2_2 == null)
          return;
        textboxCoin2_2.KeyPress += pressEventHandler;
        textboxCoin2_2.TextChanged += eventHandler;
      }
    }

    private virtual TextBox textbox_pulse3
    {
      get
      {
        return this._textbox_pulse3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.textBox_KeyPress);
        EventHandler eventHandler = new EventHandler(this.textbox_TextChanged);
        TextBox textboxPulse3_1 = this._textbox_pulse3;
        if (textboxPulse3_1 != null)
        {
          textboxPulse3_1.KeyPress -= pressEventHandler;
          textboxPulse3_1.TextChanged -= eventHandler;
        }
        this._textbox_pulse3 = value;
        TextBox textboxPulse3_2 = this._textbox_pulse3;
        if (textboxPulse3_2 == null)
          return;
        textboxPulse3_2.KeyPress += pressEventHandler;
        textboxPulse3_2.TextChanged += eventHandler;
      }
    }

    private virtual TextBox textbox_pulse2
    {
      get
      {
        return this._textbox_pulse2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.textBox_KeyPress);
        EventHandler eventHandler = new EventHandler(this.textbox_TextChanged);
        TextBox textboxPulse2_1 = this._textbox_pulse2;
        if (textboxPulse2_1 != null)
        {
          textboxPulse2_1.KeyPress -= pressEventHandler;
          textboxPulse2_1.TextChanged -= eventHandler;
        }
        this._textbox_pulse2 = value;
        TextBox textboxPulse2_2 = this._textbox_pulse2;
        if (textboxPulse2_2 == null)
          return;
        textboxPulse2_2.KeyPress += pressEventHandler;
        textboxPulse2_2.TextChanged += eventHandler;
      }
    }

    private virtual TextBox textbox_pulse1
    {
      get
      {
        return this._textbox_pulse1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.textBox_KeyPress);
        EventHandler eventHandler = new EventHandler(this.textbox_TextChanged);
        TextBox textboxPulse1_1 = this._textbox_pulse1;
        if (textboxPulse1_1 != null)
        {
          textboxPulse1_1.KeyPress -= pressEventHandler;
          textboxPulse1_1.TextChanged -= eventHandler;
        }
        this._textbox_pulse1 = value;
        TextBox textboxPulse1_2 = this._textbox_pulse1;
        if (textboxPulse1_2 == null)
          return;
        textboxPulse1_2.KeyPress += pressEventHandler;
        textboxPulse1_2.TextChanged += eventHandler;
      }
    }

    private virtual TextBox textbox_coin1
    {
      get
      {
        return this._textbox_coin1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.textBox_KeyPress);
        EventHandler eventHandler = new EventHandler(this.textbox_TextChanged);
        TextBox textboxCoin1_1 = this._textbox_coin1;
        if (textboxCoin1_1 != null)
        {
          textboxCoin1_1.KeyPress -= pressEventHandler;
          textboxCoin1_1.TextChanged -= eventHandler;
        }
        this._textbox_coin1 = value;
        TextBox textboxCoin1_2 = this._textbox_coin1;
        if (textboxCoin1_2 == null)
          return;
        textboxCoin1_2.KeyPress += pressEventHandler;
        textboxCoin1_2.TextChanged += eventHandler;
      }
    }

    internal virtual Label label_coin2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label label_coin3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label label_coin1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual TextBox textbox_turnoff
    {
      get
      {
        return this._textbox_turnoff;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.textBox_KeyPress);
        EventHandler eventHandler1 = new EventHandler(this.textbox_TextChanged);
        EventHandler eventHandler2 = new EventHandler(this.textbox_startup_MouseHover);
        TextBox textboxTurnoff1 = this._textbox_turnoff;
        if (textboxTurnoff1 != null)
        {
          textboxTurnoff1.KeyPress -= pressEventHandler;
          textboxTurnoff1.TextChanged -= eventHandler1;
          textboxTurnoff1.MouseHover -= eventHandler2;
        }
        this._textbox_turnoff = value;
        TextBox textboxTurnoff2 = this._textbox_turnoff;
        if (textboxTurnoff2 == null)
          return;
        textboxTurnoff2.KeyPress += pressEventHandler;
        textboxTurnoff2.TextChanged += eventHandler1;
        textboxTurnoff2.MouseHover += eventHandler2;
      }
    }

    private virtual TextBox textbox_password
    {
      get
      {
        return this._textbox_password;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.textbox_TextChanged);
        TextBox textboxPassword1 = this._textbox_password;
        if (textboxPassword1 != null)
          textboxPassword1.TextChanged -= eventHandler;
        this._textbox_password = value;
        TextBox textboxPassword2 = this._textbox_password;
        if (textboxPassword2 == null)
          return;
        textboxPassword2.TextChanged += eventHandler;
      }
    }

    internal virtual Label label_turnoff { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox toggle_startup { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button button_save
    {
      get
      {
        return this._button_save;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.button_save_Click);
        Button buttonSave1 = this._button_save;
        if (buttonSave1 != null)
          buttonSave1.Click -= eventHandler;
        this._button_save = value;
        Button buttonSave2 = this._button_save;
        if (buttonSave2 == null)
          return;
        buttonSave2.Click += eventHandler;
      }
    }

    internal virtual TextBox textbox_letterkey
    {
      get
      {
        return this._textbox_letterkey;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.textbox_TextChanged);
        KeyEventHandler keyEventHandler = new KeyEventHandler(this.textbox_letterkey_KeyDown);
        EventHandler eventHandler2 = new EventHandler(this.textbox_letterkey_Click);
        EventHandler eventHandler3 = new EventHandler(this.textbox_letterkey_Click);
        EventHandler eventHandler4 = new EventHandler(this.textbox_letterkey_Leave);
        TextBox textboxLetterkey1 = this._textbox_letterkey;
        if (textboxLetterkey1 != null)
        {
          textboxLetterkey1.TextChanged -= eventHandler1;
          textboxLetterkey1.KeyDown -= keyEventHandler;
          textboxLetterkey1.Click -= eventHandler2;
          textboxLetterkey1.GotFocus -= eventHandler3;
          textboxLetterkey1.Leave -= eventHandler4;
        }
        this._textbox_letterkey = value;
        TextBox textboxLetterkey2 = this._textbox_letterkey;
        if (textboxLetterkey2 == null)
          return;
        textboxLetterkey2.TextChanged += eventHandler1;
        textboxLetterkey2.KeyDown += keyEventHandler;
        textboxLetterkey2.Click += eventHandler2;
        textboxLetterkey2.GotFocus += eventHandler3;
        textboxLetterkey2.Leave += eventHandler4;
      }
    }

    internal virtual Label label_key { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label label_letterkey { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox toggle_taskmanager { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private virtual TextBox textbox_email
    {
      get
      {
        return this._textbox_email;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.textbox_TextChanged);
        EventHandler eventHandler2 = new EventHandler(this.textbox_startup_MouseHover);
        TextBox textboxEmail1 = this._textbox_email;
        if (textboxEmail1 != null)
        {
          textboxEmail1.TextChanged -= eventHandler1;
          textboxEmail1.MouseHover -= eventHandler2;
        }
        this._textbox_email = value;
        TextBox textboxEmail2 = this._textbox_email;
        if (textboxEmail2 == null)
          return;
        textboxEmail2.TextChanged += eventHandler1;
        textboxEmail2.MouseHover += eventHandler2;
      }
    }

    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolTip tooltip_startup { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    protected override void OnMove(EventArgs e)
    {
      if (this.WindowState != FormWindowState.Maximized)
        return;
      this.WindowState = FormWindowState.Normal;
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      if (e.CloseReason == CloseReason.UserClosing && this.working)
        e.Cancel = true;
      base.OnFormClosing(e);
    }

    private void Form_startup_Load(object sender, EventArgs e)
    {
      _Module.MainSerialPort.DataReceived += new SerialDataReceivedEventHandler(_Module.MainSerialPort_DataReceived);
      this.Disable();
      this.Worker = new BackgroundWorker();
      this.Worker.RunWorkerAsync();
    }

    private void combobox_cointype_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.groupbox_coins.Enabled = true;
      this.textbox_coin1.Text = "0";
      this.textbox_pulse1.Text = "0";
      if (this.combobox_cointype.SelectedIndex == 0)
        this.toggleLabelandTextbox(false, string.Empty);
      else if (this.combobox_cointype.SelectedIndex == 1)
      {
        this.toggleLabelandTextbox(true, "0");
      }
      else
      {
        if (this.combobox_cointype.SelectedIndex != 2)
          return;
        this.DualCoinAcceptor();
      }
    }

    private void DualCoinAcceptor()
    {
      this.label_coin2.Enabled = true;
      this.textbox_coin2.Enabled = true;
      this.textbox_pulse2.Enabled = true;
      this.textbox_coin2.Text = "0";
      this.textbox_pulse2.Text = "0";
      this.label_coin3.Enabled = false;
      this.textbox_coin3.Enabled = false;
      this.textbox_pulse3.Enabled = false;
      this.textbox_coin3.Text = string.Empty;
      this.textbox_pulse3.Text = string.Empty;
    }

    private void textBox_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (Microsoft.VisualBasic.Strings.Asc(e.KeyChar) == 8 || !(Microsoft.VisualBasic.Strings.Asc(e.KeyChar) < 48 | Microsoft.VisualBasic.Strings.Asc(e.KeyChar) > 57))
        return;
      e.Handled = true;
      SystemSounds.Beep.Play();
    }

    private void button_save_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Save this setting?", "settings", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
        this.SaveSetting();
      this.ActiveControl = (Control) null;
    }

    private void textbox_TextChanged(object sender, EventArgs e)
    {
      if (NewLateBinding.LateGet(sender, (System.Type) null, "Text", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null) != (object) "0" && NewLateBinding.LateGet(sender, (System.Type) null, "Text", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null) != (object) "")
      {
        if (this.combobox_device.SelectedItem != null && this.combobox_cointype.SelectedItem != null && (Operators.CompareString(this.textbox_turnoff.Text, "0", false) != 0 && Operators.CompareString(this.textbox_turnoff.Text, "", false) != 0) && (Operators.CompareString(Conversions.ToString(this.textbox_turnoff.Text.First<char>()), "0", false) != 0 && this.textbox_turnoff.Text.Count<char>() != 1 && (Operators.CompareString(this.textbox_password.Text, "", false) != 0 && Operators.CompareString(this.textbox_letterkey.Text, "", false) != 0)) && Operators.CompareString(this.textbox_letterkey.Text, "Click to set", false) != 0 && _Module.IsValidEmailFormat(this.textbox_email.Text))
        {
          if (this.combobox_cointype.SelectedIndex == 0)
          {
            if (Operators.CompareString(this.textbox_coin1.Text, "0", false) != 0 && Operators.CompareString(this.textbox_coin1.Text, "", false) != 0 && (Operators.CompareString(Conversions.ToString(this.textbox_coin1.Text.First<char>()), "0", false) != 0 && Operators.CompareString(this.textbox_pulse1.Text, "0", false) != 0) && Operators.CompareString(this.textbox_pulse1.Text, "", false) != 0 && (uint) Operators.CompareString(Conversions.ToString(this.textbox_pulse1.Text.First<char>()), "0", false) > 0U)
            {
              this.button_save.Enabled = true;
              this.button_save.Cursor = Cursors.Hand;
            }
            else
            {
              this.button_save.Enabled = false;
              this.button_save.Cursor = Cursors.Default;
            }
          }
          else if (this.combobox_cointype.SelectedIndex == 1)
          {
            if (Operators.CompareString(this.textbox_coin1.Text, "0", false) != 0 && Operators.CompareString(this.textbox_coin1.Text, "", false) != 0 && (Operators.CompareString(Conversions.ToString(this.textbox_coin1.Text.First<char>()), "0", false) != 0 && Operators.CompareString(this.textbox_pulse1.Text, "0", false) != 0) && (Operators.CompareString(this.textbox_pulse1.Text, "", false) != 0 && Operators.CompareString(Conversions.ToString(this.textbox_pulse1.Text.First<char>()), "0", false) != 0 && (Operators.CompareString(this.textbox_coin2.Text, "0", false) != 0 && Operators.CompareString(this.textbox_coin2.Text, "", false) != 0)) && (Operators.CompareString(Conversions.ToString(this.textbox_coin2.Text.First<char>()), "0", false) != 0 && Operators.CompareString(this.textbox_pulse2.Text, "0", false) != 0 && (Operators.CompareString(this.textbox_pulse2.Text, "", false) != 0 && Operators.CompareString(Conversions.ToString(this.textbox_pulse2.Text.First<char>()), "0", false) != 0) && (Operators.CompareString(this.textbox_coin3.Text, "0", false) != 0 && Operators.CompareString(this.textbox_coin3.Text, "", false) != 0 && (Operators.CompareString(Conversions.ToString(this.textbox_coin3.Text.First<char>()), "0", false) != 0 && Operators.CompareString(this.textbox_pulse3.Text, "0", false) != 0))) && Operators.CompareString(this.textbox_pulse3.Text, "", false) != 0 && (uint) Operators.CompareString(Conversions.ToString(this.textbox_pulse3.Text.First<char>()), "0", false) > 0U)
            {
              this.button_save.Enabled = true;
              this.button_save.Cursor = Cursors.Hand;
            }
            else
            {
              this.button_save.Enabled = false;
              this.button_save.Cursor = Cursors.Default;
            }
          }
          else
          {
            if (this.combobox_cointype.SelectedIndex != 2)
              return;
            if (Operators.CompareString(this.textbox_coin1.Text, "0", false) != 0 && Operators.CompareString(this.textbox_coin1.Text, "", false) != 0 && (Operators.CompareString(Conversions.ToString(this.textbox_coin1.Text.First<char>()), "0", false) != 0 && Operators.CompareString(this.textbox_pulse1.Text, "0", false) != 0) && (Operators.CompareString(this.textbox_pulse1.Text, "", false) != 0 && Operators.CompareString(Conversions.ToString(this.textbox_pulse1.Text.First<char>()), "0", false) != 0 && (Operators.CompareString(this.textbox_coin2.Text, "0", false) != 0 && Operators.CompareString(this.textbox_coin2.Text, "", false) != 0)) && (Operators.CompareString(Conversions.ToString(this.textbox_coin2.Text.First<char>()), "0", false) != 0 && Operators.CompareString(this.textbox_pulse2.Text, "0", false) != 0 && Operators.CompareString(this.textbox_pulse2.Text, "", false) != 0) && (uint) Operators.CompareString(Conversions.ToString(this.textbox_pulse2.Text.First<char>()), "0", false) > 0U)
            {
              this.button_save.Enabled = true;
              this.button_save.Cursor = Cursors.Hand;
            }
            else
            {
              this.button_save.Enabled = false;
              this.button_save.Cursor = Cursors.Default;
            }
          }
        }
        else
        {
          this.button_save.Enabled = false;
          this.button_save.Cursor = Cursors.Default;
        }
      }
      else
      {
        this.button_save.Enabled = false;
        this.button_save.Cursor = Cursors.Default;
      }
    }

    private void toggleLabelandTextbox(bool @bool, string text)
    {
      this.label_coin2.Enabled = @bool;
      this.textbox_coin2.Enabled = @bool;
      this.textbox_coin2.Text = text;
      this.textbox_pulse2.Enabled = @bool;
      this.textbox_pulse2.Text = text;
      this.label_coin3.Enabled = @bool;
      this.textbox_coin3.Enabled = @bool;
      this.textbox_coin3.Text = text;
      this.textbox_pulse3.Enabled = @bool;
      this.textbox_pulse3.Text = text;
    }

    private void SaveSetting()
    {
      if (!_Module.Config.Exists())
        _Module.Config.CreateConfigFile();
      if (this.combobox_cointype.SelectedIndex == 1)
      {
        _Module.Config.SetCoin2(this.textbox_coin2.Text, this.textbox_pulse2.Text);
        _Module.Config.SetCoin3(this.textbox_coin3.Text, this.textbox_pulse3.Text);
        _Module.Config.SetCoinAcceptor("MULTI");
      }
      else if (this.combobox_cointype.SelectedIndex == 2)
      {
        _Module.Config.SetCoin2(this.textbox_coin2.Text, this.textbox_pulse2.Text);
        _Module.Config.SetCoin3("0", "0");
        _Module.Config.SetCoinAcceptor("DUAL");
      }
      else
      {
        _Module.Config.SetCoin2("0", "0");
        _Module.Config.SetCoin3("0", "0");
        _Module.Config.SetCoinAcceptor("SINGLE");
      }
      if (this.toggle_startup.Checked)
      {
        _Module.Config.SetStartupRegValue();
        _Module.Config.SetAtStartup(true);
      }
      else
        _Module.Config.SetAtStartup(false);
      if (this.toggle_taskmanager.Checked)
      {
        _Module.Config.SetTaskmgrRegValue();
        _Module.Config.SetTaskmgr(true);
      }
      else
        _Module.Config.SetTaskmgr(false);
      _Module.Config.SetCoin1(this.textbox_coin1.Text, this.textbox_pulse1.Text);
      _Module.Config.SetTimeToShut(this.textbox_turnoff.Text);
      _Module.Config.SetKeycode(this.keycode);
      _Module.Config.SetPortName(_Module.Device.Port());
      _Module.Config.SetFirstTimeUse(false);
      _Module.Config.WriteFile(_Module._MD5.GetMd5Hash("password"), _Module._MD5.Encrypt(this.textbox_password.Text, "password"));
      _Module.Config.WriteFile(_Module._MD5.GetMd5Hash("email"), _Module._MD5.Encrypt(this.textbox_email.Text, "email"));
      int num = (int) MessageBox.Show("Settings saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      Application.Restart();
    }

    private void textbox_letterkey_KeyDown(object sender, KeyEventArgs e)
    {
      if ((e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9) && (e.KeyCode != Keys.Decimal && e.KeyCode != Keys.Pause) && (e.KeyCode != Keys.Tab && e.KeyCode != Keys.LWin && e.KeyCode != Keys.RWin) && (e.KeyCode < Keys.ShiftKey || e.KeyCode > Keys.Menu))
      {
        this.keycode = (int) e.KeyCode;
        this.keycodeString = _Module.Hotkey.GetKeypressed((int) e.KeyCode);
        this.textbox_letterkey.Text = this.keycodeString;
      }
      else
      {
        e.Handled = true;
        SystemSounds.Beep.Play();
      }
    }

    private void textbox_letterkey_Click(object sender, EventArgs e)
    {
      this.textbox_letterkey.Text = "Press a key";
    }

    private void textbox_letterkey_Leave(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.keycodeString, "", false) == 0)
        this.textbox_letterkey.Text = "Click to set";
      else
        this.textbox_letterkey.Text = this.keycodeString;
    }

    private void Disable()
    {
      this.combobox_device.Enabled = false;
      this.label_cointype.Enabled = false;
      this.combobox_cointype.Enabled = false;
      this.toggle_startup.Enabled = false;
      this.toggle_taskmanager.Enabled = false;
      this.label_turnoff.Enabled = false;
      this.textbox_turnoff.Enabled = false;
      this.label_letterkey.Enabled = false;
      this.label_key.Enabled = false;
      this.textbox_letterkey.Enabled = false;
      this.textbox_password.Enabled = false;
      this.textbox_email.Enabled = false;
    }

    private void Enable()
    {
      this.combobox_device.Enabled = true;
      this.label_cointype.Enabled = true;
      this.combobox_cointype.Enabled = true;
      this.toggle_startup.Enabled = true;
      this.toggle_taskmanager.Enabled = true;
      this.label_turnoff.Enabled = true;
      this.textbox_turnoff.Enabled = true;
      this.label_letterkey.Enabled = true;
      this.label_key.Enabled = true;
      this.textbox_letterkey.Enabled = true;
      this.textbox_password.Enabled = true;
      this.textbox_email.Enabled = true;
    }

    private void Worker_DoWork(object sender, DoWorkEventArgs e)
    {
      this.working = true;
      try
      {
        this.devport = _Module.Device.Port();
        this.devname = _Module.Device.Name();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.working = false;
        int num;
        this.Invoke((Delegate) (() => num = (int) MessageBox.Show(exception.Message, "Startup device error", MessageBoxButtons.OK, MessageBoxIcon.Hand)));
        ProjectData.ClearProjectError();
        return;
      }
      if ((uint) Operators.CompareString(this.devport, "", false) > 0U)
      {
        this.Invoke((Delegate) (() => this.combobox_device.Items.Add((object) "Testing connected device...")));
        this.Invoke((Delegate) (() => this.combobox_device.SelectedIndex = 0));
        try
        {
          _Module.MainSerialPort.BaudRate = _Module.Conf.BaudRate;
          _Module.MainSerialPort.PortName = this.devport;
          _Module.MainSerialPort.DtrEnable = true;
          _Module.MainSerialPort.Open();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Exception exception = ex;
          this.cannotConnect = true;
          if (this.combobox_device.Items.Count > 0)
            this.Invoke((Delegate) (() => this.combobox_device.Items.RemoveAt(0)));
          this.working = false;
          int num;
          this.Invoke((Delegate) (() => num = (int) MessageBox.Show(exception.Message, "Test error", MessageBoxButtons.OK, MessageBoxIcon.Hand)));
          ProjectData.ClearProjectError();
          return;
        }
        Thread.Sleep(3000);
        _Module.MainSerialPort.Write("REQDEVID;");
        Thread.Sleep(_Module.senderIDInterval);
      }
      else
      {
        this.Invoke((Delegate) (() => this.combobox_device.Items.Add((object) "--No device connected--")));
        this.Invoke((Delegate) (() => this.combobox_device.SelectedIndex = 0));
      }
    }

    private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      if (this.InvokeRequired)
        this.Invoke((Delegate) new Form_startup.Worker_RunWorkerCompleted_Delegate(this.Worker_RunWorkerCompleted), sender, (object) e);
      else if (!this.cannotConnect)
      {
        if (_Module.DeviceIsReady)
        {
          if (this.combobox_device.Items.Count > 0)
            this.combobox_device.Items.RemoveAt(0);
          this.combobox_device.Items.Add((object) this.devname);
          this.combobox_device.SelectedIndex = 0;
          this.Enable();
          int num = (int) MessageBox.Show("Device tested successfully.", "Tested", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else
        {
          if (this.combobox_device.Items.Count > 0)
            this.combobox_device.Items.RemoveAt(0);
          this.combobox_device.Items.Add((object) "--No device connected--");
          this.combobox_device.SelectedIndex = 0;
          this.combobox_device.Enabled = true;
          if ((uint) Operators.CompareString(this.devport, "", false) > 0U)
          {
            try
            {
              _Module.MainSerialPort.Close();
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              Exception exception = ex;
              int num;
              this.Invoke((Delegate) (() => num = (int) MessageBox.Show(exception.Message, "Disconnect error", MessageBoxButtons.OK, MessageBoxIcon.Hand)));
              ProjectData.ClearProjectError();
              return;
            }
            int num1;
            this.Invoke((Delegate) (() => num1 = (int) MessageBox.Show((IWin32Window) this, "\r\nCan't continue. Device is not compatible with this application.", "Device not compatible", MessageBoxButtons.OK, MessageBoxIcon.Hand)));
          }
          else
          {
            Form_startup.MyDelegate myDelegate;
            // ISSUE: reference to a compiler-generated field
            if (Form_startup._Closure\u0024__.\u0024I152\u002D2 != null)
            {
              // ISSUE: reference to a compiler-generated field
              myDelegate = Form_startup._Closure\u0024__.\u0024I152\u002D2;
            }
            else
            {
              int num;
              // ISSUE: reference to a compiler-generated field
              Form_startup._Closure\u0024__.\u0024I152\u002D2 = myDelegate = (Form_startup.MyDelegate) (() => num = (int) MessageBox.Show("No device connected to the machine.", "No device", MessageBoxButtons.OK, MessageBoxIcon.Hand));
            }
            this.Invoke((Delegate) myDelegate);
          }
        }
        this.Focus();
        this.working = false;
      }
    }

    private void textbox_startup_MouseHover(object sender, EventArgs e)
    {
      if ((TextBox) sender == this.textbox_turnoff)
      {
        this.tooltip_startup.Show("The time in seconds format to shutdown the PC when locked (10 seconds up)", (IWin32Window) this.textbox_turnoff, 10000);
      }
      else
      {
        if ((TextBox) sender != this.textbox_email)
          return;
        this.tooltip_startup.Show("The email recovery when you forgot your password", (IWin32Window) this.textbox_email, 10000);
      }
    }

    private delegate void MyDelegate();

    private delegate void Worker_RunWorkerCompleted_Delegate(
      object sender,
      RunWorkerCompletedEventArgs e);
  }
}
