using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie2
{
    [JsiiClass(nativeType: typeof(aws.Macie2.Macie2ClassificationJobScheduleFrequencyOutputReference), fullyQualifiedName: "aws.macie2.Macie2ClassificationJobScheduleFrequencyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class Macie2ClassificationJobScheduleFrequencyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public Macie2ClassificationJobScheduleFrequencyOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Macie2ClassificationJobScheduleFrequencyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Macie2ClassificationJobScheduleFrequencyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDailySchedule")]
        public virtual void ResetDailySchedule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMonthlySchedule")]
        public virtual void ResetMonthlySchedule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWeeklySchedule")]
        public virtual void ResetWeeklySchedule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "dailyScheduleInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DailyScheduleInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "monthlyScheduleInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MonthlyScheduleInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "weeklyScheduleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WeeklyScheduleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "dailySchedule", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object DailySchedule
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "monthlySchedule", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MonthlySchedule
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "weeklySchedule", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WeeklySchedule
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.macie2.Macie2ClassificationJobScheduleFrequency\"}", isOptional: true)]
        public virtual aws.Macie2.IMacie2ClassificationJobScheduleFrequency? InternalValue
        {
            get => GetInstanceProperty<aws.Macie2.IMacie2ClassificationJobScheduleFrequency?>();
            set => SetInstanceProperty(value);
        }
    }
}
