using System;
using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;

namespace testsms
{
    class Program 
    {
        public static void Main(string[] args)
        {
            AmazonSimpleNotificationServiceClient snsClient = new AmazonSimpleNotificationServiceClient("AKIAJJCM72H7527TVKNA", "b+Dg4+7Ro5cDfiYs4YQCmkvaGCflXVDUHHcqg2co", Amazon.RegionEndpoint.USWest2);
            PublishRequest pubRequest = new PublishRequest();
            pubRequest.Message = "Your OTP is bla";
            pubRequest.PhoneNumber = "+917842553188";
            // add optional MessageAttributes, for example:
            pubRequest.MessageAttributes["AWS.SNS.SMS.SMSType"] = new MessageAttributeValue { StringValue = "Transactional", DataType = "String" };
            PublishResponse pubResponse = snsClient.PublishAsync(pubRequest).Result;
            Console.WriteLine(pubResponse.MessageId);
            Console.ReadLine();
        }


    }


}
