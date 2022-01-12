using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Storagegateway
{
    [JsiiClass(nativeType: typeof(aws.Storagegateway.StoragegatewayNfsFileShareCacheAttributesOutputReference), fullyQualifiedName: "aws.storagegateway.StoragegatewayNfsFileShareCacheAttributesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class StoragegatewayNfsFileShareCacheAttributesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public StoragegatewayNfsFileShareCacheAttributesOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StoragegatewayNfsFileShareCacheAttributesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StoragegatewayNfsFileShareCacheAttributesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCacheStaleTimeoutInSeconds")]
        public virtual void ResetCacheStaleTimeoutInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "cacheStaleTimeoutInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? CacheStaleTimeoutInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "cacheStaleTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CacheStaleTimeoutInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.storagegateway.StoragegatewayNfsFileShareCacheAttributes\"}", isOptional: true)]
        public virtual aws.Storagegateway.IStoragegatewayNfsFileShareCacheAttributes? InternalValue
        {
            get => GetInstanceProperty<aws.Storagegateway.IStoragegatewayNfsFileShareCacheAttributes?>();
            set => SetInstanceProperty(value);
        }
    }
}
