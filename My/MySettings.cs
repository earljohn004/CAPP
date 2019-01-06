// Decompiled with JetBrains decompiler
// Type: coinapp.My.MySettings
// Assembly: coinapp, Version=1.4.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6DB842CC-5810-43FB-8044-475700CA1E42
// Assembly location: C:\Users\EarlJohn\Desktop\Coinapp\coinapp_1.4.0.0\coinapp.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace coinapp.My
{
  [CompilerGenerated]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal sealed class MySettings : ApplicationSettingsBase
  {
    private static MySettings defaultInstance = (MySettings) SettingsBase.Synchronized((SettingsBase) new MySettings());

    [DebuggerNonUserCode]
    public MySettings()
    {
    }

    public static MySettings Default
    {
      get
      {
        MySettings defaultInstance = MySettings.defaultInstance;
        return defaultInstance;
      }
    }
  }
}
