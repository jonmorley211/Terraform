using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshGatewayRouteSpecHttp2RouteActionTargetVirtualService), fullyQualifiedName: "aws.appmesh.AppmeshGatewayRouteSpecHttp2RouteActionTargetVirtualService")]
    public interface IAppmeshGatewayRouteSpecHttp2RouteActionTargetVirtualService
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_gateway_route#virtual_service_name AppmeshGatewayRoute#virtual_service_name}.</summary>
        [JsiiProperty(name: "virtualServiceName", typeJson: "{\"primitive\":\"string\"}")]
        string VirtualServiceName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshGatewayRouteSpecHttp2RouteActionTargetVirtualService), fullyQualifiedName: "aws.appmesh.AppmeshGatewayRouteSpecHttp2RouteActionTargetVirtualService")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshGatewayRouteSpecHttp2RouteActionTargetVirtualService
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_gateway_route#virtual_service_name AppmeshGatewayRoute#virtual_service_name}.</summary>
            [JsiiProperty(name: "virtualServiceName", typeJson: "{\"primitive\":\"string\"}")]
            public string VirtualServiceName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
