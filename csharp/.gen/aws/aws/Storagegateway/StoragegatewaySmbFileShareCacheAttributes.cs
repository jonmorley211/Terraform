using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Storagegateway
{
    [JsiiByValue(fqn: "aws.storagegateway.StoragegatewaySmbFileShareCacheAttributes")]
    public class StoragegatewaySmbFileShareCacheAttributes : aws.Storagegateway.IStoragegatewaySmbFileShareCacheAttributes
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_smb_file_share#cache_stale_timeout_in_seconds StoragegatewaySmbFileShare#cache_stale_timeout_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cacheStaleTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? CacheStaleTimeoutInSeconds
        {
            get;
            set;
        }
    }
}
