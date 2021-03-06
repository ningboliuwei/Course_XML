﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18408
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码是由 Microsoft.VSDesigner 4.0.30319.18408 版自动生成。
// 
#pragma warning disable 1591

namespace WebService的使用_实验_四则运算.CaculationService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="CaculationSoap", Namespace="http://tempuri.org/")]
    public partial class Caculation : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetAnswerOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetQuestionOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Caculation() {
            this.Url = global::WebService的使用_实验_四则运算.Properties.Settings.Default.WebService的使用_实验_四则运算_CaculationService_Caculation;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetAnswerCompletedEventHandler GetAnswerCompleted;
        
        /// <remarks/>
        public event GetQuestionCompletedEventHandler GetQuestionCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAnswer", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Answer GetAnswer(Question question, int userAnswer) {
            object[] results = this.Invoke("GetAnswer", new object[] {
                        question,
                        userAnswer});
            return ((Answer)(results[0]));
        }
        
        /// <remarks/>
        public void GetAnswerAsync(Question question, int userAnswer) {
            this.GetAnswerAsync(question, userAnswer, null);
        }
        
        /// <remarks/>
        public void GetAnswerAsync(Question question, int userAnswer, object userState) {
            if ((this.GetAnswerOperationCompleted == null)) {
                this.GetAnswerOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAnswerOperationCompleted);
            }
            this.InvokeAsync("GetAnswer", new object[] {
                        question,
                        userAnswer}, this.GetAnswerOperationCompleted, userState);
        }
        
        private void OnGetAnswerOperationCompleted(object arg) {
            if ((this.GetAnswerCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAnswerCompleted(this, new GetAnswerCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetQuestion", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Question GetQuestion() {
            object[] results = this.Invoke("GetQuestion", new object[0]);
            return ((Question)(results[0]));
        }
        
        /// <remarks/>
        public void GetQuestionAsync() {
            this.GetQuestionAsync(null);
        }
        
        /// <remarks/>
        public void GetQuestionAsync(object userState) {
            if ((this.GetQuestionOperationCompleted == null)) {
                this.GetQuestionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetQuestionOperationCompleted);
            }
            this.InvokeAsync("GetQuestion", new object[0], this.GetQuestionOperationCompleted, userState);
        }
        
        private void OnGetQuestionOperationCompleted(object arg) {
            if ((this.GetQuestionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetQuestionCompleted(this, new GetQuestionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Question {
        
        private int operand1Field;
        
        private int operand2Field;
        
        private string operatorStringField;
        
        /// <remarks/>
        public int Operand1 {
            get {
                return this.operand1Field;
            }
            set {
                this.operand1Field = value;
            }
        }
        
        /// <remarks/>
        public int Operand2 {
            get {
                return this.operand2Field;
            }
            set {
                this.operand2Field = value;
            }
        }
        
        /// <remarks/>
        public string OperatorString {
            get {
                return this.operatorStringField;
            }
            set {
                this.operatorStringField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Answer {
        
        private string questionStringField;
        
        private int rightResultField;
        
        private int userAnswerField;
        
        private string statusField;
        
        /// <remarks/>
        public string QuestionString {
            get {
                return this.questionStringField;
            }
            set {
                this.questionStringField = value;
            }
        }
        
        /// <remarks/>
        public int RightResult {
            get {
                return this.rightResultField;
            }
            set {
                this.rightResultField = value;
            }
        }
        
        /// <remarks/>
        public int UserAnswer {
            get {
                return this.userAnswerField;
            }
            set {
                this.userAnswerField = value;
            }
        }
        
        /// <remarks/>
        public string Status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void GetAnswerCompletedEventHandler(object sender, GetAnswerCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAnswerCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAnswerCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Answer Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Answer)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void GetQuestionCompletedEventHandler(object sender, GetQuestionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetQuestionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetQuestionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Question Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Question)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591