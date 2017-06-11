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
	/// Defines a taxCode feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("taxCode", Namespace="http://schemas.sage.com/crmErp/2008")]
		[SMEResource(CanGet=true, PluralName="taxCodes")]
	public class taxCodeFeedEntrySchema : Sage.Common.Syndication.FeedEntry
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
		public const string PropertytaxationCountry = "taxationCountry";
		public const string PropertytaxationLocale = "taxationLocale";
		public const string Propertyvalue = "value";
		public const string PropertyvalueText = "valueText";
		public const string PropertyprimacyIndicator = "primacyIndicator";
		public const string PropertyorderOfPrecedence = "orderOfPrecedence";
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
		private System.String _taxationCountry;
		private System.String _taxationLocale;
		private System.Decimal _value;
		private System.String _valueText;
		private System.Boolean _primacyIndicator;
		private Nullable<System.Decimal> _orderOfPrecedence;
		private noteFeedEntry _notes;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="taxCodeFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public taxCodeFeedEntrySchema()
		{
		}

		#region Properties


		[SMEEnumProperty(EnumTypeName="uuid--type", Label="TaxCode Global ID", Pattern="[0-9a-fA-F-]+", Name="uuid", Namespace="http://schemas.sage.com/crmErp/2008", IsUniqueKey=true)]			
		public virtual new string uuid { get { return _uuid; } set { SetProperty(Propertyuuid, ref _uuid, value); } }

		[SMEStringProperty(Label="TaxCode Application ID", Name="id", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual new System.String id { get { return _id; } set { SetProperty(Propertyid, ref _id, value); } }

		[SMEBoolProperty(Label="TaxCode Active Flag", Name="active", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEBoolProperty(Label="TaxCode Deleted", Name="deleted", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean deleted { get { return _deleted; } set { SetProperty(Propertydeleted, ref _deleted, value); } }

		[SMEStringProperty(Label="TaxCode Label", Name="label", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String label { get { return _label; } set { SetProperty(Propertylabel, ref _label, value); } }

		[SMEStringProperty(Label="TaxCode reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEStringProperty(Label="TaxCode Reference2", Nillable=true, Name="reference2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }

		[SMEStringProperty(Label="TaxCode Type", Nillable=true, Name="type", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }

		[SMEStringProperty(Label="TaxCode Taxation Country", Name="taxationCountry", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String taxationCountry { get { return _taxationCountry; } set { SetProperty(PropertytaxationCountry, ref _taxationCountry, value); } }

		[SMEStringProperty(Label="TaxCode Taxation Locale", Nillable=true, Name="taxationLocale", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String taxationLocale { get { return _taxationLocale; } set { SetProperty(PropertytaxationLocale, ref _taxationLocale, value); } }

		[SMEDecimalProperty(Label="TaxCode Value", Name="value", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal value { get { return _value; } set { SetProperty(Propertyvalue, ref _value, value); } }

		[SMEStringProperty(Label="TaxCode Value Text", Name="valueText", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String valueText { get { return _valueText; } set { SetProperty(PropertyvalueText, ref _valueText, value); } }

		[SMEBoolProperty(Label="TaxCode Primacy Indicator", Name="primacyIndicator", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean primacyIndicator { get { return _primacyIndicator; } set { SetProperty(PropertyprimacyIndicator, ref _primacyIndicator, value); } }

		[SMEDecimalProperty(Label="TaxCode Order Of Precedence", Nillable=true, Name="orderOfPrecedence", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> orderOfPrecedence { get { return _orderOfPrecedence; } set { SetProperty(PropertyorderOfPrecedence, ref _orderOfPrecedence, value); } }

		[SMEResource(CanGet=true, PluralName="notes", Label="TaxCode Note")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, Label="TaxCode Note", Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("notes")]			
		public virtual noteFeedEntry notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		#endregion


	}
}