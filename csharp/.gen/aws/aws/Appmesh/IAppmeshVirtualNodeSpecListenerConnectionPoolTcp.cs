using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualNodeSpecListenerConnectionPoolTcp), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecListenerConnectionPoolTcp")]
    public interface IAppmeshVirtualNodeSpecListenerConnectionPoolTcp
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#max_connections AppmeshVirtualNode#max_connections}.</summary>
        [JsiiProperty(name: "maxConnections", typeJson: "{\"primitive\":\"number\"}")]
        double MaxConnections
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualNodeSpecListenerConnectionPoolTcp), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecListenerConnectionPoolTcp")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPoolTcp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#max_connections AppmeshVirtualNode#max_connections}.</summary>
            [JsiiProperty(name: "maxConnections", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxConnections
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
