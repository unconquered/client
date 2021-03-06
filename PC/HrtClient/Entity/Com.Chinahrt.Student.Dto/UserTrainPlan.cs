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
    using System.Collections.Generic;
	
	[Serializable]
	/* @SuppressWarnings("serial")*/
	public class UserTrainPlan {
	
		private IList<TabPlanPlanuserInfo> planuserInfoList;
		private IList<TabUcenterArchivesInfo> archivesInfoList;
	
		public UserTrainPlan() {
		}
	
		public UserTrainPlan(IList<TabPlanPlanuserInfo> planuserInfoList_0,
				IList<TabUcenterArchivesInfo> archivesInfoList_1) {
			this.planuserInfoList = planuserInfoList_0;
			this.archivesInfoList = archivesInfoList_1;
		}
	
		public IList<TabPlanPlanuserInfo> GetPlanuserInfoList() {
			return planuserInfoList;
		}
	
		public void SetPlanuserInfoList(IList<TabPlanPlanuserInfo> planuserInfoList_0) {
			this.planuserInfoList = planuserInfoList_0;
		}
	
		public IList<TabUcenterArchivesInfo> GetArchivesInfoList() {
			return archivesInfoList;
		}
	
		public void SetArchivesInfoList(
				IList<TabUcenterArchivesInfo> archivesInfoList_0) {
			this.archivesInfoList = archivesInfoList_0;
		}
	}
}
