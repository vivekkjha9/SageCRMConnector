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
	/// Defines a contact feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("contact", Namespace="http://schemas.sage.com/crmErp/2008")]
		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="contacts")]
	public class contactFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyid = "id";
		public const string PropertycontactGroups = "contactGroups";
		public const string Propertyactive = "active";
		public const string Propertydeleted = "deleted";
		public const string Propertylabel = "label";
		public const string Propertyreference = "reference";
		public const string Propertyreference2 = "reference2";
		public const string PropertyoperatingCompany = "operatingCompany";
		public const string Propertystatus = "status";
		public const string Propertytype = "type";
		public const string Propertygender = "gender";
		public const string PropertyfullName = "fullName";
		public const string Propertysalutation = "salutation";
		public const string PropertyfirstName = "firstName";
		public const string PropertypreferredName = "preferredName";
		public const string PropertyfamilyName = "familyName";
		public const string Propertytitle = "title";
		public const string PropertymiddleName = "middleName";
		public const string Propertysuffix = "suffix";
		public const string PropertyfinancialAccounts = "financialAccounts";
		public const string Propertyage = "age";
		public const string PropertydateOfBirth = "dateOfBirth";
		public const string Propertynationality = "nationality";
		public const string Propertylanguage = "language";
		public const string PropertymaritalStatus = "maritalStatus";
		public const string PropertycountryOfResidence = "countryOfResidence";
		public const string PropertynationalInsuranceNumber = "nationalInsuranceNumber";
		public const string PropertytaxReference = "taxReference";
		public const string PropertypostalAddresses = "postalAddresses";
		public const string Propertyphones = "phones";
		public const string Propertyemails = "emails";
		public const string Propertywebsite = "website";
		public const string Propertycompany = "company";
		public const string Propertycustomer = "customer";
		public const string Propertysupplier = "supplier";
		public const string PropertytradingAccount = "tradingAccount";
		public const string PropertybankAccounts = "bankAccounts";
		public const string Propertylocation = "location";
		public const string PropertyjobTitle = "jobTitle";
		public const string PropertycompanyContext = "companyContext";
		public const string Propertyuser = "user";
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
		public const string Propertyinteractions = "interactions";
		public const string Propertyprojects = "projects";
		public const string Propertycases = "cases";
		public const string Propertynotes = "notes";

		#endregion

		#region Fields

		private System.String _id;
		private contactGroupFeed _contactGroups;
		private System.Boolean _active;
		private System.Boolean _deleted;
		private System.String _label;
		private System.String _reference;
		private System.String _reference2;
		private companyFeedEntry _operatingCompany;
		private System.String _status;
		private System.String _type;
		private System.String _gender;
		private System.String _fullName;
		private System.String _salutation;
		private System.String _firstName;
		private System.String _preferredName;
		private System.String _familyName;
		private System.String _title;
		private System.String _middleName;
		private System.String _suffix;
		private financialAccountFeed _financialAccounts;
		private Nullable<System.Decimal> _age;
		private Nullable<System.DateTime> _dateOfBirth;
		private System.String _nationality;
		private System.String _language;
		private System.String _maritalStatus;
		private System.String _countryOfResidence;
		private System.String _nationalInsuranceNumber;
		private System.String _taxReference;
		private postalAddressFeed _postalAddresses;
		private phoneNumberFeed _phones;
		private emailFeed _emails;
		private System.String _website;
		private companyFeedEntry _company;
		private customerFeedEntry _customer;
		private supplierFeedEntry _supplier;
		private tradingAccountFeedEntry _tradingAccount;
		private bankAccountFeed _bankAccounts;
		private locationFeedEntry _location;
		private System.String _jobTitle;
		private string _companyContext;
		private System.String _user;
		private System.Boolean _primacyIndicator;
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
		private interactionFeed _interactions;
		private projectFeed _projects;
		private caseFeed _cases;
		private noteFeed _notes;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="contactFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public contactFeedEntrySchema()
		{
		}

		#region Properties


		[SMEStringProperty(Label="Contact Application ID", Name="id", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual new System.String id { get { return _id; } set { SetProperty(Propertyid, ref _id, value); } }

		[SMEResource(CanGet=true, PluralName="contactGroups", Label="Contact ContactGroup")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Contact ContactGroup", Name="contactGroups", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual contactGroupFeed contactGroups { get { return _contactGroups; } set { SetProperty(PropertycontactGroups, ref _contactGroups, value); } }

		[SMEBoolProperty(Label="Contact Active Flag", Name="active", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEBoolProperty(Label="Contact Deleted", Name="deleted", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean deleted { get { return _deleted; } set { SetProperty(Propertydeleted, ref _deleted, value); } }

		[SMEStringProperty(Label="Contact Label", Name="label", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String label { get { return _label; } set { SetProperty(Propertylabel, ref _label, value); } }

		[SMEStringProperty(Label="Contact reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEStringProperty(Label="Contact Reference2", Nillable=true, Name="reference2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="companies")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Contact OperatingCompany", Name="operatingCompany", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("operatingCompany")]			
		public virtual companyFeedEntry operatingCompany { get { return _operatingCompany; } set { SetProperty(PropertyoperatingCompany, ref _operatingCompany, value); } }

		[SMEStringProperty(Label="Contact Status", Nillable=true, Name="status", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String status { get { return _status; } set { SetProperty(Propertystatus, ref _status, value); } }

		[SMEStringProperty(Label="Contact Type", Nillable=true, Name="type", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }

		[SMEStringProperty(Label="Contact Gender", Nillable=true, Name="gender", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String gender { get { return _gender; } set { SetProperty(Propertygender, ref _gender, value); } }

		[SMEStringProperty(Label="Contact Full Name", Name="fullName", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String fullName { get { return _fullName; } set { SetProperty(PropertyfullName, ref _fullName, value); } }

		[SMEStringProperty(Label="Contact Salutation", Nillable=true, Name="salutation", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String salutation { get { return _salutation; } set { SetProperty(Propertysalutation, ref _salutation, value); } }

		[SMEStringProperty(Label="Contact First Name", Nillable=true, Name="firstName", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String firstName { get { return _firstName; } set { SetProperty(PropertyfirstName, ref _firstName, value); } }

		[SMEStringProperty(Label="Contact Preferred Name", Nillable=true, Name="preferredName", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String preferredName { get { return _preferredName; } set { SetProperty(PropertypreferredName, ref _preferredName, value); } }

		[SMEStringProperty(Label="Contact Family Name", Nillable=true, Name="familyName", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String familyName { get { return _familyName; } set { SetProperty(PropertyfamilyName, ref _familyName, value); } }

		[SMEStringProperty(Label="Contact Title", Nillable=true, Name="title", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual new System.String title { get { return _title; } set { SetProperty(Propertytitle, ref _title, value); } }

		[SMEStringProperty(Label="Contact Middle Name", Nillable=true, Name="middleName", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String middleName { get { return _middleName; } set { SetProperty(PropertymiddleName, ref _middleName, value); } }

		[SMEStringProperty(Label="Contact Suffix", Nillable=true, Name="suffix", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String suffix { get { return _suffix; } set { SetProperty(Propertysuffix, ref _suffix, value); } }

		[SMEResource(CanGet=true, PluralName="financialAccounts", Label="Contact FinancialAccount")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Contact FinancialAccount", Name="financialAccounts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual financialAccountFeed financialAccounts { get { return _financialAccounts; } set { SetProperty(PropertyfinancialAccounts, ref _financialAccounts, value); } }

		[SMEDecimalProperty(Label="Contact Age", Nillable=true, Name="age", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> age { get { return _age; } set { SetProperty(Propertyage, ref _age, value); } }

		[SMEDateProperty(Label="Contact Date Of Birth", Nillable=true, Name="dateOfBirth", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> dateOfBirth { get { return _dateOfBirth; } set { SetProperty(PropertydateOfBirth, ref _dateOfBirth, value); } }

		[SMEStringProperty(Label="Contact Nationality", Nillable=true, Name="nationality", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String nationality { get { return _nationality; } set { SetProperty(Propertynationality, ref _nationality, value); } }

		[SMEStringProperty(Label="Contact Language", Nillable=true, Name="language", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String language { get { return _language; } set { SetProperty(Propertylanguage, ref _language, value); } }

		[SMEStringProperty(Label="Contact Marital Status", Nillable=true, Name="maritalStatus", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String maritalStatus { get { return _maritalStatus; } set { SetProperty(PropertymaritalStatus, ref _maritalStatus, value); } }

		[SMEStringProperty(Label="Contact Country of Residence", Nillable=true, Name="countryOfResidence", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String countryOfResidence { get { return _countryOfResidence; } set { SetProperty(PropertycountryOfResidence, ref _countryOfResidence, value); } }

		[SMEStringProperty(Label="Contact National Insurance Number", Nillable=true, Name="nationalInsuranceNumber", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String nationalInsuranceNumber { get { return _nationalInsuranceNumber; } set { SetProperty(PropertynationalInsuranceNumber, ref _nationalInsuranceNumber, value); } }

		[SMEStringProperty(Label="Contact Tax reference", Nillable=true, Name="taxReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String taxReference { get { return _taxReference; } set { SetProperty(PropertytaxReference, ref _taxReference, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="postalAddresses")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Contact PostalAddress", Name="postalAddresses", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual postalAddressFeed postalAddresses { get { return _postalAddresses; } set { SetProperty(PropertypostalAddresses, ref _postalAddresses, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="phoneNumbers", Label="Contact Phone")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Contact Phone", Name="phones", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual phoneNumberFeed phones { get { return _phones; } set { SetProperty(Propertyphones, ref _phones, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="emails", Label="Contact Email")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Contact Email", Name="emails", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual emailFeed emails { get { return _emails; } set { SetProperty(Propertyemails, ref _emails, value); } }

		[SMEStringProperty(Label="Contact Web site", Nillable=true, Name="website", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String website { get { return _website; } set { SetProperty(Propertywebsite, ref _website, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="companies")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Contact Company", Name="company", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("company")]			
		public virtual companyFeedEntry company { get { return _company; } set { SetProperty(Propertycompany, ref _company, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="customers")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Contact Customer", Name="customer", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("customer")]			
		public virtual customerFeedEntry customer { get { return _customer; } set { SetProperty(Propertycustomer, ref _customer, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="suppliers")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Contact Supplier", Name="supplier", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("supplier")]			
		public virtual supplierFeedEntry supplier { get { return _supplier; } set { SetProperty(Propertysupplier, ref _supplier, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Contact TradingAccount", Name="tradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("tradingAccount")]			
		public virtual tradingAccountFeedEntry tradingAccount { get { return _tradingAccount; } set { SetProperty(PropertytradingAccount, ref _tradingAccount, value); } }

		[SMEResource(CanGet=true, PluralName="bankAccounts", Label="Contact Bank Account")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Contact Bank Account", Name="bankAccounts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual bankAccountFeed bankAccounts { get { return _bankAccounts; } set { SetProperty(PropertybankAccounts, ref _bankAccounts, value); } }

		[SMEResource(CanGet=true, PluralName="locations", Label="Contact Location")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Contact Location", Name="location", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("location")]			
		public virtual locationFeedEntry location { get { return _location; } set { SetProperty(Propertylocation, ref _location, value); } }

		[SMEStringProperty(Label="Contact Job Title", Nillable=true, Name="jobTitle", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String jobTitle { get { return _jobTitle; } set { SetProperty(PropertyjobTitle, ref _jobTitle, value); } }

		[SMEEnumProperty(EnumTypeName="contactCompanyContext--enum", Label="Contact Company Context", Nillable=true, Name="companyContext", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string companyContext { get { return _companyContext; } set { SetProperty(PropertycompanyContext, ref _companyContext, value); } }

		[SMEStringProperty(Label="Contact User", Nillable=true, Name="user", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String user { get { return _user; } set { SetProperty(Propertyuser, ref _user, value); } }

		[SMEBoolProperty(Label="Contact Primacy Indicator", Name="primacyIndicator", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean primacyIndicator { get { return _primacyIndicator; } set { SetProperty(PropertyprimacyIndicator, ref _primacyIndicator, value); } }

		[SMEResource(CanGet=true, PluralName="opportunities", Label="Contact Opportunity")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Contact Opportunity", Name="opportunities", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual opportunityFeed opportunities { get { return _opportunities; } set { SetProperty(Propertyopportunities, ref _opportunities, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, PluralName="salesQuotations", Label="Contact Sales Quotation")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Contact Sales Quotation", Name="salesQuotations", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesQuotationFeed salesQuotations { get { return _salesQuotations; } set { SetProperty(PropertysalesQuotations, ref _salesQuotations, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, PluralName="salesOrders", Label="Contact Sales Order")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Contact Sales Order", Name="salesOrders", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesOrderFeed salesOrders { get { return _salesOrders; } set { SetProperty(PropertysalesOrders, ref _salesOrders, value); } }

		[SMEResource(CanGet=true, PluralName="salesOrderDeliveries", Label="Contact Sales Order Delivery")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Contact Sales Order Delivery", Name="salesOrderDeliveries", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesOrderDeliveryFeed salesOrderDeliveries { get { return _salesOrderDeliveries; } set { SetProperty(PropertysalesOrderDeliveries, ref _salesOrderDeliveries, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, PluralName="salesInvoices", Label="Contact Sales Invoice")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Contact Sales Invoice", Name="salesInvoices", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesInvoiceFeed salesInvoices { get { return _salesInvoices; } set { SetProperty(PropertysalesInvoices, ref _salesInvoices, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, PluralName="salesReturns", Label="Contact Sales Return")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Contact Sales Return", Name="salesReturns", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesReturnFeed salesReturns { get { return _salesReturns; } set { SetProperty(PropertysalesReturns, ref _salesReturns, value); } }

		[SMEResource(CanGet=true, PluralName="salesReturnDeliveries", Label="Contact Sales Return Delivery")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Contact Sales Return Delivery", Name="salesReturnDeliveries", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesReturnDeliveryFeed salesReturnDeliveries { get { return _salesReturnDeliveries; } set { SetProperty(PropertysalesReturnDeliveries, ref _salesReturnDeliveries, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, PluralName="salesCredits", Label="Contact Sales Credit")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Contact Sales Credit", Name="salesCredits", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesCreditFeed salesCredits { get { return _salesCredits; } set { SetProperty(PropertysalesCredits, ref _salesCredits, value); } }

		[SMEResource(CanGet=true, CanPost=true, PluralName="purchaseRequisitions", Label="Contact Purchase Requisition")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Contact Purchase Requisition", Name="purchaseRequisitions", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseRequisitionFeed purchaseRequisitions { get { return _purchaseRequisitions; } set { SetProperty(PropertypurchaseRequisitions, ref _purchaseRequisitions, value); } }

		[SMEResource(CanGet=true, CanPost=true, PluralName="purchaseOrders", Label="Contact Purchase Order")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Contact Purchase Order", Name="purchaseOrders", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseOrderFeed purchaseOrders { get { return _purchaseOrders; } set { SetProperty(PropertypurchaseOrders, ref _purchaseOrders, value); } }

		[SMEResource(CanGet=true, PluralName="purchaseOrderDeliveries", Label="Contact Purchase Order Delivery")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Contact Purchase Order Delivery", Name="purchaseOrderDeliveries", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseOrderDeliveryFeed purchaseOrderDeliveries { get { return _purchaseOrderDeliveries; } set { SetProperty(PropertypurchaseOrderDeliveries, ref _purchaseOrderDeliveries, value); } }

		[SMEResource(CanGet=true, CanPost=true, PluralName="purchaseInvoices", Label="Contact Purchase Invoice")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Contact Purchase Invoice", Name="purchaseInvoices", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseInvoiceFeed purchaseInvoices { get { return _purchaseInvoices; } set { SetProperty(PropertypurchaseInvoices, ref _purchaseInvoices, value); } }

		[SMEResource(CanGet=true, PluralName="purchaseReturns", Label="Contact Purchase Return")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Contact Purchase Return", Name="purchaseReturns", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseReturnFeed purchaseReturns { get { return _purchaseReturns; } set { SetProperty(PropertypurchaseReturns, ref _purchaseReturns, value); } }

		[SMEResource(CanGet=true, PluralName="purchaseReturnDeliveries", Label="Contact Purchase Return Delivery")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Contact Purchase Return Delivery", Name="purchaseReturnDeliveries", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseReturnDeliveryFeed purchaseReturnDeliveries { get { return _purchaseReturnDeliveries; } set { SetProperty(PropertypurchaseReturnDeliveries, ref _purchaseReturnDeliveries, value); } }

		[SMEResource(CanGet=true, PluralName="purchaseCredits", Label="Contact Purchase Credit")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Contact Purchase Credit", Name="purchaseCredits", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseCreditFeed purchaseCredits { get { return _purchaseCredits; } set { SetProperty(PropertypurchaseCredits, ref _purchaseCredits, value); } }

		[SMEResource(CanGet=true, PluralName="interactions", Label="Contact Interaction")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Contact Interaction", Name="interactions", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual interactionFeed interactions { get { return _interactions; } set { SetProperty(Propertyinteractions, ref _interactions, value); } }

		[SMEResource(CanGet=true, PluralName="projects", Label="Contact Project")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Contact Project", Name="projects", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual projectFeed projects { get { return _projects; } set { SetProperty(Propertyprojects, ref _projects, value); } }

		[SMEResource(CanGet=true, PluralName="cases", Label="Contact Case")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Contact Case", Name="cases", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual caseFeed cases { get { return _cases; } set { SetProperty(Propertycases, ref _cases, value); } }

		[SMEResource(CanGet=true, PluralName="notes")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Label="Contact Note", Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual noteFeed notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		#endregion


	}
}