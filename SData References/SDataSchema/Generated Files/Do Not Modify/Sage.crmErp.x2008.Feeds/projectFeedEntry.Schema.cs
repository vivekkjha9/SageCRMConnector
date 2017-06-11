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
	/// Defines a project feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("project", Namespace="http://schemas.sage.com/crmErp/2008")]
		[SMEResource(CanGet=true, PluralName="projects")]
	public class projectFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyid = "id";
		public const string Propertyactive = "active";
		public const string Propertydeleted = "deleted";
		public const string Propertylabel = "label";
		public const string Propertyreference = "reference";
		public const string Propertyreference2 = "reference2";
		public const string PropertyoperatingCompany = "operatingCompany";
		public const string Propertytype = "type";
		public const string Propertyname = "name";
		public const string PropertyshortName = "shortName";
		public const string Propertydescription = "description";
		public const string Propertystatus = "status";
		public const string PropertycompletionStatus = "completionStatus";
		public const string PropertystartDate = "startDate";
		public const string PropertyendDate = "endDate";
		public const string PropertyoriginalEndDate = "originalEndDate";
		public const string PropertyforecastEndDate = "forecastEndDate";
		public const string Propertyduration = "duration";
		public const string Propertycompany = "company";
		public const string Propertycustomer = "customer";
		public const string PropertytradingAccount = "tradingAccount";
		public const string Propertycurrency = "currency";
		public const string PropertyoperatingCompanyCurrency = "operatingCompanyCurrency";
		public const string PropertyoperatingCompanyCurrencyExchangeRate = "operatingCompanyCurrencyExchangeRate";
		public const string PropertyoperatingCompanyCurrencyExchangeRateOperator = "operatingCompanyCurrencyExchangeRateOperator";
		public const string PropertyoperatingCompanyCurrencyExchangeRateDate = "operatingCompanyCurrencyExchangeRateDate";
		public const string PropertyoriginatorDocument = "originatorDocument";
		public const string PropertyassociatedProject = "associatedProject";
		public const string PropertyparentProject = "parentProject";
		public const string PropertychildProjects = "childProjects";
		public const string PropertyprojectLines = "projectLines";
		public const string PropertycurrentCostBalance = "currentCostBalance";
		public const string PropertylastCostTransactionDate = "lastCostTransactionDate";
		public const string PropertycurrentRevenueBalance = "currentRevenueBalance";
		public const string PropertylastRevenueTransactionDate = "lastRevenueTransactionDate";
		public const string PropertycurrentCostBudget = "currentCostBudget";
		public const string PropertycurrentCostBudgetDate = "currentCostBudgetDate";
		public const string PropertycurrentRevenueBudget = "currentRevenueBudget";
		public const string PropertycurrentRevenueBudgetDate = "currentRevenueBudgetDate";
		public const string PropertycurrentCommittedCostBalance = "currentCommittedCostBalance";
		public const string PropertycurrentCommittedCostBalanceDate = "currentCommittedCostBalanceDate";
		public const string Propertycontacts = "contacts";
		public const string PropertypostalAddresses = "postalAddresses";
		public const string PropertytaxCodes = "taxCodes";
		public const string PropertyfinancialAccounts = "financialAccounts";
		public const string Propertyinteractions = "interactions";
		public const string Propertycases = "cases";
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
		private System.String _type;
		private System.String _name;
		private System.String _shortName;
		private System.String _description;
		private System.String _status;
		private System.String _completionStatus;
		private Nullable<System.DateTime> _startDate;
		private Nullable<System.DateTime> _endDate;
		private Nullable<System.DateTime> _originalEndDate;
		private Nullable<System.DateTime> _forecastEndDate;
		private Nullable<System.DateTime> _duration;
		private companyFeed _company;
		private customerFeed _customer;
		private tradingAccountFeed _tradingAccount;
		private System.String _currency;
		private System.String _operatingCompanyCurrency;
		private Nullable<System.Decimal> _operatingCompanyCurrencyExchangeRate;
		private string _operatingCompanyCurrencyExchangeRateOperator;
		private Nullable<System.DateTime> _operatingCompanyCurrencyExchangeRateDate;
		private salesOrderFeedEntry _originatorDocument;
		private projectFeedEntry _associatedProject;
		private projectFeedEntry _parentProject;
		private projectFeed _childProjects;
		private projectLineFeed _projectLines;
		private Nullable<System.Decimal> _currentCostBalance;
		private Nullable<System.DateTime> _lastCostTransactionDate;
		private Nullable<System.Decimal> _currentRevenueBalance;
		private Nullable<System.DateTime> _lastRevenueTransactionDate;
		private Nullable<System.Decimal> _currentCostBudget;
		private Nullable<System.DateTime> _currentCostBudgetDate;
		private Nullable<System.Decimal> _currentRevenueBudget;
		private Nullable<System.DateTime> _currentRevenueBudgetDate;
		private Nullable<System.Decimal> _currentCommittedCostBalance;
		private Nullable<System.DateTime> _currentCommittedCostBalanceDate;
		private contactFeed _contacts;
		private postalAddressFeed _postalAddresses;
		private taxCodeFeed _taxCodes;
		private financialAccountFeed _financialAccounts;
		private interactionFeed _interactions;
		private caseFeed _cases;
		private noteFeed _notes;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="projectFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public projectFeedEntrySchema()
		{
		}

		#region Properties


		[SMEStringProperty(Label="Project Application ID", Name="id", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual new System.String id { get { return _id; } set { SetProperty(Propertyid, ref _id, value); } }

		[SMEBoolProperty(Label="Project Active Flag", Name="active", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEBoolProperty(Label="Project Deleted", Name="deleted", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean deleted { get { return _deleted; } set { SetProperty(Propertydeleted, ref _deleted, value); } }

		[SMEStringProperty(Label="Project Label", Name="label", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String label { get { return _label; } set { SetProperty(Propertylabel, ref _label, value); } }

		[SMEStringProperty(Label="Project reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEStringProperty(Label="Project Reference2", Nillable=true, Name="reference2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="companies")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Project OperatingCompany", Name="operatingCompany", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("operatingCompany")]			
		public virtual companyFeedEntry operatingCompany { get { return _operatingCompany; } set { SetProperty(PropertyoperatingCompany, ref _operatingCompany, value); } }

		[SMEStringProperty(Label="Project Type", Nillable=true, Name="type", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }

		[SMEStringProperty(Label="Project Name", Nillable=true, Name="name", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String name { get { return _name; } set { SetProperty(Propertyname, ref _name, value); } }

		[SMEStringProperty(Label="Project Short Name", Nillable=true, Name="shortName", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String shortName { get { return _shortName; } set { SetProperty(PropertyshortName, ref _shortName, value); } }

		[SMEStringProperty(Label="Project Description", Nillable=true, Name="description", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String description { get { return _description; } set { SetProperty(Propertydescription, ref _description, value); } }

		[SMEStringProperty(Label="Project Status", Nillable=true, Name="status", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String status { get { return _status; } set { SetProperty(Propertystatus, ref _status, value); } }

		[SMEStringProperty(Label="Project Completion Status", Nillable=true, Name="completionStatus", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String completionStatus { get { return _completionStatus; } set { SetProperty(PropertycompletionStatus, ref _completionStatus, value); } }

		[SMEDateProperty(Label="Project Start Date", Nillable=true, Name="startDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> startDate { get { return _startDate; } set { SetProperty(PropertystartDate, ref _startDate, value); } }

		[SMEDateProperty(Label="Project End Date", Nillable=true, Name="endDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> endDate { get { return _endDate; } set { SetProperty(PropertyendDate, ref _endDate, value); } }

		[SMEDateProperty(Label="Project Original End Date", Nillable=true, Name="originalEndDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> originalEndDate { get { return _originalEndDate; } set { SetProperty(PropertyoriginalEndDate, ref _originalEndDate, value); } }

		[SMEDateProperty(Label="Project Forecast End Date", Nillable=true, Name="forecastEndDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> forecastEndDate { get { return _forecastEndDate; } set { SetProperty(PropertyforecastEndDate, ref _forecastEndDate, value); } }

		[SMETimeProperty(Label="Project Duration", Nillable=true, Name="duration", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> duration { get { return _duration; } set { SetProperty(Propertyduration, ref _duration, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="companies", Label="Project Company")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Project Company", Name="company", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual companyFeed company { get { return _company; } set { SetProperty(Propertycompany, ref _company, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="customers", Label="Project Customer")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Project Customer", Name="customer", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual customerFeed customer { get { return _customer; } set { SetProperty(Propertycustomer, ref _customer, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Project Customer TradingAccount", Name="tradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual tradingAccountFeed tradingAccount { get { return _tradingAccount; } set { SetProperty(PropertytradingAccount, ref _tradingAccount, value); } }

		[SMEStringProperty(Label="Project Currency", Name="currency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String currency { get { return _currency; } set { SetProperty(Propertycurrency, ref _currency, value); } }

		[SMEStringProperty(Label="Project OperatingCompany Currency", Name="operatingCompanyCurrency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String operatingCompanyCurrency { get { return _operatingCompanyCurrency; } set { SetProperty(PropertyoperatingCompanyCurrency, ref _operatingCompanyCurrency, value); } }

		[SMEDecimalProperty(Label="Project OperatingCompany Currency Exchange Rate", Nillable=true, Name="operatingCompanyCurrencyExchangeRate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> operatingCompanyCurrencyExchangeRate { get { return _operatingCompanyCurrencyExchangeRate; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRate, ref _operatingCompanyCurrencyExchangeRate, value); } }

		[SMEEnumProperty(EnumTypeName="RateOperator--enum", Label="Project OperatingCompany Currency Exchange Rate Operator", Nillable=true, Name="operatingCompanyCurrencyExchangeRateOperator", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string operatingCompanyCurrencyExchangeRateOperator { get { return _operatingCompanyCurrencyExchangeRateOperator; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRateOperator, ref _operatingCompanyCurrencyExchangeRateOperator, value); } }

		[SMEDateProperty(Label="Project OperatingCompany Currency Exchange Rate Date", Nillable=true, Name="operatingCompanyCurrencyExchangeRateDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> operatingCompanyCurrencyExchangeRateDate { get { return _operatingCompanyCurrencyExchangeRateDate; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRateDate, ref _operatingCompanyCurrencyExchangeRateDate, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, PluralName="salesOrders", Label="Project Originator Document reference")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Project Originator Document reference", Name="originatorDocument", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("originatorDocument")]			
		public virtual salesOrderFeedEntry originatorDocument { get { return _originatorDocument; } set { SetProperty(PropertyoriginatorDocument, ref _originatorDocument, value); } }

		[SMEResource(CanGet=true, PluralName="projects", Label="Project Associated Project")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Project Associated Project", Name="associatedProject", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("associatedProject")]			
		public virtual projectFeedEntry associatedProject { get { return _associatedProject; } set { SetProperty(PropertyassociatedProject, ref _associatedProject, value); } }

		[SMEResource(CanGet=true, PluralName="projects", Label="Project Parent Project")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Parent, Label="Project Parent Project", Name="parentProject", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("parentProject")]			
		public virtual projectFeedEntry parentProject { get { return _parentProject; } set { SetProperty(PropertyparentProject, ref _parentProject, value); } }

		[SMEResource(CanGet=true, PluralName="projects", Label="Project Child Project")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Label="Project Child Project", Name="childProjects", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual projectFeed childProjects { get { return _childProjects; } set { SetProperty(PropertychildProjects, ref _childProjects, value); } }

		[SMEResource(CanGet=true, PluralName="projectLines", Label="Project ProjectLine")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Label="Project ProjectLine", Name="projectLines", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual projectLineFeed projectLines { get { return _projectLines; } set { SetProperty(PropertyprojectLines, ref _projectLines, value); } }

		[SMEDecimalProperty(Label="Project Current Cost Balance", Nillable=true, Name="currentCostBalance", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> currentCostBalance { get { return _currentCostBalance; } set { SetProperty(PropertycurrentCostBalance, ref _currentCostBalance, value); } }

		[SMEDateProperty(Label="Project Last Cost Transaction Date", Nillable=true, Name="lastCostTransactionDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> lastCostTransactionDate { get { return _lastCostTransactionDate; } set { SetProperty(PropertylastCostTransactionDate, ref _lastCostTransactionDate, value); } }

		[SMEDecimalProperty(Label="Project Current Revenue Balance", Nillable=true, Name="currentRevenueBalance", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> currentRevenueBalance { get { return _currentRevenueBalance; } set { SetProperty(PropertycurrentRevenueBalance, ref _currentRevenueBalance, value); } }

		[SMEDateProperty(Label="Project Last Revenue Transaction Date", Nillable=true, Name="lastRevenueTransactionDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> lastRevenueTransactionDate { get { return _lastRevenueTransactionDate; } set { SetProperty(PropertylastRevenueTransactionDate, ref _lastRevenueTransactionDate, value); } }

		[SMEDecimalProperty(Label="Project Current Cost Budget", Nillable=true, Name="currentCostBudget", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> currentCostBudget { get { return _currentCostBudget; } set { SetProperty(PropertycurrentCostBudget, ref _currentCostBudget, value); } }

		[SMEDateProperty(Label="Project Current Cost Budget Date", Nillable=true, Name="currentCostBudgetDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> currentCostBudgetDate { get { return _currentCostBudgetDate; } set { SetProperty(PropertycurrentCostBudgetDate, ref _currentCostBudgetDate, value); } }

		[SMEDecimalProperty(Label="Project Current Revenue Budget", Nillable=true, Name="currentRevenueBudget", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> currentRevenueBudget { get { return _currentRevenueBudget; } set { SetProperty(PropertycurrentRevenueBudget, ref _currentRevenueBudget, value); } }

		[SMEDateProperty(Label="Project Current Revenue Budget Date", Nillable=true, Name="currentRevenueBudgetDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> currentRevenueBudgetDate { get { return _currentRevenueBudgetDate; } set { SetProperty(PropertycurrentRevenueBudgetDate, ref _currentRevenueBudgetDate, value); } }

		[SMEDecimalProperty(Label="Project Current Committed Cost Balance", Nillable=true, Name="currentCommittedCostBalance", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> currentCommittedCostBalance { get { return _currentCommittedCostBalance; } set { SetProperty(PropertycurrentCommittedCostBalance, ref _currentCommittedCostBalance, value); } }

		[SMEDateProperty(Label="Project Current Committed Cost Balance Date", Nillable=true, Name="currentCommittedCostBalanceDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> currentCommittedCostBalanceDate { get { return _currentCommittedCostBalanceDate; } set { SetProperty(PropertycurrentCommittedCostBalanceDate, ref _currentCommittedCostBalanceDate, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="contacts", Label="Project Contact")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Project Contact", Name="contacts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual contactFeed contacts { get { return _contacts; } set { SetProperty(Propertycontacts, ref _contacts, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="postalAddresses")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Project PostalAddress", Name="postalAddresses", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual postalAddressFeed postalAddresses { get { return _postalAddresses; } set { SetProperty(PropertypostalAddresses, ref _postalAddresses, value); } }

		[SMEResource(CanGet=true, PluralName="taxCodes", Label="Project Tax Code")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Project Tax Code", Name="taxCodes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual taxCodeFeed taxCodes { get { return _taxCodes; } set { SetProperty(PropertytaxCodes, ref _taxCodes, value); } }

		[SMEResource(CanGet=true, PluralName="financialAccounts", Label="Project FinancialAccount")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Project FinancialAccount", Name="financialAccounts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual financialAccountFeed financialAccounts { get { return _financialAccounts; } set { SetProperty(PropertyfinancialAccounts, ref _financialAccounts, value); } }

		[SMEResource(CanGet=true, PluralName="interactions", Label="Project Interaction")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Project Interaction", Name="interactions", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual interactionFeed interactions { get { return _interactions; } set { SetProperty(Propertyinteractions, ref _interactions, value); } }

		[SMEResource(CanGet=true, PluralName="cases", Label="Project Case")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Project Case", Name="cases", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual caseFeed cases { get { return _cases; } set { SetProperty(Propertycases, ref _cases, value); } }

		[SMEResource(CanGet=true, PluralName="notes")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Label="Project Note", Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual noteFeed notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		#endregion


	}
}