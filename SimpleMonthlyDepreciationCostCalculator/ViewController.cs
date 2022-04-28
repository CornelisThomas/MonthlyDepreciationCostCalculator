using System;

using AppKit;
using Foundation;

namespace SimpleMonthlyDepreciationCostCalculator
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }
        partial void ClickedCalculate(NSObject sender)
        {

            if ( !isStringNumericAndNonNegative(PurchaseValueTextbox.StringValue) )
            {
                // make purchase value text box red
                PurchaseValueTextbox.BackgroundColor = NSColor.Red;
            }
            else
            {
                PurchaseValueTextbox.BackgroundColor = NSColor.White;
            }

            if ( !isStringNumericAndNonNegative(ResidualValueTextbox.StringValue) )
            {
                // make residual text box red
                ResidualValueTextbox.BackgroundColor = NSColor.Red;
            }
            else
            {
                ResidualValueTextbox.BackgroundColor = NSColor.White;
            }

            if ( !isStringNumericAndNonNegative(OperatingTimeTextBox.StringValue) )
            {
                // make operating time text box red
                OperatingTimeTextBox.BackgroundColor = NSColor.Red;
            }
            else
            {
                OperatingTimeTextBox.BackgroundColor = NSColor.White;
            }

            if (isStringNumericAndNonNegative(PurchaseValueTextbox.StringValue) && isStringNumericAndNonNegative(ResidualValueTextbox.StringValue) && isStringNumericAndNonNegative(OperatingTimeTextBox.StringValue))
            {
                double dPurchaseValue, dResidualValue, dOperatingTime = 0;

                // convert textbox strings to double values
                dPurchaseValue = PurchaseValueTextbox.DoubleValue;
                dResidualValue = ResidualValueTextbox.DoubleValue;
                dOperatingTime = OperatingTimeTextBox.DoubleValue;
                
                // calculate depreciation, +number = cost, -number = profit
                double monthlyDepreciationCost = (dPurchaseValue - dResidualValue) / dOperatingTime;
                if (monthlyDepreciationCost > 0)
                {
                    MonthlyCostLabel.StringValue = "Monthly cost: " + Math.Round(monthlyDepreciationCost, 2).ToString();
                }
                else if (monthlyDepreciationCost == 0)
                {
                    MonthlyCostLabel.StringValue = "Monthly cost: 0 (nothing)";
                }
                else
                {
                    MonthlyCostLabel.StringValue = "Monthly profit: " + Math.Round(Math.Abs(monthlyDepreciationCost), 2).ToString();
                }
            }
        }

        bool isStringNumericAndNonNegative(string stringvalue)
        {
            double val;
            bool isNumeric = double.TryParse(stringvalue, out val);
            if (isNumeric)
            {
                if (val >= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }
    }
}
