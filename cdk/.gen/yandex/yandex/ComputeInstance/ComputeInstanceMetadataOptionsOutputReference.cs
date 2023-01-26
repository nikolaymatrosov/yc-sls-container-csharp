using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.ComputeInstance
{
    [JsiiClass(nativeType: typeof(yandex.ComputeInstance.ComputeInstanceMetadataOptionsOutputReference), fullyQualifiedName: "yandex.computeInstance.ComputeInstanceMetadataOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ComputeInstanceMetadataOptionsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ComputeInstanceMetadataOptionsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ComputeInstanceMetadataOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ComputeInstanceMetadataOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAwsV1HttpEndpoint")]
        public virtual void ResetAwsV1HttpEndpoint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAwsV1HttpToken")]
        public virtual void ResetAwsV1HttpToken()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGceHttpEndpoint")]
        public virtual void ResetGceHttpEndpoint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGceHttpToken")]
        public virtual void ResetGceHttpToken()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "awsV1HttpEndpointInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AwsV1HttpEndpointInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "awsV1HttpTokenInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AwsV1HttpTokenInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gceHttpEndpointInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? GceHttpEndpointInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gceHttpTokenInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? GceHttpTokenInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "awsV1HttpEndpoint", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AwsV1HttpEndpoint
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "awsV1HttpToken", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AwsV1HttpToken
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "gceHttpEndpoint", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double GceHttpEndpoint
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "gceHttpToken", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double GceHttpToken
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.computeInstance.ComputeInstanceMetadataOptions\"}", isOptional: true)]
        public virtual yandex.ComputeInstance.IComputeInstanceMetadataOptions? InternalValue
        {
            get => GetInstanceProperty<yandex.ComputeInstance.IComputeInstanceMetadataOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
