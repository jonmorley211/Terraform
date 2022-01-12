using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualGatewaySpecBackendDefaults), fullyQualifiedName: "aws.appmesh.AppmeshVirtualGatewaySpecBackendDefaults")]
    public interface IAppmeshVirtualGatewaySpecBackendDefaults
    {
        /// <summary>client_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#client_policy AppmeshVirtualGateway#client_policy}
        /// </remarks>
        [JsiiProperty(name: "clientPolicy", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecBackendDefaultsClientPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualGatewaySpecBackendDefaultsClientPolicy? ClientPolicy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualGatewaySpecBackendDefaults), fullyQualifiedName: "aws.appmesh.AppmeshVirtualGatewaySpecBackendDefaults")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualGatewaySpecBackendDefaults
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>client_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#client_policy AppmeshVirtualGateway#client_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientPolicy", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecBackendDefaultsClientPolicy\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualGatewaySpecBackendDefaultsClientPolicy? ClientPolicy
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualGatewaySpecBackendDefaultsClientPolicy?>();
            }
        }
    }
}
