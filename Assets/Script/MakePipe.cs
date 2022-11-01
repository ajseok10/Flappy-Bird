using UnityEngine;

public class MakePipe : MonoBehaviour
{

    public GameObject pipe;

    public float spawnPositionX;
    public float minPositionY;
    public float maxPositionY;

    public float timeDiff;

    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > timeDiff)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = new Vector3(spawnPositionX, Random.Range(minPositionY, maxPositionY), 0);
            timer = 0;
            Destroy(newpipe, 10.0f);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(new Vector3(spawnPositionX, minPositionY, 0f),new Vector3(spawnPositionX, maxPositionY, 0));
    }
}
