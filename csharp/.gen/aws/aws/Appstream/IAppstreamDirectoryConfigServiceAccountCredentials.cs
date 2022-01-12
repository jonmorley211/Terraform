using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appstream
{
    [JsiiInterface(nativeType: typeof(IAppstreamDirectoryConfigServiceAccountCredentials), fullyQualifiedName: "aws.appstream.AppstreamDirectoryConfigServiceAccountCredentials")]
    public interface IAppstreamDirectoryConfigServiceAccountCredentials
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appstream_directory_config#account_name AppstreamDirectoryConfig#account_name}.</summary>
        [JsiiProperty(name: "accountName", typeJson: "{\"primitive\":\"string\"}")]
        string AccountName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appstream_directory_config#account_password AppstreamDirectoryConfig#account_password}.</summary>
        [JsiiProperty(name: "accountPassword", typeJson: "{\"primitive\":\"string\"}")]
        string AccountPassword
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppstreamDirectoryConfigServiceAccountCredentials), fullyQualifiedName: "aws.appstream.AppstreamDirectoryConfigServiceAccountCredentials")]
        internal sealed class _Proxy : DeputyBase, aws.Appstream.IAppstreamDirectoryConfigServiceAccountCredentials
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appstream_directory_config#account_name AppstreamDirectoryConfig#account_name}.</summary>
            [JsiiProperty(name: "accountName", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appstream_directory_config#account_password AppstreamDirectoryConfig#account_password}.</summary>
            [JsiiProperty(name: "accountPassword", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountPassword
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
