using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Home()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

    //    if (s3Event == null)
    //        {
    //            return null;
    //        }
    //        try
    //        {

    //            string filename = s3Event.Object.Key;

    //    string extension = Path.GetExtension(filename);
    //    string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filename);
    //    AmazonS3Client client = new AmazonS3Client(Amazon.RegionEndpoint.APSouth1);

    //    Console.WriteLine($"working");
             

    //            Console.WriteLine($"working");
    //            GetObjectRequest request = new GetObjectRequest
    //            {
    //                BucketName = s3Event.Bucket.Name,
    //                Key = s3Event.Object.Key
    //            };
    //    Console.WriteLine($"bucket name:{s3Event.Bucket.Name}");
    //            Console.WriteLine($"Key:{s3Event.Object.Key}");
    //            Console.WriteLine($"extension:{extension}");
         

    //            ISheet sheet;
    //    var countSheets = 0;
    //            using (var response = await client.GetObjectAsync(request))
    //            using (Stream responseStream = response.ResponseStream)
    //            using (MemoryStream memStream = new MemoryStream())
    //            {
    //                var contentType = response.Metadata["Content-Type"];
    //var clientid = response.Metadata["x-amz-meta-clientid"];
    //var assesseeId = response.Metadata["x-amz-meta-assesseeid"];
    //var loginGstn = response.Metadata["x-amz-meta-gstin"];
    //var loginMonthid = response.Metadata["x-amz-meta-monthid"];
    //var list = response.Metadata["x-amz-meta-list"];
    //var checklist = list.Split(",");
    //Console.WriteLine($"Actiual Check lIst:{list},");

    //                Console.WriteLine($"List:{checklist.Length},");
                    


    //                var del = await b2BContext.DeleteAllProgressByClientId(int.Parse(assesseeId));


    ////var extensions = response.Metadata["x-amz-meta-extension"];
    //var SheetName = "";
    //Console.WriteLine($"working.loginMonthid...{loginMonthid}, assesseeId: {assesseeId} ,loginGstn:{loginGstn}");
    //                DateTime? dt;

    //responseStream.CopyTo(memStream);
    //                memStream.Seek(0, SeekOrigin.Begin);


    }
}
