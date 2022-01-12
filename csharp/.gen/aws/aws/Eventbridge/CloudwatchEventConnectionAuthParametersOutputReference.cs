using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eventbridge
{
    [JsiiClass(nativeType: typeof(aws.Eventbridge.CloudwatchEventConnectionAuthParametersOutputReference), fullyQualifiedName: "aws.eventbridge.CloudwatchEventConnectionAuthParametersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CloudwatchEventConnectionAuthParametersOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public CloudwatchEventConnectionAuthParametersOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchEventConnectionAuthParametersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchEventConnectionAuthParametersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putApiKey", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersApiKey\"}}]")]
        public virtual void PutApiKey(aws.Eventbridge.ICloudwatchEventConnectionAuthParametersApiKey @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Eventbridge.ICloudwatchEventConnectionAuthParametersApiKey)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBasic", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersBasic\"}}]")]
        public virtual void PutBasic(aws.Eventbridge.ICloudwatchEventConnectionAuthParametersBasic @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Eventbridge.ICloudwatchEventConnectionAuthParametersBasic)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInvocationHttpParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersInvocationHttpParameters\"}}]")]
        public virtual void PutInvocationHttpParameters(aws.Eventbridge.ICloudwatchEventConnectionAuthParametersInvocationHttpParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Eventbridge.ICloudwatchEventConnectionAuthParametersInvocationHttpParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOauth", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersOauth\"}}]")]
        public virtual void PutOauth(aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauth @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauth)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetApiKey")]
        public virtual void ResetApiKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBasic")]
        public virtual void ResetBasic()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInvocationHttpParameters")]
        public virtual void ResetInvocationHttpParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOauth")]
        public virtual void ResetOauth()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "apiKey", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersApiKeyOutputReference\"}")]
        public virtual aws.Eventbridge.CloudwatchEventConnectionAuthParametersApiKeyOutputReference ApiKey
        {
            get => GetInstanceProperty<aws.Eventbridge.CloudwatchEventConnectionAuthParametersApiKeyOutputReference>()!;
        }

        [JsiiProperty(name: "basic", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersBasicOutputReference\"}")]
        public virtual aws.Eventbridge.CloudwatchEventConnectionAuthParametersBasicOutputReference Basic
        {
            get => GetInstanceProperty<aws.Eventbridge.CloudwatchEventConnectionAuthParametersBasicOutputReference>()!;
        }

        [JsiiProperty(name: "invocationHttpParameters", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersInvocationHttpParametersOutputReference\"}")]
        public virtual aws.Eventbridge.CloudwatchEventConnectionAuthParametersInvocationHttpParametersOutputReference InvocationHttpParameters
        {
            get => GetInstanceProperty<aws.Eventbridge.CloudwatchEventConnectionAuthParametersInvocationHttpParametersOutputReference>()!;
        }

        [JsiiProperty(name: "oauth", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersOauthOutputReference\"}")]
        public virtual aws.Eventbridge.CloudwatchEventConnectionAuthParametersOauthOutputReference Oauth
        {
            get => GetInstanceProperty<aws.Eventbridge.CloudwatchEventConnectionAuthParametersOauthOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "apiKeyInput", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersApiKey\"}", isOptional: true)]
        public virtual aws.Eventbridge.ICloudwatchEventConnectionAuthParametersApiKey? ApiKeyInput
        {
            get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventConnectionAuthParametersApiKey?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "basicInput", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersBasic\"}", isOptional: true)]
        public virtual aws.Eventbridge.ICloudwatchEventConnectionAuthParametersBasic? BasicInput
        {
            get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventConnectionAuthParametersBasic?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "invocationHttpParametersInput", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersInvocationHttpParameters\"}", isOptional: true)]
        public virtual aws.Eventbridge.ICloudwatchEventConnectionAuthParametersInvocationHttpParameters? InvocationHttpParametersInput
        {
            get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventConnectionAuthParametersInvocationHttpParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oauthInput", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersOauth\"}", isOptional: true)]
        public virtual aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauth? OauthInput
        {
            get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauth?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParameters\"}", isOptional: true)]
        public virtual aws.Eventbridge.ICloudwatchEventConnectionAuthParameters? InternalValue
        {
            get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventConnectionAuthParameters?>();
            set => SetInstanceProperty(value);
        }
    }
}
