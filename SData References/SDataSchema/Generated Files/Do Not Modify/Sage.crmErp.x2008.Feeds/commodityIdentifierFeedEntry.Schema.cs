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
	/// Defines a commodityIdentifier feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("commodityIdentifier", Namespace="http://schemas.sage.com/crmErp/2008")]
		[SMEResource(CanGet=true, PluralName="commodityIdentifiers")]
	public class commodityIdentifierFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyid = "id";
		public const string Propertyactive = "active";
		public const string Propertydeleted = "deleted";
		public const string Propertylabel = "label";
		public const string Propertyreference = "reference";
		public const string Propertyreference2 = "reference2";
		public const string PropertyisUniqueFlag = "isUniqueFlag";
		public const string Propertystatus = "status";
		public const string Propertytype = "type";
		public const string PropertyinStockFlag = "inStockFlag";
		public const string Propertyname = "name";
		public const string Propertydescription = "description";
		public const string Propertycommodity = "commodity";
		public const string Propertyvariant = "variant";
		public const string Propertydimension = "dimension";
		public const string Propertyidentifier = "identifier";
		public const string Propertybarcode = "barcode";
		public const string PropertycreationDate = "creationDate";
		public const string PropertyuseByDate = "useByDate";
		public const string PropertyexpirationDate = "expirationDate";
		public const string PropertyparentCommodityIdentifier = "parentCommodityIdentifier";
		public const string PropertychildCommodityIdentifiers = "childCommodityIdentifiers";
		public const string PropertybuyingAllowed = "buyingAllowed";
		public const string Propertysupplier = "supplier";
		public const string PropertysupplierTradingAccount = "supplierTradingAccount";
		public const string PropertyoriginatorPurchaseDocumentLine = "originatorPurchaseDocumentLine";
		public const string PropertypurchaseDeliveryLine = "purchaseDeliveryLine";
		public const string PropertypurchaseQuantity = "purchaseQuantity";
		public const string PropertylastPurchaseDate = "lastPurchaseDate";
		public const string PropertysellingAllowed = "sellingAllowed";
		public const string Propertycustomer = "customer";
		public const string PropertycustomerTradingAccount = "customerTradingAccount";
		public const string PropertyoriginatorSalesDocumentLine = "originatorSalesDocumentLine";
		public const string PropertysalesDeliveryLine = "salesDeliveryLine";
		public const string PropertysaleQuantity = "saleQuantity";
		public const string PropertylastSaleDate = "lastSaleDate";
		public const string PropertymovementAllowed = "movementAllowed";
		public const string PropertymovementQuantity = "movementQuantity";
		public const string PropertylastMovementDate = "lastMovementDate";
		public const string PropertyavailableQuantity = "availableQuantity";
		public const string PropertyreservedQuantity = "reservedQuantity";
		public const string PropertytotalQuantity = "totalQuantity";
		public const string Propertylocation = "location";
		public const string PropertysubLocation = "subLocation";
		public const string Propertynotes = "notes";

		#endregion

		#region Fields

		private System.String _id;
		private System.Boolean _active;
		private System.Boolean _deleted;
		private System.String _label;
		private System.String _reference;
		private System.String _reference2;
		private System.Boolean _isUniqueFlag;
		private System.String _status;
		private string _type;
		private Nullable<System.Boolean> _inStockFlag;
		private System.String _name;
		private System.String _description;
		private commodityFeedEntry _commodity;
		private commodityVariantFeedEntry _variant;
		private commodityDimensionFeedEntry _dimension;
		private System.String _identifier;
		private System.String _barcode;
		private Nullable<System.DateTime> _creationDate;
		private Nullable<System.DateTime> _useByDate;
		private Nullable<System.DateTime> _expirationDate;
		private commodityIdentifierFeedEntry _parentCommodityIdentifier;
		private commodityIdentifierFeed _childCommodityIdentifiers;
		private Nullable<System.Boolean> _buyingAllowed;
		private supplierFeedEntry _supplier;
		private tradingAccountFeedEntry _supplierTradingAccount;
		private purchaseOrderLineFeedEntry _originatorPurchaseDocumentLine;
		private purchaseOrderDeliveryLineFeedEntry _purchaseDeliveryLine;
		private Nullable<System.Decimal> _purchaseQuantity;
		private Nullable<System.DateTime> _lastPurchaseDate;
		private Nullable<System.Boolean> _sellingAllowed;
		private customerFeed _customer;
		private tradingAccountFeedEntry _customerTradingAccount;
		private salesOrderLineFeed _originatorSalesDocumentLine;
		private salesOrderDeliveryLineFeed _salesDeliveryLine;
		private Nullable<System.Decimal> _saleQuantity;
		private Nullable<System.DateTime> _lastSaleDate;
		private Nullable<System.Boolean> _movementAllowed;
		private Nullable<System.Decimal> _movementQuantity;
		private Nullable<System.DateTime> _lastMovementDate;
		private System.Decimal _availableQuantity;
		private Nullable<System.Decimal> _reservedQuantity;
		private System.Decimal _totalQuantity;
		private locationFeedEntry _location;
		private locationFeedEntry _subLocation;
		private noteFeedEntry _notes;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="commodityIdentifierFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public commodityIdentifierFeedEntrySchema()
		{
		}

		#region Properties


		[SMEStringProperty(Label="CommodityIdentifier Application ID", Name="id", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual new System.String id { get { return _id; } set { SetProperty(Propertyid, ref _id, value); } }

		[SMEBoolProperty(Label="CommodityIdentifier Active Flag", Name="active", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEBoolProperty(Label="CommodityIdentifier Deleted", Name="deleted", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean deleted { get { return _deleted; } set { SetProperty(Propertydeleted, ref _deleted, value); } }

		[SMEStringProperty(Label="CommodityIdentifier Label", Name="label", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String label { get { return _label; } set { SetProperty(Propertylabel, ref _label, value); } }

		[SMEStringProperty(Label="CommodityIdentifier reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEStringProperty(Label="CommodityIdentifier Reference2", Nillable=true, Name="reference2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }

		[SMEBoolProperty(Label="CommodityIdentifier Unique Flag", Name="isUniqueFlag", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean isUniqueFlag { get { return _isUniqueFlag; } set { SetProperty(PropertyisUniqueFlag, ref _isUniqueFlag, value); } }

		[SMEStringProperty(Label="CommodityIdentifier Status", Nillable=true, Name="status", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String status { get { return _status; } set { SetProperty(Propertystatus, ref _status, value); } }

		[SMEEnumProperty(EnumTypeName="commodityIdentifierType--enum", Label="CommodityIdentifier Type", Nillable=true, Name="type", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }

		[SMEBoolProperty(Label="CommodityIdentifier In Stock Flag", Nillable=true, Name="inStockFlag", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Boolean> inStockFlag { get { return _inStockFlag; } set { SetProperty(PropertyinStockFlag, ref _inStockFlag, value); } }

		[SMEStringProperty(Label="CommodityIdentifier Name", Nillable=true, Name="name", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String name { get { return _name; } set { SetProperty(Propertyname, ref _name, value); } }

		[SMEStringProperty(Label="CommodityIdentifier Description", Nillable=true, Name="description", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String description { get { return _description; } set { SetProperty(Propertydescription, ref _description, value); } }

		[SMEResource(CanGet=true, PluralName="commodities", Label="CommodityIdentifier Commodity")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Parent, Label="CommodityIdentifier Commodity", Name="commodity", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("commodity")]			
		public virtual commodityFeedEntry commodity { get { return _commodity; } set { SetProperty(Propertycommodity, ref _commodity, value); } }

		[SMEResource(PluralName="commodityVariants", Label="CommodityIdentifier Variant")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="CommodityIdentifier Variant", Name="variant", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("variant")]			
		public virtual commodityVariantFeedEntry variant { get { return _variant; } set { SetProperty(Propertyvariant, ref _variant, value); } }

		[SMEResource(PluralName="commodityDimensions", Label="CommodityIdentifier Dimension")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="CommodityIdentifier Dimension", Name="dimension", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("dimension")]			
		public virtual commodityDimensionFeedEntry dimension { get { return _dimension; } set { SetProperty(Propertydimension, ref _dimension, value); } }

		[SMEStringProperty(Label="CommodityIdentifier Identifier", Nillable=true, Name="identifier", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String identifier { get { return _identifier; } set { SetProperty(Propertyidentifier, ref _identifier, value); } }

		[SMEStringProperty(Label="ComodityIdentifier Barcode", Nillable=true, Name="barcode", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String barcode { get { return _barcode; } set { SetProperty(Propertybarcode, ref _barcode, value); } }

		[SMEDateProperty(Label="CommodityIdentifier Creation Date", Nillable=true, Name="creationDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> creationDate { get { return _creationDate; } set { SetProperty(PropertycreationDate, ref _creationDate, value); } }

		[SMEDateProperty(Label="CommodityIdentifier Use By Date", Nillable=true, Name="useByDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> useByDate { get { return _useByDate; } set { SetProperty(PropertyuseByDate, ref _useByDate, value); } }

		[SMEDateProperty(Label="CommodityIdentifier Expiration Date", Nillable=true, Name="expirationDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> expirationDate { get { return _expirationDate; } set { SetProperty(PropertyexpirationDate, ref _expirationDate, value); } }

		[SMEResource(CanGet=true, PluralName="commodityIdentifiers", Label="Commodity Identifier Parent Commodity Identifier")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Parent, Label="Commodity Identifier Parent Commodity Identifier", Name="parentCommodityIdentifier", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("parentCommodityIdentifier")]			
		public virtual commodityIdentifierFeedEntry parentCommodityIdentifier { get { return _parentCommodityIdentifier; } set { SetProperty(PropertyparentCommodityIdentifier, ref _parentCommodityIdentifier, value); } }

		[SMEResource(CanGet=true, PluralName="commodityIdentifiers", Label="Commodity Identifier Child Commodity Identifier")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Label="Commodity Identifier Child Commodity Identifier", Name="childCommodityIdentifiers", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual commodityIdentifierFeed childCommodityIdentifiers { get { return _childCommodityIdentifiers; } set { SetProperty(PropertychildCommodityIdentifiers, ref _childCommodityIdentifiers, value); } }

		[SMEBoolProperty(Label="CommodityIdentifier Buying Allowed Flag", Nillable=true, Name="buyingAllowed", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Boolean> buyingAllowed { get { return _buyingAllowed; } set { SetProperty(PropertybuyingAllowed, ref _buyingAllowed, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="suppliers")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="CommodityIdentifier Supplier", Name="supplier", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("supplier")]			
		public virtual supplierFeedEntry supplier { get { return _supplier; } set { SetProperty(Propertysupplier, ref _supplier, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="CommodityIdentifier Supplier Trading Account", Name="supplierTradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("supplierTradingAccount")]			
		public virtual tradingAccountFeedEntry supplierTradingAccount { get { return _supplierTradingAccount; } set { SetProperty(PropertysupplierTradingAccount, ref _supplierTradingAccount, value); } }

		[SMEResource(CanGet=true, CanPost=true, PluralName="purchaseOrderLines", Label="CommodityIdentifier Originator Purchase Document Line reference")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="CommodityIdentifier Originator Purchase Document Line reference", Name="originatorPurchaseDocumentLine", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("originatorPurchaseDocumentLine")]			
		public virtual purchaseOrderLineFeedEntry originatorPurchaseDocumentLine { get { return _originatorPurchaseDocumentLine; } set { SetProperty(PropertyoriginatorPurchaseDocumentLine, ref _originatorPurchaseDocumentLine, value); } }

		[SMEResource(CanGet=true, PluralName="purchaseOrderDeliveryLines", Label="CommodityIdentifier PurchaseOrderDeliveryLine")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="CommodityIdentifier PurchaseOrderDeliveryLine", Name="purchaseDeliveryLine", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("purchaseDeliveryLine")]			
		public virtual purchaseOrderDeliveryLineFeedEntry purchaseDeliveryLine { get { return _purchaseDeliveryLine; } set { SetProperty(PropertypurchaseDeliveryLine, ref _purchaseDeliveryLine, value); } }

		[SMEDecimalProperty(Label="CommodityIdentifier Purchase Quantity", Nillable=true, Name="purchaseQuantity", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> purchaseQuantity { get { return _purchaseQuantity; } set { SetProperty(PropertypurchaseQuantity, ref _purchaseQuantity, value); } }

		[SMEDateProperty(Label="CommodityIdentifier Last Purchase Date", Nillable=true, Name="lastPurchaseDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> lastPurchaseDate { get { return _lastPurchaseDate; } set { SetProperty(PropertylastPurchaseDate, ref _lastPurchaseDate, value); } }

		[SMEBoolProperty(Label="CommodityIdentifier Selling Allowed Flag", Nillable=true, Name="sellingAllowed", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Boolean> sellingAllowed { get { return _sellingAllowed; } set { SetProperty(PropertysellingAllowed, ref _sellingAllowed, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="customers", Label="CommodityIdentifier Customer")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="CommodityIdentifier Customer", Name="customer", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual customerFeed customer { get { return _customer; } set { SetProperty(Propertycustomer, ref _customer, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="CommodityIdentifier Customer Trading Account", Name="customerTradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("customerTradingAccount")]			
		public virtual tradingAccountFeedEntry customerTradingAccount { get { return _customerTradingAccount; } set { SetProperty(PropertycustomerTradingAccount, ref _customerTradingAccount, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, PluralName="salesOrderLines", Label="CommodityIdentifier Originator Sales Document Line reference")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="CommodityIdentifier Originator Sales Document Line reference", Name="originatorSalesDocumentLine", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesOrderLineFeed originatorSalesDocumentLine { get { return _originatorSalesDocumentLine; } set { SetProperty(PropertyoriginatorSalesDocumentLine, ref _originatorSalesDocumentLine, value); } }

		[SMEResource(CanGet=true, PluralName="salesOrderDeliveryLines", Label="CommodityIdentifier SalesOrderDeliveryLine")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="CommodityIdentifier SalesOrderDeliveryLine", Name="salesDeliveryLine", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesOrderDeliveryLineFeed salesDeliveryLine { get { return _salesDeliveryLine; } set { SetProperty(PropertysalesDeliveryLine, ref _salesDeliveryLine, value); } }

		[SMEDecimalProperty(Label="CommodityIdentifier Sale Quantity", Nillable=true, Name="saleQuantity", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> saleQuantity { get { return _saleQuantity; } set { SetProperty(PropertysaleQuantity, ref _saleQuantity, value); } }

		[SMEDateProperty(Label="CommodityIdentifier Last Sale Date", Nillable=true, Name="lastSaleDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> lastSaleDate { get { return _lastSaleDate; } set { SetProperty(PropertylastSaleDate, ref _lastSaleDate, value); } }

		[SMEBoolProperty(Label="CommodityIdentifier Movements Allowed Flag", Nillable=true, Name="movementAllowed", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Boolean> movementAllowed { get { return _movementAllowed; } set { SetProperty(PropertymovementAllowed, ref _movementAllowed, value); } }

		[SMEDecimalProperty(Label="CommodityIdentifier Movement Quantity", Nillable=true, Name="movementQuantity", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> movementQuantity { get { return _movementQuantity; } set { SetProperty(PropertymovementQuantity, ref _movementQuantity, value); } }

		[SMEDateProperty(Label="CommodityIdentifier Last Movement Date", Nillable=true, Name="lastMovementDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> lastMovementDate { get { return _lastMovementDate; } set { SetProperty(PropertylastMovementDate, ref _lastMovementDate, value); } }

		[SMEDecimalProperty(Label="CommodityIdentifier Available Quantity", Name="availableQuantity", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal availableQuantity { get { return _availableQuantity; } set { SetProperty(PropertyavailableQuantity, ref _availableQuantity, value); } }

		[SMEDecimalProperty(Label="CommodityIdentifier Reserved Quantity", Nillable=true, Name="reservedQuantity", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> reservedQuantity { get { return _reservedQuantity; } set { SetProperty(PropertyreservedQuantity, ref _reservedQuantity, value); } }

		[SMEDecimalProperty(Label="CommodityIdentifier Total Quantity", Name="totalQuantity", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal totalQuantity { get { return _totalQuantity; } set { SetProperty(PropertytotalQuantity, ref _totalQuantity, value); } }

		[SMEResource(CanGet=true, PluralName="locations", Label="CommodityIdentifier Location")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="CommodityIdentifier Location", Name="location", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("location")]			
		public virtual locationFeedEntry location { get { return _location; } set { SetProperty(Propertylocation, ref _location, value); } }

		[SMEResource(CanGet=true, PluralName="locations", Label="CommodityIdentifier Sub-Location")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="CommodityIdentifier Sub-Location", Name="subLocation", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("subLocation")]			
		public virtual locationFeedEntry subLocation { get { return _subLocation; } set { SetProperty(PropertysubLocation, ref _subLocation, value); } }

		[SMEResource(CanGet=true, PluralName="notes", Label="CommodityIdentifier Note")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, Label="CommodityIdentifier Note", Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("notes")]			
		public virtual noteFeedEntry notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		#endregion


	}
}