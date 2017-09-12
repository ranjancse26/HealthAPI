using DeepStreamHubCSharp.Record.Entities;
using DeepStreamHubCSharp.Record.Write;
using Newtonsoft.Json.Linq;

namespace HealthAPI.Console.Helper
{
    public class DeepstreamHelper
    {
        public RecordReadResponse RecordRead(string token, 
            string authCRUDUrl,
            string recordName)
        {
            var recordRead = new DeepstreamRecordRead();
            var response = recordRead.Read(authCRUDUrl, new RecordReadRequest
            {
                token = token,
                body = new System.Collections.Generic.List<RecordReadBody>()
               {
                   new RecordReadBody
                   {
                       action = "read",
                       topic = "record",
                       recordName = recordName
                   }
               }
            });
            return response;
        }

        /// <summary>
        /// Token and HTTP Url is required.
        /// The version can be set to 0 if you want to always overwrite the data and not to worry about the explicity specifying the version numbers
        /// </summary>
        /// <param name="token">Token</param>
        /// <param name="authCRUDUrl">HTTP Url</param>
        /// <returns>RecordWriteResponse</returns>
        public RecordWriteResponse RecordWrite(
            string token,
            string authCRUDUrl,
            JObject data,
            string path,
            string recordName,
            int version = 0)
        {
            var recordWrite = new DeepstreamRecordWrite();
            var recordWriteBody = new System.Collections.Generic.List<RecordWriteBody>();

            recordWriteBody.Add(new RecordWriteBody
            {
                action = "write",
                topic = "record",
                path = path,
                recordName = recordName,
                version = version,
                data = data
            });

            var response = recordWrite.Write(authCRUDUrl,
                new RecordWriteRequest
                {
                    token = token,
                    body = recordWriteBody
                });

            return response;
        }

        public RecordDeleteResponse RecordDelete(string token,
                string authCRUDUrl,
                string recordName)
        {
            var recordRead = new DeepstreamRecordDelete();

            var response = recordRead.Delete(authCRUDUrl, new RecordDeleteRequest
            {
                token = token,
                body = new System.Collections.Generic.List<RecordDeleteBody>()
                   {
                       new RecordDeleteBody
                       {
                           action = "delete",
                           topic = "record",
                           recordName = recordName
                       }
                   }
            });

            return response;
        }
    }    
}
