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
	/// Defines a unitOfMeasure feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("unitOfMeasure", Namespace="http://schemas.sage.com/crmErp/2008")]
		[SMEResource(CanGet=true, PluralName="unitsOfMeasure")]
	public class unitOfMeasureFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyid = "id";
		public const string PropertyunitOfMeasureGroup = "unitOfMeasureGroup";
		public const string Propertylabel = "label";
		public const string Propertyactive = "active";
		public const string Propertydeleted = "deleted";
		public const string Propertytype = "type";
		public const string Propertyreference = "reference";
		public const string Propertyreference2 = "reference2";
		public const string PropertyoperatingCompany = "operatingCompany";
		public const string Propertyname = "name";
		public const string PropertyshortName = "shortName";
		public const string Propertysymbol = "symbol";
		public const string Propertydescription = "description";
		public const string PropertybaseNumber = "baseNumber";
		public const string PropertybaseFactorNumber = "baseFactorNumber";
		public const string PropertydecimalPlaces = "decimalPlaces";
		public const string PropertytradeIdentificationNumber = "tradeIdentificationNumber";
		public const string Propertyweight = "weight";
		public const string PropertyweightKg = "weightKg";
		public const string Propertydimension = "dimension";
		public const string PropertyprimacyIndicator = "primacyIndicator";
		public const string Propertycommodities = "commodities";
		public const string Propertynotes = "notes";

		#endregion

		#region Fields

		private System.String _id;
		private unitOfMeasureGroupFeedEntry _unitOfMeasureGroup;
		private System.String _label;
		private System.Boolean _active;
		private System.Boolean _deleted;
		private System.String _type;
		private System.String _reference;
		private System.String _reference2;
		private companyFeedEntry _operatingCompany;
		private System.String _name;
		private System.String _shortName;
		private System.String _symbol;
		private System.String _description;
		private System.Decimal _baseNumber;
		private System.Decimal _baseFactorNumber;
		private Nullable<System.Decimal> _decimalPlaces;
		private System.String _tradeIdentificationNumber;
		private Nullable<System.Decimal> _weight;
		private Nullable<System.Decimal> _weightKg;
		private commodityDimensionFeed _dimension;
		private System.Boolean _primacyIndicator;
		private commodityFeed _commodities;
		private noteFeed _notes;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="unitOfMeasureFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public unitOfMeasureFeedEntrySchema()
		{
		}

		#region Properties


		[SMEStringProperty(Label="UnitOfMeasure Application ID", Name="id", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual new System.String id { get { return _id; } set { SetProperty(Propertyid, ref _id, value); } }

		[SMEResource(CanGet=true, PluralName="unitsOfMeasureGroup", Label="UnitOfMeasure UnitOfMeasureGroup")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Parent, Label="UnitOfMeasure UnitOfMeasureGroup", Name="unitOfMeasureGroup", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("unitOfMeasureGroup")]			
		public virtual unitOfMeasureGroupFeedEntry unitOfMeasureGroup { get { return _unitOfMeasureGroup; } set { SetProperty(PropertyunitOfMeasureGroup, ref _unitOfMeasureGroup, value); } }

		[SMEStringProperty(Label="UnitOfMeasure Label", Name="label", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String label { get { return _label; } set { SetProperty(Propertylabel, ref _label, value); } }

		[SMEBoolProperty(Label="UnitOfMeasure Active Flag", Name="active", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEBoolProperty(Label="UnitOfMeasure Deleted", Name="deleted", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean deleted { get { return _deleted; } set { SetProperty(Propertydeleted, ref _deleted, value); } }

		[SMEStringProperty(Label="UnitOfMeasure Type", Nillable=true, Name="type", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }

		[SMEStringProperty(Label="UnitOfMeasure reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEStringProperty(Label="UnitOfMeasure Reference2", Nillable=true, Name="reference2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="companies")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="UnitOfMeasure OperatingCompany", Name="operatingCompany", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("operatingCompany")]			
		public virtual companyFeedEntry operatingCompany { get { return _operatingCompany; } set { SetProperty(PropertyoperatingCompany, ref _operatingCompany, value); } }

		[SMEStringProperty(Label="UnitOfMeasure Name", Nillable=true, Name="name", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String name { get { return _name; } set { SetProperty(Propertyname, ref _name, value); } }

		[SMEStringProperty(Label="UnitOfMeasure Short Name", Nillable=true, Name="shortName", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String shortName { get { return _shortName; } set { SetProperty(PropertyshortName, ref _shortName, value); } }

		[SMEStringProperty(Label="UnitOfMeasure Symbol", Nillable=true, Name="symbol", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String symbol { get { return _symbol; } set { SetProperty(Propertysymbol, ref _symbol, value); } }

		[SMEStringProperty(Label="UnitOfMeasure Description", Nillable=true, Name="description", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String description { get { return _description; } set { SetProperty(Propertydescription, ref _description, value); } }

		[SMEDecimalProperty(Label="UnitOfMeasure Base Number", Name="baseNumber", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal baseNumber { get { return _baseNumber; } set { SetProperty(PropertybaseNumber, ref _baseNumber, value); } }

		[SMEDecimalProperty(Label="UnitOfMeasure Base Factor Number", Name="baseFactorNumber", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal baseFactorNumber { get { return _baseFactorNumber; } set { SetProperty(PropertybaseFactorNumber, ref _baseFactorNumber, value); } }

		[SMEDecimalProperty(Label="UnitOfMeasure Decimal Places", Nillable=true, Name="decimalPlaces", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> decimalPlaces { get { return _decimalPlaces; } set { SetProperty(PropertydecimalPlaces, ref _decimalPlaces, value); } }

		[SMEStringProperty(Label="UnitOfMeasure Trade Identification Number", Nillable=true, Name="tradeIdentificationNumber", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual System.String tradeIdentificationNumber { get { return _tradeIdentificationNumber; } set { SetProperty(PropertytradeIdentificationNumber, ref _tradeIdentificationNumber, value); } }

		[SMEDecimalProperty(Label="UnitOfMeasure Weight", Nillable=true, Name="weight", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> weight { get { return _weight; } set { SetProperty(Propertyweight, ref _weight, value); } }

		[SMEDecimalProperty(Label="UnitOfMeasure Weight KG", Nillable=true, Name="weightKg", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> weightKg { get { return _weightKg; } set { SetProperty(PropertyweightKg, ref _weightKg, value); } }

		[SMEResource(PluralName="commodityDimensions", Label="UnitOfMeasure Dimension")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="UnitOfMeasure Dimension", Name="dimension", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual commodityDimensionFeed dimension { get { return _dimension; } set { SetProperty(Propertydimension, ref _dimension, value); } }

		[SMEBoolProperty(Label="UnitOfMeasure Primacy Indicator", Name="primacyIndicator", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean primacyIndicator { get { return _primacyIndicator; } set { SetProperty(PropertyprimacyIndicator, ref _primacyIndicator, value); } }

		[SMEResource(CanGet=true, PluralName="commodities", Label="UnitOfMeasure Commodity")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="UnitOfMeasure Commodity", Name="commodities", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual commodityFeed commodities { get { return _commodities; } set { SetProperty(Propertycommodities, ref _commodities, value); } }

		[SMEResource(CanGet=true, PluralName="notes")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Label="UnitOfMeasure Note", Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual noteFeed notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		#endregion


	}
}