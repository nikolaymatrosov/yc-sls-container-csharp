using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbKafkaConnector
{
    [JsiiClass(nativeType: typeof(yandex.MdbKafkaConnector.MdbKafkaConnectorConnectorConfigS3SinkOutputReference), fullyQualifiedName: "yandex.mdbKafkaConnector.MdbKafkaConnectorConnectorConfigS3SinkOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class MdbKafkaConnectorConnectorConfigS3SinkOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public MdbKafkaConnectorConnectorConfigS3SinkOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MdbKafkaConnectorConnectorConfigS3SinkOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MdbKafkaConnectorConnectorConfigS3SinkOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putS3Connection", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.mdbKafkaConnector.MdbKafkaConnectorConnectorConfigS3SinkS3Connection\"}}]")]
        public virtual void PutS3Connection(yandex.MdbKafkaConnector.IMdbKafkaConnectorConnectorConfigS3SinkS3Connection @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.MdbKafkaConnector.IMdbKafkaConnectorConnectorConfigS3SinkS3Connection)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFileMaxRecords")]
        public virtual void ResetFileMaxRecords()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "s3Connection", typeJson: "{\"fqn\":\"yandex.mdbKafkaConnector.MdbKafkaConnectorConnectorConfigS3SinkS3ConnectionOutputReference\"}")]
        public virtual yandex.MdbKafkaConnector.MdbKafkaConnectorConnectorConfigS3SinkS3ConnectionOutputReference S3Connection
        {
            get => GetInstanceProperty<yandex.MdbKafkaConnector.MdbKafkaConnectorConnectorConfigS3SinkS3ConnectionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "fileCompressionTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FileCompressionTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fileMaxRecordsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? FileMaxRecordsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3ConnectionInput", typeJson: "{\"fqn\":\"yandex.mdbKafkaConnector.MdbKafkaConnectorConnectorConfigS3SinkS3Connection\"}", isOptional: true)]
        public virtual yandex.MdbKafkaConnector.IMdbKafkaConnectorConnectorConfigS3SinkS3Connection? S3ConnectionInput
        {
            get => GetInstanceProperty<yandex.MdbKafkaConnector.IMdbKafkaConnectorConnectorConfigS3SinkS3Connection?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "topicsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TopicsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "fileCompressionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FileCompressionType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fileMaxRecords", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FileMaxRecords
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "topics", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Topics
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"yandex.mdbKafkaConnector.MdbKafkaConnectorConnectorConfigS3Sink\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case yandex.MdbKafkaConnector.IMdbKafkaConnectorConnectorConfigS3Sink cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(yandex.MdbKafkaConnector.IMdbKafkaConnectorConnectorConfigS3Sink).FullName}, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
