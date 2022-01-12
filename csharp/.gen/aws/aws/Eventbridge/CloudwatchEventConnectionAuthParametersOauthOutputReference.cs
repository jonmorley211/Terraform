using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eventbridge
{
    [JsiiClass(nativeType: typeof(aws.Eventbridge.CloudwatchEventConnectionAuthParametersOauthOutputReference), fullyQualifiedName: "aws.eventbridge.CloudwatchEventConnectionAuthParametersOauthOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CloudwatchEventConnectionAuthParametersOauthOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public CloudwatchEventConnectionAuthParametersOauthOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchEventConnectionAuthParametersOauthOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchEventConnectionAuthParametersOauthOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putClientParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersOauthClientParameters\"}}]")]
        public virtual void PutClientParameters(aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauthClientParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauthClientParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOauthHttpParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersOauthOauthHttpParameters\"}}]")]
        public virtual void PutOauthHttpParameters(aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauthOauthHttpParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauthOauthHttpParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetClientParameters")]
        public virtual void ResetClientParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "clientParameters", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersOauthClientParametersOutputReference\"}")]
        public virtual aws.Eventbridge.CloudwatchEventConnectionAuthParametersOauthClientParametersOutputReference ClientParameters
        {
            get => GetInstanceProperty<aws.Eventbridge.CloudwatchEventConnectionAuthParametersOauthClientParametersOutputReference>()!;
        }

        [JsiiProperty(name: "oauthHttpParameters", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersOauthOauthHttpParametersOutputReference\"}")]
        public virtual aws.Eventbridge.CloudwatchEventConnectionAuthParametersOauthOauthHttpParametersOutputReference OauthHttpParameters
        {
            get => GetInstanceProperty<aws.Eventbridge.CloudwatchEventConnectionAuthParametersOauthOauthHttpParametersOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "authorizationEndpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuthorizationEndpointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientParametersInput", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersOauthClientParameters\"}", isOptional: true)]
        public virtual aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauthClientParameters? ClientParametersInput
        {
            get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauthClientParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpMethodInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HttpMethodInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oauthHttpParametersInput", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersOauthOauthHttpParameters\"}", isOptional: true)]
        public virtual aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauthOauthHttpParameters? OauthHttpParametersInput
        {
            get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauthOauthHttpParameters?>();
        }

        [JsiiProperty(name: "authorizationEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthorizationEndpoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "httpMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HttpMethod
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersOauth\"}", isOptional: true)]
        public virtual aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauth? InternalValue
        {
            get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauth?>();
            set => SetInstanceProperty(value);
        }
    }
}
