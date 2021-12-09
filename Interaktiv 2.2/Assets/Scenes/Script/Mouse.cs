using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    public Vector2 turn;
    public float sensitivity = .5f;
    private Transform parent;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        parent = transform.parent;
    }

    // Update is called once per frame
    void Update()
    {
        turn.x += Input.GetAxisRaw("Mouse X") * sensitivity;
        turn.y -= Input.GetAxisRaw("Mouse Y") * sensitivity;
        transform.localEulerAngles = new Vector3(turn.y, 0, 0);
        parent.eulerAngles = new Vector3(0, turn.x, 0);
    }
}
