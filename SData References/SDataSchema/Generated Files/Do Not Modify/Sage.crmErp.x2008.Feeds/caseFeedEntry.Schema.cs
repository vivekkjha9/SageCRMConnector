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
	/// Defines a case feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("case", Namespace="http://schemas.sage.com/crmErp/2008")]
		[SMEResource(CanGet=true, PluralName="cases")]
	public class caseFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyuuid = "uuid";
		public const string Propertyid = "id";
		public const string Propertyactive = "active";
		public const string Propertydeleted = "deleted";
		public const string Propertylabel = "label";
		public const string Propertyreference = "reference";
		public const string Propertyreference2 = "reference2";
		public const string PropertyoperatingCompany = "operatingCompany";
		public const string Propertytype = "type";
		public const string Propertyname = "name";
		public const string Propertydescription = "description";
		public const string PropertyassociatedCase = "associatedCase";
		public const string Propertystatus = "status";
		public const string PropertycompletionStatus = "completionStatus";
		public const string PropertystartDate = "startDate";
		public const string PropertyendDate = "endDate";
		public const string PropertyoriginalEndDate = "originalEndDate";
		public const string PropertyforecastEndDate = "forecastEndDate";
		public const string Propertyduration = "duration";
		public const string Propertycompany = "company";
		public const string Propertycustomer = "customer";
		public const string PropertycustomerTradingAccount = "customerTradingAccount";
		public const string Propertycurrency = "currency";
		public const string PropertyoperatingCompanyCurrency = "operatingCompanyCurrency";
		public const string PropertyoperatingCompanyCurrencyExchangeRate = "operatingCompanyCurrencyExchangeRate";
		public const string PropertyoperatingCompanyCurrencyExchangeRateOperator = "operatingCompanyCurrencyExchangeRateOperator";
		public const string PropertyoperatingCompanyCurrencyExchangeRateDate = "operatingCompanyCurrencyExchangeRateDate";
		public const string PropertysalesOrder = "salesOrder";
		public const string PropertysalesOrderDeliveries = "salesOrderDeliveries";
		public const string PropertysalesInvoices = "salesInvoices";
		public const string PropertycurrentRevenueBalance = "currentRevenueBalance";
		public const string PropertylastRevenueTransactionDate = "lastRevenueTransactionDate";
		public const string Propertysupplier = "supplier";
		public const string PropertysupplierTradingAccount = "supplierTradingAccount";
		public const string PropertypurchaseOrder = "purchaseOrder";
		public const string PropertypurchaseOrderDeliveries = "purchaseOrderDeliveries";
		public const string PropertypurchaseInvoices = "purchaseInvoices";
		public const string PropertycurrentCostBalance = "currentCostBalance";
		public const string PropertylastCostTransactionDate = "lastCostTransactionDate";
		public const string Propertycontacts = "contacts";
		public const string Propertycommodity = "commodity";
		public const string PropertycommodityIdentifiers = "commodityIdentifiers";
		public const string Propertyproject = "project";
		public const string PropertyworkflowIndicator1 = "workflowIndicator1";
		public const string PropertyworkflowIndicator2 = "workflowIndicator2";
		public const string Propertycontract = "contract";
		public const string Propertypriority = "priority";
		public const string PropertyprivacyFlag = "privacyFlag";
		public const string Propertyinteractions = "interactions";
		public const string Propertynotes = "notes";

		#endregion

		#region Fields

		private string _uuid;
		private System.String _id;
		private System.Boolean _active;
		private System.Boolean _deleted;
		private System.String _label;
		private System.String _reference;
		private System.String _reference2;
		private companyFeedEntry _operatingCompany;
		private System.String _type;
		private System.String _name;
		private System.String _description;
		private caseFeed _associatedCase;
		private string _status;
		private System.String _completionStatus;
		private Nullable<System.DateTime> _startDate;
		private Nullable<System.DateTime> _endDate;
		private Nullable<System.DateTime> _originalEndDate;
		private Nullable<System.DateTime> _forecastEndDate;
		private Nullable<System.DateTime> _duration;
		private companyFeedEntry _company;
		private customerFeedEntry _customer;
		private tradingAccountFeedEntry _customerTradingAccount;
		private System.String _currency;
		private System.String _operatingCompanyCurrency;
		private Nullable<System.Decimal> _operatingCompanyCurrencyExchangeRate;
		private string _operatingCompanyCurrencyExchangeRateOperator;
		private Nullable<System.DateTime> _operatingCompanyCurrencyExchangeRateDate;
		private salesOrderFeed _salesOrder;
		private salesOrderDeliveryFeed _salesOrderDeliveries;
		private salesInvoiceFeed _salesInvoices;
		private Nullable<System.Decimal> _currentRevenueBalance;
		private Nullable<System.DateTime> _lastRevenueTransactionDate;
		private supplierFeedEntry _supplier;
		private tradingAccountFeedEntry _supplierTradingAccount;
		private purchaseOrderFeed _purchaseOrder;
		private purchaseOrderDeliveryFeed _purchaseOrderDeliveries;
		private purchaseInvoiceFeed _purchaseInvoices;
		private Nullable<System.Decimal> _currentCostBalance;
		private Nullable<System.DateTime> _lastCostTransactionDate;
		private contactFeed _contacts;
		private commodityFeedEntry _commodity;
		private commodityIdentifierFeed _commodityIdentifiers;
		private projectFeedEntry _project;
		private System.String _workflowIndicator1;
		private System.String _workflowIndicator2;
		private System.String _contract;
		private string _priority;
		private Nullable<System.Boolean> _privacyFlag;
		private interactionFeed _interactions;
		private noteFeed _notes;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="caseFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public caseFeedEntrySchema()
		{
		}

		#region Properties


		[SMEEnumProperty(EnumTypeName="uuid--type", Label="Case Global ID", Pattern="[0-9a-fA-F-]+", Name="uuid", Namespace="http://schemas.sage.com/crmErp/2008", IsUniqueKey=true)]			
		public virtual new string uuid { get { return _uuid; } set { SetProperty(Propertyuuid, ref _uuid, value); } }

		[SMEStringProperty(Label="Case Application ID", Name="id", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual new System.String id { get { return _id; } set { SetProperty(Propertyid, ref _id, value); } }

		[SMEBoolProperty(Label="Case Active Flag", Name="active", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEBoolProperty(Label="Case Deleted", Name="deleted", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean deleted { get { return _deleted; } set { SetProperty(Propertydeleted, ref _deleted, value); } }

		[SMEStringProperty(Label="Case Label", Name="label", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String label { get { return _label; } set { SetProperty(Propertylabel, ref _label, value); } }

		[SMEStringProperty(Label="Case reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEStringProperty(Label="Case Reference2", Nillable=true, Name="reference2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="companies")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Case OperatingCompany", Name="operatingCompany", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("operatingCompany")]			
		public virtual companyFeedEntry operatingCompany { get { return _operatingCompany; } set { SetProperty(PropertyoperatingCompany, ref _operatingCompany, value); } }

		[SMEStringProperty(Label="Case Type", Name="type", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }

		[SMEStringProperty(Label="Case Name", Nillable=true, Name="name", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String name { get { return _name; } set { SetProperty(Propertyname, ref _name, value); } }

		[SMEStringProperty(Label="Case Description", Nillable=true, Name="description", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String description { get { return _description; } set { SetProperty(Propertydescription, ref _description, value); } }

		[SMEResource(CanGet=true, PluralName="cases", Label="Case Associated Case")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Case Associated Case", Name="associatedCase", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual caseFeed associatedCase { get { return _associatedCase; } set { SetProperty(PropertyassociatedCase, ref _associatedCase, value); } }

		[SMEEnumProperty(EnumTypeName="caseStatus--enum", Label="Case Status", Nillable=true, Name="status", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string status { get { return _status; } set { SetProperty(Propertystatus, ref _status, value); } }

		[SMEStringProperty(Label="Case Completion Status", Nillable=true, Name="completionStatus", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String completionStatus { get { return _completionStatus; } set { SetProperty(PropertycompletionStatus, ref _completionStatus, value); } }

		[SMEDateProperty(Label="Case Start Date", Nillable=true, Name="startDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> startDate { get { return _startDate; } set { SetProperty(PropertystartDate, ref _startDate, value); } }

		[SMEDateProperty(Label="Case End Date", Nillable=true, Name="endDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> endDate { get { return _endDate; } set { SetProperty(PropertyendDate, ref _endDate, value); } }

		[SMEDateProperty(Label="Case Original End Date", Nillable=true, Name="originalEndDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> originalEndDate { get { return _originalEndDate; } set { SetProperty(PropertyoriginalEndDate, ref _originalEndDate, value); } }

		[SMEDateProperty(Label="Case Forecast End Date", Nillable=true, Name="forecastEndDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> forecastEndDate { get { return _forecastEndDate; } set { SetProperty(PropertyforecastEndDate, ref _forecastEndDate, value); } }

		[SMETimeProperty(Label="Case Duration", Nillable=true, Name="duration", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> duration { get { return _duration; } set { SetProperty(Propertyduration, ref _duration, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="companies")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Case Company", Name="company", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("company")]			
		public virtual companyFeedEntry company { get { return _company; } set { SetProperty(Propertycompany, ref _company, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="customers")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Case Customer", Name="customer", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("customer")]			
		public virtual customerFeedEntry customer { get { return _customer; } set { SetProperty(Propertycustomer, ref _customer, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Case Customer TradingAccount", Name="customerTradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("customerTradingAccount")]			
		public virtual tradingAccountFeedEntry customerTradingAccount { get { return _customerTradingAccount; } set { SetProperty(PropertycustomerTradingAccount, ref _customerTradingAccount, value); } }

		[SMEStringProperty(Label="Case Currency", Name="currency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String currency { get { return _currency; } set { SetProperty(Propertycurrency, ref _currency, value); } }

		[SMEStringProperty(Label="Case OperatingCompany Currency", Name="operatingCompanyCurrency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String operatingCompanyCurrency { get { return _operatingCompanyCurrency; } set { SetProperty(PropertyoperatingCompanyCurrency, ref _operatingCompanyCurrency, value); } }

		[SMEDecimalProperty(Label="Case OperatingCompany Currency Exchange Rate", Nillable=true, Name="operatingCompanyCurrencyExchangeRate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> operatingCompanyCurrencyExchangeRate { get { return _operatingCompanyCurrencyExchangeRate; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRate, ref _operatingCompanyCurrencyExchangeRate, value); } }

		[SMEEnumProperty(EnumTypeName="RateOperator--enum", Label="Case OperatingCompany Currency Exchange Rate Operator", Nillable=true, Name="operatingCompanyCurrencyExchangeRateOperator", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string operatingCompanyCurrencyExchangeRateOperator { get { return _operatingCompanyCurrencyExchangeRateOperator; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRateOperator, ref _operatingCompanyCurrencyExchangeRateOperator, value); } }

		[SMEDateProperty(Label="Case OperatingCompany Currency Exchange Rate Date", Nillable=true, Name="operatingCompanyCurrencyExchangeRateDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> operatingCompanyCurrencyExchangeRateDate { get { return _operatingCompanyCurrencyExchangeRateDate; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRateDate, ref _operatingCompanyCurrencyExchangeRateDate, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, PluralName="salesOrders", Label="Case SalesOrder")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Case SalesOrder", Name="salesOrder", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesOrderFeed salesOrder { get { return _salesOrder; } set { SetProperty(PropertysalesOrder, ref _salesOrder, value); } }

		[SMEResource(CanGet=true, PluralName="salesOrderDeliveries", Label="Case SalesOrderDelivery")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Case SalesOrderDelivery", Name="salesOrderDeliveries", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesOrderDeliveryFeed salesOrderDeliveries { get { return _salesOrderDeliveries; } set { SetProperty(PropertysalesOrderDeliveries, ref _salesOrderDeliveries, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, PluralName="salesInvoices", Label="Case SalesInvoice")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Case SalesInvoice", Name="salesInvoices", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesInvoiceFeed salesInvoices { get { return _salesInvoices; } set { SetProperty(PropertysalesInvoices, ref _salesInvoices, value); } }

		[SMEDecimalProperty(Label="Case Current Revenue Balance", Nillable=true, Name="currentRevenueBalance", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> currentRevenueBalance { get { return _currentRevenueBalance; } set { SetProperty(PropertycurrentRevenueBalance, ref _currentRevenueBalance, value); } }

		[SMEDateProperty(Label="Case Last Revenue Transaction Date", Nillable=true, Name="lastRevenueTransactionDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> lastRevenueTransactionDate { get { return _lastRevenueTransactionDate; } set { SetProperty(PropertylastRevenueTransactionDate, ref _lastRevenueTransactionDate, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="suppliers")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Case Supplier", Name="supplier", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("supplier")]			
		public virtual supplierFeedEntry supplier { get { return _supplier; } set { SetProperty(Propertysupplier, ref _supplier, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Case Supplier TradingAccount", Name="supplierTradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("supplierTradingAccount")]			
		public virtual tradingAccountFeedEntry supplierTradingAccount { get { return _supplierTradingAccount; } set { SetProperty(PropertysupplierTradingAccount, ref _supplierTradingAccount, value); } }

		[SMEResource(CanGet=true, CanPost=true, PluralName="purchaseOrders", Label="Case PurchaseOrder")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Case PurchaseOrder", Name="purchaseOrder", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseOrderFeed purchaseOrder { get { return _purchaseOrder; } set { SetProperty(PropertypurchaseOrder, ref _purchaseOrder, value); } }

		[SMEResource(CanGet=true, PluralName="purchaseOrderDeliveries", Label="Case PurchaseOrderDelivery")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Case PurchaseOrderDelivery", Name="purchaseOrderDeliveries", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseOrderDeliveryFeed purchaseOrderDeliveries { get { return _purchaseOrderDeliveries; } set { SetProperty(PropertypurchaseOrderDeliveries, ref _purchaseOrderDeliveries, value); } }

		[SMEResource(CanGet=true, CanPost=true, PluralName="purchaseInvoices", Label="Case PurchaseInvoice")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Case PurchaseInvoice", Name="purchaseInvoices", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseInvoiceFeed purchaseInvoices { get { return _purchaseInvoices; } set { SetProperty(PropertypurchaseInvoices, ref _purchaseInvoices, value); } }

		[SMEDecimalProperty(Label="Case Current Cost Balance", Nillable=true, Name="currentCostBalance", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> currentCostBalance { get { return _currentCostBalance; } set { SetProperty(PropertycurrentCostBalance, ref _currentCostBalance, value); } }

		[SMEDateProperty(Label="Case Last Cost Transaction Date", Nillable=true, Name="lastCostTransactionDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> lastCostTransactionDate { get { return _lastCostTransactionDate; } set { SetProperty(PropertylastCostTransactionDate, ref _lastCostTransactionDate, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="contacts", Label="Case Contact")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Case Contact", Name="contacts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual contactFeed contacts { get { return _contacts; } set { SetProperty(Propertycontacts, ref _contacts, value); } }

		[SMEResource(CanGet=true, PluralName="commodities", Label="Case Commodity")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Case Commodity", Name="commodity", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("commodity")]			
		public virtual commodityFeedEntry commodity { get { return _commodity; } set { SetProperty(Propertycommodity, ref _commodity, value); } }

		[SMEResource(CanGet=true, PluralName="commodityIdentifiers", Label="Case CommodityIdentifier")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Case CommodityIdentifier", Name="commodityIdentifiers", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual commodityIdentifierFeed commodityIdentifiers { get { return _commodityIdentifiers; } set { SetProperty(PropertycommodityIdentifiers, ref _commodityIdentifiers, value); } }

		[SMEResource(CanGet=true, PluralName="projects", Label="Case Project")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Case Project", Name="project", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("project")]			
		public virtual projectFeedEntry project { get { return _project; } set { SetProperty(Propertyproject, ref _project, value); } }

		[SMEStringProperty(Label="Case Workflow Indicator1", Nillable=true, Name="workflowIndicator1", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String workflowIndicator1 { get { return _workflowIndicator1; } set { SetProperty(PropertyworkflowIndicator1, ref _workflowIndicator1, value); } }

		[SMEStringProperty(Label="Case Workflow Indicator2", Nillable=true, Name="workflowIndicator2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String workflowIndicator2 { get { return _workflowIndicator2; } set { SetProperty(PropertyworkflowIndicator2, ref _workflowIndicator2, value); } }

		[SMEStringProperty(Label="Case Contract", Nillable=true, Name="contract", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String contract { get { return _contract; } set { SetProperty(Propertycontract, ref _contract, value); } }

		[SMEEnumProperty(EnumTypeName="casePriority--enum", Label="Case Priority", Nillable=true, Name="priority", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string priority { get { return _priority; } set { SetProperty(Propertypriority, ref _priority, value); } }

		[SMEBoolProperty(Label="Case Privacy", Nillable=true, Name="privacyFlag", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Boolean> privacyFlag { get { return _privacyFlag; } set { SetProperty(PropertyprivacyFlag, ref _privacyFlag, value); } }

		[SMEResource(CanGet=true, PluralName="interactions", Label="Case Interaction")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Case Interaction", Name="interactions", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual interactionFeed interactions { get { return _interactions; } set { SetProperty(Propertyinteractions, ref _interactions, value); } }

		[SMEResource(CanGet=true, PluralName="notes")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Label="Case Note", Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual noteFeed notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		#endregion


	}
}