using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshGatewayRouteSpecHttpRouteActionTarget), fullyQualifiedName: "aws.appmesh.AppmeshGatewayRouteSpecHttpRouteActionTarget")]
    public interface IAppmeshGatewayRouteSpecHttpRouteActionTarget
    {
        /// <summary>virtual_service block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_gateway_route#virtual_service AppmeshGatewayRoute#virtual_service}
        /// </remarks>
        [JsiiProperty(name: "virtualService", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttpRouteActionTargetVirtualService\"}")]
        aws.Appmesh.IAppmeshGatewayRouteSpecHttpRouteActionTargetVirtualService VirtualService
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshGatewayRouteSpecHttpRouteActionTarget), fullyQualifiedName: "aws.appmesh.AppmeshGatewayRouteSpecHttpRouteActionTarget")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshGatewayRouteSpecHttpRouteActionTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>virtual_service block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_gateway_route#virtual_service AppmeshGatewayRoute#virtual_service}
            /// </remarks>
            [JsiiProperty(name: "virtualService", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttpRouteActionTargetVirtualService\"}")]
            public aws.Appmesh.IAppmeshGatewayRouteSpecHttpRouteActionTargetVirtualService VirtualService
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshGatewayRouteSpecHttpRouteActionTargetVirtualService>()!;
            }
        }
    }
}
