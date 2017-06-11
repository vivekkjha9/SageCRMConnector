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
	/// Defines a salesOrderDeliveryLine feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("salesOrderDeliveryLine", Namespace="http://schemas.sage.com/crmErp/2008")]
		[SMEResource(CanGet=true, PluralName="salesOrderDeliveryLines")]
	public class salesOrderDeliveryLineFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string PropertysalesOrderDelivery = "salesOrderDelivery";
		public const string Propertylabel = "label";
		public const string Propertyuuid = "uuid";
		public const string Propertyid = "id";
		public const string Propertyactive = "active";
		public const string Propertydeleted = "deleted";
		public const string Propertyreference = "reference";
		public const string Propertyreference2 = "reference2";
		public const string Propertynumber = "number";
		public const string Propertystatus = "status";
		public const string Propertytype = "type";
		public const string Propertycommodity = "commodity";
		public const string Propertytext = "text";
		public const string PropertycommodityVariant = "commodityVariant";
		public const string PropertycommodityDimension = "commodityDimension";
		public const string PropertyfulfillmentLocation = "fulfillmentLocation";
		public const string PropertyfulfillmentSubLocation = "fulfillmentSubLocation";
		public const string PropertyrequestedDeliveryDate = "requestedDeliveryDate";
		public const string PropertyactualDeliveryDate = "actualDeliveryDate";
		public const string PropertyactualDeliveryTime = "actualDeliveryTime";
		public const string PropertydateExceptionReason = "dateExceptionReason";
		public const string PropertyunitOfMeasure = "unitOfMeasure";
		public const string PropertyrequestedQuantity = "requestedQuantity";
		public const string PropertydeliveredQuantity = "deliveredQuantity";
		public const string PropertyinitialPrice = "initialPrice";
		public const string Propertypricelist = "pricelist";
		public const string PropertydeliveryLineDiscountType = "deliveryLineDiscountType";
		public const string PropertydeliveryLineDiscountAmount = "deliveryLineDiscountAmount";
		public const string PropertydeliveryLineDiscountPercent = "deliveryLineDiscountPercent";
		public const string PropertydeliveryLineSubtotalDiscountType = "deliveryLineSubtotalDiscountType";
		public const string PropertydeliveryLineSubtotalDiscountAmount = "deliveryLineSubtotalDiscountAmount";
		public const string PropertydeliveryLineSubtotalDiscountPercent = "deliveryLineSubtotalDiscountPercent";
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
		public const string PropertysalesInvoiceLines = "salesInvoiceLines";
		public const string Propertyreceipts = "receipts";
		public const string PropertyfinancialAccounts = "financialAccounts";
		public const string Propertynotes = "notes";

		#endregion

		#region Fields

		private salesOrderDeliveryFeedEntry _salesOrderDelivery;
		private System.String _label;
		private string _uuid;
		private System.String _id;
		private System.Boolean _active;
		private System.Boolean _deleted;
		private System.String _reference;
		private System.String _reference2;
		private System.Decimal _number;
		private string _status;
		private string _type;
		private commodityFeedEntry _commodity;
		private System.String _text;
		private commodityVariantFeedEntry _commodityVariant;
		private commodityDimensionFeedEntry _commodityDimension;
		private locationFeedEntry _fulfillmentLocation;
		private locationFeedEntry _fulfillmentSubLocation;
		private Nullable<System.DateTime> _requestedDeliveryDate;
		private System.DateTime _actualDeliveryDate;
		private Nullable<System.DateTime> _actualDeliveryTime;
		private System.String _dateExceptionReason;
		private unitOfMeasureFeedEntry _unitOfMeasure;
		private Nullable<System.Decimal> _requestedQuantity;
		private System.Decimal _deliveredQuantity;
		private System.Decimal _initialPrice;
		private priceListFeedEntry _pricelist;
		private string _deliveryLineDiscountType;
		private Nullable<System.Decimal> _deliveryLineDiscountAmount;
		private Nullable<System.Decimal> _deliveryLineDiscountPercent;
		private string _deliveryLineSubtotalDiscountType;
		private Nullable<System.Decimal> _deliveryLineSubtotalDiscountAmount;
		private Nullable<System.Decimal> _deliveryLineSubtotalDiscountPercent;
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
		private salesInvoiceLineFeed _salesInvoiceLines;
		private receiptFeed _receipts;
		private financialAccountFeed _financialAccounts;
		private noteFeed _notes;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="salesOrderDeliveryLineFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public salesOrderDeliveryLineFeedEntrySchema()
		{
		}

		#region Properties


		[SMEResource(CanGet=true, PluralName="salesOrderDeliveries", Label="SalesOrderDeliveryLine SalesOrderDelivery")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Parent, Label="SalesOrderDeliveryLine SalesOrderDelivery", Name="salesOrderDelivery", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("salesOrderDelivery")]			
		public virtual salesOrderDeliveryFeedEntry salesOrderDelivery { get { return _salesOrderDelivery; } set { SetProperty(PropertysalesOrderDelivery, ref _salesOrderDelivery, value); } }

		[SMEStringProperty(Label="SalesOrderDeliveryLine Label", Name="label", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String label { get { return _label; } set { SetProperty(Propertylabel, ref _label, value); } }

		[SMEEnumProperty(EnumTypeName="uuid--type", Label="SalesOrderDeliveryLine Global ID", Pattern="[0-9a-fA-F-]+", Name="uuid", Namespace="http://schemas.sage.com/crmErp/2008", IsUniqueKey=true)]			
		public virtual new string uuid { get { return _uuid; } set { SetProperty(Propertyuuid, ref _uuid, value); } }

		[SMEStringProperty(Label="SalesOrderDeliveryLine Application ID", Name="id", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual new System.String id { get { return _id; } set { SetProperty(Propertyid, ref _id, value); } }

		[SMEBoolProperty(Label="SalesOrderDeliveryLine Active Flag", Name="active", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEBoolProperty(Label="SalesOrderDeliveryLine Deleted", Name="deleted", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean deleted { get { return _deleted; } set { SetProperty(Propertydeleted, ref _deleted, value); } }

		[SMEStringProperty(Label="SalesOrderDeliveryLine reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEStringProperty(Label="SalesOrderDeliveryLine Reference2", Nillable=true, Name="reference2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }

		[SMEDecimalProperty(Label="SalesOrderDeliveryLine Number", Name="number", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal number { get { return _number; } set { SetProperty(Propertynumber, ref _number, value); } }

		[SMEEnumProperty(EnumTypeName="salesOrderDeliveryLineStatus--enum", Label="SalesOrderDeliveryLine Status", Nillable=true, Name="status", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string status { get { return _status; } set { SetProperty(Propertystatus, ref _status, value); } }

		[SMEEnumProperty(EnumTypeName="lineType--enum", Label="SalesOrderDeliveryLine Type", Nillable=true, Name="type", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }

		[SMEResource(CanGet=true, PluralName="commodities", Label="SalesOrderDeliveryLine Commodity")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="SalesOrderDeliveryLine Commodity", Name="commodity", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("commodity")]			
		public virtual commodityFeedEntry commodity { get { return _commodity; } set { SetProperty(Propertycommodity, ref _commodity, value); } }

		[SMEStringProperty(Label="SalesOrderDeliveryLine Text", Nillable=true, Name="text", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String text { get { return _text; } set { SetProperty(Propertytext, ref _text, value); } }

		[SMEResource(PluralName="commodityVariants", Label="SalesOrderDeliveryLine Commodity Variant")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="SalesOrderDeliveryLine Commodity Variant", Name="commodityVariant", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("commodityVariant")]			
		public virtual commodityVariantFeedEntry commodityVariant { get { return _commodityVariant; } set { SetProperty(PropertycommodityVariant, ref _commodityVariant, value); } }

		[SMEResource(PluralName="commodityDimensions", Label="SalesOrderDeliveryLine Commodity Dimension")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="SalesOrderDeliveryLine Commodity Dimension", Name="commodityDimension", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("commodityDimension")]			
		public virtual commodityDimensionFeedEntry commodityDimension { get { return _commodityDimension; } set { SetProperty(PropertycommodityDimension, ref _commodityDimension, value); } }

		[SMEResource(CanGet=true, PluralName="locations", Label="SalesOrderDeliveryLine Fulfillment Location")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="SalesOrderDeliveryLine Fulfillment Location", Name="fulfillmentLocation", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("fulfillmentLocation")]			
		public virtual locationFeedEntry fulfillmentLocation { get { return _fulfillmentLocation; } set { SetProperty(PropertyfulfillmentLocation, ref _fulfillmentLocation, value); } }

		[SMEResource(CanGet=true, PluralName="locations", Label="SalesOrderDeliveryLine Fulfilment Sub-Location")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="SalesOrderDeliveryLine Fulfilment Sub-Location", Name="fulfillmentSubLocation", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("fulfillmentSubLocation")]			
		public virtual locationFeedEntry fulfillmentSubLocation { get { return _fulfillmentSubLocation; } set { SetProperty(PropertyfulfillmentSubLocation, ref _fulfillmentSubLocation, value); } }

		[SMEDateProperty(Label="Sales OrderDeliveryLine Requested Delivery Date", Nillable=true, Name="requestedDeliveryDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> requestedDeliveryDate { get { return _requestedDeliveryDate; } set { SetProperty(PropertyrequestedDeliveryDate, ref _requestedDeliveryDate, value); } }

		[SMEDateProperty(Label="SalesOrderDeliveryLine Actual Delivery Date", Name="actualDeliveryDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.DateTime actualDeliveryDate { get { return _actualDeliveryDate; } set { SetProperty(PropertyactualDeliveryDate, ref _actualDeliveryDate, value); } }

		[SMETimeProperty(Label="SalesOrderDeliveryLine Actual Delivery Time", Nillable=true, Name="actualDeliveryTime", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> actualDeliveryTime { get { return _actualDeliveryTime; } set { SetProperty(PropertyactualDeliveryTime, ref _actualDeliveryTime, value); } }

		[SMEStringProperty(Label="SalesOrderDeliveryLine Date Exception Reason", Nillable=true, Name="dateExceptionReason", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String dateExceptionReason { get { return _dateExceptionReason; } set { SetProperty(PropertydateExceptionReason, ref _dateExceptionReason, value); } }

		[SMEResource(CanGet=true, PluralName="unitsOfMeasure", Label="SalesOrderDeliveryLine UnitOfMeasure")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="SalesOrderDeliveryLine UnitOfMeasure", Name="unitOfMeasure", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("unitOfMeasure")]			
		public virtual unitOfMeasureFeedEntry unitOfMeasure { get { return _unitOfMeasure; } set { SetProperty(PropertyunitOfMeasure, ref _unitOfMeasure, value); } }

		[SMEDecimalProperty(Label="SalesOrderDeliveryLine Requested Quantity", Nillable=true, Name="requestedQuantity", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> requestedQuantity { get { return _requestedQuantity; } set { SetProperty(PropertyrequestedQuantity, ref _requestedQuantity, value); } }

		[SMEDecimalProperty(Label="SalesOrderDeliveryLine Delivered Quantity", Name="deliveredQuantity", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal deliveredQuantity { get { return _deliveredQuantity; } set { SetProperty(PropertydeliveredQuantity, ref _deliveredQuantity, value); } }

		[SMEDecimalProperty(Label="SalesOrderDeliveryLine Initial Price", Name="initialPrice", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal initialPrice { get { return _initialPrice; } set { SetProperty(PropertyinitialPrice, ref _initialPrice, value); } }

		[SMEResource(CanGet=true, PluralName="priceLists", Label="SalesOrderDeliveryLine PriceList")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="SalesOrderDeliveryLine PriceList", Name="pricelist", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("pricelist")]			
		public virtual priceListFeedEntry pricelist { get { return _pricelist; } set { SetProperty(Propertypricelist, ref _pricelist, value); } }

		[SMEEnumProperty(EnumTypeName="discountType--enum", Label="SalesOrderDeliveryLine Delivery Line Discount Type", Nillable=true, Name="deliveryLineDiscountType", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string deliveryLineDiscountType { get { return _deliveryLineDiscountType; } set { SetProperty(PropertydeliveryLineDiscountType, ref _deliveryLineDiscountType, value); } }

		[SMEDecimalProperty(Label="SalesOrderDeliveryLine Delivery Line Discount Amount", Nillable=true, Name="deliveryLineDiscountAmount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> deliveryLineDiscountAmount { get { return _deliveryLineDiscountAmount; } set { SetProperty(PropertydeliveryLineDiscountAmount, ref _deliveryLineDiscountAmount, value); } }

		[SMEDecimalProperty(Label="SalesOrderDeliveryLine Delivery Line Discount Percent", Nillable=true, Name="deliveryLineDiscountPercent", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> deliveryLineDiscountPercent { get { return _deliveryLineDiscountPercent; } set { SetProperty(PropertydeliveryLineDiscountPercent, ref _deliveryLineDiscountPercent, value); } }

		[SMEEnumProperty(EnumTypeName="discountType--enum", Label="SalesOrderDeliveryLine Delivery Line Subtotal Discount Type", Nillable=true, Name="deliveryLineSubtotalDiscountType", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string deliveryLineSubtotalDiscountType { get { return _deliveryLineSubtotalDiscountType; } set { SetProperty(PropertydeliveryLineSubtotalDiscountType, ref _deliveryLineSubtotalDiscountType, value); } }

		[SMEDecimalProperty(Label="SalesOrderDeliveryLine Delivery Line Subtotal Discount Amount", Nillable=true, Name="deliveryLineSubtotalDiscountAmount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> deliveryLineSubtotalDiscountAmount { get { return _deliveryLineSubtotalDiscountAmount; } set { SetProperty(PropertydeliveryLineSubtotalDiscountAmount, ref _deliveryLineSubtotalDiscountAmount, value); } }

		[SMEDecimalProperty(Label="SalesOrderDeliveryLine Delivery Line Subtotal Discount Percent", Nillable=true, Name="deliveryLineSubtotalDiscountPercent", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> deliveryLineSubtotalDiscountPercent { get { return _deliveryLineSubtotalDiscountPercent; } set { SetProperty(PropertydeliveryLineSubtotalDiscountPercent, ref _deliveryLineSubtotalDiscountPercent, value); } }

		[SMEDecimalProperty(Label="SalesOrderDeliveryLine Actual Price", Name="actualPrice", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal actualPrice { get { return _actualPrice; } set { SetProperty(PropertyactualPrice, ref _actualPrice, value); } }

		[SMEDecimalProperty(Label="SalesOrderDeliveryLine Net Total", Name="netTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal netTotal { get { return _netTotal; } set { SetProperty(PropertynetTotal, ref _netTotal, value); } }

		[SMEDecimalProperty(Label="SalesOrderDeliveryLine Charges Total", Nillable=true, Name="chargesTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> chargesTotal { get { return _chargesTotal; } set { SetProperty(PropertychargesTotal, ref _chargesTotal, value); } }

		[SMEDecimalProperty(Label="SalesOrderDeliveryLine Discount Total", Name="discountTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal discountTotal { get { return _discountTotal; } set { SetProperty(PropertydiscountTotal, ref _discountTotal, value); } }

		[SMEResource(CanGet=true, PluralName="taxCodes", Label="SalesOrderDeliveryLine Tax Code")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="SalesOrderDeliveryLine Tax Code", Name="taxCodes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual taxCodeFeed taxCodes { get { return _taxCodes; } set { SetProperty(PropertytaxCodes, ref _taxCodes, value); } }

		[SMEDecimalProperty(Label="SalesOrderDeliveryLine Price Tax", Nillable=true, Name="priceTax", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> priceTax { get { return _priceTax; } set { SetProperty(PropertypriceTax, ref _priceTax, value); } }

		[SMEDecimalProperty(Label="SalesOrderDeliveryLine Tax Total", Name="taxTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal taxTotal { get { return _taxTotal; } set { SetProperty(PropertytaxTotal, ref _taxTotal, value); } }

		[SMEDecimalProperty(Label="SalesOrderDeliveryLine Gross Total", Name="grossTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal grossTotal { get { return _grossTotal; } set { SetProperty(PropertygrossTotal, ref _grossTotal, value); } }

		[SMEDecimalProperty(Label="SalesOrderDeliveryLine Cost Total", Nillable=true, Name="costTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> costTotal { get { return _costTotal; } set { SetProperty(PropertycostTotal, ref _costTotal, value); } }

		[SMEDecimalProperty(Label="SalesOrderDeliveryLine Profit Total", Nillable=true, Name="profitTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> profitTotal { get { return _profitTotal; } set { SetProperty(PropertyprofitTotal, ref _profitTotal, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, PluralName="salesInvoiceLines", Label="SalesOrderDeliveryLine Sales Invoice Line")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="SalesOrderDeliveryLine Sales Invoice Line", Name="salesInvoiceLines", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesInvoiceLineFeed salesInvoiceLines { get { return _salesInvoiceLines; } set { SetProperty(PropertysalesInvoiceLines, ref _salesInvoiceLines, value); } }

		[SMEResource(CanGet=true, PluralName="receipts", Label="SalesOrderDeliveryLine Receipt")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="SalesOrderDeliveryLine Receipt", Name="receipts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual receiptFeed receipts { get { return _receipts; } set { SetProperty(Propertyreceipts, ref _receipts, value); } }

		[SMEResource(CanGet=true, PluralName="financialAccounts", Label="SalesOrderDeliveryLine FinancialAccount")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="SalesOrderDeliveryLine FinancialAccount", Name="financialAccounts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual financialAccountFeed financialAccounts { get { return _financialAccounts; } set { SetProperty(PropertyfinancialAccounts, ref _financialAccounts, value); } }

		[SMEResource(CanGet=true, PluralName="notes")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Label="SalesOrderDeliveryLine Note", Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual noteFeed notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		#endregion


	}
}