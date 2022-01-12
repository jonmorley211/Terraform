using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appstream
{
    /// <summary>AppStream.</summary>
    [JsiiInterface(nativeType: typeof(IAppstreamDirectoryConfigConfig), fullyQualifiedName: "aws.appstream.AppstreamDirectoryConfigConfig")]
    public interface IAppstreamDirectoryConfigConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appstream_directory_config#directory_name AppstreamDirectoryConfig#directory_name}.</summary>
        [JsiiProperty(name: "directoryName", typeJson: "{\"primitive\":\"string\"}")]
        string DirectoryName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appstream_directory_config#organizational_unit_distinguished_names AppstreamDirectoryConfig#organizational_unit_distinguished_names}.</summary>
        [JsiiProperty(name: "organizationalUnitDistinguishedNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] OrganizationalUnitDistinguishedNames
        {
            get;
        }

        /// <summary>service_account_credentials block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appstream_directory_config#service_account_credentials AppstreamDirectoryConfig#service_account_credentials}
        /// </remarks>
        [JsiiProperty(name: "serviceAccountCredentials", typeJson: "{\"fqn\":\"aws.appstream.AppstreamDirectoryConfigServiceAccountCredentials\"}")]
        aws.Appstream.IAppstreamDirectoryConfigServiceAccountCredentials ServiceAccountCredentials
        {
            get;
        }

        /// <summary>AppStream.</summary>
        [JsiiTypeProxy(nativeType: typeof(IAppstreamDirectoryConfigConfig), fullyQualifiedName: "aws.appstream.AppstreamDirectoryConfigConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Appstream.IAppstreamDirectoryConfigConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appstream_directory_config#directory_name AppstreamDirectoryConfig#directory_name}.</summary>
            [JsiiProperty(name: "directoryName", typeJson: "{\"primitive\":\"string\"}")]
            public string DirectoryName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appstream_directory_config#organizational_unit_distinguished_names AppstreamDirectoryConfig#organizational_unit_distinguished_names}.</summary>
            [JsiiProperty(name: "organizationalUnitDistinguishedNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] OrganizationalUnitDistinguishedNames
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>service_account_credentials block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appstream_directory_config#service_account_credentials AppstreamDirectoryConfig#service_account_credentials}
            /// </remarks>
            [JsiiProperty(name: "serviceAccountCredentials", typeJson: "{\"fqn\":\"aws.appstream.AppstreamDirectoryConfigServiceAccountCredentials\"}")]
            public aws.Appstream.IAppstreamDirectoryConfigServiceAccountCredentials ServiceAccountCredentials
            {
                get => GetInstanceProperty<aws.Appstream.IAppstreamDirectoryConfigServiceAccountCredentials>()!;
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
