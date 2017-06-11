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
	/// Defines a salesReturn Feed Entry
	/// </summary>
	#endregion
	public class salesReturnFeedEntry : salesReturnFeedEntrySchema
	{
		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="salesReturnFeedEntry"/> class.
		/// </summary>
		#endregion
		[SMEResource(CanGet=true, CanPost=true, CanPut=true, PluralName="salesReturns")]
		public salesReturnFeedEntry()
		{
		}
	}
}