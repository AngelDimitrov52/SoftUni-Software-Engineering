using System;

namespace P02.Graphic_Editor
{
    class Program
    {
        static void Main()
        {
            Circle circle = new Circle();
            Rectangle rec = new Rectangle();
            Square square = new Square();
            Piramid piamid = new Piramid();

            GraphicEditor graphicEditor = new GraphicEditor();
            graphicEditor.DrawShape(circle);
            graphicEditor.DrawShape(rec);
            graphicEditor.DrawShape(square);
            graphicEditor.DrawShape(piamid);

        }
    }
}
