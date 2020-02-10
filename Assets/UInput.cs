using UnityEngine;

public class UInput : MonoBehaviour
{

    public float speed;
    public Vector3 direction;


    void Start()
    {
        speed = 10;
        direction = Quaternion.identity.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
