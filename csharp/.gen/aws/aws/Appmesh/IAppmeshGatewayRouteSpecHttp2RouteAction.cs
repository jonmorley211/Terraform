using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshGatewayRouteSpecHttp2RouteAction), fullyQualifiedName: "aws.appmesh.AppmeshGatewayRouteSpecHttp2RouteAction")]
    public interface IAppmeshGatewayRouteSpecHttp2RouteAction
    {
        /// <summary>target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_gateway_route#target AppmeshGatewayRoute#target}
        /// </remarks>
        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttp2RouteActionTarget\"}")]
        aws.Appmesh.IAppmeshGatewayRouteSpecHttp2RouteActionTarget Target
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshGatewayRouteSpecHttp2RouteAction), fullyQualifiedName: "aws.appmesh.AppmeshGatewayRouteSpecHttp2RouteAction")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshGatewayRouteSpecHttp2RouteAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>target block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_gateway_route#target AppmeshGatewayRoute#target}
            /// </remarks>
            [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttp2RouteActionTarget\"}")]
            public aws.Appmesh.IAppmeshGatewayRouteSpecHttp2RouteActionTarget Target
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshGatewayRouteSpecHttp2RouteActionTarget>()!;
            }
        }
    }
}
