using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Datasync
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.datasync.DatasyncTaskSchedule")]
    public class DatasyncTaskSchedule : aws.Datasync.IDatasyncTaskSchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_task#schedule_expression DatasyncTask#schedule_expression}.</summary>
        [JsiiProperty(name: "scheduleExpression", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ScheduleExpression
        {
            get;
            set;
        }
    }
}
