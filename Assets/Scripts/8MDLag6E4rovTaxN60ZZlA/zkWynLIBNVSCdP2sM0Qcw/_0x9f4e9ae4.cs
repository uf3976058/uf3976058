using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class _0x9f4e9ae4 : MonoBehaviour
{
    private bool _0x92a41df3(Touch? _0x2b577668)
    {
        if (!_0x2b577668.HasValue)
            return false;
        Vector3 _0xa032cd69 = Camera.main.ScreenToWorldPoint(_0x2b577668.Value.screenPosition);
        Vector3 _0x949e2799 = _0xa032cd69;
        _0x949e2799.z = this.CameraTouchBounds.transform.position.z;
        if (this.CameraTouchBounds.bounds.Contains(_0x949e2799))
            return true;
        _0x2b577668 = null;
        return false;
    }

    private Touch? _0x668fdfa0()
    {
        if (!_0xf44d047f.Instance._0x892b5715)
            return null;
        foreach (Touch _0x547a7f0d in Touch.activeTouches)
            if (!_0x547a7f0d.ended)
                if (this._0x92a41df3(_0x547a7f0d))
                    return _0x547a7f0d;
        return null;
    }

    private Touch? _0xbf8d8c01()
    {
        if (!_0xf44d047f.Instance._0x892b5715)
            return null;
        foreach (Touch _0x52a93ab5 in Touch.activeTouches)
            if (_0x52a93ab5.ended)
                if (this._0x92a41df3(_0x52a93ab5))
                    return _0x52a93ab5;
        return null;
    }

    private void _0xa7e140d8(Touch? _0x3403b23f)
    {
        if (!_0xf44d047f.Instance._0x892b5715)
        {
            _0x3403b23f = null;
            return;
        }

        int _0x2ec2cb83 = _0x3403b23f.Value.touchId;
        _0x3403b23f = Touch.activeTouches.FirstOrDefault(_0x108194ef => _0x108194ef.touchId == _0x2ec2cb83);
        if (!this._0x92a41df3(_0x3403b23f.Value))
            _0x3403b23f = null;
    }

    private Touch? _0x2c04152d(Bounds _0x7c833658)
    {
        if (!_0xf44d047f.Instance._0x892b5715)
            return null;
        foreach (Touch _0x76c45cd4 in Touch.activeTouches)
            if (!_0x76c45cd4.ended)
            {
                Vector3 _0x0b56172c = Camera.main.ScreenToWorldPoint(_0x76c45cd4.screenPosition);
                Vector3 _0xb1dae76f = new(_0x0b56172c.x, _0x0b56172c.y, _0x7c833658.center.z);
                if (_0x7c833658.Contains(_0xb1dae76f) && this._0x92a41df3(_0x76c45cd4))
                    return _0x76c45cd4;
            }

        return null;
    }

    private Touch? _0x03c49b0e(Bounds _0x304e8794, TouchPhase _0x9fc4c854)
    {
        if (!_0xf44d047f.Instance._0x892b5715)
            return null;
        foreach (Touch _0x0036fa65 in Touch.activeTouches)
            if (_0x0036fa65.phase == _0x9fc4c854)
            {
                Vector3 _0x3c3dc5d9 = Camera.main.ScreenToWorldPoint(_0x0036fa65.screenPosition);
                Vector3 _0x85522c38 = new(_0x3c3dc5d9.x, _0x3c3dc5d9.y, _0x304e8794.center.z);
                if (_0x304e8794.Contains(_0x85522c38) && this._0x92a41df3(_0x0036fa65))
                    return _0x0036fa65;
            }

        return null;
    }

    private bool _0x403af24b(Touch? _0xadcefc00, Bounds _0x76efa579, TouchPhase _0x461b2459)
    {
        if (!_0xf44d047f.Instance._0x892b5715)
        {
            _0xadcefc00 = null;
            return false;
        }

        if (_0xadcefc00 != null)
            if (_0xadcefc00.Value.phase == _0x461b2459)
            {
                Vector3 _0xa7af2df7 = Camera.main.ScreenToWorldPoint(_0xadcefc00.Value.screenPosition);
                Vector3 _0x136c5f68 = new(_0xa7af2df7.x, _0xa7af2df7.y, _0x76efa579.center.z);
                if (_0x76efa579.Contains(_0x136c5f68) && this._0x92a41df3(_0xadcefc00.Value))
                    return true;
            }

        return false;
    }

    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        _0x2f5b8e56 = this.gameObject.GetComponent<_0x9f4e9ae4>();
    }

    public BoxCollider2D CameraTouchBounds;
    private static _0x9f4e9ae4 _0x2f5b8e56;
    private Touch? _0x3fae7131(Bounds _0x72d21482)
    {
        if (!_0xf44d047f.Instance._0x892b5715)
            return null;
        foreach (Touch _0x4936e42e in Touch.activeTouches)
            if (_0x4936e42e.ended)
            {
                Vector3 _0xbc50eebe = Camera.main.ScreenToWorldPoint(_0x4936e42e.screenPosition);
                Vector3 _0x75eaa27c = new(_0xbc50eebe.x, _0xbc50eebe.y, _0x72d21482.center.z);
                if (_0x72d21482.Contains(_0x75eaa27c) && this._0x92a41df3(_0x4936e42e))
                    return _0x4936e42e;
            }

        return null;
    }
}