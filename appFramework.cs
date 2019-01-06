// Decompiled with JetBrains decompiler
// Type: coinapp.appFramework
// Assembly: coinapp, Version=1.4.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6DB842CC-5810-43FB-8044-475700CA1E42
// Assembly location: C:\Users\EarlJohn\Desktop\Coinapp\coinapp_1.4.0.0\coinapp.exe

using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace coinapp
{
  public class appFramework : WindowsFormsApplicationBase
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();

    [DebuggerNonUserCode]
    static appFramework()
    {
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (appFramework.__ENCList)
      {
        if (appFramework.__ENCList.Count == appFramework.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (appFramework.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (appFramework.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                appFramework.__ENCList[index1] = appFramework.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          appFramework.__ENCList.RemoveRange(index1, checked (appFramework.__ENCList.Count - index1));
          appFramework.__ENCList.Capacity = appFramework.__ENCList.Count;
        }
        appFramework.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
      }
    }

    public appFramework(Form main)
      : base(AuthenticationMode.Windows)
    {
      appFramework.__ENCAddToList((object) this);
      this.EnableVisualStyles = true;
      this.IsSingleInstance = false;
      this.ShutdownStyle = ShutdownMode.AfterAllFormsClose;
      this.MainForm = main;
    }
  }
}
