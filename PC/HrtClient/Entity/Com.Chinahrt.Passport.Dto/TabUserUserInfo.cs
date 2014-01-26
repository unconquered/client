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
	/// TabUserUserInfo entity. @author MyEclipse Persistence Tools
	/// </summary>
	///
	[Serializable]
	
	/* @SuppressWarnings("serial")*/
	public class TabUserUserInfo {
	
		// Fields
	
		private String FUserId;
		private String FUserName; //ϵͳ�˻��û���
		private String FPassword;
		private String FRoutingId;
		private String FParentId;
		private String FIdcard;
		private String FUserlogoUrl;
		private String FRealname; //��ʵ����
		private String FSex; //�Ա�
		private DateTime FBirthday; //����
		private String FServplatId;
		private String FServplatName;
		private String FOrgId;
		private String FOrgName; //����������֯����
		private String FOffice;
		private String FPosition; //����ְ��
		private String FPolevelId;
		private String FBaseId;
		private String FPoliticalId;
		private String FDegreeId;
		private String FNatioinId;
		private String FIdentityId;
		private String FProfId; //רҵID
		private String FMobile;
		private String FOfficePhone;
		private String FEmail;
		private Int32 FIfStudent;
		private Int32 FIdType;
		private String FManageorgId;
		private String FManageorgName;
		private String FFindpassWay;
		private DateTime FCreateTime;
		private Int32 FStatus;
		private Int32 FIfOpen;
		private Int32 FUpdateFlag; // 0������ 1������
		private String FOrgPath;
		private String FManageorgPath;
		private Int32 FCheckFlag; // ѧԱע���Ƿ������	  0��δ���  1������ˡ�Ĭ�ϲ���Ҫ���
		private String FSessionId; // �����û���¼��SESSIONID��Ϣ,��
		private String FTimeStamp;
	
		// Constructors
	
		/// <summary>
		/// default constructor 
		/// </summary>
		///
		public TabUserUserInfo() {
		}
	
		/// <summary>
		/// minimal constructor 
		/// </summary>
		///
		public TabUserUserInfo(String FUserId_0) {
			this.FUserId = FUserId_0;
		}
	
		
	
		public TabUserUserInfo(String fUserId, String fUserName, String fPassword,
				String fRoutingId, String fParentId, String fIdcard,
				String fUserlogoUrl, String fRealname, String fSex, DateTime fBirthday,
				String fServplatId, String fServplatName, String fOrgId,
				String fOrgName, String fOffice, String fPosition,
				String fPolevelId, String fBaseId, String fPoliticalId,
				String fDegreeId, String fNatioinId, String fIdentityId,
				String fProfId, String fMobile, String fOfficePhone, String fEmail,
				Int32 fIfStudent, Int32 fIdType, String fManageorgId,
				String fManageorgName, String fFindpassWay, DateTime fCreateTime,
				Int32 fStatus, Int32 fIfOpen, Int32 fUpdateFlag,
				String fOrgPath, String fManageorgPath, Int32 fCheckFlag,
				String fSessionId) : base() {
			FUserId = fUserId;
			FUserName = fUserName;
			FPassword = fPassword;
			FRoutingId = fRoutingId;
			FParentId = fParentId;
			FIdcard = fIdcard;
			FUserlogoUrl = fUserlogoUrl;
			FRealname = fRealname;
			FSex = fSex;
			FBirthday = fBirthday;
			FServplatId = fServplatId;
			FServplatName = fServplatName;
			FOrgId = fOrgId;
			FOrgName = fOrgName;
			FOffice = fOffice;
			FPosition = fPosition;
			FPolevelId = fPolevelId;
			FBaseId = fBaseId;
			FPoliticalId = fPoliticalId;
			FDegreeId = fDegreeId;
			FNatioinId = fNatioinId;
			FIdentityId = fIdentityId;
			FProfId = fProfId;
			FMobile = fMobile;
			FOfficePhone = fOfficePhone;
			FEmail = fEmail;
			FIfStudent = fIfStudent;
			FIdType = fIdType;
			FManageorgId = fManageorgId;
			FManageorgName = fManageorgName;
			FFindpassWay = fFindpassWay;
			FCreateTime = fCreateTime;
			FStatus = fStatus;
			FIfOpen = fIfOpen;
			FUpdateFlag = fUpdateFlag;
			FOrgPath = fOrgPath;
			FManageorgPath = fManageorgPath;
			FCheckFlag = fCheckFlag;
			FSessionId = fSessionId;
		}
	
		// Property accessors
		public String GetFUserId() {
			return FUserId;
		}
	
		public void SetFUserId(String fUserId) {
			FUserId = fUserId;
		}
	
		public String GetFUserName() {
			return FUserName;
		}
	
		public void SetFUserName(String fUserName) {
			FUserName = fUserName;
		}
	
		public String GetFPassword() {
			return FPassword;
		}
	
		public void SetFPassword(String fPassword) {
			FPassword = fPassword;
		}
	
		public String GetFRoutingId() {
			return FRoutingId;
		}
	
		public void SetFRoutingId(String fRoutingId) {
			FRoutingId = fRoutingId;
		}
	
		public String GetFParentId() {
			return FParentId;
		}
	
		public void SetFParentId(String fParentId) {
			FParentId = fParentId;
		}
	
		public String GetFIdcard() {
			return FIdcard;
		}
	
		public void SetFIdcard(String fIdcard) {
			FIdcard = fIdcard;
		}
	
		public String GetFUserlogoUrl() {
			return FUserlogoUrl;
		}
	
		public void SetFUserlogoUrl(String fUserlogoUrl) {
			FUserlogoUrl = fUserlogoUrl;
		}
	
		public String GetFRealname() {
			return FRealname;
		}
	
		public void SetFRealname(String fRealname) {
			FRealname = fRealname;
		}
	
		public String GetFSex() {
			return FSex;
		}
	
		public void SetFSex(String fSex) {
			FSex = fSex;
		}
	
		public DateTime GetFBirthday() {
			return FBirthday;
		}
	
		public void SetFBirthday(DateTime fBirthday) {
			FBirthday = fBirthday;
		}
	
		public String GetFServplatId() {
			return FServplatId;
		}
	
		public void SetFServplatId(String fServplatId) {
			FServplatId = fServplatId;
		}
	
		public String GetFServplatName() {
			return FServplatName;
		}
	
		public void SetFServplatName(String fServplatName) {
			FServplatName = fServplatName;
		}
	
		public String GetFOrgId() {
			return FOrgId;
		}
	
		public void SetFOrgId(String fOrgId) {
			FOrgId = fOrgId;
		}
	
		public String GetFOrgName() {
			return FOrgName;
		}
	
		public void SetFOrgName(String fOrgName) {
			FOrgName = fOrgName;
		}
	
		public String GetFOffice() {
			return FOffice;
		}
	
		public void SetFOffice(String fOffice) {
			FOffice = fOffice;
		}
	
		public String GetFPosition() {
			return FPosition;
		}
	
		public void SetFPosition(String fPosition) {
			FPosition = fPosition;
		}
	
		public String GetFPolevelId() {
			return FPolevelId;
		}
	
		public void SetFPolevelId(String fPolevelId) {
			FPolevelId = fPolevelId;
		}
	
		public String GetFBaseId() {
			return FBaseId;
		}
	
		public void SetFBaseId(String fBaseId) {
			FBaseId = fBaseId;
		}
	
		public String GetFPoliticalId() {
			return FPoliticalId;
		}
	
		public void SetFPoliticalId(String fPoliticalId) {
			FPoliticalId = fPoliticalId;
		}
	
		public String GetFDegreeId() {
			return FDegreeId;
		}
	
		public void SetFDegreeId(String fDegreeId) {
			FDegreeId = fDegreeId;
		}
	
		public String GetFNatioinId() {
			return FNatioinId;
		}
	
		public void SetFNatioinId(String fNatioinId) {
			FNatioinId = fNatioinId;
		}
	
		public String GetFIdentityId() {
			return FIdentityId;
		}
	
		public void SetFIdentityId(String fIdentityId) {
			FIdentityId = fIdentityId;
		}
	
		public String GetFProfId() {
			return FProfId;
		}
	
		public void SetFProfId(String fProfId) {
			FProfId = fProfId;
		}
	
		public String GetFMobile() {
			return FMobile;
		}
	
		public void SetFMobile(String fMobile) {
			FMobile = fMobile;
		}
	
		public String GetFOfficePhone() {
			return FOfficePhone;
		}
	
		public void SetFOfficePhone(String fOfficePhone) {
			FOfficePhone = fOfficePhone;
		}
	
		public String GetFEmail() {
			return FEmail;
		}
	
		public void SetFEmail(String fEmail) {
			FEmail = fEmail;
		}
	
		public Int32 GetFIfStudent() {
			return FIfStudent;
		}
	
		public void SetFIfStudent(Int32 fIfStudent) {
			FIfStudent = fIfStudent;
		}
	
		public Int32 GetFIdType() {
			return FIdType;
		}
	
		public void SetFIdType(Int32 fIdType) {
			FIdType = fIdType;
		}
	
		public String GetFManageorgId() {
			return FManageorgId;
		}
	
		public void SetFManageorgId(String fManageorgId) {
			FManageorgId = fManageorgId;
		}
	
		public String GetFManageorgName() {
			return FManageorgName;
		}
	
		public void SetFManageorgName(String fManageorgName) {
			FManageorgName = fManageorgName;
		}
	
		public String GetFFindpassWay() {
			return FFindpassWay;
		}
	
		public void SetFFindpassWay(String fFindpassWay) {
			FFindpassWay = fFindpassWay;
		}
	
		public DateTime GetFCreateTime() {
			return FCreateTime;
		}
	
		public void SetFCreateTime(DateTime fCreateTime) {
			FCreateTime = fCreateTime;
		}
	
		public Int32 GetFStatus() {
			return FStatus;
		}
	
		public void SetFStatus(Int32 fStatus) {
			FStatus = fStatus;
		}
	
		public Int32 GetFIfOpen() {
			return FIfOpen;
		}
	
		public void SetFIfOpen(Int32 fIfOpen) {
			FIfOpen = fIfOpen;
		}
	
		public Int32 GetFUpdateFlag() {
			return FUpdateFlag;
		}
	
		public void SetFUpdateFlag(Int32 fUpdateFlag) {
			FUpdateFlag = fUpdateFlag;
		}
	
		public String GetFOrgPath() {
			return FOrgPath;
		}
	
		public void SetFOrgPath(String fOrgPath) {
			FOrgPath = fOrgPath;
		}
	
		public String GetFManageorgPath() {
			return FManageorgPath;
		}
	
		public void SetFManageorgPath(String fManageorgPath) {
			FManageorgPath = fManageorgPath;
		}
	
		public Int32 GetFCheckFlag() {
			return FCheckFlag;
		}
	
		public void SetFCheckFlag(Int32 fCheckFlag) {
			FCheckFlag = fCheckFlag;
		}
	
		public String GetFSessionId() {
			return FSessionId;
		}
	
		public void SetFSessionId(String fSessionId) {
			FSessionId = fSessionId;
		}
	
		public String GetFTimeStamp() {
			return FTimeStamp;
		}
	
		public void SetFTimeStamp(String fTimeStamp) {
			FTimeStamp = fTimeStamp;
		}
	
	}}