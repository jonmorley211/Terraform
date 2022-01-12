using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Quicksight
{
    [JsiiInterface(nativeType: typeof(IQuicksightDataSourceCredentials), fullyQualifiedName: "aws.quicksight.QuicksightDataSourceCredentials")]
    public interface IQuicksightDataSourceCredentials
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#copy_source_arn QuicksightDataSource#copy_source_arn}.</summary>
        [JsiiProperty(name: "copySourceArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CopySourceArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>credential_pair block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#credential_pair QuicksightDataSource#credential_pair}
        /// </remarks>
        [JsiiProperty(name: "credentialPair", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceCredentialsCredentialPair\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Quicksight.IQuicksightDataSourceCredentialsCredentialPair? CredentialPair
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightDataSourceCredentials), fullyQualifiedName: "aws.quicksight.QuicksightDataSourceCredentials")]
        internal sealed class _Proxy : DeputyBase, aws.Quicksight.IQuicksightDataSourceCredentials
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#copy_source_arn QuicksightDataSource#copy_source_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "copySourceArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CopySourceArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>credential_pair block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#credential_pair QuicksightDataSource#credential_pair}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "credentialPair", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceCredentialsCredentialPair\"}", isOptional: true)]
            public aws.Quicksight.IQuicksightDataSourceCredentialsCredentialPair? CredentialPair
            {
                get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceCredentialsCredentialPair?>();
            }
        }
    }
}
