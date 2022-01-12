using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiByValue(fqn: "aws.appmesh.AppmeshVirtualGatewaySpecListenerConnectionPool")]
    public class AppmeshVirtualGatewaySpecListenerConnectionPool : aws.Appmesh.IAppmeshVirtualGatewaySpecListenerConnectionPool
    {
        /// <summary>grpc block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#grpc AppmeshVirtualGateway#grpc}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "grpc", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerConnectionPoolGrpc\"}", isOptional: true, isOverride: true)]
        public aws.Appmesh.IAppmeshVirtualGatewaySpecListenerConnectionPoolGrpc? Grpc
        {
            get;
            set;
        }

        /// <summary>http block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#http AppmeshVirtualGateway#http}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "http", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerConnectionPoolHttp\"}", isOptional: true, isOverride: true)]
        public aws.Appmesh.IAppmeshVirtualGatewaySpecListenerConnectionPoolHttp? Http
        {
            get;
            set;
        }

        /// <summary>http2 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#http2 AppmeshVirtualGateway#http2}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "http2", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerConnectionPoolHttp2\"}", isOptional: true, isOverride: true)]
        public aws.Appmesh.IAppmeshVirtualGatewaySpecListenerConnectionPoolHttp2? Http2
        {
            get;
            set;
        }
    }
}
