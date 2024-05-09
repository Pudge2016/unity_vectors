using UnityEngine;

public class Follow : MonoBehaviour
{
    public GameObject goal;

    [Range(0f, 5f)]
    public float speed = 0.05f;
 
    private Vector3 direction;
    private Vector3 velocity;

    private void LateUpdate()
    {
        direction = goal.transform.position - transform.position;
        velocity = direction.normalized * speed * Time.deltaTime;

        if (direction.magnitude > 2)
        {
            transform.LookAt(goal.transform.position);
            transform.position = transform.position + velocity;
        }
    }
}
