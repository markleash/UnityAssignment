using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraSwitcher : MonoBehaviour
{

    public CinemachineFreeLook[] cameras;

    // Start is called before the first frame update
    void Update()
    {
        if (TurnManager.currentPlayerIndex == 1)
        {
            cameras[1].gameObject.SetActive(false);
            cameras[0].gameObject.SetActive(true);
        } 

        else
        {
            cameras[0].gameObject.SetActive(false);
            cameras[1].gameObject.SetActive(true);
        }
        
    }


}
