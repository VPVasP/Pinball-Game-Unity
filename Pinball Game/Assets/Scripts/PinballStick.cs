using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinballStick : MonoBehaviour
{
    public float restPosition = 0f;
    public float pressedPosition = 45f;
    public float stickStrength = 1000000f;
    public float pinballDamper = 150f;
    public string inputName;
    HingeJoint hinge;
    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;
    }

    // Update is called once per frame
    void Update()
    {
        JointSpring spring = new JointSpring();
        spring.spring = stickStrength;
        spring.damper = pinballDamper;
        if (Input.GetAxis(inputName) == 1)
        {
            spring.targetPosition = pressedPosition;
        }
        else
        {
            spring.targetPosition = restPosition;
        }
        hinge.spring = spring;
        hinge.useLimits = true;
    }
}

