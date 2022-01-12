using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_monitoring_subscription aws_cloudfront_monitoring_subscription}.</summary>
    [JsiiClass(nativeType: typeof(aws.Cloudfront.CloudfrontMonitoringSubscription), fullyQualifiedName: "aws.cloudfront.CloudfrontMonitoringSubscription", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.cloudfront.CloudfrontMonitoringSubscriptionConfig\"}}]")]
    public class CloudfrontMonitoringSubscription : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_monitoring_subscription aws_cloudfront_monitoring_subscription} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CloudfrontMonitoringSubscription(Constructs.Construct scope, string id, aws.Cloudfront.ICloudfrontMonitoringSubscriptionConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontMonitoringSubscription(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontMonitoringSubscription(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putMonitoringSubscription", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfront.CloudfrontMonitoringSubscriptionMonitoringSubscription\"}}]")]
        public virtual void PutMonitoringSubscription(aws.Cloudfront.ICloudfrontMonitoringSubscriptionMonitoringSubscription @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cloudfront.ICloudfrontMonitoringSubscriptionMonitoringSubscription)}, new object[]{@value});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Cloudfront.CloudfrontMonitoringSubscription))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "monitoringSubscription", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontMonitoringSubscriptionMonitoringSubscriptionOutputReference\"}")]
        public virtual aws.Cloudfront.CloudfrontMonitoringSubscriptionMonitoringSubscriptionOutputReference MonitoringSubscription
        {
            get => GetInstanceProperty<aws.Cloudfront.CloudfrontMonitoringSubscriptionMonitoringSubscriptionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "distributionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DistributionIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "monitoringSubscriptionInput", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontMonitoringSubscriptionMonitoringSubscription\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontMonitoringSubscriptionMonitoringSubscription? MonitoringSubscriptionInput
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontMonitoringSubscriptionMonitoringSubscription?>();
        }

        [JsiiProperty(name: "distributionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DistributionId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
