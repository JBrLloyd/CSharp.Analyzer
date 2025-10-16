namespace SampleApp;

public class Sample
{
    private int _field;

    public Sample()
    {
        _field = 0;
    }

    public Sample(int field)
    {
        _field = field;
    }

    public int Value => _field;

    public void Update(int newValue)
    {
        if (!CanUpdate(newValue))
        {
            return;
        }

        _field = newValue;
    }

    private bool CanUpdate(int newValue)
    {
        return newValue != _field;
    }
}
