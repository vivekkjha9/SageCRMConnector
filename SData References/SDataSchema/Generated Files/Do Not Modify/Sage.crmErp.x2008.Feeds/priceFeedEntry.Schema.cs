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
	/// Defines a price feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("price", Namespace="http://schemas.sage.com/crmErp/2008")]
		[SMEResource(CanGet=true, PluralName="prices")]
	public class priceFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyid = "id";
		public const string Propertyactive = "active";
		public const string Propertydeleted = "deleted";
		public const string Propertylabel = "label";
		public const string Propertyreference = "reference";
		public const string Propertystatus = "status";
		public const string PropertycustomerSupplierFlag = "customerSupplierFlag";
		public const string Propertycustomers = "customers";
		public const string Propertysuppliers = "suppliers";
		public const string PropertytradingAccounts = "tradingAccounts";
		public const string Propertycommodity = "commodity";
		public const string Propertypricelist = "pricelist";
		public const string PropertyunitOfMeasure = "unitOfMeasure";
		public const string Propertylocation = "location";
		public const string PropertypostalAddress = "postalAddress";
		public const string Propertycurrency = "currency";
		public const string PropertyoperatingCompanyCurrency = "operatingCompanyCurrency";
		public const string PropertyoperatingCompanyCurrencyExchangeRate = "operatingCompanyCurrencyExchangeRate";
		public const string PropertyoperatingCompanyCurrencyExchangeRateOperator = "operatingCompanyCurrencyExchangeRateOperator";
		public const string PropertyoperatingCompanyCurrencyExchangeRateDate = "operatingCompanyCurrencyExchangeRateDate";
		public const string PropertydecimalPlaces = "decimalPlaces";
		public const string Propertyprice = "price";
		public const string PropertyincludesTax = "includesTax";
		public const string PropertystartDate = "startDate";
		public const string PropertyendDate = "endDate";
		public const string Propertynotes = "notes";

		#endregion

		#region Fields

		private System.String _id;
		private System.Boolean _active;
		private System.Boolean _deleted;
		private System.String _label;
		private System.String _reference;
		private System.String _status;
		private string _customerSupplierFlag;
		private customerFeed _customers;
		private supplierFeed _suppliers;
		private tradingAccountFeed _tradingAccounts;
		private commodityFeedEntry _commodity;
		private priceListFeedEntry _pricelist;
		private unitOfMeasureFeedEntry _unitOfMeasure;
		private locationFeed _location;
		private postalAddressFeed _postalAddress;
		private System.String _currency;
		private System.String _operatingCompanyCurrency;
		private Nullable<System.Decimal> _operatingCompanyCurrencyExchangeRate;
		private string _operatingCompanyCurrencyExchangeRateOperator;
		private Nullable<System.DateTime> _operatingCompanyCurrencyExchangeRateDate;
		private Nullable<System.Decimal> _decimalPlaces;
		private System.Decimal _price;
		private Nullable<System.Boolean> _includesTax;
		private Nullable<System.DateTime> _startDate;
		private Nullable<System.DateTime> _endDate;
		private noteFeed _notes;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="priceFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public priceFeedEntrySchema()
		{
		}

		#region Properties


		[SMEStringProperty(Label="Price Application ID", Name="id", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual new System.String id { get { return _id; } set { SetProperty(Propertyid, ref _id, value); } }

		[SMEBoolProperty(Label="Price Active Flag", Name="active", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEBoolProperty(Label="Price Deleted", Name="deleted", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean deleted { get { return _deleted; } set { SetProperty(Propertydeleted, ref _deleted, value); } }

		[SMEStringProperty(Label="Price Label", Name="label", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String label { get { return _label; } set { SetProperty(Propertylabel, ref _label, value); } }

		[SMEStringProperty(Label="Price Reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEStringProperty(Label="Price Status", Nillable=true, Name="status", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String status { get { return _status; } set { SetProperty(Propertystatus, ref _status, value); } }

		[SMEEnumProperty(EnumTypeName="priceCustomerSupplierFlag--enum", Label="Price Customer Supplier Flag", Nillable=true, Name="customerSupplierFlag", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string customerSupplierFlag { get { return _customerSupplierFlag; } set { SetProperty(PropertycustomerSupplierFlag, ref _customerSupplierFlag, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="customers", Label="Price Customer ")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Price Customer ", Name="customers", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual customerFeed customers { get { return _customers; } set { SetProperty(Propertycustomers, ref _customers, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="suppliers", Label="Price Supplier")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Price Supplier", Name="suppliers", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual supplierFeed suppliers { get { return _suppliers; } set { SetProperty(Propertysuppliers, ref _suppliers, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Price Trading Account", Name="tradingAccounts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual tradingAccountFeed tradingAccounts { get { return _tradingAccounts; } set { SetProperty(PropertytradingAccounts, ref _tradingAccounts, value); } }

		[SMEResource(CanGet=true, PluralName="commodities", Label="Price Commodity")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Price Commodity", Name="commodity", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("commodity")]			
		public virtual commodityFeedEntry commodity { get { return _commodity; } set { SetProperty(Propertycommodity, ref _commodity, value); } }

		[SMEResource(CanGet=true, PluralName="priceLists", Label="Price PriceList")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Price PriceList", Name="pricelist", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("pricelist")]			
		public virtual priceListFeedEntry pricelist { get { return _pricelist; } set { SetProperty(Propertypricelist, ref _pricelist, value); } }

		[SMEResource(CanGet=true, PluralName="unitsOfMeasure", Label="Price UnitOfMeasure")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Price UnitOfMeasure", Name="unitOfMeasure", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("unitOfMeasure")]			
		public virtual unitOfMeasureFeedEntry unitOfMeasure { get { return _unitOfMeasure; } set { SetProperty(PropertyunitOfMeasure, ref _unitOfMeasure, value); } }

		[SMEResource(CanGet=true, PluralName="locations", Label="Price Location")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Price Location", Name="location", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual locationFeed location { get { return _location; } set { SetProperty(Propertylocation, ref _location, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="postalAddresses")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Price PostalAddress", Name="postalAddress", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual postalAddressFeed postalAddress { get { return _postalAddress; } set { SetProperty(PropertypostalAddress, ref _postalAddress, value); } }

		[SMEStringProperty(Label="Price Currency", Name="currency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String currency { get { return _currency; } set { SetProperty(Propertycurrency, ref _currency, value); } }

		[SMEStringProperty(Label="Price OperatingCompany Currency", Name="operatingCompanyCurrency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String operatingCompanyCurrency { get { return _operatingCompanyCurrency; } set { SetProperty(PropertyoperatingCompanyCurrency, ref _operatingCompanyCurrency, value); } }

		[SMEDecimalProperty(Label="Price OperatingCompany Currency Exchange Rate", Nillable=true, Name="operatingCompanyCurrencyExchangeRate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> operatingCompanyCurrencyExchangeRate { get { return _operatingCompanyCurrencyExchangeRate; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRate, ref _operatingCompanyCurrencyExchangeRate, value); } }

		[SMEEnumProperty(EnumTypeName="RateOperator--enum", Label="Price OperatingCompany Currency Exchange Rate Operator", Nillable=true, Name="operatingCompanyCurrencyExchangeRateOperator", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string operatingCompanyCurrencyExchangeRateOperator { get { return _operatingCompanyCurrencyExchangeRateOperator; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRateOperator, ref _operatingCompanyCurrencyExchangeRateOperator, value); } }

		[SMEDateProperty(Label="Price OperatingCompany Currency Exchange Rate Date", Nillable=true, Name="operatingCompanyCurrencyExchangeRateDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> operatingCompanyCurrencyExchangeRateDate { get { return _operatingCompanyCurrencyExchangeRateDate; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRateDate, ref _operatingCompanyCurrencyExchangeRateDate, value); } }

		[SMEDecimalProperty(Label="Price Decimal Places", Nillable=true, Name="decimalPlaces", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> decimalPlaces { get { return _decimalPlaces; } set { SetProperty(PropertydecimalPlaces, ref _decimalPlaces, value); } }

		[SMEDecimalProperty(Label="Price", Name="price", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal price { get { return _price; } set { SetProperty(Propertyprice, ref _price, value); } }

		[SMEBoolProperty(Label="Price Includes Tax", Nillable=true, Name="includesTax", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Boolean> includesTax { get { return _includesTax; } set { SetProperty(PropertyincludesTax, ref _includesTax, value); } }

		[SMEDateProperty(Label="Price Start Date", Nillable=true, Name="startDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> startDate { get { return _startDate; } set { SetProperty(PropertystartDate, ref _startDate, value); } }

		[SMEDateProperty(Label="Price End Date", Nillable=true, Name="endDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> endDate { get { return _endDate; } set { SetProperty(PropertyendDate, ref _endDate, value); } }

		[SMEResource(CanGet=true, PluralName="notes")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Label="Price Note", Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual noteFeed notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		#endregion


	}
}