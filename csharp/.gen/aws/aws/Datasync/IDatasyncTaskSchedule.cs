using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Datasync
{
    [JsiiInterface(nativeType: typeof(IDatasyncTaskSchedule), fullyQualifiedName: "aws.datasync.DatasyncTaskSchedule")]
    public interface IDatasyncTaskSchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_task#schedule_expression DatasyncTask#schedule_expression}.</summary>
        [JsiiProperty(name: "scheduleExpression", typeJson: "{\"primitive\":\"string\"}")]
        string ScheduleExpression
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatasyncTaskSchedule), fullyQualifiedName: "aws.datasync.DatasyncTaskSchedule")]
        internal sealed class _Proxy : DeputyBase, aws.Datasync.IDatasyncTaskSchedule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_task#schedule_expression DatasyncTask#schedule_expression}.</summary>
            [JsiiProperty(name: "scheduleExpression", typeJson: "{\"primitive\":\"string\"}")]
            public string ScheduleExpression
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
