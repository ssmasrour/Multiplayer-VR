using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class AvatarRandomizer : MonoBehaviour
{
    [SerializeField] List<GameObject> _Heads;
    public GameObject Head { get; private set; }

    void Awake()
    {
        int rndIndex = Random.Range(0, _Heads.Count - 1);

        _Heads.ForEach(a => a.SetActive(false));
        Head = _Heads[rndIndex];
        Head.SetActive(true);
    }

    public void SetLayer(LayerMask new_layer)
    {
        Head.layer = new_layer;
        foreach (Transform item in Head.transform)
        {
            item.gameObject.layer = new_layer;
        }
    }
}
