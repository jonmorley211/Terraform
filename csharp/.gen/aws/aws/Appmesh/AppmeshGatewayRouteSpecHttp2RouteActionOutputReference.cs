using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshGatewayRouteSpecHttp2RouteActionOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshGatewayRouteSpecHttp2RouteActionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppmeshGatewayRouteSpecHttp2RouteActionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AppmeshGatewayRouteSpecHttp2RouteActionOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshGatewayRouteSpecHttp2RouteActionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshGatewayRouteSpecHttp2RouteActionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putTarget", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttp2RouteActionTarget\"}}]")]
        public virtual void PutTarget(aws.Appmesh.IAppmeshGatewayRouteSpecHttp2RouteActionTarget @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshGatewayRouteSpecHttp2RouteActionTarget)}, new object[]{@value});
        }

        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttp2RouteActionTargetOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshGatewayRouteSpecHttp2RouteActionTargetOutputReference Target
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshGatewayRouteSpecHttp2RouteActionTargetOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttp2RouteActionTarget\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshGatewayRouteSpecHttp2RouteActionTarget? TargetInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshGatewayRouteSpecHttp2RouteActionTarget?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttp2RouteAction\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshGatewayRouteSpecHttp2RouteAction? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshGatewayRouteSpecHttp2RouteAction?>();
            set => SetInstanceProperty(value);
        }
    }
}
