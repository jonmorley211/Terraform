using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Workspaces
{
    [JsiiClass(nativeType: typeof(aws.Workspaces.DataAwsWorkspacesDirectorySelfServicePermissions), fullyQualifiedName: "aws.workspaces.DataAwsWorkspacesDirectorySelfServicePermissions", parametersJson: "[{\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"complexComputedListIndex\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAwsWorkspacesDirectorySelfServicePermissions : HashiCorp.Cdktf.ComplexComputedList
    {
        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        public DataAwsWorkspacesDirectorySelfServicePermissions(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, string complexComputedListIndex): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexComputedListIndex}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsWorkspacesDirectorySelfServicePermissions(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsWorkspacesDirectorySelfServicePermissions(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "changeComputeType", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object ChangeComputeType
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "increaseVolumeSize", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object IncreaseVolumeSize
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "rebuildWorkspace", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object RebuildWorkspace
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "restartWorkspace", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object RestartWorkspace
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "switchRunningMode", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object SwitchRunningMode
        {
            get => GetInstanceProperty<object>()!;
        }
    }
}
