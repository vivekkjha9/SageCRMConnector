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
	/// Defines a salesOrder feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("salesOrder", Namespace="http://schemas.sage.com/crmErp/2008")]
		[SMEResource(CanGet=true, CanPost=true, CanPut=true, PluralName="salesOrders")]
	public class salesOrderFeedEntrySchema : Sage.Common.Syndication.FeedEntry
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
		public const string PropertyallocationStatus = "allocationStatus";
		public const string PropertydeliveryStatus = "deliveryStatus";
		public const string PropertyinvoiceStatus = "invoiceStatus";
		public const string PropertystatusFlag = "statusFlag";
		public const string PropertystatusFlagText = "statusFlagText";
		public const string Propertycompany = "company";
		public const string Propertycustomer = "customer";
		public const string PropertytradingAccount = "tradingAccount";
		public const string PropertycustomerReference = "customerReference";
		public const string Propertyopportunity = "opportunity";
		public const string Propertypricelist = "pricelist";
		public const string PropertysupplierTradingAccount = "supplierTradingAccount";
		public const string PropertysupplierReference = "supplierReference";
		public const string PropertysupplierPurchaseOrders = "supplierPurchaseOrders";
		public const string Propertytype = "type";
		public const string PropertycopyFlag = "copyFlag";
		public const string PropertyoriginatorDocument = "originatorDocument";
		public const string Propertyquotation = "quotation";
		public const string PropertypostalAddresses = "postalAddresses";
		public const string PropertydeliveryMethod = "deliveryMethod";
		public const string PropertydeliveryRule = "deliveryRule";
		public const string PropertydeliveryTerms = "deliveryTerms";
		public const string PropertydeliveryDate = "deliveryDate";
		public const string PropertydueDate = "dueDate";
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
		public const string PropertyinvoiceCurrency = "invoiceCurrency";
		public const string PropertyinvoiceCurrencyExchangeRate = "invoiceCurrencyExchangeRate";
		public const string PropertyinvoiceCurrencyExchangeRateOperator = "invoiceCurrencyExchangeRateOperator";
		public const string PropertyinvoiceCurrencyExchangeRateDate = "invoiceCurrencyExchangeRateDate";
		public const string PropertycustomerTradingAccountCurrency = "customerTradingAccountCurrency";
		public const string PropertycustomerTradingAccountCurrencyExchangeRate = "customerTradingAccountCurrencyExchangeRate";
		public const string PropertycustomerTradingAccountCurrencyExchangeRateOperator = "customerTradingAccountCurrencyExchangeRateOperator";
		public const string PropertycustomerTradingAccountCurrencyExchangeRateDate = "customerTradingAccountCurrencyExchangeRateDate";
		public const string Propertydate = "date";
		public const string Propertytime = "time";
		public const string Propertyvalidity = "validity";
		public const string PropertyexpirationDate = "expirationDate";
		public const string PropertytaxCodes = "taxCodes";
		public const string PropertybuyerContact = "buyerContact";
		public const string PropertysalesPersons = "salesPersons";
		public const string Propertyuser = "user";
		public const string PropertysalesOrderLines = "salesOrderLines";
		public const string PropertylineCount = "lineCount";
		public const string PropertyorderDiscountType = "orderDiscountType";
		public const string PropertyorderDiscountAmount = "orderDiscountAmount";
		public const string PropertyorderDiscountPercent = "orderDiscountPercent";
		public const string PropertyorderAdditionalDiscount1Type = "orderAdditionalDiscount1Type";
		public const string PropertyorderAdditionalDiscount1Amount = "orderAdditionalDiscount1Amount";
		public const string PropertyorderAdditionalDiscount1Percent = "orderAdditionalDiscount1Percent";
		public const string PropertyorderAdditionalDiscount2 = "orderAdditionalDiscount2";
		public const string PropertyorderAdditionalDiscount2Amount = "orderAdditionalDiscount2Amount";
		public const string PropertyorderAdditionalDiscount2Percent = "orderAdditionalDiscount2Percent";
		public const string Propertytext1 = "text1";
		public const string Propertytext2 = "text2";
		public const string PropertynetTotal = "netTotal";
		public const string PropertydiscountTotal = "discountTotal";
		public const string PropertychargesTotal = "chargesTotal";
		public const string PropertytaxTotal = "taxTotal";
		public const string PropertygrossTotal = "grossTotal";
		public const string PropertycostTotal = "costTotal";
		public const string PropertyprofitTotal = "profitTotal";
		public const string Propertyreceipts = "receipts";
		public const string PropertydepositFlag = "depositFlag";
		public const string Propertycontract = "contract";
		public const string PropertyinvoiceTradingAccount = "invoiceTradingAccount";
		public const string PropertyinvoiceCountry = "invoiceCountry";
		public const string PropertyorderCountry = "orderCountry";
		public const string Propertyprojects = "projects";
		public const string PropertyprojectLines = "projectLines";
		public const string Propertycases = "cases";
		public const string PropertysalesOrderDeliveries = "salesOrderDeliveries";
		public const string PropertyfulfillmentLocations = "fulfillmentLocations";
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
		private string _allocationStatus;
		private string _deliveryStatus;
		private string _invoiceStatus;
		private Nullable<System.Boolean> _statusFlag;
		private System.String _statusFlagText;
		private companyFeedEntry _company;
		private customerFeedEntry _customer;
		private tradingAccountFeedEntry _tradingAccount;
		private System.String _customerReference;
		private opportunityFeedEntry _opportunity;
		private priceListFeedEntry _pricelist;
		private tradingAccountFeedEntry _supplierTradingAccount;
		private System.String _supplierReference;
		private purchaseOrderFeed _supplierPurchaseOrders;
		private System.String _type;
		private System.Boolean _copyFlag;
		private salesOrderFeedEntry _originatorDocument;
		private salesQuotationFeedEntry _quotation;
		private postalAddressFeed _postalAddresses;
		private System.String _deliveryMethod;
		private Nullable<System.Boolean> _deliveryRule;
		private System.String _deliveryTerms;
		private Nullable<System.DateTime> _deliveryDate;
		private Nullable<System.DateTime> _dueDate;
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
		private System.String _invoiceCurrency;
		private Nullable<System.Decimal> _invoiceCurrencyExchangeRate;
		private string _invoiceCurrencyExchangeRateOperator;
		private Nullable<System.DateTime> _invoiceCurrencyExchangeRateDate;
		private System.String _customerTradingAccountCurrency;
		private Nullable<System.Decimal> _customerTradingAccountCurrencyExchangeRate;
		private string _customerTradingAccountCurrencyExchangeRateOperator;
		private Nullable<System.DateTime> _customerTradingAccountCurrencyExchangeRateDate;
		private System.DateTime _date;
		private Nullable<System.DateTime> _time;
		private Nullable<System.Decimal> _validity;
		private Nullable<System.DateTime> _expirationDate;
		private taxCodeFeed _taxCodes;
		private contactFeedEntry _buyerContact;
		private salesPersonFeed _salesPersons;
		private System.String _user;
		private salesOrderLineFeed _salesOrderLines;
		private System.Decimal _lineCount;
		private string _orderDiscountType;
		private Nullable<System.Decimal> _orderDiscountAmount;
		private Nullable<System.Decimal> _orderDiscountPercent;
		private System.String _orderAdditionalDiscount1Type;
		private Nullable<System.Decimal> _orderAdditionalDiscount1Amount;
		private Nullable<System.Decimal> _orderAdditionalDiscount1Percent;
		private string _orderAdditionalDiscount2;
		private Nullable<System.Decimal> _orderAdditionalDiscount2Amount;
		private Nullable<System.Decimal> _orderAdditionalDiscount2Percent;
		private System.String _text1;
		private System.String _text2;
		private System.Decimal _netTotal;
		private System.Decimal _discountTotal;
		private Nullable<System.Decimal> _chargesTotal;
		private System.Decimal _taxTotal;
		private System.Decimal _grossTotal;
		private Nullable<System.Decimal> _costTotal;
		private Nullable<System.Decimal> _profitTotal;
		private receiptFeed _receipts;
		private Nullable<System.Boolean> _depositFlag;
		private System.String _contract;
		private tradingAccountFeedEntry _invoiceTradingAccount;
		private System.String _invoiceCountry;
		private System.String _orderCountry;
		private projectFeed _projects;
		private projectLineFeed _projectLines;
		private caseFeed _cases;
		private salesOrderDeliveryFeed _salesOrderDeliveries;
		private locationFeed _fulfillmentLocations;
		private financialAccountFeed _financialAccounts;
		private interactionFeed _interactions;
		private noteFeed _notes;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="salesOrderFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public salesOrderFeedEntrySchema()
		{
		}

		#region Properties


		[SMEStringProperty(Label="SalesOrder Application ID", Name="id", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual new System.String id { get { return _id; } set { SetProperty(Propertyid, ref _id, value); } }

		[SMEBoolProperty(Label="SalesOrder Active Flag", Name="active", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEBoolProperty(Label="SalesOrder Deleted", Name="deleted", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean deleted { get { return _deleted; } set { SetProperty(Propertydeleted, ref _deleted, value); } }

		[SMEStringProperty(Label="SalesOrder Label", Name="label", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String label { get { return _label; } set { SetProperty(Propertylabel, ref _label, value); } }

		[SMEStringProperty(Label="SalesOrder reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEStringProperty(Label="SalesOrder Reference2", Nillable=true, Name="reference2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="companies")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="SalesOrder OperatingCompany", Name="operatingCompany", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("operatingCompany")]			
		public virtual companyFeedEntry operatingCompany { get { return _operatingCompany; } set { SetProperty(PropertyoperatingCompany, ref _operatingCompany, value); } }

		[SMEEnumProperty(EnumTypeName="salesOrderStatus--enum", Label="SalesOrder Status", Nillable=true, Name="status", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string status { get { return _status; } set { SetProperty(Propertystatus, ref _status, value); } }

		[SMEEnumProperty(EnumTypeName="salesOrderAllocationStatus--enum", Label="SalesOrder Allocation Status", Nillable=true, Name="allocationStatus", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string allocationStatus { get { return _allocationStatus; } set { SetProperty(PropertyallocationStatus, ref _allocationStatus, value); } }

		[SMEEnumProperty(EnumTypeName="salesOrderDeliveryStatus--enum", Label="SalesOrder Delivery Status", Nillable=true, Name="deliveryStatus", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string deliveryStatus { get { return _deliveryStatus; } set { SetProperty(PropertydeliveryStatus, ref _deliveryStatus, value); } }

		[SMEEnumProperty(EnumTypeName="salesOrderInvoiceStatus--enum", Label="SalesOrder Invoice Status", Nillable=true, Name="invoiceStatus", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string invoiceStatus { get { return _invoiceStatus; } set { SetProperty(PropertyinvoiceStatus, ref _invoiceStatus, value); } }

		[SMEBoolProperty(Label="SalesOrder Status Flag", Nillable=true, Name="statusFlag", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Boolean> statusFlag { get { return _statusFlag; } set { SetProperty(PropertystatusFlag, ref _statusFlag, value); } }

		[SMEStringProperty(Label="SalesOrder Status Flag Text", Nillable=true, Name="statusFlagText", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String statusFlagText { get { return _statusFlagText; } set { SetProperty(PropertystatusFlagText, ref _statusFlagText, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="companies")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="SalesOrder Company", Name="company", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("company")]			
		public virtual companyFeedEntry company { get { return _company; } set { SetProperty(Propertycompany, ref _company, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="customers")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="SalesOrder Customer", Name="customer", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("customer")]			
		public virtual customerFeedEntry customer { get { return _customer; } set { SetProperty(Propertycustomer, ref _customer, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="SalesOrder Customer TradingAccount", Name="tradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("tradingAccount")]			
		public virtual tradingAccountFeedEntry tradingAccount { get { return _tradingAccount; } set { SetProperty(PropertytradingAccount, ref _tradingAccount, value); } }

		[SMEStringProperty(Label="SalesOrder Customer reference", Nillable=true, Name="customerReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String customerReference { get { return _customerReference; } set { SetProperty(PropertycustomerReference, ref _customerReference, value); } }

		[SMEResource(CanGet=true, PluralName="opportunities", Label="SalesOrder Opportunity")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="SalesOrder Opportunity", Name="opportunity", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("opportunity")]			
		public virtual opportunityFeedEntry opportunity { get { return _opportunity; } set { SetProperty(Propertyopportunity, ref _opportunity, value); } }

		[SMEResource(CanGet=true, PluralName="priceLists", Label="SalesOrder PriceList")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="SalesOrder PriceList", Name="pricelist", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("pricelist")]			
		public virtual priceListFeedEntry pricelist { get { return _pricelist; } set { SetProperty(Propertypricelist, ref _pricelist, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="SalesOrder Supplier TradingAccount", Name="supplierTradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("supplierTradingAccount")]			
		public virtual tradingAccountFeedEntry supplierTradingAccount { get { return _supplierTradingAccount; } set { SetProperty(PropertysupplierTradingAccount, ref _supplierTradingAccount, value); } }

		[SMEStringProperty(Label="SalesOrder Supplier reference", Nillable=true, Name="supplierReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String supplierReference { get { return _supplierReference; } set { SetProperty(PropertysupplierReference, ref _supplierReference, value); } }

		[SMEResource(CanGet=true, CanPost=true, PluralName="purchaseOrders", Label="SalesOrder Supplier PurchaseOrder")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="SalesOrder Supplier PurchaseOrder", Name="supplierPurchaseOrders", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseOrderFeed supplierPurchaseOrders { get { return _supplierPurchaseOrders; } set { SetProperty(PropertysupplierPurchaseOrders, ref _supplierPurchaseOrders, value); } }

		[SMEStringProperty(Label="SalesOrder Type", Nillable=true, Name="type", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }

		[SMEBoolProperty(Label="SalesOrder Copy Flag", Name="copyFlag", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean copyFlag { get { return _copyFlag; } set { SetProperty(PropertycopyFlag, ref _copyFlag, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, PluralName="salesOrders", Label="SalesOrder Originator Document reference")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="SalesOrder Originator Document reference", Name="originatorDocument", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("originatorDocument")]			
		public virtual salesOrderFeedEntry originatorDocument { get { return _originatorDocument; } set { SetProperty(PropertyoriginatorDocument, ref _originatorDocument, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, PluralName="salesQuotations", Label="SalesOrder Quotation")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="SalesOrder Quotation", Name="quotation", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("quotation")]			
		public virtual salesQuotationFeedEntry quotation { get { return _quotation; } set { SetProperty(Propertyquotation, ref _quotation, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="postalAddresses")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="SalesOrder PostalAddress", Name="postalAddresses", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual postalAddressFeed postalAddresses { get { return _postalAddresses; } set { SetProperty(PropertypostalAddresses, ref _postalAddresses, value); } }

		[SMEStringProperty(Label="SalesOrder Delivery Method", Nillable=true, Name="deliveryMethod", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String deliveryMethod { get { return _deliveryMethod; } set { SetProperty(PropertydeliveryMethod, ref _deliveryMethod, value); } }

		[SMEBoolProperty(Label="SalesOrder Delivery Rule", Nillable=true, Name="deliveryRule", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Boolean> deliveryRule { get { return _deliveryRule; } set { SetProperty(PropertydeliveryRule, ref _deliveryRule, value); } }

		[SMEStringProperty(Label="SalesOrder Delivery Terms", Nillable=true, Name="deliveryTerms", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String deliveryTerms { get { return _deliveryTerms; } set { SetProperty(PropertydeliveryTerms, ref _deliveryTerms, value); } }

		[SMEDateProperty(Label="SalesOrder Delivery Date", Nillable=true, Name="deliveryDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> deliveryDate { get { return _deliveryDate; } set { SetProperty(PropertydeliveryDate, ref _deliveryDate, value); } }

		[SMEDateProperty(Label="SalesOrder Due Date", Nillable=true, Name="dueDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> dueDate { get { return _dueDate; } set { SetProperty(PropertydueDate, ref _dueDate, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="companies", Label="SalesOrder Carrier Company")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="SalesOrder Carrier Company", Name="carrierCompany", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual companyFeed carrierCompany { get { return _carrierCompany; } set { SetProperty(PropertycarrierCompany, ref _carrierCompany, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="suppliers", Label="SalesOrder Carrier Supplier")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="SalesOrder Carrier Supplier", Name="carrierSupplier", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual supplierFeed carrierSupplier { get { return _carrierSupplier; } set { SetProperty(PropertycarrierSupplier, ref _carrierSupplier, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="SalesOrder Carrier TradingAccount", Name="carrierTradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual tradingAccountFeed carrierTradingAccount { get { return _carrierTradingAccount; } set { SetProperty(PropertycarrierTradingAccount, ref _carrierTradingAccount, value); } }

		[SMEDecimalProperty(Label="SalesOrder Carrier Net Price", Nillable=true, Name="carrierNetPrice", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> carrierNetPrice { get { return _carrierNetPrice; } set { SetProperty(PropertycarrierNetPrice, ref _carrierNetPrice, value); } }

		[SMEDecimalProperty(Label="SalesOrder Carrier Tax Price", Nillable=true, Name="carrierTaxPrice", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> carrierTaxPrice { get { return _carrierTaxPrice; } set { SetProperty(PropertycarrierTaxPrice, ref _carrierTaxPrice, value); } }

		[SMEDecimalProperty(Label="SalesOrder Carrier Gross Price", Nillable=true, Name="carrierTotalPrice", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> carrierTotalPrice { get { return _carrierTotalPrice; } set { SetProperty(PropertycarrierTotalPrice, ref _carrierTotalPrice, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, PluralName="salesInvoices", Label="SalesOrder Carrier SalesInvoice")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="SalesOrder Carrier SalesInvoice", Name="carrierSalesInvoice", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesInvoiceFeed carrierSalesInvoice { get { return _carrierSalesInvoice; } set { SetProperty(PropertycarrierSalesInvoice, ref _carrierSalesInvoice, value); } }

		[SMEResource(CanGet=true, CanPost=true, PluralName="purchaseInvoices", Label="SalesOrder Carrier PurchaseInvoice")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="SalesOrder Carrier PurchaseInvoice", Name="carrierPurchaseInvoice", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseInvoiceFeed carrierPurchaseInvoice { get { return _carrierPurchaseInvoice; } set { SetProperty(PropertycarrierPurchaseInvoice, ref _carrierPurchaseInvoice, value); } }

		[SMEResource(CanGet=true, PluralName="taxCodes", Label="SalesOrder Carrier Tax Code")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="SalesOrder Carrier Tax Code", Name="carrierTaxCodes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual taxCodeFeed carrierTaxCodes { get { return _carrierTaxCodes; } set { SetProperty(PropertycarrierTaxCodes, ref _carrierTaxCodes, value); } }

		[SMEStringProperty(Label="SalesOrder Carrier reference", Nillable=true, Name="carrierReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String carrierReference { get { return _carrierReference; } set { SetProperty(PropertycarrierReference, ref _carrierReference, value); } }

		[SMEStringProperty(Label="SalesOrder Currency", Name="currency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String currency { get { return _currency; } set { SetProperty(Propertycurrency, ref _currency, value); } }

		[SMEStringProperty(Label="SalesOrder OperatingCompany Currency", Name="operatingCompanyCurrency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String operatingCompanyCurrency { get { return _operatingCompanyCurrency; } set { SetProperty(PropertyoperatingCompanyCurrency, ref _operatingCompanyCurrency, value); } }

		[SMEDecimalProperty(Label="SalesOrder OperatingCompany Currency Exchange Rate", Nillable=true, Name="operatingCompanyCurrencyExchangeRate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> operatingCompanyCurrencyExchangeRate { get { return _operatingCompanyCurrencyExchangeRate; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRate, ref _operatingCompanyCurrencyExchangeRate, value); } }

		[SMEEnumProperty(EnumTypeName="RateOperator--enum", Label="SalesOrder OperatingCompany Currency Exchange Rate Operator", Nillable=true, Name="operatingCompanyCurrencyExchangeRateOperator", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string operatingCompanyCurrencyExchangeRateOperator { get { return _operatingCompanyCurrencyExchangeRateOperator; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRateOperator, ref _operatingCompanyCurrencyExchangeRateOperator, value); } }

		[SMEDateProperty(Label="SalesOrder OperatingCompany Currency Exchange Rate Date", Nillable=true, Name="operatingCompanyCurrencyExchangeRateDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> operatingCompanyCurrencyExchangeRateDate { get { return _operatingCompanyCurrencyExchangeRateDate; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRateDate, ref _operatingCompanyCurrencyExchangeRateDate, value); } }

		[SMEStringProperty(Label="SalesOrder Invoice Currency", Nillable=true, Name="invoiceCurrency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String invoiceCurrency { get { return _invoiceCurrency; } set { SetProperty(PropertyinvoiceCurrency, ref _invoiceCurrency, value); } }

		[SMEDecimalProperty(Label="SalesOrder Invoice Currency Exchange Rate", Nillable=true, Name="invoiceCurrencyExchangeRate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> invoiceCurrencyExchangeRate { get { return _invoiceCurrencyExchangeRate; } set { SetProperty(PropertyinvoiceCurrencyExchangeRate, ref _invoiceCurrencyExchangeRate, value); } }

		[SMEEnumProperty(EnumTypeName="RateOperator--enum", Label="SalesOrder Invoice Currency Exchange Rate Operator", Nillable=true, Name="invoiceCurrencyExchangeRateOperator", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string invoiceCurrencyExchangeRateOperator { get { return _invoiceCurrencyExchangeRateOperator; } set { SetProperty(PropertyinvoiceCurrencyExchangeRateOperator, ref _invoiceCurrencyExchangeRateOperator, value); } }

		[SMEDateProperty(Label="SalesOrder Invoice Currency Exchange Rate Date", Nillable=true, Name="invoiceCurrencyExchangeRateDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> invoiceCurrencyExchangeRateDate { get { return _invoiceCurrencyExchangeRateDate; } set { SetProperty(PropertyinvoiceCurrencyExchangeRateDate, ref _invoiceCurrencyExchangeRateDate, value); } }

		[SMEStringProperty(Label="SalesOrder Customer TradingAccount Currency", Nillable=true, Name="customerTradingAccountCurrency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String customerTradingAccountCurrency { get { return _customerTradingAccountCurrency; } set { SetProperty(PropertycustomerTradingAccountCurrency, ref _customerTradingAccountCurrency, value); } }

		[SMEDecimalProperty(Label="SalesOrder Customer TradingAccount Currency Exchange Rate", Nillable=true, Name="customerTradingAccountCurrencyExchangeRate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> customerTradingAccountCurrencyExchangeRate { get { return _customerTradingAccountCurrencyExchangeRate; } set { SetProperty(PropertycustomerTradingAccountCurrencyExchangeRate, ref _customerTradingAccountCurrencyExchangeRate, value); } }

		[SMEEnumProperty(EnumTypeName="RateOperator--enum", Label="SalesOrder Customer TradingAccount Currency Exchange Rate Operator", Nillable=true, Name="customerTradingAccountCurrencyExchangeRateOperator", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string customerTradingAccountCurrencyExchangeRateOperator { get { return _customerTradingAccountCurrencyExchangeRateOperator; } set { SetProperty(PropertycustomerTradingAccountCurrencyExchangeRateOperator, ref _customerTradingAccountCurrencyExchangeRateOperator, value); } }

		[SMEDateProperty(Label="SalesOrder Customer TradingAccount Currency Exchange Rate Date", Nillable=true, Name="customerTradingAccountCurrencyExchangeRateDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> customerTradingAccountCurrencyExchangeRateDate { get { return _customerTradingAccountCurrencyExchangeRateDate; } set { SetProperty(PropertycustomerTradingAccountCurrencyExchangeRateDate, ref _customerTradingAccountCurrencyExchangeRateDate, value); } }

		[SMEDateProperty(Label="SalesOrder Date", Name="date", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.DateTime date { get { return _date; } set { SetProperty(Propertydate, ref _date, value); } }

		[SMETimeProperty(Label="SalesOrder Time", Nillable=true, Name="time", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> time { get { return _time; } set { SetProperty(Propertytime, ref _time, value); } }

		[SMEDecimalProperty(Label="SalesOrder Validity", Nillable=true, Name="validity", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> validity { get { return _validity; } set { SetProperty(Propertyvalidity, ref _validity, value); } }

		[SMEDateProperty(Label="SalesOrder Expiration Date", Nillable=true, Name="expirationDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> expirationDate { get { return _expirationDate; } set { SetProperty(PropertyexpirationDate, ref _expirationDate, value); } }

		[SMEResource(CanGet=true, PluralName="taxCodes", Label="SalesOrder Tax Code")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="SalesOrder Tax Code", Name="taxCodes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual taxCodeFeed taxCodes { get { return _taxCodes; } set { SetProperty(PropertytaxCodes, ref _taxCodes, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="contacts", Label="SalesOrder Buyer Contact")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="SalesOrder Buyer Contact", Name="buyerContact", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("buyerContact")]			
		public virtual contactFeedEntry buyerContact { get { return _buyerContact; } set { SetProperty(PropertybuyerContact, ref _buyerContact, value); } }

		[SMEResource(PluralName="salesPersons", Label="SalesOrder Salesperson")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="SalesOrder Salesperson", Name="salesPersons", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesPersonFeed salesPersons { get { return _salesPersons; } set { SetProperty(PropertysalesPersons, ref _salesPersons, value); } }

		[SMEStringProperty(Label="SalesOrder User", Nillable=true, Name="user", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String user { get { return _user; } set { SetProperty(Propertyuser, ref _user, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, PluralName="salesOrderLines", Label="SalesOrder SalesOrderLine")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Label="SalesOrder SalesOrderLine", Name="salesOrderLines", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesOrderLineFeed salesOrderLines { get { return _salesOrderLines; } set { SetProperty(PropertysalesOrderLines, ref _salesOrderLines, value); } }

		[SMEDecimalProperty(Label="SalesOrder Line Count", Name="lineCount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal lineCount { get { return _lineCount; } set { SetProperty(PropertylineCount, ref _lineCount, value); } }

		[SMEEnumProperty(EnumTypeName="discountType--enum", Label="SalesOrder Order Discount Type", Nillable=true, Name="orderDiscountType", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string orderDiscountType { get { return _orderDiscountType; } set { SetProperty(PropertyorderDiscountType, ref _orderDiscountType, value); } }

		[SMEDecimalProperty(Label="SalesOrder Order Discount Amount", Nillable=true, Name="orderDiscountAmount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> orderDiscountAmount { get { return _orderDiscountAmount; } set { SetProperty(PropertyorderDiscountAmount, ref _orderDiscountAmount, value); } }

		[SMEDecimalProperty(Label="SalesOrder Order Discount Percent", Nillable=true, Name="orderDiscountPercent", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> orderDiscountPercent { get { return _orderDiscountPercent; } set { SetProperty(PropertyorderDiscountPercent, ref _orderDiscountPercent, value); } }

		[SMEStringProperty(Label="SalesOrder Order Additional Discount1 Type", Nillable=true, Name="orderAdditionalDiscount1Type", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String orderAdditionalDiscount1Type { get { return _orderAdditionalDiscount1Type; } set { SetProperty(PropertyorderAdditionalDiscount1Type, ref _orderAdditionalDiscount1Type, value); } }

		[SMEDecimalProperty(Label="SalesOrder Order Additional Discount1 Amount", Nillable=true, Name="orderAdditionalDiscount1Amount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> orderAdditionalDiscount1Amount { get { return _orderAdditionalDiscount1Amount; } set { SetProperty(PropertyorderAdditionalDiscount1Amount, ref _orderAdditionalDiscount1Amount, value); } }

		[SMEDecimalProperty(Label="SalesOrder Order Additional Discount1 Percent", Nillable=true, Name="orderAdditionalDiscount1Percent", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> orderAdditionalDiscount1Percent { get { return _orderAdditionalDiscount1Percent; } set { SetProperty(PropertyorderAdditionalDiscount1Percent, ref _orderAdditionalDiscount1Percent, value); } }

		[SMEEnumProperty(EnumTypeName="discountType--enum", Label="SalesOrder Order Additional Discount2 Type", Nillable=true, Name="orderAdditionalDiscount2", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string orderAdditionalDiscount2 { get { return _orderAdditionalDiscount2; } set { SetProperty(PropertyorderAdditionalDiscount2, ref _orderAdditionalDiscount2, value); } }

		[SMEDecimalProperty(Label="SalesOrder Order Additional Discount2 Amount", Nillable=true, Name="orderAdditionalDiscount2Amount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> orderAdditionalDiscount2Amount { get { return _orderAdditionalDiscount2Amount; } set { SetProperty(PropertyorderAdditionalDiscount2Amount, ref _orderAdditionalDiscount2Amount, value); } }

		[SMEDecimalProperty(Label="SalesOrder Order Additional Discount2 Percent", Nillable=true, Name="orderAdditionalDiscount2Percent", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> orderAdditionalDiscount2Percent { get { return _orderAdditionalDiscount2Percent; } set { SetProperty(PropertyorderAdditionalDiscount2Percent, ref _orderAdditionalDiscount2Percent, value); } }

		[SMEStringProperty(Label="SalesOrder Text1", Nillable=true, Name="text1", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String text1 { get { return _text1; } set { SetProperty(Propertytext1, ref _text1, value); } }

		[SMEStringProperty(Label="SalesOrder Text2", Nillable=true, Name="text2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String text2 { get { return _text2; } set { SetProperty(Propertytext2, ref _text2, value); } }

		[SMEDecimalProperty(Label="SalesOrder Net Total", Name="netTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal netTotal { get { return _netTotal; } set { SetProperty(PropertynetTotal, ref _netTotal, value); } }

		[SMEDecimalProperty(Label="SalesOrder Discount Total", Name="discountTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal discountTotal { get { return _discountTotal; } set { SetProperty(PropertydiscountTotal, ref _discountTotal, value); } }

		[SMEDecimalProperty(Label="SalesOrder Charges Total", Nillable=true, Name="chargesTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> chargesTotal { get { return _chargesTotal; } set { SetProperty(PropertychargesTotal, ref _chargesTotal, value); } }

		[SMEDecimalProperty(Label="SalesOrder Tax Total", Name="taxTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal taxTotal { get { return _taxTotal; } set { SetProperty(PropertytaxTotal, ref _taxTotal, value); } }

		[SMEDecimalProperty(Label="SalesOrder Gross Total", Name="grossTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal grossTotal { get { return _grossTotal; } set { SetProperty(PropertygrossTotal, ref _grossTotal, value); } }

		[SMEDecimalProperty(Label="SalesOrder Cost Total", Nillable=true, Name="costTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> costTotal { get { return _costTotal; } set { SetProperty(PropertycostTotal, ref _costTotal, value); } }

		[SMEDecimalProperty(Label="SalesOrder Profit Total", Nillable=true, Name="profitTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> profitTotal { get { return _profitTotal; } set { SetProperty(PropertyprofitTotal, ref _profitTotal, value); } }

		[SMEResource(CanGet=true, PluralName="receipts", Label="SalesOrder Receipt")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="SalesOrder Receipt", Name="receipts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual receiptFeed receipts { get { return _receipts; } set { SetProperty(Propertyreceipts, ref _receipts, value); } }

		[SMEBoolProperty(Label="SalesOrder Deposit Flag", Nillable=true, Name="depositFlag", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Boolean> depositFlag { get { return _depositFlag; } set { SetProperty(PropertydepositFlag, ref _depositFlag, value); } }

		[SMEStringProperty(Label="SalesOrder Contract", Nillable=true, Name="contract", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String contract { get { return _contract; } set { SetProperty(Propertycontract, ref _contract, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="SalesOrder Invoice TradingAccount", Name="invoiceTradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("invoiceTradingAccount")]			
		public virtual tradingAccountFeedEntry invoiceTradingAccount { get { return _invoiceTradingAccount; } set { SetProperty(PropertyinvoiceTradingAccount, ref _invoiceTradingAccount, value); } }

		[SMEStringProperty(Label="SalesOrder Invoice Country", Nillable=true, Name="invoiceCountry", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String invoiceCountry { get { return _invoiceCountry; } set { SetProperty(PropertyinvoiceCountry, ref _invoiceCountry, value); } }

		[SMEStringProperty(Label="SalesOrder Order Country", Nillable=true, Name="orderCountry", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String orderCountry { get { return _orderCountry; } set { SetProperty(PropertyorderCountry, ref _orderCountry, value); } }

		[SMEResource(CanGet=true, PluralName="projects", Label="SalesOrder Project")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="SalesOrder Project", Name="projects", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual projectFeed projects { get { return _projects; } set { SetProperty(Propertyprojects, ref _projects, value); } }

		[SMEResource(CanGet=true, PluralName="projectLines", Label="SalesOrder ProjectLine")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="SalesOrder ProjectLine", Name="projectLines", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual projectLineFeed projectLines { get { return _projectLines; } set { SetProperty(PropertyprojectLines, ref _projectLines, value); } }

		[SMEResource(CanGet=true, PluralName="cases", Label="SalesOrder Case reference")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="SalesOrder Case reference", Name="cases", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual caseFeed cases { get { return _cases; } set { SetProperty(Propertycases, ref _cases, value); } }

		[SMEResource(CanGet=true, PluralName="salesOrderDeliveries", Label="SalesOrder SalesOrderDelivery")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="SalesOrder SalesOrderDelivery", Name="salesOrderDeliveries", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesOrderDeliveryFeed salesOrderDeliveries { get { return _salesOrderDeliveries; } set { SetProperty(PropertysalesOrderDeliveries, ref _salesOrderDeliveries, value); } }

		[SMEResource(CanGet=true, PluralName="locations", Label="SalesOrder Fulfilment Location")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="SalesOrder Fulfilment Location", Name="fulfillmentLocations", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual locationFeed fulfillmentLocations { get { return _fulfillmentLocations; } set { SetProperty(PropertyfulfillmentLocations, ref _fulfillmentLocations, value); } }

		[SMEResource(CanGet=true, PluralName="financialAccounts", Label="SalesOrder FinancialAccount")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="SalesOrder FinancialAccount", Name="financialAccounts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual financialAccountFeed financialAccounts { get { return _financialAccounts; } set { SetProperty(PropertyfinancialAccounts, ref _financialAccounts, value); } }

		[SMEResource(CanGet=true, PluralName="interactions", Label="SalesOrder Interaction")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="SalesOrder Interaction", Name="interactions", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual interactionFeed interactions { get { return _interactions; } set { SetProperty(Propertyinteractions, ref _interactions, value); } }

		[SMEResource(CanGet=true, PluralName="notes")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Label="SalesOrder Note", Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual noteFeed notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		#endregion


	}
}