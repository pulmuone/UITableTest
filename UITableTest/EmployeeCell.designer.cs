// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace UITableTest
{
    [Register ("EmployeeCell")]
    partial class EmployeeCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel BarcodeLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton MinusButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField OrderQtyText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton PlusButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel ProductNameLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (BarcodeLabel != null) {
                BarcodeLabel.Dispose ();
                BarcodeLabel = null;
            }

            if (MinusButton != null) {
                MinusButton.Dispose ();
                MinusButton = null;
            }

            if (OrderQtyText != null) {
                OrderQtyText.Dispose ();
                OrderQtyText = null;
            }

            if (PlusButton != null) {
                PlusButton.Dispose ();
                PlusButton = null;
            }

            if (ProductNameLabel != null) {
                ProductNameLabel.Dispose ();
                ProductNameLabel = null;
            }
        }
    }
}