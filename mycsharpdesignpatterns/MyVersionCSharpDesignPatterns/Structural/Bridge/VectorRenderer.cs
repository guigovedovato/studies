namespace MyVersionCSharpDesignPatterns.Structural.Bridge
{
    public class VectorRenderer : IRenderer
    {
        public string WhatToRenderAs
        {
            get { return "lines"; }
        }
    }
}
