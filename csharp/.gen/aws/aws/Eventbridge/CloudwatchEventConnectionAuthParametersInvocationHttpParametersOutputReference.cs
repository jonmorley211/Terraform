using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eventbridge
{
    [JsiiClass(nativeType: typeof(aws.Eventbridge.CloudwatchEventConnectionAuthParametersInvocationHttpParametersOutputReference), fullyQualifiedName: "aws.eventbridge.CloudwatchEventConnectionAuthParametersInvocationHttpParametersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CloudwatchEventConnectionAuthParametersInvocationHttpParametersOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public CloudwatchEventConnectionAuthParametersInvocationHttpParametersOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchEventConnectionAuthParametersInvocationHttpParametersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchEventConnectionAuthParametersInvocationHttpParametersOutputReference(DeputyProps props): base(props)
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
        [JsiiProperty(name: "bodyInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersInvocationHttpParametersBody\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Eventbridge.ICloudwatchEventConnectionAuthParametersInvocationHttpParametersBody[]? BodyInput
        {
            get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventConnectionAuthParametersInvocationHttpParametersBody[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "headerInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersInvocationHttpParametersHeader\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Eventbridge.ICloudwatchEventConnectionAuthParametersInvocationHttpParametersHeader[]? HeaderInput
        {
            get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventConnectionAuthParametersInvocationHttpParametersHeader[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryStringInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersInvocationHttpParametersQueryString\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Eventbridge.ICloudwatchEventConnectionAuthParametersInvocationHttpParametersQueryString[]? QueryStringInput
        {
            get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventConnectionAuthParametersInvocationHttpParametersQueryString[]?>();
        }

        [JsiiProperty(name: "body", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersInvocationHttpParametersBody\"},\"kind\":\"array\"}}")]
        public virtual aws.Eventbridge.ICloudwatchEventConnectionAuthParametersInvocationHttpParametersBody[] Body
        {
            get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventConnectionAuthParametersInvocationHttpParametersBody[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "header", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersInvocationHttpParametersHeader\"},\"kind\":\"array\"}}")]
        public virtual aws.Eventbridge.ICloudwatchEventConnectionAuthParametersInvocationHttpParametersHeader[] Header
        {
            get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventConnectionAuthParametersInvocationHttpParametersHeader[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "queryString", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersInvocationHttpParametersQueryString\"},\"kind\":\"array\"}}")]
        public virtual aws.Eventbridge.ICloudwatchEventConnectionAuthParametersInvocationHttpParametersQueryString[] QueryString
        {
            get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventConnectionAuthParametersInvocationHttpParametersQueryString[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersInvocationHttpParameters\"}", isOptional: true)]
        public virtual aws.Eventbridge.ICloudwatchEventConnectionAuthParametersInvocationHttpParameters? InternalValue
        {
            get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventConnectionAuthParametersInvocationHttpParameters?>();
            set => SetInstanceProperty(value);
        }
    }
}
