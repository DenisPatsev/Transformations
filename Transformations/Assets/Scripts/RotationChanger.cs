using UnityEngine;

public class RotationChanger : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _xRotation;
    [SerializeField] private float _yRotation;
    [SerializeField] private float _zRotation;

    private void Update()
    {
        transform.Rotate(_xRotation * _speed, _yRotation * _speed, _zRotation * _speed);
    }
}
