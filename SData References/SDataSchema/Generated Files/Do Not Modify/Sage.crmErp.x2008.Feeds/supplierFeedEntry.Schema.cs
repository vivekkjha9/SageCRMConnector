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
	/// Defines a supplier feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("supplier", Namespace="http://schemas.sage.com/crmErp/2008")]
		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="suppliers")]
	public class supplierFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyid = "id";
		public const string Propertyactive = "active";
		public const string Propertydeleted = "deleted";
		public const string Propertylabel = "label";
		public const string Propertycompany = "company";
		public const string PropertytradingAccounts = "tradingAccounts";
		public const string PropertyuseTradingAccountData = "useTradingAccountData";
		public const string Propertyreference = "reference";
		public const string Propertyreference2 = "reference2";
		public const string PropertyoperatingCompany = "operatingCompany";
		public const string Propertystatus = "status";
		public const string PropertyownReference = "ownReference";
		public const string Propertyname = "name";
		public const string PropertyshortName = "shortName";
		public const string Propertytype = "type";
		public const string Propertygroup = "group";
		public const string PropertypostalAddresses = "postalAddresses";
		public const string Propertyphones = "phones";
		public const string Propertyemail = "email";
		public const string Propertywebsite = "website";
		public const string Propertycontacts = "contacts";
		public const string PropertydefaultFulfillmentLocation = "defaultFulfillmentLocation";
		public const string PropertybankAccounts = "bankAccounts";
		public const string Propertyinteractions = "interactions";
		public const string PropertypurchaseRequisitions = "purchaseRequisitions";
		public const string PropertypurchaseOrders = "purchaseOrders";
		public const string PropertypurchaseOrderDeliveries = "purchaseOrderDeliveries";
		public const string PropertypurchaseInvoices = "purchaseInvoices";
		public const string PropertypurchaseReturns = "purchaseReturns";
		public const string PropertypurchaseReturnDeliveries = "purchaseReturnDeliveries";
		public const string PropertypurchaseCredits = "purchaseCredits";
		public const string Propertypayments = "payments";
		public const string Propertyreceipts = "receipts";
		public const string Propertycases = "cases";
		public const string Propertynotes = "notes";

		#endregion

		#region Fields

		private System.String _id;
		private System.Boolean _active;
		private System.Boolean _deleted;
		private System.String _label;
		private companyFeedEntry _company;
		private tradingAccountFeed _tradingAccounts;
		private System.Boolean _useTradingAccountData;
		private System.String _reference;
		private System.String _reference2;
		private companyFeedEntry _operatingCompany;
		private System.String _status;
		private System.String _ownReference;
		private System.String _name;
		private System.String _shortName;
		private System.String _type;
		private supplierGroupFeed _group;
		private postalAddressFeed _postalAddresses;
		private phoneNumberFeed _phones;
		private emailFeed _email;
		private System.String _website;
		private contactFeed _contacts;
		private locationFeedEntry _defaultFulfillmentLocation;
		private bankAccountFeed _bankAccounts;
		private interactionFeed _interactions;
		private purchaseRequisitionFeed _purchaseRequisitions;
		private purchaseOrderFeed _purchaseOrders;
		private purchaseOrderDeliveryFeed _purchaseOrderDeliveries;
		private purchaseInvoiceFeed _purchaseInvoices;
		private purchaseReturnFeed _purchaseReturns;
		private purchaseReturnDeliveryFeed _purchaseReturnDeliveries;
		private purchaseCreditFeed _purchaseCredits;
		private paymentFeed _payments;
		private receiptFeed _receipts;
		private caseFeed _cases;
		private noteFeed _notes;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="supplierFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public supplierFeedEntrySchema()
		{
		}

		#region Properties


		[SMEStringProperty(Label="Supplier Application ID", Name="id", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual new System.String id { get { return _id; } set { SetProperty(Propertyid, ref _id, value); } }

		[SMEBoolProperty(Label="Supplier Active Flag", Name="active", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEBoolProperty(Label="Supplier Deleted", Name="deleted", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean deleted { get { return _deleted; } set { SetProperty(Propertydeleted, ref _deleted, value); } }

		[SMEStringProperty(Label="Supplier Label", Name="label", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String label { get { return _label; } set { SetProperty(Propertylabel, ref _label, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="companies")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Parent, Label="Supplier Company", Name="company", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("company")]			
		public virtual companyFeedEntry company { get { return _company; } set { SetProperty(Propertycompany, ref _company, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Label="Supplier TradingAccount", Name="tradingAccounts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual tradingAccountFeed tradingAccounts { get { return _tradingAccounts; } set { SetProperty(PropertytradingAccounts, ref _tradingAccounts, value); } }

		[SMEBoolProperty(Label="Supplier Use Trading Account Data", Name="useTradingAccountData", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean useTradingAccountData { get { return _useTradingAccountData; } set { SetProperty(PropertyuseTradingAccountData, ref _useTradingAccountData, value); } }

		[SMEStringProperty(Label="Supplier reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEStringProperty(Label="Supplier Reference2", Nillable=true, Name="reference2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="companies")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Supplier OperatingCompany", Name="operatingCompany", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("operatingCompany")]			
		public virtual companyFeedEntry operatingCompany { get { return _operatingCompany; } set { SetProperty(PropertyoperatingCompany, ref _operatingCompany, value); } }

		[SMEStringProperty(Label="Supplier Status", Nillable=true, Name="status", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String status { get { return _status; } set { SetProperty(Propertystatus, ref _status, value); } }

		[SMEStringProperty(Label="Supplier Own reference", Nillable=true, Name="ownReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String ownReference { get { return _ownReference; } set { SetProperty(PropertyownReference, ref _ownReference, value); } }

		[SMEStringProperty(Label="Supplier Name", Name="name", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String name { get { return _name; } set { SetProperty(Propertyname, ref _name, value); } }

		[SMEStringProperty(Label="Supplier Short Name", Nillable=true, Name="shortName", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String shortName { get { return _shortName; } set { SetProperty(PropertyshortName, ref _shortName, value); } }

		[SMEStringProperty(Label="Supplier Type", Name="type", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }

		[SMEResource(CanGet=true, PluralName="supplierGroups", Label="Supplier Group")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Supplier Group", Name="group", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual supplierGroupFeed group { get { return _group; } set { SetProperty(Propertygroup, ref _group, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="postalAddresses")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Supplier PostalAddress ", Name="postalAddresses", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual postalAddressFeed postalAddresses { get { return _postalAddresses; } set { SetProperty(PropertypostalAddresses, ref _postalAddresses, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="phoneNumbers", Label="Supplier Phone")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Supplier Phone", Name="phones", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual phoneNumberFeed phones { get { return _phones; } set { SetProperty(Propertyphones, ref _phones, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="emails", Label="Supplier Email")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Supplier Email", Name="email", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual emailFeed email { get { return _email; } set { SetProperty(Propertyemail, ref _email, value); } }

		[SMEStringProperty(Label="Supplier Web site", Nillable=true, Name="website", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String website { get { return _website; } set { SetProperty(Propertywebsite, ref _website, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="contacts", Label="Supplier Contact")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Supplier Contact", Name="contacts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual contactFeed contacts { get { return _contacts; } set { SetProperty(Propertycontacts, ref _contacts, value); } }

		[SMEResource(CanGet=true, PluralName="locations", Label="Supplier Default Fulfillment Location")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Supplier Default Fulfillment Location", Name="defaultFulfillmentLocation", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("defaultFulfillmentLocation")]			
		public virtual locationFeedEntry defaultFulfillmentLocation { get { return _defaultFulfillmentLocation; } set { SetProperty(PropertydefaultFulfillmentLocation, ref _defaultFulfillmentLocation, value); } }

		[SMEResource(CanGet=true, PluralName="bankAccounts", Label="Supplier BankAccount ")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Supplier BankAccount ", Name="bankAccounts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual bankAccountFeed bankAccounts { get { return _bankAccounts; } set { SetProperty(PropertybankAccounts, ref _bankAccounts, value); } }

		[SMEResource(CanGet=true, PluralName="interactions", Label="Supplier Interaction")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Supplier Interaction", Name="interactions", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual interactionFeed interactions { get { return _interactions; } set { SetProperty(Propertyinteractions, ref _interactions, value); } }

		[SMEResource(CanGet=true, CanPost=true, PluralName="purchaseRequisitions", Label="Supplier Purchase Requistion")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Supplier Purchase Requistion", Name="purchaseRequisitions", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseRequisitionFeed purchaseRequisitions { get { return _purchaseRequisitions; } set { SetProperty(PropertypurchaseRequisitions, ref _purchaseRequisitions, value); } }

		[SMEResource(CanGet=true, CanPost=true, PluralName="purchaseOrders", Label="Supplier Purchase Order")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Supplier Purchase Order", Name="purchaseOrders", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseOrderFeed purchaseOrders { get { return _purchaseOrders; } set { SetProperty(PropertypurchaseOrders, ref _purchaseOrders, value); } }

		[SMEResource(CanGet=true, PluralName="purchaseOrderDeliveries", Label="Supplier Purchase Order Delivery")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Supplier Purchase Order Delivery", Name="purchaseOrderDeliveries", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseOrderDeliveryFeed purchaseOrderDeliveries { get { return _purchaseOrderDeliveries; } set { SetProperty(PropertypurchaseOrderDeliveries, ref _purchaseOrderDeliveries, value); } }

		[SMEResource(CanGet=true, CanPost=true, PluralName="purchaseInvoices", Label="Supplier Purchase Invoice")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Supplier Purchase Invoice", Name="purchaseInvoices", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseInvoiceFeed purchaseInvoices { get { return _purchaseInvoices; } set { SetProperty(PropertypurchaseInvoices, ref _purchaseInvoices, value); } }

		[SMEResource(CanGet=true, PluralName="purchaseReturns", Label="Supplier Purchase Return")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Supplier Purchase Return", Name="purchaseReturns", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseReturnFeed purchaseReturns { get { return _purchaseReturns; } set { SetProperty(PropertypurchaseReturns, ref _purchaseReturns, value); } }

		[SMEResource(CanGet=true, PluralName="purchaseReturnDeliveries", Label="Supplier Purchase Return Delivery")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Supplier Purchase Return Delivery", Name="purchaseReturnDeliveries", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseReturnDeliveryFeed purchaseReturnDeliveries { get { return _purchaseReturnDeliveries; } set { SetProperty(PropertypurchaseReturnDeliveries, ref _purchaseReturnDeliveries, value); } }

		[SMEResource(CanGet=true, PluralName="purchaseCredits", Label="Supplier Purchase Credit")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Supplier Purchase Credit", Name="purchaseCredits", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseCreditFeed purchaseCredits { get { return _purchaseCredits; } set { SetProperty(PropertypurchaseCredits, ref _purchaseCredits, value); } }

		[SMEResource(CanGet=true, PluralName="payments", Label="Supplier Payment")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Supplier Payment", Name="payments", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual paymentFeed payments { get { return _payments; } set { SetProperty(Propertypayments, ref _payments, value); } }

		[SMEResource(CanGet=true, PluralName="receipts", Label="Supplier Receipt")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Supplier Receipt", Name="receipts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual receiptFeed receipts { get { return _receipts; } set { SetProperty(Propertyreceipts, ref _receipts, value); } }

		[SMEResource(CanGet=true, PluralName="cases", Label="Supplier Case")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Supplier Case", Name="cases", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual caseFeed cases { get { return _cases; } set { SetProperty(Propertycases, ref _cases, value); } }

		[SMEResource(CanGet=true, PluralName="notes")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Label="Supplier Note", Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual noteFeed notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		#endregion


	}
}