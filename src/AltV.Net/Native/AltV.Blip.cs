using System;
using System.Runtime.InteropServices;

namespace AltV.Net.Native
{
    internal static partial class Alt
    {
        internal static class Blip
        {
            [DllImport(_dllName, CallingConvention = _callingConvention)]
            internal static extern bool Blip_IsGlobal(IntPtr blipPointer);

            [DllImport(_dllName, CallingConvention = _callingConvention)]
            internal static extern bool Blip_IsAttached(IntPtr blipPointer);

            [DllImport(_dllName, CallingConvention = _callingConvention)]
            internal static extern IntPtr Blip_AttachedTo(IntPtr blipPointer);

            [DllImport(_dllName, CallingConvention = _callingConvention)]
            internal static extern uint Blip_GetType(IntPtr blipPointer);

            [DllImport(_dllName, CallingConvention = _callingConvention)]
            internal static extern uint Blip_SetSprite(IntPtr blipPointer, uint sprite);

            [DllImport(_dllName, CallingConvention = _callingConvention)]
            internal static extern void Blip_SetColor(IntPtr blipPointer, uint color);

            [DllImport(_dllName, CallingConvention = _callingConvention)]
            internal static extern void Blip_SetRoute(IntPtr blipPointer, bool state);

            [DllImport(_dllName, CallingConvention = _callingConvention)]
            internal static extern void Blip_SetRouteColor(IntPtr blipPointer, uint color);
        }
    }
}