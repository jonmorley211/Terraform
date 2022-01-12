using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appstream
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appstream.AppstreamImageBuilderAccessEndpoint")]
    public class AppstreamImageBuilderAccessEndpoint : aws.Appstream.IAppstreamImageBuilderAccessEndpoint
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appstream_image_builder#endpoint_type AppstreamImageBuilder#endpoint_type}.</summary>
        [JsiiProperty(name: "endpointType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string EndpointType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appstream_image_builder#vpce_id AppstreamImageBuilder#vpce_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vpceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? VpceId
        {
            get;
            set;
        }
    }
}
