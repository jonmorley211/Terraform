using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiClass(nativeType: typeof(aws.Sagemaker.SagemakerDomainDefaultUserSettingsSharingSettingsOutputReference), fullyQualifiedName: "aws.sagemaker.SagemakerDomainDefaultUserSettingsSharingSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class SagemakerDomainDefaultUserSettingsSharingSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public SagemakerDomainDefaultUserSettingsSharingSettingsOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerDomainDefaultUserSettingsSharingSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerDomainDefaultUserSettingsSharingSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetNotebookOutputOption")]
        public virtual void ResetNotebookOutputOption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3KmsKeyId")]
        public virtual void ResetS3KmsKeyId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3OutputPath")]
        public virtual void ResetS3OutputPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "notebookOutputOptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NotebookOutputOptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3KmsKeyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? S3KmsKeyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3OutputPathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? S3OutputPathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "notebookOutputOption", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NotebookOutputOption
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "s3KmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S3KmsKeyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "s3OutputPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S3OutputPath
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerDomainDefaultUserSettingsSharingSettings\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerDomainDefaultUserSettingsSharingSettings? InternalValue
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerDomainDefaultUserSettingsSharingSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
