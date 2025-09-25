using Tekenprogramma;

namespace TekenprogrammaAdvanced;

internal interface IDrawable
{
    void DrawRectangle(Rechthoek r);
    void DrawCircle(Cirkel c);
    void DrawTriangle(Driehoek d);
}