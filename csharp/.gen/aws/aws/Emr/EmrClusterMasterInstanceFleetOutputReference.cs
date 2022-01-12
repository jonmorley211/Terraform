using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Emr
{
    [JsiiClass(nativeType: typeof(aws.Emr.EmrClusterMasterInstanceFleetOutputReference), fullyQualifiedName: "aws.emr.EmrClusterMasterInstanceFleetOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class EmrClusterMasterInstanceFleetOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public EmrClusterMasterInstanceFleetOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EmrClusterMasterInstanceFleetOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EmrClusterMasterInstanceFleetOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLaunchSpecifications", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.emr.EmrClusterMasterInstanceFleetLaunchSpecifications\"}}]")]
        public virtual void PutLaunchSpecifications(aws.Emr.IEmrClusterMasterInstanceFleetLaunchSpecifications @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Emr.IEmrClusterMasterInstanceFleetLaunchSpecifications)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetInstanceTypeConfigs")]
        public virtual void ResetInstanceTypeConfigs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLaunchSpecifications")]
        public virtual void ResetLaunchSpecifications()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetOnDemandCapacity")]
        public virtual void ResetTargetOnDemandCapacity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetSpotCapacity")]
        public virtual void ResetTargetSpotCapacity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "launchSpecifications", typeJson: "{\"fqn\":\"aws.emr.EmrClusterMasterInstanceFleetLaunchSpecificationsOutputReference\"}")]
        public virtual aws.Emr.EmrClusterMasterInstanceFleetLaunchSpecificationsOutputReference LaunchSpecifications
        {
            get => GetInstanceProperty<aws.Emr.EmrClusterMasterInstanceFleetLaunchSpecificationsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceTypeConfigsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrClusterMasterInstanceFleetInstanceTypeConfigs\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Emr.IEmrClusterMasterInstanceFleetInstanceTypeConfigs[]? InstanceTypeConfigsInput
        {
            get => GetInstanceProperty<aws.Emr.IEmrClusterMasterInstanceFleetInstanceTypeConfigs[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "launchSpecificationsInput", typeJson: "{\"fqn\":\"aws.emr.EmrClusterMasterInstanceFleetLaunchSpecifications\"}", isOptional: true)]
        public virtual aws.Emr.IEmrClusterMasterInstanceFleetLaunchSpecifications? LaunchSpecificationsInput
        {
            get => GetInstanceProperty<aws.Emr.IEmrClusterMasterInstanceFleetLaunchSpecifications?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetOnDemandCapacityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TargetOnDemandCapacityInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetSpotCapacityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TargetSpotCapacityInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "instanceTypeConfigs", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrClusterMasterInstanceFleetInstanceTypeConfigs\"},\"kind\":\"array\"}}")]
        public virtual aws.Emr.IEmrClusterMasterInstanceFleetInstanceTypeConfigs[] InstanceTypeConfigs
        {
            get => GetInstanceProperty<aws.Emr.IEmrClusterMasterInstanceFleetInstanceTypeConfigs[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetOnDemandCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TargetOnDemandCapacity
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetSpotCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TargetSpotCapacity
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.emr.EmrClusterMasterInstanceFleet\"}", isOptional: true)]
        public virtual aws.Emr.IEmrClusterMasterInstanceFleet? InternalValue
        {
            get => GetInstanceProperty<aws.Emr.IEmrClusterMasterInstanceFleet?>();
            set => SetInstanceProperty(value);
        }
    }
}
