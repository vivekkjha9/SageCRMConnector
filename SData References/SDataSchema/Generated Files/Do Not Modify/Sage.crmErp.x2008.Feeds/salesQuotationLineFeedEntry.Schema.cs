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
	/// Defines a salesQuotationLine feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("salesQuotationLine", Namespace="http://schemas.sage.com/crmErp/2008")]
		[SMEResource(CanGet=true, CanPost=true, CanPut=true, PluralName="salesQuotationLines")]
	public class salesQuotationLineFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyuuid = "uuid";
		public const string Propertyid = "id";
		public const string Propertylabel = "label";
		public const string Propertyactive = "active";
		public const string Propertydeleted = "deleted";
		public const string Propertyreference = "reference";
		public const string Propertyreference2 = "reference2";
		public const string Propertynumber = "number";
		public const string Propertystatus = "status";
		public const string Propertytype = "type";
		public const string PropertydeliveryTerms = "deliveryTerms";
		public const string Propertycommodity = "commodity";
		public const string Propertytext = "text";
		public const string PropertycommodityVariant = "commodityVariant";
		public const string PropertycommodityDimension = "commodityDimension";
		public const string PropertyassociatedCommodity = "associatedCommodity";
		public const string PropertyfulfillmentLocation = "fulfillmentLocation";
		public const string PropertydeliveryDate = "deliveryDate";
		public const string PropertydueDate = "dueDate";
		public const string PropertyunitOfMeasure = "unitOfMeasure";
		public const string Propertyquantity = "quantity";
		public const string PropertyinitialPrice = "initialPrice";
		public const string Propertypricelist = "pricelist";
		public const string PropertypostalAddresses = "postalAddresses";
		public const string PropertyorderLineDiscountType = "orderLineDiscountType";
		public const string PropertyorderLineDiscountAmount = "orderLineDiscountAmount";
		public const string PropertyorderLineDiscountPercent = "orderLineDiscountPercent";
		public const string PropertyorderLineSubtotalDiscountType = "orderLineSubtotalDiscountType";
		public const string PropertyorderLineSubtotalDiscountAmount = "orderLineSubtotalDiscountAmount";
		public const string PropertyorderLineSubtotalDiscountPercent = "orderLineSubtotalDiscountPercent";
		public const string PropertyactualPrice = "actualPrice";
		public const string PropertynetTotal = "netTotal";
		public const string PropertychargesTotal = "chargesTotal";
		public const string PropertydiscountTotal = "discountTotal";
		public const string PropertytaxCodes = "taxCodes";
		public const string PropertypriceTax = "priceTax";
		public const string PropertytaxTotal = "taxTotal";
		public const string PropertygrossTotal = "grossTotal";
		public const string PropertycostTotal = "costTotal";
		public const string PropertyprofitTotal = "profitTotal";
		public const string PropertybuyerContact = "buyerContact";
		public const string Propertyproject = "project";
		public const string PropertyprojectLine = "projectLine";
		public const string PropertybOMLine = "bOMLine";
		public const string PropertyfinancialAccounts = "financialAccounts";
		public const string Propertynotes = "notes";

		#endregion

		#region Fields

		private string _uuid;
		private System.String _id;
		private System.String _label;
		private System.Boolean _active;
		private System.Boolean _deleted;
		private System.String _reference;
		private System.String _reference2;
		private System.Decimal _number;
		private string _status;
		private string _type;
		private System.String _deliveryTerms;
		private commodityFeedEntry _commodity;
		private System.String _text;
		private commodityVariantFeedEntry _commodityVariant;
		private commodityDimensionFeedEntry _commodityDimension;
		private commodityFeedEntry _associatedCommodity;
		private locationFeedEntry _fulfillmentLocation;
		private Nullable<System.DateTime> _deliveryDate;
		private Nullable<System.DateTime> _dueDate;
		private unitOfMeasureFeedEntry _unitOfMeasure;
		private System.Decimal _quantity;
		private System.Decimal _initialPrice;
		private priceListFeedEntry _pricelist;
		private postalAddressFeed _postalAddresses;
		private string _orderLineDiscountType;
		private Nullable<System.Decimal> _orderLineDiscountAmount;
		private Nullable<System.Decimal> _orderLineDiscountPercent;
		private string _orderLineSubtotalDiscountType;
		private Nullable<System.Decimal> _orderLineSubtotalDiscountAmount;
		private Nullable<System.Decimal> _orderLineSubtotalDiscountPercent;
		private System.Decimal _actualPrice;
		private System.Decimal _netTotal;
		private Nullable<System.Decimal> _chargesTotal;
		private System.Decimal _discountTotal;
		private taxCodeFeed _taxCodes;
		private Nullable<System.Decimal> _priceTax;
		private System.Decimal _taxTotal;
		private System.Decimal _grossTotal;
		private Nullable<System.Decimal> _costTotal;
		private Nullable<System.Decimal> _profitTotal;
		private contactFeedEntry _buyerContact;
		private projectFeedEntry _project;
		private projectLineFeedEntry _projectLine;
		private System.String _bOMLine;
		private financialAccountFeed _financialAccounts;
		private noteFeed _notes;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="salesQuotationLineFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public salesQuotationLineFeedEntrySchema()
		{
		}

		#region Properties


		[SMEEnumProperty(EnumTypeName="uuid--type", Label="SalesQuotationLine Global ID", Pattern="[0-9a-fA-F-]+", Name="uuid", Namespace="http://schemas.sage.com/crmErp/2008", IsUniqueKey=true)]			
		public virtual new string uuid { get { return _uuid; } set { SetProperty(Propertyuuid, ref _uuid, value); } }

		[SMEStringProperty(Label="SalesQuotationLine Application ID", Name="id", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual new System.String id { get { return _id; } set { SetProperty(Propertyid, ref _id, value); } }

		[SMEStringProperty(Label="SalesQuotationLine Label", Name="label", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String label { get { return _label; } set { SetProperty(Propertylabel, ref _label, value); } }

		[SMEBoolProperty(Label="SalesQuotationLine Active Flag", Name="active", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEBoolProperty(Label="SalesQuotationLine Deleted", Name="deleted", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean deleted { get { return _deleted; } set { SetProperty(Propertydeleted, ref _deleted, value); } }

		[SMEStringProperty(Label="SalesQuotationLine reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEStringProperty(Label="SalesQuotationLine Reference2", Nillable=true, Name="reference2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }

		[SMEDecimalProperty(Label="SalesQuotationLine Number", Name="number", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal number { get { return _number; } set { SetProperty(Propertynumber, ref _number, value); } }

		[SMEEnumProperty(EnumTypeName="salesQuotationStatus--enum", Label="SalesQuotationLine Status", Nillable=true, Name="status", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string status { get { return _status; } set { SetProperty(Propertystatus, ref _status, value); } }

		[SMEEnumProperty(EnumTypeName="lineType--enum", Label="SalesQuotationLine Type", Nillable=true, Name="type", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }

		[SMEStringProperty(Label="SalesQuotationLine Delivery Terms", Nillable=true, Name="deliveryTerms", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String deliveryTerms { get { return _deliveryTerms; } set { SetProperty(PropertydeliveryTerms, ref _deliveryTerms, value); } }

		[SMEResource(CanGet=true, PluralName="commodities", Label="SalesQuotationLine Commodity")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="SalesQuotationLine Commodity", Name="commodity", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("commodity")]			
		public virtual commodityFeedEntry commodity { get { return _commodity; } set { SetProperty(Propertycommodity, ref _commodity, value); } }

		[SMEStringProperty(Label="SalesQuotationLine Text", Nillable=true, Name="text", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String text { get { return _text; } set { SetProperty(Propertytext, ref _text, value); } }

		[SMEResource(PluralName="commodityVariants", Label="SalesQuotationLine Commodity Variant")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="SalesQuotationLine Commodity Variant", Name="commodityVariant", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("commodityVariant")]			
		public virtual commodityVariantFeedEntry commodityVariant { get { return _commodityVariant; } set { SetProperty(PropertycommodityVariant, ref _commodityVariant, value); } }

		[SMEResource(PluralName="commodityDimensions", Label="SalesQuotationLine Commodity Dimension")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="SalesQuotationLine Commodity Dimension", Name="commodityDimension", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("commodityDimension")]			
		public virtual commodityDimensionFeedEntry commodityDimension { get { return _commodityDimension; } set { SetProperty(PropertycommodityDimension, ref _commodityDimension, value); } }

		[SMEResource(CanGet=true, PluralName="commodities", Label="SalesQuotationLine Associated Commodity")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="SalesQuotationLine Associated Commodity", Name="associatedCommodity", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("associatedCommodity")]			
		public virtual commodityFeedEntry associatedCommodity { get { return _associatedCommodity; } set { SetProperty(PropertyassociatedCommodity, ref _associatedCommodity, value); } }

		[SMEResource(CanGet=true, PluralName="locations", Label="SalesQuotationLine Fulfillment Location")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="SalesQuotationLine Fulfillment Location", Name="fulfillmentLocation", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("fulfillmentLocation")]			
		public virtual locationFeedEntry fulfillmentLocation { get { return _fulfillmentLocation; } set { SetProperty(PropertyfulfillmentLocation, ref _fulfillmentLocation, value); } }

		[SMEDateProperty(Label="SalesQuotationLine Delivery Date", Nillable=true, Name="deliveryDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> deliveryDate { get { return _deliveryDate; } set { SetProperty(PropertydeliveryDate, ref _deliveryDate, value); } }

		[SMEDateProperty(Label="SalesQuotationLine Due Date", Nillable=true, Name="dueDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> dueDate { get { return _dueDate; } set { SetProperty(PropertydueDate, ref _dueDate, value); } }

		[SMEResource(CanGet=true, PluralName="unitsOfMeasure", Label="SalesQuotationLine UnitOfMeasure")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="SalesQuotationLine UnitOfMeasure", Name="unitOfMeasure", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("unitOfMeasure")]			
		public virtual unitOfMeasureFeedEntry unitOfMeasure { get { return _unitOfMeasure; } set { SetProperty(PropertyunitOfMeasure, ref _unitOfMeasure, value); } }

		[SMEDecimalProperty(Label="SalesQuotationLine Quantity", Name="quantity", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal quantity { get { return _quantity; } set { SetProperty(Propertyquantity, ref _quantity, value); } }

		[SMEDecimalProperty(Label="SalesQuotationLine Initial Price", Name="initialPrice", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal initialPrice { get { return _initialPrice; } set { SetProperty(PropertyinitialPrice, ref _initialPrice, value); } }

		[SMEResource(CanGet=true, PluralName="priceLists", Label="SalesQuotationLine PriceList")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="SalesQuotationLine PriceList", Name="pricelist", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("pricelist")]			
		public virtual priceListFeedEntry pricelist { get { return _pricelist; } set { SetProperty(Propertypricelist, ref _pricelist, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="postalAddresses")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="SalesQuotationLine PostalAddress", Name="postalAddresses", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual postalAddressFeed postalAddresses { get { return _postalAddresses; } set { SetProperty(PropertypostalAddresses, ref _postalAddresses, value); } }

		[SMEEnumProperty(EnumTypeName="discountType--enum", Label="SalesQuotationLine Order Line Discount Type", Nillable=true, Name="orderLineDiscountType", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string orderLineDiscountType { get { return _orderLineDiscountType; } set { SetProperty(PropertyorderLineDiscountType, ref _orderLineDiscountType, value); } }

		[SMEDecimalProperty(Label="SalesQuotationLine Order Line Discount Amount", Nillable=true, Name="orderLineDiscountAmount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> orderLineDiscountAmount { get { return _orderLineDiscountAmount; } set { SetProperty(PropertyorderLineDiscountAmount, ref _orderLineDiscountAmount, value); } }

		[SMEDecimalProperty(Label="SalesQuotationLine Order Line Discount Percent", Nillable=true, Name="orderLineDiscountPercent", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> orderLineDiscountPercent { get { return _orderLineDiscountPercent; } set { SetProperty(PropertyorderLineDiscountPercent, ref _orderLineDiscountPercent, value); } }

		[SMEEnumProperty(EnumTypeName="discountType--enum", Label="SalesQuotationLine Order Line Subtotal Discount Type", Nillable=true, Name="orderLineSubtotalDiscountType", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string orderLineSubtotalDiscountType { get { return _orderLineSubtotalDiscountType; } set { SetProperty(PropertyorderLineSubtotalDiscountType, ref _orderLineSubtotalDiscountType, value); } }

		[SMEDecimalProperty(Label="SalesQuotationLine Order Line Subtotal Discount Amount", Nillable=true, Name="orderLineSubtotalDiscountAmount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> orderLineSubtotalDiscountAmount { get { return _orderLineSubtotalDiscountAmount; } set { SetProperty(PropertyorderLineSubtotalDiscountAmount, ref _orderLineSubtotalDiscountAmount, value); } }

		[SMEDecimalProperty(Label="SalesQuotationLine Order Line Subtotal Discount Percent", Nillable=true, Name="orderLineSubtotalDiscountPercent", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> orderLineSubtotalDiscountPercent { get { return _orderLineSubtotalDiscountPercent; } set { SetProperty(PropertyorderLineSubtotalDiscountPercent, ref _orderLineSubtotalDiscountPercent, value); } }

		[SMEDecimalProperty(Label="SalesQuotationLine Actual Price", Name="actualPrice", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal actualPrice { get { return _actualPrice; } set { SetProperty(PropertyactualPrice, ref _actualPrice, value); } }

		[SMEDecimalProperty(Label="SalesQuotationLine Net Total", Name="netTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal netTotal { get { return _netTotal; } set { SetProperty(PropertynetTotal, ref _netTotal, value); } }

		[SMEDecimalProperty(Label="SalesQuotationLine Charges Total", Nillable=true, Name="chargesTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> chargesTotal { get { return _chargesTotal; } set { SetProperty(PropertychargesTotal, ref _chargesTotal, value); } }

		[SMEDecimalProperty(Label="SalesQuotationLine Discount Total", Name="discountTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal discountTotal { get { return _discountTotal; } set { SetProperty(PropertydiscountTotal, ref _discountTotal, value); } }

		[SMEResource(CanGet=true, PluralName="taxCodes", Label="SalesQuotationLine Tax Code")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="SalesQuotationLine Tax Code", Name="taxCodes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual taxCodeFeed taxCodes { get { return _taxCodes; } set { SetProperty(PropertytaxCodes, ref _taxCodes, value); } }

		[SMEDecimalProperty(Label="SalesQuotationLine Price Tax", Nillable=true, Name="priceTax", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> priceTax { get { return _priceTax; } set { SetProperty(PropertypriceTax, ref _priceTax, value); } }

		[SMEDecimalProperty(Label="SalesQuotationLine Tax Total", Name="taxTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal taxTotal { get { return _taxTotal; } set { SetProperty(PropertytaxTotal, ref _taxTotal, value); } }

		[SMEDecimalProperty(Label="SalesQuotationLine Gross Total", Name="grossTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal grossTotal { get { return _grossTotal; } set { SetProperty(PropertygrossTotal, ref _grossTotal, value); } }

		[SMEDecimalProperty(Label="SalesQuotationLine Cost Total", Nillable=true, Name="costTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> costTotal { get { return _costTotal; } set { SetProperty(PropertycostTotal, ref _costTotal, value); } }

		[SMEDecimalProperty(Label="SalesQuotationLine Profit Total", Nillable=true, Name="profitTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> profitTotal { get { return _profitTotal; } set { SetProperty(PropertyprofitTotal, ref _profitTotal, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="contacts", Label="SalesQuotationLine Buyer Contact")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="SalesQuotationLine Buyer Contact", Name="buyerContact", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("buyerContact")]			
		public virtual contactFeedEntry buyerContact { get { return _buyerContact; } set { SetProperty(PropertybuyerContact, ref _buyerContact, value); } }

		[SMEResource(CanGet=true, PluralName="projects", Label="SalesQuotationLine Project")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="SalesQuotationLine Project", Name="project", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("project")]			
		public virtual projectFeedEntry project { get { return _project; } set { SetProperty(Propertyproject, ref _project, value); } }

		[SMEResource(CanGet=true, PluralName="projectLines", Label="SalesQuotationLine ProjectLine")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="SalesQuotationLine ProjectLine", Name="projectLine", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("projectLine")]			
		public virtual projectLineFeedEntry projectLine { get { return _projectLine; } set { SetProperty(PropertyprojectLine, ref _projectLine, value); } }

		[SMEStringProperty(Label="SalesQuotationLine BOM Line", Nillable=true, Name="bOMLine", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String bOMLine { get { return _bOMLine; } set { SetProperty(PropertybOMLine, ref _bOMLine, value); } }

		[SMEResource(CanGet=true, PluralName="financialAccounts", Label="SalesQuotationLine FinancialAccount")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="SalesQuotationLine FinancialAccount", Name="financialAccounts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual financialAccountFeed financialAccounts { get { return _financialAccounts; } set { SetProperty(PropertyfinancialAccounts, ref _financialAccounts, value); } }

		[SMEResource(CanGet=true, PluralName="notes")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Label="SalesQuotationLine Note", Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual noteFeed notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		#endregion


	}
}