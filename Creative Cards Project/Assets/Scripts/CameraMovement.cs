using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal")* -1 * Time.deltaTime, 0f, Input.GetAxis("Vertical") *-1 * Time.deltaTime);
    }

}
