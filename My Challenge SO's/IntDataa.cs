using UnityEngine;
using UnityEngine.Events;
using Object = UnityEngine.Object;

[CreateAssetMenu(menuName = "Single Attributes/IntDataa")]
public class IntDataa : JonID
{
    public int value;
    private int currentValue;
    public UnityEvent decrementEvent, valueChangeEvent, atZeroEvent, compareTrueEvent, enableEvent, atMinValue;

    private void OnEnable() => enableEvent?.Invoke();

    public void SetValue(int amount) => UpdateValue(amount);

    public void UpdateFromCurrentValue() => UpdateValue(currentValue);

    public void UpdateCurrentValue() => currentValue = value;

    public void UpdateValue(int amount)
    {
        value += amount;
        valueChangeEvent.Invoke();
    }

    public void IncrementValue() => UpdateValue(1);

    public void DecrementToZero()
    {
        if (value > 0)
        {
            value--;
            decrementEvent.Invoke();
        }
        if (value == 0) atZeroEvent.Invoke();
    }

    public void UpdateValue(Object data)
    {
        var newData = data as IntData;
        if (newData != null) value += newData.value;
        valueChangeEvent.Invoke();
    }

    public void SetValue(Object data)
    {
        var newData = data as IntData;
        if (newData != null) value = newData.value;
        valueChangeEvent.Invoke();
    }

    public void CompareValue(int num) => CompareValue(new IntData { value = num });

    public void CompareValue(IntData data)
    {
        if (value < data.value) value = data.value;
        if (value == data.value) compareTrueEvent.Invoke();
    }

    public void CheckMinValue(int num)
    {
        if (value <= num)
        {
            value = num;
            atMinValue.Invoke();
        }
    }
}
