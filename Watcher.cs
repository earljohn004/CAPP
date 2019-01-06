// Decompiled with JetBrains decompiler
// Type: Coinapp.Watcher
// Assembly: Coinapp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: ED4B7D1C-BF2E-4AAF-8FCA-FEC188D22124
// Assembly location: C:\Users\EarlJohn\Desktop\Coinapp\Coinapp.exe

using System.Windows.Forms;

namespace Coinapp
{
  public class Watcher : NativeWindow
  {
    public event Watcher.WatchEventHandler Watch;

    public Watcher()
    {
      this.CreateHandle(new CreateParams());
    }

    protected override void WndProc(ref Message m)
    {
      if (m.Msg == 17)
        base.WndProc(ref new Message() { Msg = 31 });
      else
        base.WndProc(ref m);
    }

    public delegate void WatchEventHandler(ref Message m);
  }
}
