using UnityEngine;

public class Xandele : MonoBehaviour
{
    public float Speed = 3f;

    private Rigidbody2D Rigidbody { get; set; }

    // Start is called before the first frame update
    private void Start()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        var click = Input.GetMouseButtonDown(0);
        if (click)
        {
            Rigidbody.velocity = Speed * new Vector2(0.2f,1);
        }
    }
}