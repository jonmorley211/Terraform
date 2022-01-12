using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiByValue(fqn: "aws.glue.GlueTriggerActionsNotificationProperty")]
    public class GlueTriggerActionsNotificationProperty : aws.Glue.IGlueTriggerActionsNotificationProperty
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_trigger#notify_delay_after GlueTrigger#notify_delay_after}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "notifyDelayAfter", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? NotifyDelayAfter
        {
            get;
            set;
        }
    }
}
