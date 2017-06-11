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
	/// Defines a calendar feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("calendar", Namespace="http://schemas.sage.com/crmErp/2008")]
		[SMEResource(CanGet=true, PluralName="calendars")]
	public class calendarFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyid = "id";
		public const string Propertyactive = "active";
		public const string Propertydeleted = "deleted";
		public const string Propertylabel = "label";
		public const string Propertyreference = "reference";
		public const string PropertyoperatingCompany = "operatingCompany";
		public const string Propertyyear = "year";
		public const string PropertyquarterNumber = "quarterNumber";
		public const string PropertyquarterText = "quarterText";
		public const string PropertymonthNumber = "monthNumber";
		public const string PropertymonthText = "monthText";
		public const string PropertyweekNumber = "weekNumber";
		public const string PropertyweekText = "weekText";
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
		private companyFeedEntry _operatingCompany;
		private System.String _year;
		private Nullable<System.Decimal> _quarterNumber;
		private System.String _quarterText;
		private Nullable<System.Decimal> _monthNumber;
		private System.String _monthText;
		private Nullable<System.Decimal> _weekNumber;
		private System.String _weekText;
		private System.String _startDate;
		private System.String _endDate;
		private noteFeed _notes;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="calendarFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public calendarFeedEntrySchema()
		{
		}

		#region Properties


		[SMEStringProperty(Label="Calendar Application ID", Name="id", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true)]			
		public virtual new System.String id { get { return _id; } set { SetProperty(Propertyid, ref _id, value); } }

		[SMEBoolProperty(Label="Calendar Active Flag", Name="active", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEBoolProperty(Label="Calendar Deleted", Name="deleted", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.Boolean deleted { get { return _deleted; } set { SetProperty(Propertydeleted, ref _deleted, value); } }

		[SMEStringProperty(Label="Calendar Label", Name="label", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String label { get { return _label; } set { SetProperty(Propertylabel, ref _label, value); } }

		[SMEStringProperty(Label="Calendar Reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="companies")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Label="Calendar OperatingCompany", Name="operatingCompany", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("operatingCompany")]			
		public virtual companyFeedEntry operatingCompany { get { return _operatingCompany; } set { SetProperty(PropertyoperatingCompany, ref _operatingCompany, value); } }

		[SMEStringProperty(Label="Calendar Year", Name="year", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String year { get { return _year; } set { SetProperty(Propertyyear, ref _year, value); } }

		[SMEDecimalProperty(Label="Calendar Quarter Number", Nillable=true, Name="quarterNumber", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> quarterNumber { get { return _quarterNumber; } set { SetProperty(PropertyquarterNumber, ref _quarterNumber, value); } }

		[SMEStringProperty(Label="Calendar Quarter Text", Nillable=true, Name="quarterText", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String quarterText { get { return _quarterText; } set { SetProperty(PropertyquarterText, ref _quarterText, value); } }

		[SMEDecimalProperty(Label="Calendar Month Number", Nillable=true, Name="monthNumber", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> monthNumber { get { return _monthNumber; } set { SetProperty(PropertymonthNumber, ref _monthNumber, value); } }

		[SMEStringProperty(Label="Calendar Month Text", Nillable=true, Name="monthText", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String monthText { get { return _monthText; } set { SetProperty(PropertymonthText, ref _monthText, value); } }

		[SMEDecimalProperty(Label="Calendar Week Number", Nillable=true, Name="weekNumber", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> weekNumber { get { return _weekNumber; } set { SetProperty(PropertyweekNumber, ref _weekNumber, value); } }

		[SMEStringProperty(Label="Calendar Week Text", Nillable=true, Name="weekText", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String weekText { get { return _weekText; } set { SetProperty(PropertyweekText, ref _weekText, value); } }

		[SMEStringProperty(Label="Calendar Start Date", Nillable=true, Name="startDate", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String startDate { get { return _startDate; } set { SetProperty(PropertystartDate, ref _startDate, value); } }

		[SMEStringProperty(Label="Calendar End Date", Nillable=true, Name="endDate", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String endDate { get { return _endDate; } set { SetProperty(PropertyendDate, ref _endDate, value); } }

		[SMEResource(CanGet=true, PluralName="notes")]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Label="Calendar Note", Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual noteFeed notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		#endregion


	}
}