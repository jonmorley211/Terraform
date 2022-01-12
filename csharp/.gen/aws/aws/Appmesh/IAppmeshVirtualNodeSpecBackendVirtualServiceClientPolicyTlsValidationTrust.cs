using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationTrust), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationTrust")]
    public interface IAppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationTrust
    {
        /// <summary>acm block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#acm AppmeshVirtualNode#acm}
        /// </remarks>
        [JsiiProperty(name: "acm", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationTrustAcm\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationTrustAcm? Acm
        {
            get
            {
                return null;
            }
        }

        /// <summary>file block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#file AppmeshVirtualNode#file}
        /// </remarks>
        [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationTrustFile\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationTrustFile? File
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
        [JsiiProperty(name: "sds", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationTrustSds\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationTrustSds? Sds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationTrust), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationTrust")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationTrust
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>acm block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#acm AppmeshVirtualNode#acm}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "acm", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationTrustAcm\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationTrustAcm? Acm
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationTrustAcm?>();
            }

            /// <summary>file block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#file AppmeshVirtualNode#file}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationTrustFile\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationTrustFile? File
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationTrustFile?>();
            }

            /// <summary>sds block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#sds AppmeshVirtualNode#sds}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sds", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationTrustSds\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationTrustSds? Sds
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationTrustSds?>();
            }
        }
    }
}
