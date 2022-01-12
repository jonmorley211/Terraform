using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiByValue(fqn: "aws.appmesh.AppmeshVirtualGatewaySpecBackendDefaults")]
    public class AppmeshVirtualGatewaySpecBackendDefaults : aws.Appmesh.IAppmeshVirtualGatewaySpecBackendDefaults
    {
        /// <summary>client_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#client_policy AppmeshVirtualGateway#client_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientPolicy", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecBackendDefaultsClientPolicy\"}", isOptional: true, isOverride: true)]
        public aws.Appmesh.IAppmeshVirtualGatewaySpecBackendDefaultsClientPolicy? ClientPolicy
        {
            get;
            set;
        }
    }
}
