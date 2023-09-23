using UnityEngine;

public class RotationChanger : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Rotate(0, 1 * _speed, 0);
    }
}
