using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Quicksight
{
    [JsiiClass(nativeType: typeof(aws.Quicksight.QuicksightDataSourceCredentialsOutputReference), fullyQualifiedName: "aws.quicksight.QuicksightDataSourceCredentialsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class QuicksightDataSourceCredentialsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public QuicksightDataSourceCredentialsOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected QuicksightDataSourceCredentialsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected QuicksightDataSourceCredentialsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCredentialPair", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksight.QuicksightDataSourceCredentialsCredentialPair\"}}]")]
        public virtual void PutCredentialPair(aws.Quicksight.IQuicksightDataSourceCredentialsCredentialPair @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Quicksight.IQuicksightDataSourceCredentialsCredentialPair)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCopySourceArn")]
        public virtual void ResetCopySourceArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCredentialPair")]
        public virtual void ResetCredentialPair()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "credentialPair", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceCredentialsCredentialPairOutputReference\"}")]
        public virtual aws.Quicksight.QuicksightDataSourceCredentialsCredentialPairOutputReference CredentialPair
        {
            get => GetInstanceProperty<aws.Quicksight.QuicksightDataSourceCredentialsCredentialPairOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "copySourceArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CopySourceArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "credentialPairInput", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceCredentialsCredentialPair\"}", isOptional: true)]
        public virtual aws.Quicksight.IQuicksightDataSourceCredentialsCredentialPair? CredentialPairInput
        {
            get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceCredentialsCredentialPair?>();
        }

        [JsiiProperty(name: "copySourceArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CopySourceArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceCredentials\"}", isOptional: true)]
        public virtual aws.Quicksight.IQuicksightDataSourceCredentials? InternalValue
        {
            get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceCredentials?>();
            set => SetInstanceProperty(value);
        }
    }
}
