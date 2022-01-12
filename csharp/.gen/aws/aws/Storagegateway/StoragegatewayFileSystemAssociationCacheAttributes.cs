using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Storagegateway
{
    [JsiiByValue(fqn: "aws.storagegateway.StoragegatewayFileSystemAssociationCacheAttributes")]
    public class StoragegatewayFileSystemAssociationCacheAttributes : aws.Storagegateway.IStoragegatewayFileSystemAssociationCacheAttributes
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_file_system_association#cache_stale_timeout_in_seconds StoragegatewayFileSystemAssociation#cache_stale_timeout_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cacheStaleTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? CacheStaleTimeoutInSeconds
        {
            get;
            set;
        }
    }
}
