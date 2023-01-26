using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbVirtualHost
{
    [JsiiByValue(fqn: "yandex.albVirtualHost.AlbVirtualHostRouteRouteOptionsRbacPrincipalsAndPrincipals")]
    public class AlbVirtualHostRouteRouteOptionsRbacPrincipalsAndPrincipals : yandex.AlbVirtualHost.IAlbVirtualHostRouteRouteOptionsRbacPrincipalsAndPrincipals
    {
        private object? _any;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#any AlbVirtualHost#any}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "any", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Any
        {
            get => _any;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _any = value;
            }
        }

        /// <summary>header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#header AlbVirtualHost#header}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "header", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteRouteOptionsRbacPrincipalsAndPrincipalsHeader\"}", isOptional: true)]
        public yandex.AlbVirtualHost.IAlbVirtualHostRouteRouteOptionsRbacPrincipalsAndPrincipalsHeader? Header
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#remote_ip AlbVirtualHost#remote_ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "remoteIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RemoteIp
        {
            get;
            set;
        }
    }
}
