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
	/// Defines a opportunity feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("opportunity", Namespace="http://schemas.sage.com/crmErp/2008")]
		[SMEResource(CanGet=true, PluralName="opportunities")]
	public class opportunityFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyid = "id";
		public const string Propertyactive = "active";
		public const string Propertydeleted = "deleted";
		public const string Propertylabel = "label";
		public const string Propertystatus = "status";
		public const string PropertystatusFlag = "statusFlag";
		public const string PropertystatusFlagText = "statusFlagText";
		public const string Propertyreference = "reference";
		public const string PropertyoperatingCompany = "operatingCompany";
		public const string Propertyname = "name";
		public const string Propertydescription = "description";
		public const string Propertycompany = "company";
		public const string PropertycompanyReference = "companyReference";
		public const string Propertycustomer = "customer";
		public const string PropertycustomerReference = "customerReference";
		public const string PropertycustomerTradingAccount = "customerTradingAccount";
		public const string PropertytradingAccountReference = "tradingAccountReference";
		public const string Propertycommodities = "commodities";
		public const string Propertytext = "text";
		public const string Propertycurrency = "currency";
		public const string PropertyoperatingCompanyCurrency = "operatingCompanyCurrency";
		public const string PropertyoperatingCompanyCurrencyExchangeRate = "operatingCompanyCurrencyExchangeRate";
		public const string PropertyoperatingCompanyCurrencyExchangeRateOperator = "operatingCompanyCurrencyExchangeRateOperator";
		public const string PropertyoperatingCompanyCurrencyExchangeRateDate = "operatingCompanyCurrencyExchangeRateDate";
		public const string Propertycontacts = "contacts";
		public const string Propertysource = "source";
		public const string Propertysalesperson = "salesperson";
		public const string Propertydate = "date";
		public const string PropertycloseDate = "closeDate";
		public const string PropertyopenDays = "openDays";
		public const string Propertypriority = "priority";
		public const string PropertyprobabilityIndicatorType = "probabilityIndicatorType";
		public const string PropertyprobabilityIndicatorstring = "probabilityIndicatorstring";
		public const string PropertyprobabilityIndicatorPercent = "probabilityIndicatorPercent";
		public const string PropertyworkflowIndicator1 = "workflowIndicator1";
		public const string PropertyworkflowIndicator2 = "workflowIndicator2";
		public const string PropertynetTotal = "netTotal";
		public const string PropertydiscountTotal = "discountTotal";
		public const string PropertychargesTotal = "chargesTotal";
		public const string PropertytaxTotal = "taxTotal";
		public const string PropertygrossTotal = "grossTotal";
		public const string PropertycostTotal = "costTotal";
		public const string PropertyprofitTotal = "profitTotal";
		public const string PropertyquotationNetTotal = "quotationNetTotal";
		public const string PropertyquotationDiscountTotal = "quotationDiscountTotal";
		public const string PropertyquotationChargesTotal = "quotationChargesTotal";
		public const string PropertyquotationTaxTotal = "quotationTaxTotal";
		public const string PropertyquotationGrossTotal = "quotationGrossTotal";
		public const string PropertyquotationCostTotal = "quotationCostTotal";
		public const string PropertyquotationProfitTotal = "quotationProfitTotal";
		public const string PropertysalesQuotations = "salesQuotations";
		public const string PropertyorderNetTotal = "orderNetTotal";
		public const string PropertyorderDiscountTotal = "orderDiscountTotal";
		public const string PropertyorderChargesTotal = "orderChargesTotal";
		public const string PropertyorderTaxTotal = "orderTaxTotal";
		public const string PropertyorderGrossTotal = "orderGrossTotal";
		public const string PropertyorderCostTotal = "orderCostTotal";
		public const string PropertyorderProfitTotal = "orderProfitTotal";
		public const string PropertysalesOrders = "salesOrders";
		public const string Propertyinteractions = "interactions";
		public const string PropertyprivacyFlag = "privacyFlag";
		public const string Propertynotes = "notes";

		#endregion

		#region Fields

		private System.String _id;
		private System.Boolean _active;
		private System.Boolean _deleted;
		private System.String _label;
		private string _status;
		private Nullable<System.Boolean> _statusFlag;
		private System.String _statusFlagText;
		private System.String _reference;
		private companyFeedEntry _operatingCompany;
		private System.String _name;
		private System.String _description;
		private companyFeedEntry _company;
		private System.String _companyReference;
		private customerFeedEntry _customer;
		private System.String _customerReference;
		private tradingAccountFeedEntry _customerTradingAccount;
		private System.String _tradingAccountReference;
		private commodityFeed _commodities;
		private System.String _text;
		private System.String _currency;
		private System.String _operatingCompanyCurrency;
		private Nullable<System.Decimal> _operatingCompanyCurrencyExchangeRate;
		private string _operatingCompanyCurrencyExchangeRateOperator;
		private Nullable<System.DateTime> _operatingCompanyCurrencyExchangeRateDate;
		private contactFeed _contacts;
		private System.String _source;
		private salesPersonFeed _salesperson;
		private Nullable<System.DateTime> _date;
		private Nullable<System.DateTime> _closeDate;
		private System.String _openDays;
		private string _priority;
		private string _probabilityIndicatorType;
		private System.String _probabilityIndicatorstring;
		private Nullable<System.Decimal> _probabilityIndicatorPercent;
		private System.String _workflowIndicator1;
		private System.String _workflowIndicator2;
		private Nullable<System.Decimal> _netTotal;
		private Nullable<System.Decimal> _discountTotal;
		private Nullable<System.Decimal> _chargesTotal;
		private Nullable<System.Decimal> _taxTotal;
		private Nullable<System.Decimal> _grossTotal;
		private Nullable<System.Decimal> _costTotal;
		private Nullable<System.Decimal> _profitTotal;
		private Nullable<System.Decimal> _quotationNetTotal;
		private Nullable<System.Decimal> _quotationDiscountTotal;
		private Nullable<System.Decimal> _quotationChargesTotal;
		private Nullable<System.Decimal> _quotationTaxTotal;
		private Nullable<System.Decimal> _quotationGrossTotal;
		private Nullable<System.Decimal> _quotationCostTotal;
		private Nullable<System.Decimal> _quotationProfitTotal;
		private salesQuotationFeed _salesQuotations;
		private Nullable<System.Decimal> _orderNetTotal;
		private Nullable<System.Decimal> _orderDiscountTotal;
		private Nullable<System.Decimal> _orderChargesTotal;
		private Nullable<System.Decimal> _orderTaxTotal;
		private Nullable<System.Decimal> _orderGrossTotal;
		private Nullable<System.Decimal> _orderCostTotal;
		private Nullable<System.Decimal> _orderProfitTotal;
		private salesOrderFeed _salesOrders;
		private interactionFeed _interactions;
		private System.Boolean _privacyFlag;
		private noteFeedEntry _notes;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="opportunityFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public opportunityFeedEntrySchema()
		{
		}

		#region Properties


		[SMEStringProperty(Label="Opportunity Application ID", Name="id", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual new System.String id { get { return _id; } set { SetProperty(Propertyid, ref _id, value); } }

		[SMEBoolProperty(Label="Opportunity Active Flag", Name="active", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEBoolProperty(Label="Opportunity Deleted", Name="deleted", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean deleted { get { return _deleted; } set { SetProperty(Propertydeleted, ref _deleted, value); } }

		[SMEStringProperty(Label="Opportunity Label", Name="label", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String label { get { return _label; } set { SetProperty(Propertylabel, ref _label, value); } }

		[SMEEnumProperty(EnumTypeName="opportunityStatus--enum", Label="Opportunity Status", Nillable=true, Name="status", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string status { get { return _status; } set { SetProperty(Propertystatus, ref _status, value); } }

		[SMEBoolProperty(Label="Opportunity Status Flag", Nillable=true, Name="statusFlag", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Boolean> statusFlag { get { return _statusFlag; } set { SetProperty(PropertystatusFlag, ref _statusFlag, value); } }

		[SMEStringProperty(Label="Opportunity Status Flag Text", Nillable=true, Name="statusFlagText", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String statusFlagText { get { return _statusFlagText; } set { SetProperty(PropertystatusFlagText, ref _statusFlagText, value); } }

		[SMEStringProperty(Label="Opportunity reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="companies")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Opportunity OperatingCompany", Name="operatingCompany", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("operatingCompany")]			
		public virtual companyFeedEntry operatingCompany { get { return _operatingCompany; } set { SetProperty(PropertyoperatingCompany, ref _operatingCompany, value); } }

		[SMEStringProperty(Label="Opportunity Name", Nillable=true, Name="name", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String name { get { return _name; } set { SetProperty(Propertyname, ref _name, value); } }

		[SMEStringProperty(Label="Opportunity Description", Nillable=true, Name="description", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String description { get { return _description; } set { SetProperty(Propertydescription, ref _description, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="companies")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Opportunity Company", Name="company", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("company")]			
		public virtual companyFeedEntry company { get { return _company; } set { SetProperty(Propertycompany, ref _company, value); } }

		[SMEStringProperty(Label="Opportunity Company reference", Nillable=true, Name="companyReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String companyReference { get { return _companyReference; } set { SetProperty(PropertycompanyReference, ref _companyReference, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="customers")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Opportunity Customer ", Name="customer", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("customer")]			
		public virtual customerFeedEntry customer { get { return _customer; } set { SetProperty(Propertycustomer, ref _customer, value); } }

		[SMEStringProperty(Label="Opportunity Customer reference", Nillable=true, Name="customerReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String customerReference { get { return _customerReference; } set { SetProperty(PropertycustomerReference, ref _customerReference, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Opportunity Customer TradingAccount", Name="customerTradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("customerTradingAccount")]			
		public virtual tradingAccountFeedEntry customerTradingAccount { get { return _customerTradingAccount; } set { SetProperty(PropertycustomerTradingAccount, ref _customerTradingAccount, value); } }

		[SMEStringProperty(Label="Opportunity Customer TradingAccount reference", Nillable=true, Name="tradingAccountReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String tradingAccountReference { get { return _tradingAccountReference; } set { SetProperty(PropertytradingAccountReference, ref _tradingAccountReference, value); } }

		[SMEResource(CanGet=true, PluralName="commodities", Label="Opportunity Commodity")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Opportunity Commodity", Name="commodities", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual commodityFeed commodities { get { return _commodities; } set { SetProperty(Propertycommodities, ref _commodities, value); } }

		[SMEStringProperty(Label="Opportunity Commodity Text", Nillable=true, Name="text", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String text { get { return _text; } set { SetProperty(Propertytext, ref _text, value); } }

		[SMEStringProperty(Label="Opportunity Currency", Nillable=true, Name="currency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String currency { get { return _currency; } set { SetProperty(Propertycurrency, ref _currency, value); } }

		[SMEStringProperty(Label="Opportunity OperatingCompany Currency", Name="operatingCompanyCurrency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String operatingCompanyCurrency { get { return _operatingCompanyCurrency; } set { SetProperty(PropertyoperatingCompanyCurrency, ref _operatingCompanyCurrency, value); } }

		[SMEDecimalProperty(Label="Opportunity OperatingCompany Currency Exchange Rate", Nillable=true, Name="operatingCompanyCurrencyExchangeRate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> operatingCompanyCurrencyExchangeRate { get { return _operatingCompanyCurrencyExchangeRate; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRate, ref _operatingCompanyCurrencyExchangeRate, value); } }

		[SMEEnumProperty(EnumTypeName="RateOperator--enum", Label="Opportunity OperatingCompany Currency Exchange Rate Operator", Nillable=true, Name="operatingCompanyCurrencyExchangeRateOperator", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string operatingCompanyCurrencyExchangeRateOperator { get { return _operatingCompanyCurrencyExchangeRateOperator; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRateOperator, ref _operatingCompanyCurrencyExchangeRateOperator, value); } }

		[SMEDateProperty(Label="Opportunity OperatingCompany Currency Exchange Rate Date", Nillable=true, Name="operatingCompanyCurrencyExchangeRateDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> operatingCompanyCurrencyExchangeRateDate { get { return _operatingCompanyCurrencyExchangeRateDate; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRateDate, ref _operatingCompanyCurrencyExchangeRateDate, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="contacts", Label="Opportunity Contact")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Opportunity Contact", Name="contacts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual contactFeed contacts { get { return _contacts; } set { SetProperty(Propertycontacts, ref _contacts, value); } }

		[SMEStringProperty(Label="Opportunity Source", Nillable=true, Name="source", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual new System.String source { get { return _source; } set { SetProperty(Propertysource, ref _source, value); } }

		[SMEResource(PluralName="salesPersons", Label="Opportunity Salesperson")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Opportunity Salesperson", Name="salesperson", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesPersonFeed salesperson { get { return _salesperson; } set { SetProperty(Propertysalesperson, ref _salesperson, value); } }

		[SMEDateProperty(Label="Opportunity Date", Nillable=true, Name="date", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> date { get { return _date; } set { SetProperty(Propertydate, ref _date, value); } }

		[SMEDateProperty(Label="Opportunity Close Date", Nillable=true, Name="closeDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> closeDate { get { return _closeDate; } set { SetProperty(PropertycloseDate, ref _closeDate, value); } }

		[SMEStringProperty(Label="Opportunity Open Days", Nillable=true, Name="openDays", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String openDays { get { return _openDays; } set { SetProperty(PropertyopenDays, ref _openDays, value); } }

		[SMEEnumProperty(EnumTypeName="opportunityPriority--enum", Label="Opportunity Priority", Nillable=true, Name="priority", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string priority { get { return _priority; } set { SetProperty(Propertypriority, ref _priority, value); } }

		[SMEEnumProperty(EnumTypeName="opportunityProbabilityIndicatorType--enum", Label="Opportunity Probability Indicator Type", Nillable=true, Name="probabilityIndicatorType", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string probabilityIndicatorType { get { return _probabilityIndicatorType; } set { SetProperty(PropertyprobabilityIndicatorType, ref _probabilityIndicatorType, value); } }

		[SMEStringProperty(Label="Opportunity Probability Indicator String", Nillable=true, Name="probabilityIndicatorstring", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String probabilityIndicatorstring { get { return _probabilityIndicatorstring; } set { SetProperty(PropertyprobabilityIndicatorstring, ref _probabilityIndicatorstring, value); } }

		[SMEDecimalProperty(Label="Opportunity Probability Indicator Percent", Nillable=true, Name="probabilityIndicatorPercent", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> probabilityIndicatorPercent { get { return _probabilityIndicatorPercent; } set { SetProperty(PropertyprobabilityIndicatorPercent, ref _probabilityIndicatorPercent, value); } }

		[SMEStringProperty(Label="Opportunity Workflow Indicator1", Nillable=true, Name="workflowIndicator1", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String workflowIndicator1 { get { return _workflowIndicator1; } set { SetProperty(PropertyworkflowIndicator1, ref _workflowIndicator1, value); } }

		[SMEStringProperty(Label="Opportunity Workflow Indicator2", Nillable=true, Name="workflowIndicator2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String workflowIndicator2 { get { return _workflowIndicator2; } set { SetProperty(PropertyworkflowIndicator2, ref _workflowIndicator2, value); } }

		[SMEDecimalProperty(Label="Opportunity Net Total", Nillable=true, Name="netTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> netTotal { get { return _netTotal; } set { SetProperty(PropertynetTotal, ref _netTotal, value); } }

		[SMEDecimalProperty(Label="Opportunity Discount Total", Nillable=true, Name="discountTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> discountTotal { get { return _discountTotal; } set { SetProperty(PropertydiscountTotal, ref _discountTotal, value); } }

		[SMEDecimalProperty(Label="Opportunity Charges Total", Nillable=true, Name="chargesTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> chargesTotal { get { return _chargesTotal; } set { SetProperty(PropertychargesTotal, ref _chargesTotal, value); } }

		[SMEDecimalProperty(Label="Opportunity Tax Total", Nillable=true, Name="taxTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> taxTotal { get { return _taxTotal; } set { SetProperty(PropertytaxTotal, ref _taxTotal, value); } }

		[SMEDecimalProperty(Label="Opportunity Gross Total", Nillable=true, Name="grossTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> grossTotal { get { return _grossTotal; } set { SetProperty(PropertygrossTotal, ref _grossTotal, value); } }

		[SMEDecimalProperty(Label="Opportunity Cost Total", Nillable=true, Name="costTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> costTotal { get { return _costTotal; } set { SetProperty(PropertycostTotal, ref _costTotal, value); } }

		[SMEDecimalProperty(Label="Opportunity Profit Total", Nillable=true, Name="profitTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> profitTotal { get { return _profitTotal; } set { SetProperty(PropertyprofitTotal, ref _profitTotal, value); } }

		[SMEDecimalProperty(Label="Opportunity Quotation Net Total", Nillable=true, Name="quotationNetTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> quotationNetTotal { get { return _quotationNetTotal; } set { SetProperty(PropertyquotationNetTotal, ref _quotationNetTotal, value); } }

		[SMEDecimalProperty(Label="Opportunity Quotation Discount Total", Nillable=true, Name="quotationDiscountTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> quotationDiscountTotal { get { return _quotationDiscountTotal; } set { SetProperty(PropertyquotationDiscountTotal, ref _quotationDiscountTotal, value); } }

		[SMEDecimalProperty(Label="Opportunity Quotation Charges Total", Nillable=true, Name="quotationChargesTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> quotationChargesTotal { get { return _quotationChargesTotal; } set { SetProperty(PropertyquotationChargesTotal, ref _quotationChargesTotal, value); } }

		[SMEDecimalProperty(Label="Opportunity Quotation Tax Total", Nillable=true, Name="quotationTaxTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> quotationTaxTotal { get { return _quotationTaxTotal; } set { SetProperty(PropertyquotationTaxTotal, ref _quotationTaxTotal, value); } }

		[SMEDecimalProperty(Label="Opportunity Quotation Gross Total", Nillable=true, Name="quotationGrossTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> quotationGrossTotal { get { return _quotationGrossTotal; } set { SetProperty(PropertyquotationGrossTotal, ref _quotationGrossTotal, value); } }

		[SMEDecimalProperty(Label="Opportunity Quotation Cost Total", Nillable=true, Name="quotationCostTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> quotationCostTotal { get { return _quotationCostTotal; } set { SetProperty(PropertyquotationCostTotal, ref _quotationCostTotal, value); } }

		[SMEDecimalProperty(Label="Opportunity Quotation Profit Total", Nillable=true, Name="quotationProfitTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> quotationProfitTotal { get { return _quotationProfitTotal; } set { SetProperty(PropertyquotationProfitTotal, ref _quotationProfitTotal, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, PluralName="salesQuotations", Label="Opportunity SalesQuotation")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Opportunity SalesQuotation", Name="salesQuotations", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesQuotationFeed salesQuotations { get { return _salesQuotations; } set { SetProperty(PropertysalesQuotations, ref _salesQuotations, value); } }

		[SMEDecimalProperty(Label="Opportunity Order Net Total", Nillable=true, Name="orderNetTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> orderNetTotal { get { return _orderNetTotal; } set { SetProperty(PropertyorderNetTotal, ref _orderNetTotal, value); } }

		[SMEDecimalProperty(Label="Opportunity Order Discount Total", Nillable=true, Name="orderDiscountTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> orderDiscountTotal { get { return _orderDiscountTotal; } set { SetProperty(PropertyorderDiscountTotal, ref _orderDiscountTotal, value); } }

		[SMEDecimalProperty(Label="Opportunity Order Charges Total", Nillable=true, Name="orderChargesTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> orderChargesTotal { get { return _orderChargesTotal; } set { SetProperty(PropertyorderChargesTotal, ref _orderChargesTotal, value); } }

		[SMEDecimalProperty(Label="Opportunity Order Tax Total", Nillable=true, Name="orderTaxTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> orderTaxTotal { get { return _orderTaxTotal; } set { SetProperty(PropertyorderTaxTotal, ref _orderTaxTotal, value); } }

		[SMEDecimalProperty(Label="Opportunity Order Gross Total", Nillable=true, Name="orderGrossTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> orderGrossTotal { get { return _orderGrossTotal; } set { SetProperty(PropertyorderGrossTotal, ref _orderGrossTotal, value); } }

		[SMEDecimalProperty(Label="Opportunity Order Cost Total", Nillable=true, Name="orderCostTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> orderCostTotal { get { return _orderCostTotal; } set { SetProperty(PropertyorderCostTotal, ref _orderCostTotal, value); } }

		[SMEDecimalProperty(Label="Opportunity Order Profit Total", Nillable=true, Name="orderProfitTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> orderProfitTotal { get { return _orderProfitTotal; } set { SetProperty(PropertyorderProfitTotal, ref _orderProfitTotal, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, PluralName="salesOrders", Label="Opportunity SalesOrder")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Opportunity SalesOrder", Name="salesOrders", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesOrderFeed salesOrders { get { return _salesOrders; } set { SetProperty(PropertysalesOrders, ref _salesOrders, value); } }

		[SMEResource(CanGet=true, PluralName="interactions", Label="Opportunity Interaction")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Opportunity Interaction", Name="interactions", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual interactionFeed interactions { get { return _interactions; } set { SetProperty(Propertyinteractions, ref _interactions, value); } }

		[SMEBoolProperty(Label="Opportunity Privacy Flag", Name="privacyFlag", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean privacyFlag { get { return _privacyFlag; } set { SetProperty(PropertyprivacyFlag, ref _privacyFlag, value); } }

		[SMEResource(CanGet=true, PluralName="notes", Label="Opportunity Note")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, Label="Opportunity Note", Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("notes")]			
		public virtual noteFeedEntry notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		#endregion


	}
}