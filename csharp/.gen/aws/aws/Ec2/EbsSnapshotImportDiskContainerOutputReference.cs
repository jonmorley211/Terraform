using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiClass(nativeType: typeof(aws.Ec2.EbsSnapshotImportDiskContainerOutputReference), fullyQualifiedName: "aws.ec2.EbsSnapshotImportDiskContainerOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class EbsSnapshotImportDiskContainerOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public EbsSnapshotImportDiskContainerOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EbsSnapshotImportDiskContainerOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EbsSnapshotImportDiskContainerOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putUserBucket", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ec2.EbsSnapshotImportDiskContainerUserBucket\"}}]")]
        public virtual void PutUserBucket(aws.Ec2.IEbsSnapshotImportDiskContainerUserBucket @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ec2.IEbsSnapshotImportDiskContainerUserBucket)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUrl")]
        public virtual void ResetUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserBucket")]
        public virtual void ResetUserBucket()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "userBucket", typeJson: "{\"fqn\":\"aws.ec2.EbsSnapshotImportDiskContainerUserBucketOutputReference\"}")]
        public virtual aws.Ec2.EbsSnapshotImportDiskContainerUserBucketOutputReference UserBucket
        {
            get => GetInstanceProperty<aws.Ec2.EbsSnapshotImportDiskContainerUserBucketOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "formatInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FormatInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "urlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userBucketInput", typeJson: "{\"fqn\":\"aws.ec2.EbsSnapshotImportDiskContainerUserBucket\"}", isOptional: true)]
        public virtual aws.Ec2.IEbsSnapshotImportDiskContainerUserBucket? UserBucketInput
        {
            get => GetInstanceProperty<aws.Ec2.IEbsSnapshotImportDiskContainerUserBucket?>();
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Format
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Url
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ec2.EbsSnapshotImportDiskContainer\"}", isOptional: true)]
        public virtual aws.Ec2.IEbsSnapshotImportDiskContainer? InternalValue
        {
            get => GetInstanceProperty<aws.Ec2.IEbsSnapshotImportDiskContainer?>();
            set => SetInstanceProperty(value);
        }
    }
}
