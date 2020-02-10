using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtMovement : MonoBehaviour
{
    public UInput UInput;
    ObjectSpawner Spawner;
    public float distShiftThreshold;
    float lifetime;

    private void Start()
    {
        UInput = FindObjectOfType<UInput>();
        Spawner = FindObjectOfType<ObjectSpawner>();
    }

    void Update()
    {
        Vector3 currentPosition = transform.position;
        Vector3 moveVector = new Vector3(0,0,1);
        transform.position = currentPosition - (moveVector * Time.deltaTime * UInput.speed) ;

        float distToPlayer = Vector3.Distance(transform.position, Vector3.zero);
        if (distToPlayer > distShiftThreshold)
        {
            Spawner.ShiftObject(transform);
        }
    }
}
