using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCollision : MonoBehaviour
{
    public float minDistance = 1.0f;
    public float maxDistance = 20f;
    public float smooth = 100.0f;
    Vector3 dollyDir;
    float distance;

    void Awake()
    {
        dollyDir = transform.localPosition.normalized;
        distance = transform.localPosition.magnitude;
    }
    void Update()
    {
        Vector3 desiredCameraPos = transform.parent.TransformPoint((dollyDir * GetComponentInParent<CameraController>().GetDistance()*3f));
        RaycastHit hit;
        if (Physics.Linecast(transform.parent.position, desiredCameraPos, out hit) && hit.transform.gameObject.tag != "Trigger")
        {
            distance = Mathf.Clamp(hit.distance, minDistance, maxDistance);
        }
        else
        {
            distance = GetComponentInParent<CameraController>().GetDistance() * 3f;
        }
        transform.localPosition = Vector3.Lerp(transform.localPosition, dollyDir * distance, Time.deltaTime * smooth);
    }
}