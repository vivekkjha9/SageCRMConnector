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
	/// Defines a financialAccount feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("financialAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[SMEResource(CanGet=true, PluralName="financialAccounts")]
	public class financialAccountFeedEntrySchema : Sage.Common.Syndication.FeedEntry
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
		public const string PropertyreportingType = "reportingType";
		public const string PropertyaccountingType = "accountingType";
		public const string Propertyname = "name";
		public const string Propertydescription = "description";
		public const string Propertyaccount = "account";
		public const string Propertyanalysis01 = "analysis01";
		public const string Propertyanalysis02 = "analysis02";
		public const string Propertyanalysis03 = "analysis03";
		public const string Propertyanalysis04 = "analysis04";
		public const string Propertyanalysis05 = "analysis05";
		public const string Propertyanalysis06 = "analysis06";
		public const string Propertyanalysis07 = "analysis07";
		public const string Propertyanalysis08 = "analysis08";
		public const string Propertyanalysis09 = "analysis09";
		public const string Propertyanalysis10 = "analysis10";
		public const string Propertyanalysis11 = "analysis11";
		public const string Propertyanalysis12 = "analysis12";
		public const string Propertyanalysis13 = "analysis13";
		public const string Propertyanalysis14 = "analysis14";
		public const string Propertyanalysis15 = "analysis15";
		public const string Propertycurrency = "currency";
		public const string Propertybalance = "balance";
		public const string PropertybalanceDate = "balanceDate";
		public const string PropertylastTransactionDate = "lastTransactionDate";
		public const string PropertyprimacyIndicator = "primacyIndicator";
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
		private string _type;
		private string _reportingType;
		private string _accountingType;
		private System.String _name;
		private System.String _description;
		private System.String _account;
		private System.String _analysis01;
		private System.String _analysis02;
		private System.String _analysis03;
		private System.String _analysis04;
		private System.String _analysis05;
		private System.String _analysis06;
		private System.String _analysis07;
		private System.String _analysis08;
		private System.String _analysis09;
		private System.String _analysis10;
		private System.String _analysis11;
		private System.String _analysis12;
		private System.String _analysis13;
		private System.String _analysis14;
		private System.String _analysis15;
		private System.String _currency;
		private Nullable<System.Decimal> _balance;
		private Nullable<System.DateTime> _balanceDate;
		private Nullable<System.DateTime> _lastTransactionDate;
		private System.Boolean _primacyIndicator;
		private noteFeed _notes;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="financialAccountFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public financialAccountFeedEntrySchema()
		{
		}

		#region Properties


		[SMEEnumProperty(EnumTypeName="uuid--type", Label="FinancialAccount Global ID", Pattern="[0-9a-fA-F-]+", Name="uuid", Namespace="http://schemas.sage.com/crmErp/2008", IsUniqueKey=true)]			
		public virtual new string uuid { get { return _uuid; } set { SetProperty(Propertyuuid, ref _uuid, value); } }

		[SMEStringProperty(Label="FinancialAccount Application ID", Name="id", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual new System.String id { get { return _id; } set { SetProperty(Propertyid, ref _id, value); } }

		[SMEBoolProperty(Label="FinancialAccount Active Flag", Name="active", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEBoolProperty(Label="FinancialAccount Deleted", Name="deleted", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean deleted { get { return _deleted; } set { SetProperty(Propertydeleted, ref _deleted, value); } }

		[SMEStringProperty(Label="FinancialAccount Label", Name="label", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String label { get { return _label; } set { SetProperty(Propertylabel, ref _label, value); } }

		[SMEStringProperty(Label="FinancialAccount reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEStringProperty(Label="FinancialAccount Reference2", Nillable=true, Name="reference2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="companies")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="FinancialAccount OperatingCompany", Name="operatingCompany", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("operatingCompany")]			
		public virtual companyFeedEntry operatingCompany { get { return _operatingCompany; } set { SetProperty(PropertyoperatingCompany, ref _operatingCompany, value); } }

		[SMEEnumProperty(EnumTypeName="financialAccountType--enum", Label="FinancialAccount Type", Nillable=true, Name="type", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }

		[SMEEnumProperty(EnumTypeName="financialAccountReportingType--enum", Label="FinancialAccount Reporting Type", Nillable=true, Name="reportingType", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string reportingType { get { return _reportingType; } set { SetProperty(PropertyreportingType, ref _reportingType, value); } }

		[SMEEnumProperty(EnumTypeName="financialAccountAccountingType--enum", Label="FinancialAccount Accounting Type", Nillable=true, Name="accountingType", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string accountingType { get { return _accountingType; } set { SetProperty(PropertyaccountingType, ref _accountingType, value); } }

		[SMEStringProperty(Label="FinancialAccount Name", Name="name", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String name { get { return _name; } set { SetProperty(Propertyname, ref _name, value); } }

		[SMEStringProperty(Label="FinancialAccount Description", Nillable=true, Name="description", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String description { get { return _description; } set { SetProperty(Propertydescription, ref _description, value); } }

		[SMEStringProperty(Label="FinancialAccount Account", Nillable=true, Name="account", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String account { get { return _account; } set { SetProperty(Propertyaccount, ref _account, value); } }

		[SMEStringProperty(Label="Financial Account Analysis 01", Nillable=true, Name="analysis01", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String analysis01 { get { return _analysis01; } set { SetProperty(Propertyanalysis01, ref _analysis01, value); } }

		[SMEStringProperty(Label="Financial Account Analysis 02", Nillable=true, Name="analysis02", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String analysis02 { get { return _analysis02; } set { SetProperty(Propertyanalysis02, ref _analysis02, value); } }

		[SMEStringProperty(Label="Financial Account Analysis 03", Nillable=true, Name="analysis03", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String analysis03 { get { return _analysis03; } set { SetProperty(Propertyanalysis03, ref _analysis03, value); } }

		[SMEStringProperty(Label="Financial Account Analysis 04", Nillable=true, Name="analysis04", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String analysis04 { get { return _analysis04; } set { SetProperty(Propertyanalysis04, ref _analysis04, value); } }

		[SMEStringProperty(Label="Financial Account Analysis 05", Nillable=true, Name="analysis05", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String analysis05 { get { return _analysis05; } set { SetProperty(Propertyanalysis05, ref _analysis05, value); } }

		[SMEStringProperty(Label="Financial Account Analysis 06", Nillable=true, Name="analysis06", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String analysis06 { get { return _analysis06; } set { SetProperty(Propertyanalysis06, ref _analysis06, value); } }

		[SMEStringProperty(Label="Financial Account Analysis 07", Nillable=true, Name="analysis07", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String analysis07 { get { return _analysis07; } set { SetProperty(Propertyanalysis07, ref _analysis07, value); } }

		[SMEStringProperty(Label="Financial Account Analysis 08", Nillable=true, Name="analysis08", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String analysis08 { get { return _analysis08; } set { SetProperty(Propertyanalysis08, ref _analysis08, value); } }

		[SMEStringProperty(Label="Financial Account Analysis 09", Nillable=true, Name="analysis09", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String analysis09 { get { return _analysis09; } set { SetProperty(Propertyanalysis09, ref _analysis09, value); } }

		[SMEStringProperty(Label="Financial Account Analysis 10", Nillable=true, Name="analysis10", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String analysis10 { get { return _analysis10; } set { SetProperty(Propertyanalysis10, ref _analysis10, value); } }

		[SMEStringProperty(Label="Financial Account Analysis 11", Nillable=true, Name="analysis11", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String analysis11 { get { return _analysis11; } set { SetProperty(Propertyanalysis11, ref _analysis11, value); } }

		[SMEStringProperty(Label="Financial Account Analysis 12", Nillable=true, Name="analysis12", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String analysis12 { get { return _analysis12; } set { SetProperty(Propertyanalysis12, ref _analysis12, value); } }

		[SMEStringProperty(Label="Financial Account Analysis 13", Nillable=true, Name="analysis13", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String analysis13 { get { return _analysis13; } set { SetProperty(Propertyanalysis13, ref _analysis13, value); } }

		[SMEStringProperty(Label="Financial Account Analysis 14", Nillable=true, Name="analysis14", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String analysis14 { get { return _analysis14; } set { SetProperty(Propertyanalysis14, ref _analysis14, value); } }

		[SMEStringProperty(Label="Financial Account Analysis 15", Nillable=true, Name="analysis15", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String analysis15 { get { return _analysis15; } set { SetProperty(Propertyanalysis15, ref _analysis15, value); } }

		[SMEStringProperty(Label="FinancialAccount Currency", Name="currency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String currency { get { return _currency; } set { SetProperty(Propertycurrency, ref _currency, value); } }

		[SMEDecimalProperty(Label="FinancialAccount Balance", Nillable=true, Name="balance", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> balance { get { return _balance; } set { SetProperty(Propertybalance, ref _balance, value); } }

		[SMEDateProperty(Label="FinancialAccount Balance Date", Nillable=true, Name="balanceDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> balanceDate { get { return _balanceDate; } set { SetProperty(PropertybalanceDate, ref _balanceDate, value); } }

		[SMEDateProperty(Label="FinancialAccount Last Transaction Date", Nillable=true, Name="lastTransactionDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> lastTransactionDate { get { return _lastTransactionDate; } set { SetProperty(PropertylastTransactionDate, ref _lastTransactionDate, value); } }

		[SMEBoolProperty(Label="FinancialAccount Primacy Indicator", Name="primacyIndicator", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean primacyIndicator { get { return _primacyIndicator; } set { SetProperty(PropertyprimacyIndicator, ref _primacyIndicator, value); } }

		[SMEResource(CanGet=true, PluralName="notes")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Label="FinancialAccount Note", Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual noteFeed notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		#endregion


	}
}