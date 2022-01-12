using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Workspaces
{
    [JsiiClass(nativeType: typeof(aws.Workspaces.DataAwsWorkspacesWorkspaceWorkspaceProperties), fullyQualifiedName: "aws.workspaces.DataAwsWorkspacesWorkspaceWorkspaceProperties", parametersJson: "[{\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"complexComputedListIndex\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAwsWorkspacesWorkspaceWorkspaceProperties : HashiCorp.Cdktf.ComplexComputedList
    {
        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        public DataAwsWorkspacesWorkspaceWorkspaceProperties(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, string complexComputedListIndex): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexComputedListIndex}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsWorkspacesWorkspaceWorkspaceProperties(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsWorkspacesWorkspaceWorkspaceProperties(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "computeTypeName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeTypeName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rootVolumeSizeGib", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RootVolumeSizeGib
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "runningMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RunningMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "runningModeAutoStopTimeoutInMinutes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RunningModeAutoStopTimeoutInMinutes
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "userVolumeSizeGib", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double UserVolumeSizeGib
        {
            get => GetInstanceProperty<double>()!;
        }
    }
}
