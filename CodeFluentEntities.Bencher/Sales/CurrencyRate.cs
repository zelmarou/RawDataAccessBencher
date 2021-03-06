﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CodeFluentEntities.Bencher.Sales
{
    using CodeFluent.Runtime;
    using CodeFluent.Runtime.Utilities;
    
    
    // CodeFluent Entities generated (http://www.softfluent.com). Date: Tuesday, 18 March 2014 16:33.
    // Build:1.0.61214.0764
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CodeFluent Entities", "1.0.61214.0764")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DataObjectAttribute()]
    [System.Diagnostics.DebuggerDisplayAttribute("EK={EntityKey}, CurrencyRateID={CurrencyRateID}")]
    [System.ComponentModel.TypeConverterAttribute(typeof(CodeFluent.Runtime.Design.NameTypeConverter))]
    public partial class CurrencyRate : System.ICloneable, System.IComparable, System.IComparable<CodeFluentEntities.Bencher.Sales.CurrencyRate>, CodeFluent.Runtime.ICodeFluentEntity, System.ComponentModel.IDataErrorInfo, CodeFluent.Runtime.ICodeFluentMemberValidator, CodeFluent.Runtime.ICodeFluentSummaryValidator, System.IEquatable<CodeFluentEntities.Bencher.Sales.CurrencyRate>
    {
        
        private bool _raisePropertyChangedEvents = true;
        
        private CodeFluent.Runtime.CodeFluentEntityState _entityState;
        
        private int _currencyRateID = -1;
        
        private System.DateTime _currencyRateDate = CodeFluentPersistence.DefaultDateTimeValue;
        
        private decimal _averageRate = CodeFluentPersistence.DefaultDecimalValue;
        
        private decimal _endOfDayRate = CodeFluentPersistence.DefaultDecimalValue;
        
        private System.DateTime _modifiedDate = CodeFluentPersistence.DefaultDateTimeValue;
        
        private string _fromCurrencyCodeCurrencyCode = default(string);
        
        [System.NonSerializedAttribute()]
        private CodeFluentEntities.Bencher.Sales.Currency _fromCurrencyCode = null;
        
        private string _toCurrencyCodeCurrencyCode = default(string);
        
        [System.NonSerializedAttribute()]
        private CodeFluentEntities.Bencher.Sales.Currency _toCurrencyCode = null;
        
        [System.NonSerializedAttribute()]
        private CodeFluentEntities.Bencher.Sales.SalesOrderHeaderCollection _salesOrderHeaders;
        
        public CurrencyRate()
        {
            this._entityState = CodeFluent.Runtime.CodeFluentEntityState.Created;
        }
        
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool RaisePropertyChangedEvents
        {
            get
            {
                return this._raisePropertyChangedEvents;
            }
            set
            {
                this._raisePropertyChangedEvents = value;
            }
        }
        
        public virtual string EntityKey
        {
            get
            {
                return this.CurrencyRateID.ToString();
            }
            set
            {
                this.CurrencyRateID = ((int)(ConvertUtilities.ChangeType(value, typeof(int), -1)));
            }
        }
        
        public virtual string EntityDisplayName
        {
            get
            {
                return this.CurrencyRateID.ToString();
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(((int)(-1)))]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false, Type=typeof(int))]
        [System.ComponentModel.DataObjectFieldAttribute(true)]
        public int CurrencyRateID
        {
            get
            {
                return this._currencyRateID;
            }
            set
            {
                this._currencyRateID = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("CurrencyRateID"));
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false, Type=typeof(System.DateTime))]
        public System.DateTime CurrencyRateDate
        {
            get
            {
                return this._currencyRateDate;
            }
            set
            {
                this._currencyRateDate = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("CurrencyRateDate"));
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false, Type=typeof(decimal))]
        public decimal AverageRate
        {
            get
            {
                return this._averageRate;
            }
            set
            {
                this._averageRate = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("AverageRate"));
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false, Type=typeof(decimal))]
        public decimal EndOfDayRate
        {
            get
            {
                return this._endOfDayRate;
            }
            set
            {
                this._endOfDayRate = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("EndOfDayRate"));
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false, Type=typeof(System.DateTime))]
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._modifiedDate;
            }
            set
            {
                this._modifiedDate = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("ModifiedDate"));
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        [System.ComponentModel.DataObjectFieldAttribute(true)]
        public string FromCurrencyCodeCurrencyCode
        {
            get
            {
                if (((this._fromCurrencyCodeCurrencyCode == default(string)) 
                            && (this._fromCurrencyCode != null)))
                {
                    this._fromCurrencyCodeCurrencyCode = this._fromCurrencyCode.CurrencyCode;
                }
                return this._fromCurrencyCodeCurrencyCode;
            }
            set
            {
                if ((System.Collections.Generic.EqualityComparer<string>.Default.Equals(value, this.FromCurrencyCodeCurrencyCode) == true))
                {
                    return;
                }
                this._fromCurrencyCode = null;
                this._fromCurrencyCodeCurrencyCode = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("FromCurrencyCode"));
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("FromCurrencyCodeCurrencyCode"));
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public CodeFluentEntities.Bencher.Sales.Currency FromCurrencyCode
        {
            get
            {
                if ((this._fromCurrencyCode == null))
                {
                    this._fromCurrencyCode = CodeFluentEntities.Bencher.Sales.Currency.Load(this._fromCurrencyCodeCurrencyCode);
                }
                return this._fromCurrencyCode;
            }
            set
            {
                this._fromCurrencyCodeCurrencyCode = default(string);
                this._fromCurrencyCode = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("FromCurrencyCode"));
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("FromCurrencyCodeCurrencyCode"));
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        [System.ComponentModel.DataObjectFieldAttribute(true)]
        public string ToCurrencyCodeCurrencyCode
        {
            get
            {
                if (((this._toCurrencyCodeCurrencyCode == default(string)) 
                            && (this._toCurrencyCode != null)))
                {
                    this._toCurrencyCodeCurrencyCode = this._toCurrencyCode.CurrencyCode;
                }
                return this._toCurrencyCodeCurrencyCode;
            }
            set
            {
                if ((System.Collections.Generic.EqualityComparer<string>.Default.Equals(value, this.ToCurrencyCodeCurrencyCode) == true))
                {
                    return;
                }
                this._toCurrencyCode = null;
                this._toCurrencyCodeCurrencyCode = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("ToCurrencyCode"));
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("ToCurrencyCodeCurrencyCode"));
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public CodeFluentEntities.Bencher.Sales.Currency ToCurrencyCode
        {
            get
            {
                if ((this._toCurrencyCode == null))
                {
                    this._toCurrencyCode = CodeFluentEntities.Bencher.Sales.Currency.Load(this._toCurrencyCodeCurrencyCode);
                }
                return this._toCurrencyCode;
            }
            set
            {
                this._toCurrencyCodeCurrencyCode = default(string);
                this._toCurrencyCode = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("ToCurrencyCode"));
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("ToCurrencyCodeCurrencyCode"));
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public CodeFluentEntities.Bencher.Sales.SalesOrderHeaderCollection SalesOrderHeaders
        {
            get
            {
                if ((this._salesOrderHeaders == null))
                {
                    if (((this.CurrencyRateID == -1) 
                                || (this.EntityState.Equals(CodeFluent.Runtime.CodeFluentEntityState.Created) == true)))
                    {
                        this._salesOrderHeaders = new CodeFluentEntities.Bencher.Sales.SalesOrderHeaderCollection(null, null, null, null, this);
                        return this._salesOrderHeaders;
                    }
                    this._salesOrderHeaders = CodeFluentEntities.Bencher.Sales.SalesOrderHeaderCollection.LoadByCurrencyRate(this);
                }
                return this._salesOrderHeaders;
            }
        }
        
        string System.ComponentModel.IDataErrorInfo.Error
        {
            get
            {
                return this.Validate(System.Globalization.CultureInfo.CurrentCulture);
            }
        }
        
        string System.ComponentModel.IDataErrorInfo.this[string columnName]
        {
            get
            {
                return CodeFluentPersistence.ValidateMember(System.Globalization.CultureInfo.CurrentCulture, this, columnName, null);
            }
        }
        
        public virtual CodeFluent.Runtime.CodeFluentEntityState EntityState
        {
            get
            {
                return this._entityState;
            }
            set
            {
                if ((System.Collections.Generic.EqualityComparer<CodeFluent.Runtime.CodeFluentEntityState>.Default.Equals(value, this.EntityState) == true))
                {
                    return;
                }
                this._entityState = value;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("EntityState"));
            }
        }
        
        [field:System.NonSerializedAttribute()]
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        [field:System.NonSerializedAttribute()]
        public event CodeFluent.Runtime.CodeFluentEntityActionEventHandler EntityAction;
        
        protected virtual void OnPropertyChanged(System.ComponentModel.PropertyChangedEventArgs e)
        {
            if ((this.RaisePropertyChangedEvents == false))
            {
                return;
            }
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, e);
            }
        }
        
        protected virtual void OnEntityAction(CodeFluent.Runtime.CodeFluentEntityActionEventArgs e)
        {
            if ((this.EntityAction != null))
            {
                this.EntityAction(this, e);
            }
        }
        
        public virtual bool Equals(CodeFluentEntities.Bencher.Sales.CurrencyRate currencyRate)
        {
            if ((currencyRate == null))
            {
                return false;
            }
            if ((this.CurrencyRateID == -1))
            {
                return base.Equals(currencyRate);
            }
            return (this.CurrencyRateID.Equals(currencyRate.CurrencyRateID) == true);
        }
        
        public override int GetHashCode()
        {
            return this._currencyRateID;
        }
        
        public override bool Equals(object obj)
        {
            CodeFluentEntities.Bencher.Sales.CurrencyRate currencyRate = null;
			currencyRate = obj as CodeFluentEntities.Bencher.Sales.CurrencyRate;
            return this.Equals(currencyRate);
        }
        
        int System.IComparable.CompareTo(object value)
        {
            CodeFluentEntities.Bencher.Sales.CurrencyRate currencyRate = null;
currencyRate = value as CodeFluentEntities.Bencher.Sales.CurrencyRate;
            if ((currencyRate == null))
            {
                throw new System.ArgumentException("value");
            }
            int localCompareTo = this.CompareTo(currencyRate);
            return localCompareTo;
        }
        
        public virtual int CompareTo(CodeFluentEntities.Bencher.Sales.CurrencyRate currencyRate)
        {
            if ((currencyRate == null))
            {
                throw new System.ArgumentNullException("currencyRate");
            }
            int localCompareTo = this.CurrencyRateID.CompareTo(currencyRate.CurrencyRateID);
            return localCompareTo;
        }
        
        public virtual string Validate(System.Globalization.CultureInfo culture)
        {
            return CodeFluentPersistence.Validate(culture, this, null);
        }
        
        public virtual void Validate(System.Globalization.CultureInfo culture, System.Collections.Generic.IList<CodeFluent.Runtime.CodeFluentValidationException> results)
        {
            CodeFluent.Runtime.CodeFluentEntityActionEventArgs evt = new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Validating, true, results);
            evt.Culture = culture;
            this.OnEntityAction(evt);
            if ((evt.Cancel == true))
            {
                string externalValidate;
                if ((evt.Argument != null))
                {
                    externalValidate = evt.Argument.ToString();
                }
                else
                {
                    externalValidate = CodeFluentEntities.Bencher.Resources.Manager.GetStringWithDefault(culture, "CodeFluentEntities.Bencher.Sales.CurrencyRate.ExternalValidate", "Type \'CodeFluentEntities.Bencher.Sales.CurrencyRate\' cannot be validated.", null);
                }
                CodeFluentPersistence.AddValidationError(results, externalValidate);
            }
            CodeFluentPersistence.ValidateMember(culture, results, this, null);
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Validated, false, results));
        }
        
        public void Validate()
        {
            string var = this.Validate(System.Globalization.CultureInfo.CurrentCulture);
            if ((var != null))
            {
                throw new CodeFluent.Runtime.CodeFluentValidationException(var);
            }
        }
        
        string CodeFluent.Runtime.ICodeFluentValidator.Validate(System.Globalization.CultureInfo culture)
        {
            string localValidate = this.Validate(culture);
            return localValidate;
        }
        
        void CodeFluent.Runtime.ICodeFluentMemberValidator.Validate(System.Globalization.CultureInfo culture, string memberName, System.Collections.Generic.IList<CodeFluent.Runtime.CodeFluentValidationException> results)
        {
            this.ValidateMember(culture, memberName, results);
        }
        
        public virtual bool Delete()
        {
            bool ret = false;
            CodeFluent.Runtime.CodeFluentEntityActionEventArgs evt = new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Deleting, true);
            this.OnEntityAction(evt);
            if ((evt.Cancel == true))
            {
                return ret;
            }
            if ((this.EntityState == CodeFluent.Runtime.CodeFluentEntityState.Deleted))
            {
                return ret;
            }
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(CodeFluentEntities.Bencher.Constants.CodeFluentEntities_BencherStoreName).Persistence;
            persistence.CreateStoredProcedureCommand("Sales", "CurrencyRate", "Delete");
            persistence.AddRawParameter("@CurrencyRateID", this.CurrencyRateID);
            persistence.ExecuteNonQuery();
            this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Deleted;
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Deleted, false, false));
            ret = true;
            return ret;
        }
        
        protected virtual void ReadRecord(System.Data.IDataReader reader, CodeFluent.Runtime.CodeFluentReloadOptions options)
        {
            if ((reader == null))
            {
                throw new System.ArgumentNullException("reader");
            }
            if ((((options & CodeFluent.Runtime.CodeFluentReloadOptions.Properties) 
                        == 0) 
                        == false))
            {
                this._currencyRateID = CodeFluentPersistence.GetReaderValue(reader, "CurrencyRateID", ((int)(-1)));
                this._currencyRateDate = CodeFluentPersistence.GetReaderValue(reader, "CurrencyRateDate", ((System.DateTime)(CodeFluentPersistence.DefaultDateTimeValue)));
                this._averageRate = CodeFluentPersistence.GetReaderValue(reader, "AverageRate", ((decimal)(CodeFluentPersistence.DefaultDecimalValue)));
                this._endOfDayRate = CodeFluentPersistence.GetReaderValue(reader, "EndOfDayRate", ((decimal)(CodeFluentPersistence.DefaultDecimalValue)));
                this._modifiedDate = CodeFluentPersistence.GetReaderValue(reader, "ModifiedDate", ((System.DateTime)(CodeFluentPersistence.DefaultDateTimeValue)));
                this.FromCurrencyCodeCurrencyCode = CodeFluentPersistence.GetReaderValue(reader, "FromCurrencyCode", ((string)(default(string))));
                this.ToCurrencyCodeCurrencyCode = CodeFluentPersistence.GetReaderValue(reader, "ToCurrencyCode", ((string)(default(string))));
            }
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.ReadRecord, false, false));
        }
        
        void CodeFluent.Runtime.ICodeFluentEntity.ReadRecord(System.Data.IDataReader reader)
        {
            this.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.Default);
        }
        
        protected virtual void ReadRecordOnSave(System.Data.IDataReader reader)
        {
            if ((reader == null))
            {
                throw new System.ArgumentNullException("reader");
            }
            this._currencyRateID = CodeFluentPersistence.GetReaderValue(reader, "CurrencyRateID", ((int)(-1)));
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.ReadRecordOnSave, false, false));
        }
        
        void CodeFluent.Runtime.ICodeFluentEntity.ReadRecordOnSave(System.Data.IDataReader reader)
        {
            this.ReadRecordOnSave(reader);
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public static CodeFluentEntities.Bencher.Sales.CurrencyRate Load(int currencyRateID)
        {
            if ((currencyRateID == -1))
            {
                return null;
            }
            CodeFluentEntities.Bencher.Sales.CurrencyRate currencyRate = new CodeFluentEntities.Bencher.Sales.CurrencyRate();
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(CodeFluentEntities.Bencher.Constants.CodeFluentEntities_BencherStoreName).Persistence;
            persistence.CreateStoredProcedureCommand("Sales", "CurrencyRate", "Load");
            persistence.AddRawParameter("@CurrencyRateID", currencyRateID);
            System.Data.IDataReader reader = null;
            try
            {
                reader = persistence.ExecuteReader();
                if ((reader.Read() == true))
                {
                    currencyRate.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.Default);
                    currencyRate.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
                    return currencyRate;
                }
            }
            finally
            {
                if ((reader != null))
                {
                    reader.Dispose();
                }
                persistence.CompleteCommand();
            }
            return null;
        }
        
        public virtual bool Reload(CodeFluent.Runtime.CodeFluentReloadOptions options)
        {
            bool ret = false;
            if ((this.CurrencyRateID == -1))
            {
                return ret;
            }
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(CodeFluentEntities.Bencher.Constants.CodeFluentEntities_BencherStoreName).Persistence;
            persistence.CreateStoredProcedureCommand("Sales", "CurrencyRate", "Load");
            persistence.AddRawParameter("@CurrencyRateID", this.CurrencyRateID);
            System.Data.IDataReader reader = null;
            try
            {
                reader = persistence.ExecuteReader();
                if ((reader.Read() == true))
                {
                    this.ReadRecord(reader, options);
                    this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
                    ret = true;
                }
                else
                {
                    this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Deleted;
                }
            }
            finally
            {
                if ((reader != null))
                {
                    reader.Dispose();
                }
                persistence.CompleteCommand();
            }
            return ret;
        }
        
        protected virtual bool BaseSave(bool force)
        {
            if ((this.EntityState == CodeFluent.Runtime.CodeFluentEntityState.ToBeDeleted))
            {
                this.Delete();
                return false;
            }
            CodeFluent.Runtime.CodeFluentEntityActionEventArgs evt = new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Saving, true);
            this.OnEntityAction(evt);
            if ((evt.Cancel == true))
            {
                return false;
            }
            CodeFluentPersistence.ThrowIfDeleted(this);
            this.Validate();
            if (((force == false) 
                        && (this.EntityState == CodeFluent.Runtime.CodeFluentEntityState.Unchanged)))
            {
                return false;
            }
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(CodeFluentEntities.Bencher.Constants.CodeFluentEntities_BencherStoreName).Persistence;
            persistence.CreateStoredProcedureCommand("Sales", "CurrencyRate", "Save");
            persistence.AddRawParameter("@CurrencyRateID", this.CurrencyRateID);
            persistence.AddRawParameter("@CurrencyRateDate", this.CurrencyRateDate);
            persistence.AddRawParameter("@AverageRate", this.AverageRate);
            persistence.AddRawParameter("@EndOfDayRate", this.EndOfDayRate);
            persistence.AddRawParameter("@ModifiedDate", this.ModifiedDate);
            persistence.AddRawParameter("@FromCurrencyCode", this.FromCurrencyCodeCurrencyCode);
            persistence.AddRawParameter("@ToCurrencyCode", this.ToCurrencyCodeCurrencyCode);
            System.Data.IDataReader reader = null;
            try
            {
                reader = persistence.ExecuteReader();
                if ((reader.Read() == true))
                {
                    this.ReadRecordOnSave(reader);
                }
                CodeFluentPersistence.NextResults(reader);
            }
            finally
            {
                if ((reader != null))
                {
                    reader.Dispose();
                }
                persistence.CompleteCommand();
            }
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Saved, false, false));
            this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
            return true;
        }
        
        public virtual bool Save()
        {
            bool localSave = this.BaseSave(false);
            return localSave;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, true)]
        public static bool Save(CodeFluentEntities.Bencher.Sales.CurrencyRate currencyRate)
        {
            if ((currencyRate == null))
            {
                return false;
            }
            bool ret = currencyRate.Save();
            return ret;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public static bool Insert(CodeFluentEntities.Bencher.Sales.CurrencyRate currencyRate)
        {
            bool ret = CodeFluentEntities.Bencher.Sales.CurrencyRate.Save(currencyRate);
            return ret;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public static bool Delete(CodeFluentEntities.Bencher.Sales.CurrencyRate currencyRate)
        {
            if ((currencyRate == null))
            {
                return false;
            }
            bool ret = currencyRate.Delete();
            return ret;
        }
        
        public string Trace()
        {
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
            System.IO.StringWriter stringWriter = new System.IO.StringWriter(stringBuilder, System.Globalization.CultureInfo.CurrentCulture);
            System.CodeDom.Compiler.IndentedTextWriter writer = new System.CodeDom.Compiler.IndentedTextWriter(stringWriter);
            this.BaseTrace(writer);
            writer.Flush();
            ((System.IDisposable)(writer)).Dispose();
            ((System.IDisposable)(stringWriter)).Dispose();
            string sr = stringBuilder.ToString();
            return sr;
        }
        
        void CodeFluent.Runtime.ICodeFluentObject.Trace(System.CodeDom.Compiler.IndentedTextWriter writer)
        {
            this.BaseTrace(writer);
        }
        
        protected virtual void BaseTrace(System.CodeDom.Compiler.IndentedTextWriter writer)
        {
            writer.Write("[");
            writer.Write("CurrencyRateID=");
            writer.Write(this.CurrencyRateID);
            writer.Write(",");
            writer.Write("CurrencyRateDate=");
            writer.Write(this.CurrencyRateDate);
            writer.Write(",");
            writer.Write("AverageRate=");
            writer.Write(this.AverageRate);
            writer.Write(",");
            writer.Write("EndOfDayRate=");
            writer.Write(this.EndOfDayRate);
            writer.Write(",");
            writer.Write("ModifiedDate=");
            writer.Write(this.ModifiedDate);
            writer.Write(",");
            writer.Write("FromCurrencyCode=");
            if ((this._fromCurrencyCode != null))
            {
                ((CodeFluent.Runtime.ICodeFluentObject)(this._fromCurrencyCode)).Trace(writer);
            }
            else
            {
                writer.Write("<null>");
            }
            writer.Write(",");
            writer.Write("_fromCurrencyCodeCurrencyCode=");
            writer.Write(this._fromCurrencyCodeCurrencyCode);
            writer.Write(",");
            writer.Write("ToCurrencyCode=");
            if ((this._toCurrencyCode != null))
            {
                ((CodeFluent.Runtime.ICodeFluentObject)(this._toCurrencyCode)).Trace(writer);
            }
            else
            {
                writer.Write("<null>");
            }
            writer.Write(",");
            writer.Write("_toCurrencyCodeCurrencyCode=");
            writer.Write(this._toCurrencyCodeCurrencyCode);
            writer.Write(",");
            writer.Write("SalesOrderHeaders=");
            if ((this._salesOrderHeaders != null))
            {
                ((CodeFluent.Runtime.ICodeFluentObject)(this._salesOrderHeaders)).Trace(writer);
            }
            else
            {
                writer.Write("<null>");
            }
            writer.Write(", EntityState=");
            writer.Write(this.EntityState);
            writer.Write("]");
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public static CodeFluentEntities.Bencher.Sales.CurrencyRate LoadByEntityKey(string key)
        {
            if ((key == string.Empty))
            {
                return null;
            }
            CodeFluentEntities.Bencher.Sales.CurrencyRate currencyRate;
            int var = ((int)(ConvertUtilities.ChangeType(key, typeof(int), -1)));
            currencyRate = CodeFluentEntities.Bencher.Sales.CurrencyRate.Load(var);
            return currencyRate;
        }
        
        protected virtual void ValidateMember(System.Globalization.CultureInfo culture, string memberName, System.Collections.Generic.IList<CodeFluent.Runtime.CodeFluentValidationException> results)
        {
        }
        
        public CodeFluentEntities.Bencher.Sales.CurrencyRate Clone(bool deep)
        {
            CodeFluentEntities.Bencher.Sales.CurrencyRate currencyRate = new CodeFluentEntities.Bencher.Sales.CurrencyRate();
            this.CopyTo(currencyRate, deep);
            return currencyRate;
        }
        
        public CodeFluentEntities.Bencher.Sales.CurrencyRate Clone()
        {
            CodeFluentEntities.Bencher.Sales.CurrencyRate localClone = this.Clone(true);
            return localClone;
        }
        
        object System.ICloneable.Clone()
        {
            object localClone = this.Clone();
            return localClone;
        }
        
        public virtual void CopyFrom(System.Collections.IDictionary dict, bool deep)
        {
            if ((dict == null))
            {
                throw new System.ArgumentNullException("dict");
            }
            if ((dict.Contains("CurrencyRateID") == true))
            {
                this.CurrencyRateID = ((int)(ConvertUtilities.ChangeType(dict["CurrencyRateID"], typeof(int), -1)));
            }
            if ((dict.Contains("EndOfDayRate") == true))
            {
                this.EndOfDayRate = ((decimal)(ConvertUtilities.ChangeType(dict["EndOfDayRate"], typeof(decimal), CodeFluentPersistence.DefaultDecimalValue)));
            }
            if ((dict.Contains("ModifiedDate") == true))
            {
                this.ModifiedDate = ((System.DateTime)(ConvertUtilities.ChangeType(dict["ModifiedDate"], typeof(System.DateTime), CodeFluentPersistence.DefaultDateTimeValue)));
            }
            if ((dict.Contains("CurrencyRateDate") == true))
            {
                this.CurrencyRateDate = ((System.DateTime)(ConvertUtilities.ChangeType(dict["CurrencyRateDate"], typeof(System.DateTime), CodeFluentPersistence.DefaultDateTimeValue)));
            }
            if ((dict.Contains("AverageRate") == true))
            {
                this.AverageRate = ((decimal)(ConvertUtilities.ChangeType(dict["AverageRate"], typeof(decimal), CodeFluentPersistence.DefaultDecimalValue)));
            }
            if ((dict.Contains("ToCurrencyCodeCurrencyCode") == true))
            {
                this.ToCurrencyCodeCurrencyCode = ((string)(ConvertUtilities.ChangeType(dict["ToCurrencyCodeCurrencyCode"], typeof(string), default(string))));
            }
            if ((dict.Contains("FromCurrencyCodeCurrencyCode") == true))
            {
                this.FromCurrencyCodeCurrencyCode = ((string)(ConvertUtilities.ChangeType(dict["FromCurrencyCodeCurrencyCode"], typeof(string), default(string))));
            }
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.CopyFrom, false, dict));
        }
        
        public virtual void CopyTo(CodeFluentEntities.Bencher.Sales.CurrencyRate currencyRate, bool deep)
        {
            if ((currencyRate == null))
            {
                throw new System.ArgumentNullException("currencyRate");
            }
            currencyRate.CurrencyRateID = this.CurrencyRateID;
            currencyRate.EndOfDayRate = this.EndOfDayRate;
            currencyRate.ModifiedDate = this.ModifiedDate;
            currencyRate.CurrencyRateDate = this.CurrencyRateDate;
            currencyRate.AverageRate = this.AverageRate;
            currencyRate.ToCurrencyCodeCurrencyCode = this.ToCurrencyCodeCurrencyCode;
            currencyRate.FromCurrencyCodeCurrencyCode = this.FromCurrencyCodeCurrencyCode;
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.CopyTo, false, currencyRate));
        }
        
        public virtual void CopyTo(System.Collections.IDictionary dict, bool deep)
        {
            if ((dict == null))
            {
                throw new System.ArgumentNullException("dict");
            }
            dict["CurrencyRateID"] = this.CurrencyRateID;
            dict["EndOfDayRate"] = this.EndOfDayRate;
            dict["ModifiedDate"] = this.ModifiedDate;
            dict["CurrencyRateDate"] = this.CurrencyRateDate;
            dict["AverageRate"] = this.AverageRate;
            dict["ToCurrencyCodeCurrencyCode"] = this.ToCurrencyCodeCurrencyCode;
            dict["FromCurrencyCodeCurrencyCode"] = this.FromCurrencyCodeCurrencyCode;
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.CopyTo, false, dict));
        }
    }
}
