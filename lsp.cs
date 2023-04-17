using System;

/// <summary>
/// Class Chim
/// </summary>
public class Bird
{
}

/// <summary>
/// Class Chim có thể bay
/// </summary>
public class FlyingBird : Bird
{
  /// <summary>
  /// Hàm Bay
  /// </summary>
  public virtual void Fly()
  {
    Console.WriteLine("I'm flying!!!");
  }
}

/// <summary>
/// Class Chim đại bàng
/// </summary>
public class Eagle : FlyingBird
{
  /// <summary>
  /// Chim đại bàng ghi đè hành động Bay của FlyingBird
  /// </summary>
  public override void Fly()
  {
    Console.WriteLine("I'm an eagle and I'm flying!!!");
  }
}

/// <summary>
/// Class Chim cánh cụt
/// </summary>
public class Penguin : Bird
{
}
