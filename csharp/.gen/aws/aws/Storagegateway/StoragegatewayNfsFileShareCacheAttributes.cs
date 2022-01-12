using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Storagegateway
{
    [JsiiByValue(fqn: "aws.storagegateway.StoragegatewayNfsFileShareCacheAttributes")]
    public class StoragegatewayNfsFileShareCacheAttributes : aws.Storagegateway.IStoragegatewayNfsFileShareCacheAttributes
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_nfs_file_share#cache_stale_timeout_in_seconds StoragegatewayNfsFileShare#cache_stale_timeout_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cacheStaleTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? CacheStaleTimeoutInSeconds
        {
            get;
            set;
        }
    }
}
