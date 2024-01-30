using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{

    private Coroutine _enemySpawnRoutine;
    [SerializeField] GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        _enemySpawnRoutine = StartCoroutine(MyCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator MyCoroutine()
    {

        while (true)
        {
            
            Instantiate(enemy, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(5);

        }
    }
}
