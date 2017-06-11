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
	/// Defines a email feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("email", Namespace="http://schemas.sage.com/crmErp/2008")]
		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="emails")]
	public class emailFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyuuid = "uuid";
		public const string Propertyid = "id";
		public const string Propertyactive = "active";
		public const string Propertydeleted = "deleted";
		public const string Propertylabel = "label";
		public const string Propertyreference = "reference";
		public const string Propertyreference2 = "reference2";
		public const string Propertytype = "type";
		public const string Propertyaddress = "address";
		public const string PropertyuRL = "uRL";
		public const string PropertyprimacyIndicator = "primacyIndicator";
		public const string Propertynotes = "notes";

		#endregion

		#region Fields

		private string _uuid;
		private System.String _id;
		private System.Boolean _active;
		private System.Boolean _deleted;
		private System.String _label;
		private System.String _reference;
		private System.String _reference2;
		private System.String _type;
		private System.String _address;
		private System.String _uRL;
		private System.Boolean _primacyIndicator;
		private noteFeedEntry _notes;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="emailFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public emailFeedEntrySchema()
		{
		}

		#region Properties


		[SMEEnumProperty(EnumTypeName="uuid--type", Label="Email Global ID", Pattern="[0-9a-fA-F-]+", Name="uuid", Namespace="http://schemas.sage.com/crmErp/2008", IsUniqueKey=true)]			
		public virtual new string uuid { get { return _uuid; } set { SetProperty(Propertyuuid, ref _uuid, value); } }

		[SMEStringProperty(Label="Email Application ID", Name="id", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual new System.String id { get { return _id; } set { SetProperty(Propertyid, ref _id, value); } }

		[SMEBoolProperty(Label="Email Active Flag", Name="active", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEBoolProperty(Label="Email Deleted", Name="deleted", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean deleted { get { return _deleted; } set { SetProperty(Propertydeleted, ref _deleted, value); } }

		[SMEStringProperty(Label="Email Label", Name="label", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String label { get { return _label; } set { SetProperty(Propertylabel, ref _label, value); } }

		[SMEStringProperty(Label="Email reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEStringProperty(Label="Email Reference2", Nillable=true, Name="reference2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }

		[SMEStringProperty(Label="Email Type", Name="type", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }

		[SMEStringProperty(Label="Email Address", Name="address", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String address { get { return _address; } set { SetProperty(Propertyaddress, ref _address, value); } }

		[SMEStringProperty(Label="mailto:URL", Name="uRL", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual System.String uRL { get { return _uRL; } set { SetProperty(PropertyuRL, ref _uRL, value); } }

		[SMEBoolProperty(Label="Email Primacy Indicator", Name="primacyIndicator", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean primacyIndicator { get { return _primacyIndicator; } set { SetProperty(PropertyprimacyIndicator, ref _primacyIndicator, value); } }

		[SMEResource(CanGet=true, PluralName="notes", Label="Email Note")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, Label="Email Note", Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("notes")]			
		public virtual noteFeedEntry notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		#endregion


	}
}