using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsCertificate), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsCertificate")]
    public interface IAppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsCertificate
    {
        /// <summary>file block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#file AppmeshVirtualNode#file}
        /// </remarks>
        [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsCertificateFile\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsCertificateFile? File
        {
            get
            {
                return null;
            }
        }

        /// <summary>sds block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#sds AppmeshVirtualNode#sds}
        /// </remarks>
        [JsiiProperty(name: "sds", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsCertificateSds\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsCertificateSds? Sds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsCertificate), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsCertificate")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsCertificate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>file block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#file AppmeshVirtualNode#file}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsCertificateFile\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsCertificateFile? File
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsCertificateFile?>();
            }

            /// <summary>sds block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#sds AppmeshVirtualNode#sds}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sds", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsCertificateSds\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsCertificateSds? Sds
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsCertificateSds?>();
            }
        }
    }
}
