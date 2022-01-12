using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Storagegateway
{
    [JsiiInterface(nativeType: typeof(IStoragegatewayNfsFileShareCacheAttributes), fullyQualifiedName: "aws.storagegateway.StoragegatewayNfsFileShareCacheAttributes")]
    public interface IStoragegatewayNfsFileShareCacheAttributes
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_nfs_file_share#cache_stale_timeout_in_seconds StoragegatewayNfsFileShare#cache_stale_timeout_in_seconds}.</summary>
        [JsiiProperty(name: "cacheStaleTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CacheStaleTimeoutInSeconds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStoragegatewayNfsFileShareCacheAttributes), fullyQualifiedName: "aws.storagegateway.StoragegatewayNfsFileShareCacheAttributes")]
        internal sealed class _Proxy : DeputyBase, aws.Storagegateway.IStoragegatewayNfsFileShareCacheAttributes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_nfs_file_share#cache_stale_timeout_in_seconds StoragegatewayNfsFileShare#cache_stale_timeout_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cacheStaleTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CacheStaleTimeoutInSeconds
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
