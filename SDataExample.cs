using System;
using Sage.Integration.Client;
using Sage.crmErp.x2008.Feeds;

namespace SDataExample
{
	public class SDataExample
	{
		public static void GetFeed()
		{
			SDataRequest request = new SDataRequest(new Uri("http://my.feedprovider.com:5493/sdata/application/feedname"));
			bankAccountFeed feed = new bankAccountFeed();

			request.RequestFeed(feed);

			foreach (bankAccountFeedEntry entry in feed.Entries)
			{
				System.Diagnostics.Debug.WriteLine(entry.Title);
			}
		}
	}
}

