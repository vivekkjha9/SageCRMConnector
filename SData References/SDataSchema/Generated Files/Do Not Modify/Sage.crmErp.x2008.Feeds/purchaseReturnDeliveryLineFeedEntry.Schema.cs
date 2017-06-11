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
	/// Defines a purchaseReturnDeliveryLine feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("purchaseReturnDeliveryLine", Namespace="http://schemas.sage.com/crmErp/2008")]
		[SMEResource(CanGet=true, PluralName="purchaseReturnDeliveryLines")]
	public class purchaseReturnDeliveryLineFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string PropertypurchaseReturnDelivery = "purchaseReturnDelivery";
		public const string Propertyuuid = "uuid";
		public const string Propertyid = "id";
		public const string Propertyactive = "active";
		public const string Propertydeleted = "deleted";
		public const string Propertylabel = "label";
		public const string Propertyreference = "reference";
		public const string Propertyreference2 = "reference2";
		public const string Propertynumber = "number";
		public const string Propertystatus = "status";
		public const string Propertycommodity = "commodity";
		public const string Propertytext = "text";
		public const string PropertycommodityVariant = "commodityVariant";
		public const string PropertycommodityDimension = "commodityDimension";
		public const string PropertyfulfillmentLocation = "fulfillmentLocation";
		public const string PropertyfulfillmentSubLocation = "fulfillmentSubLocation";
		public const string PropertyunitOfMeasure = "unitOfMeasure";
		public const string PropertyrequestedQuantity = "requestedQuantity";
		public const string PropertydeliveredQuantity = "deliveredQuantity";
		public const string Propertynotes = "notes";

		#endregion

		#region Fields

		private purchaseReturnDeliveryFeedEntry _purchaseReturnDelivery;
		private string _uuid;
		private System.String _id;
		private System.Boolean _active;
		private System.Boolean _deleted;
		private System.String _label;
		private System.String _reference;
		private System.String _reference2;
		private System.Decimal _number;
		private string _status;
		private commodityFeedEntry _commodity;
		private System.String _text;
		private commodityVariantFeedEntry _commodityVariant;
		private commodityDimensionFeedEntry _commodityDimension;
		private locationFeedEntry _fulfillmentLocation;
		private locationFeedEntry _fulfillmentSubLocation;
		private unitOfMeasureFeedEntry _unitOfMeasure;
		private System.Decimal _requestedQuantity;
		private System.Decimal _deliveredQuantity;
		private noteFeedEntry _notes;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="purchaseReturnDeliveryLineFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public purchaseReturnDeliveryLineFeedEntrySchema()
		{
		}

		#region Properties


		[SMEResource(CanGet=true, PluralName="purchaseReturnDeliveries", Label="PurchaseReturnDelivery")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Parent, Label="PurchaseReturnDelivery", Name="purchaseReturnDelivery", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("purchaseReturnDelivery")]			
		public virtual purchaseReturnDeliveryFeedEntry purchaseReturnDelivery { get { return _purchaseReturnDelivery; } set { SetProperty(PropertypurchaseReturnDelivery, ref _purchaseReturnDelivery, value); } }

		[SMEEnumProperty(EnumTypeName="uuid--type", Label="PurchaseReturnDeliveryLine Global ID", Pattern="[0-9a-fA-F-]+", Name="uuid", Namespace="http://schemas.sage.com/crmErp/2008", IsUniqueKey=true)]			
		public virtual new string uuid { get { return _uuid; } set { SetProperty(Propertyuuid, ref _uuid, value); } }

		[SMEStringProperty(Label="PurchaseReturnDeliveryLine Application ID", Name="id", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual new System.String id { get { return _id; } set { SetProperty(Propertyid, ref _id, value); } }

		[SMEBoolProperty(Label="PurchaseReturnDeliveryLine Active Flag", Name="active", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEBoolProperty(Label="PurchaseReturnDeliveryLine Deleted", Name="deleted", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean deleted { get { return _deleted; } set { SetProperty(Propertydeleted, ref _deleted, value); } }

		[SMEStringProperty(Label="PurchaseReturnDeliveryLine Label", Name="label", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String label { get { return _label; } set { SetProperty(Propertylabel, ref _label, value); } }

		[SMEStringProperty(Label="PurchaseReturnDeliveryLine reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEStringProperty(Label="PurchaseReturnDeliveryLine Reference2", Nillable=true, Name="reference2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }

		[SMEDecimalProperty(Label="PurchaseReturnDeliveryLine Number", Name="number", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal number { get { return _number; } set { SetProperty(Propertynumber, ref _number, value); } }

		[SMEEnumProperty(EnumTypeName="purchaseReturnDeliveryStatus--enum", Label="PurchaseReturnDeliveryLine Status", Nillable=true, Name="status", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string status { get { return _status; } set { SetProperty(Propertystatus, ref _status, value); } }

		[SMEResource(CanGet=true, PluralName="commodities", Label="PurchaseReturnDeliveryLine Commodity")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseReturnDeliveryLine Commodity", Name="commodity", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("commodity")]			
		public virtual commodityFeedEntry commodity { get { return _commodity; } set { SetProperty(Propertycommodity, ref _commodity, value); } }

		[SMEStringProperty(Label="PurchaseReturnDeliveryLine Text", Nillable=true, Name="text", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String text { get { return _text; } set { SetProperty(Propertytext, ref _text, value); } }

		[SMEResource(PluralName="commodityVariants", Label="PurchaseReturnDeliveryLine Commodity Variant")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseReturnDeliveryLine Commodity Variant", Name="commodityVariant", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("commodityVariant")]			
		public virtual commodityVariantFeedEntry commodityVariant { get { return _commodityVariant; } set { SetProperty(PropertycommodityVariant, ref _commodityVariant, value); } }

		[SMEResource(PluralName="commodityDimensions", Label="PurchaseReturnDeliveryLine Commodity Dimension")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseReturnDeliveryLine Commodity Dimension", Name="commodityDimension", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("commodityDimension")]			
		public virtual commodityDimensionFeedEntry commodityDimension { get { return _commodityDimension; } set { SetProperty(PropertycommodityDimension, ref _commodityDimension, value); } }

		[SMEResource(CanGet=true, PluralName="locations", Label="PurchaseReturnDeliveryLine Fulfillment Location")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseReturnDeliveryLine Fulfillment Location", Name="fulfillmentLocation", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("fulfillmentLocation")]			
		public virtual locationFeedEntry fulfillmentLocation { get { return _fulfillmentLocation; } set { SetProperty(PropertyfulfillmentLocation, ref _fulfillmentLocation, value); } }

		[SMEResource(CanGet=true, PluralName="locations", Label="PurchaseReturnDeliveryLine Fulfilment Sub-Location")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseReturnDeliveryLine Fulfilment Sub-Location", Name="fulfillmentSubLocation", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("fulfillmentSubLocation")]			
		public virtual locationFeedEntry fulfillmentSubLocation { get { return _fulfillmentSubLocation; } set { SetProperty(PropertyfulfillmentSubLocation, ref _fulfillmentSubLocation, value); } }

		[SMEResource(CanGet=true, PluralName="unitsOfMeasure", Label="PurchaseReturnDeliveryLine UnitOfMeasure")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="PurchaseReturnDeliveryLine UnitOfMeasure", Name="unitOfMeasure", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("unitOfMeasure")]			
		public virtual unitOfMeasureFeedEntry unitOfMeasure { get { return _unitOfMeasure; } set { SetProperty(PropertyunitOfMeasure, ref _unitOfMeasure, value); } }

		[SMEDecimalProperty(Label="PurchaseReturnDeliveryLine Requested Quantity", Name="requestedQuantity", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal requestedQuantity { get { return _requestedQuantity; } set { SetProperty(PropertyrequestedQuantity, ref _requestedQuantity, value); } }

		[SMEDecimalProperty(Label="PurchaseReturnDeliveryLine Delivered Quantity", Name="deliveredQuantity", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Decimal deliveredQuantity { get { return _deliveredQuantity; } set { SetProperty(PropertydeliveredQuantity, ref _deliveredQuantity, value); } }

		[SMEResource(CanGet=true, PluralName="notes", Label="PurchaseReturnDeliveryLine Note")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, Label="PurchaseReturnDeliveryLine Note", Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("notes")]			
		public virtual noteFeedEntry notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		#endregion


	}
}