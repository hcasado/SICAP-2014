﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18444
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos.cd_GestionAsistencia
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SICAP-2014")]
	public partial class AsistenciaDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertASISTENCIA(ASISTENCIA instance);
    partial void UpdateASISTENCIA(ASISTENCIA instance);
    partial void DeleteASISTENCIA(ASISTENCIA instance);
    #endregion
		
		public AsistenciaDataContext() : 
				base(global::CapaDatos.Properties.Settings.Default.SICAP_2014ConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public AsistenciaDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AsistenciaDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AsistenciaDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AsistenciaDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ASISTENCIA> ASISTENCIA
		{
			get
			{
				return this.GetTable<ASISTENCIA>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.pa_RegistrarAsistencia")]
		public int pa_RegistrarAsistencia([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDASISTENCIA", DbType="VarChar(10)")] string iDASISTENCIA, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDCALENDARIO", DbType="VarChar(5)")] string iDCALENDARIO, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="CEDULA", DbType="VarChar(10)")] string cEDULA, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="FECHAHORAENTRADA", DbType="DateTime")] System.Nullable<System.DateTime> fECHAHORAENTRADA, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="FECHAHORASALIDA", DbType="DateTime")] System.Nullable<System.DateTime> fECHAHORASALIDA)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDASISTENCIA, iDCALENDARIO, cEDULA, fECHAHORAENTRADA, fECHAHORASALIDA);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.pa_FiltrarAsistenciaRango")]
		public ISingleResult<pa_FiltrarAsistenciaRangoResult> pa_FiltrarAsistenciaRango([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDCALENDARIO", DbType="VarChar(5)")] string iDCALENDARIO, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="CEDULA", DbType="VarChar(10)")] string cEDULA, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="DateTime")] System.Nullable<System.DateTime> fechainicio, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="DateTime")] System.Nullable<System.DateTime> fechafin)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDCALENDARIO, cEDULA, fechainicio, fechafin);
			return ((ISingleResult<pa_FiltrarAsistenciaRangoResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.pa_FiltrarAsistenciaMes")]
		public ISingleResult<pa_FiltrarAsistenciaMesResult> pa_FiltrarAsistenciaMes([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDCALENDARIO", DbType="VarChar(5)")] string iDCALENDARIO, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="CEDULA", DbType="VarChar(10)")] string cEDULA, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(10)")] string valor)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDCALENDARIO, cEDULA, valor);
			return ((ISingleResult<pa_FiltrarAsistenciaMesResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.pa_FiltrarAsistenciaDia")]
		public ISingleResult<pa_FiltrarAsistenciaDiaResult> pa_FiltrarAsistenciaDia([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDCALENDARIO", DbType="VarChar(5)")] string iDCALENDARIO, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="CEDULA", DbType="VarChar(10)")] string cEDULA, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(10)")] string valor)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDCALENDARIO, cEDULA, valor);
			return ((ISingleResult<pa_FiltrarAsistenciaDiaResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.pa_EliminarAsistenciaId")]
		public int pa_EliminarAsistenciaId([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDASISTENCIA", DbType="VarChar(10)")] string iDASISTENCIA)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDASISTENCIA);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ASISTENCIA")]
	public partial class ASISTENCIA : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _IDASISTENCIA;
		
		private string _IDCALENDARIO;
		
		private string _CEDULA;
		
		private System.DateTime _FECHAHORAENTRADA;
		
		private System.DateTime _FECHAHORASALIDA;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDASISTENCIAChanging(string value);
    partial void OnIDASISTENCIAChanged();
    partial void OnIDCALENDARIOChanging(string value);
    partial void OnIDCALENDARIOChanged();
    partial void OnCEDULAChanging(string value);
    partial void OnCEDULAChanged();
    partial void OnFECHAHORAENTRADAChanging(System.DateTime value);
    partial void OnFECHAHORAENTRADAChanged();
    partial void OnFECHAHORASALIDAChanging(System.DateTime value);
    partial void OnFECHAHORASALIDAChanged();
    #endregion
		
		public ASISTENCIA()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDASISTENCIA", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string IDASISTENCIA
		{
			get
			{
				return this._IDASISTENCIA;
			}
			set
			{
				if ((this._IDASISTENCIA != value))
				{
					this.OnIDASISTENCIAChanging(value);
					this.SendPropertyChanging();
					this._IDASISTENCIA = value;
					this.SendPropertyChanged("IDASISTENCIA");
					this.OnIDASISTENCIAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDCALENDARIO", DbType="VarChar(5) NOT NULL", CanBeNull=false)]
		public string IDCALENDARIO
		{
			get
			{
				return this._IDCALENDARIO;
			}
			set
			{
				if ((this._IDCALENDARIO != value))
				{
					this.OnIDCALENDARIOChanging(value);
					this.SendPropertyChanging();
					this._IDCALENDARIO = value;
					this.SendPropertyChanged("IDCALENDARIO");
					this.OnIDCALENDARIOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CEDULA", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string CEDULA
		{
			get
			{
				return this._CEDULA;
			}
			set
			{
				if ((this._CEDULA != value))
				{
					this.OnCEDULAChanging(value);
					this.SendPropertyChanging();
					this._CEDULA = value;
					this.SendPropertyChanged("CEDULA");
					this.OnCEDULAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FECHAHORAENTRADA", DbType="DateTime NOT NULL")]
		public System.DateTime FECHAHORAENTRADA
		{
			get
			{
				return this._FECHAHORAENTRADA;
			}
			set
			{
				if ((this._FECHAHORAENTRADA != value))
				{
					this.OnFECHAHORAENTRADAChanging(value);
					this.SendPropertyChanging();
					this._FECHAHORAENTRADA = value;
					this.SendPropertyChanged("FECHAHORAENTRADA");
					this.OnFECHAHORAENTRADAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FECHAHORASALIDA", DbType="DateTime NOT NULL")]
		public System.DateTime FECHAHORASALIDA
		{
			get
			{
				return this._FECHAHORASALIDA;
			}
			set
			{
				if ((this._FECHAHORASALIDA != value))
				{
					this.OnFECHAHORASALIDAChanging(value);
					this.SendPropertyChanging();
					this._FECHAHORASALIDA = value;
					this.SendPropertyChanged("FECHAHORASALIDA");
					this.OnFECHAHORASALIDAChanged();
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
	
	public partial class pa_FiltrarAsistenciaRangoResult
	{
		
		private string _IDASISTENCIA;
		
		private string _IDCALENDARIO;
		
		private string _CEDULA;
		
		private System.DateTime _FECHAHORAENTRADA;
		
		private System.DateTime _FECHAHORASALIDA;
		
		public pa_FiltrarAsistenciaRangoResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDASISTENCIA", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string IDASISTENCIA
		{
			get
			{
				return this._IDASISTENCIA;
			}
			set
			{
				if ((this._IDASISTENCIA != value))
				{
					this._IDASISTENCIA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDCALENDARIO", DbType="VarChar(5) NOT NULL", CanBeNull=false)]
		public string IDCALENDARIO
		{
			get
			{
				return this._IDCALENDARIO;
			}
			set
			{
				if ((this._IDCALENDARIO != value))
				{
					this._IDCALENDARIO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CEDULA", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string CEDULA
		{
			get
			{
				return this._CEDULA;
			}
			set
			{
				if ((this._CEDULA != value))
				{
					this._CEDULA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FECHAHORAENTRADA", DbType="DateTime NOT NULL")]
		public System.DateTime FECHAHORAENTRADA
		{
			get
			{
				return this._FECHAHORAENTRADA;
			}
			set
			{
				if ((this._FECHAHORAENTRADA != value))
				{
					this._FECHAHORAENTRADA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FECHAHORASALIDA", DbType="DateTime NOT NULL")]
		public System.DateTime FECHAHORASALIDA
		{
			get
			{
				return this._FECHAHORASALIDA;
			}
			set
			{
				if ((this._FECHAHORASALIDA != value))
				{
					this._FECHAHORASALIDA = value;
				}
			}
		}
	}
	
	public partial class pa_FiltrarAsistenciaMesResult
	{
		
		private string _IDASISTENCIA;
		
		private string _IDCALENDARIO;
		
		private string _CEDULA;
		
		private System.DateTime _FECHAHORAENTRADA;
		
		private System.DateTime _FECHAHORASALIDA;
		
		public pa_FiltrarAsistenciaMesResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDASISTENCIA", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string IDASISTENCIA
		{
			get
			{
				return this._IDASISTENCIA;
			}
			set
			{
				if ((this._IDASISTENCIA != value))
				{
					this._IDASISTENCIA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDCALENDARIO", DbType="VarChar(5) NOT NULL", CanBeNull=false)]
		public string IDCALENDARIO
		{
			get
			{
				return this._IDCALENDARIO;
			}
			set
			{
				if ((this._IDCALENDARIO != value))
				{
					this._IDCALENDARIO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CEDULA", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string CEDULA
		{
			get
			{
				return this._CEDULA;
			}
			set
			{
				if ((this._CEDULA != value))
				{
					this._CEDULA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FECHAHORAENTRADA", DbType="DateTime NOT NULL")]
		public System.DateTime FECHAHORAENTRADA
		{
			get
			{
				return this._FECHAHORAENTRADA;
			}
			set
			{
				if ((this._FECHAHORAENTRADA != value))
				{
					this._FECHAHORAENTRADA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FECHAHORASALIDA", DbType="DateTime NOT NULL")]
		public System.DateTime FECHAHORASALIDA
		{
			get
			{
				return this._FECHAHORASALIDA;
			}
			set
			{
				if ((this._FECHAHORASALIDA != value))
				{
					this._FECHAHORASALIDA = value;
				}
			}
		}
	}
	
	public partial class pa_FiltrarAsistenciaDiaResult
	{
		
		private string _IDASISTENCIA;
		
		private string _IDCALENDARIO;
		
		private string _CEDULA;
		
		private System.DateTime _FECHAHORAENTRADA;
		
		private System.DateTime _FECHAHORASALIDA;
		
		public pa_FiltrarAsistenciaDiaResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDASISTENCIA", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string IDASISTENCIA
		{
			get
			{
				return this._IDASISTENCIA;
			}
			set
			{
				if ((this._IDASISTENCIA != value))
				{
					this._IDASISTENCIA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDCALENDARIO", DbType="VarChar(5) NOT NULL", CanBeNull=false)]
		public string IDCALENDARIO
		{
			get
			{
				return this._IDCALENDARIO;
			}
			set
			{
				if ((this._IDCALENDARIO != value))
				{
					this._IDCALENDARIO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CEDULA", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string CEDULA
		{
			get
			{
				return this._CEDULA;
			}
			set
			{
				if ((this._CEDULA != value))
				{
					this._CEDULA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FECHAHORAENTRADA", DbType="DateTime NOT NULL")]
		public System.DateTime FECHAHORAENTRADA
		{
			get
			{
				return this._FECHAHORAENTRADA;
			}
			set
			{
				if ((this._FECHAHORAENTRADA != value))
				{
					this._FECHAHORAENTRADA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FECHAHORASALIDA", DbType="DateTime NOT NULL")]
		public System.DateTime FECHAHORASALIDA
		{
			get
			{
				return this._FECHAHORASALIDA;
			}
			set
			{
				if ((this._FECHAHORASALIDA != value))
				{
					this._FECHAHORASALIDA = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
