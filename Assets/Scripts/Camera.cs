using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using System.Linq;

public class Camera : MonoBehaviour
{
    public GameObject[] focusTargets = new GameObject[] { };
    public void ChangeFocus() {
        var activeVc = GetComponent<CinemachineBrain>().ActiveVirtualCamera;
        var currentFocus = activeVc.Follow;
        var currentFocusIndex = focusTargets.ToList().IndexOf(currentFocus.gameObject);
        var nextFocusIndex = currentFocusIndex >= focusTargets.Length - 1
            ? 0
            : currentFocusIndex + 1;
        activeVc.Follow = focusTargets[nextFocusIndex].transform;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
