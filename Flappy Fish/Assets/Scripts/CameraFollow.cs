using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
    // playerObject
    public Transform target;

    void Update()
    {
        // following player
        transform.position = new Vector2(target.position.x, transform.position.y);
    }
}
