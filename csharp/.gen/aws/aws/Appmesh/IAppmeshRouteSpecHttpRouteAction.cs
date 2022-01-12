using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshRouteSpecHttpRouteAction), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpecHttpRouteAction")]
    public interface IAppmeshRouteSpecHttpRouteAction
    {
        /// <summary>weighted_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#weighted_target AppmeshRoute#weighted_target}
        /// </remarks>
        [JsiiProperty(name: "weightedTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteActionWeightedTarget\"},\"kind\":\"array\"}}")]
        aws.Appmesh.IAppmeshRouteSpecHttpRouteActionWeightedTarget[] WeightedTarget
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshRouteSpecHttpRouteAction), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpecHttpRouteAction")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshRouteSpecHttpRouteAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>weighted_target block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#weighted_target AppmeshRoute#weighted_target}
            /// </remarks>
            [JsiiProperty(name: "weightedTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteActionWeightedTarget\"},\"kind\":\"array\"}}")]
            public aws.Appmesh.IAppmeshRouteSpecHttpRouteActionWeightedTarget[] WeightedTarget
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecHttpRouteActionWeightedTarget[]>()!;
            }
        }
    }
}
