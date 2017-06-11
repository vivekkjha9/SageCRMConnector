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
	/// Defines a purchaseOrderDelivery feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("purchaseOrderDelivery", Namespace="http://schemas.sage.com/crmErp/2008")]
		[SMEResource(CanGet=true, PluralName="purchaseOrderDeliveries")]
	public class purchaseOrderDeliveryFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyid = "id";
		public const string Propertyactive = "active";
		public const string Propertydeleted = "deleted";
		public const string Propertylabel = "label";
		public const string PropertypurchaseOrder = "purchaseOrder";
		public const string Propertyreference = "reference";
		public const string Propertyreference2 = "reference2";
		public const string PropertyoperatingCompany = "operatingCompany";
		public const string Propertystatus = "status";
		public const string Propertycompany = "company";
		public const string Propertycustomer = "customer";
		public const string PropertytradingAccount = "tradingAccount";
		public const string PropertysupplierReference = "supplierReference";
		public const string Propertytype = "type";
		public const string PropertypostalAddress = "postalAddress";
		public const string PropertydeliveryMethod = "deliveryMethod";
		public const string PropertycarrierCompany = "carrierCompany";
		public const string PropertycarrierSupplier = "carrierSupplier";
		public const string PropertycarrierTradingAccount = "carrierTradingAccount";
		public const string PropertydeliveryContact = "deliveryContact";
		public const string PropertycarrierReference = "carrierReference";
		public const string PropertycarrierNetPrice = "carrierNetPrice";
		public const string PropertycarrierTaxPrice = "carrierTaxPrice";
		public const string PropertycarrierTotalPrice = "carrierTotalPrice";
		public const string PropertycarrierPurchaseInvoice = "carrierPurchaseInvoice";
		public const string Propertycurrency = "currency";
		public const string PropertyoperatingCompanyCurrency = "operatingCompanyCurrency";
		public const string PropertyoperatingCompanyCurrencyExchangeRate = "operatingCompanyCurrencyExchangeRate";
		public const string PropertyoperatingCompanyCurrencyExchangeRateOperator = "operatingCompanyCurrencyExchangeRateOperator";
		public const string PropertyoperatingCompanyCurrencyExchangeRateDate = "operatingCompanyCurrencyExchangeRateDate";
		public const string PropertyinvoiceCurrency = "invoiceCurrency";
		public const string PropertyinvoiceCurrencyExchangeRate = "invoiceCurrencyExchangeRate";
		public const string PropertyinvoiceCurrencyExchangeRateOperator = "invoiceCurrencyExchangeRateOperator";
		public const string PropertyinvoiceCurrencyExchangeRateDate = "invoiceCurrencyExchangeRateDate";
		public const string PropertysupplierTradingAccountCurrency = "supplierTradingAccountCurrency";
		public const string PropertysupplierTradingAccountCurrencyExchangeRate = "supplierTradingAccountCurrencyExchangeRate";
		public const string PropertysupplierTradingAccountCurrencyExchangeRateOperator = "supplierTradingAccountCurrencyExchangeRateOperator";
		public const string PropertysupplierTradingAccountCurrencyExchangeRateDate = "supplierTradingAccountCurrencyExchangeRateDate";
		public const string PropertyrequestedDeliveryDate = "requestedDeliveryDate";
		public const string PropertyactualDeliveryDate = "actualDeliveryDate";
		public const string PropertyactualDeliveryTime = "actualDeliveryTime";
		public const string PropertydateExceptionReason = "dateExceptionReason";
		public const string PropertypurchaseOrderDeliveryLines = "purchaseOrderDeliveryLines";
		public const string PropertylineCount = "lineCount";
		public const string PropertyrequestedQuantity = "requestedQuantity";
		public const string PropertydeliveredQuantity = "deliveredQuantity";
		public const string Propertytext1 = "text1";
		public const string Propertytext2 = "text2";
		public const string PropertydestinationCountry = "destinationCountry";
		public const string Propertyuser = "user";
		public const string Propertycases = "cases";
		public const string Propertyinteractions = "interactions";
		public const string Propertynotes = "notes";

		#endregion

		#region Fields

		private System.String _id;
		private System.Boolean _active;
		private System.Boolean _deleted;
		private System.String _label;
		private purchaseOrderFeedEntry _purchaseOrder;
		private System.String _reference;
		private System.String _reference2;
		private companyFeedEntry _operatingCompany;
		private string _status;
		private companyFeedEntry _company;
		private supplierFeedEntry _customer;
		private tradingAccountFeedEntry _tradingAccount;
		private System.String _supplierReference;
		private System.String _type;
		private postalAddressFeedEntry _postalAddress;
		private System.String _deliveryMethod;
		private companyFeedEntry _carrierCompany;
		private supplierFeedEntry _carrierSupplier;
		private tradingAccountFeedEntry _carrierTradingAccount;
		private contactFeedEntry _deliveryContact;
		private System.String _carrierReference;
		private Nullable<System.Decimal> _carrierNetPrice;
		private Nullable<System.Decimal> _carrierTaxPrice;
		private Nullable<System.Decimal> _carrierTotalPrice;
		private purchaseInvoiceFeedEntry _carrierPurchaseInvoice;
		private System.String _currency;
		private System.String _operatingCompanyCurrency;
		private Nullable<System.Decimal> _operatingCompanyCurrencyExchangeRate;
		private string _operatingCompanyCurrencyExchangeRateOperator;
		private Nullable<System.DateTime> _operatingCompanyCurrencyExchangeRateDate;
		private System.String _invoiceCurrency;
		private Nullable<System.Decimal> _invoiceCurrencyExchangeRate;
		private string _invoiceCurrencyExchangeRateOperator;
		private Nullable<System.DateTime> _invoiceCurrencyExchangeRateDate;
		private System.String _supplierTradingAccountCurrency;
		private Nullable<System.Decimal> _supplierTradingAccountCurrencyExchangeRate;
		private string _supplierTradingAccountCurrencyExchangeRateOperator;
		private Nullable<System.DateTime> _supplierTradingAccountCurrencyExchangeRateDate;
		private Nullable<System.DateTime> _requestedDeliveryDate;
		private System.DateTime _actualDeliveryDate;
		private Nullable<System.DateTime> _actualDeliveryTime;
		private System.String _dateExceptionReason;
		private purchaseOrderDeliveryLineFeedEntry _purchaseOrderDeliveryLines;
		private System.Decimal _lineCount;
		private Nullable<System.Decimal> _requestedQuantity;
		private System.Decimal _deliveredQuantity;
		private System.String _text1;
		private System.String _text2;
		private System.String _destinationCountry;
		private System.String _user;
		private caseFeedEntry _cases;
		private interactionFeedEntry _interactions;
		private noteFeedEntry _notes;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="purchaseOrderDeliveryFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public purchaseOrderDeliveryFeedEntrySchema()
		{
		}

		#region Properties


		[SMEStringProperty(Label="PurchaseOrderDelivery Application ID", Name="id", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual new System.String id { get { return _id; } set { SetProperty(Propertyid, ref _id, value); } }

		[SMEBoolProperty(Label="PurchaseOrderDelivery Active Flag", Name="active", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEBoolProperty(Label="PurchaseOrderDelivery Deleted", Name="deleted", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean deleted { get { return _deleted; } set { SetProperty(Propertydeleted, ref _deleted, value); } }

		[SMEStringProperty(Label="PurchaseOrderDelivery Label", Name="label", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String label { get { return _label; } set { SetProperty(Propertylabel, ref _label, value); } }

		[SMEResource(CanGet=true, CanPost=true, PluralName="purchaseOrders", Label="PurchaseOrderDelivery Purchase Order")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Parent, Label="PurchaseOrderDelivery Purchase Order", Name="purchaseOrder", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("purchaseOrder")]			
		public virtual purchaseOrderFeedEntry purchaseOrder { get { return _purchaseOrder; } set { SetProperty(PropertypurchaseOrder, ref _purchaseOrder, value); } }

		[SMEStringProperty(Label="PurchaseOrderDelivery reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEStringProperty(Label="PurchaseOrderDelivery Reference2", Nillable=true, Name="reference2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="companies")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseOrderDelivery OperatingCompany", Name="operatingCompany", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("operatingCompany")]			
		public virtual companyFeedEntry operatingCompany { get { return _operatingCompany; } set { SetProperty(PropertyoperatingCompany, ref _operatingCompany, value); } }

		[SMEEnumProperty(EnumTypeName="purchaseOrderDeliveryStatus--enum", Label="PurchaseOrderDelivery Status", Nillable=true, Name="status", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string status { get { return _status; } set { SetProperty(Propertystatus, ref _status, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="companies")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseOrderDelivery Company", Name="company", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("company")]			
		public virtual companyFeedEntry company { get { return _company; } set { SetProperty(Propertycompany, ref _company, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="suppliers")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseOrderDelivery Supplier", Name="customer", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("customer")]			
		public virtual supplierFeedEntry customer { get { return _customer; } set { SetProperty(Propertycustomer, ref _customer, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseOrderDelivery Supplier TradingAccount", Name="tradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("tradingAccount")]			
		public virtual tradingAccountFeedEntry tradingAccount { get { return _tradingAccount; } set { SetProperty(PropertytradingAccount, ref _tradingAccount, value); } }

		[SMEStringProperty(Label="PurchaseOrderDelivery Supplier reference", Nillable=true, Name="supplierReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String supplierReference { get { return _supplierReference; } set { SetProperty(PropertysupplierReference, ref _supplierReference, value); } }

		[SMEStringProperty(Label="PurchaseOrderDelivery Type", Nillable=true, Name="type", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="postalAddresses")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, Label="PurchaseOrderDelivery PostalAddress", Name="postalAddress", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("postalAddress")]			
		public virtual postalAddressFeedEntry postalAddress { get { return _postalAddress; } set { SetProperty(PropertypostalAddress, ref _postalAddress, value); } }

		[SMEStringProperty(Label="PurchaseOrderDelivery Method", Nillable=true, Name="deliveryMethod", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String deliveryMethod { get { return _deliveryMethod; } set { SetProperty(PropertydeliveryMethod, ref _deliveryMethod, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="companies")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseOrderDelivery Carrier Company", Name="carrierCompany", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("carrierCompany")]			
		public virtual companyFeedEntry carrierCompany { get { return _carrierCompany; } set { SetProperty(PropertycarrierCompany, ref _carrierCompany, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="suppliers")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseOrderDelivery Carrier Supplier", Name="carrierSupplier", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("carrierSupplier")]			
		public virtual supplierFeedEntry carrierSupplier { get { return _carrierSupplier; } set { SetProperty(PropertycarrierSupplier, ref _carrierSupplier, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseOrderDelivery Carrier TradingAccount", Name="carrierTradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("carrierTradingAccount")]			
		public virtual tradingAccountFeedEntry carrierTradingAccount { get { return _carrierTradingAccount; } set { SetProperty(PropertycarrierTradingAccount, ref _carrierTradingAccount, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="contacts", Label="PurchaseOrderDelivery Delivery Contact")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseOrderDelivery Delivery Contact", Name="deliveryContact", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("deliveryContact")]			
		public virtual contactFeedEntry deliveryContact { get { return _deliveryContact; } set { SetProperty(PropertydeliveryContact, ref _deliveryContact, value); } }

		[SMEStringProperty(Label="PurchaseOrderDelivery Carrier reference", Nillable=true, Name="carrierReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String carrierReference { get { return _carrierReference; } set { SetProperty(PropertycarrierReference, ref _carrierReference, value); } }

		[SMEDecimalProperty(Label="PurchaseOrderDelivery Carrier Net Price", Nillable=true, Name="carrierNetPrice", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> carrierNetPrice { get { return _carrierNetPrice; } set { SetProperty(PropertycarrierNetPrice, ref _carrierNetPrice, value); } }

		[SMEDecimalProperty(Label="PurchaseOrderDelivery Carrier Tax Price", Nillable=true, Name="carrierTaxPrice", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> carrierTaxPrice { get { return _carrierTaxPrice; } set { SetProperty(PropertycarrierTaxPrice, ref _carrierTaxPrice, value); } }

		[SMEDecimalProperty(Label="PurchaseOrderDelivery Carrier Gross Price", Nillable=true, Name="carrierTotalPrice", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> carrierTotalPrice { get { return _carrierTotalPrice; } set { SetProperty(PropertycarrierTotalPrice, ref _carrierTotalPrice, value); } }

		[SMEResource(CanGet=true, CanPost=true, PluralName="purchaseInvoices", Label="PurchaseOrderDelivery Carrier PurchaseInvoice")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseOrderDelivery Carrier PurchaseInvoice", Name="carrierPurchaseInvoice", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("carrierPurchaseInvoice")]			
		public virtual purchaseInvoiceFeedEntry carrierPurchaseInvoice { get { return _carrierPurchaseInvoice; } set { SetProperty(PropertycarrierPurchaseInvoice, ref _carrierPurchaseInvoice, value); } }

		[SMEStringProperty(Label="PurchaseOrderDelivery Currency", Nillable=true, Name="currency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String currency { get { return _currency; } set { SetProperty(Propertycurrency, ref _currency, value); } }

		[SMEStringProperty(Label="PurchaseOrderDelivery OperatingCompany Currency", Name="operatingCompanyCurrency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String operatingCompanyCurrency { get { return _operatingCompanyCurrency; } set { SetProperty(PropertyoperatingCompanyCurrency, ref _operatingCompanyCurrency, value); } }

		[SMEDecimalProperty(Label="PurchaseOrderDelivery OperatingCompany Currency Exchange Rate", Nillable=true, Name="operatingCompanyCurrencyExchangeRate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> operatingCompanyCurrencyExchangeRate { get { return _operatingCompanyCurrencyExchangeRate; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRate, ref _operatingCompanyCurrencyExchangeRate, value); } }

		[SMEEnumProperty(EnumTypeName="RateOperator--enum", Label="PurchaseOrderDelivery OperatingCompany Currency Exchange Rate Operator", Nillable=true, Name="operatingCompanyCurrencyExchangeRateOperator", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string operatingCompanyCurrencyExchangeRateOperator { get { return _operatingCompanyCurrencyExchangeRateOperator; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRateOperator, ref _operatingCompanyCurrencyExchangeRateOperator, value); } }

		[SMEDateProperty(Label="PurchaseOrderDelivery OperatingCompany Currency Exchange Rate Date", Nillable=true, Name="operatingCompanyCurrencyExchangeRateDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> operatingCompanyCurrencyExchangeRateDate { get { return _operatingCompanyCurrencyExchangeRateDate; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRateDate, ref _operatingCompanyCurrencyExchangeRateDate, value); } }

		[SMEStringProperty(Label="PurchaseOrderDelivery Invoice Currency", Nillable=true, Name="invoiceCurrency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String invoiceCurrency { get { return _invoiceCurrency; } set { SetProperty(PropertyinvoiceCurrency, ref _invoiceCurrency, value); } }

		[SMEDecimalProperty(Label="PurchaseOrderDelivery Invoice Currency Exchange Rate", Nillable=true, Name="invoiceCurrencyExchangeRate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> invoiceCurrencyExchangeRate { get { return _invoiceCurrencyExchangeRate; } set { SetProperty(PropertyinvoiceCurrencyExchangeRate, ref _invoiceCurrencyExchangeRate, value); } }

		[SMEEnumProperty(EnumTypeName="RateOperator--enum", Label="PurchaseOrderDelivery Invoice Currency Exchange Rate Operator", Nillable=true, Name="invoiceCurrencyExchangeRateOperator", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string invoiceCurrencyExchangeRateOperator { get { return _invoiceCurrencyExchangeRateOperator; } set { SetProperty(PropertyinvoiceCurrencyExchangeRateOperator, ref _invoiceCurrencyExchangeRateOperator, value); } }

		[SMEDateProperty(Label="PurchaseOrderDelivery Invoice Currency Exchange Rate Date", Nillable=true, Name="invoiceCurrencyExchangeRateDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> invoiceCurrencyExchangeRateDate { get { return _invoiceCurrencyExchangeRateDate; } set { SetProperty(PropertyinvoiceCurrencyExchangeRateDate, ref _invoiceCurrencyExchangeRateDate, value); } }

		[SMEStringProperty(Label="PurchaseOrderDelivery Supplier TradingAccount Currency", Nillable=true, Name="supplierTradingAccountCurrency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String supplierTradingAccountCurrency { get { return _supplierTradingAccountCurrency; } set { SetProperty(PropertysupplierTradingAccountCurrency, ref _supplierTradingAccountCurrency, value); } }

		[SMEDecimalProperty(Label="PurchaseOrderDelivery Supplier TradingAccount Currency Exchange Rate", Nillable=true, Name="supplierTradingAccountCurrencyExchangeRate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> supplierTradingAccountCurrencyExchangeRate { get { return _supplierTradingAccountCurrencyExchangeRate; } set { SetProperty(PropertysupplierTradingAccountCurrencyExchangeRate, ref _supplierTradingAccountCurrencyExchangeRate, value); } }

		[SMEEnumProperty(EnumTypeName="RateOperator--enum", Label="PurchaseOrderDelivery Supplier TradingAccount Currency Exchange Rate Operator", Nillable=true, Name="supplierTradingAccountCurrencyExchangeRateOperator", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string supplierTradingAccountCurrencyExchangeRateOperator { get { return _supplierTradingAccountCurrencyExchangeRateOperator; } set { SetProperty(PropertysupplierTradingAccountCurrencyExchangeRateOperator, ref _supplierTradingAccountCurrencyExchangeRateOperator, value); } }

		[SMEDateProperty(Label="PurchaseOrderDelivery Supplier TradingAccount Currency Exchange Rate Date", Nillable=true, Name="supplierTradingAccountCurrencyExchangeRateDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> supplierTradingAccountCurrencyExchangeRateDate { get { return _supplierTradingAccountCurrencyExchangeRateDate; } set { SetProperty(PropertysupplierTradingAccountCurrencyExchangeRateDate, ref _supplierTradingAccountCurrencyExchangeRateDate, value); } }

		[SMEDateProperty(Label="PurchaseOrderDelivery Requested Delivery Date", Nillable=true, Name="requestedDeliveryDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> requestedDeliveryDate { get { return _requestedDeliveryDate; } set { SetProperty(PropertyrequestedDeliveryDate, ref _requestedDeliveryDate, value); } }

		[SMEDateProperty(Label="PurchaseOrderDelivery Actual Delivery Date", Name="actualDeliveryDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.DateTime actualDeliveryDate { get { return _actualDeliveryDate; } set { SetProperty(PropertyactualDeliveryDate, ref _actualDeliveryDate, value); } }

		[SMETimeProperty(Label="PurchaseOrderDelivery Actual Delivery Time", Nillable=true, Name="actualDeliveryTime", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> actualDeliveryTime { get { return _actualDeliveryTime; } set { SetProperty(PropertyactualDeliveryTime, ref _actualDeliveryTime, value); } }

		[SMEStringProperty(Label="PurchaseOrderDelivery Date Exception Reason", Nillable=true, Name="dateExceptionReason", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String dateExceptionReason { get { return _dateExceptionReason; } set { SetProperty(PropertydateExceptionReason, ref _dateExceptionReason, value); } }

		[SMEResource(CanGet=true, PluralName="purchaseOrderDeliveryLines", Label="PurchaseOrderDelivery PurchaseOrderDeliveryLine")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, Label="PurchaseOrderDelivery PurchaseOrderDeliveryLine", Name="purchaseOrderDeliveryLines", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("purchaseOrderDeliveryLines")]			
		public virtual purchaseOrderDeliveryLineFeedEntry purchaseOrderDeliveryLines { get { return _purchaseOrderDeliveryLines; } set { SetProperty(PropertypurchaseOrderDeliveryLines, ref _purchaseOrderDeliveryLines, value); } }

		[SMEDecimalProperty(Label="PurchaseOrderDelivery Line Count", Name="lineCount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal lineCount { get { return _lineCount; } set { SetProperty(PropertylineCount, ref _lineCount, value); } }

		[SMEDecimalProperty(Label="PurchaseOrderDelivery Requested Quantity", Nillable=true, Name="requestedQuantity", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> requestedQuantity { get { return _requestedQuantity; } set { SetProperty(PropertyrequestedQuantity, ref _requestedQuantity, value); } }

		[SMEDecimalProperty(Label="PurchaseOrderDelivery Delivered Quantity", Name="deliveredQuantity", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal deliveredQuantity { get { return _deliveredQuantity; } set { SetProperty(PropertydeliveredQuantity, ref _deliveredQuantity, value); } }

		[SMEStringProperty(Label="PurchaseOrderDelivery Text1", Nillable=true, Name="text1", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String text1 { get { return _text1; } set { SetProperty(Propertytext1, ref _text1, value); } }

		[SMEStringProperty(Label="PurchaseOrderDelivery Text2", Nillable=true, Name="text2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String text2 { get { return _text2; } set { SetProperty(Propertytext2, ref _text2, value); } }

		[SMEStringProperty(Label="PurchaseOrderDelivery Destination Country", Nillable=true, Name="destinationCountry", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String destinationCountry { get { return _destinationCountry; } set { SetProperty(PropertydestinationCountry, ref _destinationCountry, value); } }

		[SMEStringProperty(Label="PurchaseOrderDelivery User", Nillable=true, Name="user", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String user { get { return _user; } set { SetProperty(Propertyuser, ref _user, value); } }

		[SMEResource(CanGet=true, PluralName="cases", Label="PurchaseOrderDelivery Case reference")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseOrderDelivery Case reference", Name="cases", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("cases")]			
		public virtual caseFeedEntry cases { get { return _cases; } set { SetProperty(Propertycases, ref _cases, value); } }

		[SMEResource(CanGet=true, PluralName="interactions", Label="PurchaseOrderDelivery Interaction")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, Label="PurchaseOrderDelivery Interaction", Name="interactions", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("interactions")]			
		public virtual interactionFeedEntry interactions { get { return _interactions; } set { SetProperty(Propertyinteractions, ref _interactions, value); } }

		[SMEResource(CanGet=true, PluralName="notes", Label="PurchaseOrderDelivery Note")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, Label="PurchaseOrderDelivery Note", Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("notes")]			
		public virtual noteFeedEntry notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		#endregion


	}
}