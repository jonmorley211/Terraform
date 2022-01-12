using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Datasync
{
    [JsiiClass(nativeType: typeof(aws.Datasync.DatasyncLocationHdfsQopConfigurationOutputReference), fullyQualifiedName: "aws.datasync.DatasyncLocationHdfsQopConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DatasyncLocationHdfsQopConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public DatasyncLocationHdfsQopConfigurationOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatasyncLocationHdfsQopConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatasyncLocationHdfsQopConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDataTransferProtection")]
        public virtual void ResetDataTransferProtection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRpcProtection")]
        public virtual void ResetRpcProtection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataTransferProtectionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DataTransferProtectionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rpcProtectionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RpcProtectionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "dataTransferProtection", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataTransferProtection
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rpcProtection", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RpcProtection
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.datasync.DatasyncLocationHdfsQopConfiguration\"}", isOptional: true)]
        public virtual aws.Datasync.IDatasyncLocationHdfsQopConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.Datasync.IDatasyncLocationHdfsQopConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
