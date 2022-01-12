using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Synthetics
{
    [JsiiClass(nativeType: typeof(aws.Synthetics.SyntheticsCanaryArtifactConfigOutputReference), fullyQualifiedName: "aws.synthetics.SyntheticsCanaryArtifactConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class SyntheticsCanaryArtifactConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public SyntheticsCanaryArtifactConfigOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SyntheticsCanaryArtifactConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SyntheticsCanaryArtifactConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putS3Encryption", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.synthetics.SyntheticsCanaryArtifactConfigS3Encryption\"}}]")]
        public virtual void PutS3Encryption(aws.Synthetics.ISyntheticsCanaryArtifactConfigS3Encryption @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Synthetics.ISyntheticsCanaryArtifactConfigS3Encryption)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetS3Encryption")]
        public virtual void ResetS3Encryption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "s3Encryption", typeJson: "{\"fqn\":\"aws.synthetics.SyntheticsCanaryArtifactConfigS3EncryptionOutputReference\"}")]
        public virtual aws.Synthetics.SyntheticsCanaryArtifactConfigS3EncryptionOutputReference S3Encryption
        {
            get => GetInstanceProperty<aws.Synthetics.SyntheticsCanaryArtifactConfigS3EncryptionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3EncryptionInput", typeJson: "{\"fqn\":\"aws.synthetics.SyntheticsCanaryArtifactConfigS3Encryption\"}", isOptional: true)]
        public virtual aws.Synthetics.ISyntheticsCanaryArtifactConfigS3Encryption? S3EncryptionInput
        {
            get => GetInstanceProperty<aws.Synthetics.ISyntheticsCanaryArtifactConfigS3Encryption?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.synthetics.SyntheticsCanaryArtifactConfig\"}", isOptional: true)]
        public virtual aws.Synthetics.ISyntheticsCanaryArtifactConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Synthetics.ISyntheticsCanaryArtifactConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
