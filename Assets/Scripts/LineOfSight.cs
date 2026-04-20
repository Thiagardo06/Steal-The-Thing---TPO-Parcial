using UnityEngine;

public class LineOfSight : MonoBehaviour
{
    [SerializeField] private float distance = 10f;
    [SerializeField] private float angle = 60f;
    [SerializeField] private LayerMask layerMask;

    public bool IsInRange(Transform self, Transform target)
    {
        return Vector3.Distance(self.position, target.position) <= distance;
    }

    public bool IsInAngle(Transform self, Transform target)
    {
        Vector3 dir = (target.position - self.position).normalized;
        return Vector3.Angle(self.forward, dir) <= angle / 2f;
    }

    public bool HasLineOfSight(Transform self, Transform target)
    {
        Vector3 dir = target.position - self.position;
        return !Physics.Raycast(self.position, dir, dir.magnitude, layerMask);
    }
}