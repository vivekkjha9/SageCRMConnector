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
	/// Defines a purchaseRequisition feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("purchaseRequisition", Namespace="http://schemas.sage.com/crmErp/2008")]
		[SMEResource(CanGet=true, CanPost=true, PluralName="purchaseRequisitions")]
	public class purchaseRequisitionFeedEntrySchema : Sage.Common.Syndication.FeedEntry
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
		public const string Propertypricelist = "pricelist";
		public const string PropertycustomerTradingAccount = "customerTradingAccount";
		public const string PropertycustomerReference = "customerReference";
		public const string Propertytype = "type";
		public const string PropertycopyFlag = "copyFlag";
		public const string PropertyoriginatorDocument = "originatorDocument";
		public const string PropertypostalAddresses = "postalAddresses";
		public const string PropertydeliveryTerms = "deliveryTerms";
		public const string PropertydeliveryDate = "deliveryDate";
		public const string Propertycurrency = "currency";
		public const string PropertyoperatingCompanyCurrency = "operatingCompanyCurrency";
		public const string PropertyoperatingCompanyCurrencyExchangeRate = "operatingCompanyCurrencyExchangeRate";
		public const string PropertyoperatingCompanyCurrencyExchangeRateOperator = "operatingCompanyCurrencyExchangeRateOperator";
		public const string PropertyoperatingCompanyCurrencyExchangeRateDate = "operatingCompanyCurrencyExchangeRateDate";
		public const string PropertysupplierTradingAccountCurrency = "supplierTradingAccountCurrency";
		public const string PropertysupplierTradingAccountCurrencyExchangeRate = "supplierTradingAccountCurrencyExchangeRate";
		public const string PropertysupplierTradingAccountCurrencyExchangeRateOperator = "supplierTradingAccountCurrencyExchangeRateOperator";
		public const string PropertysupplierTradingAccountCurrencyExchangeRateDate = "supplierTradingAccountCurrencyExchangeRateDate";
		public const string Propertydate = "date";
		public const string Propertytime = "time";
		public const string Propertyvalidity = "validity";
		public const string PropertyexpirationDate = "expirationDate";
		public const string PropertydueDate = "dueDate";
		public const string PropertytaxCodes = "taxCodes";
		public const string Propertyuser = "user";
		public const string PropertybuyerUser = "buyerUser";
		public const string PropertypurchaseRequisitionLines = "purchaseRequisitionLines";
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
		public const string Propertycontract = "contract";
		public const string Propertyprojects = "projects";
		public const string PropertyprojectLines = "projectLines";
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
		private priceListFeedEntry _pricelist;
		private tradingAccountFeedEntry _customerTradingAccount;
		private System.String _customerReference;
		private System.String _type;
		private System.Boolean _copyFlag;
		private purchaseRequisitionFeedEntry _originatorDocument;
		private postalAddressFeed _postalAddresses;
		private System.String _deliveryTerms;
		private Nullable<System.DateTime> _deliveryDate;
		private System.String _currency;
		private System.String _operatingCompanyCurrency;
		private Nullable<System.Decimal> _operatingCompanyCurrencyExchangeRate;
		private string _operatingCompanyCurrencyExchangeRateOperator;
		private Nullable<System.DateTime> _operatingCompanyCurrencyExchangeRateDate;
		private System.String _supplierTradingAccountCurrency;
		private Nullable<System.Decimal> _supplierTradingAccountCurrencyExchangeRate;
		private string _supplierTradingAccountCurrencyExchangeRateOperator;
		private Nullable<System.DateTime> _supplierTradingAccountCurrencyExchangeRateDate;
		private System.DateTime _date;
		private Nullable<System.DateTime> _time;
		private Nullable<System.Decimal> _validity;
		private Nullable<System.DateTime> _expirationDate;
		private Nullable<System.DateTime> _dueDate;
		private taxCodeFeed _taxCodes;
		private System.String _user;
		private System.String _buyerUser;
		private purchaseRequisitionLineFeed _purchaseRequisitionLines;
		private System.Decimal _lineCount;
		private string _orderDiscountType;
		private Nullable<System.Decimal> _orderDiscountAmount;
		private Nullable<System.Decimal> _orderDiscountPercent;
		private string _orderAdditionalDiscount1Type;
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
		private System.String _contract;
		private projectFeed _projects;
		private projectLineFeed _projectLines;
		private financialAccountFeed _financialAccounts;
		private interactionFeed _interactions;
		private noteFeed _notes;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="purchaseRequisitionFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public purchaseRequisitionFeedEntrySchema()
		{
		}

		#region Properties


		[SMEStringProperty(Label="PurchaseRequisition Application ID", Name="id", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual new System.String id { get { return _id; } set { SetProperty(Propertyid, ref _id, value); } }

		[SMEBoolProperty(Label="PurchaseRequisition Active Flag", Name="active", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEBoolProperty(Label="PurchaseRequisition Deleted", Name="deleted", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean deleted { get { return _deleted; } set { SetProperty(Propertydeleted, ref _deleted, value); } }

		[SMEStringProperty(Label="PurchaseRequisition Label", Name="label", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String label { get { return _label; } set { SetProperty(Propertylabel, ref _label, value); } }

		[SMEStringProperty(Label="PurchaseRequisition reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEStringProperty(Label="PurchaseRequisition Reference2", Nillable=true, Name="reference2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="companies")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseRequisition OperatingCompany", Name="operatingCompany", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("operatingCompany")]			
		public virtual companyFeedEntry operatingCompany { get { return _operatingCompany; } set { SetProperty(PropertyoperatingCompany, ref _operatingCompany, value); } }

		[SMEEnumProperty(EnumTypeName="purchaseRequisitionStatus--enum", Label="PurchaseRequisition Status", Nillable=true, Name="status", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string status { get { return _status; } set { SetProperty(Propertystatus, ref _status, value); } }

		[SMEBoolProperty(Label="PurchaseRequisition Status Flag", Nillable=true, Name="statusFlag", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Boolean> statusFlag { get { return _statusFlag; } set { SetProperty(PropertystatusFlag, ref _statusFlag, value); } }

		[SMEStringProperty(Label="PurchaseRequisition Status Flag Text", Nillable=true, Name="statusFlagText", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String statusFlagText { get { return _statusFlagText; } set { SetProperty(PropertystatusFlagText, ref _statusFlagText, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="companies")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseRequisition Company", Name="company", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("company")]			
		public virtual companyFeedEntry company { get { return _company; } set { SetProperty(Propertycompany, ref _company, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="suppliers")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseRequisition Supplier", Name="supplier", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("supplier")]			
		public virtual supplierFeedEntry supplier { get { return _supplier; } set { SetProperty(Propertysupplier, ref _supplier, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseRequisition Supplier TradingAccount", Name="tradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("tradingAccount")]			
		public virtual tradingAccountFeedEntry tradingAccount { get { return _tradingAccount; } set { SetProperty(PropertytradingAccount, ref _tradingAccount, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="contacts", Label="PurchaseRequisition Seller Contact")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseRequisition Seller Contact", Name="sellerContact", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("sellerContact")]			
		public virtual contactFeedEntry sellerContact { get { return _sellerContact; } set { SetProperty(PropertysellerContact, ref _sellerContact, value); } }

		[SMEStringProperty(Label="PurchaseRequisition Supplier reference", Nillable=true, Name="supplierReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String supplierReference { get { return _supplierReference; } set { SetProperty(PropertysupplierReference, ref _supplierReference, value); } }

		[SMEResource(CanGet=true, PluralName="priceLists", Label="PurchaseRequisition PriceList")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseRequisition PriceList", Name="pricelist", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("pricelist")]			
		public virtual priceListFeedEntry pricelist { get { return _pricelist; } set { SetProperty(Propertypricelist, ref _pricelist, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseRequisition Customer TradingAccount", Name="customerTradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("customerTradingAccount")]			
		public virtual tradingAccountFeedEntry customerTradingAccount { get { return _customerTradingAccount; } set { SetProperty(PropertycustomerTradingAccount, ref _customerTradingAccount, value); } }

		[SMEStringProperty(Label="PurchaseRequisition Customer reference", Nillable=true, Name="customerReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String customerReference { get { return _customerReference; } set { SetProperty(PropertycustomerReference, ref _customerReference, value); } }

		[SMEStringProperty(Label="PurchaseRequisition Type", Nillable=true, Name="type", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }

		[SMEBoolProperty(Label="PurchaseRequisition Copy Flag", Name="copyFlag", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean copyFlag { get { return _copyFlag; } set { SetProperty(PropertycopyFlag, ref _copyFlag, value); } }

		[SMEResource(CanGet=true, CanPost=true, PluralName="purchaseRequisitions", Label="PurchaseRequisition Originator Document reference")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseRequisition Originator Document reference", Name="originatorDocument", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("originatorDocument")]			
		public virtual purchaseRequisitionFeedEntry originatorDocument { get { return _originatorDocument; } set { SetProperty(PropertyoriginatorDocument, ref _originatorDocument, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="postalAddresses")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="PurchaseRequisition PostalAddress", Name="postalAddresses", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual postalAddressFeed postalAddresses { get { return _postalAddresses; } set { SetProperty(PropertypostalAddresses, ref _postalAddresses, value); } }

		[SMEStringProperty(Label="PurchaseRequisition Delivery Terms", Nillable=true, Name="deliveryTerms", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String deliveryTerms { get { return _deliveryTerms; } set { SetProperty(PropertydeliveryTerms, ref _deliveryTerms, value); } }

		[SMEDateProperty(Label="PurchaseRequisition Delivery Date", Nillable=true, Name="deliveryDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> deliveryDate { get { return _deliveryDate; } set { SetProperty(PropertydeliveryDate, ref _deliveryDate, value); } }

		[SMEStringProperty(Label="PurchaseRequisition Currency", Name="currency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String currency { get { return _currency; } set { SetProperty(Propertycurrency, ref _currency, value); } }

		[SMEStringProperty(Label="PurchaseRequisition OperatingCompany Currency", Name="operatingCompanyCurrency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String operatingCompanyCurrency { get { return _operatingCompanyCurrency; } set { SetProperty(PropertyoperatingCompanyCurrency, ref _operatingCompanyCurrency, value); } }

		[SMEDecimalProperty(Label="PurchaseRequisition OperatingCompany Currency Exchange Rate", Nillable=true, Name="operatingCompanyCurrencyExchangeRate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> operatingCompanyCurrencyExchangeRate { get { return _operatingCompanyCurrencyExchangeRate; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRate, ref _operatingCompanyCurrencyExchangeRate, value); } }

		[SMEEnumProperty(EnumTypeName="RateOperator--enum", Label="PurchaseRequisition OperatingCompany Currency Exchange Rate Operator", Nillable=true, Name="operatingCompanyCurrencyExchangeRateOperator", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string operatingCompanyCurrencyExchangeRateOperator { get { return _operatingCompanyCurrencyExchangeRateOperator; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRateOperator, ref _operatingCompanyCurrencyExchangeRateOperator, value); } }

		[SMEDateProperty(Label="PurchaseRequisition OperatingCompany Currency Exchange Rate Date", Nillable=true, Name="operatingCompanyCurrencyExchangeRateDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> operatingCompanyCurrencyExchangeRateDate { get { return _operatingCompanyCurrencyExchangeRateDate; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRateDate, ref _operatingCompanyCurrencyExchangeRateDate, value); } }

		[SMEStringProperty(Label="PurchaseRequisition Supplier TradingAccount Currency", Nillable=true, Name="supplierTradingAccountCurrency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String supplierTradingAccountCurrency { get { return _supplierTradingAccountCurrency; } set { SetProperty(PropertysupplierTradingAccountCurrency, ref _supplierTradingAccountCurrency, value); } }

		[SMEDecimalProperty(Label="PurchaseRequisition Supplier TradingAccount Currency Exchange Rate", Nillable=true, Name="supplierTradingAccountCurrencyExchangeRate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> supplierTradingAccountCurrencyExchangeRate { get { return _supplierTradingAccountCurrencyExchangeRate; } set { SetProperty(PropertysupplierTradingAccountCurrencyExchangeRate, ref _supplierTradingAccountCurrencyExchangeRate, value); } }

		[SMEEnumProperty(EnumTypeName="RateOperator--enum", Label="PurchaseRequisition Supplier TradingAccount Currency Exchange Rate Operator", Nillable=true, Name="supplierTradingAccountCurrencyExchangeRateOperator", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string supplierTradingAccountCurrencyExchangeRateOperator { get { return _supplierTradingAccountCurrencyExchangeRateOperator; } set { SetProperty(PropertysupplierTradingAccountCurrencyExchangeRateOperator, ref _supplierTradingAccountCurrencyExchangeRateOperator, value); } }

		[SMEDateProperty(Label="PurchaseRequisition Supplier TradingAccount Currency Exchange Rate Date", Nillable=true, Name="supplierTradingAccountCurrencyExchangeRateDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> supplierTradingAccountCurrencyExchangeRateDate { get { return _supplierTradingAccountCurrencyExchangeRateDate; } set { SetProperty(PropertysupplierTradingAccountCurrencyExchangeRateDate, ref _supplierTradingAccountCurrencyExchangeRateDate, value); } }

		[SMEDateProperty(Label="PurchaseRequisition Date", Name="date", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.DateTime date { get { return _date; } set { SetProperty(Propertydate, ref _date, value); } }

		[SMETimeProperty(Label="PurchaseRequisition Time", Nillable=true, Name="time", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> time { get { return _time; } set { SetProperty(Propertytime, ref _time, value); } }

		[SMEDecimalProperty(Label="PurchaseRequisition Validity", Nillable=true, Name="validity", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> validity { get { return _validity; } set { SetProperty(Propertyvalidity, ref _validity, value); } }

		[SMEDateProperty(Label="PurchaseRequisition Expiration Date", Nillable=true, Name="expirationDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> expirationDate { get { return _expirationDate; } set { SetProperty(PropertyexpirationDate, ref _expirationDate, value); } }

		[SMEDateProperty(Label="PurchaseRequisition Due Date", Nillable=true, Name="dueDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> dueDate { get { return _dueDate; } set { SetProperty(PropertydueDate, ref _dueDate, value); } }

		[SMEResource(CanGet=true, PluralName="taxCodes", Label="PurchaseRequisition Tax Code")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="PurchaseRequisition Tax Code", Name="taxCodes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual taxCodeFeed taxCodes { get { return _taxCodes; } set { SetProperty(PropertytaxCodes, ref _taxCodes, value); } }

		[SMEStringProperty(Label="PurchaseRequisition User", Nillable=true, Name="user", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String user { get { return _user; } set { SetProperty(Propertyuser, ref _user, value); } }

		[SMEStringProperty(Label="PurchaseRequisition Buyer", Nillable=true, Name="buyerUser", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String buyerUser { get { return _buyerUser; } set { SetProperty(PropertybuyerUser, ref _buyerUser, value); } }

		[SMEResource(CanGet=true, CanPost=true, PluralName="purchaseRequisitionLines", Label="PurchaseRequisition Line")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Label="PurchaseRequisition Line", Name="purchaseRequisitionLines", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseRequisitionLineFeed purchaseRequisitionLines { get { return _purchaseRequisitionLines; } set { SetProperty(PropertypurchaseRequisitionLines, ref _purchaseRequisitionLines, value); } }

		[SMEDecimalProperty(Label="PurchaseRequisition Line Count", Name="lineCount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal lineCount { get { return _lineCount; } set { SetProperty(PropertylineCount, ref _lineCount, value); } }

		[SMEEnumProperty(EnumTypeName="discountType--enum", Label="PurchaseRequisition Order Discount Type", Nillable=true, Name="orderDiscountType", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string orderDiscountType { get { return _orderDiscountType; } set { SetProperty(PropertyorderDiscountType, ref _orderDiscountType, value); } }

		[SMEDecimalProperty(Label="PurchaseRequisition Order Discount Amount", Nillable=true, Name="orderDiscountAmount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> orderDiscountAmount { get { return _orderDiscountAmount; } set { SetProperty(PropertyorderDiscountAmount, ref _orderDiscountAmount, value); } }

		[SMEDecimalProperty(Label="PurchaseRequisition Order Discount Percent", Nillable=true, Name="orderDiscountPercent", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> orderDiscountPercent { get { return _orderDiscountPercent; } set { SetProperty(PropertyorderDiscountPercent, ref _orderDiscountPercent, value); } }

		[SMEEnumProperty(EnumTypeName="discountType--enum", Label="PurchaseRequisition Order Additional Discount1 Type", Nillable=true, Name="orderAdditionalDiscount1Type", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string orderAdditionalDiscount1Type { get { return _orderAdditionalDiscount1Type; } set { SetProperty(PropertyorderAdditionalDiscount1Type, ref _orderAdditionalDiscount1Type, value); } }

		[SMEDecimalProperty(Label="PurchaseRequisition Order Additional Discount1 Amount", Nillable=true, Name="orderAdditionalDiscount1Amount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> orderAdditionalDiscount1Amount { get { return _orderAdditionalDiscount1Amount; } set { SetProperty(PropertyorderAdditionalDiscount1Amount, ref _orderAdditionalDiscount1Amount, value); } }

		[SMEDecimalProperty(Label="PurchaseRequisition Order Additional Discount1 Percent", Nillable=true, Name="orderAdditionalDiscount1Percent", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> orderAdditionalDiscount1Percent { get { return _orderAdditionalDiscount1Percent; } set { SetProperty(PropertyorderAdditionalDiscount1Percent, ref _orderAdditionalDiscount1Percent, value); } }

		[SMEEnumProperty(EnumTypeName="discountType--enum", Label="PurchaseRequisition Order Additional Discount2 Type", Nillable=true, Name="orderAdditionalDiscount2", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string orderAdditionalDiscount2 { get { return _orderAdditionalDiscount2; } set { SetProperty(PropertyorderAdditionalDiscount2, ref _orderAdditionalDiscount2, value); } }

		[SMEDecimalProperty(Label="PurchaseRequisition Order Additional Discount2 Amount", Nillable=true, Name="orderAdditionalDiscount2Amount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> orderAdditionalDiscount2Amount { get { return _orderAdditionalDiscount2Amount; } set { SetProperty(PropertyorderAdditionalDiscount2Amount, ref _orderAdditionalDiscount2Amount, value); } }

		[SMEDecimalProperty(Label="PurchaseRequisition Order Additional Discount2 Percent", Nillable=true, Name="orderAdditionalDiscount2Percent", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> orderAdditionalDiscount2Percent { get { return _orderAdditionalDiscount2Percent; } set { SetProperty(PropertyorderAdditionalDiscount2Percent, ref _orderAdditionalDiscount2Percent, value); } }

		[SMEStringProperty(Label="PurchaseRequisition Text1", Nillable=true, Name="text1", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String text1 { get { return _text1; } set { SetProperty(Propertytext1, ref _text1, value); } }

		[SMEStringProperty(Label="PurchaseRequisition Text2", Nillable=true, Name="text2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String text2 { get { return _text2; } set { SetProperty(Propertytext2, ref _text2, value); } }

		[SMEDecimalProperty(Label="PurchaseRequisition Net Total", Name="netTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal netTotal { get { return _netTotal; } set { SetProperty(PropertynetTotal, ref _netTotal, value); } }

		[SMEDecimalProperty(Label="PurchaseRequisition Discount Total", Name="discountTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal discountTotal { get { return _discountTotal; } set { SetProperty(PropertydiscountTotal, ref _discountTotal, value); } }

		[SMEDecimalProperty(Label="PurchaseRequisition Charges Total", Nillable=true, Name="chargesTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> chargesTotal { get { return _chargesTotal; } set { SetProperty(PropertychargesTotal, ref _chargesTotal, value); } }

		[SMEDecimalProperty(Label="PurchaseRequisition Tax Total", Name="taxTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal taxTotal { get { return _taxTotal; } set { SetProperty(PropertytaxTotal, ref _taxTotal, value); } }

		[SMEDecimalProperty(Label="PurchaseRequisition Gross Total", Name="grossTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal grossTotal { get { return _grossTotal; } set { SetProperty(PropertygrossTotal, ref _grossTotal, value); } }

		[SMEStringProperty(Label="PurchaseRequisition Contract", Nillable=true, Name="contract", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String contract { get { return _contract; } set { SetProperty(Propertycontract, ref _contract, value); } }

		[SMEResource(CanGet=true, PluralName="projects", Label="PurchaseRequisition Project")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="PurchaseRequisition Project", Name="projects", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual projectFeed projects { get { return _projects; } set { SetProperty(Propertyprojects, ref _projects, value); } }

		[SMEResource(CanGet=true, PluralName="projectLines", Label="PurchaseRequisition ProjectLine")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="PurchaseRequisition ProjectLine", Name="projectLines", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual projectLineFeed projectLines { get { return _projectLines; } set { SetProperty(PropertyprojectLines, ref _projectLines, value); } }

		[SMEResource(CanGet=true, PluralName="financialAccounts", Label="PurchaseRequisition FinancialAccount")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="PurchaseRequisition FinancialAccount", Name="financialAccounts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual financialAccountFeed financialAccounts { get { return _financialAccounts; } set { SetProperty(PropertyfinancialAccounts, ref _financialAccounts, value); } }

		[SMEResource(CanGet=true, PluralName="interactions", Label="PurchaseRequisition Interaction")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="PurchaseRequisition Interaction", Name="interactions", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual interactionFeed interactions { get { return _interactions; } set { SetProperty(Propertyinteractions, ref _interactions, value); } }

		[SMEResource(CanGet=true, PluralName="notes")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Label="PurchaseRequisition Note", Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual noteFeed notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		#endregion


	}
}