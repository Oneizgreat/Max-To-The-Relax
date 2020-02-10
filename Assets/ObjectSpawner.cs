using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public int numberOfObjs;
    public GameObject objectToSpawn;
    public float spread;

    void Start()
    {
        for (int i = 0; i < numberOfObjs; i++)
        {
            Instantiate(objectToSpawn, newV3place(),Quaternion.identity);
        }
    }

    public void ShiftObject(Transform o)
    {
        Vector3 newplace = newV3place();
        newplace.z = 0f;
        o.position = newplace;
    }

    Vector3 newV3place()
    {
        Vector3 newVector = new Vector3(randomStrength(),randomStrength(), randomStrength());
        return newVector;
    }
    float randomStrength()
    {
        float i = (Random.value - 0.5f) * spread * 2;
        return i;
    }

}
