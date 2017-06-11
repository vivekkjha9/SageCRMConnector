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
	/// Defines a unitOfMeasure Feed Entry
	/// </summary>
	#endregion
	public class unitOfMeasureFeedEntry : unitOfMeasureFeedEntrySchema
	{
		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="unitOfMeasureFeedEntry"/> class.
		/// </summary>
		#endregion
		[SMEResource(CanGet=true, PluralName="unitsOfMeasure")]
		public unitOfMeasureFeedEntry()
		{
		}
	}
}