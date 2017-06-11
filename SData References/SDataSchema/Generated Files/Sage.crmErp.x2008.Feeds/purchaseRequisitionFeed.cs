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
	/// Defines a purchaseRequisition Feed
	/// </summary>
	#endregion
	public class purchaseRequisitionFeed : Sage.Common.Syndication.Feed<purchaseRequisitionFeedEntry>
	{
		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="purchaseRequisitionFeed"/> class.
		/// </summary>
		#endregion
		public purchaseRequisitionFeed()
		{
		}
	}
}