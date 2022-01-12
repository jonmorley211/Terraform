using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appstream
{
    [JsiiByValue(fqn: "aws.appstream.AppstreamFleetDomainJoinInfo")]
    public class AppstreamFleetDomainJoinInfo : aws.Appstream.IAppstreamFleetDomainJoinInfo
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appstream_fleet#directory_name AppstreamFleet#directory_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "directoryName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DirectoryName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appstream_fleet#organizational_unit_distinguished_name AppstreamFleet#organizational_unit_distinguished_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "organizationalUnitDistinguishedName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? OrganizationalUnitDistinguishedName
        {
            get;
            set;
        }
    }
}
