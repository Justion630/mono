//
// System.Windows.Forms.ScrollableControl.cs
//
// Author:
//   Miguel de Icaza (miguel@ximian.com)
//   stubbed out by Daniel Carrera (dcarrera@math.toronto.edu)
//   ScrollableControl.DockPaddingEdges stub added by Jaak Simm (jaaksimm@firm.ee)
//	Dennis Hayes (dennish@raytek.com)
//   WINELib implementation started by John Sohn (jsohn@columbus.rr.com)
//	CE Complete.
// (C) 2002/3 Ximian, Inc
//

//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Drawing;
using System.ComponentModel;
namespace System.Windows.Forms {

	public class ScrollableControl : Control {

		private ScrollableControl.DockPaddingEdges dockPadding;
		protected  const int ScrollStateAutoScrolling = 1;
		protected  const int ScrollStateFullDrag = 16;
		protected  const int ScrollStateHScrollVisible = 2;
		
		protected  const int ScrollStateUserHasScrolled = 8;
		protected  const int ScrollStateVScrollVisible = 4;


		//
		//  --- Constructor
		//
		public ScrollableControl () : base () {
			base.SetStyle(ControlStyles.ContainerControl, true);
			dockPadding = new ScrollableControl.DockPaddingEdges();
			TabStop = false;
		}

		//
		//  --- Public Properties
		//
		[MonoTODO]
		public virtual bool AutoScroll {
			get {
				throw new NotImplementedException ();
			}
			set {
				//FIXME:
			}
		}

		[MonoTODO]
		public Size AutoScrollMargin {
			get {
				throw new NotImplementedException ();
			}
			set {
				//FIXME:
			}
		}

		[MonoTODO]
		public Size AutoScrollMinSize {
			get {
				throw new NotImplementedException ();
			}
			set {
				//FIXME:
			}
		}

		[MonoTODO]
		public Point AutoScrollPosition {
			get {
				throw new NotImplementedException ();
			}
			set {
				//FIXME:
			}
		}

		public override Rectangle DisplayRectangle {
			get {
				return base.DisplayRectangle;
			}
		}

		[MonoTODO]
		public ScrollableControl.DockPaddingEdges DockPadding {
			get {
				return dockPadding;
			}
		}

		//
		//  --- public methods
		//

		[MonoTODO]
		public void ScrollControlIntoView (Control activeControl) {
		}

		//
		//  --- Protected Properties
		//

		protected override CreateParams CreateParams {
			get {
				RegisterDefaultWindowClass ( );

				CreateParams createParams = base.CreateParams;
				createParams.Caption = "ScrollableControl";
				createParams.ClassName = Win32.DEFAULT_WINDOW_CLASS;
  				
				createParams.Style = (int) (WindowStyles.WS_CLIPCHILDREN | WindowStyles.WS_CLIPSIBLINGS | WindowStyles.WS_CHILD | WindowStyles.WS_VISIBLE);
				//test version with scroll bars.
				//createParams.Style = (int) (WindowStyles.WS_OVERLAPPEDWINDOW | WindowStyles.WS_HSCROLL | WindowStyles.WS_VSCROLL);
				
				return createParams;			
			}
		}

		[MonoTODO]
		protected bool HScroll {
			get {
				throw new NotImplementedException ();
			}
			set {
				//FIXME:
			}
		}

		[MonoTODO]
		protected bool VScroll {
			get {
				throw new NotImplementedException ();
			}
			set {
				//FIXME:
			}
		}

		//
		//  --- Protected Methods
		//
		
		[MonoTODO]
		protected virtual void AdjustFormScrollbars (
			bool displayScrollbars) {
			//FIXME:
		}

		protected bool GetScrollState(int bit){
			throw new NotImplementedException ();
		}

		protected override void OnLayout (LayoutEventArgs levent) {
			//FIXME:
			base.OnLayout (levent);
		}

		protected override void OnMouseWheel (MouseEventArgs e) {
			//FIXME:
			base.OnMouseWheel (e);
		}

		protected override void OnVisibleChanged (EventArgs e) {
			//FIXME:
			base.OnVisibleChanged (e);
		}

		protected override void ScaleCore (float dx, float dy) {
			//FIXME:
			base.ScaleCore (dx, dy);
		}

		[MonoTODO]
		public void SetAutoScrollMargin(int x,int y){
		}

		[MonoTODO]
		protected void SetScrollState(int bit,bool value){
		}

		[MonoTODO]
		protected void SetDisplayRectLocation(int x,int y){
		}

		protected override void WndProc (ref Message m) {
			//FIXME:
			base.WndProc (ref m);
		}
		

		/// ScrollableControl.DockPaddingEdges
		/// Determines the border padding for docked controls.
		
		public class DockPaddingEdges : ICloneable {
			// --- Fields ---
			private int all;
			private int bottom;
			private int left;
			private int right;
			private int top;
			
			
			// --- public Properties ---
			public int All {
				get {
					return all;
				}
				set {
					all = value;
					left = value;
					right = value;
					bottom = value;
					top = value;
				}
			}
			
			public int Bottom {
				get { return bottom; }
				set { bottom = value; }
			}
			
			public int Left {
				get { return left; }
				set { left = value; }
			}
			
			public int Right {
				get { return right; }
				set { right = value; }
			}
			
			public int Top {
				get { return top; }
				set { top = value; }
			}
			
			
			/// --- public Methods ---

			/// <summary>
			///	Equality Operator
			/// </summary>
			///
			/// <remarks>
			///	Compares two DockPaddingEdges objects. The return value is
			///	based on the equivalence of the  
			///	properties of the two DockPaddingEdges.
			/// </remarks>

			public static bool operator == (DockPaddingEdges objA, DockPaddingEdges objB) {
				return ((objA.left == objB.left) && 
					(objA.right == objB.right) && 
					(objA.top == objB.top) && 
					(objA.bottom == objB.bottom) && 
					(objA.all == objB.all));
			} 			
			/// <summary>
			///	Equals Method
			/// </summary>
			///
			/// <remarks>
			///	Checks equivalence of this DockPaddingEdges and another object.
			/// </remarks>
		
			public override bool Equals (object obj) {
				if (!(obj is DockPaddingEdges))
					return false;

				return (this == (DockPaddingEdges) obj);
			}

			/// <summary>
			///	Inequality Operator
			/// </summary>
			///
			/// <remarks>
			///	Compares two DockPaddingEdges objects. The return value is
			///	based on the equivalence of the  
			///	properties of the two Sizes.
			/// </remarks>

			public static bool operator != (DockPaddingEdges objA, DockPaddingEdges objB) {
				return ((objA.left != objB.left) ||
					(objA.right != objB.right) ||
					(objA.top != objB.top) ||
					(objA.bottom != objB.bottom) ||
					(objA.all != objB.all));
			} 		
			/// <summary>
			///	GetHashCode Method
			/// </summary>
			///
			/// <remarks>
			///	Calculates a hashing value.
			/// </remarks>
		
			public override int GetHashCode () {
				unchecked{
					return all * top * bottom * right * left;
				}
			}

			
			/// This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.
			object ICloneable.Clone () {
				DockPaddingEdges dpe = new DockPaddingEdges();
				dpe.all = all;
				dpe.top = top;
				dpe.right = right;
				dpe.bottom = bottom;
				dpe.left = left;
				return (object) dpe;
			}
			
			/// <summary>
			///	ToString Method
			/// </summary>
			///
			/// <remarks>
			///	Formats the DockPaddingEdges as a string.
			/// </remarks>
		
			public override string ToString () {
				return "All = " + all.ToString() + " Top = " + top.ToString() + 
					" Right = " + right.ToString() + " Bottom = " + bottom.ToString() + 
					" Left = " + left.ToString();
			}
		}
		public class DockPaddingEdgeConverter : TypeConverter {
		}
	}
}

