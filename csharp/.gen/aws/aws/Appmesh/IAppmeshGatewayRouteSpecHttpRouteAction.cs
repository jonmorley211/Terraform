using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshGatewayRouteSpecHttpRouteAction), fullyQualifiedName: "aws.appmesh.AppmeshGatewayRouteSpecHttpRouteAction")]
    public interface IAppmeshGatewayRouteSpecHttpRouteAction
    {
        /// <summary>target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_gateway_route#target AppmeshGatewayRoute#target}
        /// </remarks>
        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttpRouteActionTarget\"}")]
        aws.Appmesh.IAppmeshGatewayRouteSpecHttpRouteActionTarget Target
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshGatewayRouteSpecHttpRouteAction), fullyQualifiedName: "aws.appmesh.AppmeshGatewayRouteSpecHttpRouteAction")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshGatewayRouteSpecHttpRouteAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>target block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_gateway_route#target AppmeshGatewayRoute#target}
            /// </remarks>
            [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttpRouteActionTarget\"}")]
            public aws.Appmesh.IAppmeshGatewayRouteSpecHttpRouteActionTarget Target
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshGatewayRouteSpecHttpRouteActionTarget>()!;
            }
        }
    }
}
