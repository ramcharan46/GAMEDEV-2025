using UnityEngine;

public class LaserSpawn : MonoBehaviour
{
    public GameObject Laser;
    public Transform spawnposition;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(Laser, spawnposition.position, spawnposition.rotation);
            Debug.Log("Spawn");
        }
    }
}
