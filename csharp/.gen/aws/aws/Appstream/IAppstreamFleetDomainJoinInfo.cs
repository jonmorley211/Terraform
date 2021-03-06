using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appstream
{
    [JsiiInterface(nativeType: typeof(IAppstreamFleetDomainJoinInfo), fullyQualifiedName: "aws.appstream.AppstreamFleetDomainJoinInfo")]
    public interface IAppstreamFleetDomainJoinInfo
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appstream_fleet#directory_name AppstreamFleet#directory_name}.</summary>
        [JsiiProperty(name: "directoryName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DirectoryName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appstream_fleet#organizational_unit_distinguished_name AppstreamFleet#organizational_unit_distinguished_name}.</summary>
        [JsiiProperty(name: "organizationalUnitDistinguishedName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OrganizationalUnitDistinguishedName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppstreamFleetDomainJoinInfo), fullyQualifiedName: "aws.appstream.AppstreamFleetDomainJoinInfo")]
        internal sealed class _Proxy : DeputyBase, aws.Appstream.IAppstreamFleetDomainJoinInfo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appstream_fleet#directory_name AppstreamFleet#directory_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "directoryName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DirectoryName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appstream_fleet#organizational_unit_distinguished_name AppstreamFleet#organizational_unit_distinguished_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "organizationalUnitDistinguishedName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OrganizationalUnitDistinguishedName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
