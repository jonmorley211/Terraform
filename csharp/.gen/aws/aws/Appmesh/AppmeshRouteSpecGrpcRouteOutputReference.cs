using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshRouteSpecGrpcRouteOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpecGrpcRouteOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppmeshRouteSpecGrpcRouteOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AppmeshRouteSpecGrpcRouteOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshRouteSpecGrpcRouteOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshRouteSpecGrpcRouteOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshRouteSpecGrpcRouteAction\"}}]")]
        public virtual void PutAction(aws.Appmesh.IAppmeshRouteSpecGrpcRouteAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshRouteSpecGrpcRouteAction)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMatch", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshRouteSpecGrpcRouteMatch\"}}]")]
        public virtual void PutMatch(aws.Appmesh.IAppmeshRouteSpecGrpcRouteMatch @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshRouteSpecGrpcRouteMatch)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRetryPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshRouteSpecGrpcRouteRetryPolicy\"}}]")]
        public virtual void PutRetryPolicy(aws.Appmesh.IAppmeshRouteSpecGrpcRouteRetryPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshRouteSpecGrpcRouteRetryPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeout", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshRouteSpecGrpcRouteTimeout\"}}]")]
        public virtual void PutTimeout(aws.Appmesh.IAppmeshRouteSpecGrpcRouteTimeout @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshRouteSpecGrpcRouteTimeout)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetMatch")]
        public virtual void ResetMatch()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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

        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecGrpcRouteActionOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshRouteSpecGrpcRouteActionOutputReference Action
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshRouteSpecGrpcRouteActionOutputReference>()!;
        }

        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecGrpcRouteMatchOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshRouteSpecGrpcRouteMatchOutputReference Match
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshRouteSpecGrpcRouteMatchOutputReference>()!;
        }

        [JsiiProperty(name: "retryPolicy", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecGrpcRouteRetryPolicyOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshRouteSpecGrpcRouteRetryPolicyOutputReference RetryPolicy
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshRouteSpecGrpcRouteRetryPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "timeout", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecGrpcRouteTimeoutOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshRouteSpecGrpcRouteTimeoutOutputReference Timeout
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshRouteSpecGrpcRouteTimeoutOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecGrpcRouteAction\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshRouteSpecGrpcRouteAction? ActionInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecGrpcRouteAction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "matchInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecGrpcRouteMatch\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshRouteSpecGrpcRouteMatch? MatchInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecGrpcRouteMatch?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retryPolicyInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecGrpcRouteRetryPolicy\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshRouteSpecGrpcRouteRetryPolicy? RetryPolicyInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecGrpcRouteRetryPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecGrpcRouteTimeout\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshRouteSpecGrpcRouteTimeout? TimeoutInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecGrpcRouteTimeout?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecGrpcRoute\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshRouteSpecGrpcRoute? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecGrpcRoute?>();
            set => SetInstanceProperty(value);
        }
    }
}
