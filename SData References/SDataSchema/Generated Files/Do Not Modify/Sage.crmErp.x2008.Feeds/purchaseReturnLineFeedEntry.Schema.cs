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
	/// Defines a purchaseReturnLine feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("purchaseReturnLine", Namespace="http://schemas.sage.com/crmErp/2008")]
		[SMEResource(CanGet=true, PluralName="purchaseReturnLines")]
	public class purchaseReturnLineFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyuuid = "uuid";
		public const string Propertyid = "id";
		public const string Propertyactive = "active";
		public const string Propertydeleted = "deleted";
		public const string Propertylabel = "label";
		public const string Propertyreference = "reference";
		public const string Propertyreference2 = "reference2";
		public const string Propertynumber = "number";
		public const string Propertystatus = "status";
		public const string Propertytype = "type";
		public const string Propertyreason = "reason";
		public const string PropertydeliveryTerms = "deliveryTerms";
		public const string Propertycommodity = "commodity";
		public const string Propertytext = "text";
		public const string PropertycommodityVariant = "commodityVariant";
		public const string PropertycommodityDimension = "commodityDimension";
		public const string PropertycarrierCompany = "carrierCompany";
		public const string PropertycarrierSupplier = "carrierSupplier";
		public const string PropertycarrierTradingAccount = "carrierTradingAccount";
		public const string PropertycarrierNetPrice = "carrierNetPrice";
		public const string PropertycarrierTaxPrice = "carrierTaxPrice";
		public const string PropertycarrierTotalPrice = "carrierTotalPrice";
		public const string PropertycarrierPurchaseInvoiceLine = "carrierPurchaseInvoiceLine";
		public const string PropertycarrierTaxCodes = "carrierTaxCodes";
		public const string PropertycarrierReference = "carrierReference";
		public const string Propertycondition = "condition";
		public const string PropertydeliveryLocation = "deliveryLocation";
		public const string PropertyunitOfMeasure = "unitOfMeasure";
		public const string Propertyquantity = "quantity";
		public const string PropertyinitialPrice = "initialPrice";
		public const string Propertypricelist = "pricelist";
		public const string PropertyreturnLineDiscountType = "returnLineDiscountType";
		public const string PropertyreturnLineDiscountAmount = "returnLineDiscountAmount";
		public const string PropertyreturnLineDiscountPercent = "returnLineDiscountPercent";
		public const string PropertyreturnLineSubtotalDiscountType = "returnLineSubtotalDiscountType";
		public const string PropertyreturnLineSubtotalDiscountAmount = "returnLineSubtotalDiscountAmount";
		public const string PropertyreturnLineSubtotalDiscountPercent = "returnLineSubtotalDiscountPercent";
		public const string PropertyactualPrice = "actualPrice";
		public const string PropertynetTotal = "netTotal";
		public const string PropertychargesTotal = "chargesTotal";
		public const string PropertyfOBPoint = "fOBPoint";
		public const string PropertytaxCodes = "taxCodes";
		public const string PropertypriceTax = "priceTax";
		public const string PropertytaxTotal = "taxTotal";
		public const string PropertygrossTotal = "grossTotal";
		public const string PropertypurchaseCreditLines = "purchaseCreditLines";
		public const string Propertyreceipts = "receipts";
		public const string PropertyreceiptLines = "receiptLines";
		public const string Propertyproject = "project";
		public const string PropertyprojectLine = "projectLine";
		public const string PropertypurchaseReturnDeliveryLine = "purchaseReturnDeliveryLine";
		public const string PropertyfinancialAccounts = "financialAccounts";
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
		private System.Decimal _number;
		private string _status;
		private string _type;
		private System.String _reason;
		private System.String _deliveryTerms;
		private commodityFeedEntry _commodity;
		private System.String _text;
		private commodityVariantFeedEntry _commodityVariant;
		private commodityDimensionFeedEntry _commodityDimension;
		private companyFeedEntry _carrierCompany;
		private supplierFeedEntry _carrierSupplier;
		private tradingAccountFeedEntry _carrierTradingAccount;
		private Nullable<System.Decimal> _carrierNetPrice;
		private Nullable<System.Decimal> _carrierTaxPrice;
		private Nullable<System.Decimal> _carrierTotalPrice;
		private purchaseInvoiceLineFeedEntry _carrierPurchaseInvoiceLine;
		private taxCodeFeed _carrierTaxCodes;
		private System.String _carrierReference;
		private System.String _condition;
		private locationFeedEntry _deliveryLocation;
		private unitOfMeasureFeedEntry _unitOfMeasure;
		private System.Decimal _quantity;
		private System.Decimal _initialPrice;
		private priceListFeedEntry _pricelist;
		private string _returnLineDiscountType;
		private Nullable<System.Decimal> _returnLineDiscountAmount;
		private Nullable<System.Decimal> _returnLineDiscountPercent;
		private string _returnLineSubtotalDiscountType;
		private Nullable<System.Decimal> _returnLineSubtotalDiscountAmount;
		private Nullable<System.Decimal> _returnLineSubtotalDiscountPercent;
		private System.Decimal _actualPrice;
		private System.Decimal _netTotal;
		private Nullable<System.Decimal> _chargesTotal;
		private System.String _fOBPoint;
		private taxCodeFeed _taxCodes;
		private Nullable<System.Decimal> _priceTax;
		private System.Decimal _taxTotal;
		private System.Decimal _grossTotal;
		private purchaseCreditLineFeed _purchaseCreditLines;
		private receiptFeed _receipts;
		private receiptLineFeed _receiptLines;
		private projectFeedEntry _project;
		private projectLineFeedEntry _projectLine;
		private purchaseReturnDeliveryLineFeed _purchaseReturnDeliveryLine;
		private financialAccountFeed _financialAccounts;
		private noteFeed _notes;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="purchaseReturnLineFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public purchaseReturnLineFeedEntrySchema()
		{
		}

		#region Properties


		[SMEEnumProperty(EnumTypeName="uuid--type", Label="PurchaseReturnLine Global ID", Pattern="[0-9a-fA-F-]+", Name="uuid", Namespace="http://schemas.sage.com/crmErp/2008", IsUniqueKey=true)]			
		public virtual new string uuid { get { return _uuid; } set { SetProperty(Propertyuuid, ref _uuid, value); } }

		[SMEStringProperty(Label="PurchaseReturnLine Application ID", Name="id", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual new System.String id { get { return _id; } set { SetProperty(Propertyid, ref _id, value); } }

		[SMEBoolProperty(Label="PurchaseReturnLine Active Flag", Name="active", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEBoolProperty(Label="PurchaseReturnLine Deleted", Name="deleted", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean deleted { get { return _deleted; } set { SetProperty(Propertydeleted, ref _deleted, value); } }

		[SMEStringProperty(Label="PurchaseReturnLine Label", Name="label", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String label { get { return _label; } set { SetProperty(Propertylabel, ref _label, value); } }

		[SMEStringProperty(Label="PurchaseReturnLine reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEStringProperty(Label="PurchaseReturnLine Reference2", Nillable=true, Name="reference2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }

		[SMEDecimalProperty(Label="PurchaseReturnLine Number", Name="number", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal number { get { return _number; } set { SetProperty(Propertynumber, ref _number, value); } }

		[SMEEnumProperty(EnumTypeName="purchaseReturnStatus--enum", Label="PurchaseReturnLine Status", Nillable=true, Name="status", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string status { get { return _status; } set { SetProperty(Propertystatus, ref _status, value); } }

		[SMEEnumProperty(EnumTypeName="lineType--enum", Label="PurchaseReturnLine Type", Nillable=true, Name="type", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }

		[SMEStringProperty(Label="PurchaseReturnLine Reason", Nillable=true, Name="reason", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String reason { get { return _reason; } set { SetProperty(Propertyreason, ref _reason, value); } }

		[SMEStringProperty(Label="PurchaseReturnLine Delivery Terms", Nillable=true, Name="deliveryTerms", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String deliveryTerms { get { return _deliveryTerms; } set { SetProperty(PropertydeliveryTerms, ref _deliveryTerms, value); } }

		[SMEResource(CanGet=true, PluralName="commodities", Label="PurchaseReturnLine Commodity")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseReturnLine Commodity", Name="commodity", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("commodity")]			
		public virtual commodityFeedEntry commodity { get { return _commodity; } set { SetProperty(Propertycommodity, ref _commodity, value); } }

		[SMEStringProperty(Label="PurchaseReturnLine Text", Nillable=true, Name="text", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String text { get { return _text; } set { SetProperty(Propertytext, ref _text, value); } }

		[SMEResource(PluralName="commodityVariants", Label="PurchaseReturnLine Commodity Variant")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseReturnLine Commodity Variant", Name="commodityVariant", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("commodityVariant")]			
		public virtual commodityVariantFeedEntry commodityVariant { get { return _commodityVariant; } set { SetProperty(PropertycommodityVariant, ref _commodityVariant, value); } }

		[SMEResource(PluralName="commodityDimensions", Label="PurchaseReturnLine Commodity Dimension")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseReturnLine Commodity Dimension", Name="commodityDimension", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("commodityDimension")]			
		public virtual commodityDimensionFeedEntry commodityDimension { get { return _commodityDimension; } set { SetProperty(PropertycommodityDimension, ref _commodityDimension, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="companies")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseReturnLine Carrier Company", Name="carrierCompany", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("carrierCompany")]			
		public virtual companyFeedEntry carrierCompany { get { return _carrierCompany; } set { SetProperty(PropertycarrierCompany, ref _carrierCompany, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="suppliers")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseReturnLine Carrier Supplier", Name="carrierSupplier", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("carrierSupplier")]			
		public virtual supplierFeedEntry carrierSupplier { get { return _carrierSupplier; } set { SetProperty(PropertycarrierSupplier, ref _carrierSupplier, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseReturnLine Carrier TradingAccount", Name="carrierTradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("carrierTradingAccount")]			
		public virtual tradingAccountFeedEntry carrierTradingAccount { get { return _carrierTradingAccount; } set { SetProperty(PropertycarrierTradingAccount, ref _carrierTradingAccount, value); } }

		[SMEDecimalProperty(Label="PurchaseReturnLine Carrier Net Price", Nillable=true, Name="carrierNetPrice", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> carrierNetPrice { get { return _carrierNetPrice; } set { SetProperty(PropertycarrierNetPrice, ref _carrierNetPrice, value); } }

		[SMEDecimalProperty(Label="PurchaseReturnLine Carrier Tax Price", Nillable=true, Name="carrierTaxPrice", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> carrierTaxPrice { get { return _carrierTaxPrice; } set { SetProperty(PropertycarrierTaxPrice, ref _carrierTaxPrice, value); } }

		[SMEDecimalProperty(Label="PurchaseReturnLine Carrier Gross Price", Nillable=true, Name="carrierTotalPrice", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> carrierTotalPrice { get { return _carrierTotalPrice; } set { SetProperty(PropertycarrierTotalPrice, ref _carrierTotalPrice, value); } }

		[SMEResource(CanGet=true, CanPost=true, PluralName="purchaseInvoiceLines", Label="PurchaseReturnLine Carrier PurchaseInvoiceLine")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseReturnLine Carrier PurchaseInvoiceLine", Name="carrierPurchaseInvoiceLine", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("carrierPurchaseInvoiceLine")]			
		public virtual purchaseInvoiceLineFeedEntry carrierPurchaseInvoiceLine { get { return _carrierPurchaseInvoiceLine; } set { SetProperty(PropertycarrierPurchaseInvoiceLine, ref _carrierPurchaseInvoiceLine, value); } }

		[SMEResource(CanGet=true, PluralName="taxCodes", Label="PurchaseReturnLine Carrier Tax Code")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="PurchaseReturnLine Carrier Tax Code", Name="carrierTaxCodes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual taxCodeFeed carrierTaxCodes { get { return _carrierTaxCodes; } set { SetProperty(PropertycarrierTaxCodes, ref _carrierTaxCodes, value); } }

		[SMEStringProperty(Label="PurchaseReturnLine Carrier reference", Nillable=true, Name="carrierReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String carrierReference { get { return _carrierReference; } set { SetProperty(PropertycarrierReference, ref _carrierReference, value); } }

		[SMEStringProperty(Label="PurchaseReturnLine Commodity Condition", Nillable=true, Name="condition", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String condition { get { return _condition; } set { SetProperty(Propertycondition, ref _condition, value); } }

		[SMEResource(CanGet=true, PluralName="locations", Label="PurchaseReturnLine Delivery Location")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseReturnLine Delivery Location", Name="deliveryLocation", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("deliveryLocation")]			
		public virtual locationFeedEntry deliveryLocation { get { return _deliveryLocation; } set { SetProperty(PropertydeliveryLocation, ref _deliveryLocation, value); } }

		[SMEResource(CanGet=true, PluralName="unitsOfMeasure", Label="PurchaseReturnLine UnitOfMeasure")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseReturnLine UnitOfMeasure", Name="unitOfMeasure", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("unitOfMeasure")]			
		public virtual unitOfMeasureFeedEntry unitOfMeasure { get { return _unitOfMeasure; } set { SetProperty(PropertyunitOfMeasure, ref _unitOfMeasure, value); } }

		[SMEDecimalProperty(Label="PurchaseReturnLine Quantity", Name="quantity", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal quantity { get { return _quantity; } set { SetProperty(Propertyquantity, ref _quantity, value); } }

		[SMEDecimalProperty(Label="PurchaseReturnLine Initial Price", Name="initialPrice", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal initialPrice { get { return _initialPrice; } set { SetProperty(PropertyinitialPrice, ref _initialPrice, value); } }

		[SMEResource(CanGet=true, PluralName="priceLists", Label="PurchaseReturnLine PriceList")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseReturnLine PriceList", Name="pricelist", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("pricelist")]			
		public virtual priceListFeedEntry pricelist { get { return _pricelist; } set { SetProperty(Propertypricelist, ref _pricelist, value); } }

		[SMEEnumProperty(EnumTypeName="discountType--enum", Label="PurchaseReturnLine Return Line Discount Type", Nillable=true, Name="returnLineDiscountType", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string returnLineDiscountType { get { return _returnLineDiscountType; } set { SetProperty(PropertyreturnLineDiscountType, ref _returnLineDiscountType, value); } }

		[SMEDecimalProperty(Label="PurchaseReturnLine Return Line Discount Amount", Nillable=true, Name="returnLineDiscountAmount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> returnLineDiscountAmount { get { return _returnLineDiscountAmount; } set { SetProperty(PropertyreturnLineDiscountAmount, ref _returnLineDiscountAmount, value); } }

		[SMEDecimalProperty(Label="PurchaseReturnLine Return Line Discount Percent", Nillable=true, Name="returnLineDiscountPercent", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> returnLineDiscountPercent { get { return _returnLineDiscountPercent; } set { SetProperty(PropertyreturnLineDiscountPercent, ref _returnLineDiscountPercent, value); } }

		[SMEEnumProperty(EnumTypeName="discountType--enum", Label="PurchaseReturnLine Return Line Subtotal Discount Type", Nillable=true, Name="returnLineSubtotalDiscountType", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string returnLineSubtotalDiscountType { get { return _returnLineSubtotalDiscountType; } set { SetProperty(PropertyreturnLineSubtotalDiscountType, ref _returnLineSubtotalDiscountType, value); } }

		[SMEDecimalProperty(Label="PurchaseReturnLine Return Line Subtotal Discount Amount", Nillable=true, Name="returnLineSubtotalDiscountAmount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> returnLineSubtotalDiscountAmount { get { return _returnLineSubtotalDiscountAmount; } set { SetProperty(PropertyreturnLineSubtotalDiscountAmount, ref _returnLineSubtotalDiscountAmount, value); } }

		[SMEDecimalProperty(Label="PurchaseReturnLine Return Line Subtotal Discount Percent", Nillable=true, Name="returnLineSubtotalDiscountPercent", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> returnLineSubtotalDiscountPercent { get { return _returnLineSubtotalDiscountPercent; } set { SetProperty(PropertyreturnLineSubtotalDiscountPercent, ref _returnLineSubtotalDiscountPercent, value); } }

		[SMEDecimalProperty(Label="PurchaseReturnLine Actual Price", Name="actualPrice", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal actualPrice { get { return _actualPrice; } set { SetProperty(PropertyactualPrice, ref _actualPrice, value); } }

		[SMEDecimalProperty(Label="PurchaseReturnLine Net Total", Name="netTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal netTotal { get { return _netTotal; } set { SetProperty(PropertynetTotal, ref _netTotal, value); } }

		[SMEDecimalProperty(Label="PurchaseReturnLine Charges Total", Nillable=true, Name="chargesTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> chargesTotal { get { return _chargesTotal; } set { SetProperty(PropertychargesTotal, ref _chargesTotal, value); } }

		[SMEStringProperty(Label="PurchaseReturnLine FOB Point", Nillable=true, Name="fOBPoint", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String fOBPoint { get { return _fOBPoint; } set { SetProperty(PropertyfOBPoint, ref _fOBPoint, value); } }

		[SMEResource(CanGet=true, PluralName="taxCodes", Label="PurchaseReturnLine Tax Code")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="PurchaseReturnLine Tax Code", Name="taxCodes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual taxCodeFeed taxCodes { get { return _taxCodes; } set { SetProperty(PropertytaxCodes, ref _taxCodes, value); } }

		[SMEDecimalProperty(Label="PurchaseReturnLine Price Tax", Nillable=true, Name="priceTax", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> priceTax { get { return _priceTax; } set { SetProperty(PropertypriceTax, ref _priceTax, value); } }

		[SMEDecimalProperty(Label="PurchaseReturnLine Tax Total", Name="taxTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal taxTotal { get { return _taxTotal; } set { SetProperty(PropertytaxTotal, ref _taxTotal, value); } }

		[SMEDecimalProperty(Label="PurchaseReturnLine Gross Total", Name="grossTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal grossTotal { get { return _grossTotal; } set { SetProperty(PropertygrossTotal, ref _grossTotal, value); } }

		[SMEResource(CanGet=true, PluralName="purchaseCreditLines", Label="PurchaseReturnLine PurchaseCreditLine")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="PurchaseReturnLine PurchaseCreditLine", Name="purchaseCreditLines", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseCreditLineFeed purchaseCreditLines { get { return _purchaseCreditLines; } set { SetProperty(PropertypurchaseCreditLines, ref _purchaseCreditLines, value); } }

		[SMEResource(CanGet=true, PluralName="receipts", Label="PurchaseReturnLine Receipt")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="PurchaseReturnLine Receipt", Name="receipts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual receiptFeed receipts { get { return _receipts; } set { SetProperty(Propertyreceipts, ref _receipts, value); } }

		[SMEResource(CanGet=true, PluralName="receiptLines", Label="PurchaseReturnLine ReceiptLine")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="PurchaseReturnLine ReceiptLine", Name="receiptLines", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual receiptLineFeed receiptLines { get { return _receiptLines; } set { SetProperty(PropertyreceiptLines, ref _receiptLines, value); } }

		[SMEResource(CanGet=true, PluralName="projects", Label="PurchaseReturnLine Project")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseReturnLine Project", Name="project", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("project")]			
		public virtual projectFeedEntry project { get { return _project; } set { SetProperty(Propertyproject, ref _project, value); } }

		[SMEResource(CanGet=true, PluralName="projectLines", Label="PurchaseReturnLine ProjectLine")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseReturnLine ProjectLine", Name="projectLine", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("projectLine")]			
		public virtual projectLineFeedEntry projectLine { get { return _projectLine; } set { SetProperty(PropertyprojectLine, ref _projectLine, value); } }

		[SMEResource(CanGet=true, PluralName="purchaseReturnDeliveryLines", Label="PurchaseReturnLine PurchaseReturnDeliveries")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="PurchaseReturnLine PurchaseReturnDeliveries", Name="purchaseReturnDeliveryLine", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseReturnDeliveryLineFeed purchaseReturnDeliveryLine { get { return _purchaseReturnDeliveryLine; } set { SetProperty(PropertypurchaseReturnDeliveryLine, ref _purchaseReturnDeliveryLine, value); } }

		[SMEResource(CanGet=true, PluralName="financialAccounts", Label="PurchaseReturnLine FinancialAccount")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="PurchaseReturnLine FinancialAccount", Name="financialAccounts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual financialAccountFeed financialAccounts { get { return _financialAccounts; } set { SetProperty(PropertyfinancialAccounts, ref _financialAccounts, value); } }

		[SMEResource(CanGet=true, PluralName="notes")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Label="PurchaseReturnLine Note", Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual noteFeed notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		#endregion


	}
}