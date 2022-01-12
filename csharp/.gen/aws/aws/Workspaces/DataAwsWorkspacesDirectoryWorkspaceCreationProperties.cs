using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Workspaces
{
    [JsiiClass(nativeType: typeof(aws.Workspaces.DataAwsWorkspacesDirectoryWorkspaceCreationProperties), fullyQualifiedName: "aws.workspaces.DataAwsWorkspacesDirectoryWorkspaceCreationProperties", parametersJson: "[{\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"complexComputedListIndex\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAwsWorkspacesDirectoryWorkspaceCreationProperties : HashiCorp.Cdktf.ComplexComputedList
    {
        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        public DataAwsWorkspacesDirectoryWorkspaceCreationProperties(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, string complexComputedListIndex): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexComputedListIndex}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsWorkspacesDirectoryWorkspaceCreationProperties(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsWorkspacesDirectoryWorkspaceCreationProperties(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "customSecurityGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomSecurityGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultOu", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultOu
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enableInternetAccess", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object EnableInternetAccess
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "enableMaintenanceMode", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object EnableMaintenanceMode
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "userEnabledAsLocalAdministrator", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object UserEnabledAsLocalAdministrator
        {
            get => GetInstanceProperty<object>()!;
        }
    }
}
