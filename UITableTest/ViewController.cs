using Foundation;
using System;
using System.Collections.Generic;
using UIKit;

namespace UITableTest
{
    public partial class ViewController : UIViewController
    {
        public ViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();
            // Perform any additional setup after loading the view, typically from a nib.

            var employees = new List<Employee>
            {
                new Employee
                {
                    Barcode= "12345",
                    ProductName ="신라면 매운맛",
                    OrderQty = "12"                    
                },
                new Employee
                {
                    Barcode= "54321",
                    ProductName ="코카콜라 1.8L",
                    OrderQty = "24"
                },
                new Employee
                {
                    Barcode= "67890",
                    ProductName ="서울우유 250ml",
                    OrderQty = "7"
                }
            };

            EmployeesTableView.Source = new EmployeesTVS(employees);
            //EmployeesTableView.RowHeight = UITableView.AutomaticDimension;
            EmployeesTableView.RowHeight = 50f;
            //EmployeesTableView.EstimatedRowHeight = 120f;
            EmployeesTableView.ReloadData();
        }

        public override void DidReceiveMemoryWarning ()
        {
            base.DidReceiveMemoryWarning ();
            // Release any cached data, images, etc that aren't in use.
        }
    }

}