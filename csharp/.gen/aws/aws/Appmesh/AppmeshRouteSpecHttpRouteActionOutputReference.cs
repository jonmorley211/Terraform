using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshRouteSpecHttpRouteActionOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpecHttpRouteActionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppmeshRouteSpecHttpRouteActionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AppmeshRouteSpecHttpRouteActionOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshRouteSpecHttpRouteActionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshRouteSpecHttpRouteActionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "weightedTargetInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteActionWeightedTarget\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshRouteSpecHttpRouteActionWeightedTarget[]? WeightedTargetInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecHttpRouteActionWeightedTarget[]?>();
        }

        [JsiiProperty(name: "weightedTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteActionWeightedTarget\"},\"kind\":\"array\"}}")]
        public virtual aws.Appmesh.IAppmeshRouteSpecHttpRouteActionWeightedTarget[] WeightedTarget
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecHttpRouteActionWeightedTarget[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteAction\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshRouteSpecHttpRouteAction? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecHttpRouteAction?>();
            set => SetInstanceProperty(value);
        }
    }
}
