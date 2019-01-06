// Decompiled with JetBrains decompiler
// Type: coinapp.My.MyProject
// Assembly: coinapp, Version=1.4.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6DB842CC-5810-43FB-8044-475700CA1E42
// Assembly location: C:\Users\EarlJohn\Desktop\Coinapp\coinapp_1.4.0.0\coinapp.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace coinapp.My
{
  [HideModuleName]
  [StandardModule]
  [GeneratedCode("MyTemplate", "8.0.0.0")]
  internal sealed class MyProject
  {
    private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();
    private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();
    private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();
    private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();
    private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

    [DebuggerNonUserCode]
    static MyProject()
    {
    }

    [HelpKeyword("My.Computer")]
    internal static MyComputer Computer
    {
      [DebuggerHidden] get
      {
        return MyProject.m_ComputerObjectProvider.GetInstance;
      }
    }

    [HelpKeyword("My.Application")]
    internal static MyApplication Application
    {
      [DebuggerHidden] get
      {
        return MyProject.m_AppObjectProvider.GetInstance;
      }
    }

    [HelpKeyword("My.User")]
    internal static User User
    {
      [DebuggerHidden] get
      {
        return MyProject.m_UserObjectProvider.GetInstance;
      }
    }

    [HelpKeyword("My.Forms")]
    internal static MyProject.MyForms Forms
    {
      [DebuggerHidden] get
      {
        return MyProject.m_MyFormsObjectProvider.GetInstance;
      }
    }

    [HelpKeyword("My.WebServices")]
    internal static MyProject.MyWebServices WebServices
    {
      [DebuggerHidden] get
      {
        return MyProject.m_MyWebServicesObjectProvider.GetInstance;
      }
    }

    [MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal sealed class MyForms
    {
      public form_account m_form_account;
      public form_account_create m_form_account_create;
      public form_config m_form_config;
      public form_dialog m_form_dialog;
      public form_installer m_form_installer;
      public form_lock m_form_lock;
      public form_login m_form_login;
      public form_main m_form_main;
      public form_use_account m_form_use_account;
      public form_use_voucher m_form_use_voucher;
      public form_voucher m_form_voucher;
      [ThreadStatic]
      private static Hashtable m_FormBeingCreated;

      public form_account form_account
      {
        [DebuggerNonUserCode] get
        {
          this.m_form_account = MyProject.MyForms.Create__Instance__<form_account>(this.m_form_account);
          return this.m_form_account;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_form_account)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<form_account>(ref this.m_form_account);
        }
      }

      public form_account_create form_account_create
      {
        [DebuggerNonUserCode] get
        {
          this.m_form_account_create = MyProject.MyForms.Create__Instance__<form_account_create>(this.m_form_account_create);
          return this.m_form_account_create;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_form_account_create)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<form_account_create>(ref this.m_form_account_create);
        }
      }

      public form_config form_config
      {
        [DebuggerNonUserCode] get
        {
          this.m_form_config = MyProject.MyForms.Create__Instance__<form_config>(this.m_form_config);
          return this.m_form_config;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_form_config)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<form_config>(ref this.m_form_config);
        }
      }

      public form_dialog form_dialog
      {
        [DebuggerNonUserCode] get
        {
          this.m_form_dialog = MyProject.MyForms.Create__Instance__<form_dialog>(this.m_form_dialog);
          return this.m_form_dialog;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_form_dialog)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<form_dialog>(ref this.m_form_dialog);
        }
      }

      public form_installer form_installer
      {
        [DebuggerNonUserCode] get
        {
          this.m_form_installer = MyProject.MyForms.Create__Instance__<form_installer>(this.m_form_installer);
          return this.m_form_installer;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_form_installer)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<form_installer>(ref this.m_form_installer);
        }
      }

      public form_lock form_lock
      {
        [DebuggerNonUserCode] get
        {
          this.m_form_lock = MyProject.MyForms.Create__Instance__<form_lock>(this.m_form_lock);
          return this.m_form_lock;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_form_lock)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<form_lock>(ref this.m_form_lock);
        }
      }

      public form_login form_login
      {
        [DebuggerNonUserCode] get
        {
          this.m_form_login = MyProject.MyForms.Create__Instance__<form_login>(this.m_form_login);
          return this.m_form_login;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_form_login)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<form_login>(ref this.m_form_login);
        }
      }

      public form_main form_main
      {
        [DebuggerNonUserCode] get
        {
          this.m_form_main = MyProject.MyForms.Create__Instance__<form_main>(this.m_form_main);
          return this.m_form_main;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_form_main)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<form_main>(ref this.m_form_main);
        }
      }

      public form_use_account form_use_account
      {
        [DebuggerNonUserCode] get
        {
          this.m_form_use_account = MyProject.MyForms.Create__Instance__<form_use_account>(this.m_form_use_account);
          return this.m_form_use_account;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_form_use_account)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<form_use_account>(ref this.m_form_use_account);
        }
      }

      public form_use_voucher form_use_voucher
      {
        [DebuggerNonUserCode] get
        {
          this.m_form_use_voucher = MyProject.MyForms.Create__Instance__<form_use_voucher>(this.m_form_use_voucher);
          return this.m_form_use_voucher;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_form_use_voucher)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<form_use_voucher>(ref this.m_form_use_voucher);
        }
      }

      public form_voucher form_voucher
      {
        [DebuggerNonUserCode] get
        {
          this.m_form_voucher = MyProject.MyForms.Create__Instance__<form_voucher>(this.m_form_voucher);
          return this.m_form_voucher;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_form_voucher)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<form_voucher>(ref this.m_form_voucher);
        }
      }

      [DebuggerHidden]
      private static T Create__Instance__<T>(T Instance) where T : Form, new()
      {
        if ((object) Instance != null && !Instance.IsDisposed)
          return Instance;
        if (MyProject.MyForms.m_FormBeingCreated != null)
        {
          if (MyProject.MyForms.m_FormBeingCreated.ContainsKey((object) typeof (T)))
            throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
        }
        else
          MyProject.MyForms.m_FormBeingCreated = new Hashtable();
        MyProject.MyForms.m_FormBeingCreated.Add((object) typeof (T), (object) null);
        try
        {
          return new T();
        }
        catch (TargetInvocationException ex) when (
        {
          // ISSUE: unable to correctly present filter
          ProjectData.SetProjectError((Exception) ex);
          if (ex.InnerException != null)
          {
            SuccessfulFiltering;
          }
          else
            throw;
        }
        )
        {
          throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", ex.InnerException.Message), ex.InnerException);
        }
        finally
        {
          MyProject.MyForms.m_FormBeingCreated.Remove((object) typeof (T));
        }
      }

      [DebuggerHidden]
      private void Dispose__Instance__<T>(ref T instance) where T : Form
      {
        instance.Dispose();
        instance = default (T);
      }

      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public MyForms()
      {
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      public override bool Equals(object o)
      {
        return base.Equals(RuntimeHelpers.GetObjectValue(o));
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      public override int GetHashCode()
      {
        return base.GetHashCode();
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      internal new System.Type GetType()
      {
        return typeof (MyProject.MyForms);
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      public override string ToString()
      {
        return base.ToString();
      }
    }

    [MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal sealed class MyWebServices
    {
      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public override bool Equals(object o)
      {
        return base.Equals(RuntimeHelpers.GetObjectValue(o));
      }

      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public override int GetHashCode()
      {
        return base.GetHashCode();
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      [DebuggerHidden]
      internal new System.Type GetType()
      {
        return typeof (MyProject.MyWebServices);
      }

      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public override string ToString()
      {
        return base.ToString();
      }

      [DebuggerHidden]
      private static T Create__Instance__<T>(T instance) where T : new()
      {
        if ((object) instance == null)
          return new T();
        return instance;
      }

      [DebuggerHidden]
      private void Dispose__Instance__<T>(ref T instance)
      {
        instance = default (T);
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      [DebuggerHidden]
      public MyWebServices()
      {
      }
    }

    [ComVisible(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal sealed class ThreadSafeObjectProvider<T> where T : new()
    {
      internal T GetInstance
      {
        [DebuggerHidden] get
        {
          if ((object) MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null)
            MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = new T();
          return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
        }
      }

      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public ThreadSafeObjectProvider()
      {
      }
    }
  }
}
