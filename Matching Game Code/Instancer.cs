using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class Instancer : ScriptableObject
{
    public GameObject prefab;

    private int num;

    public void CreateInstance()
    {
        Instantiate(prefab);
    }
    public void CreateInstance(Vector3Data obj)
    {
        Instantiate(prefab, obj.value, Quaternion.identity);
    }

    public void CreateInstanceFromList(Vector3DataList obj)
    {
        for (var i = 0; i <obj.vector3DataList.Count; i++)
        {
             Instantiate(prefab,obj.vector3DataList[i].value, Quaternion.identity);
        }
    }

    public void CreateInstanceFromListCounting(Vector3DataList obj)
    {
        Instantiate(prefab,obj.vector3DataList[num].value, Quaternion.identity);
        num++;
        if (num == obj.vector3DataList.Count)
        {
            num = 0;
        }
    }

    public void CreateInstanceFromListRandomly(Vector3DataList obj)
    {
        num = Random.Range(0, obj.vector3DataList.Count - 1);
        Instantiate(prefab,obj.vector3DataList[num].value, Quaternion.identity);
    }

     
}