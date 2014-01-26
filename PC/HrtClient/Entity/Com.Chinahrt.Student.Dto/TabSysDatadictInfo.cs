// --------------------------------------------------------------------------------------------------
// This file was automatically generated by J2CS Translator (http://j2cstranslator.sourceforge.net/). 
// Version 1.3.6.20110331_01     
// 14-1-24 ����10:49    
// ${CustomMessageForDisclaimer}                                                                             
// --------------------------------------------------------------------------------------------------
 namespace Com.Chinahrt.Student.Dto {
	
	using System;
	using System.Collections;
	using System.ComponentModel;
	using System.IO;
	using System.Runtime.CompilerServices;
	using System.Runtime.Serialization;
	
	/// <summary>
	/// TabSysDatadictInfo entity. @author MyEclipse Persistence Tools
	/// </summary>
	///
	[Serializable]
	
	/* @SuppressWarnings("serial")*/
	public class TabSysDatadictInfo {
	
		// Fields
	
		private String FDatadictId;
		private String FParentdataId;
		private String FDatadictName;
		private String FDatasignName;
		private Int32 FSortCode;
		private String FDictPath;
		private String FDatadictDesc;
		private String FDataValue;
	
		// Constructors
	
		/// <summary>
		/// default constructor 
		/// </summary>
		///
		public TabSysDatadictInfo() {
		}
	
		/// <summary>
		/// minimal constructor 
		/// </summary>
		///
		public TabSysDatadictInfo(String FDatadictId_0) {
			this.FDatadictId = FDatadictId_0;
		}
	
		/// <summary>
		/// full constructor 
		/// </summary>
		///
		public TabSysDatadictInfo(String FDatadictId_0, String FParentdataId_1,
				String FDatadictName_2, String FDatasignName_3, Int32 FSortCode_4,
				String FDictPath_5, String FDatadictDesc_6, String FDataValue_7) {
			this.FDatadictId = FDatadictId_0;
			this.FParentdataId = FParentdataId_1;
			this.FDatadictName = FDatadictName_2;
			this.FDatasignName = FDatasignName_3;
			this.FSortCode = FSortCode_4;
			this.FDictPath = FDictPath_5;
			this.FDatadictDesc = FDatadictDesc_6;
			this.FDataValue = FDataValue_7;
		}
	
		// Property accessors
	
		public String GetFDatadictId() {
			return this.FDatadictId;
		}
	
		public void SetFDatadictId(String FDatadictId_0) {
			this.FDatadictId = FDatadictId_0;
		}
	
		public String GetFParentdataId() {
			return this.FParentdataId;
		}
	
		public void SetFParentdataId(String FParentdataId_0) {
			this.FParentdataId = FParentdataId_0;
		}
	
		public String GetFDatadictName() {
			return this.FDatadictName;
		}
	
		public void SetFDatadictName(String FDatadictName_0) {
			this.FDatadictName = FDatadictName_0;
		}
	
		public String GetFDatasignName() {
			return this.FDatasignName;
		}
	
		public void SetFDatasignName(String FDatasignName_0) {
			this.FDatasignName = FDatasignName_0;
		}
	
		public Int32 GetFSortCode() {
			return this.FSortCode;
		}
	
		public void SetFSortCode(Int32 FSortCode_0) {
			this.FSortCode = FSortCode_0;
		}
	
		public String GetFDictPath() {
			return this.FDictPath;
		}
	
		public void SetFDictPath(String FDictPath_0) {
			this.FDictPath = FDictPath_0;
		}
	
		public String GetFDatadictDesc() {
			return this.FDatadictDesc;
		}
	
		public void SetFDatadictDesc(String FDatadictDesc_0) {
			this.FDatadictDesc = FDatadictDesc_0;
		}
	
		public String GetFDataValue() {
			return FDataValue;
		}
	
		public void SetFDataValue(String fDataValue) {
			FDataValue = fDataValue;
		}
	
	}}