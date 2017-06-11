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
	/// Defines a company feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("company", Namespace="http://schemas.sage.com/crmErp/2008")]
		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="companies")]
	public class companyFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyid = "id";
		public const string Propertyactive = "active";
		public const string Propertydeleted = "deleted";
		public const string Propertylabel = "label";
		public const string Propertycustomer = "customer";
		public const string PropertyuseCustomerData = "useCustomerData";
		public const string Propertysupplier = "supplier";
		public const string PropertyuseSupplierData = "useSupplierData";
		public const string Propertyreference = "reference";
		public const string Propertyreference2 = "reference2";
		public const string PropertyoperatingCompany = "operatingCompany";
		public const string Propertystatus = "status";
		public const string Propertyname = "name";
		public const string PropertyshortName = "shortName";
		public const string Propertytype = "type";
		public const string Propertycurrency = "currency";
		public const string PropertypostalAddresses = "postalAddresses";
		public const string Propertyphones = "phones";
		public const string Propertyemails = "emails";
		public const string Propertywebsite = "website";
		public const string Propertycontacts = "contacts";
		public const string Propertyidentifier = "identifier";
		public const string PropertytaxLocale = "taxLocale";
		public const string PropertytaxReference = "taxReference";
		public const string PropertybankAccounts = "bankAccounts";
		public const string Propertyindustry = "industry";
		public const string Propertylanguage = "language";
		public const string PropertyassociatedChildCompanies = "associatedChildCompanies";
		public const string PropertyassociatedParentCompany = "associatedParentCompany";
		public const string Propertyinteractions = "interactions";
		public const string Propertyopportunities = "opportunities";
		public const string PropertysalesQuotations = "salesQuotations";
		public const string PropertysalesOrders = "salesOrders";
		public const string PropertysalesOrderDeliveries = "salesOrderDeliveries";
		public const string PropertysalesInvoices = "salesInvoices";
		public const string PropertysalesReturns = "salesReturns";
		public const string PropertysalesReturnDeliveries = "salesReturnDeliveries";
		public const string PropertysalesCredits = "salesCredits";
		public const string PropertypurchaseRequistions = "purchaseRequistions";
		public const string PropertypurchaseOrders = "purchaseOrders";
		public const string PropertypurchaseOrderDeliveries = "purchaseOrderDeliveries";
		public const string PropertypurchaseInvoices = "purchaseInvoices";
		public const string PropertypurchaseReturns = "purchaseReturns";
		public const string PropertypurchaseReturnDeliveries = "purchaseReturnDeliveries";
		public const string PropertypurchaseCredits = "purchaseCredits";
		public const string Propertyreceipts = "receipts";
		public const string Propertypayments = "payments";
		public const string Propertyprojects = "projects";
		public const string Propertycases = "cases";
		public const string Propertynotes = "notes";

		#endregion

		#region Fields

		private System.String _id;
		private System.Boolean _active;
		private System.Boolean _deleted;
		private System.String _label;
		private customerFeedEntry _customer;
		private System.Boolean _useCustomerData;
		private supplierFeedEntry _supplier;
		private System.Boolean _useSupplierData;
		private System.String _reference;
		private System.String _reference2;
		private companyFeedEntry _operatingCompany;
		private System.String _status;
		private System.String _name;
		private System.String _shortName;
		private string _type;
		private System.String _currency;
		private postalAddressFeed _postalAddresses;
		private phoneNumberFeed _phones;
		private emailFeed _emails;
		private System.String _website;
		private contactFeed _contacts;
		private System.String _identifier;
		private System.String _taxLocale;
		private System.String _taxReference;
		private bankAccountFeed _bankAccounts;
		private System.String _industry;
		private System.String _language;
		private companyFeed _associatedChildCompanies;
		private companyFeedEntry _associatedParentCompany;
		private interactionFeed _interactions;
		private opportunityFeed _opportunities;
		private salesQuotationFeed _salesQuotations;
		private salesOrderFeed _salesOrders;
		private salesOrderDeliveryFeed _salesOrderDeliveries;
		private salesInvoiceFeed _salesInvoices;
		private salesReturnFeed _salesReturns;
		private salesReturnDeliveryFeed _salesReturnDeliveries;
		private salesCreditFeed _salesCredits;
		private purchaseRequisitionFeed _purchaseRequistions;
		private purchaseOrderFeed _purchaseOrders;
		private purchaseOrderDeliveryFeed _purchaseOrderDeliveries;
		private purchaseInvoiceFeed _purchaseInvoices;
		private purchaseReturnFeed _purchaseReturns;
		private purchaseReturnDeliveryFeed _purchaseReturnDeliveries;
		private purchaseCreditFeed _purchaseCredits;
		private receiptFeed _receipts;
		private paymentFeed _payments;
		private projectFeed _projects;
		private caseFeed _cases;
		private noteFeed _notes;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="companyFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public companyFeedEntrySchema()
		{
		}

		#region Properties


		[SMEStringProperty(Label="Company Application ID", Name="id", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual new System.String id { get { return _id; } set { SetProperty(Propertyid, ref _id, value); } }

		[SMEBoolProperty(Label="Company Active Flag", Name="active", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEBoolProperty(Label="Company Deleted", Name="deleted", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean deleted { get { return _deleted; } set { SetProperty(Propertydeleted, ref _deleted, value); } }

		[SMEStringProperty(Label="Company Label", Name="label", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String label { get { return _label; } set { SetProperty(Propertylabel, ref _label, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="customers", Label="Company Customer")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, Label="Company Customer", Name="customer", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("customer")]			
		public virtual customerFeedEntry customer { get { return _customer; } set { SetProperty(Propertycustomer, ref _customer, value); } }

		[SMEBoolProperty(Label="Company Use Customer Data", Name="useCustomerData", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean useCustomerData { get { return _useCustomerData; } set { SetProperty(PropertyuseCustomerData, ref _useCustomerData, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="suppliers", Label="Company Supplier")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, Label="Company Supplier", Name="supplier", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("supplier")]			
		public virtual supplierFeedEntry supplier { get { return _supplier; } set { SetProperty(Propertysupplier, ref _supplier, value); } }

		[SMEBoolProperty(Label="Company Use Supplier Data", Name="useSupplierData", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean useSupplierData { get { return _useSupplierData; } set { SetProperty(PropertyuseSupplierData, ref _useSupplierData, value); } }

		[SMEStringProperty(Label="Company reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEStringProperty(Label="Company Reference2", Nillable=true, Name="reference2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="companies", Label="Company OperatingCompany")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Company OperatingCompany", Name="operatingCompany", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("operatingCompany")]			
		public virtual companyFeedEntry operatingCompany { get { return _operatingCompany; } set { SetProperty(PropertyoperatingCompany, ref _operatingCompany, value); } }

		[SMEStringProperty(Label="Company Status", Nillable=true, Name="status", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String status { get { return _status; } set { SetProperty(Propertystatus, ref _status, value); } }

		[SMEStringProperty(Label="Company Name", Name="name", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String name { get { return _name; } set { SetProperty(Propertyname, ref _name, value); } }

		[SMEStringProperty(Label="Company Short Name", Nillable=true, Name="shortName", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String shortName { get { return _shortName; } set { SetProperty(PropertyshortName, ref _shortName, value); } }

		[SMEEnumProperty(EnumTypeName="companyType--enum", Label="Company Type", Name="type", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }

		[SMEStringProperty(Label="Company Currency", Nillable=true, Name="currency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String currency { get { return _currency; } set { SetProperty(Propertycurrency, ref _currency, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="postalAddresses", Label="Company PostalAddress")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Company PostalAddress", Name="postalAddresses", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual postalAddressFeed postalAddresses { get { return _postalAddresses; } set { SetProperty(PropertypostalAddresses, ref _postalAddresses, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="phoneNumbers", Label="Company Phone")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Company Phone", Name="phones", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual phoneNumberFeed phones { get { return _phones; } set { SetProperty(Propertyphones, ref _phones, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="emails", Label="Company Email")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Company Email", Name="emails", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual emailFeed emails { get { return _emails; } set { SetProperty(Propertyemails, ref _emails, value); } }

		[SMEStringProperty(Label="Company Web site", Nillable=true, Name="website", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String website { get { return _website; } set { SetProperty(Propertywebsite, ref _website, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="contacts", Label="Company Contact")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Company Contact", Name="contacts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual contactFeed contacts { get { return _contacts; } set { SetProperty(Propertycontacts, ref _contacts, value); } }

		[SMEStringProperty(Label="Company Identifier", Nillable=true, Name="identifier", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual System.String identifier { get { return _identifier; } set { SetProperty(Propertyidentifier, ref _identifier, value); } }

		[SMEStringProperty(Label="Company Tax Locale", Name="taxLocale", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String taxLocale { get { return _taxLocale; } set { SetProperty(PropertytaxLocale, ref _taxLocale, value); } }

		[SMEStringProperty(Label="Company Tax reference", Nillable=true, Name="taxReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual System.String taxReference { get { return _taxReference; } set { SetProperty(PropertytaxReference, ref _taxReference, value); } }

		[SMEResource(CanGet=true, PluralName="bankAccounts", Label="Company BankAccount ")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Company BankAccount ", Name="bankAccounts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual bankAccountFeed bankAccounts { get { return _bankAccounts; } set { SetProperty(PropertybankAccounts, ref _bankAccounts, value); } }

		[SMEStringProperty(Label="Company Industry", Nillable=true, Name="industry", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String industry { get { return _industry; } set { SetProperty(Propertyindustry, ref _industry, value); } }

		[SMEStringProperty(Label="Company Language", Nillable=true, Name="language", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String language { get { return _language; } set { SetProperty(Propertylanguage, ref _language, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="companies", Label="Associated child Company")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Label="Associated child Company", Name="associatedChildCompanies", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual companyFeed associatedChildCompanies { get { return _associatedChildCompanies; } set { SetProperty(PropertyassociatedChildCompanies, ref _associatedChildCompanies, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="companies", Label="Company Associated parent Company")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Parent, Label="Company Associated parent Company", Name="associatedParentCompany", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("associatedParentCompany")]			
		public virtual companyFeedEntry associatedParentCompany { get { return _associatedParentCompany; } set { SetProperty(PropertyassociatedParentCompany, ref _associatedParentCompany, value); } }

		[SMEResource(CanGet=true, PluralName="interactions", Label="Company Interaction")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Company Interaction", Name="interactions", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual interactionFeed interactions { get { return _interactions; } set { SetProperty(Propertyinteractions, ref _interactions, value); } }

		[SMEResource(CanGet=true, PluralName="opportunities", Label="Company Opportunity")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Company Opportunity", Name="opportunities", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual opportunityFeed opportunities { get { return _opportunities; } set { SetProperty(Propertyopportunities, ref _opportunities, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, PluralName="salesQuotations", Label="Company Sales Quotation")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Company Sales Quotation", Name="salesQuotations", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesQuotationFeed salesQuotations { get { return _salesQuotations; } set { SetProperty(PropertysalesQuotations, ref _salesQuotations, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, PluralName="salesOrders", Label="Company Sales Order")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Company Sales Order", Name="salesOrders", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesOrderFeed salesOrders { get { return _salesOrders; } set { SetProperty(PropertysalesOrders, ref _salesOrders, value); } }

		[SMEResource(CanGet=true, PluralName="salesOrderDeliveries", Label="Company Sales Order Delivery")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Company Sales Order Delivery", Name="salesOrderDeliveries", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesOrderDeliveryFeed salesOrderDeliveries { get { return _salesOrderDeliveries; } set { SetProperty(PropertysalesOrderDeliveries, ref _salesOrderDeliveries, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, PluralName="salesInvoices", Label="Company Sales Invoice")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Company Sales Invoice", Name="salesInvoices", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesInvoiceFeed salesInvoices { get { return _salesInvoices; } set { SetProperty(PropertysalesInvoices, ref _salesInvoices, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, PluralName="salesReturns", Label="Company Sales Return")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Company Sales Return", Name="salesReturns", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesReturnFeed salesReturns { get { return _salesReturns; } set { SetProperty(PropertysalesReturns, ref _salesReturns, value); } }

		[SMEResource(CanGet=true, PluralName="salesReturnDeliveries", Label="Company Sales Return Delivery")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Company Sales Return Delivery", Name="salesReturnDeliveries", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesReturnDeliveryFeed salesReturnDeliveries { get { return _salesReturnDeliveries; } set { SetProperty(PropertysalesReturnDeliveries, ref _salesReturnDeliveries, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, PluralName="salesCredits", Label="Company Sales Credit")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Company Sales Credit", Name="salesCredits", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesCreditFeed salesCredits { get { return _salesCredits; } set { SetProperty(PropertysalesCredits, ref _salesCredits, value); } }

		[SMEResource(CanGet=true, CanPost=true, PluralName="purchaseRequisitions", Label="Company Purchase Requisition")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Company Purchase Requisition", Name="purchaseRequistions", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseRequisitionFeed purchaseRequistions { get { return _purchaseRequistions; } set { SetProperty(PropertypurchaseRequistions, ref _purchaseRequistions, value); } }

		[SMEResource(CanGet=true, CanPost=true, PluralName="purchaseOrders", Label="Company Purchase Order")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Company Purchase Order", Name="purchaseOrders", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseOrderFeed purchaseOrders { get { return _purchaseOrders; } set { SetProperty(PropertypurchaseOrders, ref _purchaseOrders, value); } }

		[SMEResource(CanGet=true, PluralName="purchaseOrderDeliveries", Label="Company Purchase Order Delivery")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Company Purchase Order Delivery", Name="purchaseOrderDeliveries", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseOrderDeliveryFeed purchaseOrderDeliveries { get { return _purchaseOrderDeliveries; } set { SetProperty(PropertypurchaseOrderDeliveries, ref _purchaseOrderDeliveries, value); } }

		[SMEResource(CanGet=true, CanPost=true, PluralName="purchaseInvoices", Label="Company Purchase Invoice")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Company Purchase Invoice", Name="purchaseInvoices", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseInvoiceFeed purchaseInvoices { get { return _purchaseInvoices; } set { SetProperty(PropertypurchaseInvoices, ref _purchaseInvoices, value); } }

		[SMEResource(CanGet=true, PluralName="purchaseReturns", Label="Company Purchase Return")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Company Purchase Return", Name="purchaseReturns", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseReturnFeed purchaseReturns { get { return _purchaseReturns; } set { SetProperty(PropertypurchaseReturns, ref _purchaseReturns, value); } }

		[SMEResource(CanGet=true, PluralName="purchaseReturnDeliveries", Label="Company Purchase Return Delivery")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Company Purchase Return Delivery", Name="purchaseReturnDeliveries", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseReturnDeliveryFeed purchaseReturnDeliveries { get { return _purchaseReturnDeliveries; } set { SetProperty(PropertypurchaseReturnDeliveries, ref _purchaseReturnDeliveries, value); } }

		[SMEResource(CanGet=true, PluralName="purchaseCredits", Label="Company Purchase Credit")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Company Purchase Credit", Name="purchaseCredits", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseCreditFeed purchaseCredits { get { return _purchaseCredits; } set { SetProperty(PropertypurchaseCredits, ref _purchaseCredits, value); } }

		[SMEResource(CanGet=true, PluralName="receipts", Label="Company Receipt")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Company Receipt", Name="receipts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual receiptFeed receipts { get { return _receipts; } set { SetProperty(Propertyreceipts, ref _receipts, value); } }

		[SMEResource(CanGet=true, PluralName="payments", Label="Company Payment")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Company Payment", Name="payments", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual paymentFeed payments { get { return _payments; } set { SetProperty(Propertypayments, ref _payments, value); } }

		[SMEResource(CanGet=true, PluralName="projects", Label="Company Project")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Company Project", Name="projects", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual projectFeed projects { get { return _projects; } set { SetProperty(Propertyprojects, ref _projects, value); } }

		[SMEResource(CanGet=true, PluralName="cases", Label="Company Case")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Company Case", Name="cases", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual caseFeed cases { get { return _cases; } set { SetProperty(Propertycases, ref _cases, value); } }

		[SMEResource(CanGet=true, PluralName="notes", Label="Company Note")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Label="Company Note", Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual noteFeed notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		#endregion


	}
}