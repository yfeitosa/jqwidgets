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

namespace Demonstracao
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class CURSOEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new CURSOEntities object using the connection string found in the 'CURSOEntities' section of the application configuration file.
        /// </summary>
        public CURSOEntities() : base("name=CURSOEntities", "CURSOEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new CURSOEntities object.
        /// </summary>
        public CURSOEntities(string connectionString) : base(connectionString, "CURSOEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new CURSOEntities object.
        /// </summary>
        public CURSOEntities(EntityConnection connection) : base(connection, "CURSOEntities")
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
        public ObjectSet<TB_DESENVOLVEDOR> TB_DESENVOLVEDOR
        {
            get
            {
                if ((_TB_DESENVOLVEDOR == null))
                {
                    _TB_DESENVOLVEDOR = base.CreateObjectSet<TB_DESENVOLVEDOR>("TB_DESENVOLVEDOR");
                }
                return _TB_DESENVOLVEDOR;
            }
        }
        private ObjectSet<TB_DESENVOLVEDOR> _TB_DESENVOLVEDOR;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<TB_LINGUAGEM> TB_LINGUAGEM
        {
            get
            {
                if ((_TB_LINGUAGEM == null))
                {
                    _TB_LINGUAGEM = base.CreateObjectSet<TB_LINGUAGEM>("TB_LINGUAGEM");
                }
                return _TB_LINGUAGEM;
            }
        }
        private ObjectSet<TB_LINGUAGEM> _TB_LINGUAGEM;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the TB_DESENVOLVEDOR EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToTB_DESENVOLVEDOR(TB_DESENVOLVEDOR tB_DESENVOLVEDOR)
        {
            base.AddObject("TB_DESENVOLVEDOR", tB_DESENVOLVEDOR);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the TB_LINGUAGEM EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToTB_LINGUAGEM(TB_LINGUAGEM tB_LINGUAGEM)
        {
            base.AddObject("TB_LINGUAGEM", tB_LINGUAGEM);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="CURSOModel", Name="TB_DESENVOLVEDOR")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class TB_DESENVOLVEDOR : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new TB_DESENVOLVEDOR object.
        /// </summary>
        /// <param name="iD_DESENVOLVEDOR">Initial value of the ID_DESENVOLVEDOR property.</param>
        /// <param name="nM_DESENVOLVEDOR">Initial value of the NM_DESENVOLVEDOR property.</param>
        public static TB_DESENVOLVEDOR CreateTB_DESENVOLVEDOR(global::System.Int32 iD_DESENVOLVEDOR, global::System.String nM_DESENVOLVEDOR)
        {
            TB_DESENVOLVEDOR tB_DESENVOLVEDOR = new TB_DESENVOLVEDOR();
            tB_DESENVOLVEDOR.ID_DESENVOLVEDOR = iD_DESENVOLVEDOR;
            tB_DESENVOLVEDOR.NM_DESENVOLVEDOR = nM_DESENVOLVEDOR;
            return tB_DESENVOLVEDOR;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID_DESENVOLVEDOR
        {
            get
            {
                return _ID_DESENVOLVEDOR;
            }
            set
            {
                if (_ID_DESENVOLVEDOR != value)
                {
                    OnID_DESENVOLVEDORChanging(value);
                    ReportPropertyChanging("ID_DESENVOLVEDOR");
                    _ID_DESENVOLVEDOR = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID_DESENVOLVEDOR");
                    OnID_DESENVOLVEDORChanged();
                }
            }
        }
        private global::System.Int32 _ID_DESENVOLVEDOR;
        partial void OnID_DESENVOLVEDORChanging(global::System.Int32 value);
        partial void OnID_DESENVOLVEDORChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String NM_DESENVOLVEDOR
        {
            get
            {
                return _NM_DESENVOLVEDOR;
            }
            set
            {
                OnNM_DESENVOLVEDORChanging(value);
                ReportPropertyChanging("NM_DESENVOLVEDOR");
                _NM_DESENVOLVEDOR = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("NM_DESENVOLVEDOR");
                OnNM_DESENVOLVEDORChanged();
            }
        }
        private global::System.String _NM_DESENVOLVEDOR;
        partial void OnNM_DESENVOLVEDORChanging(global::System.String value);
        partial void OnNM_DESENVOLVEDORChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="CURSOModel", Name="TB_LINGUAGEM")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class TB_LINGUAGEM : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new TB_LINGUAGEM object.
        /// </summary>
        /// <param name="iD_LINGUAGEM">Initial value of the ID_LINGUAGEM property.</param>
        /// <param name="nM_LINGUAGEM">Initial value of the NM_LINGUAGEM property.</param>
        public static TB_LINGUAGEM CreateTB_LINGUAGEM(global::System.Int32 iD_LINGUAGEM, global::System.String nM_LINGUAGEM)
        {
            TB_LINGUAGEM tB_LINGUAGEM = new TB_LINGUAGEM();
            tB_LINGUAGEM.ID_LINGUAGEM = iD_LINGUAGEM;
            tB_LINGUAGEM.NM_LINGUAGEM = nM_LINGUAGEM;
            return tB_LINGUAGEM;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID_LINGUAGEM
        {
            get
            {
                return _ID_LINGUAGEM;
            }
            set
            {
                if (_ID_LINGUAGEM != value)
                {
                    OnID_LINGUAGEMChanging(value);
                    ReportPropertyChanging("ID_LINGUAGEM");
                    _ID_LINGUAGEM = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID_LINGUAGEM");
                    OnID_LINGUAGEMChanged();
                }
            }
        }
        private global::System.Int32 _ID_LINGUAGEM;
        partial void OnID_LINGUAGEMChanging(global::System.Int32 value);
        partial void OnID_LINGUAGEMChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String NM_LINGUAGEM
        {
            get
            {
                return _NM_LINGUAGEM;
            }
            set
            {
                OnNM_LINGUAGEMChanging(value);
                ReportPropertyChanging("NM_LINGUAGEM");
                _NM_LINGUAGEM = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("NM_LINGUAGEM");
                OnNM_LINGUAGEMChanged();
            }
        }
        private global::System.String _NM_LINGUAGEM;
        partial void OnNM_LINGUAGEMChanging(global::System.String value);
        partial void OnNM_LINGUAGEMChanged();

        #endregion
    
    }

    #endregion
    
}
