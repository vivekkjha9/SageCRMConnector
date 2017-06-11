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
	/// Defines a location feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("location", Namespace="http://schemas.sage.com/crmErp/2008")]
		[SMEResource(CanGet=true, PluralName="locations")]
	public class locationFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyid = "id";
		public const string Propertyactive = "active";
		public const string Propertydeleted = "deleted";
		public const string Propertylabel = "label";
		public const string Propertytype = "type";
		public const string Propertyreference = "reference";
		public const string Propertyreference2 = "reference2";
		public const string PropertyoperatingCompany = "operatingCompany";
		public const string Propertyname = "name";
		public const string Propertydescription = "description";
		public const string PropertycustomerSupplierFlag = "customerSupplierFlag";
		public const string Propertycustomer = "customer";
		public const string Propertysupplier = "supplier";
		public const string PropertypostalAddress = "postalAddress";
		public const string PropertysaleFlag = "saleFlag";
		public const string PropertypurchaseFlag = "purchaseFlag";
		public const string PropertyopeningDays = "openingDays";
		public const string PropertyopeningTimes = "openingTimes";
		public const string PropertygPSPosition = "gPSPosition";
		public const string Propertyphones = "phones";
		public const string Propertyemails = "emails";
		public const string Propertywebsite = "website";
		public const string Propertycontacts = "contacts";
		public const string PropertytransitFlag = "transitFlag";
		public const string Propertynotes = "notes";
		public const string PropertyparentLocation = "parentLocation";
		public const string PropertychildLocation = "childLocation";

		#endregion

		#region Fields

		private System.String _id;
		private System.Boolean _active;
		private System.Boolean _deleted;
		private System.String _label;
		private System.String _type;
		private System.String _reference;
		private System.String _reference2;
		private companyFeedEntry _operatingCompany;
		private System.String _name;
		private System.String _description;
		private string _customerSupplierFlag;
		private customerFeedEntry _customer;
		private supplierFeedEntry _supplier;
		private postalAddressFeedEntry _postalAddress;
		private Nullable<System.Boolean> _saleFlag;
		private Nullable<System.Boolean> _purchaseFlag;
		private System.String _openingDays;
		private Nullable<System.DateTime> _openingTimes;
		private System.String _gPSPosition;
		private phoneNumberFeed _phones;
		private emailFeed _emails;
		private System.String _website;
		private contactFeed _contacts;
		private Nullable<System.Boolean> _transitFlag;
		private noteFeed _notes;
		private locationFeedEntry _parentLocation;
		private locationFeed _childLocation;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="locationFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public locationFeedEntrySchema()
		{
		}

		#region Properties


		[SMEStringProperty(Label="Location Application ID", Name="id", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual new System.String id { get { return _id; } set { SetProperty(Propertyid, ref _id, value); } }

		[SMEBoolProperty(Label="Location Active Flag", Name="active", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEBoolProperty(Label="Location Deleted", Name="deleted", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean deleted { get { return _deleted; } set { SetProperty(Propertydeleted, ref _deleted, value); } }

		[SMEStringProperty(Label="Location Label", Name="label", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String label { get { return _label; } set { SetProperty(Propertylabel, ref _label, value); } }

		[SMEStringProperty(Label="Location Type", Nillable=true, Name="type", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }

		[SMEStringProperty(Label="Location reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEStringProperty(Label="Location Reference2", Nillable=true, Name="reference2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="companies")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Location OperatingCompany", Name="operatingCompany", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("operatingCompany")]			
		public virtual companyFeedEntry operatingCompany { get { return _operatingCompany; } set { SetProperty(PropertyoperatingCompany, ref _operatingCompany, value); } }

		[SMEStringProperty(Label="Location Name", Name="name", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String name { get { return _name; } set { SetProperty(Propertyname, ref _name, value); } }

		[SMEStringProperty(Label="Location Description", Nillable=true, Name="description", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String description { get { return _description; } set { SetProperty(Propertydescription, ref _description, value); } }

		[SMEEnumProperty(EnumTypeName="supplierFlag--enum", Label="Location Customer Supplier Flag", Nillable=true, Name="customerSupplierFlag", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual string customerSupplierFlag { get { return _customerSupplierFlag; } set { SetProperty(PropertycustomerSupplierFlag, ref _customerSupplierFlag, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="customers")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Location Customer", Name="customer", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("customer")]			
		public virtual customerFeedEntry customer { get { return _customer; } set { SetProperty(Propertycustomer, ref _customer, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="suppliers")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Location Supplier", Name="supplier", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("supplier")]			
		public virtual supplierFeedEntry supplier { get { return _supplier; } set { SetProperty(Propertysupplier, ref _supplier, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="postalAddresses")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Location PostalAddress", Name="postalAddress", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("postalAddress")]			
		public virtual postalAddressFeedEntry postalAddress { get { return _postalAddress; } set { SetProperty(PropertypostalAddress, ref _postalAddress, value); } }

		[SMEBoolProperty(Label="Location Sale Flag", Nillable=true, Name="saleFlag", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Boolean> saleFlag { get { return _saleFlag; } set { SetProperty(PropertysaleFlag, ref _saleFlag, value); } }

		[SMEBoolProperty(Label="Location Purchase Flag", Nillable=true, Name="purchaseFlag", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Boolean> purchaseFlag { get { return _purchaseFlag; } set { SetProperty(PropertypurchaseFlag, ref _purchaseFlag, value); } }

		[SMEStringProperty(Label="Location Opening Days", Nillable=true, Name="openingDays", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String openingDays { get { return _openingDays; } set { SetProperty(PropertyopeningDays, ref _openingDays, value); } }

		[SMEDateProperty(Label="Location Opening Times", Nillable=true, Name="openingTimes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> openingTimes { get { return _openingTimes; } set { SetProperty(PropertyopeningTimes, ref _openingTimes, value); } }

		[SMEStringProperty(Label="Location GPS Position", Nillable=true, Name="gPSPosition", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String gPSPosition { get { return _gPSPosition; } set { SetProperty(PropertygPSPosition, ref _gPSPosition, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="phoneNumbers", Label="Location Phone")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Location Phone", Name="phones", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual phoneNumberFeed phones { get { return _phones; } set { SetProperty(Propertyphones, ref _phones, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="emails", Label="Location Email")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Location Email", Name="emails", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual emailFeed emails { get { return _emails; } set { SetProperty(Propertyemails, ref _emails, value); } }

		[SMEStringProperty(Label="Location Web site", Nillable=true, Name="website", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String website { get { return _website; } set { SetProperty(Propertywebsite, ref _website, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="contacts", Label="Location Contact")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="Location Contact", Name="contacts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual contactFeed contacts { get { return _contacts; } set { SetProperty(Propertycontacts, ref _contacts, value); } }

		[SMEBoolProperty(Label="Location Transit Flag", Nillable=true, Name="transitFlag", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Boolean> transitFlag { get { return _transitFlag; } set { SetProperty(PropertytransitFlag, ref _transitFlag, value); } }

		[SMEResource(CanGet=true, PluralName="notes")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Label="Location Note", Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual noteFeed notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		[SMEResource(CanGet=true, PluralName="locations", Label="Location parent Location")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Parent, Label="Location parent Location", Name="parentLocation", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("parentLocation")]			
		public virtual locationFeedEntry parentLocation { get { return _parentLocation; } set { SetProperty(PropertyparentLocation, ref _parentLocation, value); } }

		[SMEResource(CanGet=true, PluralName="locations", Label="Location child Location")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Label="Location child Location", Name="childLocation", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual locationFeed childLocation { get { return _childLocation; } set { SetProperty(PropertychildLocation, ref _childLocation, value); } }

		#endregion


	}
}