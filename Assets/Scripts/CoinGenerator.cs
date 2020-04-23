using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject CoinPrefab;
    float speed = 5f;

    private void Start()
    {
        GenerateCoinPattern();
    }
    public void Update()
    {
        transform.Translate(new Vector3(0, 1, 0) * speed * Time.deltaTime);
    }
    private void GenerateCoinPattern()
    {
        int noOfCoins = Random.Range(3,8);
        float yPos = 0f;
        for (int i = 0; i < noOfCoins; i++) 
        {
            Transform coin = Instantiate(CoinPrefab).transform;
            coin.parent = this.transform;
            coin.localPosition = new Vector2(0f, yPos);
            yPos += 0.5f;
        }
      
    }
}
