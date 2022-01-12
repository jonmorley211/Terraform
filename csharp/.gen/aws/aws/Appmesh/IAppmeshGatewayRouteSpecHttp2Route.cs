using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshGatewayRouteSpecHttp2Route), fullyQualifiedName: "aws.appmesh.AppmeshGatewayRouteSpecHttp2Route")]
    public interface IAppmeshGatewayRouteSpecHttp2Route
    {
        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_gateway_route#action AppmeshGatewayRoute#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttp2RouteAction\"}")]
        aws.Appmesh.IAppmeshGatewayRouteSpecHttp2RouteAction Action
        {
            get;
        }

        /// <summary>match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_gateway_route#match AppmeshGatewayRoute#match}
        /// </remarks>
        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttp2RouteMatch\"}")]
        aws.Appmesh.IAppmeshGatewayRouteSpecHttp2RouteMatch Match
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshGatewayRouteSpecHttp2Route), fullyQualifiedName: "aws.appmesh.AppmeshGatewayRouteSpecHttp2Route")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshGatewayRouteSpecHttp2Route
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_gateway_route#action AppmeshGatewayRoute#action}
            /// </remarks>
            [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttp2RouteAction\"}")]
            public aws.Appmesh.IAppmeshGatewayRouteSpecHttp2RouteAction Action
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshGatewayRouteSpecHttp2RouteAction>()!;
            }

            /// <summary>match block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_gateway_route#match AppmeshGatewayRoute#match}
            /// </remarks>
            [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttp2RouteMatch\"}")]
            public aws.Appmesh.IAppmeshGatewayRouteSpecHttp2RouteMatch Match
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshGatewayRouteSpecHttp2RouteMatch>()!;
            }
        }
    }
}
