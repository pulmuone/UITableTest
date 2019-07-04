using Foundation;
using System;
using System.Drawing;
using UIKit;

namespace UITableTest
{
    public partial class EmployeeCell : UITableViewCell
    {
        public EmployeeCell (IntPtr handle) : base (handle)
        {

        }

        internal void UpdateCell(Employee employee)
        {
            BarcodeLabel.Text = employee.Barcode;
            ProductNameLabel.Text = employee.ProductName;
            OrderQtyText.Text = employee.OrderQty;
            OrderQtyText.EnablesReturnKeyAutomatically = true;
            OrderQtyText.KeyboardType = UIKeyboardType.NumberPad;
            OrderQtyText.ReturnKeyType = UIReturnKeyType.Done;


            OrderQtyText.ShouldReturn += (textField) =>
            {
                textField.ResignFirstResponder();
                return true;
            };

            PlusButton.TouchUpInside += (sender, e) =>
            {
                OrderQtyText.Text = (Convert.ToInt32(OrderQtyText.Text.Trim()) + 1).ToString();
                OrderQtyText.ResignFirstResponder();
            };

            MinusButton.TouchUpInside += (sender, e) =>
            {
                OrderQtyText.Text = (Convert.ToInt32(OrderQtyText.Text.Trim()) - 1).ToString();
                OrderQtyText.ResignFirstResponder();
            };


            // create the toolbar
            var toolbar = new UIToolbar(new RectangleF(0.0f, 0.0f, 50.0f, 44.0f));
            toolbar.Translucent = true;

            toolbar.Items = new[]
                 {
                new UIBarButtonItem(UIBarButtonSystemItem.FlexibleSpace),
                new UIBarButtonItem(UIBarButtonSystemItem.Done,
                    (sender, args) =>
                    {
                        OrderQtyText.ResignFirstResponder();
                    }),
            };

            // fill the screen width
            toolbar.SizeToFit();

            // set the accessory
            OrderQtyText.InputAccessoryView = toolbar;

        }

        public EventHandler Return;
    }
}