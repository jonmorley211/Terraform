using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Connect
{
    [JsiiClass(nativeType: typeof(aws.Connect.ConnectHoursOfOperationConfigStartTimeOutputReference), fullyQualifiedName: "aws.connect.ConnectHoursOfOperationConfigStartTimeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class ConnectHoursOfOperationConfigStartTimeOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public ConnectHoursOfOperationConfigStartTimeOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConnectHoursOfOperationConfigStartTimeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConnectHoursOfOperationConfigStartTimeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "hoursInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? HoursInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minutesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinutesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "hours", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Hours
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minutes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Minutes
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.connect.ConnectHoursOfOperationConfigStartTime\"}", isOptional: true)]
        public virtual aws.Connect.IConnectHoursOfOperationConfigStartTime? InternalValue
        {
            get => GetInstanceProperty<aws.Connect.IConnectHoursOfOperationConfigStartTime?>();
            set => SetInstanceProperty(value);
        }
    }
}
