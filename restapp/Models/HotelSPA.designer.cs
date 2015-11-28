﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestApp.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Hotel")]
	public partial class HotelSPADataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertRooms(Rooms instance);
    partial void UpdateRooms(Rooms instance);
    partial void DeleteRooms(Rooms instance);
    partial void InsertTreatments(Treatments instance);
    partial void UpdateTreatments(Treatments instance);
    partial void DeleteTreatments(Treatments instance);
    partial void InsertTreatmentsHistory(TreatmentsHistory instance);
    partial void UpdateTreatmentsHistory(TreatmentsHistory instance);
    partial void DeleteTreatmentsHistory(TreatmentsHistory instance);
    partial void InsertClients(Clients instance);
    partial void UpdateClients(Clients instance);
    partial void DeleteClients(Clients instance);
    #endregion
		
		public HotelSPADataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["HotelConnectionString1"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public HotelSPADataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HotelSPADataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HotelSPADataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HotelSPADataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Rooms> Rooms
		{
			get
			{
				return this.GetTable<Rooms>();
			}
		}
		
		public System.Data.Linq.Table<Treatments> Treatments
		{
			get
			{
				return this.GetTable<Treatments>();
			}
		}
		
		public System.Data.Linq.Table<TreatmentsHistory> TreatmentsHistories
		{
			get
			{
				return this.GetTable<TreatmentsHistory>();
			}
		}
		
		public System.Data.Linq.Table<Clients> Clients
		{
			get
			{
				return this.GetTable<Clients>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Rooms")]
	public partial class Rooms : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _Id;
		
		private int _Number;
		
		private int _How_many_persons;
		
		private double _Size;
		
		private double _Price;
		
		private int _Available;
		
		private EntitySet<Clients> _Clients;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(System.Guid value);
    partial void OnIdChanged();
    partial void OnNumberChanging(int value);
    partial void OnNumberChanged();
    partial void OnHow_many_personsChanging(int value);
    partial void OnHow_many_personsChanged();
    partial void OnSizeChanging(double value);
    partial void OnSizeChanged();
    partial void OnPriceChanging(double value);
    partial void OnPriceChanged();
    partial void OnAvailableChanging(int value);
    partial void OnAvailableChanged();
    #endregion
		
		public Rooms()
		{
			this._Clients = new EntitySet<Clients>(new Action<Clients>(this.attach_Clients), new Action<Clients>(this.detach_Clients));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Number", DbType="Int NOT NULL")]
		public int Number
		{
			get
			{
				return this._Number;
			}
			set
			{
				if ((this._Number != value))
				{
					this.OnNumberChanging(value);
					this.SendPropertyChanging();
					this._Number = value;
					this.SendPropertyChanged("Number");
					this.OnNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_How_many_persons", DbType="Int NOT NULL")]
		public int How_many_persons
		{
			get
			{
				return this._How_many_persons;
			}
			set
			{
				if ((this._How_many_persons != value))
				{
					this.OnHow_many_personsChanging(value);
					this.SendPropertyChanging();
					this._How_many_persons = value;
					this.SendPropertyChanged("How_many_persons");
					this.OnHow_many_personsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Size", DbType="Float NOT NULL")]
		public double Size
		{
			get
			{
				return this._Size;
			}
			set
			{
				if ((this._Size != value))
				{
					this.OnSizeChanging(value);
					this.SendPropertyChanging();
					this._Size = value;
					this.SendPropertyChanged("Size");
					this.OnSizeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Float NOT NULL")]
		public double Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Available", DbType="Int NOT NULL")]
		public int Available
		{
			get
			{
				return this._Available;
			}
			set
			{
				if ((this._Available != value))
				{
					this.OnAvailableChanging(value);
					this.SendPropertyChanging();
					this._Available = value;
					this.SendPropertyChanged("Available");
					this.OnAvailableChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Rooms_Client", Storage="_Clients", ThisKey="Id", OtherKey="Room_number")]
		public EntitySet<Clients> Clients
		{
			get
			{
				return this._Clients;
			}
			set
			{
				this._Clients.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Clients(Clients entity)
		{
			this.SendPropertyChanging();
			entity.Rooms = this;
		}
		
		private void detach_Clients(Clients entity)
		{
			this.SendPropertyChanging();
			entity.Rooms = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Treatments")]
	public partial class Treatments : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _Id;
		
		private string _Name;
		
		private double _Price;
		
		private int _Duration;
		
		private string _Description;
		
		private int _Active;
		
		private EntitySet<TreatmentsHistory> _TreatmentsHistories;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(System.Guid value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPriceChanging(double value);
    partial void OnPriceChanged();
    partial void OnDurationChanging(int value);
    partial void OnDurationChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnActiveChanging(int value);
    partial void OnActiveChanged();
    #endregion
		
		public Treatments()
		{
			this._TreatmentsHistories = new EntitySet<TreatmentsHistory>(new Action<TreatmentsHistory>(this.attach_TreatmentsHistories), new Action<TreatmentsHistory>(this.detach_TreatmentsHistories));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Float NOT NULL")]
		public double Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Duration", DbType="Int NOT NULL")]
		public int Duration
		{
			get
			{
				return this._Duration;
			}
			set
			{
				if ((this._Duration != value))
				{
					this.OnDurationChanging(value);
					this.SendPropertyChanging();
					this._Duration = value;
					this.SendPropertyChanged("Duration");
					this.OnDurationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Active", DbType="Int NOT NULL")]
		public int Active
		{
			get
			{
				return this._Active;
			}
			set
			{
				if ((this._Active != value))
				{
					this.OnActiveChanging(value);
					this.SendPropertyChanging();
					this._Active = value;
					this.SendPropertyChanged("Active");
					this.OnActiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Treatments_TreatmentsHistory", Storage="_TreatmentsHistories", ThisKey="Id", OtherKey="Treatment_id")]
		public EntitySet<TreatmentsHistory> TreatmentsHistories
		{
			get
			{
				return this._TreatmentsHistories;
			}
			set
			{
				this._TreatmentsHistories.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_TreatmentsHistories(TreatmentsHistory entity)
		{
			this.SendPropertyChanging();
			entity.Treatments = this;
		}
		
		private void detach_TreatmentsHistories(TreatmentsHistory entity)
		{
			this.SendPropertyChanging();
			entity.Treatments = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TreatmentsHistory")]
	public partial class TreatmentsHistory : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _Id;
		
		private System.Guid _Client_id;
		
		private System.Guid _Treatment_id;
		
		private int _This_stay;
		
		private int _Done;
		
		private EntityRef<Treatments> _Treatments;
		
		private EntityRef<Clients> _Clients;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(System.Guid value);
    partial void OnIdChanged();
    partial void OnClient_idChanging(System.Guid value);
    partial void OnClient_idChanged();
    partial void OnTreatment_idChanging(System.Guid value);
    partial void OnTreatment_idChanged();
    partial void OnThis_stayChanging(int value);
    partial void OnThis_stayChanged();
    partial void OnDoneChanging(int value);
    partial void OnDoneChanged();
    #endregion
		
		public TreatmentsHistory()
		{
			this._Treatments = default(EntityRef<Treatments>);
			this._Clients = default(EntityRef<Clients>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Client_id", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid Client_id
		{
			get
			{
				return this._Client_id;
			}
			set
			{
				if ((this._Client_id != value))
				{
					if (this._Clients.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnClient_idChanging(value);
					this.SendPropertyChanging();
					this._Client_id = value;
					this.SendPropertyChanged("Client_id");
					this.OnClient_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Treatment_id", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid Treatment_id
		{
			get
			{
				return this._Treatment_id;
			}
			set
			{
				if ((this._Treatment_id != value))
				{
					if (this._Treatments.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTreatment_idChanging(value);
					this.SendPropertyChanging();
					this._Treatment_id = value;
					this.SendPropertyChanged("Treatment_id");
					this.OnTreatment_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_This_stay", DbType="Int NOT NULL")]
		public int This_stay
		{
			get
			{
				return this._This_stay;
			}
			set
			{
				if ((this._This_stay != value))
				{
					this.OnThis_stayChanging(value);
					this.SendPropertyChanging();
					this._This_stay = value;
					this.SendPropertyChanged("This_stay");
					this.OnThis_stayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Done", DbType="Int NOT NULL")]
		public int Done
		{
			get
			{
				return this._Done;
			}
			set
			{
				if ((this._Done != value))
				{
					this.OnDoneChanging(value);
					this.SendPropertyChanging();
					this._Done = value;
					this.SendPropertyChanged("Done");
					this.OnDoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Treatments_TreatmentsHistory", Storage="_Treatments", ThisKey="Treatment_id", OtherKey="Id", IsForeignKey=true)]
		public Treatments Treatments
		{
			get
			{
				return this._Treatments.Entity;
			}
			set
			{
				Treatments previousValue = this._Treatments.Entity;
				if (((previousValue != value) 
							|| (this._Treatments.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Treatments.Entity = null;
						previousValue.TreatmentsHistories.Remove(this);
					}
					this._Treatments.Entity = value;
					if ((value != null))
					{
						value.TreatmentsHistories.Add(this);
						this._Treatment_id = value.Id;
					}
					else
					{
						this._Treatment_id = default(System.Guid);
					}
					this.SendPropertyChanged("Treatments");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Client_TreatmentsHistory", Storage="_Clients", ThisKey="Client_id", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public Clients Clients
		{
			get
			{
				return this._Clients.Entity;
			}
			set
			{
				Clients previousValue = this._Clients.Entity;
				if (((previousValue != value) 
							|| (this._Clients.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Clients.Entity = null;
						previousValue.TreatmentsHistories.Remove(this);
					}
					this._Clients.Entity = value;
					if ((value != null))
					{
						value.TreatmentsHistories.Add(this);
						this._Client_id = value.Id;
					}
					else
					{
						this._Client_id = default(System.Guid);
					}
					this.SendPropertyChanged("Clients");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Clients")]
	public partial class Clients : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _Id;
		
		private string _Name_surname;
		
		private string _Id_number;
		
		private string _Company;
		
		private System.Guid _Room_number;
		
		private int _Is_here;
		
		private int _Vegetarian;
		
		private int _Questionnaire;
		
		private int _Invoice;
		
		private EntitySet<TreatmentsHistory> _TreatmentsHistories;
		
		private EntityRef<Rooms> _Rooms;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(System.Guid value);
    partial void OnIdChanged();
    partial void OnName_surnameChanging(string value);
    partial void OnName_surnameChanged();
    partial void OnId_numberChanging(string value);
    partial void OnId_numberChanged();
    partial void OnCompanyChanging(string value);
    partial void OnCompanyChanged();
    partial void OnRoom_numberChanging(System.Guid value);
    partial void OnRoom_numberChanged();
    partial void OnIs_hereChanging(int value);
    partial void OnIs_hereChanged();
    partial void OnVegetarianChanging(int value);
    partial void OnVegetarianChanged();
    partial void OnQuestionnaireChanging(int value);
    partial void OnQuestionnaireChanged();
    partial void OnInvoiceChanging(int value);
    partial void OnInvoiceChanged();
    #endregion
		
		public Clients()
		{
			this._TreatmentsHistories = new EntitySet<TreatmentsHistory>(new Action<TreatmentsHistory>(this.attach_TreatmentsHistories), new Action<TreatmentsHistory>(this.detach_TreatmentsHistories));
			this._Rooms = default(EntityRef<Rooms>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name_surname", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Name_surname
		{
			get
			{
				return this._Name_surname;
			}
			set
			{
				if ((this._Name_surname != value))
				{
					this.OnName_surnameChanging(value);
					this.SendPropertyChanging();
					this._Name_surname = value;
					this.SendPropertyChanged("Name_surname");
					this.OnName_surnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_number", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Id_number
		{
			get
			{
				return this._Id_number;
			}
			set
			{
				if ((this._Id_number != value))
				{
					this.OnId_numberChanging(value);
					this.SendPropertyChanging();
					this._Id_number = value;
					this.SendPropertyChanged("Id_number");
					this.OnId_numberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Company", DbType="VarChar(100)")]
		public string Company
		{
			get
			{
				return this._Company;
			}
			set
			{
				if ((this._Company != value))
				{
					this.OnCompanyChanging(value);
					this.SendPropertyChanging();
					this._Company = value;
					this.SendPropertyChanged("Company");
					this.OnCompanyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Room_number", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid Room_number
		{
			get
			{
				return this._Room_number;
			}
			set
			{
				if ((this._Room_number != value))
				{
					if (this._Rooms.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnRoom_numberChanging(value);
					this.SendPropertyChanging();
					this._Room_number = value;
					this.SendPropertyChanged("Room_number");
					this.OnRoom_numberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Is_here", DbType="Int NOT NULL")]
		public int Is_here
		{
			get
			{
				return this._Is_here;
			}
			set
			{
				if ((this._Is_here != value))
				{
					this.OnIs_hereChanging(value);
					this.SendPropertyChanging();
					this._Is_here = value;
					this.SendPropertyChanged("Is_here");
					this.OnIs_hereChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Vegetarian", DbType="Int NOT NULL")]
		public int Vegetarian
		{
			get
			{
				return this._Vegetarian;
			}
			set
			{
				if ((this._Vegetarian != value))
				{
					this.OnVegetarianChanging(value);
					this.SendPropertyChanging();
					this._Vegetarian = value;
					this.SendPropertyChanged("Vegetarian");
					this.OnVegetarianChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Questionnaire", DbType="Int NOT NULL")]
		public int Questionnaire
		{
			get
			{
				return this._Questionnaire;
			}
			set
			{
				if ((this._Questionnaire != value))
				{
					this.OnQuestionnaireChanging(value);
					this.SendPropertyChanging();
					this._Questionnaire = value;
					this.SendPropertyChanged("Questionnaire");
					this.OnQuestionnaireChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Invoice", DbType="Int NOT NULL")]
		public int Invoice
		{
			get
			{
				return this._Invoice;
			}
			set
			{
				if ((this._Invoice != value))
				{
					this.OnInvoiceChanging(value);
					this.SendPropertyChanging();
					this._Invoice = value;
					this.SendPropertyChanged("Invoice");
					this.OnInvoiceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Client_TreatmentsHistory", Storage="_TreatmentsHistories", ThisKey="Id", OtherKey="Client_id")]
		public EntitySet<TreatmentsHistory> TreatmentsHistories
		{
			get
			{
				return this._TreatmentsHistories;
			}
			set
			{
				this._TreatmentsHistories.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Rooms_Client", Storage="_Rooms", ThisKey="Room_number", OtherKey="Id", IsForeignKey=true)]
		public Rooms Rooms
		{
			get
			{
				return this._Rooms.Entity;
			}
			set
			{
				Rooms previousValue = this._Rooms.Entity;
				if (((previousValue != value) 
							|| (this._Rooms.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Rooms.Entity = null;
						previousValue.Clients.Remove(this);
					}
					this._Rooms.Entity = value;
					if ((value != null))
					{
						value.Clients.Add(this);
						this._Room_number = value.Id;
					}
					else
					{
						this._Room_number = default(System.Guid);
					}
					this.SendPropertyChanged("Rooms");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_TreatmentsHistories(TreatmentsHistory entity)
		{
			this.SendPropertyChanging();
			entity.Clients = this;
		}
		
		private void detach_TreatmentsHistories(TreatmentsHistory entity)
		{
			this.SendPropertyChanging();
			entity.Clients = null;
		}
	}
}
#pragma warning restore 1591
