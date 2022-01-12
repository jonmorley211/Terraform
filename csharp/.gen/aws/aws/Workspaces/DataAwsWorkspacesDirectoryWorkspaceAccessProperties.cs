using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Workspaces
{
    [JsiiClass(nativeType: typeof(aws.Workspaces.DataAwsWorkspacesDirectoryWorkspaceAccessProperties), fullyQualifiedName: "aws.workspaces.DataAwsWorkspacesDirectoryWorkspaceAccessProperties", parametersJson: "[{\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"complexComputedListIndex\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAwsWorkspacesDirectoryWorkspaceAccessProperties : HashiCorp.Cdktf.ComplexComputedList
    {
        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        public DataAwsWorkspacesDirectoryWorkspaceAccessProperties(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, string complexComputedListIndex): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexComputedListIndex}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsWorkspacesDirectoryWorkspaceAccessProperties(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsWorkspacesDirectoryWorkspaceAccessProperties(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "deviceTypeAndroid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeviceTypeAndroid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deviceTypeChromeos", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeviceTypeChromeos
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deviceTypeIos", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeviceTypeIos
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deviceTypeLinux", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeviceTypeLinux
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deviceTypeOsx", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeviceTypeOsx
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deviceTypeWeb", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeviceTypeWeb
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deviceTypeWindows", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeviceTypeWindows
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deviceTypeZeroclient", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeviceTypeZeroclient
        {
            get => GetInstanceProperty<string>()!;
        }
    }
}
