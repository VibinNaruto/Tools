using System;
using UnityEngine;
using UnityEngine.Events;

[ExecuteInEditMode]
[CreateAssetMenu(menuName = "Single Attributes/FloatDataa")]
public class FloatDataa : JonID
{
    public float value;
    public UnityEvent minValueEvent, maxValueEvent, updateValueEvent;

    public void SetValue(float amount) => UpdateValue(amount);

    public void UpdateValue(float amount)
    {
        value += amount;
        updateValueEvent.Invoke();
    }

    public void IncrementValue() => UpdateValue(1f);

    public void UpdateValue(FloatData data) => UpdateValue(data?.value ?? 0f);

    public void SetValue(FloatData data) => value = data?.value ?? 0f;

    public void CheckMinValue(float minValue)
    {
        if (value < minValue)
        {
            minValueEvent.Invoke();
            value = minValue;
        }
    }
    public void CheckMaxValue(float maxValue)
    {
        if (value >= maxValue)
        {
            maxValueEvent.Invoke();
            value = maxValue;
        }
    }
}
