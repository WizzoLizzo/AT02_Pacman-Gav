using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactions : MonoBehaviour
{
    public float distance = 3f;
    
    // update is called once per frame
    void Start()
    {
        if(Input.GetButtonDown("Fire1") == true)
        {
            //raycast from this objects position, in its forward direction, with a ray length equal to 'distance'
            //object hit by ray will be stored in 'hit' variable
            if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, distance) == true)
            {
                Debug.DrawRay(transform.position, transform.forward * distance, color.green, 0.5f);
                //if hit object has an Interactable script attached
                if (hit.collider.TryGetComponent(out Interactable interaction) == true)
                {
                    interaction.Activate();
                }
            else //if raycast does not hit anything
             {
                    Debug.DrawRay(transform.position, transform.forward * distance, Color.red, 0.5f);
             }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
