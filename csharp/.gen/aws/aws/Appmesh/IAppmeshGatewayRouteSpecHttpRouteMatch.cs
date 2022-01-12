using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshGatewayRouteSpecHttpRouteMatch), fullyQualifiedName: "aws.appmesh.AppmeshGatewayRouteSpecHttpRouteMatch")]
    public interface IAppmeshGatewayRouteSpecHttpRouteMatch
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_gateway_route#prefix AppmeshGatewayRoute#prefix}.</summary>
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
        string Prefix
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshGatewayRouteSpecHttpRouteMatch), fullyQualifiedName: "aws.appmesh.AppmeshGatewayRouteSpecHttpRouteMatch")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshGatewayRouteSpecHttpRouteMatch
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_gateway_route#prefix AppmeshGatewayRoute#prefix}.</summary>
            [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
            public string Prefix
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
