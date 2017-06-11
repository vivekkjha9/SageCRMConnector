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
	/// Defines a phoneNumber feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("phoneNumber", Namespace="http://schemas.sage.com/crmErp/2008")]
		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="phoneNumbers")]
	public class phoneNumberFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyid = "id";
		public const string Propertyactive = "active";
		public const string Propertydeleted = "deleted";
		public const string Propertylabel = "label";
		public const string Propertyreference = "reference";
		public const string Propertyreference2 = "reference2";
		public const string PropertyuRI = "uRI";
		public const string Propertytype = "type";
		public const string Propertyname = "name";
		public const string Propertytext = "text";
		public const string PropertycountryCode = "countryCode";
		public const string PropertyareaCode = "areaCode";
		public const string Propertynumber = "number";
		public const string Propertyextension = "extension";
		public const string PropertyprimacyIndicator = "primacyIndicator";
		public const string Propertynotes = "notes";

		#endregion

		#region Fields

		private System.String _id;
		private System.Boolean _active;
		private System.Boolean _deleted;
		private System.String _label;
		private System.String _reference;
		private System.String _reference2;
		private System.String _uRI;
		private System.String _type;
		private System.String _name;
		private System.String _text;
		private System.String _countryCode;
		private System.String _areaCode;
		private System.String _number;
		private System.String _extension;
		private System.Boolean _primacyIndicator;
		private noteFeed _notes;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="phoneNumberFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public phoneNumberFeedEntrySchema()
		{
		}

		#region Properties


		[SMEStringProperty(Label="PhoneNumber Application ID", Name="id", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual new System.String id { get { return _id; } set { SetProperty(Propertyid, ref _id, value); } }

		[SMEBoolProperty(Label="PhoneNumber Active Flag", Name="active", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEBoolProperty(Label="PhoneNumber Deleted", Name="deleted", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean deleted { get { return _deleted; } set { SetProperty(Propertydeleted, ref _deleted, value); } }

		[SMEStringProperty(Label="PhoneNumber Label", Name="label", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String label { get { return _label; } set { SetProperty(Propertylabel, ref _label, value); } }

		[SMEStringProperty(Label="PhoneNumber reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEStringProperty(Label="PhoneNumber Reference2", Nillable=true, Name="reference2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }

		[SMEStringProperty(Label="PhoneNumber URI", Name="uRI", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual new System.String uRI { get { return _uRI; } set { SetProperty(PropertyuRI, ref _uRI, value); } }

		[SMEStringProperty(Label="PhoneNumber Type", Name="type", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }

		[SMEStringProperty(Label="PhoneNumber Name", Nillable=true, Name="name", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String name { get { return _name; } set { SetProperty(Propertyname, ref _name, value); } }

		[SMEStringProperty(Label="PhoneNumber Text", Name="text", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String text { get { return _text; } set { SetProperty(Propertytext, ref _text, value); } }

		[SMEStringProperty(Label="PhoneNumber Country Code", Name="countryCode", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String countryCode { get { return _countryCode; } set { SetProperty(PropertycountryCode, ref _countryCode, value); } }

		[SMEStringProperty(Label="PhoneNumber Area Code", Name="areaCode", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String areaCode { get { return _areaCode; } set { SetProperty(PropertyareaCode, ref _areaCode, value); } }

		[SMEStringProperty(Label="PhoneNumber Number", Name="number", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String number { get { return _number; } set { SetProperty(Propertynumber, ref _number, value); } }

		[SMEStringProperty(Label="PhoneNumber Extension", Nillable=true, Name="extension", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String extension { get { return _extension; } set { SetProperty(Propertyextension, ref _extension, value); } }

		[SMEBoolProperty(Label="PhoneNumber Primacy Indicator", Name="primacyIndicator", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean primacyIndicator { get { return _primacyIndicator; } set { SetProperty(PropertyprimacyIndicator, ref _primacyIndicator, value); } }

		[SMEResource(CanGet=true, PluralName="notes")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Label="PhoneNumber Note", Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual noteFeed notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		#endregion


	}
}