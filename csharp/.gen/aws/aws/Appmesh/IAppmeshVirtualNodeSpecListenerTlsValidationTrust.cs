using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualNodeSpecListenerTlsValidationTrust), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecListenerTlsValidationTrust")]
    public interface IAppmeshVirtualNodeSpecListenerTlsValidationTrust
    {
        /// <summary>file block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#file AppmeshVirtualNode#file}
        /// </remarks>
        [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTlsValidationTrustFile\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualNodeSpecListenerTlsValidationTrustFile? File
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
        [JsiiProperty(name: "sds", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTlsValidationTrustSds\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualNodeSpecListenerTlsValidationTrustSds? Sds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualNodeSpecListenerTlsValidationTrust), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecListenerTlsValidationTrust")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualNodeSpecListenerTlsValidationTrust
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>file block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#file AppmeshVirtualNode#file}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTlsValidationTrustFile\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualNodeSpecListenerTlsValidationTrustFile? File
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerTlsValidationTrustFile?>();
            }

            /// <summary>sds block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#sds AppmeshVirtualNode#sds}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sds", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTlsValidationTrustSds\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualNodeSpecListenerTlsValidationTrustSds? Sds
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerTlsValidationTrustSds?>();
            }
        }
    }
}
