using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appstream
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appstream.AppstreamDirectoryConfigServiceAccountCredentials")]
    public class AppstreamDirectoryConfigServiceAccountCredentials : aws.Appstream.IAppstreamDirectoryConfigServiceAccountCredentials
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appstream_directory_config#account_name AppstreamDirectoryConfig#account_name}.</summary>
        [JsiiProperty(name: "accountName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string AccountName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appstream_directory_config#account_password AppstreamDirectoryConfig#account_password}.</summary>
        [JsiiProperty(name: "accountPassword", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string AccountPassword
        {
            get;
            set;
        }
    }
}
