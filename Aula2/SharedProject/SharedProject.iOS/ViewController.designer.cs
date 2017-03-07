// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace SharedProject.iOS
{
    [Register("ViewController")]
    partial class ViewController
    {
        [Outlet]
        UIKit.UILabel textfield { get; set; }

        void ReleaseDesignerOutlets()
        {
            if (textfield != null)
            {
                textfield.Dispose();
                textfield = null;
            }
        }
    }
}
