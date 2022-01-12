using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Quicksight
{
    [JsiiByValue(fqn: "aws.quicksight.QuicksightDataSourceCredentials")]
    public class QuicksightDataSourceCredentials : aws.Quicksight.IQuicksightDataSourceCredentials
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#copy_source_arn QuicksightDataSource#copy_source_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "copySourceArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CopySourceArn
        {
            get;
            set;
        }

        /// <summary>credential_pair block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#credential_pair QuicksightDataSource#credential_pair}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "credentialPair", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceCredentialsCredentialPair\"}", isOptional: true, isOverride: true)]
        public aws.Quicksight.IQuicksightDataSourceCredentialsCredentialPair? CredentialPair
        {
            get;
            set;
        }
    }
}
