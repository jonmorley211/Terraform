using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmesh.AppmeshVirtualGatewaySpecListenerTls")]
    public class AppmeshVirtualGatewaySpecListenerTls : aws.Appmesh.IAppmeshVirtualGatewaySpecListenerTls
    {
        /// <summary>certificate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#certificate AppmeshVirtualGateway#certificate}
        /// </remarks>
        [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerTlsCertificate\"}", isOverride: true)]
        public aws.Appmesh.IAppmeshVirtualGatewaySpecListenerTlsCertificate Certificate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#mode AppmeshVirtualGateway#mode}.</summary>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Mode
        {
            get;
            set;
        }

        /// <summary>validation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#validation AppmeshVirtualGateway#validation}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "validation", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerTlsValidation\"}", isOptional: true, isOverride: true)]
        public aws.Appmesh.IAppmeshVirtualGatewaySpecListenerTlsValidation? Validation
        {
            get;
            set;
        }
    }
}
