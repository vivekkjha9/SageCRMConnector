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
	/// Defines a interaction feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("interaction", Namespace="http://schemas.sage.com/crmErp/2008")]
		[SMEResource(CanGet=true, PluralName="interactions")]
	public class interactionFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyid = "id";
		public const string Propertyactive = "active";
		public const string Propertydeleted = "deleted";
		public const string Propertylabel = "label";
		public const string Propertytype = "type";
		public const string Propertystatus = "status";
		public const string Propertyreference = "reference";
		public const string PropertyoperatingCompany = "operatingCompany";
		public const string Propertyname = "name";
		public const string Propertysubject = "subject";
		public const string Propertydescription = "description";
		public const string Propertyuser = "user";
		public const string Propertypriority = "priority";
		public const string Propertycompany = "company";
		public const string PropertycustomerSupplierFlag = "customerSupplierFlag";
		public const string Propertycustomer = "customer";
		public const string Propertysupplier = "supplier";
		public const string PropertytradingAccount = "tradingAccount";
		public const string PropertysalesInvoices = "salesInvoices";
		public const string Propertycontacts = "contacts";
		public const string Propertycommodities = "commodities";
		public const string Propertydate = "date";
		public const string Propertytime = "time";
		public const string PropertyendDate = "endDate";
		public const string PropertyendTime = "endTime";
		public const string Propertyduration = "duration";
		public const string PropertyexpirationDate = "expirationDate";
		public const string PropertyexpirationTime = "expirationTime";
		public const string Propertyrecurrence = "recurrence";
		public const string PropertyrecurrenceFrequency = "recurrenceFrequency";
		public const string PropertyworkflowIndicator1 = "workflowIndicator1";
		public const string PropertyworkflowIndicator2 = "workflowIndicator2";
		public const string PropertyprivacyFlag = "privacyFlag";
		public const string Propertyproject = "project";
		public const string Propertyxcase = "xcase";
		public const string Propertynotes = "notes";

		#endregion

		#region Fields

		private System.String _id;
		private System.Boolean _active;
		private System.Boolean _deleted;
		private System.String _label;
		private string _type;
		private string _status;
		private System.String _reference;
		private companyFeedEntry _operatingCompany;
		private System.String _name;
		private System.String _subject;
		private System.String _description;
		private System.String _user;
		private string _priority;
		private companyFeedEntry _company;
		private System.String _customerSupplierFlag;
		private customerFeedEntry _customer;
		private supplierFeedEntry _supplier;
		private tradingAccountFeedEntry _tradingAccount;
		private salesInvoiceFeed _salesInvoices;
		private contactFeed _contacts;
		private commodityFeed _commodities;
		private Nullable<System.DateTime> _date;
		private Nullable<System.DateTime> _time;
		private Nullable<System.DateTime> _endDate;
		private Nullable<System.DateTime> _endTime;
		private Nullable<System.DateTime> _duration;
		private Nullable<System.DateTime> _expirationDate;
		private Nullable<System.DateTime> _expirationTime;
		private Nullable<System.Boolean> _recurrence;
		private string _recurrenceFrequency;
		private System.String _workflowIndicator1;
		private System.String _workflowIndicator2;
		private System.Boolean _privacyFlag;
		private projectFeedEntry _project;
		private caseFeedEntry _xcase;
		private noteFeed _notes;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="interactionFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public interactionFeedEntrySchema()
		{
		}

		#region Properties


		[SMEStringProperty(Label="Interaction Application ID", Name="id", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual new System.String id { get { return _id; } set { SetProperty(Propertyid, ref _id, value); } }

		[SMEBoolProperty(Label="Interaction Active Flag", Name="active", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEBoolProperty(Label="Interaction Deleted", Name="deleted", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean deleted { get { return _deleted; } set { SetProperty(Propertydeleted, ref _deleted, value); } }

		[SMEStringProperty(Label="Interaction Label", Name="label", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String label { get { return _label; } set { SetProperty(Propertylabel, ref _label, value); } }

		[SMEEnumProperty(EnumTypeName="interactionType--enum", Label="Interaction Type", Name="type", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }

		[SMEEnumProperty(EnumTypeName="interactionStatus--enum", Label="Interaction Status", Nillable=true, Name="status", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string status { get { return _status; } set { SetProperty(Propertystatus, ref _status, value); } }

		[SMEStringProperty(Label="Interaction reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="companies")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Interaction OperatingCompany", Name="operatingCompany", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("operatingCompany")]			
		public virtual companyFeedEntry operatingCompany { get { return _operatingCompany; } set { SetProperty(PropertyoperatingCompany, ref _operatingCompany, value); } }

		[SMEStringProperty(Label="Interaction Name", Nillable=true, Name="name", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String name { get { return _name; } set { SetProperty(Propertyname, ref _name, value); } }

		[SMEStringProperty(Label="Interaction Subject", Nillable=true, Name="subject", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String subject { get { return _subject; } set { SetProperty(Propertysubject, ref _subject, value); } }

		[SMEStringProperty(Label="Interaction Description", Name="description", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String description { get { return _description; } set { SetProperty(Propertydescription, ref _description, value); } }

		[SMEStringProperty(Label="Interaction User", Nillable=true, Name="user", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String user { get { return _user; } set { SetProperty(Propertyuser, ref _user, value); } }

		[SMEEnumProperty(EnumTypeName="interactionPriority--enum", Label="Interaction Priority", Nillable=true, Name="priority", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string priority { get { return _priority; } set { SetProperty(Propertypriority, ref _priority, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="companies")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Interaction Company", Name="company", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("company")]			
		public virtual companyFeedEntry company { get { return _company; } set { SetProperty(Propertycompany, ref _company, value); } }

		[SMEStringProperty(Label="Interaction Customer Supplier Flag", Nillable=true, Name="customerSupplierFlag", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String customerSupplierFlag { get { return _customerSupplierFlag; } set { SetProperty(PropertycustomerSupplierFlag, ref _customerSupplierFlag, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="customers")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Interaction Customer", Name="customer", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("customer")]			
		public virtual customerFeedEntry customer { get { return _customer; } set { SetProperty(Propertycustomer, ref _customer, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="suppliers")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Interaction Supplier", Name="supplier", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("supplier")]			
		public virtual supplierFeedEntry supplier { get { return _supplier; } set { SetProperty(Propertysupplier, ref _supplier, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Interaction Customer Supplier TradingAccount", Name="tradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("tradingAccount")]			
		public virtual tradingAccountFeedEntry tradingAccount { get { return _tradingAccount; } set { SetProperty(PropertytradingAccount, ref _tradingAccount, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, PluralName="salesInvoices", Label="Interaction SalesInvoice")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Interaction SalesInvoice", Name="salesInvoices", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesInvoiceFeed salesInvoices { get { return _salesInvoices; } set { SetProperty(PropertysalesInvoices, ref _salesInvoices, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="contacts", Label="Interaction Contact")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Interaction Contact", Name="contacts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual contactFeed contacts { get { return _contacts; } set { SetProperty(Propertycontacts, ref _contacts, value); } }

		[SMEResource(CanGet=true, PluralName="commodities", Label="Interaction Commodity")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Interaction Commodity", Name="commodities", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual commodityFeed commodities { get { return _commodities; } set { SetProperty(Propertycommodities, ref _commodities, value); } }

		[SMEDateProperty(Label="Interaction Date", Nillable=true, Name="date", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> date { get { return _date; } set { SetProperty(Propertydate, ref _date, value); } }

		[SMETimeProperty(Label="Interaction Time", Nillable=true, Name="time", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> time { get { return _time; } set { SetProperty(Propertytime, ref _time, value); } }

		[SMEDateProperty(Label="Interaction End Date", Nillable=true, Name="endDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> endDate { get { return _endDate; } set { SetProperty(PropertyendDate, ref _endDate, value); } }

		[SMETimeProperty(Label="Interaction End Time", Nillable=true, Name="endTime", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> endTime { get { return _endTime; } set { SetProperty(PropertyendTime, ref _endTime, value); } }

		[SMETimeProperty(Label="Interaction Duration", Nillable=true, Name="duration", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> duration { get { return _duration; } set { SetProperty(Propertyduration, ref _duration, value); } }

		[SMEDateProperty(Label="Interaction Expiration Date", Nillable=true, Name="expirationDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> expirationDate { get { return _expirationDate; } set { SetProperty(PropertyexpirationDate, ref _expirationDate, value); } }

		[SMETimeProperty(Label="Interaction Expiration Time", Nillable=true, Name="expirationTime", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> expirationTime { get { return _expirationTime; } set { SetProperty(PropertyexpirationTime, ref _expirationTime, value); } }

		[SMEBoolProperty(Label="Interaction Recurrence", Nillable=true, Name="recurrence", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Boolean> recurrence { get { return _recurrence; } set { SetProperty(Propertyrecurrence, ref _recurrence, value); } }

		[SMEEnumProperty(EnumTypeName="interactionRecurrenceFrequency--enum", Label="Interaction Recurrence Frequency", Nillable=true, Name="recurrenceFrequency", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string recurrenceFrequency { get { return _recurrenceFrequency; } set { SetProperty(PropertyrecurrenceFrequency, ref _recurrenceFrequency, value); } }

		[SMEStringProperty(Label="Interaction Workflow Indicator1", Nillable=true, Name="workflowIndicator1", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String workflowIndicator1 { get { return _workflowIndicator1; } set { SetProperty(PropertyworkflowIndicator1, ref _workflowIndicator1, value); } }

		[SMEStringProperty(Label="Interaction Workflow Indicator2", Nillable=true, Name="workflowIndicator2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String workflowIndicator2 { get { return _workflowIndicator2; } set { SetProperty(PropertyworkflowIndicator2, ref _workflowIndicator2, value); } }

		[SMEBoolProperty(Label="Interaction Privacy Flag", Name="privacyFlag", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean privacyFlag { get { return _privacyFlag; } set { SetProperty(PropertyprivacyFlag, ref _privacyFlag, value); } }

		[SMEResource(CanGet=true, PluralName="projects", Label="Interaction Project")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Interaction Project", Name="project", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("project")]			
		public virtual projectFeedEntry project { get { return _project; } set { SetProperty(Propertyproject, ref _project, value); } }

		[SMEResource(CanGet=true, PluralName="cases", Label="Interaction Case")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Interaction Case", Name="case", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("case")]			
		public virtual caseFeedEntry xcase { get { return _xcase; } set { SetProperty(Propertyxcase, ref _xcase, value); } }

		[SMEResource(CanGet=true, PluralName="notes")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Label="Interaction Note", Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual noteFeed notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		#endregion


	}
}