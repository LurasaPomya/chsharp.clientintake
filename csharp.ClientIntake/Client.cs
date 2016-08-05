using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.ClientIntake
{
    [Serializable()]
    public class Client
    {

        // Client Information
        private string firstName;
        private string lastName;
        private string preferredName;
        private string age;
        private string preferredGender;
        private string schoolName;
        private string schoolGrade;
        private string allergies;

        // Parent or guardian information
        private string parentFirstName;
        private string parentLastName;
        private string parentRelation;
        private string parentAddress1;
        private string parentAddress2;
        private string parentCity;
        private string parentState;
        private string parentZipCode;
        private string parentPrimaryPhone;
        private string parentSecondaryPhone;
        private string parentEmail;

        // Emergency Contact Information
        private string emergencyName;
        private string emergencyRelation;
        private string emergencyPhone;

        // Groups interested in
        private bool groupSST; // South Seattle Tuesdays
        private bool groupGW; // Greenwood Wednesdays
        private bool groupKTH; // Kirkland Thursdays

        // Getting to know you stuff
        private string hobbies; // What activities, hobbies, or interests does your child enjoy?
        private string goals; // What are some goals you have for your child while enrolled with Wheelhouse Workshop?
        private string helps; // What helps your child if they feel frustrated or angry?
        private string challenges; // Does your child have any specific challenges you would like us to know about?
        private string additionalInformation; // Additional Information (If you would like to share any mental health or medical diagnosis or history; please feel free to do so here)

        
        



        // Now we have our getters and setters. Not going to document all these unless they are doing more than setting and getting values.
        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public string PreferredName
        {
            get
            {
                return preferredName;
            }

            set
            {
                preferredName = value;
            }
        }

        public string PreferredGender
        {
            get
            {
                return preferredGender;
            }

            set
            {
                preferredGender = value;
            }
        }

        public string SchoolName
        {
            get
            {
                return schoolName;
            }

            set
            {
                schoolName = value;
            }
        }

        public string SchoolGrade
        {
            get
            {
                return schoolGrade;
            }

            set
            {
                schoolGrade = value;
            }
        }

        public string Allergies
        {
            get
            {
                return allergies;
            }

            set
            {
                allergies = value;
            }
        }

        public string ParentFirstName
        {
            get
            {
                return parentFirstName;
            }

            set
            {
                parentFirstName = value;
            }
        }

        public string ParentLastName
        {
            get
            {
                return parentLastName;
            }

            set
            {
                parentLastName = value;
            }
        }

        public string ParentRelationship
        {
            get
            {
                return parentRelation;
            }

            set
            {
                parentRelation = value;
            }
        }

        public string ParentAddress1
        {
            get
            {
                return parentAddress1;
            }

            set
            {
                parentAddress1 = value;
            }
        }

        public string ParentCity
        {
            get
            {
                return parentCity;
            }

            set
            {
                parentCity = value;
            }
        }

        public string ParentState
        {
            get
            {
                return parentState;
            }

            set
            {
                parentState = value;
            }
        }

        public string ParentZipCode
        {
            get
            {
                return parentZipCode;
            }

            set
            {
                parentZipCode = value;
            }
        }

        public string ParentPrimaryPhone
        {
            get
            {
                return parentPrimaryPhone;
            }

            set
            {
                parentPrimaryPhone = value;
            }
        }

        public string ParentSecondaryPhone
        {
            get
            {
                return parentSecondaryPhone;
            }

            set
            {
                parentSecondaryPhone = value;
            }
        }

        public string ParentEmail
        {
            get
            {
                return parentEmail;
            }

            set
            {
                parentEmail = value;
            }
        }

        public string EmergencyName
        {
            get
            {
                return emergencyName;
            }

            set
            {
                emergencyName = value;
            }
        }

        public string EmergencyRelation
        {
            get
            {
                return emergencyRelation;
            }

            set
            {
                emergencyRelation = value;
            }
        }

        public string EmergencyPhone
        {
            get
            {
                return emergencyPhone;
            }

            set
            {
                emergencyPhone = value;
            }
        }

        public bool GroupSST
        {
            get
            {
                return groupSST;
            }

            set
            {
                groupSST = value;
            }
        }

        public bool GroupGW
        {
            get
            {
                return groupGW;
            }

            set
            {
                groupGW = value;
            }
        }

        public bool GroupKTH
        {
            get
            {
                return groupKTH;
            }

            set
            {
                groupKTH = value;
            }
        }

        public string Hobbies
        {
            get
            {
                return hobbies;
            }

            set
            {
                hobbies = value;
            }
        }

        public string Goals
        {
            get
            {
                return goals;
            }

            set
            {
                goals = value;
            }
        }

        public string Helps
        {
            get
            {
                return helps;
            }

            set
            {
                helps = value;
            }
        }

        public string Challenges
        {
            get
            {
                return challenges;
            }

            set
            {
                challenges = value;
            }
        }

        public string AdditionalInformation
        {
            get
            {
                return additionalInformation;
            }

            set
            {
                additionalInformation = value;
            }
        }

        public string ParentAddress2
        {
            get
            {
                return parentAddress2;
            }

            set
            {
                parentAddress2 = value;
            }
        }
    }
}
