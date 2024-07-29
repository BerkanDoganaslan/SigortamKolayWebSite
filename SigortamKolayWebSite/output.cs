using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SigortamKolayWebSite
{
    public class output
    {
        private long _policyNumber;
        private string _productNo;
        private string _productName;
        private string _policyBeginDate;
        private string _policyEndDate;
        private string _insurancefirmName;
        private string _clause;
        private double _totalPremiumAmount;
        public long policyNumber
        {
            get
            {
                return this._policyNumber;
            }
            set
            {
                this._policyNumber = value;
            }
        }
        public string productNo
        {
            get
            {
                return this._productNo;
            }
            set
            {
                this._productNo = value;
            }
        }
        public string productName
        {
            get
            {
                return this._productName;
            }
            set
            {
                this._productName = value;
            }
        }
        public string policyBeginDate
        {
            get
            {
                return this._policyBeginDate;
            }
            set
            {
                this._policyBeginDate = value;
            }
        }
        public string policyEndDate
        {
            get
            {
                return this._policyEndDate;
            }
            set
            {
                this._policyEndDate = value;
            }
        }
        public string insurancefirmName
        {
            get
            {
                return this._insurancefirmName;
            }
            set
            {
                this._insurancefirmName = value;
            }
        }
        public string clause
        {
            get
            {
                return this._clause;
            }
            set
            {
                this._clause = value;
            }
        }
        public double totalPremiumAmount
        {
            get
            {
                return this._totalPremiumAmount;
            }
            set
            {
                this._totalPremiumAmount = value;
            }
        }
        //public string productNo;
        //public string productName;
        //public string policyBeginDate;
        //public string policyEndDate;
        //public string insurancefirmName;
        //public string clause;
        //public double totalPremiumAmount;
        public List<outputList> outList;
    }

    public class outputList
    {
        public long _policyNumber;
        public int _coverCode;
        public string _coverName;
        public double _coverAmount;
        public double _premiumAmount;
        public long policyNumber
        {
            get
            {
                return this._policyNumber;
            }
            set
            {
                this._policyNumber = value;
            }
        }
        public int coverCode
        {
            get
            {
                return this._coverCode;
            }
            set
            {
                this._coverCode = value;
            }
        }
        public string  coverName
        {
            get
            {
                return this._coverName;
            }
            set
            {
                this._coverName = value;
            }
        }
        public double coverAmount
        {
            get
            {
                return this._coverAmount;
            }
            set
            {
                this._coverAmount = value;
            }
        }
        public double premiumAmount
        {
            get
            {
                return this._premiumAmount;
            }
            set
            {
                this._premiumAmount = value;
            }
        }
        //public long policyNumber;
        //public int coverCode;
        //public string coverName;
        //public double coverAmount;
        //public double premiumAmount;
    }
}