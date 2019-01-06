// Decompiled with JetBrains decompiler
// Type: coinapp.entrypoint
// Assembly: coinapp, Version=1.4.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6DB842CC-5810-43FB-8044-475700CA1E42
// Assembly location: C:\Users\EarlJohn\Desktop\Coinapp\coinapp_1.4.0.0\coinapp.exe

using coinapp.My;
using coinapplib;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.ServiceProcess;
using System.Windows.Forms;

namespace coinapp
{
  [StandardModule]
  internal sealed class entrypoint
  {
    [STAThread]
    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    public static void Main(string[] args)
    {
      Application.SetCompatibleTextRenderingDefault(true);
      if (args.Length > 0)
      {
        string Left = args[0];
        appFramework appFramework;
        if (Operators.CompareString(Left, "-vouchers", false) == 0)
        {
          if (args.Length < 2)
          {
            int num1 = (int) Interaction.MsgBox((object) "No additional password in arguments.", MsgBoxStyle.Critical, (object) "Voucher Manager");
          }
          else
          {
            bool flag1 = coinappMods.settings.XconfigExist(coinappMods.enc.GetMd5Hash("password"));
            bool flag2 = coinappMods.settings.XconfigExist(coinappMods.enc.GetMd5Hash("email"));
            if (flag1 && flag2)
              goto label_6;
label_5:
            int num2 = (int) Interaction.MsgBox((object) "Cannot open Voucher Manager. Application is not configured", MsgBoxStyle.Critical, (object) "Voucher Manager");
            return;
label_6:
            string str;
            try
            {
              str = coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("password")), "password");
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              str = "";
              ProjectData.ClearProjectError();
            }
            if (Operators.CompareString(str, "", false) != 0)
            {
              if (Operators.CompareString(args[1], str, false) != 0)
              {
                int num3 = (int) Interaction.MsgBox((object) "Password is incorrect.", MsgBoxStyle.Critical, (object) "Voucher Manager");
              }
              else
                new appFramework((Form) MyProject.Forms.form_voucher).Run(args);
            }
            else
              goto label_5;
          }
        }
        else if (Operators.CompareString(Left, "-accounts", false) == 0)
        {
          if (args.Length < 2)
          {
            int num4 = (int) Interaction.MsgBox((object) "No additional password in arguments.", MsgBoxStyle.Critical, (object) "Account Manager");
          }
          else
          {
            bool flag1 = coinappMods.settings.XconfigExist(coinappMods.enc.GetMd5Hash("password"));
            bool flag2 = coinappMods.settings.XconfigExist(coinappMods.enc.GetMd5Hash("email"));
            if (flag1 && flag2)
              goto label_18;
label_17:
            int num2 = (int) Interaction.MsgBox((object) "Cannot open Account Manager. Application is not configured", MsgBoxStyle.Critical, (object) "Account Manager");
            return;
label_18:
            string str;
            try
            {
              str = coinappMods.enc.Decrypt(coinappMods.settings.readEncSysFile(coinappMods.enc.GetMd5Hash("password")), "password");
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              str = "";
              ProjectData.ClearProjectError();
            }
            if (Operators.CompareString(str, "", false) != 0)
            {
              if (Operators.CompareString(args[1], str, false) != 0)
              {
                int num3 = (int) Interaction.MsgBox((object) "Password is incorrect.", MsgBoxStyle.Critical, (object) "Account Manager");
              }
              else
                new appFramework((Form) MyProject.Forms.form_account).Run(args);
            }
            else
              goto label_17;
          }
        }
        else if (Operators.CompareString(Left, "-install", false) == 0)
          new appFramework((Form) MyProject.Forms.form_installer).Run(args);
        else if (Operators.CompareString(Left, "-lock", false) == 0)
        {
          appFramework = new appFramework((Form) MyProject.Forms.form_lock);
          coinappMods.LOCKCODE = 2;
          coinappMods.ERR_APPS = Conversions.ToInteger(args[1]);
          if (args.Length == 3)
            coinappMods.svccaProcID = Conversions.ToInteger(args[2]);
          coinappMods.desktop.Lock((IWin32Window) MyProject.Forms.form_lock);
        }
        else if (Operators.CompareString(Left, "-switch", false) == 0)
        {
          string lpszDesktop1 = "default";
          IntPtr desktop1 = desktop.OpenDesktop(ref lpszDesktop1, 0, false, 33948033);
          if (desktop1 == IntPtr.Zero)
          {
            entrypoint.WriteEvent("ERROR: No default desktop handle", EventLogEntryType.Error);
            lpszDesktop1 = "default";
            ref string local1 = ref lpszDesktop1;
            string lpszDesktop2 = (string) null;
            ref string local2 = ref lpszDesktop2;
            IntPtr num2;
            IntPtr devmode = num2;
            IntPtr lpsa = num2;
            IntPtr desktop2 = desktop.CreateDesktop(ref local1, ref local2, devmode, 1, 268435456, lpsa);
            if (desktop2 == IntPtr.Zero)
            {
              entrypoint.WriteEvent("ERROR: Creating default desktop", EventLogEntryType.Error);
            }
            else
            {
              entrypoint.WriteEvent("SUCCESS: Creating default desktop. The handle is " + desktop2.ToString(), EventLogEntryType.Information);
              if (!desktop.SwitchDesktop(desktop1))
              {
                entrypoint.WriteEvent("ERROR: Switching to default desktop", EventLogEntryType.Error);
              }
              else
              {
                entrypoint.WriteEvent("SUCCESS: Switching to default desktop", EventLogEntryType.Information);
                lpszDesktop2 = "coinapp";
                IntPtr desktop3 = desktop.OpenDesktop(ref lpszDesktop2, 0, false, 33948033);
                if (desktop3 == IntPtr.Zero)
                {
                  entrypoint.WriteEvent("INFORMATION: No coinapp desktop opened", EventLogEntryType.Information);
                }
                else
                {
                  entrypoint.WriteEvent("INFORMATION: Coinapp desktop alive. The handle is " + desktop3.ToString(), EventLogEntryType.Information);
                  if (!desktop.CloseDesktop(desktop3))
                    entrypoint.WriteEvent("ERROR: Closing coinapp desktop", EventLogEntryType.Error);
                  else
                    entrypoint.WriteEvent("SUCCESS: Closing coinapp desktop", EventLogEntryType.Information);
                }
              }
            }
          }
          else
          {
            entrypoint.WriteEvent("SUCCESS: Retrieving default desktop. The handle is " + desktop1.ToString(), EventLogEntryType.Information);
            if (!desktop.SwitchDesktop(desktop1))
            {
              entrypoint.WriteEvent("ERROR: Switching to default desktop", EventLogEntryType.Error);
            }
            else
            {
              entrypoint.WriteEvent("SUCCESS: Switching to default desktop", EventLogEntryType.Information);
              string lpszDesktop2 = "coinapp";
              IntPtr desktop2 = desktop.OpenDesktop(ref lpszDesktop2, 0, false, 33948033);
              if (desktop2 == IntPtr.Zero)
              {
                entrypoint.WriteEvent("INFORMATION: No coinapp desktop opened", EventLogEntryType.Information);
              }
              else
              {
                entrypoint.WriteEvent("INFORMATION: Coinapp desktop alive. The handle is " + desktop2.ToString(), EventLogEntryType.Information);
                if (!desktop.CloseDesktop(desktop2))
                  entrypoint.WriteEvent("ERROR: Closing coinapp desktop", EventLogEntryType.Error);
                else
                  entrypoint.WriteEvent("SUCCESS: Closing coinapp desktop", EventLogEntryType.Information);
              }
            }
          }
        }
        else if (Operators.CompareString(Left, "-start", false) == 0)
        {
          if (args.Length == 1)
          {
            appFramework = new appFramework((Form) MyProject.Forms.form_lock);
            coinappMods.LOCKCODE = 2;
            coinappMods.ERR_APPS = 5;
            coinappMods.desktop.Lock((IWin32Window) MyProject.Forms.form_lock);
          }
          else
          {
            string s = args[1];
            int num2 = 0;
            ref int local = ref num2;
            if (int.TryParse(s, out local))
            {
              coinappMods.svccaProcID = Conversions.ToInteger(args[1]);
              try
              {
                coinappMods.svccaProc = Process.GetProcessById(coinappMods.svccaProcID);
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                appFramework = new appFramework((Form) MyProject.Forms.form_lock);
                coinappMods.LOCKCODE = 2;
                coinappMods.ERR_APPS = 7;
                coinappMods.desktop.Lock((IWin32Window) MyProject.Forms.form_lock);
                ProjectData.ClearProjectError();
                return;
              }
              new appFramework((Form) MyProject.Forms.form_main).Run(args);
            }
            else
            {
              appFramework = new appFramework((Form) MyProject.Forms.form_lock);
              coinappMods.LOCKCODE = 2;
              coinappMods.ERR_APPS = 6;
              coinappMods.desktop.Lock((IWin32Window) MyProject.Forms.form_lock);
            }
          }
        }
        else
        {
          int num5 = (int) MessageBox.Show("Error command line", "Coinapp", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
      else
      {
        appFramework appFramework = new appFramework((Form) MyProject.Forms.form_installer);
        if (((IEnumerable<ServiceController>) ServiceController.GetServices()).Any<ServiceController>((Func<ServiceController, bool>) (x => Operators.CompareString(x.ServiceName, "svcca", false) == 0)))
        {
          if (Directory.Exists(coinappMods.settings.systemFolder))
          {
            if (coinappMods.settings.XconfigExist(coinappMods.enc.GetMd5Hash("password")) && coinappMods.settings.XconfigExist(coinappMods.enc.GetMd5Hash("email")))
            {
              using (ServiceController serviceController = new ServiceController("svcca"))
              {
                switch (serviceController.Status)
                {
                  case ServiceControllerStatus.Stopped:
                    if (MessageBox.Show("Coinapp service is not running.\r\nDo you want to start the service to run the program?", "Coinapp", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                    {
                      serviceController.Start();
                      serviceController.WaitForStatus(ServiceControllerStatus.Running);
                      break;
                    }
                    break;
                  case ServiceControllerStatus.Running:
                    if (((IEnumerable<Process>) Process.GetProcessesByName("coinapp")).Count<Process>() < 2)
                    {
                      if (MessageBox.Show("Coinapp service is running but the program is not. \r\nDo you want to restart the service to start the program?", "Coinapp", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand) == DialogResult.OK)
                      {
                        serviceController.Stop();
                        serviceController.WaitForStatus(ServiceControllerStatus.Stopped);
                        serviceController.Start();
                        serviceController.WaitForStatus(ServiceControllerStatus.Running);
                      }
                    }
                    else
                    {
                      int num = (int) MessageBox.Show("All coinapp components are running", "Coinapp", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    break;
                }
              }
            }
            else
              appFramework.Run(args);
          }
          else
            appFramework.Run(args);
        }
        else
          appFramework.Run(args);
      }
    }

    private static void WriteEvent(string EventMessage, EventLogEntryType EntryType)
    {
      if (!EventLog.SourceExists("Coinapp"))
        EventLog.CreateEventSource("Coinapp", "System");
      EventLog.WriteEntry("Coinapp", EventMessage, EntryType);
    }
  }
}
