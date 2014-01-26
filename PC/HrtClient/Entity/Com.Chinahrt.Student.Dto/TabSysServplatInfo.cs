// --------------------------------------------------------------------------------------------------
// This file was automatically generated by J2CS Translator (http://j2cstranslator.sourceforge.net/). 
// Version 1.3.6.20110331_01     
// 14-1-24 上午10:49    
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
	/// TabSysServplatInfo entity. @author MyEclipse Persistence Tools
	/// </summary>
	///
	[Serializable]
	
	public class TabSysServplatInfo {
	
		// Fields
	
		private String FServplatId;
		private String FToporgId;
		private String FServplatName;
		private Int32 FPlatStatus;
		private String FPlatLogo;
		private String FPlatDomain;
		private String FPortalUrl;
		private String FLoginUrl;
		private String FLogoutUrl;
		private String FGuidePage;
		private String FHeadCode;
		private String FBottomCode;
		private String FSysuserId;
		private DateTime FCreateTime;
		private String FThemeId;
		private String FPlatDesc;
		private Int32 FSplitWay;
		private Double FSplitGet;
		private Double FSplitReturn;
		private String FSplitPercent;
		private String FPayAcc;
		private String FAdminUser;
		private String FTechChief;
		private String FSaleChief;
		private Int32 FPlatAttr;
		private Int32 FIfSupplier;
		private Double FTrialNums;
		private Double FTrialScores;
		private DateTime FTrialDate;
		private String FTechChiefname;
		private String FSaleChiefname;
		private String FSupplierAccount;
		private Int32 FPlatType;
		private String FRegOption;
		private Int32 FSortCode;
		private Int32 FPlanFlag; // 学员登录后是否直接进入培训计划页。0：否	1：是	默认否
		private Int32 FRegFlag; // 是否允许学员注册	0：否	1：是	默认否
		private Int32 FCheckFlag; // 学员注册是否验证	0：否	1：是
		private String FSignName; // 平台标记（大写），区分订单号用
		private Int32 FEditFlag; // 学员个人资料更新标记，0：允许更新，1：不允许更新
		private String FIndexName; // 首页index页面名称
	
		private String FPayType;
	
		// Constructors
	
		/// <summary>
		/// default constructor 
		/// </summary>
		///
		public TabSysServplatInfo() {
		}
	
		/// <summary>
		/// minimal constructor 
		/// </summary>
		///
		public TabSysServplatInfo(String FServplatId_0) {
			this.FServplatId = FServplatId_0;
		}
	
		public String GetFServplatId() {
			return this.FServplatId;
		}
	
		public void SetFServplatId(String FServplatId_0) {
			this.FServplatId = FServplatId_0;
		}
	
		public String GetFToporgId() {
			return this.FToporgId;
		}
	
		public void SetFToporgId(String FToporgId_0) {
			this.FToporgId = FToporgId_0;
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
	
		public String GetFPlatLogo() {
			return this.FPlatLogo;
		}
	
		public void SetFPlatLogo(String FPlatLogo_0) {
			this.FPlatLogo = FPlatLogo_0;
		}
	
		public String GetFPlatDomain() {
			return this.FPlatDomain;
		}
	
		public void SetFPlatDomain(String FPlatDomain_0) {
			this.FPlatDomain = FPlatDomain_0;
		}
	
		public String GetFPortalUrl() {
			return this.FPortalUrl;
		}
	
		public void SetFPortalUrl(String FPortalUrl_0) {
			this.FPortalUrl = FPortalUrl_0;
		}
	
		public String GetFLoginUrl() {
			return this.FLoginUrl;
		}
	
		public void SetFLoginUrl(String FLoginUrl_0) {
			this.FLoginUrl = FLoginUrl_0;
		}
	
		public String GetFLogoutUrl() {
			return this.FLogoutUrl;
		}
	
		public void SetFLogoutUrl(String FLogoutUrl_0) {
			this.FLogoutUrl = FLogoutUrl_0;
		}
	
		public String GetFGuidePage() {
			return this.FGuidePage;
		}
	
		public void SetFGuidePage(String FGuidePage_0) {
			this.FGuidePage = FGuidePage_0;
		}
	
		public String GetFHeadCode() {
			return this.FHeadCode;
		}
	
		public void SetFHeadCode(String FHeadCode_0) {
			this.FHeadCode = FHeadCode_0;
		}
	
		public String GetFBottomCode() {
			return this.FBottomCode;
		}
	
		public void SetFBottomCode(String FBottomCode_0) {
			this.FBottomCode = FBottomCode_0;
		}
	
		public String GetFSysuserId() {
			return this.FSysuserId;
		}
	
		public void SetFSysuserId(String FSysuserId_0) {
			this.FSysuserId = FSysuserId_0;
		}
	
		public DateTime GetFCreateTime() {
			return this.FCreateTime;
		}
	
		public void SetFCreateTime(DateTime date) {
			this.FCreateTime = date;
		}
	
		public String GetFThemeId() {
			return this.FThemeId;
		}
	
		public void SetFThemeId(String FThemeId_0) {
			this.FThemeId = FThemeId_0;
		}
	
		public String GetFPlatDesc() {
			return this.FPlatDesc;
		}
	
		public void SetFPlatDesc(String FPlatDesc_0) {
			this.FPlatDesc = FPlatDesc_0;
		}
	
		public Int32 GetFSplitWay() {
			return this.FSplitWay;
		}
	
		public void SetFSplitWay(Int32 FSplitWay_0) {
			this.FSplitWay = FSplitWay_0;
		}
	
		public Double GetFSplitGet() {
			return this.FSplitGet;
		}
	
		public void SetFSplitGet(Double FSplitGet_0) {
			this.FSplitGet = FSplitGet_0;
		}
	
		public Double GetFSplitReturn() {
			return this.FSplitReturn;
		}
	
		public void SetFSplitReturn(Double FSplitReturn_0) {
			this.FSplitReturn = FSplitReturn_0;
		}
	
		public String GetFSplitPercent() {
			return this.FSplitPercent;
		}
	
		public void SetFSplitPercent(String FSplitPercent_0) {
			this.FSplitPercent = FSplitPercent_0;
		}
	
		public String GetFPayAcc() {
			return this.FPayAcc;
		}
	
		public void SetFPayAcc(String FPayAcc_0) {
			this.FPayAcc = FPayAcc_0;
		}
	
		public String GetFAdminUser() {
			return this.FAdminUser;
		}
	
		public void SetFAdminUser(String FAdminUser_0) {
			this.FAdminUser = FAdminUser_0;
		}
	
		public String GetFTechChief() {
			return this.FTechChief;
		}
	
		public void SetFTechChief(String FTechChief_0) {
			this.FTechChief = FTechChief_0;
		}
	
		public String GetFSaleChief() {
			return this.FSaleChief;
		}
	
		public void SetFSaleChief(String FSaleChief_0) {
			this.FSaleChief = FSaleChief_0;
		}
	
		public Int32 GetFPlatAttr() {
			return this.FPlatAttr;
		}
	
		public void SetFPlatAttr(Int32 FPlatAttr_0) {
			this.FPlatAttr = FPlatAttr_0;
		}
	
		public Int32 GetFIfSupplier() {
			return this.FIfSupplier;
		}
	
		public void SetFIfSupplier(Int32 FIfSupplier_0) {
			this.FIfSupplier = FIfSupplier_0;
		}
	
		public Double GetFTrialNums() {
			return FTrialNums;
		}
	
		public void SetFTrialNums(Double fTrialNums) {
			this.FTrialNums = fTrialNums;
		}
	
		public Double GetFTrialScores() {
			return FTrialScores;
		}
	
		public void SetFTrialScores(Double fTrialScores) {
			this.FTrialScores = fTrialScores;
		}
	
		public DateTime GetFTrialDate() {
			return FTrialDate;
		}
	
		public void SetFTrialDate(DateTime fTrialDate) {
			this.FTrialDate = fTrialDate;
		}
	
		public String GetFTechChiefname() {
			return FTechChiefname;
		}
	
		public void SetFTechChiefname(String fTechChiefname) {
			FTechChiefname = fTechChiefname;
		}
	
		public String GetFSaleChiefname() {
			return FSaleChiefname;
		}
	
		public void SetFSaleChiefname(String fSaleChiefname) {
			FSaleChiefname = fSaleChiefname;
		}
	
		public String GetFSupplierAccount() {
			return FSupplierAccount;
		}
	
		public void SetFSupplierAccount(String fSupplierAccount) {
			FSupplierAccount = fSupplierAccount;
		}
	
		public Int32 GetFPlatType() {
			return FPlatType;
		}
	
		public void SetFPlatType(Int32 fPlatType) {
			FPlatType = fPlatType;
		}
	
		public String GetFRegOption() {
			return FRegOption;
		}
	
		public void SetFRegOption(String fRegOption) {
			FRegOption = fRegOption;
		}
	
		public Int32 GetFSortCode() {
			return FSortCode;
		}
	
		public void SetFSortCode(Int32 fSortCode) {
			FSortCode = fSortCode;
		}
	
		public String GetFPayType() {
			return FPayType;
		}
	
		public void SetFPayType(String fPayType) {
			FPayType = fPayType;
		}
	
		public String GetFSignName() {
			return FSignName;
		}
	
		public void SetFSignName(String fSignName) {
			FSignName = fSignName;
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
	
		public Int32 GetFCheckFlag() {
			return FCheckFlag;
		}
	
		public void SetFCheckFlag(Int32 fCheckFlag) {
			FCheckFlag = fCheckFlag;
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
	
	}}
