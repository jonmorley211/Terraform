using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Signer
{
    [JsiiClass(nativeType: typeof(aws.Signer.SignerSigningJobDestinationOutputReference), fullyQualifiedName: "aws.signer.SignerSigningJobDestinationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class SignerSigningJobDestinationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public SignerSigningJobDestinationOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SignerSigningJobDestinationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SignerSigningJobDestinationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putS3", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.signer.SignerSigningJobDestinationS3\"}}]")]
        public virtual void PutS3(aws.Signer.ISignerSigningJobDestinationS3 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Signer.ISignerSigningJobDestinationS3)}, new object[]{@value});
        }

        [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.signer.SignerSigningJobDestinationS3OutputReference\"}")]
        public virtual aws.Signer.SignerSigningJobDestinationS3OutputReference S3
        {
            get => GetInstanceProperty<aws.Signer.SignerSigningJobDestinationS3OutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3Input", typeJson: "{\"fqn\":\"aws.signer.SignerSigningJobDestinationS3\"}", isOptional: true)]
        public virtual aws.Signer.ISignerSigningJobDestinationS3? S3Input
        {
            get => GetInstanceProperty<aws.Signer.ISignerSigningJobDestinationS3?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.signer.SignerSigningJobDestination\"}", isOptional: true)]
        public virtual aws.Signer.ISignerSigningJobDestination? InternalValue
        {
            get => GetInstanceProperty<aws.Signer.ISignerSigningJobDestination?>();
            set => SetInstanceProperty(value);
        }
    }
}
