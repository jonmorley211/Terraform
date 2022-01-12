using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Emr
{
    [JsiiClass(nativeType: typeof(aws.Emr.EmrClusterMasterInstanceFleetLaunchSpecificationsOutputReference), fullyQualifiedName: "aws.emr.EmrClusterMasterInstanceFleetLaunchSpecificationsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class EmrClusterMasterInstanceFleetLaunchSpecificationsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public EmrClusterMasterInstanceFleetLaunchSpecificationsOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EmrClusterMasterInstanceFleetLaunchSpecificationsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EmrClusterMasterInstanceFleetLaunchSpecificationsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetOnDemandSpecification")]
        public virtual void ResetOnDemandSpecification()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSpotSpecification")]
        public virtual void ResetSpotSpecification()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "onDemandSpecificationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrClusterMasterInstanceFleetLaunchSpecificationsOnDemandSpecification\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Emr.IEmrClusterMasterInstanceFleetLaunchSpecificationsOnDemandSpecification[]? OnDemandSpecificationInput
        {
            get => GetInstanceProperty<aws.Emr.IEmrClusterMasterInstanceFleetLaunchSpecificationsOnDemandSpecification[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "spotSpecificationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrClusterMasterInstanceFleetLaunchSpecificationsSpotSpecification\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Emr.IEmrClusterMasterInstanceFleetLaunchSpecificationsSpotSpecification[]? SpotSpecificationInput
        {
            get => GetInstanceProperty<aws.Emr.IEmrClusterMasterInstanceFleetLaunchSpecificationsSpotSpecification[]?>();
        }

        [JsiiProperty(name: "onDemandSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrClusterMasterInstanceFleetLaunchSpecificationsOnDemandSpecification\"},\"kind\":\"array\"}}")]
        public virtual aws.Emr.IEmrClusterMasterInstanceFleetLaunchSpecificationsOnDemandSpecification[] OnDemandSpecification
        {
            get => GetInstanceProperty<aws.Emr.IEmrClusterMasterInstanceFleetLaunchSpecificationsOnDemandSpecification[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "spotSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrClusterMasterInstanceFleetLaunchSpecificationsSpotSpecification\"},\"kind\":\"array\"}}")]
        public virtual aws.Emr.IEmrClusterMasterInstanceFleetLaunchSpecificationsSpotSpecification[] SpotSpecification
        {
            get => GetInstanceProperty<aws.Emr.IEmrClusterMasterInstanceFleetLaunchSpecificationsSpotSpecification[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.emr.EmrClusterMasterInstanceFleetLaunchSpecifications\"}", isOptional: true)]
        public virtual aws.Emr.IEmrClusterMasterInstanceFleetLaunchSpecifications? InternalValue
        {
            get => GetInstanceProperty<aws.Emr.IEmrClusterMasterInstanceFleetLaunchSpecifications?>();
            set => SetInstanceProperty(value);
        }
    }
}
