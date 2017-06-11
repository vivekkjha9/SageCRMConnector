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
	/// Defines a salesCredit feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("salesCredit", Namespace="http://schemas.sage.com/crmErp/2008")]
		[SMEResource(CanGet=true, CanPost=true, CanPut=true, PluralName="salesCredits")]
	public class salesCreditFeedEntrySchema : Sage.Common.Syndication.FeedEntry
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
		public const string Propertytype = "type";
		public const string Propertycompany = "company";
		public const string Propertycustomer = "customer";
		public const string PropertytradingAccount = "tradingAccount";
		public const string PropertycustomerReference = "customerReference";
		public const string Propertyopportunity = "opportunity";
		public const string Propertypricelist = "pricelist";
		public const string PropertycopyFlag = "copyFlag";
		public const string Propertydate = "date";
		public const string Propertytime = "time";
		public const string PropertytaxDate = "taxDate";
		public const string PropertytaxCodes = "taxCodes";
		public const string PropertypostalAddresses = "postalAddresses";
		public const string PropertydeliveryMethod = "deliveryMethod";
		public const string PropertydeliveryTerms = "deliveryTerms";
		public const string PropertydeliveryRule = "deliveryRule";
		public const string PropertydeliveryDate = "deliveryDate";
		public const string PropertycarrierCompany = "carrierCompany";
		public const string PropertycarrierSupplier = "carrierSupplier";
		public const string PropertycarrierTradingAccount = "carrierTradingAccount";
		public const string PropertycarrierNetPrice = "carrierNetPrice";
		public const string PropertycarrierTaxPrice = "carrierTaxPrice";
		public const string PropertycarrierTotalPrice = "carrierTotalPrice";
		public const string PropertycarrierSalesInvoice = "carrierSalesInvoice";
		public const string PropertycarrierPurchaseInvoice = "carrierPurchaseInvoice";
		public const string PropertycarrierTaxCodes = "carrierTaxCodes";
		public const string PropertycarrierReference = "carrierReference";
		public const string Propertycurrency = "currency";
		public const string PropertyoperatingCompanyCurrency = "operatingCompanyCurrency";
		public const string PropertyoperatingCompanyCurrencyExchangeRate = "operatingCompanyCurrencyExchangeRate";
		public const string PropertyoperatingCompanyCurrencyExchangeRateOperator = "operatingCompanyCurrencyExchangeRateOperator";
		public const string PropertyoperatingCompanyCurrencyExchangeRateDate = "operatingCompanyCurrencyExchangeRateDate";
		public const string PropertycustomerTradingAccountCurrency = "customerTradingAccountCurrency";
		public const string PropertycustomerTradingAccountCurrencyExchangeRate = "customerTradingAccountCurrencyExchangeRate";
		public const string PropertycustomerTradingAccountCurrencyExchangeRateOperator = "customerTradingAccountCurrencyExchangeRateOperator";
		public const string PropertycustomerTradingAccountCurrencyExchangeRateDate = "customerTradingAccountCurrencyExchangeRateDate";
		public const string PropertybuyerContact = "buyerContact";
		public const string Propertysalespersons = "salespersons";
		public const string PropertysalesCreditLines = "salesCreditLines";
		public const string PropertylineCount = "lineCount";
		public const string PropertyoriginatorDocument = "originatorDocument";
		public const string PropertysalesReturnDeliveries = "salesReturnDeliveries";
		public const string Propertypayments = "payments";
		public const string Propertycontract = "contract";
		public const string PropertysettlementDiscountType = "settlementDiscountType";
		public const string PropertysettlementDiscountAmount = "settlementDiscountAmount";
		public const string PropertysettlementDiscountPercent = "settlementDiscountPercent";
		public const string PropertysettlementDiscountTerms = "settlementDiscountTerms";
		public const string PropertysettlementDiscountIncludedInTotal = "settlementDiscountIncludedInTotal";
		public const string PropertyinvoiceDiscountType = "invoiceDiscountType";
		public const string PropertyinvoiceDiscountAmount = "invoiceDiscountAmount";
		public const string PropertyinvoiceDiscountPercent = "invoiceDiscountPercent";
		public const string PropertyinvoiceAdditionalDiscount1Type = "invoiceAdditionalDiscount1Type";
		public const string PropertyinvoiceAdditionalDiscount1Amount = "invoiceAdditionalDiscount1Amount";
		public const string PropertyinvoiceAdditionalDiscount1Percent = "invoiceAdditionalDiscount1Percent";
		public const string PropertyinvoiceAdditionalDiscount2 = "invoiceAdditionalDiscount2";
		public const string PropertyinvoiceAdditionalDiscount2Amount = "invoiceAdditionalDiscount2Amount";
		public const string PropertyinvoiceAdditionalDiscount2Percent = "invoiceAdditionalDiscount2Percent";
		public const string PropertynetTotal = "netTotal";
		public const string PropertydiscountTotal = "discountTotal";
		public const string PropertychargesTotal = "chargesTotal";
		public const string PropertytaxTotal = "taxTotal";
		public const string PropertygrossTotal = "grossTotal";
		public const string PropertycostTotal = "costTotal";
		public const string Propertytext1 = "text1";
		public const string Propertytext2 = "text2";
		public const string Propertyprojects = "projects";
		public const string PropertyprojectLines = "projectLines";
		public const string Propertycases = "cases";
		public const string PropertyfinancialAccounts = "financialAccounts";
		public const string Propertyinteractions = "interactions";
		public const string Propertyuser = "user";
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
		private string _type;
		private companyFeedEntry _company;
		private customerFeedEntry _customer;
		private tradingAccountFeedEntry _tradingAccount;
		private System.String _customerReference;
		private opportunityFeedEntry _opportunity;
		private priceListFeedEntry _pricelist;
		private System.Boolean _copyFlag;
		private System.DateTime _date;
		private Nullable<System.DateTime> _time;
		private System.DateTime _taxDate;
		private taxCodeFeed _taxCodes;
		private postalAddressFeed _postalAddresses;
		private System.String _deliveryMethod;
		private System.String _deliveryTerms;
		private Nullable<System.Boolean> _deliveryRule;
		private Nullable<System.DateTime> _deliveryDate;
		private companyFeed _carrierCompany;
		private supplierFeed _carrierSupplier;
		private tradingAccountFeed _carrierTradingAccount;
		private Nullable<System.Decimal> _carrierNetPrice;
		private Nullable<System.Decimal> _carrierTaxPrice;
		private Nullable<System.Decimal> _carrierTotalPrice;
		private salesInvoiceFeed _carrierSalesInvoice;
		private purchaseInvoiceFeed _carrierPurchaseInvoice;
		private taxCodeFeed _carrierTaxCodes;
		private System.String _carrierReference;
		private System.String _currency;
		private System.String _operatingCompanyCurrency;
		private Nullable<System.Decimal> _operatingCompanyCurrencyExchangeRate;
		private string _operatingCompanyCurrencyExchangeRateOperator;
		private Nullable<System.DateTime> _operatingCompanyCurrencyExchangeRateDate;
		private System.String _customerTradingAccountCurrency;
		private Nullable<System.Decimal> _customerTradingAccountCurrencyExchangeRate;
		private string _customerTradingAccountCurrencyExchangeRateOperator;
		private Nullable<System.DateTime> _customerTradingAccountCurrencyExchangeRateDate;
		private contactFeedEntry _buyerContact;
		private salesPersonFeed _salespersons;
		private salesCreditLineFeed _salesCreditLines;
		private System.Decimal _lineCount;
		private salesOrderFeedEntry _originatorDocument;
		private salesReturnDeliveryFeed _salesReturnDeliveries;
		private paymentFeed _payments;
		private System.String _contract;
		private string _settlementDiscountType;
		private Nullable<System.Decimal> _settlementDiscountAmount;
		private Nullable<System.Decimal> _settlementDiscountPercent;
		private System.String _settlementDiscountTerms;
		private Nullable<System.Boolean> _settlementDiscountIncludedInTotal;
		private string _invoiceDiscountType;
		private Nullable<System.Decimal> _invoiceDiscountAmount;
		private Nullable<System.Decimal> _invoiceDiscountPercent;
		private string _invoiceAdditionalDiscount1Type;
		private Nullable<System.Decimal> _invoiceAdditionalDiscount1Amount;
		private Nullable<System.Decimal> _invoiceAdditionalDiscount1Percent;
		private string _invoiceAdditionalDiscount2;
		private Nullable<System.Decimal> _invoiceAdditionalDiscount2Amount;
		private Nullable<System.Decimal> _invoiceAdditionalDiscount2Percent;
		private System.Decimal _netTotal;
		private System.Decimal _discountTotal;
		private Nullable<System.Decimal> _chargesTotal;
		private System.Decimal _taxTotal;
		private System.Decimal _grossTotal;
		private Nullable<System.Decimal> _costTotal;
		private System.String _text1;
		private System.String _text2;
		private projectFeed _projects;
		private projectLineFeed _projectLines;
		private caseFeed _cases;
		private financialAccountFeed _financialAccounts;
		private interactionFeed _interactions;
		private System.String _user;
		private noteFeed _notes;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="salesCreditFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public salesCreditFeedEntrySchema()
		{
		}

		#region Properties


		[SMEStringProperty(Label="SalesCredit Application ID", Name="id", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual new System.String id { get { return _id; } set { SetProperty(Propertyid, ref _id, value); } }

		[SMEBoolProperty(Label="SalesCredit Active Flag", Name="active", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEBoolProperty(Label="SalesCredit Deleted", Name="deleted", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean deleted { get { return _deleted; } set { SetProperty(Propertydeleted, ref _deleted, value); } }

		[SMEStringProperty(Label="SalesCredit Label", Name="label", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String label { get { return _label; } set { SetProperty(Propertylabel, ref _label, value); } }

		[SMEStringProperty(Label="SalesCredit reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEStringProperty(Label="SalesCredit Reference2", Nillable=true, Name="reference2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="companies")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="SalesCredit OperatingCompany", Name="operatingCompany", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("operatingCompany")]			
		public virtual companyFeedEntry operatingCompany { get { return _operatingCompany; } set { SetProperty(PropertyoperatingCompany, ref _operatingCompany, value); } }

		[SMEEnumProperty(EnumTypeName="salesCreditStatus--enum", Label="SalesCredit Status", Nillable=true, Name="status", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string status { get { return _status; } set { SetProperty(Propertystatus, ref _status, value); } }

		[SMEBoolProperty(Label="SalesCredit Status Flag", Nillable=true, Name="statusFlag", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Boolean> statusFlag { get { return _statusFlag; } set { SetProperty(PropertystatusFlag, ref _statusFlag, value); } }

		[SMEStringProperty(Label="SalesCredit Status Flag Text", Nillable=true, Name="statusFlagText", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String statusFlagText { get { return _statusFlagText; } set { SetProperty(PropertystatusFlagText, ref _statusFlagText, value); } }

		[SMEEnumProperty(EnumTypeName="salesCreditType--enum", Label="SalesCredit Type", Nillable=true, Name="type", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="companies")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="SalesCredit Company", Name="company", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("company")]			
		public virtual companyFeedEntry company { get { return _company; } set { SetProperty(Propertycompany, ref _company, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="customers")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="SalesCredit Customer", Name="customer", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("customer")]			
		public virtual customerFeedEntry customer { get { return _customer; } set { SetProperty(Propertycustomer, ref _customer, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="SalesCredit Customer TradingAccount", Name="tradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("tradingAccount")]			
		public virtual tradingAccountFeedEntry tradingAccount { get { return _tradingAccount; } set { SetProperty(PropertytradingAccount, ref _tradingAccount, value); } }

		[SMEStringProperty(Label="SalesCredit Customer reference", Nillable=true, Name="customerReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String customerReference { get { return _customerReference; } set { SetProperty(PropertycustomerReference, ref _customerReference, value); } }

		[SMEResource(CanGet=true, PluralName="opportunities", Label="SalesCredit Opportunity")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="SalesCredit Opportunity", Name="opportunity", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("opportunity")]			
		public virtual opportunityFeedEntry opportunity { get { return _opportunity; } set { SetProperty(Propertyopportunity, ref _opportunity, value); } }

		[SMEResource(CanGet=true, PluralName="priceLists", Label="SalesCredit PriceList")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="SalesCredit PriceList", Name="pricelist", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("pricelist")]			
		public virtual priceListFeedEntry pricelist { get { return _pricelist; } set { SetProperty(Propertypricelist, ref _pricelist, value); } }

		[SMEBoolProperty(Label="SalesCredit Copy Flag", Name="copyFlag", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean copyFlag { get { return _copyFlag; } set { SetProperty(PropertycopyFlag, ref _copyFlag, value); } }

		[SMEDateProperty(Label="SalesCredit Date", Name="date", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.DateTime date { get { return _date; } set { SetProperty(Propertydate, ref _date, value); } }

		[SMETimeProperty(Label="SalesCredit Time", Nillable=true, Name="time", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> time { get { return _time; } set { SetProperty(Propertytime, ref _time, value); } }

		[SMEDateProperty(Label="SalesCredit Tax Date", Name="taxDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.DateTime taxDate { get { return _taxDate; } set { SetProperty(PropertytaxDate, ref _taxDate, value); } }

		[SMEResource(CanGet=true, PluralName="taxCodes", Label="SalesCredit Tax Code")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="SalesCredit Tax Code", Name="taxCodes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual taxCodeFeed taxCodes { get { return _taxCodes; } set { SetProperty(PropertytaxCodes, ref _taxCodes, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="postalAddresses")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="SalesCredit PostalAddress", Name="postalAddresses", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual postalAddressFeed postalAddresses { get { return _postalAddresses; } set { SetProperty(PropertypostalAddresses, ref _postalAddresses, value); } }

		[SMEStringProperty(Label="SalesCredit Delivery Method", Nillable=true, Name="deliveryMethod", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String deliveryMethod { get { return _deliveryMethod; } set { SetProperty(PropertydeliveryMethod, ref _deliveryMethod, value); } }

		[SMEStringProperty(Label="SalesCredit Delivery Terms", Nillable=true, Name="deliveryTerms", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String deliveryTerms { get { return _deliveryTerms; } set { SetProperty(PropertydeliveryTerms, ref _deliveryTerms, value); } }

		[SMEBoolProperty(Label="SalesCredit Delivery Rule", Nillable=true, Name="deliveryRule", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Boolean> deliveryRule { get { return _deliveryRule; } set { SetProperty(PropertydeliveryRule, ref _deliveryRule, value); } }

		[SMEDateProperty(Label="SalesCredit Delivery Date", Nillable=true, Name="deliveryDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> deliveryDate { get { return _deliveryDate; } set { SetProperty(PropertydeliveryDate, ref _deliveryDate, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="companies", Label="SalesCredit Carrier Company")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="SalesCredit Carrier Company", Name="carrierCompany", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual companyFeed carrierCompany { get { return _carrierCompany; } set { SetProperty(PropertycarrierCompany, ref _carrierCompany, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="suppliers", Label="SalesCredit Carrier Supplier")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="SalesCredit Carrier Supplier", Name="carrierSupplier", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual supplierFeed carrierSupplier { get { return _carrierSupplier; } set { SetProperty(PropertycarrierSupplier, ref _carrierSupplier, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="SalesCredit Carrier TradingAccount", Name="carrierTradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual tradingAccountFeed carrierTradingAccount { get { return _carrierTradingAccount; } set { SetProperty(PropertycarrierTradingAccount, ref _carrierTradingAccount, value); } }

		[SMEDecimalProperty(Label="SalesCredit Carrier Net Price", Nillable=true, Name="carrierNetPrice", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> carrierNetPrice { get { return _carrierNetPrice; } set { SetProperty(PropertycarrierNetPrice, ref _carrierNetPrice, value); } }

		[SMEDecimalProperty(Label="SalesCredit Carrier Tax Price", Nillable=true, Name="carrierTaxPrice", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> carrierTaxPrice { get { return _carrierTaxPrice; } set { SetProperty(PropertycarrierTaxPrice, ref _carrierTaxPrice, value); } }

		[SMEDecimalProperty(Label="SalesCredit Carrier Gross Price", Nillable=true, Name="carrierTotalPrice", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> carrierTotalPrice { get { return _carrierTotalPrice; } set { SetProperty(PropertycarrierTotalPrice, ref _carrierTotalPrice, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, PluralName="salesInvoices", Label="SalesCredit Carrier SalesInvoice")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="SalesCredit Carrier SalesInvoice", Name="carrierSalesInvoice", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesInvoiceFeed carrierSalesInvoice { get { return _carrierSalesInvoice; } set { SetProperty(PropertycarrierSalesInvoice, ref _carrierSalesInvoice, value); } }

		[SMEResource(CanGet=true, CanPost=true, PluralName="purchaseInvoices", Label="SalesCredit Carrier PurchaseInvoice")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="SalesCredit Carrier PurchaseInvoice", Name="carrierPurchaseInvoice", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseInvoiceFeed carrierPurchaseInvoice { get { return _carrierPurchaseInvoice; } set { SetProperty(PropertycarrierPurchaseInvoice, ref _carrierPurchaseInvoice, value); } }

		[SMEResource(CanGet=true, PluralName="taxCodes", Label="SalesCredit Carrier Tax Code")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="SalesCredit Carrier Tax Code", Name="carrierTaxCodes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual taxCodeFeed carrierTaxCodes { get { return _carrierTaxCodes; } set { SetProperty(PropertycarrierTaxCodes, ref _carrierTaxCodes, value); } }

		[SMEStringProperty(Label="SalesCredit Carrier reference", Nillable=true, Name="carrierReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String carrierReference { get { return _carrierReference; } set { SetProperty(PropertycarrierReference, ref _carrierReference, value); } }

		[SMEStringProperty(Label="SalesCredit Currency", Name="currency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String currency { get { return _currency; } set { SetProperty(Propertycurrency, ref _currency, value); } }

		[SMEStringProperty(Label="SalesCredit OperatingCompany Currency", Name="operatingCompanyCurrency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String operatingCompanyCurrency { get { return _operatingCompanyCurrency; } set { SetProperty(PropertyoperatingCompanyCurrency, ref _operatingCompanyCurrency, value); } }

		[SMEDecimalProperty(Label="SalesCredit OperatingCompany Currency Exchange Rate", Nillable=true, Name="operatingCompanyCurrencyExchangeRate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> operatingCompanyCurrencyExchangeRate { get { return _operatingCompanyCurrencyExchangeRate; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRate, ref _operatingCompanyCurrencyExchangeRate, value); } }

		[SMEEnumProperty(EnumTypeName="RateOperator--enum", Label="SalesCredit OperatingCompany Currency Exchange Rate Operator", Nillable=true, Name="operatingCompanyCurrencyExchangeRateOperator", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string operatingCompanyCurrencyExchangeRateOperator { get { return _operatingCompanyCurrencyExchangeRateOperator; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRateOperator, ref _operatingCompanyCurrencyExchangeRateOperator, value); } }

		[SMEDateProperty(Label="SalesCredit OperatingCompany Currency Exchange Rate Date", Nillable=true, Name="operatingCompanyCurrencyExchangeRateDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> operatingCompanyCurrencyExchangeRateDate { get { return _operatingCompanyCurrencyExchangeRateDate; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRateDate, ref _operatingCompanyCurrencyExchangeRateDate, value); } }

		[SMEStringProperty(Label="SalesCredit Customer TradingAccount Currency", Nillable=true, Name="customerTradingAccountCurrency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String customerTradingAccountCurrency { get { return _customerTradingAccountCurrency; } set { SetProperty(PropertycustomerTradingAccountCurrency, ref _customerTradingAccountCurrency, value); } }

		[SMEDecimalProperty(Label="SalesCredit Customer TradingAccount Currency Exchange Rate", Nillable=true, Name="customerTradingAccountCurrencyExchangeRate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> customerTradingAccountCurrencyExchangeRate { get { return _customerTradingAccountCurrencyExchangeRate; } set { SetProperty(PropertycustomerTradingAccountCurrencyExchangeRate, ref _customerTradingAccountCurrencyExchangeRate, value); } }

		[SMEEnumProperty(EnumTypeName="RateOperator--enum", Label="SalesCredit Customer TradingAccount Currency Exchange Rate Operator", Nillable=true, Name="customerTradingAccountCurrencyExchangeRateOperator", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string customerTradingAccountCurrencyExchangeRateOperator { get { return _customerTradingAccountCurrencyExchangeRateOperator; } set { SetProperty(PropertycustomerTradingAccountCurrencyExchangeRateOperator, ref _customerTradingAccountCurrencyExchangeRateOperator, value); } }

		[SMEDateProperty(Label="SalesCredit Customer TradingAccount Currency Exchange Rate Date", Nillable=true, Name="customerTradingAccountCurrencyExchangeRateDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> customerTradingAccountCurrencyExchangeRateDate { get { return _customerTradingAccountCurrencyExchangeRateDate; } set { SetProperty(PropertycustomerTradingAccountCurrencyExchangeRateDate, ref _customerTradingAccountCurrencyExchangeRateDate, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="contacts", Label="SalesCredit Buyer Contact")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="SalesCredit Buyer Contact", Name="buyerContact", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("buyerContact")]			
		public virtual contactFeedEntry buyerContact { get { return _buyerContact; } set { SetProperty(PropertybuyerContact, ref _buyerContact, value); } }

		[SMEResource(PluralName="salesPersons", Label="SalesCredit Salesperson")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="SalesCredit Salesperson", Name="salespersons", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesPersonFeed salespersons { get { return _salespersons; } set { SetProperty(Propertysalespersons, ref _salespersons, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, PluralName="salesCreditLines", Label="SalesCredit SalesCreditLine")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Label="SalesCredit SalesCreditLine", Name="salesCreditLines", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesCreditLineFeed salesCreditLines { get { return _salesCreditLines; } set { SetProperty(PropertysalesCreditLines, ref _salesCreditLines, value); } }

		[SMEDecimalProperty(Label="SalesCredit Line Count", Name="lineCount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal lineCount { get { return _lineCount; } set { SetProperty(PropertylineCount, ref _lineCount, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, PluralName="salesOrders", Label="SalesCredit Originator Document reference")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="SalesCredit Originator Document reference", Name="originatorDocument", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("originatorDocument")]			
		public virtual salesOrderFeedEntry originatorDocument { get { return _originatorDocument; } set { SetProperty(PropertyoriginatorDocument, ref _originatorDocument, value); } }

		[SMEResource(CanGet=true, PluralName="salesReturnDeliveries", Label="SalesCredit SalesReturnDelivery")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="SalesCredit SalesReturnDelivery", Name="salesReturnDeliveries", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesReturnDeliveryFeed salesReturnDeliveries { get { return _salesReturnDeliveries; } set { SetProperty(PropertysalesReturnDeliveries, ref _salesReturnDeliveries, value); } }

		[SMEResource(CanGet=true, PluralName="payments", Label="SalesCredit Payment")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="SalesCredit Payment", Name="payments", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual paymentFeed payments { get { return _payments; } set { SetProperty(Propertypayments, ref _payments, value); } }

		[SMEStringProperty(Label="SalesCredit Contract", Nillable=true, Name="contract", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String contract { get { return _contract; } set { SetProperty(Propertycontract, ref _contract, value); } }

		[SMEEnumProperty(EnumTypeName="discountType--enum", Label="SalesCredit Settlement Discount Type", Nillable=true, Name="settlementDiscountType", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string settlementDiscountType { get { return _settlementDiscountType; } set { SetProperty(PropertysettlementDiscountType, ref _settlementDiscountType, value); } }

		[SMEDecimalProperty(Label="SalesCredit Settlement Discount Amount", Nillable=true, Name="settlementDiscountAmount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> settlementDiscountAmount { get { return _settlementDiscountAmount; } set { SetProperty(PropertysettlementDiscountAmount, ref _settlementDiscountAmount, value); } }

		[SMEDecimalProperty(Label="SalesCredit Settlement Discount Percent", Nillable=true, Name="settlementDiscountPercent", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> settlementDiscountPercent { get { return _settlementDiscountPercent; } set { SetProperty(PropertysettlementDiscountPercent, ref _settlementDiscountPercent, value); } }

		[SMEStringProperty(Label="SalesCredit Settlement Discount Terms", Nillable=true, Name="settlementDiscountTerms", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String settlementDiscountTerms { get { return _settlementDiscountTerms; } set { SetProperty(PropertysettlementDiscountTerms, ref _settlementDiscountTerms, value); } }

		[SMEBoolProperty(Label="SalesCredit Settlement Discount Included In Total", Nillable=true, Name="settlementDiscountIncludedInTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Boolean> settlementDiscountIncludedInTotal { get { return _settlementDiscountIncludedInTotal; } set { SetProperty(PropertysettlementDiscountIncludedInTotal, ref _settlementDiscountIncludedInTotal, value); } }

		[SMEEnumProperty(EnumTypeName="discountType--enum", Label="SalesCredit Invoice Discount Type", Nillable=true, Name="invoiceDiscountType", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string invoiceDiscountType { get { return _invoiceDiscountType; } set { SetProperty(PropertyinvoiceDiscountType, ref _invoiceDiscountType, value); } }

		[SMEDecimalProperty(Label="SalesCredit Invoice Discount Amount", Nillable=true, Name="invoiceDiscountAmount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> invoiceDiscountAmount { get { return _invoiceDiscountAmount; } set { SetProperty(PropertyinvoiceDiscountAmount, ref _invoiceDiscountAmount, value); } }

		[SMEDecimalProperty(Label="SalesCredit Invoice Discount Percent", Nillable=true, Name="invoiceDiscountPercent", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> invoiceDiscountPercent { get { return _invoiceDiscountPercent; } set { SetProperty(PropertyinvoiceDiscountPercent, ref _invoiceDiscountPercent, value); } }

		[SMEEnumProperty(EnumTypeName="discountType--enum", Label="SalesCredit Invoice Additional Discount1 Type", Nillable=true, Name="invoiceAdditionalDiscount1Type", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string invoiceAdditionalDiscount1Type { get { return _invoiceAdditionalDiscount1Type; } set { SetProperty(PropertyinvoiceAdditionalDiscount1Type, ref _invoiceAdditionalDiscount1Type, value); } }

		[SMEDecimalProperty(Label="SalesCredit Invoice Additional Discount1 Amount", Nillable=true, Name="invoiceAdditionalDiscount1Amount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> invoiceAdditionalDiscount1Amount { get { return _invoiceAdditionalDiscount1Amount; } set { SetProperty(PropertyinvoiceAdditionalDiscount1Amount, ref _invoiceAdditionalDiscount1Amount, value); } }

		[SMEDecimalProperty(Label="SalesCredit Invoice Additional Discount1 Percent", Nillable=true, Name="invoiceAdditionalDiscount1Percent", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> invoiceAdditionalDiscount1Percent { get { return _invoiceAdditionalDiscount1Percent; } set { SetProperty(PropertyinvoiceAdditionalDiscount1Percent, ref _invoiceAdditionalDiscount1Percent, value); } }

		[SMEEnumProperty(EnumTypeName="discountType--enum", Label="SalesCredit Invoice Additional Discount2 Type", Nillable=true, Name="invoiceAdditionalDiscount2", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string invoiceAdditionalDiscount2 { get { return _invoiceAdditionalDiscount2; } set { SetProperty(PropertyinvoiceAdditionalDiscount2, ref _invoiceAdditionalDiscount2, value); } }

		[SMEDecimalProperty(Label="SalesCredit Invoice Additional Discount2 Amount", Nillable=true, Name="invoiceAdditionalDiscount2Amount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> invoiceAdditionalDiscount2Amount { get { return _invoiceAdditionalDiscount2Amount; } set { SetProperty(PropertyinvoiceAdditionalDiscount2Amount, ref _invoiceAdditionalDiscount2Amount, value); } }

		[SMEDecimalProperty(Label="SalesCredit Invoice Additional Discount2 Percent", Nillable=true, Name="invoiceAdditionalDiscount2Percent", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> invoiceAdditionalDiscount2Percent { get { return _invoiceAdditionalDiscount2Percent; } set { SetProperty(PropertyinvoiceAdditionalDiscount2Percent, ref _invoiceAdditionalDiscount2Percent, value); } }

		[SMEDecimalProperty(Label="SalesCredit Net Total", Name="netTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal netTotal { get { return _netTotal; } set { SetProperty(PropertynetTotal, ref _netTotal, value); } }

		[SMEDecimalProperty(Label="SalesCredit Discount Total", Name="discountTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal discountTotal { get { return _discountTotal; } set { SetProperty(PropertydiscountTotal, ref _discountTotal, value); } }

		[SMEDecimalProperty(Label="SalesCredit Charges Total", Nillable=true, Name="chargesTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> chargesTotal { get { return _chargesTotal; } set { SetProperty(PropertychargesTotal, ref _chargesTotal, value); } }

		[SMEDecimalProperty(Label="SalesCredit Tax Total", Name="taxTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal taxTotal { get { return _taxTotal; } set { SetProperty(PropertytaxTotal, ref _taxTotal, value); } }

		[SMEDecimalProperty(Label="SalesCredit Gross Total", Name="grossTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal grossTotal { get { return _grossTotal; } set { SetProperty(PropertygrossTotal, ref _grossTotal, value); } }

		[SMEDecimalProperty(Label="SalesCredit Cost Total", Nillable=true, Name="costTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> costTotal { get { return _costTotal; } set { SetProperty(PropertycostTotal, ref _costTotal, value); } }

		[SMEStringProperty(Label="SalesCredit Text1", Nillable=true, Name="text1", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String text1 { get { return _text1; } set { SetProperty(Propertytext1, ref _text1, value); } }

		[SMEStringProperty(Label="SalesCredit Text2", Nillable=true, Name="text2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String text2 { get { return _text2; } set { SetProperty(Propertytext2, ref _text2, value); } }

		[SMEResource(CanGet=true, PluralName="projects", Label="SalesCredit Project")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="SalesCredit Project", Name="projects", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual projectFeed projects { get { return _projects; } set { SetProperty(Propertyprojects, ref _projects, value); } }

		[SMEResource(CanGet=true, PluralName="projectLines", Label="SalesCredit ProjectLine")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="SalesCredit ProjectLine", Name="projectLines", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual projectLineFeed projectLines { get { return _projectLines; } set { SetProperty(PropertyprojectLines, ref _projectLines, value); } }

		[SMEResource(CanGet=true, PluralName="cases", Label="SalesCredit Case reference")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="SalesCredit Case reference", Name="cases", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual caseFeed cases { get { return _cases; } set { SetProperty(Propertycases, ref _cases, value); } }

		[SMEResource(CanGet=true, PluralName="financialAccounts", Label="SalesCredit FinancialAccount")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="SalesCredit FinancialAccount", Name="financialAccounts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual financialAccountFeed financialAccounts { get { return _financialAccounts; } set { SetProperty(PropertyfinancialAccounts, ref _financialAccounts, value); } }

		[SMEResource(CanGet=true, PluralName="interactions", Label="SalesCredit Interaction")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="SalesCredit Interaction", Name="interactions", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual interactionFeed interactions { get { return _interactions; } set { SetProperty(Propertyinteractions, ref _interactions, value); } }

		[SMEStringProperty(Label="SalesCredit User", Nillable=true, Name="user", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String user { get { return _user; } set { SetProperty(Propertyuser, ref _user, value); } }

		[SMEResource(CanGet=true, PluralName="notes")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Label="SalesCredit Note", Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual noteFeed notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		#endregion


	}
}