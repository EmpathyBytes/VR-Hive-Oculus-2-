using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;
//using UnityEngine.XR.Interaction.Toolkit;

public class LocomotionController : MonoBehaviour
{
    public XRController leftTeleportRay;
    public XRController rightTeleportRay;
    //public InputHelpers.Button teleportatAtivationButton;
    public float activationThreshold = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if(leftTeleportRay)
        {
            leftTeleportRay.gameObject.SetActive(CheckIfActivated(leftTeleportRay));
        }
        
        if(rightTeleportRay)
        {
            rightTeleportRay.gameObject.SetActive(CheckIfActivated(rightTeleportRay));
        }
    }

    public bool CheckIfActivated(XRController controller)
    {
        InputHelpers.IsPressed(controller.inputDevice, teleportatAtivationButton, out bool isActivated, activationThreshold);
        return isActivated;*/
    }
}
