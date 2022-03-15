using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    private List<GameObject> activeTiles;
    public GameObject[] tilePrefabs;

    private float yvalue;
    private float xvalue;
    private float zvalue;

    public Transform playerTransform;

    private int previousIndex;

    void Start()
    {
        // Instantiate(tilePrefabs[0], new Vector3(0.02f, 0.18f, 4.5f), Quaternion.identity);
        xvalue = 0.02f;
        yvalue = 0.18f;
        zvalue = 7f;
        
    }
    void Update()
    {
        StartCoroutine(SpawnTile());

    }
    IEnumerator SpawnTile()
    {
        yield return new WaitForSeconds(4);
        Instantiate(tilePrefabs[Random.Range(0,2)], new Vector3(xvalue, yvalue, zvalue), Quaternion.identity);
        zvalue += Random.Range(7f, 7.1f);
        xvalue += Random.Range(-0.5f, 0.5f);
        //yvalue += Random.Range(7f, 7.1f);
    }



}
