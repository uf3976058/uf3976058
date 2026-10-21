using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0x1d80aee2;

public class _0xdfbf8824 : MonoBehaviour
{
    public List<_0x0a38586f> Pops;
    public void _0x313d9b4d()
    {
        this.LastPopIndexes.RemoveAll(_0x6eaade3d => _0x6eaade3d == this.CurrentPopIndex);
        if (this.LastPopIndexes.Count <= 0)
            this._0x3e0fd508();
        else
            this._0x8e2d9485(this.LastPopIndexes.Last());
    }

    public void _0x8e2d9485(int _0x2936e266)
    {
        this.CurrentPopIndex = _0x2936e266;
        this.LastPopIndexes.Add(this.CurrentPopIndex);
        this._0x6546d6d7(true);
        this._0x4c516860();
        this.Pops[_0x2936e266].Show();
        foreach (GameObject _0x825762ae in this.GameObjectsToHide)
            _0x825762ae.SetActive(false);
    }

    public float ScaleDuration = 0.4f;
    public List<int> LastPopIndexes = new();
    private void Start()
    {
        this.BackgroundHidden();
        foreach (_0x0a38586f _0x4e4018fb in this.Pops)
            if (_0x4e4018fb != null)
                _0x4e4018fb.gameObject.SetActive(true);
    }

    public _0x0a38586f _0x8b7bda89(int _0x2df7ade6)
    {
        return this.Pops[_0x2df7ade6];
    }

    public List<GameObject> GameObjectsToHide;
    private void _0x4c516860()
    {
        this.BlurBackground.gameObject.SetActive(true);
    }

    private void _0xcf41a450()
    {
        this.Invoke(nameof(this.BackgroundHidden), this.ScaleDuration);
    }

    public int CurrentPopIndex;
    private void _0x6546d6d7(bool _0x319874a1 = false)
    {
        for (int _0xd194a162 = 0; _0xd194a162 < this.Pops.Count; ++_0xd194a162)
            if (this.Pops[_0xd194a162] != null && !(_0xd194a162 == this.CurrentPopIndex && _0x319874a1))
                this.Pops[_0xd194a162]._0x51513397();
    }

    public void _0x3e0fd508()
    {
        this.LastPopIndexes.Clear();
        this._0x6546d6d7();
        foreach (GameObject _0x74875955 in this.GameObjectsToHide)
            if (_0x74875955 != null)
                _0x74875955.SetActive(true);
        this._0xcf41a450();
    }

    public static _0xdfbf8824 Instance;
    public GameObject BlurBackground;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xdfbf8824>();
    }

    private void BackgroundHidden()
    {
        this.BlurBackground.gameObject.SetActive(false);
    }
}