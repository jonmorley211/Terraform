using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshGatewayRouteSpecHttp2RouteOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshGatewayRouteSpecHttp2RouteOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppmeshGatewayRouteSpecHttp2RouteOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AppmeshGatewayRouteSpecHttp2RouteOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshGatewayRouteSpecHttp2RouteOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshGatewayRouteSpecHttp2RouteOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttp2RouteAction\"}}]")]
        public virtual void PutAction(aws.Appmesh.IAppmeshGatewayRouteSpecHttp2RouteAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshGatewayRouteSpecHttp2RouteAction)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMatch", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttp2RouteMatch\"}}]")]
        public virtual void PutMatch(aws.Appmesh.IAppmeshGatewayRouteSpecHttp2RouteMatch @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshGatewayRouteSpecHttp2RouteMatch)}, new object[]{@value});
        }

        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttp2RouteActionOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshGatewayRouteSpecHttp2RouteActionOutputReference Action
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshGatewayRouteSpecHttp2RouteActionOutputReference>()!;
        }

        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttp2RouteMatchOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshGatewayRouteSpecHttp2RouteMatchOutputReference Match
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshGatewayRouteSpecHttp2RouteMatchOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttp2RouteAction\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshGatewayRouteSpecHttp2RouteAction? ActionInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshGatewayRouteSpecHttp2RouteAction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "matchInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttp2RouteMatch\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshGatewayRouteSpecHttp2RouteMatch? MatchInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshGatewayRouteSpecHttp2RouteMatch?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttp2Route\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshGatewayRouteSpecHttp2Route? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshGatewayRouteSpecHttp2Route?>();
            set => SetInstanceProperty(value);
        }
    }
}
