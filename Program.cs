// Decompiled with JetBrains decompiler
// Type: AloSpeedportKeyGen.Program
// Assembly: AloSpeedportKeyGen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3589E960-AABA-43FA-9244-B9F2FC9AD634
// Assembly location: C:\Users\snofl\Downloads\AloSpeedportKeyGen.exe

using System;
using System.Windows.Forms;

//#nullable disable
namespace AloSpeedportKeyGen
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new Form1());
    }
  }
}
