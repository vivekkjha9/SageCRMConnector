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
	/// Defines a paymentLine Feed
	/// </summary>
	#endregion
	public class paymentLineFeed : Sage.Common.Syndication.Feed<paymentLineFeedEntry>
	{
		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="paymentLineFeed"/> class.
		/// </summary>
		#endregion
		public paymentLineFeed()
		{
		}
	}
}