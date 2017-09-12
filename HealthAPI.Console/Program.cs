using System;
using System.Configuration;
using System.IO;
using HealthAPI.Lib;
using HealthAPI.Console.Helper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using DeepStreamHubCSharp.Auth;

namespace HealthAPI.Console
{
    public class Program
    {
        private static string recordName = "healthapi/123/bmi";
        private static string bmiPath = "bmi";

        static void Main(string[] args)
        {
            var path = Path.Combine(Environment.CurrentDirectory, "Json");
            string bmiSampleContent = File.ReadAllText(path + "\\BMI.json");

            var auth = new DeepstreamAuth();
            var authUrl = ConfigurationManager.AppSettings["ApplicationAuthUrl"].ToString();
            var cRUDUrl = ConfigurationManager.AppSettings["ApplicationCRUDUrl"].ToString();
            var emailAddress = ConfigurationManager.AppSettings["EmailAddress"].ToString();
            var password = ConfigurationManager.AppSettings["Password"].ToString();

            var authResponse = auth.Authenticate(
               authUrl, new AuthRequest
               {
                   type = "email",
                   email = emailAddress,
                   password = password
               });

            // Deepstream Record Write - BMI 
            var deepStreamHelper = new DeepstreamHelper();
            var bmiRecordWriteResponse =
                deepStreamHelper.RecordWrite(authResponse.token,
                cRUDUrl,
                JObject.Parse(bmiSampleContent),
                bmiPath,
                recordName);

            // Deepstream Record Read - BMI 
            var bmiRecordReadResponse = deepStreamHelper.RecordRead(
                    authResponse.token,
                    cRUDUrl,
                    recordName);

            if(bmiRecordReadResponse.result == "SUCCESS")
            {
                System.Console.WriteLine(bmiRecordReadResponse.body[0].data);
            }

            System.Console.ReadLine();
        }
    }
}
