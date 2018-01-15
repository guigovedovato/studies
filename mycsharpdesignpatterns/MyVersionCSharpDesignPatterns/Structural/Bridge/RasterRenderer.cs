namespace MyVersionCSharpDesignPatterns.Structural.Bridge
{
    public class RasterRenderer : IRenderer
    {
        public string WhatToRenderAs
        {
            get { return "pixels"; }
        }
    }
}
