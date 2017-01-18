﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.573
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 1.1.4322.573.
// 
namespace HowToWebServiceClient.localhost {
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Web.Services;
    using System.Data;
    using System.Xml;
    using System.Runtime.Serialization;
    
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="MainSoap", Namespace="http://msdn.microsoft.com/csharp/")]
    public class Main : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public Main() {
            this.Url = "http://localhost/HowToBuildWebServices/main.asmx";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://msdn.microsoft.com/csharp/About", RequestNamespace="http://msdn.microsoft.com/csharp/", ResponseNamespace="http://msdn.microsoft.com/csharp/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string About() {
            object[] results = this.Invoke("About", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginAbout(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("About", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public string EndAbout(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://msdn.microsoft.com/csharp/GetCustomerOrderHistory", RequestNamespace="http://msdn.microsoft.com/csharp/", ResponseNamespace="http://msdn.microsoft.com/csharp/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public CustomerAndOrderHistoryInfo GetCustomerOrderHistory(string strCustID) {
            object[] results = this.Invoke("GetCustomerOrderHistory", new object[] {
                        strCustID});
            return ((CustomerAndOrderHistoryInfo)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetCustomerOrderHistory(string strCustID, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetCustomerOrderHistory", new object[] {
                        strCustID}, callback, asyncState);
        }
        
        /// <remarks/>
        public CustomerAndOrderHistoryInfo EndGetCustomerOrderHistory(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((CustomerAndOrderHistoryInfo)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://msdn.microsoft.com/csharp/GetTenMostExpensiveProducts", RequestNamespace="http://msdn.microsoft.com/csharp/", ResponseNamespace="http://msdn.microsoft.com/csharp/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetTenMostExpensiveProducts() {
            object[] results = this.Invoke("GetTenMostExpensiveProducts", new object[0]);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetTenMostExpensiveProducts(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetTenMostExpensiveProducts", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public System.Data.DataSet EndGetTenMostExpensiveProducts(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataSet)(results[0]));
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://msdn.microsoft.com/csharp/")]
    public class CustomerAndOrderHistoryInfo {
        
        /// <remarks/>
        public dsCustOrderHist Orders;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Company;
    }
    
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.ToolboxItem(true)]
    public class dsCustOrderHist : DataSet {
        
        private CustOrderHistDataTable tableCustOrderHist;
        
        public dsCustOrderHist() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected dsCustOrderHist(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["CustOrderHist"] != null)) {
                    this.Tables.Add(new CustOrderHistDataTable(ds.Tables["CustOrderHist"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.InitClass();
            }
            this.GetSerializationData(info, context);
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public CustOrderHistDataTable CustOrderHist {
            get {
                return this.tableCustOrderHist;
            }
        }
        
        public override DataSet Clone() {
            dsCustOrderHist cln = ((dsCustOrderHist)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        protected override void ReadXmlSerializable(XmlReader reader) {
            this.Reset();
            DataSet ds = new DataSet();
            ds.ReadXml(reader);
            if ((ds.Tables["CustOrderHist"] != null)) {
                this.Tables.Add(new CustOrderHistDataTable(ds.Tables["CustOrderHist"]));
            }
            this.DataSetName = ds.DataSetName;
            this.Prefix = ds.Prefix;
            this.Namespace = ds.Namespace;
            this.Locale = ds.Locale;
            this.CaseSensitive = ds.CaseSensitive;
            this.EnforceConstraints = ds.EnforceConstraints;
            this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
            this.InitVars();
        }
        
        protected override System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            this.WriteXmlSchema(new XmlTextWriter(stream, null));
            stream.Position = 0;
            return System.Xml.Schema.XmlSchema.Read(new XmlTextReader(stream), null);
        }
        
        internal void InitVars() {
            this.tableCustOrderHist = ((CustOrderHistDataTable)(this.Tables["CustOrderHist"]));
            if ((this.tableCustOrderHist != null)) {
                this.tableCustOrderHist.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "dsCustOrderHist";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/dsCustOrderHist.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tableCustOrderHist = new CustOrderHistDataTable();
            this.Tables.Add(this.tableCustOrderHist);
        }
        
        private bool ShouldSerializeCustOrderHist() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void CustOrderHistRowChangeEventHandler(object sender, CustOrderHistRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class CustOrderHistDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnProductName;
            
            private DataColumn columnTotal;
            
            internal CustOrderHistDataTable() : 
                    base("CustOrderHist") {
                this.InitClass();
            }
            
            internal CustOrderHistDataTable(DataTable table) : 
                    base(table.TableName) {
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
                this.DisplayExpression = table.DisplayExpression;
            }
            
            [System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            internal DataColumn ProductNameColumn {
                get {
                    return this.columnProductName;
                }
            }
            
            internal DataColumn TotalColumn {
                get {
                    return this.columnTotal;
                }
            }
            
            public CustOrderHistRow this[int index] {
                get {
                    return ((CustOrderHistRow)(this.Rows[index]));
                }
            }
            
            public event CustOrderHistRowChangeEventHandler CustOrderHistRowChanged;
            
            public event CustOrderHistRowChangeEventHandler CustOrderHistRowChanging;
            
            public event CustOrderHistRowChangeEventHandler CustOrderHistRowDeleted;
            
            public event CustOrderHistRowChangeEventHandler CustOrderHistRowDeleting;
            
            public void AddCustOrderHistRow(CustOrderHistRow row) {
                this.Rows.Add(row);
            }
            
            public CustOrderHistRow AddCustOrderHistRow(string ProductName, int Total) {
                CustOrderHistRow rowCustOrderHistRow = ((CustOrderHistRow)(this.NewRow()));
                rowCustOrderHistRow.ItemArray = new object[] {
                        ProductName,
                        Total};
                this.Rows.Add(rowCustOrderHistRow);
                return rowCustOrderHistRow;
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                CustOrderHistDataTable cln = ((CustOrderHistDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new CustOrderHistDataTable();
            }
            
            internal void InitVars() {
                this.columnProductName = this.Columns["ProductName"];
                this.columnTotal = this.Columns["Total"];
            }
            
            private void InitClass() {
                this.columnProductName = new DataColumn("ProductName", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnProductName);
                this.columnTotal = new DataColumn("Total", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnTotal);
                this.columnProductName.AllowDBNull = false;
                this.columnTotal.ReadOnly = true;
            }
            
            public CustOrderHistRow NewCustOrderHistRow() {
                return ((CustOrderHistRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new CustOrderHistRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(CustOrderHistRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.CustOrderHistRowChanged != null)) {
                    this.CustOrderHistRowChanged(this, new CustOrderHistRowChangeEvent(((CustOrderHistRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.CustOrderHistRowChanging != null)) {
                    this.CustOrderHistRowChanging(this, new CustOrderHistRowChangeEvent(((CustOrderHistRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.CustOrderHistRowDeleted != null)) {
                    this.CustOrderHistRowDeleted(this, new CustOrderHistRowChangeEvent(((CustOrderHistRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.CustOrderHistRowDeleting != null)) {
                    this.CustOrderHistRowDeleting(this, new CustOrderHistRowChangeEvent(((CustOrderHistRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveCustOrderHistRow(CustOrderHistRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class CustOrderHistRow : DataRow {
            
            private CustOrderHistDataTable tableCustOrderHist;
            
            internal CustOrderHistRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableCustOrderHist = ((CustOrderHistDataTable)(this.Table));
            }
            
            public string ProductName {
                get {
                    return ((string)(this[this.tableCustOrderHist.ProductNameColumn]));
                }
                set {
                    this[this.tableCustOrderHist.ProductNameColumn] = value;
                }
            }
            
            public int Total {
                get {
                    try {
                        return ((int)(this[this.tableCustOrderHist.TotalColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableCustOrderHist.TotalColumn] = value;
                }
            }
            
            public bool IsTotalNull() {
                return this.IsNull(this.tableCustOrderHist.TotalColumn);
            }
            
            public void SetTotalNull() {
                this[this.tableCustOrderHist.TotalColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class CustOrderHistRowChangeEvent : EventArgs {
            
            private CustOrderHistRow eventRow;
            
            private DataRowAction eventAction;
            
            public CustOrderHistRowChangeEvent(CustOrderHistRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public CustOrderHistRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            public DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
}
