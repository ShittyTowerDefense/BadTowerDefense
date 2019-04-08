using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 10f;

    private Transform target;
    private int wavepointIndex = 0;

    private void Start ()
    {
        target = Waypoints.points[0];
    }

    private void Update ()
    {
        Vector3 dir = target.position - transform.position;   //Vector is for the different axis
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);   //deltaTime is there to make the speed faster if the pc has a lower framerate          normalized is there that only the speed influences the speed of the enemy

        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWaypoint();
        }
    }


    void GetNextWaypoint()
{
     if (wavepointIndex >= Waypoints.points.Length - 1)
     {
        Destroy(gameObject);
        return;
     }
        wavepointIndex++;
        target = Waypoints.points[wavepointIndex];
     }
}
