// Copyright (c) 2014-2015 Wolfgang Borgsmüller
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without 
// modification, are permitted provided that the following conditions 
// are met:
// 
// 1. Redistributions of source code must retain the above copyright 
//    notice, this list of conditions and the following disclaimer.
// 
// 2. Redistributions in binary form must reproduce the above copyright 
//    notice, this list of conditions and the following disclaimer in the 
//    documentation and/or other materials provided with the distribution.
// 
// 3. Neither the name of the copyright holder nor the names of its 
//    contributors may be used to endorse or promote products derived 
//    from this software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS 
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT 
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS 
// FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE 
// COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, 
// INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 
// BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS 
// OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND 
// ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR 
// TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE 
// USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

// Generated file. Do not edit.


using System;

namespace Chromium.Remote {

    internal class CfxRectCtorRemoteCall : CtorRemoteCall {

        internal CfxRectCtorRemoteCall()
            : base(RemoteCallId.CfxRectCtorRemoteCall) {}

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.Rect.cfx_rect_ctor();
        }
    }

    internal class CfxRectDtorRemoteCall : DtorRemoteCall {

        internal CfxRectDtorRemoteCall()
            : base(RemoteCallId.CfxRectDtorRemoteCall) {}

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            CfxApi.Rect.cfx_rect_dtor(nativePtr);
        }
    }

    internal class CfxRectGetXRemoteCall : RemoteCall {

        internal CfxRectGetXRemoteCall()
            : base(RemoteCallId.CfxRectGetXRemoteCall) {}
        internal IntPtr sender;
        internal int value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }
        protected override void WriteReturn(StreamHandler h) { h.Write(value); }
        protected override void ReadReturn(StreamHandler h) { h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            CfxApi.Rect.cfx_rect_get_x(sender, out value);
        }
    }
    internal class CfxRectSetXRemoteCall : RemoteCall {

        internal CfxRectSetXRemoteCall()
            : base(RemoteCallId.CfxRectSetXRemoteCall) {}
        internal IntPtr sender;
        internal int value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); h.Write(value); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            CfxApi.Rect.cfx_rect_set_x(sender, value);
        }
    }
    internal class CfxRectGetYRemoteCall : RemoteCall {

        internal CfxRectGetYRemoteCall()
            : base(RemoteCallId.CfxRectGetYRemoteCall) {}
        internal IntPtr sender;
        internal int value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }
        protected override void WriteReturn(StreamHandler h) { h.Write(value); }
        protected override void ReadReturn(StreamHandler h) { h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            CfxApi.Rect.cfx_rect_get_y(sender, out value);
        }
    }
    internal class CfxRectSetYRemoteCall : RemoteCall {

        internal CfxRectSetYRemoteCall()
            : base(RemoteCallId.CfxRectSetYRemoteCall) {}
        internal IntPtr sender;
        internal int value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); h.Write(value); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            CfxApi.Rect.cfx_rect_set_y(sender, value);
        }
    }
    internal class CfxRectGetWidthRemoteCall : RemoteCall {

        internal CfxRectGetWidthRemoteCall()
            : base(RemoteCallId.CfxRectGetWidthRemoteCall) {}
        internal IntPtr sender;
        internal int value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }
        protected override void WriteReturn(StreamHandler h) { h.Write(value); }
        protected override void ReadReturn(StreamHandler h) { h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            CfxApi.Rect.cfx_rect_get_width(sender, out value);
        }
    }
    internal class CfxRectSetWidthRemoteCall : RemoteCall {

        internal CfxRectSetWidthRemoteCall()
            : base(RemoteCallId.CfxRectSetWidthRemoteCall) {}
        internal IntPtr sender;
        internal int value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); h.Write(value); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            CfxApi.Rect.cfx_rect_set_width(sender, value);
        }
    }
    internal class CfxRectGetHeightRemoteCall : RemoteCall {

        internal CfxRectGetHeightRemoteCall()
            : base(RemoteCallId.CfxRectGetHeightRemoteCall) {}
        internal IntPtr sender;
        internal int value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); }
        protected override void WriteReturn(StreamHandler h) { h.Write(value); }
        protected override void ReadReturn(StreamHandler h) { h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            CfxApi.Rect.cfx_rect_get_height(sender, out value);
        }
    }
    internal class CfxRectSetHeightRemoteCall : RemoteCall {

        internal CfxRectSetHeightRemoteCall()
            : base(RemoteCallId.CfxRectSetHeightRemoteCall) {}
        internal IntPtr sender;
        internal int value;
        protected override void WriteArgs(StreamHandler h) { h.Write(sender); h.Write(value); }
        protected override void ReadArgs(StreamHandler h) { h.Read(out sender); h.Read(out value); }
        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            CfxApi.Rect.cfx_rect_set_height(sender, value);
        }
    }
}
