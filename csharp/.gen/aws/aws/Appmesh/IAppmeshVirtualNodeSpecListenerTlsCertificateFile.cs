using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualNodeSpecListenerTlsCertificateFile), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecListenerTlsCertificateFile")]
    public interface IAppmeshVirtualNodeSpecListenerTlsCertificateFile
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#certificate_chain AppmeshVirtualNode#certificate_chain}.</summary>
        [JsiiProperty(name: "certificateChain", typeJson: "{\"primitive\":\"string\"}")]
        string CertificateChain
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#private_key AppmeshVirtualNode#private_key}.</summary>
        [JsiiProperty(name: "privateKey", typeJson: "{\"primitive\":\"string\"}")]
        string PrivateKey
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualNodeSpecListenerTlsCertificateFile), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecListenerTlsCertificateFile")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualNodeSpecListenerTlsCertificateFile
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#certificate_chain AppmeshVirtualNode#certificate_chain}.</summary>
            [JsiiProperty(name: "certificateChain", typeJson: "{\"primitive\":\"string\"}")]
            public string CertificateChain
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#private_key AppmeshVirtualNode#private_key}.</summary>
            [JsiiProperty(name: "privateKey", typeJson: "{\"primitive\":\"string\"}")]
            public string PrivateKey
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
