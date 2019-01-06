// Decompiled with JetBrains decompiler
// Type: Coinapp._Entrypoint
// Assembly: Coinapp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: ED4B7D1C-BF2E-4AAF-8FCA-FEC188D22124
// Assembly location: C:\Users\EarlJohn\Desktop\Coinapp\Coinapp.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Coinapp
{
  [StandardModule]
  internal sealed class _Entrypoint
  {
    public static Form MyMainForm;

    [STAThread]
    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    public static void Main(string[] args)
    {
      Application.SetCompatibleTextRenderingDefault(true);
      new _applicationFramework().Run(args);
    }
  }
}
