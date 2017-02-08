using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RayCast();
        }
    }

    void RayCast()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            var character = hit.collider.gameObject.GetComponent<character>();
            if (character == null)
            {
                return;

            }
            character.StartConversation();
        }
    }
}

//prefab化する理由は？