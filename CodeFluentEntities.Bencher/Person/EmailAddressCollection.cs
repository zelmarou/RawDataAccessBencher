﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CodeFluentEntities.Bencher.Person
{
    using CodeFluent.Runtime;
    using CodeFluent.Runtime.Utilities;
    
    
    // CodeFluent Entities generated (http://www.softfluent.com). Date: Tuesday, 18 March 2014 16:33.
    // Build:1.0.61214.0764
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CodeFluent Entities", "1.0.61214.0764")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DataObjectAttribute()]
    [System.Diagnostics.DebuggerDisplayAttribute("Count={Count}")]
    [System.ComponentModel.TypeConverterAttribute(typeof(CodeFluent.Runtime.Design.CollectionTypeConverter))]
    public partial class EmailAddressCollection : System.Collections.IList, CodeFluent.Runtime.ICodeFluentSet, System.Collections.Generic.IList<CodeFluentEntities.Bencher.Person.EmailAddress>, System.ComponentModel.IRaiseItemChangedEvents, System.ICloneable, System.ComponentModel.INotifyPropertyChanged, System.Collections.Specialized.INotifyCollectionChanged, System.ComponentModel.IBindingList, System.ComponentModel.ICancelAddNew
    {
        
        private bool _raisePropertyChangedEvents = true;
        
        private bool _raiseCollectionChangedEvents = true;
        
        [System.NonSerializedAttribute()]
        private System.Collections.Generic.List<CodeFluentEntities.Bencher.Person.EmailAddress> _baseList = new System.Collections.Generic.List<CodeFluentEntities.Bencher.Person.EmailAddress>();
        
        [System.NonSerializedAttribute()]
        private System.Collections.Hashtable _relations = new System.Collections.Hashtable();
        
        private int _maxCount = 2147483647;
        
        [System.NonSerializedAttribute()]
        private int _addNewPos = -1;
        
        [System.NonSerializedAttribute()]
        private CodeFluent.Runtime.Utilities.BindingListManager<CodeFluentEntities.Bencher.Person.EmailAddress> _blm1983009524;
        
        private bool _raiseListChangedEvents = true;
        
        private System.Collections.Specialized.NotifyCollectionChangedEventHandler _h2943838991;

        event System.Collections.Specialized.NotifyCollectionChangedEventHandler System.Collections.Specialized.INotifyCollectionChanged.CollectionChanged{add{_h2943838991+=value;}remove{_h2943838991-=value;}}
        
        public EmailAddressCollection()
        {
            this._blm1983009524 = new CodeFluent.Runtime.Utilities.BindingListManager<CodeFluentEntities.Bencher.Person.EmailAddress>(this);
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
        
        public virtual bool RaiseCollectionChangedEvents
        {
            get
            {
                return this._raiseCollectionChangedEvents;
            }
            set
            {
                this._raiseCollectionChangedEvents = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        protected System.Collections.Generic.List<CodeFluentEntities.Bencher.Person.EmailAddress> BaseList
        {
            get
            {
                return this._baseList;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        System.Collections.IDictionary CodeFluent.Runtime.ICodeFluentSet.Relations
        {
            get
            {
                return this._relations;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false)]
        public virtual int MaxCount
        {
            get
            {
                return this._maxCount;
            }
            set
            {
                this._maxCount = value;
            }
        }
        
        public CodeFluentEntities.Bencher.Person.EmailAddress this[int index]
        {
            get
            {
                return ((CodeFluentEntities.Bencher.Person.EmailAddress)(this.BaseList[index]));
            }
            set
            {
                this.BaseList[index] = value;
            }
        }
        
        object System.Collections.IList.this[int index]
        {
            get
            {
                object i = this.BaseList[index];
                return i;
            }
            set
            {
                this.BaseList[index] = ((CodeFluentEntities.Bencher.Person.EmailAddress)(value));
            }
        }
        
        public virtual int Count
        {
            get
            {
                int v = ((System.Collections.IList)(this.BaseList)).Count;
                return v;
            }
        }
        
        public virtual bool IsSynchronized
        {
            get
            {
                bool v = ((System.Collections.IList)(this.BaseList)).IsSynchronized;
                return v;
            }
        }
        
        public virtual object SyncRoot
        {
            get
            {
                object v = ((System.Collections.IList)(this.BaseList)).SyncRoot;
                return v;
            }
        }
        
        public virtual bool IsFixedSize
        {
            get
            {
                bool v = ((System.Collections.IList)(this.BaseList)).IsFixedSize;
                return v;
            }
        }
        
        public virtual bool IsReadOnly
        {
            get
            {
                bool v = ((System.Collections.IList)(this.BaseList)).IsReadOnly;
                return v;
            }
        }
        
        public virtual bool RaiseListChangedEvents
        {
            get
            {
                return this._raiseListChangedEvents;
            }
            set
            {
                this._raiseListChangedEvents = value;
            }
        }
        
        bool System.ComponentModel.IBindingList.AllowEdit
        {
            get
            {
                return this._blm1983009524.AllowEdit;
            }
        }
        
        bool System.ComponentModel.IBindingList.AllowNew
        {
            get
            {
                return this._blm1983009524.AllowNew;
            }
        }
        
        bool System.ComponentModel.IBindingList.AllowRemove
        {
            get
            {
                return this._blm1983009524.AllowRemove;
            }
        }
        
        bool System.ComponentModel.IBindingList.IsSorted
        {
            get
            {
                return this._blm1983009524.IsSorted;
            }
        }
        
        System.ComponentModel.ListSortDirection System.ComponentModel.IBindingList.SortDirection
        {
            get
            {
                return this._blm1983009524.SortDirection;
            }
        }
        
        System.ComponentModel.PropertyDescriptor System.ComponentModel.IBindingList.SortProperty
        {
            get
            {
                return this._blm1983009524.SortProperty;
            }
        }
        
        bool System.ComponentModel.IBindingList.SupportsChangeNotification
        {
            get
            {
                return true;
            }
        }
        
        bool System.ComponentModel.IBindingList.SupportsSearching
        {
            get
            {
                return this._blm1983009524.SupportsSearching;
            }
        }
        
        bool System.ComponentModel.IBindingList.SupportsSorting
        {
            get
            {
                return this._blm1983009524.SupportsSorting;
            }
        }
        
        bool System.ComponentModel.IRaiseItemChangedEvents.RaisesItemChangedEvents
        {
            get
            {
                return this.RaiseListChangedEvents;
            }
        }
        
        [field:System.NonSerializedAttribute()]
        public event System.ComponentModel.CollectionChangeEventHandler CollectionChanged;
        
        [field:System.NonSerializedAttribute()]
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        [field:System.NonSerializedAttribute()]
        public event System.ComponentModel.AddingNewEventHandler AddingNew;
        
        [field:System.NonSerializedAttribute()]
        public event System.ComponentModel.ListChangedEventHandler ListChanged;
        
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
        
        protected virtual void OnCollectionChanged(System.ComponentModel.CollectionChangeEventArgs e)
        {
            if ((this.RaiseCollectionChangedEvents == false))
            {
                return;
            }
            if ((this.CollectionChanged != null))
            {
                this.CollectionChanged(this, e);
            }
            CodeFluent.Runtime.ServiceModel.CollectionChangeNotifier.Notify(this, e, this._h2943838991);
            this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Count"));
            this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Item[]"));
        }
        
        protected virtual void Relate(CodeFluentEntities.Bencher.Person.EmailAddress item, CodeFluent.Runtime.CodeFluentRelationType relationType)
        {
            ((CodeFluent.Runtime.ICodeFluentSet)(this)).Relations[item] = relationType;
        }
        
        public int Add(CodeFluentEntities.Bencher.Person.EmailAddress emailAddress)
        {
            int localAdd = this.BaseList.Count;
            this.BaseAdd(emailAddress);
            return localAdd;
        }
        
        protected virtual int BaseAdd(CodeFluentEntities.Bencher.Person.EmailAddress emailAddress)
        {
            if ((emailAddress == null))
            {
                throw new System.ArgumentNullException("emailAddress");
            }
            if (((emailAddress.BusinessEntityID == CodeFluentPersistence.DefaultInt32Value) 
                        || (emailAddress.EmailAddressID == -1)))
            {
                CodeFluent.Runtime.CodeFluentRuntimeException.Throw("invalidEntityKey", "BusinessEntityID, EmailAddressID", "emailAddress", "CodeFluentEntities.Bencher.Person.EmailAddress");
            }
            int localAdd = this.BaseList.Count;
            this.BaseList.Add(emailAddress);
            this.OnCollectionChanged(new CodeFluent.Runtime.Utilities.IndexedCollectionChangeEventArgs(System.ComponentModel.CollectionChangeAction.Add, emailAddress, localAdd));
            this.OnListChanged(new System.ComponentModel.ListChangedEventArgs(System.ComponentModel.ListChangedType.ItemAdded, localAdd));
            return localAdd;
        }
        
        int System.Collections.IList.Add(object value)
        {
            CodeFluentEntities.Bencher.Person.EmailAddress emailAddress = null;
            try
            {
                emailAddress = ((CodeFluentEntities.Bencher.Person.EmailAddress)(value));
            }
            catch (System.InvalidCastException )
            {
                string key = null;
                try
                {
                    key = ((string)(value));
                    int count = this.Count;
                    if ((this.AddByEntityKey(key) != null))
                    {
                        return 1;
                    }
                    return 0;
                }
                catch (System.InvalidCastException )
                {
                }
                if ((key == null))
                {
                    throw new System.ArgumentException("value");
                }
            }
            if ((emailAddress == null))
            {
                throw new System.ArgumentException("value");
            }
            int localAdd = this.Add(emailAddress);
            return localAdd;
        }
        
        void System.Collections.Generic.ICollection<CodeFluentEntities.Bencher.Person.EmailAddress>.Add(CodeFluentEntities.Bencher.Person.EmailAddress emailAddress)
        {
            this.BaseAdd(emailAddress);
        }
        
        public virtual CodeFluentEntities.Bencher.Person.EmailAddress AddByEntityKey(string key)
        {
            CodeFluentEntities.Bencher.Person.EmailAddress emailAddress = CodeFluentEntities.Bencher.Person.EmailAddress.LoadByEntityKey(key);
            if (((emailAddress != null) 
                        && (this.Contains(emailAddress) == false)))
            {
                this.Add(emailAddress);
            }
            return emailAddress;
        }
        
        public void Sort()
        {
            this.Sort(null);
        }
        
        public virtual void Sort(System.Collections.Generic.IComparer<CodeFluentEntities.Bencher.Person.EmailAddress> comparer)
        {
            this.BaseList.Sort(comparer);
        }
        
        public void CopyTo(CodeFluentEntities.Bencher.Person.EmailAddress[] array, int index)
        {
            this.BaseCopyTo(array, index);
        }
        
        protected virtual void BaseCopyTo(CodeFluentEntities.Bencher.Person.EmailAddress[] array, int index)
        {
            this.BaseList.CopyTo(array, index);
        }
        
        void System.Collections.ICollection.CopyTo(System.Array array, int index)
        {
            CodeFluent.Runtime.Utilities.ConvertUtilities.CopyTo(this, array, index);
        }
        
        public bool Contains(CodeFluentEntities.Bencher.Person.EmailAddress emailAddress)
        {
            bool localContains = this.BaseContains(emailAddress);
            return localContains;
        }
        
        protected virtual bool BaseContains(CodeFluentEntities.Bencher.Person.EmailAddress emailAddress)
        {
            if ((emailAddress == null))
            {
                return false;
            }
            bool localContains = this.BaseList.Contains(emailAddress);
            return localContains;
        }
        
        bool System.Collections.IList.Contains(object value)
        {
            CodeFluentEntities.Bencher.Person.EmailAddress emailAddress;
			emailAddress = value as CodeFluentEntities.Bencher.Person.EmailAddress;
            return this.Contains(emailAddress);
        }
        
        public int IndexOf(CodeFluentEntities.Bencher.Person.EmailAddress emailAddress)
        {
            int localIndexOf = this.BaseIndexOf(emailAddress);
            return localIndexOf;
        }
        
        protected virtual int BaseIndexOf(CodeFluentEntities.Bencher.Person.EmailAddress emailAddress)
        {
            if ((emailAddress == null))
            {
                return -1;
            }
            int localIndexOf = this.BaseList.IndexOf(emailAddress);
            return localIndexOf;
        }
        
        int System.Collections.IList.IndexOf(object value)
        {
            CodeFluentEntities.Bencher.Person.EmailAddress emailAddress;
			emailAddress = value as CodeFluentEntities.Bencher.Person.EmailAddress;
            return this.IndexOf(emailAddress);
        }
        
        public void Insert(int index, CodeFluentEntities.Bencher.Person.EmailAddress emailAddress)
        {
            this.BaseInsert(index, emailAddress);
        }
        
        protected virtual void BaseInsert(int index, CodeFluentEntities.Bencher.Person.EmailAddress emailAddress)
        {
            if ((emailAddress == null))
            {
                throw new System.ArgumentNullException("emailAddress");
            }
            this.BaseList.Insert(index, emailAddress);
            this.OnCollectionChanged(new CodeFluent.Runtime.Utilities.IndexedCollectionChangeEventArgs(System.ComponentModel.CollectionChangeAction.Add, emailAddress, index));
            this.OnListChanged(new System.ComponentModel.ListChangedEventArgs(System.ComponentModel.ListChangedType.ItemAdded, index));
        }
        
        void System.Collections.IList.Insert(int index, object value)
        {
            CodeFluentEntities.Bencher.Person.EmailAddress emailAddress;
			emailAddress = value as CodeFluentEntities.Bencher.Person.EmailAddress;
            this.Insert(index, emailAddress);
        }
        
        public virtual void Clear()
        {
            int index;
            int count = this.Count;
            for (index = 0; (index < count); index = (index + 1))
            {
                CodeFluentEntities.Bencher.Person.EmailAddress EmailAddress = this[0];
                this.BaseRemove(EmailAddress);
            }
            this.OnCollectionChanged(new CodeFluent.Runtime.Utilities.IndexedCollectionChangeEventArgs(System.ComponentModel.CollectionChangeAction.Refresh, null));
            this.OnListChanged(new System.ComponentModel.ListChangedEventArgs(System.ComponentModel.ListChangedType.Reset, -1));
        }
        
        public bool Remove(CodeFluentEntities.Bencher.Person.EmailAddress emailAddress)
        {
            return this.BaseRemove(emailAddress);
        }
        
        protected virtual bool BaseRemove(CodeFluentEntities.Bencher.Person.EmailAddress emailAddress)
        {
            if ((emailAddress == null))
            {
                throw new System.ArgumentNullException("emailAddress");
            }
            int index = this.IndexOf(emailAddress);
            this.OnListChanged(new System.ComponentModel.ListChangedEventArgs(((System.ComponentModel.ListChangedType)(CodeFluent.Runtime.Utilities.SortableBindingList<CodeFluentEntities.Bencher.Person.EmailAddress>.ListChangedTypeDeleting)), index));
            bool ret;
            ret = this.BaseList.Remove(emailAddress);
            this.OnCollectionChanged(new CodeFluent.Runtime.Utilities.IndexedCollectionChangeEventArgs(System.ComponentModel.CollectionChangeAction.Remove, emailAddress, index));
            this.OnListChanged(new System.ComponentModel.ListChangedEventArgs(System.ComponentModel.ListChangedType.ItemDeleted, index));
            return ret;
        }
        
        void System.Collections.IList.Remove(object value)
        {
            CodeFluentEntities.Bencher.Person.EmailAddress emailAddress;
			emailAddress = value as CodeFluentEntities.Bencher.Person.EmailAddress;
            this.Remove(emailAddress);
        }
        
        public virtual void RemoveAt(int index)
        {
            this.OnListChanged(new System.ComponentModel.ListChangedEventArgs(((System.ComponentModel.ListChangedType)(CodeFluent.Runtime.Utilities.SortableBindingList<CodeFluentEntities.Bencher.Person.EmailAddress>.ListChangedTypeDeleting)), index));
            CodeFluentEntities.Bencher.Person.EmailAddress emailAddress = this.BaseList[index];
            this.BaseList.RemoveAt(index);
            this.OnCollectionChanged(new CodeFluent.Runtime.Utilities.IndexedCollectionChangeEventArgs(System.ComponentModel.CollectionChangeAction.Remove, emailAddress, index));
            this.OnListChanged(new System.ComponentModel.ListChangedEventArgs(System.ComponentModel.ListChangedType.ItemDeleted, index));
        }
        
        public virtual System.Collections.Generic.IEnumerator<CodeFluentEntities.Bencher.Person.EmailAddress> GetEnumerator()
        {
            System.Collections.Generic.IEnumerator<CodeFluentEntities.Bencher.Person.EmailAddress> e = this.BaseList.GetEnumerator();
            return e;
        }
        
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.BaseList.GetEnumerator();
        }
        
        public virtual void SaveAll()
        {
            int index;
            for (index = (this.Count - 1); (index >= 0); index = (index - 1))
            {
                CodeFluentEntities.Bencher.Person.EmailAddress emailAddress = this[index];
                emailAddress.Save();
                if ((emailAddress.EntityState == CodeFluent.Runtime.CodeFluentEntityState.Deleted))
                {
                    this.Remove(emailAddress);
                }
            }
        }
        
        private void LoadAll(int pageIndex, int pageSize, CodeFluent.Runtime.PageOptions pageOptions, System.Data.IDataReader reader)
        {
            if ((reader == null))
            {
                throw new System.ArgumentNullException("reader");
            }
            if ((pageIndex < 0))
            {
                pageIndex = 0;
            }
            if ((pageSize < 0))
            {
                if ((pageOptions != null))
                {
                    pageSize = pageOptions.DefaultPageSize;
                }
                else
                {
                    pageSize = int.MaxValue;
                }
            }
            this.BaseList.Clear();
            int count = 0;
            int readCount = 0;
            bool readerRead;
            for (readerRead = reader.Read(); ((readerRead == true) 
                        && ((count < this.MaxCount) 
                        && (count < pageSize))); readerRead = reader.Read())
            {
                readCount = (readCount + 1);
                if ((CodeFluent.Runtime.CodeFluentPersistence.CanAddEntity(pageIndex, pageSize, pageOptions, readCount) == true))
                {
                    CodeFluentEntities.Bencher.Person.EmailAddress emailAddress = new CodeFluentEntities.Bencher.Person.EmailAddress();
                    ((CodeFluent.Runtime.ICodeFluentEntity)(emailAddress)).ReadRecord(reader);
                    if ((this.BaseContains(emailAddress) == false))
                    {
                        this.BaseAdd(emailAddress);
                        count = (count + 1);
                    }
                    emailAddress.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
                }
            }
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public static CodeFluentEntities.Bencher.Person.EmailAddressCollection PageLoadAll(int pageIndex, int pageSize, CodeFluent.Runtime.PageOptions pageOptions)
        {
            if ((pageIndex < 0))
            {
                pageIndex = 0;
            }
            if ((pageSize < 0))
            {
                if ((pageOptions != null))
                {
                    pageSize = pageOptions.DefaultPageSize;
                }
                else
                {
                    pageSize = int.MaxValue;
                }
            }
            CodeFluentEntities.Bencher.Person.EmailAddressCollection ret = new CodeFluentEntities.Bencher.Person.EmailAddressCollection();
            System.Data.IDataReader reader = null;
            try
            {
                reader = CodeFluentEntities.Bencher.Person.EmailAddressCollection.PageDataLoadAll(pageOptions);
                if ((reader == null))
                {
                    return ret;
                }
                ret.LoadAll(pageIndex, pageSize, pageOptions, reader);
            }
            finally
            {
                if ((reader != null))
                {
                    reader.Dispose();
                }
                CodeFluent.Runtime.CodeFluentPersistence.CompleteCommand(CodeFluentEntities.Bencher.Constants.CodeFluentEntities_BencherStoreName);
            }
            return ret;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public static CodeFluentEntities.Bencher.Person.EmailAddressCollection LoadAll()
        {
            CodeFluentEntities.Bencher.Person.EmailAddressCollection ret = CodeFluentEntities.Bencher.Person.EmailAddressCollection.PageLoadAll(int.MinValue, int.MaxValue, null);
            return ret;
        }
        
        public static System.Data.IDataReader PageDataLoadAll(CodeFluent.Runtime.PageOptions pageOptions)
        {
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(CodeFluentEntities.Bencher.Constants.CodeFluentEntities_BencherStoreName).Persistence;
            persistence.CreateStoredProcedureCommand("Person", "EmailAddress", "LoadAll");
            if ((pageOptions != null))
            {
                System.Collections.IEnumerator enumerator = pageOptions.OrderByArguments.GetEnumerator();
                bool b;
                int index = 0;
                for (b = enumerator.MoveNext(); b; b = enumerator.MoveNext())
                {
                    CodeFluent.Runtime.OrderByArgument argument = ((CodeFluent.Runtime.OrderByArgument)(enumerator.Current));
                    persistence.AddParameter(string.Format("@_orderBy{0}", index), argument.Name);
                    persistence.AddParameter(string.Format("@_orderByDirection{0}", index), ((int)(argument.Direction)));
                    index = (index + 1);
                }
            }
            System.Data.IDataReader reader = CodeFluentContext.Get(CodeFluentEntities.Bencher.Constants.CodeFluentEntities_BencherStoreName).Persistence.ExecuteReader();
            return reader;
        }
        
        public static System.Data.IDataReader DataLoadAll()
        {
            System.Data.IDataReader reader = CodeFluentEntities.Bencher.Person.EmailAddressCollection.PageDataLoadAll(null);
            return reader;
        }
        
        protected virtual void BaseTrace(System.CodeDom.Compiler.IndentedTextWriter writer)
        {
            writer.Write("[");
            writer.Write(string.Concat("Count=", this.Count));
            writer.Write("]");
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
        
        public virtual void CopyTo(CodeFluentEntities.Bencher.Person.EmailAddressCollection collection, bool deep)
        {
            if ((typeof(System.ICloneable).IsAssignableFrom(typeof(CodeFluentEntities.Bencher.Person.EmailAddress)) == false))
            {
                deep = false;
            }
            System.Collections.Generic.IEnumerator<CodeFluentEntities.Bencher.Person.EmailAddress> enumerator = this.GetEnumerator();
            bool b;
            for (b = enumerator.MoveNext(); b; b = enumerator.MoveNext())
            {
                if ((deep == true))
                {
                    collection.Add(((CodeFluentEntities.Bencher.Person.EmailAddress)(((System.ICloneable)(enumerator.Current)).Clone())));
                }
                else
                {
                    collection.Add(enumerator.Current);
                }
            }
        }
        
        public virtual CodeFluentEntities.Bencher.Person.EmailAddressCollection Clone(bool deep)
        {
            CodeFluentEntities.Bencher.Person.EmailAddressCollection ret = new CodeFluentEntities.Bencher.Person.EmailAddressCollection();
            this.CopyTo(ret, deep);
            return ret;
        }
        
        object System.ICloneable.Clone()
        {
            return this.Clone(true);
        }
        
        public virtual void CancelNew(int index)
        {
            if (((this._addNewPos >= 0) 
                        && (this._addNewPos == index)))
            {
                this.RemoveAt(index);
                this._addNewPos = -1;
            }
        }
        
        public virtual void EndNew(int index)
        {
            if (((this._addNewPos >= 0) 
                        && (this._addNewPos == index)))
            {
                this._addNewPos = -1;
            }
        }
        
        void System.ComponentModel.IBindingList.AddIndex(System.ComponentModel.PropertyDescriptor property)
        {
            this._blm1983009524.AddIndex(property);
        }
        
        protected virtual void OnAddingNew(System.ComponentModel.AddingNewEventArgs e)
        {
            if ((this.AddingNew != null))
            {
                this.AddingNew(this, e);
            }
        }
        
        object System.ComponentModel.IBindingList.AddNew()
        {
            CodeFluentEntities.Bencher.Person.EmailAddress add = new CodeFluentEntities.Bencher.Person.EmailAddress();
            System.ComponentModel.AddingNewEventArgs e = new System.ComponentModel.AddingNewEventArgs(add);
            this.OnAddingNew(e);
            add = ((CodeFluentEntities.Bencher.Person.EmailAddress)(e.NewObject));
            if ((add == null))
            {
                add = new CodeFluentEntities.Bencher.Person.EmailAddress();
            }
            this._addNewPos = this.Add(add);
            return add;
        }
        
        void System.ComponentModel.IBindingList.ApplySort(System.ComponentModel.PropertyDescriptor property, System.ComponentModel.ListSortDirection direction)
        {
            this._blm1983009524.ApplySort(property, direction);
        }
        
        int System.ComponentModel.IBindingList.Find(System.ComponentModel.PropertyDescriptor property, object key)
        {
            return this._blm1983009524.Find(property, key);
        }
        
        void System.ComponentModel.IBindingList.RemoveIndex(System.ComponentModel.PropertyDescriptor property)
        {
            this._blm1983009524.RemoveIndex(property);
        }
        
        void System.ComponentModel.IBindingList.RemoveSort()
        {
            this._blm1983009524.RemoveSort();
        }
        
        protected virtual void OnListChanged(System.ComponentModel.ListChangedEventArgs e)
        {
            if ((e == null))
            {
                throw new System.ArgumentNullException("e");
            }
            if ((this.RaiseListChangedEvents == false))
            {
                return;
            }
            if ((((e.ListChangedType == System.ComponentModel.ListChangedType.Reset) 
                        == false) 
                        && (e.NewIndex < 0)))
            {
                return;
            }
            if ((this.ListChanged != null))
            {
                this.ListChanged(this, e);
            }
        }
        
        public void AddRange(System.Collections.Generic.IEnumerable<CodeFluentEntities.Bencher.Person.EmailAddress> collection)
        {
            CodeFluent.Runtime.Utilities.ConvertUtilities.AddRange(this, collection);
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public static CodeFluentEntities.Bencher.Person.EmailAddressCollection PageLoadAll(int pageIndex, int pageSize)
        {
            return CodeFluentEntities.Bencher.Person.EmailAddressCollection.PageLoadAll(pageIndex, pageSize, null);
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, true)]
        public static bool Save(CodeFluentEntities.Bencher.Person.EmailAddress emailAddress)
        {
            if ((emailAddress == null))
            {
                return false;
            }
            bool ret = emailAddress.Save();
            return ret;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public static bool Insert(CodeFluentEntities.Bencher.Person.EmailAddress emailAddress)
        {
            bool ret = CodeFluentEntities.Bencher.Person.EmailAddress.Save(emailAddress);
            return ret;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public static bool Delete(CodeFluentEntities.Bencher.Person.EmailAddress emailAddress)
        {
            if ((emailAddress == null))
            {
                return false;
            }
            bool ret = emailAddress.Delete();
            return ret;
        }
    }
}
