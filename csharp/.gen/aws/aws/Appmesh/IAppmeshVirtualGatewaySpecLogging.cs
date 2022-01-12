using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualGatewaySpecLogging), fullyQualifiedName: "aws.appmesh.AppmeshVirtualGatewaySpecLogging")]
    public interface IAppmeshVirtualGatewaySpecLogging
    {
        /// <summary>access_log block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#access_log AppmeshVirtualGateway#access_log}
        /// </remarks>
        [JsiiProperty(name: "accessLog", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecLoggingAccessLog\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualGatewaySpecLoggingAccessLog? AccessLog
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualGatewaySpecLogging), fullyQualifiedName: "aws.appmesh.AppmeshVirtualGatewaySpecLogging")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualGatewaySpecLogging
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>access_log block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#access_log AppmeshVirtualGateway#access_log}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accessLog", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecLoggingAccessLog\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualGatewaySpecLoggingAccessLog? AccessLog
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualGatewaySpecLoggingAccessLog?>();
            }
        }
    }
}
