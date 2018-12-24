using UnityEngine;

public class MoveController : MonoBehaviour
{
    private Vector3 forward, right;

    private void Start()
    {
        forward = Camera.main.transform.forward;
        forward.y = 0;
        forward = Vector3.Normalize(forward);
        right = Quaternion.Euler(new Vector3(0, 90, 0)) * forward;
    }

    public void Move(Vector2 direction)
    {
        Vector3 rightMovement = right * direction.y * Time.deltaTime;
        Vector3 upMovement = forward * direction.x * Time.deltaTime;
        Vector3 heading = Vector3.Normalize(rightMovement + upMovement);

        transform.forward = heading;
        transform.position += rightMovement + upMovement;
    }
}
