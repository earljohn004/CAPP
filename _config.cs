// Decompiled with JetBrains decompiler
// Type: Coinapp._config
// Assembly: Coinapp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: ED4B7D1C-BF2E-4AAF-8FCA-FEC188D22124
// Assembly location: C:\Users\EarlJohn\Desktop\Coinapp\Coinapp.exe

using Settings;

namespace Coinapp
{
  public class _config
  {
    public Config c;
    public string PortName;
    public int BaudRate;
    public bool AtStartup;
    public bool Taskmgr;
    public bool Protect;
    public bool DisconnectLock;
    public bool PlaySound;
    public bool Play5SecVoice;
    public int CoinSound;
    public int TimeSound;
    public string CoinAcceptor;
    public int TimeToShut;
    public int LoginRetry;
    public int MainKeycode;
    public int Coin1;
    public int Coin2;
    public int Coin3;
    public int Pulse1;
    public int Pulse2;
    public int Pulse3;
    public string NotifyCoin1;
    public string NotifyCoin2;
    public string NotifyCoin3;
    public int Notify1;
    public int Notify2;
    public int Notify1sec;
    public int Notify2sec;
    public string NotifyMessage1;
    public string NotifyMessage2;
    public string StartupTitle;
    public string StartupMsg;
    public string StartupColor;
    public string TimesupTitle;
    public string TimesupMsg;
    public string TimesupColor;
    public string UserLogoutTitle;
    public string UserLogoutMsg;
    public string UserLogoutColor;
    public string StartupSubKey;
    public bool SaveData;
    public bool Beep;
    public int BeepCoinFreq;
    public int BeepCoinDur;
    public int BeepTime;
    public int BeepTimeRep;
    public int BeepTimeFreq;
    public int BeepTimeDur;
    public int BeepLockRep;
    public int BeepLockFreq;
    public int BeepLockDur;
    public bool BeepShut;
    public int BeepShutFreq;
    public int BeepShutDur;
    public bool CustomizeLock;
    public string BackgroundImage;
    public string BackgroundImageLayout;
    public string ControlPosition;
    public bool ControlTransparent;
    public string ControlBGColor;
    public string InitializeColor;
    public string DeviceProblemColor;
    public string ShutdownTimeColor;
    public bool AdvanceCustomization;
    public string WaitForProcmon;

    public _config()
    {
      this.c = new Config();
      this.CoinSound = -1;
      this.TimeSound = -1;
      this.AtStartup = this.c.AtStartUp();
      this.Taskmgr = this.c.Taskmgr();
      if (this.AtStartup)
      {
        if (!this.c.CheckStartupRegistry())
          this.c.SetStartupRegValue();
        else if (!this.c.CheckStartupValue())
          this.c.SetStartupRegValue();
      }
      else if (this.c.CheckStartupRegistry())
        this.c.DelStartupRegValue();
      if (this.Taskmgr)
      {
        if (!this.c.CheckTaskmgrRegValue())
          this.c.SetTaskmgrRegValue();
      }
      else if (this.c.CheckTaskmgrRegValue())
        this.c.DelTaskmgrRegValue();
      this.SaveData = this.c.SaveData();
      this.PlaySound = this.c.PlaySound();
      this.Play5SecVoice = this.c.Play5SecVoice();
      this.CoinSound = this.c.CoinSound();
      this.DisconnectLock = this.c.DisconnectLock();
      this.TimeSound = this.c.TimeSound();
      this.PortName = this.c.PortName();
      this.BaudRate = this.c.BaudRate();
      this.Coin1 = this.c.Coin1();
      this.Coin2 = this.c.Coin2();
      this.Coin3 = this.c.Coin3();
      this.Pulse1 = this.c.Pulse1();
      this.Pulse2 = this.c.Pulse2();
      this.Pulse3 = this.c.Pulse3();
      this.CoinAcceptor = this.c.CoinAcceptor();
      this.LoginRetry = this.c.LoginRetry();
      this.TimeToShut = this.c.TimeToShut();
      this.MainKeycode = this.c.Keycode();
      this.NotifyCoin1 = this.c.NotifyCoin1();
      this.NotifyCoin2 = this.c.NotifyCoin2();
      this.NotifyCoin3 = this.c.NotifyCoin3();
      this.Notify1 = this.c.Notify1();
      this.Notify2 = this.c.Notify2();
      this.Notify1sec = this.c.Notify1Sec();
      this.Notify2sec = this.c.Notify2Sec();
      this.NotifyMessage1 = this.c.NotifyMessage1();
      this.NotifyMessage2 = this.c.NotifyMessage2();
      this.StartupTitle = this.c.StartupTitle();
      this.StartupMsg = this.c.StartupMsg();
      this.StartupColor = this.c.StartupColor();
      this.TimesupTitle = this.c.TimesupTitle();
      this.TimesupMsg = this.c.TimesupMsg();
      this.TimesupColor = this.c.TimesupColor();
      this.UserLogoutTitle = this.c.UserLogoutTitle();
      this.UserLogoutMsg = this.c.UserLogoutMsg();
      this.UserLogoutColor = this.c.UserLogoutColor();
      this.Protect = this.c.Protect();
      this.StartupSubKey = this.c.StartupSubKey();
      this.Beep = _Module.Config.Beep();
      this.BeepCoinFreq = _Module.Config.BeepCoinFreq();
      this.BeepCoinDur = _Module.Config.BeepCoinDur();
      this.BeepTime = _Module.Config.BeepTime();
      this.BeepTimeRep = _Module.Config.BeepTimeRep();
      this.BeepTimeFreq = _Module.Config.BeepTimeFreq();
      this.BeepTimeDur = _Module.Config.BeepTimeDur();
      this.BeepLockRep = _Module.Config.BeepLockRep();
      this.BeepLockFreq = _Module.Config.BeepLockFreq();
      this.BeepLockDur = _Module.Config.BeepLockDur();
      this.BeepShut = _Module.Config.BeepShut();
      this.BeepShutFreq = _Module.Config.BeepShutFreq();
      this.BeepShutDur = _Module.Config.BeepShutDur();
      this.CustomizeLock = this.c.CustomizeLock();
      this.BackgroundImage = this.c.BGImage();
      this.BackgroundImageLayout = this.c.BGImageLayout();
      this.ControlPosition = this.c.ControlPosition();
      this.ControlTransparent = this.c.ControlTransparent();
      this.ControlBGColor = this.c.ControlBGColor();
      this.InitializeColor = this.c.InitializeColor();
      this.DeviceProblemColor = this.c.DeviceProblemColor();
      this.ShutdownTimeColor = this.c.ShutdownTimeColor();
      this.AdvanceCustomization = this.c.AdvanceCustomization();
      this.WaitForProcmon = this.c.WaitForProcmon();
    }
  }
}
