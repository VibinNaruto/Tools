using UnityEngine;

[CreateAssetMenu(menuName = "Single Attributes/Vector3Dataa")]
public class Vector3Dataa : JonID
{
    public Vector3 value;
       
    public void UpdateValue(Transform obj)
    {
        value = obj.position;
    }

    public void UpdateTransform(Transform obj)
    {
        obj.localPosition = value;  
    }
}