using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Sage.Common.Metadata;
using Sage.Common.Syndication;

namespace Sage.crmErp.x2008.Feeds
{
	#region Documentation
	/// <summary>
	/// Defines a salesReturnLine Feed Entry
	/// </summary>
	#endregion
	public class salesReturnLineFeedEntry : salesReturnLineFeedEntrySchema
	{
		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="salesReturnLineFeedEntry"/> class.
		/// </summary>
		#endregion
		[SMEResource(CanGet=true, CanPost=true, CanPut=true, PluralName="salesReturnLines")]
		public salesReturnLineFeedEntry()
		{
		}
	}
}