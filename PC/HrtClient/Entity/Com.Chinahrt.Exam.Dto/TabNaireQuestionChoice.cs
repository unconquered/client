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
	
	/* @SuppressWarnings("serial")*/
	[Serializable]
	public class TabNaireQuestionChoice {
	
		private String FChoiceId; //����ѡ����
		private String FQuestionId; //������
		private String FSortCode; //����ţ����磺A��B��C��D
		private String FChoiceInfo; //ѡ������
	
		public TabNaireQuestionChoice() : base() {
		}
	
		public TabNaireQuestionChoice(String fChoiceId, String fQuestionId,
				String fSortCode, String fChoiceInfo) : base() {
			FChoiceId = fChoiceId;
			FQuestionId = fQuestionId;
			FSortCode = fSortCode;
			FChoiceInfo = fChoiceInfo;
		}
	
		public String GetFChoiceId() {
			return FChoiceId;
		}
	
		public void SetFChoiceId(String fChoiceId) {
			FChoiceId = fChoiceId;
		}
	
		public String GetFQuestionId() {
			return FQuestionId;
		}
	
		public void SetFQuestionId(String fQuestionId) {
			FQuestionId = fQuestionId;
		}
	
		public String GetFSortCode() {
			return FSortCode;
		}
	
		public void SetFSortCode(String fSortCode) {
			FSortCode = fSortCode;
		}
	
		public String GetFChoiceInfo() {
			return FChoiceInfo;
		}
	
		public void SetFChoiceInfo(String fChoiceInfo) {
			FChoiceInfo = fChoiceInfo;
		}
	
	}
}