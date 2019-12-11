using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float Speed;

    // Update is called once per frame
    private void Update()
    {
        transform.position += Time.deltaTime * Speed * Vector3.left;
    }
}