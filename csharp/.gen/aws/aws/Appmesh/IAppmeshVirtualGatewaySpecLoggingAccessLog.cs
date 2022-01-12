using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualGatewaySpecLoggingAccessLog), fullyQualifiedName: "aws.appmesh.AppmeshVirtualGatewaySpecLoggingAccessLog")]
    public interface IAppmeshVirtualGatewaySpecLoggingAccessLog
    {
        /// <summary>file block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#file AppmeshVirtualGateway#file}
        /// </remarks>
        [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecLoggingAccessLogFile\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualGatewaySpecLoggingAccessLogFile? File
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualGatewaySpecLoggingAccessLog), fullyQualifiedName: "aws.appmesh.AppmeshVirtualGatewaySpecLoggingAccessLog")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualGatewaySpecLoggingAccessLog
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>file block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#file AppmeshVirtualGateway#file}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecLoggingAccessLogFile\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualGatewaySpecLoggingAccessLogFile? File
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualGatewaySpecLoggingAccessLogFile?>();
            }
        }
    }
}
