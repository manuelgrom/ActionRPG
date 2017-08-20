using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{
    public LayerMask movementMask;

    private Camera _cam = null;
    private PlayerMotor _motor = null;

    // Use this for initialization
    void Start()
    {
        _cam = Camera.main;
        _motor = GetComponent<PlayerMotor>();
    }

    // Update is called once per frame
    void Update()
    {
        #region ClickMovement
        //left mouse button
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = _cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100.0f, movementMask))
            {
                _motor.MoveToPoint(hit.point);
                //Debug.Log("we hit " + hit.collider.name + " " + hit.point);
                //move the player where we hit

                //stop focusing any objects
            }
        }
        #endregion ClickMovement

        #region ObjectInteraction

        //right mouse button
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = _cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100.0f, movementMask))
            {
                // check if we hit an interactable
            }
        }
        #endregion ObjectInteraction
    }
}
