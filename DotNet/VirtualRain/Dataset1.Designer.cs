﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#pragma warning disable 1591

namespace VirtualRain {
    
    
    /// <summary>
    ///Represents a strongly typed in-memory cache of data.
    ///</summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [global::System.Serializable()]
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema")]
    [global::System.Xml.Serialization.XmlRootAttribute("RainDSClass")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")]
    public partial class RainDSClass : global::System.Data.DataSet {
        
        private V_MODEL_RAIN_FIVE_MINUTEDataTable tableV_MODEL_RAIN_FIVE_MINUTE;
        
        private global::System.Data.SchemaSerializationMode _schemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public RainDSClass() {
            this.BeginInit();
            this.InitClass();
            global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            base.Relations.CollectionChanged += schemaChangedHandler;
            this.EndInit();
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected RainDSClass(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                base(info, context, false) {
            if ((this.IsBinarySerialized(info, context) == true)) {
                this.InitVars(false);
                global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler1 = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
                this.Tables.CollectionChanged += schemaChangedHandler1;
                this.Relations.CollectionChanged += schemaChangedHandler1;
                return;
            }
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((this.DetermineSchemaSerializationMode(info, context) == global::System.Data.SchemaSerializationMode.IncludeSchema)) {
                global::System.Data.DataSet ds = new global::System.Data.DataSet();
                ds.ReadXmlSchema(new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(strSchema)));
                if ((ds.Tables["V_MODEL_RAIN_FIVE_MINUTE"] != null)) {
                    base.Tables.Add(new V_MODEL_RAIN_FIVE_MINUTEDataTable(ds.Tables["V_MODEL_RAIN_FIVE_MINUTE"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, global::System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.ReadXmlSchema(new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(strSchema)));
            }
            this.GetSerializationData(info, context);
            global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public V_MODEL_RAIN_FIVE_MINUTEDataTable V_MODEL_RAIN_FIVE_MINUTE {
            get {
                return this.tableV_MODEL_RAIN_FIVE_MINUTE;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.BrowsableAttribute(true)]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Visible)]
        public override global::System.Data.SchemaSerializationMode SchemaSerializationMode {
            get {
                return this._schemaSerializationMode;
            }
            set {
                this._schemaSerializationMode = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new global::System.Data.DataTableCollection Tables {
            get {
                return base.Tables;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new global::System.Data.DataRelationCollection Relations {
            get {
                return base.Relations;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override void InitializeDerivedDataSet() {
            this.BeginInit();
            this.InitClass();
            this.EndInit();
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public override global::System.Data.DataSet Clone() {
            RainDSClass cln = ((RainDSClass)(base.Clone()));
            cln.InitVars();
            cln.SchemaSerializationMode = this.SchemaSerializationMode;
            return cln;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override void ReadXmlSerializable(global::System.Xml.XmlReader reader) {
            if ((this.DetermineSchemaSerializationMode(reader) == global::System.Data.SchemaSerializationMode.IncludeSchema)) {
                this.Reset();
                global::System.Data.DataSet ds = new global::System.Data.DataSet();
                ds.ReadXml(reader);
                if ((ds.Tables["V_MODEL_RAIN_FIVE_MINUTE"] != null)) {
                    base.Tables.Add(new V_MODEL_RAIN_FIVE_MINUTEDataTable(ds.Tables["V_MODEL_RAIN_FIVE_MINUTE"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, global::System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.ReadXml(reader);
                this.InitVars();
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override global::System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            global::System.IO.MemoryStream stream = new global::System.IO.MemoryStream();
            this.WriteXmlSchema(new global::System.Xml.XmlTextWriter(stream, null));
            stream.Position = 0;
            return global::System.Xml.Schema.XmlSchema.Read(new global::System.Xml.XmlTextReader(stream), null);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        internal void InitVars() {
            this.InitVars(true);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        internal void InitVars(bool initTable) {
            this.tableV_MODEL_RAIN_FIVE_MINUTE = ((V_MODEL_RAIN_FIVE_MINUTEDataTable)(base.Tables["V_MODEL_RAIN_FIVE_MINUTE"]));
            if ((initTable == true)) {
                if ((this.tableV_MODEL_RAIN_FIVE_MINUTE != null)) {
                    this.tableV_MODEL_RAIN_FIVE_MINUTE.InitVars();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void InitClass() {
            this.DataSetName = "RainDSClass";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/Dataset1.xsd";
            this.EnforceConstraints = true;
            this.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
            this.tableV_MODEL_RAIN_FIVE_MINUTE = new V_MODEL_RAIN_FIVE_MINUTEDataTable();
            base.Tables.Add(this.tableV_MODEL_RAIN_FIVE_MINUTE);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private bool ShouldSerializeV_MODEL_RAIN_FIVE_MINUTE() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void SchemaChanged(object sender, global::System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == global::System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedDataSetSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
            RainDSClass ds = new RainDSClass();
            global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
            global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
            global::System.Xml.Schema.XmlSchemaAny any = new global::System.Xml.Schema.XmlSchemaAny();
            any.Namespace = ds.Namespace;
            sequence.Items.Add(any);
            type.Particle = sequence;
            global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
            if (xs.Contains(dsSchema.TargetNamespace)) {
                global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                try {
                    global::System.Xml.Schema.XmlSchema schema = null;
                    dsSchema.Write(s1);
                    for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                        schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                        s2.SetLength(0);
                        schema.Write(s2);
                        if ((s1.Length == s2.Length)) {
                            s1.Position = 0;
                            s2.Position = 0;
                            for (; ((s1.Position != s1.Length) 
                                        && (s1.ReadByte() == s2.ReadByte())); ) {
                                ;
                            }
                            if ((s1.Position == s1.Length)) {
                                return type;
                            }
                        }
                    }
                }
                finally {
                    if ((s1 != null)) {
                        s1.Close();
                    }
                    if ((s2 != null)) {
                        s2.Close();
                    }
                }
            }
            xs.Add(dsSchema);
            return type;
        }
        
        public delegate void V_MODEL_RAIN_FIVE_MINUTERowChangeEventHandler(object sender, V_MODEL_RAIN_FIVE_MINUTERowChangeEvent e);
        
        /// <summary>
        ///Represents the strongly named DataTable class.
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class V_MODEL_RAIN_FIVE_MINUTEDataTable : global::System.Data.TypedTableBase<V_MODEL_RAIN_FIVE_MINUTERow> {
            
            private global::System.Data.DataColumn columnh2_number;
            
            private global::System.Data.DataColumn columnfive_minute_date_time;
            
            private global::System.Data.DataColumn columnfive_minute_sum_inches;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public V_MODEL_RAIN_FIVE_MINUTEDataTable() {
                this.TableName = "V_MODEL_RAIN_FIVE_MINUTE";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal V_MODEL_RAIN_FIVE_MINUTEDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
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
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected V_MODEL_RAIN_FIVE_MINUTEDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public global::System.Data.DataColumn h2_numberColumn {
                get {
                    return this.columnh2_number;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public global::System.Data.DataColumn five_minute_date_timeColumn {
                get {
                    return this.columnfive_minute_date_time;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public global::System.Data.DataColumn five_minute_sum_inchesColumn {
                get {
                    return this.columnfive_minute_sum_inches;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public V_MODEL_RAIN_FIVE_MINUTERow this[int index] {
                get {
                    return ((V_MODEL_RAIN_FIVE_MINUTERow)(this.Rows[index]));
                }
            }
            
            public event V_MODEL_RAIN_FIVE_MINUTERowChangeEventHandler V_MODEL_RAIN_FIVE_MINUTERowChanging;
            
            public event V_MODEL_RAIN_FIVE_MINUTERowChangeEventHandler V_MODEL_RAIN_FIVE_MINUTERowChanged;
            
            public event V_MODEL_RAIN_FIVE_MINUTERowChangeEventHandler V_MODEL_RAIN_FIVE_MINUTERowDeleting;
            
            public event V_MODEL_RAIN_FIVE_MINUTERowChangeEventHandler V_MODEL_RAIN_FIVE_MINUTERowDeleted;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void AddV_MODEL_RAIN_FIVE_MINUTERow(V_MODEL_RAIN_FIVE_MINUTERow row) {
                this.Rows.Add(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public V_MODEL_RAIN_FIVE_MINUTERow AddV_MODEL_RAIN_FIVE_MINUTERow(int h2_number, System.DateTime five_minute_date_time, decimal five_minute_sum_inches) {
                V_MODEL_RAIN_FIVE_MINUTERow rowV_MODEL_RAIN_FIVE_MINUTERow = ((V_MODEL_RAIN_FIVE_MINUTERow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        h2_number,
                        five_minute_date_time,
                        five_minute_sum_inches};
                rowV_MODEL_RAIN_FIVE_MINUTERow.ItemArray = columnValuesArray;
                this.Rows.Add(rowV_MODEL_RAIN_FIVE_MINUTERow);
                return rowV_MODEL_RAIN_FIVE_MINUTERow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public override global::System.Data.DataTable Clone() {
                V_MODEL_RAIN_FIVE_MINUTEDataTable cln = ((V_MODEL_RAIN_FIVE_MINUTEDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override global::System.Data.DataTable CreateInstance() {
                return new V_MODEL_RAIN_FIVE_MINUTEDataTable();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal void InitVars() {
                this.columnh2_number = base.Columns["h2_number"];
                this.columnfive_minute_date_time = base.Columns["five_minute_date_time"];
                this.columnfive_minute_sum_inches = base.Columns["five_minute_sum_inches"];
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private void InitClass() {
                this.columnh2_number = new global::System.Data.DataColumn("h2_number", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnh2_number);
                this.columnfive_minute_date_time = new global::System.Data.DataColumn("five_minute_date_time", typeof(global::System.DateTime), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnfive_minute_date_time);
                this.columnfive_minute_sum_inches = new global::System.Data.DataColumn("five_minute_sum_inches", typeof(decimal), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnfive_minute_sum_inches);
                this.columnh2_number.AllowDBNull = false;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public V_MODEL_RAIN_FIVE_MINUTERow NewV_MODEL_RAIN_FIVE_MINUTERow() {
                return ((V_MODEL_RAIN_FIVE_MINUTERow)(this.NewRow()));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new V_MODEL_RAIN_FIVE_MINUTERow(builder);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override global::System.Type GetRowType() {
                return typeof(V_MODEL_RAIN_FIVE_MINUTERow);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.V_MODEL_RAIN_FIVE_MINUTERowChanged != null)) {
                    this.V_MODEL_RAIN_FIVE_MINUTERowChanged(this, new V_MODEL_RAIN_FIVE_MINUTERowChangeEvent(((V_MODEL_RAIN_FIVE_MINUTERow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.V_MODEL_RAIN_FIVE_MINUTERowChanging != null)) {
                    this.V_MODEL_RAIN_FIVE_MINUTERowChanging(this, new V_MODEL_RAIN_FIVE_MINUTERowChangeEvent(((V_MODEL_RAIN_FIVE_MINUTERow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.V_MODEL_RAIN_FIVE_MINUTERowDeleted != null)) {
                    this.V_MODEL_RAIN_FIVE_MINUTERowDeleted(this, new V_MODEL_RAIN_FIVE_MINUTERowChangeEvent(((V_MODEL_RAIN_FIVE_MINUTERow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.V_MODEL_RAIN_FIVE_MINUTERowDeleting != null)) {
                    this.V_MODEL_RAIN_FIVE_MINUTERowDeleting(this, new V_MODEL_RAIN_FIVE_MINUTERowChangeEvent(((V_MODEL_RAIN_FIVE_MINUTERow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void RemoveV_MODEL_RAIN_FIVE_MINUTERow(V_MODEL_RAIN_FIVE_MINUTERow row) {
                this.Rows.Remove(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                RainDSClass ds = new RainDSClass();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "V_MODEL_RAIN_FIVE_MINUTEDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
        public partial class V_MODEL_RAIN_FIVE_MINUTERow : global::System.Data.DataRow {
            
            private V_MODEL_RAIN_FIVE_MINUTEDataTable tableV_MODEL_RAIN_FIVE_MINUTE;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal V_MODEL_RAIN_FIVE_MINUTERow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableV_MODEL_RAIN_FIVE_MINUTE = ((V_MODEL_RAIN_FIVE_MINUTEDataTable)(this.Table));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public int h2_number {
                get {
                    return ((int)(this[this.tableV_MODEL_RAIN_FIVE_MINUTE.h2_numberColumn]));
                }
                set {
                    this[this.tableV_MODEL_RAIN_FIVE_MINUTE.h2_numberColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public System.DateTime five_minute_date_time {
                get {
                    try {
                        return ((global::System.DateTime)(this[this.tableV_MODEL_RAIN_FIVE_MINUTE.five_minute_date_timeColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'five_minute_date_time\' in table \'V_MODEL_RAIN_FIVE_MINUTE\' " +
                                "is DBNull.", e);
                    }
                }
                set {
                    this[this.tableV_MODEL_RAIN_FIVE_MINUTE.five_minute_date_timeColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public decimal five_minute_sum_inches {
                get {
                    try {
                        return ((decimal)(this[this.tableV_MODEL_RAIN_FIVE_MINUTE.five_minute_sum_inchesColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'five_minute_sum_inches\' in table \'V_MODEL_RAIN_FIVE_MINUTE\'" +
                                " is DBNull.", e);
                    }
                }
                set {
                    this[this.tableV_MODEL_RAIN_FIVE_MINUTE.five_minute_sum_inchesColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public bool Isfive_minute_date_timeNull() {
                return this.IsNull(this.tableV_MODEL_RAIN_FIVE_MINUTE.five_minute_date_timeColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void Setfive_minute_date_timeNull() {
                this[this.tableV_MODEL_RAIN_FIVE_MINUTE.five_minute_date_timeColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public bool Isfive_minute_sum_inchesNull() {
                return this.IsNull(this.tableV_MODEL_RAIN_FIVE_MINUTE.five_minute_sum_inchesColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void Setfive_minute_sum_inchesNull() {
                this[this.tableV_MODEL_RAIN_FIVE_MINUTE.five_minute_sum_inchesColumn] = global::System.Convert.DBNull;
            }
        }
        
        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
        public class V_MODEL_RAIN_FIVE_MINUTERowChangeEvent : global::System.EventArgs {
            
            private V_MODEL_RAIN_FIVE_MINUTERow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public V_MODEL_RAIN_FIVE_MINUTERowChangeEvent(V_MODEL_RAIN_FIVE_MINUTERow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public V_MODEL_RAIN_FIVE_MINUTERow Row {
                get {
                    return this.eventRow;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
}

#pragma warning restore 1591