namespace MyVersionCSharpDesignPatterns.Structural.Bridge
{
    public abstract class Shape
    {
        private IRenderer rendering;

        protected Shape(IRenderer rendering)
        {
            this.rendering = rendering;
        }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"Drawing {Name} as {rendering.WhatToRenderAs}";
        }
    }
}
