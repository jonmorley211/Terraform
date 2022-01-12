using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrust), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrust")]
    public interface IAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrust
    {
        /// <summary>acm block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#acm AppmeshVirtualNode#acm}
        /// </remarks>
        [JsiiProperty(name: "acm", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustAcm\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustAcm? Acm
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
        [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustFile\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustFile? File
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
        [JsiiProperty(name: "sds", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustSds\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustSds? Sds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrust), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrust")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrust
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>acm block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#acm AppmeshVirtualNode#acm}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "acm", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustAcm\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustAcm? Acm
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustAcm?>();
            }

            /// <summary>file block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#file AppmeshVirtualNode#file}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustFile\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustFile? File
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustFile?>();
            }

            /// <summary>sds block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#sds AppmeshVirtualNode#sds}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sds", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustSds\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustSds? Sds
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustSds?>();
            }
        }
    }
}
