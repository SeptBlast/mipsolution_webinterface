// 	File Name : PostData.cs
// 	Auther Name : Devesh Kumar
// 	Auther EmailId : deveshkumarsep12@outlook.com
// 	Date : 09-05-2020
//
using System;
namespace mip_solutions.Models
{
    public class PostData
    {
        public double accountId { get; set; }
        public string labelId { get; set; }
        public string operationName { get; set; }
        public string userIdentity { get; internal set; }
        public string inputFilePath { get; set; }
        public string outputFilePath { get; set; }
    }
}
