using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualNodeSpecListener), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecListener")]
    public interface IAppmeshVirtualNodeSpecListener
    {
        /// <summary>port_mapping block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#port_mapping AppmeshVirtualNode#port_mapping}
        /// </remarks>
        [JsiiProperty(name: "portMapping", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerPortMapping\"}")]
        aws.Appmesh.IAppmeshVirtualNodeSpecListenerPortMapping PortMapping
        {
            get;
        }

        /// <summary>connection_pool block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#connection_pool AppmeshVirtualNode#connection_pool}
        /// </remarks>
        [JsiiProperty(name: "connectionPool", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerConnectionPool\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPool? ConnectionPool
        {
            get
            {
                return null;
            }
        }

        /// <summary>health_check block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#health_check AppmeshVirtualNode#health_check}
        /// </remarks>
        [JsiiProperty(name: "healthCheck", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerHealthCheck\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualNodeSpecListenerHealthCheck? HealthCheck
        {
            get
            {
                return null;
            }
        }

        /// <summary>outlier_detection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#outlier_detection AppmeshVirtualNode#outlier_detection}
        /// </remarks>
        [JsiiProperty(name: "outlierDetection", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerOutlierDetection\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualNodeSpecListenerOutlierDetection? OutlierDetection
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeout block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#timeout AppmeshVirtualNode#timeout}
        /// </remarks>
        [JsiiProperty(name: "timeout", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeout\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeout? Timeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>tls block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#tls AppmeshVirtualNode#tls}
        /// </remarks>
        [JsiiProperty(name: "tls", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTls\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualNodeSpecListenerTls? Tls
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualNodeSpecListener), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecListener")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualNodeSpecListener
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>port_mapping block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#port_mapping AppmeshVirtualNode#port_mapping}
            /// </remarks>
            [JsiiProperty(name: "portMapping", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerPortMapping\"}")]
            public aws.Appmesh.IAppmeshVirtualNodeSpecListenerPortMapping PortMapping
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerPortMapping>()!;
            }

            /// <summary>connection_pool block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#connection_pool AppmeshVirtualNode#connection_pool}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connectionPool", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerConnectionPool\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPool? ConnectionPool
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPool?>();
            }

            /// <summary>health_check block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#health_check AppmeshVirtualNode#health_check}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "healthCheck", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerHealthCheck\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualNodeSpecListenerHealthCheck? HealthCheck
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerHealthCheck?>();
            }

            /// <summary>outlier_detection block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#outlier_detection AppmeshVirtualNode#outlier_detection}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "outlierDetection", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerOutlierDetection\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualNodeSpecListenerOutlierDetection? OutlierDetection
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerOutlierDetection?>();
            }

            /// <summary>timeout block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#timeout AppmeshVirtualNode#timeout}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeout", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeout\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeout? Timeout
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeout?>();
            }

            /// <summary>tls block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#tls AppmeshVirtualNode#tls}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tls", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTls\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualNodeSpecListenerTls? Tls
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerTls?>();
            }
        }
    }
}
