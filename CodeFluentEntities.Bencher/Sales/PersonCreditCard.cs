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
    [System.Diagnostics.DebuggerDisplayAttribute("EK={EntityKey}, BusinessEntityID={BusinessEntityID}")]
    [System.ComponentModel.TypeConverterAttribute(typeof(CodeFluent.Runtime.Design.NameTypeConverter))]
    public partial class PersonCreditCard : System.ICloneable, System.IComparable, System.IComparable<CodeFluentEntities.Bencher.Sales.PersonCreditCard>, CodeFluent.Runtime.ICodeFluentEntity, System.ComponentModel.IDataErrorInfo, CodeFluent.Runtime.ICodeFluentMemberValidator, CodeFluent.Runtime.ICodeFluentSummaryValidator, System.IEquatable<CodeFluentEntities.Bencher.Sales.PersonCreditCard>
    {
        
        private bool _raisePropertyChangedEvents = true;
        
        private CodeFluent.Runtime.CodeFluentEntityState _entityState;
        
        private int _businessEntityID = CodeFluentPersistence.DefaultInt32Value;
        
        private System.DateTime _modifiedDate = CodeFluentPersistence.DefaultDateTimeValue;
        
        private int _creditCardCreditCardID = -1;
        
        [System.NonSerializedAttribute()]
        private CodeFluentEntities.Bencher.Sales.CreditCard _creditCard = null;
        
        public PersonCreditCard()
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
                object[] keys = new object[] {
                        this.BusinessEntityID,
                        this.CreditCardCreditCardID};
                string v = CodeFluentPersistence.BuildEntityKey(keys);
                return v;
            }
            set
            {
                System.Type[] types = new System.Type[] {
                        typeof(int),
                        typeof(int)};
                object[] defaultValues = new object[] {
                        CodeFluentPersistence.DefaultInt32Value,
                        -1};
                object[] v1 = CodeFluentPersistence.ParseEntityKey(value, types, defaultValues);
                this.BusinessEntityID = ((int)(v1[0]));
                this.CreditCardCreditCardID = ((int)(v1[1]));
            }
        }
        
        public virtual string EntityDisplayName
        {
            get
            {
                return this.BusinessEntityID.ToString();
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(CodeFluentPersistence.DefaultInt32Value)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false, Type=typeof(int))]
        [System.ComponentModel.DataObjectFieldAttribute(true)]
        public int BusinessEntityID
        {
            get
            {
                return this._businessEntityID;
            }
            set
            {
                this._businessEntityID = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("BusinessEntityID"));
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
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false)]
        [System.ComponentModel.DataObjectFieldAttribute(true)]
        public int CreditCardCreditCardID
        {
            get
            {
                if (((this._creditCardCreditCardID == -1) 
                            && (this._creditCard != null)))
                {
                    this._creditCardCreditCardID = this._creditCard.CreditCardID;
                }
                return this._creditCardCreditCardID;
            }
            set
            {
                if ((System.Collections.Generic.EqualityComparer<int>.Default.Equals(value, this.CreditCardCreditCardID) == true))
                {
                    return;
                }
                this._creditCard = null;
                this._creditCardCreditCardID = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("CreditCard"));
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("CreditCardCreditCardID"));
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public CodeFluentEntities.Bencher.Sales.CreditCard CreditCard
        {
            get
            {
                if ((this._creditCard == null))
                {
                    this._creditCard = CodeFluentEntities.Bencher.Sales.CreditCard.Load(this._creditCardCreditCardID);
                }
                return this._creditCard;
            }
            set
            {
                this._creditCardCreditCardID = -1;
                this._creditCard = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("CreditCard"));
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("CreditCardCreditCardID"));
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
        
        public virtual bool Equals(CodeFluentEntities.Bencher.Sales.PersonCreditCard personCreditCard)
        {
            if ((personCreditCard == null))
            {
                return false;
            }
            if (((this.BusinessEntityID == CodeFluentPersistence.DefaultInt32Value) 
                        || (this.CreditCardCreditCardID == -1)))
            {
                return base.Equals(personCreditCard);
            }
            return ((this.BusinessEntityID.Equals(personCreditCard.BusinessEntityID) && this.CreditCardCreditCardID.Equals(personCreditCard.CreditCardCreditCardID)) 
                        == true);
        }
        
        public override int GetHashCode()
        {
            if ((this.EntityKey == null))
            {
                return base.GetHashCode();
            }
            return this.EntityKey.GetHashCode();
        }
        
        public override bool Equals(object obj)
        {
            CodeFluentEntities.Bencher.Sales.PersonCreditCard personCreditCard = null;
			personCreditCard = obj as CodeFluentEntities.Bencher.Sales.PersonCreditCard;
            return this.Equals(personCreditCard);
        }
        
        int System.IComparable.CompareTo(object value)
        {
            CodeFluentEntities.Bencher.Sales.PersonCreditCard personCreditCard = null;
personCreditCard = value as CodeFluentEntities.Bencher.Sales.PersonCreditCard;
            if ((personCreditCard == null))
            {
                throw new System.ArgumentException("value");
            }
            int localCompareTo = this.CompareTo(personCreditCard);
            return localCompareTo;
        }
        
        public virtual int CompareTo(CodeFluentEntities.Bencher.Sales.PersonCreditCard personCreditCard)
        {
            if ((personCreditCard == null))
            {
                throw new System.ArgumentNullException("personCreditCard");
            }
            int localCompareTo = this.BusinessEntityID.CompareTo(personCreditCard.BusinessEntityID);
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
                    externalValidate = CodeFluentEntities.Bencher.Resources.Manager.GetStringWithDefault(culture, "CodeFluentEntities.Bencher.Sales.PersonCreditCard.ExternalValidate", "Type \'CodeFluentEntities.Bencher.Sales.PersonCreditCard\' cannot be validated.", null);
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
            persistence.CreateStoredProcedureCommand("Sales", "PersonCreditCard", "Delete");
            persistence.AddRawParameter("@BusinessEntityID", this.BusinessEntityID);
            persistence.AddRawParameter("@CreditCardID", this.CreditCardCreditCardID);
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
                this._businessEntityID = CodeFluentPersistence.GetReaderValue(reader, "BusinessEntityID", ((int)(CodeFluentPersistence.DefaultInt32Value)));
                this._modifiedDate = CodeFluentPersistence.GetReaderValue(reader, "ModifiedDate", ((System.DateTime)(CodeFluentPersistence.DefaultDateTimeValue)));
                this.CreditCardCreditCardID = CodeFluentPersistence.GetReaderValue(reader, "CreditCardID", ((int)(-1)));
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
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.ReadRecordOnSave, false, false));
        }
        
        void CodeFluent.Runtime.ICodeFluentEntity.ReadRecordOnSave(System.Data.IDataReader reader)
        {
            this.ReadRecordOnSave(reader);
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public static CodeFluentEntities.Bencher.Sales.PersonCreditCard Load(int businessEntityID, int creditCardCreditCardID)
        {
            if ((creditCardCreditCardID == -1))
            {
                return null;
            }
            if ((businessEntityID == CodeFluentPersistence.DefaultInt32Value))
            {
                return null;
            }
            CodeFluentEntities.Bencher.Sales.PersonCreditCard personCreditCard = new CodeFluentEntities.Bencher.Sales.PersonCreditCard();
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(CodeFluentEntities.Bencher.Constants.CodeFluentEntities_BencherStoreName).Persistence;
            persistence.CreateStoredProcedureCommand("Sales", "PersonCreditCard", "Load");
            persistence.AddRawParameter("@BusinessEntityID", businessEntityID);
            persistence.AddRawParameter("@CreditCardCreditCardID", creditCardCreditCardID);
            System.Data.IDataReader reader = null;
            try
            {
                reader = persistence.ExecuteReader();
                if ((reader.Read() == true))
                {
                    personCreditCard.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.Default);
                    personCreditCard.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
                    return personCreditCard;
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
            if (((this.BusinessEntityID == CodeFluentPersistence.DefaultInt32Value) 
                        || (this.CreditCardCreditCardID == -1)))
            {
                return ret;
            }
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(CodeFluentEntities.Bencher.Constants.CodeFluentEntities_BencherStoreName).Persistence;
            persistence.CreateStoredProcedureCommand("Sales", "PersonCreditCard", "Load");
            persistence.AddRawParameter("@BusinessEntityID", this.BusinessEntityID);
            persistence.AddRawParameter("@CreditCardCreditCardID", this.CreditCardCreditCardID);
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
            persistence.CreateStoredProcedureCommand("Sales", "PersonCreditCard", "Save");
            persistence.AddRawParameter("@BusinessEntityID", this.BusinessEntityID);
            persistence.AddRawParameter("@CreditCardID", this.CreditCardCreditCardID);
            persistence.AddRawParameter("@ModifiedDate", this.ModifiedDate);
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
        public static bool Save(CodeFluentEntities.Bencher.Sales.PersonCreditCard personCreditCard)
        {
            if ((personCreditCard == null))
            {
                return false;
            }
            bool ret = personCreditCard.Save();
            return ret;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public static bool Insert(CodeFluentEntities.Bencher.Sales.PersonCreditCard personCreditCard)
        {
            bool ret = CodeFluentEntities.Bencher.Sales.PersonCreditCard.Save(personCreditCard);
            return ret;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public static bool Delete(CodeFluentEntities.Bencher.Sales.PersonCreditCard personCreditCard)
        {
            if ((personCreditCard == null))
            {
                return false;
            }
            bool ret = personCreditCard.Delete();
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
            writer.Write("BusinessEntityID=");
            writer.Write(this.BusinessEntityID);
            writer.Write(",");
            writer.Write("ModifiedDate=");
            writer.Write(this.ModifiedDate);
            writer.Write(",");
            writer.Write("CreditCard=");
            if ((this._creditCard != null))
            {
                ((CodeFluent.Runtime.ICodeFluentObject)(this._creditCard)).Trace(writer);
            }
            else
            {
                writer.Write("<null>");
            }
            writer.Write(",");
            writer.Write("_creditCardCreditCardID=");
            writer.Write(this._creditCardCreditCardID);
            writer.Write(", EntityState=");
            writer.Write(this.EntityState);
            writer.Write("]");
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public static CodeFluentEntities.Bencher.Sales.PersonCreditCard LoadByEntityKey(string key)
        {
            if ((key == string.Empty))
            {
                return null;
            }
            CodeFluentEntities.Bencher.Sales.PersonCreditCard personCreditCard;
            System.Type[] types = new System.Type[] {
                    typeof(int),
                    typeof(int)};
            object[] defaultValues = new object[] {
                    CodeFluentPersistence.DefaultInt32Value,
                    -1};
            object[] v = CodeFluentPersistence.ParseEntityKey(key, types, defaultValues);
            int var0;
            var0 = ((int)(v[0]));
            int var1;
            var1 = ((int)(v[1]));
            personCreditCard = CodeFluentEntities.Bencher.Sales.PersonCreditCard.Load(var0, var1);
            return personCreditCard;
        }
        
        protected virtual void ValidateMember(System.Globalization.CultureInfo culture, string memberName, System.Collections.Generic.IList<CodeFluent.Runtime.CodeFluentValidationException> results)
        {
        }
        
        public CodeFluentEntities.Bencher.Sales.PersonCreditCard Clone(bool deep)
        {
            CodeFluentEntities.Bencher.Sales.PersonCreditCard personCreditCard = new CodeFluentEntities.Bencher.Sales.PersonCreditCard();
            this.CopyTo(personCreditCard, deep);
            return personCreditCard;
        }
        
        public CodeFluentEntities.Bencher.Sales.PersonCreditCard Clone()
        {
            CodeFluentEntities.Bencher.Sales.PersonCreditCard localClone = this.Clone(true);
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
            if ((dict.Contains("CreditCardCreditCardID") == true))
            {
                this.CreditCardCreditCardID = ((int)(ConvertUtilities.ChangeType(dict["CreditCardCreditCardID"], typeof(int), -1)));
            }
            if ((dict.Contains("BusinessEntityID") == true))
            {
                this.BusinessEntityID = ((int)(ConvertUtilities.ChangeType(dict["BusinessEntityID"], typeof(int), CodeFluentPersistence.DefaultInt32Value)));
            }
            if ((dict.Contains("ModifiedDate") == true))
            {
                this.ModifiedDate = ((System.DateTime)(ConvertUtilities.ChangeType(dict["ModifiedDate"], typeof(System.DateTime), CodeFluentPersistence.DefaultDateTimeValue)));
            }
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.CopyFrom, false, dict));
        }
        
        public virtual void CopyTo(CodeFluentEntities.Bencher.Sales.PersonCreditCard personCreditCard, bool deep)
        {
            if ((personCreditCard == null))
            {
                throw new System.ArgumentNullException("personCreditCard");
            }
            personCreditCard.CreditCardCreditCardID = this.CreditCardCreditCardID;
            personCreditCard.BusinessEntityID = this.BusinessEntityID;
            personCreditCard.ModifiedDate = this.ModifiedDate;
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.CopyTo, false, personCreditCard));
        }
        
        public virtual void CopyTo(System.Collections.IDictionary dict, bool deep)
        {
            if ((dict == null))
            {
                throw new System.ArgumentNullException("dict");
            }
            dict["CreditCardCreditCardID"] = this.CreditCardCreditCardID;
            dict["BusinessEntityID"] = this.BusinessEntityID;
            dict["ModifiedDate"] = this.ModifiedDate;
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.CopyTo, false, dict));
        }
    }
}
