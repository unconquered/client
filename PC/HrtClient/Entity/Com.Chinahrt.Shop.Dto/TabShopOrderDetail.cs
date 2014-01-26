// --------------------------------------------------------------------------------------------------
// This file was automatically generated by J2CS Translator (http://j2cstranslator.sourceforge.net/). 
// Version 1.3.6.20110331_01     
// 14-1-24 ����10:49    
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
	public class TabShopOrderDetail {
		//ok 3.16 У��
		private String FOrderdetailId; //	֧����ϸ��Ϣ���	varchar(64)
		private String FOrderId; //	������Ϣ���	varchar(64)
		private String FGoodsId; //	��Ʒ���	varchar(64)
		private String FGoodstypeId; //  ��Ʒ������ϢID
		private String FUserId; //	�û����	varchar(64)
		private String FUserName; //	ѧԱ�û���	varchar(100)
		private String FServplatId; //  ѧԱ��������ƽ̨ID
		private DateTime FOrderTime; //	֧��ʱ��	datetime
		private String FOrderNo; //	�������	varchar(100)
		private Double FOrderMoney; //  f_order_money
		private String FDealNo; //	���׺�	varchar(100)
		private String FPlanId; //	�����ƻ����	varchar(64)
		private String FPlanNo; //  ��ѵ�ƻ����
		private String FSupplierId; //	�μ���Ӧ��ID	varchar(64)
		private String FGoodsFilter; //	��Ʒɸѡ����ID�����ڿμ��������Ƕ������;�ָ�	varchar(500)
		private String FGoodslogoUrl; //	��Ʒ����logo	varchar(200)
		private String FGoodsName; //	��Ʒ����	varchar(100)
		private String FGoodsDesc; //	��Ʒ����	varchar(200)
		private String FPaytypeId; //	֧����ʽID	varchar(64)
		private String FPaytypeName; //	֧����ʽ����	varchar(50)
		private DateTime FPayTime;
		private Double FPayPrice; //	��Ʒ���ۼ۸�	numeric(8,2)
		private Double FPayPoints; //	��Ʒ���ۻ���	numeric(8,2)
		private Int32 FGoodsNums; //    int(11) DEFAULT NULL COMMENT '��Ʒ����',
		private Double FCostPrice; // ��Ʒ��Ӫ�ɱ�
		private Int32 FOrderStatus; //	֧��״̬	integer
		private Double FHandingFee; //	������	numeric(8,2)
		private Double FSplitMoney; //	���˽��	numeric(8,2)
		private Int32 FPointsStatus; //	����״̬��Ĭ��Ϊ�������û��֡�0�����������֣�1����������	integer
		private String FOrgPath;
		private Int32 FOrderType;
		private String FAuthorizerId; //��Ȩ��ID
		private String FAuthorizerName; //��Ȩ������
		private String FAuthorizerOrg; //��Ȩ����������
		private String FAuthorizerOrgName; //��Ȩ��������������
		private String FAuthorizerOrgPath; //��Ȩ����֯·��
		private String FOffice; //������λ
		private String FIdcard; //����֤��
		private Double FClassHours; //ѧʱ
		private Double FClassScores;//ѧ��
	
		private Int32 goodsState;//����Ʒ��״̬�������ݿ��޹أ�
	
		public TabShopOrderDetail() {
		}
	
		public String GetFOrderdetailId() {
			return FOrderdetailId;
		}
	
		public void SetFOrderdetailId(String fOrderdetailId) {
			FOrderdetailId = fOrderdetailId;
		}
	
		public String GetFOrderId() {
			return FOrderId;
		}
	
		public void SetFOrderId(String fOrderId) {
			FOrderId = fOrderId;
		}
	
		public String GetFGoodsId() {
			return FGoodsId;
		}
	
		public void SetFGoodsId(String fGoodsId) {
			FGoodsId = fGoodsId;
		}
	
		public String GetFGoodstypeId() {
			return FGoodstypeId;
		}
	
		public void SetFGoodstypeId(String fGoodstypeId) {
			FGoodstypeId = fGoodstypeId;
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
	
		public DateTime GetFOrderTime() {
			return FOrderTime;
		}
	
		public void SetFOrderTime(DateTime fOrderTime) {
			FOrderTime = fOrderTime;
		}
	
		public String GetFOrderNo() {
			return FOrderNo;
		}
	
		public void SetFOrderNo(String fOrderNo) {
			FOrderNo = fOrderNo;
		}
	
		public Double GetFOrderMoney() {
			return FOrderMoney;
		}
	
		public void SetFOrderMoney(Double fOrderMoney) {
			FOrderMoney = fOrderMoney;
		}
	
		public String GetFDealNo() {
			return FDealNo;
		}
	
		public void SetFDealNo(String fDealNo) {
			FDealNo = fDealNo;
		}
	
		public String GetFPlanId() {
			return FPlanId;
		}
	
		public void SetFPlanId(String fPlanId) {
			FPlanId = fPlanId;
		}
	
		public String GetFPlanNo() {
			return FPlanNo;
		}
	
		public void SetFPlanNo(String fPlanNo) {
			FPlanNo = fPlanNo;
		}
	
		public String GetFSupplierId() {
			return FSupplierId;
		}
	
		public void SetFSupplierId(String fSupplierId) {
			FSupplierId = fSupplierId;
		}
	
		public String GetFGoodsFilter() {
			return FGoodsFilter;
		}
	
		public void SetFGoodsFilter(String fGoodsFilter) {
			FGoodsFilter = fGoodsFilter;
		}
	
		public String GetFGoodslogoUrl() {
			return FGoodslogoUrl;
		}
	
		public void SetFGoodslogoUrl(String fGoodslogoUrl) {
			FGoodslogoUrl = fGoodslogoUrl;
		}
	
		public String GetFGoodsName() {
			return FGoodsName;
		}
	
		public void SetFGoodsName(String fGoodsName) {
			FGoodsName = fGoodsName;
		}
	
		public String GetFGoodsDesc() {
			return FGoodsDesc;
		}
	
		public void SetFGoodsDesc(String fGoodsDesc) {
			FGoodsDesc = fGoodsDesc;
		}
	
		public String GetFPaytypeId() {
			return FPaytypeId;
		}
	
		public void SetFPaytypeId(String fPaytypeId) {
			FPaytypeId = fPaytypeId;
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
	
		public Double GetFPayPrice() {
			return FPayPrice;
		}
	
		public void SetFPayPrice(Double fPayPrice) {
			FPayPrice = fPayPrice;
		}
	
		public Double GetFPayPoints() {
			return FPayPoints;
		}
	
		public void SetFPayPoints(Double fPayPoints) {
			FPayPoints = fPayPoints;
		}
	
		public Int32 GetFGoodsNums() {
			return FGoodsNums;
		}
	
		public void SetFGoodsNums(Int32 fGoodsNums) {
			FGoodsNums = fGoodsNums;
		}
	
		public Int32 GetFOrderStatus() {
			return FOrderStatus;
		}
	
		public void SetFOrderStatus(Int32 fOrderStatus) {
			FOrderStatus = fOrderStatus;
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
	
		public Int32 GetFPointsStatus() {
			return FPointsStatus;
		}
	
		public void SetFPointsStatus(Int32 fPointsStatus) {
			FPointsStatus = fPointsStatus;
		}
	
		public Double GetFCostPrice() {
			return FCostPrice;
		}
	
		public void SetFCostPrice(Double fCostPrice) {
			FCostPrice = fCostPrice;
		}
	
		public String GetFOrgPath() {
			return FOrgPath;
		}
	
		public void SetFOrgPath(String fOrgPath) {
			FOrgPath = fOrgPath;
		}
	
		public Int32 GetFOrderType() {
			return FOrderType;
		}
	
		public void SetFOrderType(Int32 fOrderType) {
			FOrderType = fOrderType;
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
	
		public Double GetFClassHours() {
			return FClassHours;
		}
	
		public void SetFClassHours(Double fClassHours) {
			FClassHours = fClassHours;
		}
	
		public Double GetFClassScores() {
			return FClassScores;
		}
	
		public void SetFClassScores(Double fClassScores) {
			FClassScores = fClassScores;
		}
	
		public Int32 GetGoodsState() {
			return goodsState;
		}
	
		public void SetGoodsState(Int32 goodsState_0) {
			this.goodsState = goodsState_0;
		}
	}
}