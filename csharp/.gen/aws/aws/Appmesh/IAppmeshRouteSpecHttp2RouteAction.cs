using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshRouteSpecHttp2RouteAction), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpecHttp2RouteAction")]
    public interface IAppmeshRouteSpecHttp2RouteAction
    {
        /// <summary>weighted_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#weighted_target AppmeshRoute#weighted_target}
        /// </remarks>
        [JsiiProperty(name: "weightedTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttp2RouteActionWeightedTarget\"},\"kind\":\"array\"}}")]
        aws.Appmesh.IAppmeshRouteSpecHttp2RouteActionWeightedTarget[] WeightedTarget
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshRouteSpecHttp2RouteAction), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpecHttp2RouteAction")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshRouteSpecHttp2RouteAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>weighted_target block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#weighted_target AppmeshRoute#weighted_target}
            /// </remarks>
            [JsiiProperty(name: "weightedTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttp2RouteActionWeightedTarget\"},\"kind\":\"array\"}}")]
            public aws.Appmesh.IAppmeshRouteSpecHttp2RouteActionWeightedTarget[] WeightedTarget
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecHttp2RouteActionWeightedTarget[]>()!;
            }
        }
    }
}
