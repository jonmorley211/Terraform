using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiClass(nativeType: typeof(aws.Sagemaker.SagemakerDomainRetentionPolicyOutputReference), fullyQualifiedName: "aws.sagemaker.SagemakerDomainRetentionPolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class SagemakerDomainRetentionPolicyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public SagemakerDomainRetentionPolicyOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerDomainRetentionPolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerDomainRetentionPolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetHomeEfsFileSystem")]
        public virtual void ResetHomeEfsFileSystem()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "homeEfsFileSystemInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HomeEfsFileSystemInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "homeEfsFileSystem", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HomeEfsFileSystem
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerDomainRetentionPolicy\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerDomainRetentionPolicy? InternalValue
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerDomainRetentionPolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
