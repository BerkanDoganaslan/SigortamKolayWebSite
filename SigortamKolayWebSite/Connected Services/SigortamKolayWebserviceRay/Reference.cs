﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SigortamKolayWebSite.SigortamKolayWebserviceRay {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://SigortamKolay.com/", ConfigurationName="SigortamKolayWebserviceRay.GetPolicyProposalSoap")]
    public interface GetPolicyProposalSoap {
        
        // CODEGEN: Generating message contract since message GetProposalRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action="http://SigortamKolay.com/GetProposal", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SigortamKolayWebSite.SigortamKolayWebserviceRay.GetProposalResponse GetProposal(SigortamKolayWebSite.SigortamKolayWebserviceRay.GetProposalRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://SigortamKolay.com/GetProposal", ReplyAction="*")]
        System.Threading.Tasks.Task<SigortamKolayWebSite.SigortamKolayWebserviceRay.GetProposalResponse> GetProposalAsync(SigortamKolayWebSite.SigortamKolayWebserviceRay.GetProposalRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://SigortamKolay.com/GetCitiesAndTowns", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SigortamKolayWebSite.SigortamKolayWebserviceRay.cityAndTown[] GetCitiesAndTowns();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://SigortamKolay.com/GetCitiesAndTowns", ReplyAction="*")]
        System.Threading.Tasks.Task<SigortamKolayWebSite.SigortamKolayWebserviceRay.cityAndTown[]> GetCitiesAndTownsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://SigortamKolay.com/GetBrandsAndModels", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SigortamKolayWebSite.SigortamKolayWebserviceRay.brandAndModel[] GetBrandsAndModels();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://SigortamKolay.com/GetBrandsAndModels", ReplyAction="*")]
        System.Threading.Tasks.Task<SigortamKolayWebSite.SigortamKolayWebserviceRay.brandAndModel[]> GetBrandsAndModelsAsync();
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://SigortamKolay.com/")]
    public partial class AuthHeader : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string usernameField;
        
        private string passwordField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Username {
            get {
                return this.usernameField;
            }
            set {
                this.usernameField = value;
                this.RaisePropertyChanged("Username");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
                this.RaisePropertyChanged("Password");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
                this.RaisePropertyChanged("AnyAttr");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://SigortamKolay.com/")]
    public partial class models : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int modelCodeField;
        
        private string modelNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int modelCode {
            get {
                return this.modelCodeField;
            }
            set {
                this.modelCodeField = value;
                this.RaisePropertyChanged("modelCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string modelName {
            get {
                return this.modelNameField;
            }
            set {
                this.modelNameField = value;
                this.RaisePropertyChanged("modelName");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://SigortamKolay.com/")]
    public partial class brandAndModel : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int brandCodeField;
        
        private string brandNameField;
        
        private models[] modelsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int brandCode {
            get {
                return this.brandCodeField;
            }
            set {
                this.brandCodeField = value;
                this.RaisePropertyChanged("brandCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string brandName {
            get {
                return this.brandNameField;
            }
            set {
                this.brandNameField = value;
                this.RaisePropertyChanged("brandName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=2)]
        public models[] models {
            get {
                return this.modelsField;
            }
            set {
                this.modelsField = value;
                this.RaisePropertyChanged("models");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://SigortamKolay.com/")]
    public partial class towns : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int townCodeField;
        
        private string townNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int townCode {
            get {
                return this.townCodeField;
            }
            set {
                this.townCodeField = value;
                this.RaisePropertyChanged("townCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string townName {
            get {
                return this.townNameField;
            }
            set {
                this.townNameField = value;
                this.RaisePropertyChanged("townName");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://SigortamKolay.com/")]
    public partial class cityAndTown : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int cityCodeField;
        
        private string cityNameField;
        
        private towns[] townsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int cityCode {
            get {
                return this.cityCodeField;
            }
            set {
                this.cityCodeField = value;
                this.RaisePropertyChanged("cityCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string cityName {
            get {
                return this.cityNameField;
            }
            set {
                this.cityNameField = value;
                this.RaisePropertyChanged("cityName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=2)]
        public towns[] towns {
            get {
                return this.townsField;
            }
            set {
                this.townsField = value;
                this.RaisePropertyChanged("towns");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://SigortamKolay.com/")]
    public partial class outputList : object, System.ComponentModel.INotifyPropertyChanged {
        
        private long policyNumberField;
        
        private int coverCodeField;
        
        private string coverNameField;
        
        private double coverAmountField;
        
        private double premiumAmountField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public long policyNumber {
            get {
                return this.policyNumberField;
            }
            set {
                this.policyNumberField = value;
                this.RaisePropertyChanged("policyNumber");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int coverCode {
            get {
                return this.coverCodeField;
            }
            set {
                this.coverCodeField = value;
                this.RaisePropertyChanged("coverCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string coverName {
            get {
                return this.coverNameField;
            }
            set {
                this.coverNameField = value;
                this.RaisePropertyChanged("coverName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public double coverAmount {
            get {
                return this.coverAmountField;
            }
            set {
                this.coverAmountField = value;
                this.RaisePropertyChanged("coverAmount");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public double premiumAmount {
            get {
                return this.premiumAmountField;
            }
            set {
                this.premiumAmountField = value;
                this.RaisePropertyChanged("premiumAmount");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://SigortamKolay.com/")]
    public partial class output : object, System.ComponentModel.INotifyPropertyChanged {
        
        private outputList[] outListField;
        
        private string clauseField;
        
        private double totalPremiumAmountField;
        
        private long policyNumberField;
        
        private string productNoField;
        
        private string productNameField;
        
        private string policyBeginDateField;
        
        private string policyEndDateField;
        
        private string insurancefirmNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
        public outputList[] outList {
            get {
                return this.outListField;
            }
            set {
                this.outListField = value;
                this.RaisePropertyChanged("outList");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string clause {
            get {
                return this.clauseField;
            }
            set {
                this.clauseField = value;
                this.RaisePropertyChanged("clause");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public double totalPremiumAmount {
            get {
                return this.totalPremiumAmountField;
            }
            set {
                this.totalPremiumAmountField = value;
                this.RaisePropertyChanged("totalPremiumAmount");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public long policyNumber {
            get {
                return this.policyNumberField;
            }
            set {
                this.policyNumberField = value;
                this.RaisePropertyChanged("policyNumber");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string productNo {
            get {
                return this.productNoField;
            }
            set {
                this.productNoField = value;
                this.RaisePropertyChanged("productNo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string productName {
            get {
                return this.productNameField;
            }
            set {
                this.productNameField = value;
                this.RaisePropertyChanged("productName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string policyBeginDate {
            get {
                return this.policyBeginDateField;
            }
            set {
                this.policyBeginDateField = value;
                this.RaisePropertyChanged("policyBeginDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string policyEndDate {
            get {
                return this.policyEndDateField;
            }
            set {
                this.policyEndDateField = value;
                this.RaisePropertyChanged("policyEndDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string insurancefirmName {
            get {
                return this.insurancefirmNameField;
            }
            set {
                this.insurancefirmNameField = value;
                this.RaisePropertyChanged("insurancefirmName");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://SigortamKolay.com/")]
    public partial class input : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string nameField;
        
        private string surNameField;
        
        private string firmNameField;
        
        private int identityTypeField;
        
        private string identityNoField;
        
        private int ageField;
        
        private int educationStatusField;
        
        private int cityCodeField;
        
        private int townCodeField;
        
        private string districtNameField;
        
        private string villageNameField;
        
        private string streetNameField;
        
        private int buildingNoField;
        
        private int floorNoField;
        
        private int apartmentNoField;
        
        private int plateCityCodeField;
        
        private string plateNoField;
        
        private int brandCodeField;
        
        private int modelCodeField;
        
        private int modelYearField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("name");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string surName {
            get {
                return this.surNameField;
            }
            set {
                this.surNameField = value;
                this.RaisePropertyChanged("surName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string firmName {
            get {
                return this.firmNameField;
            }
            set {
                this.firmNameField = value;
                this.RaisePropertyChanged("firmName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public int identityType {
            get {
                return this.identityTypeField;
            }
            set {
                this.identityTypeField = value;
                this.RaisePropertyChanged("identityType");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string identityNo {
            get {
                return this.identityNoField;
            }
            set {
                this.identityNoField = value;
                this.RaisePropertyChanged("identityNo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public int age {
            get {
                return this.ageField;
            }
            set {
                this.ageField = value;
                this.RaisePropertyChanged("age");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public int educationStatus {
            get {
                return this.educationStatusField;
            }
            set {
                this.educationStatusField = value;
                this.RaisePropertyChanged("educationStatus");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public int cityCode {
            get {
                return this.cityCodeField;
            }
            set {
                this.cityCodeField = value;
                this.RaisePropertyChanged("cityCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public int townCode {
            get {
                return this.townCodeField;
            }
            set {
                this.townCodeField = value;
                this.RaisePropertyChanged("townCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public string districtName {
            get {
                return this.districtNameField;
            }
            set {
                this.districtNameField = value;
                this.RaisePropertyChanged("districtName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public string villageName {
            get {
                return this.villageNameField;
            }
            set {
                this.villageNameField = value;
                this.RaisePropertyChanged("villageName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public string streetName {
            get {
                return this.streetNameField;
            }
            set {
                this.streetNameField = value;
                this.RaisePropertyChanged("streetName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public int buildingNo {
            get {
                return this.buildingNoField;
            }
            set {
                this.buildingNoField = value;
                this.RaisePropertyChanged("buildingNo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public int floorNo {
            get {
                return this.floorNoField;
            }
            set {
                this.floorNoField = value;
                this.RaisePropertyChanged("floorNo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
        public int apartmentNo {
            get {
                return this.apartmentNoField;
            }
            set {
                this.apartmentNoField = value;
                this.RaisePropertyChanged("apartmentNo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=15)]
        public int plateCityCode {
            get {
                return this.plateCityCodeField;
            }
            set {
                this.plateCityCodeField = value;
                this.RaisePropertyChanged("plateCityCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=16)]
        public string plateNo {
            get {
                return this.plateNoField;
            }
            set {
                this.plateNoField = value;
                this.RaisePropertyChanged("plateNo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=17)]
        public int brandCode {
            get {
                return this.brandCodeField;
            }
            set {
                this.brandCodeField = value;
                this.RaisePropertyChanged("brandCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=18)]
        public int modelCode {
            get {
                return this.modelCodeField;
            }
            set {
                this.modelCodeField = value;
                this.RaisePropertyChanged("modelCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=19)]
        public int modelYear {
            get {
                return this.modelYearField;
            }
            set {
                this.modelYearField = value;
                this.RaisePropertyChanged("modelYear");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetProposal", WrapperNamespace="http://SigortamKolay.com/", IsWrapped=true)]
    public partial class GetProposalRequest {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://SigortamKolay.com/")]
        public SigortamKolayWebSite.SigortamKolayWebserviceRay.AuthHeader AuthHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://SigortamKolay.com/", Order=0)]
        public SigortamKolayWebSite.SigortamKolayWebserviceRay.input value;
        
        public GetProposalRequest() {
        }
        
        public GetProposalRequest(SigortamKolayWebSite.SigortamKolayWebserviceRay.AuthHeader AuthHeader, SigortamKolayWebSite.SigortamKolayWebserviceRay.input value) {
            this.AuthHeader = AuthHeader;
            this.value = value;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetProposalResponse", WrapperNamespace="http://SigortamKolay.com/", IsWrapped=true)]
    public partial class GetProposalResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://SigortamKolay.com/", Order=0)]
        public SigortamKolayWebSite.SigortamKolayWebserviceRay.output GetProposalResult;
        
        public GetProposalResponse() {
        }
        
        public GetProposalResponse(SigortamKolayWebSite.SigortamKolayWebserviceRay.output GetProposalResult) {
            this.GetProposalResult = GetProposalResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface GetPolicyProposalSoapChannel : SigortamKolayWebSite.SigortamKolayWebserviceRay.GetPolicyProposalSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetPolicyProposalSoapClient : System.ServiceModel.ClientBase<SigortamKolayWebSite.SigortamKolayWebserviceRay.GetPolicyProposalSoap>, SigortamKolayWebSite.SigortamKolayWebserviceRay.GetPolicyProposalSoap {
        
        public GetPolicyProposalSoapClient() {
        }
        
        public GetPolicyProposalSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GetPolicyProposalSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GetPolicyProposalSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GetPolicyProposalSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SigortamKolayWebSite.SigortamKolayWebserviceRay.GetProposalResponse SigortamKolayWebSite.SigortamKolayWebserviceRay.GetPolicyProposalSoap.GetProposal(SigortamKolayWebSite.SigortamKolayWebserviceRay.GetProposalRequest request) {
            return base.Channel.GetProposal(request);
        }
        
        public SigortamKolayWebSite.SigortamKolayWebserviceRay.output GetProposal(SigortamKolayWebSite.SigortamKolayWebserviceRay.AuthHeader AuthHeader, SigortamKolayWebSite.SigortamKolayWebserviceRay.input value) {
            SigortamKolayWebSite.SigortamKolayWebserviceRay.GetProposalRequest inValue = new SigortamKolayWebSite.SigortamKolayWebserviceRay.GetProposalRequest();
            inValue.AuthHeader = AuthHeader;
            inValue.value = value;
            SigortamKolayWebSite.SigortamKolayWebserviceRay.GetProposalResponse retVal = ((SigortamKolayWebSite.SigortamKolayWebserviceRay.GetPolicyProposalSoap)(this)).GetProposal(inValue);
            return retVal.GetProposalResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SigortamKolayWebSite.SigortamKolayWebserviceRay.GetProposalResponse> SigortamKolayWebSite.SigortamKolayWebserviceRay.GetPolicyProposalSoap.GetProposalAsync(SigortamKolayWebSite.SigortamKolayWebserviceRay.GetProposalRequest request) {
            return base.Channel.GetProposalAsync(request);
        }
        
        public System.Threading.Tasks.Task<SigortamKolayWebSite.SigortamKolayWebserviceRay.GetProposalResponse> GetProposalAsync(SigortamKolayWebSite.SigortamKolayWebserviceRay.AuthHeader AuthHeader, SigortamKolayWebSite.SigortamKolayWebserviceRay.input value) {
            SigortamKolayWebSite.SigortamKolayWebserviceRay.GetProposalRequest inValue = new SigortamKolayWebSite.SigortamKolayWebserviceRay.GetProposalRequest();
            inValue.AuthHeader = AuthHeader;
            inValue.value = value;
            return ((SigortamKolayWebSite.SigortamKolayWebserviceRay.GetPolicyProposalSoap)(this)).GetProposalAsync(inValue);
        }
        
        public SigortamKolayWebSite.SigortamKolayWebserviceRay.cityAndTown[] GetCitiesAndTowns() {
            return base.Channel.GetCitiesAndTowns();
        }
        
        public System.Threading.Tasks.Task<SigortamKolayWebSite.SigortamKolayWebserviceRay.cityAndTown[]> GetCitiesAndTownsAsync() {
            return base.Channel.GetCitiesAndTownsAsync();
        }
        
        public SigortamKolayWebSite.SigortamKolayWebserviceRay.brandAndModel[] GetBrandsAndModels() {
            return base.Channel.GetBrandsAndModels();
        }
        
        public System.Threading.Tasks.Task<SigortamKolayWebSite.SigortamKolayWebserviceRay.brandAndModel[]> GetBrandsAndModelsAsync() {
            return base.Channel.GetBrandsAndModelsAsync();
        }
    }
}
