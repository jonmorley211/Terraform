using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshGatewayRouteSpecGrpcRouteOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshGatewayRouteSpecGrpcRouteOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppmeshGatewayRouteSpecGrpcRouteOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AppmeshGatewayRouteSpecGrpcRouteOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshGatewayRouteSpecGrpcRouteOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshGatewayRouteSpecGrpcRouteOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecGrpcRouteAction\"}}]")]
        public virtual void PutAction(aws.Appmesh.IAppmeshGatewayRouteSpecGrpcRouteAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshGatewayRouteSpecGrpcRouteAction)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMatch", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecGrpcRouteMatch\"}}]")]
        public virtual void PutMatch(aws.Appmesh.IAppmeshGatewayRouteSpecGrpcRouteMatch @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshGatewayRouteSpecGrpcRouteMatch)}, new object[]{@value});
        }

        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecGrpcRouteActionOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshGatewayRouteSpecGrpcRouteActionOutputReference Action
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshGatewayRouteSpecGrpcRouteActionOutputReference>()!;
        }

        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecGrpcRouteMatchOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshGatewayRouteSpecGrpcRouteMatchOutputReference Match
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshGatewayRouteSpecGrpcRouteMatchOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecGrpcRouteAction\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshGatewayRouteSpecGrpcRouteAction? ActionInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshGatewayRouteSpecGrpcRouteAction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "matchInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecGrpcRouteMatch\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshGatewayRouteSpecGrpcRouteMatch? MatchInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshGatewayRouteSpecGrpcRouteMatch?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecGrpcRoute\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshGatewayRouteSpecGrpcRoute? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshGatewayRouteSpecGrpcRoute?>();
            set => SetInstanceProperty(value);
        }
    }
}
