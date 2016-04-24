﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace InventoryEDMConsoleApp
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class AutoLotEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new AutoLotEntities object using the connection string found in the 'AutoLotEntities' section of the application configuration file.
        /// </summary>
        public AutoLotEntities() : base("name=AutoLotEntities", "AutoLotEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new AutoLotEntities object.
        /// </summary>
        public AutoLotEntities(string connectionString) : base(connectionString, "AutoLotEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new AutoLotEntities object.
        /// </summary>
        public AutoLotEntities(EntityConnection connection) : base(connection, "AutoLotEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Car> Cars
        {
            get
            {
                if ((_Cars == null))
                {
                    _Cars = base.CreateObjectSet<Car>("Cars");
                }
                return _Cars;
            }
        }
        private ObjectSet<Car> _Cars;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Cars EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCars(Car car)
        {
            base.AddObject("Cars", car);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="AutoLotModel", Name="Car")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Car : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Car object.
        /// </summary>
        /// <param name="carID">Initial value of the CarID property.</param>
        /// <param name="make">Initial value of the Make property.</param>
        /// <param name="color">Initial value of the Color property.</param>
        public static Car CreateCar(global::System.Int32 carID, global::System.String make, global::System.String color)
        {
            Car car = new Car();
            car.CarID = carID;
            car.Make = make;
            car.Color = color;
            return car;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 CarID
        {
            get
            {
                return _CarID;
            }
            set
            {
                if (_CarID != value)
                {
                    OnCarIDChanging(value);
                    ReportPropertyChanging("CarID");
                    _CarID = StructuralObject.SetValidValue(value, "CarID");
                    ReportPropertyChanged("CarID");
                    OnCarIDChanged();
                }
            }
        }
        private global::System.Int32 _CarID;
        partial void OnCarIDChanging(global::System.Int32 value);
        partial void OnCarIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Make
        {
            get
            {
                return _Make;
            }
            set
            {
                OnMakeChanging(value);
                ReportPropertyChanging("Make");
                _Make = StructuralObject.SetValidValue(value, false, "Make");
                ReportPropertyChanged("Make");
                OnMakeChanged();
            }
        }
        private global::System.String _Make;
        partial void OnMakeChanging(global::System.String value);
        partial void OnMakeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Color
        {
            get
            {
                return _Color;
            }
            set
            {
                OnColorChanging(value);
                ReportPropertyChanging("Color");
                _Color = StructuralObject.SetValidValue(value, false, "Color");
                ReportPropertyChanged("Color");
                OnColorChanged();
            }
        }
        private global::System.String _Color;
        partial void OnColorChanging(global::System.String value);
        partial void OnColorChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String CarNickname
        {
            get
            {
                return _CarNickname;
            }
            set
            {
                OnCarNicknameChanging(value);
                ReportPropertyChanging("CarNickname");
                _CarNickname = StructuralObject.SetValidValue(value, true, "CarNickname");
                ReportPropertyChanged("CarNickname");
                OnCarNicknameChanged();
            }
        }
        private global::System.String _CarNickname;
        partial void OnCarNicknameChanging(global::System.String value);
        partial void OnCarNicknameChanged();

        #endregion

    }

    #endregion

}
