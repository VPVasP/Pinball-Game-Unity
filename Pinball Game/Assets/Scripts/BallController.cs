using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("AddForceAfterTime", 2f);
    }

  private void AddForceAfterTime()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.back * 5f, ForceMode.Impulse);
    }
}
