// *** WARNING: this file was generated by . ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.MadeupPackage.Codegentest
{
    public static class FuncWithDictParam
    {
        /// <summary>
        /// Check codegen of functions with a Dict&lt;str,str&gt; parameter.
        /// </summary>
        public static Task<FuncWithDictParamResult> InvokeAsync(FuncWithDictParamArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<FuncWithDictParamResult>("madeup-package:codegentest:funcWithDictParam", args ?? new FuncWithDictParamArgs(), options.WithVersion());

        public static Output<FuncWithDictParamResult> Invoke(FuncWithDictParamOutputArgs? args = null, InvokeOptions? options = null)
        {
            args = args ?? new FuncWithDictParamOutputArgs();
            return Pulumi.Output.All(
                args.A.Box(),
                args.B.Box()
            ).Apply(a => {
                    var args = new FuncWithDictParamArgs();
                    a[0].Set(args, nameof(args.A));
                    a[1].Set(args, nameof(args.B));
                    return InvokeAsync(args, options);
            });
        }
    }


    public sealed class FuncWithDictParamArgs : Pulumi.InvokeArgs
    {
        [Input("a")]
        private Dictionary<string, string>? _a;
        public Dictionary<string, string> A
        {
            get => _a ?? (_a = new Dictionary<string, string>());
            set => _a = value;
        }

        [Input("b")]
        public string? B { get; set; }

        public FuncWithDictParamArgs()
        {
        }
    }

    public sealed class FuncWithDictParamOutputArgs : Pulumi.InvokeArgs
    {
        [Input("a")]
        private InputMap<string>? _a;
        public InputMap<string> A
        {
            get => _a ?? (_a = new InputMap<string>());
            set => _a = value;
        }

        [Input("b")]
        public Input<string>? B { get; set; }

        public FuncWithDictParamOutputArgs()
        {
        }
    }


    [OutputType]
    public sealed class FuncWithDictParamResult
    {
        public readonly string R;

        [OutputConstructor]
        private FuncWithDictParamResult(string r)
        {
            R = r;
        }
    }
}
