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
	/// Defines a projectLine feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("projectLine", Namespace="http://schemas.sage.com/crmErp/2008")]
		[SMEResource(CanGet=true, PluralName="projectLines")]
	public class projectLineFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyid = "id";
		public const string Propertyproject = "project";
		public const string Propertyactive = "active";
		public const string Propertydeleted = "deleted";
		public const string Propertylabel = "label";
		public const string PropertyisGroupingflag = "isGroupingflag";
		public const string Propertyreference = "reference";
		public const string Propertyreference2 = "reference2";
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
		public const string PropertyoriginatorDocument = "originatorDocument";
		public const string PropertyassociatedProjectLine = "associatedProjectLine";
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
		public const string PropertyaccountingType = "accountingType";
		public const string PropertyfinancialAccounts = "financialAccounts";
		public const string Propertynotes = "notes";

		#endregion

		#region Fields

		private System.String _id;
		private projectFeedEntry _project;
		private System.Boolean _active;
		private System.Boolean _deleted;
		private System.String _label;
		private Nullable<System.Boolean> _isGroupingflag;
		private System.String _reference;
		private System.String _reference2;
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
		private System.String _originatorDocument;
		private projectLineFeedEntry _associatedProjectLine;
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
		private string _accountingType;
		private financialAccountFeedEntry _financialAccounts;
		private noteFeedEntry _notes;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="projectLineFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public projectLineFeedEntrySchema()
		{
		}

		#region Properties


		[SMEStringProperty(Label="ProjectLine Application ID", Name="id", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual new System.String id { get { return _id; } set { SetProperty(Propertyid, ref _id, value); } }

		[SMEResource(CanGet=true, PluralName="projects", Label="ProjectLine Project")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Parent, Label="ProjectLine Project", Name="project", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("project")]			
		public virtual projectFeedEntry project { get { return _project; } set { SetProperty(Propertyproject, ref _project, value); } }

		[SMEBoolProperty(Label="ProjectLine Active Flag", Name="active", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEBoolProperty(Label="ProjectLine Deleted", Name="deleted", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean deleted { get { return _deleted; } set { SetProperty(Propertydeleted, ref _deleted, value); } }

		[SMEStringProperty(Label="ProjectLine Label", Name="label", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String label { get { return _label; } set { SetProperty(Propertylabel, ref _label, value); } }

		[SMEBoolProperty(Label="ProjectLine Is Grouping Flag", Nillable=true, Name="isGroupingflag", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Boolean> isGroupingflag { get { return _isGroupingflag; } set { SetProperty(PropertyisGroupingflag, ref _isGroupingflag, value); } }

		[SMEStringProperty(Label="ProjectLine reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEStringProperty(Label="ProjectLine Reference2", Nillable=true, Name="reference2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }

		[SMEStringProperty(Label="ProjectLine Type", Nillable=true, Name="type", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }

		[SMEStringProperty(Label="ProjectLine Name", Nillable=true, Name="name", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String name { get { return _name; } set { SetProperty(Propertyname, ref _name, value); } }

		[SMEStringProperty(Label="ProjectLine Short Name", Nillable=true, Name="shortName", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String shortName { get { return _shortName; } set { SetProperty(PropertyshortName, ref _shortName, value); } }

		[SMEStringProperty(Label="ProjectLine Description", Nillable=true, Name="description", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String description { get { return _description; } set { SetProperty(Propertydescription, ref _description, value); } }

		[SMEStringProperty(Label="ProjectLine Status", Nillable=true, Name="status", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String status { get { return _status; } set { SetProperty(Propertystatus, ref _status, value); } }

		[SMEStringProperty(Label="ProjectLine Completion Status", Nillable=true, Name="completionStatus", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String completionStatus { get { return _completionStatus; } set { SetProperty(PropertycompletionStatus, ref _completionStatus, value); } }

		[SMEDateProperty(Label="ProjectLine Start Date", Nillable=true, Name="startDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> startDate { get { return _startDate; } set { SetProperty(PropertystartDate, ref _startDate, value); } }

		[SMEDateProperty(Label="ProjectLine End Date", Nillable=true, Name="endDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> endDate { get { return _endDate; } set { SetProperty(PropertyendDate, ref _endDate, value); } }

		[SMEDateProperty(Label="ProjectLine Original End Date", Nillable=true, Name="originalEndDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> originalEndDate { get { return _originalEndDate; } set { SetProperty(PropertyoriginalEndDate, ref _originalEndDate, value); } }

		[SMEDateProperty(Label="ProjectLine Forecast End Date", Nillable=true, Name="forecastEndDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> forecastEndDate { get { return _forecastEndDate; } set { SetProperty(PropertyforecastEndDate, ref _forecastEndDate, value); } }

		[SMETimeProperty(Label="ProjectLine Duration", Nillable=true, Name="duration", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> duration { get { return _duration; } set { SetProperty(Propertyduration, ref _duration, value); } }

		[SMEStringProperty(Label="ProjectLine Originator Document reference", Nillable=true, Name="originatorDocument", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String originatorDocument { get { return _originatorDocument; } set { SetProperty(PropertyoriginatorDocument, ref _originatorDocument, value); } }

		[SMEResource(CanGet=true, PluralName="projectLines", Label="ProjectLine Associated ProjectLine")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="ProjectLine Associated ProjectLine", Name="associatedProjectLine", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("associatedProjectLine")]			
		public virtual projectLineFeedEntry associatedProjectLine { get { return _associatedProjectLine; } set { SetProperty(PropertyassociatedProjectLine, ref _associatedProjectLine, value); } }

		[SMEDecimalProperty(Label="ProjectLine Current Cost Balance", Nillable=true, Name="currentCostBalance", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> currentCostBalance { get { return _currentCostBalance; } set { SetProperty(PropertycurrentCostBalance, ref _currentCostBalance, value); } }

		[SMEDateProperty(Label="ProjectLine Last Cost Transaction Date", Nillable=true, Name="lastCostTransactionDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> lastCostTransactionDate { get { return _lastCostTransactionDate; } set { SetProperty(PropertylastCostTransactionDate, ref _lastCostTransactionDate, value); } }

		[SMEDecimalProperty(Label="ProjectLine Current Revenue Balance", Nillable=true, Name="currentRevenueBalance", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> currentRevenueBalance { get { return _currentRevenueBalance; } set { SetProperty(PropertycurrentRevenueBalance, ref _currentRevenueBalance, value); } }

		[SMEDateProperty(Label="ProjectLine Last Revenue Transaction Date", Nillable=true, Name="lastRevenueTransactionDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> lastRevenueTransactionDate { get { return _lastRevenueTransactionDate; } set { SetProperty(PropertylastRevenueTransactionDate, ref _lastRevenueTransactionDate, value); } }

		[SMEDecimalProperty(Label="ProjectLine Current Cost Budget", Nillable=true, Name="currentCostBudget", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> currentCostBudget { get { return _currentCostBudget; } set { SetProperty(PropertycurrentCostBudget, ref _currentCostBudget, value); } }

		[SMEDateProperty(Label="ProjectLine Current Cost Budget Date", Nillable=true, Name="currentCostBudgetDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> currentCostBudgetDate { get { return _currentCostBudgetDate; } set { SetProperty(PropertycurrentCostBudgetDate, ref _currentCostBudgetDate, value); } }

		[SMEDecimalProperty(Label="ProjectLine Current Revenue Budget", Nillable=true, Name="currentRevenueBudget", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> currentRevenueBudget { get { return _currentRevenueBudget; } set { SetProperty(PropertycurrentRevenueBudget, ref _currentRevenueBudget, value); } }

		[SMEDateProperty(Label="ProjectLine Current Revenue Budget Date", Nillable=true, Name="currentRevenueBudgetDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> currentRevenueBudgetDate { get { return _currentRevenueBudgetDate; } set { SetProperty(PropertycurrentRevenueBudgetDate, ref _currentRevenueBudgetDate, value); } }

		[SMEDecimalProperty(Label="ProjectLine Committed Cost Balance", Nillable=true, Name="currentCommittedCostBalance", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> currentCommittedCostBalance { get { return _currentCommittedCostBalance; } set { SetProperty(PropertycurrentCommittedCostBalance, ref _currentCommittedCostBalance, value); } }

		[SMEDateProperty(Label="ProjectLine Current Committed Cost Balance Date", Nillable=true, Name="currentCommittedCostBalanceDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> currentCommittedCostBalanceDate { get { return _currentCommittedCostBalanceDate; } set { SetProperty(PropertycurrentCommittedCostBalanceDate, ref _currentCommittedCostBalanceDate, value); } }

		[SMEEnumProperty(EnumTypeName="projectLineAccountingType--enum", Label="ProjectLine Accounting Type", Nillable=true, Name="accountingType", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string accountingType { get { return _accountingType; } set { SetProperty(PropertyaccountingType, ref _accountingType, value); } }

		[SMEResource(CanGet=true, PluralName="financialAccounts", Label="ProjectLine FinancialAccount")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="ProjectLine FinancialAccount", Name="financialAccounts", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("financialAccounts")]			
		public virtual financialAccountFeedEntry financialAccounts { get { return _financialAccounts; } set { SetProperty(PropertyfinancialAccounts, ref _financialAccounts, value); } }

		[SMEResource(CanGet=true, PluralName="notes", Label="ProjectLine Note")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, Label="ProjectLine Note", Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("notes")]			
		public virtual noteFeedEntry notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		#endregion


	}
}