using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Fsx
{
    [JsiiClass(nativeType: typeof(aws.Fsx.FsxOntapStorageVirtualMachineEndpoints), fullyQualifiedName: "aws.fsx.FsxOntapStorageVirtualMachineEndpoints", parametersJson: "[{\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"complexComputedListIndex\",\"type\":{\"primitive\":\"string\"}}]")]
    public class FsxOntapStorageVirtualMachineEndpoints : HashiCorp.Cdktf.ComplexComputedList
    {
        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        public FsxOntapStorageVirtualMachineEndpoints(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, string complexComputedListIndex): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexComputedListIndex}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FsxOntapStorageVirtualMachineEndpoints(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FsxOntapStorageVirtualMachineEndpoints(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "iscsi", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object Iscsi
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "management", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object Management
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "nfs", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object Nfs
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "smb", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object Smb
        {
            get => GetInstanceProperty<object>()!;
        }
    }
}
