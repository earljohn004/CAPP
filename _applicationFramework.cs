// Decompiled with JetBrains decompiler
// Type: Coinapp._applicationFramework
// Assembly: Coinapp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: ED4B7D1C-BF2E-4AAF-8FCA-FEC188D22124
// Assembly location: C:\Users\EarlJohn\Desktop\Coinapp\Coinapp.exe

using Coinapp.My;
using Microsoft.VisualBasic.ApplicationServices;
using Settings;
using System.Windows.Forms;

namespace Coinapp
{
  public class _applicationFramework : WindowsFormsApplicationBase
  {
    private Config _Config;

    public _applicationFramework()
      : base(AuthenticationMode.Windows)
    {
      this._Config = new Config();
      this.EnableVisualStyles = true;
      this.IsSingleInstance = true;
      this.ShutdownStyle = ShutdownMode.AfterAllFormsClose;
      _Entrypoint.MyMainForm = this._Config.Exists() && !this._Config.FirstTimeUse() ? (Form) MyProject.Forms.Form_timer : (Form) MyProject.Forms.Form_startup;
      this.MainForm = _Entrypoint.MyMainForm;
    }

    protected override void OnStartupNextInstance(StartupNextInstanceEventArgs eventArgs)
    {
      base.OnStartupNextInstance(eventArgs);
      int num = (int) MessageBox.Show("Application is alrealy running.", "Coinapp", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }
  }
}
