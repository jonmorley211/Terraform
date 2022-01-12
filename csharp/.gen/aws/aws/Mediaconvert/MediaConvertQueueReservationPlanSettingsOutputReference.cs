using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Mediaconvert
{
    [JsiiClass(nativeType: typeof(aws.Mediaconvert.MediaConvertQueueReservationPlanSettingsOutputReference), fullyQualifiedName: "aws.mediaconvert.MediaConvertQueueReservationPlanSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class MediaConvertQueueReservationPlanSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public MediaConvertQueueReservationPlanSettingsOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MediaConvertQueueReservationPlanSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MediaConvertQueueReservationPlanSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "commitmentInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CommitmentInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "renewalTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RenewalTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "reservedSlotsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ReservedSlotsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "commitment", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Commitment
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "renewalType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RenewalType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "reservedSlots", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReservedSlots
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.mediaconvert.MediaConvertQueueReservationPlanSettings\"}", isOptional: true)]
        public virtual aws.Mediaconvert.IMediaConvertQueueReservationPlanSettings? InternalValue
        {
            get => GetInstanceProperty<aws.Mediaconvert.IMediaConvertQueueReservationPlanSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
