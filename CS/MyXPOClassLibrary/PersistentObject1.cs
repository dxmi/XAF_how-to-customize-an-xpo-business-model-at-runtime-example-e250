using System;
using DevExpress.Xpo;

namespace MyXPOClassLibrary {

    public class PersistentObject1 : XPObject {
        //public PersistentObject1()
        //    : base() {
        //    // This constructor is used when an object is loaded from a persistent storage.
        //    // Do not place any code here.
        //}

        public PersistentObject1(Session session)
            : base(session) {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public override void AfterConstruction() {
            base.AfterConstruction();
            // Place here your initialization code.
        }
        private string _stringPropertyName;
        public string StringPropertyName {
            get { return _stringPropertyName; }
            set { SetPropertyValue("StringPropertyName", ref _stringPropertyName, value); }
        }
        private int _intPropertyName;
        public int IntPropertyName {
            get { return _intPropertyName; }
            set { SetPropertyValue("IntPropertyName", ref _intPropertyName, value); }
        }
    }
}