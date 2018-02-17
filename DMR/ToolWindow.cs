using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace DMR
{
	public class ToolWindow : DockContent
	{
		//private IContainer components;

		public ToolWindow()
		{
			Class21.mKf3Qywz2M1Yy();
			//base._002Ector();
			this.method_0();
			base.Scale(Class15.smethod_6());
		}

		protected override void Dispose(bool disposing)
		{
            /*
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}*/
			base.Dispose(disposing);
		}

		private void method_0()
		{
			base.SuspendLayout();
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(292, 246);
			base.DockAreas = (DockAreas.Float | DockAreas.DockLeft | DockAreas.DockRight | DockAreas.DockTop | DockAreas.DockBottom);
			this.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
			base.HideOnClose = true;
			base.Name = "ToolWindow";
			base.TabText = "ToolWindow";
			this.Text = "ToolWindow";
			base.ResumeLayout(false);
		}
	}
}
