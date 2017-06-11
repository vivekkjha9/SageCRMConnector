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
	/// Defines a commodity feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("commodity", Namespace="http://schemas.sage.com/crmErp/2008")]
		[SMEResource(CanGet=true, PluralName="commodities")]
	public class commodityFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyid = "id";
		public const string Propertyactive = "active";
		public const string Propertydeleted = "deleted";
		public const string Propertylabel = "label";
		public const string PropertycommodityGroup = "commodityGroup";
		public const string PropertycommodityIdentifierType = "commodityIdentifierType";
		public const string PropertycommodityIdentifiers = "commodityIdentifiers";
		public const string Propertyreference = "reference";
		public const string Propertyreference2 = "reference2";
		public const string PropertyoperatingCompany = "operatingCompany";
		public const string Propertystatus = "status";
		public const string Propertyname = "name";
		public const string PropertyshortName = "shortName";
		public const string Propertydescription = "description";
		public const string PropertyalternativeDescription1 = "alternativeDescription1";
		public const string PropertyalternativeDescription2 = "alternativeDescription2";
		public const string Propertytype = "type";
		public const string PropertyunitOfMeasure = "unitOfMeasure";
		public const string PropertybuyingAllowedFlag = "buyingAllowedFlag";
		public const string PropertybuyingUnitOfMeasure = "buyingUnitOfMeasure";
		public const string PropertybuyingUnitOfMeasureNumber = "buyingUnitOfMeasureNumber";
		public const string PropertysellingAllowedFlag = "sellingAllowedFlag";
		public const string PropertysellingUnitOfMeasure = "sellingUnitOfMeasure";
		public const string PropertysellingUnitOfMeasureNumber = "sellingUnitOfMeasureNumber";
		public const string PropertypackingUnitOfMeasure = "packingUnitOfMeasure";
		public const string PropertypackingUnitOfMeasureNumber = "packingUnitOfMeasureNumber";
		public const string PropertycatalogueNumber = "catalogueNumber";
		public const string PropertysupplierTradingAccount = "supplierTradingAccount";
		public const string PropertysupplierReference = "supplierReference";
		public const string PropertymanufacturerCompany = "manufacturerCompany";
		public const string PropertymanufacturerReference = "manufacturerReference";
		public const string Propertymaterial = "material";
		public const string PropertycountryOfOrigin = "countryOfOrigin";
		public const string Propertyweight = "weight";
		public const string PropertyweightKg = "weightKg";
		public const string Propertyvariant = "variant";
		public const string Propertydimension = "dimension";
		public const string Propertyclassification = "classification";
		public const string PropertytaxCodes = "taxCodes";
		public const string PropertyfinancialAccounts = "financialAccounts";
		public const string PropertydutyApplicableFlag = "dutyApplicableFlag";
		public const string PropertydutyRate = "dutyRate";
		public const string PropertytradeIdentificationNumber = "tradeIdentificationNumber";
		public const string Propertyreplacement = "replacement";
		public const string PropertyreplacementDate = "replacementDate";
		public const string PropertyleadTime = "leadTime";
		public const string Propertycost = "cost";
		public const string PropertyassociatedChildCommodities = "associatedChildCommodities";
		public const string PropertyassociatedParentCommodity = "associatedParentCommodity";
		public const string Propertyversion = "version";
		public const string PropertycommissionType = "commissionType";
		public const string PropertycommissionAmount = "commissionAmount";
		public const string PropertycommissionPercent = "commissionPercent";
		public const string Propertyinteractions = "interactions";
		public const string Propertyopportunities = "opportunities";
		public const string PropertysalesQuotationLines = "salesQuotationLines";
		public const string PropertysalesOrderLines = "salesOrderLines";
		public const string PropertysalesOrderDeliveryLines = "salesOrderDeliveryLines";
		public const string PropertysalesInvoiceLines = "salesInvoiceLines";
		public const string PropertysalesReturnLines = "salesReturnLines";
		public const string PropertysalesReturnDeliveryLines = "salesReturnDeliveryLines";
		public const string PropertysalesCreditLines = "salesCreditLines";
		public const string PropertypurchaseRequisitionLines = "purchaseRequisitionLines";
		public const string PropertypurchaseOrderLines = "purchaseOrderLines";
		public const string PropertypurchaseOrderDeliveryLines = "purchaseOrderDeliveryLines";
		public const string PropertypurchaseInvoiceLines = "purchaseInvoiceLines";
		public const string PropertypurchaseReturnLines = "purchaseReturnLines";
		public const string PropertypurchaseReturnDeliveryLines = "purchaseReturnDeliveryLines";
		public const string PropertypurchaseCreditLines = "purchaseCreditLines";
		public const string PropertyreceiptLines = "receiptLines";
		public const string Propertycases = "cases";
		public const string Propertypricelists = "pricelists";
		public const string Propertyprices = "prices";
		public const string Propertynotes = "notes";

		#endregion

		#region Fields

		private System.String _id;
		private System.Boolean _active;
		private System.Boolean _deleted;
		private System.String _label;
		private commodityGroupFeedEntry _commodityGroup;
		private string _commodityIdentifierType;
		private commodityIdentifierFeed _commodityIdentifiers;
		private System.String _reference;
		private System.String _reference2;
		private companyFeedEntry _operatingCompany;
		private System.String _status;
		private System.String _name;
		private System.String _shortName;
		private System.String _description;
		private System.String _alternativeDescription1;
		private System.String _alternativeDescription2;
		private string _type;
		private unitOfMeasureFeedEntry _unitOfMeasure;
		private Nullable<System.Boolean> _buyingAllowedFlag;
		private unitOfMeasureFeedEntry _buyingUnitOfMeasure;
		private Nullable<System.Decimal> _buyingUnitOfMeasureNumber;
		private Nullable<System.Boolean> _sellingAllowedFlag;
		private unitOfMeasureFeedEntry _sellingUnitOfMeasure;
		private Nullable<System.Decimal> _sellingUnitOfMeasureNumber;
		private unitOfMeasureFeedEntry _packingUnitOfMeasure;
		private Nullable<System.Decimal> _packingUnitOfMeasureNumber;
		private System.String _catalogueNumber;
		private tradingAccountFeed _supplierTradingAccount;
		private System.String _supplierReference;
		private companyFeedEntry _manufacturerCompany;
		private System.String _manufacturerReference;
		private System.String _material;
		private System.String _countryOfOrigin;
		private Nullable<System.Decimal> _weight;
		private Nullable<System.Decimal> _weightKg;
		private commodityVariantFeedEntry _variant;
		private commodityDimensionFeedEntry _dimension;
		private System.String _classification;
		private taxCodeFeed _taxCodes;
		private financialAccountFeed _financialAccounts;
		private Nullable<System.Boolean> _dutyApplicableFlag;
		private Nullable<System.Decimal> _dutyRate;
		private System.String _tradeIdentificationNumber;
		private commodityFeedEntry _replacement;
		private Nullable<System.DateTime> _replacementDate;
		private Nullable<System.Decimal> _leadTime;
		private Nullable<System.Decimal> _cost;
		private commodityFeed _associatedChildCommodities;
		private commodityFeedEntry _associatedParentCommodity;
		private System.String _version;
		private string _commissionType;
		private Nullable<System.Decimal> _commissionAmount;
		private Nullable<System.Decimal> _commissionPercent;
		private interactionFeed _interactions;
		private opportunityFeed _opportunities;
		private salesQuotationLineFeed _salesQuotationLines;
		private salesOrderLineFeed _salesOrderLines;
		private salesOrderDeliveryLineFeed _salesOrderDeliveryLines;
		private salesInvoiceLineFeed _salesInvoiceLines;
		private salesReturnLineFeed _salesReturnLines;
		private salesReturnDeliveryLineFeed _salesReturnDeliveryLines;
		private salesCreditLineFeed _salesCreditLines;
		private purchaseRequisitionLineFeed _purchaseRequisitionLines;
		private purchaseOrderLineFeed _purchaseOrderLines;
		private purchaseOrderDeliveryLineFeed _purchaseOrderDeliveryLines;
		private purchaseInvoiceLineFeed _purchaseInvoiceLines;
		private purchaseReturnLineFeed _purchaseReturnLines;
		private purchaseReturnDeliveryLineFeed _purchaseReturnDeliveryLines;
		private purchaseCreditLineFeed _purchaseCreditLines;
		private receiptLineFeed _receiptLines;
		private caseFeed _cases;
		private priceListFeed _pricelists;
		private priceFeed _prices;
		private noteFeed _notes;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="commodityFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public commodityFeedEntrySchema()
		{
		}

		#region Properties


		[SMEStringProperty(Label="Commodity Application ID", Name="id", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual new System.String id { get { return _id; } set { SetProperty(Propertyid, ref _id, value); } }

		[SMEBoolProperty(Label="Commodity Active Flag", Name="active", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEBoolProperty(Label="Commodity Deleted", Name="deleted", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean deleted { get { return _deleted; } set { SetProperty(Propertydeleted, ref _deleted, value); } }

		[SMEStringProperty(Label="Commodity Label", Name="label", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String label { get { return _label; } set { SetProperty(Propertylabel, ref _label, value); } }

		[SMEResource(CanGet=true, PluralName="commodityGroups", Label="Commodity CommodityGroup")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Commodity CommodityGroup", Name="commodityGroup", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("commodityGroup")]			
		public virtual commodityGroupFeedEntry commodityGroup { get { return _commodityGroup; } set { SetProperty(PropertycommodityGroup, ref _commodityGroup, value); } }

		[SMEEnumProperty(EnumTypeName="commodityCommodityIdentifierType--enum", Label="Commodity CommodityIdentifier Type", Nillable=true, Name="commodityIdentifierType", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string commodityIdentifierType { get { return _commodityIdentifierType; } set { SetProperty(PropertycommodityIdentifierType, ref _commodityIdentifierType, value); } }

		[SMEResource(CanGet=true, PluralName="commodityIdentifiers", Label="Commodity CommodityIdentifier")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Label="Commodity CommodityIdentifier", Name="commodityIdentifiers", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual commodityIdentifierFeed commodityIdentifiers { get { return _commodityIdentifiers; } set { SetProperty(PropertycommodityIdentifiers, ref _commodityIdentifiers, value); } }

		[SMEStringProperty(Label="Commodity reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEStringProperty(Label="Commodity Reference2", Nillable=true, Name="reference2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="companies")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Commodity OperatingCompany", Name="operatingCompany", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("operatingCompany")]			
		public virtual companyFeedEntry operatingCompany { get { return _operatingCompany; } set { SetProperty(PropertyoperatingCompany, ref _operatingCompany, value); } }

		[SMEStringProperty(Label="Commodity Status", Nillable=true, Name="status", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String status { get { return _status; } set { SetProperty(Propertystatus, ref _status, value); } }

		[SMEStringProperty(Label="Commodity Name", Name="name", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String name { get { return _name; } set { SetProperty(Propertyname, ref _name, value); } }

		[SMEStringProperty(Label="Commodity Short Name", Nillable=true, Name="shortName", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String shortName { get { return _shortName; } set { SetProperty(PropertyshortName, ref _shortName, value); } }

		[SMEStringProperty(Label="Commodity Description", Nillable=true, Name="description", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String description { get { return _description; } set { SetProperty(Propertydescription, ref _description, value); } }

		[SMEStringProperty(Label="Commodity Alternative Description 1", Nillable=true, Name="alternativeDescription1", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String alternativeDescription1 { get { return _alternativeDescription1; } set { SetProperty(PropertyalternativeDescription1, ref _alternativeDescription1, value); } }

		[SMEStringProperty(Label="Commodity Alternative Description 2", Nillable=true, Name="alternativeDescription2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String alternativeDescription2 { get { return _alternativeDescription2; } set { SetProperty(PropertyalternativeDescription2, ref _alternativeDescription2, value); } }

		[SMEEnumProperty(EnumTypeName="commodityType--enum", Label="Commodity Type", Name="type", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }

		[SMEResource(CanGet=true, PluralName="unitsOfMeasure", Label="Commodity UnitOfMeasure")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Commodity UnitOfMeasure", Name="unitOfMeasure", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("unitOfMeasure")]			
		public virtual unitOfMeasureFeedEntry unitOfMeasure { get { return _unitOfMeasure; } set { SetProperty(PropertyunitOfMeasure, ref _unitOfMeasure, value); } }

		[SMEBoolProperty(Label="Commodity Buying Allowed Flag", Nillable=true, Name="buyingAllowedFlag", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Boolean> buyingAllowedFlag { get { return _buyingAllowedFlag; } set { SetProperty(PropertybuyingAllowedFlag, ref _buyingAllowedFlag, value); } }

		[SMEResource(CanGet=true, PluralName="unitsOfMeasure", Label="Commodity Buying UnitOfMeasure")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Commodity Buying UnitOfMeasure", Name="buyingUnitOfMeasure", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("buyingUnitOfMeasure")]			
		public virtual unitOfMeasureFeedEntry buyingUnitOfMeasure { get { return _buyingUnitOfMeasure; } set { SetProperty(PropertybuyingUnitOfMeasure, ref _buyingUnitOfMeasure, value); } }

		[SMEDecimalProperty(Label="Commodity Buying UnitOfMeasure Number", Nillable=true, Name="buyingUnitOfMeasureNumber", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> buyingUnitOfMeasureNumber { get { return _buyingUnitOfMeasureNumber; } set { SetProperty(PropertybuyingUnitOfMeasureNumber, ref _buyingUnitOfMeasureNumber, value); } }

		[SMEBoolProperty(Label="Commodity Selling Allowed Flag", Nillable=true, Name="sellingAllowedFlag", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Boolean> sellingAllowedFlag { get { return _sellingAllowedFlag; } set { SetProperty(PropertysellingAllowedFlag, ref _sellingAllowedFlag, value); } }

		[SMEResource(CanGet=true, PluralName="unitsOfMeasure", Label="Commodity Selling UnitOfMeasure")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Commodity Selling UnitOfMeasure", Name="sellingUnitOfMeasure", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("sellingUnitOfMeasure")]			
		public virtual unitOfMeasureFeedEntry sellingUnitOfMeasure { get { return _sellingUnitOfMeasure; } set { SetProperty(PropertysellingUnitOfMeasure, ref _sellingUnitOfMeasure, value); } }

		[SMEDecimalProperty(Label="Commodity Selling UnitOfMeasure Number", Nillable=true, Name="sellingUnitOfMeasureNumber", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> sellingUnitOfMeasureNumber { get { return _sellingUnitOfMeasureNumber; } set { SetProperty(PropertysellingUnitOfMeasureNumber, ref _sellingUnitOfMeasureNumber, value); } }

		[SMEResource(CanGet=true, PluralName="unitsOfMeasure", Label="Commodity Packing UnitOfMeasure")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Commodity Packing UnitOfMeasure", Name="packingUnitOfMeasure", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("packingUnitOfMeasure")]			
		public virtual unitOfMeasureFeedEntry packingUnitOfMeasure { get { return _packingUnitOfMeasure; } set { SetProperty(PropertypackingUnitOfMeasure, ref _packingUnitOfMeasure, value); } }

		[SMEDecimalProperty(Label="Commodity Packing UnitOfMeasure Number", Nillable=true, Name="packingUnitOfMeasureNumber", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> packingUnitOfMeasureNumber { get { return _packingUnitOfMeasureNumber; } set { SetProperty(PropertypackingUnitOfMeasureNumber, ref _packingUnitOfMeasureNumber, value); } }

		[SMEStringProperty(Label="Commodity Catalogue Number", Nillable=true, Name="catalogueNumber", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String catalogueNumber { get { return _catalogueNumber; } set { SetProperty(PropertycatalogueNumber, ref _catalogueNumber, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Commodity Supplier TradingAccount", Name="supplierTradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual tradingAccountFeed supplierTradingAccount { get { return _supplierTradingAccount; } set { SetProperty(PropertysupplierTradingAccount, ref _supplierTradingAccount, value); } }

		[SMEStringProperty(Label="Commodity Supplier reference", Nillable=true, Name="supplierReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String supplierReference { get { return _supplierReference; } set { SetProperty(PropertysupplierReference, ref _supplierReference, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="companies")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Commodity Manufacturer Company", Name="manufacturerCompany", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("manufacturerCompany")]			
		public virtual companyFeedEntry manufacturerCompany { get { return _manufacturerCompany; } set { SetProperty(PropertymanufacturerCompany, ref _manufacturerCompany, value); } }

		[SMEStringProperty(Label="Commodity Manufacturer reference", Nillable=true, Name="manufacturerReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String manufacturerReference { get { return _manufacturerReference; } set { SetProperty(PropertymanufacturerReference, ref _manufacturerReference, value); } }

		[SMEStringProperty(Label="Commodity Material", Nillable=true, Name="material", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String material { get { return _material; } set { SetProperty(Propertymaterial, ref _material, value); } }

		[SMEStringProperty(Label="Commodity Country Of Origin", Nillable=true, Name="countryOfOrigin", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String countryOfOrigin { get { return _countryOfOrigin; } set { SetProperty(PropertycountryOfOrigin, ref _countryOfOrigin, value); } }

		[SMEDecimalProperty(Label="Commodity Weight", Nillable=true, Name="weight", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> weight { get { return _weight; } set { SetProperty(Propertyweight, ref _weight, value); } }

		[SMEDecimalProperty(Label="Commodity Weight KG", Nillable=true, Name="weightKg", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> weightKg { get { return _weightKg; } set { SetProperty(PropertyweightKg, ref _weightKg, value); } }

		[SMEResource(PluralName="commodityVariants", Label="Commodity Variant")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Commodity Variant", Name="variant", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual commodityVariantFeedEntry variant { get { return _variant; } set { SetProperty(Propertyvariant, ref _variant, value); } }

		[SMEResource(PluralName="commodityDimensions", Label="Commodity Dimension")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Commodity Dimension", Name="dimension", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual commodityDimensionFeedEntry dimension { get { return _dimension; } set { SetProperty(Propertydimension, ref _dimension, value); } }

		[SMEStringProperty(Label="Commodity Classification", Nillable=true, Name="classification", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String classification { get { return _classification; } set { SetProperty(Propertyclassification, ref _classification, value); } }

		[SMEResource(CanGet=true, PluralName="taxCodes", Label="Commodity Tax Code")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Commodity Tax Code", Name="taxCodes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual taxCodeFeed taxCodes { get { return _taxCodes; } set { SetProperty(PropertytaxCodes, ref _taxCodes, value); } }

		[SMEResource(CanGet=true, PluralName="financialAccounts", Label="Commodity FinancialAccount")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Commodity FinancialAccount", Name="financialAccounts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual financialAccountFeed financialAccounts { get { return _financialAccounts; } set { SetProperty(PropertyfinancialAccounts, ref _financialAccounts, value); } }

		[SMEBoolProperty(Label="Commodity Duty Applicable Flag", Nillable=true, Name="dutyApplicableFlag", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Boolean> dutyApplicableFlag { get { return _dutyApplicableFlag; } set { SetProperty(PropertydutyApplicableFlag, ref _dutyApplicableFlag, value); } }

		[SMEDecimalProperty(Label="Commodity Duty Rate", Nillable=true, Name="dutyRate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> dutyRate { get { return _dutyRate; } set { SetProperty(PropertydutyRate, ref _dutyRate, value); } }

		[SMEStringProperty(Label="Commodity Trade Identification Number", Nillable=true, Name="tradeIdentificationNumber", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual System.String tradeIdentificationNumber { get { return _tradeIdentificationNumber; } set { SetProperty(PropertytradeIdentificationNumber, ref _tradeIdentificationNumber, value); } }

		[SMEResource(CanGet=true, PluralName="commodities", Label="Commodity Replacement")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Commodity Replacement", Name="replacement", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("replacement")]			
		public virtual commodityFeedEntry replacement { get { return _replacement; } set { SetProperty(Propertyreplacement, ref _replacement, value); } }

		[SMEDateProperty(Label="Commodity Replacement Date", Nillable=true, Name="replacementDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> replacementDate { get { return _replacementDate; } set { SetProperty(PropertyreplacementDate, ref _replacementDate, value); } }

		[SMEDecimalProperty(Label="Commodity Lead Time", Nillable=true, Name="leadTime", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> leadTime { get { return _leadTime; } set { SetProperty(PropertyleadTime, ref _leadTime, value); } }

		[SMEDecimalProperty(Label="Commodity Cost", Nillable=true, Name="cost", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> cost { get { return _cost; } set { SetProperty(Propertycost, ref _cost, value); } }

		[SMEResource(CanGet=true, PluralName="commodities", Label="Associated child Commodity")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Label="Associated child Commodity", Name="associatedChildCommodities", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual commodityFeed associatedChildCommodities { get { return _associatedChildCommodities; } set { SetProperty(PropertyassociatedChildCommodities, ref _associatedChildCommodities, value); } }

		[SMEResource(CanGet=true, PluralName="commodities", Label="Commodity Associated parent Commodity")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Parent, Label="Commodity Associated parent Commodity", Name="associatedParentCommodity", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("associatedParentCommodity")]			
		public virtual commodityFeedEntry associatedParentCommodity { get { return _associatedParentCommodity; } set { SetProperty(PropertyassociatedParentCommodity, ref _associatedParentCommodity, value); } }

		[SMEStringProperty(Label="Commodity Version", Nillable=true, Name="version", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String version { get { return _version; } set { SetProperty(Propertyversion, ref _version, value); } }

		[SMEEnumProperty(EnumTypeName="commodityCommissionType--enum", Label="Commodity Commission Type", Nillable=true, Name="commissionType", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string commissionType { get { return _commissionType; } set { SetProperty(PropertycommissionType, ref _commissionType, value); } }

		[SMEDecimalProperty(Label="Commodity Commission Amount", Nillable=true, Name="commissionAmount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> commissionAmount { get { return _commissionAmount; } set { SetProperty(PropertycommissionAmount, ref _commissionAmount, value); } }

		[SMEDecimalProperty(Label="Commodity Commission Percent", Nillable=true, Name="commissionPercent", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> commissionPercent { get { return _commissionPercent; } set { SetProperty(PropertycommissionPercent, ref _commissionPercent, value); } }

		[SMEResource(CanGet=true, PluralName="interactions", Label="Commodity Interaction")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Commodity Interaction", Name="interactions", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual interactionFeed interactions { get { return _interactions; } set { SetProperty(Propertyinteractions, ref _interactions, value); } }

		[SMEResource(CanGet=true, PluralName="opportunities", Label="Commodity Opportunity")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Commodity Opportunity", Name="opportunities", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual opportunityFeed opportunities { get { return _opportunities; } set { SetProperty(Propertyopportunities, ref _opportunities, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, PluralName="salesQuotationLines", Label="Commodity Sales Quotation Line")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Commodity Sales Quotation Line", Name="salesQuotationLines", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesQuotationLineFeed salesQuotationLines { get { return _salesQuotationLines; } set { SetProperty(PropertysalesQuotationLines, ref _salesQuotationLines, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, PluralName="salesOrderLines", Label="Commodity Sales Order Line")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Commodity Sales Order Line", Name="salesOrderLines", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesOrderLineFeed salesOrderLines { get { return _salesOrderLines; } set { SetProperty(PropertysalesOrderLines, ref _salesOrderLines, value); } }

		[SMEResource(CanGet=true, PluralName="salesOrderDeliveryLines", Label="Commodity Sales Order Delivery Line")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Commodity Sales Order Delivery Line", Name="salesOrderDeliveryLines", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesOrderDeliveryLineFeed salesOrderDeliveryLines { get { return _salesOrderDeliveryLines; } set { SetProperty(PropertysalesOrderDeliveryLines, ref _salesOrderDeliveryLines, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, PluralName="salesInvoiceLines", Label="Commodity Sales Invoice Line")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Commodity Sales Invoice Line", Name="salesInvoiceLines", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesInvoiceLineFeed salesInvoiceLines { get { return _salesInvoiceLines; } set { SetProperty(PropertysalesInvoiceLines, ref _salesInvoiceLines, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, PluralName="salesReturnLines", Label="Commodity Sales Return Line")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Commodity Sales Return Line", Name="salesReturnLines", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesReturnLineFeed salesReturnLines { get { return _salesReturnLines; } set { SetProperty(PropertysalesReturnLines, ref _salesReturnLines, value); } }

		[SMEResource(CanGet=true, PluralName="salesReturnDeliveryLines", Label="Commodity Sales Return Delivery Line")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Commodity Sales Return Delivery Line", Name="salesReturnDeliveryLines", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesReturnDeliveryLineFeed salesReturnDeliveryLines { get { return _salesReturnDeliveryLines; } set { SetProperty(PropertysalesReturnDeliveryLines, ref _salesReturnDeliveryLines, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, PluralName="salesCreditLines", Label="Commodity Sales Credit Line")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Commodity Sales Credit Line", Name="salesCreditLines", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesCreditLineFeed salesCreditLines { get { return _salesCreditLines; } set { SetProperty(PropertysalesCreditLines, ref _salesCreditLines, value); } }

		[SMEResource(CanGet=true, CanPost=true, PluralName="purchaseRequisitionLines", Label="Commodity Purchase Requisition Line")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Commodity Purchase Requisition Line", Name="purchaseRequisitionLines", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseRequisitionLineFeed purchaseRequisitionLines { get { return _purchaseRequisitionLines; } set { SetProperty(PropertypurchaseRequisitionLines, ref _purchaseRequisitionLines, value); } }

		[SMEResource(CanGet=true, CanPost=true, PluralName="purchaseOrderLines", Label="Commodity Purchase Order Line")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Commodity Purchase Order Line", Name="purchaseOrderLines", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseOrderLineFeed purchaseOrderLines { get { return _purchaseOrderLines; } set { SetProperty(PropertypurchaseOrderLines, ref _purchaseOrderLines, value); } }

		[SMEResource(CanGet=true, PluralName="purchaseOrderDeliveryLines", Label="Commodity Purchase Order Delivery Line")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Commodity Purchase Order Delivery Line", Name="purchaseOrderDeliveryLines", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseOrderDeliveryLineFeed purchaseOrderDeliveryLines { get { return _purchaseOrderDeliveryLines; } set { SetProperty(PropertypurchaseOrderDeliveryLines, ref _purchaseOrderDeliveryLines, value); } }

		[SMEResource(CanGet=true, CanPost=true, PluralName="purchaseInvoiceLines", Label="Commodity Purchase Invoice Line")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Commodity Purchase Invoice Line", Name="purchaseInvoiceLines", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseInvoiceLineFeed purchaseInvoiceLines { get { return _purchaseInvoiceLines; } set { SetProperty(PropertypurchaseInvoiceLines, ref _purchaseInvoiceLines, value); } }

		[SMEResource(CanGet=true, PluralName="purchaseReturnLines", Label="Commodity Purchase Return Line")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Commodity Purchase Return Line", Name="purchaseReturnLines", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseReturnLineFeed purchaseReturnLines { get { return _purchaseReturnLines; } set { SetProperty(PropertypurchaseReturnLines, ref _purchaseReturnLines, value); } }

		[SMEResource(CanGet=true, PluralName="purchaseReturnDeliveryLines", Label="Commodity Purchase Return Delivery Line")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Commodity Purchase Return Delivery Line", Name="purchaseReturnDeliveryLines", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseReturnDeliveryLineFeed purchaseReturnDeliveryLines { get { return _purchaseReturnDeliveryLines; } set { SetProperty(PropertypurchaseReturnDeliveryLines, ref _purchaseReturnDeliveryLines, value); } }

		[SMEResource(CanGet=true, PluralName="purchaseCreditLines", Label="Commodity Purchase Credit Line")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Commodity Purchase Credit Line", Name="purchaseCreditLines", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseCreditLineFeed purchaseCreditLines { get { return _purchaseCreditLines; } set { SetProperty(PropertypurchaseCreditLines, ref _purchaseCreditLines, value); } }

		[SMEResource(CanGet=true, PluralName="receiptLines", Label="Commodity Receipt Line")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Commodity Receipt Line", Name="receiptLines", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual receiptLineFeed receiptLines { get { return _receiptLines; } set { SetProperty(PropertyreceiptLines, ref _receiptLines, value); } }

		[SMEResource(CanGet=true, PluralName="cases", Label="Commodity Case")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Commodity Case", Name="cases", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual caseFeed cases { get { return _cases; } set { SetProperty(Propertycases, ref _cases, value); } }

		[SMEResource(CanGet=true, PluralName="priceLists", Label="Commodity Price List")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Commodity Price List", Name="pricelists", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual priceListFeed pricelists { get { return _pricelists; } set { SetProperty(Propertypricelists, ref _pricelists, value); } }

		[SMEResource(CanGet=true, PluralName="prices", Label="Commodity Price")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Commodity Price", Name="prices", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual priceFeed prices { get { return _prices; } set { SetProperty(Propertyprices, ref _prices, value); } }

		[SMEResource(CanGet=true, PluralName="notes")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Label="Commodity Note", Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual noteFeed notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		#endregion


	}
}