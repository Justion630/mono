//
// System.Data.ObjectSpaces.CommonObjectContext.cs : A basic ObjectContext for handling persistent object identity and state.
//
// Author:
//   Mark Easton (mark.easton@blinksoftware.co.uk)
//   Tim Coleman (tim@timcoleman.com)
//
// (C) BLiNK Software Ltd.  http://www.blinksoftware.co.uk
// Copyright (C) Tim Coleman, 2003
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

#if NET_2_0

using System;
using System.Data.ObjectSpaces.Schema;
using System.Globalization;

namespace System.Data.ObjectSpaces
{
        public class CommonObjectContext : ObjectContext
        {
		#region Fields

		ObjectSchema objectSchema;

		#endregion // Fields

		#region Constructors

		public CommonObjectContext (ObjectSchema objectSchema)
		{
                        if (objectSchema == null)
				throw new ArgumentNullException ("objectSchema", Locale.GetText ("'objectSchema' argument cannot be null."));
			this.objectSchema = objectSchema;
		}

		#endregion // Constructors

		#region Methods
                
                [MonoTODO]
                public override void Add (object obj, ObjectState state)
                {
                        if (obj == null)
				throw new ContextException (Locale.GetText ("Cannot add null object into any object context."));
			if (!Enum.IsDefined (typeof (ObjectState), state))
				throw new NullReferenceException ();
			if (state == ObjectState.Unknown)
				throw new ContextException (Locale.GetText ("Cannot add any object into an object context as an Unknown object."));
                }

                [MonoTODO]
                public override void Delete (object obj)
                {
                        if (obj == null)
				throw new ArgumentNullException ("obj", Locale.GetText ("'obj' argument cannot be null."));
                }
                
                [MonoTODO]
                public override ValueRecord GetCurrentValueRecord (object obj)
                {
                        if (obj == null)
				throw new ArgumentNullException ("obj", Locale.GetText ("'obj' argument cannot be null."));
                        
                        return null;        
                }
                               
                [MonoTODO]
                public override ObjectState GetObjectState (object obj)
                {
                        if (obj == null)
				throw new ArgumentNullException ("obj", Locale.GetText ("'obj' argument cannot be null."));
                      
			throw new NotImplementedException ();
                }
                
                [MonoTODO]
                public override ValueRecord GetOriginalValueRecord (object obj)
                {
                        if (obj == null)
				throw new ArgumentNullException ("obj", Locale.GetText ("'obj' argument cannot be null."));
                        
                        return null;        
                }
                
                [MonoTODO]
                public override void Import (ObjectContext context)
                {
                        if (context == null)
				throw new ArgumentNullException ("context", Locale.GetText ("'context' argument cannot be null."));
                }
                                
                [MonoTODO]
                public override void Import (ObjectContext context, object obj)
                {
                        if (obj == null)
				throw new ArgumentNullException ("obj", Locale.GetText ("'obj' argument cannot be null."));
                        if (context == null)
				throw new ArgumentNullException ("context", Locale.GetText ("'context' argument cannot be null."));
                }

                [MonoTODO]
                public override void Remove (object obj)
                {
                        if (obj == null)
				throw new ArgumentNullException ("obj", Locale.GetText ("'obj' argument cannot be null."));
                }

		#endregion // Methods
        }
}

#endif
