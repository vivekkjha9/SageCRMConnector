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
	/// Defines a calendar Feed
	/// </summary>
	#endregion
	public class calendarFeed : Sage.Common.Syndication.Feed<calendarFeedEntry>
	{
		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="calendarFeed"/> class.
		/// </summary>
		#endregion
		public calendarFeed()
		{
		}
	}
}