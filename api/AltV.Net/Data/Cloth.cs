using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace AltV.Net.Data
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Cloth : IEquatable<Cloth>
    {
        public static Cloth Zero;

        public byte Drawable;
        public byte Texture;
        public byte Palette;

        public Cloth(byte drawable, byte texture, byte palette)
        {
            Drawable = drawable;
            Texture = texture;
            Palette = palette;
        }

        public override string ToString()
        {
            return $"Cloth(drawable: {Drawable}, texture: {Texture}, palette: {Palette})";
        }

        public static bool operator ==(Cloth cloth1, Cloth cloth2)
        {
            return cloth1.Drawable == cloth2.Drawable 
                   && cloth1.Texture == cloth2.Texture 
                   && cloth1.Palette == cloth2.Palette;
        }

        public static bool operator !=(Cloth cloth1, Cloth cloth2)
        {
            return cloth1.Drawable != cloth2.Drawable 
                   || cloth1.Texture != cloth2.Texture 
                   || cloth1.Palette != cloth2.Palette;
        }

        public override bool Equals(object obj)
        {
            return obj is Cloth other && Equals(other);
        }

        public bool Equals(Cloth other)
        {
            return Drawable == other.Drawable
                   && Texture == other.Texture
                   && Palette == other.Palette;
        }

        public override int GetHashCode() => HashCode.Combine(Drawable.GetHashCode(),
            Texture.GetHashCode(), Palette.GetHashCode());
    }
}