using UnityEngine;

public class SpawnBananas : MonoBehaviour
{
    public Transform whereToSpawn;
    public GameObject prefabToSpawn;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject spawned = Instantiate(prefabToSpawn, transform.position, Quaternion.identity) as GameObject;
    }
}
