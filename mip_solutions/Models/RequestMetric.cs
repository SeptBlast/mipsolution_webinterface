// 	File Name : RequestMetric.cs
// 	Auther Name : Devesh Kumar
// 	Auther EmailId : deveshkumarsep12@outlook.com
// 	Date : 09-05-2020
//
using System;
namespace mip_solutions.Models
{
    public class RequestMetric
    {
        public string UniqueId { get; set; }
        public string Method { get; set; }
        public string UrlString { get; set; }
        public string Headers { get; set; }
        public int ResponseCode { get; set; }
        public string ClientIp { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public override string ToString()
        {
            return string.Format("{{ \"request_method\" : \"{0}\", \"request_url\" : \"{1}\", \"client_ip\" : \"{2}\", \"response_code\" : \"{3}\", \"processing_time_secs\" : \"{4}\", \"start_time\" : \"{5}\", \"end_time\" : \"{6}\", \"request_headers\" : \"{7}\" }}", Method, UrlString, ClientIp, ResponseCode, (EndTime - StartTime).TotalSeconds, StartTime.ToString("yyyy-MM-ddTHH:mm:ss.fffZ"), EndTime.ToString("yyyy-MM-ddTHH:mm:ss.fffZ"), Headers);
        }
    }
}
