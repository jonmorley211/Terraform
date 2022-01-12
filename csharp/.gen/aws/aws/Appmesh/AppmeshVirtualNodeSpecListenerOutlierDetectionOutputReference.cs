using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshVirtualNodeSpecListenerOutlierDetectionOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecListenerOutlierDetectionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppmeshVirtualNodeSpecListenerOutlierDetectionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AppmeshVirtualNodeSpecListenerOutlierDetectionOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualNodeSpecListenerOutlierDetectionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualNodeSpecListenerOutlierDetectionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBaseEjectionDuration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerOutlierDetectionBaseEjectionDuration\"}}]")]
        public virtual void PutBaseEjectionDuration(aws.Appmesh.IAppmeshVirtualNodeSpecListenerOutlierDetectionBaseEjectionDuration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualNodeSpecListenerOutlierDetectionBaseEjectionDuration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInterval", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerOutlierDetectionInterval\"}}]")]
        public virtual void PutInterval(aws.Appmesh.IAppmeshVirtualNodeSpecListenerOutlierDetectionInterval @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualNodeSpecListenerOutlierDetectionInterval)}, new object[]{@value});
        }

        [JsiiProperty(name: "baseEjectionDuration", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerOutlierDetectionBaseEjectionDurationOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualNodeSpecListenerOutlierDetectionBaseEjectionDurationOutputReference BaseEjectionDuration
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualNodeSpecListenerOutlierDetectionBaseEjectionDurationOutputReference>()!;
        }

        [JsiiProperty(name: "interval", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerOutlierDetectionIntervalOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualNodeSpecListenerOutlierDetectionIntervalOutputReference Interval
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualNodeSpecListenerOutlierDetectionIntervalOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "baseEjectionDurationInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerOutlierDetectionBaseEjectionDuration\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecListenerOutlierDetectionBaseEjectionDuration? BaseEjectionDurationInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerOutlierDetectionBaseEjectionDuration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "intervalInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerOutlierDetectionInterval\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecListenerOutlierDetectionInterval? IntervalInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerOutlierDetectionInterval?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxEjectionPercentInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxEjectionPercentInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxServerErrorsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxServerErrorsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "maxEjectionPercent", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxEjectionPercent
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxServerErrors", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxServerErrors
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerOutlierDetection\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecListenerOutlierDetection? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerOutlierDetection?>();
            set => SetInstanceProperty(value);
        }
    }
}
