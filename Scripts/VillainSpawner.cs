using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillainSpawner : MonoBehaviour
{


    [SerializeField]
    private GameObject[] villainReference;

    private GameObject spawnedVillain;

    [SerializeField]
    private Transform leftpos, rightpos;

    private int randomIndex;
    private int randomSide;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnVillains());
    }

    IEnumerator SpawnVillains() {

        while (true) {

            yield return new WaitForSeconds(Random.Range(1, 5));

            randomIndex = Random.Range(0, villainReference.Length);
            randomSide = Random.Range(0, 2);

            spawnedVillain = Instantiate(villainReference[randomIndex]);

        //left side
            if (randomSide == 0)
            {

                spawnedVillain.transform.position = leftpos.position;
                spawnedVillain.GetComponent<Villains>().speed = Random.Range(4, 10);
            }
            else 
            {
            //right side

                spawnedVillain.transform.position = rightpos.position;
                spawnedVillain.GetComponent<Villains>().speed = -Random.Range(4, 10);
                spawnedVillain.transform.localScale = new Vector3(-1f, 1f, 1f);

            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
