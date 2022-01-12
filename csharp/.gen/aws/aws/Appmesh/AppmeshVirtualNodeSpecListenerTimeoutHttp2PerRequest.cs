using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttp2PerRequest")]
    public class AppmeshVirtualNodeSpecListenerTimeoutHttp2PerRequest : aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutHttp2PerRequest
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#unit AppmeshVirtualNode#unit}.</summary>
        [JsiiProperty(name: "unit", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Unit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#value AppmeshVirtualNode#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double Value
        {
            get;
            set;
        }
    }
}
