// ---------------------------------------------------------------------------------------
// <copyright file="GlobalSuppressions.cs" company="SharpBlade">
//     Copyright © 2013-2014 by Adam Hellberg and Brandon Scott.
// 
//     Permission is hereby granted, free of charge, to any person obtaining a copy of
//     this software and associated documentation files (the "Software"), to deal in
//     the Software without restriction, including without limitation the rights to
//     use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies
//     of the Software, and to permit persons to whom the Software is furnished to do
//     so, subject to the following conditions:
// 
//     The above copyright notice and this permission notice shall be included in all
//     copies or substantial portions of the Software.
// 
//     THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//     IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//     FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//     AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
//     WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
//     CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// 
//     Disclaimer: SharpBlade is in no way affiliated with Razer and/or any of
//     its employees and/or licensors. Adam Hellberg and/or Brandon Scott do not
//     take responsibility for any harm caused, direct or indirect, to any Razer
//     peripherals via the use of SharpBlade.
// 
//     "Razer" is a trademark of Razer USA Ltd.
// </copyright>
// ---------------------------------------------------------------------------------------

using System.Diagnostics.CodeAnalysis;

[assembly:
    SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "SharpBlade"
        )]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace",
        Target = "SharpBlade.Extensions")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace",
        Target = "SharpBlade.Helpers")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace",
        Target = "SharpBlade.Integration")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace",
        Target = "SharpBlade.Logging")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
        Target = "SharpBlade.DynamicKey.#Set(System.String,System.Int32)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
        Target = "SharpBlade.DynamicKey.#Set(System.String,System.String,System.Int32)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
        Target =
            "SharpBlade.DynamicKeys.#EnableDynamicKey(SharpBlade.Razer.DynamicKeyType,System.EventHandler,System.String,System.Boolean)"
        )]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
        Target =
            "SharpBlade.DynamicKeys.#EnableDynamicKey(SharpBlade.Razer.DynamicKeyType,System.EventHandler,System.String,System.String,System.Boolean)"
        )]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
        Target =
            "SharpBlade.DynamicKeys.#EnableDynamicKey(SharpBlade.Razer.DynamicKeyType,System.String,System.Boolean)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
        Target =
            "SharpBlade.DynamicKeys.#EnableDynamicKey(SharpBlade.Razer.DynamicKeyType,System.String,System.String,System.Boolean)"
        )]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
        Target =
            "SharpBlade.IRenderTarget.#DrawWindow(System.Windows.Window,System.Collections.Generic.IEnumerable`1<SharpBlade.Integration.EmbeddedWinFormsControl>)"
        )]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
        Target =
            "SharpBlade.IRenderTarget.#DrawWindow(System.Windows.Window,System.Collections.GenericMethods.IEnumerable`1<SharpBlade.Integration.EmbeddedWinFormsControl>)"
        )]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
        Target = "SharpBlade.IRenderTarget.#SetForm(System.Windows.Forms.Form,SharpBlade.RenderMethod,System.Int32)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
        Target = "SharpBlade.IRenderTarget.#SetWindow(System.Windows.Window,SharpBlade.RenderMethod)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
        Target = "SharpBlade.Logging.LogManager.#ClearOldLogs(System.Int32,System.String)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
        Target = "SharpBlade.Logging.LogManager.#LoadConfig(System.String)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
        Target = "SharpBlade.Rendering.BitmapRenderer.#.ctor(SharpBlade.Rendering.IBitmapProvider,System.Int32)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
        Target =
            "SharpBlade.Rendering.DynamicKeyImageRenderer.#.ctor(SharpBlade.Razer.DynamicKeyType,System.String,System.Int32)"
        )]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
        Target =
            "SharpBlade.Rendering.DynamicKeyImageRenderer.#.ctor(SharpBlade.Razer.DynamicKeyType,System.String,System.String,System.Int32)"
        )]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
        Target =
            "SharpBlade.Rendering.IRenderTarget.#Draw(System.Windows.Window,System.Collections.Generic.IEnumerable`1<SharpBlade.Integration.EmbeddedWinFormsControl>)"
        )]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
        Target = "SharpBlade.Rendering.IRenderTarget.#Set(SharpBlade.Rendering.IBitmapProvider,System.Int32)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
        Target = "SharpBlade.Rendering.IRenderTarget.#Set(System.String,System.Int32)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
        Target =
            "SharpBlade.Rendering.IRenderTarget.#Set(System.Windows.Forms.Form,SharpBlade.Rendering.RenderMethod,System.Int32)"
        )]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
        Target =
            "SharpBlade.Rendering.IRenderTarget.#Set(System.Windows.Window,SharpBlade.Rendering.RenderMethod,System.Int32)"
        )]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
        Target = "SharpBlade.Rendering.NativeRenderer.#.ctor(System.IntPtr,System.Int32)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
        Target = "SharpBlade.Rendering.RenderMethodNotSupportedException.#.ctor(System.String,System.Exception)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
        Target =
            "SharpBlade.Rendering.RenderTarget.#Draw(System.Windows.Window,System.Collections.Generic.IEnumerable`1<SharpBlade.Integration.EmbeddedWinFormsControl>)"
        )]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
        Target = "SharpBlade.Rendering.RenderTarget.#Set(SharpBlade.Rendering.IBitmapProvider,System.Int32)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
        Target = "SharpBlade.Rendering.RenderTarget.#Set(System.String,System.Int32)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
        Target =
            "SharpBlade.Rendering.RenderTarget.#Set(System.Windows.Forms.Form,SharpBlade.Rendering.RenderMethod,System.Int32)"
        )]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
        Target =
            "SharpBlade.Rendering.RenderTarget.#Set(System.Windows.Window,SharpBlade.Rendering.RenderMethod,System.Int32)"
        )]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
        Target = "SharpBlade.Rendering.TouchpadImageRenderer.#.ctor(System.String,System.Int32)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
        Target =
            "SharpBlade.Rendering.WpfRenderer.#.ctor(System.Windows.Window,SharpBlade.Rendering.RenderMethod,System.Int32)"
        )]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
        Target = "SharpBlade.Rendering.WpfRenderer.#.ctor(System.Windows.Window,System.Int32)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
        Target =
            "SharpBlade.Rendering.WpfRenderer.#Draw(SharpBlade.Rendering.IRenderTarget,System.Windows.Window,System.Collections.Generic.IEnumerable`1<SharpBlade.Integration.EmbeddedWinFormsControl>)"
        )]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
        Target =
            "SharpBlade.Switchblade.#StartWinFormsControlKeyboardCapture(System.Windows.Forms.Control,System.Boolean)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
        Target =
            "SharpBlade.Switchblade.#StartWpfControlKeyboardCapture(System.Windows.Controls.Control,System.Boolean)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
        Target = "SharpBlade.Touchpad.#Set(System.String,System.Int32)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
        Target =
            "SharpBlade.target.#DrawWindow(System.Windows.Window,System.Collections.Generic.IEnumerable`1<SharpBlade.Integration.EmbeddedWinFormsControl>)"
        )]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
        Target =
            "SharpBlade.target.#DrawWindow(System.Windows.Window,System.Collections.GenericMethods.IEnumerable`1<SharpBlade.Integration.EmbeddedWinFormsControl>)"
        )]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
        Target = "SharpBlade.target.#SetForm(System.Windows.Forms.Form,SharpBlade.RenderMethod,System.Int32)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
        Target = "SharpBlade.target.#SetWindow(System.Windows.Window,SharpBlade.Razer.RenderMethod)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
        Target = "SharpBlade.target.#SetWindow(System.Windows.Window,SharpBlade.RenderMethod)")]
[assembly: SuppressMessage("Microsoft.Design", "CA2210:AssembliesShouldHaveValidStrongNames")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Set", Scope = "member",
        Target = "SharpBlade.Rendering.IRenderTarget.#Set(SharpBlade.Rendering.IBitmapProvider,System.Int32)")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Set", Scope = "member",
        Target = "SharpBlade.Rendering.IRenderTarget.#Set(System.String,System.Int32)")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Set", Scope = "member",
        Target =
            "SharpBlade.Rendering.IRenderTarget.#Set(System.Windows.Forms.Form,SharpBlade.Rendering.RenderMethod,System.Int32)"
        )]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Set", Scope = "member",
        Target =
            "SharpBlade.Rendering.IRenderTarget.#Set(System.Windows.Window,SharpBlade.Rendering.RenderMethod,System.Int32)"
        )]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Set", Scope = "member",
        Target = "SharpBlade.Rendering.IRenderTarget.#Set`1(SharpBlade.Rendering.Renderer`1<!!0>)")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Stop", Scope = "member",
        Target = "SharpBlade.Rendering.IRenderer.#Stop()")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2243:AttributeStringLiteralsShouldParseCorrectly")]
