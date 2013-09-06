﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("Model1", "DomainImperative", "Domain", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(IBMConsultantTool.BusinessObjective), "Imperative", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(IBMConsultantTool.Imperative))]
[assembly: EdmRelationshipAttribute("Model1", "CategoryBusinessObjective", "Category", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(IBMConsultantTool.Category), "BusinessObjective", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(IBMConsultantTool.BusinessObjective))]
[assembly: EdmRelationshipAttribute("Model1", "BOMImperative", "BOM", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(IBMConsultantTool.BOM), "Imperative", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(IBMConsultantTool.Imperative))]
[assembly: EdmRelationshipAttribute("Model1", "ClientBOM", "Client", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(IBMConsultantTool.Client), "BOM", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(IBMConsultantTool.BOM))]
[assembly: EdmRelationshipAttribute("Model1", "InitiativeBusinessObjective", "Initiative", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(IBMConsultantTool.Initiative), "BusinessObjective", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(IBMConsultantTool.BusinessObjective))]

#endregion

namespace IBMConsultantTool
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class Model1Container : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new Model1Container object using the connection string found in the 'Model1Container' section of the application configuration file.
        /// </summary>
        public Model1Container() : base("name=Model1Container", "Model1Container")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new Model1Container object.
        /// </summary>
        public Model1Container(string connectionString) : base(connectionString, "Model1Container")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new Model1Container object.
        /// </summary>
        public Model1Container(EntityConnection connection) : base(connection, "Model1Container")
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
        public ObjectSet<Client> Client
        {
            get
            {
                if ((_Client == null))
                {
                    _Client = base.CreateObjectSet<Client>("Client");
                }
                return _Client;
            }
        }
        private ObjectSet<Client> _Client;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<BusinessObjective> BusinessObjective
        {
            get
            {
                if ((_BusinessObjective == null))
                {
                    _BusinessObjective = base.CreateObjectSet<BusinessObjective>("BusinessObjective");
                }
                return _BusinessObjective;
            }
        }
        private ObjectSet<BusinessObjective> _BusinessObjective;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Imperative> Imperative
        {
            get
            {
                if ((_Imperative == null))
                {
                    _Imperative = base.CreateObjectSet<Imperative>("Imperative");
                }
                return _Imperative;
            }
        }
        private ObjectSet<Imperative> _Imperative;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Category> Category
        {
            get
            {
                if ((_Category == null))
                {
                    _Category = base.CreateObjectSet<Category>("Category");
                }
                return _Category;
            }
        }
        private ObjectSet<Category> _Category;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<BOM> BOM
        {
            get
            {
                if ((_BOM == null))
                {
                    _BOM = base.CreateObjectSet<BOM>("BOM");
                }
                return _BOM;
            }
        }
        private ObjectSet<BOM> _BOM;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Initiative> Initiative
        {
            get
            {
                if ((_Initiative == null))
                {
                    _Initiative = base.CreateObjectSet<Initiative>("Initiative");
                }
                return _Initiative;
            }
        }
        private ObjectSet<Initiative> _Initiative;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Client EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToClient(Client client)
        {
            base.AddObject("Client", client);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the BusinessObjective EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToBusinessObjective(BusinessObjective businessObjective)
        {
            base.AddObject("BusinessObjective", businessObjective);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Imperative EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToImperative(Imperative imperative)
        {
            base.AddObject("Imperative", imperative);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Category EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCategory(Category category)
        {
            base.AddObject("Category", category);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the BOM EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToBOM(BOM bOM)
        {
            base.AddObject("BOM", bOM);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Initiative EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToInitiative(Initiative initiative)
        {
            base.AddObject("Initiative", initiative);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Model1", Name="BOM")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class BOM : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new BOM object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        public static BOM CreateBOM(global::System.Int32 id)
        {
            BOM bOM = new BOM();
            bOM.Id = id;
            return bOM;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Model1", "BOMImperative", "Imperative")]
        public EntityCollection<Imperative> Imperative
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Imperative>("Model1.BOMImperative", "Imperative");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Imperative>("Model1.BOMImperative", "Imperative", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Model1", "ClientBOM", "Client")]
        public Client Client
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Client>("Model1.ClientBOM", "Client").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Client>("Model1.ClientBOM", "Client").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Client> ClientReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Client>("Model1.ClientBOM", "Client");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Client>("Model1.ClientBOM", "Client", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Model1", Name="BusinessObjective")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class BusinessObjective : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new BusinessObjective object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        public static BusinessObjective CreateBusinessObjective(global::System.Int32 id)
        {
            BusinessObjective businessObjective = new BusinessObjective();
            businessObjective.Id = id;
            return businessObjective;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Model1", "DomainImperative", "Imperative")]
        public EntityCollection<Imperative> Imperative
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Imperative>("Model1.DomainImperative", "Imperative");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Imperative>("Model1.DomainImperative", "Imperative", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Model1", "CategoryBusinessObjective", "Category")]
        public Category Category
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Category>("Model1.CategoryBusinessObjective", "Category").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Category>("Model1.CategoryBusinessObjective", "Category").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Category> CategoryReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Category>("Model1.CategoryBusinessObjective", "Category");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Category>("Model1.CategoryBusinessObjective", "Category", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Model1", "InitiativeBusinessObjective", "Initiative")]
        public EntityCollection<Initiative> Initiative
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Initiative>("Model1.InitiativeBusinessObjective", "Initiative");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Initiative>("Model1.InitiativeBusinessObjective", "Initiative", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Model1", Name="Category")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Category : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Category object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        public static Category CreateCategory(global::System.Int32 id)
        {
            Category category = new Category();
            category.Id = id;
            return category;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Model1", "CategoryBusinessObjective", "BusinessObjective")]
        public EntityCollection<BusinessObjective> BusinessObjective
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<BusinessObjective>("Model1.CategoryBusinessObjective", "BusinessObjective");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<BusinessObjective>("Model1.CategoryBusinessObjective", "BusinessObjective", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Model1", Name="Client")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Client : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Client object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        public static Client CreateClient(global::System.Int32 id)
        {
            Client client = new Client();
            client.Id = id;
            return client;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Model1", "ClientBOM", "BOM")]
        public BOM BOM
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BOM>("Model1.ClientBOM", "BOM").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BOM>("Model1.ClientBOM", "BOM").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<BOM> BOMReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BOM>("Model1.ClientBOM", "BOM");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<BOM>("Model1.ClientBOM", "BOM", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Model1", Name="Imperative")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Imperative : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Imperative object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="currentRating">Initial value of the CurrentRating property.</param>
        /// <param name="desiredRating">Initial value of the DesiredRating property.</param>
        /// <param name="criticality">Initial value of the Criticality property.</param>
        /// <param name="differential">Initial value of the Differential property.</param>
        public static Imperative CreateImperative(global::System.Int32 id, global::System.String currentRating, global::System.String desiredRating, global::System.String criticality, global::System.String differential)
        {
            Imperative imperative = new Imperative();
            imperative.Id = id;
            imperative.CurrentRating = currentRating;
            imperative.DesiredRating = desiredRating;
            imperative.Criticality = criticality;
            imperative.Differential = differential;
            return imperative;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String CurrentRating
        {
            get
            {
                return _CurrentRating;
            }
            set
            {
                OnCurrentRatingChanging(value);
                ReportPropertyChanging("CurrentRating");
                _CurrentRating = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("CurrentRating");
                OnCurrentRatingChanged();
            }
        }
        private global::System.String _CurrentRating;
        partial void OnCurrentRatingChanging(global::System.String value);
        partial void OnCurrentRatingChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String DesiredRating
        {
            get
            {
                return _DesiredRating;
            }
            set
            {
                OnDesiredRatingChanging(value);
                ReportPropertyChanging("DesiredRating");
                _DesiredRating = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("DesiredRating");
                OnDesiredRatingChanged();
            }
        }
        private global::System.String _DesiredRating;
        partial void OnDesiredRatingChanging(global::System.String value);
        partial void OnDesiredRatingChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Criticality
        {
            get
            {
                return _Criticality;
            }
            set
            {
                OnCriticalityChanging(value);
                ReportPropertyChanging("Criticality");
                _Criticality = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Criticality");
                OnCriticalityChanged();
            }
        }
        private global::System.String _Criticality;
        partial void OnCriticalityChanging(global::System.String value);
        partial void OnCriticalityChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Differential
        {
            get
            {
                return _Differential;
            }
            set
            {
                OnDifferentialChanging(value);
                ReportPropertyChanging("Differential");
                _Differential = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Differential");
                OnDifferentialChanged();
            }
        }
        private global::System.String _Differential;
        partial void OnDifferentialChanging(global::System.String value);
        partial void OnDifferentialChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Model1", "DomainImperative", "Domain")]
        public BusinessObjective Domain
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BusinessObjective>("Model1.DomainImperative", "Domain").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BusinessObjective>("Model1.DomainImperative", "Domain").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<BusinessObjective> DomainReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BusinessObjective>("Model1.DomainImperative", "Domain");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<BusinessObjective>("Model1.DomainImperative", "Domain", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Model1", "BOMImperative", "BOM")]
        public BOM BOM
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BOM>("Model1.BOMImperative", "BOM").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BOM>("Model1.BOMImperative", "BOM").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<BOM> BOMReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BOM>("Model1.BOMImperative", "BOM");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<BOM>("Model1.BOMImperative", "BOM", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Model1", Name="Initiative")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Initiative : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Initiative object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="currentRating">Initial value of the CurrentRating property.</param>
        /// <param name="desiredRating">Initial value of the DesiredRating property.</param>
        /// <param name="criticality">Initial value of the Criticality property.</param>
        /// <param name="differential">Initial value of the Differential property.</param>
        public static Initiative CreateInitiative(global::System.Int32 id, global::System.String currentRating, global::System.String desiredRating, global::System.String criticality, global::System.String differential)
        {
            Initiative initiative = new Initiative();
            initiative.Id = id;
            initiative.CurrentRating = currentRating;
            initiative.DesiredRating = desiredRating;
            initiative.Criticality = criticality;
            initiative.Differential = differential;
            return initiative;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String CurrentRating
        {
            get
            {
                return _CurrentRating;
            }
            set
            {
                OnCurrentRatingChanging(value);
                ReportPropertyChanging("CurrentRating");
                _CurrentRating = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("CurrentRating");
                OnCurrentRatingChanged();
            }
        }
        private global::System.String _CurrentRating;
        partial void OnCurrentRatingChanging(global::System.String value);
        partial void OnCurrentRatingChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String DesiredRating
        {
            get
            {
                return _DesiredRating;
            }
            set
            {
                OnDesiredRatingChanging(value);
                ReportPropertyChanging("DesiredRating");
                _DesiredRating = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("DesiredRating");
                OnDesiredRatingChanged();
            }
        }
        private global::System.String _DesiredRating;
        partial void OnDesiredRatingChanging(global::System.String value);
        partial void OnDesiredRatingChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Criticality
        {
            get
            {
                return _Criticality;
            }
            set
            {
                OnCriticalityChanging(value);
                ReportPropertyChanging("Criticality");
                _Criticality = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Criticality");
                OnCriticalityChanged();
            }
        }
        private global::System.String _Criticality;
        partial void OnCriticalityChanging(global::System.String value);
        partial void OnCriticalityChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Differential
        {
            get
            {
                return _Differential;
            }
            set
            {
                OnDifferentialChanging(value);
                ReportPropertyChanging("Differential");
                _Differential = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Differential");
                OnDifferentialChanged();
            }
        }
        private global::System.String _Differential;
        partial void OnDifferentialChanging(global::System.String value);
        partial void OnDifferentialChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Model1", "InitiativeBusinessObjective", "BusinessObjective")]
        public BusinessObjective BusinessObjective
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BusinessObjective>("Model1.InitiativeBusinessObjective", "BusinessObjective").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BusinessObjective>("Model1.InitiativeBusinessObjective", "BusinessObjective").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<BusinessObjective> BusinessObjectiveReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BusinessObjective>("Model1.InitiativeBusinessObjective", "BusinessObjective");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<BusinessObjective>("Model1.InitiativeBusinessObjective", "BusinessObjective", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}