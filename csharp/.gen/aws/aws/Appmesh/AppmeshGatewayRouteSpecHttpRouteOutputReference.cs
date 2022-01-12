using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshGatewayRouteSpecHttpRouteOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshGatewayRouteSpecHttpRouteOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppmeshGatewayRouteSpecHttpRouteOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AppmeshGatewayRouteSpecHttpRouteOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshGatewayRouteSpecHttpRouteOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshGatewayRouteSpecHttpRouteOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttpRouteAction\"}}]")]
        public virtual void PutAction(aws.Appmesh.IAppmeshGatewayRouteSpecHttpRouteAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshGatewayRouteSpecHttpRouteAction)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMatch", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttpRouteMatch\"}}]")]
        public virtual void PutMatch(aws.Appmesh.IAppmeshGatewayRouteSpecHttpRouteMatch @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshGatewayRouteSpecHttpRouteMatch)}, new object[]{@value});
        }

        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttpRouteActionOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshGatewayRouteSpecHttpRouteActionOutputReference Action
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshGatewayRouteSpecHttpRouteActionOutputReference>()!;
        }

        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttpRouteMatchOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshGatewayRouteSpecHttpRouteMatchOutputReference Match
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshGatewayRouteSpecHttpRouteMatchOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttpRouteAction\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshGatewayRouteSpecHttpRouteAction? ActionInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshGatewayRouteSpecHttpRouteAction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "matchInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttpRouteMatch\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshGatewayRouteSpecHttpRouteMatch? MatchInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshGatewayRouteSpecHttpRouteMatch?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttpRoute\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshGatewayRouteSpecHttpRoute? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshGatewayRouteSpecHttpRoute?>();
            set => SetInstanceProperty(value);
        }
    }
}
