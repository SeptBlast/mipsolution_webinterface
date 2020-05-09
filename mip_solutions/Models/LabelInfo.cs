// 	File Name : LabelInfo.cs
// 	Auther Name : Devesh Kumar
// 	Auther EmailId : deveshkumarsep12@outlook.com
// 	Date : 09-05-2020
//
using System;
using System.Collections.Generic;

namespace mip_solutions.Models
{
    class LabelInfo
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public bool isActive { get; set; }
        public int sensitivity { get; set; }
        public string tooltip { get; set; }
        public List<ChildInfo> children { get; set; }
    }

    class ChildInfo
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public bool isActive { get; set; }
        public List<Info> parent { get; set; }
        public int sensitivity { get; set; }
        public string tooltip { get; set; }
    }

    class Info
    {
        public string name { get; set; }
        public string id { get; set; }
        public List<Info> parent { get; set; }
    }

    class NewLabel
    {
        public string appliedLabelId { get; set; }
        public string appliedLabelName { get; set; }
        public string status { get; set; }
        public string outputFilePath { get; set; }
        public bool IsProtectionAppliedFromLabel { get; set; }
    }

    class UserInfo
    {
        public string userEmail { get; set; }
    }
}
