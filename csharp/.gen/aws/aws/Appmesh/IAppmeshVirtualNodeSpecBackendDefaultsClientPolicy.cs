using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualNodeSpecBackendDefaultsClientPolicy), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecBackendDefaultsClientPolicy")]
    public interface IAppmeshVirtualNodeSpecBackendDefaultsClientPolicy
    {
        /// <summary>tls block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#tls AppmeshVirtualNode#tls}
        /// </remarks>
        [JsiiProperty(name: "tls", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackendDefaultsClientPolicyTls\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTls? Tls
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualNodeSpecBackendDefaultsClientPolicy), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecBackendDefaultsClientPolicy")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualNodeSpecBackendDefaultsClientPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>tls block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#tls AppmeshVirtualNode#tls}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tls", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackendDefaultsClientPolicyTls\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTls? Tls
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTls?>();
            }
        }
    }
}
