//
// JSFieldInfo.cs:
//
// Author:
//	Cesar Lopez Nataren (cesar@ciencias.unam.mx)
//
// (C) 2003, Cesar Lopez Nataren
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
using System.Reflection;
using System.Globalization;

namespace Microsoft.JScript {

	public sealed class JSFieldInfo : FieldInfo {

		public override FieldAttributes Attributes {
			get { throw new NotImplementedException (); }
		}


		public override Type DeclaringType {
			get { throw new NotImplementedException (); }
		}


		public override RuntimeFieldHandle FieldHandle {
			get { throw new NotImplementedException (); }
		}


		public override Type FieldType {
			get { throw new NotImplementedException (); }
		}


		public override object [] GetCustomAttributes (Type t, bool inherit)
		{
			throw new NotImplementedException ();
		}

	
		public override object [] GetCustomAttributes (bool inherit)
		{
			throw new NotImplementedException ();
		}


		public override object GetValue (object obj)
		{
			throw new NotImplementedException ();
		}


		public override bool IsDefined (Type type, bool inherit)
		{
			throw new NotImplementedException ();
		}


		public override MemberTypes MemberType {
			get { throw new NotImplementedException (); }
		}


		public override string Name {
			get { throw new NotImplementedException (); }
		}


		public override Type ReflectedType {
			get { throw new NotImplementedException (); }
		}


		public new void SetValue (object obj, object value)
		{
			throw new NotImplementedException ();
		}


		public override void SetValue (object obj, object value, BindingFlags invokeAttr,
					       Binder binder, CultureInfo culture)
		{
			throw new NotImplementedException ();
		}
	}
}
