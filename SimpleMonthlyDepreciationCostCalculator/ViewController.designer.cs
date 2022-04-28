// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace SimpleMonthlyDepreciationCostCalculator
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField MonthlyCostLabel { get; set; }

		[Outlet]
		AppKit.NSTextField OperatingTimeTextBox { get; set; }

		[Outlet]
		AppKit.NSTextField PurchaseValueTextbox { get; set; }

		[Outlet]
		AppKit.NSTextField ResidualValueTextbox { get; set; }

		[Action ("ClickedCalculate:")]
		partial void ClickedCalculate (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (MonthlyCostLabel != null) {
				MonthlyCostLabel.Dispose ();
				MonthlyCostLabel = null;
			}

			if (OperatingTimeTextBox != null) {
				OperatingTimeTextBox.Dispose ();
				OperatingTimeTextBox = null;
			}

			if (PurchaseValueTextbox != null) {
				PurchaseValueTextbox.Dispose ();
				PurchaseValueTextbox = null;
			}

			if (ResidualValueTextbox != null) {
				ResidualValueTextbox.Dispose ();
				ResidualValueTextbox = null;
			}
		}
	}
}
