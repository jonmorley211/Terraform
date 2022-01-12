using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshGatewayRouteSpecGrpcRouteActionOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshGatewayRouteSpecGrpcRouteActionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppmeshGatewayRouteSpecGrpcRouteActionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AppmeshGatewayRouteSpecGrpcRouteActionOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshGatewayRouteSpecGrpcRouteActionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshGatewayRouteSpecGrpcRouteActionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putTarget", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecGrpcRouteActionTarget\"}}]")]
        public virtual void PutTarget(aws.Appmesh.IAppmeshGatewayRouteSpecGrpcRouteActionTarget @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshGatewayRouteSpecGrpcRouteActionTarget)}, new object[]{@value});
        }

        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecGrpcRouteActionTargetOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshGatewayRouteSpecGrpcRouteActionTargetOutputReference Target
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshGatewayRouteSpecGrpcRouteActionTargetOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecGrpcRouteActionTarget\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshGatewayRouteSpecGrpcRouteActionTarget? TargetInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshGatewayRouteSpecGrpcRouteActionTarget?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecGrpcRouteAction\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshGatewayRouteSpecGrpcRouteAction? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshGatewayRouteSpecGrpcRouteAction?>();
            set => SetInstanceProperty(value);
        }
    }
}
