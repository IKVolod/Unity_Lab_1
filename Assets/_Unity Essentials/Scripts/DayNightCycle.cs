using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("Duration of a full day in seconds")]
    public float dayDurationInSeconds = 60f;

    void Update()
    {
        // Calculate the rotation for this frame
        float rotationSpeed = 360f / dayDurationInSeconds; // degrees per second
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
    }
}