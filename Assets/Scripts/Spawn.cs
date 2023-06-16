using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject spawnable;

    public float spawnTime;
    private float _timeCount;

    private void Update()
    {
        _timeCount += Time.deltaTime;

        if (!(_timeCount >= spawnTime)) return;

        var t = transform;
        
        var go = Instantiate(spawnable, t.position, t.rotation);
        
        Destroy(go, 5f);
        _timeCount = 0f;
    }
}
