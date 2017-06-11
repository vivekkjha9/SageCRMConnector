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
	/// Defines a purchaseReturnDelivery Feed Entry
	/// </summary>
	#endregion
	public class purchaseReturnDeliveryFeedEntry : purchaseReturnDeliveryFeedEntrySchema
	{
		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="purchaseReturnDeliveryFeedEntry"/> class.
		/// </summary>
		#endregion
		[SMEResource(CanGet=true, PluralName="purchaseReturnDeliveries")]
		public purchaseReturnDeliveryFeedEntry()
		{
		}
	}
}