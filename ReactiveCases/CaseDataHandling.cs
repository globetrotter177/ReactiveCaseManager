using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ReactiveCases
{

    // HINWEIS: Für den generierten Code ist möglicherweise mindestens .NET Framework 4.5 oder .NET Core/Standard 2.0 erforderlich.
    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]

    public class CaseDataHandling
    {

        //private CasesCase[] caseField;

        /// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute("Case")]
        //public CasesCase[] Case
        //{
        //    get
        //    {
        //        return this.caseField;
        //    }
        //    set
        //    {
        //        this.caseField = value;
        //    }
        //}

    ///// <remarks/>
    //[System.SerializableAttribute()]
    //[DesignerCategoryAttribute("code")]
    //[XmlTypeAttribute(AnonymousType = true)]
    //public partial class CasesCase
    //{

        private int IdField;

        private DateTime DateField;

        private DateTime StartField;

        private DateTime EndField;

        private TimeSpan DurationField;

        private string stationField;

        private string jigField;

        private string deviceField;

        private string subjectField;

        private string subjectAreaField;

        private string initialSituationField;

        private string troubleShootingField;

        private string rootCauseField;

        private bool BASCaseField;

        private string BASCaseNumberField;

        private string caseStatusField;

        private string commentField;

        private string furtherActionField;

        private string gKNContactField;

        private bool coveredByContractField;

        private DateTime DateCreatedField;

        private bool followUpField;

        private DateTime fDateField;

        /// <remarks/>
        [XmlElementAttribute("ID.")]
        public int ID
        {
            get
            {
                return IdField;
            }
            set
            {
                IdField = value;
            }
        }

        /// <remarks/>
        public DateTime Date
        {
            get
            {
                return DateField;
            }
            set
            {
                DateField = value;
            }
        }

        /// <remarks/>
        public DateTime Start
        {
            get
            {
                return StartField;
            }
            set
            {
                StartField = value;
            }
        }

        /// <remarks/>
        public DateTime End
        {
            get
            {
                return EndField;
            }
            set
            {
                EndField = value;
            }
        }

        /// <remarks/>
        public TimeSpan Duration
        {
            get
            {
                return DurationField;
            }
            set
            {
                DurationField = value;
            }
        }

        /// <remarks/>
        public string Station
        {
            get
            {
                return stationField;
            }
            set
            {
                stationField = value;
            }
        }

        /// <remarks/>
        public string Jig
        {
            get
            {
                return this.jigField;
            }
            set
            {
                jigField = value;
            }
        }

        /// <remarks/>
        public string Device
        {
            get
            {
                return deviceField;
            }
            set
            {
                deviceField = value;
            }
        }

        /// <remarks/>
        public string Subject
        {
            get
            {
                return subjectField;
            }
            set
            {
                subjectField = value;
            }
        }

        /// <remarks/>
        public string SubjectArea
        {
            get
            {
                return subjectAreaField;
            }
            set
            {
                subjectAreaField = value;
            }
        }

        /// <remarks/>
        public string InitialSituation
        {
            get
            {
                return initialSituationField;
            }
            set
            {
                initialSituationField = value;
            }
        }

        /// <remarks/>
        public string TroubleShooting
        {
            get
            {
                return troubleShootingField;
            }
            set
            {
                troubleShootingField = value;
            }
        }

        /// <remarks/>
        public string RootCause
        {
            get
            {
                return rootCauseField;
            }
            set
            {
                rootCauseField = value;
            }
        }

        /// <remarks/>
        public bool BASCase
        {
            get
            {
                return BASCaseField;
            }
            set
            {
                BASCaseField = value;
            }
        }

        /// <remarks/>
        public string BASCaseNumber
        {
            get
            {
                return BASCaseNumberField;
            }
            set
            {
                BASCaseNumberField = value;
            }
        }

        /// <remarks/>
        public string CaseStatus
        {
            get
            {
                return caseStatusField;
            }
            set
            {
                caseStatusField = value;
            }
        }

        /// <remarks/>
        public string Comment
        {
            get
            {
                return commentField;
            }
            set
            {
                commentField = value;
            }
        }

        /// <remarks/>
        public string FurtherAction
        {
            get
            {
                return furtherActionField;
            }
            set
            {
                furtherActionField = value;
            }
        }

        /// <remarks/>
        public string GKNContact
        {
            get
            {
                return gKNContactField;
            }
            set
            {
                gKNContactField = value;
            }
        }

        /// <remarks/>
        public bool CoveredByContract
        {
            get
            {
                return coveredByContractField;
            }
            set
            {
                coveredByContractField = value;
            }
        }

        /// <remarks/>
        [XmlElement("Created")]
        public DateTime DateCaseCreated

        {
            get
            {
                return DateCreatedField;
            }
            set
            {
                DateCreatedField = value;
            }
        }

        /// <remarks/>
        [XmlElement("Follow-Up")]
        public bool FollowUp
        {
            get
            {
                return followUpField;
            }
            set
            {
                followUpField = value;
            }
        }

        /// <remarks/>
        [XmlElement("F-Date")]
        public DateTime FDate
        {
            get
            {
                return fDateField;
            }
            set
            {
                fDateField = value;
            }
        }
    }

    /// <remarks/>
    //[SerializableAttribute()]
    //[DesignerCategoryAttribute("code")]
    //[XmlType(AnonymousType = true)]

    /*public partial class CasesCaseCreated
    {

        private object changedField;

        /// <remarks/>
        public object Changed
        {
            get
            {
                return this.changedField;
            }
            set
            {
                this.changedField = value;
            }
        }
    }
        */


}
