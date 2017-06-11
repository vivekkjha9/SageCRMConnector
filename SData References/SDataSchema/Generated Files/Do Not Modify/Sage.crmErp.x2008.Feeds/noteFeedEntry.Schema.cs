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
	/// Defines a note feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("note", Namespace="http://schemas.sage.com/crmErp/2008")]
		[SMEResource(CanGet=true, PluralName="notes")]
	public class noteFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyuuid = "uuid";
		public const string Propertyid = "id";
		public const string Propertyactive = "active";
		public const string Propertydeleted = "deleted";
		public const string Propertylabel = "label";
		public const string Propertyreference = "reference";
		public const string Propertyreference2 = "reference2";
		public const string Propertytext = "text";
		public const string PropertyprivacyFlag = "privacyFlag";
		public const string PropertydateStamp = "dateStamp";
		public const string PropertyprimacyIndicator = "primacyIndicator";
		public const string Propertyuser = "user";

		#endregion

		#region Fields

		private string _uuid;
		private System.String _id;
		private System.Boolean _active;
		private System.Boolean _deleted;
		private System.String _label;
		private System.String _reference;
		private System.String _reference2;
		private System.String _text;
		private System.Boolean _privacyFlag;
		private System.DateTime _dateStamp;
		private System.Boolean _primacyIndicator;
		private System.String _user;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="noteFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public noteFeedEntrySchema()
		{
		}

		#region Properties


		[SMEEnumProperty(EnumTypeName="uuid--type", Label="Note Global ID", Pattern="[0-9a-fA-F-]+", Name="uuid", Namespace="http://schemas.sage.com/crmErp/2008", IsUniqueKey=true)]			
		public virtual new string uuid { get { return _uuid; } set { SetProperty(Propertyuuid, ref _uuid, value); } }

		[SMEStringProperty(Label="Note Application ID", Name="id", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual new System.String id { get { return _id; } set { SetProperty(Propertyid, ref _id, value); } }

		[SMEBoolProperty(Label="Note Active Flag", Name="active", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEBoolProperty(Label="Note Deleted", Name="deleted", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean deleted { get { return _deleted; } set { SetProperty(Propertydeleted, ref _deleted, value); } }

		[SMEStringProperty(Label="Note Label", Name="label", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String label { get { return _label; } set { SetProperty(Propertylabel, ref _label, value); } }

		[SMEStringProperty(Label="Note reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEStringProperty(Label="NoteReference2", Nillable=true, Name="reference2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }

		[SMEStringProperty(Label="Note Text", Name="text", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String text { get { return _text; } set { SetProperty(Propertytext, ref _text, value); } }

		[SMEBoolProperty(Label="Note Privacy Flag", Name="privacyFlag", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean privacyFlag { get { return _privacyFlag; } set { SetProperty(PropertyprivacyFlag, ref _privacyFlag, value); } }

		[SMEDateProperty(Label="Note Date Stamp", Name="dateStamp", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.DateTime dateStamp { get { return _dateStamp; } set { SetProperty(PropertydateStamp, ref _dateStamp, value); } }

		[SMEBoolProperty(Label="Note Primacy Indicator", Name="primacyIndicator", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean primacyIndicator { get { return _primacyIndicator; } set { SetProperty(PropertyprimacyIndicator, ref _primacyIndicator, value); } }

		[SMEStringProperty(Label="Note User", Name="user", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String user { get { return _user; } set { SetProperty(Propertyuser, ref _user, value); } }

		#endregion


	}
}