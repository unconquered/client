// --------------------------------------------------------------------------------------------------
// This file was automatically generated by J2CS Translator (http://j2cstranslator.sourceforge.net/). 
// Version 1.3.6.20110331_01     
// 14-1-24 ����10:49    
// ${CustomMessageForDisclaimer}                                                                             
// --------------------------------------------------------------------------------------------------
 namespace Com.Chinahrt.Exam.Dto {
	
	using System;
	using System.Collections;
	using System.ComponentModel;
	using System.IO;
	using System.Runtime.CompilerServices;
	using System.Runtime.Serialization;
	
	/// <summary>
	/// TabExamRetestInfo entity. @author MyEclipse Persistence Tools
	/// </summary>
	///
	[Serializable]
	
	public class TabExamRetestInfo {
	
		// Fields
	
		private String FRetestId;
		private String FUserId;
		private String FExamId;
		private Int32 FRetestTimes;
	
		// Constructors
	
		/// <summary>
		/// default constructor 
		/// </summary>
		///
		public TabExamRetestInfo() {
		}
	
		/// <summary>
		/// minimal constructor 
		/// </summary>
		///
		public TabExamRetestInfo(String FRetestId_0) {
			this.FRetestId = FRetestId_0;
		}
	
		/// <summary>
		/// full constructor 
		/// </summary>
		///
		public TabExamRetestInfo(String FRetestId_0, String FUserId_1, String FExamId_2,
				Int32 FRetestTimes_3) {
			this.FRetestId = FRetestId_0;
			this.FUserId = FUserId_1;
			this.FExamId = FExamId_2;
			this.FRetestTimes = FRetestTimes_3;
		}
	
		// Property accessors
	
		public String GetFRetestId() {
			return this.FRetestId;
		}
	
		public void SetFRetestId(String FRetestId_0) {
			this.FRetestId = FRetestId_0;
		}
	
		public String GetFUserId() {
			return this.FUserId;
		}
	
		public void SetFUserId(String FUserId_0) {
			this.FUserId = FUserId_0;
		}
	
		public String GetFExamId() {
			return this.FExamId;
		}
	
		public void SetFExamId(String FExamId_0) {
			this.FExamId = FExamId_0;
		}
	
		public Int32 GetFRetestTimes() {
			return this.FRetestTimes;
		}
	
		public void SetFRetestTimes(Int32 FRetestTimes_0) {
			this.FRetestTimes = FRetestTimes_0;
		}
	
	}}