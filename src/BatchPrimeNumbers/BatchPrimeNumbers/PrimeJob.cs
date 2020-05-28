using Microsoft.Azure.Batch;
using Microsoft.Azure.Batch.Auth;
using System;
using System.Collections.Generic;
using System.Text;

namespace BatchPrimeNumbers
{
    public class PrimeJob
    {
        private const string BatchAccountName = "";
        private const string BatchAccountKey = "";
        private const string BatchAccountUrl = "";

        private const string PoolId = "";
        private const string JobId = "";

        public static void JobMain(string[] args)
        {
            BatchSharedKeyCredentials cred = new BatchSharedKeyCredentials(BatchAccountUrl, BatchAccountName, BatchAccountKey);
        }

        private static async System.Threading.Tasks.Task SubmitJobAsync(BatchClient batchClient)
        {
            CloudJob job = batchClient.JobOperations.CreateJob();
            job.Id = "DaCrookJobID";
            job.PoolInformation = new PoolInformation()
            {
                PoolId = "bRAM"
            };
        }
    }
}
