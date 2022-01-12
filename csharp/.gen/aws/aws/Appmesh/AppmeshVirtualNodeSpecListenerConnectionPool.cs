using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiByValue(fqn: "aws.appmesh.AppmeshVirtualNodeSpecListenerConnectionPool")]
    public class AppmeshVirtualNodeSpecListenerConnectionPool : aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPool
    {
        /// <summary>grpc block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#grpc AppmeshVirtualNode#grpc}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "grpc", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerConnectionPoolGrpc\"}", isOptional: true, isOverride: true)]
        public aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPoolGrpc? Grpc
        {
            get;
            set;
        }

        /// <summary>http block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#http AppmeshVirtualNode#http}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "http", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerConnectionPoolHttp\"}", isOptional: true, isOverride: true)]
        public aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPoolHttp? Http
        {
            get;
            set;
        }

        /// <summary>http2 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#http2 AppmeshVirtualNode#http2}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "http2", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerConnectionPoolHttp2\"}", isOptional: true, isOverride: true)]
        public aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPoolHttp2? Http2
        {
            get;
            set;
        }

        /// <summary>tcp block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#tcp AppmeshVirtualNode#tcp}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tcp", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerConnectionPoolTcp\"}", isOptional: true, isOverride: true)]
        public aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPoolTcp? Tcp
        {
            get;
            set;
        }
    }
}
