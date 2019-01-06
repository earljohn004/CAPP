// Decompiled with JetBrains decompiler
// Type: coinapp.coinappMods
// Assembly: coinapp, Version=1.4.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6DB842CC-5810-43FB-8044-475700CA1E42
// Assembly location: C:\Users\EarlJohn\Desktop\Coinapp\coinapp_1.4.0.0\coinapp.exe

using coinapp.My;
using coinapplib;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data.OleDb;
using System.Diagnostics;
using System.IO.Ports;
using System.Runtime.CompilerServices;
using System.ServiceProcess;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace coinapp
{
  [StandardModule]
  internal sealed class coinappMods
  {
    public static int coin = 0;
    public static int coinCredits = 0;
    public static string sID = (string) null;
    public static config conf = new config();
    public static device device = new device();
    public static Shutdown shutdown = new Shutdown();
    public static settings settings = new settings();
    public static pix pix = new pix();
    public static encrypt enc = new encrypt();
    public static pos pos = new pos();
    public static powerMode powerMode = new powerMode();
    [AccessedThroughProperty("desktop")]
    private static desktop _desktop;
    [AccessedThroughProperty("hotkey")]
    private static hotkey _hotkey;
    public static SerialPort SerialComPort;
    public static System.Timers.Timer serviceWatcher;
    public static Thread serviceMonitor;
    public static database voucher;
    public static database account;
    public static OleDbCommand aCommand;
    public static string userAccount;
    public static bool deviceIsReady;
    public static bool timerVisible;
    public static bool TIMERESUME;
    public static bool CHARGE;
    public static bool BEGINCHARGE;
    public static int CREDITSTYPE;
    public static int LOCKCODE;
    public static int ERR_DEVICE;
    public static int ERR_APPS;
    public static int credits;
    public static int loginAttempt;
    public static int oPause;
    public static string deviceid;
    public static string devicefw;
    public static string devicedate;
    public static NotifyIcon cNotifyIcon;
    public static ContextMenuStrip cUserContextMenuStrip;
    public static ContextMenuStrip cAdminContextMenuStrip;
    public static ToolStripMenuItem cLogoutToolStrip;
    public static ToolStripMenuItem cVisibleToolStrip;
    public static ToolStripMenuItem cPauseToolStrip;
    public static ToolStripMenuItem cSettingsToolStrip;
    public static ToolStripMenuItem cLockToolStrip;
    public static ToolStripMenuItem cTotalToolStrip;
    public static Process svccaProc;
    public static int svccaProcID;
    public static bool serviceExist;
    public static bool SERVICE_STOPPED;
    public static string serviceName;
    public static ServiceController[] serviceControllers;

    static coinappMods()
    {
      coinappMods.desktop = new desktop();
      coinappMods.hotkey = new hotkey();
      coinappMods.SerialComPort = new SerialPort();
      coinappMods.serviceWatcher = new System.Timers.Timer(10.0);
      coinappMods.CREDITSTYPE = 0;
      coinappMods.LOCKCODE = -1;
      coinappMods.serviceName = "svcca";
    }

    public static desktop desktop
    {
      [DebuggerNonUserCode] get
      {
        return coinappMods._desktop;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        coinappMods._desktop = value;
      }
    }

    public static hotkey hotkey
    {
      [DebuggerNonUserCode] get
      {
        return coinappMods._hotkey;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        coinappMods._hotkey = value;
      }
    }

    public static void hotkey_Keydown(object sender, EventArgs e)
    {
      if (coinappMods.desktop.IsLocked)
      {
        MyProject.Forms.form_login.btn_login.Text = "Unlock";
        MyProject.Forms.form_login.Show();
      }
      else if (!MyProject.Forms.form_config.Visible)
        MyProject.Forms.form_login.Show();
    }

    public static string getTime(int time)
    {
      int num1 = time % 60;
      int num2 = checked ((int) Math.Round(unchecked ((double) checked (time - num1) / 60.0 % 60.0)));
      return Strings.Format((object) checked ((int) Math.Round(unchecked ((double) checked (time - num1 + num2 * 60) / 3600.0 % 60.0))), "0 0") + "  :  " + Strings.Format((object) num2, "0 0") + "  :  " + Strings.Format((object) num1, "0 0");
    }

    public static bool isValidEmail(string email)
    {
      return Regex.IsMatch(email, "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$");
    }

    public static bool isValidID(string str)
    {
      return new Regex("[0-9a-f]{32}", RegexOptions.Compiled).IsMatch(str);
    }

    private delegate void MyDelegate();
  }
}
