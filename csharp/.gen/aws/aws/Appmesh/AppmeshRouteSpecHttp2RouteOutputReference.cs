using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshRouteSpecHttp2RouteOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpecHttp2RouteOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppmeshRouteSpecHttp2RouteOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AppmeshRouteSpecHttp2RouteOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshRouteSpecHttp2RouteOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshRouteSpecHttp2RouteOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttp2RouteAction\"}}]")]
        public virtual void PutAction(aws.Appmesh.IAppmeshRouteSpecHttp2RouteAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshRouteSpecHttp2RouteAction)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMatch", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttp2RouteMatch\"}}]")]
        public virtual void PutMatch(aws.Appmesh.IAppmeshRouteSpecHttp2RouteMatch @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshRouteSpecHttp2RouteMatch)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRetryPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttp2RouteRetryPolicy\"}}]")]
        public virtual void PutRetryPolicy(aws.Appmesh.IAppmeshRouteSpecHttp2RouteRetryPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshRouteSpecHttp2RouteRetryPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeout", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttp2RouteTimeout\"}}]")]
        public virtual void PutTimeout(aws.Appmesh.IAppmeshRouteSpecHttp2RouteTimeout @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshRouteSpecHttp2RouteTimeout)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetRetryPolicy")]
        public virtual void ResetRetryPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeout")]
        public virtual void ResetTimeout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttp2RouteActionOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshRouteSpecHttp2RouteActionOutputReference Action
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshRouteSpecHttp2RouteActionOutputReference>()!;
        }

        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttp2RouteMatchOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshRouteSpecHttp2RouteMatchOutputReference Match
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshRouteSpecHttp2RouteMatchOutputReference>()!;
        }

        [JsiiProperty(name: "retryPolicy", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttp2RouteRetryPolicyOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshRouteSpecHttp2RouteRetryPolicyOutputReference RetryPolicy
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshRouteSpecHttp2RouteRetryPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "timeout", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttp2RouteTimeoutOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshRouteSpecHttp2RouteTimeoutOutputReference Timeout
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshRouteSpecHttp2RouteTimeoutOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttp2RouteAction\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshRouteSpecHttp2RouteAction? ActionInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecHttp2RouteAction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "matchInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttp2RouteMatch\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshRouteSpecHttp2RouteMatch? MatchInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecHttp2RouteMatch?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retryPolicyInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttp2RouteRetryPolicy\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshRouteSpecHttp2RouteRetryPolicy? RetryPolicyInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecHttp2RouteRetryPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttp2RouteTimeout\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshRouteSpecHttp2RouteTimeout? TimeoutInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecHttp2RouteTimeout?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttp2Route\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshRouteSpecHttp2Route? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecHttp2Route?>();
            set => SetInstanceProperty(value);
        }
    }
}
