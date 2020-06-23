using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public Transform player;
    public GameObject theObstacle;
    public int NumberOfObstacles;
    public float HowFarOut;

    // Start is called before the first frame update
    void Start () {
        StartCoroutine(ObstacleSpawn());
    }
    // Update is called once per frame
    void Update()
    {
    }
    IEnumerator ObstacleSpawn()
    {
        float xPos;
        float zPos;
        int ObstacleCount = 0;
        while (ObstacleCount <NumberOfObstacles)
        {
            xPos = Random.Range(-7, 7);
            zPos = Random.Range(player.position.y+20, player.position.y+20+HowFarOut);
            Instantiate(theObstacle, new Vector3(xPos, 2, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.001f);
            ObstacleCount += 1;
        }
    }
}
