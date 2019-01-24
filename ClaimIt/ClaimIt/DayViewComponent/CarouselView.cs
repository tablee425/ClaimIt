
namespace ClaimIt.DayViewComponent
{
  public class CarouselView : CardsView
  {
    public CarouselView() : this(new BaseCarouselFrontViewProcessor(), new BaseCarouselBackViewProcessor())
    {
    }

    public CarouselView(ICardProcessor frontViewProcessor, ICardProcessor backViewProcessor) : base(frontViewProcessor, backViewProcessor)
    {
      IsClippedToBounds = true;
    }

    protected override double DefaultMoveWidthPercentage => .3;

    protected override bool DefaultIsCyclical => true;
  }
}
