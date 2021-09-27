using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] collectables;
    [SerializeField] private int index;
    [SerializeField] private float delay;
    [SerializeField] private float timer;

    private void Update()
    {
        if (timer >= delay)
        {
            timer = 0;
            Spawn();
        }
        else timer += Time.deltaTime;
    }

    private void Spawn()
    {
        // random position within this transform
        Vector3 randomPosition;
        randomPosition = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        randomPosition = transform.TransformPoint(randomPosition * .5f);

        // spawn the collectable
        GameObject collectable = Instantiate(collectables[Random.Range(0, 2)], randomPosition, Quaternion.identity);
        collectable.transform.SetParent(GameObject.Find("Spawner").transform);
    }
}
