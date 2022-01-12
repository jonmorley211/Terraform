using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualGatewaySpecListener), fullyQualifiedName: "aws.appmesh.AppmeshVirtualGatewaySpecListener")]
    public interface IAppmeshVirtualGatewaySpecListener
    {
        /// <summary>port_mapping block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#port_mapping AppmeshVirtualGateway#port_mapping}
        /// </remarks>
        [JsiiProperty(name: "portMapping", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerPortMapping\"}")]
        aws.Appmesh.IAppmeshVirtualGatewaySpecListenerPortMapping PortMapping
        {
            get;
        }

        /// <summary>connection_pool block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#connection_pool AppmeshVirtualGateway#connection_pool}
        /// </remarks>
        [JsiiProperty(name: "connectionPool", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerConnectionPool\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualGatewaySpecListenerConnectionPool? ConnectionPool
        {
            get
            {
                return null;
            }
        }

        /// <summary>health_check block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#health_check AppmeshVirtualGateway#health_check}
        /// </remarks>
        [JsiiProperty(name: "healthCheck", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerHealthCheck\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualGatewaySpecListenerHealthCheck? HealthCheck
        {
            get
            {
                return null;
            }
        }

        /// <summary>tls block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#tls AppmeshVirtualGateway#tls}
        /// </remarks>
        [JsiiProperty(name: "tls", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerTls\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualGatewaySpecListenerTls? Tls
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualGatewaySpecListener), fullyQualifiedName: "aws.appmesh.AppmeshVirtualGatewaySpecListener")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualGatewaySpecListener
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>port_mapping block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#port_mapping AppmeshVirtualGateway#port_mapping}
            /// </remarks>
            [JsiiProperty(name: "portMapping", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerPortMapping\"}")]
            public aws.Appmesh.IAppmeshVirtualGatewaySpecListenerPortMapping PortMapping
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualGatewaySpecListenerPortMapping>()!;
            }

            /// <summary>connection_pool block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#connection_pool AppmeshVirtualGateway#connection_pool}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connectionPool", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerConnectionPool\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualGatewaySpecListenerConnectionPool? ConnectionPool
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualGatewaySpecListenerConnectionPool?>();
            }

            /// <summary>health_check block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#health_check AppmeshVirtualGateway#health_check}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "healthCheck", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerHealthCheck\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualGatewaySpecListenerHealthCheck? HealthCheck
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualGatewaySpecListenerHealthCheck?>();
            }

            /// <summary>tls block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#tls AppmeshVirtualGateway#tls}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tls", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerTls\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualGatewaySpecListenerTls? Tls
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualGatewaySpecListenerTls?>();
            }
        }
    }
}
