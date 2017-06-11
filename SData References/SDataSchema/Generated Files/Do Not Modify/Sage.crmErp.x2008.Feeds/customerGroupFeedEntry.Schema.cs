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
	/// Defines a customerGroup feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("customerGroup", Namespace="http://schemas.sage.com/crmErp/2008")]
		[SMEResource(CanGet=true, PluralName="customerGroups")]
	public class customerGroupFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyid = "id";
		public const string Propertyactive = "active";
		public const string Propertydeleted = "deleted";
		public const string Propertylabel = "label";
		public const string Propertyreference = "reference";
		public const string PropertyoperatingCompany = "operatingCompany";
		public const string Propertyname = "name";
		public const string Propertydescription = "description";
		public const string PropertyassociatedCustomerGroup = "associatedCustomerGroup";
		public const string PropertyCustomers = "Customers";
		public const string Propertynotes = "notes";

		#endregion

		#region Fields

		private System.String _id;
		private System.Boolean _active;
		private System.Boolean _deleted;
		private System.String _label;
		private System.String _reference;
		private companyFeedEntry _operatingCompany;
		private System.String _name;
		private System.String _description;
		private customerGroupFeed _associatedCustomerGroup;
		private customerFeed _Customers;
		private noteFeed _notes;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="customerGroupFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public customerGroupFeedEntrySchema()
		{
		}

		#region Properties


		[SMEStringProperty(Label="CustomerGroup Application ID", Name="id", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual new System.String id { get { return _id; } set { SetProperty(Propertyid, ref _id, value); } }

		[SMEBoolProperty(Label="CustomerGroup Active Flag", Name="active", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEBoolProperty(Label="CustomerGroup Deleted", Name="deleted", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean deleted { get { return _deleted; } set { SetProperty(Propertydeleted, ref _deleted, value); } }

		[SMEStringProperty(Label="CustomerGroup Label", Name="label", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String label { get { return _label; } set { SetProperty(Propertylabel, ref _label, value); } }

		[SMEStringProperty(Label="CustomerGroup Reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="companies")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="CustomerGroup OperatingCompany", Name="operatingCompany", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("operatingCompany")]			
		public virtual companyFeedEntry operatingCompany { get { return _operatingCompany; } set { SetProperty(PropertyoperatingCompany, ref _operatingCompany, value); } }

		[SMEStringProperty(Label="CustomerGroup Name", Name="name", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String name { get { return _name; } set { SetProperty(Propertyname, ref _name, value); } }

		[SMEStringProperty(Label="CustomerGroup Description", Nillable=true, Name="description", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String description { get { return _description; } set { SetProperty(Propertydescription, ref _description, value); } }

		[SMEResource(CanGet=true, PluralName="customerGroups", Label="CustomerGroup Associated CustomerGroup")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="CustomerGroup Associated CustomerGroup", Name="associatedCustomerGroup", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual customerGroupFeed associatedCustomerGroup { get { return _associatedCustomerGroup; } set { SetProperty(PropertyassociatedCustomerGroup, ref _associatedCustomerGroup, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="customers", Label="CustomerGroup Customer")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Label="CustomerGroup Customer", Name="Customers", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual customerFeed Customers { get { return _Customers; } set { SetProperty(PropertyCustomers, ref _Customers, value); } }

		[SMEResource(CanGet=true, PluralName="notes")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Label="CustomerGroup Note", Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual noteFeed notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		#endregion


	}
}