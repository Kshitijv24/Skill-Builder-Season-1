// GameDev.tv ChallengeClub.Got questionsor wantto shareyour niftysolution?
// Head over to - http://community.gamedev.tv

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNewBlock : MonoBehaviour
{
    [SerializeField] GameObject blockPrefab;
    [SerializeField] Transform spawnPosition;

    Color[] colors = { Color.red, Color.yellow, Color.blue };

    private void Start()
    {
        blockPrefab.GetComponent<SpriteRenderer>().color = colors[Random.Range(0, colors.Length)];
    }

    public void SpawnBlock()
    {
        Instantiate(blockPrefab, spawnPosition.position, Quaternion.identity);
    }
}
