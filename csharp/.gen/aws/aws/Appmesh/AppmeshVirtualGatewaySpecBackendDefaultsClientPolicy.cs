using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiByValue(fqn: "aws.appmesh.AppmeshVirtualGatewaySpecBackendDefaultsClientPolicy")]
    public class AppmeshVirtualGatewaySpecBackendDefaultsClientPolicy : aws.Appmesh.IAppmeshVirtualGatewaySpecBackendDefaultsClientPolicy
    {
        /// <summary>tls block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#tls AppmeshVirtualGateway#tls}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tls", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecBackendDefaultsClientPolicyTls\"}", isOptional: true, isOverride: true)]
        public aws.Appmesh.IAppmeshVirtualGatewaySpecBackendDefaultsClientPolicyTls? Tls
        {
            get;
            set;
        }
    }
}
