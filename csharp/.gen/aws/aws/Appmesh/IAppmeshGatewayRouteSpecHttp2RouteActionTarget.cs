using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshGatewayRouteSpecHttp2RouteActionTarget), fullyQualifiedName: "aws.appmesh.AppmeshGatewayRouteSpecHttp2RouteActionTarget")]
    public interface IAppmeshGatewayRouteSpecHttp2RouteActionTarget
    {
        /// <summary>virtual_service block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_gateway_route#virtual_service AppmeshGatewayRoute#virtual_service}
        /// </remarks>
        [JsiiProperty(name: "virtualService", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttp2RouteActionTargetVirtualService\"}")]
        aws.Appmesh.IAppmeshGatewayRouteSpecHttp2RouteActionTargetVirtualService VirtualService
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshGatewayRouteSpecHttp2RouteActionTarget), fullyQualifiedName: "aws.appmesh.AppmeshGatewayRouteSpecHttp2RouteActionTarget")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshGatewayRouteSpecHttp2RouteActionTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>virtual_service block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_gateway_route#virtual_service AppmeshGatewayRoute#virtual_service}
            /// </remarks>
            [JsiiProperty(name: "virtualService", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttp2RouteActionTargetVirtualService\"}")]
            public aws.Appmesh.IAppmeshGatewayRouteSpecHttp2RouteActionTargetVirtualService VirtualService
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshGatewayRouteSpecHttp2RouteActionTargetVirtualService>()!;
            }
        }
    }
}
