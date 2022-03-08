// Decompiled with JetBrains decompiler
// Type: Sipaa.Framework.SDragControl
// Assembly: SipaaFramework, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2E6ACA98-543B-4B66-84B9-8C1EA6BCB548
// Assembly location: C:\Users\pc2\AppData\Local\Temp\Canumyl\40d4f05453\lib\net46\SipaaFramework.dll

using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Sipaa.Framework
{
  public class SDragControl : Component
  {
    private Control controler;

    [DllImport("user32.dll")]
    private static extern int SendMessage(IntPtr o, int msg, int wParams, int IParam);

    [DllImport("user32.dll")]
    public static extern bool ReleaseCapture();

    public Control TargetControl
    {
      get => this.controler;
      set
      {
        this.controler = value;
        this.controler.MouseDown += new MouseEventHandler(this.Controler_MouseDown);
      }
    }

    private void Controler_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      SDragControl.ReleaseCapture();
      SDragControl.SendMessage(this.TargetControl.FindForm().Handle, 161, 2, 0);
    }
  }
}
