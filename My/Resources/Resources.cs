// Decompiled with JetBrains decompiler
// Type: coinapp.My.Resources.Resources
// Assembly: coinapp, Version=1.4.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6DB842CC-5810-43FB-8044-475700CA1E42
// Assembly location: C:\Users\EarlJohn\Desktop\Coinapp\coinapp_1.4.0.0\coinapp.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace coinapp.My.Resources
{
  [HideModuleName]
  [CompilerGenerated]
  [StandardModule]
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [DebuggerNonUserCode]
  internal sealed class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (object.ReferenceEquals((object) coinapp.My.Resources.Resources.resourceMan, (object) null))
          coinapp.My.Resources.Resources.resourceMan = new ResourceManager("coinapp.Resources", typeof (coinapp.My.Resources.Resources).Assembly);
        return coinapp.My.Resources.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get
      {
        return coinapp.My.Resources.Resources.resourceCulture;
      }
      set
      {
        coinapp.My.Resources.Resources.resourceCulture = value;
      }
    }
  }
}
