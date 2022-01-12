using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eventbridge
{
    [JsiiClass(nativeType: typeof(aws.Eventbridge.CloudwatchEventConnectionAuthParametersOauthOauthHttpParametersOutputReference), fullyQualifiedName: "aws.eventbridge.CloudwatchEventConnectionAuthParametersOauthOauthHttpParametersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CloudwatchEventConnectionAuthParametersOauthOauthHttpParametersOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public CloudwatchEventConnectionAuthParametersOauthOauthHttpParametersOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchEventConnectionAuthParametersOauthOauthHttpParametersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchEventConnectionAuthParametersOauthOauthHttpParametersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetBody")]
        public virtual void ResetBody()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHeader")]
        public virtual void ResetHeader()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQueryString")]
        public virtual void ResetQueryString()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "bodyInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersOauthOauthHttpParametersBody\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauthOauthHttpParametersBody[]? BodyInput
        {
            get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauthOauthHttpParametersBody[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "headerInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersOauthOauthHttpParametersHeader\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauthOauthHttpParametersHeader[]? HeaderInput
        {
            get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauthOauthHttpParametersHeader[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryStringInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersOauthOauthHttpParametersQueryString\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauthOauthHttpParametersQueryString[]? QueryStringInput
        {
            get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauthOauthHttpParametersQueryString[]?>();
        }

        [JsiiProperty(name: "body", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersOauthOauthHttpParametersBody\"},\"kind\":\"array\"}}")]
        public virtual aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauthOauthHttpParametersBody[] Body
        {
            get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauthOauthHttpParametersBody[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "header", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersOauthOauthHttpParametersHeader\"},\"kind\":\"array\"}}")]
        public virtual aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauthOauthHttpParametersHeader[] Header
        {
            get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauthOauthHttpParametersHeader[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "queryString", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersOauthOauthHttpParametersQueryString\"},\"kind\":\"array\"}}")]
        public virtual aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauthOauthHttpParametersQueryString[] QueryString
        {
            get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauthOauthHttpParametersQueryString[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersOauthOauthHttpParameters\"}", isOptional: true)]
        public virtual aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauthOauthHttpParameters? InternalValue
        {
            get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauthOauthHttpParameters?>();
            set => SetInstanceProperty(value);
        }
    }
}
