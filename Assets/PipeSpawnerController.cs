using UnityEngine;

public class PipeSpawnerController : MonoBehaviour
{
    public float height;
    public float maxTime = 2f;
    public GameObject pipe;
    private float timer = 12;

    private void Start()
    {
        var newPipe = CreatePipe();
    }

    private GameObject CreatePipe()
    {
        var newPipe = Instantiate(pipe);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
        return newPipe;
    }

    private void Update()
    {
        if (timer > maxTime)
        {
            var newPipe = CreatePipe();
            Destroy(newPipe, 40f);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}