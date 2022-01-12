using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie2
{
    [JsiiByValue(fqn: "aws.macie2.Macie2ClassificationJobScheduleFrequency")]
    public class Macie2ClassificationJobScheduleFrequency : aws.Macie2.IMacie2ClassificationJobScheduleFrequency
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_classification_job#daily_schedule Macie2ClassificationJob#daily_schedule}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dailySchedule", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? DailySchedule
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_classification_job#monthly_schedule Macie2ClassificationJob#monthly_schedule}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "monthlySchedule", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MonthlySchedule
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_classification_job#weekly_schedule Macie2ClassificationJob#weekly_schedule}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "weeklySchedule", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? WeeklySchedule
        {
            get;
            set;
        }
    }
}
