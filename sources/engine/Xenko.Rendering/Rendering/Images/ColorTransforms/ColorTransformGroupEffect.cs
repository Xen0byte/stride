﻿// <auto-generated>
// Do not edit this file yourself!
//
// This code was generated by Xenko Shader Mixin Code Generator.
// To generate it yourself, please install Xenko.VisualStudio.Package .vsix
// and re-save the associated .xkfx.
// </auto-generated>

using System;
using Xenko.Core;
using Xenko.Rendering;
using Xenko.Graphics;
using Xenko.Shaders;
using Xenko.Core.Mathematics;
using Buffer = Xenko.Graphics.Buffer;

namespace Xenko.Rendering.Images
{
    internal static partial class ShaderMixins
    {
        internal partial class ColorTransformCompose  : IShaderMixinBuilder
        {
            public void Generate(ShaderMixinSource mixin, ShaderMixinContext context)
            {
                context.Mixin(mixin, context.GetParam(ColorTransformKeys.Shader), context.GetParam(ColorTransformKeys.GenericArguments));
            }

            [ModuleInitializer]
            internal static void __Initialize__()

            {
                ShaderMixinManager.Register("ColorTransformCompose", new ColorTransformCompose());
            }
        }
    }
    internal static partial class ShaderMixins
    {
        internal partial class ColorTransformGroupEffect  : IShaderMixinBuilder
        {
            public void Generate(ShaderMixinSource mixin, ShaderMixinContext context)
            {
                context.Mixin(mixin, "ColorTransformGroupShader");
                foreach(var colorTransform in context.GetParam(ColorTransformGroupKeys.Transforms))

                {
                    context.PushParameters(colorTransform.Parameters);

                    {
                        var __mixinToCompose__ = "ColorTransformCompose";
                        var __subMixin = new ShaderMixinSource();
                        context.PushCompositionArray(mixin, "Transforms", __subMixin);
                        context.Mixin(__subMixin, __mixinToCompose__);
                        context.PopComposition();
                    }
                    context.PopParameters();
                }
            }

            [ModuleInitializer]
            internal static void __Initialize__()

            {
                ShaderMixinManager.Register("ColorTransformGroupEffect", new ColorTransformGroupEffect());
            }
        }
    }
}