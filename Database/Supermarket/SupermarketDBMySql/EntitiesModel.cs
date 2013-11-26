﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ContextGenerator.ttinclude code generation file.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;
using SupermarketModelMySql;

namespace SupermarketModelMySql	
{
	[NamingSettings(SourceStrategy = NamingSourceStrategy.Property, RemoveLeadingUnderscores = true, ResolveReservedWords = true, UseDelimitedSQL = true, WordBreak = "_")]
	public partial class SupermarketModel : OpenAccessContext, ISupermarketModelUnitOfWork
	{
		private static string connectionStringName = @"SupermarketDBConn";
			
		private static BackendConfiguration backend = GetBackendConfiguration();
				
		private static MetadataSource metadataSource = AttributesMetadataSource.FromContext(typeof(SupermarketModel));
		
		public SupermarketModel()
			:base(connectionStringName, backend, metadataSource)
		{ }
		
		public SupermarketModel(string connection)
			:base(connection, backend, metadataSource)
		{ }
		
		public SupermarketModel(BackendConfiguration backendConfiguration)
			:base(connectionStringName, backendConfiguration, metadataSource)
		{ }
			
		public SupermarketModel(string connection, MetadataSource metadataSource)
			:base(connection, backend, metadataSource)
		{ }
		
		public SupermarketModel(string connection, BackendConfiguration backendConfiguration, MetadataSource metadataSource)
			:base(connection, backendConfiguration, metadataSource)
		{ }
			
		public IQueryable<Vendor> Vendors 
		{
			get
			{
				return this.GetAll<Vendor>();
			}
		}
		
		public IQueryable<Product> Products 
		{
			get
			{
				return this.GetAll<Product>();
			}
		}
		
		public IQueryable<Measure> Measures 
		{
			get
			{
				return this.GetAll<Measure>();
			}
		}
		
		public static BackendConfiguration GetBackendConfiguration()
		{
			BackendConfiguration backend = new BackendConfiguration();
			backend.Backend = "MySql";
			backend.ProviderName = "MySql.Data.MySqlClient";
			return backend;
		}
	}
	
	public interface ISupermarketModelUnitOfWork : IUnitOfWork
	{
		IQueryable<Vendor> Vendors
		{
			get;
		}
		IQueryable<Product> Products
		{
			get;
		}
		IQueryable<Measure> Measures
		{
			get;
		}
	}
}
#pragma warning restore 1591
