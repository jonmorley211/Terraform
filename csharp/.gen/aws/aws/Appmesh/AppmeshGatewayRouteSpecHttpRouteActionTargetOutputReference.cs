using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshGatewayRouteSpecHttpRouteActionTargetOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshGatewayRouteSpecHttpRouteActionTargetOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppmeshGatewayRouteSpecHttpRouteActionTargetOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AppmeshGatewayRouteSpecHttpRouteActionTargetOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshGatewayRouteSpecHttpRouteActionTargetOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshGatewayRouteSpecHttpRouteActionTargetOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putVirtualService", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttpRouteActionTargetVirtualService\"}}]")]
        public virtual void PutVirtualService(aws.Appmesh.IAppmeshGatewayRouteSpecHttpRouteActionTargetVirtualService @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshGatewayRouteSpecHttpRouteActionTargetVirtualService)}, new object[]{@value});
        }

        [JsiiProperty(name: "virtualService", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttpRouteActionTargetVirtualServiceOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshGatewayRouteSpecHttpRouteActionTargetVirtualServiceOutputReference VirtualService
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshGatewayRouteSpecHttpRouteActionTargetVirtualServiceOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "virtualServiceInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttpRouteActionTargetVirtualService\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshGatewayRouteSpecHttpRouteActionTargetVirtualService? VirtualServiceInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshGatewayRouteSpecHttpRouteActionTargetVirtualService?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttpRouteActionTarget\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshGatewayRouteSpecHttpRouteActionTarget? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshGatewayRouteSpecHttpRouteActionTarget?>();
            set => SetInstanceProperty(value);
        }
    }
}
