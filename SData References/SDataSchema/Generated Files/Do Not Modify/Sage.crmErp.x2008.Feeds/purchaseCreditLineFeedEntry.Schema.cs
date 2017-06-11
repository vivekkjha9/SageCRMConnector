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
	/// Defines a purchaseCreditLine feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("purchaseCreditLine", Namespace="http://schemas.sage.com/crmErp/2008")]
		[SMEResource(CanGet=true, PluralName="purchaseCreditLines")]
	public class purchaseCreditLineFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyuuid = "uuid";
		public const string Propertyid = "id";
		public const string Propertyactive = "active";
		public const string Propertydeleted = "deleted";
		public const string Propertylabel = "label";
		public const string PropertyoriginatorDocumentLine = "originatorDocumentLine";
		public const string Propertyreference = "reference";
		public const string Propertyreference2 = "reference2";
		public const string Propertystatus = "status";
		public const string Propertytype = "type";
		public const string Propertynumber = "number";
		public const string Propertycommodity = "commodity";
		public const string Propertytext = "text";
		public const string PropertycommodityVariant = "commodityVariant";
		public const string PropertycommodityDimension = "commodityDimension";
		public const string PropertydeliveryDate = "deliveryDate";
		public const string PropertycarrierCompany = "carrierCompany";
		public const string PropertycarrierSupplier = "carrierSupplier";
		public const string PropertycarrierTradingAccount = "carrierTradingAccount";
		public const string PropertycarrierNetPrice = "carrierNetPrice";
		public const string PropertycarrierTaxPrice = "carrierTaxPrice";
		public const string PropertycarrierTotalPrice = "carrierTotalPrice";
		public const string PropertycarrierPurchaseInvoiceLine = "carrierPurchaseInvoiceLine";
		public const string PropertycarrierTaxCodes = "carrierTaxCodes";
		public const string PropertycarrierReference = "carrierReference";
		public const string PropertyunitOfMeasure = "unitOfMeasure";
		public const string Propertyquantity = "quantity";
		public const string PropertyinitialPrice = "initialPrice";
		public const string Propertypricelist = "pricelist";
		public const string PropertysettlementDiscountType = "settlementDiscountType";
		public const string PropertysettlementDiscountAmount = "settlementDiscountAmount";
		public const string PropertysettlementDiscountPercent = "settlementDiscountPercent";
		public const string PropertysettlementDiscountTerms = "settlementDiscountTerms";
		public const string PropertyinvoiceLineDiscountType = "invoiceLineDiscountType";
		public const string PropertyinvoiceLineDiscountAmount = "invoiceLineDiscountAmount";
		public const string PropertyinvoiceLineDiscountPercent = "invoiceLineDiscountPercent";
		public const string PropertyinvoiceLineSubtotalDiscountType = "invoiceLineSubtotalDiscountType";
		public const string PropertyinvoiceLineSubtotalDiscountAmount = "invoiceLineSubtotalDiscountAmount";
		public const string PropertyinvoiceLineSubtotalDiscountPercent = "invoiceLineSubtotalDiscountPercent";
		public const string PropertyactualPrice = "actualPrice";
		public const string PropertynetTotal = "netTotal";
		public const string PropertychargesTotal = "chargesTotal";
		public const string PropertyfOBPoint = "fOBPoint";
		public const string PropertytaxCodes = "taxCodes";
		public const string PropertypriceTax = "priceTax";
		public const string PropertytaxTotal = "taxTotal";
		public const string PropertygrossTotal = "grossTotal";
		public const string PropertydutyTotal = "dutyTotal";
		public const string Propertyproject = "project";
		public const string PropertyprojectLine = "projectLine";
		public const string PropertypurchaseReturnDeliveryLine = "purchaseReturnDeliveryLine";
		public const string Propertyreceipts = "receipts";
		public const string PropertyreceiptLines = "receiptLines";
		public const string PropertyfinancialAccounts = "financialAccounts";
		public const string Propertynotes = "notes";

		#endregion

		#region Fields

		private string _uuid;
		private System.String _id;
		private System.Boolean _active;
		private System.Boolean _deleted;
		private System.String _label;
		private purchaseOrderLineFeedEntry _originatorDocumentLine;
		private System.String _reference;
		private System.String _reference2;
		private string _status;
		private string _type;
		private System.Decimal _number;
		private commodityFeedEntry _commodity;
		private System.String _text;
		private commodityVariantFeedEntry _commodityVariant;
		private commodityDimensionFeedEntry _commodityDimension;
		private Nullable<System.DateTime> _deliveryDate;
		private companyFeedEntry _carrierCompany;
		private supplierFeedEntry _carrierSupplier;
		private tradingAccountFeedEntry _carrierTradingAccount;
		private Nullable<System.Decimal> _carrierNetPrice;
		private Nullable<System.Decimal> _carrierTaxPrice;
		private Nullable<System.Decimal> _carrierTotalPrice;
		private purchaseInvoiceLineFeedEntry _carrierPurchaseInvoiceLine;
		private taxCodeFeed _carrierTaxCodes;
		private System.String _carrierReference;
		private unitOfMeasureFeedEntry _unitOfMeasure;
		private System.Decimal _quantity;
		private System.Decimal _initialPrice;
		private priceListFeedEntry _pricelist;
		private string _settlementDiscountType;
		private Nullable<System.Decimal> _settlementDiscountAmount;
		private Nullable<System.Decimal> _settlementDiscountPercent;
		private System.String _settlementDiscountTerms;
		private string _invoiceLineDiscountType;
		private Nullable<System.Decimal> _invoiceLineDiscountAmount;
		private Nullable<System.Decimal> _invoiceLineDiscountPercent;
		private string _invoiceLineSubtotalDiscountType;
		private Nullable<System.Decimal> _invoiceLineSubtotalDiscountAmount;
		private Nullable<System.Decimal> _invoiceLineSubtotalDiscountPercent;
		private System.Decimal _actualPrice;
		private System.Decimal _netTotal;
		private Nullable<System.Decimal> _chargesTotal;
		private System.String _fOBPoint;
		private taxCodeFeed _taxCodes;
		private Nullable<System.Decimal> _priceTax;
		private System.Decimal _taxTotal;
		private System.Decimal _grossTotal;
		private Nullable<System.Decimal> _dutyTotal;
		private projectFeedEntry _project;
		private projectLineFeedEntry _projectLine;
		private purchaseReturnDeliveryLineFeed _purchaseReturnDeliveryLine;
		private receiptFeed _receipts;
		private receiptLineFeed _receiptLines;
		private financialAccountFeed _financialAccounts;
		private noteFeed _notes;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="purchaseCreditLineFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public purchaseCreditLineFeedEntrySchema()
		{
		}

		#region Properties


		[SMEEnumProperty(EnumTypeName="uuid--type", Label="PurchaseCreditLine Global ID", Pattern="[0-9a-fA-F-]+", Name="uuid", Namespace="http://schemas.sage.com/crmErp/2008", IsUniqueKey=true)]			
		public virtual new string uuid { get { return _uuid; } set { SetProperty(Propertyuuid, ref _uuid, value); } }

		[SMEStringProperty(Label="PurchaseCreditLine Application ID", Name="id", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual new System.String id { get { return _id; } set { SetProperty(Propertyid, ref _id, value); } }

		[SMEBoolProperty(Label="PurchaseCreditLine Active Flag", Name="active", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEBoolProperty(Label="PurchaseCreditLine Deleted", Name="deleted", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean deleted { get { return _deleted; } set { SetProperty(Propertydeleted, ref _deleted, value); } }

		[SMEStringProperty(Label="PurchaseCreditLine Label", Name="label", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String label { get { return _label; } set { SetProperty(Propertylabel, ref _label, value); } }

		[SMEResource(CanGet=true, CanPost=true, PluralName="purchaseOrderLines", Label="PurchaseCreditLine Originator Document Line reference")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseCreditLine Originator Document Line reference", Name="originatorDocumentLine", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("originatorDocumentLine")]			
		public virtual purchaseOrderLineFeedEntry originatorDocumentLine { get { return _originatorDocumentLine; } set { SetProperty(PropertyoriginatorDocumentLine, ref _originatorDocumentLine, value); } }

		[SMEStringProperty(Label="PurchaseCreditLine reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEStringProperty(Label="PurchaseCreditLine Reference2", Nillable=true, Name="reference2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }

		[SMEEnumProperty(EnumTypeName="purchaseCreditStatus--enum", Label="PurchaseCreditLine Status", Nillable=true, Name="status", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string status { get { return _status; } set { SetProperty(Propertystatus, ref _status, value); } }

		[SMEEnumProperty(EnumTypeName="lineType--enum", Label="PurchaseCreditLine Type", Nillable=true, Name="type", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }

		[SMEDecimalProperty(Label="PurchaseCreditLine Number", Name="number", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal number { get { return _number; } set { SetProperty(Propertynumber, ref _number, value); } }

		[SMEResource(CanGet=true, PluralName="commodities", Label="PurchaseCreditLine Commodity")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseCreditLine Commodity", Name="commodity", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("commodity")]			
		public virtual commodityFeedEntry commodity { get { return _commodity; } set { SetProperty(Propertycommodity, ref _commodity, value); } }

		[SMEStringProperty(Label="PurchaseCreditLine Text", Nillable=true, Name="text", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String text { get { return _text; } set { SetProperty(Propertytext, ref _text, value); } }

		[SMEResource(PluralName="commodityVariants", Label="PurchaseCreditLine Commodity Variant")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseCreditLine Commodity Variant", Name="commodityVariant", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("commodityVariant")]			
		public virtual commodityVariantFeedEntry commodityVariant { get { return _commodityVariant; } set { SetProperty(PropertycommodityVariant, ref _commodityVariant, value); } }

		[SMEResource(PluralName="commodityDimensions", Label="PurchaseCreditLine Commodity Dimension")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseCreditLine Commodity Dimension", Name="commodityDimension", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("commodityDimension")]			
		public virtual commodityDimensionFeedEntry commodityDimension { get { return _commodityDimension; } set { SetProperty(PropertycommodityDimension, ref _commodityDimension, value); } }

		[SMEDateProperty(Label="PurchaseCreditLine Delivery Date", Nillable=true, Name="deliveryDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> deliveryDate { get { return _deliveryDate; } set { SetProperty(PropertydeliveryDate, ref _deliveryDate, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="companies")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseCreditLine Carrier Company", Name="carrierCompany", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("carrierCompany")]			
		public virtual companyFeedEntry carrierCompany { get { return _carrierCompany; } set { SetProperty(PropertycarrierCompany, ref _carrierCompany, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="suppliers")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseCreditLine Carrier Supplier", Name="carrierSupplier", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("carrierSupplier")]			
		public virtual supplierFeedEntry carrierSupplier { get { return _carrierSupplier; } set { SetProperty(PropertycarrierSupplier, ref _carrierSupplier, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseCreditLine Carrier TradingAccount", Name="carrierTradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("carrierTradingAccount")]			
		public virtual tradingAccountFeedEntry carrierTradingAccount { get { return _carrierTradingAccount; } set { SetProperty(PropertycarrierTradingAccount, ref _carrierTradingAccount, value); } }

		[SMEDecimalProperty(Label="PurchaseCreditLine Carrier Net Price", Nillable=true, Name="carrierNetPrice", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> carrierNetPrice { get { return _carrierNetPrice; } set { SetProperty(PropertycarrierNetPrice, ref _carrierNetPrice, value); } }

		[SMEDecimalProperty(Label="PurchaseCreditLine Carrier Tax Price", Nillable=true, Name="carrierTaxPrice", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> carrierTaxPrice { get { return _carrierTaxPrice; } set { SetProperty(PropertycarrierTaxPrice, ref _carrierTaxPrice, value); } }

		[SMEDecimalProperty(Label="PurchaseCreditLine Carrier Gross Price", Nillable=true, Name="carrierTotalPrice", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> carrierTotalPrice { get { return _carrierTotalPrice; } set { SetProperty(PropertycarrierTotalPrice, ref _carrierTotalPrice, value); } }

		[SMEResource(CanGet=true, CanPost=true, PluralName="purchaseInvoiceLines", Label="PurchaseCreditLine Carrier PurchaseInvoiceLine")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseCreditLine Carrier PurchaseInvoiceLine", Name="carrierPurchaseInvoiceLine", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("carrierPurchaseInvoiceLine")]			
		public virtual purchaseInvoiceLineFeedEntry carrierPurchaseInvoiceLine { get { return _carrierPurchaseInvoiceLine; } set { SetProperty(PropertycarrierPurchaseInvoiceLine, ref _carrierPurchaseInvoiceLine, value); } }

		[SMEResource(CanGet=true, PluralName="taxCodes", Label="PurchaseCreditLine Carrier Tax Code")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="PurchaseCreditLine Carrier Tax Code", Name="carrierTaxCodes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual taxCodeFeed carrierTaxCodes { get { return _carrierTaxCodes; } set { SetProperty(PropertycarrierTaxCodes, ref _carrierTaxCodes, value); } }

		[SMEStringProperty(Label="PurchaseCreditLine Carrier reference", Nillable=true, Name="carrierReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String carrierReference { get { return _carrierReference; } set { SetProperty(PropertycarrierReference, ref _carrierReference, value); } }

		[SMEResource(CanGet=true, PluralName="unitsOfMeasure", Label="PurchaseCreditLine UnitOfMeasure")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseCreditLine UnitOfMeasure", Name="unitOfMeasure", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("unitOfMeasure")]			
		public virtual unitOfMeasureFeedEntry unitOfMeasure { get { return _unitOfMeasure; } set { SetProperty(PropertyunitOfMeasure, ref _unitOfMeasure, value); } }

		[SMEDecimalProperty(Label="PurchaseCreditLine Quantity", Name="quantity", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal quantity { get { return _quantity; } set { SetProperty(Propertyquantity, ref _quantity, value); } }

		[SMEDecimalProperty(Label="PurchaseCreditLine Initial Price", Name="initialPrice", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal initialPrice { get { return _initialPrice; } set { SetProperty(PropertyinitialPrice, ref _initialPrice, value); } }

		[SMEResource(CanGet=true, PluralName="priceLists", Label="PurchaseCreditLine PriceList")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseCreditLine PriceList", Name="pricelist", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("pricelist")]			
		public virtual priceListFeedEntry pricelist { get { return _pricelist; } set { SetProperty(Propertypricelist, ref _pricelist, value); } }

		[SMEEnumProperty(EnumTypeName="discountType--enum", Label="PurchaseCreditLine Settlement Discount Type", Nillable=true, Name="settlementDiscountType", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string settlementDiscountType { get { return _settlementDiscountType; } set { SetProperty(PropertysettlementDiscountType, ref _settlementDiscountType, value); } }

		[SMEDecimalProperty(Label="PurchaseCreditLine Settlement Discount Amount", Nillable=true, Name="settlementDiscountAmount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> settlementDiscountAmount { get { return _settlementDiscountAmount; } set { SetProperty(PropertysettlementDiscountAmount, ref _settlementDiscountAmount, value); } }

		[SMEDecimalProperty(Label="PurchaseCreditLine Settlement Discount Percent", Nillable=true, Name="settlementDiscountPercent", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> settlementDiscountPercent { get { return _settlementDiscountPercent; } set { SetProperty(PropertysettlementDiscountPercent, ref _settlementDiscountPercent, value); } }

		[SMEStringProperty(Label="PurchaseCreditLine Settlement Discount Terms", Nillable=true, Name="settlementDiscountTerms", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String settlementDiscountTerms { get { return _settlementDiscountTerms; } set { SetProperty(PropertysettlementDiscountTerms, ref _settlementDiscountTerms, value); } }

		[SMEEnumProperty(EnumTypeName="discountType--enum", Label="PurchaseCreditLine Invoice Line Discount Type", Nillable=true, Name="invoiceLineDiscountType", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string invoiceLineDiscountType { get { return _invoiceLineDiscountType; } set { SetProperty(PropertyinvoiceLineDiscountType, ref _invoiceLineDiscountType, value); } }

		[SMEDecimalProperty(Label="PurchaseCreditLine Invoice Line Discount Amount", Nillable=true, Name="invoiceLineDiscountAmount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> invoiceLineDiscountAmount { get { return _invoiceLineDiscountAmount; } set { SetProperty(PropertyinvoiceLineDiscountAmount, ref _invoiceLineDiscountAmount, value); } }

		[SMEDecimalProperty(Label="PurchaseCreditLine Invoice Line Discount Percent", Nillable=true, Name="invoiceLineDiscountPercent", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> invoiceLineDiscountPercent { get { return _invoiceLineDiscountPercent; } set { SetProperty(PropertyinvoiceLineDiscountPercent, ref _invoiceLineDiscountPercent, value); } }

		[SMEEnumProperty(EnumTypeName="discountType--enum", Label="PurchaseCreditLine Invoice Line Subtotal Discount Type", Nillable=true, Name="invoiceLineSubtotalDiscountType", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string invoiceLineSubtotalDiscountType { get { return _invoiceLineSubtotalDiscountType; } set { SetProperty(PropertyinvoiceLineSubtotalDiscountType, ref _invoiceLineSubtotalDiscountType, value); } }

		[SMEDecimalProperty(Label="PurchaseCreditLine Invoice Line Subtotal Discount Amount", Nillable=true, Name="invoiceLineSubtotalDiscountAmount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> invoiceLineSubtotalDiscountAmount { get { return _invoiceLineSubtotalDiscountAmount; } set { SetProperty(PropertyinvoiceLineSubtotalDiscountAmount, ref _invoiceLineSubtotalDiscountAmount, value); } }

		[SMEDecimalProperty(Label="PurchaseCreditLine Invoice Line Subtotal Discount Percent", Nillable=true, Name="invoiceLineSubtotalDiscountPercent", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> invoiceLineSubtotalDiscountPercent { get { return _invoiceLineSubtotalDiscountPercent; } set { SetProperty(PropertyinvoiceLineSubtotalDiscountPercent, ref _invoiceLineSubtotalDiscountPercent, value); } }

		[SMEDecimalProperty(Label="PurchaseCreditLine Actual Price", Name="actualPrice", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal actualPrice { get { return _actualPrice; } set { SetProperty(PropertyactualPrice, ref _actualPrice, value); } }

		[SMEDecimalProperty(Label="PurchaseCreditLine Net Total", Name="netTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal netTotal { get { return _netTotal; } set { SetProperty(PropertynetTotal, ref _netTotal, value); } }

		[SMEDecimalProperty(Label="PurchaseCreditLine Charges Total", Nillable=true, Name="chargesTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> chargesTotal { get { return _chargesTotal; } set { SetProperty(PropertychargesTotal, ref _chargesTotal, value); } }

		[SMEStringProperty(Label="PurchaseCreditLine FOB Point", Nillable=true, Name="fOBPoint", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String fOBPoint { get { return _fOBPoint; } set { SetProperty(PropertyfOBPoint, ref _fOBPoint, value); } }

		[SMEResource(CanGet=true, PluralName="taxCodes", Label="PurchaseCreditLine Tax Code")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="PurchaseCreditLine Tax Code", Name="taxCodes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual taxCodeFeed taxCodes { get { return _taxCodes; } set { SetProperty(PropertytaxCodes, ref _taxCodes, value); } }

		[SMEDecimalProperty(Label="PurchaseCreditLine Price Tax", Nillable=true, Name="priceTax", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> priceTax { get { return _priceTax; } set { SetProperty(PropertypriceTax, ref _priceTax, value); } }

		[SMEDecimalProperty(Label="PurchaseCreditLine Tax Total", Name="taxTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal taxTotal { get { return _taxTotal; } set { SetProperty(PropertytaxTotal, ref _taxTotal, value); } }

		[SMEDecimalProperty(Label="PurchaseCreditLine Gross Total", Name="grossTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal grossTotal { get { return _grossTotal; } set { SetProperty(PropertygrossTotal, ref _grossTotal, value); } }

		[SMEDecimalProperty(Label="PurchaseCreditLine Duty Total", Nillable=true, Name="dutyTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> dutyTotal { get { return _dutyTotal; } set { SetProperty(PropertydutyTotal, ref _dutyTotal, value); } }

		[SMEResource(CanGet=true, PluralName="projects", Label="PurchaseCreditLine Project")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseCreditLine Project", Name="project", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("project")]			
		public virtual projectFeedEntry project { get { return _project; } set { SetProperty(Propertyproject, ref _project, value); } }

		[SMEResource(CanGet=true, PluralName="projectLines", Label="PurchaseCreditLine ProjectLine")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseCreditLine ProjectLine", Name="projectLine", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("projectLine")]			
		public virtual projectLineFeedEntry projectLine { get { return _projectLine; } set { SetProperty(PropertyprojectLine, ref _projectLine, value); } }

		[SMEResource(CanGet=true, PluralName="purchaseReturnDeliveryLines", Label="PurchaseCreditLine PurchaseOrderDeliveryLine")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="PurchaseCreditLine PurchaseOrderDeliveryLine", Name="purchaseReturnDeliveryLine", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseReturnDeliveryLineFeed purchaseReturnDeliveryLine { get { return _purchaseReturnDeliveryLine; } set { SetProperty(PropertypurchaseReturnDeliveryLine, ref _purchaseReturnDeliveryLine, value); } }

		[SMEResource(CanGet=true, PluralName="receipts", Label="PurchaseCreditLine Receipt")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="PurchaseCreditLine Receipt", Name="receipts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual receiptFeed receipts { get { return _receipts; } set { SetProperty(Propertyreceipts, ref _receipts, value); } }

		[SMEResource(CanGet=true, PluralName="receiptLines", Label="PurchaseCreditLine ReceiptLine")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="PurchaseCreditLine ReceiptLine", Name="receiptLines", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual receiptLineFeed receiptLines { get { return _receiptLines; } set { SetProperty(PropertyreceiptLines, ref _receiptLines, value); } }

		[SMEResource(CanGet=true, PluralName="financialAccounts", Label="PurchaseCreditLine FinancialAccount")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="PurchaseCreditLine FinancialAccount", Name="financialAccounts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual financialAccountFeed financialAccounts { get { return _financialAccounts; } set { SetProperty(PropertyfinancialAccounts, ref _financialAccounts, value); } }

		[SMEResource(CanGet=true, PluralName="notes")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Label="PurchaseCreditLine Note", Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual noteFeed notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		#endregion


	}
}