namespace Kimtak.Client.Presenter;

public class CounterPresenter : IPresenter
{
    private int currentCount = default;

    public int CurrentCount => currentCount;

    public CounterPresenter()
    {
        this.currentCount = 0;
    }

    public void IncrementCount()
    {
        this.currentCount++;
    }
}
