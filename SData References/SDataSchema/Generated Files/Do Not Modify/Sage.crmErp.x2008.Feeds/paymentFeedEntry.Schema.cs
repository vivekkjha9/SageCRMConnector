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
	/// Defines a payment feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("payment", Namespace="http://schemas.sage.com/crmErp/2008")]
		[SMEResource(CanGet=true, PluralName="payments")]
	public class paymentFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyid = "id";
		public const string Propertyactive = "active";
		public const string Propertydeleted = "deleted";
		public const string Propertylabel = "label";
		public const string Propertytype = "type";
		public const string PropertybankAccount = "bankAccount";
		public const string Propertysource = "source";
		public const string Propertystatus = "status";
		public const string PropertytenderType = "tenderType";
		public const string PropertytenderReference = "tenderReference";
		public const string PropertyexternalReference = "externalReference";
		public const string Propertyreference = "reference";
		public const string Propertyreference2 = "reference2";
		public const string PropertyoperatingCompany = "operatingCompany";
		public const string Propertydate = "date";
		public const string PropertyprocessDate = "processDate";
		public const string Propertycompany = "company";
		public const string PropertycustomerSupplierFlag = "customerSupplierFlag";
		public const string Propertycustomer = "customer";
		public const string Propertysupplier = "supplier";
		public const string PropertytradingAccount = "tradingAccount";
		public const string PropertyoriginatorDocument = "originatorDocument";
		public const string PropertytaxCode = "taxCode";
		public const string Propertyuser = "user";
		public const string Propertycurrency = "currency";
		public const string PropertyoperatingCompanyCurrency = "operatingCompanyCurrency";
		public const string PropertyoperatingCompanyCurrencyExchangeRate = "operatingCompanyCurrencyExchangeRate";
		public const string PropertyoperatingCompanyCurrencyExchangeRateOperator = "operatingCompanyCurrencyExchangeRateOperator";
		public const string PropertyoperatingCompanyCurrencyExchangeRateDate = "operatingCompanyCurrencyExchangeRateDate";
		public const string PropertybankAccountCurrency = "bankAccountCurrency";
		public const string PropertybankAccountCurrencyExchangeRate = "bankAccountCurrencyExchangeRate";
		public const string PropertybankAccountCurrencyExchangeRateOperator = "bankAccountCurrencyExchangeRateOperator";
		public const string PropertybankAccountCurrencyExchangeRateDate = "bankAccountCurrencyExchangeRateDate";
		public const string PropertybalanceBefore = "balanceBefore";
		public const string PropertybalanceAfter = "balanceAfter";
		public const string PropertydiscountTotal = "discountTotal";
		public const string PropertychargesTotal = "chargesTotal";
		public const string PropertytaxTotal = "taxTotal";
		public const string PropertygrossTotal = "grossTotal";
		public const string PropertynetTotal = "netTotal";
		public const string Propertyname = "name";
		public const string Propertydescription = "description";
		public const string Propertytext1 = "text1";
		public const string Propertytext2 = "text2";
		public const string PropertypaymentLines = "paymentLines";
		public const string PropertylineCount = "lineCount";
		public const string PropertyfinancialAccounts = "financialAccounts";
		public const string Propertyprojects = "projects";
		public const string PropertyprojectLines = "projectLines";
		public const string Propertyinteractions = "interactions";
		public const string Propertynotes = "notes";

		#endregion

		#region Fields

		private System.String _id;
		private System.Boolean _active;
		private System.Boolean _deleted;
		private System.String _label;
		private System.String _type;
		private bankAccountFeedEntry _bankAccount;
		private System.String _source;
		private System.String _status;
		private System.String _tenderType;
		private System.String _tenderReference;
		private System.String _externalReference;
		private System.String _reference;
		private System.String _reference2;
		private companyFeedEntry _operatingCompany;
		private Nullable<System.DateTime> _date;
		private Nullable<System.DateTime> _processDate;
		private companyFeedEntry _company;
		private System.String _customerSupplierFlag;
		private customerFeedEntry _customer;
		private supplierFeedEntry _supplier;
		private tradingAccountFeedEntry _tradingAccount;
		private purchaseInvoiceFeed _originatorDocument;
		private taxCodeFeed _taxCode;
		private System.String _user;
		private System.String _currency;
		private System.String _operatingCompanyCurrency;
		private Nullable<System.Decimal> _operatingCompanyCurrencyExchangeRate;
		private string _operatingCompanyCurrencyExchangeRateOperator;
		private Nullable<System.DateTime> _operatingCompanyCurrencyExchangeRateDate;
		private System.String _bankAccountCurrency;
		private Nullable<System.Decimal> _bankAccountCurrencyExchangeRate;
		private string _bankAccountCurrencyExchangeRateOperator;
		private Nullable<System.DateTime> _bankAccountCurrencyExchangeRateDate;
		private Nullable<System.Decimal> _balanceBefore;
		private Nullable<System.Decimal> _balanceAfter;
		private Nullable<System.Decimal> _discountTotal;
		private Nullable<System.Decimal> _chargesTotal;
		private Nullable<System.Decimal> _taxTotal;
		private Nullable<System.Decimal> _grossTotal;
		private Nullable<System.Decimal> _netTotal;
		private System.String _name;
		private System.String _description;
		private System.String _text1;
		private System.String _text2;
		private paymentLineFeed _paymentLines;
		private Nullable<System.Decimal> _lineCount;
		private financialAccountFeed _financialAccounts;
		private projectFeed _projects;
		private projectLineFeed _projectLines;
		private interactionFeed _interactions;
		private noteFeed _notes;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="paymentFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public paymentFeedEntrySchema()
		{
		}

		#region Properties


		[SMEStringProperty(Label="Payment Application ID", Name="id", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual new System.String id { get { return _id; } set { SetProperty(Propertyid, ref _id, value); } }

		[SMEBoolProperty(Label="Payment Active Flag", Name="active", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEBoolProperty(Label="Payment Deleted", Name="deleted", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean deleted { get { return _deleted; } set { SetProperty(Propertydeleted, ref _deleted, value); } }

		[SMEStringProperty(Label="Payment Label", Name="label", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String label { get { return _label; } set { SetProperty(Propertylabel, ref _label, value); } }

		[SMEStringProperty(Label="Payment Type", Nillable=true, Name="type", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }

		[SMEResource(CanGet=true, PluralName="bankAccounts", Label="Payment BankAccount")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Payment BankAccount", Name="bankAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("bankAccount")]			
		public virtual bankAccountFeedEntry bankAccount { get { return _bankAccount; } set { SetProperty(PropertybankAccount, ref _bankAccount, value); } }

		[SMEStringProperty(Label="Payment Source", Nillable=true, Name="source", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual new System.String source { get { return _source; } set { SetProperty(Propertysource, ref _source, value); } }

		[SMEStringProperty(Label="Payment Status", Nillable=true, Name="status", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String status { get { return _status; } set { SetProperty(Propertystatus, ref _status, value); } }

		[SMEStringProperty(Label="Payment Tender Type", Nillable=true, Name="tenderType", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String tenderType { get { return _tenderType; } set { SetProperty(PropertytenderType, ref _tenderType, value); } }

		[SMEStringProperty(Label="Payment Tender reference", Nillable=true, Name="tenderReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String tenderReference { get { return _tenderReference; } set { SetProperty(PropertytenderReference, ref _tenderReference, value); } }

		[SMEStringProperty(Label="Payment Tender External reference", Nillable=true, Name="externalReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String externalReference { get { return _externalReference; } set { SetProperty(PropertyexternalReference, ref _externalReference, value); } }

		[SMEStringProperty(Label="Payment reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEStringProperty(Label="Payment Reference2", Nillable=true, Name="reference2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="companies")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Payment OperatingCompany", Name="operatingCompany", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("operatingCompany")]			
		public virtual companyFeedEntry operatingCompany { get { return _operatingCompany; } set { SetProperty(PropertyoperatingCompany, ref _operatingCompany, value); } }

		[SMEDateProperty(Label="Payment Date", Nillable=true, Name="date", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> date { get { return _date; } set { SetProperty(Propertydate, ref _date, value); } }

		[SMEDateProperty(Label="Payment Process Date", Nillable=true, Name="processDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> processDate { get { return _processDate; } set { SetProperty(PropertyprocessDate, ref _processDate, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="companies")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Payment Company", Name="company", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("company")]			
		public virtual companyFeedEntry company { get { return _company; } set { SetProperty(Propertycompany, ref _company, value); } }

		[SMEStringProperty(Label="Payment Customer Supplier Flag", Nillable=true, Name="customerSupplierFlag", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String customerSupplierFlag { get { return _customerSupplierFlag; } set { SetProperty(PropertycustomerSupplierFlag, ref _customerSupplierFlag, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="customers")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Payment Customer", Name="customer", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("customer")]			
		public virtual customerFeedEntry customer { get { return _customer; } set { SetProperty(Propertycustomer, ref _customer, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="suppliers")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Payment Supplier", Name="supplier", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("supplier")]			
		public virtual supplierFeedEntry supplier { get { return _supplier; } set { SetProperty(Propertysupplier, ref _supplier, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Payment TradingAccount", Name="tradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("tradingAccount")]			
		public virtual tradingAccountFeedEntry tradingAccount { get { return _tradingAccount; } set { SetProperty(PropertytradingAccount, ref _tradingAccount, value); } }

		[SMEResource(CanGet=true, CanPost=true, PluralName="purchaseInvoices", Label="Payment Originator Document reference")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Payment Originator Document reference", Name="originatorDocument", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseInvoiceFeed originatorDocument { get { return _originatorDocument; } set { SetProperty(PropertyoriginatorDocument, ref _originatorDocument, value); } }

		[SMEResource(CanGet=true, PluralName="taxCodes", Label="Payment Tax Code")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Payment Tax Code", Name="taxCode", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual taxCodeFeed taxCode { get { return _taxCode; } set { SetProperty(PropertytaxCode, ref _taxCode, value); } }

		[SMEStringProperty(Label="Payment User", Nillable=true, Name="user", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String user { get { return _user; } set { SetProperty(Propertyuser, ref _user, value); } }

		[SMEStringProperty(Label="Payment Currency", Name="currency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String currency { get { return _currency; } set { SetProperty(Propertycurrency, ref _currency, value); } }

		[SMEStringProperty(Label="Payment OperatingCompany Currency", Name="operatingCompanyCurrency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String operatingCompanyCurrency { get { return _operatingCompanyCurrency; } set { SetProperty(PropertyoperatingCompanyCurrency, ref _operatingCompanyCurrency, value); } }

		[SMEDecimalProperty(Label="Payment OperatingCompany Currency Exchange Rate", Nillable=true, Name="operatingCompanyCurrencyExchangeRate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> operatingCompanyCurrencyExchangeRate { get { return _operatingCompanyCurrencyExchangeRate; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRate, ref _operatingCompanyCurrencyExchangeRate, value); } }

		[SMEEnumProperty(EnumTypeName="RateOperator--enum", Label="Payment OperatingCompany Currency Exchange Rate Operator", Nillable=true, Name="operatingCompanyCurrencyExchangeRateOperator", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string operatingCompanyCurrencyExchangeRateOperator { get { return _operatingCompanyCurrencyExchangeRateOperator; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRateOperator, ref _operatingCompanyCurrencyExchangeRateOperator, value); } }

		[SMEDateProperty(Label="Payment OperatingCompany Currency Exchange Rate Date", Nillable=true, Name="operatingCompanyCurrencyExchangeRateDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> operatingCompanyCurrencyExchangeRateDate { get { return _operatingCompanyCurrencyExchangeRateDate; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRateDate, ref _operatingCompanyCurrencyExchangeRateDate, value); } }

		[SMEStringProperty(Label="Payment Bank Account Currency", Name="bankAccountCurrency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String bankAccountCurrency { get { return _bankAccountCurrency; } set { SetProperty(PropertybankAccountCurrency, ref _bankAccountCurrency, value); } }

		[SMEDecimalProperty(Label="Payment Bank Account Currency Exchange Rate", Nillable=true, Name="bankAccountCurrencyExchangeRate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> bankAccountCurrencyExchangeRate { get { return _bankAccountCurrencyExchangeRate; } set { SetProperty(PropertybankAccountCurrencyExchangeRate, ref _bankAccountCurrencyExchangeRate, value); } }

		[SMEEnumProperty(EnumTypeName="RateOperator--enum", Label="Payment Bank Account Currency Exchange Rate Operator", Nillable=true, Name="bankAccountCurrencyExchangeRateOperator", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string bankAccountCurrencyExchangeRateOperator { get { return _bankAccountCurrencyExchangeRateOperator; } set { SetProperty(PropertybankAccountCurrencyExchangeRateOperator, ref _bankAccountCurrencyExchangeRateOperator, value); } }

		[SMEDateProperty(Label="Payment Bank Account Currency Exchange Rate Date", Nillable=true, Name="bankAccountCurrencyExchangeRateDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> bankAccountCurrencyExchangeRateDate { get { return _bankAccountCurrencyExchangeRateDate; } set { SetProperty(PropertybankAccountCurrencyExchangeRateDate, ref _bankAccountCurrencyExchangeRateDate, value); } }

		[SMEDecimalProperty(Label="Payment BankAccount Balance Before", Nillable=true, Name="balanceBefore", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> balanceBefore { get { return _balanceBefore; } set { SetProperty(PropertybalanceBefore, ref _balanceBefore, value); } }

		[SMEDecimalProperty(Label="Payment BankAccount Balance After", Nillable=true, Name="balanceAfter", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> balanceAfter { get { return _balanceAfter; } set { SetProperty(PropertybalanceAfter, ref _balanceAfter, value); } }

		[SMEDecimalProperty(Label="Payment Discount Total", Nillable=true, Name="discountTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> discountTotal { get { return _discountTotal; } set { SetProperty(PropertydiscountTotal, ref _discountTotal, value); } }

		[SMEDecimalProperty(Label="Payment Charges Total", Nillable=true, Name="chargesTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> chargesTotal { get { return _chargesTotal; } set { SetProperty(PropertychargesTotal, ref _chargesTotal, value); } }

		[SMEDecimalProperty(Label="Payment Tax Total", Nillable=true, Name="taxTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> taxTotal { get { return _taxTotal; } set { SetProperty(PropertytaxTotal, ref _taxTotal, value); } }

		[SMEDecimalProperty(Label="Payment Gross Total", Nillable=true, Name="grossTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> grossTotal { get { return _grossTotal; } set { SetProperty(PropertygrossTotal, ref _grossTotal, value); } }

		[SMEDecimalProperty(Label="Payment Net Total", Nillable=true, Name="netTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> netTotal { get { return _netTotal; } set { SetProperty(PropertynetTotal, ref _netTotal, value); } }

		[SMEStringProperty(Label="Payment Name", Nillable=true, Name="name", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String name { get { return _name; } set { SetProperty(Propertyname, ref _name, value); } }

		[SMEStringProperty(Label="Payment Description", Nillable=true, Name="description", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String description { get { return _description; } set { SetProperty(Propertydescription, ref _description, value); } }

		[SMEStringProperty(Label="Payment Text1", Nillable=true, Name="text1", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String text1 { get { return _text1; } set { SetProperty(Propertytext1, ref _text1, value); } }

		[SMEStringProperty(Label="Payment Text2", Nillable=true, Name="text2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String text2 { get { return _text2; } set { SetProperty(Propertytext2, ref _text2, value); } }

		[SMEResource(CanGet=true, PluralName="paymentLines", Label="PaymentLine")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Label="PaymentLine", Name="paymentLines", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual paymentLineFeed paymentLines { get { return _paymentLines; } set { SetProperty(PropertypaymentLines, ref _paymentLines, value); } }

		[SMEDecimalProperty(Label="Payment Line Count", Nillable=true, Name="lineCount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> lineCount { get { return _lineCount; } set { SetProperty(PropertylineCount, ref _lineCount, value); } }

		[SMEResource(CanGet=true, PluralName="financialAccounts", Label="Payment FinancialAccount")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Payment FinancialAccount", Name="financialAccounts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual financialAccountFeed financialAccounts { get { return _financialAccounts; } set { SetProperty(PropertyfinancialAccounts, ref _financialAccounts, value); } }

		[SMEResource(CanGet=true, PluralName="projects", Label="Payment Project")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Payment Project", Name="projects", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual projectFeed projects { get { return _projects; } set { SetProperty(Propertyprojects, ref _projects, value); } }

		[SMEResource(CanGet=true, PluralName="projectLines", Label="Payment ProjectLine")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Payment ProjectLine", Name="projectLines", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual projectLineFeed projectLines { get { return _projectLines; } set { SetProperty(PropertyprojectLines, ref _projectLines, value); } }

		[SMEResource(CanGet=true, PluralName="interactions", Label="Payment Interaction")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Payment Interaction", Name="interactions", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual interactionFeed interactions { get { return _interactions; } set { SetProperty(Propertyinteractions, ref _interactions, value); } }

		[SMEResource(CanGet=true, PluralName="notes")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Label="Payment Note", Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual noteFeed notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		#endregion


	}
}