using System;
using System.Reflection.Metadata;

namespace DesignPatternsDemo
{
    public interface IRenderer
    {
        void Render(string shap);
    }
    public class RasterRenderer : IRenderer
    {
        public void Render(string shape)
        {
            Console.WriteLine("Raster rendering: " + shape);
        }
    }
    public class VectorRenderer : IRenderer
    {
        public void Render(string shape)
        {
            Console.WriteLine("Vector rendering: " + shape);
        }
    }

    public abstract class Shape
    {
        protected IRenderer renderer;
        protected Shape(IRenderer renderer)
        {
            this.renderer = renderer;
        }

        public abstract void Draw();
    }

    public class Circle : Shape
    {
        public Circle(IRenderer renderer) : base(renderer) { }

        public override void Draw()
        {
            renderer.Render("Circle");
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape shape1 = new Circle(new VectorRenderer());
            shape1.Draw();

            Shape shape2 = new Circle(new RasterRenderer());
            shape2.Draw();
        }
    }
}
