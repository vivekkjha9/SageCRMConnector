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
	/// Defines a payment Feed Entry
	/// </summary>
	#endregion
	public class paymentFeedEntry : paymentFeedEntrySchema
	{
		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="paymentFeedEntry"/> class.
		/// </summary>
		#endregion
		[SMEResource(CanGet=true, PluralName="payments")]
		public paymentFeedEntry()
		{
		}
	}
}