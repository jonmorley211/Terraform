using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualNodeSpec), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpec")]
    public interface IAppmeshVirtualNodeSpec
    {
        /// <summary>backend block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#backend AppmeshVirtualNode#backend}
        /// </remarks>
        [JsiiProperty(name: "backend", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackend\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualNodeSpecBackend[]? Backend
        {
            get
            {
                return null;
            }
        }

        /// <summary>backend_defaults block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#backend_defaults AppmeshVirtualNode#backend_defaults}
        /// </remarks>
        [JsiiProperty(name: "backendDefaults", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackendDefaults\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualNodeSpecBackendDefaults? BackendDefaults
        {
            get
            {
                return null;
            }
        }

        /// <summary>listener block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#listener AppmeshVirtualNode#listener}
        /// </remarks>
        [JsiiProperty(name: "listener", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListener\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualNodeSpecListener? Listener
        {
            get
            {
                return null;
            }
        }

        /// <summary>logging block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#logging AppmeshVirtualNode#logging}
        /// </remarks>
        [JsiiProperty(name: "logging", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecLogging\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualNodeSpecLogging? Logging
        {
            get
            {
                return null;
            }
        }

        /// <summary>service_discovery block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#service_discovery AppmeshVirtualNode#service_discovery}
        /// </remarks>
        [JsiiProperty(name: "serviceDiscovery", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecServiceDiscovery\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualNodeSpecServiceDiscovery? ServiceDiscovery
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualNodeSpec), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpec")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualNodeSpec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>backend block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#backend AppmeshVirtualNode#backend}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "backend", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackend\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualNodeSpecBackend[]? Backend
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecBackend[]?>();
            }

            /// <summary>backend_defaults block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#backend_defaults AppmeshVirtualNode#backend_defaults}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "backendDefaults", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackendDefaults\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualNodeSpecBackendDefaults? BackendDefaults
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecBackendDefaults?>();
            }

            /// <summary>listener block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#listener AppmeshVirtualNode#listener}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "listener", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListener\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualNodeSpecListener? Listener
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListener?>();
            }

            /// <summary>logging block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#logging AppmeshVirtualNode#logging}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logging", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecLogging\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualNodeSpecLogging? Logging
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecLogging?>();
            }

            /// <summary>service_discovery block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#service_discovery AppmeshVirtualNode#service_discovery}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serviceDiscovery", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecServiceDiscovery\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualNodeSpecServiceDiscovery? ServiceDiscovery
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecServiceDiscovery?>();
            }
        }
    }
}
