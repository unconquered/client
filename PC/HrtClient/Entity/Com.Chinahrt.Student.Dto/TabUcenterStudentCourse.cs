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
	/// AbstractTabUcenterStudentCourse entity provides the base persistence
	/// definition of the TabUcenterStudentCourse entity.
	/// </summary>
	///
	[Serializable]
	
	public class TabUcenterStudentCourse {
	
		// Fields
	
		private String FStucourId;
		private String FCourseId;
		private String FEntityId;
		private String FUserId;
		private String FPlanId;
		private String FUserName;
		private String FServplatId;
		private DateTime FAddTime;
		private String FCourseNumber;
		private String FCourseName;
		private String FCourseblogoUrl;
		private String FCourseslogoUrl;
		private String FCourseDesc;
		private String FTeacherName;
		private String FSupplierName;
		private Int32 FClassType;
		private String FPlanName;
		private Int32 FIfTest;
		private Double FClassHours;
		private Double FClassScores;
		private Double FClassFee;
		private DateTime FFirstDate;
		private String FHighStatus;
		private DateTime FHighStatusDate;
		private Double FHighScore;
		private Double FLastScore;
		private String FLastStatus;
		private DateTime FLastDate;
		private String FTotalTime;
		private Double FStudyProgress;
		private DateTime FProgressDate;
		private String FStudyStatus;
		private Int32 FFromWay;
		private String FOrderNo;
		private Int32 FCourseStatus;
		private DateTime FCloseDate;
	
		// Constructors
	
		// Property accessors
	
		public String GetFStucourId() {
			return this.FStucourId;
		}
	
		public void SetFStucourId(String FStucourId_0) {
			this.FStucourId = FStucourId_0;
		}
	
		public String GetFCourseId() {
			return this.FCourseId;
		}
	
		public void SetFCourseId(String FCourseId_0) {
			this.FCourseId = FCourseId_0;
		}
	
		public String GetFEntityId() {
			return this.FEntityId;
		}
	
		public void SetFEntityId(String FEntityId_0) {
			this.FEntityId = FEntityId_0;
		}
	
		public String GetFUserId() {
			return this.FUserId;
		}
	
		public void SetFUserId(String FUserId_0) {
			this.FUserId = FUserId_0;
		}
	
		public String GetFPlanId() {
			return this.FPlanId;
		}
	
		public void SetFPlanId(String FPlanId_0) {
			this.FPlanId = FPlanId_0;
		}
	
		public String GetFUserName() {
			return this.FUserName;
		}
	
		public void SetFUserName(String FUserName_0) {
			this.FUserName = FUserName_0;
		}
	
		public String GetFCourseNumber() {
			return this.FCourseNumber;
		}
	
		public void SetFCourseNumber(String FCourseNumber_0) {
			this.FCourseNumber = FCourseNumber_0;
		}
	
		public String GetFCourseName() {
			return this.FCourseName;
		}
	
		public void SetFCourseName(String FCourseName_0) {
			this.FCourseName = FCourseName_0;
		}
	
		public String GetFCourseblogoUrl() {
			return this.FCourseblogoUrl;
		}
	
		public void SetFCourseblogoUrl(String FCourseblogoUrl_0) {
			this.FCourseblogoUrl = FCourseblogoUrl_0;
		}
	
		public String GetFCourseslogoUrl() {
			return this.FCourseslogoUrl;
		}
	
		public void SetFCourseslogoUrl(String FCourseslogoUrl_0) {
			this.FCourseslogoUrl = FCourseslogoUrl_0;
		}
	
		public String GetFTeacherName() {
			return this.FTeacherName;
		}
	
		public void SetFTeacherName(String FTeacherName_0) {
			this.FTeacherName = FTeacherName_0;
		}
	
		public String GetFSupplierName() {
			return this.FSupplierName;
		}
	
		public void SetFSupplierName(String FSupplierName_0) {
			this.FSupplierName = FSupplierName_0;
		}
	
		public Int32 GetFClassType() {
			return this.FClassType;
		}
	
		public void SetFClassType(Int32 FClassType_0) {
			this.FClassType = FClassType_0;
		}
	
		public String GetFPlanName() {
			return this.FPlanName;
		}
	
		public void SetFPlanName(String FPlanName_0) {
			this.FPlanName = FPlanName_0;
		}
	
		public Int32 GetFIfTest() {
			return this.FIfTest;
		}
	
		public void SetFIfTest(Int32 FIfTest_0) {
			this.FIfTest = FIfTest_0;
		}
	
		public Double GetFClassHours() {
			return this.FClassHours;
		}
	
		public void SetFClassHours(Double FClassHours_0) {
			this.FClassHours = FClassHours_0;
		}
	
		public Double GetFClassScores() {
			return this.FClassScores;
		}
	
		public void SetFClassScores(Double FClassScores_0) {
			this.FClassScores = FClassScores_0;
		}
	
		public Double GetFClassFee() {
			return this.FClassFee;
		}
	
		public void SetFClassFee(Double FClassFee_0) {
			this.FClassFee = FClassFee_0;
		}
	
		public DateTime GetFFirstDate() {
			return this.FFirstDate;
		}
	
		public void SetFFirstDate(DateTime FFirstDate_0) {
			this.FFirstDate = FFirstDate_0;
		}
	
		public String GetFHighStatus() {
			return this.FHighStatus;
		}
	
		public void SetFHighStatus(String FHighStatus_0) {
			this.FHighStatus = FHighStatus_0;
		}
	
		public DateTime GetFHighStatusDate() {
			return this.FHighStatusDate;
		}
	
		public void SetFHighStatusDate(DateTime FHighStatusDate_0) {
			this.FHighStatusDate = FHighStatusDate_0;
		}
	
		public Double GetFHighScore() {
			return this.FHighScore;
		}
	
		public void SetFHighScore(Double FHighScore_0) {
			this.FHighScore = FHighScore_0;
		}
	
		public Double GetFLastScore() {
			return this.FLastScore;
		}
	
		public void SetFLastScore(Double FLastScore_0) {
			this.FLastScore = FLastScore_0;
		}
	
		public String GetFLastStatus() {
			return this.FLastStatus;
		}
	
		public void SetFLastStatus(String FLastStatus_0) {
			this.FLastStatus = FLastStatus_0;
		}
	
		public DateTime GetFLastDate() {
			return this.FLastDate;
		}
	
		public void SetFLastDate(DateTime FLastDate_0) {
			this.FLastDate = FLastDate_0;
		}
	
		public String GetFTotalTime() {
			return this.FTotalTime;
		}
	
		public void SetFTotalTime(String FTotalTime_0) {
			this.FTotalTime = FTotalTime_0;
		}
	
		public Double GetFStudyProgress() {
			return this.FStudyProgress;
		}
	
		public void SetFStudyProgress(Double FStudyProgress_0) {
			this.FStudyProgress = FStudyProgress_0;
		}
	
		public DateTime GetFProgressDate() {
			return this.FProgressDate;
		}
	
		public void SetFProgressDate(DateTime FProgressDate_0) {
			this.FProgressDate = FProgressDate_0;
		}
	
		public String GetFCourseDesc() {
			return FCourseDesc;
		}
	
		public void SetFCourseDesc(String fCourseDesc) {
			FCourseDesc = fCourseDesc;
		}
	
		public String GetFStudyStatus() {
			return FStudyStatus;
		}
	
		public void SetFStudyStatus(String fStudyStatus) {
			FStudyStatus = fStudyStatus;
		}
	
		public Int32 GetFFromWay() {
			return FFromWay;
		}
	
		public void SetFFromWay(Int32 fFromWay) {
			FFromWay = fFromWay;
		}
	
		public DateTime GetFAddTime() {
			return FAddTime;
		}
	
		public void SetFAddTime(DateTime fAddTime) {
			FAddTime = fAddTime;
		}
	
		public String GetFServplatId() {
			return FServplatId;
		}
	
		public void SetFServplatId(String fServplatId) {
			FServplatId = fServplatId;
		}
	
		public String GetFOrderNo() {
			return FOrderNo;
		}
	
		public void SetFOrderNo(String fOrderNo) {
			FOrderNo = fOrderNo;
		}
	
		public Int32 GetFCourseStatus() {
			return FCourseStatus;
		}
	
		public void SetFCourseStatus(Int32 fCourseStatus) {
			FCourseStatus = fCourseStatus;
		}
	
		public DateTime GetFCloseDate() {
			return FCloseDate;
		}
	
		public void SetFCloseDate(DateTime fCloseDate) {
			FCloseDate = fCloseDate;
		}
	
	}}
