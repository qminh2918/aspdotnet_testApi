﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.10.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
////////////////////////////////////////////////////////////// 
using System;
using System.Linq;
using test.Dal.EntityClasses;
using test.Dal.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.QuerySpec.AdapterSpecific;
using SD.LLBLGen.Pro.QuerySpec;

namespace test.Dal.FactoryClasses
{
	/// <summary>Factory class to produce DynamicQuery instances and EntityQuery instances</summary>
	public partial class QueryFactory : QueryFactoryBase2
	{
		/// <summary>Creates and returns a new EntityQuery for the Test entity</summary>
		public EntityQuery<TestEntity> Test { get { return Create<TestEntity>(); } }

		/// <inheritdoc/>
		protected override IElementCreatorCore CreateElementCreator() { return new ElementCreator(); }
 
	}
}