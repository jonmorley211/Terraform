using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Budgets
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.budgets.BudgetsBudgetNotification")]
    public class BudgetsBudgetNotification : aws.Budgets.IBudgetsBudgetNotification
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget#comparison_operator BudgetsBudget#comparison_operator}.</summary>
        [JsiiProperty(name: "comparisonOperator", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ComparisonOperator
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget#notification_type BudgetsBudget#notification_type}.</summary>
        [JsiiProperty(name: "notificationType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string NotificationType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget#threshold BudgetsBudget#threshold}.</summary>
        [JsiiProperty(name: "threshold", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double Threshold
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget#threshold_type BudgetsBudget#threshold_type}.</summary>
        [JsiiProperty(name: "thresholdType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ThresholdType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget#subscriber_email_addresses BudgetsBudget#subscriber_email_addresses}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subscriberEmailAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? SubscriberEmailAddresses
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget#subscriber_sns_topic_arns BudgetsBudget#subscriber_sns_topic_arns}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subscriberSnsTopicArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? SubscriberSnsTopicArns
        {
            get;
            set;
        }
    }
}
