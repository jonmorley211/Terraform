using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiInterface(nativeType: typeof(IGlueJobNotificationProperty), fullyQualifiedName: "aws.glue.GlueJobNotificationProperty")]
    public interface IGlueJobNotificationProperty
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#notify_delay_after GlueJob#notify_delay_after}.</summary>
        [JsiiProperty(name: "notifyDelayAfter", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NotifyDelayAfter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueJobNotificationProperty), fullyQualifiedName: "aws.glue.GlueJobNotificationProperty")]
        internal sealed class _Proxy : DeputyBase, aws.Glue.IGlueJobNotificationProperty
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#notify_delay_after GlueJob#notify_delay_after}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "notifyDelayAfter", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NotifyDelayAfter
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
