using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsCertificateSds), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsCertificateSds")]
    public interface IAppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsCertificateSds
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#secret_name AppmeshVirtualNode#secret_name}.</summary>
        [JsiiProperty(name: "secretName", typeJson: "{\"primitive\":\"string\"}")]
        string SecretName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsCertificateSds), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsCertificateSds")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsCertificateSds
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#secret_name AppmeshVirtualNode#secret_name}.</summary>
            [JsiiProperty(name: "secretName", typeJson: "{\"primitive\":\"string\"}")]
            public string SecretName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
