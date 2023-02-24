using System.IO;
using UnityEngine;

namespace TobisUtils
{
    public static class LoadData
    {
        public static Texture2D ImageAsset(string path)
        {
            Texture2D tex = new Texture2D(2, 2);
            // A small 64x64 Unity logo encoded into a PNG.
            byte[] pngBytes = File.ReadAllBytes(path);

            tex.LoadImage(pngBytes);

            return tex;
        }
    }
}