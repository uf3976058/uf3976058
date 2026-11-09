using UnityEngine;

/// One local objective. Plain data, built with new Mission().Init(...) - no constructor (C.59).
public sealed class _0xaf17bb5a
{
    public int Id;
    public string Unit;
    public int Kind;
    public int EstimatedSpins;
    public int Target;
    public _0xaf17bb5a _0x88d81158(int _0x737786e9, int _0x97ee3f97, int _0xbc3aeb6e, int _0x5d7c62a2, int _0x77be2bbe, string _0xc27d7202, string _0x817d7556)
    {
        this.Id = _0x737786e9;
        this.Kind = _0x97ee3f97;
        this.Target = _0xbc3aeb6e;
        this.Reward = _0x5d7c62a2;
        this.EstimatedSpins = _0x77be2bbe;
        this.Title = _0xc27d7202;
        this.Unit = _0x817d7556;
        return this;
    }

    public string Title;
    public int Reward;
}