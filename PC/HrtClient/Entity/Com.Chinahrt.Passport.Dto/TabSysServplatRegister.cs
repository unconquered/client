// --------------------------------------------------------------------------------------------------
// This file was automatically generated by J2CS Translator (http://j2cstranslator.sourceforge.net/). 
// Version 1.3.6.20110331_01     
// 14-1-24 ����10:49    
// ${CustomMessageForDisclaimer}                                                                             
// --------------------------------------------------------------------------------------------------
 namespace Com.Chinahrt.Passport.Dto {
	
	using System;
	using System.Collections;
	using System.ComponentModel;
	using System.IO;
	using System.Runtime.CompilerServices;
	using System.Runtime.Serialization;
	
	/// <summary>
	/// TabSysServplatRegister entity. @author MyEclipse Persistence Tools
	/// </summary>
	///
	[Serializable]
	
	public class TabSysServplatRegister {
	
		// Fields
	
		private String FRegisterId;
		private String FServplatId;
		private String FServplatName;
		private Int32 FPlatStatus;
		private String FRegOption;
		private Int32 FPlatPub;
		private String FToporgId;
		private String FLogoutUrl;
		private String FGuidePage;
		private String FPlatLogo;
		private Int32 FPlanFlag;
		private Int32 FRegFlag;
		private String FSignName;
		private Int32 FEditFlag; //�Ƿ�����ѧԱ�޸�����
		private String FIndexName; //��ҳ����
		private Int32 FCheckFlag; //ѧԱע���Ƿ����
		private String FEditOption; //ѧԱ���ɱ༭�б�
	
		// Constructors
	
		/// <summary>
		/// default constructor 
		/// </summary>
		///
		public TabSysServplatRegister() {
		}
	
		/// <summary>
		/// minimal constructor 
		/// </summary>
		///
		public TabSysServplatRegister(String FRegisterId_0) {
			this.FRegisterId = FRegisterId_0;
		}
	
		/// <summary>
		/// full constructor 
		/// </summary>
		///
		public String GetFRegisterId() {
			return this.FRegisterId;
		}
	
		public TabSysServplatRegister(String fRegisterId, String fServplatId,
				String fServplatName, Int32 fPlatStatus, String fRegOption,
				Int32 fPlatPub, String fToporgId, String fLogoutUrl,
				String fGuidePage, String fPlatLogo, Int32 fPlanFlag,
				Int32 fRegFlag, String fSignName, Int32 fEditFlag,
				String fIndexName, Int32 fCheckFlag, String fEditOption) : base() {
			FRegisterId = fRegisterId;
			FServplatId = fServplatId;
			FServplatName = fServplatName;
			FPlatStatus = fPlatStatus;
			FRegOption = fRegOption;
			FPlatPub = fPlatPub;
			FToporgId = fToporgId;
			FLogoutUrl = fLogoutUrl;
			FGuidePage = fGuidePage;
			FPlatLogo = fPlatLogo;
			FPlanFlag = fPlanFlag;
			FRegFlag = fRegFlag;
			FSignName = fSignName;
			FEditFlag = fEditFlag;
			FIndexName = fIndexName;
			FCheckFlag = fCheckFlag;
			FEditOption = fEditOption;
		}
	
		public void SetFRegisterId(String FRegisterId_0) {
			this.FRegisterId = FRegisterId_0;
		}
	
		public String GetFServplatId() {
			return this.FServplatId;
		}
	
		public void SetFServplatId(String FServplatId_0) {
			this.FServplatId = FServplatId_0;
		}
	
		public String GetFServplatName() {
			return this.FServplatName;
		}
	
		public void SetFServplatName(String FServplatName_0) {
			this.FServplatName = FServplatName_0;
		}
	
		public Int32 GetFPlatStatus() {
			return this.FPlatStatus;
		}
	
		public void SetFPlatStatus(Int32 FPlatStatus_0) {
			this.FPlatStatus = FPlatStatus_0;
		}
	
		public String GetFRegOption() {
			return this.FRegOption;
		}
	
		public void SetFRegOption(String FRegOption_0) {
			this.FRegOption = FRegOption_0;
		}
	
		public Int32 GetFPlatPub() {
			return this.FPlatPub;
		}
	
		public void SetFPlatPub(Int32 FPlatPub_0) {
			this.FPlatPub = FPlatPub_0;
		}
	
		public String GetFToporgId() {
			return FToporgId;
		}
	
		public void SetFToporgId(String fToporgId) {
			FToporgId = fToporgId;
		}
	
		public String GetFLogoutUrl() {
			return FLogoutUrl;
		}
	
		public void SetFLogoutUrl(String fLogoutUrl) {
			FLogoutUrl = fLogoutUrl;
		}
	
		public String GetFGuidePage() {
			return FGuidePage;
		}
	
		public void SetFGuidePage(String fGuidePage) {
			FGuidePage = fGuidePage;
		}
	
		public String GetFPlatLogo() {
			return FPlatLogo;
		}
	
		public void SetFPlatLogo(String fPlatLogo) {
			FPlatLogo = fPlatLogo;
		}
	
		public Int32 GetFPlanFlag() {
			return FPlanFlag;
		}
	
		public void SetFPlanFlag(Int32 fPlanFlag) {
			FPlanFlag = fPlanFlag;
		}
	
		public Int32 GetFRegFlag() {
			return FRegFlag;
		}
	
		public void SetFRegFlag(Int32 fRegFlag) {
			FRegFlag = fRegFlag;
		}
	
		public String GetFSignName() {
			return FSignName;
		}
	
		public void SetFSignName(String fSignName) {
			FSignName = fSignName;
		}
	
		public Int32 GetFEditFlag() {
			return FEditFlag;
		}
	
		public void SetFEditFlag(Int32 fEditFlag) {
			FEditFlag = fEditFlag;
		}
	
		public String GetFIndexName() {
			return FIndexName;
		}
	
		public void SetFIndexName(String fIndexName) {
			FIndexName = fIndexName;
		}
	
		public Int32 GetFCheckFlag() {
			return FCheckFlag;
		}
	
		public void SetFCheckFlag(Int32 fCheckFlag) {
			FCheckFlag = fCheckFlag;
		}
	
		public String GetFEditOption() {
			return FEditOption;
		}
	
		public void SetFEditOption(String fEditOption) {
			FEditOption = fEditOption;
		}
	
	}}