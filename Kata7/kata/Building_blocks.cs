namespace kata
{
  public class Block
  {
    private readonly int Width, Length, Height;
    public Block(int[] dimensions)
    {
      Width = dimensions[0];
      Length = dimensions[1];
      Height = dimensions[2];
    }
    public int GetWidth() => Width;
    public int GetLength() => Length;
    public int GetHeight() => Height;
    public int GetVolume() => (Height * Width * Length);
    public int GetSurfaceArea() => 2 * (Height * Width + Width * Length + Height * Length);
  }
}