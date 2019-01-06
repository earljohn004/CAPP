// Decompiled with JetBrains decompiler
// Type: coinapp.config
// Assembly: coinapp, Version=1.4.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6DB842CC-5810-43FB-8044-475700CA1E42
// Assembly location: C:\Users\EarlJohn\Desktop\Coinapp\coinapp_1.4.0.0\coinapp.exe

using coinapplib;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;

namespace coinapp
{
  public class config
  {
    private settings setting;
    public string port;
    public int baud;
    public int coin1;
    public int pulse1;
    public int coin2;
    public int pulse2;
    public int coin3;
    public int pulse3;
    public int coin4;
    public int pulse4;
    public int coin5;
    public int pulse5;
    public int coin6;
    public int pulse6;
    public int acceptor;
    public int shutdown;
    public int retryLog;
    public int keycode;
    public int taskmgr;
    public int pause;
    public int data;
    public int voucher;
    public int account;

    public config()
    {
      this.setting = new settings();
      try
      {
        this.port = this.setting.port();
        this.baud = this.setting.baud();
        this.coin1 = this.setting.coin1();
        this.pulse1 = this.setting.pulse1();
        this.coin2 = this.setting.coin2();
        this.pulse2 = this.setting.pulse2();
        this.coin3 = this.setting.coin3();
        this.pulse3 = this.setting.pulse3();
        this.acceptor = this.setting.acceptor();
        this.shutdown = this.setting.shutdown();
        this.retryLog = this.setting.retryLog();
        this.keycode = this.setting.keycode();
        this.taskmgr = this.setting.taskmgr();
        this.pause = this.setting.pause();
        this.data = this.setting.data();
        this.voucher = this.setting.voucher();
        this.account = this.setting.account();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) ex.Message, MsgBoxStyle.Critical, (object) null);
        ProjectData.ClearProjectError();
      }
    }
  }
}
