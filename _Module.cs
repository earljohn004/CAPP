// Decompiled with JetBrains decompiler
// Type: Coinapp._Module
// Assembly: Coinapp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: ED4B7D1C-BF2E-4AAF-8FCA-FEC188D22124
// Assembly location: C:\Users\EarlJohn\Desktop\Coinapp\Coinapp.exe

using Coinapp.My;
using Control;
using Device;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using RegistryUtils;
using Settings;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Management;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace Coinapp
{
  [StandardModule]
  internal sealed class _Module
  {
    public static int senderIDInterval = 1000;
    public static int waitProcmonProcess = 1000;
    public static Config Config = new Config();
    public static _config Conf = new _config();
    public static Settings.Image Image = new Settings.Image();
    public static Encryption _MD5 = new Encryption();
    public static Desktop Desktop = new Desktop();
    public static PowerManager PowerManager = new PowerManager();
    public static RegistryMonitor StartupChecker;
    public static Communicate Communicate;
    public static Shutdown Shutdown;
    public static Control.Hotkey KeyCombination;
    public static BringTo BringTo;
    public static MyFonts _font;
    public static SerialPort MainSerialPort;
    public static Watcher PreventShutdown;
    public static System.Timers.Timer SwitchTimerLock;
    public static System.Timers.Timer LockWatcher;
    public static Form_notify Notify;
    public static Form_dialog Dialog;
    public static string MyID;
    public static bool resumeTime;
    public static bool beepConfigured;
    public static Bitmap bgImage;
    public static BackgroundWorker DeviceConnectionWorker;
    public static ManagementEventWatcher DeviceConnectionWatcher;
    public static int MyPID;
    public static int procPID;
    public static Process[] processes;
    public static Process proc;
    public static string procmon;
    public static string errorcode;
    public static string deviceid;
    public static string devicefirmware;
    public static string devicefirmwaredate;
    public static int CoinCredits;
    public static int PasswordLoginRetry;
    public static bool FirstTimeToHide;
    public static bool FormTimerIsHidden;
    public static bool DeviceIsError;
    public static bool ApplicationStarted;
    public static bool ExecuteVariables;
    public static bool DeviceIsReady;
    public static bool Initialized;
    public static bool CreditsIsCounting;
    public static bool CoinNotify;
    public static bool TimeNotify;
    public static bool exitapp;
    public static bool hacked;
    public static bool logout;
    public static bool visibledDialog;
    public static NotifyIcon CoinappNotifyIcon;
    public static ContextMenuStrip CoinappContextMenuStrip;
    public static ToolStripMenuItem CoinappVisibleToolStrip;
    public static ToolStripMenuItem CoinappSettingsToolStrip;
    public static ToolStripMenuItem CoinappLockToolStrip;
    public static ToolStripMenuItem CoinappLogoutToolStrip;
    public static ToolStripMenuItem CoinappCounterToolStrip;
    public static Form LockForm;
    public const int WM_QUERYENDSESSION = 17;
    public const int WM_CANCELMODE = 31;

    static _Module()
    {
      _Module.Hotkey = new Hotkeys();
      _Module.Device = new Board();
      _Module.Communicate = new Communicate();
      _Module.Shutdown = new Shutdown();
      _Module.KeyCombination = new Control.Hotkey();
      _Module.BringTo = new BringTo();
      _Module._font = new MyFonts();
      _Module.MainSerialPort = new SerialPort();
      _Module.SwitchTimerLock = new System.Timers.Timer(500.0);
      _Module.LockWatcher = new System.Timers.Timer(500.0);
      _Module.DeviceConnectionWorker = new BackgroundWorker();
      _Module.DeviceConnectionWatcher = new ManagementEventWatcher("SELECT * FROM Win32_DeviceChangeEvent");
      _Module.procmon = Application.StartupPath + "\\procmon.exe";
      _Module.errorcode = "0";
      _Module.CoinCredits = 0;
      _Module.PasswordLoginRetry = 0;
      _Module.FirstTimeToHide = true;
      _Module.FormTimerIsHidden = true;
      _Module.DeviceIsError = true;
      _Module.ApplicationStarted = true;
    }

    public static Hotkeys Hotkey { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    public static Board Device { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    public static void Hotkey_Keydown(object sender, EventArgs e)
    {
      if (_Module.Desktop.IsLocked)
      {
        MyProject.Forms.Form_login.button_login.Text = "Unlock Desktop";
        MyProject.Forms.Form_login.Show();
      }
      else if (!MyProject.Forms.Form_login.Visible & !MyProject.Forms.Form_settings.Visible)
        MyProject.Forms.Form_login.Show();
    }

    public static string GetTime(int Time)
    {
      int num1 = Time % 60;
      int num2 = checked ((int) Math.Round(unchecked ((double) checked (Time - num1) / 60.0 % 60.0)));
      return Strings.Format((object) checked ((int) Math.Round(unchecked ((double) checked (Time - num1 + num2 * 60) / 3600.0 % 60.0))), "00") + ":" + Strings.Format((object) num2, "00") + ":" + Strings.Format((object) num1, "00");
    }

    public static void MainSerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
      string Left = _Module.MainSerialPort.ReadTo(",");
      if (_Module.DeviceIsReady)
      {
        if (Operators.CompareString(Left, "COIN1", false) == 0)
        {
          _Module.CoinCounter("COIN1");
          if (_Module.visibledDialog)
          {
            _Module.Dialog.Close();
            _Module.visibledDialog = false;
          }
          if (_Module.Desktop.IsLocked)
          {
            if (_Module.LockWatcher.Enabled)
              _Module.LockWatcher.Stop();
            _Module.Desktop.Unlock();
          }
          if (!_Module.CreditsIsCounting)
          {
            _Module.CreditsIsCounting = true;
            _Module.MainSerialPort.Write("COUNT=1");
          }
          _Module.logout = false;
          _Module.CoinNotify = true;
          _Module.ShowNotification(_Module.Conf.NotifyCoin1, _Module.Image.coins(), 3);
          Left = "";
        }
        else if (Operators.CompareString(Left, "COIN2", false) == 0)
        {
          _Module.CoinCounter("COIN2");
          if (_Module.visibledDialog)
          {
            _Module.Dialog.Close();
            _Module.visibledDialog = false;
          }
          if (_Module.Desktop.IsLocked)
          {
            if (_Module.LockWatcher.Enabled)
              _Module.LockWatcher.Stop();
            _Module.Desktop.Unlock();
          }
          if (!_Module.CreditsIsCounting)
          {
            _Module.CreditsIsCounting = true;
            _Module.MainSerialPort.Write("COUNT=1");
          }
          _Module.logout = false;
          _Module.CoinNotify = true;
          _Module.ShowNotification(_Module.Conf.NotifyCoin2, _Module.Image.coins(), 3);
          Left = "";
        }
        else if (Operators.CompareString(Left, "COIN3", false) == 0)
        {
          _Module.CoinCounter("COIN3");
          if (_Module.visibledDialog)
          {
            _Module.Dialog.Close();
            _Module.visibledDialog = false;
          }
          if (_Module.Desktop.IsLocked)
          {
            if (_Module.LockWatcher.Enabled)
              _Module.LockWatcher.Stop();
            _Module.Desktop.Unlock();
          }
          if (!_Module.CreditsIsCounting)
          {
            _Module.CreditsIsCounting = true;
            _Module.MainSerialPort.Write("COUNT=1");
          }
          _Module.logout = false;
          _Module.CoinNotify = true;
          _Module.ShowNotification(_Module.Conf.NotifyCoin3, _Module.Image.coins(), 3);
          Left = "";
        }
        if (Operators.CompareString(Left, "TIME", false) == 0)
        {
          _Module.CreditsIsCounting = false;
          _Module.CoinCredits = 0;
          if (_Module.Dialog != null && _Module.Dialog.Visible)
          {
            _Module.Dialog.Dispose();
            _Module.Dialog.Close();
          }
          if (!_Module.FormTimerIsHidden)
          {
            Form_timer mainForm = (Form_timer) _Entrypoint.MyMainForm;
            _Module.MyDelegate myDelegate;
            // ISSUE: reference to a compiler-generated field
            if (_Module._Closure\u0024__.\u0024I73\u002D0 != null)
            {
              // ISSUE: reference to a compiler-generated field
              myDelegate = _Module._Closure\u0024__.\u0024I73\u002D0;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              _Module._Closure\u0024__.\u0024I73\u002D0 = myDelegate = (_Module.MyDelegate) (() => _Entrypoint.MyMainForm.Hide());
            }
            mainForm.BeginInvoke((Delegate) myDelegate);
            _Module.FormTimerIsHidden = true;
          }
          if (_Module.Desktop.DeskLocked())
          {
            if (!_Module.SwitchTimerLock.Enabled)
              _Module.SwitchTimerLock.Start();
          }
          else
          {
            _Module.LockWatcher.Start();
            Form_timer mainForm = (Form_timer) _Entrypoint.MyMainForm;
            _Module.MyDelegate myDelegate;
            // ISSUE: reference to a compiler-generated field
            if (_Module._Closure\u0024__.\u0024I73\u002D1 != null)
            {
              // ISSUE: reference to a compiler-generated field
              myDelegate = _Module._Closure\u0024__.\u0024I73\u002D1;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              _Module._Closure\u0024__.\u0024I73\u002D1 = myDelegate = (_Module.MyDelegate) (() => _Module.Desktop.Lock((IWin32Window) MyProject.Forms.Form_lock));
            }
            mainForm.BeginInvoke((Delegate) myDelegate);
          }
          Left = "";
        }
        else
        {
          string s = Left;
          int num = 0;
          ref int local = ref num;
          if (int.TryParse(s, out local))
          {
            _Module.CoinCredits = Conversions.ToInteger(Left);
            if (_Module.Desktop.IsLocked)
              _Module.Desktop.Unlock();
            if (!_Module.FormTimerIsHidden)
            {
              Form_timer mainForm = (Form_timer) _Entrypoint.MyMainForm;
              _Module.MyDelegate myDelegate;
              // ISSUE: reference to a compiler-generated field
              if (_Module._Closure\u0024__.\u0024I73\u002D2 != null)
              {
                // ISSUE: reference to a compiler-generated field
                myDelegate = _Module._Closure\u0024__.\u0024I73\u002D2;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                _Module._Closure\u0024__.\u0024I73\u002D2 = myDelegate = (_Module.MyDelegate) (() => MyProject.Forms.Form_timer.label_countdown.Text = _Module.GetTime(_Module.CoinCredits));
              }
              mainForm.BeginInvoke((Delegate) myDelegate);
            }
            if (_Module.Conf.SaveData)
              _Module.Config.WriteCoin(_Module._MD5.Decrypt(_Module.Config.EncryptedReadFile(_Module._MD5.GetMd5Hash("datafolder")), "datafolder"), _Module._MD5.GetMd5Hash("remainingtime" + _Module.MyID), _Module._MD5.Encrypt(Conversions.ToString(_Module.CoinCredits), "remainingtime"));
            if ((uint) _Module.Conf.Notify1 > 0U && _Module.CoinCredits == _Module.Conf.Notify1)
            {
              _Module.TimeNotify = true;
              if ((uint) _Module.Conf.Notify1sec > 0U)
                _Module.ShowNotification(_Module.Conf.NotifyMessage1, _Module.Image.attention(), _Module.Conf.Notify1sec);
              else
                _Module.ShowNotification(_Module.Conf.NotifyMessage1, _Module.Image.attention(), 3);
            }
            if ((uint) _Module.Conf.Notify2 > 0U)
            {
              if (_Module.CoinCredits == _Module.Conf.Notify2)
              {
                _Module.TimeNotify = true;
                if (_Module.FormTimerIsHidden)
                {
                  _Module.FormTimerIsHidden = false;
                  _Entrypoint.MyMainForm.BeginInvoke((Delegate) new _Module.MyDelegate(((System.Windows.Forms.Control) _Entrypoint.MyMainForm).Show));
                  Form_timer mainForm = (Form_timer) _Entrypoint.MyMainForm;
                  _Module.MyDelegate myDelegate;
                  // ISSUE: reference to a compiler-generated field
                  if (_Module._Closure\u0024__.\u0024I73\u002D3 != null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    myDelegate = _Module._Closure\u0024__.\u0024I73\u002D3;
                  }
                  else
                  {
                    // ISSUE: reference to a compiler-generated field
                    _Module._Closure\u0024__.\u0024I73\u002D3 = myDelegate = (_Module.MyDelegate) (() => _Module.ChangeVisibleToolText("Hide"));
                  }
                  mainForm.BeginInvoke((Delegate) myDelegate);
                }
                if ((uint) _Module.Conf.Notify2sec > 0U)
                  _Module.ShowNotification(_Module.Conf.NotifyMessage2, _Module.Image.priority(), _Module.Conf.Notify2sec);
                else
                  _Module.ShowNotification(_Module.Conf.NotifyMessage2, _Module.Image.priority(), 3);
              }
            }
            else if (_Module.CoinCredits == 5 && _Module.FormTimerIsHidden)
            {
              _Module.FormTimerIsHidden = false;
              _Entrypoint.MyMainForm.BeginInvoke((Delegate) new _Module.MyDelegate(((System.Windows.Forms.Control) _Entrypoint.MyMainForm).Show));
              Form_timer mainForm = (Form_timer) _Entrypoint.MyMainForm;
              _Module.MyDelegate myDelegate;
              // ISSUE: reference to a compiler-generated field
              if (_Module._Closure\u0024__.\u0024I73\u002D4 != null)
              {
                // ISSUE: reference to a compiler-generated field
                myDelegate = _Module._Closure\u0024__.\u0024I73\u002D4;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                _Module._Closure\u0024__.\u0024I73\u002D4 = myDelegate = (_Module.MyDelegate) (() => _Module.ChangeVisibleToolText("Hide"));
              }
              mainForm.BeginInvoke((Delegate) myDelegate);
            }
            if (_Module.Conf.PlaySound && _Module.Conf.Play5SecVoice && _Module.CoinCredits == 5)
              MyProject.Computer.Audio.Play((Stream) _Module.Config.five_seconds(), AudioPlayMode.Background);
            Left = "";
          }
        }
        if (Operators.CompareString(Left, "MULTI", false) == 0)
        {
          _Module.MainSerialPort.Write("COIN1=" + Conversions.ToString(_Module.Conf.Coin1));
          _Module.MainSerialPort.Write("COIN2=" + Conversions.ToString(_Module.Conf.Coin2));
          _Module.MainSerialPort.Write("COIN3=" + Conversions.ToString(_Module.Conf.Coin3));
          _Module.MainSerialPort.Write("PULSE1=" + Conversions.ToString(_Module.Conf.Pulse1));
          _Module.MainSerialPort.Write("PULSE2=" + Conversions.ToString(_Module.Conf.Pulse2));
          _Module.MainSerialPort.Write("PULSE3=" + Conversions.ToString(_Module.Conf.Pulse3));
          _Module.ConfigureBeep();
          if (_Module.Desktop.IsLocked && !_Module.logout)
          {
            Form_lock lockForm = (Form_lock) _Module.Desktop.LockForm;
            _Module.MyDelegate myDelegate;
            // ISSUE: reference to a compiler-generated field
            if (_Module._Closure\u0024__.\u0024I73\u002D5 != null)
            {
              // ISSUE: reference to a compiler-generated field
              myDelegate = _Module._Closure\u0024__.\u0024I73\u002D5;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              _Module._Closure\u0024__.\u0024I73\u002D5 = myDelegate = (_Module.MyDelegate) (() => ((Form_lock) _Module.Desktop.LockForm).StartupDisplay());
            }
            lockForm.BeginInvoke((Delegate) myDelegate);
          }
          _Module.ResumeTimeRemaining();
          Left = "";
        }
        else if (Operators.CompareString(Left, "DUAL", false) == 0)
        {
          _Module.MainSerialPort.Write("COIN1=" + Conversions.ToString(_Module.Conf.Coin1));
          _Module.MainSerialPort.Write("PULSE1=" + Conversions.ToString(_Module.Conf.Pulse1));
          _Module.MainSerialPort.Write("COIN2=" + Conversions.ToString(_Module.Conf.Coin2));
          _Module.MainSerialPort.Write("PULSE2=" + Conversions.ToString(_Module.Conf.Pulse2));
          _Module.ConfigureBeep();
          if (_Module.Desktop.IsLocked && !_Module.logout)
          {
            Form_lock lockForm = (Form_lock) _Module.Desktop.LockForm;
            _Module.MyDelegate myDelegate;
            // ISSUE: reference to a compiler-generated field
            if (_Module._Closure\u0024__.\u0024I73\u002D6 != null)
            {
              // ISSUE: reference to a compiler-generated field
              myDelegate = _Module._Closure\u0024__.\u0024I73\u002D6;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              _Module._Closure\u0024__.\u0024I73\u002D6 = myDelegate = (_Module.MyDelegate) (() => ((Form_lock) _Module.Desktop.LockForm).StartupDisplay());
            }
            lockForm.BeginInvoke((Delegate) myDelegate);
          }
          _Module.ResumeTimeRemaining();
          Left = "";
        }
        else if (Operators.CompareString(Left, "SINGLE", false) == 0)
        {
          _Module.MainSerialPort.Write("COIN1=" + Conversions.ToString(_Module.Conf.Coin1));
          _Module.MainSerialPort.Write("PULSE1=" + Conversions.ToString(_Module.Conf.Pulse1));
          _Module.ConfigureBeep();
          if (_Module.Desktop.IsLocked && !_Module.logout)
          {
            Form_lock lockForm = (Form_lock) _Module.Desktop.LockForm;
            _Module.MyDelegate myDelegate;
            // ISSUE: reference to a compiler-generated field
            if (_Module._Closure\u0024__.\u0024I73\u002D7 != null)
            {
              // ISSUE: reference to a compiler-generated field
              myDelegate = _Module._Closure\u0024__.\u0024I73\u002D7;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              _Module._Closure\u0024__.\u0024I73\u002D7 = myDelegate = (_Module.MyDelegate) (() => ((Form_lock) _Module.Desktop.LockForm).StartupDisplay());
            }
            lockForm.BeginInvoke((Delegate) myDelegate);
          }
          _Module.ResumeTimeRemaining();
          Left = "";
        }
        if (Operators.CompareString(Left, "DEVID", false) == 0)
        {
          _Module.deviceid = _Module.MainSerialPort.ReadTo(",");
          Left = "";
        }
        if (Operators.CompareString(Left, "FIRMVER", false) == 0)
        {
          _Module.devicefirmware = _Module.MainSerialPort.ReadTo(",");
          Left = "";
        }
        if (Operators.CompareString(Left, "FIRMDATE", false) != 0)
          return;
        _Module.devicefirmwaredate = _Module.MainSerialPort.ReadTo(",");
      }
      else
      {
        if (Operators.CompareString(Left, "READY", false) == 0)
        {
          _Module.DeviceIsReady = true;
          if (Operators.CompareString(_Module.Conf.CoinAcceptor, "DUAL", false) == 0)
            _Module.MainSerialPort.Write("COINSLOT=2");
          else if (Operators.CompareString(_Module.Conf.CoinAcceptor, "MULTI", false) == 0)
            _Module.MainSerialPort.Write("COINSLOT=3");
          else
            _Module.MainSerialPort.Write("COINSLOT=1");
        }
        if (Operators.CompareString(Left, "REQDEVID", false) == 0)
        {
          _Module.MyID = _Module.MainSerialPort.ReadTo(",");
          if (_Module.VerifyDeviceID(_Module.MyID))
            _Module.MainSerialPort.Write(_Module.MyID + ";");
          else
            _Module.MyID = "";
        }
      }
    }

    public static int TotalCoinCounter(int coinsToAdd = 0)
    {
      int num;
      try
      {
        num = Conversions.ToInteger(_Module._MD5.Decrypt(_Module.Config.EncryptedReadCoin(_Module._MD5.Decrypt(_Module.Config.EncryptedReadFile(_Module._MD5.GetMd5Hash("datafolder")), "datafolder"), _Module._MD5.GetMd5Hash("coincounter" + _Module.MyID)), "coincounter"));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        num = 0;
        ProjectData.ClearProjectError();
      }
      return checked (coinsToAdd + num);
    }

    private static void CoinCounter(string args)
    {
      if (!_Module.Conf.SaveData)
        return;
      if (Operators.CompareString(args, "COIN1", false) == 0)
        _Module.Config.WriteCoin(_Module._MD5.Decrypt(_Module.Config.EncryptedReadFile(_Module._MD5.GetMd5Hash("datafolder")), "datafolder"), _Module._MD5.GetMd5Hash("coincounter" + _Module.MyID), _Module._MD5.Encrypt(Conversions.ToString(_Module.TotalCoinCounter(1)), "coincounter"));
      else if (Operators.CompareString(args, "COIN2", false) == 0)
        _Module.Config.WriteCoin(_Module._MD5.Decrypt(_Module.Config.EncryptedReadFile(_Module._MD5.GetMd5Hash("datafolder")), "datafolder"), _Module._MD5.GetMd5Hash("coincounter" + _Module.MyID), _Module._MD5.Encrypt(Conversions.ToString(_Module.TotalCoinCounter(5)), "coincounter"));
      else if (Operators.CompareString(args, "COIN3", false) == 0)
        _Module.Config.WriteCoin(_Module._MD5.Decrypt(_Module.Config.EncryptedReadFile(_Module._MD5.GetMd5Hash("datafolder")), "datafolder"), _Module._MD5.GetMd5Hash("coincounter" + _Module.MyID), _Module._MD5.Encrypt(Conversions.ToString(_Module.TotalCoinCounter(10)), "coincounter"));
    }

    private static void ResumeTimeRemaining()
    {
      if (!_Module.Conf.SaveData)
        return;
      int num;
      try
      {
        num = Conversions.ToInteger(_Module._MD5.Decrypt(_Module.Config.EncryptedReadCoin(_Module._MD5.Decrypt(_Module.Config.EncryptedReadFile(_Module._MD5.GetMd5Hash("datafolder")), "datafolder"), _Module._MD5.GetMd5Hash("remainingtime" + _Module.MyID)), "remainingtime"));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        num = 0;
        ProjectData.ClearProjectError();
      }
      _Module.CoinCredits = num;
      if ((uint) _Module.CoinCredits > 0U)
      {
        _Module.resumeTime = true;
        if (_Module.Desktop.IsLocked && !_Module.visibledDialog)
        {
          _Module.CreateResumeDialog();
          Form_lock lockForm = (Form_lock) _Module.Desktop.LockForm;
          _Module.MyDelegate myDelegate;
          // ISSUE: reference to a compiler-generated field
          if (_Module._Closure\u0024__.\u0024I76\u002D0 != null)
          {
            // ISSUE: reference to a compiler-generated field
            myDelegate = _Module._Closure\u0024__.\u0024I76\u002D0;
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            _Module._Closure\u0024__.\u0024I76\u002D0 = myDelegate = (_Module.MyDelegate) (() => _Module.Dialog.Show());
          }
          lockForm.BeginInvoke((Delegate) myDelegate);
        }
      }
    }

    public static void CreateResumeDialog()
    {
      _Module.MainSerialPort.Write("CREDITS=" + Conversions.ToString(_Module.CoinCredits));
      _Module.Dialog = new Form_dialog("TIME RESUME", "There is a " + _Module.GetTime(_Module.CoinCredits) + " remaining time to be resume. You can resume or cancel the time remaining. What will you do?", "USE TIME", "CANCEL TIME");
      _Module.Dialog.Locked = true;
      _Module.Dialog.ControlBox = false;
    }

    private static void ConfigureBeep()
    {
      if (!_Module.Conf.Beep)
        return;
      _Module.MainSerialPort.Write("BEEP=1");
      _Module.MainSerialPort.Write("BCDUR=" + Conversions.ToString(_Module.Conf.BeepCoinDur));
      _Module.MainSerialPort.Write("BCFREQ=" + Conversions.ToString(_Module.Conf.BeepCoinFreq));
      _Module.MainSerialPort.Write("BTIME= " + Conversions.ToString(_Module.Conf.BeepTime));
      _Module.MainSerialPort.Write("BTFREQ= " + Conversions.ToString(_Module.Conf.BeepTimeFreq));
      _Module.MainSerialPort.Write("BTREP= " + Conversions.ToString(_Module.Conf.BeepTimeRep));
      _Module.MainSerialPort.Write("BTDUR= " + Conversions.ToString(_Module.Conf.BeepTimeDur));
      _Module.MainSerialPort.Write("BLFREQ= " + Conversions.ToString(_Module.Conf.BeepLockFreq));
      _Module.MainSerialPort.Write("BLREP= " + Conversions.ToString(_Module.Conf.BeepLockRep));
      _Module.MainSerialPort.Write("BLDUR= " + Conversions.ToString(_Module.Conf.BeepLockDur));
      if (_Module.Conf.BeepShut)
      {
        _Module.MainSerialPort.Write("BSDUR= " + Conversions.ToString(_Module.Conf.BeepShutDur));
        _Module.MainSerialPort.Write("BSFREQ= " + Conversions.ToString(_Module.Conf.BeepShutFreq));
      }
      _Module.beepConfigured = true;
    }

    public static bool ConnectDevice()
    {
      bool flag;
      if (!_Module.MainSerialPort.IsOpen)
      {
        string str = _Module.Device.Port();
        if ((uint) Operators.CompareString(str, "", false) > 0U)
        {
          if ((uint) Operators.CompareString(str, _Module.Conf.PortName, false) > 0U)
            _Module.Config.SetPortName(str);
          try
          {
            _Module.MainSerialPort.BaudRate = _Module.Conf.BaudRate;
            _Module.MainSerialPort.PortName = str;
            _Module.MainSerialPort.DtrEnable = true;
            _Module.MainSerialPort.Open();
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            _Module.DeviceIsError = true;
            if (_Module.Desktop.DeskLocked())
            {
              if (!_Module.SwitchTimerLock.Enabled)
                _Module.SwitchTimerLock.Start();
            }
            else
            {
              if (!_Module.LockWatcher.Enabled)
                _Module.LockWatcher.Start();
              Form_timer mainForm = (Form_timer) _Entrypoint.MyMainForm;
              _Module.MyDelegate myDelegate;
              // ISSUE: reference to a compiler-generated field
              if (_Module._Closure\u0024__.\u0024I79\u002D0 != null)
              {
                // ISSUE: reference to a compiler-generated field
                myDelegate = _Module._Closure\u0024__.\u0024I79\u002D0;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                _Module._Closure\u0024__.\u0024I79\u002D0 = myDelegate = (_Module.MyDelegate) (() => _Module.Desktop.Lock((IWin32Window) MyProject.Forms.Form_lock));
              }
              mainForm.BeginInvoke((Delegate) myDelegate);
            }
            flag = false;
            ProjectData.ClearProjectError();
            goto label_37;
          }
          flag = true;
        }
        else
        {
          _Module.DeviceIsError = true;
          if (_Module.Desktop.DeskLocked())
          {
            if (!_Module.SwitchTimerLock.Enabled)
              _Module.SwitchTimerLock.Start();
          }
          else
          {
            if (!_Module.LockWatcher.Enabled)
              _Module.LockWatcher.Start();
            Form_timer mainForm = (Form_timer) _Entrypoint.MyMainForm;
            _Module.MyDelegate myDelegate;
            // ISSUE: reference to a compiler-generated field
            if (_Module._Closure\u0024__.\u0024I79\u002D1 != null)
            {
              // ISSUE: reference to a compiler-generated field
              myDelegate = _Module._Closure\u0024__.\u0024I79\u002D1;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              _Module._Closure\u0024__.\u0024I79\u002D1 = myDelegate = (_Module.MyDelegate) (() => _Module.Desktop.Lock((IWin32Window) MyProject.Forms.Form_lock));
            }
            mainForm.BeginInvoke((Delegate) myDelegate);
          }
          flag = false;
        }
      }
      else
      {
        _Module.DeviceIsError = true;
        if (_Module.Desktop.DeskLocked())
        {
          if (!_Module.SwitchTimerLock.Enabled)
            _Module.SwitchTimerLock.Start();
        }
        else
        {
          if (!_Module.LockWatcher.Enabled)
            _Module.LockWatcher.Start();
          Form_timer mainForm = (Form_timer) _Entrypoint.MyMainForm;
          _Module.MyDelegate myDelegate;
          // ISSUE: reference to a compiler-generated field
          if (_Module._Closure\u0024__.\u0024I79\u002D2 != null)
          {
            // ISSUE: reference to a compiler-generated field
            myDelegate = _Module._Closure\u0024__.\u0024I79\u002D2;
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            _Module._Closure\u0024__.\u0024I79\u002D2 = myDelegate = (_Module.MyDelegate) (() => _Module.Desktop.Lock((IWin32Window) MyProject.Forms.Form_lock));
          }
          mainForm.BeginInvoke((Delegate) myDelegate);
        }
        flag = false;
      }
label_37:
      return flag;
    }

    public static void ConfigureDevice()
    {
      _Module.DeviceIsError = false;
      _Module.DeviceConnectionWatcher.Start();
      if (!_Module.Desktop.IsAdmin)
      {
        if (_Module.Desktop.DeskLocked())
        {
          if (!_Module.SwitchTimerLock.Enabled)
            _Module.SwitchTimerLock.Start();
        }
        else
        {
          if (!_Module.LockWatcher.Enabled)
            _Module.LockWatcher.Start();
          Form_timer mainForm = (Form_timer) _Entrypoint.MyMainForm;
          _Module.MyDelegate myDelegate;
          // ISSUE: reference to a compiler-generated field
          if (_Module._Closure\u0024__.\u0024I80\u002D0 != null)
          {
            // ISSUE: reference to a compiler-generated field
            myDelegate = _Module._Closure\u0024__.\u0024I80\u002D0;
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            _Module._Closure\u0024__.\u0024I80\u002D0 = myDelegate = (_Module.MyDelegate) (() => _Module.Desktop.Lock((IWin32Window) MyProject.Forms.Form_lock));
          }
          mainForm.BeginInvoke((Delegate) myDelegate);
        }
      }
      Thread.Sleep(3000);
      _Module.MainSerialPort.Write("REQDEVID;");
      Thread.Sleep(_Module.senderIDInterval);
      _Module.Initialized = true;
      if (_Module.DeviceIsReady)
        return;
      if (_Module.Desktop.IsLocked)
      {
        Form_lock lockForm = (Form_lock) _Module.Desktop.LockForm;
        _Module.MyDelegate myDelegate;
        // ISSUE: reference to a compiler-generated field
        if (_Module._Closure\u0024__.\u0024I80\u002D1 != null)
        {
          // ISSUE: reference to a compiler-generated field
          myDelegate = _Module._Closure\u0024__.\u0024I80\u002D1;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          _Module._Closure\u0024__.\u0024I80\u002D1 = myDelegate = (_Module.MyDelegate) (() => ((Form_lock) _Module.Desktop.LockForm).DeviceNotCompatible());
        }
        lockForm.BeginInvoke((Delegate) myDelegate);
      }
      try
      {
        _Module.MainSerialPort.Close();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) ex.Message, MsgBoxStyle.Critical, (object) null);
        ProjectData.ClearProjectError();
      }
      _Module.DeviceIsError = true;
      _Module.CoinappNotifyIcon.Icon = _Module.Image.icon_red();
    }

    public static void ShowNotification(string message, Bitmap icon, int time = 3)
    {
      _Module.Notify = new Form_notify(message, icon, time);
      _Module.Notify.ShowInTaskbar = false;
      Form_timer mainForm = (Form_timer) _Entrypoint.MyMainForm;
      _Module.MyDelegate myDelegate;
      // ISSUE: reference to a compiler-generated field
      if (_Module._Closure\u0024__.\u0024I81\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        myDelegate = _Module._Closure\u0024__.\u0024I81\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        _Module._Closure\u0024__.\u0024I81\u002D0 = myDelegate = (_Module.MyDelegate) (() => _Module.Notify.Show());
      }
      mainForm.BeginInvoke((Delegate) myDelegate);
    }

    private static void ChangeVisibleToolText(string text)
    {
      _Module.CoinappVisibleToolStrip.Text = text;
    }

    public static void ProcessExited(object sender, EventArgs e)
    {
      if (_Module.exitapp)
        return;
      _Module.proc = Process.Start(_Module.procmon);
      _Module.procPID = _Module.proc.Id;
      _Module.proc.EnableRaisingEvents = true;
      _Module.proc.Exited += new EventHandler(_Module.ProcessExited);
      ThreadStart start;
      // ISSUE: reference to a compiler-generated field
      if (_Module._Closure\u0024__.\u0024IR83\u002D1 != null)
      {
        // ISSUE: reference to a compiler-generated field
        start = _Module._Closure\u0024__.\u0024IR83\u002D1;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        _Module._Closure\u0024__.\u0024IR83\u002D1 = start = (ThreadStart) (() => _Module.SendMessage());
      }
      new Thread(start).Start();
      _Module.processes = Process.GetProcessesByName("procmon");
      if (_Module.processes.Length == 0)
      {
        _Module.errorcode = "3";
        _Module.hacked = true;
        if (!_Module.Desktop.IsLocked)
        {
          if (_Module.Desktop.DeskLocked())
          {
            _Module.SwitchTimerLock.Start();
          }
          else
          {
            _Module.LockWatcher.Start();
            Form_timer mainForm = (Form_timer) _Entrypoint.MyMainForm;
            _Module.MyDelegate myDelegate;
            // ISSUE: reference to a compiler-generated field
            if (_Module._Closure\u0024__.\u0024I83\u002D0 != null)
            {
              // ISSUE: reference to a compiler-generated field
              myDelegate = _Module._Closure\u0024__.\u0024I83\u002D0;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              _Module._Closure\u0024__.\u0024I83\u002D0 = myDelegate = (_Module.MyDelegate) (() => _Module.Desktop.Lock((IWin32Window) MyProject.Forms.Form_lock));
            }
            mainForm.BeginInvoke((Delegate) myDelegate);
          }
        }
      }
      else if (_Module.processes.Length > 1)
      {
        int num = checked (_Module.processes.Length - 1);
        int index = 0;
        bool flag;
        while (index <= num)
        {
          if (_Module.processes[index].Id == _Module.procPID)
            flag = true;
          checked { ++index; }
        }
        if (!flag)
        {
          _Module.errorcode = "4";
          if (!_Module.Desktop.IsLocked)
          {
            if (_Module.Desktop.DeskLocked())
            {
              _Module.SwitchTimerLock.Start();
            }
            else
            {
              _Module.LockWatcher.Start();
              Form_timer mainForm = (Form_timer) _Entrypoint.MyMainForm;
              _Module.MyDelegate myDelegate;
              // ISSUE: reference to a compiler-generated field
              if (_Module._Closure\u0024__.\u0024I83\u002D1 != null)
              {
                // ISSUE: reference to a compiler-generated field
                myDelegate = _Module._Closure\u0024__.\u0024I83\u002D1;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                _Module._Closure\u0024__.\u0024I83\u002D1 = myDelegate = (_Module.MyDelegate) (() => _Module.Desktop.Lock((IWin32Window) MyProject.Forms.Form_lock));
              }
              mainForm.BeginInvoke((Delegate) myDelegate);
            }
          }
        }
      }
    }

    public static bool SendMessage()
    {
      Thread.Sleep(_Module.waitProcmonProcess);
      bool flag = _Module.Communicate.SendMessage(Conversions.ToString(_Module.MyPID), Conversions.ToString(_Module.procPID));
      if (!flag)
      {
        _Module.errorcode = "2";
        _Module.hacked = true;
        if (!_Module.Desktop.IsLocked)
        {
          if (_Module.Desktop.DeskLocked())
          {
            _Module.SwitchTimerLock.Start();
          }
          else
          {
            _Module.LockWatcher.Start();
            Form_timer mainForm = (Form_timer) _Entrypoint.MyMainForm;
            _Module.MyDelegate myDelegate;
            // ISSUE: reference to a compiler-generated field
            if (_Module._Closure\u0024__.\u0024I84\u002D0 != null)
            {
              // ISSUE: reference to a compiler-generated field
              myDelegate = _Module._Closure\u0024__.\u0024I84\u002D0;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              _Module._Closure\u0024__.\u0024I84\u002D0 = myDelegate = (_Module.MyDelegate) (() => _Module.Desktop.Lock((IWin32Window) MyProject.Forms.Form_lock));
            }
            mainForm.BeginInvoke((Delegate) myDelegate);
          }
        }
      }
      return flag;
    }

    public static bool IsValidEmailFormat(string email)
    {
      return Regex.IsMatch(email, "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$");
    }

    public static void SessionEnding(object sender, SessionEndingEventArgs e)
    {
      switch (e.Reason)
      {
        case SessionEndReasons.Logoff:
          _Module.Shutdown.Force();
          break;
        case SessionEndReasons.SystemShutdown:
          _Module.Shutdown.Force();
          break;
      }
    }

    public static void SessionSwitch(object sender, SessionSwitchEventArgs e)
    {
      switch (e.Reason)
      {
        case SessionSwitchReason.RemoteConnect:
          _Module.Shutdown.Force();
          break;
        case SessionSwitchReason.RemoteDisconnect:
          _Module.Shutdown.Force();
          break;
        case SessionSwitchReason.SessionLogoff:
          _Module.Shutdown.Force();
          break;
        case SessionSwitchReason.SessionRemoteControl:
          _Module.Shutdown.Force();
          break;
      }
    }

    public static void SwitchTimerLock_Event(object sender, ElapsedEventArgs e)
    {
      if (_Module.Desktop.DeskLocked())
        return;
      _Module.SwitchTimerLock.Stop();
      _Module.LockWatcher.Start();
      Form_timer mainForm = (Form_timer) _Entrypoint.MyMainForm;
      _Module.MyDelegate myDelegate;
      // ISSUE: reference to a compiler-generated field
      if (_Module._Closure\u0024__.\u0024I88\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        myDelegate = _Module._Closure\u0024__.\u0024I88\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        _Module._Closure\u0024__.\u0024I88\u002D0 = myDelegate = (_Module.MyDelegate) (() => _Module.Desktop.Lock((IWin32Window) MyProject.Forms.Form_lock));
      }
      mainForm.BeginInvoke((Delegate) myDelegate);
    }

    public static void LockWatcher_Event(object sender, ElapsedEventArgs e)
    {
      if (!_Module.Desktop.IsLocked)
        return;
      _Module.Desktop.SwitchLock();
    }

    private static bool VerifyDeviceID(string str)
    {
      return new Regex("[0-9a-f]{32}", RegexOptions.Compiled).IsMatch(str);
    }

    private delegate void MyDelegate();
  }
}
