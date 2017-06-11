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
	/// Defines a tradingAccount feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("tradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts")]
	public class tradingAccountFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyid = "id";
		public const string Propertyactive = "active";
		public const string Propertydeleted = "deleted";
		public const string Propertylabel = "label";
		public const string PropertycustomerSupplierFlag = "customerSupplierFlag";
		public const string Propertycustomer = "customer";
		public const string Propertysupplier = "supplier";
		public const string PropertyinvoiceTradingAccount = "invoiceTradingAccount";
		public const string PropertyopenedDate = "openedDate";
		public const string Propertyreference = "reference";
		public const string Propertyreference2 = "reference2";
		public const string PropertyoperatingCompany = "operatingCompany";
		public const string Propertystatus = "status";
		public const string Propertyname = "name";
		public const string PropertyshortName = "shortName";
		public const string Propertytype = "type";
		public const string PropertypostalAddresses = "postalAddresses";
		public const string PropertyshippingAddresses = "shippingAddresses";
		public const string PropertybillingAddresses = "billingAddresses";
		public const string Propertyphones = "phones";
		public const string Propertyemails = "emails";
		public const string Propertywebsite = "website";
		public const string Propertycontacts = "contacts";
		public const string PropertydeliveryContact = "deliveryContact";
		public const string PropertysalesPersons = "salesPersons";
		public const string PropertydeliveryMethod = "deliveryMethod";
		public const string PropertydeliveryRule = "deliveryRule";
		public const string Propertycurrency = "currency";
		public const string PropertytaxCode = "taxCode";
		public const string PropertytaxReference = "taxReference";
		public const string PropertytaxationCountry = "taxationCountry";
		public const string PropertyuseTaxInclusivePrices = "useTaxInclusivePrices";
		public const string PropertyfinanceBalance = "financeBalance";
		public const string PropertyfinanceLimit = "financeLimit";
		public const string PropertyfinanceBalanceDate = "financeBalanceDate";
		public const string PropertyfinanceStatusFlag = "financeStatusFlag";
		public const string PropertyfinanceStatusText = "financeStatusText";
		public const string PropertysettlementDiscountType = "settlementDiscountType";
		public const string PropertysettlementDiscountAmount = "settlementDiscountAmount";
		public const string PropertysettlementDiscountPercent = "settlementDiscountPercent";
		public const string PropertysettlementDiscountTerms = "settlementDiscountTerms";
		public const string PropertysettlementDiscountTermsCommencement = "settlementDiscountTermsCommencement";
		public const string PropertysettlementDiscountIncludedInTotal = "settlementDiscountIncludedInTotal";
		public const string PropertypaymentTerms = "paymentTerms";
		public const string PropertypaymentTermsCommencement = "paymentTermsCommencement";
		public const string PropertyorderDiscountType = "orderDiscountType";
		public const string PropertyorderDiscountAmount = "orderDiscountAmount";
		public const string PropertyorderDiscountPercent = "orderDiscountPercent";
		public const string PropertyorderText1 = "orderText1";
		public const string PropertyorderText2 = "orderText2";
		public const string PropertyorderLineDiscountType = "orderLineDiscountType";
		public const string PropertyorderLineDiscountAmount = "orderLineDiscountAmount";
		public const string PropertyorderLineDiscountPercent = "orderLineDiscountPercent";
		public const string PropertyorderLineText1 = "orderLineText1";
		public const string PropertyorderLineText2 = "orderLineText2";
		public const string PropertyinvoiceDiscountType = "invoiceDiscountType";
		public const string PropertyinvoiceDiscountAmount = "invoiceDiscountAmount";
		public const string PropertyinvoiceDiscountPercent = "invoiceDiscountPercent";
		public const string PropertyinvoiceText1 = "invoiceText1";
		public const string PropertyinvoiceText2 = "invoiceText2";
		public const string PropertybankAccounts = "bankAccounts";
		public const string PropertytenderType = "tenderType";
		public const string PropertydefaultFulfillmentLocation = "defaultFulfillmentLocation";
		public const string Propertypricelists = "pricelists";
		public const string PropertypricingOverride = "pricingOverride";
		public const string PropertyaccountingType = "accountingType";
		public const string PropertyfinancialAccounts = "financialAccounts";
		public const string PropertyprimacyIndicator = "primacyIndicator";
		public const string Propertyopportunities = "opportunities";
		public const string PropertysalesQuotations = "salesQuotations";
		public const string PropertysalesOrders = "salesOrders";
		public const string PropertysalesOrderDeliveries = "salesOrderDeliveries";
		public const string PropertysalesInvoices = "salesInvoices";
		public const string PropertysalesReturns = "salesReturns";
		public const string PropertysalesReturnDeliveries = "salesReturnDeliveries";
		public const string PropertysalesCredits = "salesCredits";
		public const string PropertypurchaseRequisitions = "purchaseRequisitions";
		public const string PropertypurchaseOrders = "purchaseOrders";
		public const string PropertypurchaseOrderDeliveries = "purchaseOrderDeliveries";
		public const string PropertypurchaseInvoices = "purchaseInvoices";
		public const string PropertypurchaseReturns = "purchaseReturns";
		public const string PropertypurchaseReturnDeliveries = "purchaseReturnDeliveries";
		public const string PropertypurchaseCredits = "purchaseCredits";
		public const string Propertyreceipts = "receipts";
		public const string Propertypayments = "payments";
		public const string Propertyinteractions = "interactions";
		public const string Propertyprojects = "projects";
		public const string Propertycases = "cases";
		public const string Propertynotes = "notes";

		#endregion

		#region Fields

		private System.String _id;
		private System.Boolean _active;
		private System.Boolean _deleted;
		private System.String _label;
		private System.String _customerSupplierFlag;
		private customerFeedEntry _customer;
		private supplierFeedEntry _supplier;
		private tradingAccountFeedEntry _invoiceTradingAccount;
		private System.DateTime _openedDate;
		private System.String _reference;
		private System.String _reference2;
		private companyFeedEntry _operatingCompany;
		private System.String _status;
		private System.String _name;
		private System.String _shortName;
		private string _type;
		private postalAddressFeed _postalAddresses;
		private postalAddressFeed _shippingAddresses;
		private postalAddressFeed _billingAddresses;
		private phoneNumberFeed _phones;
		private emailFeed _emails;
		private System.String _website;
		private contactFeed _contacts;
		private contactFeedEntry _deliveryContact;
		private salesPersonFeed _salesPersons;
		private System.String _deliveryMethod;
		private Nullable<System.Boolean> _deliveryRule;
		private System.String _currency;
		private taxCodeFeed _taxCode;
		private System.String _taxReference;
		private System.String _taxationCountry;
		private Nullable<System.Boolean> _useTaxInclusivePrices;
		private Nullable<System.Decimal> _financeBalance;
		private Nullable<System.Decimal> _financeLimit;
		private Nullable<System.DateTime> _financeBalanceDate;
		private Nullable<System.Boolean> _financeStatusFlag;
		private System.String _financeStatusText;
		private string _settlementDiscountType;
		private Nullable<System.Decimal> _settlementDiscountAmount;
		private Nullable<System.Decimal> _settlementDiscountPercent;
		private System.String _settlementDiscountTerms;
		private System.String _settlementDiscountTermsCommencement;
		private Nullable<System.Boolean> _settlementDiscountIncludedInTotal;
		private System.String _paymentTerms;
		private System.String _paymentTermsCommencement;
		private string _orderDiscountType;
		private Nullable<System.Decimal> _orderDiscountAmount;
		private Nullable<System.Decimal> _orderDiscountPercent;
		private System.String _orderText1;
		private System.String _orderText2;
		private string _orderLineDiscountType;
		private Nullable<System.Decimal> _orderLineDiscountAmount;
		private Nullable<System.Decimal> _orderLineDiscountPercent;
		private System.String _orderLineText1;
		private System.String _orderLineText2;
		private string _invoiceDiscountType;
		private Nullable<System.Decimal> _invoiceDiscountAmount;
		private Nullable<System.Decimal> _invoiceDiscountPercent;
		private System.String _invoiceText1;
		private System.String _invoiceText2;
		private bankAccountFeed _bankAccounts;
		private System.String _tenderType;
		private locationFeedEntry _defaultFulfillmentLocation;
		private priceListFeed _pricelists;
		private priceListFeed _pricingOverride;
		private string _accountingType;
		private financialAccountFeed _financialAccounts;
		private Nullable<System.Boolean> _primacyIndicator;
		private opportunityFeed _opportunities;
		private salesQuotationFeed _salesQuotations;
		private salesOrderFeed _salesOrders;
		private salesOrderDeliveryFeed _salesOrderDeliveries;
		private salesInvoiceFeed _salesInvoices;
		private salesReturnFeed _salesReturns;
		private salesReturnDeliveryFeed _salesReturnDeliveries;
		private salesCreditFeed _salesCredits;
		private purchaseRequisitionFeed _purchaseRequisitions;
		private purchaseOrderFeed _purchaseOrders;
		private purchaseOrderDeliveryFeed _purchaseOrderDeliveries;
		private purchaseInvoiceFeed _purchaseInvoices;
		private purchaseReturnFeed _purchaseReturns;
		private purchaseReturnDeliveryFeed _purchaseReturnDeliveries;
		private purchaseCreditFeed _purchaseCredits;
		private receiptFeed _receipts;
		private paymentFeed _payments;
		private interactionFeed _interactions;
		private projectFeed _projects;
		private caseFeed _cases;
		private noteFeed _notes;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="tradingAccountFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public tradingAccountFeedEntrySchema()
		{
		}

		#region Properties


		[SMEStringProperty(Label="TradingAccount Application ID", Name="id", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual new System.String id { get { return _id; } set { SetProperty(Propertyid, ref _id, value); } }

		[SMEBoolProperty(Label="TradingAccount Active Flag", Name="active", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEBoolProperty(Label="Trading Account Deleted", Name="deleted", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean deleted { get { return _deleted; } set { SetProperty(Propertydeleted, ref _deleted, value); } }

		[SMEStringProperty(Label="TradingAccount Label", Name="label", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String label { get { return _label; } set { SetProperty(Propertylabel, ref _label, value); } }

		[SMEStringProperty(Label="TradingAccount Customer Supplier Flag", Name="customerSupplierFlag", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String customerSupplierFlag { get { return _customerSupplierFlag; } set { SetProperty(PropertycustomerSupplierFlag, ref _customerSupplierFlag, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="customers")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Parent, Label="TradingAccount Customer", Name="customer", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("customer")]			
		public virtual customerFeedEntry customer { get { return _customer; } set { SetProperty(Propertycustomer, ref _customer, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="suppliers")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Parent, Label="TradingAccount Supplier", Name="supplier", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("supplier")]			
		public virtual supplierFeedEntry supplier { get { return _supplier; } set { SetProperty(Propertysupplier, ref _supplier, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="TradingAccount Invoice TradingAccount", Name="invoiceTradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("invoiceTradingAccount")]			
		public virtual tradingAccountFeedEntry invoiceTradingAccount { get { return _invoiceTradingAccount; } set { SetProperty(PropertyinvoiceTradingAccount, ref _invoiceTradingAccount, value); } }

		[SMEDateProperty(Label="TradingAccount Opened Date", Name="openedDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.DateTime openedDate { get { return _openedDate; } set { SetProperty(PropertyopenedDate, ref _openedDate, value); } }

		[SMEStringProperty(Label="TradingAccount reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEStringProperty(Label="TradingAccount Reference2", Nillable=true, Name="reference2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="companies")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="TradingAccount OperatingCompany", Name="operatingCompany", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("operatingCompany")]			
		public virtual companyFeedEntry operatingCompany { get { return _operatingCompany; } set { SetProperty(PropertyoperatingCompany, ref _operatingCompany, value); } }

		[SMEStringProperty(Label="TradingAccount Status", Nillable=true, Name="status", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String status { get { return _status; } set { SetProperty(Propertystatus, ref _status, value); } }

		[SMEStringProperty(Label="TradingAccount Name", Name="name", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String name { get { return _name; } set { SetProperty(Propertyname, ref _name, value); } }

		[SMEStringProperty(Label="TradingAccount Short Name", Nillable=true, Name="shortName", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String shortName { get { return _shortName; } set { SetProperty(PropertyshortName, ref _shortName, value); } }

		[SMEEnumProperty(EnumTypeName="tradingAccountType--enum", Label="TradingAccount Type", Nillable=true, Name="type", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="postalAddresses")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="TradingAccount PostalAddress", Name="postalAddresses", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual postalAddressFeed postalAddresses { get { return _postalAddresses; } set { SetProperty(PropertypostalAddresses, ref _postalAddresses, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="postalAddresses")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="TradingAccount ShippingAddress", Name="shippingAddresses", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual postalAddressFeed shippingAddresses { get { return _shippingAddresses; } set { SetProperty(PropertyshippingAddresses, ref _shippingAddresses, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="postalAddresses")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="TradingAccount BillingAddress", Name="billingAddresses", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual postalAddressFeed billingAddresses { get { return _billingAddresses; } set { SetProperty(PropertybillingAddresses, ref _billingAddresses, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="phoneNumbers", Label="TradingAccount Phone")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="TradingAccount Phone", Name="phones", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual phoneNumberFeed phones { get { return _phones; } set { SetProperty(Propertyphones, ref _phones, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="emails", Label="TradingAccount Email")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="TradingAccount Email", Name="emails", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual emailFeed emails { get { return _emails; } set { SetProperty(Propertyemails, ref _emails, value); } }

		[SMEStringProperty(Label="TradingAccount Web site", Nillable=true, Name="website", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String website { get { return _website; } set { SetProperty(Propertywebsite, ref _website, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="contacts", Label="TradingAccount Contact ")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="TradingAccount Contact ", Name="contacts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual contactFeed contacts { get { return _contacts; } set { SetProperty(Propertycontacts, ref _contacts, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="contacts", Label="TradingAccount Delivery Contact")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="TradingAccount Delivery Contact", Name="deliveryContact", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("deliveryContact")]			
		public virtual contactFeedEntry deliveryContact { get { return _deliveryContact; } set { SetProperty(PropertydeliveryContact, ref _deliveryContact, value); } }

		[SMEResource(PluralName="salesPersons", Label="TradingAccount Salesperson")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="TradingAccount Salesperson", Name="salesPersons", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesPersonFeed salesPersons { get { return _salesPersons; } set { SetProperty(PropertysalesPersons, ref _salesPersons, value); } }

		[SMEStringProperty(Label="TradingAccount Delivery Method", Nillable=true, Name="deliveryMethod", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String deliveryMethod { get { return _deliveryMethod; } set { SetProperty(PropertydeliveryMethod, ref _deliveryMethod, value); } }

		[SMEBoolProperty(Label="TradingAccount Delivery Rule", Nillable=true, Name="deliveryRule", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Boolean> deliveryRule { get { return _deliveryRule; } set { SetProperty(PropertydeliveryRule, ref _deliveryRule, value); } }

		[SMEStringProperty(Label="TradingAccount Currency", Name="currency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String currency { get { return _currency; } set { SetProperty(Propertycurrency, ref _currency, value); } }

		[SMEResource(CanGet=true, PluralName="taxCodes", Label="TradingAccount Tax Code")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="TradingAccount Tax Code", Name="taxCode", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual taxCodeFeed taxCode { get { return _taxCode; } set { SetProperty(PropertytaxCode, ref _taxCode, value); } }

		[SMEStringProperty(Label="TradingAccount Tax reference", Nillable=true, Name="taxReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual System.String taxReference { get { return _taxReference; } set { SetProperty(PropertytaxReference, ref _taxReference, value); } }

		[SMEStringProperty(Label="TradingAccount Taxation Country", Nillable=true, Name="taxationCountry", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String taxationCountry { get { return _taxationCountry; } set { SetProperty(PropertytaxationCountry, ref _taxationCountry, value); } }

		[SMEBoolProperty(Label="TradingAccount Use Tax Inclusive Prices", Nillable=true, Name="useTaxInclusivePrices", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Boolean> useTaxInclusivePrices { get { return _useTaxInclusivePrices; } set { SetProperty(PropertyuseTaxInclusivePrices, ref _useTaxInclusivePrices, value); } }

		[SMEDecimalProperty(Label="TradingAccount Finance Balance", Nillable=true, Name="financeBalance", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> financeBalance { get { return _financeBalance; } set { SetProperty(PropertyfinanceBalance, ref _financeBalance, value); } }

		[SMEDecimalProperty(Label="TradingAccount Finance Limit", Nillable=true, Name="financeLimit", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> financeLimit { get { return _financeLimit; } set { SetProperty(PropertyfinanceLimit, ref _financeLimit, value); } }

		[SMEDateProperty(Label="TradingAccount Finance Balance Date", Nillable=true, Name="financeBalanceDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> financeBalanceDate { get { return _financeBalanceDate; } set { SetProperty(PropertyfinanceBalanceDate, ref _financeBalanceDate, value); } }

		[SMEBoolProperty(Label="TradingAccount Finance Status Flag", Nillable=true, Name="financeStatusFlag", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Boolean> financeStatusFlag { get { return _financeStatusFlag; } set { SetProperty(PropertyfinanceStatusFlag, ref _financeStatusFlag, value); } }

		[SMEStringProperty(Label="TradingAccount Finance Status Text", Nillable=true, Name="financeStatusText", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String financeStatusText { get { return _financeStatusText; } set { SetProperty(PropertyfinanceStatusText, ref _financeStatusText, value); } }

		[SMEEnumProperty(EnumTypeName="discountType--enum", Label="TradingAccount Settlement Discount Type", Nillable=true, Name="settlementDiscountType", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string settlementDiscountType { get { return _settlementDiscountType; } set { SetProperty(PropertysettlementDiscountType, ref _settlementDiscountType, value); } }

		[SMEDecimalProperty(Label="TradingAccount Settlement Discount Amount", Nillable=true, Name="settlementDiscountAmount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> settlementDiscountAmount { get { return _settlementDiscountAmount; } set { SetProperty(PropertysettlementDiscountAmount, ref _settlementDiscountAmount, value); } }

		[SMEDecimalProperty(Label="TradingAccount Settlement Discount Percent", Nillable=true, Name="settlementDiscountPercent", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> settlementDiscountPercent { get { return _settlementDiscountPercent; } set { SetProperty(PropertysettlementDiscountPercent, ref _settlementDiscountPercent, value); } }

		[SMEStringProperty(Label="TradingAccount Settlement Discount Terms", Nillable=true, Name="settlementDiscountTerms", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String settlementDiscountTerms { get { return _settlementDiscountTerms; } set { SetProperty(PropertysettlementDiscountTerms, ref _settlementDiscountTerms, value); } }

		[SMEStringProperty(Label="TradingAccount Settlement Discount Terms Commencement", Nillable=true, Name="settlementDiscountTermsCommencement", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String settlementDiscountTermsCommencement { get { return _settlementDiscountTermsCommencement; } set { SetProperty(PropertysettlementDiscountTermsCommencement, ref _settlementDiscountTermsCommencement, value); } }

		[SMEBoolProperty(Label="TradingAccount Settlement Discount Included In Total", Nillable=true, Name="settlementDiscountIncludedInTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Boolean> settlementDiscountIncludedInTotal { get { return _settlementDiscountIncludedInTotal; } set { SetProperty(PropertysettlementDiscountIncludedInTotal, ref _settlementDiscountIncludedInTotal, value); } }

		[SMEStringProperty(Label="TradingAccount Payment Terms", Nillable=true, Name="paymentTerms", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String paymentTerms { get { return _paymentTerms; } set { SetProperty(PropertypaymentTerms, ref _paymentTerms, value); } }

		[SMEStringProperty(Label="TradingAccount Payment Terms Commencement", Nillable=true, Name="paymentTermsCommencement", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String paymentTermsCommencement { get { return _paymentTermsCommencement; } set { SetProperty(PropertypaymentTermsCommencement, ref _paymentTermsCommencement, value); } }

		[SMEEnumProperty(EnumTypeName="discountType--enum", Label="TradingAccount Order Discount Type", Nillable=true, Name="orderDiscountType", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string orderDiscountType { get { return _orderDiscountType; } set { SetProperty(PropertyorderDiscountType, ref _orderDiscountType, value); } }

		[SMEDecimalProperty(Label="TradingAccount Order Discount Amount", Nillable=true, Name="orderDiscountAmount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> orderDiscountAmount { get { return _orderDiscountAmount; } set { SetProperty(PropertyorderDiscountAmount, ref _orderDiscountAmount, value); } }

		[SMEDecimalProperty(Label="TradingAccount Order Discount Percent", Nillable=true, Name="orderDiscountPercent", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> orderDiscountPercent { get { return _orderDiscountPercent; } set { SetProperty(PropertyorderDiscountPercent, ref _orderDiscountPercent, value); } }

		[SMEStringProperty(Label="TradingAccount Order Text1", Nillable=true, Name="orderText1", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String orderText1 { get { return _orderText1; } set { SetProperty(PropertyorderText1, ref _orderText1, value); } }

		[SMEStringProperty(Label="TradingAccount Order Text2", Nillable=true, Name="orderText2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String orderText2 { get { return _orderText2; } set { SetProperty(PropertyorderText2, ref _orderText2, value); } }

		[SMEEnumProperty(EnumTypeName="discountType--enum", Label="TradingAccount Order Line Discount Type", Nillable=true, Name="orderLineDiscountType", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string orderLineDiscountType { get { return _orderLineDiscountType; } set { SetProperty(PropertyorderLineDiscountType, ref _orderLineDiscountType, value); } }

		[SMEDecimalProperty(Label="TradingAccount Order Line Discount Amount", Nillable=true, Name="orderLineDiscountAmount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> orderLineDiscountAmount { get { return _orderLineDiscountAmount; } set { SetProperty(PropertyorderLineDiscountAmount, ref _orderLineDiscountAmount, value); } }

		[SMEDecimalProperty(Label="TradingAccount Order Line Discount Percent", Nillable=true, Name="orderLineDiscountPercent", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> orderLineDiscountPercent { get { return _orderLineDiscountPercent; } set { SetProperty(PropertyorderLineDiscountPercent, ref _orderLineDiscountPercent, value); } }

		[SMEStringProperty(Label="TradingAccount OrderLine Text1", Nillable=true, Name="orderLineText1", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String orderLineText1 { get { return _orderLineText1; } set { SetProperty(PropertyorderLineText1, ref _orderLineText1, value); } }

		[SMEStringProperty(Label="TradingAccount OrderLine Text2", Nillable=true, Name="orderLineText2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String orderLineText2 { get { return _orderLineText2; } set { SetProperty(PropertyorderLineText2, ref _orderLineText2, value); } }

		[SMEEnumProperty(EnumTypeName="discountType--enum", Label="TradingAccount Invoice Discount Type", Nillable=true, Name="invoiceDiscountType", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string invoiceDiscountType { get { return _invoiceDiscountType; } set { SetProperty(PropertyinvoiceDiscountType, ref _invoiceDiscountType, value); } }

		[SMEDecimalProperty(Label="TradingAccount Invoice Discount Amount", Nillable=true, Name="invoiceDiscountAmount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> invoiceDiscountAmount { get { return _invoiceDiscountAmount; } set { SetProperty(PropertyinvoiceDiscountAmount, ref _invoiceDiscountAmount, value); } }

		[SMEDecimalProperty(Label="TradingAccount Invoice Discount Percent", Nillable=true, Name="invoiceDiscountPercent", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> invoiceDiscountPercent { get { return _invoiceDiscountPercent; } set { SetProperty(PropertyinvoiceDiscountPercent, ref _invoiceDiscountPercent, value); } }

		[SMEStringProperty(Label="TradingAccount Invoice Text1", Nillable=true, Name="invoiceText1", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String invoiceText1 { get { return _invoiceText1; } set { SetProperty(PropertyinvoiceText1, ref _invoiceText1, value); } }

		[SMEStringProperty(Label="TradingAccount Invoice Text2", Nillable=true, Name="invoiceText2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String invoiceText2 { get { return _invoiceText2; } set { SetProperty(PropertyinvoiceText2, ref _invoiceText2, value); } }

		[SMEResource(CanGet=true, PluralName="bankAccounts", Label="TradingAccount BankAccount ")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="TradingAccount BankAccount ", Name="bankAccounts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual bankAccountFeed bankAccounts { get { return _bankAccounts; } set { SetProperty(PropertybankAccounts, ref _bankAccounts, value); } }

		[SMEStringProperty(Label="TradingAccount Default Tender Type", Nillable=true, Name="tenderType", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String tenderType { get { return _tenderType; } set { SetProperty(PropertytenderType, ref _tenderType, value); } }

		[SMEResource(CanGet=true, PluralName="locations", Label="TradingAccount Default Fulfillment Location")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="TradingAccount Default Fulfillment Location", Name="defaultFulfillmentLocation", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("defaultFulfillmentLocation")]			
		public virtual locationFeedEntry defaultFulfillmentLocation { get { return _defaultFulfillmentLocation; } set { SetProperty(PropertydefaultFulfillmentLocation, ref _defaultFulfillmentLocation, value); } }

		[SMEResource(CanGet=true, PluralName="priceLists", Label="TradingAccount PriceList")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="TradingAccount PriceList", Name="pricelists", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual priceListFeed pricelists { get { return _pricelists; } set { SetProperty(Propertypricelists, ref _pricelists, value); } }

		[SMEResource(CanGet=true, PluralName="priceLists", Label="TradingAccount Pricing Override")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="TradingAccount Pricing Override", Name="pricingOverride", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual priceListFeed pricingOverride { get { return _pricingOverride; } set { SetProperty(PropertypricingOverride, ref _pricingOverride, value); } }

		[SMEEnumProperty(EnumTypeName="tradingAccountAccountingType--enum", Label="TradingAccount Accounting Type", Nillable=true, Name="accountingType", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string accountingType { get { return _accountingType; } set { SetProperty(PropertyaccountingType, ref _accountingType, value); } }

		[SMEResource(CanGet=true, PluralName="financialAccounts", Label="TradingAccount FinancialAccount")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="TradingAccount FinancialAccount", Name="financialAccounts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual financialAccountFeed financialAccounts { get { return _financialAccounts; } set { SetProperty(PropertyfinancialAccounts, ref _financialAccounts, value); } }

		[SMEBoolProperty(Label="TradingAccount Primacy Indicator", Nillable=true, Name="primacyIndicator", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Boolean> primacyIndicator { get { return _primacyIndicator; } set { SetProperty(PropertyprimacyIndicator, ref _primacyIndicator, value); } }

		[SMEResource(CanGet=true, PluralName="opportunities", Label="TradingAccount Opportunity")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="TradingAccount Opportunity", Name="opportunities", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual opportunityFeed opportunities { get { return _opportunities; } set { SetProperty(Propertyopportunities, ref _opportunities, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, PluralName="salesQuotations", Label="TradingAccount Sales Quotation")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="TradingAccount Sales Quotation", Name="salesQuotations", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesQuotationFeed salesQuotations { get { return _salesQuotations; } set { SetProperty(PropertysalesQuotations, ref _salesQuotations, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, PluralName="salesOrders", Label="TradingAccount Sales Order")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="TradingAccount Sales Order", Name="salesOrders", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesOrderFeed salesOrders { get { return _salesOrders; } set { SetProperty(PropertysalesOrders, ref _salesOrders, value); } }

		[SMEResource(CanGet=true, PluralName="salesOrderDeliveries", Label="TradingAccount Sales Order Delivery")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="TradingAccount Sales Order Delivery", Name="salesOrderDeliveries", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesOrderDeliveryFeed salesOrderDeliveries { get { return _salesOrderDeliveries; } set { SetProperty(PropertysalesOrderDeliveries, ref _salesOrderDeliveries, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, PluralName="salesInvoices", Label="TradingAccount Sales Invoice")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="TradingAccount Sales Invoice", Name="salesInvoices", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesInvoiceFeed salesInvoices { get { return _salesInvoices; } set { SetProperty(PropertysalesInvoices, ref _salesInvoices, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, PluralName="salesReturns", Label="TradingAccount Sales Return")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="TradingAccount Sales Return", Name="salesReturns", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesReturnFeed salesReturns { get { return _salesReturns; } set { SetProperty(PropertysalesReturns, ref _salesReturns, value); } }

		[SMEResource(CanGet=true, PluralName="salesReturnDeliveries", Label="TradingAccount Sales Return Delivery")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="TradingAccount Sales Return Delivery", Name="salesReturnDeliveries", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesReturnDeliveryFeed salesReturnDeliveries { get { return _salesReturnDeliveries; } set { SetProperty(PropertysalesReturnDeliveries, ref _salesReturnDeliveries, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, PluralName="salesCredits", Label="TradingAccount Sales Credit")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="TradingAccount Sales Credit", Name="salesCredits", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesCreditFeed salesCredits { get { return _salesCredits; } set { SetProperty(PropertysalesCredits, ref _salesCredits, value); } }

		[SMEResource(CanGet=true, CanPost=true, PluralName="purchaseRequisitions", Label="TradingAccount Purchase Requisition")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="TradingAccount Purchase Requisition", Name="purchaseRequisitions", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseRequisitionFeed purchaseRequisitions { get { return _purchaseRequisitions; } set { SetProperty(PropertypurchaseRequisitions, ref _purchaseRequisitions, value); } }

		[SMEResource(CanGet=true, CanPost=true, PluralName="purchaseOrders", Label="TradingAccount Purchase Order")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="TradingAccount Purchase Order", Name="purchaseOrders", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseOrderFeed purchaseOrders { get { return _purchaseOrders; } set { SetProperty(PropertypurchaseOrders, ref _purchaseOrders, value); } }

		[SMEResource(CanGet=true, PluralName="purchaseOrderDeliveries", Label="TradingAccount Purchase Order Delivery")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="TradingAccount Purchase Order Delivery", Name="purchaseOrderDeliveries", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseOrderDeliveryFeed purchaseOrderDeliveries { get { return _purchaseOrderDeliveries; } set { SetProperty(PropertypurchaseOrderDeliveries, ref _purchaseOrderDeliveries, value); } }

		[SMEResource(CanGet=true, CanPost=true, PluralName="purchaseInvoices", Label="TradingAccount Purchase Invoice")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="TradingAccount Purchase Invoice", Name="purchaseInvoices", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseInvoiceFeed purchaseInvoices { get { return _purchaseInvoices; } set { SetProperty(PropertypurchaseInvoices, ref _purchaseInvoices, value); } }

		[SMEResource(CanGet=true, PluralName="purchaseReturns", Label="TradingAccount Purchase Return")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="TradingAccount Purchase Return", Name="purchaseReturns", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseReturnFeed purchaseReturns { get { return _purchaseReturns; } set { SetProperty(PropertypurchaseReturns, ref _purchaseReturns, value); } }

		[SMEResource(CanGet=true, PluralName="purchaseReturnDeliveries", Label="TradingAccount Purchase Return Delivery")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="TradingAccount Purchase Return Delivery", Name="purchaseReturnDeliveries", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseReturnDeliveryFeed purchaseReturnDeliveries { get { return _purchaseReturnDeliveries; } set { SetProperty(PropertypurchaseReturnDeliveries, ref _purchaseReturnDeliveries, value); } }

		[SMEResource(CanGet=true, PluralName="purchaseCredits", Label="TradingAccount Purchase Credit")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="TradingAccount Purchase Credit", Name="purchaseCredits", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseCreditFeed purchaseCredits { get { return _purchaseCredits; } set { SetProperty(PropertypurchaseCredits, ref _purchaseCredits, value); } }

		[SMEResource(CanGet=true, PluralName="receipts", Label="TradingAccount Receipt")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="TradingAccount Receipt", Name="receipts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual receiptFeed receipts { get { return _receipts; } set { SetProperty(Propertyreceipts, ref _receipts, value); } }

		[SMEResource(CanGet=true, PluralName="payments", Label="TradingAccount Payment")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="TradingAccount Payment", Name="payments", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual paymentFeed payments { get { return _payments; } set { SetProperty(Propertypayments, ref _payments, value); } }

		[SMEResource(CanGet=true, PluralName="interactions", Label="TradingAccount Interaction")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="TradingAccount Interaction", Name="interactions", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual interactionFeed interactions { get { return _interactions; } set { SetProperty(Propertyinteractions, ref _interactions, value); } }

		[SMEResource(CanGet=true, PluralName="projects", Label="TradingAccount Project")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="TradingAccount Project", Name="projects", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual projectFeed projects { get { return _projects; } set { SetProperty(Propertyprojects, ref _projects, value); } }

		[SMEResource(CanGet=true, PluralName="cases", Label="TradingAccount Case")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="TradingAccount Case", Name="cases", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual caseFeed cases { get { return _cases; } set { SetProperty(Propertycases, ref _cases, value); } }

		[SMEResource(CanGet=true, PluralName="notes")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Label="TradingAccount Note", Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual noteFeed notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		#endregion


	}
}