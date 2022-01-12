using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiByValue(fqn: "aws.appmesh.AppmeshVirtualGatewaySpecLogging")]
    public class AppmeshVirtualGatewaySpecLogging : aws.Appmesh.IAppmeshVirtualGatewaySpecLogging
    {
        /// <summary>access_log block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#access_log AppmeshVirtualGateway#access_log}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accessLog", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecLoggingAccessLog\"}", isOptional: true, isOverride: true)]
        public aws.Appmesh.IAppmeshVirtualGatewaySpecLoggingAccessLog? AccessLog
        {
            get;
            set;
        }
    }
}
