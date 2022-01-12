using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshGatewayRouteSpecHttpRoute), fullyQualifiedName: "aws.appmesh.AppmeshGatewayRouteSpecHttpRoute")]
    public interface IAppmeshGatewayRouteSpecHttpRoute
    {
        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_gateway_route#action AppmeshGatewayRoute#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttpRouteAction\"}")]
        aws.Appmesh.IAppmeshGatewayRouteSpecHttpRouteAction Action
        {
            get;
        }

        /// <summary>match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_gateway_route#match AppmeshGatewayRoute#match}
        /// </remarks>
        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttpRouteMatch\"}")]
        aws.Appmesh.IAppmeshGatewayRouteSpecHttpRouteMatch Match
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshGatewayRouteSpecHttpRoute), fullyQualifiedName: "aws.appmesh.AppmeshGatewayRouteSpecHttpRoute")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshGatewayRouteSpecHttpRoute
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_gateway_route#action AppmeshGatewayRoute#action}
            /// </remarks>
            [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttpRouteAction\"}")]
            public aws.Appmesh.IAppmeshGatewayRouteSpecHttpRouteAction Action
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshGatewayRouteSpecHttpRouteAction>()!;
            }

            /// <summary>match block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_gateway_route#match AppmeshGatewayRoute#match}
            /// </remarks>
            [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttpRouteMatch\"}")]
            public aws.Appmesh.IAppmeshGatewayRouteSpecHttpRouteMatch Match
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshGatewayRouteSpecHttpRouteMatch>()!;
            }
        }
    }
}
