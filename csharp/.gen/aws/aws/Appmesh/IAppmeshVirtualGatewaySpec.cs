using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualGatewaySpec), fullyQualifiedName: "aws.appmesh.AppmeshVirtualGatewaySpec")]
    public interface IAppmeshVirtualGatewaySpec
    {
        /// <summary>listener block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#listener AppmeshVirtualGateway#listener}
        /// </remarks>
        [JsiiProperty(name: "listener", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListener\"}")]
        aws.Appmesh.IAppmeshVirtualGatewaySpecListener Listener
        {
            get;
        }

        /// <summary>backend_defaults block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#backend_defaults AppmeshVirtualGateway#backend_defaults}
        /// </remarks>
        [JsiiProperty(name: "backendDefaults", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecBackendDefaults\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualGatewaySpecBackendDefaults? BackendDefaults
        {
            get
            {
                return null;
            }
        }

        /// <summary>logging block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#logging AppmeshVirtualGateway#logging}
        /// </remarks>
        [JsiiProperty(name: "logging", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecLogging\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualGatewaySpecLogging? Logging
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualGatewaySpec), fullyQualifiedName: "aws.appmesh.AppmeshVirtualGatewaySpec")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualGatewaySpec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>listener block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#listener AppmeshVirtualGateway#listener}
            /// </remarks>
            [JsiiProperty(name: "listener", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListener\"}")]
            public aws.Appmesh.IAppmeshVirtualGatewaySpecListener Listener
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualGatewaySpecListener>()!;
            }

            /// <summary>backend_defaults block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#backend_defaults AppmeshVirtualGateway#backend_defaults}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "backendDefaults", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecBackendDefaults\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualGatewaySpecBackendDefaults? BackendDefaults
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualGatewaySpecBackendDefaults?>();
            }

            /// <summary>logging block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#logging AppmeshVirtualGateway#logging}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logging", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecLogging\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualGatewaySpecLogging? Logging
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualGatewaySpecLogging?>();
            }
        }
    }
}
