using UnityEngine;

public class Waypoints : MonoBehaviour
{
    public static Transform[] points;          //static accessible from anywhere        Transform if you want a list of game objects
    void Awake()
    {
        points = new Transform[transform.childCount];
        for (int i = 0;i < points.Length; i++)
        {
            points[i] = transform.GetChild(i);
        }
    }
}
