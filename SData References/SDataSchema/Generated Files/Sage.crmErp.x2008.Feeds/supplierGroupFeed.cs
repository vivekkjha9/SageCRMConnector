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
	/// Defines a supplierGroup Feed
	/// </summary>
	#endregion
	public class supplierGroupFeed : Sage.Common.Syndication.Feed<supplierGroupFeedEntry>
	{
		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="supplierGroupFeed"/> class.
		/// </summary>
		#endregion
		public supplierGroupFeed()
		{
		}
	}
}