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
	/// Defines a purchaseReturn feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("purchaseReturn", Namespace="http://schemas.sage.com/crmErp/2008")]
		[SMEResource(CanGet=true, PluralName="purchaseReturns")]
	public class purchaseReturnFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyid = "id";
		public const string Propertyactive = "active";
		public const string Propertydeleted = "deleted";
		public const string Propertylabel = "label";
		public const string Propertyreference = "reference";
		public const string Propertyreference2 = "reference2";
		public const string PropertyoperatingCompany = "operatingCompany";
		public const string Propertystatus = "status";
		public const string PropertystatusFlag = "statusFlag";
		public const string PropertystatusFlagText = "statusFlagText";
		public const string Propertycompany = "company";
		public const string Propertysupplier = "supplier";
		public const string PropertytradingAccount = "tradingAccount";
		public const string PropertysellerContact = "sellerContact";
		public const string PropertysupplierReference = "supplierReference";
		public const string Propertyreason = "reason";
		public const string Propertypricelist = "pricelist";
		public const string Propertytype = "type";
		public const string PropertycopyFlag = "copyFlag";
		public const string PropertyoriginatorDocument = "originatorDocument";
		public const string PropertypostalAddresses = "postalAddresses";
		public const string PropertydeliveryMethod = "deliveryMethod";
		public const string PropertydeliveryTerms = "deliveryTerms";
		public const string PropertydeliveryDate = "deliveryDate";
		public const string PropertycarrierCompany = "carrierCompany";
		public const string PropertycarrierSupplier = "carrierSupplier";
		public const string PropertycarrierTradingAccount = "carrierTradingAccount";
		public const string PropertycarrierNetPrice = "carrierNetPrice";
		public const string PropertycarrierTaxPrice = "carrierTaxPrice";
		public const string PropertycarrierTotalPrice = "carrierTotalPrice";
		public const string PropertycarrierPurchaseInvoice = "carrierPurchaseInvoice";
		public const string PropertycarrierTaxCodes = "carrierTaxCodes";
		public const string PropertycarrierReference = "carrierReference";
		public const string Propertycurrency = "currency";
		public const string PropertyoperatingCompanyCurrency = "operatingCompanyCurrency";
		public const string PropertyoperatingCompanyCurrencyExchangeRate = "operatingCompanyCurrencyExchangeRate";
		public const string PropertyoperatingCompanyCurrencyExchangeRateOperator = "operatingCompanyCurrencyExchangeRateOperator";
		public const string PropertyoperatingCompanyCurrencyExchangeRateDate = "operatingCompanyCurrencyExchangeRateDate";
		public const string PropertycreditCurrency = "creditCurrency";
		public const string PropertycreditCurrencyExchangeRate = "creditCurrencyExchangeRate";
		public const string PropertycreditCurrencyExchangeRateOperator = "creditCurrencyExchangeRateOperator";
		public const string PropertycreditCurrencyExchangeRateDate = "creditCurrencyExchangeRateDate";
		public const string PropertysupplierTradingAccountCurrency = "supplierTradingAccountCurrency";
		public const string PropertysupplierTradingAccountCurrencyExchangeRate = "supplierTradingAccountCurrencyExchangeRate";
		public const string PropertysupplierTradingAccountCurrencyExchangeRateOperator = "supplierTradingAccountCurrencyExchangeRateOperator";
		public const string PropertysupplierTradingAccountCurrencyExchangeRateDate = "supplierTradingAccountCurrencyExchangeRateDate";
		public const string Propertydate = "date";
		public const string Propertytime = "time";
		public const string Propertyvalidity = "validity";
		public const string PropertyexpirationDate = "expirationDate";
		public const string PropertytaxCodes = "taxCodes";
		public const string Propertyuser = "user";
		public const string PropertypurchaseReturnLines = "purchaseReturnLines";
		public const string PropertylineCount = "lineCount";
		public const string PropertyreturnDiscountType = "returnDiscountType";
		public const string PropertyreturnDiscountAmount = "returnDiscountAmount";
		public const string PropertyreturnDiscountPercent = "returnDiscountPercent";
		public const string PropertyreturnAdditionalDiscount1Type = "returnAdditionalDiscount1Type";
		public const string PropertyreturnAdditionalDiscount1Amount = "returnAdditionalDiscount1Amount";
		public const string PropertyreturnAdditionalDiscount1Percent = "returnAdditionalDiscount1Percent";
		public const string PropertyreturnAdditionalDiscount2 = "returnAdditionalDiscount2";
		public const string PropertyreturnAdditionalDiscount2Amount = "returnAdditionalDiscount2Amount";
		public const string PropertyreturnAdditionalDiscount2Percent = "returnAdditionalDiscount2Percent";
		public const string Propertytext1 = "text1";
		public const string Propertytext2 = "text2";
		public const string PropertynetTotal = "netTotal";
		public const string PropertydiscountTotal = "discountTotal";
		public const string PropertychargesTotal = "chargesTotal";
		public const string PropertytaxTotal = "taxTotal";
		public const string PropertygrossTotal = "grossTotal";
		public const string Propertyreceipts = "receipts";
		public const string Propertycontract = "contract";
		public const string PropertycreditTradingAccount = "creditTradingAccount";
		public const string PropertydestinationCountry = "destinationCountry";
		public const string Propertyprojects = "projects";
		public const string PropertyprojectLines = "projectLines";
		public const string Propertycases = "cases";
		public const string PropertypurchaseReturnDeliveries = "purchaseReturnDeliveries";
		public const string PropertyfinancialAccounts = "financialAccounts";
		public const string Propertyinteractions = "interactions";
		public const string Propertynotes = "notes";

		#endregion

		#region Fields

		private System.String _id;
		private System.Boolean _active;
		private System.Boolean _deleted;
		private System.String _label;
		private System.String _reference;
		private System.String _reference2;
		private companyFeedEntry _operatingCompany;
		private string _status;
		private Nullable<System.Boolean> _statusFlag;
		private System.String _statusFlagText;
		private companyFeedEntry _company;
		private supplierFeedEntry _supplier;
		private tradingAccountFeedEntry _tradingAccount;
		private contactFeedEntry _sellerContact;
		private System.String _supplierReference;
		private System.String _reason;
		private priceListFeedEntry _pricelist;
		private System.String _type;
		private System.Boolean _copyFlag;
		private purchaseReturnFeed _originatorDocument;
		private postalAddressFeed _postalAddresses;
		private System.String _deliveryMethod;
		private System.String _deliveryTerms;
		private Nullable<System.DateTime> _deliveryDate;
		private companyFeed _carrierCompany;
		private supplierFeed _carrierSupplier;
		private tradingAccountFeed _carrierTradingAccount;
		private Nullable<System.Decimal> _carrierNetPrice;
		private Nullable<System.Decimal> _carrierTaxPrice;
		private Nullable<System.Decimal> _carrierTotalPrice;
		private purchaseInvoiceFeed _carrierPurchaseInvoice;
		private taxCodeFeed _carrierTaxCodes;
		private System.String _carrierReference;
		private System.String _currency;
		private System.String _operatingCompanyCurrency;
		private Nullable<System.Decimal> _operatingCompanyCurrencyExchangeRate;
		private string _operatingCompanyCurrencyExchangeRateOperator;
		private Nullable<System.DateTime> _operatingCompanyCurrencyExchangeRateDate;
		private System.String _creditCurrency;
		private Nullable<System.Decimal> _creditCurrencyExchangeRate;
		private string _creditCurrencyExchangeRateOperator;
		private Nullable<System.DateTime> _creditCurrencyExchangeRateDate;
		private System.String _supplierTradingAccountCurrency;
		private Nullable<System.Decimal> _supplierTradingAccountCurrencyExchangeRate;
		private string _supplierTradingAccountCurrencyExchangeRateOperator;
		private Nullable<System.DateTime> _supplierTradingAccountCurrencyExchangeRateDate;
		private System.DateTime _date;
		private Nullable<System.DateTime> _time;
		private Nullable<System.Decimal> _validity;
		private Nullable<System.DateTime> _expirationDate;
		private taxCodeFeed _taxCodes;
		private System.String _user;
		private purchaseReturnLineFeed _purchaseReturnLines;
		private System.Decimal _lineCount;
		private string _returnDiscountType;
		private Nullable<System.Decimal> _returnDiscountAmount;
		private Nullable<System.Decimal> _returnDiscountPercent;
		private string _returnAdditionalDiscount1Type;
		private Nullable<System.Decimal> _returnAdditionalDiscount1Amount;
		private Nullable<System.Decimal> _returnAdditionalDiscount1Percent;
		private string _returnAdditionalDiscount2;
		private Nullable<System.Decimal> _returnAdditionalDiscount2Amount;
		private Nullable<System.Decimal> _returnAdditionalDiscount2Percent;
		private System.String _text1;
		private System.String _text2;
		private System.Decimal _netTotal;
		private System.Decimal _discountTotal;
		private Nullable<System.Decimal> _chargesTotal;
		private System.Decimal _taxTotal;
		private System.Decimal _grossTotal;
		private receiptFeed _receipts;
		private System.String _contract;
		private tradingAccountFeedEntry _creditTradingAccount;
		private System.String _destinationCountry;
		private projectFeed _projects;
		private projectLineFeed _projectLines;
		private caseFeed _cases;
		private purchaseReturnDeliveryFeed _purchaseReturnDeliveries;
		private financialAccountFeed _financialAccounts;
		private interactionFeed _interactions;
		private noteFeed _notes;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="purchaseReturnFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public purchaseReturnFeedEntrySchema()
		{
		}

		#region Properties


		[SMEStringProperty(Label="PurchaseReturn Application ID", Name="id", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual new System.String id { get { return _id; } set { SetProperty(Propertyid, ref _id, value); } }

		[SMEBoolProperty(Label="PurchaseReturn Active Flag", Name="active", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEBoolProperty(Label="PurchaseReturn Deleted", Name="deleted", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean deleted { get { return _deleted; } set { SetProperty(Propertydeleted, ref _deleted, value); } }

		[SMEStringProperty(Label="PurchaseReturn Label", Name="label", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String label { get { return _label; } set { SetProperty(Propertylabel, ref _label, value); } }

		[SMEStringProperty(Label="PurchaseReturn reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEStringProperty(Label="PurchaseReturn Reference2", Nillable=true, Name="reference2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="companies")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseReturn OperatingCompany", Name="operatingCompany", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("operatingCompany")]			
		public virtual companyFeedEntry operatingCompany { get { return _operatingCompany; } set { SetProperty(PropertyoperatingCompany, ref _operatingCompany, value); } }

		[SMEEnumProperty(EnumTypeName="purchaseReturnStatus--enum", Label="PurchaseReturn Status", Nillable=true, Name="status", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string status { get { return _status; } set { SetProperty(Propertystatus, ref _status, value); } }

		[SMEBoolProperty(Label="PurchaseReturn Status Flag", Nillable=true, Name="statusFlag", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Boolean> statusFlag { get { return _statusFlag; } set { SetProperty(PropertystatusFlag, ref _statusFlag, value); } }

		[SMEStringProperty(Label="PurchaseReturn Status Flag Text", Nillable=true, Name="statusFlagText", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String statusFlagText { get { return _statusFlagText; } set { SetProperty(PropertystatusFlagText, ref _statusFlagText, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="companies")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseReturn Company", Name="company", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("company")]			
		public virtual companyFeedEntry company { get { return _company; } set { SetProperty(Propertycompany, ref _company, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="suppliers")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseReturn Supplier", Name="supplier", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("supplier")]			
		public virtual supplierFeedEntry supplier { get { return _supplier; } set { SetProperty(Propertysupplier, ref _supplier, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseReturn Supplier TradingAccount", Name="tradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("tradingAccount")]			
		public virtual tradingAccountFeedEntry tradingAccount { get { return _tradingAccount; } set { SetProperty(PropertytradingAccount, ref _tradingAccount, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="contacts", Label="PurchaseReturn Seller Contact")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseReturn Seller Contact", Name="sellerContact", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("sellerContact")]			
		public virtual contactFeedEntry sellerContact { get { return _sellerContact; } set { SetProperty(PropertysellerContact, ref _sellerContact, value); } }

		[SMEStringProperty(Label="PurchaseReturn Supplier reference", Nillable=true, Name="supplierReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String supplierReference { get { return _supplierReference; } set { SetProperty(PropertysupplierReference, ref _supplierReference, value); } }

		[SMEStringProperty(Label="PurchaseReturn Reason", Nillable=true, Name="reason", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String reason { get { return _reason; } set { SetProperty(Propertyreason, ref _reason, value); } }

		[SMEResource(CanGet=true, PluralName="priceLists", Label="PurchaseReturn PriceList")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseReturn PriceList", Name="pricelist", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("pricelist")]			
		public virtual priceListFeedEntry pricelist { get { return _pricelist; } set { SetProperty(Propertypricelist, ref _pricelist, value); } }

		[SMEStringProperty(Label="PurchaseReturn Type", Nillable=true, Name="type", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }

		[SMEBoolProperty(Label="PurchaseReturn Copy Flag", Name="copyFlag", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean copyFlag { get { return _copyFlag; } set { SetProperty(PropertycopyFlag, ref _copyFlag, value); } }

		[SMEResource(CanGet=true, PluralName="purchaseReturns", Label="PurchaseReturn Originator Document reference")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="PurchaseReturn Originator Document reference", Name="originatorDocument", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseReturnFeed originatorDocument { get { return _originatorDocument; } set { SetProperty(PropertyoriginatorDocument, ref _originatorDocument, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="postalAddresses")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="PurchaseReturn PostalAddress", Name="postalAddresses", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual postalAddressFeed postalAddresses { get { return _postalAddresses; } set { SetProperty(PropertypostalAddresses, ref _postalAddresses, value); } }

		[SMEStringProperty(Label="PurchaseReturn Delivery Method", Nillable=true, Name="deliveryMethod", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String deliveryMethod { get { return _deliveryMethod; } set { SetProperty(PropertydeliveryMethod, ref _deliveryMethod, value); } }

		[SMEStringProperty(Label="PurchaseReturn Delivery Terms", Nillable=true, Name="deliveryTerms", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String deliveryTerms { get { return _deliveryTerms; } set { SetProperty(PropertydeliveryTerms, ref _deliveryTerms, value); } }

		[SMEDateProperty(Label="PurchaseReturn Delivery Date", Nillable=true, Name="deliveryDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> deliveryDate { get { return _deliveryDate; } set { SetProperty(PropertydeliveryDate, ref _deliveryDate, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="companies", Label="PurchaseReturn Carrier Company")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="PurchaseReturn Carrier Company", Name="carrierCompany", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual companyFeed carrierCompany { get { return _carrierCompany; } set { SetProperty(PropertycarrierCompany, ref _carrierCompany, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="suppliers", Label="PurchaseReturn Carrier Supplier")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="PurchaseReturn Carrier Supplier", Name="carrierSupplier", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual supplierFeed carrierSupplier { get { return _carrierSupplier; } set { SetProperty(PropertycarrierSupplier, ref _carrierSupplier, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="PurchaseReturn Carrier TradingAccount", Name="carrierTradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual tradingAccountFeed carrierTradingAccount { get { return _carrierTradingAccount; } set { SetProperty(PropertycarrierTradingAccount, ref _carrierTradingAccount, value); } }

		[SMEDecimalProperty(Label="PurchaseReturn Carrier Net Price", Nillable=true, Name="carrierNetPrice", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> carrierNetPrice { get { return _carrierNetPrice; } set { SetProperty(PropertycarrierNetPrice, ref _carrierNetPrice, value); } }

		[SMEDecimalProperty(Label="PurchaseReturn Carrier Tax Price", Nillable=true, Name="carrierTaxPrice", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> carrierTaxPrice { get { return _carrierTaxPrice; } set { SetProperty(PropertycarrierTaxPrice, ref _carrierTaxPrice, value); } }

		[SMEDecimalProperty(Label="PurchaseReturn Carrier Gross Price", Nillable=true, Name="carrierTotalPrice", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> carrierTotalPrice { get { return _carrierTotalPrice; } set { SetProperty(PropertycarrierTotalPrice, ref _carrierTotalPrice, value); } }

		[SMEResource(CanGet=true, CanPost=true, PluralName="purchaseInvoices", Label="PurchaseReturn Carrier PurchaseInvoice")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="PurchaseReturn Carrier PurchaseInvoice", Name="carrierPurchaseInvoice", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseInvoiceFeed carrierPurchaseInvoice { get { return _carrierPurchaseInvoice; } set { SetProperty(PropertycarrierPurchaseInvoice, ref _carrierPurchaseInvoice, value); } }

		[SMEResource(CanGet=true, PluralName="taxCodes", Label="PurchaseReturn Carrier Tax Code")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="PurchaseReturn Carrier Tax Code", Name="carrierTaxCodes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual taxCodeFeed carrierTaxCodes { get { return _carrierTaxCodes; } set { SetProperty(PropertycarrierTaxCodes, ref _carrierTaxCodes, value); } }

		[SMEStringProperty(Label="PurchaseReturn Carrier reference", Nillable=true, Name="carrierReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String carrierReference { get { return _carrierReference; } set { SetProperty(PropertycarrierReference, ref _carrierReference, value); } }

		[SMEStringProperty(Label="PurchaseReturn Currency", Name="currency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String currency { get { return _currency; } set { SetProperty(Propertycurrency, ref _currency, value); } }

		[SMEStringProperty(Label="PurchaseReturn OperatingCompany Currency", Name="operatingCompanyCurrency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String operatingCompanyCurrency { get { return _operatingCompanyCurrency; } set { SetProperty(PropertyoperatingCompanyCurrency, ref _operatingCompanyCurrency, value); } }

		[SMEDecimalProperty(Label="PurchaseReturn OperatingCompany Currency Exchange Rate", Nillable=true, Name="operatingCompanyCurrencyExchangeRate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> operatingCompanyCurrencyExchangeRate { get { return _operatingCompanyCurrencyExchangeRate; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRate, ref _operatingCompanyCurrencyExchangeRate, value); } }

		[SMEEnumProperty(EnumTypeName="RateOperator--enum", Label="PurchaseReturn OperatingCompany Currency Exchange Rate Operator", Nillable=true, Name="operatingCompanyCurrencyExchangeRateOperator", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string operatingCompanyCurrencyExchangeRateOperator { get { return _operatingCompanyCurrencyExchangeRateOperator; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRateOperator, ref _operatingCompanyCurrencyExchangeRateOperator, value); } }

		[SMEDateProperty(Label="PurchaseReturn OperatingCompany Currency Exchange Rate Date", Nillable=true, Name="operatingCompanyCurrencyExchangeRateDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> operatingCompanyCurrencyExchangeRateDate { get { return _operatingCompanyCurrencyExchangeRateDate; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRateDate, ref _operatingCompanyCurrencyExchangeRateDate, value); } }

		[SMEStringProperty(Label="PurchaseReturn Credit Currency", Nillable=true, Name="creditCurrency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String creditCurrency { get { return _creditCurrency; } set { SetProperty(PropertycreditCurrency, ref _creditCurrency, value); } }

		[SMEDecimalProperty(Label="PurchaseReturn Credit Currency Exchange Rate", Nillable=true, Name="creditCurrencyExchangeRate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> creditCurrencyExchangeRate { get { return _creditCurrencyExchangeRate; } set { SetProperty(PropertycreditCurrencyExchangeRate, ref _creditCurrencyExchangeRate, value); } }

		[SMEEnumProperty(EnumTypeName="RateOperator--enum", Label="PurchaseReturn Credit Currency Exchange Rate Operator", Nillable=true, Name="creditCurrencyExchangeRateOperator", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string creditCurrencyExchangeRateOperator { get { return _creditCurrencyExchangeRateOperator; } set { SetProperty(PropertycreditCurrencyExchangeRateOperator, ref _creditCurrencyExchangeRateOperator, value); } }

		[SMEDateProperty(Label="PurchaseReturn Credit Currency Exchange Rate Date", Nillable=true, Name="creditCurrencyExchangeRateDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> creditCurrencyExchangeRateDate { get { return _creditCurrencyExchangeRateDate; } set { SetProperty(PropertycreditCurrencyExchangeRateDate, ref _creditCurrencyExchangeRateDate, value); } }

		[SMEStringProperty(Label="PurchaseReturn Supplier TradingAccount Currency", Nillable=true, Name="supplierTradingAccountCurrency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String supplierTradingAccountCurrency { get { return _supplierTradingAccountCurrency; } set { SetProperty(PropertysupplierTradingAccountCurrency, ref _supplierTradingAccountCurrency, value); } }

		[SMEDecimalProperty(Label="PurchaseReturn Supplier TradingAccount Currency Exchange Rate", Nillable=true, Name="supplierTradingAccountCurrencyExchangeRate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> supplierTradingAccountCurrencyExchangeRate { get { return _supplierTradingAccountCurrencyExchangeRate; } set { SetProperty(PropertysupplierTradingAccountCurrencyExchangeRate, ref _supplierTradingAccountCurrencyExchangeRate, value); } }

		[SMEEnumProperty(EnumTypeName="RateOperator--enum", Label="PurchaseReturn Supplier TradingAccount Currency Exchange Rate Operator", Nillable=true, Name="supplierTradingAccountCurrencyExchangeRateOperator", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string supplierTradingAccountCurrencyExchangeRateOperator { get { return _supplierTradingAccountCurrencyExchangeRateOperator; } set { SetProperty(PropertysupplierTradingAccountCurrencyExchangeRateOperator, ref _supplierTradingAccountCurrencyExchangeRateOperator, value); } }

		[SMEDateProperty(Label="PurchaseReturn Supplier TradingAccount Currency Exchange Rate Date", Nillable=true, Name="supplierTradingAccountCurrencyExchangeRateDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> supplierTradingAccountCurrencyExchangeRateDate { get { return _supplierTradingAccountCurrencyExchangeRateDate; } set { SetProperty(PropertysupplierTradingAccountCurrencyExchangeRateDate, ref _supplierTradingAccountCurrencyExchangeRateDate, value); } }

		[SMEDateProperty(Label="PurchaseReturn Date", Name="date", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.DateTime date { get { return _date; } set { SetProperty(Propertydate, ref _date, value); } }

		[SMETimeProperty(Label="PurchaseReturn Time", Nillable=true, Name="time", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> time { get { return _time; } set { SetProperty(Propertytime, ref _time, value); } }

		[SMEDecimalProperty(Label="PurchaseReturn Validity", Nillable=true, Name="validity", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> validity { get { return _validity; } set { SetProperty(Propertyvalidity, ref _validity, value); } }

		[SMEDateProperty(Label="PurchaseReturn Expiration Date", Nillable=true, Name="expirationDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> expirationDate { get { return _expirationDate; } set { SetProperty(PropertyexpirationDate, ref _expirationDate, value); } }

		[SMEResource(CanGet=true, PluralName="taxCodes", Label="PurchaseReturn Tax Code")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="PurchaseReturn Tax Code", Name="taxCodes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual taxCodeFeed taxCodes { get { return _taxCodes; } set { SetProperty(PropertytaxCodes, ref _taxCodes, value); } }

		[SMEStringProperty(Label="PurchaseReturn User", Nillable=true, Name="user", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String user { get { return _user; } set { SetProperty(Propertyuser, ref _user, value); } }

		[SMEResource(CanGet=true, PluralName="purchaseReturnLines", Label="PurchaseReturn PurchaseReturnLine")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Label="PurchaseReturn PurchaseReturnLine", Name="purchaseReturnLines", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseReturnLineFeed purchaseReturnLines { get { return _purchaseReturnLines; } set { SetProperty(PropertypurchaseReturnLines, ref _purchaseReturnLines, value); } }

		[SMEDecimalProperty(Label="PurchaseReturn Line Count", Name="lineCount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal lineCount { get { return _lineCount; } set { SetProperty(PropertylineCount, ref _lineCount, value); } }

		[SMEEnumProperty(EnumTypeName="discountType--enum", Label="PurchaseReturn Return Discount Type", Nillable=true, Name="returnDiscountType", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string returnDiscountType { get { return _returnDiscountType; } set { SetProperty(PropertyreturnDiscountType, ref _returnDiscountType, value); } }

		[SMEDecimalProperty(Label="PurchaseReturn Return Discount Amount", Nillable=true, Name="returnDiscountAmount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> returnDiscountAmount { get { return _returnDiscountAmount; } set { SetProperty(PropertyreturnDiscountAmount, ref _returnDiscountAmount, value); } }

		[SMEDecimalProperty(Label="PurchaseReturn Return Discount Percent", Nillable=true, Name="returnDiscountPercent", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> returnDiscountPercent { get { return _returnDiscountPercent; } set { SetProperty(PropertyreturnDiscountPercent, ref _returnDiscountPercent, value); } }

		[SMEEnumProperty(EnumTypeName="discountType--enum", Label="PurchaseReturn Return Additional Discount1 Type", Nillable=true, Name="returnAdditionalDiscount1Type", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string returnAdditionalDiscount1Type { get { return _returnAdditionalDiscount1Type; } set { SetProperty(PropertyreturnAdditionalDiscount1Type, ref _returnAdditionalDiscount1Type, value); } }

		[SMEDecimalProperty(Label="PurchaseReturn Return Additional Discount1 Amount", Nillable=true, Name="returnAdditionalDiscount1Amount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> returnAdditionalDiscount1Amount { get { return _returnAdditionalDiscount1Amount; } set { SetProperty(PropertyreturnAdditionalDiscount1Amount, ref _returnAdditionalDiscount1Amount, value); } }

		[SMEDecimalProperty(Label="PurchaseReturn Return Additional Discount1 Percent", Nillable=true, Name="returnAdditionalDiscount1Percent", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> returnAdditionalDiscount1Percent { get { return _returnAdditionalDiscount1Percent; } set { SetProperty(PropertyreturnAdditionalDiscount1Percent, ref _returnAdditionalDiscount1Percent, value); } }

		[SMEEnumProperty(EnumTypeName="discountType--enum", Label="PurchaseReturn Return Additional Discount2 Type", Nillable=true, Name="returnAdditionalDiscount2", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string returnAdditionalDiscount2 { get { return _returnAdditionalDiscount2; } set { SetProperty(PropertyreturnAdditionalDiscount2, ref _returnAdditionalDiscount2, value); } }

		[SMEDecimalProperty(Label="PurchaseReturn Return Additional Discount2 Amount", Nillable=true, Name="returnAdditionalDiscount2Amount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> returnAdditionalDiscount2Amount { get { return _returnAdditionalDiscount2Amount; } set { SetProperty(PropertyreturnAdditionalDiscount2Amount, ref _returnAdditionalDiscount2Amount, value); } }

		[SMEDecimalProperty(Label="PurchaseReturn Return Additional Discount2 Percent", Nillable=true, Name="returnAdditionalDiscount2Percent", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> returnAdditionalDiscount2Percent { get { return _returnAdditionalDiscount2Percent; } set { SetProperty(PropertyreturnAdditionalDiscount2Percent, ref _returnAdditionalDiscount2Percent, value); } }

		[SMEStringProperty(Label="PurchaseReturn Text1", Nillable=true, Name="text1", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String text1 { get { return _text1; } set { SetProperty(Propertytext1, ref _text1, value); } }

		[SMEStringProperty(Label="PurchaseReturn Text2", Nillable=true, Name="text2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String text2 { get { return _text2; } set { SetProperty(Propertytext2, ref _text2, value); } }

		[SMEDecimalProperty(Label="PurchaseReturn Net Total", Name="netTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal netTotal { get { return _netTotal; } set { SetProperty(PropertynetTotal, ref _netTotal, value); } }

		[SMEDecimalProperty(Label="PurchaseReturn Discount Total", Name="discountTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal discountTotal { get { return _discountTotal; } set { SetProperty(PropertydiscountTotal, ref _discountTotal, value); } }

		[SMEDecimalProperty(Label="PurchaseReturn Charges Total", Nillable=true, Name="chargesTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> chargesTotal { get { return _chargesTotal; } set { SetProperty(PropertychargesTotal, ref _chargesTotal, value); } }

		[SMEDecimalProperty(Label="PurchaseReturn Tax Total", Name="taxTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal taxTotal { get { return _taxTotal; } set { SetProperty(PropertytaxTotal, ref _taxTotal, value); } }

		[SMEDecimalProperty(Label="PurchaseReturn Gross Total", Name="grossTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal grossTotal { get { return _grossTotal; } set { SetProperty(PropertygrossTotal, ref _grossTotal, value); } }

		[SMEResource(CanGet=true, PluralName="receipts", Label="PurchaseReturn Receipt")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="PurchaseReturn Receipt", Name="receipts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual receiptFeed receipts { get { return _receipts; } set { SetProperty(Propertyreceipts, ref _receipts, value); } }

		[SMEStringProperty(Label="PurchaseReturn Contract", Nillable=true, Name="contract", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String contract { get { return _contract; } set { SetProperty(Propertycontract, ref _contract, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseReturn Credit TradingAccount", Name="creditTradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("creditTradingAccount")]			
		public virtual tradingAccountFeedEntry creditTradingAccount { get { return _creditTradingAccount; } set { SetProperty(PropertycreditTradingAccount, ref _creditTradingAccount, value); } }

		[SMEStringProperty(Label="PurchaseReturn Destination Country", Nillable=true, Name="destinationCountry", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String destinationCountry { get { return _destinationCountry; } set { SetProperty(PropertydestinationCountry, ref _destinationCountry, value); } }

		[SMEResource(CanGet=true, PluralName="projects", Label="PurchaseReturn Project")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="PurchaseReturn Project", Name="projects", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual projectFeed projects { get { return _projects; } set { SetProperty(Propertyprojects, ref _projects, value); } }

		[SMEResource(CanGet=true, PluralName="projectLines", Label="PurchaseReturn ProjectLine")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="PurchaseReturn ProjectLine", Name="projectLines", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual projectLineFeed projectLines { get { return _projectLines; } set { SetProperty(PropertyprojectLines, ref _projectLines, value); } }

		[SMEResource(CanGet=true, PluralName="cases", Label="PurchaseReturn Case reference")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="PurchaseReturn Case reference", Name="cases", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual caseFeed cases { get { return _cases; } set { SetProperty(Propertycases, ref _cases, value); } }

		[SMEResource(CanGet=true, PluralName="purchaseReturnDeliveries", Label="PurchaseReturn PurchaseReturnDeliveries")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="PurchaseReturn PurchaseReturnDeliveries", Name="purchaseReturnDeliveries", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseReturnDeliveryFeed purchaseReturnDeliveries { get { return _purchaseReturnDeliveries; } set { SetProperty(PropertypurchaseReturnDeliveries, ref _purchaseReturnDeliveries, value); } }

		[SMEResource(CanGet=true, PluralName="financialAccounts", Label="PurchaseReturn FinancialAccount")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="PurchaseReturn FinancialAccount", Name="financialAccounts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual financialAccountFeed financialAccounts { get { return _financialAccounts; } set { SetProperty(PropertyfinancialAccounts, ref _financialAccounts, value); } }

		[SMEResource(CanGet=true, PluralName="interactions", Label="PurchaseReturn Interaction")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="PurchaseReturn Interaction", Name="interactions", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual interactionFeed interactions { get { return _interactions; } set { SetProperty(Propertyinteractions, ref _interactions, value); } }

		[SMEResource(CanGet=true, PluralName="notes")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Label="PurchaseReturn Note", Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual noteFeed notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		#endregion


	}
}