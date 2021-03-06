// --------------------------------------------------------------------------------------------------
// This file was automatically generated by J2CS Translator (http://j2cstranslator.sourceforge.net/). 
// Version 1.3.6.20110331_01     
// 14-1-24 上午10:49    
// ${CustomMessageForDisclaimer}                                                                             
// --------------------------------------------------------------------------------------------------
 namespace Com.Chinahrt.Shop.Dto {
	
	using System;
	using System.Collections;
	using System.ComponentModel;
	using System.IO;
	using System.Runtime.CompilerServices;
	using System.Runtime.Serialization;
	
	/* @SuppressWarnings("serial")*/
	[Serializable]
	public class TabShopOrderInfo {
	
		private String FOrderId; //	订单信息编号	varchar(64)
		private String FUserId; //	学员编号	varchar(64)
		private String FUserName; //	学员用户名	varchar(100)
		private String FServplatId; //	所属平台	varchar(64)
		private String FOrderNo; //	订单编号	varchar(100)
		private String FDealNo; //	订单交易号	varchar(100)
		private String FOrderInfo; //	订单内容	varchar(500)
		private DateTime FOrderTime; //	订单创建时间	datetime
		private Double FOrderMoney; //	订单金额	numeric(8,2)
		private Double FOrderPoints; //	订单积分	
		private String FPaytypeId; //	支付方式ID	varchar(64)
		private String FPaytypeName; //  支付方式名称
		private DateTime FPayTime; //  订单支付时间
		private Double FPayMoney; //	支付金额	numeric(8,2)
		private Double FDiscount; //	折扣	numeric(8,2)
		private Double FPayPoints; //	订单支付的积分	numeric(8)
		private String FPayAccount; //	支付账号	varchar(64)
		private Double FHandingFee; //	手续费	numeric(8,2)
		private Double FSplitMoney; //	分账金额	numeric(8,2)
		private Int32 FOrderStatus; //	订单状态	integer
		private Int32 FOrderType; //  `f_order_type`
	
		private Int32 FInvoiceStatus; //  发票状态，0：未开；1：已开
		private String FInvoiceId; //  发票ID
		private String FInvoiceNo; //  有用，勿动！
	
		private String FOrgPath;
		private String FAuthorizerId; //授权人ID
		private String FAuthorizerName; //授权人名称
		private String FAuthorizerOrg; //授权人所属地区
		private String FAuthorizerOrgName; //授权人所属地区名称
		private String FAuthorizerOrgPath; //授权人组织路径
		private String FOffice; //工作单位
		private String FIdcard; //身份证号
	
		public TabShopOrderInfo() {
		}
	
		public String GetFOrderId() {
			return FOrderId;
		}
	
		public void SetFOrderId(String fOrderId) {
			FOrderId = fOrderId;
		}
	
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
	
		public String GetFDealNo() {
			return FDealNo;
		}
	
		public void SetFDealNo(String fDealNo) {
			FDealNo = fDealNo;
		}
	
		public String GetFOrderInfo() {
			return FOrderInfo;
		}
	
		public void SetFOrderInfo(String fOrderInfo) {
			FOrderInfo = fOrderInfo;
		}
	
		public DateTime GetFOrderTime() {
			return FOrderTime;
		}
	
		public void SetFOrderTime(DateTime fOrderTime) {
			FOrderTime = fOrderTime;
		}
	
		public Double GetFOrderMoney() {
			return FOrderMoney;
		}
	
		public void SetFOrderMoney(Double fOrderMoney) {
			FOrderMoney = fOrderMoney;
		}
	
		public Double GetFOrderPoints() {
			return FOrderPoints;
		}
	
		public void SetFOrderPoints(Double fOrderPoints) {
			FOrderPoints = fOrderPoints;
		}
	
		public String GetFPaytypeId() {
			return FPaytypeId;
		}
	
		public void SetFPaytypeId(String fPaytypeId) {
			FPaytypeId = fPaytypeId;
		}
	
		public Double GetFPayMoney() {
			return FPayMoney;
		}
	
		public void SetFPayMoney(Double fPayMoney) {
			FPayMoney = fPayMoney;
		}
	
		public Double GetFDiscount() {
			return FDiscount;
		}
	
		public void SetFDiscount(Double fDiscount) {
			FDiscount = fDiscount;
		}
	
		public Double GetFPayPoints() {
			return FPayPoints;
		}
	
		public void SetFPayPoints(Double fPayPoints) {
			FPayPoints = fPayPoints;
		}
	
		public String GetFPayAccount() {
			return FPayAccount;
		}
	
		public void SetFPayAccount(String fPayAccount) {
			FPayAccount = fPayAccount;
		}
	
		public Double GetFHandingFee() {
			return FHandingFee;
		}
	
		public void SetFHandingFee(Double fHandingFee) {
			FHandingFee = fHandingFee;
		}
	
		public Double GetFSplitMoney() {
			return FSplitMoney;
		}
	
		public void SetFSplitMoney(Double fSplitMoney) {
			FSplitMoney = fSplitMoney;
		}
	
		public Int32 GetFOrderStatus() {
			return FOrderStatus;
		}
	
		public void SetFOrderStatus(Int32 fOrderStatus) {
			FOrderStatus = fOrderStatus;
		}
	
		public String GetFPaytypeName() {
			return FPaytypeName;
		}
	
		public void SetFPaytypeName(String fPaytypeName) {
			FPaytypeName = fPaytypeName;
		}
	
		public DateTime GetFPayTime() {
			return FPayTime;
		}
	
		public void SetFPayTime(DateTime fPayTime) {
			FPayTime = fPayTime;
		}
	
		public Int32 GetFOrderType() {
			return FOrderType;
		}
	
		public void SetFOrderType(Int32 fOrderType) {
			FOrderType = fOrderType;
		}
	
		public Int32 GetFInvoiceStatus() {
			return FInvoiceStatus;
		}
	
		public void SetFInvoiceStatus(Int32 fInvoiceStatus) {
			FInvoiceStatus = fInvoiceStatus;
		}
	
		public String GetFInvoiceId() {
			return FInvoiceId;
		}
	
		public void SetFInvoiceId(String fInvoiceId) {
			FInvoiceId = fInvoiceId;
		}
	
		public String GetFOrgPath() {
			return FOrgPath;
		}
	
		public void SetFOrgPath(String fOrgPath) {
			FOrgPath = fOrgPath;
		}
	
		public String GetFAuthorizerId() {
			return FAuthorizerId;
		}
	
		public void SetFAuthorizerId(String fAuthorizerId) {
			FAuthorizerId = fAuthorizerId;
		}
	
		public String GetFAuthorizerName() {
			return FAuthorizerName;
		}
	
		public void SetFAuthorizerName(String fAuthorizerName) {
			FAuthorizerName = fAuthorizerName;
		}
	
		public String GetFAuthorizerOrg() {
			return FAuthorizerOrg;
		}
	
		public void SetFAuthorizerOrg(String fAuthorizerOrg) {
			FAuthorizerOrg = fAuthorizerOrg;
		}
	
		public String GetFAuthorizerOrgName() {
			return FAuthorizerOrgName;
		}
	
		public void SetFAuthorizerOrgName(String fAuthorizerOrgName) {
			FAuthorizerOrgName = fAuthorizerOrgName;
		}
	
		public String GetFAuthorizerOrgPath() {
			return FAuthorizerOrgPath;
		}
	
		public void SetFAuthorizerOrgPath(String fAuthorizerOrgPath) {
			FAuthorizerOrgPath = fAuthorizerOrgPath;
		}
	
		public String GetFOffice() {
			return FOffice;
		}
	
		public void SetFOffice(String fOffice) {
			FOffice = fOffice;
		}
	
		public String GetFIdcard() {
			return FIdcard;
		}
	
		public void SetFIdcard(String fIdcard) {
			FIdcard = fIdcard;
		}
	
		public String GetFInvoiceNo() {
			return FInvoiceNo;
		}
	
		public void SetFInvoiceNo(String fInvoiceNo) {
			FInvoiceNo = fInvoiceNo;
		}
	
	}
}
