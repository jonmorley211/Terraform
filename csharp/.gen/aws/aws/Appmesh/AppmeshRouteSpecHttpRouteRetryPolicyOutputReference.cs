using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshRouteSpecHttpRouteRetryPolicyOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpecHttpRouteRetryPolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppmeshRouteSpecHttpRouteRetryPolicyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AppmeshRouteSpecHttpRouteRetryPolicyOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshRouteSpecHttpRouteRetryPolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshRouteSpecHttpRouteRetryPolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPerRetryTimeout", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteRetryPolicyPerRetryTimeout\"}}]")]
        public virtual void PutPerRetryTimeout(aws.Appmesh.IAppmeshRouteSpecHttpRouteRetryPolicyPerRetryTimeout @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshRouteSpecHttpRouteRetryPolicyPerRetryTimeout)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetHttpRetryEvents")]
        public virtual void ResetHttpRetryEvents()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTcpRetryEvents")]
        public virtual void ResetTcpRetryEvents()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "perRetryTimeout", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteRetryPolicyPerRetryTimeoutOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshRouteSpecHttpRouteRetryPolicyPerRetryTimeoutOutputReference PerRetryTimeout
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshRouteSpecHttpRouteRetryPolicyPerRetryTimeoutOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpRetryEventsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? HttpRetryEventsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxRetriesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxRetriesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "perRetryTimeoutInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteRetryPolicyPerRetryTimeout\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshRouteSpecHttpRouteRetryPolicyPerRetryTimeout? PerRetryTimeoutInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecHttpRouteRetryPolicyPerRetryTimeout?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tcpRetryEventsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? TcpRetryEventsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "httpRetryEvents", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] HttpRetryEvents
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxRetries", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxRetries
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tcpRetryEvents", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] TcpRetryEvents
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteRetryPolicy\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshRouteSpecHttpRouteRetryPolicy? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecHttpRouteRetryPolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
