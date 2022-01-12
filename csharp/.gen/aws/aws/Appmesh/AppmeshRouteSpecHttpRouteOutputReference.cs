using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshRouteSpecHttpRouteOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpecHttpRouteOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppmeshRouteSpecHttpRouteOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AppmeshRouteSpecHttpRouteOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshRouteSpecHttpRouteOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshRouteSpecHttpRouteOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteAction\"}}]")]
        public virtual void PutAction(aws.Appmesh.IAppmeshRouteSpecHttpRouteAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshRouteSpecHttpRouteAction)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMatch", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteMatch\"}}]")]
        public virtual void PutMatch(aws.Appmesh.IAppmeshRouteSpecHttpRouteMatch @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshRouteSpecHttpRouteMatch)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRetryPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteRetryPolicy\"}}]")]
        public virtual void PutRetryPolicy(aws.Appmesh.IAppmeshRouteSpecHttpRouteRetryPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshRouteSpecHttpRouteRetryPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeout", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteTimeout\"}}]")]
        public virtual void PutTimeout(aws.Appmesh.IAppmeshRouteSpecHttpRouteTimeout @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshRouteSpecHttpRouteTimeout)}, new object[]{@value});
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

        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteActionOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshRouteSpecHttpRouteActionOutputReference Action
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshRouteSpecHttpRouteActionOutputReference>()!;
        }

        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteMatchOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshRouteSpecHttpRouteMatchOutputReference Match
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshRouteSpecHttpRouteMatchOutputReference>()!;
        }

        [JsiiProperty(name: "retryPolicy", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteRetryPolicyOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshRouteSpecHttpRouteRetryPolicyOutputReference RetryPolicy
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshRouteSpecHttpRouteRetryPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "timeout", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteTimeoutOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshRouteSpecHttpRouteTimeoutOutputReference Timeout
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshRouteSpecHttpRouteTimeoutOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteAction\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshRouteSpecHttpRouteAction? ActionInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecHttpRouteAction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "matchInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteMatch\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshRouteSpecHttpRouteMatch? MatchInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecHttpRouteMatch?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retryPolicyInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteRetryPolicy\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshRouteSpecHttpRouteRetryPolicy? RetryPolicyInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecHttpRouteRetryPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteTimeout\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshRouteSpecHttpRouteTimeout? TimeoutInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecHttpRouteTimeout?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRoute\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshRouteSpecHttpRoute? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecHttpRoute?>();
            set => SetInstanceProperty(value);
        }
    }
}
