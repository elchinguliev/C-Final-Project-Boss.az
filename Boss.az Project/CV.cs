using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Boss.az_Project
{

    public class CV
    {
 

        public CV(string speciality, int school, int universitypoint, string skills, bool isdifferentdiploma, string companies,/*List<>string>languageskills*/ string languageskills, string linkedin, string github)
        {
            Speciality=speciality;
            School=school;
            Universitypoint=universitypoint;
            Skills=skills;
            Companies=companies;
            Languageskills =languageskills;
            //Languages =languageskills;
            LinkedinProfile=linkedin;
            GitLink=github;
            HonorsDiploma=isdifferentdiploma;
        }


        public string Speciality { get; set; }


        public int School { get; set; }


        public int Universitypoint { get; set; }

        public bool HonorsDiploma { get; set; }
        public string Skills { get; set; }

        public string Companies { get; set; }
        public string Languageskills { get; set; }
        public string LinkedinProfile { get; set; }
        public string GitLink { get; set; }

        public override string ToString()
        {
            return $"Speicality : {Speciality} \nSchool : {School} \nUniveristy point : {Universitypoint} \nSkills : {Skills} \nHonors Diploma True/False : {HonorsDiploma} \nCompanies : {Companies}  \nLanguage Skills : {Languageskills} \nLinkedin : {LinkedinProfile} \nGithub : {GitLink}";
        }




    }

}