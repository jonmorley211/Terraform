using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appstream
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appstream.AppstreamStackStorageConnectors")]
    public class AppstreamStackStorageConnectors : aws.Appstream.IAppstreamStackStorageConnectors
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appstream_stack#connector_type AppstreamStack#connector_type}.</summary>
        [JsiiProperty(name: "connectorType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ConnectorType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appstream_stack#domains AppstreamStack#domains}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "domains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? Domains
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appstream_stack#resource_identifier AppstreamStack#resource_identifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ResourceIdentifier
        {
            get;
            set;
        }
    }
}
