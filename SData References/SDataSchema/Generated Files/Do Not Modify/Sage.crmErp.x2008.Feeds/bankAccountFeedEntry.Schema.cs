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
	/// Defines a bankAccount feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("bankAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[SMEResource(CanGet=true, PluralName="bankAccounts")]
	public class bankAccountFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyid = "id";
		public const string Propertyactive = "active";
		public const string Propertydeleted = "deleted";
		public const string Propertylabel = "label";
		public const string Propertytype = "type";
		public const string Propertyreference = "reference";
		public const string PropertyoperatingCompany = "operatingCompany";
		public const string Propertyname = "name";
		public const string Propertydescription = "description";
		public const string PropertybranchIdentifier = "branchIdentifier";
		public const string PropertyaccountNumber = "accountNumber";
		public const string PropertyiBANNumber = "iBANNumber";
		public const string PropertybICSwiftCode = "bICSwiftCode";
		public const string PropertyrollNumber = "rollNumber";
		public const string Propertycurrency = "currency";
		public const string PropertyoperatingCompanyCurrency = "operatingCompanyCurrency";
		public const string Propertycompany = "company";
		public const string PropertycustomerSupplierFlag = "customerSupplierFlag";
		public const string Propertycustomer = "customer";
		public const string Propertysupplier = "supplier";
		public const string PropertytradingAccount = "tradingAccount";
		public const string Propertycontacts = "contacts";
		public const string Propertyphones = "phones";
		public const string Propertyemails = "emails";
		public const string Propertywebsite = "website";
		public const string PropertypostalAddress = "postalAddress";
		public const string PropertycompanyReference = "companyReference";
		public const string PropertypaymentAllowedFlag = "paymentAllowedFlag";
		public const string PropertypaymentReference = "paymentReference";
		public const string PropertyreceiptAllowedFlag = "receiptAllowedFlag";
		public const string PropertyreceiptReference = "receiptReference";
		public const string Propertyreference2 = "reference2";
		public const string Propertybalance = "balance";
		public const string Propertylimit = "limit";
		public const string PropertyfinancialAccounts = "financialAccounts";
		public const string PropertylastStatementDate = "lastStatementDate";
		public const string PropertyprimacyIndicator = "primacyIndicator";
		public const string Propertynotes = "notes";

		#endregion

		#region Fields

		private System.String _id;
		private System.Boolean _active;
		private System.Boolean _deleted;
		private System.String _label;
		private System.String _type;
		private System.String _reference;
		private companyFeedEntry _operatingCompany;
		private System.String _name;
		private System.String _description;
		private System.String _branchIdentifier;
		private System.String _accountNumber;
		private System.String _iBANNumber;
		private System.String _bICSwiftCode;
		private System.String _rollNumber;
		private System.String _currency;
		private System.String _operatingCompanyCurrency;
		private companyFeedEntry _company;
		private string _customerSupplierFlag;
		private customerFeedEntry _customer;
		private supplierFeedEntry _supplier;
		private tradingAccountFeedEntry _tradingAccount;
		private contactFeed _contacts;
		private phoneNumberFeed _phones;
		private emailFeed _emails;
		private System.String _website;
		private postalAddressFeedEntry _postalAddress;
		private System.String _companyReference;
		private Nullable<System.Boolean> _paymentAllowedFlag;
		private System.String _paymentReference;
		private Nullable<System.Boolean> _receiptAllowedFlag;
		private System.String _receiptReference;
		private System.String _reference2;
		private System.Decimal _balance;
		private Nullable<System.Decimal> _limit;
		private financialAccountFeed _financialAccounts;
		private Nullable<System.DateTime> _lastStatementDate;
		private System.Boolean _primacyIndicator;
		private noteFeed _notes;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="bankAccountFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public bankAccountFeedEntrySchema()
		{
		}

		#region Properties


		[SMEStringProperty(Label="BankAccount Application ID", Name="id", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual new System.String id { get { return _id; } set { SetProperty(Propertyid, ref _id, value); } }

		[SMEBoolProperty(Label="BankAccount Active Flag", Name="active", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEBoolProperty(Label="BankAccount Deleted", Name="deleted", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean deleted { get { return _deleted; } set { SetProperty(Propertydeleted, ref _deleted, value); } }

		[SMEStringProperty(Label="BankAccount Label", Name="label", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String label { get { return _label; } set { SetProperty(Propertylabel, ref _label, value); } }

		[SMEStringProperty(Label="BankAccount Type", Nillable=true, Name="type", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }

		[SMEStringProperty(Label="BankAccount Reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="companies")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="BankAccount OperatingCompany", Name="operatingCompany", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("operatingCompany")]			
		public virtual companyFeedEntry operatingCompany { get { return _operatingCompany; } set { SetProperty(PropertyoperatingCompany, ref _operatingCompany, value); } }

		[SMEStringProperty(Label="BankAccount Name", Nillable=true, Name="name", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String name { get { return _name; } set { SetProperty(Propertyname, ref _name, value); } }

		[SMEStringProperty(Label="BankAccount Description", Nillable=true, Name="description", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String description { get { return _description; } set { SetProperty(Propertydescription, ref _description, value); } }

		[SMEStringProperty(Label="BankAccount Branch Identifier", Nillable=true, Name="branchIdentifier", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String branchIdentifier { get { return _branchIdentifier; } set { SetProperty(PropertybranchIdentifier, ref _branchIdentifier, value); } }

		[SMEStringProperty(Label="BankAccount Account Number", Nillable=true, Name="accountNumber", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String accountNumber { get { return _accountNumber; } set { SetProperty(PropertyaccountNumber, ref _accountNumber, value); } }

		[SMEStringProperty(Label="BankAccount IBAN Number", Nillable=true, Name="iBANNumber", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual System.String iBANNumber { get { return _iBANNumber; } set { SetProperty(PropertyiBANNumber, ref _iBANNumber, value); } }

		[SMEStringProperty(Label="BankAccount BIC Swift Code", Nillable=true, Name="bICSwiftCode", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String bICSwiftCode { get { return _bICSwiftCode; } set { SetProperty(PropertybICSwiftCode, ref _bICSwiftCode, value); } }

		[SMEStringProperty(Label="BankAccount Roll Number", Nillable=true, Name="rollNumber", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String rollNumber { get { return _rollNumber; } set { SetProperty(PropertyrollNumber, ref _rollNumber, value); } }

		[SMEStringProperty(Label="BankAccount Currency", Name="currency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String currency { get { return _currency; } set { SetProperty(Propertycurrency, ref _currency, value); } }

		[SMEStringProperty(Label="BankAccount OperatingCompany Currency", Name="operatingCompanyCurrency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String operatingCompanyCurrency { get { return _operatingCompanyCurrency; } set { SetProperty(PropertyoperatingCompanyCurrency, ref _operatingCompanyCurrency, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="companies")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="BankAccount Company", Name="company", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("company")]			
		public virtual companyFeedEntry company { get { return _company; } set { SetProperty(Propertycompany, ref _company, value); } }

		[SMEEnumProperty(EnumTypeName="supplierFlag--enum", Label="BankAccount Customer Supplier Flag", Name="customerSupplierFlag", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string customerSupplierFlag { get { return _customerSupplierFlag; } set { SetProperty(PropertycustomerSupplierFlag, ref _customerSupplierFlag, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="customers")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="BankAccount Customer", Name="customer", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("customer")]			
		public virtual customerFeedEntry customer { get { return _customer; } set { SetProperty(Propertycustomer, ref _customer, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="suppliers")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="BankAccount Supplier", Name="supplier", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("supplier")]			
		public virtual supplierFeedEntry supplier { get { return _supplier; } set { SetProperty(Propertysupplier, ref _supplier, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Bank Account Trading Account", Name="tradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("tradingAccount")]			
		public virtual tradingAccountFeedEntry tradingAccount { get { return _tradingAccount; } set { SetProperty(PropertytradingAccount, ref _tradingAccount, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="contacts", Label="BankAccount Contact")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="BankAccount Contact", Name="contacts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual contactFeed contacts { get { return _contacts; } set { SetProperty(Propertycontacts, ref _contacts, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="phoneNumbers", Label="BankAccount Phone")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="BankAccount Phone", Name="phones", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual phoneNumberFeed phones { get { return _phones; } set { SetProperty(Propertyphones, ref _phones, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="emails", Label="BankAccount Email")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="BankAccount Email", Name="emails", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual emailFeed emails { get { return _emails; } set { SetProperty(Propertyemails, ref _emails, value); } }

		[SMEStringProperty(Label="BankAccount Web site", Nillable=true, Name="website", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String website { get { return _website; } set { SetProperty(Propertywebsite, ref _website, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="postalAddresses")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="BankAccount Address", Name="postalAddress", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("postalAddress")]			
		public virtual postalAddressFeedEntry postalAddress { get { return _postalAddress; } set { SetProperty(PropertypostalAddress, ref _postalAddress, value); } }

		[SMEStringProperty(Label="BankAccount Company reference", Nillable=true, Name="companyReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String companyReference { get { return _companyReference; } set { SetProperty(PropertycompanyReference, ref _companyReference, value); } }

		[SMEBoolProperty(Label="BankAccount Payment Allowed Flag", Nillable=true, Name="paymentAllowedFlag", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Boolean> paymentAllowedFlag { get { return _paymentAllowedFlag; } set { SetProperty(PropertypaymentAllowedFlag, ref _paymentAllowedFlag, value); } }

		[SMEStringProperty(Label="BankAccount Payment reference", Nillable=true, Name="paymentReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String paymentReference { get { return _paymentReference; } set { SetProperty(PropertypaymentReference, ref _paymentReference, value); } }

		[SMEBoolProperty(Label="BankAccount Receipt Allowed Flag", Nillable=true, Name="receiptAllowedFlag", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Boolean> receiptAllowedFlag { get { return _receiptAllowedFlag; } set { SetProperty(PropertyreceiptAllowedFlag, ref _receiptAllowedFlag, value); } }

		[SMEStringProperty(Label="BankAccount Receipt reference", Nillable=true, Name="receiptReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String receiptReference { get { return _receiptReference; } set { SetProperty(PropertyreceiptReference, ref _receiptReference, value); } }

		[SMEStringProperty(Label="BankAccount Reference2", Nillable=true, Name="reference2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }

		[SMEDecimalProperty(Label="BankAccount Balance", Name="balance", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal balance { get { return _balance; } set { SetProperty(Propertybalance, ref _balance, value); } }

		[SMEDecimalProperty(Label="BankAccount Limit", Nillable=true, Name="limit", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> limit { get { return _limit; } set { SetProperty(Propertylimit, ref _limit, value); } }

		[SMEResource(CanGet=true, PluralName="financialAccounts", Label="BankAccount Financial Account")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="BankAccount Financial Account", Name="financialAccounts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual financialAccountFeed financialAccounts { get { return _financialAccounts; } set { SetProperty(PropertyfinancialAccounts, ref _financialAccounts, value); } }

		[SMEDateProperty(Label="BankAccount Last Statement Date", Nillable=true, Name="lastStatementDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> lastStatementDate { get { return _lastStatementDate; } set { SetProperty(PropertylastStatementDate, ref _lastStatementDate, value); } }

		[SMEBoolProperty(Label="BankAccount Primacy Indicator", Name="primacyIndicator", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean primacyIndicator { get { return _primacyIndicator; } set { SetProperty(PropertyprimacyIndicator, ref _primacyIndicator, value); } }

		[SMEResource(CanGet=true, PluralName="notes")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Label="BankAccount Note", Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual noteFeed notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		#endregion


	}
}