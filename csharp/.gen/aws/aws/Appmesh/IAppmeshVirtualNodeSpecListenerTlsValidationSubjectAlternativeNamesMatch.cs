using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualNodeSpecListenerTlsValidationSubjectAlternativeNamesMatch), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecListenerTlsValidationSubjectAlternativeNamesMatch")]
    public interface IAppmeshVirtualNodeSpecListenerTlsValidationSubjectAlternativeNamesMatch
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#exact AppmeshVirtualNode#exact}.</summary>
        [JsiiProperty(name: "exact", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Exact
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualNodeSpecListenerTlsValidationSubjectAlternativeNamesMatch), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecListenerTlsValidationSubjectAlternativeNamesMatch")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualNodeSpecListenerTlsValidationSubjectAlternativeNamesMatch
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#exact AppmeshVirtualNode#exact}.</summary>
            [JsiiProperty(name: "exact", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Exact
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
